using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.FieldsOfStudy.Mathematics;
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
        /// the recipients' votes divided by their seats including this one. Under the D'Hondt method this is the quotient
        /// that won the seat; under other divisor methods it is just for information
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
        /// seats from the vote for each party that passed the electoral threshold. Under mixed-member proportional this
        /// is the party's proportional share, which can be less than its total seats if it won more electorates; see
        /// <see cref="SainteLagueSeatDistribution.TotalSeats"/>
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
    /// result of distributing parliamentary seats using the D'Hondt method
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
        /// <summary>
        /// for mixed-member proportional, the electorates each party that passed the electoral threshold won, including
        /// those that won none. Empty if no electorate seats were given
        /// </summary>
        public Dictionary<string, int> ElectorateSeats { get; set; } = new Dictionary<string, int>();

        /// <summary>
        /// for mixed-member proportional, each party's list seats: its <see cref="SeatDistributionBase.Seats"/> minus
        /// its electorates, or zero if it won more electorates than that. Empty if no electorate seats were given
        /// </summary>
        public Dictionary<string, int> ListSeats { get; set; } = new Dictionary<string, int>();

        /// <summary>
        /// for mixed-member proportional, the electorates each party won beyond its
        /// <see cref="SeatDistributionBase.Seats"/>, which it keeps as extra seats. Empty if no electorate seats were given
        /// </summary>
        public Dictionary<string, int> OverhangSeats { get; set; } = new Dictionary<string, int>();

        /// <summary>
        /// for mixed-member proportional, each party's electorates plus list seats, which is its
        /// <see cref="SeatDistributionBase.Seats"/> plus any overhang. Empty if no electorate seats were given
        /// </summary>
        public Dictionary<string, int> TotalSeats { get; set; } = new Dictionary<string, int>();

        /// <summary>
        /// number of seats in the parliament plus any overhang seats
        /// </summary>
        public int NumberOfMembers { get; set; }

        /// <summary>
        /// for mixed-member proportional, whether <see cref="SeatDistributionBase.NextOrderedSeat"/> would go to a party
        /// with overhang seats. That party already has more electorates than its share, so one more seat in its share
        /// would only take away an overhang seat, leaving its total seats and the number of members the same. The same
        /// goes for <see cref="SeatDistributionBase.VotesNeededForNextOrderedSeat"/>
        /// </summary>
        public bool NextOrderedSeatIrrelevantBecausePartyHasOverhangSeat { get; set; }
    }

    public static class SeatDistributions
    {
        /// <summary>
        /// distributes seats in a single district using the D'Hondt method, which Victor D'Hondt developed in Belgium in
        /// the 1870s and 1880s. The same method was proposed earlier by
        /// <see cref="UnitedStatesPoliticians.JeffersonThomas"/> in the United States in the 1790s, and also developed by
        /// Hagenbach-Bischoff in Switzerland and Bader-Ofer in Israel. Parties below the electoral threshold (a percentage
        /// of all valid votes) get nothing, and surplus vote agreements with such a party are annulled. Each remaining
        /// party gets a base seat per whole quota of qualifying votes. Leftover seats then go one at a time to the party
        /// or surplus vote agreement with the most votes per seat if it got one more, and within an agreement to the party
        /// with the most votes per seat if it got one more. Ties go to the side with more votes. Surplus vote agreements
        /// are an addition to plain D'Hondt, so pass none to get plain D'Hondt
        /// </summary>
        /// <param name="NumberOfVotes">votes for each party. Include every party, since the electoral threshold is a
        /// percentage of all of them; minor parties far below the threshold can be lumped into one entry</param>
        /// <param name="SurplusVoteAgreements">pairs of parties with surplus vote agreements</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        /// <param name="ElectoralThreshold">percentage of all valid votes a party needs for any seats, as a fraction so it is
        /// compared exactly, such as 13/4 or 325/100 for 3.25%</param>
        public static DHondtSeatDistribution CalculateDHondtParliamentarySeatDistributionSingleDistrict(IDictionary<string, long> NumberOfVotes, IEnumerable<(string, string)> SurplusVoteAgreements, int NumberOfSeats, SimpleFraction ElectoralThreshold)
        {
            DHondtSeatDistribution r = new DHondtSeatDistribution();
            List<string> qualifying = ApplyElectoralThreshold(r, NumberOfVotes, NumberOfSeats, ElectoralThreshold, Enumerable.Empty<string>());
            r.Quota = (decimal)r.QualifyingVotes / NumberOfSeats;

            foreach (string sParty in qualifying)
            {
                int iSeats = (int)(NumberOfVotes[sParty] * NumberOfSeats / r.QualifyingVotes);
                r.BaseSeats[sParty] = iSeats;
                r.Seats[sParty] = iSeats;
            }

            List<string[]> recipients = GetRecipients(r, NumberOfVotes, SurplusVoteAgreements, qualifying);
            GiveOutOrderedSeats(r, NumberOfVotes, recipients, GetLinearDivisor(DHondtSlope, new SimpleFraction(1, 1)), NumberOfSeats);
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
        /// party with the highest votes / (2 × seats + 1). Ties go to the side with more votes. Unlike the D'Hondt method
        /// there are no base seats from whole quotas, since Sainte-Laguë can give a party fewer seats than its whole
        /// quotas. Surplus vote agreements are an addition to plain Sainte-Laguë, carried over from how Israel adds them
        /// to D'Hondt, so pass none to get plain Sainte-Laguë. The modified Sainte-Laguë method raises the first divisor
        /// so a party's first seat costs more, which Norway does with 1.4 (7/5) and Sweden did with 1.4 before changing
        /// to 1.2 (6/5) in 2018. For mixed-member proportional, as in New Zealand, pass the electorates each party won:
        /// winning one qualifies a party even below the electoral threshold, the seats are still divided by the party
        /// vote, and a party that won more electorates than its share keeps them as overhang seats
        /// </summary>
        /// <param name="NumberOfVotes">votes for each party. Include every party, since the electoral threshold is a
        /// percentage of all of them; minor parties far below the threshold can be lumped into one entry</param>
        /// <param name="SurplusVoteAgreements">pairs of parties with surplus vote agreements</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        /// <param name="ElectoralThreshold">percentage of all valid votes a party needs for any seats, as a fraction so it is
        /// compared exactly, such as 13/4 or 325/100 for 3.25%</param>
        /// <param name="FirstDivisor">divisor for a party's first seat, with a positive numerator and denominator, and
        /// no more than 3, the divisor for the second seat. Null for plain Sainte-Laguë, which uses 1/1</param>
        /// <param name="ElectorateSeats">for mixed-member proportional, the electorates each party won; parties left out
        /// won none. Each party has to be in <paramref name="NumberOfVotes"/>, so electorates won by independents aren't
        /// supported. Null if there are no electorates</param>
        public static SainteLagueSeatDistribution CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(IDictionary<string, long> NumberOfVotes, IEnumerable<(string, string)> SurplusVoteAgreements, int NumberOfSeats, SimpleFraction ElectoralThreshold, SimpleFraction? FirstDivisor = null, IDictionary<string, int>? ElectorateSeats = null)
        {
            Func<int, long> divisor = GetLinearDivisor(SainteLagueSlope, FirstDivisor);
            foreach (KeyValuePair<string, int> next in ElectorateSeats ?? new Dictionary<string, int>())
            {
                if (!NumberOfVotes.ContainsKey(next.Key)) throw new ArgumentException($"{next.Key} won electorates but has no party votes", nameof(ElectorateSeats));
                if (next.Value < 0) throw new ArgumentException($"{next.Key} has negative electorate seats", nameof(ElectorateSeats));
            }

            SainteLagueSeatDistribution r = new SainteLagueSeatDistribution();
            IEnumerable<string> wonElectorates = ElectorateSeats?.Where(p => p.Value > 0).Select(p => p.Key) ?? Enumerable.Empty<string>();
            List<string> qualifying = ApplyElectoralThreshold(r, NumberOfVotes, NumberOfSeats, ElectoralThreshold, wonElectorates);
            foreach (string sParty in qualifying) r.Seats[sParty] = 0;
            List<string[]> recipients = GetRecipients(r, NumberOfVotes, SurplusVoteAgreements, qualifying);
            GiveOutOrderedSeats(r, NumberOfVotes, recipients, divisor, NumberOfSeats);

            if (ElectorateSeats != null)
            {
                foreach (string sParty in qualifying)
                {
                    int iElectorateSeats = ElectorateSeats.TryGetValue(sParty, out int iWon) ? iWon : 0;
                    int iSeats = r.Seats[sParty];
                    r.ElectorateSeats[sParty] = iElectorateSeats;
                    r.ListSeats[sParty] = Math.Max(0, iSeats - iElectorateSeats);
                    r.OverhangSeats[sParty] = Math.Max(0, iElectorateSeats - iSeats);
                    r.TotalSeats[sParty] = Math.Max(iSeats, iElectorateSeats);
                }
            }
            r.NumberOfMembers = NumberOfSeats + r.OverhangSeats.Values.Sum();
            r.NextOrderedSeatIrrelevantBecausePartyHasOverhangSeat = r.OverhangSeats.GetValueOrDefault(r.NextOrderedSeat.PoliticalParty) > 0;
            return r;
        }

        /// <summary>
        /// gives out the seats not yet in <see cref="SeatDistributionBase.Seats"/> one at a time, filling in
        /// <see cref="SeatDistributionBase.OrderedSeats"/>, <see cref="SeatDistributionBase.OrderedSeatsByRecipient"/>,
        /// <see cref="SeatDistributionBase.NextOrderedSeat"/> and
        /// <see cref="SeatDistributionBase.VotesNeededForNextOrderedSeat"/>. The seats already there, such as D'Hondt's base
        /// seats, decide where it starts, so <see cref="SeatDistributionBase.Seats"/> needs an entry for each qualifying
        /// party first, even if it is zero
        /// </summary>
        /// <param name="divisor">whole-number divisor for a party's next seat, given its current number of seats</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        private static void GiveOutOrderedSeats(SeatDistributionBase r, IDictionary<string, long> NumberOfVotes, List<string[]> recipients, Func<int, long> divisor, int NumberOfSeats)
        {
            for (int iSeat = r.Seats.Values.Sum() + 1; iSeat <= NumberOfSeats; iSeat++)
            {
                OrderedSeat seat = PickOrderedSeat(r, NumberOfVotes, recipients, divisor, iSeat);
                r.OrderedSeats.Add(seat);
                r.OrderedSeatsByRecipient[string.Join(" + ", seat.Recipients)]++;
                r.Seats[seat.PoliticalParty]++;
            }
            r.NextOrderedSeat = PickOrderedSeat(r, NumberOfVotes, recipients, divisor, NumberOfSeats + 1);

            long lNextVotes = r.NextOrderedSeat.Recipients.Sum(p => NumberOfVotes[p]);
            int iNextSeats = r.NextOrderedSeat.Recipients.Sum(p => r.Seats[p]);
            r.VotesNeededForNextOrderedSeat = recipients
                .Where(a => a != r.NextOrderedSeat.Recipients && a.Sum(p => r.Seats[p]) > 0)
                .Min(a => (long?)(GetVotesToWinSeatFrom(iNextSeats, a.Sum(p => NumberOfVotes[p]), a.Sum(p => r.Seats[p]), divisor) - lNextVotes));
        }

        /// <summary>
        /// slope of the D'Hondt divisor: 1, 2, 3, ... for a party's 1st, 2nd, 3rd, ... seat
        /// </summary>
        private static readonly SimpleFraction DHondtSlope = new SimpleFraction(1, 1);

        /// <summary>
        /// slope of the Sainte-Laguë divisor: 1, 3, 5, ... for a party's 1st, 2nd, 3rd, ... seat
        /// </summary>
        private static readonly SimpleFraction SainteLagueSlope = new SimpleFraction(2, 1);

        /// <summary>
        /// gets the divisor for a party's next seat under a linear divisor method, <paramref name="Slope"/> x seats + 1,
        /// with the first one optionally replaced by <paramref name="FirstDivisor"/>. Any divisor of the form a x seats + b
        /// can be written this way with a slope of a/b, since multiplying every divisor by the same number doesn't change
        /// who wins: 1/1 is D'Hondt (1, 2, 3, ...), 2/1 is Sainte-Laguë (1, 3, 5, ...), 3/1 is the Danish method
        /// (1, 4, 7, ...) and 1/2 is Imperiali (2, 3, 4, ... as 1, 3/2, 2, ...). The divisors are all multiplied by both
        /// denominators so they are whole numbers; that is fine since only ratios of quotients are compared, so
        /// Sainte-Laguë with a first divisor of 7/5 goes from 7/5, 3, 5, ... to 7, 15, 25, ...
        /// </summary>
        /// <param name="Slope">how much the divisor goes up with each seat, with a positive numerator and denominator</param>
        /// <param name="FirstDivisor">divisor for a party's first seat instead of 1, with a positive numerator and
        /// denominator, and no more than the second divisor (<paramref name="Slope"/> + 1)</param>
        private static Func<int, long> GetLinearDivisor(SimpleFraction Slope, SimpleFraction FirstDivisor)
        {
            if (Slope.Numerator <= 0 || Slope.Denominator <= 0) throw new ArgumentException($"the slope {Slope} must have a positive numerator and denominator", nameof(Slope));
            if (FirstDivisor.Numerator <= 0 || FirstDivisor.Denominator <= 0) throw new ArgumentException($"the first divisor {FirstDivisor} must have a positive numerator and denominator", nameof(FirstDivisor));

            //with a slope of p/q and a first divisor of m/n, multiplying by q x n gives m x q, then (p x seats + q) x n
            long slopeNumerator = Slope.Numerator;
            long slopeDenominator = Slope.Denominator;
            long first = checked(FirstDivisor.Numerator * slopeDenominator);
            long firstDenominator = FirstDivisor.Denominator;
            Func<int, long> divisor = iSeats => iSeats == 0 ? first : checked((slopeNumerator * iSeats + slopeDenominator) * firstDenominator);

            //past the second divisor a party's second seat would cost less than its first, which breaks giving out seats
            //one at a time
            if (divisor(0) > divisor(1)) throw new ArgumentException($"the first divisor {FirstDivisor} can't be more than the second divisor {checked(slopeNumerator + slopeDenominator)}/{slopeDenominator}", nameof(FirstDivisor));
            return divisor;
        }

        /// <summary>
        /// picks who gets the next seat given out one at a time: first the party or surplus vote agreement with the
        /// highest quotient, then within an agreement the party in it with the highest quotient. A quotient is votes
        /// divided by the divisor for the next seat
        /// </summary>
        /// <param name="divisor">whole-number divisor for the next seat, given the current number of seats</param>
        /// <param name="iSeat">overall seat number of the seat being picked</param>
        private static OrderedSeat PickOrderedSeat(SeatDistributionBase r, IDictionary<string, long> NumberOfVotes, List<string[]> recipients, Func<int, long> divisor, int iSeat)
        {
            //apply the divisor calculation to the parties that passed the electoral threshold, and to the surplus vote agreements that didn't get annulled
            string[] winner = PickHighestQuotient(recipients, a => a.Sum(p => NumberOfVotes[p]), a => a.Sum(p => r.Seats[p]), divisor);

            //apply the divisor calculation to the parties in the agreeement to determine who gets the next seat within the agreement parties
            string sParty = PickHighestQuotient(winner.OrderByDescending(p => NumberOfVotes[p]), p => NumberOfVotes[p], p => r.Seats[p], divisor);

            long lVotes = winner.Sum(p => NumberOfVotes[p]);
            int iSeats = winner.Sum(p => r.Seats[p]);
            return new OrderedSeat(iSeat, winner, sParty, (decimal)lVotes / (iSeats + 1));
        }

        /// <summary>
        /// validates the inputs common to all the methods and applies the electoral threshold, filling in
        /// <see cref="SeatDistributionBase.TotalVotes"/>, <see cref="SeatDistributionBase.QualifyingVotes"/> and
        /// <see cref="SeatDistributionBase.PoliticalPartiesBelowElectoralThreshold"/>
        /// </summary>
        /// <param name="exempt">parties that qualify whatever their votes, such as those that won an electorate under
        /// mixed-member proportional</param>
        /// <returns>the parties that passed the electoral threshold, in the order of <paramref name="NumberOfVotes"/></returns>
        private static List<string> ApplyElectoralThreshold(SeatDistributionBase r, IDictionary<string, long> NumberOfVotes, int NumberOfSeats, SimpleFraction ElectoralThreshold, IEnumerable<string> exempt)
        {
            if (NumberOfSeats <= 0) throw new ArgumentException("the number of seats must be positive", nameof(NumberOfSeats));
            if (ElectoralThreshold.Numerator < 0 || ElectoralThreshold.Denominator <= 0) throw new ArgumentException($"the electoral threshold {ElectoralThreshold} must have a numerator that isn't negative and a positive denominator", nameof(ElectoralThreshold));

            r.TotalVotes = NumberOfVotes.Values.Sum();
            if (r.TotalVotes <= 0) throw new ArgumentException("there are no votes", nameof(NumberOfVotes));

            HashSet<string> exemptSet = [.. exempt];
            List<string> qualifying = new List<string>();
            foreach (KeyValuePair<string, long> next in NumberOfVotes)
            {
                if (next.Value < 0) throw new ArgumentException($"{next.Key} has negative votes", nameof(NumberOfVotes));
                //the party's percentage of the vote, as a fraction so the comparison is exact
                if (exemptSet.Contains(next.Key) || new SimpleFraction(checked(next.Value * 100), r.TotalVotes) >= ElectoralThreshold)
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
        /// gets the fewest total votes a candidate needs for one more seat to come from another candidate, which takes a
        /// higher quotient for the candidate's next seat than the other candidate's last seat was won with:
        ///   votes needed           other votes
        ///   ---------------  &gt;  ---------------------
        ///   divisor(seats)         divisor(other seats - 1)
        /// Under D'Hondt that is seats + 1 against other seats. A tie is also enough if it leaves the candidate with more
        /// votes than the other candidate, since ties go to the side with more votes, which is when its divisor is the
        /// larger one. This compares exactly with integer math
        /// </summary>
        /// <param name="divisor">whole-number divisor for a party's next seat, given its current number of seats</param>
        private static long GetVotesToWinSeatFrom(int iSeats, long lOtherVotes, int iOtherSeats, Func<int, long> divisor)
        {
            long lDivisor = divisor(iSeats);
            long lOtherDivisor = divisor(iOtherSeats - 1);
            long lVotesForTie = Math.DivRem(checked(lOtherVotes * lDivisor), lOtherDivisor, out long lRemainder);
            return lRemainder == 0 && lDivisor > lOtherDivisor ? lVotesForTie : lVotesForTie + 1;
        }

        /// <summary>
        /// picks the candidate with the highest quotient, its votes divided by the divisor for its next seat, comparing
        /// exactly with integer math. Ties go to the first candidate, so callers order candidates by votes
        /// </summary>
        private static T PickHighestQuotient<T>(IEnumerable<T> candidates, Func<T, long> votes, Func<T, int> seats, Func<int, long> divisor)
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
                    //To determine the candidate party(s) that get the next seat, compare the quotients (pick higher value)
                    //  candidate votes                        best votes
                    //  ---------------------------  against   ----------------------
                    //  divisor(candidate seats)               divisor(best seats)
                    //Under D'Hondt the divisor is seats + 1, so this maximizes the votes per seat, intending to keep seats from being
                    //too cheap in votes. That has the side effect of favoring party(s) with more seats, since an extra seat lowers a
                    //larger group's votes per seat by a smaller share. Sainte-Laguë's divisor of 2 x seats + 1 is roughly neutral
                    //between larger and smaller party(s).
                    //The calculation below is a simple transformation of the main equation to use multiplication instead of division,
                    //checked so a divisor scaled too far throws instead of silently overflowing.
                    isBest = checked(lVotes * divisor(iBestSeats) > lBestVotes * divisor(iSeats));
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
