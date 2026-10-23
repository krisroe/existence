using Existence.Earth.Countries;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.War;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Existence.Tests
{
    /// <summary>
    /// test class
    /// </summary>
    [TestClass]
    public class IsraeliHamasHostagesTest
    {
        /// <summary>
        /// validates that the Number attributes across the IsraelHamasHostages class structure
        /// add up to the number of values in the HostageList enumeration
        /// </summary>
        [TestMethod]
        public void ValidateHostagesEnumAgainstHostageOutcomes()
        {
            int iHostageCount = Enum.GetValues<HostageList>().Length;
            int iOutcomeCount = SumNumberAttributes(typeof(IsraelHamasHostages));
            Assert.AreEqual(iHostageCount, iOutcomeCount, "sum of Number attributes under IsraelHamasHostages does not match the HostageList count");
        }

        /// <summary>
        /// validates that each Total attribute in the IsraelHamasHostages class structure (e.g. on the year classes)
        /// matches the sum of the hostage outcome Number attributes beneath it
        /// </summary>
        [TestMethod]
        public void ValidateHostageOutcomeIntermediateTotals()
        {
            int iTotalsChecked = ValidateTotalAttributes(typeof(IsraelHamasHostages));
            Assert.IsTrue(iTotalsChecked > 0, "no Total attributes found under IsraelHamasHostages");
        }

        /// <summary>
        /// validates that the Total attribute on each IsraeliHamasHostageAgreement value matches the sum of the hostage outcome
        /// Number attributes under the classes marked with that agreement (an agreement may span several classes)
        /// </summary>
        [TestMethod]
        public void ValidateHostageAgreementTotals()
        {
            Dictionary<PostOctober7HostageAgreement, int> agreementCounts = new Dictionary<PostOctober7HostageAgreement, int>();
            SumAgreementOutcomes(typeof(IsraelHamasHostages), agreementCounts);
            foreach (PostOctober7HostageAgreement agreement in Enum.GetValues<PostOctober7HostageAgreement>())
            {
                TotalAttribute? total = typeof(PostOctober7HostageAgreement).GetField(agreement.ToString())!.GetCustomAttribute<TotalAttribute>();
                Assert.IsNotNull(total, $"{agreement} has no Total attribute");
                agreementCounts.TryGetValue(agreement, out int iOutcomeCount);
                Assert.AreEqual(total.Number, iOutcomeCount, $"Total attribute on {agreement} does not match the sum of the hostage outcome Number attributes for that agreement");
            }
        }

        /// <summary>
        /// validates that every hostage under the classes marked with the Thailand November 2023 agreement is a Thai national
        /// </summary>
        [TestMethod]
        public void ValidateThailandAgreementHostagesAreThai()
        {
            List<HostageList> hostages = new List<HostageList>();
            CollectAgreementHostages(typeof(IsraelHamasHostages), PostOctober7HostageAgreement.November2023HostageReleaseAgreementThailand, hostages);
            Assert.IsTrue(hostages.Count > 0, "no hostages found under the November2023HostageReleaseAgreementThailand classes");
            foreach (HostageList hostage in hostages)
            {
                Assert.IsTrue(GetHostageCountries(hostage).Contains(CountryLikeThings.Thailand), $"{hostage} is listed under the November2023HostageReleaseAgreementThailand classes but is not Thai");
            }
        }

        /// <summary>
        /// recursively collects the hostages listed under classes marked with a given agreement
        /// </summary>
        /// <param name="t">type whose nested types are searched</param>
        /// <param name="agreement">agreement to collect hostages for</param>
        /// <param name="hostages">collected hostages</param>
        private static void CollectAgreementHostages(Type t, PostOctober7HostageAgreement agreement, List<HostageList> hostages)
        {
            foreach (Type tNested in t.GetNestedTypes(BindingFlags.Public))
            {
                IsraeliHamasHostageAgreementAttribute? agreementAttribute = tNested.GetCustomAttribute<IsraeliHamasHostageAgreementAttribute>(false);
                if (agreementAttribute == null)
                {
                    CollectAgreementHostages(tNested, agreement, hostages);
                }
                else if (agreementAttribute.Agreement == agreement)
                {
                    CollectHostages(tNested, hostages);
                }
            }
        }

        /// <summary>
        /// recursively collects the hostages listed in Hostages attributes on the nested types of a type
        /// </summary>
        /// <param name="t">type whose nested types are searched</param>
        /// <param name="hostages">collected hostages</param>
        private static void CollectHostages(Type t, List<HostageList> hostages)
        {
            foreach (Type tNested in t.GetNestedTypes(BindingFlags.Public))
            {
                HostagesAttribute? hostagesAttribute = tNested.GetCustomAttribute<HostagesAttribute>(false);
                if (hostagesAttribute != null)
                {
                    hostages.AddRange(hostagesAttribute.Hostages);
                }
                CollectHostages(tNested, hostages);
            }
        }

        /// <summary>
        /// gets the countries of a hostage from the Country and Countries attributes on the HostageList value
        /// </summary>
        /// <param name="hostage">hostage</param>
        /// <returns>countries of the hostage</returns>
        private static HashSet<CountryLikeThings> GetHostageCountries(HostageList hostage)
        {
            FieldInfo field = typeof(HostageList).GetField(hostage.ToString())!;
            HashSet<CountryLikeThings> countries = new HashSet<CountryLikeThings>();
            foreach (CountryAttribute country in field.GetCustomAttributes<CountryAttribute>())
            {
                countries.Add(country.Country);
            }
            foreach (CountriesAttribute countriesAttribute in field.GetCustomAttributes<CountriesAttribute>())
            {
                countries.UnionWith(countriesAttribute.Countries);
            }
            return countries;
        }

        /// <summary>
        /// recursively sums the hostage outcome Number attributes under classes marked with an IsraeliHamasHostageAgreement attribute
        /// </summary>
        /// <param name="t">type whose nested types are searched</param>
        /// <param name="agreementCounts">running sum of outcome Number attributes per agreement</param>
        private static void SumAgreementOutcomes(Type t, Dictionary<PostOctober7HostageAgreement, int> agreementCounts)
        {
            foreach (Type tNested in t.GetNestedTypes(BindingFlags.Public))
            {
                IsraeliHamasHostageAgreementAttribute? agreement = tNested.GetCustomAttribute<IsraeliHamasHostageAgreementAttribute>(false);
                if (agreement != null)
                {
                    agreementCounts.TryGetValue(agreement.Agreement, out int iCount);
                    agreementCounts[agreement.Agreement] = iCount + SumNumberAttributes(tNested);
                }
                else
                {
                    SumAgreementOutcomes(tNested, agreementCounts);
                }
            }
        }

        /// <summary>
        /// recursively validates the Total attributes on the nested types of a type
        /// </summary>
        /// <param name="t">type whose nested types are validated</param>
        /// <returns>number of Total attributes validated</returns>
        private static int ValidateTotalAttributes(Type t)
        {
            int iTotalsChecked = 0;
            foreach (Type tNested in t.GetNestedTypes(BindingFlags.Public))
            {
                TotalAttribute? total = tNested.GetCustomAttribute<TotalAttribute>(false);
                if (total != null)
                {
                    Assert.AreEqual(total.Number, SumNumberAttributes(tNested), $"Total attribute on {tNested.FullName} does not match the sum of the hostage outcome Number attributes beneath it");
                    iTotalsChecked++;
                }
                iTotalsChecked += ValidateTotalAttributes(tNested);
            }
            return iTotalsChecked;
        }

        /// <summary>
        /// recursively sums the Number attributes on the nested types of a type (years, events, sub-events),
        /// counting only types that also have a HostageOutcome attribute
        /// </summary>
        /// <param name="t">type whose nested types are summed</param>
        /// <returns>sum of Number attributes</returns>
        private static int SumNumberAttributes(Type t)
        {
            int iCount = 0;
            foreach (Type tNested in t.GetNestedTypes(BindingFlags.Public))
            {
                if (tNested.IsDefined(typeof(HostageOutcomeAttribute), false))
                {
                    foreach (NumberAttribute n in tNested.GetCustomAttributes<NumberAttribute>(false))
                    {
                        if (n.GetType() == typeof(NumberAttribute)) //exclude derived attributes like Age
                        {
                            iCount += n.Number;
                        }
                    }
                }
                iCount += SumNumberAttributes(tNested);
            }
            return iCount;
        }
    }
}
