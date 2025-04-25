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
