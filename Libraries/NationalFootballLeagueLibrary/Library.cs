using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using HtmlAgilityPack;
using LibraryShared;
using System.Globalization;
using System.Reflection;
using System.Xml;

namespace NationalFootballLeagueLibrary
{
    public static class Library
    {
        public static int RunMain(string[] args)
        {
            if (args.Length < 1 || string.IsNullOrEmpty(args[0]))
            {
                Console.WriteLine("No command line arguments given");
                return Common.READ_NEWLINE;
            }
            string filePath = args[0];
            XmlDocument doc = new XmlDocument();
            XmlElement top = doc.CreateElement("scorigamiinformation");
            doc.AppendChild(top);

            foreach (FinalScoreInfo fsi in ProcessAllGameScoresFromWeb(Common.HttpClient))
            {
                fsi.WriteToConsole();
                XmlElement nextScore = doc.CreateElement("score");
                nextScore.SetAttribute("score", fsi.Score);
                nextScore.SetAttribute("count", fsi.Count.ToString());
                nextScore.SetAttribute("firstdate", fsi.FirstDate.ToString("yyyy-MM-dd"));
                nextScore.SetAttribute("lastdate", fsi.LastDate.ToString("yyyy-MM-dd"));
                XmlElement matchup;
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
                top.AppendChild(nextScore);
            }
            Common.WriteToFile(doc, filePath);
            Console.Out.WriteLine("Wrote game score info to " + filePath);
            return Common.READ_NEWLINE;
        }

        /// <summary>
        /// retrieves the first and last game with the game score
        /// </summary>
        /// <param name="gsi">game score information</param>
        /// <param name="hc">http client</param>
        /// <exception cref="InvalidOperationException"></exception>
        public static FinalScoreInfo GetFirstAndLastGameScoreInfo(GameScoreInfo gsi, HttpClient hc)
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
                    GameInfo nextGame = GameInfo.GetEmptyObject();
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
            FinalScoreInfo fsi = new FinalScoreInfo(gsi.PtsW.ToString().PadLeft(2, '0') + "-" + gsi.PtsL.ToString().PadLeft(2, '0'), gsi.Count.ToString().PadLeft(3, '0'), firstDate, lastDate);

            MatchupType mt;

            foreach (GameInfo nextFirstGame in firstGames)
            {
                string firstteam1, firstteam2;
                int firstteam1points, firstteam2points;
                if (nextFirstGame.game_location == "@" || nextFirstGame.game_location == "N")
                {
                    firstteam1 = nextFirstGame.winner;
                    firstteam1points = gsi.PtsW;
                    firstteam2 = nextFirstGame.loser;
                    firstteam2points = gsi.PtsL;
                }
                else
                {
                    firstteam1 = nextFirstGame.loser;
                    firstteam1points = gsi.PtsL;
                    firstteam2 = nextFirstGame.winner;
                    firstteam2points = gsi.PtsW;
                }
                string firstGameVersusOrAt = nextFirstGame.game_location == "N" ? "vs" : "at";

                mt = nextFirstGame.GetMatchupType();
                string sMatchupString = firstteam1 + " " + firstteam1points.ToString() + " " + firstGameVersusOrAt + " " + firstteam2points.ToString() + " " + firstteam2;
                if (mt != MatchupType.RegularSeason)
                {
                    sMatchupString += (" (" + GameScoreInfo.GetMatchupTypeString(mt) + ")");
                }
                fsi.FirstMatchups.Add(sMatchupString);
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
        /// <returns>enumerates through the game scores</returns>
        public static IEnumerable<FinalScoreInfo> ProcessAllGameScoresFromWeb(HttpClient hc)
        {
            bool pastFirst = false;
            foreach (GameScoreInfo gsi in GetAllGameScoresFromWeb(hc))
            {
                if (pastFirst)
                    Thread.Sleep(5000); //sleep to try to avoid being throttled
                else
                    pastFirst = true;
                yield return Library.GetFirstAndLastGameScoreInfo(gsi, Common.HttpClient);
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
            public FinalScoreInfo(string Score, string Count, DateTime FirstDate, DateTime LastDate)
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
            public string Count { get; set; }

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


        /// <summary>
        /// game information for matchup
        /// </summary>
        public class GameInfo
        {
            /// <summary>
            /// constructor
            /// </summary>
            public static GameInfo GetEmptyObject()
            {
                return new GameInfo()
                {
                    week_num = string.Empty,
                    game_date = string.Empty,
                    winner = string.Empty,
                    game_location = string.Empty,
                    loser = string.Empty
                };
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
            /// week number
            /// </summary>
            public required string week_num { get; set; }

            /// <summary>
            /// game date
            /// </summary>
            public required string game_date { get; set; }

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
        }


        /// <summary>
        /// processes all game scores from local CSV (copy from https://www.pro-football-reference.com/boxscores/game-scores.htm)
        /// </summary>
        /// <returns>enumerates through the game scores</returns>
        public static IEnumerable<GameScoreInfo> ProcessAllGameScoresFromCSV()
        {
            string sExecutingAssemblyLocation = Assembly.GetExecutingAssembly().Location;
            FileInfo oExecutingFile = new FileInfo(sExecutingAssemblyLocation);
            string allGameScoresLocation = Path.Combine(oExecutingFile.Directory!.FullName, "AllGameScores.txt");
            using (var reader = new StreamReader(allGameScoresLocation))
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
