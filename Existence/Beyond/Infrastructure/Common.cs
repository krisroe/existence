
using System;
using System.Collections.Generic;
using Existence.Earth.FieldsOfStudy.Psychology;

namespace Existence.Beyond.Infrastructure
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

    public enum EmotionalCapacity
    {
        None,
        Minimal,
        Developed,
        Normal
    }

    public class CapacityForEmotionAttribute : Attribute
    {
        public Emotions Emotion { get; set; }
        public EmotionalCapacity Capacity { get; set; }
        public CapacityForEmotionAttribute(Emotions Emotion, EmotionalCapacity Capacity)
        {
            this.Emotion = Emotion;
            this.Capacity = Capacity;
        }
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

    public class BeyondObjectVersionAttribute : Attribute
    {
        public Version Version { get; set; }
        public BeyondObjectVersionAttribute(int Major, int Minor, int Build, int Revision)
        {
            this.Version = new Version(Major, Minor, Build, Revision);
        }
    }

    public class TimelessVersionAttribute : Attribute
    {
        public Version Version { get; set; }
        public TimelessVersionAttribute(int Major, int Minor, int Build, int Revision)
        {
            this.Version = new Version(Major, Minor, Build, Revision);
        }
    }

    public abstract class JudgmentDayBase
    {
        public abstract int GetLevel();

        public abstract List<CosmicCharity> GetCosmicCharity();
    }
}
