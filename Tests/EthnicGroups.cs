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
        /// <summary>
        /// validates that every OriginatedFrom attribute in the JewishEthnic(Sub...)Subdivisions enums specifies its
        /// HierarchyItemOriginTypes value explicitly, instead of using the constructor that defaults it to Main
        /// </summary>
        [TestMethod]
        public void ValidateJewishEthnicOriginTypesAreExplicit()
        {
            Regex rJewishEthnicSubdivisions = new Regex("^JewishEthnic(Sub)+divisions$");
            Type[] enumTypes = typeof(OriginatedFromAttribute).Assembly.GetTypes().Where(t => t.IsEnum && rJewishEthnicSubdivisions.IsMatch(t.Name)).ToArray();
            Assert.IsTrue(enumTypes.Length > 0, "no JewishEthnic(Sub...)Subdivisions enums found");
            int iOriginatedFromCount = 0;
            foreach (Type t in enumTypes)
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
            Assert.IsTrue(iOriginatedFromCount > 0, "no OriginatedFrom attributes found in the JewishEthnic(Sub...)Subdivisions enums");
        }
    }
}
