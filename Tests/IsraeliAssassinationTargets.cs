using Existence.Earth.War;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Reflection;

namespace Existence.Tests
{
    /// <summary>
    /// test class
    /// </summary>
    [TestClass]
    public class IsraeliAssassinationTargetsTest
    {
        /// <summary>
        /// validates that the number of assassinations, survived assassination attempts and other killings of assassination
        /// targets made after the 2023-10-07 attacks across the IsraeliAssassinationTarget enum matches the total attribute on the enum
        /// </summary>
        [TestMethod]
        public void ValidateCorrectNumberOfAssassinationAttemptsStemmingFrom2023OctoberAttacks()
        {
            int iAttemptCount = 0;
            foreach (FieldInfo field in typeof(IsraeliAssassinationTarget).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                iAttemptCount += field.GetCustomAttributes<AssassinatedAttribute>().Count(a => !IsPriorToOctober7(a));
                iAttemptCount += field.GetCustomAttributes<AssassinationAttemptAttribute>().Count(a => !IsPriorToOctober7(a));
                iAttemptCount += field.GetCustomAttributes<AssassinatedButNotActuallyAssassinatedAttribute>().Count();
            }
            TotalAssassinationAttemptsStemmingFrom2023OctoberAttacksAttribute? totalAttribute = typeof(IsraeliAssassinationTarget).GetCustomAttribute<TotalAssassinationAttemptsStemmingFrom2023OctoberAttacksAttribute>();
            Assert.IsNotNull(totalAttribute, $"{nameof(IsraeliAssassinationTarget)} has no {nameof(TotalAssassinationAttemptsStemmingFrom2023OctoberAttacksAttribute)}");
            Assert.AreEqual(totalAttribute.Number, iAttemptCount, $"{nameof(TotalAssassinationAttemptsStemmingFrom2023OctoberAttacksAttribute)} on {nameof(IsraeliAssassinationTarget)} does not match the number of {nameof(AssassinatedAttribute)}, {nameof(AssassinationAttemptAttribute)} and {nameof(AssassinatedButNotActuallyAssassinatedAttribute)} attributes on its values, excluding those prior to the 2023-10-07 attacks");
        }

        /// <summary>
        /// validates that the survivor count range on the IsraeliAssassinationTarget enum matches the number of targets
        /// marked as having survived (low) plus those where it is unclear if they are still alive (high)
        /// </summary>
        [TestMethod]
        public void ValidateSurvivorCountRange()
        {
            FieldInfo[] fields = typeof(IsraeliAssassinationTarget).GetFields(BindingFlags.Public | BindingFlags.Static);
            int iSurvivorCount = fields.Count(f => f.IsDefined(typeof(SurvivedTheEndOfNetanyahusPostOctober7AttacksTermAttribute)));
            int iUnclearCount = fields.Count(f => f.IsDefined(typeof(UnclearIfStillAliveAttribute)));
            SurvivorCountRangeAttribute? rangeAttribute = typeof(IsraeliAssassinationTarget).GetCustomAttribute<SurvivorCountRangeAttribute>();
            Assert.IsNotNull(rangeAttribute, $"{nameof(IsraeliAssassinationTarget)} has no {nameof(SurvivorCountRangeAttribute)}");
            Assert.AreEqual(rangeAttribute.Low, iSurvivorCount, $"{nameof(SurvivorCountRangeAttribute.Low)} on {nameof(IsraeliAssassinationTarget)} does not match the number of {nameof(SurvivedTheEndOfNetanyahusPostOctober7AttacksTermAttribute)} attributes on its values");
            Assert.AreEqual(rangeAttribute.High, iSurvivorCount + iUnclearCount, $"{nameof(SurvivorCountRangeAttribute.High)} on {nameof(IsraeliAssassinationTarget)} does not match the number of {nameof(SurvivedTheEndOfNetanyahusPostOctober7AttacksTermAttribute)} and {nameof(UnclearIfStillAliveAttribute)} attributes on its values");
        }

        /// <summary>
        /// determines whether an assassination or assassination attempt attribute is one of the
        /// attributes marking events prior to the 2023-10-07 attacks
        /// </summary>
        /// <param name="attribute">the attribute to check</param>
        /// <returns>true if the attribute marks an event prior to the 2023-10-07 attacks</returns>
        private static bool IsPriorToOctober7(Attribute attribute)
        {
            return attribute is AssassinatedPriorToOctober7Attribute || attribute is AttemptedAssassinationPriorToOctober7Attribute;
        }
    }
}
