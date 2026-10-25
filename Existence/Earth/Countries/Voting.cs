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
