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
    /// the Input element of an XML file, and writes the resulting <see cref="SeatDistribution"/> back to the same file as
    /// the Output element, replacing any existing one. The file looks like this before it is first run, with
    /// SurplusVoteAgreements being optional:
    /// <code>
    /// &lt;ParliamentaryApportionment&gt;
    ///   &lt;Input&gt;
    ///     &lt;NumberOfSeats&gt;120&lt;/NumberOfSeats&gt;
    ///     &lt;ElectoralThreshold&gt;3.25&lt;/ElectoralThreshold&gt;
    ///     &lt;NumberOfVotes&gt;
    ///       &lt;PoliticalParty Name="Party1" Votes="1000" /&gt;
    ///       &lt;PoliticalParty Name="Party2" Votes="2000" /&gt;
    ///     &lt;/NumberOfVotes&gt;
    ///     &lt;SurplusVoteAgreements&gt;
    ///       &lt;SurplusVoteAgreement Party1="Party1" Party2="Party2" /&gt;
    ///     &lt;/SurplusVoteAgreements&gt;
    ///   &lt;/Input&gt;
    /// &lt;/ParliamentaryApportionment&gt;
    /// </code>
    /// </summary>
    public class Program
    {
        private const string InputElement = "Input";
        private const string OutputElement = "Output";
        private const string NumberOfSeatsElement = "NumberOfSeats";
        private const string ElectoralThresholdElement = "ElectoralThreshold";
        private const string NumberOfVotesElement = "NumberOfVotes";
        private const string SurplusVoteAgreementsElement = "SurplusVoteAgreements";
        private const string PoliticalPartyElement = "PoliticalParty";
        private const string SurplusVoteAgreementElement = "SurplusVoteAgreement";
        private const string RecipientElement = "Recipient";
        private const string NameAttribute = "Name";
        private const string VotesAttribute = "Votes";
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
            foreach (XElement next in GetRequiredElement(input, NumberOfVotesElement).Elements(PoliticalPartyElement))
            {
                string sParty = (string)GetRequiredAttribute(next, NameAttribute);
                if (!ret.TryAdd(sParty, (long)GetRequiredAttribute(next, VotesAttribute)))
                    throw new FormatException($"{sParty} is listed more than once in {NumberOfVotesElement}");
            }
            return ret;
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
                new XElement(nameof(SeatDistribution.PoliticalPartiesBelowElectoralThreshold),
                    r.PoliticalPartiesBelowElectoralThreshold.Select(p => new XElement(PoliticalPartyElement, new XAttribute(NameAttribute, p)))),
                new XElement(nameof(SeatDistribution.AnnulledSurplusVoteAgreements),
                    r.AnnulledSurplusVoteAgreements.Select(a => new XElement(SurplusVoteAgreementElement, new XAttribute(Party1Attribute, a.Item1), new XAttribute(Party2Attribute, a.Item2)))),
                BuildSeatCounts(nameof(SeatDistribution.BaseSeats), PoliticalPartyElement, r.BaseSeats),
                new XElement(nameof(SeatDistribution.LeftoverSeats),
                    r.LeftoverSeats.Select(s => BuildLeftoverSeat(nameof(LeftoverSeat), s))),
                BuildSeatCounts(nameof(SeatDistribution.LeftoverSeatsByRecipient), RecipientElement, r.LeftoverSeatsByRecipient),
                BuildSeatCounts(nameof(SeatDistribution.Seats), PoliticalPartyElement, r.Seats),
                BuildLeftoverSeat(nameof(SeatDistribution.NextLeftoverSeat), r.NextLeftoverSeat));
        }

        private static XElement BuildLeftoverSeat(string sElement, LeftoverSeat s)
        {
            return new XElement(sElement,
                new XAttribute(nameof(LeftoverSeat.SeatNumber), s.SeatNumber),
                new XAttribute(nameof(LeftoverSeat.PoliticalParty), s.PoliticalParty),
                new XAttribute(nameof(LeftoverSeat.VotesPerSeat), s.VotesPerSeat),
                s.Recipients.Select(p => new XElement(RecipientElement, new XAttribute(NameAttribute, p))));
        }

        private static XElement BuildSeatCounts(string sElement, string sChildElement, Dictionary<string, int> seats)
        {
            return new XElement(sElement, seats.Select(p => new XElement(sChildElement, new XAttribute(NameAttribute, p.Key), new XAttribute(SeatsAttribute, p.Value))));
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
