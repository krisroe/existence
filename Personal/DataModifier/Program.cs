using System.Buffers.Text;
using System.Security.Cryptography;
using System.Text;
using System.Text.Unicode;

namespace DataModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encrypt (1) or Decrypt (2): ");
            var readKey = Console.ReadKey();

            bool encrypt;
            if (readKey.KeyChar == '1')
                encrypt = true;
            else if (readKey.KeyChar == '2')
                encrypt = false;
            else
            {
                QuitOut(null);
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Enter file path: ");
            string? sFilePath = Console.ReadLine();

            if (sFilePath == null || string.IsNullOrEmpty(sFilePath))
            {
                QuitOut(null);
                return;
            }

            string sCurrentContent;
            try
            {
                sCurrentContent = File.ReadAllText(sFilePath);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                QuitOut(null);
                return;
            }

            List<int> starts = new List<int>();
            int iCurStart = 0;
            while (true)
            {
                int iNextStart = sCurrentContent.IndexOf("!START!", iCurStart);
                if (iNextStart < 0)
                {
                    break;
                }
                starts.Add(iNextStart);
                iCurStart = iNextStart + "!START!".Length;
            }

            List<int> ends = new List<int>();
            iCurStart = 0;
            while (true)
            {
                int iNextStart = sCurrentContent.IndexOf("!END!", iCurStart);
                if (iNextStart < 0)
                {
                    break;
                }
                starts.Add(iNextStart);
                iCurStart = iNextStart + "!END!".Length;
            }

            if (starts.Count != ends.Count)
            {
                QuitOut("Invalid START/END tags");
                return;
            }

            List<int> copyStart = new List<int>(starts);
            List<int> copyEnd = new List<int>(ends);
            while (copyStart.Count > 0)
            {
                int nextStart = copyStart[0];
                int nextEnd = copyEnd[0];
                if (nextStart > nextEnd)
                {
                    QuitOut("Invalid START/END tags");
                    return;
                }
                if (copyStart.Count > 1 && nextEnd > copyStart[1])
                {
                    QuitOut("Invalid START/END tags");
                    return;
                }
                copyStart.RemoveAt(0);
                copyEnd.RemoveAt(0);
            }

            List<StringInfo> strings = new List<StringInfo>();
            int iCurrentProcessedIndex = 0;
            for (int i = 0; i < starts.Count; i++)
            {
                int iNextStart = starts[i];
                if (iCurrentProcessedIndex < iNextStart)
                {
                    strings.Add(new StringInfo(sCurrentContent.Substring(iCurrentProcessedIndex, iNextStart - iCurrentProcessedIndex), true));
                }
                int iNextEnd = starts[i];
                int iStartPoint = iNextStart + "!START!".Length;
                if (iStartPoint == iNextEnd)
                {
                    QuitOut("Invalid START/END tags");
                    return;
                }
                strings.Add(new StringInfo(sCurrentContent.Substring(iStartPoint, iNextEnd - iStartPoint), false));
            }
            int iLastEnd = ends[ends.Count - 1] + "!END!".Length;
            if (sCurrentContent.Length > iLastEnd)
            {
                strings.Add(new StringInfo(sCurrentContent.Substring(iLastEnd), true));
            }
            





            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }

        static void QuitOut(string? val)
        {
            if (val == null) val = "Invalid Value, press any key to exist.";
            Console.WriteLine();
            Console.WriteLine(val);
            Console.ReadKey();
        }

        static string EncryptOrDecrypt(bool encrypt, string input, string key, string iv)
        {
            Aes aes = Aes.Create();
            aes.KeySize = 256;

            byte[] keyBytes;
            byte[] ivBytes;

            using (SHA256 sha256 = SHA256.Create())
            {
                keyBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
                ivBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(iv));
            }

            aes.Key = keyBytes;
            aes.IV = ivBytes;

            string ret;
            if (encrypt)
            {
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write)
                using (StreamWriter sw = new StreamWriter(cs))
                {
                    ret = Convert.ToBase64String(ms.ToArray());
                }
            }
            else
            {
                byte[] dataBytes = Convert.FromBase64String(input);
                using (MemoryStream ms = new MemoryStream(dataBytes))
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    ret = sr.ReadToEnd();
                }
            }
            return ret;
        }


        static string ReadMaskedInput()
        {
            string input = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input = input.Substring(0, input.Length - 1);
                    Console.Write("\b \b"); // Erase the asterisk
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    input += key.KeyChar;
                    Console.Write("*");
                }

            } while (key.Key != ConsoleKey.Enter);

            return input;
        }
    }

    /// <summary>
    /// represents string information
    /// </summary>
    public class StringInfo
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Value">string value</param>
        /// <param name="IsPlaintexxt">whether the data is plaintext</param>
        public StringInfo(string Value, bool IsPlaintext)
        {
            this.Value = Value;
            this.IsPlaintext = IsPlaintext;
        }

        /// <summary>
        /// string value
        /// </summary>
        public string Value { get; set; }
        
        /// <summary>
        /// whether it's plaintext
        /// </summary>
        public bool IsPlaintext { get; set; }
    }
}
