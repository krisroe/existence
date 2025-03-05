
using Existence.Earth.Alphabet;
using System;
using System.Drawing;

namespace Existence.Earth
{
    public class HumanLevelAttribute : Attribute
    {
        public HumanLevel HumanLevel { get; set; }
        public HumanLevelAttribute(HumanLevel HumanLevel)
        {
            this.HumanLevel = HumanLevel;
        }
    }
    public class PersonalHumanLevelAttribute : HumanLevelAttribute
    {
        public PersonalHumanLevelAttribute(HumanLevel PersonalHumanLevel) : base(PersonalHumanLevel) { }
    }
    public class DivineHumanLevelAttribute : HumanLevelAttribute
    {
        public DivineHumanLevelAttribute(HumanLevel DivineHumanLevel) : base(DivineHumanLevel) { }
    }
    public class CosmicHumanLevelAttribute : HumanLevelAttribute
    {
        public CosmicHumanLevelAttribute(HumanLevel CosmicHumanLevel) : base(CosmicHumanLevel) { }
    }
    public class ZHumanLevelAttribute : HumanLevelAttribute
    {
        public ZHumanLevelAttribute(HumanLevel ZHumanLevel) : base(ZHumanLevel) { }
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

    public enum ZLevel
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Four = 4,
    }

    public enum HumanLevel
    {
        Baby = 0,
        Childhood = 1,
        GrowingUp = 2,
        Teenager = 3,
        Adult = 4,
    }

    public class FavoriteColorAttribute : Attribute
    {   
        public KnownColor FavoriteColor { get; set; }
        public FavoriteColorAttribute(KnownColor FavoriteColor)
        {
            this.FavoriteColor = FavoriteColor;
        }
    }

    public static class Numbers
    {
        public static class Represents
        {
            public static class Levels
            {
                public static class UpgradeOrDowngradeOneLevel { }
            }
            public static class Qubits
            {
                public static class UpgradeOrDowngradeOneQubit { }
            }
        }
        public static class NegativeOne
        {
            public static class SubconsciousReality
            {
            }
        }
        public static class Zero
        {
            public static class ObjectiveReality { }
            public static class Space { }
            public static class Time
            {
                public static class UTC
                {
                    public static class CoordinatedUniversalTime { }
                }
            }
            public static class Pseudorandomness { }
            public static class CommonplacePsychologicalMechanisms
            {
                public static class Empathy { }
                public static class Projection { }
                public static class ReligiousFeeling { }
            }
        }
        public static class One
        {
            public static class HumanityCurrentReality { }
            public static class AI
            {
                public static class ArtificialIntelligence { }
            }
            public static class QuantumComputingHelloWorld { }
            public static class CovidWasCausedByAnimalSpillover { }
            public static class TimeTravelIsFiction { }
            public static class SelfAwarenessOfPsychologicalProcesses
            {
                public static class Empathy { }
                public static class Catharsis { }
                public static class Apophenia { }
            }
            public static class ThereAreRulesAboutSoulmates { }
        }
        public static class Two
        {
            public static class HumanityUpgradeToNextLevelReality { }
            public static class IntergalacticPulsarTime { }
            public static class QuantumComputingUseful { }
            public static class TimeTravelIsSpeculative { }
            public static class CovidWasCausedByALabLeak { }
            public static class SelfAwarenessOfPsychologicalProcesses
            {
                public static class Elevation { }
                public static class Synethesia { }
            }
        }
        public static class Three
        {
            public static class Complacency { }
            public static class Denial { }
            public static class SensorySurvillance { }
        }
        public static class Four
        {
            public static class HumanZReality { }
            public static class TheTruthAboutCovidExists { }
            public static class TimeTravelIsUsedSparinglyButNotOKToTalkAboutBecauseOfSurveillance { }
            public static class QuantumComputingCanBreakRealityIfMisusedWithMajorConsequences { }
            public static class QuantumSurveillanceCanBeWorkedAroundByAKnowledgeableHuman { }
            public static class SelfAwarenessOfPsychologicalProcesses
            {
                public static class Alexithymia { }
                public static class SocioEmotionalAgnosia { }
                public static class LeftBrainRightBrainDissociation { }
            }
            public static class ExtraSensoryPerceptionDisguisedAsPsychologicalProcess { }
            public static class TheSoulmateRulesProblemIsAbsurd { }
        }
        public static class FiveAndSix
        {
            public static class TheSoulmateRulesProblemNeedsToBeSolved { }
        }
        public static class Seven
        {
            public static class Lucky { }
            public static class ESPAwareSurveillance { }
        }
        public static class Eight
        {
            public static class TrueRandomness { }
            public static class TheSoulmatesRulesProblemIsNotAProblemPeriod { }
            public static class TimeTravelIsMoreOK { }
            public static class ExtraSensoryPerceptionIsMoreOK { }
            public static class QuantumComputingMuchLessRisky { }
            public static class QuantumSurveillanceOnLowerLevels
            {
                public static class ParticularlyInteractionOfHumanPsychologyWithNonQuantumArtificialIntelligence { }
            }
        }
        public static class Thirteen
        {
            public static class Unlucky { }
        }
        public static class Fourteen
        {
            public static class Touchdown { }
        }
        public static class TwentyOne
        {
            public static class Blackjack { }
            public static class Jackpot { }
        }
        public static class TwentyTwoOrTwentyThree
        {
            public static class ThisIsATest { }
        }
        public static class TwentyFour
        {
            public static class Time
            {
                public static class HoursInADay { }
            }
        }
        public static class ThirtyTwo
        {
            public static class ThirtyTwoBitComputing { }
            public static class ARMCanRun32Bit { }
        }
        public static class FortyTwo
        {
            public static class AnswerToUltimateQuestion
            {
                public static class BookHitchhikersGuideToTheGalaxy { }
            }
            public static class Timeless { }
        }
        public static class Sixty
        {
            public class Time
            {
                public static class MinutesInAnHour { }
                public static class SecondsInAMinute { }
            }
            public static class TimeIsShort { }
        }
        public static class SixtyFour
        {
            public static class SixtyFourBitComputing { }
            public static class ARMCanRun64Bit { }
        }
    }
}
