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
    /// The optional IncludePerformance element adds a Performance element to the Output element with how long each
    /// algorithm took in milliseconds whenever the element is there; its inner text is ignored. Its UntimedRuns attribute
    /// (0 or more) is how many times all the algorithms run first without being timed, so the timing doesn't include the
    /// one-time cost of compiling the code. Its StartupQuietPeriodTicks attribute (0 or more) is how long to wait before
    /// those runs, and its PostUntimedRunsTicks attribute (0 or more) is how long to wait after them, both in ticks of
    /// 100 nanoseconds (10,000 to a millisecond); see <see cref="PerformanceRuns"/> for why neither matches what .NET
    /// waits for. Its TimedRuns attribute (1 or more) is how many times each is then timed, taking turns. The optional
    /// CallCountingDelayMs (0 or more) and CallCountThreshold (1 or more) attributes change .NET's tiered compilation
    /// settings of the same names, and the optional TieredCompilation, TieredPGO and ReadyToRun attributes (true or
    /// false) turn those .NET features on or off; since .NET only reads these when it starts, the program runs a copy of
    /// itself with them to do the work. The time written is each algorithm's median, which for an even number of timed
    /// runs is the average of the two middle times:
    /// <code>
    /// &lt;Election&gt;
    ///   &lt;Input&gt;
    ///     &lt;Method Algorithms="OrderedSeats,QuotientTable,DivisorRounding"&gt;Sainte-Laguë&lt;/Method&gt;
    ///     &lt;IncludePerformance StartupQuietPeriodTicks="0" UntimedRuns="300" PostUntimedRunsTicks="0" TimedRuns="21" /&gt;
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
        private const string MillisecondsAttribute = "MedianMilliseconds";
        private const string BaseAlgorithm = "Base";
        private const string OrderedSeatsAlgorithm = "OrderedSeats";
        private const string QuotientTableAlgorithm = "QuotientTable";
        private const string DivisorRoundingAlgorithm = "DivisorRounding";

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
        /// The 100 milliseconds and 30 calls are what <see cref="CallCountingDelayMs"/> and <see cref="CallCountThreshold"/>
        /// change, through the DOTNET_TC_CallCountingDelayMs and DOTNET_TC_CallCountThreshold environment variables. Two
        /// other things often matter more: Dynamic PGO (<see cref="TieredPGO"/>) adds its instrumented stage, and the
        /// .NET libraries themselves (List, Dictionary, LINQ, decimal and so on) come precompiled as ReadyToRun code
        /// (<see cref="ReadyToRun"/>), which isn't fully optimized and is only replaced through tiered compilation.
        /// Turning off <see cref="TieredCompilation"/> and <see cref="ReadyToRun"/> together compiles everything fully
        /// optimized the first time it runs, so hardly any untimed runs are needed
        /// </summary>
        /// <param name="UntimedRuns">how many times to run all the algorithms before timing them, 0 or more</param>
        /// <param name="TimedRuns">how many times to time each algorithm, 1 or more</param>
        /// <param name="StartupQuietPeriodTicks">ticks to wait before the first run, 0 or more</param>
        /// <param name="PostUntimedRunsTicks">ticks to wait between the untimed and timed runs, 0 or more</param>
        /// <param name="CallCountingDelayMs">milliseconds .NET waits without new methods being compiled before it starts
        /// counting calls, 0 or more, or null to leave it as it is</param>
        /// <param name="CallCountThreshold">calls before .NET queues a method to be compiled with optimizations, 1 or
        /// more, or null to leave it as it is</param>
        /// <param name="TieredCompilation">whether .NET first compiles methods quickly and later again with
        /// optimizations, or null to leave it as it is. When off, methods are compiled with optimizations the first time</param>
        /// <param name="TieredPGO">whether .NET records how methods are used before compiling them with optimizations
        /// (Dynamic PGO), or null to leave it as it is</param>
        /// <param name="ReadyToRun">whether .NET uses the precompiled code that comes with assemblies such as its own
        /// libraries, or null to leave it as it is. When off, that code is compiled when it runs, like the program's</param>
        private sealed record PerformanceRuns(int UntimedRuns, int TimedRuns, long StartupQuietPeriodTicks, long PostUntimedRunsTicks, int? CallCountingDelayMs, int? CallCountThreshold, bool? TieredCompilation, bool? TieredPGO, bool? ReadyToRun);

        /// <summary>
        /// prefix of the environment variables for .NET's settings, which go after it by name
        /// </summary>
        private const string RuntimeEnvironmentVariablePrefix = "DOTNET_";

        /// <summary>
        /// prefix of the names of .NET's tiered compilation thresholds, after <see cref="RuntimeEnvironmentVariablePrefix"/>
        /// </summary>
        private const string TieredCompilationSettingPrefix = "TC_";

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
        /// <param name="Result">the seat distribution it worked out</param>
        /// <param name="Elapsed">the median of its timed runs, or null if performance isn't included</param>
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
                    PerformanceRuns? performance = ReadPerformanceRuns(input);
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

                    List<string> algorithms = ReadAlgorithms(method, sMethod, available);

                    //the input has been checked by now, so a copy started for the tiered compilation settings only fails
                    //on something that happens while calculating
                    int? iCopyExitCode = RelaunchIfNeeded(sPath, performance);
                    if (iCopyExitCode == null)
                    {
                        List<AlgorithmResult> results = RunAlgorithms(algorithms, available, performance);
                        SeatDistributionBase r = GetVerifiedResult(input, results);
                        WritePartyResults(input, r);
                        doc.Root!.Element(OutputElement)?.Remove();
                        input.AddAfterSelf(BuildOutput(r, performance, results));
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
        /// or more) and PostUntimedRunsTicks (0 or more) attributes. CallCountingDelayMs (0 or more),
        /// CallCountThreshold (1 or more), TieredCompilation, TieredPGO and ReadyToRun (true or false) are optional
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
                    ReadOptionalAtLeast(element, nameof(PerformanceRuns.CallCountingDelayMs), 0),
                    ReadOptionalAtLeast(element, nameof(PerformanceRuns.CallCountThreshold), 1),
                    (bool?)element.Attribute(nameof(PerformanceRuns.TieredCompilation)),
                    (bool?)element.Attribute(nameof(PerformanceRuns.TieredPGO)),
                    (bool?)element.Attribute(nameof(PerformanceRuns.ReadyToRun)));
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
        /// reads an optional whole-number attribute that has to be at least <paramref name="iMinimum"/> if it's there
        /// </summary>
        /// <returns>the value, or null if the attribute isn't there</returns>
        private static int? ReadOptionalAtLeast(XElement element, string sName, int iMinimum)
        {
            int? ret = element.Attribute(sName) == null ? null : checked((int)ReadAtLeast(element, sName, iMinimum));
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
            Dictionary<string, int> wanted = new Dictionary<string, int>();
            if (performance?.CallCountingDelayMs is int iDelay) wanted[RuntimeEnvironmentVariablePrefix + TieredCompilationSettingPrefix + nameof(PerformanceRuns.CallCountingDelayMs)] = iDelay;
            if (performance?.CallCountThreshold is int iThreshold) wanted[RuntimeEnvironmentVariablePrefix + TieredCompilationSettingPrefix + nameof(PerformanceRuns.CallCountThreshold)] = iThreshold;
            if (performance?.TieredCompilation is bool isTiered) wanted[RuntimeEnvironmentVariablePrefix + nameof(PerformanceRuns.TieredCompilation)] = isTiered ? 1 : 0;
            if (performance?.TieredPGO is bool isPgo) wanted[RuntimeEnvironmentVariablePrefix + nameof(PerformanceRuns.TieredPGO)] = isPgo ? 1 : 0;
            if (performance?.ReadyToRun is bool isReadyToRun) wanted[RuntimeEnvironmentVariablePrefix + nameof(PerformanceRuns.ReadyToRun)] = isReadyToRun ? 1 : 0;
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
        /// <param name="available">how to run each algorithm</param>
        /// <param name="performance">how many times to run the algorithms, or null if performance isn't included</param>
        private static List<AlgorithmResult> RunAlgorithms(List<string> algorithms, Dictionary<string, Func<SeatDistributionBase>> available, PerformanceRuns? performance)
        {
            int iUntimedRuns = performance?.UntimedRuns ?? 1;
            int iTimedRuns = performance?.TimedRuns ?? 0;
            SeatDistributionBase?[] results = new SeatDistributionBase?[algorithms.Count];
            List<TimeSpan>[] elapsed = algorithms.Select(a => new List<TimeSpan>()).ToArray();
            if (performance != null) Wait(performance.StartupQuietPeriodTicks);
            for (int iRun = 0; iRun < iUntimedRuns + iTimedRuns; iRun++)
            {
                if (performance != null && iRun == iUntimedRuns) Wait(performance.PostUntimedRunsTicks);
                for (int i = 0; i < algorithms.Count; i++)
                {
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    SeatDistributionBase result = available[algorithms[i]]();
                    stopwatch.Stop();
                    results[i] ??= result;
                    if (iRun >= iUntimedRuns) elapsed[i].Add(stopwatch.Elapsed);
                }
            }
            return algorithms.Select((a, i) => new AlgorithmResult(a, results[i]!, performance == null ? null : GetMedian(elapsed[i]))).ToList();
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

            XElement expectedOutput = BuildOutput(expected, null, []);
            XElement actualOutput = BuildOutput(actual, null, []);
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
        /// <param name="performance">how many times the algorithms ran, or null if performance isn't included</param>
        /// <param name="results">the algorithms with how long each took</param>
        private static XElement BuildOutput(SeatDistributionBase r, PerformanceRuns? performance, List<AlgorithmResult> results)
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
                    new XAttribute(nameof(PerformanceRuns.UntimedRuns), performance.UntimedRuns),
                    new XAttribute(nameof(PerformanceRuns.TimedRuns), performance.TimedRuns),
                    new XAttribute(nameof(PerformanceRuns.StartupQuietPeriodTicks), performance.StartupQuietPeriodTicks),
                    new XAttribute(nameof(PerformanceRuns.PostUntimedRunsTicks), performance.PostUntimedRunsTicks),
                    performance.CallCountingDelayMs == null ? null : new XAttribute(nameof(PerformanceRuns.CallCountingDelayMs), performance.CallCountingDelayMs),
                    performance.CallCountThreshold == null ? null : new XAttribute(nameof(PerformanceRuns.CallCountThreshold), performance.CallCountThreshold),
                    performance.TieredCompilation == null ? null : new XAttribute(nameof(PerformanceRuns.TieredCompilation), performance.TieredCompilation),
                    performance.TieredPGO == null ? null : new XAttribute(nameof(PerformanceRuns.TieredPGO), performance.TieredPGO),
                    performance.ReadyToRun == null ? null : new XAttribute(nameof(PerformanceRuns.ReadyToRun), performance.ReadyToRun),
                    results.Select(a => new XElement(AlgorithmElement, new XAttribute(NameAttribute, a.Name), new XAttribute(MillisecondsAttribute, a.Elapsed!.Value.TotalMilliseconds)))));
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
