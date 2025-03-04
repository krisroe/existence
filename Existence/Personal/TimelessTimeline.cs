
using Existence.Earth;
using Existence.Earth.Alphabet;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Logic.Random;
using Existence.Time;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Existence.Personal
{
    internal class TimelessTimelinePreBirthToGrowingUp
    {
        public TimelessTimelinePreBirthToGrowingUp()
        {
            BaseEvent male = new BaseEvent("Male");
            Birth birthEvent = new Birth(male);
            SiblingBirth siblingBirthEvent = new SiblingBirth(birthEvent);
            HomeInHarmonyGroveWI home1Event = new HomeInHarmonyGroveWI(siblingBirthEvent);
            HomeInEndeavorWI home2Event = new HomeInEndeavorWI(home1Event);
            ChurchInWisconsinDellsWI churchEvent = new ChurchInWisconsinDellsWI(home2Event);
            ActionsHaveConsequences actionsHaveConsequences = new ActionsHaveConsequences(churchEvent);
            DoubletEvent postHomeEndeavorWIEvents = new DoubletEvent("Age 6ish",
                new BaseEvent("StartedPianoLessons"),
                new FavoriteNumbers(), actionsHaveConsequences);
            DoubletEvent age7ish = new DoubletEvent("Age 7ish",
                new BaseEvent("StartedUsingComputers"),
                new SonyasDumb(), postHomeEndeavorWIEvents);
            EventuallyIWillDie eventuallyWillDie = new EventuallyIWillDie(age7ish);
            DoubletEvent age9ish = new DoubletEvent("Age 9ish",
                new LifesNotFair(),
                new SelfAwarenessOfAdultLevelOfAnalyticalThinking(), eventuallyWillDie);
            new SkepticismOfReligion(age9ish);
        }

        public class DoubletEvent : BaseEvent
        {
            public BaseEvent Event1 { get; set; }
            public BaseEvent Event2 { get; set; }
            public DoubletEvent(string EventName, BaseEvent Event1, BaseEvent Event2, params BaseEvent[] PreviousEvents) : base(EventName, PreviousEvents)
            {
                this.Event1 = Event1;
                this.Event2 = Event2;

                //randomize
                List<BaseEvent> list = new List<BaseEvent>() { Event1, Event2 };
                RandomLogic.RandomType randomValue = (RandomLogic.RandomType)RandomNumberGenerator.GetInt32(0, 4);
                RandomLogic.LinqHandling linqHandling = (RandomLogic.LinqHandling)RandomNumberGenerator.GetInt32(0, 3);
                IList<BaseEvent> randomized = RandomLogic.DoFisherYatesKnuthRandomizer(list, null, randomValue, linqHandling);
                Event1 = randomized[0];
                Event2 = randomized[1];
            }
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

        [YearDate(1980, 12, 6)]
        [PersonalHumanLevel(HumanLevel.Baby)]
        public class Birth : BaseEvent
        {
            public Birth(params BaseEvent[] PreviousEvents) : base("Birth", PreviousEvents) { }
        }

        [YearDate(1982, 12, 31)]
        [FirstName("Sonya")]
        public class SiblingBirth : BaseEvent
        {
            public SiblingBirth(params BaseEvent[] PreviousEvents) : base("Sibling Birth", PreviousEvents) { }
        }

        [PersonalFirst("Memory")]
        [PersonalHumanLevel(HumanLevel.Childhood)]
        public class HomeInHarmonyGroveWI : HomeEvent
        {
            public HomeInHarmonyGroveWI(params BaseEvent[] PreviousEvents) : base("Home=HarmonyGroveWI", PreviousEvents)
            {
            }
        }

        public class HomeInEndeavorWI : HomeEvent
        {
            public HomeInEndeavorWI(params BaseEvent[] PreviousEvents) : base("Home=EndeavorWI", PreviousEvents)
            {
            }
        }

        [DivineHumanLevel(HumanLevel.Childhood)]
        public class ChurchInWisconsinDellsWI : BaseEvent
        {
            public ChurchInWisconsinDellsWI(params BaseEvent[] PreviousEvents) : base("Church=WisconsinDellsWI", PreviousEvents)
            {
            }
        }

        /// <summary>
        /// This refers to an incident at the Endeavor house with sticking my finger in exposed light outlets.
        /// There were no discernable consequences, but the lesson was learned nonetheless.
        /// </summary>
        public class ActionsHaveConsequences : BaseEvent
        {
            public ActionsHaveConsequences(params BaseEvent[] PreviousEvents) : base("Actions Have Consequences", PreviousEvents)
            {
            }
        }

        [ApproximateAge(6)]
        [FavoriteNumber(24865)]
        [SecondFavoriteNumber(4)]
        [CosmicZLevel(ZLevel.One)]
        [CosmicHumanLevel(HumanLevel.Childhood)]
        public class FavoriteNumbers : BaseEvent
        {
            public FavoriteNumbers(params BaseEvent[] PreviousEvents) : base("Favorite Numbers", PreviousEvents) { }
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
            public ParodySong(string SongName, string Parodies, params BaseEvent[] PreviousEvents) : base(SongName, PreviousEvents)
            {
                this.Parodies = Parodies;
            }
        }

        [PersonalFirst("Parody Song")]
        public class SonyasDumb : ParodySong
        {
            public SonyasDumb() : base("Sonya's Dumb", "Rain, Rain, Go Away")
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
                sb.AppendLine("Although my analytical skills are significantly beyond hers,");
                sb.AppendLine("As humans go she is normal to a bit above normal intelligence.");
                return sb.ToString();
            }
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

        [ApproximateAge(9)]
        [CosmicHumanLevel(HumanLevel.GrowingUp)]
        public class SelfAwarenessOfAdultLevelOfAnalyticalThinking : BaseEvent
        {
            public SelfAwarenessOfAdultLevelOfAnalyticalThinking(params BaseEvent[] PreviousEvents) : base("Post High School", PreviousEvents)
            {
            }
        }

        [ApproximateAge(10)]
        [DivineHumanLevel(HumanLevel.GrowingUp)]
        [Quote("I have no sin.", "My Bedroom", "Alone")]
        public class SkepticismOfReligion : BaseEvent
        {
            public SkepticismOfReligion(params BaseEvent[] PreviousEvents) : base("Skepticism of Religion", PreviousEvents) { }
        }
    }
}
