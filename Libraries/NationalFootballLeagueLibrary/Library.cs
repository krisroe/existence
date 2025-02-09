using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using CsvHelper.TypeConversion;
using HtmlAgilityPack;
using LibraryShared;
using System.Globalization;
using System.Xml;

namespace NationalFootballLeagueLibrary
{
    public static class Library
    {
        public const int MAXIMUM_SCORE = 73;
        public const int STARTING_YEAR = 1920;

        public static int RunMain(string[] args)
        {
            if (args.Length < 2 || string.IsNullOrEmpty(args[0]) || string.IsNullOrEmpty(args[1]))
            {
                Console.WriteLine("No command line arguments given");
                return Common.READ_NEWLINE;
            }
            string operation = args[0];
            string filePath1 = args[1];
            string filePath2 = args.Length > 2 ? args[2] : string.Empty;
            if (operation == "fromweb")
            {
                WriteGameInfosToCSV(ProcessAllGameScoresFromWeb(Common.HttpClient), filePath1);
            }
            else if (operation == "fromcsv") //load from all games csv file
            {
                List<GameInfo> allGameInfos = new List<GameInfo>();
                allGameInfos.AddRange(ProcessAllGameInfosFromCSV(filePath1));
                //ProcessScorigamiCountsBySeason(allGameInfos, false);
                //allGameInfos.Sort(new GameInfoComparer(GameInfoSortType.ChronologicalWithinCalendarYear));
                //WriteGameInfosToCSV(allGameInfos, filePath2);
                bool includeAAFC = true;
                SaveToXmlFile(ProcessScorigamiInfo(ProcessAllGameInfosFromCSV(filePath1), includeAAFC), filePath2);
            }
            else if (operation == "reprocessxml") //load from XML file
            {
                SaveToXmlFile(GetFinalScoreInfosFromXML(filePath1), filePath1);
            }
            else if (operation == "loadxml")
            {
                GetProbabilitiesForAllScores(GetFinalScoreInfosFromXML(filePath1), true);
            }
            else
            {
                throw new InvalidOperationException();
            }
            Console.Out.WriteLine("Finished! Press Enter to Continue.");
            return Common.READ_NEWLINE;
        }

        /// <summary>
        /// processes scorigami information from games
        /// </summary>
        /// <param name="gameInfos">games, assumed to be in chronological order</param>
        /// <param name="includeAAFC">whether to include AAFC games</param>
        /// <returns>final score info objects</returns>
        private static List<FinalScoreInfo> ProcessScorigamiInfo(IEnumerable<GameInfo> gameInfos, bool includeAAFC)
        {
            FinalScoreInfo[,] scorigamis = new FinalScoreInfo[MAXIMUM_SCORE + 1, MAXIMUM_SCORE + 1];
            foreach (GameInfo gi in gameInfos)
            {
                if (gi.league == LeagueType.AAFC && !includeAAFC) continue;
                int iWinnerPts = gi.pts_win;
                int iLoserPts = gi.pts_loss;
                DateTime dtDateObject = gi.GetDateObject();
                FinalScoreInfo existingFSI = scorigamis[iWinnerPts, iLoserPts];
                bool isScorigami = existingFSI == null || existingFSI.LastDate == dtDateObject;
                string matchupString = GetMatchupString(gi.game_location, gi.winner, gi.loser, gi.pts_win, gi.pts_loss, gi.GetMatchupType());
                if (isScorigami)
                {
                    if (existingFSI == null)
                    {
                        existingFSI = new FinalScoreInfo(gi.pts_win.ToString().PadLeft(2, '0') + "-" + gi.pts_loss.ToString().PadLeft(2, '0'), 0, dtDateObject, dtDateObject);
                        scorigamis[iWinnerPts, iLoserPts] = existingFSI;
                    }
                    existingFSI.FirstDate = dtDateObject;
                    existingFSI.LastDate = dtDateObject;
                    existingFSI.FirstMatchups.Add(matchupString);
                }
                else
                {
                    if (existingFSI == null) throw new InvalidOperationException();
                    if (existingFSI.LastDate != dtDateObject)
                    {
                        existingFSI.LastMatchups.Clear();
                    }
                    existingFSI.LastMatchups.Add(matchupString);
                }
                existingFSI.Count++;
            }
            List<FinalScoreInfo> allFinalScores = new List<FinalScoreInfo>();
            for (int i = 0; i <= MAXIMUM_SCORE; i++)
            {
                for (int j = 0; j < MAXIMUM_SCORE; j++)
                {
                    FinalScoreInfo fsi = scorigamis[i, j];
                    if (fsi != null) allFinalScores.Add(fsi);
                }
            }
            allFinalScores.Sort(new FinalScoreInfoSorter(FinalScoreInfoSortType.ByScore));
            return allFinalScores;
        }

        /// <summary>
        /// process scorigami counts by season (useful for validating https://champsorchumps.us/summary/nfl/scorigamis-by-year)
        /// </summary>
        /// <param name="gameInfos">game information</param>
        /// <param name="includeAAFC">whether to include AAFC games (Champs or Chumps does not consider these games)</param>
        private static void ProcessScorigamiCountsBySeason(IEnumerable<GameInfo> gameInfos, bool includeAAFC)
        {
            int nowYear = DateTime.Now.Year;
            bool[,] scorigamis = new bool[MAXIMUM_SCORE+1, MAXIMUM_SCORE+1];
            int[] scorigamiCountsByYear = new int[nowYear - STARTING_YEAR + 1];
            foreach (GameInfo gi in gameInfos)
            {
                if (gi.league == LeagueType.AAFC && !includeAAFC) continue;
                int iWinnerPts = gi.pts_win;
                int iLoserPts = gi.pts_loss;
                if (!scorigamis[iWinnerPts, iLoserPts])
                {
                    scorigamis[iWinnerPts, iLoserPts] = true;
                    scorigamiCountsByYear[gi.GetSeasonStartingYear() - STARTING_YEAR]++;
                }
            }
            for (int i = 0; i < scorigamiCountsByYear.Length; i++)
            {
                Console.Out.WriteLine(i + STARTING_YEAR + ": " + scorigamiCountsByYear[i]);
            }
        }

        private static void WriteGameInfosToCSV(IEnumerable<GameInfo> gameInfos, string filePath)
        {
            if (File.Exists(filePath)) throw new InvalidOperationException();
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.Write("week_num,game_date,winner,loser,game_location,pts_win,pts_loss,league");
                foreach (GameInfo gi in gameInfos)
                {
                    sw.WriteLine();
                    sw.Write(gi.week_num);
                    sw.Write(",");
                    sw.Write(gi.game_date);
                    sw.Write(",");
                    sw.Write(gi.winner);
                    sw.Write(",");
                    sw.Write(gi.loser);
                    sw.Write(",");
                    sw.Write(gi.game_location);
                    sw.Write(",");
                    sw.Write(gi.pts_win);
                    sw.Write(",");
                    sw.Write(gi.pts_loss);
                    sw.Write(",");
                    if (gi.league != LeagueType.NFL)
                    {
                        sw.Write(gi.league.ToString());
                    }
                }
            }
        }

        private static void GetProbabilitiesForAllScores(IEnumerable<FinalScoreInfo> fsis, bool displayActualCounts)
        {
            int totalFinalScores = 0;
            int totalCount = 0;
            int[] buckets = new int[MAXIMUM_SCORE+1];
            FinalScoreInfo[,] finalScores = new FinalScoreInfo[MAXIMUM_SCORE + 1, MAXIMUM_SCORE + 1];

            foreach (FinalScoreInfo fsi in fsis)
            {
                string[] scores = fsi.Score.Split("-");
                if (scores.Length != 2) throw new InvalidOperationException();
                int iFirstScore = int.Parse(scores[0]);
                int iSecondScore = int.Parse(scores[1]);
                int iGameCount = fsi.Count;

                //count twice since there are two teams in a game
                totalCount += iGameCount;
                totalCount += iGameCount;
                buckets[iFirstScore] += iGameCount;
                buckets[iSecondScore] += iGameCount;

                finalScores[iFirstScore, iSecondScore] = fsi;
                totalFinalScores++;
            }

            // display actual counts for each score
            if (displayActualCounts)
            {
                Console.Out.WriteLine(totalFinalScores + " unique scores");
                for (int i = 0; i <= MAXIMUM_SCORE; i++)
                {
                    Console.Out.WriteLine(i + " points: " + buckets[i] + "/" + totalCount);
                }
            }

            //adjust to account for zeroes at 67/68/69 and 71 (1 point is left at zero). This means probabilities add up to slightly over 100%
            int d70Count = buckets[70];
            if (buckets[66] != d70Count) throw new InvalidOperationException();
            if (buckets[67] != 0) throw new InvalidOperationException();
            if (buckets[68] != 0) throw new InvalidOperationException();
            if (buckets[69] != 0) throw new InvalidOperationException();
            buckets[67] = d70Count;
            buckets[68] = d70Count;
            buckets[69] = d70Count;
            int d72Count = buckets[72];
            if (d72Count != buckets[73]) throw new InvalidOperationException();
            buckets[71] = d72Count;

            double dTotalExpectedCount = 0;
            double[,] expectedPercentage = new double[MAXIMUM_SCORE + 1, MAXIMUM_SCORE + 1];
            double[,] expectedCount = new double[MAXIMUM_SCORE + 1, MAXIMUM_SCORE + 1];
            
            for (int i = 0; i <= MAXIMUM_SCORE; i++)
            {
                double dPercentageWinner = (double)buckets[i] / totalCount;
                for (int j = i; j >= 0; j--)
                {
                    double dPercentageLoser = (double)buckets[j] / totalCount;
                    double dPercentageForCell;
                    if (i == j) //tie
                    {
                        dPercentageForCell = dPercentageLoser * dPercentageLoser;
                        
                    }
                    else //counts for double since either team could win
                    {
                        dPercentageForCell = dPercentageLoser * dPercentageWinner * 2;
                    }
                    dTotalExpectedCount += dPercentageForCell;
                    expectedPercentage[i, j] = dPercentageForCell;
                    expectedCount[i, j] = dPercentageForCell * totalCount;
                }
            }

            //print out expected number of games for that score
            double dScorigamiPercentage = 0;
            for (int i = 0; i <= MAXIMUM_SCORE; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (finalScores[i, j] == null)
                    {
                        double nextExpectedScorigamiPercentage = expectedPercentage[i, j];
                        dScorigamiPercentage += nextExpectedScorigamiPercentage;
                        Console.WriteLine("Scorigami Percentage 1/X " + i + "-" + j + ": " + ((double)1 / nextExpectedScorigamiPercentage).ToString("F4"));
                    }
                    //Console.WriteLine(i.ToString().PadLeft(2, '0') + "-" + j.ToString().PadLeft(2, '0') + ":" + expectedCount[i, j].ToString("F2"));
                }
            }
            Console.WriteLine("Overall Scorigami Percentage 1/X:" + ((double)1 / dScorigamiPercentage).ToString("F2"));
        }
        public static void SaveToXmlFile(IEnumerable<FinalScoreInfo> fsis, string filePath)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement top = doc.CreateElement("scorigamiinformation");
            doc.AppendChild(top);
            foreach (FinalScoreInfo fsi in fsis)
            {
                fsi.WriteToConsole();
                XmlElement nextScore = doc.CreateElement("score");
                nextScore.SetAttribute("score", fsi.Score);
                nextScore.SetAttribute("count", fsi.Count.ToString());
                nextScore.SetAttribute("firstdate", fsi.FirstDate.ToString("yyyy-MM-dd"));
                nextScore.SetAttribute("lastdate", fsi.LastDate.ToString("yyyy-MM-dd"));
                XmlElement matchup;

                //duplicate checking
                HashSet<string> matchups = new HashSet<string>();
                foreach (string nextMatchup in fsi.FirstMatchups)
                {
                    if (matchups.Contains(nextMatchup)) throw new InvalidOperationException();
                    matchups.Add(nextMatchup);
                }
                foreach (string nextMatchup in fsi.LastMatchups)
                {
                    if (matchups.Contains(nextMatchup)) throw new InvalidOperationException();
                    matchups.Add(nextMatchup);
                }

                int iFirstCount = fsi.FirstMatchups.Count;
                int iLastCount = fsi.LastMatchups.Count;

                if (iFirstCount + iLastCount == 1)
                {
                    matchup = doc.CreateElement("Only");
                    matchup.InnerText = matchups.First();
                    nextScore.AppendChild(matchup);
                }
                else //both first and last
                {
                    foreach (string nextMatchup in fsi.FirstMatchups)
                    {
                        matchup = doc.CreateElement("First");
                        matchup.InnerText = nextMatchup;
                        nextScore.AppendChild(matchup);
                    }
                    foreach (string nextMatchup in fsi.LastMatchups)
                    {
                        matchup = doc.CreateElement("Last");
                        matchup.InnerText = nextMatchup;
                        nextScore.AppendChild(matchup);
                    }
                }
                top.AppendChild(nextScore);
            }
            Common.WriteToFile(doc, filePath);
            Console.Out.WriteLine("Wrote game score info to " + filePath);
        }

        public static IEnumerable<FinalScoreInfo> GetFinalScoreInfosFromXML(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            foreach (XmlNode node in doc.DocumentElement!.ChildNodes)
            {
                if (node is XmlElement elem)
                {
                    string sScore = elem.GetAttribute("score");
                    int iCount = int.Parse(elem.GetAttribute("count"));
                    string firstdate = elem.GetAttribute("firstdate");
                    string lastdate = elem.GetAttribute("lastdate");
                    List<string> first = new List<string>();
                    List<string> last = new List<string>();
                    int exampleCount = 0;
                    bool isOnly = false;
                    foreach (XmlNode exampleNode in elem.ChildNodes)
                    {
                        if (exampleNode is XmlElement exampleelem)
                        {
                            string sText = exampleelem.InnerText;
                            if (exampleelem.Name == "Only")
                            {
                                first.Add(sText);
                                exampleCount++;
                                isOnly = true;
                            }
                            else if (exampleelem.Name == "First")
                            {
                                first.Add(sText);
                                exampleCount++;
                            }
                            else if (exampleelem.Name == "Last")
                            {
                                last.Add(sText);
                                exampleCount++;
                            }
                            else
                            {
                                throw new InvalidOperationException();
                            }
                        }
                    }
                    if (isOnly)
                    {
                        if (exampleCount != 1 || iCount != 1) 
                            throw new InvalidOperationException();
                    }
                    else //not is only
                    {
                        if (exampleCount < 2 || iCount < 2)
                            throw new InvalidOperationException();
                    }
                    DateTime dtFirst = DateTime.ParseExact(firstdate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    DateTime dtLast = DateTime.ParseExact(lastdate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    FinalScoreInfo fsi = new FinalScoreInfo(sScore, iCount, dtFirst, dtLast);
                    fsi.FirstMatchups.AddRange(first);
                    fsi.LastMatchups.AddRange(last);
                    yield return fsi;
                }
            }
        }

        /// <summary>
        /// retrieves the first and last game with the game score
        /// </summary>
        /// <param name="gsi">game score information</param>
        /// <param name="hc">http client</param>
        /// <param name="keepTrackOfAllGames">list for keeping track of all games</param>
        /// <exception cref="InvalidOperationException"></exception>
        public static FinalScoreInfo GetFirstAndLastGameScoreInfo(GameScoreInfo gsi, HttpClient hc, List<GameInfo> keepTrackOfAllGames)
        {
            string sURL = $"https://www.pro-football-reference.com/boxscores/game_scores_find.cgi?pts_win={gsi.PtsW}&pts_lose={gsi.PtsL}";
            HtmlDocument mainDoc = GetHtmlDocumentFromURL(sURL, hc);
            HtmlNode foundTable = GetRankerTable(mainDoc);
            int iRowIndex = 0;
            List<GameInfo> firstGames = new List<GameInfo>();
            List<GameInfo> lastGames = new List<GameInfo>();
            foreach (HtmlNode nextRow in foundTable.SelectNodes("//tr"))
            {
                iRowIndex++;
                if (iRowIndex > 1)
                {
                    GameInfo nextGame = GameInfo.GetEmptyObject(gsi.PtsW, gsi.PtsL);
                    foreach (HtmlNode nextCol in nextRow.ChildNodes.AsEnumerable())
                    {
                        string sColName = nextCol.Name;
                        bool isheader = sColName == "th";
                        bool isdata = sColName == "td";
                        if (isheader || isdata)
                        {
                            string dataStat = nextCol.GetAttributeValue("data-stat", "N/A");
                            string sValue = nextCol.InnerText;
                            switch (dataStat)
                            {
                                case "ranker":
                                    if (!int.TryParse(sValue, out _)) 
                                        throw new InvalidOperationException();
                                    break;
                                case "to_lose":
                                case "to_win":
                                case "yards_lose":
                                case "yards_win":
                                    if (!string.IsNullOrEmpty(sValue) && //some games are missing these statistics
                                        !int.TryParse(sValue, out _))
                                    {
                                        throw new InvalidOperationException();
                                    }
                                    break;
                                case "game_day_of_week":
                                    if (sValue != "Sun" &&
                                        sValue != "Mon" &&
                                        sValue != "Tue" &&
                                        sValue != "Wed" &&
                                        sValue != "Thu" &&
                                        sValue != "Fri" &&
                                        sValue != "Sat")
                                    {
                                        throw new InvalidOperationException();
                                    }
                                    break;
                                case "boxscore_word":
                                    if (sValue != "boxscore") throw new InvalidOperationException();
                                    break;
                                case "week_num":
                                    nextGame.week_num = sValue;
                                    break;
                                case "game_date":
                                    nextGame.game_date = sValue;
                                    break;
                                case "winner":
                                    nextGame.winner = sValue;
                                    break;
                                case "game_location":
                                    if (sValue != string.Empty && sValue != "@" && sValue != "N")
                                        throw new InvalidOperationException();
                                    nextGame.game_location = sValue == string.Empty ? " " : sValue;
                                    break;
                                case "loser":
                                    nextGame.loser = sValue;
                                    break;
                                case "game_outcome": //otherwise ignored, but validate it matches the game score info
                                    string expected = gsi.PtsL == gsi.PtsW ? "T" : "W";
                                    if (expected != sValue) throw new InvalidOperationException();
                                    break;
                                case "pts_win":
                                    if (gsi.PtsW.ToString() != sValue) throw new InvalidOperationException();
                                    break;
                                case "pts_lose":
                                    if (gsi.PtsL.ToString() != sValue) throw new InvalidOperationException();
                                    break;
                                default:
                                    throw new InvalidOperationException();
                            }
                        }
                    }
                    if (!nextGame.IsValid()) throw new InvalidOperationException();
                    DateTime dtGameDate = DateTime.ParseExact(nextGame.game_date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    nextGame.league = DetermineLeagueType(dtGameDate, nextGame.winner, nextGame.loser);
                    keepTrackOfAllGames.Add(nextGame);

                    int iComparisonValue;

                    //determine if the game works as a first game for that score
                    bool isFirstGame;
                    if (firstGames.Count > 0)
                    {
                        iComparisonValue = nextGame.game_date.CompareTo(firstGames[0].game_date);
                        if (iComparisonValue < 0) firstGames.Clear();
                        isFirstGame = iComparisonValue <= 0;
                    }
                    else
                    {
                        isFirstGame = true;
                    }
                    if (isFirstGame) 
                        firstGames.Add(nextGame);

                    //determine if the game works as a last game for that score
                    bool isLastGame;
                    if (lastGames.Count > 0)
                    {
                        iComparisonValue = nextGame.game_date.CompareTo(lastGames[0].game_date);
                        if (iComparisonValue > 0) lastGames.Clear();
                        isLastGame = iComparisonValue >= 0;
                    }
                    else
                    {
                        isLastGame = true;
                    }
                    if (isLastGame) lastGames.Add(nextGame);
                }
            }
            if (firstGames.Count == 0 || lastGames.Count == 0)
            {
                throw new InvalidOperationException();
            }
            DateTime firstDate = DateTime.ParseExact(firstGames[0].game_date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime lastDate = DateTime.ParseExact(lastGames[0].game_date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            FinalScoreInfo fsi = new FinalScoreInfo(gsi.PtsW.ToString().PadLeft(2, '0') + "-" + gsi.PtsL.ToString().PadLeft(2, '0'), gsi.Count, firstDate, lastDate);

            MatchupType mt;

            foreach (GameInfo nextFirstGame in firstGames)
            {
                fsi.FirstMatchups.Add(GetMatchupString(nextFirstGame.game_location, nextFirstGame.winner, nextFirstGame.loser, gsi.PtsW, gsi.PtsL, nextFirstGame.GetMatchupType()));
            }
            bool foundMatchingLastGame = false;
            foreach (GameInfo nextLastGame in lastGames)
            {
                string lastteam1, lastteam2;
                int lastteam1points, lastteam2points;
                if (nextLastGame.game_location == "@" || nextLastGame.game_location == "N")
                {
                    lastteam1 = nextLastGame.winner;
                    lastteam1points = gsi.PtsW;
                    lastteam2 = nextLastGame.loser;
                    lastteam2points = gsi.PtsL;
                }
                else
                {
                    lastteam1 = nextLastGame.loser;
                    lastteam1points = gsi.PtsL;
                    lastteam2 = nextLastGame.winner;
                    lastteam2points = gsi.PtsW;
                }
                mt = nextLastGame.GetMatchupType();
                string lastGameVersusOrAt = nextLastGame.game_location == "N" ? "vs" : "at";
                string lastMatchup = lastteam1 + " " + lastteam1points.ToString() + " " + lastGameVersusOrAt + " " + lastteam2points.ToString() + " " + lastteam2;

                //validate the existing last matchup value (with respect to the pro football reference dataset)
                if (string.Equals(lastMatchup, gsi.LastMatchup) ||
                    string.Equals(lastMatchup, gsi.LastMatchup.Replace(" vs ", " at ")) ||
                    string.Equals(nextLastGame.winner + " vs " + nextLastGame.loser, gsi.LastMatchup) ||
                    string.Equals(nextLastGame.loser + " vs " + nextLastGame.winner, gsi.LastMatchup))
                {
                    if (foundMatchingLastGame)
                    {
                        throw new InvalidOperationException();
                    }
                    if (fsi.LastDate != lastDate) //date mismatch
                    {
                        throw new InvalidOperationException();
                    }
                    foundMatchingLastGame = true;
                }

                if (mt != MatchupType.RegularSeason)
                {
                    lastMatchup += (" (" + GameScoreInfo.GetMatchupTypeString(mt) + ")");
                }
                fsi.LastMatchups.Add(lastMatchup);
            }
            if (!foundMatchingLastGame)
            {
                throw new InvalidOperationException();
            }
            return fsi;
        }

        private static string GetMatchupString(string game_location, string winner, string loser, int PtsW, int PtsL, MatchupType mt)
        {
            string firstteam1, firstteam2;
            int firstteam1points, firstteam2points;
            if (game_location == "@" || game_location == "N")
            {
                firstteam1 = winner;
                firstteam1points = PtsW;
                firstteam2 = loser;
                firstteam2points = PtsL;
            }
            else
            {
                firstteam1 = loser;
                firstteam1points = PtsL;
                firstteam2 = winner;
                firstteam2points = PtsW;
            }
            string firstGameVersusOrAt = game_location == "N" ? "vs" : "at";
            string sMatchupString = firstteam1 + " " + firstteam1points.ToString() + " " + firstGameVersusOrAt + " " + firstteam2points.ToString() + " " + firstteam2;
            if (mt != MatchupType.RegularSeason)
            {
                sMatchupString += (" (" + GameScoreInfo.GetMatchupTypeString(mt) + ")");
            }
            return sMatchupString;
        }

        private static LeagueType DetermineLeagueType(DateTime dt, string team1, string team2)
        {
            LeagueType ret = LeagueType.NFL;
            if (dt.Year >= 1946 && dt.Year <= 1949)
            {
                HashSet<string> aafcTeams = new HashSet<string>()
                {
                    "Cleveland Browns",
                    "San Francisco 49ers",
                    "New York Yankees",
                    "Brooklyn-New York Yankees",
                    "Los Angeles Dons",
                    "Buffalo Bills",
                    "Buffalo Bisons",
                    "Chicago Rockets",
                    "Chicago Hornets",
                    "Miami Seahawks",
                    "Baltimore Colts",
                    "Brooklyn Dodgers",
                };
                bool isTeam1AAFC = aafcTeams.Contains(team1);
                bool isTeam2AAFC = aafcTeams.Contains(team2);
                if (isTeam1AAFC && isTeam2AAFC)
                {
                    ret = LeagueType.AAFC;
                }
                else if (!isTeam1AAFC && !isTeam2AAFC)
                {
                    ret = LeagueType.NFL;
                }
                else //inconsistent
                {
                    throw new InvalidOperationException();
                }
            }
            return ret;
        }

        /// <summary>
        /// league type
        /// </summary>
        public enum LeagueType
        {
            /// <summary>
            /// national football league
            /// </summary>
            NFL,

            /// <summary>
            /// AAFC (1946-1949)
            /// </summary>
            AAFC,
        }

        private static IEnumerable<GameScoreInfo> GetAllGameScoresFromWeb(HttpClient hc)
        {
            HtmlDocument mainDoc = GetHtmlDocumentFromURL("https://www.pro-football-reference.com/boxscores/game-scores.htm", hc);
            HtmlNode foundTable = GetRankerTable(mainDoc);
            int iRowIndex = 0;
            foreach (HtmlNode nextRow in foundTable.SelectNodes("//tr"))
            {
                iRowIndex++;
                if (iRowIndex > 1)
                {
                    int iRk = -1;
                    string sGameScore = string.Empty;
                    int iPtsWin = -1;
                    int iPtsLose = -1;
                    int iPtsTotal = -1;
                    int iPtsDiff = -1;
                    int iCount = -1;
                    string sLastGame = string.Empty;
                    foreach (HtmlNode nextCol in nextRow.ChildNodes.AsEnumerable())
                    {
                        string sColName = nextCol.Name;
                        bool isheader = sColName == "th";
                        bool isdata = sColName == "td";
                        if (isheader || isdata)
                        {
                            string dataStat = nextCol.GetAttributeValue("data-stat", "N/A");
                            string sValue = nextCol.InnerText;
                            switch (dataStat)
                            {
                                case "ranker":
                                    iRk = int.Parse(sValue);
                                    break;
                                case "game_score":
                                    sGameScore = sValue;
                                    break;
                                case "pts_win":
                                    iPtsWin = int.Parse(sValue);
                                    break;
                                case "pts_lose":
                                    iPtsLose = int.Parse(sValue);
                                    break;
                                case "points_total":
                                    iPtsTotal = int.Parse(sValue);
                                    break;
                                case "points_diff":
                                    iPtsDiff = int.Parse(sValue);
                                    break;
                                case "counter":
                                    iCount = int.Parse(sValue);
                                    break;
                                case "all_games":
                                    //ignored
                                    break;
                                case "last_game":
                                    sLastGame = sValue.Replace(",", string.Empty);
                                    break;
                                default:
                                    throw new InvalidOperationException();
                            }
                        }

                    }

                    if (iRk == -1 ||
                        string.IsNullOrEmpty(sGameScore) ||
                        iPtsWin == -1 ||
                        iPtsLose == -1 ||
                        iPtsTotal == -1 ||
                        iPtsDiff == -1 ||
                        iCount == -1 ||
                        string.IsNullOrEmpty(sLastGame))
                    {
                        throw new InvalidOperationException();
                    }
                    GameScoreRow gsr = new GameScoreRow()
                    {
                        Rk = iRk,
                        Score = sGameScore,
                        PtsW = iPtsWin,
                        PtsL = iPtsLose,
                        PtTot = iPtsTotal,
                        PD = iPtsDiff,
                        Count = iCount,
                        LastGame = sLastGame
                    };
                    yield return new GameScoreInfo(gsr);
                }
            }
        }

        /// <summary>
        /// processes all game scores from the web (https://www.pro-football-reference.com/boxscores/game-scores.htm)
        /// </summary>
        /// <param name="hc">HTTP client</param>
        /// <returns>enumerates through the game scores</returns>
        public static IEnumerable<GameInfo> ProcessAllGameScoresFromWeb(HttpClient hc)
        {
            bool pastFirst = false;
            foreach (GameScoreInfo gsi in GetAllGameScoresFromWeb(hc))
            {
                List<GameInfo> allGames = new List<GameInfo>();
                if (pastFirst)
                    Thread.Sleep(5000); //sleep to try to avoid being throttled
                else
                    pastFirst = true;
                GetFirstAndLastGameScoreInfo(gsi, Common.HttpClient, allGames);
                foreach (GameInfo nextGame in allGames)
                {
                    yield return nextGame;
                }
            }
        }

        public enum FinalScoreInfoSortType
        {
            TotalCountDescending,
            ByScore,
        }

        public class FinalScoreInfoSorter : IComparer<FinalScoreInfo>
        {
            private FinalScoreInfoSortType SortType { get; set; }
            public FinalScoreInfoSorter(FinalScoreInfoSortType SortType)
            {
                this.SortType = SortType;
            }
            public int Compare(FinalScoreInfo? x, FinalScoreInfo? y)
            {
                if (x == null || y == null) throw new InvalidOperationException();
                int ret;
                if (SortType == FinalScoreInfoSortType.TotalCountDescending)
                {
                    ret = y.Count.CompareTo(x.Count);
                }
                else if (SortType == FinalScoreInfoSortType.ByScore)
                {
                    ret = x.Score.CompareTo(y.Score);
                }
                else
                {
                    throw new InvalidOperationException();
                }
                return ret;
            }
        }

        /// <summary>
        /// final score info
        /// </summary>
        public class FinalScoreInfo
        {
            /// <summary>
            /// final score info constructor
            /// </summary>
            public FinalScoreInfo(string Score, int Count, DateTime FirstDate, DateTime LastDate)
            {
                FirstMatchups = new List<string>();
                LastMatchups = new List<string>();
                this.Score = Score;
                this.Count = Count;
                this.FirstDate = FirstDate;
                this.LastDate = LastDate;
            }

            /// <summary>
            /// writes the information to console
            /// </summary>
            public void WriteToConsole()
            {
                Console.Out.WriteLine(this.Score + " " + this.Count);
                Console.Out.WriteLine(" " + this.FirstDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                foreach (string next in FirstMatchups)
                {
                    Console.Out.WriteLine("  " + next);
                }
                Console.Out.WriteLine(" " + this.LastDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                foreach (string next in LastMatchups)
                {
                    Console.Out.WriteLine("  " + next);
                }
            }

            /// <summary>
            /// score
            /// </summary>
            public string Score { get; set; }

            /// <summary>
            /// number of games
            /// </summary>
            public int Count { get; set; }

            /// <summary>
            /// date for the first game
            /// </summary>
            public DateTime FirstDate { get; set; }

            /// <summary>
            /// date for the last game
            /// </summary>
            public DateTime LastDate { get; set; }

            /// <summary>
            /// first matchup or matchups
            /// </summary>
            public List<string> FirstMatchups { get; set; }

            /// <summary>
            /// last matchups
            /// </summary>
            public List<string> LastMatchups { get; set; }
        }

        public enum GameInfoSortType
        {
            Chronological,
            ChronologicalWithinCalendarYear,
        }

        public class GameInfoComparer : IComparer<GameInfo>
        {
            private GameInfoSortType GameInfoSortType { get; set; }
            public GameInfoComparer(GameInfoSortType GameInfoSortType)
            {
                this.GameInfoSortType = GameInfoSortType;
            }
            public int Compare(GameInfo? x, GameInfo? y)
            {
                if (x == null || y == null) throw new InvalidOperationException();
                int ret;
                if (GameInfoSortType == GameInfoSortType.Chronological)
                {
                    ret = x.game_date.CompareTo(y.game_date);
                }
                else if (GameInfoSortType == GameInfoSortType.ChronologicalWithinCalendarYear)
                {
                    ret = x.GetMonth().CompareTo(y.GetMonth());
                    if (ret == 0) ret = x.GetDay().CompareTo(y.GetDay());
                }
                else
                {
                    throw new InvalidOperationException();
                }
                return ret;
            }
        }

        /// <summary>
        /// game information for matchup
        /// </summary>
        public class GameInfo
        {
            /// <summary>
            /// constructor
            /// </summary>
            public static GameInfo GetEmptyObject(int pts_win, int pts_loss)
            {
                return new GameInfo()
                {
                    pts_win = pts_win,
                    pts_loss = pts_loss,
                    week_num = string.Empty,
                    game_date = string.Empty,
                    winner = string.Empty,
                    game_location = string.Empty,
                    loser = string.Empty,
                    league = LeagueType.NFL,
                };
            }

            /// <summary>
            /// retrieves the game info date object
            /// </summary>
            /// <returns>game info date object</returns>
            public DateTime GetDateObject()
            {
                if (this.ParsedDate == null)
                {
                    this.ParsedDate = DateTime.ParseExact(game_date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                }
                return this.ParsedDate.Value;
            }

            /// <summary>
            /// retrieves the game info year
            /// </summary>
            /// <returns>game info year</returns>
            public int GetYear()
            {
                return this.GetDateObject().Year;
            }

            /// <summary>
            /// retrieves the game info month
            /// </summary>
            /// <returns>game info month</returns>
            public int GetMonth()
            {
                return this.GetDateObject().Month;
            }

            /// <summary>
            /// retrieves the game info day
            /// </summary>
            /// <returns>game info day</returns>
            public int GetDay()
            {
                return this.GetDateObject().Day;
            }

            /// <summary>
            /// retrieves the season starting year. This assumes a season lasts from August-February (there are no games outside that window)
            /// </summary>
            /// <returns>season starting year</returns>
            public int GetSeasonStartingYear()
            {
                int y = GetYear();
                int m = GetMonth();
                if (m == 1 || m == 2) y--;
                return y;
            }

            /// <summary>
            /// whether the game information is valid
            /// </summary>
            /// <returns>true if valid, false otherwise</returns>
            public bool IsValid()
            {
                return !string.IsNullOrEmpty(week_num) &&
                       !string.IsNullOrEmpty(game_date) &&
                       !string.IsNullOrEmpty(winner) &&
                       !string.IsNullOrEmpty(game_location) &&
                       !string.IsNullOrEmpty(loser);
            }

            /// <summary>
            /// retrieves the matchup type for the game
            /// </summary>
            /// <returns>matchup type</returns>
            public MatchupType GetMatchupType()
            {
                MatchupType mt;
                if (int.TryParse(week_num, out _))
                    mt = MatchupType.RegularSeason;
                else if (week_num == "Wild Card")
                    mt = MatchupType.WildCard;
                else if (week_num == "Division")
                    mt = MatchupType.Division;
                else if (week_num == "Conf. Champ")
                    mt = MatchupType.ConferenceChampionship;
                else if (week_num == "Champ")
                    mt = MatchupType.Championship;
                else if (week_num == "Super Bowl")
                    mt = MatchupType.SuperBowl;
                else
                    throw new InvalidOperationException();
                return mt;
            }

            /// <summary>
            /// winning team points
            /// </summary>
            public required int pts_win { get; set; }

            /// <summary>
            /// losting team points
            /// </summary>
            public required int pts_loss { get; set; }

            /// <summary>
            /// week number
            /// </summary>
            public required string week_num { get; set; }

            /// <summary>
            /// game date
            /// </summary>
            public required string game_date { get; set; }

            /// <summary>
            /// parsed date
            /// </summary>
            private DateTime? ParsedDate { get; set; }

            /// <summary>
            /// winner
            /// </summary>
            public required string winner { get; set; }

            /// <summary>
            /// game location
            /// </summary>
            public required string game_location { get; set; }

            /// <summary>
            /// loser
            /// </summary>
            public required string loser { get; set; }

            /// <summary>
            /// league type
            /// </summary>
            public required LeagueType league { get; set; }
        }

        public class GameInfoMap : ClassMap<GameInfo>
        {
            public GameInfoMap()
            {
                Map(m => m.pts_win);
                Map(m => m.pts_loss);
                Map(m => m.week_num);
                Map(m => m.game_date);
                Map(m => m.winner);
                Map(m => m.game_location);
                Map(m => m.loser);
                Map(m => m.league).TypeConverter<LeagueTypeConverter>();
            }
        }

        public class LeagueTypeConverter : ITypeConverter
        {
            public object? ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
            {
                if (string.IsNullOrEmpty(text))
                {
                    return LeagueType.NFL;
                }
                if (Enum.TryParse<LeagueType>(text, out LeagueType result))
                {
                    return result;
                }
                throw new TypeConverterException(this, memberMapData, text, row.Context);
            }

            public string? ConvertToString(object? value, IWriterRow row, MemberMapData memberMapData)
            {
                return value?.ToString() ?? string.Empty;
            }
        }

        /// <summary>
        /// processes all game scores from local CSV
        /// </summary>
        /// <param name="filePath">file path</param>
        /// <returns>game info objects</returns>
        public static IEnumerable<GameInfo> ProcessAllGameInfosFromCSV(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GameInfoMap>();
                foreach (GameInfo gi in csv.GetRecords<GameInfo>())
                {
                    yield return gi;
                }
            }
        }


        /// <summary>
        /// processes all game scores from local CSV (copy from https://www.pro-football-reference.com/boxscores/game-scores.htm)
        /// </summary>
        /// <returns>enumerates through the game scores</returns>
        public static IEnumerable<GameScoreInfo> ProcessAllGameScoresFromCSV(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GameScoreRowMap>();
                foreach (GameScoreRow gsr in csv.GetRecords<GameScoreRow>())
                {
                    yield return new GameScoreInfo(gsr);
                }
            }
        }

        /// <summary>
        /// retrieves an HTML document for a URL
        /// </summary>
        /// <param name="URL">URL</param>
        /// <param name="hc">HTTP client</param>
        /// <returns>HTML document</returns>
        private static HtmlDocument GetHtmlDocumentFromURL(string URL, HttpClient hc)
        {
            HtmlDocument mainDoc = new HtmlDocument();
            HttpResponseMessage hrm = hc.GetAsync(URL).Result;
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

        /// <summary>
        /// retrieves the ranker table for an HTML document
        /// </summary>
        /// <param name="mainDoc">main document</param>
        /// <returns>table element</returns>
        private static HtmlNode GetRankerTable(HtmlDocument mainDoc)
        {
            HtmlNode? foundTable = null;
            foreach (HtmlNode node in mainDoc.DocumentNode.SelectNodes("//table"))
            {
                if (node.HasClass("sortable") && node.HasClass("stats_table") && node.Id == "games")
                {
                    foundTable = node;
                    break;
                }
            }
            if (foundTable == null) throw new InvalidOperationException();
            return foundTable!;
        }
    }

    /// <summary>
    /// game score information
    /// </summary>
    public class GameScoreInfo
    {
        public static string GetMatchupTypeString(MatchupType mt)
        {
            string ret = string.Empty;
            if (mt != MatchupType.RegularSeason)
            {
                string append = string.Empty;
                switch (mt)
                {
                    case MatchupType.SuperBowl:
                        append = "SB";
                        break;
                    case MatchupType.Championship:
                        append = "Champ";
                        break;
                    case MatchupType.WildCard:
                    case MatchupType.Division:
                    case MatchupType.ConferenceChampionship:
                        append = "Playoff";
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                ret += append;
            }
            return ret;
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="r">input row</param>
        /// <exception cref="InvalidOperationException">invalid csv data</exception>
        public GameScoreInfo(GameScoreRow r)
        {
            this.PtsW = r.PtsW;
            this.PtsL = r.PtsL;
            this.Count = r.Count;

            string sMatchupInfo = r.LastGame;
            int matchupLength = sMatchupInfo.Length;
            int iLastYear = int.Parse(sMatchupInfo.Substring(matchupLength - 4));
            sMatchupInfo = sMatchupInfo.Substring(0, matchupLength - 5);

            int previousSpace = sMatchupInfo.LastIndexOf(' ');
            int iLastDay = int.Parse(sMatchupInfo.Substring(previousSpace + 1));
            sMatchupInfo = sMatchupInfo.Substring(0, previousSpace);

            previousSpace = sMatchupInfo.LastIndexOf(' ');
            string sMonth = sMatchupInfo.Substring(previousSpace + 1);

            switch (sMonth)
            {
                case "January":
                case "February":
                case "March":
                case "April":
                case "May":
                case "June":
                case "July":
                case "August":
                case "September":
                case "October":
                case "November":
                case "December":
                    break;
                default:
                    throw new InvalidOperationException();
            }
            this.LastMatchup = sMatchupInfo.Substring(0, previousSpace).Replace("vs.", "vs");                        
        }

        /// <summary>
        /// winning team points
        /// </summary>
        public int PtsW { get; set; }

        /// <summary>
        /// losing team points
        /// </summary>
        public int PtsL { get; set; }

        /// <summary>
        /// number of times the score has been seen
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// last matchup
        /// </summary>
        public string LastMatchup { get; set;  }
    }

    public enum MatchupType
    {
        RegularSeason,
        WildCard,
        Division,
        ConferenceChampionship,
        Championship,
        SuperBowl,
    }

    /// <summary>
    /// game score
    /// </summary>
    public class GameScoreRow
    {
        /// <summary>
        /// index number
        /// </summary>
        public required int Rk { get; set; }
        /// <summary>
        /// game score
        /// </summary>
        public required string Score { get; set; }
        /// <summary>
        /// winning team points
        /// </summary>
        public required int PtsW { get; set; }
        /// <summary>
        /// losing team points
        /// </summary>
        public required int PtsL { get; set; }
        /// <summary>
        /// total points
        /// </summary>
        public required int PtTot { get; set; }
        /// <summary>
        /// point differential
        /// </summary>
        public required int PD { get; set; }
        /// <summary>
        /// number of times the score has been seen
        /// </summary>
        public required int Count { get; set; }
        /// <summary>
        /// last game
        /// </summary>
        [Name("Last Game")]
        public required string LastGame { get; set; }
    }

    // Define a mapping that ignores the empty column
    public class GameScoreRowMap : ClassMap<GameScoreRow>
    {
        public GameScoreRowMap()
        {
            Map(m => m.Rk).Name("Rk");
            Map(m => m.Score).Name("Score");
            Map(m => m.PtsW).Name("PtsW");
            Map(m => m.PtsL).Name("PtsL");
            Map(m => m.PtTot).Name("PtTot");
            Map(m => m.PD).Name("PD");
            Map(m => m.Count).Name("Count");
            Map(m => m.LastGame).Name("Last Game");

            // Ignore the empty column
            Map(m => m.LastGame).Ignore(false); // Ensure "Last Game" is mapped correctly
        }
    }
}
