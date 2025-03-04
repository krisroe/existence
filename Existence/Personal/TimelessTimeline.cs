
using Existence.Earth;
using Existence.Earth.Alphabet;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Logic.Random;
using Existence.Time;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Existence.Personal
{
    internal class TimelessTimeline
    {
        public TimelessTimeline()
        {
            List<BaseEvent> preBirthEvents = new List<BaseEvent>()
            {
                new BaseEvent("Male"),
                new BaseEvent("ActionsHaveConsequences")
            };

            RandomLogic.RandomType randomValue = (RandomLogic.RandomType)RandomNumberGenerator.GetInt32(0, 4);
            RandomLogic.LinqHandling linqHandling = (RandomLogic.LinqHandling)RandomNumberGenerator.GetInt32(0, 3);
            RandomLogic.DoFisherYatesKnuthRandomizer(preBirthEvents, null, randomValue, linqHandling);

            new SkepticismOfReligion(new LifesNotFair(new Birth(preBirthEvents.ToArray())));
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
        public class Birth : BaseEvent
        {
            public Birth(params BaseEvent[] PreviousEvents) : base("Birth", PreviousEvents) { }
        }

        [ApproximateAge(9)]
        [UpgradeToLevel(1)]
        public class LifesNotFair : BaseEvent
        {
            public LifesNotFair(params BaseEvent[] PreviousEvents) : base("Life's Not Fair", PreviousEvents) { }
        }

        [ApproximateAge(10)]
        [Quote("I have no sin.", "My Bedroom", "Alone")]
        public class SkepticismOfReligion : BaseEvent
        {
            public SkepticismOfReligion(params BaseEvent[] PreviousEvents) : base("Skepticism of Religion", PreviousEvents) { }
        }
    }
}
