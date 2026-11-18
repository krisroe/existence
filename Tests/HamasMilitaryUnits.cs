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
                PalestinianGazaMilitaryBrigade? brigade = GetBrigade(battalion);
                Assert.IsNotNull(brigade, $"{battalion} has no {nameof(PalestinianGazaMilitaryBrigadeAttribute)}");
                Assert.IsFalse(IsWholeMilitaryWing(brigade.Value), $"{battalion} belongs to {brigade.Value} rather than a regional brigade");
            }
        }

        /// <summary>
        /// validates the militant role attributes (commanders, deputy commanders and spokespeople) on the assassination targets:
        /// a whole military wing matches its faction, a battalion is a Hamas battalion in the brigade named with it,
        /// and nobody is marked as both a commander and a deputy commander
        /// </summary>
        [TestMethod]
        public void ValidateMilitantRoles()
        {
            foreach (FieldInfo field in typeof(IsraeliAssassinationTarget).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                bool isCommander = false;
                bool isDeputy = false;
                foreach (PalestinianMilitantAttribute role in field.GetCustomAttributes<PalestinianMilitantAttribute>())
                {
                    if (role.Brigade == PalestinianGazaMilitaryBrigade.AlQassam)
                    {
                        Assert.AreEqual(PalestinianMilitantGroups.Hamas, role.Faction, $"{field.Name} has {nameof(PalestinianGazaMilitaryBrigade.AlQassam)} with faction {role.Faction}");
                    }
                    if (role.Brigade == PalestinianGazaMilitaryBrigade.AlQuds)
                    {
                        Assert.AreEqual(PalestinianMilitantGroups.PalestinianIslamicJihad, role.Faction, $"{field.Name} has {nameof(PalestinianGazaMilitaryBrigade.AlQuds)} with faction {role.Faction}");
                    }
                    if (role.Battalion.HasValue)
                    {
                        Assert.AreEqual(PalestinianMilitantGroups.Hamas, role.Faction, $"{field.Name} has a {nameof(HamasMilitaryBattalion)} with faction {role.Faction}");
                        Assert.AreEqual(GetBrigade(role.Battalion.Value), role.Brigade, $"{field.Name} has {role.Battalion.Value}, which is not in the {role.Brigade} brigade");
                    }
                    if (role is PalestinianMilitantCommanderAttribute commander)
                    {
                        isCommander |= !commander.IsDeputy;
                        isDeputy |= commander.IsDeputy;
                    }
                }
                Assert.IsFalse(isCommander && isDeputy, $"{field.Name} is marked as both a commander and a deputy commander");
            }
        }

        /// <summary>
        /// gets the brigade a battalion belongs to
        /// </summary>
        /// <param name="battalion">the battalion</param>
        /// <returns>the brigade, or null if the battalion has no brigade attribute</returns>
        private static PalestinianGazaMilitaryBrigade? GetBrigade(HamasMilitaryBattalion battalion)
        {
            return typeof(HamasMilitaryBattalion).GetField(battalion.ToString())!.GetCustomAttribute<PalestinianGazaMilitaryBrigadeAttribute>()?.Brigade;
        }

        /// <summary>
        /// determines whether a brigade value stands for a whole military wing rather than a regional brigade
        /// </summary>
        /// <param name="brigade">the brigade</param>
        /// <returns>true for a whole military wing</returns>
        private static bool IsWholeMilitaryWing(PalestinianGazaMilitaryBrigade brigade)
        {
            return brigade == PalestinianGazaMilitaryBrigade.AlQassam || brigade == PalestinianGazaMilitaryBrigade.AlQuds;
        }
    }
}
