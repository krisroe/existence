
using System;
using System.Collections.Generic;
using Existence.Earth;
using Existence.Earth.FieldsOfStudy.Psychology;
using Existence.Earth.Human.People;
using Existence.Time;

namespace Existence.Beyond.Infrastructure
{
    internal class ZLevelAttribute : Attribute
    {
        internal ZLevel ZLevel { get; set; }
        internal ZLevelAttribute(ZLevel ZLevel)
        {
            this.ZLevel = ZLevel;
        }
    }
    internal class CosmicZLevelAttribute : ZLevelAttribute
    {
        internal CosmicZLevelAttribute(ZLevel CosmicZLevel) : base(CosmicZLevel) { }
    }
    internal class PersonalZLevelAttribute : ZLevelAttribute
    {
        internal PersonalZLevelAttribute(ZLevel PersonalZLevel) : base(PersonalZLevel) { }
    }

    internal enum ZLevel
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Four = 4,
    }


    internal enum PlaceType
    {
        Home,
        Church,
        School,
    }

    internal enum EmotionalCapacity
    {
        None,
        Minimal,
        Developed,
        Normal
    }

    internal enum CosmicProcess
    {
        RealityManipulation
    }

    internal enum CosmicResponsibility
    {
        Irresponsible,
        Responsible
    }

    internal enum CosmicTimeScale
    {
        HumanShortTerm,
        HumanLongTerm,
    }

    internal enum CosmicTimeInterval
    {
        Days,
        Months,
    }

    internal class CapacityForEmotionAttribute : Attribute
    {
        internal Emotions Emotion { get; set; }
        internal EmotionalCapacity Capacity { get; set; }
        internal CapacityForEmotionAttribute(Emotions Emotion, EmotionalCapacity Capacity)
        {
            this.Emotion = Emotion;
            this.Capacity = Capacity;
        }
    }

    internal class CosmicPayday
    {
        internal CosmicPayday(int Amount, string Reason)
        {
            this.Amount = Amount;
            this.Reason = Reason;
        }
        internal int Amount { get; set; }
        internal string Reason { get; set; }
    }

    internal class CosmicCharity
    {
        internal CosmicCharity(int Amount, int Target, string Reason)
        {
            this.Amount = Amount;
            this.Target = Target;
            this.Reason = Reason;
        }
        internal int Amount { get; set; }
        internal int Target { get; set; }
        internal string Reason { get; set; }
    }

    internal class IsReleasedAttribute : Attribute
    {
        internal bool IsReleased { get; set; }
        internal IsReleasedAttribute(bool IsReleased)
        {
            this.IsReleased = IsReleased;
        }
    }

    internal class BeyondObjectVersionAttribute : Attribute
    {
        internal Version Version { get; set; }
        internal BeyondObjectVersionAttribute(int Major, int Minor, int Build, int Revision)
        {
            this.Version = new Version(Major, Minor, Build, Revision);
        }
    }

    internal class TimelessPurposeAttribute : Attribute
    {
        internal string Purpose { get; set; }
        internal TimelessPurposeAttribute(string Purpose)
        {
            this.Purpose = Purpose;
        }
    }

    internal class CosmicProcessResponsibilityAttribute : Attribute
    {
        internal CosmicResponsibility Responsibility { get; set; }
        internal CosmicProcess Process { get; set; }
        internal CosmicProcessResponsibilityAttribute(CosmicProcess Process, CosmicResponsibility Responsibility)
        {
            this.Process = Process;
            this.Responsibility = Responsibility;
        }
    }
    
    internal class CosmicTimeScaleAttribute : Attribute
    {
        internal CosmicTimeScale TimeScale { get; set; }
        internal CosmicTimeInterval Interval { get; set; }
        internal CosmicTimeScaleAttribute(CosmicTimeScale TimeScale, CosmicTimeInterval Interval)
        {
            this.TimeScale = TimeScale;
            this.Interval = Interval;
        }
    }
   
    internal abstract class SubmissionBase
    {
        internal virtual List<LevelJustification> GetLevelJustifications()
        {
            throw new InvalidOperationException();
        }
        internal virtual List<TimelessChange>? GetTimelessChanges()
        {
            return null;
        }
    }

    internal abstract class JudgmentDayBase
    {
        internal virtual List<LevelJustification> GetLevelJustifications()
        {
            throw new InvalidOperationException();
        }
        internal virtual List<CosmicCharity>? GetCosmicCharity()
        {
            return null;
        }
        internal virtual List<TimelessChange>? GetTimelessChanges()
        {
            return null;
        }
        internal virtual List<MissingInformation>? GetMissingInformation()
        {
            throw new InvalidOperationException();
        }
    }

    internal class MissingInformation
    {
        internal string Info { get; set; }
        internal MissingInformation(string Info)
        {
            this.Info = Info;
        }
    }

    internal abstract class CosmicCharityBase
    {
        internal abstract List<CosmicCharity> GetCosmicCharity();
    }

    internal abstract class CosmicPaydayBase
    {
        internal abstract List<CosmicPayday> GetCosmicPayday();
    }

    internal class TerminalEvent
    {
        internal string EventName { get; set; }
        internal BaseEvent[] PreviousEvents { get; set; }
        internal TerminalEvent(string EventName, params BaseEvent[] PreviousEvents)
        {
            this.EventName = EventName;
            this.PreviousEvents = PreviousEvents;
        }
    }

    internal class BaseEvent
    {
        internal string EventName { get; set; }
        internal BaseEvent? PreviousEvent;

        internal BaseEvent(string EventName)
        {
            this.EventName = EventName;
            PreviousEvent = null;
        }
    }

    internal class VoteEvent : BaseEvent
    {
        internal int? Who { get; set; }
        internal bool? Won { get; set; }
        internal VoteEvent(int? Who, string What, bool? Won) : base(What)
        {
            this.Who = Who;
            this.Won = Won;
        }
    }

    internal class SongEvent : BaseEvent
    {
        internal SongEvent(string SongName) : base(SongName)
        {
        }
    }

    internal class TimelessSongEvent : BaseEvent
    {
        internal int Owner { get; set; }
        internal TimelessSongEvent(string SongName, int Owner) : base(SongName)
        {
            this.Owner = Owner;
        }
    }

    /// <summary>
    /// rewriting lyrics for funny or satirical purposes
    /// </summary>
    internal class ParodySongEvent : SongEvent
    {
        internal string Source { get; set; }
        internal PeopleEnumerated Parodyer { get; set; }
        internal ParodySongEvent(PeopleEnumerated Parodyer, string SongName, string Source) : base(SongName)
        {
            this.Parodyer = Parodyer;
            this.Source = Source;
        }
    }

    /// <summary>
    /// rewriting lyrics for serious or artistic purposes
    /// </summary>
    internal class ContrafactumSongEvent : SongEvent
    {
        internal string Source { get; set; }
        internal PeopleEnumerated Contrafactumer { get; set; }
        internal ContrafactumSongEvent(PeopleEnumerated Contrafactumer, string SongName, string Source) : base(SongName)
        {
            this.Contrafactumer = Contrafactumer;
            this.Source = Source;
        }
    }

    internal class OriginalSongEvent : BaseEvent
    {
        internal OriginalSongEvent(string SongName) : base(SongName)
        {
        }
    }

    internal enum SongInterpretationLevel
    {
        ModernHuman,
        IntergalacticPulsarTime,
        PostIntergalacticPulsarTime,
    }

    internal class SongInterpretationLevelsAttribute : Attribute
    {
        internal SongInterpretationLevel[] Levels { get; set; }

        internal SongInterpretationLevelsAttribute(params SongInterpretationLevel[] Levels)
        {
            this.Levels = Levels;
        }
    }

    internal class CosmicRequest : Attribute
    {
        internal string Request { get; set; }
        internal CosmicRequest(string Request)
        {
            this.Request = Request;
        }
    }

    internal class DefiningCharacteristicsAttribute : Attribute
    {
        internal string[] Characteristics { get; set; }
        internal DefiningCharacteristicsAttribute(params string[] Characteristics)
        {
            this.Characteristics = Characteristics;
        }
    }

    internal class CatchPhraseAttribute : Attribute
    {
        internal string CatchPhrase { get; set; }
        internal CatchPhraseAttribute(string CatchPhrase)
        {
            this.CatchPhrase = CatchPhrase;
        }
    }

    internal class TimelessChange
    {
        internal string Description { get; set; }
        internal TimelessChange(string Description)
        {
            this.Description = Description;
        }
    }

    internal class SomeoneSaidSomethingAndIFoundOutViaHearsay : BaseEvent
    {
        internal int PersonWhoSaidIt { get; set; }
        internal int PersonWhoToldMe { get; set; }
        internal SomeoneSaidSomethingAndIFoundOutViaHearsay(string WhatWasSaid, int PersonWhoSaidIt, int PersonWhoToldMe) : base(WhatWasSaid)
        {
            this.PersonWhoSaidIt = PersonWhoSaidIt;
            this.PersonWhoToldMe = PersonWhoToldMe;
        }
    }

    internal class SomeoneTouchedSomeoneElse : BaseEvent
    {
        internal int TouchingPerson { get; set; }
        internal int TouchedPerson { get; set; }
        internal SomeoneTouchedSomeoneElse(string Description, int TouchingPerson, int TouchedPerson) : base(Description)
        {
            this.TouchingPerson = TouchingPerson;
            this.TouchedPerson = TouchedPerson;
        }
    }

    internal class SomeoneFeltEmotion : BaseEvent
    {
        internal int Who { get; set; }
        internal SomeoneFeltEmotion(string Description, int Who, Emotions Emotion) : base(Description)
        {
            this.Who = Who;
        }
    }

    internal class DeathEvent : BaseEvent
    {
        internal int Who { get; set; }
        internal DateTime Date { get; set; }
        internal CausesOfDeath Cause { get; set; }
        internal DeathEvent(string Description, int Who, int Year, int Month, int Day, CausesOfDeath Cause) : base(Description)
        {
            this.Who = Who;
            this.Date = new DateTime(Year, Month, Day);
            this.Cause = Cause;
        }
    }
    internal class MindDeathEvent : DeathEvent
    {
        internal MindDeathEvent(string Description, int Who, int Year, int Month, int Day, CausesOfDeath Cause)
            : base(Description, Who, Year, Month, Day, Cause)
        {
        }
    }
    internal class BodyDeathEvent : DeathEvent
    {
        internal BodyDeathEvent(string Description, int Who, int Year, int Month, int Day, CausesOfDeath Cause)
            : base(Description, Who, Year, Month, Day, Cause)
        {
        }
    }

    internal class Pet
    {
        /// <summary>
        /// integer value representing the pet
        /// </summary>
        internal int? PetValue { get; set; }
        internal PetTypes PetType { get; set; }
        internal List<string> Names { get; set; }
        internal TruthClassification TruthClass { get; set; }
        internal string? DefiningCharacteristics { get; set; }
        internal string? CatchPhrase { get; set; }
        internal PetEyeColors[]? EyeColors { get; set; }
        internal Sexes? Sex { get; set; }
        internal int? BirthYear { get; set; }

        internal Pet(string Name, PetTypes PetType, TruthClassification TruthClass) : this(null, Name, PetType, TruthClass)
        {
        }

        internal Pet(int? PetValue, string Name, PetTypes PetType, TruthClassification TruthClass)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new InvalidOperationException();
            }
            this.PetValue = PetValue;
            this.Names = new List<string>() { Name };
            this.PetType = PetType;
            this.TruthClass = TruthClass;
        }
    }

    internal class TruthClassificationAttribute : Attribute
    {
        internal TruthClassification TruthClass { get; set; }
        internal TruthClassificationAttribute(TruthClassification TruthClass)
        {
            this.TruthClass = TruthClass;
        }
    }

    internal enum TruthClassification
    {
        Fictional,
        Nonfictional,
        Metaphorical,
    }

    internal class FloatingTimelineAttribute : Attribute
    {
        internal int Year { get; set; }
        internal FloatingTimelineAttribute(int Year)
        {
            this.Year = Year;
        }
    }


    internal class PetGraveyard
    {
        internal TruthClassification TruthClass { get; set; }
        internal List<Pet> Pets { get; set; }
        internal PetGraveyard(TruthClassification TruthClass)
        {
            this.TruthClass = TruthClass;
            this.Pets = new List<Pet>();
        }
        internal void AddPet(Pet Pet)
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

    internal class CorrespondsToAttribute : Attribute
    {
        internal int Who { get; set; }
        internal CorrespondsToAttribute(int Who)
        {
            this.Who = Who;
        }
    }

    internal class LevelJustification
    {
    }

    internal class NumberJustification : LevelJustification
    {
        internal int Number;
        internal string Object;
        internal string Explanation;
        public NumberJustification(int Number, string Object, string Explanation)
        {
            this.Number = Number;
            this.Object = Object;
            this.Explanation = Explanation;
        }
    }

    internal class ProofJustification : LevelJustification
    {
        internal string Proved { get; set; }
        internal ProofJustification(string Proved)
        {
            this.Proved = Proved;
        }
    }
    internal class DocumentsJustification : LevelJustification
    {
        internal string[] Documents { get; set; }
        internal DocumentsJustification(params string[] Documents)
        {
            this.Documents = Documents;
        }
    }

    internal class ReleaseSongJustification : LevelJustification
    {
        internal SongEvent Song { get; set; }
        internal SongJustificationType Justification { get; set; }
        internal ReleaseSongJustification(SongEvent Song, SongJustificationType Justification)
        {
            this.Song = Song;
            this.Justification = Justification;
        }
    }
    internal enum SongJustificationType
    {
        ReleaseSong,
        ReleaseSongMeaning,
        InterpretSongMeaning,
    }

    internal class MaleSiblingCountAttribute : SiblingCountAttribute
    {
        internal MaleSiblingCountAttribute(int MinCount, int MaxCount) : base(MinCount, MaxCount, Sexes.Male)
        {
        }
    }

    internal class FemaleSiblingCountAttribute : SiblingCountAttribute
    {
        internal FemaleSiblingCountAttribute(int MinCount, int MaxCount) : base(MinCount, MaxCount, Sexes.Female)
        {

        }
    }

    internal class SiblingCountAttribute : Attribute
    {
        internal int MinCount { get; set; }
        internal int MaxCount { get; set; }
        internal Sexes Sex { get; set; }
        internal SiblingCountAttribute(int MinCount, int MaxCount, Sexes Sex)
        {
            this.MinCount = MinCount;
            this.MaxCount = MaxCount;
            this.Sex = Sex;
        }
    }

    internal class MeAttribute : Attribute
    {
    }

    internal static class TimelessStatic
    {
        internal const string TO_BE_DETERMINED = "*";
    }
}
