using Existence.Earth.FieldsOfStudy.Mathematics;
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
