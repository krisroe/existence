
using Existence.Earth;
using Existence.Earth.Alphabet;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Logic.Random;
using Existence.Time;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Existence.Personal
{
    internal class TimelessTimelinePreBirthToGrowingUp
    {
        public TimelessTimelinePreBirthToGrowingUp()
        {
            IList<BaseEvent> preBirthEvents = RandomizeEvents(new List<BaseEvent>()
            {
                new BaseEvent("Male"),
                new BaseEvent("ActionsHaveConsequences")
            });
            BaseEvent birthEvent = new Birth(preBirthEvents.ToArray());
            HomeIsHarmonyGroveWI home1Event = new HomeIsHarmonyGroveWI(birthEvent);
            HomeIsEndeavorWI home2Event = new HomeIsEndeavorWI(home1Event);
            IList<BaseEvent> postHomeEndeavorWIEvents = RandomizeEvents(new List<BaseEvent>()
            {
                new BaseEvent("StartedPianoLessons", home2Event),
                new FavoriteNumbers(home2Event),
            });
            BaseEvent startedUsingComputers = new BaseEvent("StartedUsingComputers", postHomeEndeavorWIEvents.ToArray());
            new SkepticismOfReligion(new LifesNotFair(new EventuallyIWillDie(startedUsingComputers)));
        }

        public static IList<BaseEvent> RandomizeEvents(List<BaseEvent> events)
        {
            RandomLogic.RandomType randomValue = (RandomLogic.RandomType)RandomNumberGenerator.GetInt32(0, 4);
            RandomLogic.LinqHandling linqHandling = (RandomLogic.LinqHandling)RandomNumberGenerator.GetInt32(0, 3);
            return RandomLogic.DoFisherYatesKnuthRandomizer(events, null, randomValue, linqHandling);
        }

        public class BaseEvent
        {
            public string EventName { get; set; }
            public BaseEvent[]? PreviousEvents;

            public BaseEvent(string EventName, params BaseEvent[] PreviousEvents)
            {
                this.EventName = EventName;
                this.PreviousEvents = PreviousEvents;
            }
        }

        public class HomeEvent : BaseEvent
        {
            public HomeEvent(string Home, params BaseEvent[] PreviousEvents) : base(Home, PreviousEvents)
            {
                this.EventName = Home;
                this.PreviousEvents = PreviousEvents;
            }
        }

        public class HomeIsEndeavorWI : HomeEvent
        {
            public HomeIsEndeavorWI(params BaseEvent[] PreviousEvents) : base("Home=EndeavorWI", PreviousEvents)
            {
            }
        }

        [FirstMemory]
        [PersonalHumanLevel(HumanLevel.Childhood)]
        public class HomeIsHarmonyGroveWI : HomeEvent
        {
            public HomeIsHarmonyGroveWI(params BaseEvent[] PreviousEvents) : base("Home=HarmonyGroveWI", PreviousEvents)
            {
            }
        }

        [YearDate(1980, 12, 6)]
        [PersonalHumanLevel(HumanLevel.Baby)]
        public class Birth : BaseEvent
        {
            public Birth(params BaseEvent[] PreviousEvents) : base("Birth", PreviousEvents) { }
        }

        [ApproximateAge(6)]
        [FavoriteNumber(24865)]
        [SecondFavoriteNumber(4)]
        [CosmicZLevel(ZLevel.One)]
        public class FavoriteNumbers : BaseEvent
        {
            public FavoriteNumbers(params BaseEvent[] PreviousEvents) : base("Favorite Numbers", PreviousEvents) { }
        }

        /// <summary>
        /// subject deferred to age 16
        /// </summary>
        [ApproximateAge(8)]
        public class EventuallyIWillDie : BaseEvent
        {
            public EventuallyIWillDie(params BaseEvent[] PreviousEvents) : base("Eventually I will Die", PreviousEvents) { }
        }

        [ApproximateAge(9)]
        [PersonalHumanLevel(HumanLevel.GrowingUp)]
        [PersonalZLevel(ZLevel.One)]
        public class LifesNotFair : BaseEvent
        {
            public LifesNotFair(params BaseEvent[] PreviousEvents) : base("Life's Not Fair", PreviousEvents) { }
        }

        [ApproximateAge(10)]
        [CosmicHumanLevel(HumanLevel.GrowingUp)]
        [Quote("I have no sin.", "My Bedroom", "Alone")]
        public class SkepticismOfReligion : BaseEvent
        {
            public SkepticismOfReligion(params BaseEvent[] PreviousEvents) : base("Skepticism of Religion", PreviousEvents) { }
        }
    }
}
