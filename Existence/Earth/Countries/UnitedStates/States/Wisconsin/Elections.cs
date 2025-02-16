using Existence.Earth.Alphabet;
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates.States.Wisconsin
{
    internal class Elections
    {
        /// <summary>
        /// nonpartisan elections for 10 year terms
        /// </summary>
        public static class StateSupremeCourt
        {
            /// <summary>
            /// Ann Walsh Bradley (incumbent) 471,866 58.02%
            /// James P. Daley                340,632 41.89%
            /// Write-in                          702  0.09%
            /// </summary>
            [YearDate(2015, 4, 7)]
            public static class v2015 { }

            /// <summary>
            /// Rebecca Bradley (incumbent)  1,024,892 52.35%
            /// JoAnne Kloppenbert             929,377 47.47%
            /// Write-in                         3,678  0.19%
            /// </summary>
            [YearDate(2016, 4, 5)]
            public static class v2016 { }

            /// <summary>
            /// Annette Ziegler (incumbent)    492,352 97.20%
            /// Write-in                        14,165  2.80%
            /// </summary>
            [YearDate(2017, 4, 4)]
            public static class v2017 { }

            /// <summary>
            /// Rebecca Dallet                 555,848 55.72%
            /// Michael Screnock               440,808 44.19%
            /// Write-in                           829  0.08%
            /// </summary>
            [YearDate(2018, 4, 3)]
            public static class v2018 { }

            /// <summary>
            /// Brian Hagedorn                 606,414 50.22%
            /// Lisa Neubauer                  600,433 49.72%
            /// Write-in                           722  0.06%
            /// </summary>
            [YearDate(2019, 4, 2)]
            public static class v2019 { }

            /// <summary>
            /// Jill Karofsky                  855,573 55.21%
            /// Daniel Kelly                   693,134 44.73%
            /// Write-in                           990  0.06%
            /// </summary>
            [YearDate(2020, 4, 7)]
            public static class v2020 { }

            /// <summary>
            /// Janet Protasiewicz           1,021,822 55.43%
            /// Daniel Kelly                   818,391 44.39%
            /// Write-in                         3,267  0.18%
            /// </summary>
            [YearDate(2023, 4, 4)]
            public static class v2023 { }

            /// <summary>
            /// PENDING
            /// Brad Schimel
            /// Susan Crawford
            /// </summary>
            [TODO("Future Election")]
            public static class v2025 { }
        }

        public static class StateLegislature
        {
            public static class v2022
            {
                /// <summary>
                /// Republican: 64 (+3) (not quite a 2/3 supermajority)
                /// Democratic: 35 (-3)
                /// </summary>
                public static class Assembly { }

                /// <summary>
                /// Republican: 12 (+1) Total: 22 (2/3 supermajority)
                /// Democratic:  5 (-1)        11
                /// </summary>
                public static class Senate { }
            }

            /// <summary>
            /// first election after State Supreme Court ordered maps redrawn for continuousness
            /// </summary>
            public static class v2024
            {
                /// <summary>
                /// Republican: 54 (-10)
                /// Democratic: 45 (+10)
                /// </summary>
                public static class Assembly { }

                /// <summary>
                /// Republican:  6 (-4) Total: 18 (lost 2/3 supermajority)
                /// Democratic: 10 (+4)        15
                /// </summary>
                public static class Senate { }
            }
        }
    }
}
