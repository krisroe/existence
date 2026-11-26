using Existence.Earth.War;
using Existence.Time;
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
        /// validates the reported death dates on the IsraeliAssassinationTarget enum: each is a full date on a target with a death date,
        /// the death date is not after it, and for an overnight report a death date given to the day is the report date or the day before
        /// </summary>
        [TestMethod]
        public void ValidateDeathDatesReported()
        {
            foreach (FieldInfo field in typeof(IsraeliAssassinationTarget).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                DeathDateReportedAttribute? reported = field.GetCustomAttribute<DeathDateReportedAttribute>();
                if (reported != null)
                {
                    Assert.IsTrue(reported.Month > 0 && reported.Day > 0, $"{field.Name} has a {nameof(DeathDateReportedAttribute)} without a month and day");
                    DateTime reportedDate = new DateTime(reported.Year, reported.Month!.Value, reported.Day!.Value);
                    DeathDateAttribute? death = field.GetCustomAttribute<DeathDateAttribute>();
                    Assert.IsNotNull(death, $"{field.Name} has a {nameof(DeathDateReportedAttribute)} but no {nameof(DeathDateAttribute)}");
                    int deathMonth = death.Month ?? 0;
                    int deathDay = death.Day ?? 0;
                    if (deathMonth == 0)
                    {
                        Assert.IsTrue(death.Year <= reportedDate.Year, $"{field.Name} died after the death was reported");
                    }
                    else if (deathDay == 0)
                    {
                        Assert.IsTrue(new DateTime(death.Year, deathMonth, 1) <= reportedDate, $"{field.Name} died after the death was reported");
                    }
                    else
                    {
                        DateTime deathDate = new DateTime(death.Year, deathMonth, deathDay);
                        Assert.IsTrue(deathDate <= reportedDate, $"{field.Name} died after the death was reported");
                        if (reported.Overnight)
                        {
                            Assert.IsTrue(deathDate >= reportedDate.AddDays(-1), $"{field.Name} has an overnight report but died more than a day before it");
                        }
                    }
                }
            }
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
