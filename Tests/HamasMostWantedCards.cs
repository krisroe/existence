using Existence.Earth.Gambling;
using Existence.Earth.War;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Existence.Tests
{
    /// <summary>
    /// test class
    /// </summary>
    [TestClass]
    public class HamasMostWantedCardsTest
    {
        /// <summary>
        /// validates that every card in a standard deck is assigned to exactly one person across the
        /// IsraeliAssassinationTarget and IsraeliHamasMostWantedTargets enums
        /// </summary>
        [TestMethod]
        public void ValidateEachCardIsUsedExactlyOnce()
        {
            List<StandardPlayingCard> cards = new List<StandardPlayingCard>();
            foreach (Type t in new[] { typeof(IsraeliAssassinationTarget), typeof(IsraeliHamasMostWantedTargets) })
            {
                foreach (FieldInfo field in t.GetFields(BindingFlags.Public | BindingFlags.Static))
                {
                    cards.AddRange(field.GetCustomAttributes<HamasMostWantedAttribute>().Select(a => a.Card));
                }
            }
            foreach (StandardPlayingCard card in Enum.GetValues<StandardPlayingCard>())
            {
                Assert.AreEqual(1, cards.Count(c => c == card), $"{card} is not assigned to exactly one person");
            }
            Assert.AreEqual(Enum.GetValues<StandardPlayingCard>().Length, cards.Count, $"number of {nameof(HamasMostWantedAttribute)} attributes does not match the number of cards in a standard deck");
        }

        /// <summary>
        /// validates that nobody in IsraeliHamasMostWantedTargets is also on the IsraeliAssassinationTarget list
        /// </summary>
        [TestMethod]
        public void ValidateMostWantedTargetsAreNotAssassinationTargets()
        {
            HashSet<string> assassinationTargets = new HashSet<string>(Enum.GetNames<IsraeliAssassinationTarget>());
            foreach (string name in Enum.GetNames<IsraeliHamasMostWantedTargets>())
            {
                Assert.IsFalse(assassinationTargets.Contains(name), $"{name} is in both {nameof(IsraeliHamasMostWantedTargets)} and {nameof(IsraeliAssassinationTarget)}");
            }
        }
    }
}
