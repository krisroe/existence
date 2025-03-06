using Existence.Earth.Alphabet;
using System;
using System.Collections.Generic;

namespace Existence.JudgmentDay
{
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

    public class CosmicCharity(int Amount, int Target, string Reason)
    {
        public int Amount { get; set; }
        public int Target { get; set; }
        public string Reason { get; set; }
    }

    public class IsReleasedAttribute : Attribute
    {
        public bool IsReleased { get; set; }
        public IsReleasedAttribute(bool IsReleased)
        {
            this.IsReleased = IsReleased;
        }
    }

    public abstract class JudgmentDayBase
    {
        public abstract int GetLevel();

        public abstract List<CosmicCharity> GetCosmicCharity();
    }
}
