using Existence.Earth.Countries;
using Existence.Earth.Countries.NewZealand;
using Existence.Earth.Human;
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
    public class NewZealandPoliticsTest
    {
        /// <summary>
        /// validates that each party class in each parliament points to the one PoliticalParties entry of the same name,
        /// so a party can't be listed twice or point to another party
        /// </summary>
        [TestMethod]
        public void ValidatePartiesPointToPoliticalPartyOfSameName()
        {
            foreach (Type party in GetParliaments().SelectMany(GetParties))
            {
                int[] politicalParties = party.GetCustomAttributes<PoliticalPartiesAttribute>().SelectMany(a => a.PoliticalParties).ToArray();
                Assert.AreEqual(1, politicalParties.Length, $"{party.FullName} must point to one political party");
                Assert.AreEqual(party.Name, Enum.GetName(typeof(PoliticalParties), politicalParties[0]), $"{party.FullName} points to another political party");
            }
        }

        /// <summary>
        /// validates that every political party ran a party list in at least one parliament's election, and that each
        /// parliament has parties
        /// </summary>
        [TestMethod]
        public void ValidateEveryPoliticalPartyRan()
        {
            Assert.IsTrue(GetParliaments().Count > 0, "no parliaments found");
            foreach (Type parliament in GetParliaments()) Assert.IsTrue(GetParties(parliament).Count > 0, $"{parliament.Name} has no parties");
            HashSet<string> ran = GetParliaments().SelectMany(GetParties).Select(p => p.Name).ToHashSet();
            foreach (string sPoliticalParty in Enum.GetNames(typeof(PoliticalParties))) Assert.IsTrue(ran.Contains(sPoliticalParty), $"{sPoliticalParty} ran in no parliament's election");
        }

        /// <summary>
        /// validates that in each parliament with results, each party with seats has proportional and electorate seats
        /// adding up to its seats, and that all the seats add up to the number of members. Parties that fell below the
        /// electoral threshold need no seat attributes, since that already means they won none
        /// </summary>
        [TestMethod]
        public void ValidateSeatsAddUp()
        {
            int iParliaments = 0;
            foreach (Type parliament in GetParliaments())
            {
                NumberOfMembersAttribute? members = parliament.GetCustomAttribute<NumberOfMembersAttribute>();
                if (members == null) continue; //no results yet
                iParliaments++;
                int iSeats = 0;
                foreach (Type party in GetParties(parliament))
                {
                    NumberOfSeatsAttribute? seats = party.GetCustomAttribute<NumberOfSeatsAttribute>();
                    NumberOfProportionalSeatsAttribute? proportional = party.GetCustomAttribute<NumberOfProportionalSeatsAttribute>();
                    NumberOfElectorateSeatsAttribute? electorate = party.GetCustomAttribute<NumberOfElectorateSeatsAttribute>();
                    if (party.GetCustomAttribute<BelowElectoralThresholdAttribute>() != null)
                    {
                        Assert.IsTrue(seats == null && proportional == null && electorate == null, $"{party.FullName} is below the electoral threshold but has seat attributes");
                        continue;
                    }
                    Assert.IsNotNull(seats, $"{party.FullName} has no NumberOfSeats attribute");
                    Assert.IsNotNull(proportional, $"{party.FullName} has no NumberOfProportionalSeats attribute");
                    Assert.IsNotNull(electorate, $"{party.FullName} has no NumberOfElectorateSeats attribute");
                    Assert.AreEqual(seats.NumberOfSeats, proportional.NumberOfSeats + electorate.NumberOfSeats, $"{party.FullName} seats are not its proportional seats plus its electorate seats");
                    iSeats += seats.NumberOfSeats;
                }
                Assert.AreEqual(members.LowEstimate, iSeats, $"seats for {parliament.Name} do not add up to its number of members");
            }
            Assert.IsTrue(iParliaments > 0, "no parliaments with results found");
        }

        /// <summary>
        /// validates that in each parliament with results, only parties with a share of the vote under the electoral
        /// threshold are marked as below it, and that the vote percentages come close to 100. They can fall a little short
        /// because they are truncated
        /// </summary>
        [TestMethod]
        public void ValidateVotePercentages()
        {
            foreach (Type parliament in GetParliaments().Where(p => p.GetCustomAttribute<NumberOfMembersAttribute>() != null))
            {
                decimal dThreshold = parliament.GetCustomAttribute<ParliamentaryElectoralThresholdAttribute>()!.Percentage;
                decimal dTotal = 0;
                foreach (Type party in GetParties(parliament))
                {
                    VotePercentageAttribute? percentage = party.GetCustomAttribute<VotePercentageAttribute>();
                    Assert.IsNotNull(percentage, $"{party.FullName} has no VotePercentage attribute");
                    dTotal += percentage.Percentage;
                    if (party.GetCustomAttribute<BelowElectoralThresholdAttribute>() != null)
                        Assert.IsTrue(percentage.Percentage < dThreshold, $"{party.FullName} is marked below the electoral threshold but has {percentage.Percentage}%");
                }
                Assert.IsTrue(dTotal >= 99m && dTotal <= 100m, $"vote percentages for {parliament.Name} add up to {dTotal}");
            }
        }

        private static List<Type> GetParliaments()
        {
            return typeof(Parliament).GetNestedTypes().ToList();
        }

        private static List<Type> GetParties(Type parliament)
        {
            Type? parties = parliament.GetNestedType("Parties");
            Assert.IsNotNull(parties, $"{parliament.Name} has no Parties class");
            return parties.GetNestedTypes().ToList();
        }
    }
}
