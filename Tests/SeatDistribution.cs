using Existence.Earth.Human.Politics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Existence.Tests
{
    /// <summary>
    /// test class
    /// </summary>
    [TestClass]
    public class SeatDistributionTest
    {
        private const int knessetNumberOfSeats = 120;

        private const decimal knessetV25ElectoralThreshold = 3.25m;

        /// <summary>
        /// votes for each list in the 2022 Knesset election. Other lumps together the minor lists, each far below the
        /// electoral threshold
        /// </summary>
        private static readonly Dictionary<string, long> knessetV25Votes = new Dictionary<string, long>()
        {
            { "Likud", 1115336 },
            { "YeshAtid", 847435 },
            { "ReligiousZionism", 516470 },
            { "NationalUnity", 432482 },
            { "Shas", 392964 },
            { "UnitedTorahJudaism", 280194 },
            { "YisraelBeiteinu", 213687 },
            { "UnitedArabList", 194047 },
            { "HadashTaal", 178735 },
            { "Labor", 175992 },
            { "Meretz", 150793 },
            { "Balad", 138617 },
            { "TheJewishHome", 56793 },
            { "Other", 71197 },
        };

        private static readonly List<(string, string)> knessetV25SurplusVoteAgreements = new List<(string, string)>()
        {
            ("Likud", "ReligiousZionism"),
            ("YeshAtid", "NationalUnity"),
            ("Shas", "UnitedTorahJudaism"),
            ("Labor", "Meretz"),
        };

        /// <summary>
        /// validates the 2022 Knesset election's seat distribution, which Knesset.v25.LeftoverSeatDistribution describes:
        /// 113 base seats, the Labor-Meretz surplus vote agreement annulled, and the 7 leftover seats in order
        /// </summary>
        [TestMethod]
        public void ValidateKnessetV25SeatDistribution()
        {
            DHondtSeatDistribution r = SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(knessetV25Votes, knessetV25SurplusVoteAgreements, knessetNumberOfSeats, knessetV25ElectoralThreshold);
            Assert.AreEqual(4347342, r.QualifyingVotes);
            CollectionAssert.AreEquivalent(new[] { "Meretz", "Balad", "TheJewishHome", "Other" }, r.PoliticalPartiesBelowElectoralThreshold);
            CollectionAssert.AreEqual(new[] { ("Labor", "Meretz") }, r.AnnulledSurplusVoteAgreements);

            Dictionary<string, int> expectedBaseSeats = new Dictionary<string, int>()
            {
                { "Likud", 30 }, { "YeshAtid", 23 }, { "ReligiousZionism", 14 }, { "NationalUnity", 11 }, { "Shas", 10 },
                { "UnitedTorahJudaism", 7 }, { "YisraelBeiteinu", 5 }, { "UnitedArabList", 5 }, { "HadashTaal", 4 }, { "Labor", 4 },
            };
            CollectionAssert.AreEquivalent(expectedBaseSeats, r.BaseSeats);

            List<(int, string, string)> expectedLeftoverSeats = new List<(int, string, string)>()
            {
                (114, "Shas + UnitedTorahJudaism", "Shas"),
                (115, "YeshAtid + NationalUnity", "NationalUnity"),
                (116, "Likud + ReligiousZionism", "Likud"),
                (117, "HadashTaal", "HadashTaal"),
                (118, "YisraelBeiteinu", "YisraelBeiteinu"),
                (119, "YeshAtid + NationalUnity", "YeshAtid"),
                (120, "Likud + ReligiousZionism", "Likud"),
            };
            CollectionAssert.AreEqual(expectedLeftoverSeats, r.OrderedSeats.Select(s => (s.SeatNumber, string.Join(" + ", s.Recipients), s.PoliticalParty)).ToList());
            Assert.AreEqual(2, r.OrderedSeatsByRecipient["Likud + ReligiousZionism"]);
            Assert.AreEqual(0, r.OrderedSeatsByRecipient["UnitedArabList"]);

            Dictionary<string, int> expectedSeats = new Dictionary<string, int>()
            {
                { "Likud", 32 }, { "YeshAtid", 24 }, { "ReligiousZionism", 14 }, { "NationalUnity", 12 }, { "Shas", 11 },
                { "UnitedTorahJudaism", 7 }, { "YisraelBeiteinu", 6 }, { "UnitedArabList", 5 }, { "HadashTaal", 5 }, { "Labor", 4 },
            };
            CollectionAssert.AreEquivalent(expectedSeats, r.Seats);
        }

        /// <summary>
        /// validates that without any surplus vote agreements, the 2022 Knesset election's 120th seat would have gone to
        /// Labor instead of Likud, as Knesset.v25.LeftoverSeatDistribution says
        /// </summary>
        [TestMethod]
        public void ValidateKnessetV25SeatDistributionWithoutSurplusVoteAgreements()
        {
            DHondtSeatDistribution r = SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(knessetV25Votes, new List<(string, string)>(), knessetNumberOfSeats, knessetV25ElectoralThreshold);
            Assert.AreEqual(0, r.AnnulledSurplusVoteAgreements.Count);
            Assert.AreEqual("Labor", r.OrderedSeats.Last().PoliticalParty);
            Assert.AreEqual(31, r.Seats["Likud"]);
            Assert.AreEqual(5, r.Seats["Labor"]);
            Assert.AreEqual(120, r.Seats.Values.Sum());
        }

        /// <summary>
        /// validates that the 2022 Knesset election's next leftover seat would go to United Torah Judaism, through its
        /// surplus vote agreement with Shas
        /// </summary>
        [TestMethod]
        public void ValidateKnessetV25NextOrderedSeat()
        {
            DHondtSeatDistribution r = SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(knessetV25Votes, knessetV25SurplusVoteAgreements, knessetNumberOfSeats, knessetV25ElectoralThreshold);
            Assert.AreEqual(121, r.NextOrderedSeat.SeatNumber);
            CollectionAssert.AreEqual(new[] { "Shas", "UnitedTorahJudaism" }, r.NextOrderedSeat.Recipients);
            Assert.AreEqual("UnitedTorahJudaism", r.NextOrderedSeat.PoliticalParty);
            Assert.AreEqual(673158m / 19, r.NextOrderedSeat.VotesPerSeat);
            Assert.AreEqual(120, r.Seats.Values.Sum());
        }

        /// <summary>
        /// validates that the next leftover seat gives the same result as recalculating with more seats, even though
        /// more seats lower the quota and change how many of them are base seats
        /// </summary>
        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void ValidateNextOrderedSeatMatchesRecalculatingWithOneMoreSeat(bool useSurplusVoteAgreements)
        {
            List<(string, string)> agreements = useSurplusVoteAgreements ? knessetV25SurplusVoteAgreements : new List<(string, string)>();
            for (int iSeats = knessetNumberOfSeats; iSeats < knessetNumberOfSeats + 20; iSeats++)
            {
                DHondtSeatDistribution r = SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(knessetV25Votes, agreements, iSeats, knessetV25ElectoralThreshold);
                DHondtSeatDistribution withOneMoreSeat = SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(knessetV25Votes, agreements, iSeats + 1, knessetV25ElectoralThreshold);

                Dictionary<string, int> expectedSeats = new Dictionary<string, int>(r.Seats);
                expectedSeats[r.NextOrderedSeat.PoliticalParty]++;
                CollectionAssert.AreEquivalent(expectedSeats, withOneMoreSeat.Seats, $"going from {iSeats} seats to {iSeats + 1}");
            }
        }

        /// <summary>
        /// validates the votes Shas and United Torah Judaism needed for a further seat in the 2022 Knesset election, which
        /// would have come from Likud and Religious Zionism, the agreement with the lowest votes per seat
        /// </summary>
        [TestMethod]
        public void ValidateKnessetV25VotesNeededForNextOrderedSeat()
        {
            DHondtSeatDistribution r = SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(knessetV25Votes, knessetV25SurplusVoteAgreements, knessetNumberOfSeats, knessetV25ElectoralThreshold);
            Assert.AreEqual(849, r.VotesNeededForNextOrderedSeat);
        }

        /// <summary>
        /// validates by recalculating that the votes needed for the next leftover seat are enough for its recipients to gain
        /// a seat, and that one vote fewer isn't
        /// </summary>
        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void ValidateVotesNeededForNextOrderedSeatByRecalculating(bool useSurplusVoteAgreements)
        {
            List<(string, string)> agreements = useSurplusVoteAgreements ? knessetV25SurplusVoteAgreements : new List<(string, string)>();
            for (int iSeats = knessetNumberOfSeats; iSeats < knessetNumberOfSeats + 20; iSeats++)
            {
                DHondtSeatDistribution r = SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(knessetV25Votes, agreements, iSeats, knessetV25ElectoralThreshold);
                string[] recipients = r.NextOrderedSeat.Recipients;
                int iRecipientSeats = recipients.Sum(p => r.Seats[p]);
                long lVotesNeeded = r.VotesNeededForNextOrderedSeat!.Value;
                Assert.IsTrue(lVotesNeeded > 0, $"at {iSeats} seats");

                Assert.AreEqual(iRecipientSeats + 1, RecipientSeatsWithExtraVotes(lVotesNeeded), $"enough votes at {iSeats} seats");
                Assert.AreEqual(iRecipientSeats, RecipientSeatsWithExtraVotes(lVotesNeeded - 1), $"one vote fewer at {iSeats} seats");

                int RecipientSeatsWithExtraVotes(long lExtraVotes)
                {
                    Dictionary<string, long> votes = new Dictionary<string, long>(knessetV25Votes);
                    votes[r.NextOrderedSeat.PoliticalParty] += lExtraVotes;
                    DHondtSeatDistribution changed = SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(votes, agreements, iSeats, knessetV25ElectoralThreshold);
                    return recipients.Sum(p => changed.Seats[p]);
                }
            }
        }

        /// <summary>
        /// validates that the votes needed are null when no other party has a seat that could be won
        /// </summary>
        [TestMethod]
        public void ValidateVotesNeededForNextOrderedSeatWithOnlyOneQualifyingParty()
        {
            Dictionary<string, long> votes = new Dictionary<string, long>() { { "Party1", 1000 }, { "Party2", 10 } };
            DHondtSeatDistribution r = SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(votes, new List<(string, string)>(), knessetNumberOfSeats, knessetV25ElectoralThreshold);
            Assert.AreEqual("Party1", r.NextOrderedSeat.PoliticalParty);
            Assert.IsNull(r.VotesNeededForNextOrderedSeat);
        }
    }
}
