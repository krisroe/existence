using System.Globalization;
using System.Text;
using static NationalFootballLeagueLibrary.Library;

namespace NationalFootballLeagueLibrary
{
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
            FirstMatchups = new List<FinalScoreMatchup>();
            LastMatchups = new List<FinalScoreMatchup>();
            this.Score = Score;
            this.Count = Count;
            this.FirstDate = FirstDate;
            this.LastDate = LastDate;
        }



        /// <summary>
        /// writes the information to console
        /// </summary>
        /// <param name="DisplayInfo">display information</param>
        public void WriteToConsole(ScorigamiMatchupInfoToDisplay DisplayInfo)
        {
            Console.Out.WriteLine(this.Score + " " + this.Count.ToString().PadLeft(3, '0'));
            if (DisplayInfo == ScorigamiMatchupInfoToDisplay.First || DisplayInfo == ScorigamiMatchupInfoToDisplay.FirstAndLast)
            {
                Console.Out.WriteLine(" " + this.FirstDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                foreach (FinalScoreMatchup fsm in FirstMatchups)
                {
                    Console.Out.WriteLine("  " + fsm.ToString());
                }
            }
            if (this.FirstDate != this.LastDate && (DisplayInfo == ScorigamiMatchupInfoToDisplay.Last || DisplayInfo == ScorigamiMatchupInfoToDisplay.FirstAndLast))
            {
                Console.Out.WriteLine(" " + this.LastDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                foreach (FinalScoreMatchup fsm in LastMatchups)
                {
                    Console.Out.WriteLine("  " + fsm.ToString());
                }
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
        public List<FinalScoreMatchup> FirstMatchups { get; set; }

        /// <summary>
        /// last matchups
        /// </summary>
        public List<FinalScoreMatchup> LastMatchups { get; set; }

        /// <summary>
        /// enumerates matchups, both winners and losers
        /// </summary>
        /// <returns>matchups</returns>
        public IEnumerable<FinalScoreMatchup> EnumerateMatchups()
        {
            foreach (FinalScoreMatchup fsm1 in FirstMatchups) yield return fsm1;
            foreach (FinalScoreMatchup fsm2 in LastMatchups) yield return fsm2;
        }
    }

    public class FinalScoreMatchup
    {
        public static FinalScoreMatchup CreateFromXMLInformation(string team1franchise, string team1name, string team1points, string team2points, string team2name, string team2franchise, string neutral, string gameweekspecial, string league)
        {
            bool isNeutral = false;
            LeagueType leagueType = LeagueType.NFL;
            MatchupType matchupType = MatchupType.RegularSeason;
            if (!string.IsNullOrEmpty(neutral))
            {
                isNeutral = bool.Parse(neutral);
            }
            if (!string.IsNullOrEmpty(league))
            {
                leagueType = (LeagueType)Enum.Parse(typeof(LeagueType), league);
            }
            if (!string.IsNullOrEmpty(gameweekspecial))
            {
                matchupType = (MatchupType)Enum.Parse(typeof(MatchupType), gameweekspecial);
            }
            return new FinalScoreMatchup()
            {
                Team1Franchise = team1franchise,
                Team1Name = team1name,
                Team1Points = int.Parse(team1points),
                Team2Franchise = team2franchise,
                Team2Name = team2name,
                Team2Points = int.Parse(team2points),
                IsNeutralSite = isNeutral,
                GameWeekSpecial = matchupType,
                League = leagueType
            };
        }

        public static FinalScoreMatchup CreateFromGameInfoObject(GameInfo gi)
        {
            return CreateFromGameInformation(gi.game_location, gi.winner, gi.winner_franchise, gi.loser, gi.loser_franchise, gi.pts_win, gi.pts_loss, gi.GetMatchupType(), gi.league);
        }

        public static FinalScoreMatchup CreateFromGameInformation(string game_location, string winner, string winner_franchise, string loser, string loser_franchise, int PtsW, int PtsL, MatchupType mt, LeagueType league)
        {
            string firstteam1, firstteam2;
            int firstteam1points, firstteam2points;
            string firstteam1franchise, firstteam2franchise;
            if (game_location == "@" || game_location == "N")
            {
                firstteam1 = winner;
                firstteam1points = PtsW;
                firstteam1franchise = winner_franchise;
                firstteam2 = loser;
                firstteam2points = PtsL;
                firstteam2franchise = loser_franchise;
            }
            else
            {
                firstteam1 = loser;
                firstteam1points = PtsL;
                firstteam1franchise = loser_franchise;
                firstteam2 = winner;
                firstteam2points = PtsW;
                firstteam2franchise = winner_franchise;
            }
            return new FinalScoreMatchup()
            {
                Team1Franchise = firstteam1franchise,
                Team1Name = firstteam1,
                Team1Points = firstteam1points,
                Team2Franchise = firstteam2franchise,
                Team2Name = firstteam2,
                Team2Points = firstteam2points,
                IsNeutralSite = game_location == "N",
                GameWeekSpecial = mt,
                League = league
            };
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(Team1Franchise))
            {
                sb.Append("(");
                sb.Append(Team1Franchise);
                sb.Append(") ");
            }
            sb.Append(Team1Name);
            sb.Append(" ");
            sb.Append(Team1Points);
            sb.Append(" ");
            sb.Append(IsNeutralSite ? "vs" : "at");
            sb.Append(" ");
            sb.Append(Team2Points);
            sb.Append(" ");
            sb.Append(Team2Name);

            //appended text
            if (!string.IsNullOrEmpty(Team2Franchise) || GameWeekSpecial != MatchupType.RegularSeason || League != LeagueType.NFL)
            {
                sb.Append(" ");
                if (!string.IsNullOrEmpty(Team2Franchise))
                {
                    sb.Append("(");
                    sb.Append(Team2Franchise);
                    sb.Append(")");
                }
                if (GameWeekSpecial != MatchupType.RegularSeason)
                {
                    sb.Append("(");
                    sb.Append(GameWeekSpecial);
                    sb.Append(")");
                }
                if (League != LeagueType.NFL)
                {
                    sb.Append("(");
                    sb.Append(League);
                    sb.Append(")");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// team 1 franchise
        /// </summary>
        public required string Team1Franchise { get; set; }

        /// <summary>
        /// team 1 name
        /// </summary>
        public required string Team1Name { get; set; }

        /// <summary>
        /// number of points scored by team 1
        /// </summary>
        public required int Team1Points { get; set; }

        /// <summary>
        /// whether the game is a neutral site
        /// </summary>
        public required bool IsNeutralSite { get; set; }

        /// <summary>
        /// number of points scored by team 2
        /// </summary>
        public required int Team2Points { get; set;  }

        /// <summary>
        /// team 2 name
        /// </summary>
        public required string Team2Name { get; set; }

        /// <summary>
        /// team 2 franchise
        /// </summary>
        public required string Team2Franchise { get; set; }

        /// <summary>
        /// game/week special
        /// </summary>
        public required MatchupType GameWeekSpecial { get; set; }

        /// <summary>
        /// league, if not the NFL
        /// </summary>
        public required LeagueType League { get; set; }
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
}
