
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

        public class Synesthesia
        {
            public static class Colors
            {
                public static class AppearBrighter { }
                public static class MeanThingsMore { }
            }
        }

        public class Elevation
        {
            public const string Definition = "Sum Total of All Brain Activity";

            public static class Excessive
            {
                public static class Hypomania
                {
                    public static class FunctioningSomewhatCompromised { }
                }
                public static class Mania
                {
                    public static class FunctioningVeryCompromised { }
                }
            }

            public static class PotentiallyProblematicPsychologicalAspects
            {
                /// <summary>
                /// lack of sensory information for certain types of things
                /// </summary>
                public static class Agnosia
                {
                    public static class ProbablyOtherTypes { }
                    public static class SocioEmotional { }
                }
                public static class Alexithymia { }
                public static class Delusions { }
            }

            public static class CouldBePositiveOrNegativeAspectsOfHigherElevation
            {
                public static class Apophenia { }
                public static class Synethesia { }
            }

            public static class PositiveAspectsOfHigherElevation
            {
                public static class Creativity { }
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
            public static class Abilify
            {
                public static class Stated
                {
                    public static class AntiPsychotic { }
                }
                public static class Unstated
                {
                    public static class RegulatesEmotionalProcessing { }
                }
            }

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
                        public static class Regulates
                        {
                            public static class ConsciousAwarenessOfSubconsciousProcesses { }
                        }
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
                        public static class RegulatesConnectionBetween
                        {
                            public static class Emotion { }
                            public static class Language { }
                        }
                        public static class TherebyReducing
                        {
                            public static class Elevation { }
                        }
                        public static class SomewhatEquivalentTo
                        {
                            public static class Alexithymia { }
                        }
                    }
                }

            }
        }

        public static class Human
        {
            public static class Comprises
            {
                public static class Brain
                {
                    public static class Deterministic { }
                    public static class Parts
                    {
                        public static class PreFrontalCortex
                        {
                            public static class DecisionMaking { }
                            public static class SocialBehavior { }
                        }

                        public static class LeftHemisphere
                        {
                            public static class Performs
                            {
                                public static class Analytics { }
                                public static class Logic { }
                                public static class Language { }
                            }
                        }

                        public static class Communication
                        {
                            public static class CorpusCallosum
                            {
                                public static class RegulatesConnectionBetweenAreas
                                {
                                    public static class LeftHemisphere { }
                                    public static class RightHemisphere { }
                                }
                            }

                            public static class AgnosiaSwitch
                            {
                                public static class SocioEmotional
                                {
                                    public static class RegulatesConnectionBetweenAreas
                                    {
                                        public static class Social { }
                                        public static class Emotion { }
                                    }
                                }
                            }

                            public static class AlexithymiaSwitch
                            {
                                public static class RegulatesConnectionBetweenAreas
                                {
                                    public static class Language { }
                                    public static class Emotion { }
                                }
                            }
                        }

                        public static class DopamineNeurotransmitter
                        {
                            public static class Manages
                            {
                                public static class Motivation { }
                                public static class PatternDetection { }
                                public static class Reward { }
                            }
                            public static class CorrelatedWith
                            {
                                public static class Apophenia { }
                            }
                        }

                        public static class Amygdala
                        {
                            public static class Emotion
                            {
                                public static class Facial
                                {
                                    public static class Expression { }

                                }
                            }
                        }

                        public static class RightHemisphere
                        {
                            public static class Creativity { }
                            public static class Intuition { }
                            public static class Spatial { }
                        }
                    }
                }

                public static class Mind
                {
                    public static class SelfAwareness
                    {
                        public static class DisruptedByExcessiveElevation { }
                    }

                    public static class Ethics
                    {
                        public static class Comprises
                        {
                            public static class Consciousness
                            {
                                public static class LogicalReasoning { }
                                public static class EthicalPrinciples { }
                            }
                            public static class Subconscious
                            {
                                public static class SenseOfRightAndWrong 
                                {
                                    public static class Figurative
                                    {
                                        public static class DevilAndAngelOnYourShoulders { }
                                    }
                                    public static class Literal
                                    {
                                        public static class FeelingsOnRightAndLeftSideOfThroat
                                        {
                                            public static class Applause { }
                                            public static class No { }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    public static class FreeWill { }
                }
            }
            public static class Sentience { }
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
