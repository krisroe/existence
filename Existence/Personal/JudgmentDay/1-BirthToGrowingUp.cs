using Existence.Earth.Human.People;
using Existence.Earth;
using Existence.Earth.Code;
using Existence.Earth.Time;
using Existence.Earth.Alphabet;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.FieldsOfStudy.Psychology;
using Existence.JudgmentDay;
using Existence.Logic.Random;
using Existence.Logic;
using Existence.Time;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace Existence.Personal.JudgmentDay
{
    public class Timeless
    {
        [Archetypes(Archetypes.Programmer)]
        [FavoriteColor(KnownColor.Transparent)]
        [HumanGender(HumanGender.Male)]
        [HumanSex(HumanSex.Male)]
        [FavoriteNumber(24865)]
        [SecondFavoriteNumber(4)]
        public class Self
        {
            [SourceCodeRepositoryUser(CloudRepositoryGitProvider.GitHub, "krisroe")]
            public static class Repositories
            {
                [RepositoryName("existence")]
                public static class Existence { }

                [RepositoryName("musicnotes")]
                public static class Music { }
            }
        }

        [LastName("Rowe")]
        public static class NuclearFamilyUnit
        {
            public class v1
            {
                [Birthdate(1952, 2, 18)]
                public class Mother
                {
                    public static class SiblingsByAgeDescending
                    {
                        public static class Mother { }
                        public static class Sister1 { }
                        public static class Brother { }
                        public static class Sister2 { }
                    }
                }

                [FavoriteColor(KnownColor.Green)]
                [Birthdate(1952, 7, 4)]
                public class Father { }

                [FavoriteColor(KnownColor.Red)]
                [Birthdate(1980, 12, 6)]
                public class Brother { }

                [Birthdate(1980, 12, 31)]
                public class Sister { }
            }
        }
    }

    [PersonalFirst("Judgment Day")]
    [Age(44, TimePeriods.Years)]
    [IsReleased(false)]
    public class BirthToGrowingUp : JudgmentDayBase
    {
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
                new AnnotatedPlaceEvent1(PlaceType.Home, USCities.WisconsinHarmonyGrove, string.Empty),
                new AnnotatedPlaceEvent2(PlaceType.Home, USCities.WisconsinEndeavor, string.Empty),
                new AnnotatedPlaceEvent3(PlaceType.Church, USCities.WisconsinWisconsinDells, "ELCA Lutheran"),
                new PlaceInSpecificCity(PlaceType.School, USCities.WisconsinWisconsinDells, "Kindergarden"),
                new PlaceInSpecificCity(PlaceType.School, USCities.WisconsinBriggsville, "Grades 1-3"),
                new SchoolClassList("1st Grade", typeof(FirstGradeClassAttendanceListAlphabetical)),
                new SchoolClassList("3rd Grade", typeof(ThirdGradePartialClassList))
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
                new MultiEvent("Age 9ish", [new SelfAwarenessOfAdultLevelOfAnalyticalThinking(), new OrionIsaRising()]),
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
                "He's a genius", (int)FirstGradeClassAttendanceListAlphabetical.Laura, (int)FamilyMembers.MyMaternalUncle);
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
                new CosmicCharity(1, (int)FamilyMembers.MySister, "Insulting Song #1"),
                new CosmicCharity(1, (int)FamilyMembers.MySister, "Insulting Song #2"),
                new CosmicCharity(1, (int)FamilyMembers.MySister, "Her Name is Exposed"),
                new CosmicCharity(1, (int)FirstGradeClassAttendanceListAlphabetical.Laura, "Never Acknowledged Compliment, Potential Soulmate"),
            };
        }

        private static void ChainEvents(List<BaseEvent> events, BaseEvent? previousEvent)
        {
            for (int i = 0; i < events.Count; i++)
            {
                events[i].PreviousEvent = (i == 0 ? previousEvent : events[i - 1]);
            }
        }

        public enum FamilyMembers
        {
            MyMaternalUncle,
            MyMother,
            MyFather,
            Myself,
            MySister,
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

        public class TerminalEvent
        {
            public string EventName { get; set; }
            public BaseEvent[] PreviousEvents { get; set; }
            public TerminalEvent(string EventName, params BaseEvent[] PreviousEvents)
            {
                this.EventName = EventName;
                this.PreviousEvents = PreviousEvents;
            }
        }

        public class BaseEvent
        {
            public string EventName { get; set; }
            public BaseEvent? PreviousEvent;

            public BaseEvent(string EventName)
            {
                this.EventName = EventName;
                this.PreviousEvent = null;
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

        public abstract class Song : BaseEvent
        {
            public virtual string GetLyrics()
            {
                throw new InvalidOperationException();
            }
            public virtual string GetMeaning()
            {
                throw new InvalidOperationException();
            }
            public Song(string SongName) : base(SongName)
            {
            }
        }

        public abstract class ParodySong : Song
        {
            public string Parodies { get; set; }
            public ParodySong(string SongName, string Parodies) : base(SongName)
            {
                this.Parodies = Parodies;
            }
        }

        public abstract class OriginalSong : BaseEvent
        {
            public virtual string GetLyrics()
            {
                throw new InvalidOperationException();
            }
            public virtual string GetMeaning()
            {
                throw new InvalidOperationException();
            }
            public OriginalSong(string SongName) : base(SongName)
            {
            }
        }

        [PersonalFirst("Parody Song")]
        [ZHumanLevel(HumanLevel.Childhood)]
        [MusicNotesRepositoryAudioFile(@"Released\JudgmentDay\Audio\SonyasDumb.wav", PeopleEnumerated.RoweChris)]
        public class FirstParodySong : ParodySong
        {
            public FirstParodySong() : base("Sonya's Dumb", "Rain, Rain, Go Away")
            {
            }

            public override string GetLyrics()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Sonya's dumb");
                sb.AppendLine("She's a bum");
                sb.AppendLine("She is a dirty trum");
                sb.AppendLine("Ha ha ha");
                sb.AppendLine("She's some fa");
                sb.AppendLine("She gets sent to la la la");
                return sb.ToString();
            }
            public override string GetMeaning()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("The song is insulting the sibling (Sonya) for being dumb, and the singer finds this funny (ha ha ha). There is no");
                sb.AppendLine("particular meaning ascribed to bum other than it rhymes with dumb. \"Trum\", \"fa\", and \"la la la\" are nonsense");
                sb.AppendLine("filler. Although the singer's analytical skills are significantly beyond the sibling's, as humans go the sibling");
                sb.AppendLine("was actually normal to a bit above normal intelligence.");
                return sb.ToString();
            }
        }

        [PersonalFirst("Original Song")]
        [MusicNotesRepositoryAudioFile(@"Released\JudgmentDay\Audio\2-TheNationalSIDFoundation.wav", PeopleEnumerated.RoweChris)]
        public class FirstOriginalSong : Song
        {
            public FirstOriginalSong() : base("The National SID Foundation")
            {
                
            }
            public override string GetLyrics()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("The National SID Foundation is proud to commend Sonya Rowe.");
                sb.AppendLine("For being an idiot station, and having no brains that we know.");
                return sb.ToString();
            }
            public override string GetMeaning()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("SID stands for \"Sonya is Dumb\". It is absurd to think there would be a country-level organization");
                sb.AppendLine("dedicated to the stupidity of a specific person. This is purely an insult song, and did frequently provoke");
                sb.AppendLine("a reaction. As noted elsewhere (most notably in the explanation for \"Sonya's Dumb\"), the target of the song");
                sb.AppendLine("is actually of normal to slightly above average intelligence. Occasionally the target of the song would sing it ");
                sb.AppendLine("with altered lyrics, specifically reversing to \"The National CRID Foundation is proud to commend Chris Rowe\".");
                sb.AppendLine("The original creator of the song was generally okay with the reversal, acknowledging that turnabout is fair play.");
                sb.AppendLine("But the lack of reaction for the reversal meant the main song was sung far more often than the reversal, an");
                sb.AppendLine("example of the principle that life is not fair.");
                return sb.ToString();
            }
        }

        [Text("Sung as a round many times in the car with mother and sister")]
        public class SweetlySingsTheDonkeyAtTheBreakOfDay : Song
        {
            public SweetlySingsTheDonkeyAtTheBreakOfDay() : base("Sweetly Sings the Donkey at the Break of Day")
            {
            }
            public override string GetLyrics()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Sweetly sings the donkey at the break of day.");
                sb.AppendLine("If you do not feed him, this is what he'll say:");
                sb.AppendLine("Hee-haw, hee-haw, hee-haw, hee-haw, hee-haw.");
                return sb.ToString();
            }
            public override string GetMeaning()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("The song describes the morning routine of a donkey. The donkey sings at daybreak, which is curious because donkeys");
                sb.AppendLine("do not \"sing\" the way humans do, and also the noises a donkey makes are not particularly analogous to singing to human ears.");
                sb.AppendLine("The donkey is fed in the morning as typical for farm animals. And if not fed the hungry donkey will say donkey sounds. Again,");
                sb.AppendLine("this is curious because donkeys do not \"say\" things the way humans do. Nevertheless the donkey says \"Hee-haw\" five times.");
                sb.AppendLine("What does the donkey mean by its singing and saying? The obvious answer of saying \"Feed me\" or \"Please feed me\" is a reasonable");
                sb.AppendLine("choice of ascribing human words to the donkey. But we can never really know if that's correct or if the donkey's singing/saying");
                sb.AppendLine("has another more inscrutable meaning.");
                return sb.ToString();
            }
        }

        public class OrionIsaRising : Song
        {
            public OrionIsaRising() : base("Orion is a-Rising")
            {
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

            public string Consequences
            {
                get
                {
                    return "I never acknowledged this in any way.";
                }
            }
        }

        public enum PetDogs
        {
            
            Abe,
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
