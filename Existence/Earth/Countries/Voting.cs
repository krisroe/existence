using Existence.Earth.Alphabet;
using Existence.Time;
using System;

namespace Existence.Earth.Countries
{
    public enum ReferendumChoice
    {
        Yes = 1,
        No = 2
    }

    public class ReferendumChoiceAttribute : Attribute
    {
        public ReferendumChoice ReferendumChoice { get; set; }
        public ReferendumChoiceAttribute(ReferendumChoice ReferendumChoice)
        {
            this.ReferendumChoice = ReferendumChoice;
        }
    }

    public class PoliticianAttribute : Attribute
    {
        public int Politician { get; set; }
        public PoliticianAttribute(int Politician)
        {
            this.Politician = Politician;
        }
    }

    public class PoliticalPartyLeaderAttribute : Attribute
    {
        public int Politician { get; set; }
        public PoliticalPartyLeaderAttribute(int Politician)
        {
            this.Politician = Politician;
        }
    }

    /// <summary>
    /// the joint list the political party ran on with other parties
    /// </summary>
    public class JointListAttribute : Attribute
    {
        public int JointList { get; set; }
        public JointListAttribute(int JointList)
        {
            this.JointList = JointList;
        }
    }

    /// <summary>
    /// political parties that share something, such as one side of a surplus vote agreement. Apply once per group,
    /// e.g. once for each side of the agreement
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class PoliticalPartiesAttribute : Attribute
    {
        public int[] PoliticalParties { get; set; }
        public PoliticalPartiesAttribute(params int[] PoliticalParties)
        {
            this.PoliticalParties = PoliticalParties;
        }
    }

    /// <summary>
    /// percentage of the vote the political party got on its own list. Parties on a joint list have no vote
    /// percentage of their own; the joint list has a JointListVotePercentage instead
    /// </summary>
    public class VotePercentageAttribute : Attribute
    {
        public decimal Percentage { get; set; }
        public VotePercentageAttribute(double Percentage)
        {
            this.Percentage = (decimal)Percentage;
        }
    }

    /// <summary>
    /// percentage of the vote a joint list of several political parties got. Not a subclass of
    /// VotePercentageAttribute, so that vote percentages of joint lists and of parties are kept apart
    /// </summary>
    public class JointListVotePercentageAttribute : Attribute
    {
        public decimal Percentage { get; set; }
        public JointListVotePercentageAttribute(double Percentage)
        {
            this.Percentage = (decimal)Percentage;
        }
    }

    /// <summary>
    /// number of seats the political party won, either on its own list or as its share of a joint list's seats
    /// </summary>
    public class NumberOfSeatsAttribute : Attribute
    {
        public int NumberOfSeats { get; set; }
        public NumberOfSeatsAttribute(int NumberOfSeats)
        {
            this.NumberOfSeats = NumberOfSeats;
        }
    }

    /// <summary>
    /// number of seats a joint list of several political parties won. Not a subclass of NumberOfSeatsAttribute, so
    /// that summing seats of parties doesn't count the joint list's seats again
    /// </summary>
    public class JointListNumberOfSeatsAttribute : Attribute
    {
        public int NumberOfSeats { get; set; }
        public JointListNumberOfSeatsAttribute(int NumberOfSeats)
        {
            this.NumberOfSeats = NumberOfSeats;
        }
    }

    /// <summary>
    /// minimum percentage of the vote a list needs to win seats in a parliament
    /// </summary>
    public class ParliamentaryElectoralThresholdAttribute : Attribute
    {
        public decimal Percentage { get; set; }
        public ParliamentaryElectoralThresholdAttribute(double Percentage)
        {
            this.Percentage = (decimal)Percentage;
        }
    }

    /// <summary>
    /// the political party's list fell below the electoral threshold and won no seats
    /// </summary>
    public class BelowElectoralThresholdAttribute : Attribute
    {
    }

    /// <summary>
    /// the politician was prime minister over the date range. EndDate is null while still in office
    /// </summary>
    public class PrimeMinisterAttribute : Attribute
    {
        public int Politician { get; set; }
        public StartDateAttribute StartDate { get; set; }
        public EndDateAttribute EndDate { get; set; }
        public PrimeMinisterAttribute(int Politician, int StartYear, int StartMonth, int StartDay)
        {
            this.Politician = Politician;
            this.StartDate = new StartDateAttribute(StartYear, StartMonth, StartDay);
        }
        public PrimeMinisterAttribute(int Politician, int StartYear, int StartMonth, int StartDay, int EndYear, int EndMonth, int EndDay) : this(Politician, StartYear, StartMonth, StartDay)
        {
            this.EndDate = new EndDateAttribute(EndYear, EndMonth, EndDay);
        }
    }

    /// <summary>
    /// the politician acted as prime minister over the date range, without formally holding the office for at least
    /// part of it
    /// </summary>
    public class ActingPrimeMinisterAttribute : PrimeMinisterAttribute
    {
        public ActingPrimeMinisterAttribute(int Politician, int StartYear, int StartMonth, int StartDay) : base(Politician, StartYear, StartMonth, StartDay)
        {
        }
        public ActingPrimeMinisterAttribute(int Politician, int StartYear, int StartMonth, int StartDay, int EndYear, int EndMonth, int EndDay) : base(Politician, StartYear, StartMonth, StartDay, EndYear, EndMonth, EndDay)
        {
        }
    }

    /// <summary>
    /// the politician is the current prime minister
    /// </summary>
    public class CurrentPrimeMinisterAttribute : Attribute
    {
    }

    /// <summary>
    /// the politician formally held the office of prime minister over the date range, while someone else acted as
    /// prime minister
    /// </summary>
    public class PaperPrimeMinisterAttribute : PrimeMinisterAttribute
    {
        public PaperPrimeMinisterAttribute(int Politician, int StartYear, int StartMonth, int StartDay) : base(Politician, StartYear, StartMonth, StartDay)
        {
        }
        public PaperPrimeMinisterAttribute(int Politician, int StartYear, int StartMonth, int StartDay, int EndYear, int EndMonth, int EndDay) : base(Politician, StartYear, StartMonth, StartDay, EndYear, EndMonth, EndDay)
        {
        }
    }

    /// <summary>
    /// the factions a political party is split into
    /// </summary>
    public class FactionsAttribute : Attribute
    {
        public int[] Factions { get; set; }
        public FactionsAttribute(params int[] Factions)
        {
            this.Factions = Factions;
        }
    }

    public class IncumbentAttribute : Attribute
    {
        public int? Politician { get; set; }
        public IncumbentAttribute()
        {
        }
        public IncumbentAttribute(int Politician)
        {
            this.Politician = Politician;
        }
    }

    /// <summary>
    /// the politician lost the election and did not publicly concede
    /// </summary>
    public class DidNotConcedeAttribute : Attribute
    {
        public int Politician { get; set; }
        public DidNotConcedeAttribute(int Politician)
        {
            this.Politician = Politician;
        }
    }

    /// <summary>
    /// the politician I personally rooted for in the election.
    /// Rooting is not a meaningless activity
    /// </summary>
    public class IRootedForAttribute : Attribute
    {
        public int Politician { get; set; }
        public IRootedForAttribute(int Politician)
        {
            this.Politician = Politician;
        }
    }

    /// <summary>
    /// the politician I personally predicted would win the election
    /// </summary>
    public class IPredictedElectionWinnerAttribute : Attribute
    {
        public int Politician { get; set; }
        public IPredictedElectionWinnerAttribute(int Politician)
        {
            this.Politician = Politician;
        }
    }

    /// <summary>
    /// the politician who appears likely to win while the result isn't final yet
    /// </summary>
    public class LikelyElectionWinnerAttribute : Attribute
    {
        public int Politician { get; set; }
        public LikelyElectionWinnerAttribute(int Politician)
        {
            this.Politician = Politician;
        }
    }

    /// <summary>
    /// the losing politician did not publicly concede, but reportedly conceded in private
    /// </summary>
    public class OnlyConcededPrivatelyAttribute : Attribute
    {
        public int Politician { get; set; }
        public string ToWho { get; set; }
        public string AllegedWords { get; set; }
        public OnlyConcededPrivatelyAttribute(int Politician, string ToWho, string AllegedWords)
        {
            this.Politician = Politician;
            this.ToWho = ToWho;
            this.AllegedWords = AllegedWords;
        }
    }

    /// <summary>
    /// the losing politician publicly conceded
    /// </summary>
    public abstract class ConcessionAttribute : Attribute
    {
        public int Politician { get; set; }
        protected ConcessionAttribute(int Politician)
        {
            this.Politician = Politician;
        }
    }

    /// <summary>
    /// the losing politician publicly conceded on election night
    /// </summary>
    public class ElectionNightConcessionAttribute : ConcessionAttribute
    {
        public ElectionNightConcessionAttribute(int Politician) : base(Politician)
        {
        }
    }

    /// <summary>
    /// the losing politician publicly conceded after election night, on this date
    /// </summary>
    public class LaterConcessionAttribute : ConcessionAttribute
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public LaterConcessionAttribute(int Politician, int Year, int Month, int Day) : base(Politician)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
        }
    }

    /// <summary>
    /// decimal isn't a valid attribute parameter type, so the results are passed in as doubles and stored as decimals
    /// </summary>
    public class HeadToHeadElectionResultAttribute : Attribute
    {
        public int Winner { get; set; }
        public decimal WinnerResult { get; set; }
        public int Loser { get; set; }
        public decimal LoserResult { get; set; }
        public HeadToHeadElectionResultAttribute(int Winner, double WinnerResult, int Loser, double LoserResult)
        {
            this.Winner = Winner;
            this.WinnerResult = (decimal)WinnerResult;
            this.Loser = Loser;
            this.LoserResult = (decimal)LoserResult;
        }
    }

    /// <summary>
    /// first round of a runoff election; the winner and loser are the top two finishers, who most likely advance to the second round
    /// (unless one of them dies or steps down). decimal isn't a valid attribute parameter type, so the results are passed in as doubles and stored as decimals
    /// </summary>
    public class AmbiguousRunoffElectionResultAttribute : Attribute
    {
        public int FirstPlace { get; set; }
        public decimal FirstPlacePercentage { get; set; }
        public int SecondPlace { get; set; }
        public decimal SecondPlacePercentage { get; set; }
        public int? ThirdPlace { get; set; }
        public decimal? ThirdPlacePercentage { get; set; }
        public AmbiguousRunoffElectionResultAttribute(int Winner, double WinnerResult, int Loser, double LoserResult)
        {
            this.FirstPlace = Winner;
            this.FirstPlacePercentage = (decimal)WinnerResult;
            this.SecondPlace = Loser;
            this.SecondPlacePercentage = (decimal)LoserResult;
        }
        public AmbiguousRunoffElectionResultAttribute(int Winner, double WinnerResult, int Loser, double LoserResult, int ThirdPlace, double ThirdPlaceResult) : this(Winner, WinnerResult, Loser, LoserResult)
        {
            this.ThirdPlace = ThirdPlace;
            this.ThirdPlacePercentage = (decimal)ThirdPlaceResult;
        }
    }

    /// <summary>
    /// percentages of the total votes cast that were valid, invalid (null), and blank. decimal isn't a valid attribute parameter type,
    /// so the percentages are passed in as doubles and stored as decimals
    /// </summary>
    public class VoteValidityAttribute : Attribute
    {
        public decimal ValidPercentage { get; set; }
        public decimal InvalidPercentage { get; set; }
        public decimal BlankPercentage { get; set; }
        public VoteValidityAttribute(double validPercent, double invalidPercent, double blankPercent)
        {
            this.ValidPercentage = (decimal)validPercent;
            this.InvalidPercentage = (decimal)invalidPercent;
            this.BlankPercentage = (decimal)blankPercent;
        }
    }

    public class IdeologyAttribute : TextAttribute
    {
        public string Ideology
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
        public IdeologyAttribute(string Ideology): base(Ideology)
        {
        }
    }
}
