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
    /// reads the inputs of <see cref="SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict"/> from
    /// the Input element of an XML file, and writes the resulting <see cref="SeatDistribution"/> back to the same file.
    /// Each Party element gets AboveThreshold, BaseSeats and Seats attributes, and everything else goes in the Output
    /// element. Those attributes and the Output element are ignored when reading and regenerated on every run, so only
    /// Name and Votes need to be filled in. The file looks like this before it is first run, with SurplusVoteAgreements
    /// being optional:
    /// <code>
    /// &lt;Election&gt;
    ///   &lt;Input&gt;
    ///     &lt;NumberOfSeats&gt;120&lt;/NumberOfSeats&gt;
    ///     &lt;ElectoralThreshold&gt;3.25&lt;/ElectoralThreshold&gt;
    ///     &lt;Parties&gt;
    ///       &lt;Party Name="Party1" Votes="1000" /&gt;
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
                    SeatDistribution r = SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(
                        ReadNumberOfVotes(input),
                        ReadSurplusVoteAgreements(input),
                        (int)GetRequiredElement(input, NumberOfSeatsElement),
                        (decimal)GetRequiredElement(input, ElectoralThresholdElement));

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
        /// sets the result attributes of each party, replacing any existing ones. Parties below the electoral threshold
        /// get no seats, so they aren't in the seat dictionaries
        /// </summary>
        private static void WritePartyResults(XElement input, SeatDistribution r)
        {
            foreach (XElement next in GetRequiredElement(input, PartiesElement).Elements(PartyElement))
            {
                string sParty = (string)GetRequiredAttribute(next, NameAttribute);
                next.SetAttributeValue(AboveThresholdAttribute, r.BaseSeats.ContainsKey(sParty));
                next.SetAttributeValue(nameof(SeatDistribution.BaseSeats), r.BaseSeats.GetValueOrDefault(sParty));
                next.SetAttributeValue(SeatsAttribute, r.Seats.GetValueOrDefault(sParty));
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

        private static XElement BuildOutput(SeatDistribution r)
        {
            return new XElement(OutputElement,
                new XElement(nameof(SeatDistribution.TotalVotes), r.TotalVotes),
                new XElement(nameof(SeatDistribution.QualifyingVotes), r.QualifyingVotes),
                new XElement(nameof(SeatDistribution.Quota), r.Quota),
                new XElement(nameof(SeatDistribution.AnnulledSurplusVoteAgreements),
                    r.AnnulledSurplusVoteAgreements.Select(a => new XElement(SurplusVoteAgreementElement, new XAttribute(Party1Attribute, a.Item1), new XAttribute(Party2Attribute, a.Item2)))),
                new XElement(nameof(SeatDistribution.LeftoverSeats),
                    r.LeftoverSeats.Select(s => BuildLeftoverSeat(nameof(LeftoverSeat), s))),
                new XElement(nameof(SeatDistribution.LeftoverSeatsByRecipient),
                    r.LeftoverSeatsByRecipient.Select(p => new XElement(RecipientElement, new XAttribute(NameAttribute, p.Key), new XAttribute(SeatsAttribute, p.Value)))),
                BuildLeftoverSeat(nameof(SeatDistribution.NextLeftoverSeat), r.NextLeftoverSeat),
                new XElement(nameof(SeatDistribution.VotesNeededForNextLeftoverSeat), r.VotesNeededForNextLeftoverSeat));
        }

        private static XElement BuildLeftoverSeat(string sElement, LeftoverSeat s)
        {
            return new XElement(sElement,
                new XAttribute(nameof(LeftoverSeat.SeatNumber), s.SeatNumber),
                new XAttribute(nameof(LeftoverSeat.PoliticalParty), s.PoliticalParty),
                new XAttribute(nameof(LeftoverSeat.VotesPerSeat), s.VotesPerSeat),
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
