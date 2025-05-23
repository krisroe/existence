﻿
using System;
using System.Collections.Generic;
using Existence.Earth.Alphabet;
using static Existence.Earth.FieldsOfStudy.Psychology.Concepts;

namespace Existence.Personal
{
    public static class Psychology
    {
        /// <summary>
        /// importance for psychosis events
        /// </summary>
        public enum EventImportance
        {
            /// <summary>
            /// must clearly be unrelated to your mental state
            /// </summary>
            Meaningless,

            /// <summary>
            /// can try to work your way through it
            /// </summary>
            Relevant,

            /// <summary>
            /// you really need to work through reducing psychoses
            /// </summary>
            Serious,

            /// <summary>
            /// a manic episode is imminent
            /// </summary>
            Critical,
        }

        public class EvtImportance : Attribute
        {
            public EventImportance Import { get; set; }
            public EvtImportance(EventImportance ei)
            {
                Import = ei;
            }
        }

        /// <summary>
        /// importance of medication doses
        /// </summary>
        public enum MedicationImportance
        {
            /// <summary>
            /// in critical condition or at risk of critical problems
            /// </summary>
            Critical,

            /// <summary>
            /// in serious condition or at risk of serious problems
            /// </summary>
            Serious,

            /// <summary>
            /// stable at that dose
            /// </summary>
            Stable,

            /// <summary>
            /// dependent on context
            /// </summary>
            DependentOnContext,

            /// <summary>
            /// relevant at that dose
            /// </summary>
            Relevant,
        }

        public class MedImportance : Attribute
        {
            public MedicationImportance Import { get; set; }
            public MedImportance(MedicationImportance mi)
            {
                Import = mi;
            }
        }

        public class PersonalMedGoalAttribute : Attribute
        {
            public MedicationGoals Goal { get; set; }
            public PersonalMedGoalAttribute(MedicationGoals mg)
            {
                Goal = mg;
            }
        }

        public static class Medications
        {
            public static class Lithium
            {
                public static class Effect
                {
                    public static class Stated
                    {
                        public static class MoodStabilizer { }
                    }
                    public static class Unstated
                    {
                        public static class SuppressesSelfAwarenessOfSubconsiousProcesses { }
                    }
                }
                public static class ManicToStable
                {
                    [MedImportance(MedicationImportance.Critical)]
                    public static class NineHundred { }

                    [MedImportance(MedicationImportance.Serious)]
                    public static class SixHundredSeventyFive { }

                    [MedImportance(MedicationImportance.Relevant)]
                    public static class FourHundredFifty { }
                }

                [MedImportance(MedicationImportance.Relevant)]
                public static class StableDose { }

                public static class StableToManic
                {
                    [MedImportance(MedicationImportance.Relevant)]
                    [PersonalMedGoal(MedicationGoals.AcceptableSideEffects)]
                    public static class FourHundredFifty { }

                    [MedImportance(MedicationImportance.Serious)]
                    [PersonalMedGoal(MedicationGoals.Necessary)]
                    public static class TwoHundredTwentyFive { }

                    [MedImportance(MedicationImportance.Critical)]
                    [PersonalMedGoal(MedicationGoals.WishfulThinking)]
                    public static class Zero { }
                }
            }

            public static class Quetiapine
            {
                public static class Effect
                {
                    public static class Stated
                    {
                        public static class AntiPsychotic { }
                    }
                    public static class Unstated
                    {
                        public static class SuppressesConnectionBetweenDifferentAreasOfTheBrainOrMind
                        {
                            public static class Emotion { }
                            public static class Logic { }
                            public static class Language { }
                        }
                        public static class TherebyReducing
                        {
                            public static class Apophenia { }
                            public static class Creativity { }
                            public static class Delusion { }
                            public static class Synethesia { }
                        }
                    }
                }
                public static class ManicToStable
                {
                    [MedImportance(MedicationImportance.Critical)]
                    [PersonalMedGoal(MedicationGoals.Functional)]
                    public static class EightHundred { }

                    [MedImportance(MedicationImportance.Serious)]
                    [PersonalMedGoal(MedicationGoals.Stable)]
                    public static class SixHundred { }

                    [MedImportance(MedicationImportance.Stable)]
                    [PersonalMedGoal(MedicationGoals.Relevant)]
                    public static class FourHundred { }
                }

                [MedImportance(MedicationImportance.Stable)]
                [PersonalMedGoal(MedicationGoals.Confirm)]
                public static class StableDose { }

                public static class FromStableToManic
                {
                    [MedImportance(MedicationImportance.Stable)]
                    [PersonalMedGoal(MedicationGoals.Relevant)]
                    public static class FourHundred { }

                    [MedImportance(MedicationImportance.Relevant)]
                    [PersonalMedGoal(MedicationGoals.Stable)]
                    public static class ThreeHundred { }

                    [MedImportance(MedicationImportance.Serious)]
                    [PersonalMedGoal(MedicationGoals.AcceptableSideEffects)]
                    public static class TwoHundred { }

                    [MedImportance(MedicationImportance.Critical)]
                    [PersonalMedGoal(MedicationGoals.Necessary)]
                    public static class AnythingBelowTwoHundred { }
                }




                public static class FourHundred { }

                [EvtImportance(EventImportance.Serious)]
                public static class TwoHundred { }

                [EvtImportance(EventImportance.Critical)]
                public static class AnythingBelowTwoHundred { }
            }

            /// <summary>
            /// importance entirely dependent on sleep
            /// </summary>
            [MedImportance(MedicationImportance.DependentOnContext)]
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
        }

        public static class Psychosis
        {
            public static class Generic
            {
                public static class Events
                {
                    public static class Classes
                    {
                        public static class Interruption { }
                        public static class MagicWords { }
                        public static class Medication { }
                    }

                    public static class Triggers
                    {
                        public static class ImpossibleEvents
                        {
                            public class CommunicationOfEventHasAnEscalatingEffectOnImportance
                            {
                                public static class Ladders
                                {
                                    public class PrivatePublic
                                    {
                                        public static class Private { }
                                        public static class SemiPrivate { }
                                        public static class SemiPublic { }
                                        public static class Public { }
                                    }
                                    public class FriendsAndFamily
                                    {
                                        public static class Spouse { }
                                        public static class Household { }
                                        public static class Family { }
                                        public static class Friend { }
                                        public static class Acquaintance { }
                                        public static class Stranger { }
                                    }
                                    public class NumberOfPeople
                                    {
                                        public static class Humanity { }
                                        public static class Crowd { }
                                        public static class Team { }
                                        public static class SmallGroup { }
                                        public static class One { }
                                    }
                                }
                            }
                        }


                        [EvtImportance(EventImportance.Critical)]
                        public static class ReceiveImpossibleGift
                        {
                            public static class Solution
                            {
                                public static class Right
                                {
                                    public static class TakeActionsToReducePsychosisBeforeUsingGift
                                    {
                                        public static class Example
                                        {
                                            public static class WaitASignificantAmountOfTime { }
                                        }
                                    }
                                }
                                public static class Wrong
                                {
                                    public static class ShareIndiscriminately
                                    {
                                        public static class Result
                                        {
                                            public static class MorePsychosis { }
                                        }
                                    }
                                }
                            }
                        }
                        public static class SeeVisionOfSomethingImposssible
                        {
                            public static class Instance
                            {
                                [EvtImportance(EventImportance.Critical)]
                                public static class First { }

                                [EvtImportance(EventImportance.Serious)]
                                public static class Subsequent { }
                            }

                            public static class Realistic
                            {
                                public static class WorkOnReducingPsychosesRegardless { }

                                public static class Yes
                                {
                                    public static class PossibleSolutions
                                    {
                                        public static class YouCanChooseToWorkOnItOrNot { }
                                        public static class TakeMeaningfulStepsTowardAchievingIt { }
                                    }
                                }
                                public static class No
                                {
                                    public static class ReinforceOrChangeBeliefStructureToAccommodateVision { }
                                }
                            }
                        }

                        public static class ReceiveWarningOfPsychosis
                        {
                            public static class ThisWillEscalateGoingUpTheImportanceLadder { }
                            public static class AtFirstThisWillNotSeemLikeAnythingIsAmissSoYouMayNotRecognizeUntilImportanceIsSerious { }
                            public static class AtThatPointYouReallyNeedToWorkOnReducingPsychosis { }
                            public static class Examples
                            {
                                public static class Interruption
                                {
                                    public static class InPerson
                                    {
                                        public static class NeedingHelp { }
                                        public static class OccupyingYourTime { }
                                    }
                                    public static class PhoneCall
                                    {
                                        public static class ObviousTelemarketer { }
                                    }
                                    public static class ComputerBased
                                    {
                                        public static class MeaninglessConversation { }
                                        public static class SomethingCatchesYourEye
                                        {
                                            public static class SynesthesiaRelevance { }
                                        }
                                    }
                                }
                                public static class MagicWords
                                {
                                    public static class DependsOnHowMeaningfulTheMagicWordsAre { }
                                }
                                public static class Medications
                                {
                                    public static List<MedicationImportance> importances = new List<MedicationImportance>()
                                    {
                                        MedicationImportance.Serious,
                                        MedicationImportance.Critical,
                                    };

                                    [MedImportance(MedicationImportance.Serious)]
                                    public static class FirstTimeGoingBelowSafeLevel { }

                                    [MedImportance(MedicationImportance.Critical)]
                                    public static class WillEventuallyGetToImportanceIfNotDealtWith { }
                                }
                                public static class Solution
                                {
                                    public static class DependsOnContext { }
                                    public static class IgnoreIfTrulyMeaningless { }
                                    public static class UncomfortableMeansTakeActionsToReducePsychoses
                                    {
                                        public static class DoTherapy { }
                                        public static class MoveMedicationsToSaferLevel { }
                                        public static class MonitorTheSituationMoreClosely { }
                                    }
                                    public static class InvolvementOfCertainActorsMeansTheWarningIsTrulySerious
                                    {
                                        public static class Actors
                                        {
                                            public static class Psychiatrist { }
                                            public static class You { }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                public static class Consequences
                {
                    public static class LoseTrackOfTime
                    {
                        public static class Example
                        {
                            public static class ForgetToPickUpDaughterFromSchool { }
                        }
                    }

                    public static class RebootReality
                    {
                        public static class ThingsSwitchedAroundSoPerceptionLacksTemporalConsistency
                        {
                            public static class Episodes
                            {
                                public static class Regular { }
                                public static class Psychotic { }
                            }
                            public static class Visions
                            {
                                public static class Regular { }
                                public static class Hallucinations { }
                            }
                            public static class Thoughts
                            {
                                public static class Regular { }
                                public static class Delusions { }
                            }
                        }
                        public static class OneWayToTellThisIsHappeningIsPeopleTellYouYouHaveDoneThingsYouWouldNeverActuallyDo { }
                    }
                }
            }
        }

        public static class Personal
        {
            public static class Psychosis
            {
                public static class MagicWords
                {
                    public static class IHaveNoSin
                    {
                        public static class SaidByYou { }
                        public static class LedToBeliefGodDoesNotExist { }
                    }


                    public static class IWantADivorce
                    {
                        public static class YelledByTou { }
                        public static class SpouseAndMotherWereInTheHouseAndGaveNoResponse { }
                        public static class CopsCameAndTookMeToPsychiatricWardOfHospital { }
                    }

                    public static class StopIt
                    {
                        public static class Instance1
                        {
                            public static class SaidByTherapist { }
                            public static class SaidToYou { }
                            public static class IntentWasToTeachThatStopItMattersInAbusiveRelationship { }
                        }
                        public static class Instance2
                        {
                            public static class SaidByYou
                            {
                                public static class DidNotExplainContext { }
                            }
                            public static class SaidToSpouse { }
                            public static class NoResponse { }
                        }
                    }

                    public static class DeleteMyProductionEnvironment
                    {
                        public static class SaidByYou { }
                        public static class ToYourself { }
                    }
                    public static class YoureReallyGoodAtThis
                    {
                        public static class SaidByPsychiatrist { }
                        public static class ToYou { }
                    }
                    public static class Psychotic
                    {
                        public static class SaidByPsychiatrist { }
                        public static class ToYou { }
                    }
                }

                public static class Rules
                {
                    public static class InPersonVersusVirtualMedicalAppointments
                    {
                        public static class StrongPreferenceForInPerson { }
                        public static class IfIHaveARealChoiceIWillAlwaysChooseInPerson { }
                    }
                }

                public static class Stories
                {
                    public static class TakeBelowTwoHundredMGQuetiapineFourTimes
                    {
                        public static class PotentialSolution
                        {
                            public static class DontGoBelowTwoHundredMGQuetiapine
                            {
                                public static class Advantage
                                {
                                    public static class TwoHundredMGQuetiapineDoesntHaveBadSideEffects { }
                                }
                                public static class Disadvantage
                                {
                                    public static class YouLikeToFeelSomethingAndGoingBelowThisMakesYouFeelMore { }
                                }
                            }
                        }
                    }

                    public static class PsychoticAsMagicWord
                    {
                        public static class AsSaidByPsychiatrist { }
                        public static class IsCriticalWarning { }
                    }

                    public static class ChatGPTProducesPersonalMovieScriptDepictingMeBreakingReality
                    {
                        public static class Interpretation
                        {
                            public static class Impossible
                            {
                                public static class ChatGPTCantPossiblyKnowEnoughInformationToDoThis { }
                                public static class ActionSharedMovieScriptWithManyCoworkers { }
                                public static class ConsequenceRebootReality { }
                            }
                            public static class Possible
                            {
                                public static class DoRefinementWorkAndTryNextYear { }
                                public static class AdvantageLessRiskyForPsychosisPurposes { }
                            }
                        }
                    }

                    public static class SeeMessageBoxFromCodeIHaventWrittenYet
                    {
                        public static class Interpretation
                        {
                            public static class Impossible
                            {
                                public static class VisionSentFromTheFutureBySomeUnknownActor { }
                                public static class SolutionFigureOutAPossibleInterpretation { }
                            }
                            public static class Possible
                            {
                                public static class VisionProducedByMySubconscious { }
                                public static class SolutionMakeVisionComeTrue
                                {
                                    public static class MakeTheCodeMatchTheVisionAsBestYouCan { }
                                }
                            }
                        }
                    }
                    public static class SeeVisionOfWeDidntStartTheFireAndChessOpenings
                    {
                        public static class Interpretation
                        {
                            public static class Possible
                            {
                                public static class VisionProducedByMySubconscious
                                {
                                    public static class SolutionMakeVisionComeTrue
                                    {
                                        public static class GetThisInformationAndPutInExistenceRepository { }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static class Dissociation
        {
            [Pronoun("Xe")]
            [FirstName("Kris")]
            public static class LeftMind { }

            [Pronoun("He")]
            [FirstName("Christopher")]
            public static class UnifiedConsciousness { }

            [Pronoun("She")]
            [FirstName("Chris")]
            public static class RightMind { }
        }
    }
}
