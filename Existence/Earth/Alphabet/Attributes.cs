using System;

namespace Existence.Earth.Alphabet
{
    public class TextAttribute : Attribute
    {
        protected string Text { get; set; }
        public TextAttribute(string Text)
        {
            this.Text = Text;
        }
    }

    public class TextsAttribute : Attribute
    {
        protected string[] Texts { get; set; }
        public TextsAttribute(params string[] Texts)
        {
            this.Texts = Texts;
        }
    }

    public class LocationAttribute : TextAttribute
    {
        public string Place
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
        public LocationAttribute(string AKA) : base(AKA)
        {
        }
    }
    public class AlsoKnownAsAttribute : TextAttribute
    {
        public string AKA
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
        public AlsoKnownAsAttribute(string AKA) : base(AKA)
        {
        }
    }

    public class WorkTicketAttribute : TextAttribute
    {
        public string Ticket
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
        public WorkTicketAttribute(string Ticket) : base(Ticket) { }
    }

    public class BiblePassageAttribute : Attribute
    {
        public string Verse { get; set; }

        public BiblePassageAttribute(string Verse)
        {
            this.Verse = Verse;
        }
    }

    public class QuoteAttribute : Attribute
    {
        public string Location { get; set; }
        public string Quote { get; set; }
        public string Company { get; set; }
        public string SaidBy { get; set; }
        public QuoteAttribute(string Quote)
        {
            this.Quote = Quote;
            this.SaidBy = string.Empty;
            this.Location = string.Empty;
            this.Company = string.Empty;
        }
        public QuoteAttribute(string Quote, string SaidBy, string Location, string Company)
        {
            this.Quote = Quote;
            this.SaidBy = SaidBy;
            this.Location = Location;
            this.Company = Company;
        }
    }

    public class MagicWordsAttribute : QuoteAttribute
    {
        public MagicWordsAttribute(string Quote, string SaidBy, string Location, string Company) : base(Quote,SaidBy, Location, Company)
        {
        }
    }

    public class ConsequencesAttribute : TextAttribute
    {
        public string Consequences
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
        public ConsequencesAttribute(string Consequences) : base(Consequences)
        {
        }
    }

    public class ObservationAttribute : TextAttribute
    {
        public string Observation
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
        public ObservationAttribute(string Observation) : base(Observation)
        {

        }
    }

    public class TODOAttribute : TextAttribute
    {
        public string TODO
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
        public TODOAttribute(string TODO) : base(TODO)
        {
        }
    }

    public class ShortNameAttribute : TextAttribute
    {
        public string ShortName
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
        public ShortNameAttribute(string ShortName) : base(ShortName)
        {
        }
    }

    public class BirthNameAttribute : TextAttribute
    {
        public string BirthName
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
        public BirthNameAttribute(string BirthName) : base(BirthName)
        {
        }
    }

    public class BirthplaceAttribute : Attribute
    {
        public int Country { get; set; }
        public int City { get; set; }
        public BirthplaceAttribute(int Country, int City)
        {
            this.Country = Country;
            this.City = City;
        }
    }

    public class FullNameAttribute : TextAttribute
    {
        public string FullName
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
        public FullNameAttribute(string FullName) : base(FullName)
        {

        }
    }

    public class AbbreviationAttribute : TextAttribute
    {
        public string Abbreviation
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
        public AbbreviationAttribute(string Abbreviation) : base(Abbreviation)
        {

        }
    }

    public class PronounAttribute : TextAttribute
    {
        public string Pronoun
        {
            get { return base.Text; }
            set { base.Text = value; }
        }
        public PronounAttribute(string Pronoun) : base(Pronoun) { }
    }

    public class FirstNameAttribute : TextAttribute
    {
        public string FirstName
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
        public FirstNameAttribute(string FirstName) : base(FirstName)
        {
        }
    }

    public class LastNameAttribute : TextAttribute
    {
        public string LastName
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
        public LastNameAttribute(string LastName) : base(LastName)
        {
        }
    }
}
