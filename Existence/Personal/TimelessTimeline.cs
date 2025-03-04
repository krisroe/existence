
using Existence.Earth;
using Existence.Earth.Alphabet;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.People;
using Existence.Logic.Random;
using Existence.Time;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Existence.Personal
{
    [HumanGender(HumanGender.Male)]
    [HumanSex(HumanSex.Male)]
    internal class Timeless { }

    internal class BirthToGrowingUp
    {
        public BirthToGrowingUp()
        {
            Birth birthEvent = new Birth();
            SiblingBirth siblingBirthEvent = new SiblingBirth(birthEvent);
            HomeInSpecificCity1 home1Event = new HomeInSpecificCity1(siblingBirthEvent);
            HomeInSpecificCity2 home2Event = new HomeInSpecificCity2(home1Event);
            ChurchInSpecificCity3 churchEvent = new ChurchInSpecificCity3(home2Event);
            ActionsHaveConsequences actionsHaveConsequences = new ActionsHaveConsequences(churchEvent);
            DoubletEvent newHomeEvents = new DoubletEvent("Age 6ish",
                new BaseEvent("StartedPianoLessons"),
                new FavoriteNumbers(), actionsHaveConsequences);
            DoubletEvent age7ish = new DoubletEvent("Age 7ish",
                new BaseEvent("StartedUsingComputers"),
                new FirstParodySong(), newHomeEvents);
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

                //randomize event #1 vis-a-vis event #2
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

        [YearDate(1980, 12, 6)]
        [HumanSex(HumanSex.Male)]
        [PersonalHumanLevel(HumanLevel.Baby)]
        public class Birth : BaseEvent
        {
            public Birth() : base("Birth") { }
        }

        [YearDate(1982, 12, 31)]
        [FirstName("Sonya")]
        public class SiblingBirth : BaseEvent
        {
            public SiblingBirth(params BaseEvent[] PreviousEvents) : base("Sibling Birth", PreviousEvents) { }
        }

        /// <summary>
        /// first memory of touching the bark of the birch trees outside
        /// </summary>
        [PersonalFirst("Memory")]
        [PersonalHumanLevel(HumanLevel.Childhood)]
        [USCity(USCities.WisconsinHarmonyGrove)]
        public class HomeInSpecificCity1 : BaseEvent
        {
            public HomeInSpecificCity1(params BaseEvent[] PreviousEvents) : base("Home=HarmonyGroveWI", PreviousEvents)
            {
            }
        }

        /// <summary>
        /// early memory of warming myself in the morning by the radiator
        /// </summary>
        [USCity(USCities.WisconsinEndeavor)]
        public class HomeInSpecificCity2 : BaseEvent
        {
            public HomeInSpecificCity2(params BaseEvent[] PreviousEvents) : base("Home=EndeavorWI", PreviousEvents)
            {
            }
        }

        [DivineHumanLevel(HumanLevel.Childhood)]
        [USCity(USCities.WisconsinWisconsinDells)]
        public class ChurchInSpecificCity3 : BaseEvent
        {
            public ChurchInSpecificCity3(params BaseEvent[] PreviousEvents) : base("Church=WisconsinDellsWI", PreviousEvents)
            {
            }
        }

        /// <summary>
        /// This refers to an incident at the house #2 with sticking my finger in exposed light outlets.
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

        /// <summary>
        /// took a standardized test in 3rd grade, receiving "post high school" pretty much across the board
        /// </summary>
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
