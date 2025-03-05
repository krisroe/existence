using Existence.Earth.Alphabet;
using System;

namespace Existence
{
    public class JudgmentDayLevelAttribute : Attribute
    {
        public int Level { get; set; }
        public JudgmentDayLevelAttribute(int Level)
        {
            this.Level = Level;
        }
    }

    public class ZLevelAttribute : Attribute
    {
        public ZLevel ZLevel { get; set; }
        public ZLevelAttribute(ZLevel ZLevel)
        {
            this.ZLevel = ZLevel;
        }
    }
    public class CosmicZLevelAttribute : ZLevelAttribute
    {
        public CosmicZLevelAttribute(ZLevel CosmicZLevel) : base(CosmicZLevel) { }
    }
    public class PersonalZLevelAttribute : ZLevelAttribute
    {
        public PersonalZLevelAttribute(ZLevel PersonalZLevel) : base(PersonalZLevel) { }
    }

    public class PersonalFirst : TextAttribute
    {
        public string Thing
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
        public PersonalFirst(string Thing) : base(Thing)
        {

        }
    }

    public class URIAttribute : TextAttribute
    {
        public string URI
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
        public URIAttribute(string URI) : base(URI)
        {

        }
    }

    public class RepositoryNameAttribute : TextAttribute
    {
        public string Name
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
        public RepositoryNameAttribute(string Name) : base(Name)
        {
        }
    }

    public class SignificantMemory : TextAttribute
    {
        public string Memory
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
        public SignificantMemory(string Memory) : base(Memory)
        {
        }
    }

    public enum ZLevel
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Four = 4,
    }


    public enum PlaceType
    {
        Home,
        Church,
        School,
    }
}
