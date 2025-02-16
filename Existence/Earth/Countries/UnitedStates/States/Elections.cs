
namespace Existence.Earth.Countries.UnitedStates.States
{
    public static class Elections
    {
        public static class PrimaryElections
        {
            public static class California
            {
                /// <summary>
                /// California Two Two Primary Preference Rules:
                /// * Candidates must list their party preference on the ballot, or "No Party Preference"
                /// * Candidates do not have to be a member of the party, it does not imply party endorsement
                /// * Candidates cannot leave the party preference field blank
                /// </summary>
                public static class TopTwoPrimary { }
            }

            public static class Washington
            {
                /// <summary>
                /// Washington Top Two Party Preference Rules:
                /// * Candidates may list their party preference on the ballot, or "No Party Preference"
                /// * Candidates do not have to be a member of the party, it does not imply party endorsement
                /// * Candidates can leave the party preference field blank
                /// </summary>
                public static class TopTwoPrimary { }
            }

            /// <summary>
            /// Always has a primary election before the main election day.
            /// All candidates for an office appear on the same primary ballot, regardless of party.
            /// Voters can choose any candidate, regardless of their own party affiliation.
            /// The top two vote-getters advance to the general election, regardless of party.
            /// This means the general election may feature two candidates from the same party.
            /// All voters can participate in the primary, regardless of their own party affiliation.
            /// There is no requirement to register with a party to vote in the primary.
            /// This does NOT apply to presidential elections
            /// </summary>
            public static class TopTwoPrimary { }


            public static class Louisiana
            {
                /// <summary>
                /// The first round is held on the main election day (November).
                /// If a candidate gets more than 50% of the vote, they win outright, and no further election is needed.
                /// If no candidate gets a majority, the top two advance to a runoff, which is held after the main election day 
                /// (usually in December).
                /// 
                /// Jungle Primary used from 1975-2006
                /// Partisan Primary used from 2008-2010
                /// Jungle Primary used from 2012-present (Act 570)
                /// </summary>
                public static class JunglePrimary { }
            }
        }
    }
}
