
namespace Existence.Earth.Countries.UnitedStates.States
{
    public static class Elections
    {
        public static class PrimaryElections
        {
            public static class Alaska
            {
                /// <summary>
                /// All candidates, regardless of party, appear on the same primary ballot.
                /// Voters can choose any candidate, regardless of their own party affiliation.
                /// The top four candidates who receive the most votes advance to the general election, regardless of party.
                /// Candidates must list a party preference or can choose “Nonpartisan” or “Undeclared.”
                /// Political parties do not control who can appear on the ballot under their party label.
                /// This does NOT apply to presidential elections.
                /// </summary>
                public static class TopFourPrimary { }
            }

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

            public static class Maine
            {
                /// <summary>
                /// Separate primaries for each political party
                /// Registered party members can vote only in their own party’s primary.
                /// Unenrolled (independent) voters can choose to vote in one party’s primary without changing their 
                /// registration. Political parties can opt out and restrict primaries to their members
                /// Voters registered with a party cannot vote in another party’s primary.
                /// </summary>
                public static class SemiOpenPartyPrimaries { }
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
        }

        public static class GeneralElections
        {
            public static class Alaska
            {
                /// <summary>
                /// used in state and federal offices
                /// </summary>
                public static class RankedChoiceVoting { }
            }

            public static class Louisiana
            {
                /// <summary>
                /// The first round is held on the main election day (November).
                /// If a candidate gets more than 50% of the vote, they win outright, and no further election is needed.
                /// If no candidate gets a majority, the top two advance to a runoff, which is held after the main election day 
                /// (usually in December).
                /// 
                /// Jungle Primary used from 1975-2006
                /// Partisan Primary used from 2008-2010 (federal pressure related to voting rights act considerations)
                /// Jungle Primary used from 2012-present (Act 570)
                /// </summary>
                public static class JunglePrimary { }
            }

            public static class Maine
            {
                /// <summary>
                /// used in U.S. Senate and House elections
                /// </summary>
                public static class RankedChoiceVoting { }
            }

            /// <summary>
            /// Voters rank the four candidates in order of preference (1st choice, 2nd choice, etc.).
            /// If no candidate wins more than 50% of the first-choice votes, the lowest-ranked candidate is eliminated.
            /// Votes for the eliminated candidate are reallocated to the voter’s next-ranked choice.
            /// This process continues until a candidate receives more than 50% of the votes.
            /// </summary>
            public static class RankedChoiceVoting { }
        }
    }
}
