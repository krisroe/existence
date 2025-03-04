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

    public class QuoteAttribute : Attribute
    {
        public string Location { get; set; }
        public string Quote { get; set; }
        public string Company { get; set; }
        public QuoteAttribute(string Quote)
        {
            this.Quote = Quote;
            this.Location = string.Empty;
            this.Company = string.Empty;
        }
        public QuoteAttribute(string Quote, string Location)
        {
            this.Quote = Quote;
            this.Location = Location;
            this.Company = string.Empty;
        }
        public QuoteAttribute(string Quote, string Location, string Company)
        {
            this.Quote = Quote;
            this.Location = Location;
            this.Company = Company;
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
}
