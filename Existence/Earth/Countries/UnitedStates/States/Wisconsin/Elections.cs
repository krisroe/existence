using Existence.Beyond.Infrastructure;
using Existence.Earth.Alphabet;
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates.States.Wisconsin.Elections
{
    public static class Constants
    {
        public const string ITS_TIME_FOR_THE_GERRYMANDER_TO_COME_DOWN = "It's time for the gerrymander to come down";
    }


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
        /// Susan Crawford                1,301,137 55.02%
        /// Brad Schimel                  1,062,330 44.92%
        /// </summary>
        [YearDate(2025, 4, 1)]
        public static class v2025 { }
    }

    public static class StateLegislature
    {
        [ElectionDate(2022, 11, 8)]
        [PostElectionTakeOfficeDate(2023, 1, 3)]
        public static class v2022
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 64, 3, (int)PoliticalParties.Democratic, 35, -3, "not quite a 2/3 supermajority")]
            [TotalLegislatureSeats(99)]
            public static class Assembly { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 22, 1, (int)PoliticalParties.Democratic, 11, -1, SeatsUp: 17, "2/3 supermajority")]
            [TotalLegislatureSeats(33)]
            public static class Senate { }
        }

        /// <summary>
        /// first election after State Supreme Court ordered maps redrawn for contiguousness
        /// </summary>
        [ElectionDate(2024, 11, 5)]
        [PostElectionTakeOfficeDate(2025, 1, 6)]
        public static class v2024
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 54, -10, (int)PoliticalParties.Democratic, 45, 10)]
            [TotalLegislatureSeats(99)]
            public static class Assembly { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 18, -4, (int)PoliticalParties.Democratic, 15, 4, SeatsUp: 16, "lost 2/3 supermajority")]
            [TotalLegislatureSeats(33)]
            public static class Senate { }
        }

        [ElectionDate(2026, 11, 3)]
        [PostElectionTakeOfficeDate(2027, 1, 4)]
        public static class v2026
        {
            [IRootedFor((int)PoliticalParties.Democratic)]
            [IPredictedTwoPartyLegislativeElection((int)PoliticalParties.Democratic, 50, (int)PoliticalParties.Republican, 49, Correctness.Future, Constants.ITS_TIME_FOR_THE_GERRYMANDER_TO_COME_DOWN)]
            [UpcomingTwoPartyLegislativeElection((int)PoliticalParties.Republican, 54, (int)PoliticalParties.Democratic, 45, SeatsUp: 99)]
            [TotalLegislatureSeats(99)]
            public static class Assembly { }

            [IRootedFor((int)PoliticalParties.Democratic)]
            [IPredictedTwoPartyLegislativeElection((int)PoliticalParties.Democratic, 18, (int)PoliticalParties.Republican, 15, Correctness.Future, Constants.ITS_TIME_FOR_THE_GERRYMANDER_TO_COME_DOWN)]
            [UpcomingTwoPartyLegislativeElection((int)PoliticalParties.Republican, 18, (int)PoliticalParties.Democratic, 15, SeatsUp: 17)]
            [TotalLegislatureSeats(33)]
            public static class Senate { }
        }
    }

    public static class Governor
    {
        [YearDate(1986, 11, 4)]
        [Incumbent((int)WisconsinPoliticians.EarlTony)]
        [HeadToHeadElectionResult((int)WisconsinPoliticians.ThompsonTommy, 52.73, (int)WisconsinPoliticians.EarlTony, 46.21)]
        public static class v1986 { }

        [YearDate(1990, 11, 6)]
        [Incumbent((int)WisconsinPoliticians.ThompsonTommy)]
        [HeadToHeadElectionResult((int)WisconsinPoliticians.ThompsonTommy, 58.15, (int)WisconsinPoliticians.LoftusTom, 41.77)]
        public static class v1990 { }

        [YearDate(1994, 11, 8)]
        [Incumbent((int)WisconsinPoliticians.ThompsonTommy)]
        [HeadToHeadElectionResult((int)WisconsinPoliticians.ThompsonTommy, 67.23, (int)WisconsinPoliticians.ChvalaChuck, 30.88)]
        public static class v1994 { }

        [YearDate(1998, 11, 3)]
        [Incumbent((int)WisconsinPoliticians.ThompsonTommy)]
        [HeadToHeadElectionResult((int)WisconsinPoliticians.ThompsonTommy, 59.66, (int)WisconsinPoliticians.GarveyEd, 38.70)]
        public static class v1998 { }

        /// <summary>
        /// McCallum became governor in 2001 when Thompson resigned to become Secretary of Health and Human Services
        /// </summary>
        [YearDate(2002, 11, 5)]
        [Incumbent((int)WisconsinPoliticians.McCallumScott)]
        [HeadToHeadElectionResult((int)WisconsinPoliticians.DoyleJim, 45.09, (int)WisconsinPoliticians.McCallumScott, 41.39)]
        public static class v2002 { }

        [YearDate(2006, 11, 7)]
        [Incumbent((int)WisconsinPoliticians.DoyleJim)]
        [HeadToHeadElectionResult((int)WisconsinPoliticians.DoyleJim, 52.70, (int)WisconsinPoliticians.GreenMark, 45.31)]
        public static class v2006 { }

        /// <summary>
        /// open seat, Doyle did not seek a third term
        /// </summary>
        [YearDate(2010, 11, 2)]
        [IncumbentNotRunning((int)WisconsinPoliticians.DoyleJim, IncumbentNotRunningReason.DeclinedToRun)]
        [HeadToHeadElectionResult((int)WisconsinPoliticians.WalkerScott, 52.25, (int)WisconsinPoliticians.BarrettTom, 46.48)]
        [ElectionNightConcession((int)WisconsinPoliticians.BarrettTom)]
        public static class v2010 { }

        [YearDate(2014, 11, 4)]
        [Incumbent((int)WisconsinPoliticians.WalkerScott)]
        [HeadToHeadElectionResult((int)WisconsinPoliticians.WalkerScott, 52.26, (int)WisconsinPoliticians.BurkeMary, 46.59)]
        [ElectionNightConcession((int)WisconsinPoliticians.BurkeMary)]
        public static class v2014 { }

        /// <summary>
        /// Walker conceded in a statement the afternoon after the election, declining to seek a recount
        /// </summary>
        [YearDate(2018, 11, 6)]
        [Incumbent((int)WisconsinPoliticians.WalkerScott)]
        [HeadToHeadElectionResult((int)WisconsinPoliticians.EversTony, 49.54, (int)WisconsinPoliticians.WalkerScott, 48.44)]
        [LaterConcession((int)WisconsinPoliticians.WalkerScott, 2018, 11, 7)]
        public static class v2018 { }

        /// <summary>
        /// Michels conceded to supporters around 12:20 a.m. Central on November 9, technically the day after the
        /// election, but clearly an election night concession.
        /// </summary>
        [YearDate(2022, 11, 8)]
        [Incumbent((int)WisconsinPoliticians.EversTony)]
        [HeadToHeadElectionResult((int)WisconsinPoliticians.EversTony, 51.15, (int)WisconsinPoliticians.MichelsTim, 47.75)]
        [ElectionNightConcession((int)WisconsinPoliticians.MichelsTim)]
        public static class v2022 { }

        /// <summary>
        /// open seat, Evers did not seek a third term. Crowley narrowly beat Francesca Hong in the August 11 Democratic
        /// primary, Tiffany won the Republican primary easily
        /// </summary>
        [YearDate(2026, 11, 3)]
        [IncumbentNotRunning((int)WisconsinPoliticians.EversTony, IncumbentNotRunningReason.DeclinedToRun)]
        [HeadToHeadElectionCandidates((int)WisconsinPoliticians.CrowleyDavid, (int)WisconsinPoliticians.TiffanyTom)]
        [IVotedForPolitician((int)WisconsinPoliticians.CrowleyDavid, "This is the first time I ever voted for a Democrat in a general election")]
        [IPredictedElectionWinner((int)WisconsinPoliticians.CrowleyDavid, Correctness.Correct, "Trump's impact on the election is more powerful than the usual anti-incumbent (party) bias")]
        public static class v2026
        {
            /// <summary>
            /// <see cref="WisconsinPoliticians.TiffanyTom"/> won the Republican primary easily
            /// </summary>
            public static class Primary
            {
                [YearDate(2026, 8, 11)]
                [HeadToHeadElectionResult((int)WisconsinPoliticians.CrowleyDavid, 39.8, (int)WisconsinPoliticians.HongFrancesca, 39.3)]
                [IVotedForPolitician((int)WisconsinPoliticians.CrowleyDavid, "This is the first time I ever voted for a Democrat")]
                [IPredictedElectionWinner((int)WisconsinPoliticians.HongFrancesca, Correctness.Incorrect, "I expected undecided voters to skew toward Crowley, but Hong's lead in the polls seemed insurmountable")]
                public static class Democratic { }
            }
        }
    }
}
