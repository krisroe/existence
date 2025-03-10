
using System;
using System.Collections.Generic;
using Existence.Earth.FieldsOfStudy.Psychology;
using Existence.Time;

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

    public enum CosmicProcess
    {
        RealityManipulation
    }

    public enum CosmicResponsibility
    {
        Irresponsible,
        Responsible
    }

    public enum CosmicTimeScale
    {
        HumanShortTerm,
        HumanLongTerm,
    }

    public enum CosmicTimeInterval
    {
        Days,
        Months,
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

    public class CosmicPayday
    {
        public CosmicPayday(int Amount, string Reason)
        {
            this.Amount = Amount;
            this.Reason = Reason;
        }
        public int Amount { get; set; }
        public string Reason { get; set; }
    }

    public class CosmicCharity
    {
        public CosmicCharity(int Amount, int Target, string Reason)
        {
            this.Amount = Amount;
            this.Target = Target;
            this.Reason = Reason;
        }
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

    public class CosmicProcessResponsibilityAttribute : Attribute
    {
        public CosmicResponsibility Responsibility { get; set; }
        public CosmicProcess Process { get; set; }
        public CosmicProcessResponsibilityAttribute(CosmicProcess Process, CosmicResponsibility Responsibility)
        {
            this.Process = Process;
            this.Responsibility = Responsibility;
        }
    }
    
    public class CosmicTimeScaleAttribute : Attribute
    {
        public CosmicTimeScale TimeScale { get; set; }
        public CosmicTimeInterval Interval { get; set; }
        public CosmicTimeScaleAttribute(CosmicTimeScale TimeScale, CosmicTimeInterval Interval)
        {
            this.TimeScale = TimeScale;
            this.Interval = Interval;
        }
    }
   

    public abstract class JudgmentDayBase
    {
        public abstract int GetLevel();

        public virtual List<CosmicCharity>? GetCosmicCharity()
        {
            return null;
        }
        public virtual List<TimelessChange>? GetTimelessChanges()
        {
            return null;
        }
    }

    public abstract class CosmicCharityBase
    {
        public abstract List<CosmicCharity> GetCosmicCharity();
    }

    public abstract class CosmicPaydayBase
    {
        public abstract List<CosmicPayday> GetCosmicPayday();
    }

    public class TerminalEvent
    {
        public string EventName { get; set; }
        public BaseEvent[] PreviousEvents { get; set; }
        public TerminalEvent(string EventName, params BaseEvent[] PreviousEvents)
        {
            this.EventName = EventName;
            this.PreviousEvents = PreviousEvents;
        }
    }

    public class BaseEvent
    {
        public string EventName { get; set; }
        public BaseEvent? PreviousEvent;

        public BaseEvent(string EventName)
        {
            this.EventName = EventName;
            PreviousEvent = null;
        }
    }

    public class SongEvent : BaseEvent
    {
        public SongEvent(string SongName) : base(SongName)
        {
        }
    }

    public class ParodySongEvent : SongEvent
    {
        public string Parodies { get; set; }
        public ParodySongEvent(string SongName, string Parodies) : base(SongName)
        {
            this.Parodies = Parodies;
        }
    }

    public class OriginalSongEvent : BaseEvent
    {
        public OriginalSongEvent(string SongName) : base(SongName)
        {
        }
    }

    public enum SongInterpretationLevel
    {
        ModernHuman,
        IntergalacticPulsarTime,
        PostIntergalacticPulsarTime,
    }

    public class SongInterpretationLevelsAttribute : Attribute
    {
        public SongInterpretationLevel[] Levels { get; set; }

        public SongInterpretationLevelsAttribute(params SongInterpretationLevel[] Levels)
        {
            this.Levels = Levels;
        }
    }

    public class CosmicRequest : Attribute
    {
        public string Request { get; set; }
        public CosmicRequest(string Request)
        {
            this.Request = Request;
        }
    }

    public class TimelessChange
    {
        public string Description { get; set; }
        public TimelessChange(string Description)
        {
            this.Description = Description;
        }
    }

    public class SomeoneSaidSomethingAndIFoundOutViaHearsay : BaseEvent
    {
        public int PersonWhoSaidIt { get; set; }
        public int PersonWhoToldMe { get; set; }
        public SomeoneSaidSomethingAndIFoundOutViaHearsay(string WhatWasSaid, int PersonWhoSaidIt, int PersonWhoToldMe) : base(WhatWasSaid)
        {
            this.PersonWhoSaidIt = PersonWhoSaidIt;
            this.PersonWhoToldMe = PersonWhoToldMe;
        }
    }

    public class SomeoneTouchedSomeoneElse : BaseEvent
    {
        public int TouchingPerson { get; set; }
        public int TouchedPerson { get; set; }
        public SomeoneTouchedSomeoneElse(string Description, int TouchingPerson, int TouchedPerson) : base(Description)
        {
            this.TouchingPerson = TouchingPerson;
            this.TouchedPerson = TouchedPerson;
        }
    }

    public class SomeoneFeltEmotion : BaseEvent
    {
        public int Who { get; set; }
        public SomeoneFeltEmotion(string Description, int Who, Emotions Emotion) : base(Description)
        {
            this.Who = Who;
        }
    }

    public class DeathEvent : BaseEvent
    {
        public int Who { get; set; }
        public DateTime Date { get; set; }
        public CausesOfDeath Cause { get; set; }
        public DeathEvent(string Description, int Who, int Year, int Month, int Day, CausesOfDeath Cause) : base(Description)
        {
            this.Who = Who;
            this.Date = new DateTime(Year, Month, Day);
            this.Cause = Cause;
        }
    }
    public class MindDeathEvent : DeathEvent
    {
        public MindDeathEvent(string Description, int Who, int Year, int Month, int Day, CausesOfDeath Cause)
            : base(Description, Who, Year, Month, Day, Cause)
        {
        }
    }
    public class BodyDeathEvent : DeathEvent
    {
        public BodyDeathEvent(string Description, int Who, int Year, int Month, int Day, CausesOfDeath Cause)
            : base(Description, Who, Year, Month, Day, Cause)
        {
        }
    }
}
