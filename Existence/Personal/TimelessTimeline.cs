
using Existence.Earth;
using Existence.Earth.Alphabet;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.People;
using Existence.Logic.Random;
using Existence.Time;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace Existence.Personal
{
    internal class Timeless
    {
        [HumanGender(HumanGender.Male)]
        [HumanSex(HumanSex.Male)]
        [FavoriteColor(KnownColor.Transparent)]
        [Birthdate(1980, 12, 6)]
        public class Self { }

        [Birthdate(1952, 2, 18)]
        public class Mother { }

        [FavoriteColor(KnownColor.Green)]
        [Birthdate(1952, 7, 4)]
        public class Father { }

        [Birthdate(1980, 12, 31)]
        public class Sister { }
    }

    internal class BirthToGrowingUp
    {
        public BirthToGrowingUp()
        {
            List<BaseEvent> chainedEvents = new List<BaseEvent>()
            {
                new Birth(),
                new SisterName(),
                new HomeInSpecificCity1(),
                new HomeInSpecificCity2(),
                new ChurchInSpecificCity3(),
                new ActionsHaveConsequences(),
                new MultiEvent("Age 6ish", [new BaseEvent("StartedPianoLessons") , new SimpleFavorites()]),
                new MultiEvent("Age 7ish", [new BaseEvent("StartedUsingComputers"), new FirstParodySong()]),
                new EventuallyIWillDie(),
                new MultiEvent("Age 9ish", [new LifesNotFair(), new SelfAwarenessOfAdultLevelOfAnalyticalThinking()]),
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

        [HumanSex(HumanSex.Male)]
        [PersonalHumanLevel(HumanLevel.Baby)]
        public class Birth : BaseEvent
        {
            public Birth() : base("Birth") { }
        }

        [FirstName("Sonya")]
        public class SisterName : BaseEvent
        {
            public SisterName() : base("Sister Name") { }
        }

        /// <summary>
        /// first memory of touching the bark of the birch trees outside
        /// </summary>
        [PersonalFirst("Memory")]
        [PersonalHumanLevel(HumanLevel.Childhood)]
        [USCity(USCities.WisconsinHarmonyGrove)]
        public class HomeInSpecificCity1 : BaseEvent
        {
            public HomeInSpecificCity1() : base("Home=HarmonyGroveWI")
            {
            }
        }

        /// <summary>
        /// early memory of warming myself in the morning by the radiator
        /// </summary>
        [USCity(USCities.WisconsinEndeavor)]
        public class HomeInSpecificCity2 : BaseEvent
        {
            public HomeInSpecificCity2() : base("Home=EndeavorWI")
            {
            }
        }

        [DivineHumanLevel(HumanLevel.Childhood)]
        [USCity(USCities.WisconsinWisconsinDells)]
        public class ChurchInSpecificCity3 : BaseEvent
        {
            public ChurchInSpecificCity3() : base("Church=WisconsinDellsWI")
            {
            }
        }

        /// <summary>
        /// This refers to an incident at the house #2 with sticking my finger in exposed light outlets.
        /// There were no discernable consequences, but the lesson was learned nonetheless.
        /// </summary>
        public class ActionsHaveConsequences : BaseEvent
        {
            public ActionsHaveConsequences() : base("Actions Have Consequences")
            {
            }
        }

        [FavoriteNumber(24865)]
        [SecondFavoriteNumber(4)]
        [FavoriteColor(KnownColor.Red)]
        [CosmicZLevel(ZLevel.One)]
        [CosmicHumanLevel(HumanLevel.Childhood)]
        public class SimpleFavorites : BaseEvent
        {
            public SimpleFavorites() : base("Simple Favorites") { }
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

        /// <summary>
        /// subject contemplated, further processing deferred to age 16
        /// </summary>
        [ApproximateAge(8)]
        public class EventuallyIWillDie : BaseEvent
        {
            public EventuallyIWillDie() : base("Eventually I will Die") { }
        }

        [ApproximateAge(9)]
        [PersonalHumanLevel(HumanLevel.GrowingUp)]
        [PersonalZLevel(ZLevel.One)]
        public class LifesNotFair : BaseEvent
        {
            public LifesNotFair() : base("Life's Not Fair") { }
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
        }

        [ApproximateAge(10)]
        [DivineHumanLevel(HumanLevel.GrowingUp)]
        [Quote("I have no sin.", "My Bedroom", "Alone")]
        public class SkepticismOfReligion : BaseEvent
        {
            public SkepticismOfReligion() : base("Skepticism of Religion") { }
        }
    }
}
