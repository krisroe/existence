using Existence.Beyond.Infrastructure;
using Existence.Earth.Human.People;
using Existence.Earth;
using Existence.Earth.Alphabet;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.FieldsOfStudy.Psychology;
using Existence.Personal.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using Existence.Time;
using Existence.Personal;
using static Existence.Beyond.JudgmentDay.HumanDivineGrowingUpToTeenager;

namespace Existence.Beyond.JudgmentDay
{
    internal class BirthToGrowingUp : JudgmentDayBase
    {
        private enum VersionHistory
        {
            /// <summary>
            /// created. This covers the timeline from birth to growing up with respect to
            /// human, divine, and cosmic scales.
            /// </summary>
            [PersonalFirst("Judgment Day")]
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 3, 7)]
            Created,

            /// <summary>
            /// updated orion is a-rising meaning to add overpopulation
            /// </summary>
            [BeyondObjectVersion(1, 1, 0, 0)]
            [YearDate(2025, 3, 7)]
            OrionIsARisingUpdate,

            /// <summary>
            /// song meaning files moved to musicnotes repositories and incorporated by reference
            /// instead of storing in both text files and the judgment day document.
            /// </summary>
            [BeyondObjectVersion(1, 2, 0, 0)]
            [YearDate(2025, 3, 7)]
            MoveSongMeaningFilesToMusicNotesRepository,

            /// <summary>
            /// shifted song meaning files to no longer be in a judgment day specific folder
            /// class name changes to avoid namespace conflicts
            /// </summary>
            [BeyondObjectVersion(1, 3, 0, 0)]
            [YearDate(2025, 3, 7)]
            ReferenceShiftForMusicMeaningFilesInMusicNotesRepository,

            /// <summary>
            /// moved enums to next judgment day, renamed family members enums to be more precise
            /// </summary>
            [BeyondObjectVersion(1, 4, 0, 0)]
            [YearDate(2025, 3, 8)]
            MovePetDogsAndFamilyMemberEnums,

            /// <summary>
            /// audio files now in audio folder since they might be released in contexts other than judgment day
            /// </summary>
            [BeyondObjectVersion(1, 4, 0, 0)]
            [YearDate(2025, 3, 9)]
            MoveAudioFilesOutOfJudgmentDayFolder,

            /// <summary>
            /// move hearsay attribute to common so it's more easily used from other contexts
            /// </summary>
            [BeyondObjectVersion(1, 5, 0, 0)]
            [YearDate(2025, 3, 10)]
            MoveHearsayAttributeToCommonInfrastructure,

            /// <summary>
            /// add justifications (pull songs to member vars so they are usable as justifications
            /// make it more clear the firsts are personal
            /// </summary>
            [BeyondObjectVersion(1, 6, 0, 0)]
            [YearDate(2025, 3, 10)]
            AddJustifications,

            /// <summary>
            /// add my sister's reversing parody of the National SID Foundation
            /// </summary>
            [BeyondObjectVersion(1, 7, 0, 0)]
            [YearDate(2025, 3, 14)]
            AddSistersParodyOfMyFirstOriginalSong,

            [BeyondObjectVersion(1, 8, 0, 0)]
            [YearDate(2025, 3, 24)]
            EarlyMemoriesUpdateAndAddDateForMoveToEndeavorHome,

            [BeyondObjectVersion(1, 9, 0, 0)]
            [YearDate(2025, 3, 24)]
            InternalizedAndRemovedTimelessVersion,

            [BeyondObjectVersion(1, 10, 0, 0)]
            [YearDate(2025, 3, 26)]
            MoveChainEventFunctionToCommon,

            [BeyondObjectVersion(1, 11, 0, 0)]
            [YearDate(2025, 3, 27)]
            MakeChainedEventsWorkBetterAndClarifySomeoneCalledMeAGeniusAndClarifyOriginalSongs,

            [BeyondObjectVersion(1, 12, 0, 0)]
            [YearDate(2025, 3, 28)]
            AddDivineChildhoodIncidentRemoveMissingInformationImplementation,

            [BeyondObjectVersion(1, 13, 0, 0)]
            [YearDate(2025, 3, 29)]
            MakeBirthAndDivineSkepticismMorePublicMoveMultiEventIntoInfrastructure,

            [BeyondObjectVersion(1, 14, 0, 0)]
            [YearDate(2025, 3, 30)]
            MovePersonalBirthOut,

            [BeyondObjectVersion(1, 15, 0, 0)]
            [YearDate(2025, 3, 30)]
            AddReligiousFlagsChildhoodNativityPlaysILikeToFartPlayMoveCapacityForReligiousOut,

            [BeyondObjectVersion(1, 16, 0, 0)]
            [YearDate(2025, 3, 31)]
            UpdatedLocationForSomeoneCalledMeAGenius,

            [BeyondObjectVersion(1, 17, 0, 0)]
            [YearDate(2025, 4, 2)]
            UpdatedHumanDivineTeenagerClass,
        }

        public PersonalFirstOriginalSong MyFirstOriginalSong;
        public SistersParodyOfMyFirstOriginalSong MySistersParodyOfMyFirstOriginalSong;
        public PersonalFirstParodySong MyFirstParodySong;
        public SweetlySingsTheDonkeyAtTheBreakOfDay SweetlySingsTheDonkeyInterpretation;
        public OrionIsarising OrionisaRisingHumanInterpretation;
        public SomeoneCalledMeAGenius ClassmateCalledMeAGenius;

        public BirthToGrowingUp()
        {
            MyReligiousFlags myReligiousFlags = new MyReligiousFlags(Skepticism: null);
            BaseEvent startedPianoLessons = new BaseEvent("StartedPianoLessons");
            BaseEvent childishNativityPlays = new ChildhoodNativityPlayDisrespect1(myReligiousFlags);
            BaseEvent childishNativityScenes = new ChildhoodNativityPlayDisrespect2(myReligiousFlags);
            BaseEvent skepticismOfReligion = new SkepticismOfReligionPersonal(myReligiousFlags);
            MyFirstOriginalSong = new PersonalFirstOriginalSong();
            MySistersParodyOfMyFirstOriginalSong = new SistersParodyOfMyFirstOriginalSong(MyFirstOriginalSong);
            MyFirstParodySong = new PersonalFirstParodySong();
            SweetlySingsTheDonkeyInterpretation = new SweetlySingsTheDonkeyAtTheBreakOfDay();
            OrionisaRisingHumanInterpretation = new OrionIsarising();
            ClassmateCalledMeAGenius = new SomeoneCalledMeAGenius(
                Z.MAGIC_WORDS_HES_A_GENIUS,
                (int)FirstGradeClassAttendanceListAlphabetical.Laura, 
                (int)FamilyMembers.MyMothersBrotherGerald,
                (int)PersonalChurches.SaintJohnLutheranChurch);
            BaseEvent birth = new PersonalBirth();
            BaseEvent establishedFavoriteNumbers = new EstablishedFavoriteNumbers();

            OrderedEvents factListOrdered = new OrderedEvents(birth, new List<BaseEvent>()
            {
                new SelfShortFirstName(),
                new SelfFullFirstName(),
                new SisterFirstName(),
                new CapacityForTheReligious(),
                new FirstMemoryEvent("touching the bark of the birch trees outside home"),
                new MovedToSecondSignificantHome(PlaceType.Home, USCities.WisconsinEndeavor, string.Empty),
                new EarlyHomeMemory("warming myself in the morning by the radiator"),
                new AnnotatedPlaceEvent3(PlaceType.Church, USCities.WisconsinWisconsinDells, "ELCA Lutheran"),
                new PlaceInSpecificCity(PlaceType.School, USCities.WisconsinWisconsinDells, "Kindergarden"),
                new PlaceInSpecificCity(PlaceType.School, USCities.WisconsinBriggsville, "Grades 1-3"),
                new SchoolClassList("1st Grade", typeof(FirstGradeClassAttendanceListAlphabetical)),
                new SchoolClassList("3rd Grade", typeof(ThirdGradePartialClassList)),
                new OpinionOfCamping("I dislike it.", Emotions.Hatred)
            });
            OrderedEvents orderedEvents = new OrderedEvents(null, new List<BaseEvent>()
            {
                new BaseEvent("Fact(Concept)"),
                new BaseEvent("ActionsHaveConsequences"),
                birth,
                new MultiEvent("EarlyChildhoodFacts", factListOrdered.GetEventsAsArray()),
                new MultiEvent("Early Childhood", [establishedFavoriteNumbers, new BittenByAPetDog((int)PetDogs.Abe)]),
                new MultiEvent("Age 6-7ish", [startedPianoLessons, new BaseEvent("StartedUsingComputers"), new ILikeToFartHandPuppetPlay(), childishNativityPlays]),
                new MultiEvent("Age 8ish", [new ContemplatedEventuallyIWillDie(), new LifesNotFair()]),
                new MultiEvent("Age 9ish", [new SelfAwarenessOfAdultLevelOfAnalyticalThinking(), OrionisaRisingHumanInterpretation, childishNativityScenes]),
                skepticismOfReligion
            });
            OrderedEvents relevantSongs = new OrderedEvents(startedPianoLessons, new List<BaseEvent>()
            {
                SweetlySingsTheDonkeyInterpretation,
                MyFirstParodySong,
                MyFirstOriginalSong,
                MySistersParodyOfMyFirstOriginalSong
            });
            OrderedEvents calledAGeniusOrder = new OrderedEvents(establishedFavoriteNumbers, new List<BaseEvent>()
            {
                ClassmateCalledMeAGenius
            });

            List<BaseEvent> terminalEvents = new List<BaseEvent>()
            {
                MySistersParodyOfMyFirstOriginalSong,
                ClassmateCalledMeAGenius,
                skepticismOfReligion,
            };

            AnnotatedTerminalEvent terminalEvent = new AnnotatedTerminalEvent("Growing Up", terminalEvents.ToArray());
        }

        internal override List<LevelJustification> GetLevelJustifications()
        {
            return new List<LevelJustification>()
            {
                new ReleaseSongJustification(MyFirstParodySong, SongJustificationType.ReleaseSong),
                new ReleaseSongJustification(MyFirstOriginalSong, SongJustificationType.ReleaseSong),
                new ReleaseSongJustification(SweetlySingsTheDonkeyInterpretation, SongJustificationType.InterpretSongMeaning),
                new ReleaseSongJustification(OrionisaRisingHumanInterpretation, SongJustificationType.InterpretSongMeaning),
            };
        }

        internal override List<CosmicCharity> GetCosmicCharity()
        {
            return new List<CosmicCharity>()
            {
                new CosmicCharity(1, (int)FamilyMembers.MySisterSonya, "Insulting Song #1"),
                new CosmicCharity(1, (int)FamilyMembers.MySisterSonya, "Insulting Song #2"),
                new CosmicCharity(1, (int)FamilyMembers.MySisterSonya, "Her Name is Exposed"),
                new CosmicCharity(1, (int)FirstGradeClassAttendanceListAlphabetical.Laura, "Never Acknowledged Compliment, Potential Soulmate"),
            };
        }

        [PersonalHumanLevel(HumanLevel.GrowingUp)]
        [DivineHumanLevel(HumanLevel.GrowingUp)]
        [CosmicHumanLevel(HumanLevel.GrowingUp)]
        [ZHumanLevel(HumanLevel.Childhood)]
        public class AnnotatedTerminalEvent : TerminalEvent
        {
            public AnnotatedTerminalEvent(string EventName, params BaseEvent[] PreviousEvents) : base(EventName, PreviousEvents)
            {
            }
        }

        /// <summary>
        /// literally means "one who carries/bears Christ"
        /// </summary>
        [FirstName("Christopher")]
        public class SelfFullFirstName : BaseEvent
        {
            public SelfFullFirstName() : base("Self Full First Name") { }
        }

        [FirstName("Chris")]
        public class SelfShortFirstName : BaseEvent
        {
            public SelfShortFirstName() : base("Self Short First Name") { }
        }

        [FirstName("Sonya")]
        public class SisterFirstName : BaseEvent
        {
            public SisterFirstName() : base("Sister First Name") { }
        }

        [PersonalFirst("Memory")]
        [PersonalHumanLevel(HumanLevel.Childhood)]
        public class FirstMemoryEvent : BaseEvent
        {
            public string Description { get; set; }
            public FirstMemoryEvent(string Description) : base("First Memory")
            {
                this.Description = Description;
            }
        }

        public class HomeAfterBirthAttribute : Attribute
        {
            public USCities City { get; set; }
            public HomeAfterBirthAttribute(USCities City)
            {
                this.City = City;
            }
        }

        public class AnnotatedPlaceEvent1 : PlaceInSpecificCity
        {
            public AnnotatedPlaceEvent1(PlaceType PlaceType, USCities City, string Detail) : base(PlaceType, City, Detail) { }
        }

        /// <summary>
        /// per my father we briefly lived with my mother's parents first for a small number of months
        /// </summary>
        [YearDate(1985, 8, 17)] //this is a significant date for my father as it was his father's birthday
        public class MovedToSecondSignificantHome : PlaceInSpecificCity
        {
            public MovedToSecondSignificantHome(PlaceType PlaceType, USCities City, string Detail) : base(PlaceType, City, Detail) { }
        }

        public class EarlyHomeMemory : BaseEvent
        {
            public string Description { get; set; }
            public EarlyHomeMemory(string Description) : base("Early Home Memory")
            {
                this.Description = Description;
            }
        }

        /// <summary>
        /// If an incident is required for stepping into the divine child threshold, there is one 
        /// possibility that I do not remember beyond being told the story. After moving to Endeavor, 
        /// we first tried my grandparents' church (Missouri Synod Lutheran). My mother wanted to sit 
        /// in with the Sunday school but this was not allowed, and motivated by this my mother switched 
        /// to Bethany Lutheran Church in Wisconsin Dells, where she was a Sunday school teacher for 
        /// the youngest level for several years.
        /// </summary>
        [DivineHumanLevel(HumanLevel.Childhood)]
        public class AnnotatedPlaceEvent3 : PlaceInSpecificCity
        {
            public AnnotatedPlaceEvent3(PlaceType PlaceType, USCities City, string Detail) : base(PlaceType, City, Detail) { }
        }

        public class PlaceInSpecificCity : BaseEvent
        {
            public PlaceType PlaceType { get; set; }
            public USCities City { get; set; }
            public string Detail { get; set; }
            public PlaceInSpecificCity(PlaceType PlaceType, USCities City, string Detail) :
                base(PlaceType.ToString() + "=" + City.ToString() + (string.IsNullOrEmpty(Detail) ? string.Empty : " " + Detail))
            {
                this.PlaceType = PlaceType;
                this.City = City;
                this.Detail = Detail;
            }
        }

        public class SchoolClassList : BaseEvent
        {
            public Type AttendanceType { get; set; }
            public SchoolClassList(string Class, Type AttendanceType) : base(Class)
            {
                this.AttendanceType = AttendanceType;
            }
        }

        /// <summary>
        /// I used a repetitive chant mnemonic to remember this list.
        /// This may be incomplete/inaccurate due to the passage of time.
        /// </summary>
        [Emotions("Disappointed that 2nd grade didn't use an alphabetized list", Emotions.Disappointment)]
        public enum FirstGradeClassAttendanceListAlphabetical
        {
            Abby,
            Alisa,
            Christopher,
            Daniel,
            Greg,
            Jesse,
            Judy,
            Kim,
            /// <summary>
            /// less than average intelligence
            /// </summary>
            Laura,
            Luke,
            /// <summary>
            /// significantly less than average intelligence
            /// </summary>
            Mato,
            Matthew,
            Rochelle,
            Ryan,
            /// <summary>
            /// possibly confabulated
            /// </summary>
            Tameka,
        }

        public enum ThirdGradePartialClassList
        {
            /// <summary>
            /// lowest intelligence in the class
            /// </summary>
            Tameka,
        }

        [CosmicZLevel(ZLevel.One)]
        [CosmicHumanLevel(HumanLevel.Childhood)]
        public class EstablishedFavoriteNumbers : BaseEvent
        {
            public EstablishedFavoriteNumbers() : base("Established Favorite Numbers") { }
        }

        [PersonalFirst("Parody Song")]
        [ZHumanLevel(HumanLevel.Childhood)]
        [MusicNotesRepositoryAudioFile(@"Released\Audio\001-SonyasDumb.wav", PeopleEnumerated.RoweChris)]
        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\001-SonyasDumb.txt", PeopleEnumerated.RoweChris)]
        public class PersonalFirstParodySong : ParodySongEvent
        {
            public PersonalFirstParodySong() : base(PeopleEnumerated.RoweChris, "Sonya's Dumb", "Rain, Rain, Go Away")
            {
            }
        }

        [PersonalFirst("Original Song")]
        [MusicNotesRepositoryAudioFile(@"Released\Audio\002-TheNationalSIDFoundation.wav", PeopleEnumerated.RoweChris)]
        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\002-TheNationalSIDFoundation.txt", PeopleEnumerated.RoweChris)]
        public class PersonalFirstOriginalSong : OriginalSongEvent
        {
            public PersonalFirstOriginalSong() : base("The National SID Foundation")
            {

            }
        }

        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\002-TheNationalSIDFoundation.txt", PeopleEnumerated.RoweChris)]
        public class SistersParodyOfMyFirstOriginalSong : ParodySongEvent
        {
            public SistersParodyOfMyFirstOriginalSong(OriginalSongEvent Parodied) : base(PeopleEnumerated.RoweSonya, "The National CRID Foundation", Parodied.EventName)
            {
            }
        }

        [Text("Sung as a round many times in the car with my mother and my sister")]
        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\003-SweetlySingsTheDonkeyAtTheBreakOfDay.txt", PeopleEnumerated.RoweChris)]
        public class SweetlySingsTheDonkeyAtTheBreakOfDay : SongEvent
        {
            public SweetlySingsTheDonkeyAtTheBreakOfDay() : base("Sweetly Sings the Donkey at the Break of Day")
            {
            }
        }

        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\004-OrionisaRisingHuman.txt", PeopleEnumerated.RoweChris)]
        public class OrionIsarising : SongEvent
        {
            public OrionIsarising() : base("Orion is a-rising") { }
        }

        public class OpinionOfCamping : BaseEvent
        {
            public string Opinion { get; set; }
            public Emotions Emotion { get; set; }
            public OpinionOfCamping(string Opinion, Emotions Emotion) : base(Opinion)
            {
                this.Opinion = Opinion;
                this.Emotion = Emotion;
            }
        }

        /// <summary>
        /// my recollection is I was in the kitchen/dining-room of the Endeavor house
        /// </summary>
        public class ContemplatedEventuallyIWillDie : BaseEvent
        {
            public ContemplatedEventuallyIWillDie() : base("Eventually I will Die") { }

            public int DeferredToAge
            {
                get
                {
                    return 16;
                }
            }

            public string Consequences
            {
                get
                {
                    return "This increased the magnitude of a future mid-life crisis, but not to an earth shattering level";
                }
            }
        }

        /// <summary>
        /// I thought it was unfair that when the second graders played the third graders in touch football,
        /// the third graders always won. The school guidance counselor got involved. Once the lesson was
        /// learned, went back to playing football as usual.
        /// </summary>
        [PersonalHumanLevel(HumanLevel.GrowingUp)]
        [PersonalZLevel(ZLevel.One)]
        public class LifesNotFair : BaseEvent
        {
            public LifesNotFair() : base("Life's Not Fair") { }

            public string Consequences
            {
                get
                {
                    return "This ripped a hole in my soul, that's why it bumped the Z level up.";
                }
            }
        }

        /// <summary>
        /// took a standardized test in 3rd grade, receiving "post high school" pretty much across the board
        /// </summary>
        [CosmicHumanLevel(HumanLevel.GrowingUp)]
        public class SelfAwarenessOfAdultLevelOfAnalyticalThinking : BaseEvent
        {
            public SelfAwarenessOfAdultLevelOfAnalyticalThinking() : base("Post High School")
            {
            }
            public string Consequences
            {
                get
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Chose to focus on developing analytical thinking skills, and minimally develop people skills");
                    sb.AppendLine("This was not recognized as a mistake until much later.");
                    return sb.ToString();
                }
            }
        }

        /// <summary>
        /// I'm pretty sure this happened at my mother's mother's church, it's the only
        /// thing that makes sense.
        /// </summary>
        public class SomeoneCalledMeAGenius : SomeoneSaidSomethingAndIFoundOutViaHearsay
        {
            public SomeoneCalledMeAGenius(string WhatWasSaid, int PersonWhoSaidIt, int PersonWhoToldMe, int Location) : base(WhatWasSaid, PersonWhoSaidIt, PersonWhoToldMe, Location)
            {
            }

            public string Reaction
            {
                get
                {
                    return "I never acknowledged this in any way.";
                }
            }

            public string Consequences
            {
                get
                {
                    return "I lost an opportunity for a potential friend.";
                }
            }
        }

        public class BittenByAPetDog : BaseEvent
        {
            public int Dog { get; set; }
            public BittenByAPetDog(int Dog) : base("Bitten by a Pet Dog")
            {
                this.Dog = Dog;
            }
            public string Consequences
            {
                get
                {
                    return "My injury was not severe. The (elderly) dog became an outside dog.";
                }
            }
        }
    }

    /// <summary>
    /// My mother had us do puppet based nativity Christmas pageants. When they started I took them
    /// seriously, but this went downhill from respectful and disrespectful over the course of the
    /// years until they were stopped.
    /// </summary>
    [ApproximateAgeInYears(8, 10)]
    [Emotions("Childish Nativity Plays", Emotions.Disrespect)]
    public class ChildhoodNativityPlayDisrespect1 : BaseEvent
    {
        public ChildhoodNativityPlayDisrespect1(MyReligiousFlags flags) : base("Childish Nativity Plays")
        {
            flags.Respectful--;
        }
    }

    /// <summary>
    /// we had a nativity diorama growing up. I would place the pieces in obviously incorrect
    /// places. A clear example would be putting a lamb in place of baby Jesus and putting the
    /// manger upside down in the corner or inside a feed trough.
    /// </summary>
    [ApproximateAgeInYears(10, 16)]
    [Emotions("Childish Nativity Scenes", Emotions.Disrespect)]
    public class ChildhoodNativityPlayDisrespect2 : BaseEvent
    {
        public ChildhoodNativityPlayDisrespect2(MyReligiousFlags flags) : base("Childish Nativity Scenes")
        {
            flags.Respectful--;
        }
    }

    /// <summary>
    /// Hand puppet play with the main character as a pig. The headline catch phrase is "I like to fart!" and when 
    /// confronted this is inappropriate doubles down defending the behavior with "But I like to do it in public!".
    /// </summary>
    public class ILikeToFartHandPuppetPlay : BaseEvent
    {
        public ILikeToFartHandPuppetPlay() : base("\"I Like to Fart\" Hand Puppet Play")
        {
        }
    }

    /// <summary>
    /// I was curious as to what would happen, and at the time concluded that nothing did happen.
    /// </summary>
    [ApproximateAgeInYears(10)]
    [DivineHumanLevel(HumanLevel.GrowingUp)]
    [Quotes("I have no sin.", "Me", "My Bedroom", "Alone")]
    [BiblePassage("1 John 1:8-9")]
    public class SkepticismOfReligionPersonal : BaseEvent
    {
        public SkepticismOfReligionPersonal(MyReligiousFlags myFlags) : base("Skepticism of Religion")
        {
            myFlags.Respectful++;
            myFlags.Skepticism = true;
        }

        /// <summary>
        /// part of the Confession and Forgiveness section at the beginning of the service.
        /// </summary>
        public string BiblePassage
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("If we say we have no sin, we deceive ourselves, and the truth is not in us.");
                sb.AppendLine("But if we confess our sins, God, who is faithful and just,");
                sb.AppendLine("will forgive our sins and cleanse us from all unrighteousness.");
                return sb.ToString();
            }
        }
        /// <summary>
        /// I have never seriously thought there were any consequences of this
        /// </summary>
        public string? Consequences
        {
            get
            {
                return null;
            }
        }
    }

    [CapacityForEmotion(Emotions.Religious, EmotionalCapacity.Minimal)]
    public class CapacityForTheReligious : BaseEvent
    {
        public CapacityForTheReligious() : base("Starting Religious Feeling")
        {
        }
    }
}
