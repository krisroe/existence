using HtmlAgilityPack;
using System.Globalization;
using System.Xml;
using CsvHelper;
using CsvHelper.Configuration;

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

        /// <summary>
        /// processes all game scores from local CSV
        /// </summary>
        /// <param name="filePath">file path</param>
        /// <returns>game info objects</returns>
        public static IEnumerable<T> ProcessCSV<T,U>(string filePath) where U : ClassMap
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<U>();
                foreach (T gi in csv.GetRecords<T>())
                {
                    yield return gi;
                }
            }
        }

        /// <summary>
        /// retrieves an HTML document for a URL
        /// </summary>
        /// <param name="URL">URL</param>
        /// <returns>HTML document</returns>
        public static HtmlDocument GetHtmlDocumentFromURL(string URL)
        {
            HtmlDocument mainDoc = new HtmlDocument();
            HttpResponseMessage hrm = HttpClient.GetAsync(URL).Result;
            if (hrm.IsSuccessStatusCode)
            {
                string sContent = hrm.Content.ReadAsStringAsync().Result;
                mainDoc.LoadHtml(sContent);
                return mainDoc;
            }
            else if (hrm.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
            {
                int retryAfter = -1;
                foreach (var nextHeader in hrm.Headers)
                {
                    if (nextHeader.Key == "Retry-After")
                    {
                        retryAfter = nextHeader.Key.First();
                    }
                }
                if (retryAfter != -1)
                {
                    throw new Exception("429 (Too Many Requests) Error. Try again after " + retryAfter + " seconds");
                }

            }
            throw new Exception("HTTP request to " + URL + " failed with " + Convert.ToInt32(hrm.StatusCode) + " (" + hrm.StatusCode.ToString() + ") error");
        }
    }
}
