using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.EthnicGroups.Jewish;
using Existence.Earth.Human.EthnicGroups.Jewish.Historical;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Existence.Tests
{
    /// <summary>
    /// test class
    /// </summary>
    [TestClass]
    public class EthnicGroupsTest
    {
        private static readonly Regex rJewishEthnicDivisions = new Regex(@"^JewishEthnicDivisionsLevel(\d+)$");

        /// <summary>
        /// validates that every OriginatedFrom attribute in the JewishEthnicDivisionsLevel(N) enums specifies its
        /// HierarchyItemOriginTypes value explicitly, instead of using the constructor that defaults it to Main
        /// </summary>
        [TestMethod]
        public void ValidateJewishEthnicOriginTypesAreExplicit()
        {
            int iOriginatedFromCount = 0;
            foreach (Type t in GetJewishEthnicDivisionEnums())
            {
                foreach (FieldInfo field in t.GetFields(BindingFlags.Public | BindingFlags.Static))
                {
                    foreach (CustomAttributeData attributeData in field.GetCustomAttributesData())
                    {
                        if (attributeData.AttributeType != typeof(OriginatedFromAttribute)) continue;
                        iOriginatedFromCount++;
                        Assert.AreEqual(2, attributeData.ConstructorArguments.Count, $"{t.Name}.{field.Name} has an OriginatedFrom attribute that does not specify a HierarchyItemOriginTypes value");
                    }
                }
            }
            Assert.IsTrue(iOriginatedFromCount > 0, "no OriginatedFrom attributes found in the JewishEthnicDivisionsLevel(N) enums");
        }

        /// <summary>
        /// validates that every value in the JewishEthnicDivisionsLevel(N) enums below level 1 has exactly one attribute
        /// that either points to a higher level subdivision or marks it as independent
        /// </summary>
        [TestMethod]
        public void ValidateJewishEthnicDivisionsHaveHigherLevelOrIndependent()
        {
            Type[] parentAttributeTypes = new Type[]
            {
                typeof(IndependentJewishSubdivisionAttribute),
                typeof(HigherLevelJewishSubdivisionLevel1Attribute),
                typeof(HigherLevelJewishSubdivisionsLevel1Attribute),
                typeof(HigherLevelJewishSubdivisionLevel2Attribute),
                typeof(HigherLevelJewishSubdivisionLevel3Attribute),
            };
            int iCheckedCount = 0;
            foreach (Type t in GetJewishEthnicDivisionEnums())
            {
                int iLevel = int.Parse(rJewishEthnicDivisions.Match(t.Name).Groups[1].Value);
                if (iLevel == 1) continue;
                foreach (FieldInfo field in t.GetFields(BindingFlags.Public | BindingFlags.Static))
                {
                    iCheckedCount++;
                    int iParentAttributeCount = parentAttributeTypes.Sum(attributeType => field.GetCustomAttributes(attributeType, false).Length);
                    Assert.AreEqual(1, iParentAttributeCount, $"{t.Name}.{field.Name} must have exactly one IndependentJewishSubdivision or HigherLevelJewishSubdivision attribute, but has {iParentAttributeCount}");
                }
            }
            Assert.IsTrue(iCheckedCount > 0, "no values found in the JewishEthnicDivisionsLevel(N) enums below level 1");
        }

        /// <summary>
        /// validates that the Total attribute on each JewishEthnicDivisionsLevel(N) enum and on JewishEthnicDivisionsHistorical
        /// matches the number of values in that enum, and that the Total attribute on JewishEthnicDivisionsTotal matches the
        /// number of values across all of them
        /// </summary>
        [TestMethod]
        public void ValidateJewishEthnicDivisionTotals()
        {
            Type[] enumTypes = GetJewishEthnicDivisionEnums().Append(typeof(JewishEthnicDivisionsHistorical)).ToArray();
            int iAllValuesCount = 0;
            foreach (Type t in enumTypes)
            {
                int iValueCount = Enum.GetValues(t).Length;
                iAllValuesCount += iValueCount;
                TotalAttribute? totalAttribute = t.GetCustomAttribute<TotalAttribute>();
                Assert.IsNotNull(totalAttribute, $"{t.Name} has no Total attribute");
                Assert.AreEqual(totalAttribute.Number, iValueCount, $"Total attribute on {t.Name} does not match the number of {t.Name} values");
            }
            TotalAttribute? overallTotalAttribute = typeof(JewishEthnicDivisionsTotal).GetCustomAttribute<TotalAttribute>();
            Assert.IsNotNull(overallTotalAttribute, "JewishEthnicDivisionsTotal has no Total attribute");
            Assert.AreEqual(overallTotalAttribute.Number, iAllValuesCount, "Total attribute on JewishEthnicDivisionsTotal does not match the number of values across all Jewish ethnic division enums");
        }

        /// <summary>
        /// gets the JewishEthnicDivisionsLevel(N) enums
        /// </summary>
        /// <returns>the JewishEthnicDivisionsLevel(N) enum types</returns>
        private static Type[] GetJewishEthnicDivisionEnums()
        {
            Type[] enumTypes = typeof(OriginatedFromAttribute).Assembly.GetTypes().Where(t => t.IsEnum && rJewishEthnicDivisions.IsMatch(t.Name)).ToArray();
            Assert.IsTrue(enumTypes.Length > 0, "no JewishEthnicDivisionsLevel(N) enums found");
            return enumTypes;
        }
    }
}
