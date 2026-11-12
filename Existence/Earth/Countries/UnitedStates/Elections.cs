using Existence.Beyond.Infrastructure;
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates.Elections
{
    /// <summary>
    /// November general elections. Seat counts are by party on election day, with independents counted as members of the
    /// party they caucused with. Deltas are the change from the previous November general election, so they include
    /// special elections and party switches in between
    /// </summary>
    public static class Congress
    {
        [ElectionDate(1994, 11, 8)]
        [PostElectionTakeOfficeDate(1995, 1, 3)]
        public static class v1994
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 230, 54, (int)PoliticalParties.Democratic, 205, -54, $"first Republican majority since 1954. {nameof(UnitedStatesPoliticians.SandersBernie)} (independent) caucused with the Democrats")]
            [LegislativeChamberSwitchedControl((int)PoliticalParties.Republican)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 52, 9, (int)PoliticalParties.Democratic, 48, -9, SeatsUp: 33, $"{nameof(UnitedStatesPoliticians.ShelbyRichard)} switched from Democrat to Republican the day after the election")]
            [LegislativeChamberSwitchedControl((int)PoliticalParties.Republican)]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(1996, 11, 5)]
        [PostElectionTakeOfficeDate(1997, 1, 3)]
        public static class v1996
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 227, -3, (int)PoliticalParties.Democratic, 208, 3, $"independents: {nameof(UnitedStatesPoliticians.SandersBernie)} caucused with the Democrats, {nameof(UnitedStatesPoliticians.EmersonJoAnn)} with the Republicans (rejoined them in January 1997)")]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 55, 3, (int)PoliticalParties.Democratic, 45, -3, SeatsUp: 33)]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(1998, 11, 3)]
        [PostElectionTakeOfficeDate(1999, 1, 3)]
        public static class v1998
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 223, -4, (int)PoliticalParties.Democratic, 212, 4,$"{nameof(UnitedStatesPoliticians.SandersBernie)} (independent) caucused with the Democrats")]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 55, 0, (int)PoliticalParties.Democratic, 45, 0, SeatsUp: 34)]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2000, 11, 7)]
        [PostElectionTakeOfficeDate(2001, 1, 3)]
        public static class v2000
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 222, -1, (int)PoliticalParties.Democratic, 213, 1, $"independents: {nameof(UnitedStatesPoliticians.SandersBernie)} caucused with the Democrats, {nameof(UnitedStatesPoliticians.GoodeVirgil)} with the Republicans")]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Democratic, 50, 5, (int)PoliticalParties.Republican, 50, -5, SeatsUp: 33, $"50-50 split, outgoing Vice President {nameof(UnitedStatesPoliticians.GoreAl)} was able to break ties until the President took office")]
            [LegislativeChamberSwitchedControl((int)PoliticalParties.Democratic)]
            [TotalLegislatureSeats(100)]
            public static class Senate
            {
                /// <summary>
                /// New Vice President <see cref="UnitedStatesPoliticians.CheneyDick"/> was able to break ties
                /// </summary>
                [StartDate(2001, 1, 20)]
                [LegislativeChamberSwitchedControl((int)PoliticalParties.Republican)]
                public static class PresidentTookOffice { }

                /// <summary>
                /// <see cref="UnitedStatesPoliticians.JeffordsJim"/> left the Republicans to become an independent caucusing
                /// with the Democrats. He announced the switch on 2001-05-24, and it took effect when the Democrats took
                /// control on 2001-06-06
                /// </summary>
                [StartDate(2001, 6, 6)]
                [LegislativeChamberSwitchedControl((int)PoliticalParties.Democratic)]
                public static class SenatorSwitchedSides { }
            }
        }

        [ElectionDate(2002, 11, 5)]
        [PostElectionTakeOfficeDate(2003, 1, 3)]
        public static class v2002
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 229, 7, (int)PoliticalParties.Democratic, 206, -7, $"{nameof(UnitedStatesPoliticians.SandersBernie)} (independent) caucused with the Democrats")]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 51, 1, (int)PoliticalParties.Democratic, 49, -1, SeatsUp: 33, $"{nameof(UnitedStatesPoliticians.JeffordsJim)} (independent) caucused with the Democrats")]
            [LegislativeChamberSwitchedControl((int)PoliticalParties.Republican)]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2004, 11, 2)]
        [PostElectionTakeOfficeDate(2005, 1, 3)]
        public static class v2004
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 232, 3, (int)PoliticalParties.Democratic, 203, -3, $"{nameof(UnitedStatesPoliticians.SandersBernie)} (independent) caucused with the Democrats")]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 55, 4, (int)PoliticalParties.Democratic, 45, -4, SeatsUp: 34, $"{nameof(UnitedStatesPoliticians.JeffordsJim)} (independent) caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2006, 11, 7)]
        [PostElectionTakeOfficeDate(2007, 1, 3)]
        public static class v2006
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 202, -30, (int)PoliticalParties.Democratic, 233, 30)]
            [LegislativeChamberSwitchedControl((int)PoliticalParties.Democratic)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 49, -6, (int)PoliticalParties.Democratic, 51, 6, SeatsUp: 33, $"independents {nameof(UnitedStatesPoliticians.SandersBernie)} and {nameof(UnitedStatesPoliticians.LiebermanJoe)} caucused with the Democrats, giving them the majority")]
            [LegislativeChamberSwitchedControl((int)PoliticalParties.Democratic)]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        /// <summary>
        /// <see cref="UnitedStatesPoliticians.LiebermanJoe"/> endorsed Republican <see cref="UnitedStatesPoliticians.McCainJohn"/> for President and spoke at the
        /// Republican National Convention, over foreign policy and his support for the Iraq war. At the core he remained a
        /// Democrat, so he kept caucusing with the Democrats, who let him keep his Homeland Security committee chairmanship,
        /// and he is counted as a Democrat
        /// </summary>
        [ElectionDate(2008, 11, 4)]
        [PostElectionTakeOfficeDate(2009, 1, 3)]
        public static class v2008
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 178, -24, (int)PoliticalParties.Democratic, 257, 24)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 41, -8, (int)PoliticalParties.Democratic, 59, 8, SeatsUp: 33, $"independents {nameof(UnitedStatesPoliticians.SandersBernie)} and {nameof(UnitedStatesPoliticians.LiebermanJoe)} caucused with the Democrats. Includes {nameof(UnitedStatesPoliticians.FrankenAl)}'s Minnesota win, decided by recount in 2009")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2010, 11, 2)]
        [PostElectionTakeOfficeDate(2011, 1, 3)]
        public static class v2010
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 242, 64, (int)PoliticalParties.Democratic, 193, -64)]
            [LegislativeChamberSwitchedControl((int)PoliticalParties.Republican)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 47, 6, (int)PoliticalParties.Democratic, 53, -6, SeatsUp: 34, $"independents {nameof(UnitedStatesPoliticians.SandersBernie)} and {nameof(UnitedStatesPoliticians.LiebermanJoe)} caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2012, 11, 6)]
        [PostElectionTakeOfficeDate(2013, 1, 3)]
        public static class v2012
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 234, -8, (int)PoliticalParties.Democratic, 201, 8)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 45, -2, (int)PoliticalParties.Democratic, 55, 2, SeatsUp: 33, $"independents {nameof(UnitedStatesPoliticians.SandersBernie)} and {nameof(UnitedStatesPoliticians.KingAngus)} caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2014, 11, 4)]
        [PostElectionTakeOfficeDate(2015, 1, 3)]
        public static class v2014
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 247, 13, (int)PoliticalParties.Democratic, 188, -13)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 54, 9, (int)PoliticalParties.Democratic, 46, -9, SeatsUp: 33, $"independents {nameof(UnitedStatesPoliticians.SandersBernie)} and {nameof(UnitedStatesPoliticians.KingAngus)} caucused with the Democrats")]
            [LegislativeChamberSwitchedControl((int)PoliticalParties.Republican)]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2016, 11, 8)]
        [PostElectionTakeOfficeDate(2017, 1, 3)]
        public static class v2016
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 241, -6, (int)PoliticalParties.Democratic, 194, 6)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 52, -2, (int)PoliticalParties.Democratic, 48, 2, SeatsUp: 34, $"independents {nameof(UnitedStatesPoliticians.SandersBernie)} and {nameof(UnitedStatesPoliticians.KingAngus)} caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2018, 11, 6)]
        [PostElectionTakeOfficeDate(2019, 1, 3)]
        public static class v2018
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 199, -42, (int)PoliticalParties.Democratic, 235, 41, "North Carolina's 9th district was left vacant over election fraud, a Republican won the 2019 special election")]
            [LegislativeChamberSwitchedControl((int)PoliticalParties.Democratic)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 53, 1, (int)PoliticalParties.Democratic, 47, -1, SeatsUp: 33, $"independents {nameof(UnitedStatesPoliticians.SandersBernie)} and {nameof(UnitedStatesPoliticians.KingAngus)} caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2020, 11, 3)]
        [PostElectionTakeOfficeDate(2021, 1, 3)]
        public static class v2020
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 213, 14, (int)PoliticalParties.Democratic, 222, -13)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 50, -3, (int)PoliticalParties.Democratic, 50, 3, SeatsUp: 33, $"independents {nameof(UnitedStatesPoliticians.SandersBernie)} and {nameof(UnitedStatesPoliticians.KingAngus)} caucused with the Democrats, giving them the majority with Vice President {nameof(UnitedStatesPoliticians.HarrisKamala)} breaking ties. Includes both Georgia seats, decided in January 2021 runoffs")]
            [LegislativeChamberSwitchedControl((int)PoliticalParties.Democratic)]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2022, 11, 8)]
        [PostElectionTakeOfficeDate(2023, 1, 3)]
        public static class v2022
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 222, 9, (int)PoliticalParties.Democratic, 213, -9)]
            [LegislativeChamberSwitchedControl((int)PoliticalParties.Republican)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 49, -1, (int)PoliticalParties.Democratic, 51, 1, SeatsUp: 34, $"independents {nameof(UnitedStatesPoliticians.SandersBernie)} and {nameof(UnitedStatesPoliticians.KingAngus)} caucused with the Democrats. {nameof(UnitedStatesPoliticians.SinemaKyrsten)} left the Democrats to become an independent in December 2022")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2024, 11, 5)]
        [PostElectionTakeOfficeDate(2025, 1, 3)]
        public static class v2024
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 220, -2, (int)PoliticalParties.Democratic, 215, 2)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 53, 4, (int)PoliticalParties.Democratic, 47, -4, SeatsUp: 33, $"independents {nameof(UnitedStatesPoliticians.SandersBernie)} and {nameof(UnitedStatesPoliticians.KingAngus)} caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2026, 11, 3)]
        [PostElectionTakeOfficeDate(2027, 1, 3)]
        public static class v2026
        {
            /// <summary>
            /// 2026-11-11: currently sitting at 255 Dem - 168 GOP (12 uncalled per Associated Press)
            /// </summary>
            [IRootedFor((int)PoliticalParties.Democratic)]
            [IPredictedTwoPartyLegislativeElection((int)PoliticalParties.Democratic, 240, (int)PoliticalParties.Republican, 195, Correctness.Incorrect, $"{nameof(UnitedStatesPoliticians.TrumpDonald)} needs to be put in his place.")]
            [UpcomingTwoPartyLegislativeElection((int)PoliticalParties.Republican, 219, (int)PoliticalParties.Democratic, 214, SeatsUp: 435)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            /// <summary>
            /// Prediction Details for Senate tossups (9):
            /// Texas (correct): This is the big switch, <see cref="UnitedStatesPoliticians.TalaricoJames"/> asked me for absurdly low amounts of money [I didn't give him any], wins over <see cref="UnitedStatesPoliticians.PaxtonKen"/> who beat <see cref="UnitedStatesPoliticians.CornynJohn"/> in the primary)
            /// Michigan (correct): Dem (There's a reason <see cref="UnitedStatesPoliticians.ElSayedAbdul"/> is here [Muslim+Progressive], wins over <see cref="UnitedStatesPoliticians.RogersMike"/>)
            /// Alaska (pending): GOP (I can't endorse <see cref="UnitedStatesPoliticians.PeltolaMary"/>'s shenanigans with the lookalike <see cref="UnitedStatesPoliticians.SullivanDan"/> but wins anyway)
            /// Maine (correct): Dem (<see cref="UnitedStatesPoliticians.CollinsSusan"> doesn't deserve to lose, but lose she will anyway to <see cref="UnitedStatesPoliticians.JacksonTroy"/> who replaced <see cref="UnitedStatesPoliticians.PlatnerGraham"/>)
            /// Ohio (correct): Dan (<see cref="UnitedStatesPoliticians.BrownSherrod"/> returns to the Senate after a brief absence)
            /// South Carolina (incorrect): GOP (<see cref="UnitedStatesPoliticians.GrahamDarline"/> replaced her older brother (both as temporary vacancy and as candidate) <see cref="UnitedStatesPoliticians.GrahamLindsey"/>, who died after winning the primary
            /// Kansas (correct): Dem (in a generic year it would be surprising this one is in play, but this is no generic year)
            /// Nebraska (correct): GOP (in a generic year it would be surprising this one is in play, but this is no generic year)
            /// I also made mistakes by not making a prediction for other seat that flipped (I only predicted RCP tossup seats which wasn't good enough this year).
            /// Iowa (not clear what I would have predicted): GOP->Dem
            /// North Carolina (would have predicted Dem): GOP->Dem
            /// 
            /// As it stands, the Democrats have 54 seats with a 55th coming if they win Alaska (Democrat is currently ahead)
            /// </summary>
            [IRootedFor((int)PoliticalParties.Democratic)]
            [IPredictedTwoPartyLegislativeElection((int)PoliticalParties.Democratic, 53, (int)PoliticalParties.Republican, 47, Correctness.Incorrect, $"{nameof(UnitedStatesPoliticians.TrumpDonald)} needs to be put in his place.")]
            [UpcomingTwoPartyLegislativeElection((int)PoliticalParties.Republican, 53, (int)PoliticalParties.Democratic, 47, SeatsUp: 33)]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }
    }
}
