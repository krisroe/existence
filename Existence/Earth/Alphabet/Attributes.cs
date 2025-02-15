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

    public class QuoteAttribute : TextAttribute
    {
        public string Quote
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
        public QuoteAttribute(string Quote) : base(Quote)
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
}
