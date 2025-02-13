
using Existence.Earth.FieldsOfStudy.Astrology;
using Existence.Time;

namespace Existence.Personal
{
    public static class VotingRecord
    {
        public static class v2000
        {
            [YearDate(2000, 11, 7)]
            public static class November
            {
                /// <summary>
                /// this was a novelty
                /// </summary>
                public static class VotedLibertarianHarryBrowneForUSPresident { }
                /// <summary>
                /// I really didn't understand what was going on here and voted reflexively (voting rights for
                /// the class seemed reasonable)
                /// </summary>
                public static class VotedYesOnBallotInitiativeExtendedVotingRightsToChildrenOfUSCitizens { }
                /// <summary>
                /// Ballotpedia seems to have no idea what this question was. I remember it as an advisory question of
                /// whether restricting campaign finance was a good idea. I voted no since at the time I thought
                /// campaign finance reform as having ulterior motives I disagreed with. I remember the initiative
                /// passing by a large margin, but don't see online record of this.
                /// </summary>
                public static class VotedNoOnCampaignFinanceQuestion { }
            }
        }

        public static class v2008
        {
            [AstrologicalSign(AstrologicalSigns.Pisces)] //pisces cutoff within 2/18/2008
            [YearDate(2008, 2, 19)]
            public static class February
            {
                public static class RepublicanPresidentialPrimaryVotedForRonPaul { }
            }
        }

        [YearDate(2012, 11, 6)]
        public static class v2012
        {
            public static class November
            {
                public static class VotedLibertarianGaryJohnson { }
            }
        }

        [YearDate(2016, 11, 8)]
        public static class v2016
        {
            public static class November
            {
                public static class VotedLibertarianGaryJohnson { }
                public static class DonatedFiftyDollarsToTheTrumpCampaign { }
            }
        }
    }
}
