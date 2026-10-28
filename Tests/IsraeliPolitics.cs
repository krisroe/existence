using Existence.Earth.Countries;
using Existence.Earth.Countries.Israel.Politics;
using Existence.Earth.Human;
using Existence.Time;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Existence.Tests
{
    /// <summary>
    /// test class
    /// </summary>
    [TestClass]
    public class IsraeliPoliticsTest
    {
        private static readonly Regex rPrimeMinisterTenure = new Regex(@"^v(\d+)$");
        private static readonly DateTime dtIndependence = new DateTime(1948, 5, 14);

        /// <summary>
        /// validates that the prime ministerial tenures, in order, form an unbroken chain from independence to the
        /// politician marked as the current prime minister. Acting and paper prime ministers are left out, and a
        /// tenure may start on the day its predecessor ended or the day after
        /// </summary>
        [TestMethod]
        public void ValidatePrimeMinistersUnbrokenChain()
        {
            List<(string Tenure, PrimeMinisterAttribute PrimeMinister)> tenures = GetPrimeMinisterTenures()
                .Where(t => t.PrimeMinister != null)
                .Select(t => (t.Tenure, t.PrimeMinister!))
                .ToList();
            Assert.IsTrue(tenures.Count > 0, "no prime minister tenures found");
            Assert.AreEqual(dtIndependence, ToDateTime(tenures[0].PrimeMinister.StartDate), $"{tenures[0].Tenure} does not start at independence");
            for (int i = 1; i < tenures.Count; i++)
            {
                var previous = tenures[i - 1];
                var current = tenures[i];
                Assert.IsNotNull(previous.PrimeMinister.EndDate, $"{previous.Tenure} has no end date but is not the last tenure");
                DateTime dtPreviousEnd = ToDateTime(previous.PrimeMinister.EndDate);
                DateTime dtCurrentStart = ToDateTime(current.PrimeMinister.StartDate);
                Assert.IsTrue(dtCurrentStart >= ToDateTime(previous.PrimeMinister.StartDate), $"{current.Tenure} starts before {previous.Tenure}");
                Assert.IsTrue(dtCurrentStart <= dtPreviousEnd.AddDays(1), $"gap between {previous.Tenure} ending {dtPreviousEnd:yyyy-MM-dd} and {current.Tenure} starting {dtCurrentStart:yyyy-MM-dd}");
            }
            var last = tenures[tenures.Count - 1];
            Assert.IsNull(last.PrimeMinister.EndDate, $"the last tenure, {last.Tenure}, has an end date");

            List<FieldInfo> currentPrimeMinisters = typeof(Politicians).GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.GetCustomAttribute<CurrentPrimeMinisterAttribute>() != null)
                .ToList();
            Assert.AreEqual(1, currentPrimeMinisters.Count, "exactly one politician must be marked as the current prime minister");
            Assert.AreEqual(currentPrimeMinisters[0].Name, Enum.GetName(typeof(Politicians), last.PrimeMinister.Politician), $"the last tenure, {last.Tenure}, is not held by the current prime minister");
        }

        /// <summary>
        /// validates that no two prime ministerial tenures overlap, once the acting and paper periods at the start or
        /// end of each tenure are trimmed off. Tenures may share a handover day
        /// </summary>
        [TestMethod]
        public void ValidatePrimeMinistersDoNotOverlap()
        {
            List<(string Tenure, DateTime Start, DateTime End)> periods = new List<(string, DateTime, DateTime)>();
            foreach (var t in GetPrimeMinisterTenures())
            {
                if (t.PrimeMinister == null) continue;
                DateTime dtStart = ToDateTime(t.PrimeMinister.StartDate);
                DateTime dtEnd = t.PrimeMinister.EndDate == null ? DateTime.MaxValue : ToDateTime(t.PrimeMinister.EndDate);
                foreach (PrimeMinisterAttribute partial in t.PartialPrimeMinisters)
                {
                    DateTime dtPartialStart = ToDateTime(partial.StartDate);
                    DateTime dtPartialEnd = ToDateTime(partial.EndDate);
                    if (dtPartialStart == dtStart) dtStart = dtPartialEnd;
                    else if (dtPartialEnd == dtEnd) dtEnd = dtPartialStart;
                    else Assert.Fail($"{t.Tenure} has a {partial.GetType().Name} period that is not at the start or end of its tenure");
                }
                periods.Add((t.Tenure, dtStart, dtEnd));
            }
            Assert.IsTrue(periods.Count > 0, "no prime minister tenures found");
            periods = periods.OrderBy(p => p.Start).ToList();
            for (int i = 1; i < periods.Count; i++)
            {
                var previous = periods[i - 1];
                var current = periods[i];
                Assert.IsTrue(current.Start >= previous.End, $"{previous.Tenure} (to {previous.End:yyyy-MM-dd}) overlaps {current.Tenure} (from {current.Start:yyyy-MM-dd})");
            }
        }

        /// <summary>
        /// validates that the seats won by the 25th Knesset's political parties add up to the number of members of the
        /// Knesset
        /// </summary>
        [TestMethod]
        public void ValidateKnessetV25SeatsByPoliticalParty()
        {
            int iSeats = GetPoliticalPartyFields().Sum(f => GetNumberOfSeats(f));
            Assert.AreEqual(GetKnessetV25NumberOfMembers(), iSeats);
        }

        /// <summary>
        /// validates that the seats add up to the number of members of the 25th Knesset when the parties on joint lists
        /// are counted through their joint lists instead, and that each joint list's seats equal the seats of the
        /// parties or factions on it
        /// </summary>
        [TestMethod]
        public void ValidateKnessetV25SeatsByJointList()
        {
            int iSeats = GetPoliticalPartyFields()
                .Where(f => f.GetCustomAttribute<JointListAttribute>() == null)
                .Sum(f => GetNumberOfSeats(f));
            foreach (FieldInfo jointList in typeof(Knesset.v25.JointLists).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                JointListNumberOfSeatsAttribute? jointListSeats = jointList.GetCustomAttribute<JointListNumberOfSeatsAttribute>();
                Assert.IsNotNull(jointListSeats, $"JointLists.{jointList.Name} has no JointListNumberOfSeats attribute");
                iSeats += jointListSeats.NumberOfSeats;

                FactionsAttribute? factions = jointList.GetCustomAttribute<FactionsAttribute>();
                int iMemberSeats = factions != null
                    ? factions.Factions.Sum(i => GetNumberOfSeats(GetEnumField(typeof(Knesset.v25.Factions), i)))
                    : jointList.GetCustomAttributes<PoliticalPartiesAttribute>().SelectMany(a => a.PoliticalParties).Sum(i => GetNumberOfSeats(GetEnumField(typeof(Knesset.v25.PoliticalParties), i)));
                Assert.AreEqual(jointListSeats.NumberOfSeats, iMemberSeats, $"JointLists.{jointList.Name} seats do not match the seats of the parties or factions on it");
            }
            Assert.AreEqual(GetKnessetV25NumberOfMembers(), iSeats);
        }

        /// <summary>
        /// validates that the seats add up to the number of members of the 25th Knesset when the parties split into
        /// factions are counted through their factions instead, and that each such party's seats equal the seats of its
        /// factions
        /// </summary>
        [TestMethod]
        public void ValidateKnessetV25SeatsByFaction()
        {
            int iSeats = 0;
            foreach (FieldInfo politicalParty in GetPoliticalPartyFields())
            {
                FactionsAttribute? factions = politicalParty.GetCustomAttribute<FactionsAttribute>();
                if (factions == null)
                {
                    iSeats += GetNumberOfSeats(politicalParty);
                    continue;
                }
                int iFactionSeats = factions.Factions.Sum(i => GetNumberOfSeats(GetEnumField(typeof(Knesset.v25.Factions), i)));
                Assert.AreEqual(GetNumberOfSeats(politicalParty), iFactionSeats, $"PoliticalParties.{politicalParty.Name} seats do not match the seats of its factions");
                iSeats += iFactionSeats;
            }
            Assert.AreEqual(GetKnessetV25NumberOfMembers(), iSeats);
        }

        /// <summary>
        /// validates that PoliticalPartyFranchise attributes in each Knesset point to a franchise and are only applied
        /// when the name of the party or faction doesn't match the franchise, since a matching name already implies it
        /// </summary>
        [TestMethod]
        public void ValidatePoliticalPartyFranchisesOnlyWhenNameDiffers()
        {
            int iFranchises = 0;
            foreach (Type knesset in typeof(Knesset).GetNestedTypes())
            {
                foreach (Type enumType in knesset.GetNestedTypes().Where(t => t.IsEnum))
                {
                    foreach (FieldInfo field in enumType.GetFields(BindingFlags.Public | BindingFlags.Static))
                    {
                        PoliticalPartyFranchiseAttribute? franchise = field.GetCustomAttribute<PoliticalPartyFranchiseAttribute>();
                        if (franchise == null) continue;
                        iFranchises++;
                        string sField = $"Knesset.{knesset.Name}.{enumType.Name}.{field.Name}";
                        string? sFranchise = Enum.GetName(typeof(PoliticalPartyFranchises), franchise.PoliticalPartyFranchise);
                        Assert.IsNotNull(sFranchise, $"{sField} has PoliticalPartyFranchise {franchise.PoliticalPartyFranchise}, which is not a value of PoliticalPartyFranchises");
                        Assert.AreNotEqual(sFranchise, field.Name, $"{sField} has a PoliticalPartyFranchise attribute that matches its name");
                    }
                }
            }
            Assert.IsTrue(iFranchises > 0, "no PoliticalPartyFranchise attributes found");
        }

        /// <summary>
        /// gets the prime ministerial tenures in numeric order, with each tenure's full PrimeMinister attribute (null when
        /// the tenure only has acting or paper prime ministers) and its acting and paper prime minister attributes
        /// </summary>
        private static List<(string Tenure, PrimeMinisterAttribute? PrimeMinister, List<PrimeMinisterAttribute> PartialPrimeMinisters)> GetPrimeMinisterTenures()
        {
            var tenures = new List<(int Number, string Tenure, PrimeMinisterAttribute? PrimeMinister, List<PrimeMinisterAttribute> PartialPrimeMinisters)>();
            foreach (Type t in typeof(PrimeMinisters).GetNestedTypes())
            {
                Match m = rPrimeMinisterTenure.Match(t.Name);
                Assert.IsTrue(m.Success, $"unexpected class {t.Name} in PrimeMinisters");
                List<PrimeMinisterAttribute> attributes = t.GetCustomAttributes<PrimeMinisterAttribute>().ToList();
                List<PrimeMinisterAttribute> fullAttributes = attributes.Where(a => a.GetType() == typeof(PrimeMinisterAttribute)).ToList();
                Assert.IsTrue(fullAttributes.Count <= 1, $"{t.Name} has more than one PrimeMinister attribute");
                Assert.IsTrue(attributes.Count > 0, $"{t.Name} has no prime minister attributes");
                tenures.Add((int.Parse(m.Groups[1].Value), t.Name, fullAttributes.FirstOrDefault(), attributes.Where(a => a.GetType() != typeof(PrimeMinisterAttribute)).ToList()));
            }
            return tenures.OrderBy(t => t.Number).Select(t => (t.Tenure, t.PrimeMinister, t.PartialPrimeMinisters)).ToList();
        }

        private static DateTime ToDateTime(YearDateAttribute? date)
        {
            Assert.IsNotNull(date);
            Assert.IsTrue(date.Month.HasValue && date.Day.HasValue, $"date in {date.Year} has no month or day");
            return new DateTime(date.Year, date.Month.Value, date.Day.Value);
        }

        private static IEnumerable<FieldInfo> GetPoliticalPartyFields()
        {
            return typeof(Knesset.v25.PoliticalParties).GetFields(BindingFlags.Public | BindingFlags.Static);
        }

        private static FieldInfo GetEnumField(Type enumType, int value)
        {
            string? sName = Enum.GetName(enumType, value);
            Assert.IsNotNull(sName, $"{value} is not a value of {enumType.Name}");
            return enumType.GetField(sName)!;
        }

        private static int GetNumberOfSeats(FieldInfo field)
        {
            NumberOfSeatsAttribute? seats = field.GetCustomAttribute<NumberOfSeatsAttribute>();
            Assert.IsNotNull(seats, $"{field.DeclaringType!.Name}.{field.Name} has no NumberOfSeats attribute");
            return seats.NumberOfSeats;
        }

        private static int GetKnessetV25NumberOfMembers()
        {
            NumberOfMembersAttribute? members = typeof(Knesset.v25).GetCustomAttribute<NumberOfMembersAttribute>();
            Assert.IsNotNull(members, "Knesset.v25 has no NumberOfMembers attribute");
            Assert.AreEqual(members.LowEstimate, members.HighEstimate, "Knesset.v25 must have an exact number of members");
            return (int)members.LowEstimate;
        }
    }
}
