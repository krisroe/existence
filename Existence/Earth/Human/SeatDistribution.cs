using Existence.Earth.Countries.UnitedStates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Existence.Earth.Human.Politics
{
    /// <summary>
    /// a seat given out one at a time by a divisor method, in the order it was given out. For a method with base seats
    /// this is a leftover seat
    /// </summary>
    public class OrderedSeat
    {
        /// <summary>
        /// overall seat number, counting any base seats first
        /// </summary>
        public int SeatNumber { get; set; }

        /// <summary>
        /// the party that won the seat on its own, or both parties of the surplus vote agreement that won it
        /// </summary>
        public string[] Recipients { get; set; }

        /// <summary>
        /// the party that got the seat. For a surplus vote agreement, the party in it with the higher votes per seat
        /// if it got one more
        /// </summary>
        public string PoliticalParty { get; set; }

        /// <summary>
        /// the recipients' votes divided by their seats including this one, which won the seat
        /// </summary>
        public decimal VotesPerSeat { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="SeatNumber">seat number</param>
        /// <param name="Recipients">political parties that receive the seat</param>
        /// <param name="PoliticalParty"></param>
        /// <param name="VotesPerSeat"></param>
        public OrderedSeat(int SeatNumber, string[] Recipients, string PoliticalParty, decimal VotesPerSeat)
        {
            this.SeatNumber = SeatNumber;
            this.Recipients = Recipients;
            this.PoliticalParty = PoliticalParty;
            this.VotesPerSeat = VotesPerSeat;
        }
    }

    /// <summary>
    /// result of distributing parliamentary seats, with what all the methods have in common
    /// </summary>
    public abstract class SeatDistributionBase
    {
        /// <summary>
        /// valid votes for all parties, which the electoral threshold is a percentage of
        /// </summary>
        public long TotalVotes { get; set; }

        /// <summary>
        /// votes for the parties that passed the electoral threshold
        /// </summary>
        public long QualifyingVotes { get; set; }

        /// <summary>
        /// political parties that fell below the electoral threshold and thus get no representation
        /// </summary>
        public List<string> PoliticalPartiesBelowElectoralThreshold { get; set; } = new List<string>();

        /// <summary>
        /// surplus vote agreements that didn't count because one of the parties fell below the electoral threshold
        /// </summary>
        public List<(string, string)> AnnulledSurplusVoteAgreements { get; set; } = new List<(string, string)>();

        /// <summary>
        /// seats given out one at a time, in order. For a method with base seats these are the seats left after them;
        /// otherwise they are every seat
        /// </summary>
        public List<OrderedSeat> OrderedSeats { get; set; } = new List<OrderedSeat>();

        /// <summary>
        /// number of <see cref="OrderedSeats"/> for each party running on its own or surplus vote agreement (keyed as
        /// "Party1 + Party2"), including those that got none
        /// </summary>
        public Dictionary<string, int> OrderedSeatsByRecipient { get; set; } = new Dictionary<string, int>();

        /// <summary>
        /// total seats for each party that passed the electoral threshold
        /// </summary>
        public Dictionary<string, int> Seats { get; set; } = new Dictionary<string, int>();

        /// <summary>
        /// the seat that would be given out next if the parliament had one more seat, which isn't included in
        /// <see cref="Seats"/>. The result is the same as recalculating with one more seat, since under a divisor method
        /// adding a seat never takes one away from a party. For a method with base seats, recalculating lowers the quota
        /// and can turn leftover seats into base seats, but the totals are the same
        /// </summary>
        public OrderedSeat NextOrderedSeat { get; set; } = null!;

        /// <summary>
        /// the fewest extra votes the recipients of <see cref="NextOrderedSeat"/> would have needed to win a seat from
        /// another party or surplus vote agreement, which is the one whose last seat was won with the lowest quotient. For a surplus vote
        /// agreement the votes can go to either party, though that can decide which of them gets the seat. Assumes the
        /// votes come from parties that are below the electoral threshold or from people who didn't vote, and that no
        /// party crosses the electoral threshold as a result. Null if no other party or surplus vote agreement has seats
        /// </summary>
        public long? VotesNeededForNextOrderedSeat { get; set; }
    }

    /// <summary>
    /// result of distributing parliamentary seats using the d'Hondt method
    /// </summary>
    public class DHondtSeatDistribution : SeatDistributionBase
    {
        /// <summary>
        /// qualifying votes per seat
        /// </summary>
        public decimal Quota { get; set; }

        /// <summary>
        /// seats from whole quotas, for each party that passed the electoral threshold
        /// </summary>
        public Dictionary<string, int> BaseSeats { get; set; } = new Dictionary<string, int>();
    }

    /// <summary>
    /// result of distributing parliamentary seats using the Sainte-Laguë method, which has no base seats
    /// </summary>
    public class SainteLagueSeatDistribution : SeatDistributionBase
    {
    }

    public static class SeatDistributions
    {
        /// <summary>
        /// distributes seats in a single district using the d'Hondt method, which Victor d'Hondt developed in Belgium in
        /// the 1870s and 1880s. The same method was proposed earlier by
        /// <see cref="UnitedStatesPoliticians.JeffersonThomas"/> in the United States in the 1790s, and also developed by
        /// Hagenbach-Bischoff in Switzerland and Bader-Ofer in Israel. Parties below the electoral threshold (a percentage
        /// of all valid votes) get nothing, and surplus vote agreements with such a party are annulled. Each remaining
        /// party gets a base seat per whole quota of qualifying votes. Leftover seats then go one at a time to the party
        /// or surplus vote agreement with the most votes per seat if it got one more, and within an agreement to the party
        /// with the most votes per seat if it got one more. Ties go to the side with more votes. Surplus vote agreements
        /// are an addition to plain d'Hondt, so pass none to get plain d'Hondt
        /// </summary>
        /// <param name="NumberOfVotes">votes for each party. Include every party, since the electoral threshold is a
        /// percentage of all of them; minor parties far below the threshold can be lumped into one entry</param>
        /// <param name="SurplusVoteAgreements">pairs of parties with surplus vote agreements</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        /// <param name="ElectoralThreshold">percentage of all valid votes a party needs for any seats</param>
        public static DHondtSeatDistribution CalculateDHondtParliamentarySeatDistributionSingleDistrict(IDictionary<string, long> NumberOfVotes, IEnumerable<(string, string)> SurplusVoteAgreements, int NumberOfSeats, decimal ElectoralThreshold)
        {
            DHondtSeatDistribution r = new DHondtSeatDistribution();
            List<string> qualifying = ApplyElectoralThreshold(r, NumberOfVotes, NumberOfSeats, ElectoralThreshold);
            r.Quota = (decimal)r.QualifyingVotes / NumberOfSeats;

            int iBaseSeats = 0;
            foreach (string sParty in qualifying)
            {
                int iSeats = (int)(NumberOfVotes[sParty] * NumberOfSeats / r.QualifyingVotes);
                r.BaseSeats[sParty] = iSeats;
                r.Seats[sParty] = iSeats;
                iBaseSeats += iSeats;
            }

            List<string[]> recipients = GetRecipients(r, NumberOfVotes, SurplusVoteAgreements, qualifying);

            OrderedSeat PickOrderedSeat(int iSeat)
            {
                //apply the d'Hondt calculation to the parties that passed the electoral threshold, and to the surplus vote agreements that didn't get annulled
                string[] winner = PickHighestVotesPerNextSeat(recipients, a => a.Sum(p => NumberOfVotes[p]), a => a.Sum(p => r.Seats[p]));

                //apply the d'Hondt calculation to the parties in the agreeement to determine who gets the next seat within the agreement parties
                string sParty = PickHighestVotesPerNextSeat(winner.OrderByDescending(p => NumberOfVotes[p]), p => NumberOfVotes[p], p => r.Seats[p]);

                long lVotes = winner.Sum(p => NumberOfVotes[p]);
                int iSeats = winner.Sum(p => r.Seats[p]);
                return new OrderedSeat(iSeat, winner, sParty, (decimal)lVotes / (iSeats + 1));
            }

            for (int iSeat = iBaseSeats + 1; iSeat <= NumberOfSeats; iSeat++)
            {
                OrderedSeat seat = PickOrderedSeat(iSeat);
                r.OrderedSeats.Add(seat);
                r.OrderedSeatsByRecipient[string.Join(" + ", seat.Recipients)]++;
                r.Seats[seat.PoliticalParty]++;
            }
            r.NextOrderedSeat = PickOrderedSeat(NumberOfSeats + 1);

            long lNextVotes = r.NextOrderedSeat.Recipients.Sum(p => NumberOfVotes[p]);
            int iNextSeats = r.NextOrderedSeat.Recipients.Sum(p => r.Seats[p]);
            r.VotesNeededForNextOrderedSeat = recipients
                .Where(a => a != r.NextOrderedSeat.Recipients && a.Sum(p => r.Seats[p]) > 0)
                .Select(a => (long?)(GetVotesToWinSeatFrom(iNextSeats, a.Sum(p => NumberOfVotes[p]), a.Sum(p => r.Seats[p])) - lNextVotes))
                .Min();
            return r;
        }

        /// <summary>
        /// distributes seats in a single district using the Sainte-Laguë method, which André Sainte-Laguë proposed in
        /// France in 1910. The same method was proposed earlier by <see cref="UnitedStatesPoliticians.WebsterDaniel"/> in
        /// the United States in 1832 for apportioning the House of Representatives, and was used that way after the 1840,
        /// 1910 and 1930 censuses. Hans Schepers also developed it in Germany, where it is known as Sainte-Laguë/Schepers.
        /// Parties below the electoral threshold (a percentage of all valid votes) get nothing, and surplus vote
        /// agreements with such a party are annulled. Seats then go one at a time to the party or surplus vote agreement
        /// with the highest votes / (2 × seats + 1), so the divisors are 1, 3, 5, ..., and within an agreement to the
        /// party with the highest votes / (2 × seats + 1). Ties go to the side with more votes. Unlike the d'Hondt method
        /// there are no base seats from whole quotas, since Sainte-Laguë can give a party fewer seats than its whole
        /// quotas. Surplus vote agreements are an addition to plain Sainte-Laguë, carried over from how Israel adds them
        /// to d'Hondt, so pass none to get plain Sainte-Laguë
        /// </summary>
        /// <param name="NumberOfVotes">votes for each party. Include every party, since the electoral threshold is a
        /// percentage of all of them; minor parties far below the threshold can be lumped into one entry</param>
        /// <param name="SurplusVoteAgreements">pairs of parties with surplus vote agreements</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        /// <param name="ElectoralThreshold">percentage of all valid votes a party needs for any seats</param>
        public static SainteLagueSeatDistribution CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(IDictionary<string, long> NumberOfVotes, IEnumerable<(string, string)> SurplusVoteAgreements, int NumberOfSeats, decimal ElectoralThreshold)
        {
            SainteLagueSeatDistribution r = new SainteLagueSeatDistribution();
            List<string> qualifying = ApplyElectoralThreshold(r, NumberOfVotes, NumberOfSeats, ElectoralThreshold);
            List<string[]> recipients = GetRecipients(r, NumberOfVotes, SurplusVoteAgreements, qualifying);
            throw new NotImplementedException();
        }

        /// <summary>
        /// validates the inputs common to all the methods and applies the electoral threshold, filling in
        /// <see cref="SeatDistributionBase.TotalVotes"/>, <see cref="SeatDistributionBase.QualifyingVotes"/> and
        /// <see cref="SeatDistributionBase.PoliticalPartiesBelowElectoralThreshold"/>
        /// </summary>
        /// <returns>the parties that passed the electoral threshold, in the order of <paramref name="NumberOfVotes"/></returns>
        private static List<string> ApplyElectoralThreshold(SeatDistributionBase r, IDictionary<string, long> NumberOfVotes, int NumberOfSeats, decimal ElectoralThreshold)
        {
            if (NumberOfSeats <= 0) throw new ArgumentException("the number of seats must be positive", nameof(NumberOfSeats));

            r.TotalVotes = NumberOfVotes.Values.Sum();
            if (r.TotalVotes <= 0) throw new ArgumentException("there are no votes", nameof(NumberOfVotes));

            List<string> qualifying = new List<string>();
            foreach (KeyValuePair<string, long> next in NumberOfVotes)
            {
                if (next.Value < 0) throw new ArgumentException($"{next.Key} has negative votes", nameof(NumberOfVotes));
                if (next.Value * 100m >= ElectoralThreshold * r.TotalVotes)
                    qualifying.Add(next.Key);
                else
                    r.PoliticalPartiesBelowElectoralThreshold.Add(next.Key);
            }
            if (qualifying.Count == 0) throw new InvalidOperationException("no party passed the electoral threshold");
            r.QualifyingVotes = qualifying.Sum(p => NumberOfVotes[p]);
            return qualifying;
        }

        /// <summary>
        /// validates the surplus vote agreements and gets the possible recipients of seats given out one at a time: each
        /// surplus vote agreement whose parties both passed the electoral threshold, and each other qualifying party on
        /// its own. Fills in <see cref="SeatDistributionBase.AnnulledSurplusVoteAgreements"/>, and
        /// <see cref="SeatDistributionBase.OrderedSeatsByRecipient"/> with zero seats for each recipient
        /// </summary>
        /// <returns>the recipients, ordered by votes descending, which is how ties are broken</returns>
        private static List<string[]> GetRecipients(SeatDistributionBase r, IDictionary<string, long> NumberOfVotes, IEnumerable<(string, string)> SurplusVoteAgreements, List<string> qualifying)
        {
            HashSet<string> qualifyingSet = new HashSet<string>(qualifying);
            HashSet<string> inAgreement = new HashSet<string>(); //list of parties in a surplus vote agreement, to validate a party can only be in one
            List<string[]> recipients = new List<string[]>(); //list of possible recipients of seats, either a single party or a surplus vote agreement
            foreach ((string sParty1, string sParty2) in SurplusVoteAgreements)
            {
                foreach (string sParty in new[] { sParty1, sParty2 })
                {
                    if (!NumberOfVotes.ContainsKey(sParty)) throw new ArgumentException($"surplus vote agreement party {sParty} has no votes", nameof(SurplusVoteAgreements));
                    if (!inAgreement.Add(sParty)) throw new ArgumentException($"{sParty} is in more than one surplus vote agreement, or one with itself", nameof(SurplusVoteAgreements));
                }
                if (qualifyingSet.Contains(sParty1) && qualifyingSet.Contains(sParty2))
                    recipients.Add(new[] { sParty1, sParty2 });
                else
                    r.AnnulledSurplusVoteAgreements.Add((sParty1, sParty2));
            }

            //add any qualifying parties not in a surplus vote agreement
            foreach (string sParty in qualifying)
            {
                if (!recipients.Any(a => a.Contains(sParty))) recipients.Add(new[] { sParty });
            }

            recipients = recipients.OrderByDescending(a => a.Sum(p => NumberOfVotes[p])).ToList();
            foreach (string[] next in recipients) r.OrderedSeatsByRecipient[string.Join(" + ", next)] = 0;
            return recipients;
        }

        /// <summary>
        /// gets the fewest total votes a candidate needs for one more seat to come from another candidate, which takes
        /// more votes per seat, including that seat, than the other candidate has now:
        ///   votes needed       other votes
        ///   ---------------  &gt;  -----------
        ///   seats + 1          other seats
        /// A tie is also enough if it leaves the candidate with more votes than the other candidate, since ties go to the
        /// side with more votes, which is when it would have more seats. This compares exactly with integer math
        /// </summary>
        private static long GetVotesToWinSeatFrom(int iSeats, long lOtherVotes, int iOtherSeats)
        {
            long lVotesForTie = Math.DivRem(lOtherVotes * (iSeats + 1L), iOtherSeats, out long lRemainder);
            return lRemainder == 0 && iSeats + 1 > iOtherSeats ? lVotesForTie : lVotesForTie + 1;
        }

        /// <summary>
        /// picks the candidate with the most votes per seat if it got one more, comparing exactly with integer math.
        /// Ties go to the first candidate, so callers order candidates by votes
        /// </summary>
        private static T PickHighestVotesPerNextSeat<T>(IEnumerable<T> candidates, Func<T, long> votes, Func<T, int> seats)
        {
            T best = default!;
            long lBestVotes = -1;
            int iBestSeats = 0;
            foreach (T next in candidates)
            {
                long lVotes = votes(next); //number of votes for the candidate party(s)
                int iSeats = seats(next); //current number of seats for the candidate party(s)
                bool isBest;
                if (lBestVotes < 0) //first candidate
                {
                    isBest = true;
                }
                else
                {
                    //To determine the candidate party(s) that get the next seat, compare the resultant votes/seat (pick higher value)
                    //  candidate votes                 best votes
                    //  -------------------  against    --------------
                    //  candidate seats + 1             best seats + 1
                    //This maximizes the votes per seat, intending to keep seats from being too cheap in votes.
                    //This has the side effect of favoring party(s) with more seats, since an extra seat lowers a larger group's votes
                    //per seat by a smaller share.
                    //The calculation below is a simple transformation of the main equation to use multiplication instead of division.
                    isBest = lVotes * (iBestSeats + 1L) > lBestVotes * (iSeats + 1L);
                }
                if (isBest)
                {
                    best = next;
                    lBestVotes = lVotes;
                    iBestSeats = iSeats;
                }
            }
            return best;
        }
    }
}
