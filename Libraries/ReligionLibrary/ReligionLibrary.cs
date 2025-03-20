using CsvHelper;
using CsvHelper.Configuration;
using HtmlAgilityPack;
using LibraryShared;
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
            if (args.Length < 1) throw new InvalidOperationException();
            string file1 = args[0];
            string file2 = args.Length > 1 ? args[1] : string.Empty;
            if (string.IsNullOrEmpty(file1)) throw new InvalidOperationException();

            Dictionary<string, List<int>> regnalNamesAndNumbers;
            List<PrecisePope> ppByToken = LoadPopesByToken(file1, out regnalNamesAndNumbers);
            List<PrecisePope> ppByLegacyMethod = LoadPopes(file1);

            if (ppByToken.Count != ppByLegacyMethod.Count) throw new InvalidOperationException();

            for (int popeIndex = 0; popeIndex < ppByToken.Count; popeIndex++)
            {
                PrecisePope p1 = ppByToken[popeIndex];
                PrecisePope p2 = ppByLegacyMethod[popeIndex];

                if (PopeStatic.YearSwitchExceptions.Contains(p1.Number))
                {
                    int yrTemp;
                    if (p1.StartDates[0][0].YearA > p1.StartDates[0][1].YearA)
                    {
                        yrTemp = p1.StartDates[0][0].YearA;
                        p1.StartDates[0][0].YearA = p1.StartDates[0][1].YearA;
                        p1.StartDates[0][1].YearA = yrTemp;
                    }
                    if (p2.StartDates[0][0].YearA > p2.StartDates[0][1].YearA)
                    {
                        yrTemp = p2.StartDates[0][0].YearA;
                        p2.StartDates[0][0].YearA = p2.StartDates[0][1].YearA;
                        p2.StartDates[0][1].YearA = yrTemp;
                    }
                }

                //verify end date is equivalent by both methods
                if (p1.EndDate.Count != p2.EndDate.Count) throw new InvalidOperationException();
                if (p1.EndDate.Count == 0 && popeIndex != ppByToken.Count - 1) throw new InvalidOperationException();
                for (int i = 0; i < p1.EndDate.Count; i++)
                {
                    ValidatePapalDates(p1.EndDate[i], p2.EndDate[i]);
                }
                
                //verify all three start dates are equivalent by both methods
                bool foundNothing = false;
                List<PapalDate> startDates = new List<PapalDate>();
                for (int i = 0; i < 3; i++)
                {
                    List<PapalDate> list1 = p1.StartDates[i];
                    List<PapalDate> list2 = p2.StartDates[i];
                    if (list1.Count != list2.Count) throw new InvalidOperationException();
                    if (i == 0 && list1.Count == 0) throw new InvalidOperationException();
                    if (foundNothing && list1.Count > 0) throw new InvalidOperationException();
                    for (int j = 0; j < list1.Count; j++)
                    {
                        ValidatePapalDates(list1[j], list2[j]);
                    }
                    startDates.AddRange(list1);
                }

                //verify the start date(s) followed by end date(s) are all in consistent order
                for (int i = 1; i < startDates.Count; i++)
                {
                    if (startDates[i-1].CompareTo(startDates[i]) >= 0)
                    {
                        throw new InvalidOperationException();
                    }
                }
                if (p1.EndDate.Count > 0)
                {
                    for (int i = 1; i < p1.EndDate.Count; i++)
                    {
                        if (p1.EndDate[i - 1].CompareTo(p1.EndDate[i]) >= 0)
                        {
                            throw new InvalidOperationException();
                        }
                    }
                    bool isViolation = p1.EndDate[0].CompareTo(startDates[startDates.Count - 1]) < 0;
                    bool expectedViolation = PopeStatic.DatesOutOfOrderExceptions.Contains(p1.Number);
                    if (isViolation != expectedViolation) throw new InvalidOperationException();
                }
            }
            if (!string.IsNullOrEmpty(file2))
            {
                SavePopesToFile(file2, ppByToken, regnalNamesAndNumbers);
            }
            return 0;
        }

        private static void ValidatePapalDates(PapalDate dt1, PapalDate dt2)
        {
            if (!dt1.IsValidDate()) throw new InvalidOperationException();
            if (!dt1.IsSimpleDate()) throw new InvalidOperationException();
            if (!dt2.IsValidDate()) throw new InvalidOperationException();
            if (!dt2.IsSimpleDate()) throw new InvalidOperationException();
            if (dt1.CompareTo(dt2) != 0) throw new InvalidOperationException();
        }

        private static HashSet<string> ValidTokenCombinations = new HashSet<string>()
        {
                "0",
                "...0",
                "0o0",
                "...IoI.0",
                "0.I.0",
                "0o0o0.I.0",
                "0o0.I.0",
                "0,0.I.0",
                "0.I.0,0.I.0",
                "...I,0.I.0",
                "...I.0,0.I.0",
                "0.I,0.I.0",
                "...I.0",
                "0.Io0.I.0",
                "...I-I.0",
                "...I.0oI.0",
                "..I.0oI.0",
                "...IoIoI.0",
                "0.I,...I.0",
                "0.I.0o0",
                "0,0,0.I.0",
                "0.I,0,0.I.0",
                "0,0.I,0.I.0",
        };

        /// <summary>
        /// holds pope exceptions
        /// </summary>
        public static class PopeStatic
        {
            /// <summary>
            /// static constructor
            /// </summary>
            static PopeStatic()
            {
                DateReplacements = new Dictionary<string, string>()
                {
                    { "21.25.X.1187", "21,25.X.1187" },
                    { "1. 6.IX.1181", "1,6.IX.1181" },
                };
                PapalNameReplacements = new Dictionary<string, string>()
                {
                    { "Callistus", "Callixtus" }
                };
                PapalNameReplacementsReverse = new Dictionary<string, string>()
                {
                    { "Callixtus", "Callistus" }
                };
                MissingRegnalNumbersByRegnalName = new Dictionary<string, List<int>>()
                {
                    { "Alexander", new List<int>() { 5 } }, //antipope
                    { "Benedict", new List<int>() { 10 } }, //antipope
                    { "Boniface", new List<int>() { 7 } }, //antipope
                    { "Felix", new List<int>() { 2 } }, //antipope
                    { "John", new List<int>() { 16, 20 } }, //antipope and skipped by mistake (possibly double counting John XIV)
                    { "Martin", new List<int>() { 2, 3 } } //skipped by mistake (confusion with Marinus I and II)
                };
                YearSwitchExceptions = new HashSet<int>() { 5 };
                UnusedTokenCombinations = new HashSet<string>(ValidTokenCombinations);
                DatesOutOfOrderExceptions = new HashSet<int>(){ 11 };
            }

            /// <summary>
            /// token combinations
            /// </summary>
            public static HashSet<string> UnusedTokenCombinations { get; set; }

            /// <summary>
            /// date replacements
            /// </summary>
            public static Dictionary<string, string> DateReplacements { get; set; }

            /// <summary>
            /// papal name replacements
            /// </summary>
            public static Dictionary<string, string> PapalNameReplacements { get; set; }

            /// <summary>
            /// papal name replacements reverse mapping
            /// </summary>
            public static Dictionary<string, string> PapalNameReplacementsReverse { get; set; }

            /// <summary>
            /// missing Regnal Numbers by Regnal Name
            /// </summary>
            public static Dictionary<string, List<int>> MissingRegnalNumbersByRegnalName { get; set; }

            /// <summary>
            /// date switch exceptions, by pope number
            /// </summary>
            public static HashSet<int> YearSwitchExceptions { get; set; }

            /// <summary>
            /// dates out of order exceptions
            /// </summary>
            public static HashSet<int> DatesOutOfOrderExceptions { get; set; }
        }

        /// <summary>
        /// load popes by token
        /// </summary>
        /// <param name="inputFilePath">input file path</param>
        /// <param name="regnalNamesAndNumbers">regnal names and numbers</param>
        /// <returns></returns>
        public static List<PrecisePope> LoadPopesByToken(string inputFilePath, out Dictionary<string, List<int>> regnalNamesAndNumbers)
        {
            Dictionary<int, string> testPopes = new Dictionary<int, string>()
            {
                { 1, "Peter" },
                { 3, "Anacletus or Cletus" },
                { 11, "Anicetus" },
                { 14, "Victor I" },
                { 16, "Callistus I" },
                { 18, "Pontianus" },
                { 21, "Cornelius" },
                { 22, "Lucius I" },
                { 26, "Felix I" },
                { 32, "Miltiades or Melchiades" },
                { 33, "Sylvester I" },
                { 34, "Mark" },
                { 38, "Siricius" },
                { 48, "Felix III" },
                { 49, "Gelasius I" },
                { 54, "Felix IV" },
                { 55, "Boniface II" },
                { 58, "Silverius" },
                { 68, "Deusdedit or Adeodatus I" },
                { 106, "Adrian II" },
                { 109, "Adrian III" },
                { 113, "Stephen VI" },
                { 114, "Romanus" },
                { 115, "Theodore II" },
                { 116, "John IX" },
                { 120, "Anastasius III" },
                { 121, "Lando" },
                { 122, "John X" },
                { 123, "Leo VI" },
                { 132, "Benedict V" },
                { 136, "John XIV" },
                { 138, "Gregory V" },
                { 141, "John XVIII" },
                { 144, "John XIX" },
                { 145, "Benedict IX" }, //has three separate reigns
                { 146, "Sylvester III" },
                { 147, "Benedict IX" }, //has three separate reigns
                { 148, "Gregory VI" },
                { 149, "Clement II" },
                { 150, "Benedict IX" }, //has three separate reigns
                { 151, "Damasus II" },
                { 157, "Urban II" },
                { 159, "Paschal II" },
                { 162, "Callixtus II" },
                { 163, "Honorius II" },
                { 176, "Innocent III" },
                { 192, "Celestine V" },
                { 193, "Boniface VIII" },
                { 200, "Urban V" },
                { 201, "Gregory XI" },
                { 202, "Urban VI" },
                { 205, "Gregory XII" },
                { 209, "Callixtus III" },
                { 216, "Julius II" },
                { 217, "Leo X" },
                { 226, "Gregory XIII" }, //Julian->Gregorian Calendar transition
                { 255, "Pius IX" }, //first vatican council
                { 261, "John XXIII" }, //started second vatican council
                { 262, "Paul VI" }, //concluded second vatican council (last pope who had a coronation)
                { 263, "John Paul I" },
                { 264, "John Paul II" },
                { 265, "Benedict XVI" },
                { 266, "Francis" },
            };
            HashSet<string> unprocessedStartDates = new HashSet<string>();
            HashSet<string> unprocessedEndDates = new HashSet<string>();
            foreach (string s in ValidTokenCombinations)
            {
                unprocessedStartDates.Add(s);
                unprocessedEndDates.Add(s);
            }
            if (PopeStatic.UnusedTokenCombinations.Count != ValidTokenCombinations.Count)
            {
                throw new InvalidOperationException();
            }
            regnalNamesAndNumbers = new Dictionary<string, List<int>>();
            HashSet<string> popeTokenTypes = new HashSet<string>();
            int iIndex = 0;
            List<Pope> initialPopeList = GetInitialPopeList(inputFilePath);
            List<PrecisePope> ppList = new List<PrecisePope>();
            foreach (Pope p in initialPopeList)
            {
                PrecisePope pp = new PrecisePope(p.Number, p.SecularName, p.Birthplace, p.Century);

                List<string> papalNames = new List<string>();
                if (p.PapalName.Contains(OR_TOKEN_WITH_SPACES_SINGLE_LETTER))
                {
                    string[] vals = p.PapalName.Split(OR_TOKEN_WITH_SPACES_SINGLE_LETTER);
                    if (vals.Length != 2) throw new InvalidOperationException();
                    papalNames.Add(vals[0]);
                    papalNames.Add(vals[1]);
                }
                else
                {
                    papalNames.Add(p.PapalName);
                }
                List<KeyValuePair<string, int>> PapalNames = new List<KeyValuePair<string, int>>();
                foreach (string name in papalNames)
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

                string rawInput = p.BeginningPontificate;
                List<PopeToken> tokens = LoadPopeTokens(rawInput);
                string nextTokenString = GetPopeTokenStringWithoutNumbers(tokens);

                if (!testPopes.ContainsKey(p.Number))
                {
                    if (unprocessedStartDates.Contains(nextTokenString))
                    {
                        unprocessedStartDates.Remove(nextTokenString);
                        Console.Out.WriteLine(p.Number + " " + p.PapalName);
                    }
                    else if (unprocessedEndDates.Contains(nextTokenString))
                    {
                        unprocessedEndDates.Remove(nextTokenString);
                        Console.Out.WriteLine(p.Number + " " + p.PapalName);
                    }
                }
                List<List<PapalDate>> startDates = GetPapalDates(nextTokenString, tokens, rawInput, true);
                ValidatePopeTokens(tokens, p.Number);
                pp.StartDates[0].AddRange(startDates[0]);
                pp.StartDates[1].AddRange(startDates[1]);
                pp.StartDates[2].AddRange(startDates[2]);

                if (string.IsNullOrEmpty(p.EndPontificate))
                {
                    if (iIndex != initialPopeList.Count - 1)
                    {
                        throw new InvalidOperationException();
                    }
                }
                else //past pontiff
                {
                    rawInput = p.EndPontificate;
                    tokens = LoadPopeTokens(rawInput);
                    nextTokenString = GetPopeTokenStringWithoutNumbers(tokens);
                    List<List<PapalDate>> endDate = GetPapalDates(nextTokenString, tokens, rawInput, false);
                    if (endDate.Count != 1) throw new InvalidOperationException();
                    ValidatePopeTokens(tokens, p.Number);
                    pp.EndDate.AddRange(endDate[0]);
                }

                //update the list of regnal numbers
                foreach (var next in PapalNames)
                {
                    string s = next.Key;
                    int iRegnalNumber = next.Value;
                    string nameToUse = s;
                    if (PopeStatic.PapalNameReplacements.TryGetValue(s, out string? sActualNameToUse))
                    {
                        nameToUse = sActualNameToUse;
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
                    pp.PapalNames.Add(new KeyValuePair<string, int>(s, iRegnalNumber));
                }
                ppList.Add(pp);
                iIndex++;
            }

            if (PopeStatic.UnusedTokenCombinations.Count > 0)
            {
                throw new InvalidOperationException();
            }

            //validate regnal names and numbers
            foreach (KeyValuePair<string, List<int>> entry in regnalNamesAndNumbers)
            {
                string sName = entry.Key;
                if (PopeStatic.PapalNameReplacementsReverse.TryGetValue(sName, out string? sReplacement))
                {
                    sName = sReplacement;
                }
                List<int> numbers = entry.Value;
                numbers.Sort();
                int lowest = numbers[0];
                if (lowest != 1)
                    throw new InvalidOperationException();
                PopeStatic.MissingRegnalNumbersByRegnalName.TryGetValue(sName, out List<int>? missingNumbers);
                int expectedHighest = numbers.Count;
                if (missingNumbers?.Count > 0)
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
            return ppList;
        }

        private static void ValidatePopeTokens(List<PopeToken> tokens, int popeNumber)
        {
            foreach (PopeToken nextToken in tokens)
            {
                switch (nextToken.TokenType)
                {
                    case PopeTokenType.ArabicNumber:
                        if (!nextToken.Number.HasValue) throw new InvalidOperationException();
                        if (!nextToken.DateType.HasValue) throw new InvalidOperationException();
                        if (nextToken.DateType.Value == DateTypes.Day)
                        {
                            if (nextToken.Number.Value < 1 || nextToken.Number.Value > 31) throw new InvalidOperationException();
                        }
                        else if (nextToken.DateType.Value == DateTypes.Year)
                        {
                            if (popeNumber > 1 && nextToken.Number < 30) 
                                throw new InvalidOperationException();
                        }
                        else
                        {
                            throw new InvalidOperationException();
                        }
                        break;
                    case PopeTokenType.RomanNumeral:
                        if (!nextToken.Number.HasValue) throw new InvalidOperationException();
                        if (!nextToken.DateType.HasValue) throw new InvalidOperationException();
                        if (nextToken.DateType != DateTypes.Month) throw new InvalidOperationException();
                        if (nextToken.Number.Value < 0 || nextToken.Number.Value > 12) throw new InvalidOperationException();
                        break;
                    case PopeTokenType.Comma:
                    case PopeTokenType.Dash:
                    case PopeTokenType.Or:
                    case PopeTokenType.Period:
                        if (nextToken.Number.HasValue) throw new InvalidOperationException();
                        if (nextToken.DateType.HasValue) throw new InvalidOperationException();
                        break;
                }
            }
        }

        private static List<List<PapalDate>> GetPapalDates(string input, List<PopeToken> tokens, string rawInput, bool forStart)
        {
            if (!ValidTokenCombinations.Contains(input))
            {
                throw new InvalidOperationException();
            }
            List<List<PapalDate>> theDates = new List<List<PapalDate>>();
            switch (input)
            {
                case "0":
                    tokens[0].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[0].Number!.Value, null, null)
                        });
                    break;
                case "...0":
                    tokens[3].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[3].Number!.Value, null, null)
                        });
                    break;
                case "0o0":
                    tokens[0].DateType = DateTypes.Year;
                    tokens[2].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[0].Number!.Value, null, null),
                            new PapalDate(tokens[2].Number!.Value, null, null)
                        });
                    break;
                case "...IoI.0":
                    tokens[7].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[7].Number!.Value, tokens[3].Number!.Value, null),
                            new PapalDate(tokens[7].Number!.Value, tokens[5].Number!.Value, null)
                        });
                    break;
                case "0.I.0":
                    tokens[0].DateType = DateTypes.Day;
                    tokens[4].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[4].Number!.Value, tokens[2].Number!.Value, tokens[0].Number!.Value)
                        });
                    break;
                case "0o0o0.I.0":
                    tokens[0].DateType = DateTypes.Day;
                    tokens[2].DateType = DateTypes.Day;
                    tokens[4].DateType = DateTypes.Day;
                    tokens[8].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[8].Number!.Value, tokens[6].Number!.Value, tokens[0].Number!.Value),
                            new PapalDate(tokens[8].Number!.Value, tokens[6].Number!.Value, tokens[2].Number!.Value),
                            new PapalDate(tokens[8].Number!.Value, tokens[6].Number!.Value, tokens[4].Number!.Value),
                        });
                    break;
                case "0o0.I.0":
                    tokens[0].DateType = DateTypes.Day;
                    tokens[2].DateType = DateTypes.Day;
                    tokens[6].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[6].Number!.Value, tokens[4].Number!.Value, tokens[0].Number!.Value),
                            new PapalDate(tokens[6].Number!.Value, tokens[4].Number!.Value, tokens[2].Number!.Value)
                        });
                    break;
                case "0,0.I.0":
                    tokens[0].DateType = DateTypes.Day;
                    tokens[2].DateType = DateTypes.Day;
                    tokens[6].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[6].Number!.Value, tokens[4].Number!.Value, tokens[0].Number!.Value)
                        });
                    theDates.Add(new List<PapalDate>()
                    {
                            new PapalDate(tokens[6].Number!.Value, tokens[4].Number!.Value, tokens[2].Number!.Value)
                    });
                    break;
                case "0.I.0,0.I.0":
                    tokens[0].DateType = DateTypes.Day;
                    tokens[6].DateType = DateTypes.Day;
                    tokens[4].DateType = DateTypes.Year;
                    tokens[10].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[4].Number!.Value, tokens[2].Number!.Value, tokens[0].Number!.Value),
                        });
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[10].Number!.Value, tokens[8].Number!.Value, tokens[6].Number!.Value),
                        });
                    break;
                case "...I,0.I.0":
                    tokens[5].DateType = DateTypes.Day;
                    tokens[9].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[9].Number!.Value, tokens[3].Number!.Value, null),
                        });
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[9].Number!.Value, tokens[7].Number!.Value, tokens[5].Number!.Value),
                        });
                    break;
                case "...I.0,0.I.0":
                    tokens[5].DateType = DateTypes.Year;
                    tokens[7].DateType = DateTypes.Day;
                    tokens[11].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[5].Number!.Value, tokens[3].Number!.Value, null),
                        });
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[11].Number!.Value, tokens[9].Number!.Value, tokens[7].Number!.Value),
                        });
                    break;
                case "0.I,0.I.0":
                    tokens[0].DateType = DateTypes.Day;
                    tokens[4].DateType = DateTypes.Day;
                    tokens[8].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[8].Number!.Value, tokens[2].Number!.Value, tokens[0].Number!.Value),
                        });
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[8].Number!.Value, tokens[6].Number!.Value, tokens[4].Number!.Value),
                        });
                    break;
                case "...I.0":
                    tokens[5].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[5].Number!.Value, tokens[3].Number!.Value, null),
                        });
                    break;
                case "0.Io0.I.0":
                    tokens[0].DateType = DateTypes.Day;
                    tokens[4].DateType = DateTypes.Day;
                    tokens[8].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                        {
                            new PapalDate(tokens[8].Number!.Value, tokens[2].Number!.Value, tokens[0].Number!.Value),
                            new PapalDate(tokens[8].Number!.Value, tokens[6].Number!.Value, tokens[4].Number!.Value)
                        });
                    break;
                case "...I-I.0":
                    tokens[7].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                    {
                            new PapalDate(tokens[7].Number!.Value, tokens[3].Number!.Value, null),
                            new PapalDate(tokens[7].Number!.Value, tokens[5].Number!.Value, null)
                    });
                    break;
                case "...I.0oI.0":
                    tokens[5].DateType = DateTypes.Year;
                    tokens[9].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                    {
                            new PapalDate(tokens[5].Number!.Value, tokens[3].Number!.Value, null),
                            new PapalDate(tokens[9].Number!.Value, tokens[7].Number!.Value, null)
                    });
                    break;
                case "..I.0oI.0":
                    tokens[4].DateType = DateTypes.Year;
                    tokens[8].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                    {
                            new PapalDate(tokens[4].Number!.Value, tokens[2].Number!.Value, null),
                            new PapalDate(tokens[8].Number!.Value, tokens[6].Number!.Value, null)
                    });
                    break;
                case "...IoIoI.0":
                    tokens[9].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                    {
                            new PapalDate(tokens[9].Number!.Value, tokens[3].Number!.Value, null),
                            new PapalDate(tokens[9].Number!.Value, tokens[5].Number!.Value, null),
                            new PapalDate(tokens[9].Number!.Value, tokens[7].Number!.Value, null)
                    });
                    break;
                case "0.I,...I.0":
                    tokens[0].DateType = DateTypes.Day;
                    tokens[9].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                    {
                        new PapalDate(tokens[9].Number!.Value, tokens[2].Number!.Value, tokens[0].Number!.Value),
                    });
                    theDates.Add(new List<PapalDate>()
                    {
                        new PapalDate(tokens[9].Number!.Value, tokens[7].Number!.Value, null),
                    });
                    break;
                case "0.I.0o0":
                    tokens[0].DateType = DateTypes.Day;
                    tokens[4].DateType = DateTypes.Year;
                    tokens[6].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                    {
                        new PapalDate(tokens[4].Number!.Value, tokens[2].Number!.Value, tokens[0].Number!.Value),
                        new PapalDate(tokens[6].Number!.Value, tokens[2].Number!.Value, tokens[0].Number!.Value),
                    });
                    break;
                case "0,0,0.I.0":
                    tokens[0].DateType = DateTypes.Day;
                    tokens[2].DateType = DateTypes.Day;
                    tokens[4].DateType = DateTypes.Day;
                    tokens[8].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                    {
                        new PapalDate(tokens[8].Number!.Value, tokens[6].Number!.Value, tokens[0].Number!.Value),
                    });
                    theDates.Add(new List<PapalDate>()
                    {
                        new PapalDate(tokens[8].Number!.Value, tokens[6].Number!.Value, tokens[2].Number!.Value),
                    });
                    theDates.Add(new List<PapalDate>()
                    {
                        new PapalDate(tokens[8].Number!.Value, tokens[6].Number!.Value, tokens[4].Number!.Value),
                    });
                    break;
                case "0.I,0,0.I.0":
                    tokens[0].DateType = DateTypes.Day;
                    tokens[6].DateType = DateTypes.Day;
                    tokens[4].DateType = DateTypes.Day;
                    tokens[10].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                    {
                        new PapalDate(tokens[10].Number!.Value, tokens[2].Number!.Value, tokens[0].Number!.Value),
                    });
                    theDates.Add(new List<PapalDate>()
                    {
                        new PapalDate(tokens[10].Number!.Value, tokens[8].Number!.Value, tokens[4].Number!.Value),
                    });
                    theDates.Add(new List<PapalDate>()
                    {
                        new PapalDate(tokens[10].Number!.Value, tokens[8].Number!.Value, tokens[6].Number!.Value),
                    });
                    break;
                case "0,0.I,0.I.0":
                    tokens[0].DateType = DateTypes.Day;
                    tokens[2].DateType = DateTypes.Day;
                    tokens[6].DateType = DateTypes.Day;
                    tokens[10].DateType = DateTypes.Year;
                    theDates.Add(new List<PapalDate>()
                    {
                        new PapalDate(tokens[10].Number!.Value, tokens[4].Number!.Value, tokens[0].Number!.Value),
                    });
                    theDates.Add(new List<PapalDate>()
                    {
                        new PapalDate(tokens[10].Number!.Value, tokens[4].Number!.Value, tokens[2].Number!.Value),
                    });
                    theDates.Add(new List<PapalDate>()
                    {
                        new PapalDate(tokens[10].Number!.Value, tokens[8].Number!.Value, tokens[6].Number!.Value),
                    });
                    break;
                default:
                    throw new InvalidOperationException();
            }

            if (PopeStatic.UnusedTokenCombinations.Contains(input))
            {
                PopeStatic.UnusedTokenCombinations.Remove(input);
            }

            ///add blank date lists at the end if there are less than three dates
            if (forStart)
            {
                for (int i = theDates.Count; i < 3; i++)
                {
                    theDates.Add(new List<PapalDate>());
                }
            }
            return theDates;
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
                    case PopeTokenType.Dash:
                        c = '-';
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
                if (next == '-' || next == ' ' || next == ',' || next == '.' || next == 'o')
                {
                    if (currentTokenType == PopeTokenType.ArabicNumber)
                        ret.Add(new PopeToken(PopeTokenType.ArabicNumber, null, int.Parse(currentNumber)));
                    else if (currentTokenType == PopeTokenType.RomanNumeral)
                        ret.Add(new PopeToken(PopeTokenType.RomanNumeral, DateTypes.Month, Common.RomanNumeralToInteger(currentNumber)));
                    currentTokenType = null;
                    currentNumber = string.Empty;
                    PopeTokenType? ptt = null;
                    if (next == '-')
                        ptt = PopeTokenType.Dash;
                    else if (next == ',')
                        ptt = PopeTokenType.Comma;
                    else if (next == '.')
                        ptt = PopeTokenType.Period;
                    else if (next == 'o')
                        ptt = PopeTokenType.Or;
                    else if (next != ' ')
                        throw new InvalidOperationException();
                    if (next != ' ')
                    {
                        ret.Add(new PopeToken(ptt!.Value, null, null));
                    }
                }
                else if (next == '0' ||
                    next == '1' ||
                    next == '2' ||
                    next == '3' ||
                    next == '4' ||
                    next == '5' ||
                    next == '6' ||
                    next == '7' ||
                    next == '8' ||
                    next == '9')
                {
                    if (currentTokenType == PopeTokenType.RomanNumeral) throw new InvalidOperationException();
                    currentNumber += next;
                    currentTokenType = PopeTokenType.ArabicNumber;
                }
                else if (next == 'I' || next == 'V' || next == 'X')
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
            ret.Add(new PopeToken(PopeTokenType.ArabicNumber, null, int.Parse(currentNumber)));
            return ret;
        }

        /// <summary>
        /// applies initial transformations to the pope
        /// </summary>
        /// <param name="p">pope</param>
        private static void ApplyInitialTransformations(Pope p)
        {
            if (p.Number == 1)
            {
                if (string.IsNullOrEmpty(p.BeginningPontificate))
                {
                    p.BeginningPontificate = "30" + OR_TOKEN_WITH_SPACES_SINGLE_LETTER + "33";
                }
                if (string.IsNullOrEmpty(p.SecularName))
                {
                    p.SecularName = "Simon or Simeon";
                }
            }
            string sBegin = p.BeginningPontificate;
            if (PopeStatic.DateReplacements.TryGetValue(sBegin, out string? sNewValue))
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
            HashSet<char> usedChars = new HashSet<char>();
            List<Pope> popeList = new List<Pope>();
            foreach (Pope p in Common.ProcessCSV<Pope, PopeMap>(inputFilePath))
            {
                ApplyInitialTransformations(p);
                popeList.Add(p);
                foreach (char c in p.BeginningPontificate)
                {
                    if (!usedChars.Contains(c)) usedChars.Add(c);
                }
                if (!string.IsNullOrEmpty(p.EndPontificate))
                {
                    foreach (char c in p.EndPontificate)
                    {
                        if (!usedChars.Contains(c)) usedChars.Add(c);
                    }
                }
            }
            //determine what characters are actually used (not part of mainline functionality)
            List<char> usedCharsList = new List<char>(usedChars);
            usedCharsList.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (char c in usedCharsList)
            {
                sb.Append(c);
            }
            string allUsedChars = sb.ToString();
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

        public static List<PrecisePope> LoadPopes(string inputFilePath)
        {
            List<PrecisePope> precisePopes = new List<PrecisePope>();
            List<Pope> popeList = GetInitialPopeList(inputFilePath);
            for (int i = 0; i < popeList.Count; i++)
            {
                Pope p = popeList[i];
                CleanPope cp = new CleanPope();
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
                PrecisePope pp = new PrecisePope(cp, p.Number, p.SecularName, p.Birthplace, p.Century);
                precisePopes.Add(pp);
            }
            return precisePopes;
        }

        private static void SavePopesToFile(string outputFilePath, List<PrecisePope> pps, Dictionary<string, List<int>> regnalNamesAndNumbers)
        {
            bool foundPopeWithoutEndDate = false;
            XmlDocument doc = new XmlDocument();
            XmlElement mainElement = doc.CreateElement("popes");
            doc.AppendChild(mainElement);
            foreach (var p in pps)
            {
                XmlElement popeElement = doc.CreateElement("p");
                popeElement.SetAttribute("number", p.Number.ToString());
                popeElement.SetAttribute("century", p.Century.ToString());
                if (!string.IsNullOrEmpty(p.SecularName))
                {
                    popeElement.SetAttribute("secularname", p.SecularName);
                }
                if (!string.IsNullOrEmpty(p.Birthplace))
                {
                    popeElement.SetAttribute("birthplace", p.Birthplace);
                }

                foreach (var nextPapalName in p.PapalNames)
                {
                    XmlElement papalNameElement = doc.CreateElement("Name");
                    papalNameElement.SetAttribute("n", nextPapalName.Key);
                    papalNameElement.SetAttribute("r", nextPapalName.Value.ToString());

                    string sNameToCheck = nextPapalName.Key;
                    if (PopeStatic.PapalNameReplacements.TryGetValue(sNameToCheck, out string? actualName))
                    {
                        sNameToCheck = actualName;
                    }
                    if (!regnalNamesAndNumbers.ContainsKey(sNameToCheck))
                    {
                        throw new InvalidOperationException();
                    }
                    if (regnalNamesAndNumbers[sNameToCheck].Count == 1)
                    {
                        papalNameElement.SetAttribute("only", "true");
                    }
                    popeElement.AppendChild(papalNameElement);
                }

                if (p.StartDates[0].Count == 0) throw new InvalidOperationException();
                if (p.StartDates[2].Count > 0 && p.StartDates[1].Count == 0) throw new InvalidOperationException();

                XmlElement startDate = doc.CreateElement("StartDate");
                if (p.StartDates[0].Count == 1)
                {
                    startDate.SetAttribute("d", GetDateElementText(p.StartDates[0][0]));
                }
                else if (p.StartDates[0].Count == 2)
                {
                    startDate.SetAttribute("d1", GetDateElementText(p.StartDates[0][0]));
                    startDate.SetAttribute("d2", GetDateElementText(p.StartDates[0][1]));
                }
                else if (p.StartDates[0].Count == 3)
                {
                    startDate.SetAttribute("d1", GetDateElementText(p.StartDates[0][0]));
                    startDate.SetAttribute("d2", GetDateElementText(p.StartDates[0][1]));
                    startDate.SetAttribute("d3", GetDateElementText(p.StartDates[0][2]));
                }
                else
                {
                    throw new InvalidOperationException();
                }
                popeElement.AppendChild(startDate);

                if (p.StartDates[1].Count > 0)
                {
                    startDate = doc.CreateElement("StartDate");
                    if (p.StartDates[1].Count == 1)
                    {
                        startDate.SetAttribute("d", GetDateElementText(p.StartDates[1][0]));
                    }
                    else if (p.StartDates[1].Count == 2)
                    {
                        startDate.SetAttribute("d1", GetDateElementText(p.StartDates[1][0]));
                        startDate.SetAttribute("d2", GetDateElementText(p.StartDates[1][1]));
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                    popeElement.AppendChild(startDate);
                }
                if (p.StartDates[2].Count > 0)
                {
                    startDate = doc.CreateElement("StartDate");
                    if (p.StartDates[2].Count == 1)
                    {
                        startDate.SetAttribute("d", GetDateElementText(p.StartDates[2][0]));
                    }
                    else if (p.StartDates[2].Count == 2)
                    {
                        startDate.SetAttribute("d1", GetDateElementText(p.StartDates[2][0]));
                        startDate.SetAttribute("d2", GetDateElementText(p.StartDates[2][1]));
                        startDate.SetAttribute("d3", GetDateElementText(p.StartDates[2][2]));
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
                ret = dt.YearA.ToString().PadLeft(4, '0');
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
                ret.Add(new PapalDate(900, null, 1, 5, null, null, null, null));
            }
            else if (date == "..XII.897" + OR_TOKEN_WITH_SPACES_SINGLE_LETTER + "I.898")
            {
                ret.Add(new PapalDate(897, 898, 12, 1, null, null, null, null));
            }
            else if (date == "... II-V.824")
            {
                ret.Add(new PapalDate(824, null, 2, 5, null, null, null, null));
            }
            else if (date == "15 o 22 o 29.XII.384")
            {
                ret.Add(new PapalDate(384, null, 12, null, null, 15, 22, 29));
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
                        yearDates.Add(new PapalDate(year, null, null, null, null, null, null, null));
                    }
                    else
                    {
                        string remainder = nextYear.Substring(0, nextYear.Length - year.ToString().Length - 1);
                        if (remainder == "...")
                        {
                            yearDates.Add(new PapalDate(year, null, null, null, null, null, null, null));
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
                                yearDates.Insert(0, new PapalDate(year, null, monthA, monthB, null, dayA, dayB, null));
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
            if (date.Contains(OR_TOKEN_WITH_SPACES_SINGLE_LETTER))
            {
                string[] vals = date.Split(OR_TOKEN_WITH_SPACES_SINGLE_LETTER);
                iYearA = int.Parse(vals[0]);
                iYearB = int.Parse(vals[1]);
            }
            else
            {
                iYearA = int.Parse(date);
                iYearB = null;
            }
            return new PapalDate(iYearA, iYearB, null, null, null, null, null, null);
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
            else if (date == "... XII.928" + OR_TOKEN_WITH_SPACES_SINGLE_LETTER + "I.929")
            {
                ret = new PapalDate(928, 929, 12, 1, null, null, null, null);
            }
            else if (date == "...XII.897" + OR_TOKEN_WITH_SPACES_SINGLE_LETTER + "I.898")
            {
                ret = new PapalDate(897, 898, 12, 1, null, null, null, null);
            }
            else if (date == "...I-V.900")
            {
                ret = new PapalDate(900, null, 1, 5, null, null, null, null);
            }
            else if (date == "... II-V.824")
            {
                ret = new PapalDate(824, null, 2, 5, null, null, null, null);
            }
            else if (date == "25.II" + OR_TOKEN_WITH_SPACES_SINGLE_LETTER + "1.III.492")
            {
                ret = new PapalDate(492, null, 2, 3, null, 25, 1, null);
            }
            else if (date == "... VI" + OR_TOKEN_WITH_SPACES_SINGLE_LETTER + "VIII" + OR_TOKEN_WITH_SPACES_SINGLE_LETTER + "X.913")
            {
                ret = new PapalDate(913, null, 6, 8, 10, null, null, null);
            }
            else
            {
                string[] end = date.Split(".");
                if (end.Length < 3) throw new InvalidOperationException();
                string yearValue = end[end.Length - 1];
                int yearA;
                int? yearB;
                if (yearValue == "964" + OR_TOKEN_WITH_SPACES_SINGLE_LETTER + "965")
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
                    if (sMonth.Contains(OR_TOKEN_WITH_SPACES_SINGLE_LETTER))
                    {
                        string[] vals = sMonth.Split(OR_TOKEN_WITH_SPACES_SINGLE_LETTER);
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
                else if (remaindertext.Contains(OR_TOKEN_WITH_SPACES_SINGLE_LETTER)) //two possible dates
                {
                    string[] vals = remaindertext.Split(OR_TOKEN_WITH_SPACES_SINGLE_LETTER);
                    if (vals.Length != 2) throw new InvalidOperationException();
                    dayA = int.Parse(vals[0]);
                    dayB = int.Parse(vals[1]);
                }
                else //simple day
                {
                    if (remaindertext == ".")
                    {
                        dayA = null;
                    }
                    else
                    {
                        dayA = int.Parse(remaindertext);
                    }
                    dayB = null;
                }
                ret = new PapalDate(yearA, yearB, monthA, monthB, null, dayA, dayB, null);
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
        /// simple constructor with just one date point
        /// </summary>
        /// <param name="Year">year</param>
        /// <param name="Month">month</param>
        /// <param name="Day">date</param>
        public PapalDate(int Year, int? Month, int? Day) : this(Year, null, Month, null, null, Day, null, null)
        {
        }

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
        /// <param name="DayC">day c</param>
        public PapalDate(int YearA, int? YearB, int? MonthA, int? MonthB, int? MonthC, int? DayA, int? DayB, int? DayC)
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
            this.DayC = DayC;
        }

        public bool IsValidDate()
        {
            return YearA >= 30;
        }

        public bool IsSimpleDate()
        {
            return !YearB.HasValue && !MonthB.HasValue && !MonthC.HasValue && !DayB.HasValue;
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
        /// day C
        /// </summary>
        public int? DayC { get; set; }
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
        /// constructor
        /// </summary>
        /// <param name="Number">pope number</param>
        /// <param name="SecularName">secular name</param>
        /// <param name="Birthplace">birthplace</param>
        /// <param name="Century">century</param>
        public PrecisePope(int Number, string SecularName, string Birthplace, int Century)
        {
            StartDates = new List<List<PapalDate>>()
            {
                new List<PapalDate>(),
                new List<PapalDate>(),
                new List<PapalDate>()
            };
            EndDate = new List<PapalDate>();
            this.PapalNames = new List<KeyValuePair<string, int>>();
            this.Number = Number;
            this.SecularName = SecularName;
            this.Birthplace = Birthplace;
            this.Century = Century;
        }

        /// <summary>
        /// more precise pope information
        /// </summary>
        /// <param name="CleanPope">clean pope information</param>
        /// <param name="Number">pope number</param>
        /// <param name="SecularName">secular name</param>
        /// <param name="Birthplace">birthplace</param>
        /// <param name="Century">century</param>
        public PrecisePope(CleanPope CleanPope, int Number, string SecularName, string Birthplace, int Century) : this(Number, SecularName, Birthplace, Century)
        {
            this.Number = Number;
            this.SecularName = SecularName;
            this.Birthplace = Birthplace;
            this.Century = Century;

            if (CleanPope.EndDate != null)
            {
                GenerateSeparatePapalDates(CleanPope.EndDate, EndDate);
            }

            if (CleanPope.StartDate1 == null)
                throw new InvalidOperationException();

            List<PapalDate> StartDate1 = new List<PapalDate>();
            List<PapalDate> StartDate2 = new List<PapalDate>();
            List<PapalDate> StartDate3 = new List<PapalDate>();

            GenerateSeparatePapalDates(CleanPope.StartDate1, StartDate1);
            if (StartDate1.Count > 0) StartDates[0] = StartDate1;

            if (CleanPope.StartDate2 != null)
            {
                GenerateSeparatePapalDates(CleanPope.StartDate2, StartDate2);
                if (StartDate2.Count > 0) StartDates[1] = StartDate2;

                if (CleanPope.StartDate3 != null)
                {
                    GenerateSeparatePapalDates(CleanPope.StartDate3, StartDate3);
                    if (StartDate3.Count > 0) StartDates[2] = StartDate3;
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

            if (Input.DayC.HasValue) //only one example in the data set
            {
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayA, null, null));
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayB, null, null));
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayC, null, null));
                if (Input.YearB.HasValue) throw new InvalidOperationException();
                if (Input.MonthB.HasValue) throw new InvalidOperationException();
                if (Input.MonthC.HasValue) throw new InvalidOperationException();
            }
            else if (Input.DayB.HasValue)
            {
                if (Input.MonthB.HasValue) //ambiguous days in different months
                {
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayA, null, null));
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthB, null, null, Input.DayB, null, null));
                    if (Input.YearB.HasValue) throw new InvalidOperationException();
                    if (Input.MonthC.HasValue) throw new InvalidOperationException();
                    if (!Input.DayA.HasValue) throw new InvalidOperationException();
                }
                else //ambiguous days in the same month
                {
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayA, null, null));
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayB, null, null));
                    if (Input.YearB.HasValue) throw new InvalidOperationException();
                    if (!Input.MonthA.HasValue) throw new InvalidOperationException();
                    if (Input.MonthB.HasValue) throw new InvalidOperationException();
                    if (Input.MonthC.HasValue) throw new InvalidOperationException();
                    if (!Input.DayA.HasValue) throw new InvalidOperationException();
                }
            }
            else if (Input.MonthC.HasValue) //only one example in the data set
            {
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, null, null, null));
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthB, null, null, null, null, null));
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthC, null, null, null, null, null));
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
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, null, null, null));
                    ret.Add(new PapalDate(Input.YearB.Value, null, Input.MonthB, null, null, null, null, null));
                    if (!Input.MonthA.HasValue) throw new InvalidOperationException();
                    if (Input.DayA.HasValue) throw new InvalidOperationException();
                    if (Input.DayB.HasValue) throw new InvalidOperationException();
                }
                else
                {
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, null, null, null));
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthB, null, null, null, null, null));
                    if (!Input.MonthA.HasValue) throw new InvalidOperationException();
                    if (Input.DayA.HasValue) throw new InvalidOperationException();
                    if (Input.DayB.HasValue) throw new InvalidOperationException();
                }
            }
            else if (Input.YearB.HasValue)
            {
                if (Input.DayB.HasValue) //specific days for different years
                {
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayA, null, null));
                    ret.Add(new PapalDate(Input.YearB.Value, null, Input.MonthB, null, null, Input.DayB, null, null));
                    if (!Input.MonthA.HasValue) throw new InvalidOperationException();
                    if (!Input.DayA.HasValue) throw new InvalidOperationException();
                    if (!Input.DayB.HasValue) throw new InvalidOperationException();
                }
                else if (Input.DayA.HasValue) //specific day+month, but unclear what year
                {
                    ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayA, null, null));
                    ret.Add(new PapalDate(Input.YearB.Value, null, Input.MonthA, null, null, Input.DayA, null, null));
                    if (!Input.MonthA.HasValue) throw new InvalidOperationException();
                }
                else if (Input.YearB.HasValue) //two possible years
                {
                    ret.Add(new PapalDate(Input.YearA, null, null, null, null, null, null, null));
                    ret.Add(new PapalDate(Input.YearB.Value, null, null, null, null, null, null, null));
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
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, Input.DayA, null, null));
            }
            else if (Input.MonthA.HasValue)
            {
                ret.Add(new PapalDate(Input.YearA, null, Input.MonthA, null, null, null, null, null));
            }
            else //only the year
            {
                ret.Add(new PapalDate(Input.YearA, null, null, null, null, null, null, null));
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
        /// start dates
        /// </summary>
        public List<List<PapalDate>> StartDates { get; set; }

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
        public CleanPope()
        {
        }

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

    public enum DateTypes
    {
        Year,
        Month,
        Day,
    }

    /// <summary>
    /// pope token
    /// </summary>
    public class PopeToken
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (TokenType)
            {
                case PopeTokenType.ArabicNumber:
                    if (DateType == DateTypes.Day || DateType == DateTypes.Year)
                    {
                        string sChar = DateType == DateTypes.Day ? "d" : "y";
                        sb.Append($"({sChar}={Number!.Value})");
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                    break;
                case PopeTokenType.RomanNumeral:
                    if (DateType == DateTypes.Month)
                    {
                        sb.Append($"(m={Number!.Value})");
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                    break;
                case PopeTokenType.Comma:
                    sb.Append(",");
                    break;
                case PopeTokenType.Dash:
                    sb.Append("-");
                    break;
                case PopeTokenType.Or:
                    sb.Append("o");
                    break;
                case PopeTokenType.Period:
                    sb.Append(".");
                    break;
            }
            return sb.ToString();
        }

        /// <summary>
        /// construtor
        /// </summary>
        /// <param name="TokenType">token type</param>
        /// <param name="DateType">date type</param>
        /// <param name="Number">number</param>
        public PopeToken(PopeTokenType TokenType, DateTypes? DateType, int? Number)
        {
            this.TokenType = TokenType;
            this.DateType = DateType;
            this.Number = Number;
        }

        /// <summary>
        /// pope token type
        /// </summary>
        public PopeTokenType TokenType { get; set; }

        /// <summary>
        /// date type
        /// </summary>
        public DateTypes? DateType { get; set; }

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
        /// dash
        /// </summary>
        Dash,
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



