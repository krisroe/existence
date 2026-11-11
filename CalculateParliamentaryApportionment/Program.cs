using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.Politics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// gets NumberOfMembers.
    /// The Method element needs an Algorithms attribute, a comma-separated list of the ways to work out the seats:
    /// Base for D'Hondt (<see cref="SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict"/>), and
    /// any of OrderedSeats (<see cref="SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict"/>),
    /// QuotientTable (<see cref="SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrictUsingQuotientTable"/>)
    /// and DivisorRounding (<see cref="SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrictUsingDivisorRounding"/>)
    /// for Sainte-Laguë. They run in the order listed, and with more than one they have to give the same results, except
    /// that DivisorRounding doesn't give out seats in order, so OrderedSeats is only compared between the others. The
    /// results written are from the first algorithm listed that gives out seats in order, or the first one if none does.
    /// The optional IncludePerformance element (false if left out) adds a Performance element to the Output element with
    /// how long each algorithm took in milliseconds. Each algorithm is run once untimed first, so the timing doesn't
    /// include the one-time cost of compiling the code:
    /// <code>
    /// &lt;Election&gt;
    ///   &lt;Input&gt;
    ///     &lt;Method Algorithms="OrderedSeats,QuotientTable,DivisorRounding"&gt;Sainte-Laguë&lt;/Method&gt;
    ///     &lt;IncludePerformance&gt;true&lt;/IncludePerformance&gt;
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
        private const string AlgorithmsAttribute = "Algorithms";
        private const string IncludePerformanceElement = "IncludePerformance";
        private const string PerformanceElement = "Performance";
        private const string AlgorithmElement = "Algorithm";
        private const string MillisecondsAttribute = "Milliseconds";
        private const string BaseAlgorithm = "Base";
        private const string OrderedSeatsAlgorithm = "OrderedSeats";
        private const string QuotientTableAlgorithm = "QuotientTable";
        private const string DivisorRoundingAlgorithm = "DivisorRounding";

        /// <summary>
        /// algorithms that don't give out seats in order, so they leave <see cref="SeatDistributionBase.OrderedSeats"/>
        /// empty
        /// </summary>
        private static readonly HashSet<string> UnorderedAlgorithms = new HashSet<string> { DivisorRoundingAlgorithm };

        /// <summary>
        /// the result of running one algorithm
        /// </summary>
        /// <param name="Name">the algorithm</param>
        /// <param name="Result">the seat distribution it worked out</param>
        /// <param name="Elapsed">how long it took, or null if performance isn't included</param>
        private sealed record AlgorithmResult(string Name, SeatDistributionBase Result, TimeSpan? Elapsed);

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
                    XElement method = GetRequiredElement(input, MethodElement);
                    string sMethod = (string)method;
                    bool includePerformance = (bool?)input.Element(IncludePerformanceElement) ?? false;
                    Dictionary<string, Func<SeatDistributionBase>> available;
                    if (sMethod == DHondtMethod)
                    {
                        if (firstDivisor != null) throw new FormatException($"{FirstDivisorElement} is only for {SainteLagueMethod}");
                        if (electorateSeats != null) throw new FormatException($"{ElectorateSeatsAttribute} is only for {SainteLagueMethod}");
                        available = new Dictionary<string, Func<SeatDistributionBase>>
                        {
                            [BaseAlgorithm] = () => SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(votes, agreements, iNumberOfSeats, electoralThreshold),
                        };
                    }
                    else if (sMethod == SainteLagueMethod)
                    {
                        SimpleFraction? fraction = firstDivisor == null ? null : new SimpleFraction(
                            (long)GetRequiredAttribute(firstDivisor, NumeratorAttribute),
                            (long)GetRequiredAttribute(firstDivisor, DenominatorAttribute));
                        available = new Dictionary<string, Func<SeatDistributionBase>>
                        {
                            [OrderedSeatsAlgorithm] = () => SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(votes, agreements, iNumberOfSeats, electoralThreshold, fraction, electorateSeats),
                            [QuotientTableAlgorithm] = () => SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrictUsingQuotientTable(votes, agreements, iNumberOfSeats, electoralThreshold, fraction, electorateSeats),
                            [DivisorRoundingAlgorithm] = () => SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrictUsingDivisorRounding(votes, agreements, iNumberOfSeats, electoralThreshold, fraction, electorateSeats),
                        };
                    }
                    else
                    {
                        throw new FormatException($"{MethodElement} must be {DHondtMethod} or {SainteLagueMethod}, not {sMethod}");
                    }

                    List<AlgorithmResult> results = RunAlgorithms(ReadAlgorithms(method, sMethod, available), available, includePerformance);
                    SeatDistributionBase r = GetVerifiedResult(input, results);
                    WritePartyResults(input, r);
                    doc.Root!.Element(OutputElement)?.Remove();
                    input.AddAfterSelf(BuildOutput(r, includePerformance ? results : null));
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

        /// <summary>
        /// reads the Algorithms attribute of the Method element, a comma-separated list of the algorithms to run in order
        /// </summary>
        /// <param name="sMethod">the method, for error messages</param>
        /// <param name="available">the algorithms the method has</param>
        private static List<string> ReadAlgorithms(XElement method, string sMethod, Dictionary<string, Func<SeatDistributionBase>> available)
        {
            List<string> ret = ((string)GetRequiredAttribute(method, AlgorithmsAttribute)).Split(',', StringSplitOptions.TrimEntries).ToList();
            HashSet<string> seen = new HashSet<string>();
            foreach (string sAlgorithm in ret)
            {
                if (!available.ContainsKey(sAlgorithm)) throw new FormatException($"{AlgorithmsAttribute} for {sMethod} can only have {string.Join(", ", available.Keys)}, not \"{sAlgorithm}\"");
                if (!seen.Add(sAlgorithm)) throw new FormatException($"{AlgorithmsAttribute} has {sAlgorithm} more than once");
            }
            return ret;
        }

        /// <summary>
        /// runs each algorithm in order. When timing them, each is run once untimed first so the time doesn't include
        /// compiling the code the first time it runs
        /// </summary>
        /// <param name="algorithms">the algorithms to run, in order</param>
        /// <param name="available">how to run each algorithm</param>
        /// <param name="includePerformance">whether to time the algorithms</param>
        private static List<AlgorithmResult> RunAlgorithms(List<string> algorithms, Dictionary<string, Func<SeatDistributionBase>> available, bool includePerformance)
        {
            List<AlgorithmResult> ret = new List<AlgorithmResult>();
            foreach (string sAlgorithm in algorithms)
            {
                Func<SeatDistributionBase> calculate = available[sAlgorithm];
                TimeSpan? elapsed = null;
                if (includePerformance)
                {
                    calculate();
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    SeatDistributionBase timed = calculate();
                    stopwatch.Stop();
                    elapsed = stopwatch.Elapsed;
                    ret.Add(new AlgorithmResult(sAlgorithm, timed, elapsed));
                }
                else
                {
                    ret.Add(new AlgorithmResult(sAlgorithm, calculate(), elapsed));
                }
            }
            return ret;
        }

        /// <summary>
        /// checks that all the algorithms give the same results, comparing what gets written to the file. The ordered
        /// seats are only compared between algorithms that both give out seats in order
        /// </summary>
        /// <returns>the result to write, from the first algorithm that gives out seats in order, or the first algorithm
        /// if none does</returns>
        private static SeatDistributionBase GetVerifiedResult(XElement input, List<AlgorithmResult> results)
        {
            AlgorithmResult expected = results.FirstOrDefault(a => !UnorderedAlgorithms.Contains(a.Name)) ?? results[0];
            foreach (AlgorithmResult next in results.Where(a => a != expected))
            {
                bool compareOrderedSeats = !UnorderedAlgorithms.Contains(expected.Name) && !UnorderedAlgorithms.Contains(next.Name);
                string? sDifference = FindDifference(input, expected.Result, next.Result, compareOrderedSeats);
                if (sDifference != null) throw new InvalidOperationException($"the {expected.Name} and {next.Name} algorithms give different {sDifference}");
            }
            return expected.Result;
        }

        /// <summary>
        /// compares two results by the party attributes and Output element they would write
        /// </summary>
        /// <param name="compareOrderedSeats">whether to compare the ordered seats</param>
        /// <returns>what's different, or null if they're the same</returns>
        private static string? FindDifference(XElement input, SeatDistributionBase expected, SeatDistributionBase actual, bool compareOrderedSeats)
        {
            XElement expectedInput = new XElement(input);
            XElement actualInput = new XElement(input);
            WritePartyResults(expectedInput, expected);
            WritePartyResults(actualInput, actual);
            foreach ((XElement nextExpected, XElement nextActual) in GetRequiredElement(expectedInput, PartiesElement).Elements(PartyElement).Zip(GetRequiredElement(actualInput, PartiesElement).Elements(PartyElement)))
            {
                if (!XNode.DeepEquals(nextExpected, nextActual)) return $"results for {(string?)nextExpected.Attribute(NameAttribute)}";
            }

            XElement expectedOutput = BuildOutput(expected, null);
            XElement actualOutput = BuildOutput(actual, null);
            if (!compareOrderedSeats)
            {
                expectedOutput.Element(nameof(SeatDistributionBase.OrderedSeats))?.Remove();
                actualOutput.Element(nameof(SeatDistributionBase.OrderedSeats))?.Remove();
            }
            foreach (XName next in expectedOutput.Elements().Select(e => e.Name).Union(actualOutput.Elements().Select(e => e.Name)))
            {
                if (!XNode.DeepEquals(expectedOutput.Element(next), actualOutput.Element(next))) return next.LocalName;
            }
            return null;
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
        /// with overhang seats, which makes both NextOrderedSeat and VotesNeededForNextOrderedSeat irrelevant. A
        /// Performance element with each algorithm's time comes after that when timing them
        /// </summary>
        /// <param name="performance">the algorithms with how long each took, or null if performance isn't included</param>
        private static XElement BuildOutput(SeatDistributionBase r, List<AlgorithmResult>? performance)
        {
            return new XElement(OutputElement,
                new XElement(nameof(SeatDistributionBase.TotalVotes), r.TotalVotes),
                new XElement(nameof(SeatDistributionBase.QualifyingVotes), r.QualifyingVotes),
                r is DHondtSeatDistribution dHondt ? new XElement(nameof(DHondtSeatDistribution.Quota), dHondt.Quota) : null,
                r is SainteLagueSeatDistribution sainteLague && sainteLague.ElectorateSeats.Count > 0 ? new XElement(nameof(SainteLagueSeatDistribution.NumberOfMembers), sainteLague.NumberOfMembers) : null,
                new XElement(nameof(SeatDistributionBase.AnnulledSurplusVoteAgreements),
                    r.AnnulledSurplusVoteAgreements.Select(a => new XElement(SurplusVoteAgreementElement, new XAttribute(Party1Attribute, a.Item1), new XAttribute(Party2Attribute, a.Item2)))),
                new XElement(nameof(SeatDistributionBase.OrderedSeatsByRecipient),
                    r.OrderedSeatsByRecipient.Select(p => new XElement(RecipientElement, new XAttribute(NameAttribute, p.Key), new XAttribute(SeatsAttribute, p.Value)))),
                new XElement(nameof(SeatDistributionBase.OrderedSeats),
                    r.OrderedSeats.Select(s => BuildOrderedSeat(nameof(OrderedSeat), s))),
                BuildOrderedSeat(nameof(SeatDistributionBase.NextOrderedSeat), r.NextOrderedSeat),
                new XElement(nameof(SeatDistributionBase.VotesNeededForNextOrderedSeat), r.VotesNeededForNextOrderedSeat),
                r is SainteLagueSeatDistribution { NextOrderedSeatIrrelevantBecausePartyHasOverhangSeat: true } ? new XElement(nameof(SainteLagueSeatDistribution.NextOrderedSeatIrrelevantBecausePartyHasOverhangSeat)) : null,
                performance == null ? null : new XElement(PerformanceElement,
                    performance.Select(a => new XElement(AlgorithmElement, new XAttribute(NameAttribute, a.Name), new XAttribute(MillisecondsAttribute, a.Elapsed!.Value.TotalMilliseconds)))));
        }

        private static XElement BuildOrderedSeat(string sElement, OrderedSeat s)
        {
            return new XElement(sElement,
                new XAttribute(nameof(OrderedSeat.SeatNumber), s.SeatNumber),
                new XAttribute(nameof(OrderedSeat.PoliticalParty), s.PoliticalParty),
                new XAttribute(nameof(OrderedSeat.DivisorCalculation), s.DivisorCalculation),
                new XAttribute(nameof(OrderedSeat.Divisor), FormatDivisor(s.Divisor)),
                new XAttribute(nameof(OrderedSeat.Quotient), s.Quotient),
                s.Recipients.Select(p => new XElement(RecipientElement,
                    new XAttribute(NameAttribute, p.PoliticalParty),
                    //a party on its own has the same votes and seats as the seat, so its numbers would only repeat the seat's
                    s.Recipients.Count > 1 ? new XAttribute(nameof(OrderedSeatRecipient.DivisorCalculation), p.DivisorCalculation) : null,
                    s.Recipients.Count > 1 ? new XAttribute(nameof(OrderedSeatRecipient.Divisor), FormatDivisor(p.Divisor)) : null,
                    s.Recipients.Count > 1 ? new XAttribute(nameof(OrderedSeatRecipient.Quotient), p.Quotient) : null)));
        }

        /// <summary>
        /// writes a divisor already in lowest terms as a whole number when it is one, such as 3, or as a fraction such
        /// as 7/5
        /// </summary>
        private static string FormatDivisor(SimpleFraction Divisor)
        {
            return Divisor.Denominator == 1 ? Divisor.Numerator.ToString() : Divisor.ToString();
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
