using Existence.Earth.Human;
using Existence.Time;

namespace Existence.Earth.Countries.NewZealand
{
    public enum Politicians
    {
        AlpKelvyn,
        ApplebyMichael,
        BillotVictor,
        DavidsonMarama,
        GreySue,
        HerbertMaki,
        HipkinsChris,
        HopkinsonPaul,
        HoughtonHelen,
        KapaKingiMariameno,
        LuxonChristopher,
        McNeilRobert,
        NgarewaPackerDebbie,
        OvensJill,
        PetersWinston,
        SeymourDavid,
        ShawJames,
        SwarbrickChlöe,
        TamakiHannah,
        TrenberthDawn,
        WaititiRawiri,
        WeretaDannette,
        WongQiulae,
    }

    /// <summary>
    /// political parties that ran party lists in the 2023 and 2026 elections. New Zealand's parties are stable from one
    /// election to the next, with few of the mergers and joint lists that Israel's have, so there is one entry per party
    /// and each election's details are in <see cref="Parliament"/>
    /// </summary>
    public enum PoliticalParties
    {
        /// <summary>
        /// economic liberal party, founded in 1994
        /// </summary>
        ACT,

        /// <summary>
        /// left-wing party, founded in 1991 as a multi-party bloc. Ran no party list in 2023
        /// </summary>
        Alliance,

        AnimalJustice,

        /// <summary>
        /// the New Conservatives in 2023
        /// </summary>
        Conservative,

        DemocracyNZ,

        /// <summary>
        /// founded in 2026
        /// </summary>
        FreePalestine,

        /// <summary>
        /// 2023 umbrella list, including <see cref="NewZealandOutdoorsAndFreedom"/> and <see cref="VisionNewZealand"/>,
        /// which ran their own lists in 2026
        /// </summary>
        FreedomsNZ,

        /// <summary>
        /// environmental party, founded in 1990
        /// </summary>
        Green,

        /// <summary>
        /// main center-left party, founded in 1916
        /// </summary>
        Labour,

        LeightonBaker,

        LegaliseCannabis,

        /// <summary>
        /// main center-right party, founded in 1936
        /// </summary>
        National,

        NewNation,

        NewZeal,

        /// <summary>
        /// nationalist and populist party, founded in 1993
        /// </summary>
        NewZealandFirst,

        NewZealandLoyal,

        NewZealandOutdoorsAndFreedom,

        /// <summary>
        /// The Opportunities Party in 2023
        /// </summary>
        Opportunity,

        /// <summary>
        /// Māori rights party, founded in 2004
        /// </summary>
        TePātiMāori,

        /// <summary>
        /// founded in 2026 by <see cref="Politicians.KapaKingiMariameno"/>, the MP for the Te Tai Tokerau electorate, who
        /// left <see cref="TePātiMāori"/> on 2026-05-11. It expelled her on 2025-11-10, and she was reinstated in March
        /// 2026 after the High Court ruled the expulsion unlawful
        /// </summary>
        TeTaiTokerau,

        VisionNewZealand,

        WomensRights,
    }

    /// <summary>
    /// New Zealand's parliament, by number. Mixed-member proportional: each party's share of the party vote sets its share
    /// of the seats, starting from the electorates it won and topped up from its party list. A party qualifies for this
    /// with the percentage in ParliamentaryElectoralThreshold or by winning at least one electorate. A party keeps any
    /// electorates it won beyond its proportional share, and those overhang seats make the parliament larger than 120
    /// </summary>
    public static class Parliament
    {
        /// <summary>
        /// the only overhang was 2 seats for Te Pāti Māori, which won 6 electorates and was entitled to 4 seats. Parties
        /// without seats are below the threshold since none won an electorate. Vote percentages are as the Electoral
        /// Commission declared them on 2023-11-03, out of 2,850,527 valid party votes, and are truncated rather than
        /// rounded
        /// </summary>
        [ElectionDate(2023, 10, 14)]
        [PostElectionTakeOfficeDate(2023, 12, 5)]
        [ParliamentaryElectoralThreshold(5)]
        [NumberOfMembers(123)]
        public static class v54
        {
            /// <summary>
            /// one class per party list, each pointing to its PoliticalParties entry. The party with the most votes comes
            /// first
            /// </summary>
            public static class Parties
            {
                /// <summary>
                /// declared with 43 electorates and 48 seats, then won the Port Waikato by-election on 2023-11-25, which
                /// made the parliament 123 seats. The electorate's vote was cancelled in the general election because the
                /// ACT candidate died
                /// </summary>
                [PoliticalParties((int)PoliticalParties.National)]
                [PoliticalPartyLeader((int)Politicians.LuxonChristopher)]
                [VotePercentage(38.06)]
                [NumberOfProportionalSeats(5)]
                [NumberOfElectorateSeats(44)]
                [NumberOfSeats(49)]
                [Government]
                [InGovernmentCoalitionAtNextElection]
                [InGovernmentExecutiveAtNextElection]
                public static class National { }

                [PoliticalParties((int)PoliticalParties.Labour)]
                [PoliticalPartyLeader((int)Politicians.HipkinsChris)]
                [VotePercentage(26.91)]
                [NumberOfProportionalSeats(17)]
                [NumberOfElectorateSeats(17)]
                [NumberOfSeats(34)]
                [Opposition]
                public static class Labour { }

                [PoliticalParties((int)PoliticalParties.Green)]
                [PoliticalPartyLeader((int)Politicians.ShawJames)]
                [PoliticalPartyLeader((int)Politicians.DavidsonMarama)]
                [VotePercentage(11.60)]
                [NumberOfProportionalSeats(12)]
                [NumberOfElectorateSeats(3)]
                [NumberOfSeats(15)]
                [Opposition]
                public static class Green { }

                [PoliticalParties((int)PoliticalParties.ACT)]
                [PoliticalPartyLeader((int)Politicians.SeymourDavid)]
                [VotePercentage(8.64)]
                [NumberOfProportionalSeats(9)]
                [NumberOfElectorateSeats(2)]
                [NumberOfSeats(11)]
                [Government]
                [InGovernmentCoalitionAtNextElection]
                [InGovernmentExecutiveAtNextElection]
                public static class ACT { }

                [PoliticalParties((int)PoliticalParties.NewZealandFirst)]
                [PoliticalPartyLeader((int)Politicians.PetersWinston)]
                [VotePercentage(6.08)]
                [NumberOfProportionalSeats(8)]
                [NumberOfElectorateSeats(0)]
                [NumberOfSeats(8)]
                [Government]
                [InGovernmentCoalitionAtNextElection]
                [InGovernmentExecutiveAtNextElection]
                public static class NewZealandFirst { }

                /// <summary>
                /// below the threshold, but qualified by winning electorates. Its 6 seats were at the start of the term. By
                /// dissolution it had 4, with 2 independents who had left it
                /// </summary>
                [PoliticalParties((int)PoliticalParties.TePātiMāori)]
                [PoliticalPartyLeader((int)Politicians.NgarewaPackerDebbie)]
                [PoliticalPartyLeader((int)Politicians.WaititiRawiri)]
                [VotePercentage(3.08)]
                [NumberOfProportionalSeats(0)]
                [NumberOfElectorateSeats(6)]
                [NumberOfSeats(6)]
                [Opposition]
                public static class TePātiMāori { }

                [PoliticalParties((int)PoliticalParties.Opportunity)]
                [VotePercentage(2.22)]
                [BelowElectoralThreshold]
                public static class Opportunity { }

                [PoliticalParties((int)PoliticalParties.NewZealandLoyal)]
                [VotePercentage(1.20)]
                [BelowElectoralThreshold]
                public static class NewZealandLoyal { }

                [PoliticalParties((int)PoliticalParties.NewZeal)]
                [VotePercentage(0.56)]
                [BelowElectoralThreshold]
                public static class NewZeal { }

                [PoliticalParties((int)PoliticalParties.LegaliseCannabis)]
                [VotePercentage(0.45)]
                [BelowElectoralThreshold]
                public static class LegaliseCannabis { }

                [PoliticalParties((int)PoliticalParties.FreedomsNZ)]
                [VotePercentage(0.33)]
                [BelowElectoralThreshold]
                public static class FreedomsNZ { }

                [PoliticalParties((int)PoliticalParties.DemocracyNZ)]
                [VotePercentage(0.23)]
                [BelowElectoralThreshold]
                public static class DemocracyNZ { }

                [PoliticalParties((int)PoliticalParties.AnimalJustice)]
                [VotePercentage(0.17)]
                [BelowElectoralThreshold]
                public static class AnimalJustice { }

                [PoliticalParties((int)PoliticalParties.Conservative)]
                [VotePercentage(0.15)]
                [BelowElectoralThreshold]
                public static class Conservative { }

                [PoliticalParties((int)PoliticalParties.LeightonBaker)]
                [VotePercentage(0.09)]
                [BelowElectoralThreshold]
                public static class LeightonBaker { }

                [PoliticalParties((int)PoliticalParties.WomensRights)]
                [VotePercentage(0.08)]
                [BelowElectoralThreshold]
                public static class WomensRights { }

                [PoliticalParties((int)PoliticalParties.NewNation)]
                [VotePercentage(0.05)]
                [BelowElectoralThreshold]
                public static class NewNation { }
            }
        }

        /// <summary>
        /// the election is on 2026-11-07. Official results are due on 2026-11-27 and the writ is due back on 2026-12-03,
        /// so the vote percentages, seats, number of members and date of taking office aren't known yet
        /// </summary>
        [ElectionDate(2026, 11, 7)]
        [ParliamentaryElectoralThreshold(5)]
        public static class v55
        {
            /// <summary>
            /// one class per party list, each pointing to its PoliticalParties entry. Parties from the 54th Parliament come
            /// first, then the others alphabetically
            /// </summary>
            public static class Parties
            {
                [PoliticalParties((int)PoliticalParties.National)]
                [PoliticalPartyLeader((int)Politicians.LuxonChristopher)]
                public static class National { }

                [PoliticalParties((int)PoliticalParties.Labour)]
                [PoliticalPartyLeader((int)Politicians.HipkinsChris)]
                public static class Labour { }

                [PoliticalParties((int)PoliticalParties.Green)]
                [PoliticalPartyLeader((int)Politicians.DavidsonMarama)]
                [PoliticalPartyLeader((int)Politicians.SwarbrickChlöe)]
                public static class Green { }

                [PoliticalParties((int)PoliticalParties.ACT)]
                [PoliticalPartyLeader((int)Politicians.SeymourDavid)]
                public static class ACT { }

                [PoliticalParties((int)PoliticalParties.NewZealandFirst)]
                [PoliticalPartyLeader((int)Politicians.PetersWinston)]
                public static class NewZealandFirst { }

                [PoliticalParties((int)PoliticalParties.TePātiMāori)]
                [PoliticalPartyLeader((int)Politicians.NgarewaPackerDebbie)]
                [PoliticalPartyLeader((int)Politicians.WaititiRawiri)]
                public static class TePātiMāori { }

                [PoliticalParties((int)PoliticalParties.Alliance)]
                [PoliticalPartyLeader((int)Politicians.BillotVictor)]
                public static class Alliance { }

                [PoliticalParties((int)PoliticalParties.AnimalJustice)]
                [PoliticalPartyLeader((int)Politicians.McNeilRobert)]
                [PoliticalPartyLeader((int)Politicians.WeretaDannette)]
                public static class AnimalJustice { }

                [PoliticalParties((int)PoliticalParties.Conservative)]
                [PoliticalPartyLeader((int)Politicians.HoughtonHelen)]
                public static class Conservative { }

                [PoliticalParties((int)PoliticalParties.FreePalestine)]
                [PoliticalPartyLeader((int)Politicians.HopkinsonPaul)]
                public static class FreePalestine { }

                [PoliticalParties((int)PoliticalParties.LegaliseCannabis)]
                [PoliticalPartyLeader((int)Politicians.HerbertMaki)]
                [PoliticalPartyLeader((int)Politicians.ApplebyMichael)]
                public static class LegaliseCannabis { }

                [PoliticalParties((int)PoliticalParties.NewZealandLoyal)]
                [PoliticalPartyLeader((int)Politicians.AlpKelvyn)]
                public static class NewZealandLoyal { }

                [PoliticalParties((int)PoliticalParties.NewZealandOutdoorsAndFreedom)]
                [PoliticalPartyLeader((int)Politicians.GreySue)]
                public static class NewZealandOutdoorsAndFreedom { }

                [PoliticalParties((int)PoliticalParties.Opportunity)]
                [PoliticalPartyLeader((int)Politicians.WongQiulae)]
                public static class Opportunity { }

                [PoliticalParties((int)PoliticalParties.TeTaiTokerau)]
                [PoliticalPartyLeader((int)Politicians.KapaKingiMariameno)]
                public static class TeTaiTokerau { }

                [PoliticalParties((int)PoliticalParties.VisionNewZealand)]
                [PoliticalPartyLeader((int)Politicians.TamakiHannah)]
                public static class VisionNewZealand { }

                [PoliticalParties((int)PoliticalParties.WomensRights)]
                [PoliticalPartyLeader((int)Politicians.OvensJill)]
                [PoliticalPartyLeader((int)Politicians.TrenberthDawn)]
                public static class WomensRights { }
            }
        }
    }
}
