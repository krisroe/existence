using Existence.Earth.Alphabet;

namespace Existence.Personal.Infrastructure
{
    public class PersonalFirst : TextAttribute
    {
        public string Thing
        {
            get
            {
                return Text;
            }
            set
            {
                Text = value;
            }
        }
        public PersonalFirst(string Thing) : base(Thing)
        {

        }
    }

    public class SignificantMemory : TextAttribute
    {
        public string Memory
        {
            get
            {
                return Text;
            }
            set
            {
                Text = value;
            }
        }
        public SignificantMemory(string Memory) : base(Memory)
        {
        }
    }
}
