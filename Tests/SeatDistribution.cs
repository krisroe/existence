using Existence.Earth.FieldsOfStudy.Mathematics;
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

        /// <summary>
        /// 3.25%
        /// </summary>
        private static readonly SimpleFraction knessetV25ElectoralThreshold = new SimpleFraction(13, 4);

        /// <summary>
        /// 5%
        /// </summary>
        private static readonly SimpleFraction newZealandElectoralThreshold = new SimpleFraction(5, 1);

        /// <summary>
        /// no electoral threshold, all parties receiving votes eligible to receive seats
        /// </summary>
        private static readonly SimpleFraction noElectoralThreshold = new SimpleFraction(0, 1);

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

        /// <summary>
        /// preliminary party votes for each list in the 2026 New Zealand election, as of 2026-11-08 with 85.90% counted
        /// </summary>
        private static readonly Dictionary<string, long> newZealandV55Votes = new Dictionary<string, long>()
        {
            { "Labour", 710330 },
            { "National", 706680 },
            { "Green", 321902 },
            { "ACT", 264121 },
            { "NewZealandFirst", 236630 },
            { "Opportunity", 144298 },
            { "TePātiMāori", 13845 },
            { "LegaliseCannabis", 4829 },
            { "NewZealandOutdoorsAndFreedom", 2685 },
            { "AnimalJustice", 2585 },
            { "Conservative", 1886 },
            { "WomensRights", 1856 },
            { "NewZealandLoyal", 1855 },
            { "VisionNewZealand", 1529 },
            { "TeTaiTokerau", 1217 },
            { "FreePalestine", 1168 },
            { "Alliance", 1149 },
        };

        /// <summary>
        /// electorates each party won in the 2026 New Zealand election's preliminary results, 71 in all
        /// </summary>
        private static readonly Dictionary<string, int> newZealandV55ElectorateSeats = new Dictionary<string, int>()
        {
            { "National", 42 }, { "Labour", 21 }, { "TePātiMāori", 5 }, { "Green", 2 }, { "ACT", 1 },
        };

        /// <summary>
        /// validates the 2026 New Zealand election's preliminary result: Te Pāti Māori qualifies with 0.57% of the party
        /// vote by winning electorates, the 120 seats are divided by the party vote, and the 7 overhang seats for National
        /// and 4 for Te Pāti Māori make 131 members
        /// </summary>
        [TestMethod]
        public void ValidateNewZealandV55SeatDistribution()
        {
            SainteLagueSeatDistribution r = SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(newZealandV55Votes, new List<(string, string)>(), 120, newZealandElectoralThreshold, null, newZealandV55ElectorateSeats);
            Assert.AreEqual(2418565, r.TotalVotes);
            CollectionAssert.AreEquivalent(new Dictionary<string, int>()
            {
                { "Labour", 36 }, { "National", 35 }, { "Green", 16 }, { "ACT", 13 }, { "NewZealandFirst", 12 }, { "Opportunity", 7 }, { "TePātiMāori", 1 },
            }, r.Seats);
            CollectionAssert.AreEquivalent(new Dictionary<string, int>()
            {
                { "Labour", 15 }, { "National", 0 }, { "Green", 14 }, { "ACT", 12 }, { "NewZealandFirst", 12 }, { "Opportunity", 7 }, { "TePātiMāori", 0 },
            }, r.ListSeats);
            CollectionAssert.AreEquivalent(new Dictionary<string, int>()
            {
                { "Labour", 0 }, { "National", 7 }, { "Green", 0 }, { "ACT", 0 }, { "NewZealandFirst", 0 }, { "Opportunity", 0 }, { "TePātiMāori", 4 },
            }, r.OverhangSeats);
            CollectionAssert.AreEquivalent(new Dictionary<string, int>()
            {
                { "Labour", 36 }, { "National", 42 }, { "Green", 16 }, { "ACT", 13 }, { "NewZealandFirst", 12 }, { "Opportunity", 7 }, { "TePātiMāori", 5 },
            }, r.TotalSeats);
            Assert.AreEqual(131, r.NumberOfMembers);
            Assert.AreEqual(60, r.ListSeats.Values.Sum());

            //the next seat goes to National, whose total stays at 42 with one less overhang seat
            Assert.AreEqual("National", r.NextOrderedSeat.PoliticalParty);
            Assert.IsTrue(r.NextOrderedSeatIrrelevantBecausePartyHasOverhangSeat);
            SainteLagueSeatDistribution withOneMoreSeat = SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(newZealandV55Votes, new List<(string, string)>(), 121, newZealandElectoralThreshold, null, newZealandV55ElectorateSeats);
            CollectionAssert.AreEquivalent(r.TotalSeats, withOneMoreSeat.TotalSeats);
            Assert.AreEqual(131, withOneMoreSeat.NumberOfMembers);
        }

        /// <summary>
        /// validates that without electorate seats, Te Pāti Māori is below the 5% threshold, and the parliament stays at
        /// its 120 seats
        /// </summary>
        [TestMethod]
        public void ValidateNewZealandV55WithoutElectorateSeats()
        {
            SainteLagueSeatDistribution r = SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(newZealandV55Votes, new List<(string, string)>(), 120, newZealandElectoralThreshold);
            CollectionAssert.Contains(r.PoliticalPartiesBelowElectoralThreshold, "TePātiMāori");
            Assert.AreEqual(0, r.ElectorateSeats.Count);
            Assert.AreEqual(120, r.NumberOfMembers);
            Assert.IsFalse(r.NextOrderedSeatIrrelevantBecausePartyHasOverhangSeat);
        }

        /// <summary>
        /// validates that electorate seats for a party without party votes, or negative electorate seats, are rejected
        /// </summary>
        [TestMethod]
        [DataRow("Independent", 1)]
        [DataRow("Labour", -1)]
        public void ValidateBadElectorateSeatsAreRejected(string sParty, int iElectorateSeats)
        {
            Dictionary<string, int> electorateSeats = new Dictionary<string, int>() { { sParty, iElectorateSeats } };
            Assert.ThrowsExactly<System.ArgumentException>(() => SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(newZealandV55Votes, new List<(string, string)>(), 120, newZealandElectoralThreshold, null, electorateSeats));
        }

        /// <summary>
        /// small example where D'Hondt, Sainte-Laguë and modified Sainte-Laguë all give different results, with the
        /// smallest party getting a seat only under plain Sainte-Laguë
        /// </summary>
        private static readonly Dictionary<string, long> smallExampleVotes = new Dictionary<string, long>()
        {
            { "A", 53000 }, { "B", 24000 }, { "C", 23000 }, { "D", 9000 },
        };

        private const int smallExampleNumberOfSeats = 7;

        /// <summary>
        /// validates that the electoral threshold is compared exactly: a party with exactly 3.25% of the votes passes,
        /// and one vote fewer doesn't, whether the threshold is 13/4 or 325/100
        /// </summary>
        [TestMethod]
        [DataRow(13L, 4L)]
        [DataRow(325L, 100L)]
        public void ValidateElectoralThresholdIsExact(long lNumerator, long lDenominator)
        {
            SimpleFraction threshold = new SimpleFraction(lNumerator, lDenominator);
            Dictionary<string, long> atThreshold = new Dictionary<string, long>() { { "A", 9675 }, { "B", 325 } };
            CollectionAssert.Contains(SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(atThreshold, new List<(string, string)>(), 10, threshold).Seats.Keys, "B");
            Dictionary<string, long> belowThreshold = new Dictionary<string, long>() { { "A", 9676 }, { "B", 324 } };
            CollectionAssert.Contains(SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(belowThreshold, new List<(string, string)>(), 10, threshold).PoliticalPartiesBelowElectoralThreshold, "B");
        }

        /// <summary>
        /// validates converting decimals to fractions exactly
        /// </summary>
        [TestMethod]
        public void ValidateSimpleFractionFromDecimal()
        {
            Assert.AreEqual("325/100", SimpleFraction.FromDecimal(3.25m).ToString());
            Assert.AreEqual("5/1", SimpleFraction.FromDecimal(5m).ToString());
            Assert.AreEqual("50/10", SimpleFraction.FromDecimal(5.0m).ToString());
        }

        /// <summary>
        /// validates plain Sainte-Laguë on the small example, where the quotients for seats 1-7 are 53000 (A),
        /// 24000 (B), 23000 (C), 53000/3 (A), 53000/5 (A), 9000 (D) and 24000/3 (B), and the next seat goes to C at
        /// 23000/3, ahead of A at 53000/7. D'Hondt gives A 4 seats, B 2, C 1 and D none
        /// </summary>
        [TestMethod]
        public void ValidateSainteLagueSmallExample()
        {
            SainteLagueSeatDistribution r = SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(smallExampleVotes, new List<(string, string)>(), smallExampleNumberOfSeats, noElectoralThreshold);
            CollectionAssert.AreEqual(new[] { "A", "B", "C", "A", "A", "D", "B" }, r.OrderedSeats.Select(s => s.PoliticalParty).ToList());
            CollectionAssert.AreEqual(Enumerable.Range(1, smallExampleNumberOfSeats).ToList(), r.OrderedSeats.Select(s => s.SeatNumber).ToList());
            CollectionAssert.AreEquivalent(new Dictionary<string, int>() { { "A", 3 }, { "B", 2 }, { "C", 1 }, { "D", 1 } }, r.Seats);
            Assert.AreEqual("C", r.NextOrderedSeat.PoliticalParty);
            Assert.AreEqual(8, r.NextOrderedSeat.SeatNumber);

            DHondtSeatDistribution dHondt = SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(smallExampleVotes, new List<(string, string)>(), smallExampleNumberOfSeats, noElectoralThreshold);
            CollectionAssert.AreEquivalent(new Dictionary<string, int>() { { "A", 4 }, { "B", 2 }, { "C", 1 }, { "D", 0 } }, dHondt.Seats);
        }

        /// <summary>
        /// validates modified Sainte-Laguë with a first divisor of 7/5 (1.4) on the small example, where D's first seat
        /// now takes 9000/1.4, about 6429, which is below C's second seat at 23000/3, so D gets nothing and C gets 2
        /// </summary>
        [TestMethod]
        public void ValidateModifiedSainteLagueSmallExample()
        {
            SainteLagueSeatDistribution r = SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(smallExampleVotes, new List<(string, string)>(), smallExampleNumberOfSeats, noElectoralThreshold, new SimpleFraction(7, 5));
            CollectionAssert.AreEqual(new[] { "A", "A", "B", "C", "A", "B", "C" }, r.OrderedSeats.Select(s => s.PoliticalParty).ToList());
            CollectionAssert.AreEquivalent(new Dictionary<string, int>() { { "A", 3 }, { "B", 2 }, { "C", 2 }, { "D", 0 } }, r.Seats);
        }

        /// <summary>
        /// validates that a first divisor that isn't positive or is more than 3 is rejected
        /// </summary>
        [TestMethod]
        [DataRow(0L, 1L)]
        [DataRow(-7L, 5L)]
        [DataRow(7L, -5L)]
        [DataRow(16L, 5L)]
        public void ValidateSainteLagueRejectsBadFirstDivisor(long lNumerator, long lDenominator)
        {
            Assert.ThrowsExactly<System.ArgumentException>(() => SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(smallExampleVotes, new List<(string, string)>(), smallExampleNumberOfSeats, noElectoralThreshold, new SimpleFraction(lNumerator, lDenominator)));
        }

        /// <summary>
        /// validates that under Sainte-Laguë, plain and modified, the next seat gives the same result as recalculating
        /// with one more seat
        /// </summary>
        [TestMethod]
        [DataRow(true, 1L, 1L)]
        [DataRow(false, 1L, 1L)]
        [DataRow(true, 7L, 5L)]
        [DataRow(false, 7L, 5L)]
        [DataRow(false, 6L, 5L)]
        public void ValidateSainteLagueNextOrderedSeatMatchesRecalculatingWithOneMoreSeat(bool useSurplusVoteAgreements, long lNumerator, long lDenominator)
        {
            List<(string, string)> agreements = useSurplusVoteAgreements ? knessetV25SurplusVoteAgreements : new List<(string, string)>();
            SimpleFraction firstDivisor = new SimpleFraction(lNumerator, lDenominator);
            for (int iSeats = knessetNumberOfSeats; iSeats < knessetNumberOfSeats + 20; iSeats++)
            {
                SainteLagueSeatDistribution r = SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(knessetV25Votes, agreements, iSeats, knessetV25ElectoralThreshold, firstDivisor);
                SainteLagueSeatDistribution withOneMoreSeat = SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(knessetV25Votes, agreements, iSeats + 1, knessetV25ElectoralThreshold, firstDivisor);
                Assert.AreEqual(iSeats, r.Seats.Values.Sum());

                Dictionary<string, int> expectedSeats = new Dictionary<string, int>(r.Seats);
                expectedSeats[r.NextOrderedSeat.PoliticalParty]++;
                CollectionAssert.AreEquivalent(expectedSeats, withOneMoreSeat.Seats, $"going from {iSeats} seats to {iSeats + 1}");
            }
        }

        /// <summary>
        /// validates by recalculating that under Sainte-Laguë, plain and modified, the votes needed for the next seat are
        /// enough for its recipients to gain a seat, and that one vote fewer isn't
        /// </summary>
        [TestMethod]
        [DataRow(true, 1L, 1L)]
        [DataRow(false, 1L, 1L)]
        [DataRow(true, 7L, 5L)]
        [DataRow(false, 7L, 5L)]
        [DataRow(false, 6L, 5L)]
        public void ValidateSainteLagueVotesNeededForNextOrderedSeatByRecalculating(bool useSurplusVoteAgreements, long lNumerator, long lDenominator)
        {
            List<(string, string)> agreements = useSurplusVoteAgreements ? knessetV25SurplusVoteAgreements : new List<(string, string)>();
            SimpleFraction firstDivisor = new SimpleFraction(lNumerator, lDenominator);
            for (int iSeats = knessetNumberOfSeats; iSeats < knessetNumberOfSeats + 20; iSeats++)
            {
                SainteLagueSeatDistribution r = SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(knessetV25Votes, agreements, iSeats, knessetV25ElectoralThreshold, firstDivisor);
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
                    SainteLagueSeatDistribution changed = SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(votes, agreements, iSeats, knessetV25ElectoralThreshold, firstDivisor);
                    return recipients.Sum(p => changed.Seats[p]);
                }
            }
        }
    }
}
