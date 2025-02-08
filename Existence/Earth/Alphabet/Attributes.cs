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
}
