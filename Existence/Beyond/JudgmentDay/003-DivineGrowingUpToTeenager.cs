using static Existence.Beyond.JudgmentDay.BirthToGrowingUp;
using Existence.Beyond.CosmicSubmission;
using Existence.Beyond.Infrastructure;
using Existence.Earth;
using Existence.Earth.Alphabet;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.Human.People;
using Existence.Personal;
using Existence.Song;
using Existence.Time;
using System;
using System.Collections.Generic;
using Existence.Earth.Religions;
using static Existence.Beyond.JudgmentDay.HumanDivineGrowingUpToTeenager;
using Existence.Earth.FieldsOfStudy.Mathematics;

namespace Existence.Beyond.JudgmentDay
{
    [MusicNotesRepositoryScriptFile(@"Released\Scripts\001-JudgmentDayDivineTeenager.txt", PeopleEnumerated.RoweChris)]
    internal class HumanDivineGrowingUpToTeenager : JudgmentDayBase
    {
        public enum VersionHistory
        {
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 4, 5)]
            InitialRelease,

            [BeyondObjectVersion(1, 1, 0, 0)]
            [YearDate(2025, 4, 6)]
            AddTimelessChoirDirectorsAndArrangements,

            [BeyondObjectVersion(1, 2, 0, 0)]
            [YearDate(2025, 4, 18)]
            StartIntegratingSinsWithGeniusGhosting,

            [BeyondObjectVersion(1, 3, 0, 0)]
            [YearDate(2025, 5, 3)]
            MadeSomeEventsMorePubliclyAvailable,
        }

        private IfIWasAnOmnipotentBeing _IfIWasAnOmnipotentBeing;

        internal override List<LevelJustification> GetLevelJustifications()
        {
            return new List<LevelJustification>()
            {
                new ReleaseSongJustification(_IfIWasAnOmnipotentBeing, SongJustificationType.ReleaseSong),
                new ReleaseSongJustification(ImportantSongs.WadeInTheWater, SongJustificationType.InterpretSongMeaning),
                new ReleaseSongJustification(ImportantSongs.AwesomeGod, SongJustificationType.InterpretSongMeaning),
                new ReleaseSongJustification(ImportantSongs.OneOfUs, SongJustificationType.InterpretSongMeaning),
                new ReleaseSongJustification(ImportantSongs.CanticleOfTheTurning, SongJustificationType.InterpretSongMeaning),
            };
        }

        internal override List<TimelessChange>? GetTimelessChanges()
        {
            new TimelessChange("Genericize Favorite Number"); //this is a freebie
            return new List<TimelessChange>()
            {
                new TimelessChange("Add Timeless Religion"),
                new TimelessChange("Add Nuclear Family Religions"),
                new TimelessChange("Add Choir Directors"),
                new TimelessChange("Add Wade in the Water Arrangement"),
                new TimelessChange("Add Canticle of the Turning Arrangement")
            };
        }

        /// <summary>
        /// this particular year of sunday school is the most important
        /// but I don't really know why.
        /// </summary>
        public static List<int> SeventhGradeSundaySchoolClassmates;

        /// <summary>
        /// static constructor
        /// </summary>
        static HumanDivineGrowingUpToTeenager()
        {
            //one member is missing from the list. I have a photograph but
            //do not recognize him.
            SeventhGradeSundaySchoolClassmates = new List<int>()
            {
                (int)ClassmateList.JessicaLloyd,
                (int)YearBelowClassmateList.CassieMattei,
                (int)ClassmateList.StephanieHartman,
                (int)ClassmateList.GregFarrington,
                (int)ClassmateList.JasonWhite,
            };
        }

        public HumanDivineGrowingUpToTeenager()
        {
            MyReligiousFlags myReligionFlags = new MyReligiousFlags(Skepticism: null);
            _IfIWasAnOmnipotentBeing = new IfIWasAnOmnipotentBeing();

            List<BaseEvent> events = new List<BaseEvent>()
            {
                new PersonalBirth(myReligionFlags),
                new MyBaptism(),
                new ChurchTransitionAfterMove(USCities.WisconsinEndeavor, myReligionFlags),
                new ChildhoodNativityPlayDisrespect1(myReligionFlags),
                new StartedPianoLessons(myReligionFlags),
                new ChildhoodNativityPlayDisrespect2(myReligionFlags),
                new SomeoneCalledMeAGenius(
                 ZStuff.MAGIC_WORDS_HES_A_GENIUS,
                 (int)ClassmateList.LauraCummings,
                 (int)FamilyMembers.MyMothersBrotherGerald,
                 (int)PersonalChurches.SaintJohnLutheranChurch,
                 new SomeoneCalledMeAGeniusGhosting()),
                new MultiEvent("ReligiousSkepticism",
                    [new SkepticismOfReligionPersonal(myReligionFlags),
                    new ChurchChoirDirectorEvent(ChurchChoirDirectors.EleanorCollins, ChoirType.Childrens)]),
                new FirstCommunionAsAnAcolyte(myReligionFlags),
                new LeadRoleInSilentNightChristmasPageant(myReligionFlags),
                new MultiEvent("Pre-atheist Events",
                    [new HesGotReligionMagicWords((int)ClassmateList.JasonWhite, (int)ClassmateList.JustinRaudebush, "Present, listening, kept silent", (int)PersonalSchools.SpringHillMiddleSchool, myReligionFlags),
                    new ELCALutheranConfirmationDespiteNearAtheism()]),
                new BecameAnAtheist(myReligionFlags),
                new SemipubliclyClaimToBeTheAntichristAsAJoke(),
                new DoSomethingWithYourSoulAsAJokeAndItsUnclearWhatHappensToIt(),

                new MultiEvent("College Philosophy",
                  [new BrieflyBecameAgnosticBasedOnCollegePhilosophyClass(myReligionFlags),
                   _IfIWasAnOmnipotentBeing]),

                new MarriageInAChurch(PersonalChurches.SaintDunstansEpiscopalChurch, myReligionFlags),
                new ChurchChoirDirectorEvent(ChurchChoirDirectors.MitchellPatton, ChoirType.Adult),
                new IamthePopeOriginalSong(),
                new MetSomeoneWhoSeemedToThinkHeWasGod((int)PersonalHospitals.SaintMarysMadisonWisconsin),
                new ChurchChoirDirectorEvent(ChurchChoirDirectors.MartinGanschow, ChoirType.Adult),

                new CreatedSoloArrangementOfReligiousSong(ImportantSongs.WadeInTheWater),
                new WordBasedSynethesiaDuringChurchService(),
                new SemiPubliclyPerformedMyArrangementInChurch((int)PeopleEnumerated.RoweChris, ImportantSongs.WadeInTheWater),

                new ChoirSangFutureChoirDirectorArrangement(ChurchChoirDirectors.DeannaClement, ImportantSongs.CanticleOfTheTurning),
                new ChurchChoirDirectorEvent(ChurchChoirDirectors.DeannaClement, ChoirType.Adult),

                new DoneWithChurchWithAPushFromCovid(),

                new StartedMyOwnReligion(myReligionFlags),
                new PersonalReligionContrafactum1(ImportantSongs.AwesomeGod, myReligionFlags),
                new PersonalReligionContrafactum2(ImportantSongs.OneOfUs),
                new ZDeviationMessageBoxViolatingCausality(myReligionFlags),
            };
            OrderedEvents eventsOrdered = new OrderedEvents(null, events);

            //relevant for the religion, but not for the growing up part
            new GivingUpGivingUpSomethingForLentForLent(myReligionFlags);
        }

        /// <summary>
        /// I don't know if this happened in Harmony Grove or Oxford
        /// It doesn't really matter, I didn't have any agency relevent
        /// to this.
        /// </summary>
        public class MyBaptism : BaseEvent
        {
            public MyBaptism() : base("My Baptism")
            {

            }
        }

        /// <summary>
        /// The story here is my mother wanted to sit in on Sunday school but my mother's parents' church wouldn't let her.
        /// So she switched to a different church even though geographically it was less convenient (the Endeavor house
        /// was closer to Oxford than the Dells). I don't remember any of this, but in hindsight it may have been quite
        /// important to avoid the stricter (Missouri synod) denomination in favor of the less strict (ELCA). This
        /// was also good for my mother who taught the youngest Sunday school class (not early childhood) for
        /// many years.
        /// 
        /// I believe my father went to church for social reasons (not religious ones as he had issues with his Catholic
        /// school experience). In conversation after his retirement he stated he liked some religious discussions. But as
        /// far as I know he never went up to the communion rail to take Communion.
        /// </summary>
        public class ChurchTransitionAfterMove : BaseEvent
        {
            public ChurchTransitionAfterMove(USCities NewHome, MyReligiousFlags religiousFlags) : base("Endeavor Home Church Transition")
            {
                bool moved = false;
                foreach (PersonalChurches next in new PersonalChurches[] { PersonalChurches.SaintJohnLutheranChurch, PersonalChurches.BethanyLutheranChurch })
                {
                    if (SwitchChurchBasedOnMove(USCities.WisconsinEndeavor, next))
                    {
                        religiousFlags.BaseChurch = next;
                        religiousFlags.CurrentReligion = religiousFlags.PrimaryReligion = (int)ChristianDenominations.LutheranELCA;
                        moved = true;
                    }
                }
                if (!moved) throw new InvalidOperationException();
            }
            private bool SwitchChurchBasedOnMove(USCities Target, PersonalChurches church)
            {
                bool ret;
                if (Target == USCities.WisconsinEndeavor)
                {
                    if (church == PersonalChurches.SaintJohnLutheranChurch)
                        ret = false;
                    else if (church == PersonalChurches.BethanyLutheranChurch)
                        ret = true;
                    else
                        throw new InvalidOperationException();
                }
                else
                {
                    throw new InvalidOperationException();
                }
                return ret;
            }
        }

        /// <summary>
        /// I ignored the First Communion paraphernalia given to us at Sunday School and didn't do first communion.
        /// Typically I wouldn't even go up to the communion rail (following my father's lead). However, that could
        /// not be continued respectfully as an acolyte, so I did take communion in that context. Year is approximate.
        /// </summary>
        [Year(1992)]
        public class FirstCommunionAsAnAcolyte : BaseEvent
        {
            public FirstCommunionAsAnAcolyte(MyReligiousFlags myReligiousFlags) : base("First Communion as Acolyte")
            {
                myReligiousFlags.IncrementRespectful(1);
            }
        }

        /// <summary>
        /// I participated in a lead role (Franz Gruber) in a Christmas pageant telling the story of Silent Night.
        /// I did the best I could, which was typical for me in a singing/acting public display. Year is approximate.
        /// </summary>
        [Year(1994)]
        public class LeadRoleInSilentNightChristmasPageant : BaseEvent
        {
            public LeadRoleInSilentNightChristmasPageant(MyReligiousFlags myReligiousFlags) : base("Lead Role in Silent Night Church Christmas Pageant")
            {
                myReligiousFlags.IncrementRespectful(2);
            }
        }

        /// <summary>
        /// I took a philosophy class in college that made me think about my religion some
        /// more. For a time I considered myself an agnostic, but I eventually went back
        /// to atheist. I do not remember my logic, and I don't think it's important. For
        /// a time I had a private joke that "I'm an atheist except for a brief time in 
        /// college when I was an agnostic." The joke is that atheist and agnostic seemed
        /// very similar for a time. But in the long term, this seems to have been much
        /// more important than it seemed.
        /// </summary>
        [ApproximateAgeInYears(20)]
        [Year(2000)]
        public class BrieflyBecameAgnosticBasedOnCollegePhilosophyClass : BaseEvent
        {
            public BrieflyBecameAgnosticBasedOnCollegePhilosophyClass(MyReligiousFlags religionFlags) : base("Briefly an Agnostic in College")
            {
                religionFlags.CurrentReligion = (int)WorldReligions.Agnosticism;
                religionFlags.CurrentReligion = (int)WorldReligions.Atheism;
            }
        }

        [MusicNotesRepositoryAudioFile(@"Released\Audio\008-IfIWasAnOmnipotentBeing.wav", PeopleEnumerated.RoweChris)]
        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\013-IfIWasAnOmnipotentBeing.txt", PeopleEnumerated.RoweChris)]        
        public class IfIWasAnOmnipotentBeing : OriginalSongEvent
        {
            public IfIWasAnOmnipotentBeing() : base("If I was an omnipotent being")
            {
            }
        }

        [LocationInteger((int)PersonalChurches.SaintDunstansEpiscopalChurch)]
        [YearDate(2007, 4, 28)]
        public class MarriageInAChurch : BaseEvent
        {
            public PersonalChurches Church { get; set; }
            public MarriageInAChurch(PersonalChurches Church, MyReligiousFlags religiousFlags) : base("Got Married")
            {
                this.Church = Church;
                religiousFlags.BaseChurch = Church;
            }
        }

        /// <summary>
        /// while in the hospital for one of my three psychiatric hospitalizations at
        /// one hospital. I met someone who seemed to think he was God. I didn't think 
        /// much of it at the time and didn't strike up a relationship with him in
        /// any way. In retrospect it may have been more important than it seemed.
        /// And here is another place it is appropriate to ding me for poor
        /// communication. I don't know what I could have done to help both of us
        /// (I think we were both out of it at the time), but here any communication
        /// would have been better than none.
        /// </summary>
        [YearDate(2012)]
        [LocationInteger((int)PersonalHospitals.SaintMarysMadisonWisconsin)]
        [SinType(SinType.LackOfCommunication)]
        public class MetSomeoneWhoSeemedToThinkHeWasGod : BaseEvent
        {
            public int Location { get; set; }
            public MetSomeoneWhoSeemedToThinkHeWasGod(int Location) : base("Me Someone Who Seemed to Think he was God")
            {
                this.Location = Location;
            }
        }

        /// <summary>
        /// recovering from the WTS Paradigm shooting, I attended church services. During the
        /// service I saw my vision of words was affected based on how I felt about the liturgy.
        /// Some parts of the liturgy I would say at normal volume and others I would say at
        /// low volume or not at all. This also affected pronoun preferences, where I typically
        /// prefer a generic "he" to gender neutral language when referring to God.
        /// </summary>
        [YearDate(2018, 9, 23)]
        public class WordBasedSynethesiaDuringChurchService : BaseEvent
        {
            public WordBasedSynethesiaDuringChurchService() : base("Church Word-based Synestheia")
            {

            }
        }

        /// <summary>
        /// Inspired by
        /// 1. A coworker wading across the water at a work event at the zoo
        /// 2. A coworker having extreme difficult getting home after a strong local storm in August
        /// This is a solo voice + piano arrangement
        /// </summary>
        [YearMonth(2018, 8)]
        public class CreatedSoloArrangementOfReligiousSong : BaseEvent
        {
            public ImportantSongs Song { get; set; }
            public CreatedSoloArrangementOfReligiousSong(ImportantSongs Song) : base("Personal Wade in the Water Arrangement")
            {
                this.Song = Song;
            }
        }

        /// <summary>
        /// At the end of the service I played+sang my arrangement of "Wade in the Water" at
        /// the end of the service. This was in the choir loft, and no one but the choir
        /// really knew anything out of the ordinary had happened. This was done in preparation
        /// for a later company event.
        /// 
        /// Deanna noted that my arrangement was kind of low, an accurate observation
        /// because I had tailored it to my tenor voice.
        /// </summary>
        [YearDate(2018, 9, 23)]
        public class SemiPubliclyPerformedMyArrangementInChurch : BaseEvent
        {
            public int PerformerArranger { get; set; }
            public ImportantSongs Song { get; set; }
            public SemiPubliclyPerformedMyArrangementInChurch(int PerformerArranger, ImportantSongs Song) : base("Performed " + Song.ToString() + " after Church")
            {
                this.PerformerArranger = PerformerArranger;
                this.Song = Song;
            }
        }

        /// <summary>
        /// As far as I am concerned, Deanna's version of Canticle of the Turning
        /// is the most accurate one. This is helpful for making a personal/Z 
        /// reinterpretation less risky.
        /// </summary>
        public class ChoirSangFutureChoirDirectorArrangement : BaseEvent
        {
            private ChurchChoirDirectors Director { get; set; }
            private ImportantSongs Song { get; set; }
            public ChoirSangFutureChoirDirectorArrangement(ChurchChoirDirectors Director, ImportantSongs Song) :
                base("Choir did " + Director.ToString() + " Arrangement of " + Song.ToString())
            {
                this.Director = Director;
                this.Song = Song;
            }
        }

        /// <summary>
        /// during a couple years of Covid we didn't physically go to church anymore.
        /// When that became an option again I chose not to reengage.
        /// </summary>
        public class DoneWithChurchWithAPushFromCovid : BaseEvent
        {
            public DoneWithChurchWithAPushFromCovid() : base("Done with Church")
            {
            }
        }
    }

    public class ReligionHistory
    {
        public ReligionHistory()
        {
            MyReligiousFlags religionFlags = new MyReligiousFlags(null);
            List<BaseEvent> events = new List<BaseEvent>()
            {
                //Generic Lutheran at birth
                //1. Father was nonpracticing Catholic
                //2. Mother was raised Missouri Synod Lutheran but went to less strict denomination church when I was born. This controls.
                new PersonalBirth(religionFlags),

                //became Lutheran (ELCA) at age 4 immediately on church transition (not to Missouri Synod Lutheran church)
                new ChurchTransitionAfterMove(USCities.WisconsinEndeavor, religionFlags),

                //I was never Wisconsin Synod Lutheran despite living in Wisconsin
                new JokeThatIsNotAJokeWisconsinSynodLutheran(religionFlags, (int)ChristianDenominations.LutheranWisconsinSynod),

                //age 14 (1994) becomes primary religion and stays that way
                new BecameAnAtheist(religionFlags),

                //age 20 (2020) briefly agnostic, but remain atheist
                new BrieflyBecameAgnosticBasedOnCollegePhilosophyClass(religionFlags),

                //age 43 (Feb/Mar 2024) Began developing my own religion, though I didn't switch to it immediately.
                new StartedMyOwnReligion(religionFlags),

                //age 44 (May 27 2024) beyond religion, this changes current religion to the personal religion, and trips a beyond religion
                //flag since we're no longer talking about just the divine as the cosmic also comes into play.
                new ZDeviationMessageBoxViolatingCausality(religionFlags)
            };
            OrderedEvents orderedEvents = new OrderedEvents(null, events);
        }
    }

    /// <summary>
    /// I have connections to the main United States Lutheran denominations except for the one
    /// corresponding to my home state. This seems like something that would be a cosmic/divine
    /// joke that is not a joke. It's not funny to me.
    /// </summary>
    public class JokeThatIsNotAJokeWisconsinSynodLutheran : BaseEvent
    {
        public int LutheranDenomination { get; set; }
        public JokeThatIsNotAJokeWisconsinSynodLutheran(MyReligiousFlags religiousFlags, int LutheranDenomination) : base("Never Wisconsin Synod Lutheran")
        {
            this.LutheranDenomination = LutheranDenomination;
        }
    }


    public enum PersonalChurches
    {
        /// <summary>
        /// specific Lutheran denomination not listed on their web site, based on other web site info, not strict
        /// </summary>
        [USCities(USCities.WisconsinPoynette)]
        [UnitedStatesChristianDenomination(ChristianDenominations.Lutheran)]
        DekorraLutheranChurch = 1,

        [USCities(USCities.WisconsinOxford)]
        [UnitedStatesChristianDenomination(ChristianDenominations.LutheranMissouriSynod)]
        SaintJohnLutheranChurch = 2,

        [USCities(USCities.WisconsinWisconsinDells)]
        [UnitedStatesChristianDenomination(ChristianDenominations.LutheranELCA)]
        BethanyLutheranChurch = 3,

        [USCities(USCities.WisconsinPortage)]
        [UnitedStatesChristianDenomination(ChristianDenominations.Methodist)]
        PortageUnitedMethodistChurch = 4,

        [USCities(USCities.WisconsinMadison)]
        [UnitedStatesChristianDenomination(ChristianDenominations.Episcopal)]
        SaintDunstansEpiscopalChurch = 5,

        [USCities(USCities.WisconsinMiddleton)]
        [UnitedStatesChristianDenomination(ChristianDenominations.Catholic)]
        SaintBernardCatholicChurch = 6,
    }

    /// <summary>
    /// Adding the Lutheran denomination. This is based on parentage. My father was a non-practicing Catholic. My mother
    /// grew up Lutheran (Missouri Synod). My parents' church at the time was Dekorra Lutheran Church which I don't think
    /// was Missouri Synod, and based on contemporary info doesn't appear to be one of the main denominations, although they
    /// seem non strict as it stands today.
    /// </summary>
    [HomeAfterBirth(USCities.WisconsinHarmonyGrove)]
    [Birthdate(1980, 12, 6)]
    [BirthdatePrecise(1980, 12, 6, 12, 53)]
    [LocationInteger((int)PersonalHospitals.SaintMarysMadisonWisconsin)]
    public class PersonalBirth : ZBirth
    {
        public PersonalBirth(MyReligiousFlags religiousFlags) : base()
        {
            religiousFlags.BaseChurch = PersonalChurches.DekorraLutheranChurch;
            religiousFlags.ReligiousCapacity = EmotionalCapacity.Minimal;
            religiousFlags.CurrentReligion = religiousFlags.PrimaryReligion = (int)ChristianDenominations.Lutheran;
        }
    }

    public enum PersonalSchools
    {
        /// <summary>
        /// kindergarten
        /// </summary>
        SaintCeciliasElementarySchool,

        /// <summary>
        /// grades 1-3
        /// </summary>
        BriggsvilleElementarySchool,

        /// <summary>
        /// grades 4-6
        /// </summary>
        BigSpringElementarySchool,

        /// <summary>
        /// this school replaced Briggsville/Big Spring elementary schools. My sister
        /// went there, but I did not. The school was closed due to district 
        /// consolidation (part of this is fewer students in the rural areas)
        /// </summary>
        NeenahCreekElementarySchool,

        /// <summary>
        /// grades 7-8
        /// </summary>
        SpringHillMiddleSchool,

        /// <summary>
        /// Grades 9-12
        /// </summary>
        WisconsinDellsHighSchool,
    }

    public enum PersonalHospitals
    {
        SaintMarysMadisonWisconsin
    }

    public enum ImportantSongs
    {
        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\015-AwesomeGod.txt", PeopleEnumerated.RoweChris)]
        AwesomeGod,

        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\017-CanticleOfTheTurning.txt", PeopleEnumerated.RoweChris)]
        CanticleOfTheTurning,

        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\016-OneOfUs.txt", PeopleEnumerated.RoweChris)]
        OneOfUs,

        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\014-WadeInTheWater.txt", PeopleEnumerated.RoweChris)]
        [YouTubeVideoID("DuU7sTGspV8", 2014, 4, 6)]
        WadeInTheWater,
    }

    /// <summary>
    /// there's no specific event around this other than the previous incidents. Once I
    /// decided to be an atheist, I already was, and thus it was not a transition of
    /// significance.
    /// </summary>
    [Year(1994)]
    [ApproximateAgeInYears(14)]
    public class BecameAnAtheist : BaseEvent
    {
        public BecameAnAtheist(MyReligiousFlags religionFlags) : base("Became an Atheist")
        {
            religionFlags.CurrentReligion = religionFlags.PrimaryReligion = (int)WorldReligions.Atheism;
        }
    }

    /// <summary>
    /// started personal religion notes in LastPass therapy notes. Probably stated in February,
    /// but truly started in earnest in March.
    /// </summary>
    [DivineHumanLevel(HumanLevel.Teenager)]
    [YearMonth(2024, 2)]
    public class StartedMyOwnReligion : BaseEvent
    {
        public StartedMyOwnReligion(MyReligiousFlags religiousFlags) : base("Started Own Religion")
        {
            religiousFlags.DivineCapacity = EmotionalCapacity.Minimal;
        }
    }

    internal class PersonalReligionContrafactum1 : ContrafactumSongEvent
    {
        public ImportantSongs Song { get; set; }
        internal PersonalReligionContrafactum1(ImportantSongs Song, MyReligiousFlags religiousFlags) : base(PeopleEnumerated.RoweChris, "Awesome God", "musicnotes.com MN0041001")
        {
            this.Song = Song;
            religiousFlags.BornAgain = true;
        }
    }

    internal class PersonalReligionContrafactum2 : ContrafactumSongEvent
    {
        public ImportantSongs Song { get; set; }
        internal PersonalReligionContrafactum2(ImportantSongs Song) : base(PeopleEnumerated.RoweChris, "One of Us", "musicnotes.com MN0026701")
        {
            this.Song = Song;
        }
    }

    /// <summary>
    /// This was a discussion between two classmates in the foyer of Spring Hill Middle School, one of which was in my Sunday 
    /// School class. These two classmates were more philosophical then most. One referred to me as "He's got religion" 
    /// (I may not have the phrasing of the magic words quite right). The truth was I was closer to atheist than anything 
    /// else. Still, I did not correct them, I didn't have an issue with them incorrectly thinking that. In hindsight, 
    /// I should have said something (anything would have been better than nothing here).
    /// </summary>
    [Year(1994)]
    [MagicWords("He's got religion.", "Sunday school classmate", "My middle school", "Sunday school classmate's friend")]
    [SinType(SinType.LackOfCommunication)]
    public class HesGotReligionMagicWords : BaseEvent
    {
        public HesGotReligionMagicWords(int Source, int Target, string MyRole, int Location, MyReligiousFlags religiousFlags) : base("\"He's got religion\"")
        {
            religiousFlags.IncrementRespectful(1);
        }
    }

    /// <summary>
    /// I had a discussion with Pastor Kreuger before confirmation. I knew full well I wasn't going to have anything to do
    /// with the church in the long term and wanted to make sure nothing was expected of him. The answer to my question was
    /// no, nothing was expected of me. The discussion was awkward (I'm not sure he or I truly understood
    /// my concern. As it seemed like it didn't matter, I got confirmed.
    ///  
    /// As it turns out, ELCA Lutheran is quite tolerant of skepticism, and I did not understand
    /// that fact at the time. In my ignorance I thought the rules were stricter than they actually are.
    /// This is evidence I never really paid attention to any of the Sunday school lessons.
    /// 
    /// I will never know whether going through with the confirmation was actually a mistake.
    /// I may have made a better decision (yes or no) if I had been more knowledgeable.
    /// </summary>
    [Year(1994)]
    [SinType(SinType.Ignorance)]
    public class ELCALutheranConfirmationDespiteNearAtheism : BaseEvent
    {
        public ELCALutheranConfirmationDespiteNearAtheism() : base("Near-atheism ELCA Lutheran Confirmation")
        {
        }
    }

    /// <summary>
    /// This was almost certainly inspired by a Simpson's episode where Bart writes his soul
    /// on a piece of paper, and students act maliciously, until Bart gets it back and rips it up and eats
    /// it to save his soul. I wanted to go further, and did the same thing on a piece of paper in
    /// 11th grade AP US History Class. It was passed out a bit and ended up in Greg Wisniewski's
    /// hands. The Wisniewskis (Greg [1 year younger than I] and Katie [1 year older than I] were
    /// highly intelligent and religious. Greg Wisniewski was a significant goofball though
    /// so I really don't know what happened to it. My soul could be anywhere. It remained
    /// a joke for many years afterward but is a bit unsettling now.
    /// </summary>
    [Year(1997)]
    [SinType(SinType.DisrespectOfReligion)]
    public class GaveMySoulToAClassmateAndIDontKnowWhatHappenedToIt : BaseEvent
    {
        public GaveMySoulToAClassmateAndIDontKnowWhatHappenedToIt() : base("Put my Soul on Piece of Paper, Left with Classmate")
        {

        }
    }

    /// <summary>
    /// Sophomore in High School: Math class (FST). I claimed to be the Antichrist to the class.
    /// This was a joke. Brian Wimann referred to me as Satan for a time. During one class
    /// I stood in front of the classroom and called the clas "my people". Melissa Hamburg objected
    /// so I told her she was excluded. It didn't take too long for the joke to get old. It remained
    /// a joke for many years afterwork but is a bit unsettling now.
    /// </summary>
    [Year(1998)]
    [SinType(SinType.DisrespectOfReligion)]
    public class SemipubliclyClaimToBeTheAntichristAsAJoke : BaseEvent
    {
        public SemipubliclyClaimToBeTheAntichristAsAJoke() : base("Publicly Claim to be the Antichrist as a Joke")
        {

        }
    }

    /// <summary>
    /// I do not remember ever giving up something tangible for Lent (it wasn't emphasized in ELCA Lutheran upbringing,
    /// but I know my Catholic relatives did). As an adult I came up with the running gag of giving up "giving things
    /// up for Lent" for Lent. I'm not sure if I'm being disrespectful of religion or not. Tt's just an absurd way of
    /// saying I don't participate in that part of the religion, but I'm also not a practicing Christian. On the other
    /// hand I'm not really broadcasting that to the world, so maybe it doesn't actually matter. But it's still a joke,
    /// and has remained so even as my understanding of disrespect for religion has increased.
    /// </summary>
    public class GivingUpGivingUpSomethingForLentForLent : BaseEvent
    {
        public GivingUpGivingUpSomethingForLentForLent(MyReligiousFlags myReligiousFlags) : base("Joke Giving Up Nothing for Lent")
        {
            myReligiousFlags.IncrementDisrespectful(1);
        }
    }
}
