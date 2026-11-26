using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.Politics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static Existence.Tests.Fakeland;

namespace Existence.Tests
{
    /// <summary>
    /// tests CalculateParliamentaryApportionment on elections whose seats are worked out separately in each
    /// constituency, using made-up elections in <see cref="Fakeland"/>
    /// </summary>
    [TestClass]
    public class ConstituencyElectionTest
    {
        private static FakeParty P(string sName, long lVotes) => new FakeParty(sName, lVotes);

        /// <summary>
        /// a simple election in two constituencies, for changing into a bad one
        /// </summary>
        private static FakeElection TwoConstituencies() => new FakeElection
        {
            ElectoralThreshold = 3,
            Constituencies =
            {
                new FakeConstituency("North", 5, P(Liberals, 500), P(Conservatives, 300), P(Socialists, 200)),
                new FakeConstituency("South", 4, P(Conservatives, 450), P(Socialists, 350), P(Pirates, 100)),
            },
        };

        /// <summary>
        /// checks that each national party's votes and seats add up those of its constituency parties, and the national
        /// party votes those of the constituencies
        /// </summary>
        private static void AssertNationalTotals(FakeElection e, FakeElectionResult r)
        {
            Dictionary<string, int> seats = new Dictionary<string, int>();
            foreach (FakeConstituency c in e.Constituencies)
            {
                Dictionary<string, int> constituencySeats = r.Seats(c.Name);
                Assert.AreEqual(c.NumberOfSeats, constituencySeats.Values.Sum(), c.Name);
                foreach (FakeParty p in c.Parties)
                {
                    string sNationalParty = p.NationalParty ?? p.Name;
                    seats[sNationalParty] = seats.GetValueOrDefault(sNationalParty) + constituencySeats[p.Name];
                }
            }
            foreach ((string sName, long lVotes) in e.GetNationalParties())
            {
                XElement nationalParty = r.NationalParty(sName);
                Assert.AreEqual(lVotes, (long)nationalParty.Attribute("Votes")!, sName);
                Assert.AreEqual(seats[sName], (int)nationalParty.Attribute("Seats")!, sName);
            }
            Assert.AreEqual(e.Constituencies.Sum(c => c.NumberOfSeats), r.NationalSeats().Values.Sum());
            Assert.AreEqual(e.Constituencies.SelectMany(c => c.Parties).Sum(p => p.Votes), (long)r.Output.Element("PartyVotes")!);
        }

        /// <summary>
        /// validates that the national results add up the constituencies, with the Environmentalists going by another
        /// name on the coast, the Anarchists boycotting, the Marxists and Communists in a surplus vote agreement, and a
        /// single-issue party whose issue is left as it is
        /// </summary>
        [TestMethod]
        public void ValidateNationalResultsAddUpConstituencies()
        {
            FakeElection e = new FakeElection
            {
                ElectoralThreshold = 3,
                SingleIssues = { [SingleIssueParty] = "four-day week" },
                Constituencies =
                {
                    new FakeConstituency("Capital", 10, P(Liberals, 3000), P(Conservatives, 2500), P(Socialists, 2000), P(Marxists, 600), P(Communists, 500), P(SingleIssueParty, 150), P(Anarchists, 0))
                    {
                        SurplusVoteAgreements = { (Marxists, Communists) },
                    },
                    new FakeConstituency("Coast", 6, P(Conservatives, 1800), P("Green Coast", 1200) with { NationalParty = Environmentalists }, P(Liberals, 1000), P(Socialists, 900), P(Pirates, 100)),
                    new FakeConstituency("Highlands", 4, P(Regionalists, 2000), P(Conservatives, 900), P(Liberals, 500), P(Environmentalists, 300), P(Anarchists, 0)),
                },
            };
            FakeElectionResult r = e.Run();
            Assert.AreEqual(0, r.ExitCode, r.Error);
            AssertNationalTotals(e, r);
            Assert.AreEqual(1500L, (long)r.NationalParty(Environmentalists).Attribute("Votes")!);
            Assert.AreEqual(0, r.NationalSeats()[Anarchists]);
            Assert.AreEqual("four-day week", (string?)r.NationalParty(SingleIssueParty).Attribute("SingleIssue"));
            Assert.IsNull(r.Output.Element("TotalVotes"), "there are no invalid or blank votes");
        }

        /// <summary>
        /// validates that an election with one constituency gives the same seats and Output element as the same election
        /// without constituencies
        /// </summary>
        [TestMethod]
        [DataRow(FakeElection.DHondt)]
        [DataRow(FakeElection.SainteLague)]
        public void ValidateOneConstituencyMatchesNoConstituencies(string sMethod)
        {
            FakeElection e = new FakeElection
            {
                Method = sMethod,
                ElectoralThreshold = 5,
                Constituencies =
                {
                    new FakeConstituency("Everywhere", 11, P(Liberals, 4100), P(Conservatives, 3900), P(Socialists, 1500), P(Pirates, 560), P(Pacifists, 400), P(Cheaters, 90))
                    {
                        InvalidVotes = new FakeBallots(300, false),
                        BlankVotes = new FakeBallots(250, true),
                        Turnout = new FakeTurnout(14000, 11100),
                    },
                },
            };
            FakeElectionResult withConstituencies = e.Run();
            FakeElectionResult without = FakeElection.Run(e.ToSingleDistrictXml());
            Assert.AreEqual(0, withConstituencies.ExitCode, withConstituencies.Error);
            Assert.AreEqual(0, without.ExitCode, without.Error);
            Assert.IsTrue(XNode.DeepEquals(without.Output, withConstituencies.ConstituencyOutput("Everywhere")), $"{without.Output}\n\n{withConstituencies.ConstituencyOutput("Everywhere")}");
            foreach (FakeParty p in e.Constituencies[0].Parties)
            {
                static string Results(XElement party) => string.Join(" ", party.Attributes().Where(a => a.Name != "Id").Select(a => a.ToString()));
                Assert.AreEqual(Results(without.Party(null, p.Name)), Results(withConstituencies.Party("Everywhere", p.Name)));
            }
        }

        /// <summary>
        /// validates that running on a file that already has results gives the same file, since results are ignored
        /// when reading
        /// </summary>
        [TestMethod]
        public void ValidateRunningAgainGivesTheSameFile()
        {
            FakeElectionResult first = TwoConstituencies().Run();
            Assert.AreEqual(0, first.ExitCode, first.Error);
            FakeElectionResult second = FakeElection.Run(first.Document);
            Assert.AreEqual(0, second.ExitCode, second.Error);
            Assert.AreEqual(first.Document.ToString(), second.Document.ToString());
        }

        /// <summary>
        /// validates that bad constituency input fails with an error saying what's wrong, leaving the file unchanged
        /// </summary>
        [TestMethod]
        [DataRow("NationalIdsOutOfOrder", "NationalParties: ")]
        [DataRow("ConstituencyIdsDontCarryOn", "Constituency South: the IDs have to go from")]
        [DataRow("NationalPartyWithoutParty", "national party Pacifists has no party in any Constituency")]
        [DataRow("UnknownNationalParty", "Constituency South: Pirates's national party Monarchists isn't in NationalParties")]
        [DataRow("DuplicateConstituency", "North is listed more than once in Constituencies")]
        [DataRow("NumberOfSeatsInInput", "with Constituencies, NumberOfSeats goes in each Constituency rather than in Input")]
        [DataRow("NationalPartiesWithoutConstituencies", "NationalParties is only for Constituencies")]
        [DataRow("AllWinnerTakeAll", "at least one Constituency has to be Proportional")]
        public void ValidateBadConstituencyInputIsRejected(string sCase, string sExpectedError)
        {
            FakeElection e = TwoConstituencies();
            XDocument doc = e.ToXml();
            XElement input = doc.Root!.Element("Input")!;
            List<XElement> constituencies = input.Element("Constituencies")!.Elements("Constituency").ToList();
            IEnumerable<XElement> Parties(XElement constituency) => constituency.Element("Parties")!.Elements("Party");
            switch (sCase)
            {
                case "NationalIdsOutOfOrder":
                    List<XElement> nationalParties = input.Element("NationalParties")!.Elements("NationalParty").ToList();
                    nationalParties[0].SetAttributeValue("Id", 2);
                    nationalParties[1].SetAttributeValue("Id", 1);
                    break;
                case "ConstituencyIdsDontCarryOn":
                    foreach (XElement party in Parties(constituencies[1])) party.SetAttributeValue("Id", (int)party.Attribute("Id")! + 1);
                    break;
                case "NationalPartyWithoutParty":
                    input.Element("NationalParties")!.Add(new XElement("NationalParty", new XAttribute("Id", e.GetNationalParties().Count + 1), new XAttribute("Name", Pacifists)));
                    foreach (XElement party in constituencies.SelectMany(Parties)) party.SetAttributeValue("Id", (int)party.Attribute("Id")! + 1);
                    break;
                case "UnknownNationalParty":
                    Parties(constituencies[1]).Single(p => (string)p.Attribute("Name")! == Pirates).SetAttributeValue("NationalParty", "Monarchists");
                    break;
                case "DuplicateConstituency":
                    constituencies[1].SetAttributeValue("Name", "North");
                    break;
                case "NumberOfSeatsInInput":
                    input.Add(new XElement("NumberOfSeats", 9));
                    break;
                case "NationalPartiesWithoutConstituencies":
                    doc = new FakeElection { ElectoralThreshold = 3, Constituencies = { e.Constituencies[0] } }.ToSingleDistrictXml();
                    doc.Root!.Element("Input")!.Add(new XElement(input.Element("NationalParties")!));
                    break;
                case "AllWinnerTakeAll":
                    foreach (XElement next in constituencies) next.SetAttributeValue("CalculationMethod", "WinnerTakeAll");
                    break;
                default:
                    throw new ArgumentException($"unknown case {sCase}", nameof(sCase));
            }
            FakeElectionResult r = FakeElection.Run(doc);
            Assert.AreEqual(1, r.ExitCode);
            StringAssert.Contains(r.Error, sExpectedError);
            Assert.IsNull(r.Document.Root!.Element("Output"), "the file should be left unchanged");
        }

        /// <summary>
        /// validates that a WinnerTakeAll constituency gives every seat to the party with the most votes, that the party
        /// listed first, so with the lower ID, wins a tie, and that its Output element has only what it should, with its
        /// relevant blank votes never changing the result
        /// </summary>
        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void ValidateWinnerTakeAll(bool pacifistsListedFirst)
        {
            FakeParty[] tied = pacifistsListedFirst ? new[] { P(Pacifists, 500), P(Libertarians, 500) } : new[] { P(Libertarians, 500), P(Pacifists, 500) };
            FakeElection e = new FakeElection
            {
                ElectoralThreshold = 3,
                Constituencies =
                {
                    new FakeConstituency("Mainland", 5, P(Liberals, 1000), P(Pacifists, 300), P(Libertarians, 200)),
                    new FakeConstituency("Island", 2, tied.Append(P(Pirates, 20)).ToArray())
                    {
                        WinnerTakeAll = true,
                        BlankVotes = new FakeBallots(50, true),
                    },
                },
            };
            FakeElectionResult r = e.Run();
            Assert.AreEqual(0, r.ExitCode, r.Error);
            string sWinner = tied[0].Name;
            CollectionAssert.AreEquivalent(new Dictionary<string, int> { [sWinner] = 2, [tied[1].Name] = 0, [Pirates] = 0 }, r.Seats("Island"));
            XElement output = r.ConstituencyOutput("Island");
            CollectionAssert.AreEqual(new[] { "TotalVotes", "BlankVotes", "PartyVotes" }, output.Elements().Select(x => x.Name.LocalName).ToArray());
            Assert.AreEqual(1070L, (long)output.Element("TotalVotes")!);
            Assert.AreEqual(false, (bool?)output.Element("BlankVotes")!.Attribute("RelevantToResult"));
            Assert.AreEqual(false, (bool?)r.Output.Element("BlankVotes")!.Attribute("RelevantToResult"));
            AssertNationalTotals(e, r);
        }

        /// <summary>
        /// validates that a WinnerTakeAll constituency, which has no electoral threshold, rejects proportional features that don't make sense
        /// with one
        /// </summary>
        [TestMethod]
        [DataRow("SurplusVoteAgreements")]
        [DataRow("MinorityListQuotientBonus")]
        [DataRow("MinorityList")]
        [DataRow("ElectorateSeats")]
        public void ValidateWinnerTakeAllRejectsProportionalExtras(string sExtra)
        {
            FakeConstituency island = new FakeConstituency("Island", 1, P(Islamists, 300) with { MinorityList = sExtra == "MinorityList", ElectorateSeats = sExtra == "ElectorateSeats" ? 1 : null }, P(Pacifists, 200))
            {
                WinnerTakeAll = true,
                SurplusVoteAgreements = sExtra == "SurplusVoteAgreements" ? new List<(string, string)> { (Islamists, Pacifists) } : new List<(string, string)>(),
                MinorityListQuotientBonus = sExtra == "MinorityListQuotientBonus" ? 35 : null,
            };
            FakeElection e = new FakeElection
            {
                ElectoralThreshold = 3,
                Constituencies = { new FakeConstituency("Mainland", 5, P(Liberals, 1000), P(Islamists, 300)), island },
            };
            FakeElectionResult r = e.Run();
            Assert.AreEqual(1, r.ExitCode);
            StringAssert.Contains(r.Error, $"Constituency Island: {sExtra} isn't for WinnerTakeAll");
        }

        /// <summary>
        /// validates that the electoral threshold applies in each constituency on its own: the Pirates, with 9% of the
        /// votes in every constituency and so nationally, win nothing under a 10% threshold, while the Regionalists, with
        /// fewer votes nationally but all of them in the Highlands, win a seat there
        /// </summary>
        [TestMethod]
        public void ValidateElectoralThresholdIsPerConstituency()
        {
            FakeElection e = new FakeElection
            {
                ElectoralThreshold = 10,
                Constituencies =
                {
                    new FakeConstituency("Capital", 5, P(Liberals, 500), P(Conservatives, 410), P(Pirates, 90)),
                    new FakeConstituency("Coast", 5, P(Conservatives, 500), P(Liberals, 410), P(Pirates, 90)),
                    new FakeConstituency("Highlands", 5, P(Conservatives, 400), P(Liberals, 260), P(Regionalists, 250), P(Pirates, 90)),
                },
            };
            FakeElectionResult r = e.Run();
            Assert.AreEqual(0, r.ExitCode, r.Error);
            Assert.IsTrue((long)r.NationalParty(Regionalists).Attribute("Votes")! < (long)r.NationalParty(Pirates).Attribute("Votes")!);
            Assert.AreEqual(1, r.NationalSeats()[Regionalists]);
            Assert.AreEqual(0, r.NationalSeats()[Pirates]);
            foreach (FakeConstituency c in e.Constituencies)
                Assert.AreEqual(false, (bool?)r.Party(c.Name, Pirates).Attribute("AboveThreshold"), c.Name);
            AssertNationalTotals(e, r);
        }

        /// <summary>
        /// validates that in a constituency a party exactly on the electoral threshold passes it and one vote fewer
        /// doesn't
        /// </summary>
        [TestMethod]
        [DataRow(100L, true)]
        [DataRow(99L, false)]
        public void ValidateConstituencyElectoralThresholdIsExact(long lPirateVotes, bool isAboveThreshold)
        {
            FakeElection e = new FakeElection
            {
                ElectoralThreshold = 10,
                Constituencies =
                {
                    new FakeConstituency("Capital", 10, P(Liberals, 500), P(Conservatives, 500 - lPirateVotes), P(Pirates, lPirateVotes)),
                    new FakeConstituency("Coast", 3, P(Liberals, 600), P(Conservatives, 400)),
                },
            };
            FakeElectionResult r = e.Run();
            Assert.AreEqual(0, r.ExitCode, r.Error);
            Assert.AreEqual(isAboveThreshold, (bool?)r.Party("Capital", Pirates).Attribute("AboveThreshold"));
            Assert.AreEqual(isAboveThreshold ? 1 : 0, r.NationalSeats()[Pirates]);
        }

        /// <summary>
        /// validates that the national turnout adds up the constituencies when they all have it, and is left out when
        /// any doesn't
        /// </summary>
        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void ValidateNationalTurnout(bool allHaveTurnout)
        {
            FakeElection e = new FakeElection
            {
                ElectoralThreshold = 3,
                Constituencies =
                {
                    new FakeConstituency("North", 5, P(Liberals, 600), P(Conservatives, 500)) { Turnout = new FakeTurnout(2000, 1100) },
                    new FakeConstituency("South", 4, P(Conservatives, 900), P(Socialists, 600)) { Turnout = allHaveTurnout ? new FakeTurnout(3000, 1500) : null },
                },
            };
            FakeElectionResult r = e.Run();
            Assert.AreEqual(0, r.ExitCode, r.Error);
            Assert.AreEqual(55m, (decimal)r.ConstituencyOutput("North").Element("TurnoutPercentage")!);
            if (allHaveTurnout)
            {
                Assert.AreEqual(5000L, (long)r.Output.Element("TurnoutBase")!);
                Assert.AreEqual(2600L, (long)r.Output.Element("TurnoutRaw")!);
                Assert.AreEqual(52m, (decimal)r.Output.Element("TurnoutPercentage")!);
            }
            else
            {
                Assert.IsNull(r.Output.Element("TurnoutBase"));
                Assert.IsNull(r.Output.Element("TurnoutRaw"));
                Assert.IsNull(r.Output.Element("TurnoutPercentage"));
            }
        }

        /// <summary>
        /// validates that the national turnout can't add up constituencies that count different things
        /// </summary>
        [TestMethod]
        public void ValidateNationalTurnoutNeedsTheSameMeanings()
        {
            FakeElection e = new FakeElection
            {
                ElectoralThreshold = 3,
                Constituencies =
                {
                    new FakeConstituency("North", 5, P(Liberals, 600), P(Conservatives, 500)) { Turnout = new FakeTurnout(2000, 1100) },
                    new FakeConstituency("South", 4, P(Conservatives, 900), P(Socialists, 600)) { Turnout = new FakeTurnout(3000, 1500, RawMeaning: "BallotsInBoxes") },
                },
            };
            FakeElectionResult r = e.Run();
            Assert.AreEqual(1, r.ExitCode);
            StringAssert.Contains(r.Error, "count different things");
        }

        /// <summary>
        /// validates the national totals of invalid and blank votes, given separately in some constituencies and not at
        /// all in another, none of them relevant, so there are no RelevantToResult attributes
        /// </summary>
        [TestMethod]
        public void ValidateNationalInvalidAndBlankVotesGivenSeparately()
        {
            FakeElection e = new FakeElection
            {
                ElectoralThreshold = 3,
                Constituencies =
                {
                    new FakeConstituency("North", 5, P(Liberals, 600), P(Conservatives, 500)) { InvalidVotes = new FakeBallots(30, false), BlankVotes = new FakeBallots(20, false) },
                    new FakeConstituency("South", 4, P(Conservatives, 900), P(Socialists, 600)) { InvalidVotes = new FakeBallots(10, false) },
                    new FakeConstituency("Island", 1, P(Pacifists, 70), P(Pirates, 30)),
                },
            };
            FakeElectionResult r = e.Run();
            Assert.AreEqual(0, r.ExitCode, r.Error);
            CollectionAssert.AreEqual(new[] { "TotalVotes", "InvalidVotes", "BlankVotes", "PartyVotes" }, r.Output.Elements().Select(x => x.Name.LocalName).ToArray());
            Assert.AreEqual(2760L, (long)r.Output.Element("TotalVotes")!);
            Assert.AreEqual(40L, (long)r.Output.Element("InvalidVotes")!);
            Assert.AreEqual(20L, (long)r.Output.Element("BlankVotes")!);
            Assert.IsFalse(r.Document.Descendants().Any(x => x.Attribute("RelevantToResult") != null));
        }

        /// <summary>
        /// validates the national total of invalid and blank votes when the constituencies don't separate them
        /// </summary>
        [TestMethod]
        public void ValidateNationalInvalidAndBlankVotesGivenTogether()
        {
            FakeElection e = new FakeElection
            {
                ElectoralThreshold = 3,
                Constituencies =
                {
                    new FakeConstituency("North", 5, P(Liberals, 600), P(Conservatives, 500)) { InvalidAndBlankVotes = new FakeBallots(25, false) },
                    new FakeConstituency("South", 4, P(Conservatives, 900), P(Socialists, 600)) { InvalidAndBlankVotes = new FakeBallots(15, false) },
                },
            };
            FakeElectionResult r = e.Run();
            Assert.AreEqual(0, r.ExitCode, r.Error);
            CollectionAssert.AreEqual(new[] { "TotalVotes", "InvalidAndBlankVotes", "PartyVotes" }, r.Output.Elements().Select(x => x.Name.LocalName).ToArray());
            Assert.AreEqual(40L, (long)r.Output.Element("InvalidAndBlankVotes")!);
        }

        /// <summary>
        /// the rigged seat swap: blank ballots push the Pirates under a 20% threshold in the North, giving their seat to
        /// the Environmentalists, and push the Environmentalists under it in the South, giving their seat to the Pirates.
        /// Each party ends up with the same seats nationally, but the blank votes still changed the result, so they are
        /// relevant to it nationally as well as in each constituency
        /// </summary>
        [TestMethod]
        public void ValidateSeatSwapIsRelevantToResultNationally()
        {
            FakeElection Rigged(bool blanksCount) => new FakeElection
            {
                ElectoralThreshold = 20,
                Constituencies =
                {
                    new FakeConstituency("North", 3, P(Environmentalists, 320), P(Liberals, 300), P(Pirates, 170)) { BlankVotes = new FakeBallots(100, blanksCount) },
                    new FakeConstituency("South", 3, P(Pirates, 320), P(Liberals, 300), P(Environmentalists, 170)) { BlankVotes = new FakeBallots(100, blanksCount) },
                },
            };
            FakeElectionResult rigged = Rigged(true).Run();
            FakeElectionResult fair = Rigged(false).Run();
            Assert.AreEqual(0, rigged.ExitCode, rigged.Error);
            Assert.AreEqual(0, fair.ExitCode, fair.Error);

            CollectionAssert.AreEquivalent(new Dictionary<string, int> { [Environmentalists] = 2, [Liberals] = 1, [Pirates] = 0 }, rigged.Seats("North"));
            CollectionAssert.AreEquivalent(new Dictionary<string, int> { [Pirates] = 2, [Liberals] = 1, [Environmentalists] = 0 }, rigged.Seats("South"));
            CollectionAssert.AreEquivalent(new Dictionary<string, int> { [Environmentalists] = 1, [Liberals] = 1, [Pirates] = 1 }, fair.Seats("North"));
            CollectionAssert.AreEquivalent(fair.NationalSeats(), rigged.NationalSeats(), "the national seats come out the same");

            foreach (string sConstituency in new[] { "North", "South" })
                Assert.AreEqual(true, (bool?)rigged.ConstituencyOutput(sConstituency).Element("BlankVotes")!.Attribute("RelevantToResult"), sConstituency);
            XElement national = rigged.Output.Element("BlankVotes")!;
            Assert.AreEqual(200L, (long)national);
            Assert.AreEqual(true, (bool?)national.Attribute("RelevantToResult"));
            Assert.IsNull(fair.ConstituencyOutput("North").Element("BlankVotes"), "blank votes that aren't relevant to the calculation get no RelevantToResult");
        }

        /// <summary>
        /// the rigged ballot stuffing: the Cheaters stuff the Capital's ballot boxes with invalid ballots, where the
        /// threshold counts every ballot in the boxes, pushing the Pirates under it. The invalid ballots changed the
        /// result there and the blank ones didn't, while in the Countryside neither did. Invalid and blank votes are both
        /// relevant but given separately, so InvalidAndBlankVotes gets a RelevantToResult, and nationally it has no
        /// total
        /// </summary>
        [TestMethod]
        public void ValidateBallotStuffingIsRelevantToResult()
        {
            FakeElection Stuffed(long lInvalidVotes) => new FakeElection
            {
                ElectoralThreshold = 10,
                ElectoralThresholdBase = "BallotsInBoxes",
                Constituencies =
                {
                    new FakeConstituency("Capital", 9, P(Liberals, 500), P(Conservatives, 370), P(Pirates, 110), P(Cheaters, 20))
                    {
                        InvalidVotes = new FakeBallots(lInvalidVotes, true),
                        BlankVotes = new FakeBallots(5, true),
                    },
                    new FakeConstituency("Countryside", 5, P(Liberals, 600), P(Conservatives, 400))
                    {
                        InvalidVotes = new FakeBallots(10, true),
                        BlankVotes = new FakeBallots(5, true),
                    },
                },
            };
            FakeElectionResult stuffed = Stuffed(200).Run();
            FakeElectionResult honest = Stuffed(5).Run();
            Assert.AreEqual(0, stuffed.ExitCode, stuffed.Error);
            Assert.AreEqual(0, honest.ExitCode, honest.Error);
            Assert.AreEqual(0, stuffed.Seats("Capital")[Pirates]);
            Assert.AreEqual(1, honest.Seats("Capital")[Pirates]);
            Assert.AreEqual(0, stuffed.Seats("Capital")[Cheaters], "cheating doesn't pay");

            static Dictionary<string, bool> Relevance(XElement output) => output.Elements().Where(x => x.Attribute("RelevantToResult") != null).ToDictionary(x => x.Name.LocalName, x => (bool)x.Attribute("RelevantToResult")!);
            CollectionAssert.AreEquivalent(new Dictionary<string, bool> { ["InvalidVotes"] = true, ["BlankVotes"] = false, ["InvalidAndBlankVotes"] = true }, Relevance(stuffed.ConstituencyOutput("Capital")));
            CollectionAssert.AreEquivalent(new Dictionary<string, bool> { ["InvalidVotes"] = false, ["BlankVotes"] = false, ["InvalidAndBlankVotes"] = false }, Relevance(stuffed.ConstituencyOutput("Countryside")));
            CollectionAssert.AreEquivalent(new Dictionary<string, bool> { ["InvalidVotes"] = true, ["BlankVotes"] = false, ["InvalidAndBlankVotes"] = true }, Relevance(stuffed.Output));
            Assert.AreEqual(210L, (long)stuffed.Output.Element("InvalidVotes")!);
            Assert.AreEqual("", stuffed.Output.Element("InvalidAndBlankVotes")!.Value, "the constituencies give no total of invalid and blank votes together");
        }

        /// <summary>
        /// the dead heat: the Pacifists and Libertarians tie for the last seat, which goes to the one listed first, so
        /// with the lower ID
        /// </summary>
        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void ValidateDeadHeatGoesToLowerId(bool pacifistsListedFirst)
        {
            FakeParty[] tied = pacifistsListedFirst ? new[] { P(Pacifists, 150), P(Libertarians, 150) } : new[] { P(Libertarians, 150), P(Pacifists, 150) };
            FakeElection e = new FakeElection
            {
                Constituencies = { new FakeConstituency("Capital", 3, new[] { P(Liberals, 400) }.Concat(tied).ToArray()) },
            };
            FakeElectionResult r = e.Run();
            Assert.AreEqual(0, r.ExitCode, r.Error);
            CollectionAssert.AreEquivalent(new Dictionary<string, int> { [Liberals] = 2, [tied[0].Name] = 1, [tied[1].Name] = 0 }, r.Seats("Capital"));
        }

        /// <summary>
        /// the landslide: only the Conservatives pass the threshold anywhere, so they win every seat, and with no other
        /// party with seats there are no votes needed for the next seat
        /// </summary>
        [TestMethod]
        [DataRow(FakeElection.DHondt)]
        [DataRow(FakeElection.SainteLague)]
        public void ValidateLandslide(string sMethod)
        {
            FakeElection e = new FakeElection
            {
                Method = sMethod,
                ElectoralThreshold = 10,
                Constituencies =
                {
                    new FakeConstituency("Capital", 4, P(Conservatives, 950), P(Pirates, 50)),
                    new FakeConstituency("Coast", 3, P(Conservatives, 960), P(Pirates, 40)),
                },
            };
            FakeElectionResult r = e.Run();
            Assert.AreEqual(0, r.ExitCode, r.Error);
            CollectionAssert.AreEquivalent(new Dictionary<string, int> { [Conservatives] = 7, [Pirates] = 0 }, r.NationalSeats());
            foreach (FakeConstituency c in e.Constituencies)
                Assert.AreEqual("", r.ConstituencyOutput(c.Name).Element("VotesNeededForNextOrderedSeat")!.Value, c.Name);
        }

        /// <summary>
        /// stress tests made-up elections with random constituencies, parties, votes, invalid and blank votes and
        /// turnout, with small vote counts in half of them so ties are common, checking each constituency against the
        /// seat distribution worked out directly and the national results against the constituencies. The seed is fixed
        /// so the elections are the same every run
        /// </summary>
        [TestMethod]
        public void ValidateMadeUpConstituencyElections()
        {
            Random random = new Random(1958);
            decimal[] thresholds = { 0, 3, 5 };
            for (int iElection = 0; iElection < 150; iElection++)
            {
                long lMostVotes = iElection % 2 == 0 ? 20 : 100000;
                FakeElection e = new FakeElection
                {
                    Method = random.Next(2) == 0 ? FakeElection.DHondt : FakeElection.SainteLague,
                    ElectoralThreshold = thresholds[random.Next(thresholds.Length)],
                };
                bool withTurnout = random.Next(2) == 0;
                int iConstituencies = random.Next(1, 13);
                for (int i = 0; i < iConstituencies; i++)
                    e.Constituencies.Add(MakeUpConstituency(random, $"Constituency{i + 1}", winnerTakeAll: i > 0 && random.Next(6) == 0, lMostVotes, e.ElectoralThreshold, withTurnout));

                FakeElectionResult r = e.Run();
                string sElection = $"election {iElection}";
                Assert.AreEqual(0, r.ExitCode, $"{sElection}: {r.Error}");
                AssertNationalTotals(e, r);
                AssertMatchesDirectCalculation(e, r, sElection);
            }
        }

        /// <summary>
        /// makes up a constituency with a random set of parties and votes, and sometimes invalid and blank votes given
        /// separately or together and relevant or not. A Proportional constituency's biggest party always passes the
        /// threshold, so some party qualifies
        /// </summary>
        private static FakeConstituency MakeUpConstituency(Random random, string sName, bool winnerTakeAll, long lMostVotes, decimal threshold, bool withTurnout)
        {
            List<string> names = Fakeland.Parties.OrderBy(p => random.Next()).Take(random.Next(1, Fakeland.Parties.Length + 1)).ToList();
            List<long> votes = names.Select(n => random.NextInt64(0, lMostVotes + 1)).ToList();
            votes[0]++; //so there is at least one vote

            FakeBallots? Ballots() => random.Next(2) == 0 ? null : new FakeBallots(random.NextInt64(0, lMostVotes / 5 + 1), random.Next(2) == 0);
            FakeBallots? invalidVotes = null, blankVotes = null, invalidAndBlankVotes = null;
            switch (random.Next(3))
            {
                case 1:
                    invalidVotes = Ballots();
                    blankVotes = Ballots();
                    break;
                case 2:
                    invalidAndBlankVotes = Ballots();
                    break;
            }
            long lRelevant = new[] { invalidVotes, blankVotes, invalidAndBlankVotes }.Where(b => b?.RelevantToCalculation == true).Sum(b => b!.Votes);
            int iBiggest = votes.IndexOf(votes.Max());
            if (!winnerTakeAll && votes[iBiggest] * 100 < threshold * (votes.Sum() + lRelevant)) votes[iBiggest] += votes.Sum() + lRelevant;

            long lTotal = votes.Sum() + new[] { invalidVotes, blankVotes, invalidAndBlankVotes }.Sum(b => b?.Votes ?? 0);
            return new FakeConstituency(sName, random.Next(1, 31), names.Zip(votes, (n, v) => P(n, v)).ToArray())
            {
                WinnerTakeAll = winnerTakeAll,
                InvalidVotes = invalidVotes,
                BlankVotes = blankVotes,
                InvalidAndBlankVotes = invalidAndBlankVotes,
                Turnout = withTurnout ? new FakeTurnout(lTotal + random.NextInt64(0, lMostVotes + 1), lTotal) : null,
            };
        }

        /// <summary>
        /// checks each constituency's seats and RelevantToResult attributes against working them out directly with
        /// <see cref="SeatDistributions"/>, and the national RelevantToResult attributes against the constituencies
        /// </summary>
        private static void AssertMatchesDirectCalculation(FakeElection e, FakeElectionResult r, string sElection)
        {
            SimpleFraction threshold = SimpleFraction.FromDecimal(e.ElectoralThreshold);
            Dictionary<string, List<bool>> national = new Dictionary<string, List<bool>>();
            foreach (FakeConstituency c in e.Constituencies)
            {
                string sWhere = $"{sElection}, {c.Name}";
                Dictionary<string, int> seats = r.Seats(c.Name);
                Dictionary<string, long> relevant = new Dictionary<string, long>();
                foreach ((string sName, FakeBallots? b) in new[] { ("InvalidVotes", c.InvalidVotes), ("BlankVotes", c.BlankVotes), ("InvalidAndBlankVotes", c.InvalidAndBlankVotes) })
                {
                    if (b?.RelevantToCalculation == true) relevant[sName] = b.Votes;
                }
                bool both = relevant.ContainsKey("InvalidVotes") && relevant.ContainsKey("BlankVotes");
                List<string> relevanceNames = new[] { "InvalidVotes", "BlankVotes", "InvalidAndBlankVotes" }.Where(n => relevant.ContainsKey(n) || (n == "InvalidAndBlankVotes" && both)).ToList();

                Dictionary<string, bool> expected = new Dictionary<string, bool>();
                if (c.WinnerTakeAll)
                {
                    FakeParty winner = c.Parties.OrderByDescending(p => p.Votes).First();
                    CollectionAssert.AreEquivalent(c.Parties.ToDictionary(p => p.Name, p => p == winner ? c.NumberOfSeats : 0), seats, sWhere);
                    foreach (string sName in relevanceNames) expected[sName] = false;
                }
                else
                {
                    List<PoliticalPartyVotes> parties = r.Constituency(c.Name).Element("Parties")!.Elements("Party").Select(p => new PoliticalPartyVotes((int)p.Attribute("Id")!, (string)p.Attribute("Name")!, (long)p.Attribute("Votes")!)).ToList();
                    int iOffset = parties.Min(p => p.Id) - 1;
                    parties = parties.Select(p => p with { Id = p.Id - iOffset }).ToList();
                    SeatDistributionBase Calculate(long lInvalidAndBlankVotes) => e.Method == FakeElection.DHondt
                        ? SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(parties, new List<(int, int)>(), c.NumberOfSeats, threshold, null, null, lInvalidAndBlankVotes)
                        : SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(parties, new List<(int, int)>(), c.NumberOfSeats, threshold, null, null, lInvalidAndBlankVotes);
                    bool Differ(SeatDistributionBase a, SeatDistributionBase b) => parties.Any(p => a.Seats.GetValueOrDefault(p.Name) != b.Seats.GetValueOrDefault(p.Name));

                    long lRelevant = relevant.Values.Sum();
                    SeatDistributionBase direct = Calculate(lRelevant);
                    CollectionAssert.AreEquivalent(parties.ToDictionary(p => p.Name, p => direct.Seats.GetValueOrDefault(p.Name)), seats, sWhere);
                    foreach (string sName in relevanceNames)
                        expected[sName] = Differ(direct, Calculate(sName == "InvalidAndBlankVotes" ? 0 : lRelevant - relevant[sName]));
                }

                Dictionary<string, bool> actual = r.ConstituencyOutput(c.Name).Elements().Where(x => x.Attribute("RelevantToResult") != null).ToDictionary(x => x.Name.LocalName, x => (bool)x.Attribute("RelevantToResult")!);
                CollectionAssert.AreEquivalent(expected, actual, sWhere);
                foreach (KeyValuePair<string, bool> next in expected)
                {
                    if (!national.TryGetValue(next.Key, out List<bool>? list)) national[next.Key] = list = new List<bool>();
                    list.Add(next.Value);
                }
            }

            foreach (string sName in new[] { "InvalidVotes", "BlankVotes", "InvalidAndBlankVotes" })
            {
                bool? expected = national.TryGetValue(sName, out List<bool>? list) ? list.Contains(true) : null;
                Assert.AreEqual(expected, (bool?)r.Output.Element(sName)?.Attribute("RelevantToResult"), $"{sElection}, national {sName}");
            }
        }
    }
}
