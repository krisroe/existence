using Existence.Earth.FieldsOfStudy.Mathematics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Existence.Tests
{
    /// <summary>
    /// test class
    /// </summary>
    [TestClass]
    public class SimpleFractionTest
    {
        /// <summary>
        /// validates converting decimals to fractions exactly
        /// </summary>
        [TestMethod]
        public void ValidateSimpleFractionFromDecimal()
        {
            Assert.AreEqual("325/100", SimpleFraction.FromDecimal(3.25m).ToString());
            Assert.AreEqual("5/1", SimpleFraction.FromDecimal(5m).ToString());
            Assert.AreEqual("50/10", SimpleFraction.FromDecimal(5.0m).ToString());
        }

        /// <summary>
        /// validates reducing fractions to lowest terms with a positive denominator
        /// </summary>
        [TestMethod]
        public void ValidateSimpleFractionReduce()
        {
            Assert.AreEqual("3/1", new SimpleFraction(15, 5).Reduce().ToString());
            Assert.AreEqual("7/5", new SimpleFraction(7, 5).Reduce().ToString());
            Assert.AreEqual("-1/2", new SimpleFraction(2, -4).Reduce().ToString());
            Assert.AreEqual("1/2", new SimpleFraction(-2, -4).Reduce().ToString());
            Assert.AreEqual("0/1", new SimpleFraction(0, -7).Reduce().ToString());
        }

        /// <summary>
        /// validates comparing fractions by value, including unreduced and negative denominators
        /// </summary>
        [TestMethod]
        public void ValidateSimpleFractionComparison()
        {
            Assert.AreEqual(0, new SimpleFraction(14, 10).CompareTo(new SimpleFraction(7, 5)));
            Assert.IsTrue(new SimpleFraction(6, 5) < new SimpleFraction(7, 5));
            Assert.IsTrue(new SimpleFraction(7, 5) > new SimpleFraction(6, 5));
            Assert.IsTrue(new SimpleFraction(325, 100) >= new SimpleFraction(13, 4));
            Assert.IsTrue(new SimpleFraction(325, 100) <= new SimpleFraction(13, 4));
            Assert.IsTrue(new SimpleFraction(1, -2) < new SimpleFraction(1, 3));
            Assert.IsTrue(new SimpleFraction(-1, -2) > new SimpleFraction(1, 3));
            Assert.IsTrue(new SimpleFraction(1, -2) < new SimpleFraction(-1, 3));
            Assert.IsTrue(new SimpleFraction(0, 1) > null);
            Assert.ThrowsException<OverflowException>(() => new SimpleFraction(long.MaxValue, 1).CompareTo(new SimpleFraction(1, 2)));
        }
    }
}
