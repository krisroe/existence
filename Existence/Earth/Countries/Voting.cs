using Existence.Earth.Alphabet;
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
