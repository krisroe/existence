using Existence.Earth.Countries.UnitedStates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Existence.Earth.Human.Politics
{
    /// <summary>
    /// a leftover seat, in the order it was given out
    /// </summary>
    public class LeftoverSeat
    {
        /// <summary>
        /// overall seat number, counting the base seats first
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
        /// <param name="Recipients">political parties that receive the leftover seats</param>
        /// <param name="PoliticalParty"></param>
        /// <param name="VotesPerSeat"></param>
        public LeftoverSeat(int SeatNumber, string[] Recipients, string PoliticalParty, decimal VotesPerSeat)
        {
            this.SeatNumber = SeatNumber;
            this.Recipients = Recipients;
            this.PoliticalParty = PoliticalParty;
            this.VotesPerSeat = VotesPerSeat;
        }
    }

    /// <summary>
    /// result of distributing parliamentary seats
    /// </summary>
    public class SeatDistribution
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
        /// qualifying votes per seat
        /// </summary>
        public decimal Quota { get; set; }

        /// <summary>
        /// political parties that fell below the electoral threshold and thus get no representation
        /// </summary>
        public List<string> PoliticalPartiesBelowElectoralThreshold { get; set; } = new List<string>();

        /// <summary>
        /// surplus vote agreements that didn't count because one of the parties fell below the electoral threshold
        /// </summary>
        public List<(string, string)> AnnulledSurplusVoteAgreements { get; set; } = new List<(string, string)>();

        /// <summary>
        /// seats from whole quotas, for each party that passed the electoral threshold
        /// </summary>
        public Dictionary<string, int> BaseSeats { get; set; } = new Dictionary<string, int>();

        /// <summary>
        /// leftover seats in the order they were given out
        /// </summary>
        public List<LeftoverSeat> LeftoverSeats { get; set; } = new List<LeftoverSeat>();

        /// <summary>
        /// number of leftover seats for each party running on its own or surplus vote agreement (keyed as
        /// "Party1 + Party2"), including those that got none
        /// </summary>
        public Dictionary<string, int> LeftoverSeatsByRecipient { get; set; } = new Dictionary<string, int>();

        /// <summary>
        /// total seats for each party that passed the electoral threshold
        /// </summary>
        public Dictionary<string, int> Seats { get; set; } = new Dictionary<string, int>();

        /// <summary>
        /// the leftover seat that would be given out next if the parliament had one more seat, which isn't included in
        /// <see cref="Seats"/>. The result is the same as recalculating with one more seat: that lowers the quota and can
        /// turn leftover seats into base seats, but under the d'Hondt method no existing seat changes hands
        /// </summary>
        public LeftoverSeat NextLeftoverSeat { get; set; } = null!;

        /// <summary>
        /// the fewest extra votes the recipients of <see cref="NextLeftoverSeat"/> would have needed to win a seat from
        /// another party or surplus vote agreement, which is the one with the lowest votes per seat. For a surplus vote
        /// agreement the votes can go to either party, though that can decide which of them gets the seat. Assumes the
        /// votes come from parties that are below the electoral threshold or from people who didn't vote, and that no
        /// party crosses the electoral threshold as a result. Null if no other party or surplus vote agreement has seats
        /// </summary>
        public long? VotesNeededForNextLeftoverSeat { get; set; }
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
        public static SeatDistribution CalculateDHondtParliamentarySeatDistributionSingleDistrict(IDictionary<string, long> NumberOfVotes, IEnumerable<(string, string)> SurplusVoteAgreements, int NumberOfSeats, decimal ElectoralThreshold)
        {
            if (NumberOfSeats <= 0) throw new ArgumentException("the number of seats must be positive", nameof(NumberOfSeats));

            SeatDistribution r = new SeatDistribution();
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
            r.Quota = (decimal)r.QualifyingVotes / NumberOfSeats;

            int iBaseSeats = 0;
            foreach (string sParty in qualifying)
            {
                int iSeats = (int)(NumberOfVotes[sParty] * NumberOfSeats / r.QualifyingVotes);
                r.BaseSeats[sParty] = iSeats;
                r.Seats[sParty] = iSeats;
                iBaseSeats += iSeats;
            }

            HashSet<string> inAgreement = new HashSet<string>(); //list of parties in a surplus vote agreement, to validate a party can only be in one
            List<string[]> recipients = new List<string[]>(); //list of possible recipients of leftover seats, either a single party or a surplus vote agreement
            foreach ((string sParty1, string sParty2) in SurplusVoteAgreements)
            {
                foreach (string sParty in new[] { sParty1, sParty2 })
                {
                    if (!NumberOfVotes.ContainsKey(sParty)) throw new ArgumentException($"surplus vote agreement party {sParty} has no votes", nameof(SurplusVoteAgreements));
                    if (!inAgreement.Add(sParty)) throw new ArgumentException($"{sParty} is in more than one surplus vote agreement, or one with itself", nameof(SurplusVoteAgreements));
                }
                if (r.Seats.ContainsKey(sParty1) && r.Seats.ContainsKey(sParty2))
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
            foreach (string[] next in recipients) r.LeftoverSeatsByRecipient[string.Join(" + ", next)] = 0;

            LeftoverSeat PickLeftoverSeat(int iSeat)
            {
                //apply the d'Hondt calculation to the parties that passed the electoral threshold, and to the surplus vote agreements that didn't get annulled
                string[] winner = PickHighestVotesPerNextSeat(recipients, a => a.Sum(p => NumberOfVotes[p]), a => a.Sum(p => r.Seats[p]));

                //apply the d'Hondt calculation to the parties in the agreeement to determine who gets the next seat within the agreement parties
                string sParty = PickHighestVotesPerNextSeat(winner.OrderByDescending(p => NumberOfVotes[p]), p => NumberOfVotes[p], p => r.Seats[p]);

                long lVotes = winner.Sum(p => NumberOfVotes[p]);
                int iSeats = winner.Sum(p => r.Seats[p]);
                return new LeftoverSeat(iSeat, winner, sParty, (decimal)lVotes / (iSeats + 1));
            }

            for (int iSeat = iBaseSeats + 1; iSeat <= NumberOfSeats; iSeat++)
            {
                LeftoverSeat seat = PickLeftoverSeat(iSeat);
                r.LeftoverSeats.Add(seat);
                r.LeftoverSeatsByRecipient[string.Join(" + ", seat.Recipients)]++;
                r.Seats[seat.PoliticalParty]++;
            }
            r.NextLeftoverSeat = PickLeftoverSeat(NumberOfSeats + 1);

            long lNextVotes = r.NextLeftoverSeat.Recipients.Sum(p => NumberOfVotes[p]);
            int iNextSeats = r.NextLeftoverSeat.Recipients.Sum(p => r.Seats[p]);
            r.VotesNeededForNextLeftoverSeat = recipients
                .Where(a => a != r.NextLeftoverSeat.Recipients && a.Sum(p => r.Seats[p]) > 0)
                .Select(a => (long?)(GetVotesToWinSeatFrom(iNextSeats, a.Sum(p => NumberOfVotes[p]), a.Sum(p => r.Seats[p])) - lNextVotes))
                .Min();
            return r;
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
                    //To determine the candidate party(s) that get the next leftover seat, compare the resultant votes/seat (pick higher value)
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
