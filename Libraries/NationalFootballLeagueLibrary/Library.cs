using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.Reflection;

namespace NationalFootballLeagueLibrary
{
    public static class Library
    {
        /// <summary>
        /// processes all game scores from CSV (https://www.pro-football-reference.com/boxscores/game-scores.htm)
        /// </summary>
        /// <returns>enumerates through the game scores</returns>
        public static IEnumerable<GameScoreInfo> ProcessAllGameScores()
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
            string first = this.PtsW.ToString().PadLeft(2, '0') + "-" + this.PtsL.ToString().PadLeft(2, '0') + " " + this.Count.ToString().PadLeft(3, '0') + " " + this.Year + "/" + this.Month.ToString().PadLeft(2, '0') + "/" + this.Day.ToString().PadLeft(2, '0') + " " + this.Matchup;
            return first.Replace("vs.", "vs");
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
            this.Year = int.Parse(sMatchupInfo.Substring(matchupLength - 4));
            sMatchupInfo = sMatchupInfo.Substring(0, matchupLength - 5);

            int previousSpace = sMatchupInfo.LastIndexOf(' ');
            this.Day = int.Parse(sMatchupInfo.Substring(previousSpace + 1));
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
            this.Month = iMonth;
            this.Matchup = sMatchupInfo.Substring(0, previousSpace);
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
        /// year
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// day
        /// </summary>
        public int Day { get; set; }

        /// <summary>
        /// month
        /// </summary>
        public int Month { get; set;  }

        /// <summary>
        /// matchup
        /// </summary>
        public string Matchup { get; set; }
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
