using CsvHelper;
using CsvHelper.Configuration;
using HtmlAgilityPack;
using LibraryShared;
using System.Globalization;

namespace ReligionLibrary
{
    public static class ReligionLibrary
    {
        public static int RunMain(string[] args)
        {
            LoadPopes(args[0]);
            return 0;
        }

        //interesting: Julian/Gregorian calendar switchover
        //There is no John XX.
        
        public static void LoadPopes(string filePath)
        {
            List<Pope> popeList = new List<Pope>();
            foreach (Pope p in Common.ProcessCSV<Pope, PopeMap>(filePath))
            {
                string sBegin = p.BeginningPontificate.Replace(" o ", " or ");
                if (sBegin == "21.25.X.1187")
                    p.BeginningPontificate = "21,25.X.1187";
                else if  (sBegin == "1. 6.IX.1181")
                    p.BeginningPontificate = "1,6.IX.1181";
                else
                    p.BeginningPontificate = sBegin;
                p.EndPontificate = p.EndPontificate.Replace(" o ", " or ");
                popeList.Add(p);
            }
            for (int i = popeList.Count - 1; i >= 0; i--)
            {
                Pope p = popeList[i];
                CleanPope cp = new CleanPope(p.Number, p.PapalName, p.SecularName, p.Birthplace, p.Century);
                if (string.IsNullOrEmpty(p.EndPontificate))
                    cp.EndDate = null;
                else
                    cp.EndDate = ParsePopeEndDate(p.Number, p.EndPontificate);

                if (p.Number > 1)
                {
                    List<PapalDate> start = ParsePopeStartDates(p.Number, p.BeginningPontificate);
                    if (start.Count <= 0 || start.Count > 3)
                        throw new InvalidOperationException();

                    cp.StartDate1 = start[0];
                    if (start.Count > 1)
                    {
                        cp.StartDate2 = start[1];
                        if (cp.StartDate1.CompareTo(cp.StartDate2) >= 0)
                        {
                            throw new InvalidOperationException();
                        }
                    }
                    if (start.Count > 2)
                    {
                        cp.StartDate3 = start[2];
                        if (cp.StartDate2!.CompareTo(cp.StartDate3) >= 0)
                        {
                            throw new InvalidOperationException();
                        }
                    }
                }
            }
        }

        private static List<PapalDate> ParsePopeStartDates(int popeNumber, string date)
        {
            List<PapalDate> ret = new List<PapalDate>();
            if (popeNumber <= 17) //simplified logic before any months are in the data
            {
                ret.Add(ParseEarlyPopeYearOrYears(date));
            }
            else if (date == "...I-V.900")
            {
                ret.Add(new PapalDate(900, null, 1, 5, null, null));
            }
            else if (date == "..XII.897 or I.898")
            {
                ret.Add(new PapalDate(897, 898, 12, 1, null, null));
            }
            else if (date == "... II-V.824")
            {
                ret.Add(new PapalDate(824, null, 2, 5, null, null));
            }
            else //more modern popes have more consistent year data
            {
                bool foundFirstYear = false;
                bool foundLastYear = false;
                int firstYear = 0;
                int lastYear = 0;
                int place = 1;
                for (int i = date.Length - 1; i >= 0; i--)
                {
                    char nextChar = date[i];
                    string sChar = nextChar.ToString();
                    bool isDigit = char.IsDigit(nextChar);
                    if (!foundLastYear)
                    {
                        if (isDigit)
                        {
                            lastYear += place * int.Parse(sChar);
                            place *= 10;
                        }
                        else
                        {
                            foundLastYear = true;
                            place = 1;
                            firstYear = 0;
                        }
                    }
                    else //looking for the second year
                    {
                        if (isDigit)
                        {
                            firstYear += place * int.Parse(sChar);
                            place *= 10;
                        }
                        else if (nextChar == '.' || nextChar == ' ')
                        {
                            if (firstYear <= lastYear && firstYear + 100 > lastYear)
                            {
                                foundFirstYear = true;
                                break;
                            }
                            else
                            {
                                firstYear = 0;
                                place = 1;
                            }
                        }
                        else
                        {
                            firstYear = 0;
                            place = 1;
                        }
                    }
                }

                List<string> yearData = new List<string>();
                if (foundFirstYear)
                {
                    int iFirstDateIndex = date.IndexOf(firstYear.ToString());
                    if (iFirstDateIndex < 0) throw new InvalidOperationException();
                    string firstYearData = date.Substring(0, iFirstDateIndex + firstYear.ToString().Length);
                    string secondYearData = date.Substring(firstYearData.Length + 1);
                    yearData.Add(firstYearData);
                    yearData.Add(secondYearData);
                }
                else
                {
                    yearData.Add(date);
                }

                for (int k = 0; k < yearData.Count; k++)
                {
                    string nextYear = yearData[k];
                    List<PapalDate> yearDates = new List<PapalDate>();
                    int year;
                    if (foundFirstYear)
                        year = k == 0 ? firstYear : lastYear;
                    else
                        year = lastYear;
                    if (nextYear.Length == year.ToString().Length)
                    {
                        yearDates.Add(new PapalDate(year, null, null, null, null, null));
                    }
                    else
                    {
                        string remainder = nextYear.Substring(0, nextYear.Length - year.ToString().Length - 1);
                        if (remainder == "...")
                        {
                            yearDates.Add(new PapalDate(year, null, null, null, null, null));
                        }
                        else
                        {
                            string[] daysandmonths = remainder.Split(",");
                            int monthA = -1;
                            int? monthB = null;
                            for (int j = daysandmonths.Length - 1; j >= 0; j--) //day(s)+month entries
                            {
                                string[] splitoutmonth = daysandmonths[j].Split(".");
                                string sNextDayMonth = splitoutmonth[splitoutmonth.Length - 1].Trim();
                                int? dayA;
                                int? dayB;
                                if (int.TryParse(sNextDayMonth, out int iDay))
                                {
                                    dayA = iDay;
                                    dayB = null;
                                }
                                else
                                {
                                    if (sNextDayMonth.Contains(" or "))
                                    {
                                        string[] vals = sNextDayMonth.Split(" or ");
                                        monthA = Common.RomanNumeralToInteger(vals[0]);
                                        monthB = Common.RomanNumeralToInteger(vals[1]);
                                    }
                                    else
                                    {
                                        monthA = Common.RomanNumeralToInteger(sNextDayMonth);
                                        monthB = null;
                                    }
                                    string[] monthremoved = new string[splitoutmonth.Length - 1];
                                    Array.Copy(splitoutmonth, monthremoved, splitoutmonth.Length - 1);
                                    string sRemaining = string.Join(".", monthremoved);
                                    if (sRemaining == "..")
                                    {
                                        dayA = null;
                                        dayB = null;
                                    }
                                    else if (sRemaining.Contains(" or "))
                                    {
                                        string[] vals = sRemaining.Split(" or ");
                                        dayA = int.Parse(vals[0]);
                                        dayB = int.Parse(vals[1]);
                                    }
                                    else
                                    {
                                        dayA = dayA = int.Parse(sRemaining);
                                        dayB = null;
                                    }
                                }
                                yearDates.Insert(0, new PapalDate(year, null, monthA, monthB, dayA, dayB));
                            }
                        }
                    }
                    ret.AddRange(yearDates);
                }
            }
            return ret;
        }

        private static PapalDate ParseEarlyPopeYearOrYears(string date)
        {
            int iYearA;
            int? iYearB;
            if (date.Contains(" or "))
            {
                string[] vals = date.Split(" or ");
                iYearA = int.Parse(vals[0]);
                iYearB = int.Parse(vals[1]);
            }
            else
            {
                iYearA = -1;
                try
                {
                    iYearA = int.Parse(date);
                }
                catch (Exception ex)
                {

                }
                iYearB = null;
            }
            return new PapalDate(iYearA, iYearB, null, null, null, null);
        }

        /// <summary>
        /// parses the pope end date
        /// </summary>
        /// <param name="popeNumber">pope number</param>
        /// <param name="date">date as string</param>
        /// <returns>end date</returns>
        private static PapalDate ParsePopeEndDate(int popeNumber, string date)
        {
            PapalDate ret;
            if (popeNumber <= 17)
            {
                ret = ParseEarlyPopeYearOrYears(date);
            }
            else if (date == "... XII.928 or I.929")
            {
                ret = new PapalDate(928, 929, 12, 1, null, null);
            }
            else if (date == "...XII.897 or I.898")
            {
                ret = new PapalDate(897, 898, 12, 1, null, null);
            }
            else if (date == "...I-V.900")
            {
                ret = new PapalDate(900, null, 1, 5, null, null);
            }
            else if (date == "... II-V.824")
            {
                ret = new PapalDate(824, null, 2, 5, null, null);
            }
            else if (date == "25.II or 1.III.492")
            {
                ret = new PapalDate(492, null, 2, 3, 25, 1);
            }
            else
            {
                string[] end = date.Split(".");
                if (end.Length < 3) throw new InvalidOperationException();
                string yearValue = end[end.Length - 1];
                int yearA;
                int? yearB;
                if (yearValue == "964 or 965")
                {
                    yearA = 964;
                    yearB = 965;
                }
                else
                {
                    yearA = int.Parse(yearValue);
                    yearB = null;
                }
                string sMonth = end[end.Length - 2].Trim();
                int? monthA = null;
                int? monthB = null;
                string[] remainder = new string[end.Length - 2];
                Array.Copy(end, remainder, end.Length - 2);
                string remaindertext = string.Join(".", remainder);
                if (string.IsNullOrEmpty(sMonth))
                {
                    if (remaindertext == ".")
                    {
                        monthA = null;
                        monthB = null;
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                }
                else //regular month
                {
                    if (sMonth.Contains(" or "))
                    {
                        string[] vals = sMonth.Split(" or ");
                        monthA = Common.RomanNumeralToInteger(vals[0]);
                        monthB = Common.RomanNumeralToInteger(vals[1]);
                    }
                    else
                    {
                        monthA = Common.RomanNumeralToInteger(sMonth);
                        monthB = null;
                    }
                }
                int? dayA;
                int? dayB;
                if (remaindertext == "..") //no date
                {
                    dayA = null;
                    dayB = null;
                }
                else if (remaindertext.Contains(" or ")) //two possible dates
                {
                    string[] vals = remaindertext.Split(" or ");
                    if (vals.Length != 2) throw new InvalidOperationException();
                    dayA = int.Parse(vals[0]);
                    dayB = int.Parse(vals[1]);
                }
                else //simple day
                {
                    if (remaindertext == ".")
                        dayA = null;
                    else
                        dayA = int.Parse(remaindertext);
                    dayB = null;
                }
                ret = new PapalDate(yearA, yearB, monthA, monthB, dayA, dayB);
            }
            return ret;
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

    /// <summary>
    /// a date relevant to transitioning to and from pope
    /// </summary>
    public class PapalDate : IComparable<PapalDate>
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="YearA">year A</param>
        /// <param name="YearB">year B</param>
        /// <param name="MonthA">month a</param>
        /// <param name="MonthB">month b</param>
        /// <param name="DayA">day a</param>
        /// <param name="DayB">day b</param>
        public PapalDate(int YearA, int? YearB, int? MonthA, int? MonthB, int? DayA, int? DayB)
        {
            if (YearA < 0) throw new InvalidOperationException();
            this.YearA = YearA;
            if (YearB.HasValue && YearB.Value < 0) throw new InvalidOperationException();
            this.YearB = YearB;
            if (MonthA < 1 || MonthA > 12) throw new InvalidOperationException();
            if (MonthB.HasValue)
            {
                if (MonthB.Value < 1 || MonthB.Value > 12) throw new InvalidOperationException();
            }
            this.MonthA = MonthA;
            this.MonthB = MonthB;
            this.DayA = DayA;
            this.DayB = DayB;
        }
        /// <summary>
        /// day A or null if unknown day
        /// </summary>
        public int? DayA { get; set; }
        /// <summary>
        /// day B or null if unknown day or there is only one day
        /// </summary>
        public int? DayB { get; set; }
        /// <summary>
        /// month A or null if unknown
        /// </summary>
        public int? MonthA { get; set; }
        /// <summary>
        /// month B or null if there is only one month
        /// </summary>
        public int? MonthB { get; set; }
        /// <summary>
        /// first or only year
        /// </summary>
        public int YearA { get; set; }
        /// <summary>
        /// year B if the year is ambiguous
        /// </summary>
        public int? YearB { get; set; }

        /// <summary>
        /// compares two dates
        /// </summary>
        /// <param name="other">other date</param>
        /// <returns>comparison value</returns>
        public int CompareTo(PapalDate? other)
        {
            if (other == null) return 1;
            int ret = this.YearA.CompareTo(other.YearA);
            if (ret == 0)
            {
                if (!other.MonthA.HasValue && !this.MonthA.HasValue) ret = 0;
                else if (!other.MonthA.HasValue) ret = 1;
                else if (!this.MonthA.HasValue) ret = -1;
                else ret = this.MonthA.Value.CompareTo(other.MonthA.Value);
            }
            if (ret == 0)
            {
                if (!other.DayA.HasValue && !this.DayA.HasValue) ret = 0;
                else if (!other.DayA.HasValue) ret = 1;
                else if (!this.DayA.HasValue) ret = -1;
                else ret = this.DayA.Value.CompareTo(other.DayA.Value);
            }
            return ret;
        }
    }

    public class CleanPope
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Number">pope number</param>
        /// <param name="PapalName">papal name</param>
        /// <param name="SecularName">secular name</param>
        /// <param name="Birthplace">birthplace</param>
        /// <param name="Century">century</param>
        public CleanPope(int Number, string PapalName, string SecularName, string Birthplace, int Century)
        {
            this.Number = Number;
            this.PapalName = PapalName;
            this.SecularName = SecularName;
            this.Birthplace = Birthplace;
            this.Century = Century;
        }

        /// <summary>
        /// pope number
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// papal name
        /// </summary>
        public string PapalName { get; set; }

        /// <summary>
        /// first start date
        /// </summary>
        public PapalDate? StartDate1 { get; set; }

        /// <summary>
        /// second start date
        /// </summary>
        public PapalDate? StartDate2 { get; set; }

        /// <summary>
        /// third start date
        /// </summary>
        public PapalDate? StartDate3 { get; set; }

        /// <summary>
        /// end date
        /// </summary>
        public PapalDate? EndDate { get; set; }

        /// <summary>
        /// secular name
        /// </summary>
        public string SecularName { get; set; }

        /// <summary>
        /// birth
        /// </summary>
        public string Birthplace { get; set; }
        /// <summary>
        /// century
        /// </summary>
        public int Century { get; set; }
    }

    public class Pope
    {
        /// <summary>
        /// pope number
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// papal name
        /// </summary>
        public required string PapalName { get; set; }
        /// <summary>
        /// beginning pontificate
        /// </summary>
        public required string BeginningPontificate { get; set; }
        /// <summary>
        /// end pontificate
        /// </summary>
        public required string EndPontificate { get; set; }
        /// <summary>
        /// secular name
        /// </summary>
        public required string SecularName { get; set; }
        /// <summary>
        /// birth place
        /// </summary>
        public required string Birthplace { get; set; }
        /// <summary>
        /// century
        /// </summary>
        public int Century { get; set; }
    }
    /// <summary>
    /// pope map
    /// </summary>
    public class PopeMap : ClassMap<Pope>
    {
        /// <summary>
        /// constructor
        /// </summary>
        public PopeMap()
        {
            Map(m => m.Number).Index(0);
            Map(m => m.PapalName).Name("PAPAL NAME");
            Map(m => m.BeginningPontificate).Name("BEGINNING PONTIFICATE");
            Map(m => m.EndPontificate).Name("END PONTIFICATE");
            Map(m => m.SecularName).Name("SECULAR NAME");
            Map(m => m.Birthplace).Name("BIRTH");
            Map(m => m.Century).Name("CENTURY");
        }
    }
}
