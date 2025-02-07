using System.Xml;

namespace LibraryShared
{
    public class Common
    {
        /// <summary>
        /// normal exit
        /// </summary>
        public const int NORMAL_EXIT = 0;

        /// <summary>
        /// read a newline
        /// </summary>
        public const int READ_NEWLINE = 1;

        /// <summary>
        /// static constructor
        /// </summary>
        static Common()
        {
            HttpClient = new HttpClient();
        }

        /// <summary>
        /// shared HTTP client (not using HttpClientFactory right now)
        /// </summary>
        public static HttpClient HttpClient { get; set; }

        /// <summary>
        /// writes an XML document to file
        /// </summary>
        /// <param name="doc">XML document</param>
        /// <param name="path">target file path</param>
        public static void WriteToFile(XmlDocument doc, string path)
        {
            using (XmlWriter xw = GetXmlWriterToFile(path))
            {
                doc.WriteTo(xw);
            }
        }

        /// <summary>
        /// gets an XML writer that writes to file
        /// </summary>
        /// <param name="path">file path</param>
        /// <returns>XML writer</returns>
        private static XmlWriter GetXmlWriterToFile(string path)
        {
            return XmlWriter.Create(path, GetXmlWriterSettings());
        }

        /// <summary>
        /// retrieves shared XML writer settings
        /// </summary>
        /// <returns></returns>
        private static XmlWriterSettings GetXmlWriterSettings()
        {
            XmlWriterSettings s = new XmlWriterSettings();
            s.Indent = true;
            s.IndentChars = " ";
            return s;
        }
    }
}
