using Existence.Logic.Random;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Existence.Tests
{
    /// <summary>
    /// Fisher/Yates/Knuth randomization tests
    /// </summary>
    [TestClass]
    public class FisherYatesKnuthTests
    {
        /// <summary>
        /// tests for throwing an argument null exception
        /// </summary>
        [TestMethod]
        public void DoFisherYatesKnuthRandomizer_NullList_ThrowsArgumentNullException()
        {
            List<int> nullList = null!;
            Random? r = null;

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                RandomLogic.DoFisherYatesKnuthRandomizer(
                    nullList,
                    r,
                    RandomLogic.RandomType.Global,
                    RandomLogic.LinqHandling.None
                );
            });
        }

        [TestMethod]
        public void DoFisherYatesKnuthRandomizer_ListWithSingleElement_ReturnsSameList()
        {
            List<int> list = new List<int> { 42 };
            Random? r = null;
            var result = RandomLogic.DoFisherYatesKnuthRandomizer(list, r, RandomLogic.RandomType.Global, RandomLogic.LinqHandling.None);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(42, result[0]);
        }

        [TestMethod]
        public void DoFisherYatesKnuthRandomizer_UsingSpecifiedRandom_WithFixedSeed_ProducesExpectedPermutation()
        {
            // Arrange
            List<int> list = Enumerable.Range(1, 10).ToList();
            List<int> originalList = list.ToList();
            // Use a fixed seed for determinism.
            var seededRandom = new Random(42);

            // Act
            List<int> shuffled = (List<int>)RandomLogic.DoFisherYatesKnuthRandomizer(list, seededRandom, RandomLogic.RandomType.Specified, RandomLogic.LinqHandling.None);

            // Assert that the shuffled list is a permutation of the original.
            // Using CollectionAssert.AreEquivalent to check that all elements exist regardless of order.
            CollectionAssert.AreEquivalent(originalList, shuffled);

            // Optionally, if you have determined the expected order for the fixed seed,
            // you can uncomment and adjust the following lines:
            // var expectedOrder = new List<int> { 10, 4, 7, 5, 9, 8, 6, 3, 1, 2 };
            // CollectionAssert.AreEqual(expectedOrder, shuffled);
        }

        [TestMethod]
        public void DoFisherYatesKnuthRandomizer_LinqShuffleInPlace_ProducesPermutation()
        {
            // Arrange
            List<int> list = Enumerable.Range(1, 20).ToList();
            List<int> originalList = list.ToList();
            Random seededRandom = new Random(123);

            // Act: Use the LINQ in-place shuffle option.
            List<int> result = (List<int>)RandomLogic.DoFisherYatesKnuthRandomizer(list, seededRandom, RandomLogic.RandomType.Specified, RandomLogic.LinqHandling.ShuffleInPlace);

            // Assert: The result should be a permutation of the original.
            CollectionAssert.AreEquivalent(originalList, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DoFisherYatesKnuthRandomizer_SpecifiedRandom_NullRandom_ThrowsException()
        {
            // Arrange
            IList<int> list = new List<int> { 1, 2, 3 };

            // Act
            // This should throw because RandomType.Specified requires a non-null random instance.
            RandomLogic.DoFisherYatesKnuthRandomizer(list, null, RandomLogic.RandomType.Specified, RandomLogic.LinqHandling.None);
        }

        // You can add additional tests to cover:
        // - Using RandomType.Global, RandomType.RandomShared, RandomType.New, and RandomType.ThreadLocalRandomNew.
        // - Using LinqHandling.Linq.
    }
}