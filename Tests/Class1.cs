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
            try
            {
                Existence.Logic.Random.Logic.DoFisherYatesKnuthRandomizer(nullList, r, Existence.Logic.Random.Logic.RandomType.Global, Existence.Logic.Random.Logic.LinqHandling.None);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException)
                    Assert.IsTrue(true);
                else
                    Assert.Fail();
            }
            Assert.Fail();
        }

        [TestMethod]
        public void DoFisherYatesKnuthRandomizer_ListWithSingleElement_ReturnsSameList()
        {
            List<int> list = new List<int> { 42 };
            Random? r = null;
            var result = Existence.Logic.Random.Logic.DoFisherYatesKnuthRandomizer(list, r, Existence.Logic.Random.Logic.RandomType.Global, Existence.Logic.Random.Logic.LinqHandling.None);

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
            List<int> shuffled = (List<int>)Existence.Logic.Random.Logic.DoFisherYatesKnuthRandomizer(list, seededRandom, Existence.Logic.Random.Logic.RandomType.Specified, Existence.Logic.Random.Logic.LinqHandling.None);

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
            List<int> result = (List<int>)Existence.Logic.Random.Logic.DoFisherYatesKnuthRandomizer(list, seededRandom, Existence.Logic.Random.Logic.RandomType.Specified, Existence.Logic.Random.Logic.LinqHandling.ShuffleInPlace);

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
            Existence.Logic.Random.Logic.DoFisherYatesKnuthRandomizer(list, null, Existence.Logic.Random.Logic.RandomType.Specified, Existence.Logic.Random.Logic.LinqHandling.None);
        }

        // You can add additional tests to cover:
        // - Using RandomType.Global, RandomType.RandomShared, RandomType.New, and RandomType.ThreadLocalRandomNew.
        // - Using LinqHandling.Linq.
    }
}