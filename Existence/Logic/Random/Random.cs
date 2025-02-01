using System;
using System.Linq;

namespace Existence.Logic.Random
{
    /// <summary>
    /// random number logic
    /// </summary>
    public static class Logic
    {
        /// <summary>
        /// global random object (not thread safe)
        /// </summary>
        private static readonly System.Random GlobalRandom = new System.Random();

        /// <summary>
        /// thread-local random instance (one per thread)
        /// </summary>
        private static readonly ThreadLocal<System.Random> ThreadLocalRandomNew = new(() => new System.Random());

        /// <summary>
        /// Specifies the type of random generator to use for shuffling.
        /// </summary>
        public enum RandomType
        {
            /// <summary>
            /// Uses a global Random instance
            /// </summary>
            Global,

            /// <summary>
            /// Uses .NET 6+ Random.Shared (thread-safe)
            /// </summary>
            RandomShared,

            /// <summary>
            /// Uses the provided Random object
            /// </summary>
            Specified,

            /// <summary>
            /// Creates a new Random instance
            /// </summary>
            New,

            /// <summary>
            /// Uses ThreadLocal Random (one per thread)
            /// </summary>
            ThreadLocalRandomNew
        }

        /// <summary>
        /// how to handle linq queries
        /// </summary>
        public enum LinqHandling
        {
            /// <summary>
            /// do not use linq
            /// </summary>
            None,

            /// <summary>
            /// shuffle in place
            /// </summary>
            ShuffleInPlace,

            /// <summary>
            /// shuffle in place
            /// </summary>
            Linq,
        }

        /// <summary>
        /// Runs the Fisher-Yates (Knuth) shuffle on a list with O(n) complexity.
        /// Supports different random generators and an optional LINQ shuffle.
        ///
        /// 1. Start from the last element of the list.
        /// 2. Swap it with a random element from the list (including itself).
        /// 3. Move to the second last element and repeat.
        /// 4. Continue until you reach the first element.
        ///
        /// This ensures that each element has an equal probability of appearing in any position.
        /// </summary>
        /// <typeparam name="T">Type of object being shuffled</typeparam>
        /// <param name="list">List to shuffle</param>
        /// <param name="r">Random instance (used if RandomType.Specified is selected)</param>
        /// <param name="rt">Type of random generator to use</param>
        /// <param name="lh">specific linq handling</param>
        public static IList<T> DoFisherYatesKnuthRandomizer<T>(IList<T> list, System.Random? r, RandomType rt, LinqHandling lh)
        {
            if (list == null) throw new ArgumentNullException(nameof(list), "List cannot be null.");
            if (list.Count <= 1) return list; // Exit early for lists with 0 or 1 elements
            r = rt switch // Assign the correct random generator using a switch expression
            {
                RandomType.New => new System.Random(),
                RandomType.Global => GlobalRandom,
                RandomType.RandomShared => System.Random.Shared,
                RandomType.ThreadLocalRandomNew => ThreadLocalRandomNew.Value,
                RandomType.Specified when r != null => r,
                RandomType.Specified => throw new ArgumentNullException(nameof(r), "No random object specified."),
                _ => throw new InvalidOperationException("Invalid random type.")
            };
            if (r == null) throw new InvalidOperationException("Random instance should never be null at this point.");
            if (lh != LinqHandling.None) //use linq
            {
                if (lh == LinqHandling.ShuffleInPlace)
                {
                    try
                    {
                        var shuffled = list.OrderBy(_ => r!.Next()).ToList();
                        for (int i = 0; i < list.Count; i++) list[i] = shuffled[i];
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Unexpected error shuffling in place.", ex);
                    }
                }
                else if (list is List<T> listAsList)
                {
                    return listAsList.OrderBy(_ => r!.Next()).ToList();
                }
                else if (list.IsReadOnly)
                {
                    return list.OrderBy(_ => r!.Next()).ToList();
                }
            }
            else // In-place Fisher-Yates shuffle (O(n))
            {
                int n = list.Count;
                while (n > 1)
                {
                    n--;
                    int k = r!.Next(n + 1);
                    (list[n], list[k]) = (list[k], list[n]);
                }
            }
            return list;
        }
    }
}