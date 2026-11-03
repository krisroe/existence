using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates.Elections
{
    /// <summary>
    /// November general elections. Seat counts are by party on election day and leave out independents, so they don't
    /// always add up to the total. Deltas are the change from the previous November general election, so they include
    /// special elections and party switches in between
    /// </summary>
    public static class Congress
    {
        [ElectionDate(1994, 11, 8)]
        public static class v1994
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 230, 54, (int)PoliticalParties.Democratic, 204, -54, "first Republican majority since 1954. Bernie Sanders (independent) caucused with the Democrats")]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 52, 9, (int)PoliticalParties.Democratic, 48, -9, SeatsUp: 33, "Richard Shelby switched from Democrat to Republican the day after the election")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(1996, 11, 5)]
        public static class v1996
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 226, -4, (int)PoliticalParties.Democratic, 207, 3, "independents: Bernie Sanders caucused with the Democrats, Jo Ann Emerson with the Republicans (rejoined them in January 1997)")]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 55, 3, (int)PoliticalParties.Democratic, 45, -3, SeatsUp: 33)]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(1998, 11, 3)]
        public static class v1998
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 223, -3, (int)PoliticalParties.Democratic, 211, 4,"Bernie Sanders (independent) caucused with the Democrats")]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 55, 0, (int)PoliticalParties.Democratic, 45, 0, SeatsUp: 34)]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2000, 11, 7)]
        public static class v2000
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 221, -2, (int)PoliticalParties.Democratic, 212, 1, "independents: Bernie Sanders caucused with the Democrats, Virgil Goode with the Republicans")]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 50, -5, (int)PoliticalParties.Democratic, 50, 5, SeatsUp: 33, "50-50 split, Jim Jeffords left the Republicans in 2001 to caucus with the Democrats, giving them the majority")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2002, 11, 5)]
        public static class v2002
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 229, 8, (int)PoliticalParties.Democratic, 205, -7, "Bernie Sanders (independent) caucused with the Democrats")]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 51, 1, (int)PoliticalParties.Democratic, 48, -2, SeatsUp: 33, "Jim Jeffords (independent) caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2004, 11, 2)]
        public static class v2004
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 232, 3, (int)PoliticalParties.Democratic, 202, -3, "Bernie Sanders (independent) caucused with the Democrats")]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 55, 4, (int)PoliticalParties.Democratic, 44, -4, SeatsUp: 34, "Jim Jeffords (independent) caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2006, 11, 7)]
        public static class v2006
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 202, -30, (int)PoliticalParties.Democratic, 233, 31)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 49, -6, (int)PoliticalParties.Democratic, 49, 5, SeatsUp: 33, "independents Bernie Sanders and Joe Lieberman caucused with the Democrats, giving them the majority")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2008, 11, 4)]
        public static class v2008
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 178, -24, (int)PoliticalParties.Democratic, 257, 24)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 41, -8, (int)PoliticalParties.Democratic, 57, 8, SeatsUp: 33, "independents Bernie Sanders and Joe Lieberman caucused with the Democrats. Includes Al Franken's Minnesota win, decided by recount in 2009")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2010, 11, 2)]
        public static class v2010
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 242, 64, (int)PoliticalParties.Democratic, 193, -64)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 47, 6, (int)PoliticalParties.Democratic, 51, -6, SeatsUp: 34, "independents Bernie Sanders and Joe Lieberman caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2012, 11, 6)]
        public static class v2012
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 234, -8, (int)PoliticalParties.Democratic, 201, 8)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 45, -2, (int)PoliticalParties.Democratic, 53, 2, SeatsUp: 33, "independents Bernie Sanders and Angus King caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2014, 11, 4)]
        public static class v2014
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 247, 13, (int)PoliticalParties.Democratic, 188, -13)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 54, 9, (int)PoliticalParties.Democratic, 44, -9, SeatsUp: 33, "independents Bernie Sanders and Angus King caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2016, 11, 8)]
        public static class v2016
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 241, -6, (int)PoliticalParties.Democratic, 194, 6)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 52, -2, (int)PoliticalParties.Democratic, 46, 2, SeatsUp: 34, "independents Bernie Sanders and Angus King caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2018, 11, 6)]
        public static class v2018
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 199, -42, (int)PoliticalParties.Democratic, 235, 41, "North Carolina's 9th district was left vacant over election fraud, a Republican won the 2019 special election")]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 53, 1, (int)PoliticalParties.Democratic, 45, -1, SeatsUp: 33, "independents Bernie Sanders and Angus King caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2020, 11, 3)]
        public static class v2020
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 213, 14, (int)PoliticalParties.Democratic, 222, -13)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 50, -3, (int)PoliticalParties.Democratic, 48, 3, SeatsUp: 33, "independents Bernie Sanders and Angus King caucused with the Democrats, giving them the majority with Vice President Kamala Harris breaking ties. Includes both Georgia seats, decided in January 2021 runoffs")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2022, 11, 8)]
        public static class v2022
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 222, 9, (int)PoliticalParties.Democratic, 213, -9)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 49, -1, (int)PoliticalParties.Democratic, 49, 1, SeatsUp: 34, "independents Bernie Sanders and Angus King caucused with the Democrats. Kyrsten Sinema left the Democrats to become an independent in December 2022")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2024, 11, 5)]
        public static class v2024
        {
            [TwoPartyLegislatureResultAllSeats((int)PoliticalParties.Republican, 220, -2, (int)PoliticalParties.Democratic, 215, 2)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [TwoPartyLegislatureResultPartialSeats((int)PoliticalParties.Republican, 53, 4, (int)PoliticalParties.Democratic, 45, -4, SeatsUp: 33, "independents Bernie Sanders and Angus King caucused with the Democrats")]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }

        [ElectionDate(2026, 11, 3)]
        public static class v2026
        {
            [UpcomingTwoPartyLegislativeElection((int)PoliticalParties.Republican, 218, (int)PoliticalParties.Democratic, 214, SeatsUp: 435)]
            [TotalLegislatureSeats(435)]
            public static class House { }

            [UpcomingTwoPartyLegislativeElection((int)PoliticalParties.Republican, 53, (int)PoliticalParties.Democratic, 45, SeatsUp: 33)]
            [TotalLegislatureSeats(100)]
            public static class Senate { }
        }
    }
}
