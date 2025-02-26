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
        /// test method
        /// </summary>
        [TestMethod]
        public void TestMethod()
        {
            int iCount = 0;
            Type t = typeof(IsraelHamasHostages);
            foreach (Type tYear in t.GetNestedTypes(BindingFlags.Public))
            {
                foreach (Type tEvent in tYear.GetNestedTypes(BindingFlags.Public))
                {
                    NumberAttribute n = tEvent.GetCustomAttribute<NumberAttribute>()!;
                    iCount += n.Number;
                }
            }
            Assert.AreEqual(iCount, 1234);
        }
    }
}
