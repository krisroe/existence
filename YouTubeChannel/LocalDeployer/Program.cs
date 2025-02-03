using Renci.SshNet;
using System.Text;
namespace LocalDeployer
{
    internal class Program
    {
        static int Main(string[] args)
        {
            bool local = true;
            int requiredArgsCount = 2;
            if (args == null || args.Length < requiredArgsCount)
            {
                Console.Error.WriteLine(requiredArgsCount + " arguments are required.");
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
            string sTargetFolder = args[1];
            if (string.IsNullOrEmpty(sTargetFolder))
            {
                Console.Error.WriteLine("No target folder specified.");
                return -1;
            }
            if (!Directory.Exists(sTargetFolder))
            {
                Console.Error.WriteLine("Target folder does not exist.");
                return -1;
            }

            int port = local ? 5432 : 24866;

            SftpClient? sftpClient = null;
            string sServer;
            string sProtocol;
            if (local)
            {
                sProtocol = "http";
                sServer = "localhost";
            }
            else
            {
                sProtocol = "https";
                sServer = "destroyallpugz.site";
                PrivateKeyFile pkf = new PrivateKeyFile(@"C:\music\Technical\id_rsa");
                PrivateKeyAuthenticationMethod pkam = new PrivateKeyAuthenticationMethod("ubuntu", pkf);
                ConnectionInfo ci = new ConnectionInfo("destroyallpugz.site", 22, "ubuntu", pkam);
                sftpClient = new SftpClient(ci);
                sftpClient.Connect();
                sftpClient.ChangeDirectory("/var/www/destroyallpugs");
            }

            string sOAuthClientIDReplacement = "{oauthclientid}";
            string sOAuthClientSecretReplacement = "{oauthclientsecret}";
            string sOAuthClientID = "CSRTODO";
            string sOAuthClientSecret = "CSRTODO";
            string sGoogleCloudApiKey = "CSRTODO";

            DirectoryInfo diTarget = new DirectoryInfo(sTargetFolder);
            DirectoryInfo di = new DirectoryInfo(sSourceFolder);
            foreach (FileInfo fi in di.GetFiles("*", SearchOption.TopDirectoryOnly))
            {
                string sContent = File.ReadAllText(fi.FullName);
                sContent = sContent.Replace("{protocol}", sProtocol);
                sContent = sContent.Replace("{pgconnstr}", "host=localhost port=" + port + " dbname=DestroyAllPugs user=postgres password=ToiletDrawHind939");
                sContent = sContent.Replace("{server}", sServer);
                sContent = sContent.Replace("{stylefilename}", "stylesv2.css");
                sContent = sContent.Replace(sOAuthClientIDReplacement, sOAuthClientID);
                sContent = sContent.Replace(sOAuthClientSecretReplacement, sOAuthClientSecret);

                //used for google drive and youtube APIs
                sContent = sContent.Replace("{googlecloudapikey}", sGoogleCloudApiKey);

                if (local)
                {
                    File.WriteAllText(Path.Combine(diTarget.FullName, fi.Name), sContent);
                }
                else //remove
                {
                    using (MemoryStream ms = new MemoryStream())
                    using (StreamWriter sw = new StreamWriter(ms, Encoding.UTF8))
                    {
                        sw.Write(sContent);
                        sw.Flush();
                        ms.Position = 0;
                        sftpClient.UploadFile(ms, fi.Name);
                    }
                }
            }

            return 0;
        }
    }
}
