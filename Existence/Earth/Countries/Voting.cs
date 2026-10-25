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
