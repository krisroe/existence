using Existence.Earth.Sports;
using Existence.Earth.Sports.Baseball.American;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Existence.Tests
{
    /// <summary>
    /// test class
    /// </summary>
    [TestClass]
    public class MajorLeagueBaseballTest
    {
        private static readonly Regex rSeason = new Regex(@"^v\d{4}$");
        private static readonly Regex rGame = new Regex(@"^Game(\d+)$");
        /// <summary>
        /// the classes holding a league's divisions; a split season (e.g. 1981) has separate standings for each half
        /// </summary>
        private static readonly string[] asDivisions = { "Divisions", "SplitSeason1Divisions", "SplitSeason2Divisions" };
        /// <summary>
        /// the classes holding a league's teams directly, for a split season without divisions (e.g. 1892)
        /// </summary>
        private static readonly string[] asLeagueStandings = { "SplitSeason1", "SplitSeason2" };
        private static readonly string[] asLeagues = { "AmericanLeague", "NationalLeague" };

        /// <summary>
        /// validates that every playoff series standing lists first the team with the same or more wins
        /// </summary>
        [TestMethod]
        public void ValidatePlayoffSeriesLeadingTeamHasMostWins()
        {
            int iSeries = 0;
            foreach (Type t in GetNestedTypesRecursive(typeof(MajorLeagueBaseball)))
            {
                foreach (MajorLeagueBaseballPlayoffSeriesAttribute series in t.GetCustomAttributes<MajorLeagueBaseballPlayoffSeriesAttribute>())
                {
                    iSeries++;
                    Assert.IsTrue(series.LeadingTeamWins >= series.TrailingTeamWins, $"{GetName(t)} lists {series.LeadingTeam} with {series.LeadingTeamWins} wins ahead of {series.TrailingTeam} with {series.TrailingTeamWins} wins");
                }
            }
            Assert.IsTrue(iSeries > 0, "no playoff series attributes found");
        }

        /// <summary>
        /// validates that the teams in each division, including each half of a split season with or without divisions,
        /// are listed from the best winning percentage to the worst. A division whose records haven't been filled in
        /// yet, with no TeamWinLossRecord on any team, is skipped
        /// </summary>
        [TestMethod]
        public void ValidateDivisionsSortedByRecord()
        {
            int iDivisions = 0;
            foreach (Type season in GetSeasons())
            {
                foreach (Type division in asLeagues.SelectMany(s => GetStandings(season, s)))
                {
                    List<Type> teams = GetTeams(division);
                    Assert.IsTrue(teams.Count > 0, $"{GetName(division)} has no teams");
                    if (teams.All(t => t.GetCustomAttribute<TeamWinLossRecordAttribute>() == null)) continue;
                    iDivisions++;
                    for (int i = 1; i < teams.Count; i++)
                    {
                        TeamWinLossRecordAttribute previous = GetRecord(teams[i - 1]);
                        TeamWinLossRecordAttribute current = GetRecord(teams[i]);
                        // compares winning percentages without division
                        Assert.IsTrue(previous.Wins * (current.Wins + current.Losses) >= current.Wins * (previous.Wins + previous.Losses), $"{GetName(teams[i])} ({current.Wins}-{current.Losses}) has a better record than {teams[i - 1].Name} ({previous.Wins}-{previous.Losses}) listed above it");
                    }
                }
            }
            Assert.IsTrue(iDivisions > 0, "no divisions found");
        }

        /// <summary>
        /// validates the WorldSeries attributes of each season with standings whose World Series has been filled in,
        /// through a WorldSeries class with a BestOf attribute or through WorldSeries attributes on its teams. Exactly one
        /// team in each league has a WorldSeries attribute, and in a split season each half's standings have it on the
        /// same team with the same outcome. The two leagues' outcomes are a Win and a Loss once the series is decided or
        /// Future for both while it's undecided. When the season has a WorldSeries class, the attributes must be on its
        /// two teams and the Win on the team that won a majority of the games
        /// </summary>
        [TestMethod]
        public void ValidateWorldSeriesAttributes()
        {
            int iSeasons = 0;
            foreach (Type season in GetSeasons())
            {
                (Type Team, TwoPlayerGameOutcome Outcome)? americanLeagueOutcome = GetWorldSeriesOutcome(season, "AmericanLeague");
                (Type Team, TwoPlayerGameOutcome Outcome)? nationalLeagueOutcome = GetWorldSeriesOutcome(season, "NationalLeague");
                Type? worldSeries = season.GetNestedType("WorldSeries");
                BestOfAttribute? bestOf = worldSeries?.GetCustomAttribute<BestOfAttribute>();
                if (bestOf == null && americanLeagueOutcome == null && nationalLeagueOutcome == null) continue; // no World Series was played, or it hasn't been filled in
                if (!GetStandings(season, "AmericanLeague").Any() && !GetStandings(season, "NationalLeague").Any()) continue; // no standings to put the attributes on
                iSeasons++;

                Assert.IsNotNull(americanLeagueOutcome, $"{season.Name} has no WorldSeries attribute in the American League");
                Assert.IsNotNull(nationalLeagueOutcome, $"{season.Name} has no WorldSeries attribute in the National League");
                (Type Team, TwoPlayerGameOutcome Outcome) americanLeague = americanLeagueOutcome.Value;
                (Type Team, TwoPlayerGameOutcome Outcome) nationalLeague = nationalLeagueOutcome.Value;

                if (worldSeries != null && bestOf != null)
                {
                    AssertWorldSeriesTeam(season, worldSeries, "AmericanLeagueTeam", americanLeague.Team);
                    AssertWorldSeriesTeam(season, worldSeries, "NationalLeagueTeam", nationalLeague.Team);
                    MajorLeagueBaseballTeams? winner = GetWorldSeriesWinner(worldSeries, bestOf);
                    if (winner == null)
                    {
                        Assert.AreEqual(TwoPlayerGameOutcome.Future, americanLeague.Outcome, $"{season.Name} World Series is undecided but {americanLeague.Team.Name} has a {americanLeague.Outcome} WorldSeries attribute");
                        Assert.AreEqual(TwoPlayerGameOutcome.Future, nationalLeague.Outcome, $"{season.Name} World Series is undecided but {nationalLeague.Team.Name} has a {nationalLeague.Outcome} WorldSeries attribute");
                    }
                    else
                    {
                        Assert.AreEqual(americanLeague.Team.Name == winner.ToString() ? TwoPlayerGameOutcome.Win : TwoPlayerGameOutcome.Loss, americanLeague.Outcome, $"{season.Name} World Series was won by {winner} but {americanLeague.Team.Name} has a {americanLeague.Outcome} WorldSeries attribute");
                        Assert.AreEqual(nationalLeague.Team.Name == winner.ToString() ? TwoPlayerGameOutcome.Win : TwoPlayerGameOutcome.Loss, nationalLeague.Outcome, $"{season.Name} World Series was won by {winner} but {nationalLeague.Team.Name} has a {nationalLeague.Outcome} WorldSeries attribute");
                    }
                }
                else
                {
                    // without the games, the outcomes can only be checked against each other
                    bool bDecided = (americanLeague.Outcome, nationalLeague.Outcome) is (TwoPlayerGameOutcome.Win, TwoPlayerGameOutcome.Loss) or (TwoPlayerGameOutcome.Loss, TwoPlayerGameOutcome.Win);
                    bool bUndecided = (americanLeague.Outcome, nationalLeague.Outcome) is (TwoPlayerGameOutcome.Future, TwoPlayerGameOutcome.Future);
                    Assert.IsTrue(bDecided || bUndecided, $"{season.Name} World Series teams {americanLeague.Team.Name} and {nationalLeague.Team.Name} have {americanLeague.Outcome} and {nationalLeague.Outcome} WorldSeries attributes instead of a Win and a Loss, or Future for both");
                }
            }
            Assert.IsTrue(iSeasons > 0, "no seasons with standings and a World Series found");
        }

        /// <summary>
        /// validates the WorstRecordInLeague attributes of each season whose records are filled in. The teams with the
        /// worst full-season winning percentage in all of Major League Baseball, including ties, have MajorLeagueBaseball,
        /// and otherwise the teams with the worst in their league have that league; no other team has the attribute. In a
        /// split season the full-season record is the sum of the halves, and each half's entry for a team has the same
        /// attribute
        /// </summary>
        [TestMethod]
        public void ValidateWorstRecordInLeague()
        {
            int iSeasons = 0;
            foreach (Type season in GetSeasons())
            {
                var leagueRecords = new Dictionary<MajorLeagueBaseballLeagues, Dictionary<string, (int Wins, int Losses)>>();
                bool bComplete = true;
                foreach (string sLeague in asLeagues)
                {
                    var records = new Dictionary<string, (int Wins, int Losses)>();
                    foreach (Type team in GetSeasonHalves(season, sLeague).SelectMany(h => h.Teams))
                    {
                        TeamWinLossRecordAttribute? record = team.GetCustomAttribute<TeamWinLossRecordAttribute>();
                        if (record == null)
                        {
                            bComplete = false;
                            break;
                        }
                        records.TryGetValue(team.Name, out (int Wins, int Losses) total);
                        records[team.Name] = (total.Wins + record.Wins, total.Losses + record.Losses);
                    }
                    if (records.Count > 0) leagueRecords[Enum.Parse<MajorLeagueBaseballLeagues>(sLeague)] = records;
                }
                if (!bComplete || leagueRecords.Count == 0) continue; // records haven't been filled in
                iSeasons++;

                HashSet<string> majorLeagueWorst = GetWorstRecords(leagueRecords.Values.SelectMany(r => r));
                foreach (var league in leagueRecords)
                {
                    HashSet<string> leagueWorst = GetWorstRecords(league.Value);
                    foreach (Type team in GetSeasonHalves(season, league.Key.ToString()).SelectMany(h => h.Teams))
                    {
                        MajorLeagueBaseballLeagues? expected = majorLeagueWorst.Contains(team.Name) ? MajorLeagueBaseballLeagues.MajorLeagueBaseball : leagueWorst.Contains(team.Name) ? league.Key : null;
                        MajorLeagueBaseballLeagues? actual = team.GetCustomAttribute<WorstRecordInLeagueAttribute>()?.League;
                        Assert.AreEqual(expected, actual, $"{GetName(team)} has WorstRecordInLeague {actual?.ToString() ?? "(none)"} instead of {expected?.ToString() ?? "(none)"}");
                    }
                }
            }
            Assert.IsTrue(iSeasons > 0, "no seasons with filled-in records found");
        }

        /// <summary>
        /// gets the names of the teams with the worst winning percentage, including ties
        /// </summary>
        private static HashSet<string> GetWorstRecords(IEnumerable<KeyValuePair<string, (int Wins, int Losses)>> records)
        {
            List<KeyValuePair<string, (int Wins, int Losses)>> list = records.ToList();
            (int Wins, int Losses) worst = list[0].Value;
            // compares winning percentages without division
            foreach (var record in list)
            {
                if (record.Value.Wins * (worst.Wins + worst.Losses) < worst.Wins * (record.Value.Wins + record.Value.Losses)) worst = record.Value;
            }
            return list
                .Where(r => r.Value.Wins * (worst.Wins + worst.Losses) == worst.Wins * (r.Value.Wins + r.Value.Losses))
                .Select(r => r.Key)
                .ToHashSet();
        }

        /// <summary>
        /// gets the league's team with a WorldSeries attribute and its outcome, or null if no team has one. The league
        /// must have exactly one such team in its standings, and in a split season each half's standings must have the
        /// attribute on the same team with the same outcome
        /// </summary>
        private static (Type Team, TwoPlayerGameOutcome Outcome)? GetWorldSeriesOutcome(Type season, string sLeague)
        {
            var halves = GetSeasonHalves(season, sLeague)
                .Select(h => (h.Name, Outcomes: h.Teams.SelectMany(t => t.GetCustomAttributes<WorldSeriesAttribute>().Select(a => (Team: t, a.Outcome))).ToList()))
                .ToList();
            if (halves.All(h => h.Outcomes.Count == 0)) return null;
            foreach (var half in halves)
            {
                Assert.AreEqual(1, half.Outcomes.Count, $"{season.Name}.{sLeague}.{half.Name} has {half.Outcomes.Count} WorldSeries attributes instead of 1: {string.Join(", ", half.Outcomes.Select(o => GetName(o.Team)))}");
            }
            (Type Team, TwoPlayerGameOutcome Outcome) first = halves[0].Outcomes[0];
            foreach (var half in halves.Skip(1))
            {
                (Type Team, TwoPlayerGameOutcome Outcome) outcome = half.Outcomes[0];
                Assert.AreEqual(first.Team.Name, outcome.Team.Name, $"{season.Name}.{sLeague}.{half.Name} has its WorldSeries attribute on {outcome.Team.Name} instead of {first.Team.Name} as in {halves[0].Name}");
                Assert.AreEqual(first.Outcome, outcome.Outcome, $"{season.Name}.{sLeague}.{half.Name} has a {outcome.Outcome} WorldSeries attribute on {outcome.Team.Name} instead of {first.Outcome} as in {halves[0].Name}");
            }
            return first;
        }

        /// <summary>
        /// gets the league's teams for each part of the season with its own standings: the whole season, or each half of
        /// a split season, whether or not the league had divisions
        /// </summary>
        private static List<(string Name, List<Type> Teams)> GetSeasonHalves(Type season, string sLeague)
        {
            var halves = new List<(string Name, List<Type> Teams)>();
            foreach (string sDivisions in asDivisions)
            {
                List<Type> teams = GetDivisions(season, sLeague, sDivisions).SelectMany(GetTeams).ToList();
                if (teams.Count > 0) halves.Add((sDivisions, teams));
            }
            foreach (string sLeagueStandings in asLeagueStandings)
            {
                Type? standings = season.GetNestedType(sLeague)?.GetNestedType(sLeagueStandings);
                if (standings != null) halves.Add((sLeagueStandings, GetTeams(standings)));
            }
            return halves;
        }

        /// <summary>
        /// checks that the team with the league's WorldSeries attribute is the WorldSeries class's team for the league
        /// </summary>
        private static void AssertWorldSeriesTeam(Type season, Type worldSeries, string sWorldSeriesTeam, Type team)
        {
            Type? worldSeriesTeam = worldSeries.GetNestedType(sWorldSeriesTeam);
            Assert.IsNotNull(worldSeriesTeam, $"{season.Name}.WorldSeries has no {sWorldSeriesTeam}");
            MajorLeagueBaseballTeamAttribute? teamAttribute = worldSeriesTeam.GetCustomAttribute<MajorLeagueBaseballTeamAttribute>();
            Assert.IsNotNull(teamAttribute, $"{season.Name}.WorldSeries.{sWorldSeriesTeam} has no MajorLeagueBaseballTeam attribute");
            Assert.AreEqual(teamAttribute.Team.ToString(), team.Name, $"{season.Name} has a WorldSeries attribute on {GetName(team)} instead of the {sWorldSeriesTeam}, {teamAttribute.Team}");
        }

        /// <summary>
        /// gets the team that won a majority of the games in the World Series as of the last game with a series
        /// standing, or null if no team has yet
        /// </summary>
        private static MajorLeagueBaseballTeams? GetWorldSeriesWinner(Type worldSeries, BestOfAttribute bestOf)
        {
            MajorLeagueBaseballPlayoffSeriesAttribute? series = worldSeries.GetNestedTypes()
                .Select(t => (Match: rGame.Match(t.Name), Game: t))
                .Where(g => g.Match.Success)
                .OrderBy(g => int.Parse(g.Match.Groups[1].Value))
                .Select(g => g.Game.GetCustomAttribute<MajorLeagueBaseballPlayoffSeriesAttribute>())
                .LastOrDefault(s => s != null);
            return series != null && series.LeadingTeamWins > bestOf.Games / 2 ? series.LeadingTeam : null;
        }

        private static IEnumerable<Type> GetSeasons()
        {
            return typeof(MajorLeagueBaseball).GetNestedTypes().Where(t => rSeason.IsMatch(t.Name));
        }

        /// <summary>
        /// gets every class whose nested classes are the teams of one set of standings: each division, and for a split
        /// season each half's divisions, or each half of the league itself when it had no divisions
        /// </summary>
        private static IEnumerable<Type> GetStandings(Type season, string sLeague)
        {
            foreach (Type division in asDivisions.SelectMany(s => GetDivisions(season, sLeague, s)))
            {
                yield return division;
            }
            foreach (string sLeagueStandings in asLeagueStandings)
            {
                Type? standings = season.GetNestedType(sLeague)?.GetNestedType(sLeagueStandings);
                if (standings != null) yield return standings;
            }
        }

        private static IEnumerable<Type> GetDivisions(Type season, string sLeague, string sDivisions = "Divisions")
        {
            return season.GetNestedType(sLeague)?.GetNestedType(sDivisions)?.GetNestedTypes() ?? Enumerable.Empty<Type>();
        }

        /// <summary>
        /// gets the division's teams in the order they're declared; nested types' metadata tokens follow declaration
        /// order, which reflection otherwise doesn't guarantee
        /// </summary>
        private static List<Type> GetTeams(Type division)
        {
            return division.GetNestedTypes().OrderBy(t => t.MetadataToken).ToList();
        }

        private static TeamWinLossRecordAttribute GetRecord(Type team)
        {
            TeamWinLossRecordAttribute? record = team.GetCustomAttribute<TeamWinLossRecordAttribute>();
            Assert.IsNotNull(record, $"{GetName(team)} has no TeamWinLossRecord attribute");
            return record;
        }

        private static IEnumerable<Type> GetNestedTypesRecursive(Type t)
        {
            foreach (Type nested in t.GetNestedTypes())
            {
                yield return nested;
                foreach (Type descendant in GetNestedTypesRecursive(nested))
                {
                    yield return descendant;
                }
            }
        }

        /// <summary>
        /// gets the type's name relative to its namespace, e.g. MajorLeagueBaseball.v1982.WorldSeries.Game1
        /// </summary>
        private static string GetName(Type t)
        {
            return t.FullName!.Substring(t.Namespace!.Length + 1).Replace('+', '.');
        }
    }
}
