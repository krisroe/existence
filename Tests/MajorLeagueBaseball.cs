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
                foreach (Type division in GetStandings(season))
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
        /// validates that for each season with division standings and a World Series, the World Series teams are the
        /// only teams with a WorldSeries attribute, one from each league. The winner of a finished series has a Win and
        /// the loser a Loss, and both have Future while the series is undecided
        /// </summary>
        [TestMethod]
        public void ValidateWorldSeriesAttributes()
        {
            int iSeasons = 0;
            foreach (Type season in GetSeasons())
            {
                Type? worldSeries = season.GetNestedType("WorldSeries");
                BestOfAttribute? bestOf = worldSeries?.GetCustomAttribute<BestOfAttribute>();
                if (worldSeries == null || bestOf == null) continue; // no World Series was played
                List<Type> americanLeagueTeams = GetDivisions(season, "AmericanLeague").SelectMany(GetTeams).ToList();
                List<Type> nationalLeagueTeams = GetDivisions(season, "NationalLeague").SelectMany(GetTeams).ToList();
                if (americanLeagueTeams.Count == 0 && nationalLeagueTeams.Count == 0) continue; // no division standings
                iSeasons++;

                (MajorLeagueBaseballTeams Team, TwoPlayerGameOutcome Outcome) americanLeague = GetWorldSeriesOutcome(season, worldSeries, americanLeagueTeams, "AmericanLeagueTeam");
                (MajorLeagueBaseballTeams Team, TwoPlayerGameOutcome Outcome) nationalLeague = GetWorldSeriesOutcome(season, worldSeries, nationalLeagueTeams, "NationalLeagueTeam");
                MajorLeagueBaseballTeams? winner = GetWorldSeriesWinner(worldSeries, bestOf);
                if (winner == null)
                {
                    Assert.AreEqual(TwoPlayerGameOutcome.Future, americanLeague.Outcome, $"{season.Name} World Series is undecided but {americanLeague.Team} has a {americanLeague.Outcome} WorldSeries attribute");
                    Assert.AreEqual(TwoPlayerGameOutcome.Future, nationalLeague.Outcome, $"{season.Name} World Series is undecided but {nationalLeague.Team} has a {nationalLeague.Outcome} WorldSeries attribute");
                }
                else
                {
                    Assert.AreEqual(americanLeague.Team == winner ? TwoPlayerGameOutcome.Win : TwoPlayerGameOutcome.Loss, americanLeague.Outcome, $"{season.Name} World Series was won by {winner} but {americanLeague.Team} has a {americanLeague.Outcome} WorldSeries attribute");
                    Assert.AreEqual(nationalLeague.Team == winner ? TwoPlayerGameOutcome.Win : TwoPlayerGameOutcome.Loss, nationalLeague.Outcome, $"{season.Name} World Series was won by {winner} but {nationalLeague.Team} has a {nationalLeague.Outcome} WorldSeries attribute");
                }
            }
            Assert.IsTrue(iSeasons > 0, "no seasons with division standings and a World Series found");
        }

        /// <summary>
        /// gets the league's World Series team and its outcome, checking that it's the only team in the league's
        /// divisions with a WorldSeries attribute
        /// </summary>
        private static (MajorLeagueBaseballTeams Team, TwoPlayerGameOutcome Outcome) GetWorldSeriesOutcome(Type season, Type worldSeries, List<Type> leagueTeams, string sWorldSeriesTeam)
        {
            Type? worldSeriesTeam = worldSeries.GetNestedType(sWorldSeriesTeam);
            Assert.IsNotNull(worldSeriesTeam, $"{season.Name}.WorldSeries has no {sWorldSeriesTeam}");
            MajorLeagueBaseballTeamAttribute? team = worldSeriesTeam.GetCustomAttribute<MajorLeagueBaseballTeamAttribute>();
            Assert.IsNotNull(team, $"{season.Name}.WorldSeries.{sWorldSeriesTeam} has no MajorLeagueBaseballTeam attribute");

            var outcomes = leagueTeams
                .SelectMany(t => t.GetCustomAttributes<WorldSeriesAttribute>().Select(a => (Team: t, a.Outcome)))
                .ToList();
            Assert.AreEqual(1, outcomes.Count, $"{season.Name} has {outcomes.Count} WorldSeries attributes for {sWorldSeriesTeam}'s league instead of 1: {string.Join(", ", outcomes.Select(o => GetName(o.Team)))}");
            Assert.AreEqual(team.Team.ToString(), outcomes[0].Team.Name, $"{season.Name} has a WorldSeries attribute on {outcomes[0].Team.Name} instead of the {sWorldSeriesTeam}, {team.Team}");
            return (team.Team, outcomes[0].Outcome);
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
        private static IEnumerable<Type> GetStandings(Type season)
        {
            foreach (string sLeague in asLeagues)
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
