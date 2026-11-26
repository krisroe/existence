using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.Politics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
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
    /// and regenerated on every run, so only Id, Name and Votes need to be filled in. Id is the party's number: 1 for
    /// the party with the most votes, then 2, 3 and so on as the votes go down, each used once, so a party with more
    /// votes always has a lower ID. Parties with the same votes can be in either order, and the lower ID wins a tie
    /// between them. The seats are worked out by ID. The file looks like this before it is
    /// first run, with SurplusVoteAgreements being optional, and FirstDivisor being optional and only for Sainte-Laguë
    /// (leave it out for plain Sainte-Laguë, or use 7/5 for Norway's modified Sainte-Laguë). For mixed-member
    /// proportional, as in New Zealand, give each party that won electorates an ElectorateSeats attribute, also only for
    /// Sainte-Laguë; then each party also gets ListSeats, OverhangSeats and TotalSeats attributes, and the Output element
    /// gets NumberOfMembers.
    /// For national minority lists, as in Serbia, give each one a MinorityList="true" attribute, only for D'Hondt; they
    /// qualify whatever their votes. An optional MinorityListQuotientBonus element, also only for D'Hondt, is the
    /// percentage the quotients of minority lists below the threshold are raised by, such as 35 for Serbia; each
    /// minority list then also gets a QuotientBonus attribute saying whether it got the bonus.
    /// Ballots that aren't votes for a party go in optional InvalidAndBlankVotes, InvalidVotes and BlankVotes elements,
    /// with InvalidAndBlankVotes for a count that doesn't separate them, so it can't be used with the other two. Each
    /// has a required Relevant attribute saying whether those ballots count toward the electoral threshold, as in
    /// Serbia, where it is a percentage of everyone who voted, rather than only of the party votes. With any of them the
    /// Output element gets TotalVotes, the party votes plus all of those ballots whether relevant or not, which is for
    /// information and doesn't affect the seats, and ElectoralThresholdVotes, the votes the threshold is a percentage of.
    /// The ElectoralThreshold element can have a Base attribute, an <see cref="ElectoralThresholdBase"/> saying what the
    /// threshold is a percentage of. It explains the Relevant attributes rather than replacing them, so they have to agree.
    /// It can also have a BaseLaw attribute with what the law says the threshold is a percentage of, which can be less
    /// specific than Base. It is for information, so it is left as it is and not used.
    /// Optional TurnoutBase and TurnoutRaw elements, which go together, are the number turnout is a percentage of and the
    /// number included in turnout. Each has a required Meaning attribute saying where the number comes from, which is a
    /// <see cref="TurnoutBaseMeaning"/> or <see cref="TurnoutRawMeaning"/>. They are for information and don't affect the
    /// seats. With them the Output element gets TurnoutPercentage, rounded to 2 decimal places.
    /// An optional RulesChanges element has text explaining changes to the rules since the previous election. It is for
    /// information, so it is left as it is and not used.
    /// A Party element, or with constituencies a NationalParty element, can have a SingleIssue attribute with the one
    /// issue a single-issue party stands for. It is for information, so it is left as it is and not used.
    /// For an election whose seats are worked out separately in each constituency, as in Spain, the Input element has a
    /// Constituencies element with a Constituency element for each, with a Name attribute, holding the NumberOfSeats,
    /// Parties, SurplusVoteAgreements, MinorityListQuotientBonus, invalid and blank votes and turnout elements that
    /// otherwise go in the Input element. The Method, FirstDivisor, ElectoralThreshold and IncludePerformance elements
    /// stay in the Input element and apply to every constituency. The Input element also has a NationalParties element
    /// with a NationalParty element, with Id and Name attributes, for each party across the constituencies. A
    /// constituency's Party element belongs to the national party its optional NationalParty attribute names, or the one
    /// with its own name without one, and every national party needs at least one. National party IDs go from 1 for the
    /// most votes across all constituencies, and constituency party IDs carry on from there, constituency by
    /// constituency in the order listed, each constituency's going down by its own votes. A Constituency element's
    /// optional CalculationMethod attribute, a <see cref="ConstituencyCalculationMethod"/>, says how its seats are worked
    /// out, and is Proportional without it. A WinnerTakeAll constituency has no electoral threshold, and its Party
    /// elements can't have MinorityList or ElectorateSeats attributes, nor the constituency SurplusVoteAgreements or
    /// MinorityListQuotientBonus elements. Each constituency gets its party attributes, only Seats for WinnerTakeAll,
    /// and its own Output element, last inside the Constituency element, with only TurnoutPercentage, TotalVotes and
    /// PartyVotes for WinnerTakeAll. Each NationalParty element gets Votes and Seats attributes, and the Output element
    /// after the Input element gets the national TotalVotes and PartyVotes, InvalidVotes, BlankVotes and
    /// InvalidAndBlankVotes, each added up over the constituencies that have it and left out when none does, and
    /// Performance, which times only the Proportional constituencies. When every constituency has turnout, it also gets TurnoutBase and TurnoutRaw added
    /// up over the constituencies, with the Meaning attributes they all have to share, and TurnoutPercentage from them.
    /// The Method element needs an Algorithms attribute, a comma-separated list of the ways to work out the seats:
    /// D'Hondt: Base (<see cref="SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict"/>)
    /// Sainte-Laguë:
    ///  OrderedSeats (<see cref="SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict"/>),
    ///  QuotientTable (<see cref="SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrictUsingQuotientTable"/>)
    ///  DivisorRounding (<see cref="SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrictUsingDivisorRounding"/>)
    /// Algorithms run in the order listed, and with more than one they have to give the same results, except
    /// that DivisorRounding doesn't give out seats in order, so OrderedSeats is only compared between the others. The
    /// results written are from the first algorithm listed that gives out seats in order, or the first one if none does.
    /// 
    /// IncludePerformance element (optional)
    /// 
    /// When specified, adds a Performance element to the Output element with how long each
    /// algorithm took in milliseconds whenever the element is there. Its UntimedRuns attribute
    /// (0 or more) is how many times all the algorithms run first without being timed, so the timing doesn't include the
    /// one-time cost of compiling the code. Its StartupQuietPeriodTicks attribute (0 or more) is how long to wait before
    /// those runs, and its PostUntimedRunsTicks attribute (0 or more) is how long to wait after them, both in ticks (100 ns).
    /// See <see cref="PerformanceRuns"/> for why neither matches what .NET
    /// waits for. Its TimedRuns attribute (1 or more) is how many times each is then timed, taking turns. The time
    /// written is each algorithm's median, which for an even number of timed runs is the average of the two middle times.
    /// 
    /// IncludePerformance supports an EnvironmentVariables element with .NET settings to run with. When environment variables
    /// are specified, the program runs a copy of itself to do the work, passing in the environment variables.
    ///  DOTNET_TieredCompilation (true/false)
    ///  DOTNET_TieredPGO (true/false)
    ///  DOTNET_ReadyToRun (true/false)
    ///  DOTNET_TC_CallCountingDelayMs (0 or more, converted to hex)
    ///  DOTNET_TC_CallCountThreshold (1 or more, converted to hex)
    /// 
    /// <code>
    /// &lt;Election&gt;
    ///   &lt;Input&gt;
    ///     &lt;Method Algorithms="OrderedSeats,QuotientTable,DivisorRounding"&gt;Sainte-Laguë&lt;/Method&gt;
    ///     &lt;IncludePerformance StartupQuietPeriodTicks="0" UntimedRuns="0" PostUntimedRunsTicks="0" TimedRuns="21"&gt;
    ///       &lt;EnvironmentVariables DOTNET_TieredCompilation="false" DOTNET_ReadyToRun="false" /&gt;
    ///     &lt;/IncludePerformance&gt;
    ///     &lt;FirstDivisor Numerator="7" Denominator="5" /&gt;
    ///     &lt;NumberOfSeats&gt;120&lt;/NumberOfSeats&gt;
    ///     &lt;ElectoralThreshold&gt;3.25&lt;/ElectoralThreshold&gt;
    ///     &lt;Parties&gt;
    ///       &lt;Party Id="2" Name="Party1" Votes="1000" ElectorateSeats="1" /&gt;
    ///       &lt;Party Id="1" Name="Party2" Votes="2000" /&gt;
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
        private const string IdAttribute = nameof(PoliticalPartyVotes.Id);
        private const string NameAttribute = "Name";
        private const string VotesAttribute = "Votes";
        private const string AboveThresholdAttribute = "AboveThreshold";
        private const string SeatsAttribute = "Seats";
        private const string Party1Attribute = "Party1";
        private const string Party2Attribute = "Party2";
        private const string NumeratorAttribute = "Numerator";
        private const string DenominatorAttribute = "Denominator";
        private const string ElectorateSeatsAttribute = nameof(SainteLagueSeatDistribution.ElectorateSeats);
        private const string MinorityListAttribute = "MinorityList";
        private const string QuotientBonusAttribute = "QuotientBonus";
        private const string MinorityListQuotientBonusElement = "MinorityListQuotientBonus";
        private const string InvalidAndBlankVotesElement = "InvalidAndBlankVotes";
        private const string InvalidVotesElement = "InvalidVotes";
        private const string BlankVotesElement = "BlankVotes";
        private const string RelevantAttribute = "Relevant";
        private const string TotalVotesElement = "TotalVotes";
        private const string TurnoutBaseElement = "TurnoutBase";
        private const string TurnoutRawElement = "TurnoutRaw";
        private const string TurnoutPercentageElement = "TurnoutPercentage";
        private const string MeaningAttribute = "Meaning";
        private const string BaseAttribute = "Base";
        private const string DHondtMethod = "D'Hondt";
        private const string SainteLagueMethod = "Sainte-Laguë";
        private const string AlgorithmsAttribute = "Algorithms";
        private const string IncludePerformanceElement = "IncludePerformance";
        private const string PerformanceElement = "Performance";
        private const string AlgorithmElement = "Algorithm";
        private const string MillisecondsAttribute = "MedianMilliseconds";
        private const string BaseAlgorithm = "Base";
        private const string OrderedSeatsAlgorithm = "OrderedSeats";
        private const string QuotientTableAlgorithm = "QuotientTable";
        private const string DivisorRoundingAlgorithm = "DivisorRounding";
        private const string ConstituenciesElement = "Constituencies";
        private const string ConstituencyElement = "Constituency";
        private const string NationalPartiesElement = "NationalParties";
        private const string NationalPartyElement = "NationalParty";
        private const string NationalPartyAttribute = "NationalParty";
        private const string CalculationMethodAttribute = "CalculationMethod";

        /// <summary>
        /// how a constituency's seats are worked out
        /// </summary>
        private enum ConstituencyCalculationMethod
        {
            /// <summary>
            /// shared out among the parties by the method in the Method element
            /// </summary>
            Proportional,

            /// <summary>
            /// all to the party with the most votes, as in Ceuta and Melilla, with the lower ID winning a tie
            /// </summary>
            WinnerTakeAll,
        }

        /// <summary>
        /// a constituency whose seats all go to the party with the most votes
        /// </summary>
        /// <param name="Element">the Constituency element</param>
        /// <param name="Winner">the name of the party with the most votes</param>
        /// <param name="NumberOfSeats">the constituency's seats, which all go to <paramref name="Winner"/></param>
        /// <param name="Turnout">the turnout, or null if it isn't given</param>
        private sealed record WinnerTakeAllConstituency(XElement Element, string Winner, int NumberOfSeats, Turnout? Turnout);

        /// <summary>
        /// the elements that, with constituencies, go in each Constituency element rather than in the Input element
        /// </summary>
        private static readonly string[] ConstituencyElements = new[] { NumberOfSeatsElement, PartiesElement, SurplusVoteAgreementsElement, MinorityListQuotientBonusElement, InvalidAndBlankVotesElement, InvalidVotesElement, BlankVotesElement, TurnoutBaseElement, TurnoutRawElement };

        /// <summary>
        /// votes whose seats are worked out on their own: the whole election, or one constituency
        /// </summary>
        /// <param name="Name">the constituency, or null for the whole election</param>
        /// <param name="Element">the element with the parties, seats, invalid and blank votes and turnout: the Input
        /// element for the whole election, or a Constituency element</param>
        /// <param name="Available">how to run each algorithm the method has</param>
        /// <param name="Turnout">the turnout, or null if it isn't given</param>
        private sealed record District(string? Name, XElement Element, Dictionary<string, Func<SeatDistributionBase>> Available, Turnout? Turnout);

        /// <summary>
        /// how many times to run the algorithms when including performance, and how long to wait along the way. The
        /// waits are in ticks of 100 nanoseconds, so 10,000 ticks is a millisecond. Neither wait lines up with what .NET
        /// actually waits for before switching to optimized code (tiered compilation, with the default settings):
        /// - StartupQuietPeriodTicks: .NET only starts counting calls once about 100 milliseconds have passed without
        ///   any method being compiled for the first time, and that clock restarts every time one is. Waiting before
        ///   the first run happens before most of the algorithms' code has been compiled at all, so the first untimed
        ///   run compiles it and restarts .NET's clock after this wait is already over. Calls made before .NET starts
        ///   counting don't count, so what really gets past its quiet period is enough untimed runs.
        /// - PostUntimedRunsTicks: once counting starts, a method is queued to be compiled with optimizations after
        ///   about 30 calls, which happens on a background thread. With Dynamic PGO, on by default, it goes through
        ///   that twice, first to an instrumented version that records how it's used and then to the final one. This
        ///   wait only gives compiles that are already queued time to finish. It can't get a method there that hasn't
        ///   been called enough, such as the top-level method of each algorithm, which is called just once a run. Those
        ///   only get there with more untimed runs. A long wait can also make the timed runs slower, since the CPU
        ///   may slow down and its caches go cold while idle, which is why the waits keep the CPU busy instead
        /// The 100 milliseconds and 30 calls are what <see cref="CallCountingDelayMsVariable"/> and
        /// <see cref="CallCountThresholdVariable"/> change. Two other things often matter more: Dynamic PGO
        /// (<see cref="TieredPGOVariable"/>) adds its instrumented stage, and the .NET libraries themselves (List,
        /// Dictionary, LINQ, decimal and so on) come precompiled as ReadyToRun code (<see cref="ReadyToRunVariable"/>),
        /// which isn't fully optimized and is only replaced through tiered compilation. Turning off
        /// <see cref="TieredCompilationVariable"/> and <see cref="ReadyToRunVariable"/> together compiles everything
        /// fully optimized the first time it runs, so hardly any untimed runs are needed
        /// </summary>
        /// <param name="UntimedRuns">how many times to run all the algorithms before timing them, 0 or more</param>
        /// <param name="TimedRuns">how many times to time each algorithm, 1 or more</param>
        /// <param name="StartupQuietPeriodTicks">ticks to wait before the first run, 0 or more</param>
        /// <param name="PostUntimedRunsTicks">ticks to wait between the untimed and timed runs, 0 or more</param>
        /// <param name="EnvironmentVariables">.NET settings to run with, by environment variable, in the order given, with
        /// on and off as 1 and 0. Settings left out stay as they are</param>
        private sealed record PerformanceRuns(int UntimedRuns, int TimedRuns, long StartupQuietPeriodTicks, long PostUntimedRunsTicks, IReadOnlyDictionary<string, int> EnvironmentVariables);

        /// <summary>
        /// whether .NET first compiles methods quickly and later again with optimizations. When off, methods are compiled
        /// with optimizations the first time
        /// </summary>
        private const string TieredCompilationVariable = "DOTNET_TieredCompilation";

        /// <summary>
        /// whether .NET records how methods are used before compiling them with optimizations (Dynamic PGO)
        /// </summary>
        private const string TieredPGOVariable = "DOTNET_TieredPGO";

        /// <summary>
        /// whether .NET uses the precompiled code that comes with assemblies such as its own libraries. When off, that
        /// code is compiled when it runs, like the program's
        /// </summary>
        private const string ReadyToRunVariable = "DOTNET_ReadyToRun";

        /// <summary>
        /// milliseconds .NET waits without new methods being compiled before it starts counting calls
        /// </summary>
        private const string CallCountingDelayMsVariable = "DOTNET_TC_CallCountingDelayMs";

        /// <summary>
        /// calls before .NET queues a method to be compiled with optimizations
        /// </summary>
        private const string CallCountThresholdVariable = "DOTNET_TC_CallCountThreshold";

        /// <summary>
        /// the environment variables the EnvironmentVariables element can set: whether each is an on/off switch, written
        /// true or false, or else a whole number, and the lowest whole number it can be
        /// </summary>
        private static readonly Dictionary<string, (bool IsSwitch, int Minimum)> SupportedEnvironmentVariables = new Dictionary<string, (bool IsSwitch, int Minimum)>
        {
            [TieredCompilationVariable] = (true, 0),
            [TieredPGOVariable] = (true, 0),
            [ReadyToRunVariable] = (true, 0),
            [CallCountingDelayMsVariable] = (false, 0),
            [CallCountThresholdVariable] = (false, 1),
        };

        private const string EnvironmentVariablesElement = "EnvironmentVariables";

        /// <summary>
        /// set in the environment of a copy of this program started to apply tiered compilation settings, so a copy
        /// that still doesn't have them fails rather than starting another copy
        /// </summary>
        private const string RelaunchedEnvironmentVariable = "CalculateParliamentaryApportionment_Relaunched";

        /// <summary>
        /// algorithms that don't give out seats in order, so they leave <see cref="SeatDistributionBase.OrderedSeats"/>
        /// empty
        /// </summary>
        private static readonly HashSet<string> UnorderedAlgorithms = new HashSet<string> { DivisorRoundingAlgorithm };

        /// <summary>
        /// the result of running one algorithm
        /// </summary>
        /// <param name="Name">the algorithm</param>
        /// <param name="Results">the seat distribution it worked out for each district, in order</param>
        /// <param name="Elapsed">the median of its timed runs, each covering all the districts, or null if performance
        /// isn't included</param>
        private sealed record AlgorithmResult(string Name, List<SeatDistributionBase> Results, TimeSpan? Elapsed);

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
                    XElement method = GetRequiredElement(input, MethodElement);
                    string sMethod = (string)method;
                    PerformanceRuns? performance = ReadPerformanceRuns(input);
                    XElement? constituencies = input.Element(ConstituenciesElement);
                    List<District> districts;
                    List<WinnerTakeAllConstituency> winnerTakeAll = new List<WinnerTakeAllConstituency>();
                    if (constituencies == null)
                    {
                        if (input.Element(NationalPartiesElement) != null) throw new FormatException($"{NationalPartiesElement} is only for {ConstituenciesElement}");
                        districts = [ReadDistrict(input, input, null, sMethod, 0)];
                    }
                    else
                    {
                        districts = ReadConstituencies(input, constituencies, sMethod, winnerTakeAll);
                    }
                    List<string> algorithms = ReadAlgorithms(method, sMethod, districts[0].Available);

                    //the input has been checked by now, so a copy started for the tiered compilation settings only fails
                    //on something that happens while calculating
                    int? iCopyExitCode = RelaunchIfNeeded(sPath, performance);
                    if (iCopyExitCode == null)
                    {
                        List<AlgorithmResult> results = RunAlgorithms(algorithms, districts, performance);
                        List<SeatDistributionBase> verified = GetVerifiedResults(districts, results);
                        XElement output;
                        if (constituencies == null)
                        {
                            WritePartyResults(input, verified[0]);
                            output = BuildOutput(input, verified[0], districts[0].Turnout);
                        }
                        else
                        {
                            foreach ((District d, SeatDistributionBase r) in districts.Zip(verified))
                            {
                                WritePartyResults(d.Element, r);
                                d.Element.Element(OutputElement)?.Remove();
                                d.Element.Add(BuildOutput(d.Element, r, d.Turnout));
                            }
                            foreach (WinnerTakeAllConstituency w in winnerTakeAll) WriteWinnerTakeAllResults(w);
                            output = WriteNationalResults(input, constituencies, districts, verified, winnerTakeAll);
                        }
                        if (performance != null) output.Add(BuildPerformance(performance, results));
                        doc.Root!.Element(OutputElement)?.Remove();
                        input.AddAfterSelf(output);
                        doc.Save(sPath);
                        rc = 0;
                    }
                    else //the copy did the work and wrote any error itself
                    {
                        rc = iCopyExitCode.Value;
                    }
                }
                catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or XmlException or ArgumentException or InvalidOperationException or FormatException or OverflowException or Win32Exception)
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
        /// reads the inputs of one district and gets how to work out its seats with each algorithm the method has.
        /// The method, first divisor and electoral threshold come from the Input element, and everything else from
        /// the district's own element
        /// </summary>
        /// <param name="input">the Input element</param>
        /// <param name="district">the Input element for the whole election, or a Constituency element</param>
        /// <param name="sName">the constituency, or null for the whole election</param>
        /// <param name="sMethod">the method from the Method element</param>
        /// <param name="iIdOffset">what to take off each party's ID so the district's IDs start from 1, which is 0 for
        /// the whole election</param>
        private static District ReadDistrict(XElement input, XElement district, string? sName, string sMethod, int iIdOffset)
        {
            List<PoliticalPartyVotes> parties = ReadParties(district).Select(p => p with { Id = p.Id - iIdOffset }).ToList();
            List<(int, int)> agreements = ReadSurplusVoteAgreements(district, parties);
            int iNumberOfSeats = (int)GetRequiredElement(district, NumberOfSeatsElement);
            SimpleFraction electoralThreshold = SimpleFraction.FromDecimal((decimal)GetRequiredElement(input, ElectoralThresholdElement));
            XElement? firstDivisor = input.Element(FirstDivisorElement);
            Dictionary<int, int>? electorateSeats = ReadElectorateSeats(district, parties);
            List<int> minorityLists = ReadMinorityLists(district, parties);
            XElement? minorityListQuotientBonus = district.Element(MinorityListQuotientBonusElement);
            long lInvalidAndBlankVotes = ReadInvalidAndBlankVotesInElectoralThreshold(district);
            CheckElectoralThresholdBase(input, district);
            Turnout? turnout = ReadTurnout(district);
            Dictionary<string, Func<SeatDistributionBase>> available;
            if (sMethod == DHondtMethod)
            {
                if (firstDivisor != null) throw new FormatException($"{FirstDivisorElement} is only for {SainteLagueMethod}");
                if (electorateSeats != null) throw new FormatException($"{ElectorateSeatsAttribute} is only for {SainteLagueMethod}");
                SimpleFraction? bonus = minorityListQuotientBonus == null ? null : SimpleFraction.FromDecimal((decimal)minorityListQuotientBonus);
                available = new Dictionary<string, Func<SeatDistributionBase>>
                {
                    [BaseAlgorithm] = () => SeatDistributions.CalculateDHondtParliamentarySeatDistributionSingleDistrict(parties, agreements, iNumberOfSeats, electoralThreshold, minorityLists, bonus, lInvalidAndBlankVotes),
                };
            }
            else if (sMethod == SainteLagueMethod)
            {
                if (minorityLists.Count > 0) throw new FormatException($"{MinorityListAttribute} is only for {DHondtMethod}");
                if (minorityListQuotientBonus != null) throw new FormatException($"{MinorityListQuotientBonusElement} is only for {DHondtMethod}");
                SimpleFraction? fraction = firstDivisor == null ? null : new SimpleFraction(
                    (long)GetRequiredAttribute(firstDivisor, NumeratorAttribute),
                    (long)GetRequiredAttribute(firstDivisor, DenominatorAttribute));
                available = new Dictionary<string, Func<SeatDistributionBase>>
                {
                    [OrderedSeatsAlgorithm] = () => SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrict(parties, agreements, iNumberOfSeats, electoralThreshold, fraction, electorateSeats, lInvalidAndBlankVotes),
                    [QuotientTableAlgorithm] = () => SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrictUsingQuotientTable(parties, agreements, iNumberOfSeats, electoralThreshold, fraction, electorateSeats, lInvalidAndBlankVotes),
                    [DivisorRoundingAlgorithm] = () => SeatDistributions.CalculateSainteLagueParliamentarySeatDistributionSingleDistrictUsingDivisorRounding(parties, agreements, iNumberOfSeats, electoralThreshold, fraction, electorateSeats, lInvalidAndBlankVotes),
                };
            }
            else
            {
                throw new FormatException($"{MethodElement} must be {DHondtMethod} or {SainteLagueMethod}, not {sMethod}");
            }
            return new District(sName, district, available, turnout);
        }

        /// <summary>
        /// reads the NationalParties element and each Constituency element in the Constituencies element. National
        /// party IDs go from 1 for the national party with the most votes across all constituencies, and constituency
        /// party IDs carry on from there, constituency by constituency in the order listed, with a party with more votes
        /// in its constituency having a lower ID. Each constituency party belongs to the national party named by its
        /// NationalParty attribute, or by its own name without one, and each national party needs at least one. Each
        /// constituency's optional CalculationMethod attribute says how its seats are worked out, Proportional without
        /// it, and at least one constituency has to be Proportional
        /// </summary>
        /// <param name="sMethod">the method from the Method element</param>
        /// <param name="winnerTakeAll">gets the WinnerTakeAll constituencies, in the order listed</param>
        /// <returns>the Proportional constituencies, in the order listed</returns>
        private static List<District> ReadConstituencies(XElement input, XElement constituencies, string sMethod, List<WinnerTakeAllConstituency> winnerTakeAll)
        {
            foreach (string sElement in ConstituencyElements)
            {
                if (input.Element(sElement) != null) throw new FormatException($"with {ConstituenciesElement}, {sElement} goes in each {ConstituencyElement} rather than in {InputElement}");
            }

            List<PoliticalPartyVotes> nationalParties = new List<PoliticalPartyVotes>();
            Dictionary<string, long> nationalVotes = new Dictionary<string, long>();
            foreach (XElement next in GetRequiredElement(input, NationalPartiesElement).Elements(NationalPartyElement))
            {
                string sParty = (string)GetRequiredAttribute(next, NameAttribute);
                if (!nationalVotes.TryAdd(sParty, 0)) throw new FormatException($"{sParty} is listed more than once in {NationalPartiesElement}");
                nationalParties.Add(new PoliticalPartyVotes((int)GetRequiredAttribute(next, IdAttribute), sParty, 0));
            }

            List<District> ret = new List<District>();
            HashSet<string> names = new HashSet<string>();
            HashSet<string> used = new HashSet<string>();
            int iNextId = nationalParties.Count + 1;
            foreach (XElement next in constituencies.Elements(ConstituencyElement))
            {
                string sName = (string)GetRequiredAttribute(next, NameAttribute);
                if (!names.Add(sName)) throw new FormatException($"{sName} is listed more than once in {ConstituenciesElement}");
                try
                {
                    List<PoliticalPartyVotes> parties = ReadParties(next);
                    CheckIds(parties, iNextId);
                    foreach ((XElement party, PoliticalPartyVotes votes) in GetRequiredElement(next, PartiesElement).Elements(PartyElement).Zip(parties))
                    {
                        string sNationalParty = GetNationalParty(party);
                        if (!nationalVotes.ContainsKey(sNationalParty)) throw new FormatException($"{votes.Name}'s national party {sNationalParty} isn't in {NationalPartiesElement}");
                        nationalVotes[sNationalParty] = checked(nationalVotes[sNationalParty] + votes.Votes);
                        used.Add(sNationalParty);
                    }
                    ConstituencyCalculationMethod calculationMethod = next.Attribute(CalculationMethodAttribute) == null ? ConstituencyCalculationMethod.Proportional : ReadEnum<ConstituencyCalculationMethod>(next, CalculationMethodAttribute);
                    switch (calculationMethod)
                    {
                        case ConstituencyCalculationMethod.Proportional:
                            ret.Add(ReadDistrict(input, next, sName, sMethod, iNextId - 1));
                            break;
                        case ConstituencyCalculationMethod.WinnerTakeAll:
                            winnerTakeAll.Add(ReadWinnerTakeAll(next, parties));
                            break;
                        default:
                            throw new InvalidOperationException($"unexpected {CalculationMethodAttribute} {calculationMethod}");
                    }
                    iNextId += parties.Count;
                }
                catch (FormatException ex)
                {
                    throw new FormatException($"{ConstituencyElement} {sName}: {ex.Message}", ex);
                }
            }

            string? sUnused = nationalParties.Select(p => p.Name).FirstOrDefault(n => !used.Contains(n));
            if (sUnused != null) throw new FormatException($"national party {sUnused} has no party in any {ConstituencyElement}");
            try
            {
                CheckIds(nationalParties.Select(p => p with { Votes = nationalVotes[p.Name] }).ToList(), 1);
            }
            catch (FormatException ex)
            {
                throw new FormatException($"{NationalPartiesElement}: {ex.Message}", ex);
            }
            if (ret.Count == 0) throw new FormatException($"at least one {ConstituencyElement} has to be {nameof(ConstituencyCalculationMethod.Proportional)}");
            SumTurnout(constituencies.Elements(ConstituencyElement).ToList()); //checks the constituencies agree on what turnout counts
            return ret;
        }

        /// <summary>
        /// reads a WinnerTakeAll constituency, which has no electoral threshold, so none of the proportional extras
        /// </summary>
        /// <param name="constituency">the Constituency element</param>
        /// <param name="parties">the constituency's parties, with their IDs already checked</param>
        private static WinnerTakeAllConstituency ReadWinnerTakeAll(XElement constituency, List<PoliticalPartyVotes> parties)
        {
            string sMethod = nameof(ConstituencyCalculationMethod.WinnerTakeAll);
            foreach (string sElement in new[] { SurplusVoteAgreementsElement, MinorityListQuotientBonusElement })
            {
                if (constituency.Element(sElement) != null) throw new FormatException($"{sElement} isn't for {sMethod}");
            }
            foreach (string sAttribute in new[] { MinorityListAttribute, ElectorateSeatsAttribute })
            {
                if (GetRequiredElement(constituency, PartiesElement).Elements(PartyElement).Any(p => p.Attribute(sAttribute) != null)) throw new FormatException($"{sAttribute} isn't for {sMethod}");
            }
            int iNumberOfSeats = (int)GetRequiredElement(constituency, NumberOfSeatsElement);
            if (iNumberOfSeats <= 0) throw new FormatException($"{NumberOfSeatsElement} must be positive, not {iNumberOfSeats}");
            if (parties.Count == 0) throw new FormatException($"{sMethod} needs at least one party");
            ReadInvalidAndBlankVotesInElectoralThreshold(constituency);

            //the IDs go down by votes, so the lowest is the most votes and wins a tie
            string sWinner = parties.MinBy(p => p.Id)!.Name;
            return new WinnerTakeAllConstituency(constituency, sWinner, iNumberOfSeats, ReadTurnout(constituency));
        }

        /// <summary>
        /// sets the Seats attribute of each party in a WinnerTakeAll constituency, replacing any existing one, and replaces
        /// its Output element with one with TurnoutPercentage when it has turnout, TotalVotes when it has invalid or blank
        /// votes, and PartyVotes
        /// </summary>
        private static void WriteWinnerTakeAllResults(WinnerTakeAllConstituency w)
        {
            long lPartyVotes = 0;
            foreach (XElement next in GetRequiredElement(w.Element, PartiesElement).Elements(PartyElement))
            {
                next.SetAttributeValue(SeatsAttribute, (string)GetRequiredAttribute(next, NameAttribute) == w.Winner ? w.NumberOfSeats : 0);
                lPartyVotes = checked(lPartyVotes + (long)GetRequiredAttribute(next, VotesAttribute));
            }
            w.Element.Element(OutputElement)?.Remove();
            w.Element.Add(new XElement(OutputElement,
                w.Turnout == null ? null : new XElement(TurnoutPercentageElement, w.Turnout.Percentage),
                HasInvalidOrBlankVotes(w.Element) ? new XElement(TotalVotesElement, checked(lPartyVotes + GetInvalidAndBlankVotes(w.Element))) : null,
                new XElement(nameof(SeatDistributionBase.PartyVotes), lPartyVotes)));
        }

        /// <summary>
        /// checks that party IDs go from <paramref name="iFirstId"/> up, each used once, with a party with more votes
        /// having a lower ID
        /// </summary>
        private static void CheckIds(List<PoliticalPartyVotes> parties, int iFirstId)
        {
            List<PoliticalPartyVotes> byId = parties.OrderBy(p => p.Id).ToList();
            for (int i = 0; i < byId.Count; i++)
            {
                if (byId[i].Id != iFirstId + i) throw new FormatException($"the IDs have to go from {iFirstId} to {iFirstId + byId.Count - 1}, one for each party, but {byId[i].Name} has ID {byId[i].Id}");
                if (i > 0 && byId[i].Votes > byId[i - 1].Votes) throw new FormatException($"{byId[i].Name} (ID {byId[i].Id}) has more votes than {byId[i - 1].Name} (ID {byId[i - 1].Id}), but a party with more votes needs a lower ID");
            }
        }

        /// <summary>
        /// gets the national party a constituency's Party element belongs to: its NationalParty attribute, or its name
        /// without one
        /// </summary>
        private static string GetNationalParty(XElement party)
        {
            return (string?)party.Attribute(NationalPartyAttribute) ?? (string)GetRequiredAttribute(party, NameAttribute);
        }

        /// <summary>
        /// sets the Votes and Seats attributes of each NationalParty element, replacing any existing ones, and builds the
        /// national Output element, with votes and seats across all constituencies. The Output element has TurnoutBase,
        /// TurnoutRaw and TurnoutPercentage, added up over the constituencies, only when every constituency has turnout,
        /// TotalVotes only when any has invalid or blank votes, and InvalidVotes, BlankVotes and InvalidAndBlankVotes,
        /// each added up over the constituencies that have it, only when any has it
        /// </summary>
        /// <param name="districts">the Proportional constituencies</param>
        /// <param name="results">the seat distribution of each of <paramref name="districts"/></param>
        /// <param name="winnerTakeAll">the WinnerTakeAll constituencies</param>
        private static XElement WriteNationalResults(XElement input, XElement constituencies, List<District> districts, List<SeatDistributionBase> results, List<WinnerTakeAllConstituency> winnerTakeAll)
        {
            List<XElement> all = constituencies.Elements(ConstituencyElement).ToList();
            Dictionary<string, long> votes = new Dictionary<string, long>();
            Dictionary<string, int> seats = new Dictionary<string, int>();
            foreach (XElement next in all)
            {
                foreach (XElement party in GetRequiredElement(next, PartiesElement).Elements(PartyElement))
                {
                    string sNationalParty = GetNationalParty(party);
                    votes[sNationalParty] = checked(votes.GetValueOrDefault(sNationalParty) + (long)GetRequiredAttribute(party, VotesAttribute));
                }
            }
            foreach ((District d, SeatDistributionBase r) in districts.Zip(results))
            {
                foreach (XElement party in GetRequiredElement(d.Element, PartiesElement).Elements(PartyElement))
                {
                    string sNationalParty = GetNationalParty(party);
                    seats[sNationalParty] = seats.GetValueOrDefault(sNationalParty) + r.Seats.GetValueOrDefault((string)GetRequiredAttribute(party, NameAttribute));
                }
            }
            foreach (WinnerTakeAllConstituency w in winnerTakeAll)
            {
                XElement winner = GetRequiredElement(w.Element, PartiesElement).Elements(PartyElement).First(p => (string)GetRequiredAttribute(p, NameAttribute) == w.Winner);
                string sNationalParty = GetNationalParty(winner);
                seats[sNationalParty] = seats.GetValueOrDefault(sNationalParty) + w.NumberOfSeats;
            }
            foreach (XElement next in GetRequiredElement(input, NationalPartiesElement).Elements(NationalPartyElement))
            {
                string sNationalParty = (string)GetRequiredAttribute(next, NameAttribute);
                next.SetAttributeValue(VotesAttribute, votes[sNationalParty]);
                next.SetAttributeValue(SeatsAttribute, seats.GetValueOrDefault(sNationalParty));
            }

            Turnout? turnout = SumTurnout(all);
            long lPartyVotes = votes.Values.Sum();
            return new XElement(OutputElement,
                turnout == null ? null : new XElement(TurnoutBaseElement, new XAttribute(MeaningAttribute, turnout.BaseMeaning), turnout.Base),
                turnout == null ? null : new XElement(TurnoutRawElement, new XAttribute(MeaningAttribute, turnout.RawMeaning), turnout.Raw),
                turnout == null ? null : new XElement(TurnoutPercentageElement, turnout.Percentage),
                all.Any(HasInvalidOrBlankVotes) ? new XElement(TotalVotesElement, checked(lPartyVotes + all.Sum(GetInvalidAndBlankVotes))) : null,
                InvalidAndBlankVotesElements.Select(n => SumElement(all, n)),
                new XElement(nameof(SeatDistributionBase.PartyVotes), lPartyVotes));
        }

        /// <summary>
        /// adds up an element across the constituencies that have it, such as InvalidVotes
        /// </summary>
        /// <param name="constituencies">the Constituency elements</param>
        /// <param name="sName">the element to add up</param>
        /// <returns>an element with the same name and the total, or null if no constituency has it</returns>
        private static XElement? SumElement(List<XElement> constituencies, string sName)
        {
            List<long> values = constituencies.Select(c => c.Element(sName)).OfType<XElement>().Select(e => (long)e).ToList();
            return values.Count == 0 ? null : new XElement(sName, checked(values.Sum()));
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
        /// reads the optional IncludePerformance element. Performance is included whenever the element is there, whatever
        /// its inner text, and then it needs UntimedRuns (0 or more), TimedRuns (1 or more), StartupQuietPeriodTicks (0
        /// or more) and PostUntimedRunsTicks (0 or more) attributes. It can also have an EnvironmentVariables element
        /// </summary>
        /// <returns>how many times to run the algorithms, or null if performance isn't included</returns>
        private static PerformanceRuns? ReadPerformanceRuns(XElement input)
        {
            PerformanceRuns? ret = null;
            XElement? element = input.Element(IncludePerformanceElement);
            if (element != null)
            {
                ret = new PerformanceRuns(
                    checked((int)ReadAtLeast(element, nameof(PerformanceRuns.UntimedRuns), 0)),
                    checked((int)ReadAtLeast(element, nameof(PerformanceRuns.TimedRuns), 1)),
                    ReadAtLeast(element, nameof(PerformanceRuns.StartupQuietPeriodTicks), 0),
                    ReadAtLeast(element, nameof(PerformanceRuns.PostUntimedRunsTicks), 0),
                    ReadEnvironmentVariables(element));
            }
            return ret;
        }

        /// <summary>
        /// reads a required whole-number attribute that has to be at least <paramref name="lMinimum"/>
        /// </summary>
        private static long ReadAtLeast(XElement element, string sName, long lMinimum)
        {
            long ret = (long)GetRequiredAttribute(element, sName);
            if (ret < lMinimum) throw new FormatException($"{sName} must be {lMinimum} or more, not {ret}");
            return ret;
        }

        /// <summary>
        /// reads the optional EnvironmentVariables element inside IncludePerformance, whose attributes are named after
        /// the environment variables in <see cref="SupportedEnvironmentVariables"/>. Switches are written true or false
        /// and the others as ordinary whole numbers, which are converted to the way .NET reads them
        /// </summary>
        /// <returns>the settings by environment variable, in the order given, with on and off as 1 and 0; empty if the
        /// element isn't there</returns>
        private static Dictionary<string, int> ReadEnvironmentVariables(XElement performance)
        {
            Dictionary<string, int> ret = new Dictionary<string, int>();
            XElement? element = performance.Element(EnvironmentVariablesElement);
            foreach (XAttribute next in element?.Attributes() ?? Enumerable.Empty<XAttribute>())
            {
                string sName = next.Name.LocalName;
                if (!SupportedEnvironmentVariables.TryGetValue(sName, out (bool IsSwitch, int Minimum) supported))
                    throw new FormatException($"{EnvironmentVariablesElement} can only have {string.Join(", ", SupportedEnvironmentVariables.Keys)}, not {sName}");
                ret[sName] = supported.IsSwitch ? ((bool)next ? 1 : 0) : checked((int)ReadAtLeast(element!, sName, supported.Minimum));
            }
            return ret;
        }

        /// <summary>
        /// .NET reads its compilation settings from the environment once, when it starts, so changing them for this
        /// process is too late. When the settings asked for aren't the ones this process started with, this starts a
        /// copy of the program with them in its environment, on the same file, and waits for it. The copy does all the
        /// work, so this process mustn't have changed the file. .NET reads these environment variables as hexadecimal,
        /// so 30 is written as 1E, and on and off as 1 and 0
        /// </summary>
        /// <returns>the copy's exit code, or null if this process already has the settings and should go on</returns>
        private static int? RelaunchIfNeeded(string sPath, PerformanceRuns? performance)
        {
            int? ret = null;
            IReadOnlyDictionary<string, int> wanted = performance?.EnvironmentVariables ?? new Dictionary<string, int>();
            if (wanted.Any(p => ParseHex(Environment.GetEnvironmentVariable(p.Key)) != p.Value))
            {
                if (Environment.GetEnvironmentVariable(RelaunchedEnvironmentVariable) != null)
                    throw new InvalidOperationException("the copy of the program started with the compilation settings didn't get them");

                //when run with "dotnet program.dll" the process is dotnet, so the program has to be passed to it
                string sProcessPath = Environment.ProcessPath ?? throw new InvalidOperationException("can't find this program to start a copy of it");
                ProcessStartInfo start = new ProcessStartInfo(sProcessPath) { UseShellExecute = false };
                if (Path.GetFileNameWithoutExtension(sProcessPath).Equals("dotnet", StringComparison.OrdinalIgnoreCase)) start.ArgumentList.Add(typeof(Program).Assembly.Location);
                start.ArgumentList.Add(sPath);
                foreach (KeyValuePair<string, int> next in wanted) start.Environment[next.Key] = next.Value.ToString("X");
                start.Environment[RelaunchedEnvironmentVariable] = "1";
                using Process copy = Process.Start(start) ?? throw new InvalidOperationException("couldn't start a copy of the program");
                copy.WaitForExit();
                ret = copy.ExitCode;
            }
            return ret;
        }

        /// <summary>
        /// reads a whole number written in hexadecimal, with or without 0x in front, the way .NET reads its settings
        /// from the environment
        /// </summary>
        /// <returns>the number, or null if there isn't one</returns>
        private static int? ParseHex(string? sValue)
        {
            string? sDigits = sValue?.Trim();
            if (sDigits != null && sDigits.StartsWith("0x", StringComparison.OrdinalIgnoreCase)) sDigits = sDigits[2..];
            int? ret = int.TryParse(sDigits, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out int iValue) ? iValue : null;
            return ret;
        }

        /// <summary>
        /// waits by keeping the CPU busy rather than sleeping, which is accurate to well under a millisecond, where a
        /// sleep can run over by as much as 15 milliseconds on Windows, and keeps the CPU from slowing down
        /// </summary>
        /// <param name="lTicks">how long to wait, in ticks of 100 nanoseconds</param>
        private static void Wait(long lTicks)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            while (stopwatch.Elapsed.Ticks < lTicks) Thread.SpinWait(10);
        }

        /// <summary>
        /// runs the algorithms in rounds, each round running all of them in order. Without performance there is just
        /// one round. With performance there is a wait of <see cref="PerformanceRuns.StartupQuietPeriodTicks"/> first,
        /// then <see cref="PerformanceRuns.UntimedRuns"/> untimed rounds, so the timed runs don't include compiling code
        /// the first time it runs, including code the algorithms share, then a wait of
        /// <see cref="PerformanceRuns.PostUntimedRunsTicks"/>, and then <see cref="PerformanceRuns.TimedRuns"/> timed rounds. Taking turns this way spreads a slow moment across
        /// the algorithms. Each algorithm's result comes from its first run, timed or not, and its time is the median
        /// of its timed runs
        /// </summary>
        /// <param name="algorithms">the algorithms to run, in order</param>
        /// <param name="districts">the districts to run each algorithm on, all of them in one run</param>
        /// <param name="performance">how many times to run the algorithms, or null if performance isn't included</param>
        private static List<AlgorithmResult> RunAlgorithms(List<string> algorithms, List<District> districts, PerformanceRuns? performance)
        {
            int iUntimedRuns = performance?.UntimedRuns ?? 1;
            int iTimedRuns = performance?.TimedRuns ?? 0;
            List<SeatDistributionBase>?[] results = new List<SeatDistributionBase>?[algorithms.Count];
            List<TimeSpan>[] elapsed = algorithms.Select(a => new List<TimeSpan>()).ToArray();
            if (performance != null) Wait(performance.StartupQuietPeriodTicks);
            for (int iRun = 0; iRun < iUntimedRuns + iTimedRuns; iRun++)
            {
                if (performance != null && iRun == iUntimedRuns) Wait(performance.PostUntimedRunsTicks);
                for (int i = 0; i < algorithms.Count; i++)
                {
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    List<SeatDistributionBase> result = new List<SeatDistributionBase>(districts.Count);
                    foreach (District d in districts) result.Add(RunAlgorithm(d, algorithms[i]));
                    stopwatch.Stop();
                    results[i] ??= result;
                    if (iRun >= iUntimedRuns) elapsed[i].Add(stopwatch.Elapsed);
                }
            }
            return algorithms.Select((a, i) => new AlgorithmResult(a, results[i]!, performance == null ? null : GetMedian(elapsed[i]))).ToList();
        }

        /// <summary>
        /// runs an algorithm on a district, naming the constituency in any error
        /// </summary>
        private static SeatDistributionBase RunAlgorithm(District d, string sAlgorithm)
        {
            SeatDistributionBase ret;
            try
            {
                ret = d.Available[sAlgorithm]();
            }
            catch (ArgumentException ex) when (d.Name != null)
            {
                throw new ArgumentException($"{ConstituencyElement} {d.Name}: {ex.Message}", ex);
            }
            catch (InvalidOperationException ex) when (d.Name != null)
            {
                throw new InvalidOperationException($"{ConstituencyElement} {d.Name}: {ex.Message}", ex);
            }
            return ret;
        }

        /// <summary>
        /// gets the median time: the middle one for an odd number of times, or the average of the two middle ones for
        /// an even number
        /// </summary>
        private static TimeSpan GetMedian(List<TimeSpan> times)
        {
            List<TimeSpan> sorted = times.Order().ToList();
            int iMiddle = sorted.Count / 2;
            return sorted.Count % 2 == 1 ? sorted[iMiddle] : (sorted[iMiddle - 1] + sorted[iMiddle]) / 2;
        }

        /// <summary>
        /// checks that all the algorithms give the same results in each district, comparing what gets written to the
        /// file. The ordered seats are only compared between algorithms that both give out seats in order
        /// </summary>
        /// <returns>the results to write for each district, from the first algorithm that gives out seats in order, or
        /// the first algorithm if none does</returns>
        private static List<SeatDistributionBase> GetVerifiedResults(List<District> districts, List<AlgorithmResult> results)
        {
            AlgorithmResult expected = results.FirstOrDefault(a => !UnorderedAlgorithms.Contains(a.Name)) ?? results[0];
            foreach (AlgorithmResult next in results.Where(a => a != expected))
            {
                bool compareOrderedSeats = !UnorderedAlgorithms.Contains(expected.Name) && !UnorderedAlgorithms.Contains(next.Name);
                for (int i = 0; i < districts.Count; i++)
                {
                    string? sDifference = FindDifference(districts[i].Element, expected.Results[i], next.Results[i], compareOrderedSeats);
                    if (sDifference != null) throw new InvalidOperationException($"{(districts[i].Name == null ? "" : $"{ConstituencyElement} {districts[i].Name}: ")}the {expected.Name} and {next.Name} algorithms give different {sDifference}");
                }
            }
            return expected.Results;
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

            XElement expectedOutput = BuildOutput(input, expected, null);
            XElement actualOutput = BuildOutput(input, actual, null);
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

        /// <summary>
        /// reads each party's Id, Name and Votes. The IDs themselves are checked when the seats are worked out: they have
        /// to go from 1 up to the number of parties, each used once, with a party with more votes having a lower ID
        /// </summary>
        /// <returns>the parties in the order they're listed</returns>
        private static List<PoliticalPartyVotes> ReadParties(XElement input)
        {
            List<PoliticalPartyVotes> ret = new List<PoliticalPartyVotes>();
            HashSet<string> names = new HashSet<string>();
            foreach (XElement next in GetRequiredElement(input, PartiesElement).Elements(PartyElement))
            {
                string sParty = (string)GetRequiredAttribute(next, NameAttribute);
                if (!names.Add(sParty)) throw new FormatException($"{sParty} is listed more than once in {PartiesElement}");
                ret.Add(new PoliticalPartyVotes((int)GetRequiredAttribute(next, IdAttribute), sParty, (long)GetRequiredAttribute(next, VotesAttribute)));
            }
            return ret;
        }

        /// <summary>
        /// reads the ElectorateSeats attribute of each party that has one, which is an input rather than a result
        /// </summary>
        /// <param name="parties">the parties from <see cref="ReadParties"/></param>
        /// <returns>the electorates each party won, by party ID, or null if no party has the attribute</returns>
        private static Dictionary<int, int>? ReadElectorateSeats(XElement input, List<PoliticalPartyVotes> parties)
        {
            Dictionary<int, int>? ret = null;
            Dictionary<string, int> ids = parties.ToDictionary(p => p.Name, p => p.Id);
            foreach (XElement next in GetRequiredElement(input, PartiesElement).Elements(PartyElement))
            {
                XAttribute? seats = next.Attribute(ElectorateSeatsAttribute);
                if (seats != null)
                {
                    ret ??= new Dictionary<int, int>();
                    ret[ids[(string)GetRequiredAttribute(next, NameAttribute)]] = (int)seats;
                }
            }
            return ret;
        }

        /// <summary>
        /// reads the IDs of the parties with MinorityList="true", an input rather than a result
        /// </summary>
        /// <param name="parties">the parties from <see cref="ReadParties"/></param>
        /// <returns>the minority lists' IDs in the order they're listed, empty if there are none</returns>
        private static List<int> ReadMinorityLists(XElement input, List<PoliticalPartyVotes> parties)
        {
            Dictionary<string, int> ids = parties.ToDictionary(p => p.Name, p => p.Id);
            return GetRequiredElement(input, PartiesElement).Elements(PartyElement)
                .Where(p => (bool?)p.Attribute(MinorityListAttribute) == true)
                .Select(p => ids[(string)GetRequiredAttribute(p, NameAttribute)])
                .ToList();
        }

        /// <summary>
        /// the elements for ballots that aren't votes for a party
        /// </summary>
        private static readonly string[] InvalidAndBlankVotesElements = new[] { InvalidAndBlankVotesElement, InvalidVotesElement, BlankVotesElement };

        /// <summary>
        /// whether the input has any of the elements for ballots that aren't votes for a party
        /// </summary>
        private static bool HasInvalidOrBlankVotes(XElement input) => InvalidAndBlankVotesElements.Any(n => input.Element(n) != null);

        /// <summary>
        /// reads the optional InvalidAndBlankVotes, InvalidVotes and BlankVotes elements, each with a required Relevant
        /// attribute, where InvalidAndBlankVotes can't be used with the other two
        /// </summary>
        /// <returns>the ballots with Relevant="true", which count toward the electoral threshold, or 0 if there are none</returns>
        private static long ReadInvalidAndBlankVotesInElectoralThreshold(XElement input)
        {
            if (input.Element(InvalidAndBlankVotesElement) != null && (input.Element(InvalidVotesElement) != null || input.Element(BlankVotesElement) != null))
                throw new FormatException($"{InvalidAndBlankVotesElement} can't be used with {InvalidVotesElement} or {BlankVotesElement}");

            long ret = 0;
            foreach (string sName in InvalidAndBlankVotesElements)
            {
                XElement? element = input.Element(sName);
                if (element != null)
                {
                    long lVotes = (long)element;
                    if (lVotes < 0) throw new FormatException($"{sName} can't be negative, not {lVotes}");
                    if ((bool)GetRequiredAttribute(element, RelevantAttribute)) ret = checked(ret + lVotes);
                }
            }
            return ret;
        }

        /// <summary>
        /// gets all the ballots in the InvalidAndBlankVotes, InvalidVotes and BlankVotes elements, whether or not they
        /// count toward the electoral threshold. They are validated by
        /// <see cref="ReadInvalidAndBlankVotesInElectoralThreshold"/>
        /// </summary>
        private static long GetInvalidAndBlankVotes(XElement input) => InvalidAndBlankVotesElements.Sum(n => (long?)input.Element(n) ?? 0);

        /// <summary>
        /// what the electoral threshold is a percentage of
        /// </summary>
        private enum ElectoralThresholdBase
        {
            /// <summary>
            /// votes for all parties
            /// </summary>
            PartyVotes,

            /// <summary>
            /// ballots found in the ballot boxes, valid or not
            /// </summary>
            BallotsInBoxes,

            /// <summary>
            /// votes for all parties plus blank ballots, but not invalid ones, as in Spain, where the law counts blank
            /// ballots as valid votes
            /// </summary>
            PartyVotesAndBlanks,
        }

        /// <summary>
        /// checks that the ElectoralThreshold element's optional Base attribute agrees with which invalid and blank votes
        /// are relevant: none for party votes, all of them, with at least one given, for ballots in boxes, and blank
        /// votes, given separately, but not invalid votes for party votes and blanks
        /// </summary>
        /// <param name="input">the Input element, for the ElectoralThreshold element</param>
        /// <param name="district">the element with the invalid and blank votes: the Input element, or a Constituency
        /// element</param>
        private static void CheckElectoralThresholdBase(XElement input, XElement district)
        {
            XElement threshold = GetRequiredElement(input, ElectoralThresholdElement);
            if (threshold.Attribute(BaseAttribute) != null)
            {
                ElectoralThresholdBase thresholdBase = ReadEnum<ElectoralThresholdBase>(threshold, BaseAttribute);
                List<bool> relevant = InvalidAndBlankVotesElements.Select(n => district.Element(n)).OfType<XElement>().Select(e => (bool)GetRequiredAttribute(e, RelevantAttribute)).ToList();
                bool? IsRelevant(string sElement)
                {
                    XElement? element = district.Element(sElement);
                    return element == null ? null : (bool)GetRequiredAttribute(element, RelevantAttribute);
                }
                bool agrees = thresholdBase switch
                {
                    ElectoralThresholdBase.PartyVotes => !relevant.Contains(true),
                    ElectoralThresholdBase.BallotsInBoxes => relevant.Count > 0 && !relevant.Contains(false),
                    ElectoralThresholdBase.PartyVotesAndBlanks => IsRelevant(BlankVotesElement) == true && IsRelevant(InvalidVotesElement) != true,
                    _ => throw new InvalidOperationException($"unexpected {BaseAttribute} {thresholdBase}"),
                };
                if (!agrees) throw new FormatException($"{BaseAttribute}=\"{thresholdBase}\" for {ElectoralThresholdElement} doesn't agree with the {RelevantAttribute} attributes of the invalid and blank votes");
            }
        }

        /// <summary>
        /// what the TurnoutBase element counts
        /// </summary>
        private enum TurnoutBaseMeaning
        {
            /// <summary>
            /// people on the voter list
            /// </summary>
            RegisteredVoters,
        }

        /// <summary>
        /// what the TurnoutRaw element counts
        /// </summary>
        private enum TurnoutRawMeaning
        {
            /// <summary>
            /// people recorded on the voter list as having come to vote, such as by signing it, whether or not they cast a
            /// ballot
            /// </summary>
            VotersSignedIn,

            /// <summary>
            /// ballots found in the ballot boxes, valid or not
            /// </summary>
            BallotsInBoxes,

            /// <summary>
            /// valid, invalid and blank votes added together, where the source only gives those rather than a count of
            /// voters or of ballots in boxes
            /// </summary>
            TotalVotes,
        }

        /// <summary>
        /// reads a required attribute that has to be the name of one of the values of an enum
        /// </summary>
        private static T ReadEnum<T>(XElement element, string sAttribute) where T : struct, Enum
        {
            string sValue = (string)GetRequiredAttribute(element, sAttribute);
            string[] names = Enum.GetNames<T>(); //parsing on its own would also allow numbers
            if (!names.Contains(sValue)) throw new FormatException($"{sAttribute} for {element.Name} can only be {string.Join(", ", names)}, not \"{sValue}\"");
            return Enum.Parse<T>(sValue);
        }

        /// <summary>
        /// the numbers turnout is worked out from
        /// </summary>
        /// <param name="Base">the number turnout is a percentage of, from the TurnoutBase element</param>
        /// <param name="Raw">the number included in turnout, from the TurnoutRaw element</param>
        /// <param name="BaseMeaning">what <paramref name="Base"/> counts</param>
        /// <param name="RawMeaning">what <paramref name="Raw"/> counts</param>
        private sealed record Turnout(long Base, long Raw, TurnoutBaseMeaning BaseMeaning, TurnoutRawMeaning RawMeaning)
        {
            /// <summary>
            /// the turnout percentage rounded to 2 decimal places
            /// </summary>
            public decimal Percentage => Math.Round(Raw * 100m / Base, 2, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// reads the optional TurnoutBase and TurnoutRaw elements, which have to be given together. Their Meaning
        /// attributes are checked but otherwise only for information
        /// </summary>
        /// <param name="district">the element with the turnout: the Input element, or a Constituency element</param>
        /// <returns>the turnout, or null if the elements aren't there</returns>
        private static Turnout? ReadTurnout(XElement district)
        {
            Turnout? ret = null;
            XElement? turnoutBase = district.Element(TurnoutBaseElement);
            XElement? turnoutRaw = district.Element(TurnoutRawElement);
            if ((turnoutBase == null) != (turnoutRaw == null)) throw new FormatException($"{TurnoutBaseElement} and {TurnoutRawElement} have to be given together");
            if (turnoutBase != null && turnoutRaw != null)
            {
                TurnoutBaseMeaning baseMeaning = ReadEnum<TurnoutBaseMeaning>(turnoutBase, MeaningAttribute);
                TurnoutRawMeaning rawMeaning = ReadEnum<TurnoutRawMeaning>(turnoutRaw, MeaningAttribute);
                long lBase = (long)turnoutBase;
                long lRaw = (long)turnoutRaw;
                if (lBase <= 0) throw new FormatException($"{TurnoutBaseElement} must be positive, not {lBase}");
                if (lRaw < 0 || lRaw > lBase) throw new FormatException($"{TurnoutRawElement} must be from 0 to {TurnoutBaseElement} ({lBase}), not {lRaw}");
                ret = new Turnout(lBase, lRaw, baseMeaning, rawMeaning);
            }
            return ret;
        }

        /// <summary>
        /// adds up the turnout of all the constituencies, which have to agree on what their TurnoutBase and TurnoutRaw
        /// elements count
        /// </summary>
        /// <param name="constituencies">the Constituency elements</param>
        /// <returns>the national turnout, or null unless every constituency has turnout</returns>
        private static Turnout? SumTurnout(List<XElement> constituencies)
        {
            List<Turnout?> turnouts = constituencies.Select(ReadTurnout).ToList();
            Turnout? ret = null;
            if (turnouts.Count > 0 && !turnouts.Contains(null))
            {
                Turnout first = turnouts[0]!;
                Turnout? different = turnouts.FirstOrDefault(t => t!.BaseMeaning != first.BaseMeaning || t.RawMeaning != first.RawMeaning);
                if (different != null) throw new FormatException($"the national turnout can't add up constituencies whose {TurnoutBaseElement} and {TurnoutRawElement} count different things, such as {first.BaseMeaning} and {first.RawMeaning} with {different.BaseMeaning} and {different.RawMeaning}");
                ret = new Turnout(checked(turnouts.Sum(t => t!.Base)), checked(turnouts.Sum(t => t!.Raw)), first.BaseMeaning, first.RawMeaning);
            }
            return ret;
        }

        /// <summary>
        /// sets the result attributes of each party, replacing any existing ones. Parties below the electoral threshold
        /// get no seats, so they aren't in the seat dictionaries. BaseSeats is removed for a method without base seats,
        /// ListSeats, OverhangSeats and TotalSeats are removed without electorate seats, and QuotientBonus is only on
        /// minority lists when there is a minority list quotient bonus
        /// </summary>
        private static void WritePartyResults(XElement input, SeatDistributionBase r)
        {
            DHondtSeatDistribution? dHondt = r as DHondtSeatDistribution;
            SainteLagueSeatDistribution? mixedMember = r is SainteLagueSeatDistribution sainteLague && sainteLague.ElectorateSeats.Count > 0 ? sainteLague : null;
            bool hasBonus = input.Element(MinorityListQuotientBonusElement) != null;
            foreach (XElement next in GetRequiredElement(input, PartiesElement).Elements(PartyElement))
            {
                string sParty = (string)GetRequiredAttribute(next, NameAttribute);
                bool isAboveThreshold = r.Seats.ContainsKey(sParty);
                bool isMinorityList = (bool?)next.Attribute(MinorityListAttribute) == true;
                next.SetAttributeValue(AboveThresholdAttribute, isAboveThreshold);
                next.SetAttributeValue(QuotientBonusAttribute, hasBonus && isMinorityList ? dHondt?.MinorityListsWithQuotientBonus.Contains(sParty) : null);
                next.SetAttributeValue(nameof(DHondtSeatDistribution.BaseSeats), dHondt?.BaseSeats.GetValueOrDefault(sParty));
                next.SetAttributeValue(SeatsAttribute, r.Seats.GetValueOrDefault(sParty));
                next.SetAttributeValue(nameof(SainteLagueSeatDistribution.ListSeats), mixedMember?.ListSeats.GetValueOrDefault(sParty));
                next.SetAttributeValue(nameof(SainteLagueSeatDistribution.OverhangSeats), mixedMember?.OverhangSeats.GetValueOrDefault(sParty));
                next.SetAttributeValue(nameof(SainteLagueSeatDistribution.TotalSeats), mixedMember?.TotalSeats.GetValueOrDefault(sParty));
            }
        }

        /// <summary>
        /// reads the surplus vote agreements, which name their parties, and gets them by party ID
        /// </summary>
        /// <param name="parties">the parties from <see cref="ReadParties"/></param>
        private static List<(int, int)> ReadSurplusVoteAgreements(XElement input, List<PoliticalPartyVotes> parties)
        {
            List<(int, int)> ret = new List<(int, int)>();
            Dictionary<string, int> ids = parties.ToDictionary(p => p.Name, p => p.Id);
            int GetId(XElement agreement, string sAttribute)
            {
                string sParty = (string)GetRequiredAttribute(agreement, sAttribute);
                return ids.TryGetValue(sParty, out int iId) ? iId : throw new FormatException($"surplus vote agreement party {sParty} isn't in {PartiesElement}");
            }

            XElement? agreements = input.Element(SurplusVoteAgreementsElement);
            if (agreements != null)
            {
                foreach (XElement next in agreements.Elements(SurplusVoteAgreementElement))
                    ret.Add((GetId(next, Party1Attribute), GetId(next, Party2Attribute)));
            }
            return ret;
        }

        /// <summary>
        /// builds the Output element, with TurnoutPercentage only when the input has turnout, TotalVotes and
        /// ElectoralThresholdVotes only when it has invalid or blank votes, Quota only for D'Hondt, NumberOfMembers only
        /// with electorate seats and AnnulledSurplusVoteAgreements only when there are any. An empty
        /// NextOrderedSeatIrrelevantBecausePartyHasOverhangSeat element comes last when the next seat would go to a party
        /// with overhang seats, which makes both NextOrderedSeat and VotesNeededForNextOrderedSeat irrelevant
        /// </summary>
        /// <param name="input">the element with the invalid and blank votes: the Input element, or a Constituency
        /// element</param>
        /// <param name="turnout">the turnout, or null to leave it out</param>
        private static XElement BuildOutput(XElement input, SeatDistributionBase r, Turnout? turnout)
        {
            return new XElement(OutputElement,
                turnout == null ? null : new XElement(TurnoutPercentageElement, turnout.Percentage),
                HasInvalidOrBlankVotes(input) ? new XElement(TotalVotesElement, checked(r.PartyVotes + GetInvalidAndBlankVotes(input))) : null,
                new XElement(nameof(SeatDistributionBase.PartyVotes), r.PartyVotes),
                HasInvalidOrBlankVotes(input) ? new XElement(nameof(SeatDistributionBase.ElectoralThresholdVotes), r.ElectoralThresholdVotes) : null,
                new XElement(nameof(SeatDistributionBase.QualifyingVotes), r.QualifyingVotes),
                r is DHondtSeatDistribution dHondt ? new XElement(nameof(DHondtSeatDistribution.Quota), dHondt.Quota) : null,
                r is SainteLagueSeatDistribution sainteLague && sainteLague.ElectorateSeats.Count > 0 ? new XElement(nameof(SainteLagueSeatDistribution.NumberOfMembers), sainteLague.NumberOfMembers) : null,
                r.AnnulledSurplusVoteAgreements.Count == 0 ? null : new XElement(nameof(SeatDistributionBase.AnnulledSurplusVoteAgreements),
                    r.AnnulledSurplusVoteAgreements.Select(a => new XElement(SurplusVoteAgreementElement, new XAttribute(Party1Attribute, a.Item1), new XAttribute(Party2Attribute, a.Item2)))),
                new XElement(nameof(SeatDistributionBase.OrderedSeatsByRecipient),
                    r.OrderedSeatsByRecipient.Select(p => new XElement(RecipientElement, new XAttribute(NameAttribute, p.Key), new XAttribute(SeatsAttribute, p.Value)))),
                new XElement(nameof(SeatDistributionBase.OrderedSeats),
                    r.OrderedSeats.Select(s => BuildOrderedSeat(nameof(OrderedSeat), s))),
                BuildOrderedSeat(nameof(SeatDistributionBase.NextOrderedSeat), r.NextOrderedSeat),
                new XElement(nameof(SeatDistributionBase.VotesNeededForNextOrderedSeat), r.VotesNeededForNextOrderedSeat),
                r is SainteLagueSeatDistribution { NextOrderedSeatIrrelevantBecausePartyHasOverhangSeat: true } ? new XElement(nameof(SainteLagueSeatDistribution.NextOrderedSeatIrrelevantBecausePartyHasOverhangSeat)) : null);
        }

        /// <summary>
        /// builds the Performance element with each algorithm's time, which goes last in the Output element after the
        /// Input element
        /// </summary>
        /// <param name="performance">how many times the algorithms ran</param>
        /// <param name="results">the algorithms with how long each took</param>
        private static XElement BuildPerformance(PerformanceRuns performance, List<AlgorithmResult> results)
        {
            return new XElement(PerformanceElement,
                new XAttribute(nameof(PerformanceRuns.UntimedRuns), performance.UntimedRuns),
                new XAttribute(nameof(PerformanceRuns.TimedRuns), performance.TimedRuns),
                new XAttribute(nameof(PerformanceRuns.StartupQuietPeriodTicks), performance.StartupQuietPeriodTicks),
                new XAttribute(nameof(PerformanceRuns.PostUntimedRunsTicks), performance.PostUntimedRunsTicks),
                performance.EnvironmentVariables.Count == 0 ? null : new XElement(EnvironmentVariablesElement,
                    performance.EnvironmentVariables.Select(p => new XAttribute(p.Key, SupportedEnvironmentVariables[p.Key].IsSwitch ? p.Value == 1 : p.Value))),
                results.Select(a => new XElement(AlgorithmElement, new XAttribute(NameAttribute, a.Name), new XAttribute(MillisecondsAttribute, a.Elapsed!.Value.TotalMilliseconds))));
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
