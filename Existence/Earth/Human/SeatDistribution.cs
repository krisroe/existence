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
        /// the party that won the seat on its own, or both parties of the surplus vote agreement that won it, with the
        /// party that got the seat first and then the others by votes descending
        /// </summary>
        public List<OrderedSeatRecipient> Recipients { get; set; }

        /// <summary>
        /// the party that got the seat. For a surplus vote agreement, the party in it with the highest
        /// <see cref="OrderedSeatRecipient.Quotient"/>
        /// </summary>
        public string PoliticalParty { get; set; }

        /// <summary>
        /// what the recipients' combined votes were divided by: slope x their combined seats before this one + 1, or
        /// the first divisor if they had none. In lowest terms, so it's a whole number except for a modified first
        /// divisor such as 7/5
        /// </summary>
        public SimpleFraction Divisor { get; set; }

        /// <summary>
        /// how <see cref="Divisor"/> was worked out, such as "2*3 + 1" for a party's fourth seat under Sainte-Laguë,
        /// "1*(10+7) + 1" for a surplus vote agreement whose parties had 10 and 7 seats under D'Hondt (in the order of
        /// <see cref="Recipients"/>), or just "6/5" for a modified first divisor
        /// </summary>
        public string DivisorCalculation { get; set; }

        /// <summary>
        /// the recipients' combined votes divided by <see cref="Divisor"/>, raised by any minority list quotient bonus,
        /// the quotient that won the seat (for information, since the comparison itself is done exactly with whole
        /// numbers)
        /// </summary>
        public decimal Quotient { get; set; }

        /// <summary>
        /// IDs of the recipients in the order the method uses for them, whose names joined with " + " are the keys of
        /// <see cref="SeatDistributionBase.OrderedSeatsByRecipient"/>
        /// </summary>
        internal int[] RecipientGroup { get; set; }

        /// <summary>
        /// ID of <see cref="PoliticalParty"/>
        /// </summary>
        internal int PoliticalPartyId { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="SeatNumber">seat number</param>
        /// <param name="RecipientGroup">IDs of the political parties that receive the seat, in the order the method uses
        /// for them</param>
        /// <param name="PoliticalPartyId">ID of the party that got the seat, which is the first of
        /// <paramref name="Recipients"/></param>
        /// <param name="Recipients">each recipient's own divisor and quotient, with the one that got the seat first</param>
        /// <param name="Divisor">what the recipients' combined votes were divided by</param>
        /// <param name="DivisorCalculation">how <paramref name="Divisor"/> was worked out</param>
        /// <param name="Quotient">the recipients' combined votes divided by <paramref name="Divisor"/></param>
        internal OrderedSeat(int SeatNumber, int[] RecipientGroup, int PoliticalPartyId, List<OrderedSeatRecipient> Recipients, SimpleFraction Divisor, string DivisorCalculation, decimal Quotient)
        {
            this.SeatNumber = SeatNumber;
            this.RecipientGroup = RecipientGroup;
            this.PoliticalPartyId = PoliticalPartyId;
            this.Recipients = Recipients;
            this.PoliticalParty = Recipients[0].PoliticalParty;
            this.Divisor = Divisor;
            this.DivisorCalculation = DivisorCalculation;
            this.Quotient = Quotient;
        }
    }

    /// <summary>
    /// one party among the recipients of an <see cref="OrderedSeat"/>, with the calculation that decides which party in
    /// a surplus vote agreement gets the seat. For a party on its own this is the same as the seat's
    /// </summary>
    public class OrderedSeatRecipient
    {
        /// <summary>
        /// the party
        /// </summary>
        public string PoliticalParty { get; set; }

        /// <summary>
        /// what the party's own votes were divided by: slope x its seats before this one + 1, or the first divisor if it
        /// had none, in lowest terms
        /// </summary>
        public SimpleFraction Divisor { get; set; }

        /// <summary>
        /// how <see cref="Divisor"/> was worked out, such as "1*10 + 1" for a party with 10 seats under D'Hondt
        /// </summary>
        public string DivisorCalculation { get; set; }

        /// <summary>
        /// the party's own votes divided by <see cref="Divisor"/>, raised by any minority list quotient bonus (for
        /// information, since the comparison itself is done exactly with whole numbers)
        /// </summary>
        public decimal Quotient { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="PoliticalParty">the party</param>
        /// <param name="Divisor">what the party's own votes were divided by</param>
        /// <param name="DivisorCalculation">how <paramref name="Divisor"/> was worked out</param>
        /// <param name="Quotient">the party's own votes divided by <paramref name="Divisor"/></param>
        public OrderedSeatRecipient(string PoliticalParty, SimpleFraction Divisor, string DivisorCalculation, decimal Quotient)
        {
            this.PoliticalParty = PoliticalParty;
            this.Divisor = Divisor;
            this.DivisorCalculation = DivisorCalculation;
            this.Quotient = Quotient;
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
        /// party crosses the electoral threshold as a result, which for a minority list with a quotient bonus would lose
        /// it the bonus. A minority list's extra votes count with its bonus. Null if no other party or surplus vote
        /// agreement has seats
        /// </summary>
        public long? VotesNeededForNextOrderedSeat { get; set; }
    }

    /// <summary>
    /// result of distributing parliamentary seats using the D'Hondt method
    /// </summary>
    public class DHondtSeatDistribution : SeatDistributionBase
    {
        /// <summary>
        /// qualifying votes per seat, with the votes of <see cref="MinorityListsWithQuotientBonus"/> counted with their
        /// bonus
        /// </summary>
        public decimal Quota { get; set; }

        /// <summary>
        /// minority lists below the electoral threshold, which qualify anyway and have their quotients raised by the
        /// minority list quotient bonus, in the order the parties were given. Empty without a bonus
        /// </summary>
        public List<string> MinorityListsWithQuotientBonus { get; set; } = new List<string>();

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

    /// <summary>
    /// a party's votes, for working out a seat distribution by party ID
    /// </summary>
    /// <param name="Id">the party's number: 1 for the party with the most votes, then 2, 3 and so on up to the number of
    /// parties as the votes go down, so a party with more votes always has a lower ID. Parties with the same votes can
    /// be in either order, and the one with the lower ID wins a tie between them</param>
    /// <param name="Name">the party's name, which the results use</param>
    /// <param name="Votes">votes for the party, not negative</param>
    public sealed record PoliticalPartyVotes(int Id, string Name, long Votes);

    public static class SeatDistributions
    {
        /// <summary>
        /// gets the parties with IDs from 1 for the most votes, with ties in the order given, for working out a seat
        /// distribution given votes by party name. Negative votes are rejected here, as they would be by party ID
        /// </summary>
        /// <returns>the parties in the order given</returns>
        private static List<PoliticalPartyVotes> AssignIds(IDictionary<string, long> NumberOfVotes)
        {
            foreach (KeyValuePair<string, long> next in NumberOfVotes)
            {
                if (next.Value < 0) throw new ArgumentException($"{next.Key} has negative votes", nameof(NumberOfVotes));
            }
            Dictionary<string, int> ids = NumberOfVotes.OrderByDescending(p => p.Value).Select((p, i) => (p.Key, Id: i + 1)).ToDictionary(p => p.Key, p => p.Id);
            return NumberOfVotes.Select(p => new PoliticalPartyVotes(ids[p.Key], p.Key, p.Value)).ToList();
        }

        /// <summary>
        /// gets the surplus vote agreements by party ID, given them by party name
        /// </summary>
        private static List<(int, int)> GetSurplusVoteAgreementIds(List<PoliticalPartyVotes> parties, IEnumerable<(string, string)> SurplusVoteAgreements)
        {
            Dictionary<string, int> ids = parties.ToDictionary(p => p.Name, p => p.Id);
            int GetId(string sParty) => ids.TryGetValue(sParty, out int ret) ? ret : throw new ArgumentException($"surplus vote agreement party {sParty} has no votes", nameof(SurplusVoteAgreements));
            return SurplusVoteAgreements.Select(a => (GetId(a.Item1), GetId(a.Item2))).ToList();
        }

        /// <summary>
        /// gets the electorates each party won by party ID, given them by party name
        /// </summary>
        /// <returns>null if <paramref name="ElectorateSeats"/> is</returns>
        private static Dictionary<int, int>? GetElectorateSeatIds(List<PoliticalPartyVotes> parties, IDictionary<string, int>? ElectorateSeats)
        {
            Dictionary<int, int>? ret = null;
            if (ElectorateSeats != null)
            {
                Dictionary<string, int> ids = parties.ToDictionary(p => p.Name, p => p.Id);
                ret = new Dictionary<int, int>();
                foreach (KeyValuePair<string, int> next in ElectorateSeats)
                {
                    if (!ids.TryGetValue(next.Key, out int iId)) throw new ArgumentException($"{next.Key} won electorates but has no party votes", nameof(ElectorateSeats));
                    ret[iId] = next.Value;
                }
            }
            return ret;
        }

        /// <summary>
        /// same as <see cref="CalculateDHondtParliamentarySeatDistributionSingleDistrict(IReadOnlyList{PoliticalPartyVotes}, IEnumerable{ValueTuple{int, int}}, int, SimpleFraction)"/>,
        /// with the parties given by name and their IDs worked out from their votes
        /// </summary>
        /// <param name="NumberOfVotes">votes for each party. Include every party, since the electoral threshold is a
        /// percentage of all of them; minor parties far below the threshold can be lumped into one entry. Parties with
        /// the same votes are taken to be in the order given</param>
        /// <param name="SurplusVoteAgreements">pairs of parties with surplus vote agreements</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        /// <param name="ElectoralThreshold">percentage of all valid votes a party needs for any seats, as a fraction so it is
        /// compared exactly, such as 13/4 or 325/100 for 3.25%</param>
        /// <param name="MinorityLists">national minority lists, which qualify whatever their votes. Each has to be in
        /// <paramref name="NumberOfVotes"/>. Null if there are none</param>
        /// <param name="MinorityListQuotientBonus">percentage the quotients of minority lists below the electoral
        /// threshold are raised by, such as 35/1 for Serbia. Null for no bonus</param>
        public static DHondtSeatDistribution CalculateDHondtParliamentarySeatDistributionSingleDistrict(IDictionary<string, long> NumberOfVotes, IEnumerable<(string, string)> SurplusVoteAgreements, int NumberOfSeats, SimpleFraction ElectoralThreshold, IEnumerable<string>? MinorityLists = null, SimpleFraction? MinorityListQuotientBonus = null)
        {
            List<PoliticalPartyVotes> parties = AssignIds(NumberOfVotes);
            List<int>? minorityListIds = null;
            if (MinorityLists != null)
            {
                Dictionary<string, int> ids = parties.ToDictionary(p => p.Name, p => p.Id);
                minorityListIds = MinorityLists.Select(p => ids.TryGetValue(p, out int iId) ? iId : throw new ArgumentException($"minority list {p} has no votes", nameof(MinorityLists))).ToList();
            }
            return CalculateDHondtParliamentarySeatDistributionSingleDistrict(parties, GetSurplusVoteAgreementIds(parties, SurplusVoteAgreements), NumberOfSeats, ElectoralThreshold, minorityListIds, MinorityListQuotientBonus);
        }

        /// <summary>
        /// distributes seats in a single district using the D'Hondt method, which Victor D'Hondt developed in Belgium in
        /// the 1870s and 1880s. The same method was proposed earlier by
        /// <see cref="UnitedStatesPoliticians.JeffersonThomas"/> in the United States in the 1790s, and also developed by
        /// Hagenbach-Bischoff in Switzerland and Bader-Ofer in Israel. Parties below the electoral threshold (a percentage
        /// of all valid votes) get nothing, and surplus vote agreements with such a party are annulled. Each remaining
        /// party gets a base seat per whole quota of qualifying votes. Leftover seats then go one at a time to the party
        /// or surplus vote agreement with the most votes per seat if it got one more, and within an agreement to the party
        /// with the most votes per seat if it got one more. Ties go to the side with more votes. Surplus vote agreements
        /// are an addition to plain D'Hondt, so pass none to get plain D'Hondt. National minority lists can be exempt
        /// from the electoral threshold, as in Serbia and Poland, and in Serbia those below it also have their quotients
        /// raised by 35%. A bonus is the same as counting the list's votes with the bonus, so the base seats come from
        /// whole quotas of the votes counted that way. The calculation works with party IDs, and the results give the
        /// parties by name
        /// </summary>
        /// <param name="Parties">votes for each party, with IDs from 1 for the most votes. Include every party, since the
        /// electoral threshold is a percentage of all of them; minor parties far below the threshold can be lumped into
        /// one entry. The results list parties in this order</param>
        /// <param name="SurplusVoteAgreements">pairs of party IDs with surplus vote agreements. A minority list with a
        /// quotient bonus can only be in one that isn't annulled with another party that has the bonus</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        /// <param name="ElectoralThreshold">percentage of all valid votes a party needs for any seats, as a fraction so it is
        /// compared exactly, such as 13/4 or 325/100 for 3.25%</param>
        /// <param name="MinorityLists">IDs of national minority lists, which qualify whatever their votes. Null if there
        /// are none</param>
        /// <param name="MinorityListQuotientBonus">percentage the quotients of minority lists below the electoral
        /// threshold are raised by, such as 35/1 for Serbia, with a numerator that isn't negative and a positive
        /// denominator. Lists at or above the threshold get no bonus. Null for no bonus</param>
        public static DHondtSeatDistribution CalculateDHondtParliamentarySeatDistributionSingleDistrict(IReadOnlyList<PoliticalPartyVotes> Parties, IEnumerable<(int, int)> SurplusVoteAgreements, int NumberOfSeats, SimpleFraction ElectoralThreshold, IEnumerable<int>? MinorityLists = null, SimpleFraction? MinorityListQuotientBonus = null)
        {
            Election e = new Election(Parties);
            HashSet<int> minorityLists = new HashSet<int>();
            foreach (int iParty in MinorityLists ?? Enumerable.Empty<int>())
            {
                if (iParty < 1 || iParty >= e.Names.Length) throw new ArgumentException($"minority list party ID {iParty} has no votes", nameof(MinorityLists));
                if (!minorityLists.Add(iParty)) throw new ArgumentException($"{e.Names[iParty]} is a minority list more than once", nameof(MinorityLists));
            }
            if (MinorityListQuotientBonus != null && (MinorityListQuotientBonus.Numerator < 0 || MinorityListQuotientBonus.Denominator <= 0))
                throw new ArgumentException($"the minority list quotient bonus {MinorityListQuotientBonus} must have a numerator that isn't negative and a positive denominator", nameof(MinorityListQuotientBonus));

            DHondtSeatDistribution r = new DHondtSeatDistribution();
            List<int> qualifying = ApplyElectoralThreshold(r, e, NumberOfSeats, ElectoralThreshold, minorityLists);
            if (MinorityListQuotientBonus != null && MinorityListQuotientBonus.Numerator > 0)
            {
                HashSet<int> withBonus = qualifying.Where(p => minorityLists.Contains(p) && !IsAtElectoralThreshold(e.Votes[p], r.TotalVotes, ElectoralThreshold)).ToHashSet();
                e.ApplyQuotientBonus(withBonus, MinorityListQuotientBonus);
                r.MinorityListsWithQuotientBonus.AddRange(qualifying.Where(withBonus.Contains).Select(p => e.Names[p]));
            }

            long lQualifyingQuotientVotes = qualifying.Sum(e.QuotientVotes);
            r.Quota = (decimal)lQualifyingQuotientVotes / e.QuotientScale / NumberOfSeats;
            foreach (int iParty in qualifying)
            {
                int iSeats = (int)(checked(e.QuotientVotes(iParty) * NumberOfSeats) / lQualifyingQuotientVotes);
                r.BaseSeats[e.Names[iParty]] = iSeats;
                e.Seats[iParty] = iSeats;
            }

            List<int[]> recipients = GetRecipients(r, e, SurplusVoteAgreements, qualifying);

            //the votes needed for the next seat can go to either party of a surplus vote agreement, which only works out
            //when the bonus is the same for both
            int[]? mixed = recipients.FirstOrDefault(a => a.Any(p => e.QuotientWeights[p] != e.QuotientWeights[a[0]]));
            if (mixed != null) throw new ArgumentException($"{e.GetName(mixed)} is a surplus vote agreement with a minority list quotient bonus for only one of the parties", nameof(SurplusVoteAgreements));
            GiveOutOrderedSeats(r, e, recipients, GetLinearDivisor(DHondtSlope, new SimpleFraction(1, 1)), NumberOfSeats);
            CopySeats(r, e, qualifying);
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
        /// vote, and a party that won more electorates than its share keeps them as overhang seats. The calculation works
        /// with party IDs, and the results give the parties by name
        /// </summary>
        /// <param name="Parties">votes for each party, with IDs from 1 for the most votes. Include every party, since the
        /// electoral threshold is a percentage of all of them; minor parties far below the threshold can be lumped into
        /// one entry. The results list parties in this order</param>
        /// <param name="SurplusVoteAgreements">pairs of party IDs with surplus vote agreements</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        /// <param name="ElectoralThreshold">percentage of all valid votes a party needs for any seats, as a fraction so it is
        /// compared exactly, such as 13/4 or 325/100 for 3.25%</param>
        /// <param name="FirstDivisor">divisor for a party's first seat, with a positive numerator and denominator, and
        /// no more than 3, the divisor for the second seat. Null for plain Sainte-Laguë, which uses 1/1</param>
        /// <param name="ElectorateSeats">for mixed-member proportional, the electorates each party won, by party ID;
        /// parties left out won none. Each party has to be in <paramref name="Parties"/>, so electorates won by
        /// independents aren't supported. Null if there are no electorates</param>
        public static SainteLagueSeatDistribution CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(IReadOnlyList<PoliticalPartyVotes> Parties, IEnumerable<(int, int)> SurplusVoteAgreements, int NumberOfSeats, SimpleFraction ElectoralThreshold, SimpleFraction? FirstDivisor = null, IDictionary<int, int>? ElectorateSeats = null)
        {
            return CalculateSainteLague(Parties, SurplusVoteAgreements, NumberOfSeats, ElectoralThreshold, FirstDivisor, ElectorateSeats, GiveOutOrderedSeats);
        }

        /// <summary>
        /// same as the Sainte-Laguë method by party ID with the same result, but worked out with a quotient table, the way
        /// New Zealand's Electoral Commission does it. Instead of going seat by seat and recalculating each party's
        /// quotient as it wins seats, every party's votes are divided by all the divisors up front (1, 3, 5, ...), all the
        /// quotients go in one table, and the highest ones, as many as there are seats, each win a seat. A surplus vote
        /// agreement goes in the table with its combined votes, and its seats are then shared out with a second table
        /// that has just its own parties. Ties go to the side with more votes
        /// </summary>
        /// <param name="Parties">votes for each party, with IDs from 1 for the most votes</param>
        /// <param name="SurplusVoteAgreements">pairs of party IDs with surplus vote agreements</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        /// <param name="ElectoralThreshold">percentage of all valid votes a party needs for any seats</param>
        /// <param name="FirstDivisor">divisor for a party's first seat. Null for plain Sainte-Laguë, which uses 1/1</param>
        /// <param name="ElectorateSeats">for mixed-member proportional, the electorates each party won, by party ID. Null
        /// if there are no electorates</param>
        public static SainteLagueSeatDistribution CalculateSainteLagueParliamentarySeatDistributionSingleDistrictUsingQuotientTable(IReadOnlyList<PoliticalPartyVotes> Parties, IEnumerable<(int, int)> SurplusVoteAgreements, int NumberOfSeats, SimpleFraction ElectoralThreshold, SimpleFraction? FirstDivisor = null, IDictionary<int, int>? ElectorateSeats = null)
        {
            return CalculateSainteLague(Parties, SurplusVoteAgreements, NumberOfSeats, ElectoralThreshold, FirstDivisor, ElectorateSeats, GiveOutSeatsUsingQuotientTable);
        }

        /// <summary>
        /// same as the Sainte-Laguë method by party ID with the same seats, but worked out by rounding with a common
        /// divisor, the way Germany does it (Sainte-Laguë/Schepers) and the United States did it for the House of
        /// Representatives (<see cref="UnitedStatesPoliticians.WebsterDaniel"/>'s method). Every party's votes are divided
        /// by the same number of votes per seat and the result is rounded to the nearest whole number, which is the
        /// party's seats: 3.4 gives 3 seats and 3.5 gives 4. Under modified Sainte-Laguë only the first seat is different,
        /// taking half the first divisor instead of 0.5, such as 0.7 for a first divisor of 7/5. The first try at the
        /// votes per seat is the qualifying votes divided by the number of seats. If the seats then add up to too few, the
        /// votes per seat are lowered, and if too many, raised, until they add up. A surplus vote agreement is rounded
        /// with its combined votes, and its seats are then shared out by rounding again with just its own parties. Ties
        /// go to the side with more votes. Since no seat is given out before another this way,
        /// <see cref="SeatDistributionBase.OrderedSeats"/> is left empty, though
        /// <see cref="SeatDistributionBase.OrderedSeatsByRecipient"/> still has each recipient's seats
        /// </summary>
        /// <param name="Parties">votes for each party, with IDs from 1 for the most votes</param>
        /// <param name="SurplusVoteAgreements">pairs of party IDs with surplus vote agreements</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        /// <param name="ElectoralThreshold">percentage of all valid votes a party needs for any seats</param>
        /// <param name="FirstDivisor">divisor for a party's first seat. Null for plain Sainte-Laguë, which uses 1/1</param>
        /// <param name="ElectorateSeats">for mixed-member proportional, the electorates each party won, by party ID. Null
        /// if there are no electorates</param>
        public static SainteLagueSeatDistribution CalculateSainteLagueParliamentarySeatDistributionSingleDistrictUsingDivisorRounding(IReadOnlyList<PoliticalPartyVotes> Parties, IEnumerable<(int, int)> SurplusVoteAgreements, int NumberOfSeats, SimpleFraction ElectoralThreshold, SimpleFraction? FirstDivisor = null, IDictionary<int, int>? ElectorateSeats = null)
        {
            return CalculateSainteLague(Parties, SurplusVoteAgreements, NumberOfSeats, ElectoralThreshold, FirstDivisor, ElectorateSeats, GiveOutSeatsUsingDivisorRounding);
        }

        /// <summary>
        /// same as the Sainte-Laguë method by party ID, with the parties given by name and their IDs worked out from
        /// their votes
        /// </summary>
        /// <param name="NumberOfVotes">votes for each party. Include every party, since the electoral threshold is a
        /// percentage of all of them; minor parties far below the threshold can be lumped into one entry. Parties with
        /// the same votes are taken to be in the order given</param>
        /// <param name="SurplusVoteAgreements">pairs of parties with surplus vote agreements</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        /// <param name="ElectoralThreshold">percentage of all valid votes a party needs for any seats, as a fraction so it is
        /// compared exactly, such as 13/4 or 325/100 for 3.25%</param>
        /// <param name="FirstDivisor">divisor for a party's first seat. Null for plain Sainte-Laguë, which uses 1/1</param>
        /// <param name="ElectorateSeats">for mixed-member proportional, the electorates each party won; parties left out
        /// won none. Each party has to be in <paramref name="NumberOfVotes"/>. Null if there are no electorates</param>
        public static SainteLagueSeatDistribution CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(IDictionary<string, long> NumberOfVotes, IEnumerable<(string, string)> SurplusVoteAgreements, int NumberOfSeats, SimpleFraction ElectoralThreshold, SimpleFraction? FirstDivisor = null, IDictionary<string, int>? ElectorateSeats = null)
        {
            List<PoliticalPartyVotes> parties = AssignIds(NumberOfVotes);
            return CalculateSainteLague(parties, GetSurplusVoteAgreementIds(parties, SurplusVoteAgreements), NumberOfSeats, ElectoralThreshold, FirstDivisor, GetElectorateSeatIds(parties, ElectorateSeats), GiveOutOrderedSeats);
        }

        /// <summary>
        /// same as the Sainte-Laguë method using a quotient table by party ID, with the parties given by name and their
        /// IDs worked out from their votes
        /// </summary>
        /// <param name="NumberOfVotes">votes for each party, with parties with the same votes taken to be in the order
        /// given</param>
        /// <param name="SurplusVoteAgreements">pairs of parties with surplus vote agreements</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        /// <param name="ElectoralThreshold">percentage of all valid votes a party needs for any seats</param>
        /// <param name="FirstDivisor">divisor for a party's first seat. Null for plain Sainte-Laguë, which uses 1/1</param>
        /// <param name="ElectorateSeats">for mixed-member proportional, the electorates each party won. Null if there are
        /// no electorates</param>
        public static SainteLagueSeatDistribution CalculateSainteLagueParliamentarySeatDistributionSingleDistrictUsingQuotientTable(IDictionary<string, long> NumberOfVotes, IEnumerable<(string, string)> SurplusVoteAgreements, int NumberOfSeats, SimpleFraction ElectoralThreshold, SimpleFraction? FirstDivisor = null, IDictionary<string, int>? ElectorateSeats = null)
        {
            List<PoliticalPartyVotes> parties = AssignIds(NumberOfVotes);
            return CalculateSainteLague(parties, GetSurplusVoteAgreementIds(parties, SurplusVoteAgreements), NumberOfSeats, ElectoralThreshold, FirstDivisor, GetElectorateSeatIds(parties, ElectorateSeats), GiveOutSeatsUsingQuotientTable);
        }

        /// <summary>
        /// same as the Sainte-Laguë method using divisor rounding by party ID, with the parties given by name and their
        /// IDs worked out from their votes
        /// </summary>
        /// <param name="NumberOfVotes">votes for each party, with parties with the same votes taken to be in the order
        /// given</param>
        /// <param name="SurplusVoteAgreements">pairs of parties with surplus vote agreements</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        /// <param name="ElectoralThreshold">percentage of all valid votes a party needs for any seats</param>
        /// <param name="FirstDivisor">divisor for a party's first seat. Null for plain Sainte-Laguë, which uses 1/1</param>
        /// <param name="ElectorateSeats">for mixed-member proportional, the electorates each party won. Null if there are
        /// no electorates</param>
        public static SainteLagueSeatDistribution CalculateSainteLagueParliamentarySeatDistributionSingleDistrictUsingDivisorRounding(IDictionary<string, long> NumberOfVotes, IEnumerable<(string, string)> SurplusVoteAgreements, int NumberOfSeats, SimpleFraction ElectoralThreshold, SimpleFraction? FirstDivisor = null, IDictionary<string, int>? ElectorateSeats = null)
        {
            List<PoliticalPartyVotes> parties = AssignIds(NumberOfVotes);
            return CalculateSainteLague(parties, GetSurplusVoteAgreementIds(parties, SurplusVoteAgreements), NumberOfSeats, ElectoralThreshold, FirstDivisor, GetElectorateSeatIds(parties, ElectorateSeats), GiveOutSeatsUsingDivisorRounding);
        }

        /// <summary>
        /// the parties being worked out, by ID, which is what the calculation uses. Their names are only used to fill in
        /// the results
        /// </summary>
        private sealed class Election
        {
            /// <summary>
            /// each party's name, by ID. ID 0 isn't a party
            /// </summary>
            public string[] Names { get; }

            /// <summary>
            /// each party's votes, by ID
            /// </summary>
            public long[] Votes { get; }

            /// <summary>
            /// each party's seats so far, by ID
            /// </summary>
            public int[] Seats { get; }

            /// <summary>
            /// the party IDs in the order the parties were given, which is the order the results list them in
            /// </summary>
            public int[] Order { get; }

            /// <summary>
            /// what each party's votes are multiplied by for its quotients, by ID, as whole numbers over
            /// <see cref="QuotientScale"/>. All the same as the scale unless there is a minority list quotient bonus
            /// </summary>
            public long[] QuotientWeights { get; }

            /// <summary>
            /// what <see cref="QuotientWeights"/> are over, so a weight equal to it means no bonus
            /// </summary>
            public long QuotientScale { get; private set; } = 1;

            /// <summary>
            /// checks the party IDs and sets up the parties. The IDs have to be 1 up to the number of parties, each used
            /// once, and a party with more votes has to have a lower ID
            /// </summary>
            /// <param name="Parties">the parties, in the order to list them in the results</param>
            public Election(IReadOnlyList<PoliticalPartyVotes> Parties)
            {
                int iCount = Parties.Count;
                Names = new string[iCount + 1];
                Votes = new long[iCount + 1];
                Seats = new int[iCount + 1];
                Order = new int[iCount];
                QuotientWeights = Enumerable.Repeat(1L, iCount + 1).ToArray();
                HashSet<string> names = new HashSet<string>();
                for (int i = 0; i < iCount; i++)
                {
                    PoliticalPartyVotes next = Parties[i];
                    if (next.Id < 1 || next.Id > iCount) throw new ArgumentException($"{next.Name} has ID {next.Id}, but the IDs have to go from 1 to {iCount}, one for each party", nameof(Parties));
                    if (Names[next.Id] != null) throw new ArgumentException($"{Names[next.Id]} and {next.Name} both have ID {next.Id}", nameof(Parties));
                    if (!names.Add(next.Name)) throw new ArgumentException($"{next.Name} is listed more than once", nameof(Parties));
                    if (next.Votes < 0) throw new ArgumentException($"{next.Name} has negative votes", nameof(Parties));
                    Names[next.Id] = next.Name;
                    Votes[next.Id] = next.Votes;
                    Order[i] = next.Id;
                }

                //with each ID used once, checking each party against the one before it by ID is enough
                for (int iId = 2; iId <= iCount; iId++)
                {
                    if (Votes[iId] > Votes[iId - 1]) throw new ArgumentException($"{Names[iId]} (ID {iId}) has more votes than {Names[iId - 1]} (ID {iId - 1}), but a party with more votes needs a lower ID", nameof(Parties));
                }
            }

            /// <summary>
            /// gets the combined votes of a party on its own or the parties of a surplus vote agreement
            /// </summary>
            public long VotesOf(int[] group)
            {
                long ret = 0;
                foreach (int iParty in group) ret += Votes[iParty];
                return ret;
            }

            /// <summary>
            /// raises the quotients of some parties by a percentage, such as 35/1 for 35%. Their votes are multiplied
            /// by 1 + the percentage / 100 and everyone else's by 1, both scaled to whole numbers, so 35% makes the
            /// weights 27 and 20 over a scale of 20
            /// </summary>
            /// <param name="parties">IDs of the parties that get the bonus</param>
            /// <param name="percentage">the bonus, with a positive numerator and denominator</param>
            public void ApplyQuotientBonus(HashSet<int> parties, SimpleFraction percentage)
            {
                SimpleFraction weight = new SimpleFraction(checked(percentage.Denominator * 100 + percentage.Numerator), checked(percentage.Denominator * 100)).Reduce();
                QuotientScale = weight.Denominator;
                for (int iParty = 1; iParty < QuotientWeights.Length; iParty++) QuotientWeights[iParty] = parties.Contains(iParty) ? weight.Numerator : weight.Denominator;
            }

            /// <summary>
            /// gets a party's votes times its <see cref="QuotientWeights"/>, which its quotients are worked out from
            /// </summary>
            public long QuotientVotes(int iParty) => checked(Votes[iParty] * QuotientWeights[iParty]);

            /// <summary>
            /// gets the combined <see cref="QuotientVotes"/> of a party on its own or the parties of a surplus vote
            /// agreement
            /// </summary>
            public long QuotientVotesOf(int[] group)
            {
                long ret = 0;
                foreach (int iParty in group) ret = checked(ret + QuotientVotes(iParty));
                return ret;
            }

            /// <summary>
            /// gets the combined seats so far of a party on its own or the parties of a surplus vote agreement
            /// </summary>
            public int SeatsOf(int[] group)
            {
                int ret = 0;
                foreach (int iParty in group) ret += Seats[iParty];
                return ret;
            }

            /// <summary>
            /// gets the total seats so far
            /// </summary>
            public int TotalSeats() => Seats.Sum();

            /// <summary>
            /// gets the name of a party on its own or a surplus vote agreement, such as "Party1 + Party2", which is how
            /// <see cref="SeatDistributionBase.OrderedSeatsByRecipient"/> is keyed
            /// </summary>
            public string GetName(int[] group) => group.Length == 1 ? Names[group[0]] : string.Join(" + ", group.Select(p => Names[p]));

            /// <summary>
            /// gets the parties of a party on its own or a surplus vote agreement by votes descending, which is by ID
            /// </summary>
            public static int[] ByVotes(int[] group) => group.Length == 1 ? group : group.Order().ToArray();
        }

        /// <summary>
        /// fills in <see cref="SeatDistributionBase.Seats"/> with the seats worked out by ID, for each party that passed
        /// the electoral threshold
        /// </summary>
        private static void CopySeats(SeatDistributionBase r, Election e, List<int> qualifying)
        {
            foreach (int iParty in qualifying) r.Seats[e.Names[iParty]] = e.Seats[iParty];
        }

        /// <summary>
        /// a way of giving out the seats among the recipients, which fills in <see cref="Election.Seats"/>,
        /// <see cref="SeatDistributionBase.OrderedSeatsByRecipient"/>, <see cref="SeatDistributionBase.NextOrderedSeat"/>
        /// and <see cref="SeatDistributionBase.VotesNeededForNextOrderedSeat"/>
        /// </summary>
        private delegate void SeatGiver(SeatDistributionBase r, Election e, List<int[]> recipients, LinearDivisor divisor, int NumberOfSeats);

        /// <summary>
        /// distributes seats using the Sainte-Laguë method, with everything the ways of working it out have in common:
        /// the electoral threshold, the surplus vote agreements and the electorates
        /// </summary>
        /// <param name="giveOutSeats">how the seats are given out among the recipients</param>
        private static SainteLagueSeatDistribution CalculateSainteLague(IReadOnlyList<PoliticalPartyVotes> Parties, IEnumerable<(int, int)> SurplusVoteAgreements, int NumberOfSeats, SimpleFraction ElectoralThreshold, SimpleFraction? FirstDivisor, IDictionary<int, int>? ElectorateSeats, SeatGiver giveOutSeats)
        {
            LinearDivisor divisor = GetLinearDivisor(SainteLagueSlope, FirstDivisor ?? new SimpleFraction(1, 1));
            Election e = new Election(Parties);
            foreach (KeyValuePair<int, int> next in ElectorateSeats ?? new Dictionary<int, int>())
            {
                if (next.Key < 1 || next.Key >= e.Names.Length) throw new ArgumentException($"party ID {next.Key} won electorates but has no party votes", nameof(ElectorateSeats));
                if (next.Value < 0) throw new ArgumentException($"{e.Names[next.Key]} has negative electorate seats", nameof(ElectorateSeats));
            }

            SainteLagueSeatDistribution r = new SainteLagueSeatDistribution();
            HashSet<int> wonElectorates = ElectorateSeats?.Where(p => p.Value > 0).Select(p => p.Key).ToHashSet() ?? new HashSet<int>();
            List<int> qualifying = ApplyElectoralThreshold(r, e, NumberOfSeats, ElectoralThreshold, wonElectorates);
            List<int[]> recipients = GetRecipients(r, e, SurplusVoteAgreements, qualifying);
            giveOutSeats(r, e, recipients, divisor, NumberOfSeats);
            CopySeats(r, e, qualifying);

            if (ElectorateSeats != null)
            {
                foreach (int iParty in qualifying)
                {
                    string sParty = e.Names[iParty];
                    int iElectorateSeats = ElectorateSeats.TryGetValue(iParty, out int iWon) ? iWon : 0;
                    int iSeats = e.Seats[iParty];
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
        /// gives out the seats not yet in <see cref="Election.Seats"/> one at a time, filling in
        /// <see cref="SeatDistributionBase.OrderedSeats"/>, <see cref="SeatDistributionBase.OrderedSeatsByRecipient"/>,
        /// <see cref="SeatDistributionBase.NextOrderedSeat"/> and
        /// <see cref="SeatDistributionBase.VotesNeededForNextOrderedSeat"/>. The seats already there, such as D'Hondt's base
        /// seats, decide where it starts
        /// </summary>
        /// <param name="divisor">divisor for a party's next seat, given its current number of seats</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        private static void GiveOutOrderedSeats(SeatDistributionBase r, Election e, List<int[]> recipients, LinearDivisor divisor, int NumberOfSeats)
        {
            for (int iSeat = e.TotalSeats() + 1; iSeat <= NumberOfSeats; iSeat++)
            {
                OrderedSeat seat = PickOrderedSeat(e, recipients, divisor, iSeat);
                r.OrderedSeats.Add(seat);
                r.OrderedSeatsByRecipient[e.GetName(seat.RecipientGroup)]++;
                e.Seats[seat.PoliticalPartyId]++;
            }
            FillNextOrderedSeat(r, e, recipients, divisor, NumberOfSeats);
        }

        /// <summary>
        /// gives out all the seats using a quotient table: each recipient's votes divided by each divisor it could need,
        /// with the highest quotients winning the seats. Reading the table from the highest quotient down gives the
        /// seats in the same order as giving them out one at a time, so this fills in
        /// <see cref="SeatDistributionBase.OrderedSeats"/> too
        /// </summary>
        /// <param name="divisor">divisor for a party's next seat, given its current number of seats</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        private static void GiveOutSeatsUsingQuotientTable(SeatDistributionBase r, Election e, List<int[]> recipients, LinearDivisor divisor, int NumberOfSeats)
        {
            //one table for the parties and surplus vote agreements, with a row for each seat won
            List<int[]> winners = GetHighestQuotients(recipients, e.VotesOf, divisor.Scaled, NumberOfSeats);

            //a table for each surplus vote agreement with just its own parties, which decides the party for each of the
            //agreement's seats. For a party on its own it is simply that party every time
            Dictionary<int[], Queue<int>> partiesByRecipient = new Dictionary<int[], Queue<int>>();
            foreach (int[] next in recipients)
            {
                int[] byVotes = Election.ByVotes(next);
                partiesByRecipient[next] = new Queue<int>(GetHighestQuotients(byVotes, p => e.Votes[p], divisor.Scaled, winners.Count(w => w == next)));
            }

            for (int i = 0; i < winners.Count; i++)
            {
                OrderedSeat seat = BuildOrderedSeat(e, winners[i], partiesByRecipient[winners[i]].Dequeue(), divisor, i + 1);
                r.OrderedSeats.Add(seat);
                r.OrderedSeatsByRecipient[e.GetName(seat.RecipientGroup)]++;
                e.Seats[seat.PoliticalPartyId]++;
            }
            FillNextOrderedSeat(r, e, recipients, divisor, NumberOfSeats);
        }

        /// <summary>
        /// builds a quotient table with each candidate's votes divided by the divisors for its first
        /// <paramref name="iCount"/> seats, which is as many as it could win, and gets the candidates with the
        /// <paramref name="iCount"/> highest quotients from the highest down. A candidate is there once for each of its
        /// quotients that made it. Compares exactly with integer math. Ties go to the earlier candidate, so callers order
        /// candidates by votes
        /// </summary>
        /// <param name="divisor">whole-number divisor for a party's next seat, given its current number of seats</param>
        private static List<T> GetHighestQuotients<T>(IReadOnlyList<T> candidates, Func<T, long> votes, Func<int, long> divisor, int iCount)
        {
            List<(int Candidate, int Seats, long Votes)> table = new List<(int Candidate, int Seats, long Votes)>();
            for (int i = 0; i < candidates.Count; i++)
            {
                long lVotes = votes(candidates[i]);
                for (int iSeats = 0; iSeats < iCount; iSeats++) table.Add((i, iSeats, lVotes));
            }

            table.Sort((x, y) =>
            {
                //highest quotient first, so y's quotient is compared to x's
                int iCompare = new SimpleFraction(y.Votes, divisor(y.Seats)).CompareTo(new SimpleFraction(x.Votes, divisor(x.Seats)));
                if (iCompare != 0) return iCompare;
                if (x.Candidate != y.Candidate) return x.Candidate.CompareTo(y.Candidate);
                return x.Seats.CompareTo(y.Seats);
            });
            return table.Take(iCount).Select(t => candidates[t.Candidate]).ToList();
        }

        /// <summary>
        /// gives out all the seats by rounding with a common divisor, first among the parties and surplus vote
        /// agreements, and then within each agreement among its parties. There is no order to the seats this way, so
        /// <see cref="SeatDistributionBase.OrderedSeats"/> stays empty
        /// </summary>
        /// <param name="divisor">divisor for a party's next seat, given its current number of seats</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        private static void GiveOutSeatsUsingDivisorRounding(SeatDistributionBase r, Election e, List<int[]> recipients, LinearDivisor divisor, int NumberOfSeats)
        {
            int[] recipientSeats = RoundWithCommonDivisor(recipients, e.VotesOf, divisor, NumberOfSeats);
            for (int i = 0; i < recipients.Count; i++)
            {
                r.OrderedSeatsByRecipient[e.GetName(recipients[i])] = recipientSeats[i];
                int[] byVotes = Election.ByVotes(recipients[i]);
                int[] partySeats = RoundWithCommonDivisor(byVotes, p => e.Votes[p], divisor, recipientSeats[i]);
                for (int j = 0; j < byVotes.Length; j++) e.Seats[byVotes[j]] = partySeats[j];
            }
            FillNextOrderedSeat(r, e, recipients, divisor, NumberOfSeats);
        }

        /// <summary>
        /// divides every candidate's votes by a common number of votes per seat and rounds to get its seats, adjusting
        /// the votes per seat until the seats add up to <paramref name="seatsToGive"/>. A candidate gets one more seat
        /// when its votes divided by the votes per seat reach the divisor for that seat divided by the slope, which for
        /// Sainte-Laguë's 1, 3, 5, ... and slope of 2 is 0.5, 1.5, 2.5, ..., the same as rounding to the nearest whole
        /// number. The first try is the votes per seat if the seats were shared out exactly, all the votes divided by
        /// <paramref name="seatsToGive"/>. Someone doing this by hand then tries other values until the seats add up.
        /// Here the votes per seat are instead moved just far enough for one seat to change at a time: down to the
        /// highest quotient that didn't get a seat when there are too few, and up past the lowest quotient that got one
        /// when there are too many. Compares exactly with integer math. Ties go to the earlier candidate, so callers
        /// order candidates by votes
        /// </summary>
        /// <returns>seats for each candidate, in the order of <paramref name="candidates"/></returns>
        private static int[] RoundWithCommonDivisor<T>(IReadOnlyList<T> candidates, Func<T, long> votes, LinearDivisor divisor, int seatsToGive)
        {
            long[] candidateVotes = candidates.Select(votes).ToArray();
            int[] seats = new int[candidates.Count];
            long totalVotes = candidateVotes.Sum();

            //first try, with total votes / seats to give as the votes per seat. A candidate has another seat coming when
            //  votes                    divisor(seats)
            //  ---------------  >=  ----------------
            //  votes per seat           slope
            //which is transformed to use multiplication instead of division. The divisor is scaled to a whole number, so
            //the scale goes on the other side
            if (seatsToGive > 0 && totalVotes > 0)
            {
                checked
                {
                    long shareMultiplier = seatsToGive * divisor.Slope.Numerator * divisor.Scale;
                    long totalVotesMultiplier = totalVotes * divisor.Slope.Denominator;
                    for (int i = 0; i < seats.Length; i++)
                    {
                        long lShare = candidateVotes[i] * shareMultiplier;
                        while (lShare >= totalVotesMultiplier * divisor.Scaled(seats[i])) seats[i]++;
                    }
                }
            }

            //too few seats, so lower the votes per seat until the next highest quotient gets a seat
            IEnumerable<int> indexes = Enumerable.Range(0, seats.Length);
            while (seats.Sum() < seatsToGive)
                seats[PickHighestQuotient(indexes, i => candidateVotes[i], i => seats[i], divisor.Scaled)]++;

            //too many seats, so raise the votes per seat until the lowest quotient that got a seat loses it
            while (seats.Sum() > seatsToGive)
            {
                int iLowest = -1;
                foreach (int i in indexes.Where(i => seats[i] > 0))
                {
                    //compare the quotients the candidates' last seats were won with, where ties go against the later
                    //candidate, the one with fewer votes
                    if (iLowest < 0 || new SimpleFraction(candidateVotes[i], divisor.Scaled(seats[i] - 1)) <= new SimpleFraction(candidateVotes[iLowest], divisor.Scaled(seats[iLowest] - 1)))
                        iLowest = i;
                }
                seats[iLowest]--;
            }
            return seats;
        }

        /// <summary>
        /// fills in <see cref="SeatDistributionBase.NextOrderedSeat"/> and
        /// <see cref="SeatDistributionBase.VotesNeededForNextOrderedSeat"/> once all the seats are given out, however that
        /// was done
        /// </summary>
        /// <param name="divisor">divisor for a party's next seat, given its current number of seats</param>
        /// <param name="NumberOfSeats">number of seats in the parliament</param>
        private static void FillNextOrderedSeat(SeatDistributionBase r, Election e, List<int[]> recipients, LinearDivisor divisor, int NumberOfSeats)
        {
            r.NextOrderedSeat = PickOrderedSeat(e, recipients, divisor, NumberOfSeats + 1);

            int[] next = r.NextOrderedSeat.RecipientGroup;
            long lNextVotes = e.VotesOf(next);
            int iNextSeats = e.SeatsOf(next);
            //the parties of a surplus vote agreement all have the same quotient weight
            r.VotesNeededForNextOrderedSeat = recipients
                .Where(a => a != next && e.SeatsOf(a) > 0)
                .Min(a => (long?)(GetVotesToWinSeatFrom(iNextSeats, e.QuotientWeights[next[0]], e.VotesOf(a), e.QuotientWeights[a[0]], e.SeatsOf(a), divisor.Scaled) - lNextVotes));
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
        private static LinearDivisor GetLinearDivisor(SimpleFraction Slope, SimpleFraction FirstDivisor)
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
            return new LinearDivisor(divisor, checked(slopeDenominator * firstDenominator), Slope.Reduce(), FirstDivisor.Reduce());
        }

        /// <summary>
        /// a linear divisor from <see cref="GetLinearDivisor"/>, in whole numbers for exact comparisons, with what's needed
        /// to show the actual divisor and how it was worked out
        /// </summary>
        /// <param name="Scaled">whole-number divisor for a party's next seat given its current number of seats, which is
        /// the actual divisor multiplied by <paramref name="Scale"/></param>
        /// <param name="Scale">what <paramref name="Scaled"/> multiplied the actual divisors by to make them whole numbers</param>
        /// <param name="Slope">how much the divisor goes up with each seat, in lowest terms</param>
        /// <param name="FirstDivisor">divisor for a party's first seat, in lowest terms</param>
        private sealed record LinearDivisor(Func<int, long> Scaled, long Scale, SimpleFraction Slope, SimpleFraction FirstDivisor)
        {
            /// <summary>
            /// gets the actual divisor in lowest terms
            /// </summary>
            /// <param name="seats">current number of seats</param>
            public SimpleFraction GetActual(int seats) => new SimpleFraction(Scaled(seats), Scale).Reduce();

            /// <summary>
            /// gets the votes divided by the actual divisor, for information
            /// </summary>
            /// <param name="seats">current number of seats</param>
            public decimal GetQuotient(long votes, int seats) => (decimal)votes * Scale / Scaled(seats);

            /// <summary>
            /// describes how the divisor is worked out, such as "2*3 + 1", or "1*(10+7) + 1" for a surplus vote agreement
            /// whose parties have 10 and 7 seats. A modified first divisor (one that isn't slope x 0 + 1 = 1) is shown on
            /// its own, such as "6/5"
            /// </summary>
            /// <param name="seatList">current number of seats for each party the divisor applies to</param>
            public string Describe(IReadOnlyList<int> seatList)
            {
                if (seatList.Sum() == 0 && FirstDivisor.CompareTo(new SimpleFraction(1, 1)) != 0) return Format(FirstDivisor);
                string slope = Slope.Denominator == 1 ? Slope.Numerator.ToString() : $"({Slope})";
                string seats = seatList.Count == 1 ? seatList[0].ToString() : $"({string.Join("+", seatList)})";
                return $"{slope}*{seats} + 1";
            }

            private static string Format(SimpleFraction Value) => Value.Denominator == 1 ? Value.Numerator.ToString() : Value.ToString();
        }

        /// <summary>
        /// picks who gets the next seat given out one at a time: first the party or surplus vote agreement with the
        /// highest quotient, then within an agreement the party in it with the highest quotient. A quotient is votes
        /// divided by the divisor for the next seat
        /// </summary>
        /// <param name="divisor">divisor for the next seat, given the current number of seats</param>
        /// <param name="iSeat">overall seat number of the seat being picked</param>
        private static OrderedSeat PickOrderedSeat(Election e, List<int[]> recipients, LinearDivisor divisor, int iSeat)
        {
            //apply the divisor calculation to the parties that passed the electoral threshold, and to the surplus vote agreements that didn't get annulled
            int[] winner = PickHighestQuotient(recipients, e.QuotientVotesOf, e.SeatsOf, divisor.Scaled);

            //apply the divisor calculation to the parties in the agreeement to determine who gets the next seat within the agreement parties
            int iParty = PickHighestQuotient(Election.ByVotes(winner), e.QuotientVotes, p => e.Seats[p], divisor.Scaled);

            return BuildOrderedSeat(e, winner, iParty, divisor, iSeat);
        }

        /// <summary>
        /// builds the <see cref="OrderedSeat"/> for a seat going to a party, with the divisors and quotients from the
        /// seats held before it
        /// </summary>
        /// <param name="winner">the party on its own, or the parties of the surplus vote agreement that won the seat</param>
        /// <param name="iParty">the party in <paramref name="winner"/> that gets the seat</param>
        /// <param name="divisor">divisor for the next seat, given the current number of seats</param>
        /// <param name="iSeat">overall seat number of the seat</param>
        private static OrderedSeat BuildOrderedSeat(Election e, int[] winner, int iParty, LinearDivisor divisor, int iSeat)
        {
            List<int> winnerFirst = Election.ByVotes(winner).OrderBy(p => p == iParty ? 0 : 1).ToList(); //stable, so the others stay by votes descending
            List<OrderedSeatRecipient> recipientDetails = winnerFirst
                .Select(p => new OrderedSeatRecipient(e.Names[p], divisor.GetActual(e.Seats[p]), divisor.Describe(new[] { e.Seats[p] }), divisor.GetQuotient(e.QuotientVotes(p), e.Seats[p]) / e.QuotientScale))
                .ToList();
            long lQuotientVotes = e.QuotientVotesOf(winner);
            int iSeats = e.SeatsOf(winner);
            return new OrderedSeat(iSeat, winner, iParty, recipientDetails, divisor.GetActual(iSeats), divisor.Describe(winnerFirst.Select(p => e.Seats[p]).ToList()), divisor.GetQuotient(lQuotientVotes, iSeats) / e.QuotientScale);
        }

        /// <summary>
        /// validates the inputs common to all the methods and applies the electoral threshold, filling in
        /// <see cref="SeatDistributionBase.TotalVotes"/>, <see cref="SeatDistributionBase.QualifyingVotes"/> and
        /// <see cref="SeatDistributionBase.PoliticalPartiesBelowElectoralThreshold"/>
        /// </summary>
        /// <param name="exempt">IDs of parties that qualify whatever their votes, such as those that won an electorate
        /// under mixed-member proportional</param>
        /// <returns>the IDs of the parties that passed the electoral threshold, in the order the parties were given</returns>
        private static List<int> ApplyElectoralThreshold(SeatDistributionBase r, Election e, int NumberOfSeats, SimpleFraction ElectoralThreshold, HashSet<int> exempt)
        {
            if (NumberOfSeats <= 0) throw new ArgumentException("the number of seats must be positive", nameof(NumberOfSeats));
            if (ElectoralThreshold.Numerator < 0 || ElectoralThreshold.Denominator <= 0) throw new ArgumentException($"the electoral threshold {ElectoralThreshold} must have a numerator that isn't negative and a positive denominator", nameof(ElectoralThreshold));

            r.TotalVotes = e.Votes.Sum();
            if (r.TotalVotes <= 0) throw new ArgumentException("there are no votes", nameof(PoliticalPartyVotes.Votes));

            List<int> qualifying = new List<int>();
            foreach (int iParty in e.Order)
            {
                if (exempt.Contains(iParty) || IsAtElectoralThreshold(e.Votes[iParty], r.TotalVotes, ElectoralThreshold))
                    qualifying.Add(iParty);
                else
                    r.PoliticalPartiesBelowElectoralThreshold.Add(e.Names[iParty]);
            }
            if (qualifying.Count == 0) throw new InvalidOperationException("no party passed the electoral threshold");
            r.QualifyingVotes = qualifying.Sum(p => e.Votes[p]);
            return qualifying;
        }

        /// <summary>
        /// whether a party's share of the vote reaches the electoral threshold, compared as fractions so it's exact
        /// </summary>
        /// <param name="ElectoralThreshold">percentage of all valid votes needed, such as 13/4 for 3.25%</param>
        private static bool IsAtElectoralThreshold(long votes, long totalVotes, SimpleFraction ElectoralThreshold)
        {
            return new SimpleFraction(votes, totalVotes) >= ElectoralThreshold.FromPercentage(); //share of the vote needed, such as 13/400 for 3.25%
        }

        /// <summary>
        /// validates the surplus vote agreements and gets the possible recipients of seats given out one at a time: each
        /// surplus vote agreement whose parties both passed the electoral threshold, and each other qualifying party on
        /// its own. Fills in <see cref="SeatDistributionBase.AnnulledSurplusVoteAgreements"/>, and
        /// <see cref="SeatDistributionBase.OrderedSeatsByRecipient"/> with zero seats for each recipient
        /// </summary>
        /// <param name="SurplusVoteAgreements">pairs of party IDs with surplus vote agreements</param>
        /// <param name="qualifying">IDs of the parties that passed the electoral threshold</param>
        /// <returns>the recipients as party IDs, with an agreement's parties in the order given, ordered by votes
        /// descending, which is how ties are broken</returns>
        private static List<int[]> GetRecipients(SeatDistributionBase r, Election e, IEnumerable<(int, int)> SurplusVoteAgreements, List<int> qualifying)
        {
            HashSet<int> qualifyingSet = new HashSet<int>(qualifying);
            HashSet<int> inAgreement = new HashSet<int>(); //parties in a surplus vote agreement, to validate a party can only be in one
            HashSet<int> inRecipient = new HashSet<int>(); //parties in a surplus vote agreement that wasn't annulled
            List<int[]> recipients = new List<int[]>(); //possible recipients of seats, either a single party or a surplus vote agreement
            foreach ((int iParty1, int iParty2) in SurplusVoteAgreements)
            {
                foreach (int iParty in new[] { iParty1, iParty2 })
                {
                    if (iParty < 1 || iParty >= e.Names.Length) throw new ArgumentException($"surplus vote agreement party ID {iParty} has no votes", nameof(SurplusVoteAgreements));
                    if (!inAgreement.Add(iParty)) throw new ArgumentException($"{e.Names[iParty]} is in more than one surplus vote agreement, or one with itself", nameof(SurplusVoteAgreements));
                }
                if (qualifyingSet.Contains(iParty1) && qualifyingSet.Contains(iParty2))
                {
                    recipients.Add(new[] { iParty1, iParty2 });
                    inRecipient.Add(iParty1);
                    inRecipient.Add(iParty2);
                }
                else
                {
                    r.AnnulledSurplusVoteAgreements.Add((e.Names[iParty1], e.Names[iParty2]));
                }
            }

            //add any qualifying parties not in a surplus vote agreement
            foreach (int iParty in qualifying)
            {
                if (!inRecipient.Contains(iParty)) recipients.Add(new[] { iParty });
            }

            recipients = recipients.OrderByDescending(e.VotesOf).ToList();
            foreach (int[] next in recipients) r.OrderedSeatsByRecipient[e.GetName(next)] = 0;
            return recipients;
        }

        /// <summary>
        /// gets the fewest total votes a candidate needs for one more seat to come from another candidate, which takes a
        /// higher quotient for the candidate's next seat than the other candidate's last seat was won with:
        ///   votes needed           other votes
        ///   ---------------  &gt;  ---------------------
        ///   divisor(seats)         divisor(other seats - 1)
        /// Under D'Hondt that is seats + 1 against other seats. With a minority list quotient bonus each side's votes are
        /// multiplied by its quotient weight first. A tie is also enough if it leaves the candidate with more votes than
        /// the other candidate, since ties go to the side with more votes, which without a bonus is when its divisor is
        /// the larger one. This compares exactly with integer math
        /// </summary>
        /// <param name="weight">the candidate's quotient weight</param>
        /// <param name="otherWeight">the other candidate's quotient weight</param>
        /// <param name="divisorFxn">whole-number divisor for a party's next seat, given its current number of seats</param>
        private static long GetVotesToWinSeatFrom(int seats, long weight, long otherVotes, long otherWeight, int otherSeats, Func<int, long> divisorFxn)
        {
            long divisor = divisorFxn(seats);
            long otherDivisor = divisorFxn(otherSeats - 1);
            long votesForTie = Math.DivRem(checked(otherVotes * otherWeight * divisor), checked(weight * otherDivisor), out long remainder);
            return remainder == 0 && votesForTie > otherVotes ? votesForTie : votesForTie + 1;
        }

        /// <summary>
        /// picks the candidate with the highest quotient, its votes divided by the divisor for its next seat, comparing
        /// exactly with integer math. Ties go to the first candidate, so callers order candidates by votes
        /// </summary>
        private static T PickHighestQuotient<T>(IEnumerable<T> candidates, Func<T, long> votes, Func<T, int> seats, Func<int, long> divisor)
        {
            T best = default!;
            SimpleFraction? bestQuotient = null;
            foreach (T next in candidates)
            {
                //To determine the candidate party(s) that get the next seat, compare the quotients (pick higher value)
                //  candidate votes                        best votes
                //  ---------------------------  against   ----------------------
                //  divisor(candidate seats)               divisor(best seats)
                //Under D'Hondt the divisor is seats + 1, so this maximizes the votes per seat, intending to keep seats from being
                //too cheap in votes. That has the side effect of favoring party(s) with more seats, since an extra seat lowers a
                //larger group's votes per seat by a smaller share. Sainte-Laguë's divisor of 2 x seats + 1 is roughly neutral
                //between larger and smaller party(s).
                //Any quotient is greater than null, so the first candidate is always best so far.
                SimpleFraction quotient = new SimpleFraction(votes(next), divisor(seats(next)));
                if (quotient > bestQuotient)
                {
                    best = next;
                    bestQuotient = quotient;
                }
            }
            return best;
        }
    }
}
