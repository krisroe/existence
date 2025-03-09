using Existence.Beyond.Infrastructure;
using Existence.Beyond.JudgmentDay;
using Existence.Earth.Human.People;
using Existence.Earth;
using Existence.Earth.Time;
using Existence.Earth.Alphabet;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.FieldsOfStudy.Psychology;
using Existence.Logic.Random;
using Existence.Personal.Infrastructure;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Existence.Time;
using Existence.Personal;

namespace Existence.Beyond.JudgmentDay
{
    public class BirthToGrowingUp : JudgmentDayBase
    {
        private enum VersionHistory
        {
            /// <summary>
            /// created. This covers the timeline from birth to growing up with respect to
            /// human, divine, and cosmic scales.
            /// </summary>
            [PersonalFirst("Judgment Day")]
            [BeyondObjectVersion(1, 0, 0, 0)]
            [TimelessVersion(1, 0, 0, 0)]
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
        }

        public BirthToGrowingUp()
        {
            BaseEvent startedPianoLessons = new BaseEvent("StartedPianoLessons");
            BaseEvent skepticismOfReligion = new SkepticismOfReligion();
            BaseEvent firstOriginalSong = new FirstOriginalSong();
            BaseEvent birth = new Birth();
            BaseEvent establishedFavoriteNumbers = new EstablishedFavoriteNumbers();

            List<BaseEvent> factListOrdered = new List<BaseEvent>()
            {
                new SelfShortFirstName(),
                new SelfFullFirstName(),
                new SisterFirstName(),
                new CapacityForTheReligious(),
                new AnnotatedPlaceEvent1(PlaceType.Home, USCities.WisconsinHarmonyGrove, string.Empty),
                new AnnotatedPlaceEvent2(PlaceType.Home, USCities.WisconsinEndeavor, string.Empty),
                new AnnotatedPlaceEvent3(PlaceType.Church, USCities.WisconsinWisconsinDells, "ELCA Lutheran"),
                new PlaceInSpecificCity(PlaceType.School, USCities.WisconsinWisconsinDells, "Kindergarden"),
                new PlaceInSpecificCity(PlaceType.School, USCities.WisconsinBriggsville, "Grades 1-3"),
                new SchoolClassList("1st Grade", typeof(FirstGradeClassAttendanceListAlphabetical)),
                new SchoolClassList("3rd Grade", typeof(ThirdGradePartialClassList)),
                new OpinionOfCamping("I dislike it.", Emotions.Hatred)
            };
            List<BaseEvent> chainedEvents = new List<BaseEvent>()
            {
                new BaseEvent("Fact(Concept)"),
                new BaseEvent("ActionsHaveConsequences"),
                birth,
                new MultiEvent("EarlyChildhoodFacts", factListOrdered.ToArray()),
                new MultiEvent("Early Childhood", [establishedFavoriteNumbers, new BittenByAPetDog((int)PetDogs.Abe)]),
                new MultiEvent("Age 6-7ish", [startedPianoLessons, new BaseEvent("StartedUsingComputers")]),
                new MultiEvent("Age 8ish", [new ContemplatedEventuallyIWillDie(), new LifesNotFair()]),
                new MultiEvent("Age 9ish", [new SelfAwarenessOfAdultLevelOfAnalyticalThinking(), new OrionIsarising()]),
                skepticismOfReligion
            };
            List<BaseEvent> personalSongs = new List<BaseEvent>()
            {
                new SweetlySingsTheDonkeyAtTheBreakOfDay(),
                new FirstParodySong(),
                firstOriginalSong
            };
            ChainEvents(chainedEvents, null);
            ChainEvents(personalSongs, startedPianoLessons);
            ChainEvents(factListOrdered, birth);

            SomeoneSaidSomethingAndIFoundOutViaHearsay calledAGenius = new SomeoneSaidSomethingAndIFoundOutViaHearsay(
                "He's a genius", (int)FirstGradeClassAttendanceListAlphabetical.Laura, (int)FamilyMembers.MyMothersBrotherGerald);
            calledAGenius.PreviousEvent = establishedFavoriteNumbers;

            List<BaseEvent> terminalEvents = new List<BaseEvent>()
            {
                skepticismOfReligion,
                firstOriginalSong,
            };

            AnnotatedTerminalEvent terminalEvent = new AnnotatedTerminalEvent("Growing Up", terminalEvents.ToArray());
        }

        public override int GetLevel()
        {
            return 4;
        }

        public override List<CosmicCharity> GetCosmicCharity()
        {
            return new List<CosmicCharity>()
            {
                new CosmicCharity(1, (int)FamilyMembers.MySisterSonya, "Insulting Song #1"),
                new CosmicCharity(1, (int)FamilyMembers.MySisterSonya, "Insulting Song #2"),
                new CosmicCharity(1, (int)FamilyMembers.MySisterSonya, "Her Name is Exposed"),
                new CosmicCharity(1, (int)FirstGradeClassAttendanceListAlphabetical.Laura, "Never Acknowledged Compliment, Potential Soulmate"),
            };
        }

        private static void ChainEvents(List<BaseEvent> events, BaseEvent? previousEvent)
        {
            for (int i = 0; i < events.Count; i++)
            {
                events[i].PreviousEvent = i == 0 ? previousEvent : events[i - 1];
            }
        }

        public class MultiEvent : BaseEvent
        {
            public IList<BaseEvent> Events;
            public MultiEvent(string EventName, BaseEvent[] Events) : base(EventName)
            {
                List<BaseEvent> baseEvents = new List<BaseEvent>(Events);
                RandomLogic.RandomType randomValue = (RandomLogic.RandomType)RandomNumberGenerator.GetInt32(0, 4);
                RandomLogic.LinqHandling linqHandling = (RandomLogic.LinqHandling)RandomNumberGenerator.GetInt32(0, 3);
                this.Events = RandomLogic.DoFisherYatesKnuthRandomizer(baseEvents, null, randomValue, linqHandling);
            }
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

        [PersonalHumanLevel(HumanLevel.Baby)]
        [DivineHumanLevel(HumanLevel.Baby)]
        [CosmicHumanLevel(HumanLevel.Baby)]
        [ZHumanLevel(HumanLevel.Baby)]
        [PersonalZLevel(ZLevel.Zero)]
        [CosmicZLevel(ZLevel.Zero)]
        public class Birth : BaseEvent
        {
            public Birth() : base("Birth") { }
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
        [SignificantMemory("touching the bark of the birch trees outside")]
        [PersonalHumanLevel(HumanLevel.Childhood)]
        [USCity(USCities.WisconsinHarmonyGrove)]
        public class AnnotatedPlaceEvent1 : PlaceInSpecificCity
        {
            public AnnotatedPlaceEvent1(PlaceType PlaceType, USCities City, string Detail) : base(PlaceType, City, Detail) { }
        }

        [USCity(USCities.WisconsinEndeavor)]
        [SignificantMemory("early memory of warming myself in the morning by the radiator")]
        public class AnnotatedPlaceEvent2 : PlaceInSpecificCity
        {
            public AnnotatedPlaceEvent2(PlaceType PlaceType, USCities City, string Detail) : base(PlaceType, City, Detail) { }
        }

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

        [CapacityForEmotion(Emotions.Religious, EmotionalCapacity.Minimal)]
        public class CapacityForTheReligious : BaseEvent
        {
            public CapacityForTheReligious() : base("Starting Religious Feeling")
            {
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
        [MusicNotesRepositoryAudioFile(@"Released\JudgmentDay\Audio\SonyasDumb.wav", PeopleEnumerated.RoweChris)]
        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\001-SonyasDumb.txt", PeopleEnumerated.RoweChris)]
        public class FirstParodySong : ParodySongEvent
        {
            public FirstParodySong() : base("Sonya's Dumb", "Rain, Rain, Go Away")
            {
            }
        }

        [PersonalFirst("Original Song")]
        [MusicNotesRepositoryAudioFile(@"Released\JudgmentDay\Audio\2-TheNationalSIDFoundation.wav", PeopleEnumerated.RoweChris)]
        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\002-TheNationalSIDFoundation.txt", PeopleEnumerated.RoweChris)]
        public class FirstOriginalSong : SongEvent
        {
            public FirstOriginalSong() : base("The National SID Foundation")
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

        public class SomeoneCalledMeAGenius : SomeoneSaidSomethingAndIFoundOutViaHearsay
        {
            public SomeoneCalledMeAGenius(string WhatWasSaid, int PersonWhoSaidIt, int PersonWhoToldMe) : base(WhatWasSaid, PersonWhoSaidIt, PersonWhoToldMe)
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

        /// <summary>
        /// I was curious as to what would happen, and at the time concluded that nothing did happen.
        /// </summary>
        [ApproximateAge(10, TimePeriods.Years)]
        [DivineHumanLevel(HumanLevel.GrowingUp)]
        [Quote("I have no sin.", "Me", "My Bedroom", "Alone")]
        [BiblePassage("1 John 1:8-9")]
        public class SkepticismOfReligion : BaseEvent
        {
            public SkepticismOfReligion() : base("Skepticism of Religion") { }

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
    }
}
