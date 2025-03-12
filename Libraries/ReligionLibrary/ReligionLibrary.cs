using CsvHelper;
using HtmlAgilityPack;
using LibraryShared;
using System.Globalization;

namespace ReligionLibrary
{
    public static class ReligionLibrary
    {
        public static int RunMain(string[] args)
        {
            SavePopes(args[0]);
            return 0;
        }

        /// <summary>
        /// retrieves the relevant table for an HTML document
        /// </summary>
        /// <param name="mainDoc">main document</param>
        /// <returns>table element</returns>
        private static HtmlNode GetPopeTable(HtmlDocument mainDoc)
        {
            HtmlNode? foundTable = null;
            foreach (HtmlNode node in mainDoc.DocumentNode.SelectNodes("//table"))
            {
                if (node.Id == "holy-father")
                {
                    foundTable = node;
                    break;
                }
            }
            if (foundTable == null) throw new InvalidOperationException();
            return foundTable!;
        }

        /// <summary>
        /// loads popes from https://www.vatican.va/content/vatican/LANGUAGE/holy-father.html
        /// </summary>
        /// <param name="directory">directory to save the popes to</param>
        public static void SavePopes(string directory)
        {
            string[] languages = ["ar", "de", "en", "es", "fr", "it", "pt"];
            for (int i = 0; i < languages.Length; i++)
            {
                if (i > 0) //wait a bit to avoid being throttled
                {
                    Thread.Sleep(5000);   
                }
                string lang = languages[i];
                using (StreamWriter sw = new StreamWriter(Path.Combine(directory, "popes." + lang + ".csv")))
                using (CsvWriter csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
                {
                    string url = $@"https://www.vatican.va/content/vatican/{lang}/holy-father.html";
                    HtmlDocument mainDoc = Common.GetHtmlDocumentFromURL(url);
                    HtmlNode foundTable = GetPopeTable(mainDoc);
                    int iRowIndex = 0;
                    List<string> headers = new List<string>();
                    foreach (HtmlNode nextRow in foundTable.SelectNodes("//tr"))
                    {
                        iRowIndex++;
                        if (iRowIndex > 1)
                        {
                            foreach (HtmlNode nextDatum in nextRow.ChildNodes.AsEnumerable())
                            {
                                string sName = nextDatum.Name;
                                if (sName == "th" || sName == "td")
                                {
                                    string sText = nextDatum.InnerText.Trim();
                                    sText = sText.Replace("&nbsp;", string.Empty);
                                    csv.WriteField(sText);
                                }
                            }
                            csv.NextRecord();
                        }
                    }
                }
            }
        }
    }
}
