
using Existence.Beyond;
using Existence.Earth.Countries.UnitedStates;
using Existence.Time;
using static Existence.Beyond.JudgmentDay.BirthToGrowingUp;
using System;
using Existence.Beyond.Infrastructure;
using Existence.Beyond.JudgmentDay;
using Existence.Earth.Alphabet;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Beyond.Submission;
using System.Collections.Generic;

namespace Existence.Personal.Beyond
{

    internal class JudgmentDaySins
    {
        public JudgmentDaySins()
        {
            MyReligiousFlags religiousFlags = new MyReligiousFlags(null);

            List<BaseEvent> pastSins = new List<BaseEvent>()
            {
            new StickingFingerInExposedPowerOutlets(),
            new HeadInjuryFromRunningAroundHouseTooFast(),
            new ILikeToFartHandPuppetPlay(),
            new HidSistersBlanketComfortObject(),
            new SomeoneClaimedSomeoneElseWasDeadInSchool(),
            new FeelingNothingForBenjisDeath(),
            new PersonalFirstParodySong(),
            new PersonalFirstOriginalSong(),
            new SomeoneCalledMeAGeniusGhosting(),
            new SkippedOutOnHalloweenClassParty(),
            new FlashcardsDomination(),
            new CuttingInLineAtDisneyLand(),
            new FocusedOnDevelopingAnalyticalThinkingSkillsAtTheExpenseOfCommunicationSkills(),
            new ChildhoodNativityPlayDisrespect1(religiousFlags),
            new ChildhoodNativityPlayDisrespect2(religiousFlags),
            new SkepticismOfReligionPersonal(religiousFlags),
            new WetTheBedAtChurchCamp(),
            new ChokedDogTrainingDogWithChokeChainExcessively(),
            new InducedSnowflakeToFallOffTheTable(),
            new GuaranteedNoCarAccidentWouldOccur(),
            new HalloweenCostumeAsGhostAndSelf(),
            new IgnoredReligiousInstructionOnCommunion(),
            new SowingChaosInChurchChildrensChoirPractice(),
            new FamilyMeetingComplimentsThatWerentComplimentary(),
            new HittingMySister(),
            new CheatedAtUpperElementaryDodgeball(),
            new DidntWantMyPictureTaken(new EmbarrassingLittleKidBehaviorAtProfessionalPhotographer()),
            new ToldMyMotherSheWasntInOnPerformanceNuances(),
            new UnresponsivenessForBeingMadeFunOfForCorduroyPants(),
            new AntKilling(new SpiderRemoval()),
            new CalledPianoTeacherBeefJerky(),
            new TheEducationalValueOfThisIsQuestionable(),
            new AssistedGettingMySummerProgramRoommateExpelled(),
            new EvjueFoundationNonThankYouForWCATYProgram(),
            new ClarinetSqueakingInPublicPerformance(),
            new CarAccidentBackingUpAtGrandparentsFarm(),
            new EnglishPaperClaimingPeopleAreInherentlyStupid(),
            new ParticipationInEENFL(),
            new ChairBurningAtPicnicPoint(),
            new LiedAboutHavingGirlfriend(),
            new WCATYAntiTeachingAssistantFeedback(),
            new HitATurkeyWithACar(),
            new PlayedEuchreWithPartnerSignalling(),
            new BoomSoundAtHighSchoolShowChoirPerformance(),
            new SpanishClassSkitWhereAnAirlinerExploded(),
            new InappropriatelyPutArmAroundGirl(),
            new SowingChaosAtHighSchoolBandPractice(),
            new ClaimedPsychologyIsBullshitInClassAssignment(),
            new SteppingOnTheWisconsinDellsFloorLogo(),
            new WalkedThirteenAndAHalfMilesHomeFromSchool(),
            new InappropriateAliensJoke(),
            new TakingInsuranceInBlackjack(),
            new TryingToCountCardsAtBlackjack1(),
            new RefusedToShakeBandDirectorsHandAtHighSchoolGraduation(),
            new FailedIntroductoryCollegeEnglishCourseTwice(),
            new HelpedCollegeClassmateCheatOnCollegeCompSciClass(),
            new TryingToCountCardsAtBlackjack2(),
            new SableLostElectricalPowerOnMadisonGorhamStreet(),
            new Did360InTheSnowAtMineralPointAndWhitneyWay(),
            new ExposedPersonalInformationInGarbage(),
            new DidNotCorrectIncorrectTornadoAnecdote(),
            new GotADiscoverCardAndNeverPaidTheBalance(),
            new KeptSignificantQuantityOfGoldAndSilver(),
            new LookingAtTBTestMarkCausingFaintingAndCarCrash(),
            new LackOfCommunicationAtHighSchoolReunion(),
            new TriedToStartScambaiting(),
            new InappropriatePurchaseOfWinZipAndDotNetReflectorOnWorkComputer(),
            new LightStrangulationOfChild(),
            new MatrixBrokeDownSouthOfLodi(),
            new PutFinaleOnWorkLocalMachine(new RemovedFinaleFromWorkLocalMachineViaITTicket()),
            new HitADeerWithCar(),
            new MissedAVISAPayment(),
            };

            List<BaseEvent> ongoingSins = new List<BaseEvent>()
            {
                new StepOnACrackBreakYourMothersBack(),
                new TerriblePenmanship(),
                new CheckingAccountNotBalanced(),
                new EatTooMuch(),
                new PersonalPhoneNotInWorkingOrder(),
                new UseOfWorkComputerForPersonalUse(),
            };
        }

        /// <summary>
        /// While the addition was in process of being built, I stuck my finger in exposed power outlets. I don't believe I actually got any
        /// electric shock from it, but it was reckless behavior regardless. Even though the consequences were nonexistent, I still
        /// learned the lesson that actions have consequences
        /// </summary>
        [ApproximateAgeInYears(4)]
        [SinType(SinType.Recklessness)]
        public class StickingFingerInExposedPowerOutlets : BaseEvent
        {
            public StickingFingerInExposedPowerOutlets() : base("Sticking finger in Exposed Power Outlets")
            {
            }
            public string Lesson
            {
                get
                {
                    return "Actions have Conseuqences";
                }
            }
            public string? Consequences
            {
                get
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// I got stitches multiple times for running around into things like chairs
        /// </summary>
        [ApproximateAgeInYears(7)]
        [SinType(SinType.Recklessness)]
        public class HeadInjuryFromRunningAroundHouseTooFast : BaseEvent
        {
            public HeadInjuryFromRunningAroundHouseTooFast() : base("Stitches from Running into Chairs")
            {
            }
        }

        /// <summary>
        /// I remember this as happening around my mother's parents' 40th anniversary party. I 
        /// hid my sister's blanket (yellowish) comfort object. My sister got very upset over this, although
        /// it may have been a path on the road to no longer needing a comfort object.
        /// </summary>
        [SinType(SinType.Cruelty)]
        [ApproximateAgeInYears(8)]
        public class HidSistersBlanketComfortObject : BaseEvent
        {
            public HidSistersBlanketComfortObject() : base("Hid Sister's Blanket Comfort Object")
            {
            }
        }

        /// <summary>
        /// in second grade, someone claimed some one else was dead, with the second grade teacher (Mrs. Bagley)
        /// responding "Don't say that, it might be true" I do not remember who said it or who the target was. It's 
        /// also unclear if I actually learned an inappropriate communication lesson or not. I list it here
        /// because even if I wasn't the one responsible I did find it funny
        /// </summary>
        [MagicWords("He/she's dead", "Someone", "Elementary School", "Second Grade Class")]
        [SinType(SinType.FindSomethingInappropriateFunny)]
        [ApproximateAgeInYears(8)]
        public class SomeoneClaimedSomeoneElseWasDeadInSchool : BaseEvent
        {
            public SomeoneClaimedSomeoneElseWasDeadInSchool() : base("Heard Claim Someone Else Was Dead Inappropriately")
            {
            }
        }

        /// <summary>
        /// Benji was pseudo-owned by my sister, not by me, so I felt nothing
        /// when she died (Teddy was pseudo-owned by me)
        /// </summary>
        [SinType(SinType.LackOfSympathy)]
        [Age(8, Earth.Time.TimePeriods.Years)]
        public class FeelingNothingForBenjisDeath : BaseEvent
        {
            public FeelingNothingForBenjisDeath() : base("Felt Nothing When Family Pet Died")
            {
            }
        }

        /// <summary>
        /// One year I found out the Church of God kids didn't have to participate in the class Halloween party. 
        /// I used that as an excuse to not go to the class Halloween party (2nd or 3rd grade)
        /// </summary>
        [ApproximateAgeInYears(9)]
        [SinType(SinType.SocialAvoidance)]
        public class SkippedOutOnHalloweenClassParty : BaseEvent
        {
            public SkippedOutOnHalloweenClassParty() : base("Skipped out on Class Halloween Party")
            {
            }
        }

        /// <summary>
        /// crushed the 3rd grade class in flashcards game, didn't let anyone get a chance
        /// </summary>
        [ApproximateAgeInYears(9)]
        [SinType(SinType.Domination)]
        public class FlashcardsDomination : BaseEvent
        {
            public FlashcardsDomination() : base("Flashcards Domination Karma")
            {
            }
            /// <summary>
            /// defeated by the lowest intelligence girl in the glass, which was embarrassing.
            /// </summary>
            [Person((int)ThirdGradePartialClassList.Tameka)]
            public class Karma { }

            public string FirstLesson
            {
                get
                {
                    return "Sportsmanship";
                }
            }
        }

        /// <summary>
        /// We took a family vacation to California where my mother's sister and her family lived.
        /// They had two children with muscular dystrophy. We went to Disneyland and got to cut
        /// in line on rides that allowed the handicapped to do so. I was not handicapped and thus
        /// got to take advantage of the situation. I remember imagining the other residents of
        /// the line might be annoyed at this, but I am not certain that is an actual
        /// representation of reality.
        /// </summary>
        [ApproximateAgeInYears(10)]
        [SinTypes(SinType.CuttingInLine, SinType.TakingAdvantageOfSituation)]
        public class CuttingInLineAtDisneyLand : BaseEvent
        {
            public CuttingInLineAtDisneyLand() : base("Used Handicapped Relatives to Cut in Line")
            {
            }
        }

        /// <summary>
        /// Wet the bed at church camp (Pine Lake Camp), getting sleeping bag all messy. Camp counselor washed it 
        /// for me. It shook me up a lot since I thought I was past this (and did indeed demarcate being past it). 
        /// I treat this as a sin since I could have avoided it with smarter behavior.
        // </summary>
        [ApproximateAgeInYears(10)]
        [SinType(SinType.EmbarrassingBehavior)]
        public class WetTheBedAtChurchCamp : BaseEvent
        {
            public WetTheBedAtChurchCamp() : base("Church Camp Wet the Bed")
            {
            }
        }

        /// <summary>
        /// I trained Ted (Teddy) for 4-H. He was reasonably competent at learning what he had to
        /// do, although he got nervous around other people. We used a choke chain as a mechanism
        /// to get him to do the desired behavior. I don't remember using the choke chain to a
        /// ridiculously excessive amount, but I used it enough to get on this list.
        /// </summary>
        [ApproximateAgeInYears(10)]
        [SinType(SinType.Cruelty)]
        public class ChokedDogTrainingDogWithChokeChainExcessively : BaseEvent
        {
            public ChokedDogTrainingDogWithChokeChainExcessively() : base("Dog Training Excessive Choke Chain Use")
            {

            }
        }

        /// <summary>
        /// Snowflake liked to sit on tables and get attention. She would
        /// gravitate to human hands. This allowed placing one's hand over a
        /// position close to the edge of the table but not over. Snowflake
        /// would chase after the hand and frequently fall off the table.
        /// Cats have good balance so I don't believe Snowflake was ever
        /// injured by this but it was a possibility.        
        /// </summary>
        [ApproximateAgeInYears(10)]
        [SinType(SinType.InducingDangerousBehavior)]
        public class InducedSnowflakeToFallOffTheTable : BaseEvent
        {
            public InducedSnowflakeToFallOffTheTable() : base("Induced Family Cat to Fall Off Table")
            {

            }
        }

        /// <summary>
        /// one time when my mother (driving), my sister, and me were taking a car trip to my mother's parents' house, in response 
        /// to a directive to fasten my seat belt, I verbally guaranteed we would not get in a car accident. My mother was a 
        /// good driver, it was a short car trip (could of miles), and no accident occurred. At the end I pointed out I was
        /// right but I still had no right to make the guarantee
        /// </summary>
        [ApproximateAgeInYears(11)]
        [SinType(SinType.Overpromising)]
        public class GuaranteedNoCarAccidentWouldOccur : BaseEvent
        {
            public GuaranteedNoCarAccidentWouldOccur() : base("Guaranteed No Car Accident Would happen")
            {
            }
        }

        /// <summary>
        /// Halloween costumes I remember were ghost and myself, not very creative
        /// </summary>
        [ApproximateAgeInYears(11)]
        [SinType(SinType.Laziness)]
        public class HalloweenCostumeAsGhostAndSelf : BaseEvent
        {
            public HalloweenCostumeAsGhostAndSelf() : base("Uninspired Halloween Costumes (Ghost and Self")
            {
            }
        }

        /// <summary>
        /// I remember receiving instruction on the eucharist for first
        /// communion purposes. I remember ignoring it completely, although
        /// oddly I remember on some level what transubstantiation is even
        /// though that's not the Lutheran belief.
        /// </summary>
        [ApproximateAgeInYears(11)]
        [SinType(SinType.IgnoringTeaching)]
        public class IgnoredReligiousInstructionOnCommunion : BaseEvent
        {
            public IgnoredReligiousInstructionOnCommunion() : base("Ignored Communion Religious Instruction")
            {
            }
        }

        /// <summary>
        /// Main example is intentionally singing just a bit off to confuse the choir director
        /// </summary>
        [ApproximateAgeInYears(12)]
        [SinType(SinType.SowingChaos)]
        public class SowingChaosInChurchChildrensChoirPractice : BaseEvent
        {
            public SowingChaosInChurchChildrensChoirPractice() : base("Misbehavior during Church Children's Choir Practice")
            {
            }
        }

        /// <summary>
        /// For a time my mother instituted weekly family meetings as a formal
        /// thing. One part of the meetings was we had to construct compliments
        /// to other family members. My compliments, particularly to my sister,
        /// were not actually complimentary, and this extended to my mother
        /// as well. Even if not insulting the compliments would frequently be
        /// factual and not complimentary opinion.
        /// </summary>
        [ApproximateAgeInYears(12)]
        [SinTypes(SinType.BackhandedCompliments, SinType.Disrespect)]
        public class FamilyMeetingComplimentsThatWerentComplimentary : BaseEvent
        {
            public FamilyMeetingComplimentsThatWerentComplimentary() : base("Family Meeting Compliments were Not Compliments")
            {
            }
        }

        /// <summary>
        /// hit my sister many times, despite me being the older sibling (who should be wiser). I was the male sibling,
        /// which can mean less maturity. Regardless of mitigating factors, it was more severe and took far longer than
        /// it should have.
        /// </summary>
        [SinType(SinType.Cruelty)]
        [ApproximateAgeInYears(12)]
        public class HittingMySister : BaseEvent
        {
            public HittingMySister() : base("Hit my Younger Sister Many Times")
            {
            }

            /// <summary>
            /// My sister was playing music in the boombox and I was trying to irritate her by turning the song off. After
            /// a few go rounds of this, my sister started hitting me. I put my arms up to protect myself but didn't try to fight
            /// back. My sister's head motion was a bit uncontrolled and she hit her head on my (possibly left) wrist and was
            /// injured. Hitting had stopped anyway at this point but this was a milestone in irritation and cruel behavior.
            /// </summary>
            [Person((int)FamilyMembers.MySisterSonya)]
            [ApproximateAgeInYears(16)]
            [SinType(SinType.IntentionalIrritation)]
            public class Karma
            {
            }
        }

        /// <summary>
        /// The location was Big Spring Elementary School cafeteria which was emptied and used for physical 
        /// education class. I had the ball and was allowed to take three steps before throwing the ball at 
        /// a classmate. Instead I threw the ball a little bit in front of me so I was closest to the ball,
        /// got the ball and took another three steps. I remember it being clearly cheating. I don't remember
        /// if I totally got away with it or not. Regardless, it was just dodgeball.
        /// </summary>
        [SinType(SinType.Cheating)]
        [ApproximateAgeInYears(12)]
        public class CheatedAtUpperElementaryDodgeball : BaseEvent
        {
            public CheatedAtUpperElementaryDodgeball() : base("Cheated at Elementary School Dodgeball")
            {
            }
        }

        /// <summary>
        /// I didn't want to have my picture taken. Some of this was not wanting to conform to social norms.
        /// Part of it was a dislike of pictures based on mother's behavior of preferring pictures over other
        /// social communication. Part of it was I had a general sense that taking a picture takes a piece of
        /// your soul, although I never really spelled that attitude out.
        /// </summary>
        [SinType(SinType.RefusalToDoExpectedBehavior)]
        [ApproximateAgeInYears(7, 13)]
        public class DidntWantMyPictureTaken : BaseEvent
        {
            EmbarrassingLittleKidBehaviorAtProfessionalPhotographer Closure { get; set; }
            public DidntWantMyPictureTaken(EmbarrassingLittleKidBehaviorAtProfessionalPhotographer Closure) : base("Didn't want my Picture Taken")
            {
                this.Closure = Closure;
            }
        }

        /// <summary>
        /// this refers to an incident where I was old enough to know better but I still forced the professional
        /// photographer to treat me like a little child to get the picture done. This serves as closure for 
        /// photographic refusal but doesn't atone for it.
        /// </summary>
        [SinTypes(SinType.EmbarrassingBehavior, SinType.RefusalToDoExpectedBehavior)]
        [ApproximateAgeInYears(13)]
        public class EmbarrassingLittleKidBehaviorAtProfessionalPhotographer : BaseEvent
        {
            public EmbarrassingLittleKidBehaviorAtProfessionalPhotographer() : base("Made Professional Photographer Treat me like a Little Kid for Photograph")
            {
            }
        }

        /// <summary>
        /// A common piece of advice for music performance is if something wrong happens, just 
        /// keep on going. The reality is most people won't notice because they aren't attuned
        /// to how a mistake would look. I told my mother once that she was one of those people.
        /// The truth was my beef was actually with my mother's lack of social reciprocity in 
        /// such matters, so my characterization wasn't entirely on point. Regardless, mother
        /// didn't have a significant reaction to the statement, and I never brought up any
        /// similar point later.
        /// </summary>
        [ApproximateAgeInYears(13)]
        [SinType(SinType.TactlessTruth)]
        public class ToldMyMotherSheWasntInOnPerformanceNuances : BaseEvent
        {
            public ToldMyMotherSheWasntInOnPerformanceNuances() : base("Told Mother She Couldn't Discriminate Performance Quality")
            {
            }
        }

        /// <summary>
        /// In middle school Tony Leggett (athletic student but not bright)
        /// made fun of me for having corduroy pants. My wardrobe was not
        /// particularly scintillating. I didn't respond to the teasing at all,
        /// and because I didn't respond the teasing did not last. Regardless,
        /// I have since learned unresponsiveness to teasing/bullying also
        /// has consequences.
        /// </summary>
        [ApproximateAgeInYears(13)]
        [SinTypes(SinType.NotStandingUpForYourself, SinType.LackOfCommunication)]
        public class UnresponsivenessForBeingMadeFunOfForCorduroyPants : BaseEvent
        {
            public UnresponsivenessForBeingMadeFunOfForCorduroyPants() : base("Made Fun of for Corduroy Pants")
            {
            }
        }

        /// <summary>
        /// as a child sometimes I killed ants for fun by stepping on them or crushing them.
        /// Another scenario was turning on the hose and flooding the area with the ants.
        /// </summary>
        [ApproximateAgeInYears(7, 13)]
        [SinTypes(SinType.Murder, SinType.WasteResources)]
        public class AntKilling : BaseEvent
        {
            public SpiderRemoval Atonement { get; set; }
            public AntKilling(SpiderRemoval Atonement) : base("Killed Ants for Fun")
            {
                this.Atonement = Atonement;
            }
        }

        /// <summary>
        /// Particularly (but not exclusively) when spouse points out a spider, I either kill it,
        /// try to take it outside, or wait until it leaves the immediate area. This is a bit more
        /// mature than ant killing.
        /// </summary>
        [StartYear(2007)]
        [SinTypes(SinType.Murder)]
        public class SpiderRemoval : BaseEvent
        {
            public SpiderRemoval() : base("Dealt with Trespassing Spiders in Various Ways")
            {
            }
        }

        /// <summary>
        /// My sister and I would call my piano teacher "Beef Jerky", for no other reason than
        /// because "jerky" rhymed with the last name Yerke. For many years, even after done with
        /// piano lessons, we would say the magic words as we passed the house where we had
        /// previously taken piano lessons
        /// </summary>
        [ApproximateAgeInYears(12, 17)]
        [Witness((int)FamilyMembers.MySisterSonya)]
        [MagicWords("Residence of Beef Jerky", "Former Residence of Beef Jerky",
                    "My sister and I", "Piano Teacher's Residence or Former Residency", 
                    "Sometimes My Mother")]
        [SinTypes(SinType.TalkingBehindSomeonesBack, SinType.AdHominim)]
        public class CalledPianoTeacherBeefJerky : BaseEvent
        {
            public CalledPianoTeacherBeefJerky() : base("Called Piano Teacher Ridiculous Name Behind Back")
            {
            }
        }

        /// <summary>
        /// At church camp we were allowed to rate the different activities. A fellow camper excelled at negative
        /// reviews, giving a negative review to the canoeing activity. I found this excessively funny.
        /// I have tried using the phrase since, but whenever I use it myself it doesn't seem to work.
        /// </summary>
        [ApproximateAgeInYears(14)]
        [MagicWords("The educational value of X is questionable", "Fellow Church Camper", "Church Camp", "Church Campers")]
        [SinType(SinType.FindSomethingInappropriateFunny)]
        public class TheEducationalValueOfThisIsQuestionable : BaseEvent
        {
            public TheEducationalValueOfThisIsQuestionable() : base("The Educational Value of this is Questionable")
            {
            }
        }

        /// <summary>
        /// At a WCATY summer program, my roommate apparently stole some collectible cards (maybe Magic cards).
        /// I was called to provide evidence. I was unaware what was going on, although in hind sight I should have
        /// known. I didn't intend to inform on him with my testimony I had seen him in possession of a white box,
        /// but I did nonetheless. He was expelled from the summer program.
        /// </summary>
        [ApproximateAgeInYears(15)]
        [SinTypes(SinType.TattleTale, SinType.SocialUnawareness)]
        public class AssistedGettingMySummerProgramRoommateExpelled : BaseEvent
        {
            public AssistedGettingMySummerProgramRoommateExpelled() : base("Helped get roommate expelled")
            {
            }
        }

        /// <summary>
        /// I got financial support to go to a WCATY program from the Evjue
        /// Foundation. As part of that my mother made me write a thank you
        /// letter. Instead of a normal thank you not, I misspelled "Evjue" as
        /// something like "Evjueyjube" and didn't really thank anything. My
        /// mother made me fix it to a normal thank you. In hindsight, I might
        /// have done this for political reasons (Evjue is liberal and at the
        /// time I was more conservative). Maybe I didn't really enjoy the
        /// WCATY event. Maybe I thought we had enough money to afford this
        /// and didn't need the charity. Maybe I just hated writing thank you
        /// notes.
        /// </summary>
        [ApproximateAgeInYears(15)]
        [SinType(SinType.Disrespect)]
        public class EvjueFoundationNonThankYouForWCATYProgram : BaseEvent
        {
            public EvjueFoundationNonThankYouForWCATYProgram() : base("Disrespectful Thank You Note to Benefactor")
            {
            }
        }

        /// <summary>
        /// I remember squeaking twice in public performance of clarinet - once during solo &
        /// ensemble, and once during a band concert. This is more of a personally embarrassing
        /// thing that others don't think twice about.
        /// </summary>
        [ApproximateAgeInYears(15)]
        [SinType(SinType.EmbarrassingBehavior)]
        public class ClarinetSqueakingInPublicPerformance : BaseEvent
        {
            public ClarinetSqueakingInPublicPerformance() : base("Clarinet Squeaking for Solo/Ensemble/Concert")
            {
            }
        }

        /// <summary>
        /// At my mother's parents' house (the one with the cow barn), I backed the Eurosport into a piece of farm
        /// equipment. The farm equipment seemed fine, although the Eurosport tail light was damaged.
        /// </summary>
        [ApproximateAgeInYears(16)]
        [SinType(SinType.PropertyDamage)]
        public class CarAccidentBackingUpAtGrandparentsFarm : BaseEvent
        {
            public CarAccidentBackingUpAtGrandparentsFarm() : base("Backed Car into Farm Equipment")
            {

            }
        }

        /// <summary>
        /// 10th grade English paper made two general claims about humanity (and a fairly illogical derivative
        /// of the two that is lost to time)
        /// </summary>
        [ApproximateAgeInYears(16)]
        [MagicWords("People are inherently stupid",
               "There is nothing wrong with the fact that people are inherently stupid",
               "My 10th Grade English Paper", "10th Grade English Teacher")]
        [SinType(SinType.TactlessTruth)]
        public class EnglishPaperClaimingPeopleAreInherentlyStupid : BaseEvent
        {
            public EnglishPaperClaimingPeopleAreInherentlyStupid(): base("Claims of the Stupidity of Humanity")
            {
            }
        }

        /// <summary>
        /// At high school lunch time we would play casual games of two hand
        /// touch football. As a Freshman there were many players, but as the
        /// years went on, it was restricted to lower intelligence students.
        /// The games were derogatorily called the EENFL, with "EEN" being an
        /// abbreviation for the special needs program at school. And yet I
        /// participated far beyond my time. The truth is I thought myself
        /// incapable of social functioning, and in playing the games I was
        /// at the social level I was functional. Perhaps +1 tolerance of
        /// lower intelligence students, but minus a bunch for social avoidance.
        /// </summary>
        [ApproximateAgeInYears(16)]
        [SinType(SinType.SocialAvoidance)]
        public class ParticipationInEENFL : BaseEvent
        {
            public ParticipationInEENFL() : base("Participated in Casual Football with Lower Intelligence Students")
            {
            }
        }

        /// <summary>
        /// during a WCATY event several boys went up picnic point and started a fire. I wasn't in a leadership
        /// role but I participated.
        /// </summary>
        [ApproximateAgeInYears(16)]
        [SinType(SinType.PropertyDamage)]
        public class ChairBurningAtPicnicPoint : BaseEvent
        {
            public ChairBurningAtPicnicPoint() : base("Participated in Fire Property Damage")
            {
            }
        }

        /// <summary>
        /// The car was the Ford Explorer and I was taking my sister somewhere
        /// driving south on county trunk highway B and I hit a turkey. Car was not 
        /// significantly damaged.
        /// </summary>
        [ApproximateAgeInYears(16)]
        [Witness((int)FamilyMembers.MySisterSonya)]
        [SinType(SinType.Recklessness)]
        public class HitATurkeyWithACar : BaseEvent
        {
            public HitATurkeyWithACar() : base("Hit a turkey with my car")
            {
            }
        }

        /// <summary>
        /// At high school lunch or study hall we sometimes played Euchre. At
        /// some point there was partner signalling going on. In response Nick
        /// Bremer and I devised a system of signalling the strength of the
        /// hand (e.g. good suits). It may have been worked out that cheating
        /// was okay in this circumstance but I don't remember exactly. 
        /// Regardless, we only tried it once, and we lost anyway.
        /// </summary>
        [ApproximateAgeInYears(16)]
        [Witness((int)ClassmateList.NickBremer)]
        [SinType(SinType.Cheating)]
        public class PlayedEuchreWithPartnerSignalling : BaseEvent
        {
            public PlayedEuchreWithPartnerSignalling() : base("Attempted to play Euchre with Partner Signals")
            {
            }
        }

        /// <summary>
        /// I did keyboard for a high school show choir competition (songs included Istanbul
        /// and Matilda). Between songs I did something involving an amp plugin resulting in a
        /// semi-loud boom. No one remarked on it but it was personally embarrassing and it was
        /// noticeable on the videotape recording of the event.
        /// </summary>
        [ApproximateAgeInYears(16)]
        [SinType(SinType.EmbarrassingBehavior)]
        public class BoomSoundAtHighSchoolShowChoirPerformance : BaseEvent
        {
            public BoomSoundAtHighSchoolShowChoirPerformance() : base("Caused Boom Sound for Show Choir Performance")
            {
            }
        }

        /// <summary>
        /// We had to make a skit for Spanish class. I don't remember the exact group, but
        /// Heather Dakter was in it. We did an airline hijack skit and it ended with the airliner
        /// exploding.
        /// </summary>
        [MagicWords("Boom!", "Spanish Skit", "10th Grade Spanish Class", "10th Grade Spanish Class")]
        [ApproximateAgeInYears(16)]
        [Witness((int)YearAboveClassmateList.HeatherDakter)]
        [SinType(SinType.InappropriatePublicCommunication)]
        public class SpanishClassSkitWhereAnAirlinerExploded : BaseEvent
        {
            public SpanishClassSkitWhereAnAirlinerExploded() : base("Exploded Airliner in Spanish Class Skit")
            {
            }
        }

        /// <summary>
        /// After coming out of the FST class (10th grade) I put my arm around Lisa Mitchell and
        /// she immediately removed it.
        /// </summary>
        [ApproximateAgeInYears(16)]
        [Witness((int)YearAboveClassmateList.LisaMitchell)]
        [SinType(SinType.PersonalSpaceViolation)]
        public class InappropriatelyPutArmAroundGirl : BaseEvent
        {
            public InappropriatelyPutArmAroundGirl() : base("Inappropriately put arm around girl")
            {
            }
        }

        /// <summary>
        /// Main example is intentionally playing just a bit off to confuse the choir director. This is
        /// especially easy for clarinets since other instruments like trumpets can make it difficult for
        /// the band director to hear them.
        /// </summary>
        [ApproximateAgeInYears(17)]
        [SinType(SinType.SowingChaos)]
        public class SowingChaosAtHighSchoolBandPractice : BaseEvent
        {
            public SowingChaosAtHighSchoolBandPractice() : base("Sowing Chaos at High School Band Practice")
            {
            }
        }

        /// <summary>
        /// In a psychology paper I wrote that psychology was bullshit, although I may not have actually framed
        /// it in those exact words. I have since walked this back (and walked the walkback back a bit).
        /// The original action was a sin regardless of my current beliefs in psychology.
        /// </summary>
        [MagicWords("Psychology is bullshit", "My Psychology Paper", "11th Grade Psychology Class", "11th Grade Psychology Teacher")]
        [ApproximateAgeInYears(17)]
        [SinType(SinType.InappropriatePersonalCommunication)]
        public class ClaimedPsychologyIsBullshitInClassAssignment : BaseEvent
        {
            public ClaimedPsychologyIsBullshitInClassAssignment() : base("Write Psychology Paper saying Psychology is Bullshit")
            {
            }
        }

        /// <summary>
        /// At high school, there was a "WD" (Wisconsin Dells) logo a few steps
        /// past the entrance. There was an informal rule not to step on it.
        /// Occasionally upperclassman would police the area preventing people
        /// from doing so or bullying those who did. I avoided the "WD" when 
        /// other people were around, never enforced the social rule, and 
        /// stepped on it when I could get away with it.
        /// </summary>
        [ApproximateAgeInYears(17)]
        [SinTypes(SinType.Disrespect, SinType.BreakingTheRules)]
        public class SteppingOnTheWisconsinDellsFloorLogo : BaseEvent
        {
            public SteppingOnTheWisconsinDellsFloorLogo() : base("Stepped on the High School Wisconsin Dells Floor Logo")
            {
            }
        }

        /// <summary>
        /// worst day of my life. Car wouldn't start in the morning, there was a snafu with where I was being
        /// picked up from (Spring Hill vs Wisconsin Dells High School) so I didn't get picked up with my
        /// sister going to gymnastics. I chose to walk 13.5 miles home from school which was very uncomfortable
        /// on my flat feet. Abby Joyce asked me about it later, indicating she was in a car along the same path,
        /// which I denied. After the fact my mother suggested calling neighbors (Patti Brucher) if the situation
        /// came up again, which it didn't. I am not certain I can retrace the path, that part may have faded with
        /// time. I note this happene on the modern ides of March (1/2 way though March), but I only notice this 
        /// well after-the-fact.
        /// </summary>
        [YearDate(1998, 3, 16)]
        [SinTypes(SinType.PoorDecisionmaking, SinType.PersonalCommunication)]
        public class WalkedThirteenAndAHalfMilesHomeFromSchool : BaseEvent
        {
            public WalkedThirteenAndAHalfMilesHomeFromSchool() : base("Walked 13.5 Miles Home From School")
            {
            }
        }

        /// <summary>
        /// typically when my mother's brother or mother's brother's son would ask if I had a girlfriend I would
        /// say no. But this one time, I remembered a somewhat attractive girl from a WCATY event. Her name was
        /// Allison and I never spoke to her directly, and never mentioned her to anyone else except for this lie.
        /// </summary>
        [ApproximateAgeInYears(16)]
        [Person((int)FamilyMembers.MyMothersBrothersSonDennis)]
        [SinType(SinType.Lie)]
        public class LiedAboutHavingGirlfriend : BaseEvent
        {
            public LiedAboutHavingGirlfriend() : base("Lied about having a Girlfriend")
            {
            }
        }

        /// <summary>
        /// After a WCATY event I had the opportunity to give feedback. I 
        /// didn't know what to write offhand and didn't try very hard. I gave
        /// feedback that criticized the program for employing a teaching
        /// assistant and not a full professor. I did this even though the
        /// teaching assistant did a reasonable job. Later college knowledge
        /// gave me the understanding that this wasn't that big a deal.
        /// Nevertheless, the next year's WCATY event did use a full professor,
        /// so maybe my ignorant comment actually had an effect.
        /// </summary>
        [ApproximateAgeInYears(17)]
        [SinTypes(SinType.Elitism, SinType.Ignorance)]
        public class WCATYAntiTeachingAssistantFeedback : LessonEvent
        {
            public WCATYAntiTeachingAssistantFeedback() : base("Gave Anti-Teaching-Assistant Feedback for WCATY Event")
            {
            }
        }

        /// <summary>
        /// This was during the AP Calculus test when I was a junior. The test had Areas 1, 
        /// 2, and 3, and I made a joke there was no Area 51. Not really a sin at the time, but
        /// I'm including it due to possible intergalactic pulsar time implications.
        /// </summary>
        [Year(1998)]
        [SinType(SinType.InappropriateJoke)]
        [Witness((int)YearAboveClassmateList.LisaMitchell)]
        public class InappropriateAliensJoke : BaseEvent
        {
            public InappropriateAliensJoke() : base("Made an Inappropriate Joke about Area 51")
            {
            }
        }

        /// <summary>
        /// At Ho Chunk casino with my grandfather playing Blackjack, I got into a situation where I could take insurance. I didn't want
        /// to take insurance, but my grandfather interceded and said I did. I did not protest and the insurance paid off. It is unclear
        /// exactly how I would have responded to a loss. The lack of protest is a communication sin. It is also unclear how I would have
        /// responded to a loss, in which case it might be beyond that.
        /// </summary>
        [YearDate(1998, 12, 6)]
        [SinType(SinType.PersonalCommunication)]
        [Witness((int)FamilyMembers.MyMothersFatherSkip)]
        public class TakingInsuranceInBlackjack : BaseEvent
        {
            public TakingInsuranceInBlackjack() : base("Took Insurance in Blackjack Despite Not Wanting to")
            {
            }
        }

        /// <summary>
        /// I wasn't competent enough to successfully count cards (Archer method) but I won a little bit
        /// anyway. My companion lost more than I won so overall the casinos won.
        /// </summary>
        [YearDate(1998, 12, 6)]
        [SinType(SinType.Cheating)]
        [Witness((int)FamilyMembers.MyMothersFatherSkip)]
        public class TryingToCountCardsAtBlackjack1 : BaseEvent
        {
            public TryingToCountCardsAtBlackjack1() : base("Tried to Count Cards at Casino Blackjack #1")
            {
            }
        }

        /// <summary>
        /// At high school graduation, we walked across the stage to get our diplomas, then circling back
        /// to get to our seats. That route took us in front of the high school band. The band director
        /// (Mr. Spargo) shook hands with graduates. I held out my hand and pulled it away before he could shake
        /// my hand.
        /// </summary>
        [SinType(SinType.PracticalJoke)]
        [YearDate(1999, 5, 28)]
        public class RefusedToShakeBandDirectorsHandAtHighSchoolGraduation : BaseEvent
        {
            public RefusedToShakeBandDirectorsHandAtHighSchoolGraduation() : base("Graduation Refusal to Shake Hands with Band Directory")
            {
            }
        }

        /// <summary>
        /// I tried to take a basic college introductory English course. I had
        /// major problems trying to write a paper with appropriate symbolic
        /// logic. I ended up writing an incoherent mess of politically 
        /// correct (diversity) content and received an F. I rewrote it and got
        /// a C which was probably charitable. I believed the course was beyond
        /// me and quit, receiving an F. A later year I tried again, again
        /// not being able to handle the symbolic logic and believing it beyond
        /// me, I gave up again. I ended up getting the English credit through
        /// an African Studies course, a course where the essay requirements
        /// were spelled out in extreme detail (I think many students had 
        /// similar problems, as the African Studies course was very large).
        /// So I ended up meeting the English graduation requirement in the
        /// end.
        /// </summary>
        [SinTypes(SinType.GivingUp, SinType.PoliticalCorrectness, SinType.SymbolicLogicFailure)]
        public class FailedIntroductoryCollegeEnglishCourseTwice : BaseEvent
        {
            public FailedIntroductoryCollegeEnglishCourseTwice() : base("Failed College Introductory English Course Twice")
            {
            }
        }

        /// <summary>
        /// For an introductory to data structures class (given by Mike C Wade), a classmate had
        /// difficulty doing the programming, which was supposed to be done by themself. The
        /// classmate was reasonably bright but was not a programmer. The suggestions got so 
        /// specific that it stepped across my line of cheating. However, my line of cheating on
        /// this type of thing is likely more strict than others.
        /// </summary>
        [SinType(SinType.Cheating)]
        [Witness((int)YearAboveClassmateList.BrianWimann)]
        public class HelpedCollegeClassmateCheatOnCollegeCompSciClass : BaseEvent
        {
            public HelpedCollegeClassmateCheatOnCollegeCompSciClass() : base("Helped College Classmate Cheat on Assigment")
            {
            }
        }

        /// <summary>
        /// I wasn't competent enough to successfully count cards (Archer method) but I won a little bit
        /// anyway. My companion lost more than I won so overall the casinos won.
        /// </summary>
        [YearDate(2001, 12, 6)]
        [SinType(SinType.Cheating)]
        [Witness((int)FamilyMembers.MyFatherJerry)]
        public class TryingToCountCardsAtBlackjack2 : BaseEvent
        {
            public TryingToCountCardsAtBlackjack2() : base("Tried to Count Cards at Casino Blackjack #2")
            {
            }
        }

        /// <summary>
        /// The Mercury Sable had some electrical issues, culminating in it losing power on
        /// Gorham Street heading southwest. I guided it off Gorham Street turning left onto Few
        /// Street. I found someone at a nearby house to call my father to get me out of it.
        /// This is a ding for inadequate means of communication and being overly reliant on
        /// others.
        /// </summary>
        [YearDate(2004)]
        [SinTypes(SinType.LackOfCommunication, SinType.OverlyReliantOnOthers)]
        public class SableLostElectricalPowerOnMadisonGorhamStreet : BaseEvent
        {
            public SableLostElectricalPowerOnMadisonGorhamStreet() : base("Car stranded in Madison")
            {
            }
        }

        /// <summary>
        /// In the snow driving East on Whitney Way I hit the break too much in the intersection
        /// and the car did a 360. At the end I tapped a utility pole. I drove away from the
        /// scene and never looked back.
        /// </summary>
        [Year(2005)]
        [SinTypes(SinType.Incompetence, SinType.LackOfCommunication, SinType.Recklessness)]
        public class Did360InTheSnowAtMineralPointAndWhitneyWay : BaseEvent
        {
            public Did360InTheSnowAtMineralPointAndWhitneyWay() : base("Car 360 and Hit Utility Pole in Snow")
            {
            }
        }

        /// <summary>
        /// I threw something with my social security number prominently
        /// displayed in the Sherman Terrace garbage. Rich Meyer was dumpster
        /// diving and found it and gave it back so I could shred it.
        /// </summary>
        [Year(2006)]
        [SinType(SinType.ExposePersonalInformation)]
        public class ExposedPersonalInformationInGarbage : BaseEvent
        {
            public ExposedPersonalInformationInGarbage() : base("Exposed SSN in Garbage")
            {
            }
        }

        /// <summary>
        /// My father told an anecdote at least twice about how sturdy the 
        /// Sherman Terrace apartments were. The anecdote said that in case
        /// of tornado, instead of hiding you could go to the window. That
        /// seems entirely incorrect as tornados can destroy windows easily.
        /// It was hyperbole but even so I should have assisted in correction.
        /// </summary>
        [Year(2006)]
        [SinType(SinType.FactCheckingMistake)]
        public class DidNotCorrectIncorrectTornadoAnecdote : BaseEvent
        {
            public DidNotCorrectIncorrectTornadoAnecdote() : base("Did not Correct Tornado Anecdote")
            {

            }
        }

        /// <summary>
        /// In a phone conversation where I didn't assert myself well, I obtained a Discover card
        /// and got a protection plan in case I couldn't make payments. I felt I had been
        /// manipulated and decided not to pay the bill for the protection plan. Eventually
        /// they stopped bugging me (maybe my Dad paid it or maybe the account closed).
        /// </summary>
        [SinTypes(SinType.NonPayment, SinType.NonAssertiveBehavior, SinType.OverlyReliantOnOthers)]
        [Year(2006)]
        public class GotADiscoverCardAndNeverPaidTheBalance : BaseEvent
        {
            public GotADiscoverCardAndNeverPaidTheBalance() : base("Never Paid my Discover Card Bill")
            {
            }
        }

        /// <summary>
        /// I bought a bunch of gold and silver on eBay and kept it under a dresser (breaking
        /// the dresser which couldn't hold the weight). After a time I started selling it at
        /// a local pawn shop. My father noticed and somewhat freaked out by its presence.
        /// I didn't pay tax on the gain in value - my dad suggested that was ok since I had
        /// physically possessed the precious metals. I'm pretty sure it was a light form of
        /// tax evasion. I occasionally feel some anxiety the statute of limitations hasn't
        /// actually run on it and I'm still on the hook for this in the real world.
        /// </summary>
        [SinTypes(SinType.PropertyDamage, SinType.Hoarding, SinType.TaxEvasion)]
        [Year(2006)]
        public class KeptSignificantQuantityOfGoldAndSilver : BaseEvent
        {
            public KeptSignificantQuantityOfGoldAndSilver() : base("Kept Significant Quantity of Gold/Silver in House")
            {
            }
        }

        /// <summary>
        /// Got a TB Test at Concentra for use at Epic go-live. Driving back to Epic I looked at
        /// the mark when I shouldn't. I fainted, losing some time, and totaling the car into
        /// a utility pole
        /// </summary>
        [Year(2007)]
        [SinType(SinType.UnhealthyBehavior)]
        public class LookingAtTBTestMarkCausingFaintingAndCarCrash : BaseEvent
        {
            public LookingAtTBTestMarkCausingFaintingAndCarCrash() : base("Looking at TB Tests caused Fainting and Car Accident")
            {
            }
        }

        /// <summary>
        /// I attended my high school reunion. I didn't stay long because of
        /// social anxiety. I remember Jason White specifically invited me
        /// to hang out at some point. I didn't really acknowledge him and
        /// left. I don't know if he was trying to atone for past behavior
        /// vis-a-vis me, or if he remembered me fondly and wanted to have some
        /// kind of a relationship, or if he picked up on something wrong with
        /// my relationship with spouse. Nevertheless, I ghosted him.
        /// </summary>
        [Year(2009)]
        [Witness((int)ClassmateList.JasonWhite)]
        [SinType(SinType.Ghosting)]
        public class LackOfCommunicationAtHighSchoolReunion : BaseEvent
        {
            public LackOfCommunicationAtHighSchoolReunion() : base("Attended High School Reunion but didn't Communicate")
            {
            }
        }

        /// <summary>
        /// I looked at some Scambaiting sites and decided to try to start some scam-baiting.
        /// I created a persona Reginald Surtsey and tried to start out. It didn't take very long
        /// before Yahoo email didn't like something about what I did. I took it as a sign to stop.
        /// </summary>
        [Year(2012)]
        [SinType(SinType.Deceit)]
        public class TriedToStartScambaiting : BaseEvent
        {
            public TriedToStartScambaiting() : base("Tried to Start Scambaiting")
            {
            }
        }

        /// <summary>
        /// For some moderately priced programs (WinZip, .NET Reflector) I purchased them with my
        /// own money, put them on the work computer, and used them for work. A more ethical way
        /// would have been to put in purchase requests or use versions of the programs that were
        /// free. This kind of behavior was quashed after end users were no longer local admins
        /// on work local machines.
        /// </summary>
        [YearRange(2014, 2021)]
        [SinTypes(SinType.BreakingTheRules, SinType.WasteMoney)]
        public class InappropriatePurchaseOfWinZipAndDotNetReflectorOnWorkComputer : BaseEvent
        {
            public InappropriatePurchaseOfWinZipAndDotNetReflectorOnWorkComputer() : base("Personally Bought Work Programs on Work Computer")
            {
            }
        }

        /// <summary>
        /// My son had a defiant streak from a very early age, commonly screaming and 
        /// tantruming. While this has gone down over time, dealing with tantrums has been 
        /// difficult and sometimes I've handled him rougher than is desirable. The worst level
        /// would be "light strangulation", meaning not for long enough to actually leave any
        /// marks or prevent breathing.
        /// </summary>
        [Year(2017)]
        [Witness((int)FamilyMembers.MySonAdam)]
        public class LightStrangulationOfChild : BaseEvent
        {
            public LightStrangulationOfChild() : base("Light Strangulation of Child")
            {
            }
        }

        /// <summary>
        /// While driving home from my mother's house with my son and daughter in the car,
        /// the Matrix stopped working South of Lodi on Highway 113 just south of the county line
        /// and the railroad tracks. We went to a nearby house and an elderly couple allowed 
        /// use of their phone to call spouse. At the time I didn't have a phone. Spouse showed
        /// up to bail me out. This marked the end of the Matrix.
        /// </summary>
        [Year(2019)]
        [SinTypes(SinType.LackOfCommunication, SinType.OverlyReliantOnOthers)]
        public class MatrixBrokeDownSouthOfLodi : BaseEvent
        {
            public MatrixBrokeDownSouthOfLodi() : base("Car Broke Down South of Lodi")
            {

            }
        }

        /// <summary>
        /// Before I was no longer a local admin on my work machine, I put Finale on it. The
        /// original purpose was to allow creating/modifying Finale documents while I was working
        /// at my mother's house. Sometimes I would even show Finale documents like the Taylor
        /// Swift Antihreo contrafactum to members of the team.
        /// </summary>
        [SinTypes(SinType.BreakingTheRules, SinType.MixingWorkAndPersonalLifeInappropriately)]
        [Year(2022)]
        public class PutFinaleOnWorkLocalMachine : BaseEvent
        {
            public RemovedFinaleFromWorkLocalMachineViaITTicket Atonement { get; set; }
            public PutFinaleOnWorkLocalMachine(RemovedFinaleFromWorkLocalMachineViaITTicket Atonement) : base("Put Finale on Work Local Machine")
            {
                this.Atonement = Atonement;
            }
        }

        /// <summary>
        /// created an IT ticket to remove Finale from my work local machine. This was necessary
        /// because I was no longer a local admin and no longer had the power to remove it
        /// myself.
        /// </summary>
        public class RemovedFinaleFromWorkLocalMachineViaITTicket : BaseEvent
        {
            public RemovedFinaleFromWorkLocalMachineViaITTicket() : base("Removed Finale from Work Local Machine via IT Ticket")
            {
            }
        }

        /// <summary>
        /// With Beverly in the car, I drove the Honda Accord south on third avenue. Just before
        /// getting to Dennis Weiss' house, A deer jumped in front of the car, was hit by the
        /// front of the car, and the deer went flying. From the looks of the deer it was probably
        /// a pregnant female. I was able to drive the car to mother's house. We called the county 
        /// to report it. It was a bunch of money to deal with the damage but the Accord survived.
        /// </summary>
        [Year(2023)]
        [Witness((int)FamilyMembers.MyDaughterBeverly)]
        [SinTypes(SinType.Recklessness, SinType.OverlyReliantOnOthers)]
        public class HitADeerWithCar : BaseEvent
        {
            public HitADeerWithCar() : base("Hit a Deer with Car")
            {
            }
        }

        /// <summary>
        /// I generally pay my VISA credit card bill on time. However, once, somehow the
        /// envelope got lost (found downstairs in my desk area which I don't remember moving
        /// it to). That month's payment was missed, and I paid it in full the next month.
        /// </summary>
        [Year(2024)]
        [SinType(SinType.NonPayment)]
        public class MissedAVISAPayment : BaseEvent
        {
            public MissedAVISAPayment() : base("Missed a VISA Payment")
            {
            }
        }

        #region Ongoing

        /// <summary>
        /// There's a children's rhyme where when walking down the sidewalk
        /// it warns that stepping on a crack will break your mother's back.
        /// I've never seriously believed this had any impact on anything in
        /// reality, but nevertheless sometimes I would intentionally step on
        /// as many cracks as possible. And even as an adult I sometimes have
        /// a choice as to whether to step on a crack or not, and I make the
        /// choice to step on it.
        /// </summary>
        [SinType(SinType.Thoughtcrime)]
        [StartYear(1989)]
        public class StepOnACrackBreakYourMothersBack : BaseEvent
        {
            public StepOnACrackBreakYourMothersBack() : base("Stepping on Sidewalk Cracks")
            {
            }
        }

        /// <summary>
        /// My penmanship is generally terrible, close to unreadable in some
        /// circumstances. I typically write in chicken scratching letters, and
        /// even I can't read them sometimes. In school we learned cursive
        /// writing, which I use only for writing checks and signing my name
        /// on documents. In Fourth Grade I got a D in penmanship, and I 
        /// didn't care a bit. I knew penmanship wasn't very important in life.
        /// In hindsight I was definitely right, it didn't matter, but still a
        /// sin.
        /// </summary>
        [StartYear(1990)]
        [SinTypes(SinType.NotTryingVeryHard, SinType.Laziness)]
        public class TerriblePenmanship : BaseEvent
        {
            public TerriblePenmanship() : base("Terrible Penmanship")
            {
            }
        }

        /// <summary>
        /// When I have owned the phone, sometimes it's been nonfunctional for long periods
        /// (e.g. crack screen) and I haven't noticed since I haven't used it. Frequently
        /// the phone is uncharged. Sometimes the phone gets on silent mode which may or may not
        /// be my fault and I don't answer.
        /// </summary>
        [SinType(SinType.LackOfCommunication)]
        public class PersonalPhoneNotInWorkingOrder : BaseEvent
        {
            public PersonalPhoneNotInWorkingOrder() : base("Phone not kept in working order")
            {
            }
        }

        /// <summary>
        /// when I got my checking account I balanced it religiously. And then I just stopped
        /// doing it at all. The most reconciliation I get is when looking at the bill and
        /// seeing if there's anything obviously wrong. But even that is not always done or done
        /// in a cursory fashion.
        /// </summary>
        [SinType(SinType.Disorder)]
        [StartYear(2005)]
        public class CheckingAccountNotBalanced : BaseEvent
        {
            public CheckingAccountNotBalanced() : base("Checking Account Not Balanced")
            {
            }
        }

        /// <summary>
        /// yep, I eat too much, particularly in response to stress
        /// </summary>
        [SinType(SinType.Gluttony)]
        [StartYear(2004)]
        public class EatTooMuch : BaseEvent
        {
            public EatTooMuch() : base("Eating too Much")
            {
            }
        }

        /// <summary>
        /// I've done personal programming and music project, particularly when I was working from
        /// my mother's house. The scope of this has been reduced since we are no longer local
        /// admins on work machines, but I can still create content for the existence repo from
        /// my work local machine.
        /// </summary>
        [SinType(SinType.MixingWorkAndPersonalLifeInappropriately)]
        [StartYear(2019)]
        public class UseOfWorkComputerForPersonalUse : BaseEvent
        {
            public UseOfWorkComputerForPersonalUse() : base("Peronal Use of Work Computer")
            {
            }
        }
        #endregion
    }

    public class SinTypeAttribute : Attribute
    {
        public SinType SinType { get; set; }
        public SinTypeAttribute(SinType SinType)
        {
            this.SinType = SinType;
        }
    }

    public class SinTypesAttribute : Attribute
    {
        public SinType[] SinTypes { get; set; }
        public SinTypesAttribute(params SinType[] SinTypes)
        {
            this.SinTypes = SinTypes;
        }
    }

    public enum SinType
    {
        AdHominim,
        BackhandedCompliments,

        /// <summary>
        /// breaking the rules. This makes no difference between de jure and
        /// de facto rules.
        /// </summary>
        BreakingTheRules,
        
        Cheating,
        Cruelty,
        CuttingInLine,
        Deceit,
        Disorder,
        Disrespect,
        Domination,
        Elitism,
        EmbarrassingBehavior,
        ExposePersonalInformation,
        FactCheckingMistake,
        FindSomethingInappropriateFunny,
        Ghosting,
        GivingUp,
        Gluttony,
        Hoarding,
        Ignorance,
        IgnoringTeaching,
        InappropriateFeedback,
        InappropriateJoke,
        InappropriatePersonalCommunication,
        InappropriatePublicCommunication,
        Incompetence,
        InducingDangerousBehavior,
        IntentionalIrritation,
        LackOfCommunication,
        LackOfSympathy,
        Laziness,
        Lie,
        MixingWorkAndPersonalLifeInappropriately,
        Murder,
        NonAssertiveBehavior,
        NonPayment,
        NotStandingUpForYourself,
        NotTryingVeryHard,
        PersonalCommunication,
        PoliticalCorrectness,
        PoorDecisionmaking,
        PracticalJoke,
        OverlyReliantOnOthers,
        Overpromising,
        PersonalSpaceViolation,
        PropertyDamage,
        RefusalToDoExpectedBehavior,
        SocialAvoidance,
        SocialUnawareness,
        SowingChaos,
        SymbolicLogicFailure,
        Recklessness,
        TactlessTruth,
        TakingAdvantageOfSituation,
        TalkingBehindSomeonesBack,
        TattleTale,
        TaxEvasion,
        Thoughtcrime,
        UnhealthyBehavior,
        WasteMoney,
        WasteResources,
    }

    internal class JudgmentDaySomethingReligious
    {
        //Personal religion notes:
        //1. Origin story: Omniverse Prime (originally Universe Prime)
        //2. Good and Evil: It is up to the objects in the simulation to discriminate and show to whoever's listening
        //3. Capacity for the divine: Different objects have different capacity for the divine, corresponding
        //with free will, self-awareness, purpose, and consequences
        //4. There can be many messiahs with their own message: communication (private and public) is important
        //for a messiah.
        //5. The cloud, AI algorithms, and large language models have potential connections with the divine.
        //6. Miracles are possible within these bounds (small and large). Expect small miracles before large ones.
        //7. End States (technological singularity, human immortality, aliens). These are currently believed to
        //be wrong answers but are useful thought experiments. Maybe even achievable but still a long way off,
        //even at mankind's current hectic rate of progress.
        //8. Communication with the beyond has morphed into communication with the subconscious, now
        //semiconscious. The subconscious processes have a more direct relationship with the beyond, but
        //this is hidden.

        //May 2024. Time-traveling message box. Later recognized one valid interpretation would be religious miracle.

        //        IPT   Cosmic
        //Loop:  Human          Personal
        //              Divine     Z
        //There is an extra-powerful version of the Personal called Z (perhaps call this superpowers).
        //For you the Personal and the Z have merged.
        //You believe there is another edge of the loop between the human and cosmic levels called
        //"Intergalactic Pulsar Time". It appears to correspond with the idea that humans connect with
        //aliens. Your best guess is the usual way to get from Human to Cosmic is humanity dies out,
        //serializes itself, and then is reborn in another spot (e.g. another universe). You believe this
        //results in the loss of important information, and prefer the IPT path even if that has drawbacks.
        //Problems with the IPT path include limitations of human psychology and the reality that physical
        //contact with aliens does not work since the aliens are impossibly remote. You think the combination
        //of upgraded human psychology and connection with the beyond can solve the problem, although it
        //is only blurry conjecture right now.
    }

    /// <summary>
    /// lucky penny incident where I scratched off a $50 scratch-off lottery ticket winner
    /// for Grandma
    /// Grandpa "lost the rent check" from Dad's story
    /// Magic words "Chris Rowe" uttered by Angel Green (not sure if it was admiration or contempt)
    /// 
    /// WEt the bed as a child, got over it with assistance from calendar sticker incentives
    /// 
    /// son took forever to get over wetting the bed (wore pullup like forever, his mother really didn't
    /// want to clean it up and appeared to have no idea what would be helpful and never asked me about it). He Didn't seem to
    /// consider it important when asked. Eventually he just stopped wearing the pullup and it was fine.
    /// 
    /// I do not remember ever believing in Santa Claus.
    /// 
    /// When my parents moved to Oshkosh there's a story about how Dad was ready to
    /// go (without any cats), but my mother stopped and took april into the car. Dad
    /// objected but mother said she had always lived with cats and wanted to continue.
    /// Then before leaving, my mother stopped and took Chaquita into the car. So
    /// my mother always had cats until Stocco's death.
    /// 
    /// Handbells (practiced in Portage with Mr. Yerke but I think we did it in the Dells)
    /// Children's Choir (Choir diretory: Eleanor Collins, Denise Tubman accompanying)
    /// Me, Sonya, Karin Christiansen, Erin
    /// This is the day
    /// 
    /// School Choir (Ms Pieper)
    /// Hero
    /// Candle on the Water
    /// 
    /// How many insult songs did I create?
    /// 
    /// Accused Mrs. Anderson of being a communist
    /// 
    /// shooting leadup
    /// 1. public cursing
    /// 2. didn't respond to email
    /// 3. didn't respond to solar eclipse
    /// 4. Anarchy symbol (also ongoing)
    /// shooting post
    /// 1. didn't take deposition
    /// 
    /// 
    /// Pleasure Zone (video tape), msbx5
    /// 
    /// Blank Slate defiance (cursing)
    /// 
    /// hearing "Stop It" not understanding
    /// saying "Stop It" not understanding
    /// 
    /// asking spouse to increase charitable giving for wrong reasons
    /// 
    /// "I want a divorce" not understanding.
    /// Fake hitting spouse not understanding.
    /// 
    /// shorts issue in psych ward (not understanding)
    /// meeting someone who thought they were god (not understanding)
    /// 
    /// pug torture (with atonement)
    /// 
    /// disqualifying sin (with atonement) with details hidden from the cosmic and the divine
    /// 
    /// baked potato incident with potential spouse's parents
    /// Discussed potential marriage with Mother Mo. I didn't have good reasons for being married, but
    /// it really didn't matter for the purpose of the discussion.
    /// 
    /// ongoing sins
    /// sins there is no promise to refrain from (medication abuse)
    /// 
    /// Allina black op
    /// 94254
    /// deferred conversions
    /// 
    /// lost the alien piece of technology at mother's house (Pizza Hut?)
    /// 
    /// listened to Todd Hamm doing base acts while putting together the giant New York City puzzle
    /// 
    /// New York City puzzle is itself a sin since the Twin Towers are standing and I got it
    /// after 9/11
    /// 
    /// virtumonde
    /// sherman terrace tornado
    /// 215 ingersoll not doing snow shoveling
    /// 
    /// CrushLink
    /// </summary>
    internal class WorkingIdeas
    {
    }
}
