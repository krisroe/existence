
using System;

namespace Existence.Earth.FieldsOfStudy.Psychology
{
    public static class Concepts
    {
        public class ColorAssociations
        {
            public static class Rainbow
            {
                public static class PeopleHaveAWideRangeOfBehaviorSuchAsHomosexuality { }

                public static class AcronymROYGBIV
                {
                    public static class Red
                    {
                        public static class Stop { }
                        public static class Important { }
                    }
                    public static class Orange
                    {
                        public static class Warning { }
                    }
                    public static class Yellow
                    {
                        public static class Caution { }
                    }
                    public static class Green
                    {
                        public static class Go { }
                        public static class Good { }
                        public static class Grass { }
                    }
                    public static class Blue
                    {
                        public static class Calm { }
                        public static class Safe { }
                    }
                    public static class Indigo
                    {
                        public static class PartOfTheRainbow { }
                    }
                    public static class Purple
                    {
                        public static class PersonalToSomeone { }
                    }
                }
            }

            public static class Tricolor
            {
                public static class RGB
                {
                    public static class Red { }
                    public static class Green { }
                    public static class Blue { }
                }
            }

            public static class TrafficLightPattern
            {
                public static class Red
                {
                    public static class Stop { }
                }
                public static class Yellow
                {
                    public static class Caution { }
                }
                public static class Green
                {
                    public static class Go { }
                }
            }

            public static class Opposites
            {
                public class BlackWhite
                {
                    public static class Black
                    {
                        public static class Death { }
                    }
                    public static class White
                    {
                        public static class Life { }
                    }
                }
            }

            public static class HumanRaces
            {
                public static class White { }
                public static class Black { }
                public static class Yellow { }
                public static class Brown { }
            }
        }

        public class Elevation
        {
            public const string Definition = "Sum Total of All Brain Activity";

            public static class ThingsDependentOnElevation
            {
                public static class Apophenia
                {
                    public static class MakingConnectionsWithApparentlyUnrelatedThings { }
                }
                public static class Creativity { }
                public static class DelusionalThoughts { }
                public static class Synethesia
                {
                    public static class Colors
                    {
                        public static class AppearBrighter { }
                        public static class MeanThingsMore { }
                    }
                }
            }
        }

        public class Emotions
        {
            public static class EmotionalResonance
            {
                public static class AssociationOfAnEmotionWithSomethingSuchAsASong { }
            }

            public static class EmotionalRelease
            {
                public static class Catharsis
                {
                    public static class GainOrLoseEmotionAfterSomethingIsFinished { }
                }
            }


            public class Anger { }
            public class Annoyance { }
            public class Anticipation { }
            public class Anxiety { }
            public class Boredom { }
            public class Enlightenment { }
            public class Fear { }
            public class Happy { }
            public class Hatred { }
            public class Hope { }
            public class Love { }
            public class Lust { }
            public class Rage { }
            public class Sadness { }
        }

        public static class Archetypes
        {
            public static class AntiHero { }
            public static class Hero { }
        }

        public enum MedicationGoals
        {
            Stable,
            Functional,
            AcceptableSideEffects,
            Necessary,
            Emergency,
            WishfulThinking,
            Relevant,
            Confirm,
        }

        public class MedGoalAttribute : Attribute
        {
            public MedicationGoals Goal { get; set; }
            public MedGoalAttribute(MedicationGoals mg)
            {
                Goal = mg;
            }
        }

        public static class Medications
        {
            public static class Lithium
            {
                public const int GenericNumber = 224;
                public static class Effect
                {
                    [MedGoal(MedicationGoals.Stable)]
                    public static class NineHundredMG { }

                    public static class Stated
                    {
                        public static class MoodStabilizer { }
                    }

                    public static class Unstated
                    {
                        public static class RegulatesSelfAwarenessOfSubconsiousProcesses { }
                    }
                }
            }

            public static class Lorazepam
            {
                public static class Helps
                {
                    public static class Sleep { }
                }
                public static class Drawback
                {
                    public static class LowerQualitySleep { }
                }
            }

            public static class Quetiapine
            {
                public const string BrandName = "Seroquel";
                public const int GenericNumber = 260;

                public static class Effect
                {
                    [MedGoal(MedicationGoals.Emergency)]
                    public static class EightHundredMG { }

                    [MedGoal(MedicationGoals.Functional)]
                    public static class SixHundredMG { }

                    [MedGoal(MedicationGoals.Stable)]
                    public static class FourHundredMG { }

                    public static class Stated
                    {
                        public static class AntiPsychotic { }
                    }
                    
                    public static class Unstated
                    {
                        public static class RegulatesConnectionBetweenDifferentAreasOfTheMind
                        {
                            public static class Emotion { }
                            public static class Logic { }
                            public static class Language { }
                        }
                        public static class TherebyReducing
                        {
                            public static class Elevation { }
                        }
                    }
                }

            }
        }

        public static class Psychosis
        {
            public static class Symptoms
            {
                public static class InabilityToDistinguishWhatIsReality { }
                public static class UncontrolledElevationLevel { }
            }
        }


        public static class PsychologicalTrauma
        {
            public static class Memory
            {
                public static class Repressed { }
                public static class Confabulated { }
                public static class Painful { }
            }
        }

        public static class SuspensionOfDisbelief
        {
            public static class BelievingFictionIsRealForThePurposeOfEntertainment { }
        }
    }
}
