using Existence.Earth.War;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace Existence.Tests
{
    /// <summary>
    /// test class
    /// </summary>
    [TestClass]
    public class HamasMilitaryUnitsTest
    {
        /// <summary>
        /// validates that every battalion has a brigade attribute naming a regional brigade
        /// </summary>
        [TestMethod]
        public void ValidateBattalionBrigades()
        {
            foreach (HamasMilitaryBattalion battalion in Enum.GetValues<HamasMilitaryBattalion>())
            {
                HamasMilitaryBrigade? brigade = GetBrigade(battalion);
                Assert.IsNotNull(brigade, $"{battalion} has no {nameof(HamasMilitaryBrigadeAttribute)}");
                Assert.AreNotEqual(HamasMilitaryBrigade.AlQassam, brigade, $"{battalion} belongs to {nameof(HamasMilitaryBrigade.AlQassam)} rather than a regional brigade");
            }
        }

        /// <summary>
        /// validates that every battalion commander and deputy commander attribute on the assassination targets names the brigade
        /// the battalion belongs to, and that nobody is marked as both a commander and a deputy commander
        /// </summary>
        [TestMethod]
        public void ValidateCommanderUnits()
        {
            foreach (FieldInfo field in typeof(IsraeliAssassinationTarget).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                bool isCommander = false;
                bool isDeputy = false;
                foreach (HamasMilitaryCommanderAttribute commander in field.GetCustomAttributes<HamasMilitaryCommanderAttribute>())
                {
                    string role = commander.IsDeputy ? "is deputy commander of" : "commands";
                    if (commander.Battalion.HasValue)
                    {
                        Assert.AreEqual(GetBrigade(commander.Battalion.Value), commander.Brigade, $"{field.Name} {role} {commander.Battalion.Value}, which is not in the {commander.Brigade} brigade");
                    }
                    isCommander |= !commander.IsDeputy;
                    isDeputy |= commander.IsDeputy;
                }
                Assert.IsFalse(isCommander && isDeputy, $"{field.Name} is marked as both a commander and a deputy commander");
            }
        }

        /// <summary>
        /// gets the brigade a battalion belongs to
        /// </summary>
        /// <param name="battalion">the battalion</param>
        /// <returns>the brigade, or null if the battalion has no brigade attribute</returns>
        private static HamasMilitaryBrigade? GetBrigade(HamasMilitaryBattalion battalion)
        {
            return typeof(HamasMilitaryBattalion).GetField(battalion.ToString())!.GetCustomAttribute<HamasMilitaryBrigadeAttribute>()?.Brigade;
        }
    }
}
