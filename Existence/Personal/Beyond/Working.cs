
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

namespace Existence.Personal.Beyond
{

    internal class JudgmentDaySins
    {
        public JudgmentDaySins()
        {
            MyReligiousFlags religiousFlags = new MyReligiousFlags(null);
            new StickingFingerInExposedPowerOutlets();
            new HeadInjuryFromRunningAroundHouseTooFast();
            new ILikeToFartHandPuppetPlay();
            new HidSistersBlanketComfortObject();
            new SomeoneClaimedSomeoneElseWasDeadInSchool();
            new PersonalFirstParodySong();
            new PersonalFirstOriginalSong();
            new SomeoneCalledMeAGeniusGhosting();
            new SkippedOutOnHalloweenClassParty();
            new FlashcardsDomination();
            new FocusedOnDevelopingAnalyticalThinkingSkillsAtTheExpenseOfCommunicationSkills();
            new ChildhoodNativityPlayDisrespect1(religiousFlags);
            new ChildhoodNativityPlayDisrespect2(religiousFlags);
            new SkepticismOfReligionPersonal(religiousFlags);
            new WetTheBedAtChurchCamp();
            new GuaranteedNoCarAccidentWouldOccur();
            new HalloweenCostumeAsGhostAndSelf();
            new SowingChaosInChurchChildrensChoirPractice();
            new HittingMySister();
            new CheatedAtUpperElementaryDodgeball();
            new DidntWantMyPictureTaken();
            new EmbarrassingLittleKidBehaviorAtProfessionalPhotographer();
            new TheEducationalValueOfThisIsQuestionable();
            new AssistedGettingMySummerProgramRoommateExpelled();
            new CarAccidentBackingUpAtGrandparentsFarm();
            new EnglishPaperClaimingPeopleAreInherentlyStupid();
            new ChairBurningAtPicnicPoint();
            new LiedAboutHavingGirlfriend();
            new SowingChaosAtHighSchoolBandPractice();
            new ClaimedPsychologyIsBullshitInClassAssignment();
            new WalkedThirteenAndAHalfMilesHomeFromSchool();
            new TakingInsuranceInBlackjack();
            new TryingToCountCardsAtBlackjack1();
            new RefusedToShakeBandDirectorsHandAtHighSchoolGraduation();
            new TryingToCountCardsAtBlackjack2();
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
        /// Wet the bed at church camp, getting sleeping bag all messy. Camp counselor washed it for me. It shook
        /// me up a lot since I thought I was past this. I treat this as a sin since I could have avoided it with
        /// smarter behavior.
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
        [ApproximateAgeInYears(12)]
        public class DidntWantMyPictureTaken : BaseEvent
        {
            public DidntWantMyPictureTaken() : base("Didn't want my Picture Taken")
            {
            }
        }

        /// <summary>
        /// this refers to an incident where I was old enough to know better but I still forced the professional
        /// photographer to treat me like a little child to get the picture done.
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
        /// At church camp we were allowed to rate the different activities. A fellow camper excelled at negative
        /// reviews, giving a negative review to the canoeing activity. I found this excessively funny.
        /// I have tried using the phrase since, but whenever I use it myself it doesn't seem to work.
        /// </summary>
        [SinType(SinType.FindSomethingInappropriateFunny)]
        [ApproximateAgeInYears(14)]
        [MagicWords("The educational value of X is questionable", "Fellow Church Camper", "Church Camp", "Church Campers")]
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
        /// typically when my mother's brother or mother's brother's son would ask if I had a girlfriend I would
        /// say no. But this one time, I remembered a somewhat attractive girl from a WCATY event. Her name was
        /// Allison and I never spoke to her directly, and never mentioned her to anyone else except for this lie.
        /// </summary>
        [ApproximateAgeInYears(16)]
        [SinType(SinType.Lie)]
        public class LiedAboutHavingGirlfriend : BaseEvent
        {
            public LiedAboutHavingGirlfriend() : base("Lied about having a Girlfriend")
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
        Cheating,
        Cruelty,
        Disrespect,
        Domination,
        EmbarrassingBehavior,
        FindSomethingInappropriateFunny,
        InappropriatePersonalCommunication,
        InappropriatePublicCommunication,
        IntentionalIrritation,
        LackOfCommunication,
        Laziness,
        Lie,
        PersonalCommunication,
        PoorDecisionmaking,
        PracticalJoke,
        Overpromising,
        PropertyDamage,
        RefusalToDoExpectedBehavior,
        SocialAvoidance,
        SocialUnawareness,
        SowingChaos,
        Recklessness,
        TactlessTruth,
        TattleTale
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
    /// 
    /// WEt the bed as a child, got over it with assistance from calendar sticker incentives
    /// last wet the bed incident was at Pine Lake camp (camp counselor washed the sleeping bag)
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
    /// How many insult songs did I create?
    /// 
    /// Called piano teacher beef jerky
    /// 
    /// Accused Mrs. Anderson of being a communist
    /// 
    /// Car Accidents:
    /// 1. Hit a turkey
    /// 2. Sable losing electrical power on Gorham Street
    /// 3. Matrix breaking down on 113 south of Lodi
    /// 4. Hit a deer
    /// 
    /// shooting leadup
    /// 1. public cursing
    /// 2. didn't respond to email
    /// 3. didn't respond to solar eclipe
    /// shooting post
    /// 1. didn't take deposition
    /// 
    /// clarinet squeaking during solo and ensemble bad
    /// show choir amp malfunction leading to ridiculous sound
    /// 
    /// School Choir (Ms Pieper)
    /// Hero
    /// Candle on the Water
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
    /// dog choke chain
    /// light strangulation
    /// </summary>
    internal class WorkingIdeas
    {
    }
}
