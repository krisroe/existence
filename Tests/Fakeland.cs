using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Existence.Tests
{
    /// <summary>
    /// a made-up country whose made-up parties take part in made-up, and sometimes rigged, elections, so tests don't
    /// have to copy real ones. Each party has a part it usually plays:
    /// Liberals, Conservatives and Socialists are the big parties that win most of the seats;
    /// Marxists and Communists split the left vote, and sometimes have a surplus vote agreement;
    /// Nationalists want a strong national government;
    /// Regionalists are strong in one region, so they win seats there with few votes nationally;
    /// Pirates are spread thinly everywhere, near the electoral threshold;
    /// Islamists are a national minority list;
    /// SingleIssueParty stands for a single issue;
    /// Environmentalists go by another name in some constituencies;
    /// Anarchists boycott some elections, so they get no votes there;
    /// Pacifists and Libertarians tie with each other;
    /// Cheaters stuff the ballot boxes
    /// </summary>
    internal static class Fakeland
    {
        public const string Libertarians = nameof(Libertarians);
        public const string Liberals = nameof(Liberals);
        public const string Conservatives = nameof(Conservatives);
        public const string Environmentalists = nameof(Environmentalists);
        public const string Socialists = nameof(Socialists);
        public const string Marxists = nameof(Marxists);
        public const string Anarchists = nameof(Anarchists);
        public const string Communists = nameof(Communists);
        public const string Nationalists = nameof(Nationalists);
        public const string Regionalists = nameof(Regionalists);
        public const string SingleIssueParty = nameof(SingleIssueParty);
        public const string Cheaters = nameof(Cheaters);
        public const string Pirates = nameof(Pirates);
        public const string Islamists = nameof(Islamists);
        public const string Pacifists = nameof(Pacifists);

        /// <summary>
        /// every party, in no particular order
        /// </summary>
        public static readonly string[] Parties = { Libertarians, Liberals, Conservatives, Environmentalists, Socialists, Marxists, Anarchists, Communists, Nationalists, Regionalists, SingleIssueParty, Cheaters, Pirates, Islamists, Pacifists };
    }

    /// <summary>
    /// a party's votes in one constituency
    /// </summary>
    /// <param name="Name">the party's name in the constituency</param>
    internal sealed record FakeParty(string Name, long Votes)
    {
        /// <summary>
        /// the national party it belongs to, or null if that has the same name
        /// </summary>
        public string? NationalParty { get; init; }

        public bool MinorityList { get; init; }

        public int? ElectorateSeats { get; init; }
    }

    /// <summary>
    /// invalid or blank ballots
    /// </summary>
    internal sealed record FakeBallots(long Votes, bool RelevantToCalculation);

    internal sealed record FakeTurnout(long Base, long Raw, string BaseMeaning = "RegisteredVoters", string RawMeaning = "TotalVotes");

    /// <summary>
    /// a constituency of <see cref="Fakeland"/>
    /// </summary>
    internal sealed class FakeConstituency
    {
        public FakeConstituency(string sName, int iNumberOfSeats, params FakeParty[] parties)
        {
            Name = sName;
            NumberOfSeats = iNumberOfSeats;
            Parties = parties.ToList();
        }

        public string Name { get; }

        public int NumberOfSeats { get; }

        /// <summary>
        /// the parties, where those with the same votes get IDs in the order listed, so the first listed wins a tie
        /// </summary>
        public List<FakeParty> Parties { get; }

        public bool WinnerTakeAll { get; init; }

        public FakeBallots? InvalidVotes { get; init; }

        public FakeBallots? BlankVotes { get; init; }

        public FakeBallots? InvalidAndBlankVotes { get; init; }

        public FakeTurnout? Turnout { get; init; }

        public List<(string, string)> SurplusVoteAgreements { get; init; } = new List<(string, string)>();

        public decimal? MinorityListQuotientBonus { get; init; }
    }

    /// <summary>
    /// an election in <see cref="Fakeland"/>, written as the XML file CalculateParliamentaryApportionment reads, with
    /// the party IDs worked out from the votes
    /// </summary>
    internal sealed class FakeElection
    {
        public const string DHondt = "D'Hondt";
        public const string SainteLague = "Sainte-Laguë";

        public string Method { get; init; } = DHondt;

        /// <summary>
        /// the electoral threshold, as a percentage
        /// </summary>
        public decimal ElectoralThreshold { get; init; }

        public string? ElectoralThresholdBase { get; init; }

        /// <summary>
        /// the issue each single-issue party stands for, by national party
        /// </summary>
        public Dictionary<string, string> SingleIssues { get; init; } = new Dictionary<string, string>();

        public List<FakeConstituency> Constituencies { get; init; } = new List<FakeConstituency>();

        /// <summary>
        /// every algorithm for the method, so the program also checks they agree
        /// </summary>
        private string Algorithms => Method == DHondt ? "Base" : "OrderedSeats,QuotientTable,DivisorRounding";

        /// <summary>
        /// the national parties in ID order: by votes across all constituencies, and for the same votes in the order
        /// they first appear
        /// </summary>
        public List<(string Name, long Votes)> GetNationalParties()
        {
            List<(string Name, long Votes)> ret = new List<(string Name, long Votes)>();
            foreach (FakeParty next in Constituencies.SelectMany(c => c.Parties))
            {
                string sNationalParty = next.NationalParty ?? next.Name;
                int i = ret.FindIndex(p => p.Name == sNationalParty);
                if (i < 0) ret.Add((sNationalParty, next.Votes));
                else ret[i] = (sNationalParty, ret[i].Votes + next.Votes);
            }
            return ret.OrderByDescending(p => p.Votes).ToList();
        }

        /// <summary>
        /// builds the input with a Constituencies element
        /// </summary>
        public XDocument ToXml()
        {
            List<(string Name, long Votes)> nationalParties = GetNationalParties();
            int iNextId = nationalParties.Count + 1;
            List<XElement> constituencies = new List<XElement>();
            foreach (FakeConstituency c in Constituencies)
            {
                constituencies.Add(new XElement("Constituency",
                    new XAttribute("Name", c.Name),
                    c.WinnerTakeAll ? new XAttribute("CalculationMethod", "WinnerTakeAll") : null,
                    BuildDistrict(c, iNextId)));
                iNextId += c.Parties.Count;
            }
            return new XDocument(new XElement("Election", new XElement("Input",
                BuildMethod(),
                new XElement("NationalParties", nationalParties.Select((p, i) => new XElement("NationalParty",
                    new XAttribute("Id", i + 1),
                    new XAttribute("Name", p.Name),
                    SingleIssues.TryGetValue(p.Name, out string? sIssue) ? new XAttribute("SingleIssue", sIssue) : null))),
                new XElement("Constituencies", constituencies))));
        }

        /// <summary>
        /// builds the same election without constituencies, which needs exactly one Proportional constituency
        /// </summary>
        public XDocument ToSingleDistrictXml()
        {
            FakeConstituency c = Constituencies.Single();
            if (c.WinnerTakeAll) throw new InvalidOperationException("an election without constituencies is always proportional");
            return new XDocument(new XElement("Election", new XElement("Input", BuildMethod(), BuildDistrict(c, 1))));
        }

        private IEnumerable<XElement> BuildMethod()
        {
            yield return new XElement("Method", new XAttribute("Algorithms", Algorithms), Method);
            yield return new XElement("ElectoralThreshold", ElectoralThresholdBase == null ? null : new XAttribute("Base", ElectoralThresholdBase), ElectoralThreshold);
        }

        /// <summary>
        /// builds the elements of a constituency, or of an election without constituencies
        /// </summary>
        /// <param name="iFirstId">the ID of the party with the most votes</param>
        private static IEnumerable<XElement?> BuildDistrict(FakeConstituency c, int iFirstId)
        {
            static XElement? Ballots(string sName, FakeBallots? b) => b == null ? null : new XElement(sName, new XAttribute("RelevantToCalculation", b.RelevantToCalculation), b.Votes);

            yield return new XElement("NumberOfSeats", c.NumberOfSeats);
            if (c.Turnout != null)
            {
                yield return new XElement("TurnoutBase", new XAttribute("Meaning", c.Turnout.BaseMeaning), c.Turnout.Base);
                yield return new XElement("TurnoutRaw", new XAttribute("Meaning", c.Turnout.RawMeaning), c.Turnout.Raw);
            }
            yield return Ballots("InvalidVotes", c.InvalidVotes);
            yield return Ballots("BlankVotes", c.BlankVotes);
            yield return Ballots("InvalidAndBlankVotes", c.InvalidAndBlankVotes);
            yield return new XElement("Parties", c.Parties.OrderByDescending(p => p.Votes).Select((p, i) => new XElement("Party",
                new XAttribute("Id", iFirstId + i),
                new XAttribute("Name", p.Name),
                p.NationalParty == null ? null : new XAttribute("NationalParty", p.NationalParty),
                new XAttribute("Votes", p.Votes),
                p.MinorityList ? new XAttribute("MinorityList", true) : null,
                p.ElectorateSeats == null ? null : new XAttribute("ElectorateSeats", p.ElectorateSeats))));
            if (c.SurplusVoteAgreements.Count > 0)
            {
                yield return new XElement("SurplusVoteAgreements", c.SurplusVoteAgreements.Select(a => new XElement("SurplusVoteAgreement", new XAttribute("Party1", a.Item1), new XAttribute("Party2", a.Item2))));
            }
            if (c.MinorityListQuotientBonus != null) yield return new XElement("MinorityListQuotientBonus", c.MinorityListQuotientBonus);
        }

        /// <summary>
        /// runs the election through CalculateParliamentaryApportionment
        /// </summary>
        public FakeElectionResult Run() => Run(ToXml());

        /// <summary>
        /// runs an election file through CalculateParliamentaryApportionment, using a temporary file
        /// </summary>
        public static FakeElectionResult Run(XDocument input)
        {
            string sPath = Path.Combine(Path.GetTempPath(), $"Fakeland-{Guid.NewGuid():N}.xml");
            input.Save(sPath);
            TextWriter original = Console.Error;
            StringWriter error = new StringWriter();
            try
            {
                Console.SetError(error);
                int iExitCode = CalculateParliamentaryApportionment.Program.Main(new[] { sPath });
                return new FakeElectionResult(iExitCode, XDocument.Load(sPath), error.ToString());
            }
            finally
            {
                Console.SetError(original);
                File.Delete(sPath);
            }
        }
    }

    /// <summary>
    /// what CalculateParliamentaryApportionment did with an election file
    /// </summary>
    /// <param name="Document">the file afterwards, which is unchanged on failure</param>
    /// <param name="Error">what was written to standard error</param>
    internal sealed record FakeElectionResult(int ExitCode, XDocument Document, string Error)
    {
        private XElement Input => Document.Root!.Element("Input")!;

        /// <summary>
        /// the Output element after the Input element
        /// </summary>
        public XElement Output => Document.Root!.Element("Output")!;

        public XElement Constituency(string sName) => Input.Element("Constituencies")!.Elements("Constituency").Single(c => (string)c.Attribute("Name")! == sName);

        public XElement ConstituencyOutput(string sName) => Constituency(sName).Element("Output")!;

        /// <summary>
        /// a party in a constituency, or in an election without constituencies when <paramref name="sConstituency"/> is
        /// null
        /// </summary>
        public XElement Party(string? sConstituency, string sParty) => (sConstituency == null ? Input : Constituency(sConstituency)).Element("Parties")!.Elements("Party").Single(p => (string)p.Attribute("Name")! == sParty);

        public XElement NationalParty(string sName) => Input.Element("NationalParties")!.Elements("NationalParty").Single(p => (string)p.Attribute("Name")! == sName);

        /// <summary>
        /// each party's seats in a constituency
        /// </summary>
        public Dictionary<string, int> Seats(string sConstituency) => Constituency(sConstituency).Element("Parties")!.Elements("Party").ToDictionary(p => (string)p.Attribute("Name")!, p => (int)p.Attribute("Seats")!);

        /// <summary>
        /// each national party's seats
        /// </summary>
        public Dictionary<string, int> NationalSeats() => Input.Element("NationalParties")!.Elements("NationalParty").ToDictionary(p => (string)p.Attribute("Name")!, p => (int)p.Attribute("Seats")!);
    }
}
