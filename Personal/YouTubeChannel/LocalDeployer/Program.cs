using Renci.SshNet;
using System.Security.Cryptography;
using System.Text;
namespace LocalDeployer
{
    internal class Program
    {
        /// <summary>
        /// runs a local or server deploy
        /// </summary>
        /// <param name="args">command line arguments</param>
        /// <returns>process return code</returns>
        /// <remarks>
        /// Command line arguments:
        ///  1. Source folder
        ///  2. local or remote
        ///  3 (local). Destination folder (e.g. C:\DestroyAllPugsWebsite). For remote it's uploaded to var/www/destroyallpugs.
        ///  3 (remote). Path to the private key file (e.g. id_rsa)
        /// </remarks>
        /// <remarks>
        /// String replacements:
        ///  stylefilename: stylesv2.css
        ///  server: localhost or destroyallpugz.site
        ///  protocol: http (local) or https (remote)
        ///  pgconnport: postgres port
        /// </remarks>
        static int Main(string[] args)
        {
            int requiredArgsCount = 2;
            if (args == null || args.Length < requiredArgsCount)
            {
                Console.Error.WriteLine($"{requiredArgsCount} arguments are required.");
                return -1;
            }
            string sSourceFolder = args[0];
            if (string.IsNullOrEmpty(sSourceFolder))
            {
                Console.Error.WriteLine("No source folder specified.");
                return -1;
            }
            if (!Directory.Exists(sSourceFolder))
            {
                Console.Error.WriteLine("Source folder does not exist.");
                return -1;
            }
            bool local;
            string sLocalOrRemote = args[1];
            if (sLocalOrRemote == "local")
            {
                local = true;
            }
            else if (sLocalOrRemote == "remote")
            {
                local = false;
            }
            else
            {
                Console.Error.WriteLine($"Invalid argument #3 (local or remote): {sLocalOrRemote}");
                return -1;
            }
            string? argument3 = args[2];
            string? targetFolder = null;
            string? privateKeyFile = null;
            if (string.IsNullOrEmpty(argument3))
            {
                Console.Error.WriteLine("No third argument specified.");
                return -1;
            }
            if (local)
            {
                targetFolder = argument3;
                if (!Directory.Exists(targetFolder))
                {
                    Console.Error.WriteLine("Target folder does not exist.");
                    return -1;
                }
            }
            else
            {
                privateKeyFile = argument3;
                if (!File.Exists(privateKeyFile))
                {
                    Console.Error.WriteLine("Private key file does not exist.");
                    return -1;
                }
            }

            int port = local ? 5432 : 24866;

            SftpClient? sftpClient = null;
            string server;
            string protocol;
            string user;
            if (local)
            {
                protocol = "http";
                server = "localhost";
                user = "postgres";
            }
            else
            {
                protocol = "https";
                server = "destroyallpugz.site";
                user = "destroyallpugs_web";
                PrivateKeyFile pkf = new PrivateKeyFile(privateKeyFile!);
                PrivateKeyAuthenticationMethod pkam = new PrivateKeyAuthenticationMethod("ubuntu", pkf);
                ConnectionInfo ci = new ConnectionInfo("destroyallpugz.site", 22, "ubuntu", pkam);
                sftpClient = new SftpClient(ci);
                sftpClient.Connect();
                sftpClient.ChangeDirectory("/var/www/destroyallpugs");
            }

            int exitCode = 0;

            DirectoryInfo di = new DirectoryInfo(sSourceFolder);
            foreach (FileInfo fi in di.GetFiles("*", SearchOption.TopDirectoryOnly))
            {
                string sContent = File.ReadAllText(fi.FullName);
                sContent = sContent.Replace("{protocol}", protocol);
                sContent = sContent.Replace("{pgconnport}", port.ToString());
                sContent = sContent.Replace("{pgconnuser}", user);
                sContent = sContent.Replace("{server}", server);
                sContent = sContent.Replace("{stylefilename}", "stylesv2.css");

                string sourceFullPath = fi.FullName;
                string fileName = fi.Name;
                if (local)
                {
                    DirectoryInfo diTarget = new DirectoryInfo(targetFolder!);
                    string path = Path.Combine(diTarget.FullName, fileName);
                    File.WriteAllText(path, sContent);

                    if (File.ReadAllText(path) != sContent)
                    {
                        Console.Error.WriteLine($"Uploaded file does not match for {fileName}");
                        exitCode = -1;
                    }
                    else if (string.IsNullOrEmpty(sContent))
                    {
                        Console.Error.WriteLine($"Uploaded file is blank for {fileName}");
                        exitCode = -1;
                    }
                }
                else //remote
                {
                    long uploadFileLength;
                    byte[] localHash, remoteHash;
                    using (SHA256 sha = SHA256.Create())
                    {
                        using (MemoryStream ms = new MemoryStream())
                        using (StreamWriter sw = new StreamWriter(ms, Encoding.UTF8))
                        {
                            sw.Write(sContent);
                            sw.Flush();
                            uploadFileLength = ms.Length;
                            ms.Position = 0;
                            localHash = sha.ComputeHash(ms);
                            ms.Position = 0;
                            sftpClient!.UploadFile(ms, fi.Name, true);
                        }

                        var attributes = sftpClient.GetAttributes(fileName);
                        if (attributes.IsRegularFile)
                        {
                            if (attributes.Size != uploadFileLength)
                            {
                                Console.Error.WriteLine($"Failed to upload: {fileName}, resultant size does not match");
                                exitCode = -1;
                            }
                        }
                        else
                        {
                            Console.Error.WriteLine($"Failed to upload: {fileName}, not a regular file");
                            exitCode = -1;
                        }

                        using (MemoryStream remoteStream = new MemoryStream())
                        {
                            sftpClient.DownloadFile(fileName, remoteStream);
                            remoteStream.Position = 0;
                            remoteHash = sha.ComputeHash(remoteStream);
                        }

                        if (!localHash.SequenceEqual(remoteHash))
                        {
                            Console.Error.WriteLine($"Failed to upload: {fileName}, SHA-256 hash does not match");
                            exitCode = -1;
                        }
                    }
                }
            }

            Console.Out.WriteLine(exitCode == 0 ? "Upload complete." : "Upload failed.");
            return exitCode;
        }
    }
}
