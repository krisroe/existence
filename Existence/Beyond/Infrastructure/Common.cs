
using System;
using System.Collections.Generic;
using Existence.Earth;
using Existence.Earth.FieldsOfStudy.Psychology;
using Existence.Earth.Human.People;
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

    public class TimelessPurposeAttribute : Attribute
    {
        public string Purpose { get; set; }
        public TimelessPurposeAttribute(string Purpose)
        {
            this.Purpose = Purpose;
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
   
    public abstract class SubmissionBase
    {
        public virtual List<LevelJustification> GetLevelJustifications()
        {
            throw new InvalidOperationException();
        }
        public virtual List<TimelessChange>? GetTimelessChanges()
        {
            return null;
        }
    }

    public abstract class JudgmentDayBase
    {
        public virtual List<LevelJustification> GetLevelJustifications()
        {
            throw new InvalidOperationException();
        }
        public virtual List<CosmicCharity>? GetCosmicCharity()
        {
            return null;
        }
        public virtual List<TimelessChange>? GetTimelessChanges()
        {
            return null;
        }
        public virtual List<MissingInformation>? GetMissingInformation()
        {
            throw new InvalidOperationException();
        }
    }

    public class MissingInformation
    {
        public string Info { get; set; }
        public MissingInformation(string Info)
        {
            this.Info = Info;
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

    /// <summary>
    /// rewriting lyrics for funny or satirical purposes
    /// </summary>
    public class ParodySongEvent : SongEvent
    {
        public string Source { get; set; }
        public PeopleEnumerated Parodyer { get; set; }
        public ParodySongEvent(PeopleEnumerated Parodyer, string SongName, string Source) : base(SongName)
        {
            this.Parodyer = Parodyer;
            this.Source = Source;
        }
    }

    /// <summary>
    /// rewriting lyrics for serious or artistic purposes
    /// </summary>
    public class ContrafactumSongEvent : SongEvent
    {
        public string Source { get; set; }
        public PeopleEnumerated Contrafactumer { get; set; }
        public ContrafactumSongEvent(PeopleEnumerated Contrafactumer, string SongName, string Source) : base(SongName)
        {
            this.Contrafactumer = Contrafactumer;
            this.Source = Source;
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

    public class DefiningCharacteristicsAttribute : Attribute
    {
        public string[] Characteristics { get; set; }
        public DefiningCharacteristicsAttribute(params string[] Characteristics)
        {
            this.Characteristics = Characteristics;
        }
    }

    public class CatchPhraseAttribute : Attribute
    {
        public string CatchPhrase { get; set; }
        public CatchPhraseAttribute(string CatchPhrase)
        {
            this.CatchPhrase = CatchPhrase;
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

    public class Pet
    {
        /// <summary>
        /// integer value representing the pet
        /// </summary>
        public int PetValue { get; set; }
        public PetTypes PetType { get; set; }
        public string Name { get; set; }
        public TruthClassification TruthClass { get; set; }

        public Pet(int PetValue, string Name, PetTypes PetType)
        {
            this.PetValue = PetValue;
            this.Name = Name;
            this.PetType = PetType;
            this.TruthClass = TruthClassification.Nonfictional;
        }

        public Pet(int PetValue, string Name, PetTypes PetType, TruthClassification TruthClass) : this(PetValue, Name, PetType)
        {
            this.TruthClass = TruthClass;
        }
    }

    public enum TruthClassification
    {
        Fictional,
        Nonfictional,
        Metaphorical,
    }


    public class PetGraveyard
    {
        public TruthClassification TruthClass { get; set; }
        public List<Pet> Pets { get; set; }
        public PetGraveyard(TruthClassification TruthClass)
        {
            this.TruthClass = TruthClass;
            this.Pets = new List<Pet>();
        }
        public void AddPet(Pet Pet)
        {
            //metaphorical pets can go in any type of pet graveyard
            //fictional pets can be in only fictional pet graveyards
            //nonfictional pets can be in only nonfictional pet graveyards
            bool allowed = false;
            if (this.TruthClass == TruthClassification.Nonfictional)
            {
                allowed = Pet.TruthClass == TruthClassification.Nonfictional || Pet.TruthClass == TruthClassification.Metaphorical;
            }
            else if (this.TruthClass == TruthClassification.Fictional)
            {
                allowed = Pet.TruthClass == TruthClassification.Fictional || Pet.TruthClass == TruthClassification.Metaphorical;
            }
            else if (this.TruthClass == TruthClassification.Metaphorical)
            {
                allowed = Pet.TruthClass == TruthClassification.Metaphorical;
            }
            else
            {
                throw new InvalidOperationException();
            }
            if (!allowed)
            {
                throw new InvalidOperationException();
            }
            this.Pets.Add(Pet);
        }
    }

    public class CorrespondsToAttribute : Attribute
    {
        public int Who { get; set; }
        public CorrespondsToAttribute(int Who)
        {
            this.Who = Who;
        }
    }

    public class LevelJustification
    {
    }
    public class ProofJustification : LevelJustification
    {
        public string Proved { get; set; }
        public ProofJustification(string Proved)
        {
            this.Proved = Proved;
        }
    }
    public class DocumentsJustification : LevelJustification
    {
        public string[] Documents { get; set; }
        public DocumentsJustification(params string[] Documents)
        {
            this.Documents = Documents;
        }
    }

    public class ReleaseSongJustification : LevelJustification
    {
        public SongEvent Song { get; set; }
        public SongJustificationType Justification { get; set; }
        public ReleaseSongJustification(SongEvent Song, SongJustificationType Justification)
        {
            this.Song = Song;
            this.Justification = Justification;
        }
    }
    public enum SongJustificationType
    {
        ReleaseSong,
        ReleaseSongMeaning,
        InterpretSongMeaning,
    }
}
