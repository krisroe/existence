using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Existence.Earth.Human.People;
using Existence.Earth;
using Existence.Time;
using Existence.Earth.Alphabet;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Logic.Random;
using System.Security.Cryptography;
using Existence.Logic;

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
            [URI("https://github.com/krisroe")]
            public static class Repositories
            {
                [RepositoryName("existence")]
                public static class Existence { }

                [RepositoryName("musicnotes")]
                public static class Music { }
            }
        }

        public class FirstNuclearFamilyUnit
        {
            [Birthdate(1952, 2, 18)]
            public class Mother { }

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

    [PersonalFirst("Judgment Day")]
    [JudgmentDayLevel(4)]
    public class BirthToGrowingUp
    {
        public BirthToGrowingUp()
        {
            List<BaseEvent> chainedEvents = new List<BaseEvent>()
            {
                new BaseEvent("ActionsHaveConsequences"),
                new Birth(),
                new SisterName(),
                new AnnotatedPlaceEvent1(PlaceType.Home, USCities.WisconsinHarmonyGrove, string.Empty),
                new AnnotatedPlaceEvent2(PlaceType.Home, USCities.WisconsinEndeavor, string.Empty),
                new AnnotatedPlaceEvent3(PlaceType.Church, USCities.WisconsinWisconsinDells, "ELCA Lutheran"),
                new PlaceInSpecificCity(PlaceType.School, USCities.WisconsinWisconsinDells, "Kindergarden"),
                new PlaceInSpecificCity(PlaceType.School, USCities.WisconsinBriggsville, "Grades 1-3"),
                new MultiEvent("Age 6ish", [new BaseEvent("StartedPianoLessons") , new EstablishedFavoriteNumbers()]),
                new MultiEvent("Age 7ish", [new BaseEvent("StartedUsingComputers"), new FirstParodySong()]),
                new MultiEvent("Age 8ish", [new ContemplatedEventuallyIWillDie(), new LifesNotFair()]),
                new SelfAwarenessOfAdultLevelOfAnalyticalThinking(),
                new SkepticismOfReligion()
            };
            for (int i = 0; i < chainedEvents.Count; i++)
            {
                if (i > 0)
                {
                    chainedEvents[i].PreviousEvent = chainedEvents[i - 1];
                }
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

        [FirstName("Sonya")]
        public class SisterName : BaseEvent
        {
            public SisterName() : base("Sister Name") { }
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

        [CosmicZLevel(ZLevel.One)]
        [CosmicHumanLevel(HumanLevel.Childhood)]
        public class EstablishedFavoriteNumbers : BaseEvent
        {
            public EstablishedFavoriteNumbers() : base("Established Favorite Numbers") { }
        }

        public abstract class ParodySong : BaseEvent
        {
            public string Parodies { get; set; }
            public virtual string GetLyrics()
            {
                throw new InvalidOperationException();
            }
            public virtual string GetMeaning()
            {
                throw new InvalidOperationException();
            }
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
                sb.AppendLine("The song is insulting the sibling for being dumb.");
                sb.AppendLine("Although my analytical skills are significantly beyond the sibling's,");
                sb.AppendLine("As humans go the sibling was actually normal to a bit above normal intelligence.");
                return sb.ToString();
            }
        }

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
        [ApproximateAge(9)]
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
                    return "Chose to focus on developing analytical thinking skills, and develop people skills to minimum necessary";
                }
            }
        }

        [ApproximateAge(10)]
        [DivineHumanLevel(HumanLevel.GrowingUp)]
        [Quote("I have no sin.", "Me", "My Bedroom", "Alone")]
        [BiblePassage("1 John 1:8-9")]
        public class SkepticismOfReligion : BaseEvent
        {
            public SkepticismOfReligion() : base("Skepticism of Religion") { }

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
