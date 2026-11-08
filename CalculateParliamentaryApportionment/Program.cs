using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.Politics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace CalculateParliamentaryApportionment
{
    /// <summary>
    /// reads the inputs of <see cref="SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict"/> or
    /// <see cref="SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict"/> from the Input
    /// element of an XML file, and writes the resulting seat distribution back to the same file. Method is exactly
    /// D'Hondt or Sainte-Laguë. Each Party element gets AboveThreshold and Seats attributes, plus BaseSeats for D'Hondt,
    /// and everything else goes in the Output element. Those attributes and the Output element are ignored when reading
    /// and regenerated on every run, so only Name and Votes need to be filled in. The file looks like this before it is
    /// first run, with SurplusVoteAgreements being optional, and FirstDivisor being optional and only for Sainte-Laguë
    /// (leave it out for plain Sainte-Laguë, or use 7/5 for Norway's modified Sainte-Laguë). For mixed-member
    /// proportional, as in New Zealand, give each party that won electorates an ElectorateSeats attribute, also only for
    /// Sainte-Laguë; then each party also gets ListSeats, OverhangSeats and TotalSeats attributes, and the Output element
    /// gets NumberOfMembers:
    /// <code>
    /// &lt;Election&gt;
    ///   &lt;Input&gt;
    ///     &lt;Method&gt;Sainte-Laguë&lt;/Method&gt;
    ///     &lt;FirstDivisor Numerator="7" Denominator="5" /&gt;
    ///     &lt;NumberOfSeats&gt;120&lt;/NumberOfSeats&gt;
    ///     &lt;ElectoralThreshold&gt;3.25&lt;/ElectoralThreshold&gt;
    ///     &lt;Parties&gt;
    ///       &lt;Party Name="Party1" Votes="1000" ElectorateSeats="1" /&gt;
    ///       &lt;Party Name="Party2" Votes="2000" /&gt;
    ///     &lt;/Parties&gt;
    ///     &lt;SurplusVoteAgreements&gt;
    ///       &lt;SurplusVoteAgreement Party1="Party1" Party2="Party2" /&gt;
    ///     &lt;/SurplusVoteAgreements&gt;
    ///   &lt;/Input&gt;
    /// &lt;/Election&gt;
    /// </code>
    /// </summary>
    public class Program
    {
        private const string InputElement = "Input";
        private const string OutputElement = "Output";
        private const string MethodElement = "Method";
        private const string FirstDivisorElement = "FirstDivisor";
        private const string NumberOfSeatsElement = "NumberOfSeats";
        private const string ElectoralThresholdElement = "ElectoralThreshold";
        private const string PartiesElement = "Parties";
        private const string SurplusVoteAgreementsElement = "SurplusVoteAgreements";
        private const string PartyElement = "Party";
        private const string SurplusVoteAgreementElement = "SurplusVoteAgreement";
        private const string RecipientElement = "Recipient";
        private const string NameAttribute = "Name";
        private const string VotesAttribute = "Votes";
        private const string AboveThresholdAttribute = "AboveThreshold";
        private const string SeatsAttribute = "Seats";
        private const string Party1Attribute = "Party1";
        private const string Party2Attribute = "Party2";
        private const string NumeratorAttribute = "Numerator";
        private const string DenominatorAttribute = "Denominator";
        private const string ElectorateSeatsAttribute = nameof(SainteLagueSeatDistribution.ElectorateSeats);
        private const string DHondtMethod = "D'Hondt";
        private const string SainteLagueMethod = "Sainte-Laguë";

        /// <summary>
        /// entry point
        /// </summary>
        /// <param name="args">the path of the XML file</param>
        /// <returns>0 on success, 1 on failure, in which case the file is left unchanged</returns>
        public static int Main(string[] args)
        {
            int rc;
            if (args.Length == 1)
            {
                string sPath = args[0];
                try
                {
                    XDocument doc = XDocument.Load(sPath);
                    XElement input = GetRequiredElement(doc.Root!, InputElement);
                    Dictionary<string, long> votes = ReadNumberOfVotes(input);
                    List<(string, string)> agreements = ReadSurplusVoteAgreements(input);
                    int iNumberOfSeats = (int)GetRequiredElement(input, NumberOfSeatsElement);
                    SimpleFraction electoralThreshold = SimpleFraction.FromDecimal((decimal)GetRequiredElement(input, ElectoralThresholdElement));
                    XElement? firstDivisor = input.Element(FirstDivisorElement);
                    Dictionary<string, int>? electorateSeats = ReadElectorateSeats(input);
                    string sMethod = (string)GetRequiredElement(input, MethodElement);
                    SeatDistributionBase r;
                    if (sMethod == DHondtMethod)
                    {
                        if (firstDivisor != null) throw new FormatException($"{FirstDivisorElement} is only for {SainteLagueMethod}");
                        if (electorateSeats != null) throw new FormatException($"{ElectorateSeatsAttribute} is only for {SainteLagueMethod}");
                        r = SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(votes, agreements, iNumberOfSeats, electoralThreshold);
                    }
                    else if (sMethod == SainteLagueMethod)
                    {
                        SimpleFraction? fraction = firstDivisor == null ? null : new SimpleFraction(
                            (long)GetRequiredAttribute(firstDivisor, NumeratorAttribute),
                            (long)GetRequiredAttribute(firstDivisor, DenominatorAttribute));
                        r = SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(votes, agreements, iNumberOfSeats, electoralThreshold, fraction, electorateSeats);
                    }
                    else
                    {
                        throw new FormatException($"{MethodElement} must be {DHondtMethod} or {SainteLagueMethod}, not {sMethod}");
                    }

                    WritePartyResults(input, r);
                    doc.Root!.Element(OutputElement)?.Remove();
                    input.AddAfterSelf(BuildOutput(r));
                    doc.Save(sPath);
                    rc = 0;
                }
                catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or XmlException or ArgumentException or InvalidOperationException or FormatException or OverflowException)
                {
                    Console.Error.WriteLine($"{sPath}: {ex.Message}");
                    rc = 1;
                }
            }
            else
            {
                Console.Error.WriteLine("usage: CalculateParliamentaryApportionment <XML file path>");
                rc = 1;
            }
            return rc;
        }

        private static Dictionary<string, long> ReadNumberOfVotes(XElement input)
        {
            Dictionary<string, long> ret = new Dictionary<string, long>();
            foreach (XElement next in GetRequiredElement(input, PartiesElement).Elements(PartyElement))
            {
                string sParty = (string)GetRequiredAttribute(next, NameAttribute);
                if (!ret.TryAdd(sParty, (long)GetRequiredAttribute(next, VotesAttribute)))
                    throw new FormatException($"{sParty} is listed more than once in {PartiesElement}");
            }
            return ret;
        }

        /// <summary>
        /// reads the ElectorateSeats attribute of each party that has one, which is an input rather than a result
        /// </summary>
        /// <returns>the electorates each party won, or null if no party has the attribute</returns>
        private static Dictionary<string, int>? ReadElectorateSeats(XElement input)
        {
            Dictionary<string, int>? ret = null;
            foreach (XElement next in GetRequiredElement(input, PartiesElement).Elements(PartyElement))
            {
                XAttribute? seats = next.Attribute(ElectorateSeatsAttribute);
                if (seats != null)
                {
                    ret ??= new Dictionary<string, int>();
                    ret[(string)GetRequiredAttribute(next, NameAttribute)] = (int)seats;
                }
            }
            return ret;
        }

        /// <summary>
        /// sets the result attributes of each party, replacing any existing ones. Parties below the electoral threshold
        /// get no seats, so they aren't in the seat dictionaries. BaseSeats is removed for a method without base seats,
        /// and ListSeats, OverhangSeats and TotalSeats are removed without electorate seats
        /// </summary>
        private static void WritePartyResults(XElement input, SeatDistributionBase r)
        {
            DHondtSeatDistribution? dHondt = r as DHondtSeatDistribution;
            SainteLagueSeatDistribution? mixedMember = r is SainteLagueSeatDistribution sainteLague && sainteLague.ElectorateSeats.Count > 0 ? sainteLague : null;
            foreach (XElement next in GetRequiredElement(input, PartiesElement).Elements(PartyElement))
            {
                string sParty = (string)GetRequiredAttribute(next, NameAttribute);
                bool isAboveThreshold = r.Seats.ContainsKey(sParty);
                next.SetAttributeValue(AboveThresholdAttribute, isAboveThreshold);
                next.SetAttributeValue(nameof(DHondtSeatDistribution.BaseSeats), dHondt?.BaseSeats.GetValueOrDefault(sParty));
                next.SetAttributeValue(SeatsAttribute, r.Seats.GetValueOrDefault(sParty));
                next.SetAttributeValue(nameof(SainteLagueSeatDistribution.ListSeats), mixedMember?.ListSeats.GetValueOrDefault(sParty));
                next.SetAttributeValue(nameof(SainteLagueSeatDistribution.OverhangSeats), mixedMember?.OverhangSeats.GetValueOrDefault(sParty));
                next.SetAttributeValue(nameof(SainteLagueSeatDistribution.TotalSeats), mixedMember?.TotalSeats.GetValueOrDefault(sParty));
            }
        }

        private static List<(string, string)> ReadSurplusVoteAgreements(XElement input)
        {
            List<(string, string)> ret = new List<(string, string)>();
            XElement? agreements = input.Element(SurplusVoteAgreementsElement);
            if (agreements != null)
            {
                foreach (XElement next in agreements.Elements(SurplusVoteAgreementElement))
                    ret.Add(((string)GetRequiredAttribute(next, Party1Attribute), (string)GetRequiredAttribute(next, Party2Attribute)));
            }
            return ret;
        }

        /// <summary>
        /// builds the Output element, with Quota only for D'Hondt and NumberOfMembers only with electorate seats. An empty
        /// NextOrderedSeatIrrelevantBecausePartyHasOverhangSeat element comes last when the next seat would go to a party
        /// with overhang seats, which makes both NextOrderedSeat and VotesNeededForNextOrderedSeat irrelevant
        /// </summary>
        private static XElement BuildOutput(SeatDistributionBase r)
        {
            return new XElement(OutputElement,
                new XElement(nameof(SeatDistributionBase.TotalVotes), r.TotalVotes),
                new XElement(nameof(SeatDistributionBase.QualifyingVotes), r.QualifyingVotes),
                r is DHondtSeatDistribution dHondt ? new XElement(nameof(DHondtSeatDistribution.Quota), dHondt.Quota) : null,
                r is SainteLagueSeatDistribution sainteLague && sainteLague.ElectorateSeats.Count > 0 ? new XElement(nameof(SainteLagueSeatDistribution.NumberOfMembers), sainteLague.NumberOfMembers) : null,
                new XElement(nameof(SeatDistributionBase.AnnulledSurplusVoteAgreements),
                    r.AnnulledSurplusVoteAgreements.Select(a => new XElement(SurplusVoteAgreementElement, new XAttribute(Party1Attribute, a.Item1), new XAttribute(Party2Attribute, a.Item2)))),
                new XElement(nameof(SeatDistributionBase.OrderedSeats),
                    r.OrderedSeats.Select(s => BuildOrderedSeat(nameof(OrderedSeat), s))),
                new XElement(nameof(SeatDistributionBase.OrderedSeatsByRecipient),
                    r.OrderedSeatsByRecipient.Select(p => new XElement(RecipientElement, new XAttribute(NameAttribute, p.Key), new XAttribute(SeatsAttribute, p.Value)))),
                BuildOrderedSeat(nameof(SeatDistributionBase.NextOrderedSeat), r.NextOrderedSeat),
                new XElement(nameof(SeatDistributionBase.VotesNeededForNextOrderedSeat), r.VotesNeededForNextOrderedSeat),
                r is SainteLagueSeatDistribution { NextOrderedSeatIrrelevantBecausePartyHasOverhangSeat: true } ? new XElement(nameof(SainteLagueSeatDistribution.NextOrderedSeatIrrelevantBecausePartyHasOverhangSeat)) : null);
        }

        private static XElement BuildOrderedSeat(string sElement, OrderedSeat s)
        {
            return new XElement(sElement,
                new XAttribute(nameof(OrderedSeat.SeatNumber), s.SeatNumber),
                new XAttribute(nameof(OrderedSeat.PoliticalParty), s.PoliticalParty),
                new XAttribute(nameof(OrderedSeat.VotesPerSeat), s.VotesPerSeat),
                s.Recipients.Select(p => new XElement(RecipientElement, new XAttribute(NameAttribute, p))));
        }

        private static XElement GetRequiredElement(XElement parent, string sName)
        {
            return parent.Element(sName) ?? throw new FormatException($"{parent.Name} is missing the {sName} element");
        }

        private static XAttribute GetRequiredAttribute(XElement element, string sName)
        {
            return element.Attribute(sName) ?? throw new FormatException($"{element.Name} is missing the {sName} attribute");
        }
    }
}
