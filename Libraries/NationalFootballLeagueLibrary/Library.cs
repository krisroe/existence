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

            bool pastFirst = false;

            List<GameScoreInfo> gsis = new List<GameScoreInfo>();
            foreach (GameScoreInfo gsi in Library.ProcessAllGameScoresFromWeb(Common.HttpClient))
            {
                if (pastFirst)
                    Thread.Sleep(5000); //sleep to try to avoid being throttled
                else
                    pastFirst = true;
                Library.GetFirstAndLastGameScoreInfo(gsi, Common.HttpClient);
                Console.Out.WriteLine(gsi.ToString());
                XmlElement nextScore = doc.CreateElement("score");
                nextScore.SetAttribute("score", gsi.PtsW + "-" + gsi.PtsL);
                nextScore.SetAttribute("count", gsi.Count.ToString());
                nextScore.SetAttribute("firstdate", gsi.GetFirstMatchupDate());
                nextScore.SetAttribute("firstmatchup", gsi.GetFirstMatchupText());
                nextScore.SetAttribute("lastdate", gsi.GetLastMatchupDate());
                nextScore.SetAttribute("lastmatchup", gsi.GetFirstMatchupText());
                top.AppendChild(nextScore);
            }
            Common.WriteToFile(doc, filePath);
            Console.Out.WriteLine("Wrote game score info to " + filePath);
            return Common.READ_NEWLINE;
        }

        public static void GetFirstAndLastGameScoreInfo(GameScoreInfo gsi, HttpClient hc)
        {
            string sURL = $"https://www.pro-football-reference.com/boxscores/game_scores_find.cgi?pts_win={gsi.PtsW}&pts_lose={gsi.PtsL}";
            HtmlDocument mainDoc = GetHtmlDocumentFromURL(sURL, hc);
            HtmlNode foundTable = GetRankerTable(mainDoc);
            int iRowIndex = 0;
            string first_week_num = string.Empty;
            string first_game_date = string.Empty;
            string first_winner = string.Empty;
            string first_game_location = string.Empty;
            string first_loser = string.Empty;
            string last_week_num = string.Empty;
            string last_game_date = string.Empty;
            string last_winner = string.Empty;
            string last_game_location = string.Empty;
            string last_loser = string.Empty;
            foreach (HtmlNode nextRow in foundTable.SelectNodes("//tr"))
            {
                iRowIndex++;
                if (iRowIndex > 1)
                {
                    string next_week_num = string.Empty;
                    string next_game_date = string.Empty;
                    string next_winner = string.Empty;
                    string next_game_location = string.Empty;
                    string next_loser = string.Empty;
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
                                    next_week_num = sValue;
                                    break;
                                case "game_date":
                                    next_game_date = sValue;
                                    break;
                                case "winner":
                                    next_winner = sValue;
                                    break;
                                case "game_location":
                                    if (sValue != string.Empty && sValue != "@" && sValue != "N")
                                        throw new InvalidOperationException();
                                    next_game_location = sValue == string.Empty ? " " : sValue;
                                    break;
                                case "loser":
                                    next_loser = sValue;
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

                    if (string.IsNullOrEmpty(next_week_num) ||
                        string.IsNullOrEmpty(next_game_date) ||
                        string.IsNullOrEmpty(next_winner) ||
                        string.IsNullOrEmpty(next_game_location) ||
                        string.IsNullOrEmpty(next_loser))
                    {
                        throw new InvalidOperationException();
                    }
                    if (iRowIndex == 2)
                    {
                        first_week_num = next_week_num;
                        first_game_date = next_game_date;
                        first_winner = next_winner;
                        first_game_location = next_game_location;
                        first_loser = next_loser;
                    }
                    last_week_num = next_week_num;
                    last_game_date = next_game_date;
                    last_winner = next_winner;
                    last_game_location = next_game_location;
                    last_loser = next_loser;
                }
            }
            if (string.IsNullOrEmpty(first_week_num) ||
                string.IsNullOrEmpty(first_game_date) ||
                string.IsNullOrEmpty(first_winner) ||
                string.IsNullOrEmpty(first_game_location) ||
                string.IsNullOrEmpty(first_loser) ||
                string.IsNullOrEmpty(last_week_num) ||
                string.IsNullOrEmpty(last_game_date) ||
                string.IsNullOrEmpty(last_winner) ||
                string.IsNullOrEmpty(last_game_location) ||
                string.IsNullOrEmpty(last_loser))
            {
                throw new InvalidOperationException();
            }
            string firstteam1, firstteam2;
            if (first_game_location == "@" || first_game_location == "N")
            {
                firstteam1 = first_winner;
                firstteam2 = first_loser;
            }
            else
            {
                firstteam1 = first_loser;
                firstteam2 = first_winner;
            }
            string lastteam1, lastteam2;
            if (last_game_location == "@" || last_game_location == "N")
            {
                lastteam1 = last_winner;
                lastteam2 = last_loser;
            }
            else
            {
                lastteam1 = last_loser;
                lastteam2 = last_winner;
            }

            DateTime firstDate = DateTime.ParseExact(first_game_date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime lastDate = DateTime.ParseExact(last_game_date, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            if (gsi.LastDay != lastDate.Day ||
                gsi.LastMonth != lastDate.Month ||
                gsi.LastYear != lastDate.Year)
            {
                throw new InvalidOperationException();
            }

            gsi.FirstYear = firstDate.Year;
            gsi.FirstMonth = firstDate.Month;
            gsi.FirstDay = firstDate.Day;

            MatchupType mt;
            if (int.TryParse(first_week_num, out _))
                mt = MatchupType.RegularSeason;
            else if (first_week_num == "Wild Card")
                mt = MatchupType.WildCard;
            else if (first_week_num == "Division")
                mt = MatchupType.Division;
            else if (first_week_num == "Conf. Champ")
                mt = MatchupType.ConferenceChampionship;
            else if (first_week_num == "Champ")
                mt = MatchupType.Championship;
            else if (first_week_num == "Super Bowl")
                mt = MatchupType.SuperBowl;
            else
                throw new InvalidOperationException();
            gsi.FirstMatchupType = mt;
            if (int.TryParse(last_week_num, out _))
                mt = MatchupType.RegularSeason;
            else if (last_week_num == "Wild Card")
                mt = MatchupType.WildCard;
            else if (last_week_num == "Division")
                mt = MatchupType.Division;
            else if (last_week_num == "Conf. Champ")
                mt = MatchupType.ConferenceChampionship;
            else if (last_week_num == "Champ")
                mt = MatchupType.Championship;
            else if (last_week_num == "Super Bowl")
                mt = MatchupType.SuperBowl;
            else
                throw new InvalidOperationException();
            gsi.LastMatchupType = mt;

            string lastMatchup;
            if (last_game_location == "N")
                lastMatchup = lastteam1 + " vs " + lastteam2;
            else
                lastMatchup = lastteam1 + " at " + lastteam2;            

            if (!string.Equals(lastMatchup, gsi.LastMatchup) &&
                !string.Equals(lastMatchup, gsi.LastMatchup.Replace(" vs ", " at ")) &&
                !string.Equals(last_winner + " vs " + last_loser, gsi.LastMatchup))
            {
                throw new InvalidOperationException();
            }
            gsi.LastMatchup = lastMatchup;

            string firstMatchup;
            if (first_game_location == "N")
                firstMatchup = firstteam1 + " vs " + firstteam2;
            else
                firstMatchup = firstteam1 + " at " + firstteam2;
            gsi.FirstMatchup = firstMatchup;
        }

        /// <summary>
        /// processes all game scores from the web (https://www.pro-football-reference.com/boxscores/game-scores.htm)
        /// </summary>
        /// <returns>enumerates through the game scores</returns>
        public static IEnumerable<GameScoreInfo> ProcessAllGameScoresFromWeb(HttpClient hc)
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
        /// <summary>
        /// text version of the game score info
        /// </summary>
        /// <returns>text version of the game score info</returns>
        public override string ToString()
        {
            return this.PtsW.ToString().PadLeft(2, '0') + "-" + this.PtsL.ToString().PadLeft(2, '0') + " " + 
                this.Count.ToString().PadLeft(3, '0') + " " + 
                GetLastMatchupDate() + " " + GetLastMatchupText() + " " + GetFirstMatchupDate() + " " + GetFirstMatchupText();
        }

        public string GetLastMatchupDate()
        {
            return this.LastYear.ToString().PadLeft(4, '0') + "/" + this.LastMonth.ToString().PadLeft(2, '0') + "/" + this.LastDay.ToString().PadLeft(2, '0');
        }

        public string GetLastMatchupText()
        {
            return this.LastMatchup + GetMatchupTypeString(this.LastMatchupType);
        }

        public string GetFirstMatchupDate()
        {
            return this.FirstYear.ToString().PadLeft(4, '0') + "/" + this.FirstMonth.ToString().PadLeft(2, '0') + "/" + this.FirstDay.ToString().PadLeft(2, '0');
        }

        public string GetFirstMatchupText()
        {
            return this.FirstMatchup + GetMatchupTypeString(this.FirstMatchupType);
        }

        private static string GetMatchupTypeString(MatchupType mt)
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
            this.LastYear = int.Parse(sMatchupInfo.Substring(matchupLength - 4));
            sMatchupInfo = sMatchupInfo.Substring(0, matchupLength - 5);

            int previousSpace = sMatchupInfo.LastIndexOf(' ');
            this.LastDay = int.Parse(sMatchupInfo.Substring(previousSpace + 1));
            sMatchupInfo = sMatchupInfo.Substring(0, previousSpace);

            previousSpace = sMatchupInfo.LastIndexOf(' ');
            string sMonth = sMatchupInfo.Substring(previousSpace + 1);

            int iMonth;
            switch (sMonth)
            {
                case "January":
                    iMonth = 1;
                    break;
                case "February":
                    iMonth = 2;
                    break;
                case "March":
                    iMonth = 3;
                    break;
                case "April":
                    iMonth = 4;
                    break;
                case "May":
                    iMonth = 5;
                    break;
                case "June":
                    iMonth = 6;
                    break;
                case "July":
                    iMonth = 7;
                    break;
                case "August":
                    iMonth = 8;
                    break;
                case "September":
                    iMonth = 9;
                    break;
                case "October":
                    iMonth = 10;
                    break;
                case "November":
                    iMonth = 11;
                    break;
                case "December":
                    iMonth = 12;
                    break;
                default:
                    throw new InvalidOperationException();
            }
            this.LastMonth = iMonth;
            this.LastMatchup = sMatchupInfo.Substring(0, previousSpace).Replace("vs.", "vs");
                        
            this.FirstMatchup = string.Empty; //populated in second pass
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
        /// last year
        /// </summary>
        public int LastYear { get; set; }

        /// <summary>
        /// last day
        /// </summary>
        public int LastDay { get; set; }

        /// <summary>
        /// last month
        /// </summary>
        public int LastMonth { get; set;  }

        /// <summary>
        /// last matchup
        /// </summary>
        public string LastMatchup { get; set; }

        /// <summary>
        /// last matchup type
        /// </summary>
        public MatchupType LastMatchupType { get; set; }

        /// <summary>
        /// first year
        /// </summary>
        public int FirstYear { get; set; }

        /// <summary>
        /// first day
        /// </summary>
        public int FirstDay { get; set; }
        
        /// <summary>
        /// first month
        /// </summary>
        public int FirstMonth { get; set; }

        /// <summary>
        /// first matchup
        /// </summary>
        public string FirstMatchup { get; set; }
        /// <summary>
        /// first matchup type
        /// </summary>
        public MatchupType FirstMatchupType { get; set; }
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
