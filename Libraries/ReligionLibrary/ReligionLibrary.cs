using CsvHelper;
using CsvHelper.Configuration;
using HtmlAgilityPack;
using LibraryShared;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml;

namespace ReligionLibrary
{
    public static class ReligionLibrary
    {
        public const string OR_TOKEN_WITH_SPACES_SINGLE_LETTER = " o ";
        public const string OR_TOKEN_WITH_SPACES_DOUBLE_LETTER = " or ";

        public static int RunMain(string[] args)
        {
            //if (args.Length < 2) throw new InvalidOperationException();
            string file1 = args[0];
            //string file2 = args[1];
            if (string.IsNullOrEmpty(file1)) throw new InvalidOperationException();
            LoadPopesByToken(file1);
            return 0;
        }

        /// <summary>
        /// holds pope exceptions
        /// </summary>
        public static class PopeExceptions
        {
            /// <summary>
            /// static constructor
            /// </summary>
            static PopeExceptions()
            {
                Replacements = new Dictionary<string, string>()
                {
                    { "21.25.X.1187", "21,25.X.1187" },
                    { "1. 6.IX.1181", "1,6.IX.1181" },
                };
            }

            /// <summary>
            /// replacements
            /// </summary>
            public static Dictionary<string, string> Replacements { get; set; }
        }

        public static void LoadPopesByToken(string inputFilePath)
        {
            HashSet<string> popeTokenTypes = new HashSet<string>();
            foreach (Pope p in GetInitialPopeList(inputFilePath))
            {
                List<PopeToken> tokens = LoadPopeTokens(p.BeginningPontificate);
                string nextTokenString = GetPopeTokenStringWithoutNumbers(tokens);
                List<List<PapalDate>> theDates = new List<List<PapalDate>>();
                switch (nextTokenString)
                {
                    case "0":
                        theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[0].Number!.Value, null, null, null, null, null, null)
                        });
                        break;
                    case "...0":
                        theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[3].Number!.Value, null, null, null, null, null, null)
                        });
                        break;
                    case "0o0":
                        theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[0].Number!.Value, null, null, null, null, null, null),
                            new PapalDate(tokens[2].Number!.Value, null, null, null, null, null, null)
                        });
                        break;
                    case "...IoI.0":
                        theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[7].Number!.Value, null, tokens[3].Number!.Value, null, null, null, null),
                            new PapalDate(tokens[7].Number!.Value, null, tokens[5].Number!.Value, null, null, null, null)
                        });
                        break;
                    case "0.I.0":
                        theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[4].Number!.Value, null, tokens[2].Number!.Value, null, null, tokens[0].Number!.Value, null)
                        });
                        break;
                    case "0o0o0.I.0":
                        theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[8].Number!.Value, null, tokens[6].Number!.Value, null, null, tokens[0].Number!.Value, null),
                            new PapalDate(tokens[8].Number!.Value, null, tokens[6].Number!.Value, null, null, tokens[2].Number!.Value, null),
                            new PapalDate(tokens[8].Number!.Value, null, tokens[6].Number!.Value, null, null, tokens[4].Number!.Value, null),
                        });
                        break;
                    case "0o0.I.0":
                        theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[6].Number!.Value, null, tokens[4].Number!.Value, null, null, tokens[0].Number!.Value, null),
                            new PapalDate(tokens[6].Number!.Value, null, tokens[4].Number!.Value, null, null, tokens[2].Number!.Value, null)
                        });
                        break;
                    case "0,0.I.0":
                        theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[6].Number!.Value, null, tokens[4].Number!.Value, null, null, tokens[0].Number!.Value, null),
                            new PapalDate(tokens[6].Number!.Value, null, tokens[4].Number!.Value, null, null, tokens[2].Number!.Value, null)
                        });
                        break;
                    default:
                        throw new InvalidOperationException();
                        break;

                }
            }
        }

        private static string GetPopeTokenStringWithoutNumbers(List<PopeToken> tokens)
        {
            StringBuilder sb = new StringBuilder();
            foreach (PopeToken pt in tokens)
            {
                char c;
                switch (pt.TokenType)
                {
                    case PopeTokenType.ArabicNumber:
                        c = '0'; 
                        break;
                    case PopeTokenType.Comma:
                        c = ',';
                        break;
                    case PopeTokenType.Or:
                        c = 'o';
                        break;
                    case PopeTokenType.Period:
                        c = '.';
                        break;
                    case PopeTokenType.RomanNumeral:
                        c = 'I';
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                sb.Append(c);
            }
            return sb.ToString();
        }

        private static List<PopeToken> LoadPopeTokens(string input)
        {
            PopeTokenType? currentTokenType = null;
            List<PopeToken> ret = new List<PopeToken>();
            string currentNumber = string.Empty;
            foreach (char next in input)
            {
                if (next == ' ')
                {
                    if (currentTokenType == PopeTokenType.ArabicNumber)
                        ret.Add(new PopeToken(PopeTokenType.ArabicNumber, int.Parse(currentNumber)));
                    else if (currentTokenType == PopeTokenType.RomanNumeral)
                        ret.Add(new PopeToken(PopeTokenType.RomanNumeral, Common.RomanNumeralToInteger(currentNumber)));
                    currentTokenType = null;
                    currentNumber = string.Empty;
                    continue;
                }
                else if (next == ',')
                {
                    if (currentTokenType == PopeTokenType.ArabicNumber)
                        ret.Add(new PopeToken(PopeTokenType.ArabicNumber, int.Parse(currentNumber)));
                    else if (currentTokenType == PopeTokenType.RomanNumeral)
                        ret.Add(new PopeToken(PopeTokenType.RomanNumeral, Common.RomanNumeralToInteger(currentNumber)));
                    currentTokenType = null;
                    currentNumber = string.Empty;
                    ret.Add(new PopeToken(PopeTokenType.Comma, null));
                }
                else if (next == '.')
                {
                    if (currentTokenType == PopeTokenType.ArabicNumber)
                        ret.Add(new PopeToken(PopeTokenType.ArabicNumber, int.Parse(currentNumber)));
                    else if (currentTokenType == PopeTokenType.RomanNumeral)
                        ret.Add(new PopeToken(PopeTokenType.RomanNumeral, Common.RomanNumeralToInteger(currentNumber)));
                    currentTokenType = null;
                    currentNumber = string.Empty;
                    ret.Add(new PopeToken(PopeTokenType.Period, null));
                }
                else if (next == 'o')
                {
                    if (currentTokenType == PopeTokenType.ArabicNumber)
                        ret.Add(new PopeToken(PopeTokenType.ArabicNumber, int.Parse(currentNumber)));
                    else if (currentTokenType == PopeTokenType.RomanNumeral)
                        ret.Add(new PopeToken(PopeTokenType.RomanNumeral, Common.RomanNumeralToInteger(currentNumber)));
                    currentTokenType = null;
                    currentNumber = string.Empty;
                    ret.Add(new PopeToken(PopeTokenType.Or, null));
                }
                else if (char.IsDigit(next))
                {
                    if (currentTokenType == PopeTokenType.RomanNumeral) throw new InvalidOperationException();
                    currentNumber += next;
                    currentTokenType = PopeTokenType.ArabicNumber;
                }
                else if (char.IsLetter(next))
                {
                    if (currentTokenType == PopeTokenType.ArabicNumber) throw new InvalidOperationException();
                    currentNumber += next;
                    currentTokenType = PopeTokenType.RomanNumeral;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            if (currentTokenType != PopeTokenType.ArabicNumber) throw new InvalidOperationException();
            ret.Add(new PopeToken(PopeTokenType.ArabicNumber, int.Parse(currentNumber)));
            return ret;
        }

        /// <summary>
        /// applies initial transformations to the pope
        /// </summary>
        /// <param name="p">pope</param>
        private static void ApplyInitialTransformations(Pope p)
        {
            if (p.Number == 1 && string.IsNullOrEmpty(p.BeginningPontificate))
            {
                p.BeginningPontificate = "30" + OR_TOKEN_WITH_SPACES_SINGLE_LETTER + "33";
            }
            string sBegin = p.BeginningPontificate;
            if (PopeExceptions.Replacements.TryGetValue(sBegin, out string? sNewValue))
            {
                sBegin = sNewValue;
            }
            p.BeginningPontificate = sBegin.Replace(OR_TOKEN_WITH_SPACES_DOUBLE_LETTER, OR_TOKEN_WITH_SPACES_SINGLE_LETTER);
            p.EndPontificate = p.EndPontificate.Replace(OR_TOKEN_WITH_SPACES_DOUBLE_LETTER, OR_TOKEN_WITH_SPACES_SINGLE_LETTER);
            p.PapalName = p.PapalName.Replace(OR_TOKEN_WITH_SPACES_DOUBLE_LETTER, OR_TOKEN_WITH_SPACES_SINGLE_LETTER);
        }

        /// <summary>
        /// retrieves the initial pope list
        /// </summary>
        /// <param name="inputFilePath">initial file path</param>
        /// <returns>list of popes</returns>
        private static List<Pope> GetInitialPopeList(string inputFilePath)
        {
            List<Pope> popeList = new List<Pope>();
            foreach (Pope p in Common.ProcessCSV<Pope, PopeMap>(inputFilePath))
            {
                ApplyInitialTransformations(p);
                popeList.Add(p);
            }
            return popeList;
        }

        //interesting: Julian/Gregorian calendar switchover
        //Benedict IX was pope on three separate occasions
        //Benedict X, John XVI, Alexander V, Felix II are anti-popes but count in the papal numbering
        //Boniface VII is considered anti-pope since he murdered the pope and took by force but counts in the numbering
        //John XXII was an anti-pope (1410-1415) and a pope (1958-1963)
        //There is no John XX (this was a mistake)

        //Popes that left office by other than dying:
        // 1. Pontian (230-235) (Resigned). Exiled to Sardinia, resigned to allow a new election.
        // 2. Silverius (536-537) (Deposed). Deposed by Byzantine general Belisarius, exiled.
        // 3. Benedict V (964) (Deposed). Deposed by Emperor Otto I; died in exile.
        // 4. John XVIII (1003-1009) (Abdicated, possible/uncertain). Some sources suggest he retired to a monastery, possible he may have died.
        // 5. Benedict IX (3 reigns from 1032-1048, Resigned/deposed/abdicated). Only pope to reign 3 times; sold papacy at one point.
        // 6. Gregory VI (1045-1046) (Resigned). Resigned due to being involved in simony (buying papacy from Benedict IX).
        // 7. Celestine V (1294) (Voluntarily Resigned). Famous for his humility; formally resigned after 5 months.
        // 8. Gregory XII (1406-1415) (Voluntarily Resigned). To end the Western Schism.
        // 9. Benedict XVI (2005-2013) (Voluntarily Resigned) First pope to resign in nearly 600 years.

        public static void LoadPopes(string inputFilePath, string outputFilePath)
        {
            Dictionary<string, List<int>> regnalNamesAndNumbers = new Dictionary<string, List<int>>();            
            List<PrecisePope> precisePopes = new List<PrecisePope>();
            List<Pope> popeList = GetInitialPopeList(inputFilePath);
            for (int i = popeList.Count - 1; i >= 0; i--)
            {
                Pope p = popeList[i];
                string sPapalNameA;
                string sPapalNameB;
                if (p.PapalName.Contains(OR_TOKEN_WITH_SPACES_SINGLE_LETTER))
                {
                    string[] vals = p.PapalName.Split(OR_TOKEN_WITH_SPACES_SINGLE_LETTER);
                    if (vals.Length != 2) throw new InvalidOperationException();
                    sPapalNameA = vals[0];
                    sPapalNameB = vals[1];
                }
                else
                {
                    sPapalNameA = p.PapalName;
                    sPapalNameB = string.Empty;
                }
                CleanPope cp = new CleanPope(p.Number, sPapalNameA, sPapalNameB, p.SecularName, p.Birthplace, p.Century);
                if (string.IsNullOrEmpty(p.EndPontificate))
                    cp.EndDate = null;
                else
                    cp.EndDate = ParsePopeEndDate(p.Number, p.EndPontificate);

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

                PrecisePope pp = new PrecisePope(cp);
                precisePopes.Add(pp);

                //update the list of regnal numbers
                foreach (var next in pp.PapalNames)
                {
                    string s = next.Key;
                    int iRegnalNumber = next.Value;
                    string nameToUse = s;
                    if (s == "Callistus")
                    {
                        nameToUse = "Callixtus";
                    }
                    List<int> nameNumbers;
                    if (regnalNamesAndNumbers.ContainsKey(nameToUse))
                    {
                        nameNumbers = regnalNamesAndNumbers[nameToUse];
                    }
                    else
                    {
                        nameNumbers = new List<int>();
                        regnalNamesAndNumbers[nameToUse] = nameNumbers;
                    }
                    if (!nameNumbers.Contains(iRegnalNumber))
                    {
                        nameNumbers.Add(iRegnalNumber);
                    }
                }
            }

            foreach (KeyValuePair<string, List<int>> entry in regnalNamesAndNumbers)
            {
                string sName = entry.Key;
                if (sName == "Callistus")
                {
                    sName = "Callixtus";
                }
                List<int> numbers = entry.Value;
                numbers.Sort();
                int lowest = numbers[0];
                if (lowest != 1)
                    throw new InvalidOperationException();
                List<int> missingNumbers = new List<int>();
                if (sName == "Alexander")
                {
                    missingNumbers.Add(5); //antipope
                }
                else if (sName == "Benedict")
                {
                    missingNumbers.Add(10); //antipope
                }
                else if (sName == "Boniface")
                {
                    missingNumbers.Add(7);
                }
                else if (sName == "Felix")
                {
                    missingNumbers.Add(2);
                }
                else if (sName == "John")
                {
                    missingNumbers.Add(16); //antipope
                    missingNumbers.Add(20); //skipped by mistake (possibly double counting of John XIV)
                }
                else if (sName == "Martin")
                {
                    missingNumbers.Add(2); //skipped by mistake (confusion with Marinus 1)
                    missingNumbers.Add(3); //skipped by mistake (confusion with Marinus 2)
                }
                int expectedHighest = numbers.Count;
                if (missingNumbers.Count > 0)
                {
                    foreach (int nextMissingNumber in missingNumbers)
                    {
                        if (numbers.Contains(nextMissingNumber))
                        {
                            throw new InvalidOperationException();
                        }
                        expectedHighest++;
                    }
                }
                if (numbers[numbers.Count - 1] != expectedHighest)
                    throw new InvalidOperationException();
            }

            bool foundPopeWithoutEndDate = false;
            XmlDocument doc = new XmlDocument();
            XmlElement mainElement = doc.CreateElement("popes");
            doc.AppendChild(mainElement);
            foreach (var p in precisePopes)
            {
                XmlElement popeElement = doc.CreateElement("p");
                popeElement.SetAttribute("number", p.Number.ToString());
                popeElement.SetAttribute("century", p.Century.ToString());
                if (!string.IsNullOrEmpty(p.SecularName))
                {
                    popeElement.SetAttribute("secularname", p.SecularName);
                }
                if (!string.IsNullOrEmpty("birthplace"))
                {
                    popeElement.SetAttribute("birthplace", p.Birthplace);
                }

                foreach (var nextPapalName in p.PapalNames)
                {
                    XmlElement papalNameElement = doc.CreateElement("Name");
                    papalNameElement.SetAttribute("n", nextPapalName.Key);
                    if (nextPapalName.Value > 1)
                    {
                        papalNameElement.SetAttribute("r", nextPapalName.Value.ToString());
                    }
                    popeElement.AppendChild(papalNameElement);
                }

                if (p.StartDate1.Count == 0) throw new InvalidOperationException();
                if (p.StartDate3.Count > 0 && p.StartDate2.Count == 0) throw new InvalidOperationException();
                if (p.StartDate1.Count > 0)
                {
                    XmlElement startDate = doc.CreateElement("StartDate");
                    if (p.StartDate1.Count == 1)
                    {
                        startDate.SetAttribute("d", GetDateElementText(p.StartDate1[0]));
                    }
                    else if (p.StartDate1.Count == 2)
                    {
                        startDate.SetAttribute("d1", GetDateElementText(p.StartDate1[0]));
                        startDate.SetAttribute("d2", GetDateElementText(p.StartDate1[1]));
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                    popeElement.AppendChild(startDate);
                }
                if (p.StartDate2.Count > 0)
                {
                    XmlElement startDate = doc.CreateElement("StartDate");
                    if (p.StartDate2.Count == 1)
                    {
                        startDate.SetAttribute("d", GetDateElementText(p.StartDate2[0]));
                    }
                    else if (p.StartDate2.Count == 2)
                    {
                        startDate.SetAttribute("d1", GetDateElementText(p.StartDate2[0]));
                        startDate.SetAttribute("d2", GetDateElementText(p.StartDate2[1]));
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                    popeElement.AppendChild(startDate);
                }
                if (p.StartDate3.Count > 0)
                {
                    XmlElement startDate = doc.CreateElement("StartDate");
                    if (p.StartDate3.Count == 1)
                    {
                        startDate.SetAttribute("d", GetDateElementText(p.StartDate3[0]));
                    }
                    else if (p.StartDate3.Count == 2)
                    {
                        startDate.SetAttribute("d1", GetDateElementText(p.StartDate3[0]));
                        startDate.SetAttribute("d2", GetDateElementText(p.StartDate3[1]));
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                    popeElement.AppendChild(startDate);
                }

                mainElement.AppendChild(popeElement);

                bool isCurrentPope = p.EndDate.Count == 0;
                if (isCurrentPope) //current pope
                {
                    if (foundPopeWithoutEndDate)
                    {
                        throw new InvalidOperationException();
                    }
                    else
                    {
                        foundPopeWithoutEndDate = true;
                    }
                }
                else //not the current pope
                {
                    XmlElement endDateElement = doc.CreateElement("EndDate");
                    if (p.EndDate.Count == 0)
                    {
                        throw new InvalidOperationException();
                    }
                    else if (p.EndDate.Count == 1)
                    {
                        endDateElement.SetAttribute("d", GetDateElementText(p.EndDate[0]));
                    }
                    else if (p.EndDate.Count == 2)
                    {
                        endDateElement.SetAttribute("d1", GetDateElementText(p.EndDate[0]));
                        endDateElement.SetAttribute("d2", GetDateElementText(p.EndDate[1]));
                    }
                    else if (p.EndDate.Count == 3)
                    {
                        endDateElement.SetAttribute("d1", GetDateElementText(p.EndDate[0]));
                        endDateElement.SetAttribute("d2", GetDateElementText(p.EndDate[1]));
                        endDateElement.SetAttribute("d3", GetDateElementText(p.EndDate[2]));
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                    popeElement.AppendChild(endDateElement);
                }
            }
            Common.WriteToFile(doc, outputFilePath);
        }

        private static string GetDateElementText(PapalDate dt)
        {
            if (dt.DayB.HasValue) throw new InvalidOperationException();
            if (dt.MonthB.HasValue) throw new InvalidOperationException();
            if (dt.MonthC.HasValue) throw new InvalidOperationException();
            if (dt.YearB.HasValue) throw new InvalidOperationException();
            string ret;
            if (dt.DayA.HasValue)
            {
                if (!dt.MonthA.HasValue) throw new InvalidOperationException();
                ret = dt.YearA.ToString().PadLeft(4, '0') + "-" + dt.MonthA.Value.ToString().PadLeft(2, '0') + "-" + dt.DayA.Value.ToString().PadLeft(2, '0');
            }
            else if (dt.MonthA.HasValue)
            {
                ret = dt.YearA.ToString().PadLeft(4, '0') + "-" + dt.MonthA.Value.ToString().PadLeft(2, '0');
            }
            else
            {
                ret = dt.YearA.ToString();
            }
            return ret;
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
                ret.Add(new PapalDate(900, null, 1, 5, null, null, null));
            }
            else if (date == "..XII.897 or I.898")
            {
                ret.Add(new PapalDate(897, 898, 12, 1, null, null, null));
            }
            else if (date == "... II-V.824")
            {
                ret.Add(new PapalDate(824, null, 2, 5, null, null, null));
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
                        yearDates.Add(new PapalDate(year, null, null, null, null, null, null));
                    }
                    else
                    {
                        string remainder = nextYear.Substring(0, nextYear.Length - year.ToString().Length - 1);
                        if (remainder == "...")
                        {
                            yearDates.Add(new PapalDate(year, null, null, null, null, null, null));
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
                                    if (sNextDayMonth.Contains(OR_TOKEN_WITH_SPACES_SINGLE_LETTER))
                                    {
                                        string[] vals = sNextDayMonth.Split(OR_TOKEN_WITH_SPACES_SINGLE_LETTER);
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
                                    else if (sRemaining.Contains(OR_TOKEN_WITH_SPACES_SINGLE_LETTER))
                                    {
                                        string[] vals = sRemaining.Split(OR_TOKEN_WITH_SPACES_SINGLE_LETTER);
                                        dayA = int.Parse(vals[0]);
                                        dayB = int.Parse(vals[1]);
                                    }
                                    else
                                    {
                                        dayA = dayA = int.Parse(sRemaining);
                                        dayB = null;
                                    }
                                }
                                yearDates.Insert(0, new PapalDate(year, null, monthA, monthB, null, dayA, dayB));
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
            return new PapalDate(iYearA, iYearB, null, null, null, null, null);
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
                ret = new PapalDate(928, 929, 12, 1, null, null, null);
            }
            else if (date == "...XII.897 or I.898")
            {
                ret = new PapalDate(897, 898, 12, 1, null, null, null);
            }
            else if (date == "...I-V.900")
            {
                ret = new PapalDate(900, null, 1, 5, null, null, null);
            }
            else if (date == "... II-V.824")
            {
                ret = new PapalDate(824, null, 2, 5, null, null, null);
            }
            else if (date == "25.II or 1.III.492")
            {
                ret = new PapalDate(492, null, 2, 3, null, 25, 1);
            }
            else if (date == "... VI or VIII or X.913")
            {
                ret = new PapalDate(913, null, 6, 8, 10, null, null);
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
                ret = new PapalDate(yearA, yearB, monthA, monthB, null, dayA, dayB);
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
        /// <param name="MonthC">month c</param>
        /// <param name="DayA">day a</param>
        /// <param name="DayB">day b</param>
        public PapalDate(int YearA, int? YearB, int? MonthA, int? MonthB, int? MonthC, int? DayA, int? DayB)
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
            if (MonthC.HasValue)
            {
                if (MonthC.Value < 1 || MonthC.Value > 12) throw new InvalidOperationException();
            }
            this.MonthA = MonthA;
            this.MonthB = MonthB;
            this.MonthC = MonthC;
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
        /// month C or null if there are fewer than one month
        /// </summary>
        public int? MonthC { get; set; }
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

    public class PrecisePope
    {
        /// <summary>
        /// more precise pope information
        /// </summary>
        /// <param name="CleanPope">clean pope information</param>
        public PrecisePope(CleanPope CleanPope)
        {
            PapalNames = new List<KeyValuePair<string, int>>();
            this.Number = CleanPope.Number;

            foreach (string name in CleanPope.PapalNames)
            {
                //separate the name and regnal number
                string[] nameWords = name.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string romanNumeral = string.Empty;
                int regnalNumber = -1;
                string baseName;
                bool parseRomanNumeral = true;
                if (nameWords.Length == 1)
                {
                    baseName = nameWords[0];
                    regnalNumber = 1;
                    parseRomanNumeral = false;
                }
                else if (nameWords.Length == 2)
                {
                    baseName = nameWords[0];
                    romanNumeral = nameWords[1];
                }
                else if (nameWords.Length == 3)
                {
                    baseName = nameWords[0] + " " + nameWords[1];
                    romanNumeral = nameWords[2];
                }
                else
                {
                    throw new InvalidOperationException();
                }
                if (parseRomanNumeral)
                {
                    regnalNumber = Common.RomanNumeralToInteger(romanNumeral);
                }
                PapalNames.Add(new KeyValuePair<string, int>(baseName, regnalNumber));
            }

            this.SecularName = CleanPope.SecularName;
            this.Birthplace = CleanPope.Birthplace;
            this.Century = CleanPope.Century;


            StartDate1 = new List<PapalDate>();
            StartDate2 = new List<PapalDate>();
            StartDate3 = new List<PapalDate>();
            EndDate = new List<PapalDate>();

            if (CleanPope.EndDate != null)
            {
                GenerateSeparatePapalDates(CleanPope.EndDate, EndDate);
            }

            if (CleanPope.StartDate1 == null)
                throw new InvalidOperationException();
            GenerateSeparatePapalDates(CleanPope.StartDate1, StartDate1);
            if (CleanPope.StartDate2 != null)
            {
                GenerateSeparatePapalDates(CleanPope.StartDate2, StartDate2);
                if (CleanPope.StartDate3 != null)
                {
                     GenerateSeparatePapalDates(CleanPope.StartDate3, StartDate3);
                }
            }
            else
            {
                if (CleanPope.StartDate3 != null) throw new InvalidOperationException();
            }
        }

        private void GenerateSeparatePapalDates(PapalDate Input, List<PapalDate> ret)
        {
            //first date in the Vatican's pope list is 64 or 67 for the end date of 1st pope
            //(I added in 30-33 as the claimed starting data for the 1st pope)
            if (Input.YearA < 30) throw new InvalidOperationException();

            if (Input.DayB.HasValue)
            {
                if (Input.MonthB.HasValue) //ambiguous days in different months
                {
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayA, null));
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthB, null, null, Input.DayB, null));
                    if (Input.YearB.HasValue) throw new InvalidOperationException();
                    if (Input.MonthC.HasValue) throw new InvalidOperationException();
                    if (!Input.DayA.HasValue) throw new InvalidOperationException();
                }
                else //ambiguous days in the same month
                {
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayA, null));
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayB, null));
                    if (Input.YearB.HasValue) throw new InvalidOperationException();
                    if (!Input.MonthA.HasValue) throw new InvalidOperationException();
                    if (Input.MonthB.HasValue) throw new InvalidOperationException();
                    if (Input.MonthC.HasValue) throw new InvalidOperationException();
                    if (!Input.DayA.HasValue) throw new InvalidOperationException();
                }
            }
            else if (Input.MonthC.HasValue) //only one example in the data set
            {
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, null, null));
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthB, null, null, null, null));
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthC, null, null, null, null));
                if (Input.YearB.HasValue) throw new InvalidOperationException();
                if (!Input.MonthA.HasValue) throw new InvalidOperationException();
                if (!Input.MonthB.HasValue) throw new InvalidOperationException();
                if (Input.DayA.HasValue) throw new InvalidOperationException();
                if (Input.DayB.HasValue) throw new InvalidOperationException();
            }
            else if (Input.MonthB.HasValue)
            {
                if (Input.YearB.HasValue)
                {
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, null, null));
                    ret.Add(new PapalDate(Input.YearB.Value, null, Input.MonthB, null, null, null, null));
                    if (!Input.MonthA.HasValue) throw new InvalidOperationException();
                    if (Input.DayA.HasValue) throw new InvalidOperationException();
                    if (Input.DayB.HasValue) throw new InvalidOperationException();
                }
                else
                {
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, null, null));
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthB, null, null, null, null));
                    if (!Input.MonthA.HasValue) throw new InvalidOperationException();
                    if (Input.DayA.HasValue) throw new InvalidOperationException();
                    if (Input.DayB.HasValue) throw new InvalidOperationException();
                }
            }
            else if (Input.YearB.HasValue)
            {
                if (Input.DayB.HasValue) //specific days for different years
                {
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayA, null));
                    ret.Add(new PapalDate(Input.YearB.Value, null, Input.MonthB, null, null, Input.DayB, null));
                    if (!Input.MonthA.HasValue) throw new InvalidOperationException();
                    if (!Input.DayA.HasValue) throw new InvalidOperationException();
                    if (!Input.DayB.HasValue) throw new InvalidOperationException();
                }
                else if (Input.DayA.HasValue) //specific day+month, but unclear what year
                {
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayA, null));
                    ret.Add(new PapalDate(Input.YearB.Value, null, Input.MonthA, null, null, Input.DayA, null));
                    if (!Input.MonthA.HasValue) throw new InvalidOperationException();
                }
                else if (Input.YearB.HasValue) //two possible years
                {
                    ret.Add(new PapalDate(Input.YearA, null, null, null, null, null, null));
                    ret.Add(new PapalDate(Input.YearB.Value, null, null, null, null, null, null));
                    if (Input.MonthA.HasValue) throw new InvalidOperationException();
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            else if (Input.DayA.HasValue)
            {
                if (!Input.MonthA.HasValue) throw new InvalidOperationException();
                if (!Input.DayA.HasValue) throw new InvalidOperationException();
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayA, null));
            }
            else if (Input.MonthA.HasValue)
            {
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, null, null));
            }
            else //only the year
            {
                ret.Add(new PapalDate(Input.YearA, null, null, null, null, null, null));
            }
        }

        /// <summary>
        /// pope number
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// papal names and regnal numbers
        /// </summary>
        public List<KeyValuePair<string, int>> PapalNames { get; set; }
        
        /// <summary>
        /// possible start dates (date #3)
        /// </summary>
        public List<PapalDate> StartDate1 { get; set; }

        /// <summary>
        /// possible start dates (date #2)
        /// </summary>
        public List<PapalDate> StartDate2 { get; set; }

        /// <summary>
        /// possible start dates (date #3)
        /// </summary>
        public List<PapalDate> StartDate3 { get; set; }

        /// <summary>
        /// possible end dates
        /// </summary>
        public List<PapalDate> EndDate { get; set; }

        /// <summary>
        /// secular name
        /// </summary>
        public string SecularName { get; set; }

        /// <summary>
        /// birth
        /// </summary>
        public string Birthplace { get; set; }

        /// <summary>
        /// century (from the vatican's list, some popes' reigns are included in two centuries)
        /// </summary>
        public int Century { get; set; }
    }

    public class CleanPope
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Number">pope number</param>
        /// <param name="PapalNameA">papal name A</param>
        /// <param name="PapalNameB">papal name B</param>
        /// <param name="SecularName">secular name</param>
        /// <param name="Birthplace">birthplace</param>
        /// <param name="Century">century</param>
        public CleanPope(int Number, string PapalNameA, string PapalNameB, string SecularName, string Birthplace, int Century)
        {
            this.Number = Number;
            this.PapalNames = new List<string>() { PapalNameA };
            if (!string.IsNullOrEmpty(PapalNameB)) this.PapalNames.Add(PapalNameB);
            this.SecularName = SecularName;
            this.Birthplace = Birthplace;
            this.Century = Century;
        }

        /// <summary>
        /// pope number
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// papal names
        /// </summary>
        public List<string> PapalNames { get; set; }

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

    /// <summary>
    /// pope token
    /// </summary>
    public class PopeToken
    {
        /// <summary>
        /// construtor
        /// </summary>
        /// <param name="TokenType">token type</param>
        /// <param name="Number">number</param>
        public PopeToken(PopeTokenType TokenType, int? Number)
        {
            this.TokenType = TokenType;
            this.Number = Number;
        }

        /// <summary>
        /// pope token type
        /// </summary>
        public PopeTokenType TokenType { get; set; }

        /// <summary>
        /// token number for an arabic number or roman numeral
        /// </summary>
        public int? Number { get; set; }
    }

    /// <summary>
    /// pope token type
    /// </summary>
    public enum PopeTokenType
    {
        /// <summary>
        /// arabic number
        /// </summary>
        ArabicNumber,
        /// <summary>
        /// comma
        /// </summary>
        Comma,
        /// <summary>
        /// or
        /// </summary>
        Or,
        /// <summary>
        /// period
        /// </summary>
        Period,
        /// <summary>
        /// roman numeral
        /// </summary>
        RomanNumeral,
    }
}
