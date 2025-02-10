using Existence.Earth.Alphabet;
using Existence.Earth.Companies.Insurance;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.People;
using Existence.Time;

namespace Existence.Earth.Sports.Football.American
{
    public class Season2024to2025
    {
        /// <summary>
        /// seven level 1 scorigamis occurred (6 regular season, 1 playoffs)
        /// </summary>
        public class LevelOneScorigamis
        {
            /// <summary>
            /// Week 1 (September 9, 2024): San Francisco 49ers defeated the New York Jets with a score of 32-19.
            /// </summary>
            public class First { }
            /// <summary>
            /// Week 2 (September 15, 2024): New Orleans Saints triumphed over the Dallas Cowboys, ending the game at 44-19.
            /// </summary>
            public class Second { }
            /// <summary>
            /// Week 6 (October 13, 2024): Detroit Lions dominated the Dallas Cowboys with a final score of 47-9.
            /// </summary>
            public class Third { }
            /// <summary>
            /// Week 11 (November 17, 2024): Detroit Lions secured a victory against the Jacksonville Jaguars, concluding the game at 52-6. 
            /// </summary>
            public class Fourth { }
            /// <summary>
            /// Week 14 (December 8, 2024): Miami Dolphins edged out the New York Jets with a scoreline of 32-26.
            /// </summary>
            public class Fifth { }
            /// <summary>
            /// Week 15 (December 15, 2024): Buffalo Bills narrowly defeated the Detroit Lions, ending the game at 48-42.
            /// </summary>
            public class Sixth { }
            /// <summary>
            /// Wild Card Playoffs (January 11, 2025): Houston Texans overcame the Los Angeles Chargers with a final score of 32-12.
            /// </summary>
            public class Seventh { }
        }

        public class Playoffs
        {
            /// <summary>
            /// Texans     32 Chargers   12 (level   1 scorigami)
            /// Ravens     28 Steelers   14 (level  70 scorigami)
            /// Bills      31 Broncos     7 (level  82 scorigami)
            /// Rams       27 Vikings     9 (level  16 scorigami)
            /// Bucs       23 Commanders 20 (level 210 scorigami)
            /// Eagles     22 Packers    10 (level  21 scorigami)
            /// </summary>
            public class WildCard { }

            /// <summary>
            /// Chiefs     23 Texans     14 (level  52 scorigami) (not a one-score game)
            /// Bills      27 Ravens     25 (level  11 scorigami)
            /// Commanders 45 Lions      31 (level   9 scorigami)
            /// Eagles     28 Rams       22 (level  13 scorigami)
            /// </summary>
            public class Divisional { }

            /// <summary>
            /// Chiefs     32 Bills      29 (level   8 scorigami) (a one-score game)
            /// Eagles     55 Commanders 23 (level   2 scorigami)
            /// </summary>
            public class ConferenceChampionship { }
        }

        [AlsoKnownAs("Taylor Swift Bowl")]
        [Number(59)]
        [RomanNumeral("LIX")]
        [Location("New Orleans, Louisiana")]
        [YearDate(2025, (int)Months.February, 9)]
        public class SuperBowl
        {
            [TeamWinLossTieRecord(15, 2, 0)]
            [Record("17 consecutive one-score victories dating back to last season")]
            /// <summary>
            /// one-score regular season games (11-0) and one-score playoff games (1-0), making 12-0 in one-score games for the season
            /// Week 1 (Sep 5): vs. Baltimore Ravens, 27–20
            /// Week 2 (Sep 15): vs. Cincinnati Bengals, 26–25
            /// Week 3 (Sep 22): at Atlanta Falcons, 22–17
            /// Week 4 (Sep 29): at Los Angeles Chargers, 17–10
            /// Week 8 (Oct 27): at Las Vegas Raiders, 27–20
            /// Week 9 (Nov 4): vs. Tampa Bay Buccaneers, 30–24 (OT)
            /// Week 10 (Nov 10): vs. Denver Broncos, 16–14
            /// Week 11 (Nov 17): at Buffalo Bills, 21–30 (a close loss, but not a one-score game) (level 31 scorigami)
            /// Week 12 (Nov 24): at Carolina Panthers, 30–27
            /// Week 13 (Nov 29): vs. Las Vegas Raiders, 19–17
            /// Week 14 (Dec 8): vs. Los Angeles Chargers, 19–17
            /// Week 16 (Dec 21): vs. Houston Texans, 27–19
            /// Week 17 (Jan  5): at Denver Broncos (only other loss - level 23 scorigami)
            /// </summary>
            public static class KansasCityChiefs
            {
                [CoachType(CoachType.HeadCoach)]
                [Insurance(InsuranceCompanies.StateFarm)]
                public static class AndyReid { }

                [CoachType(CoachType.OffensiveCoordinator)]
                public static class MattNagy { }

                [CoachType(CoachType.DefensiveCoordinator)]
                public static class SteveSpagnuolo { }

                [Married(true)]
                public static class Marriage
                {
                    [PlayerType(Players.Offensive.PlayerType.Quarterback)]
                    [Insurance(InsuranceCompanies.StateFarm)]
                    public static class PatrickMahomes { }
                    public static class BrittanyMahomes { }
                }

                [PlayerType(Players.Offensive.PlayerType.RunningBack)]
                public static class IsaiahPacheco { }

                [PlayerType(Players.Offensive.PlayerType.TightEnd)]
                [InRelationshipWith(PeopleEnumerated.TaylorSwift, Level.Serious)]
                [Married(false)]
                public static class TravisKelce { }

                [PlayerType(Players.Offensive.PlayerType.Center)]
                public static class CamJurgens { }
            }

            [TeamWinLossTieRecord(14, 3, 0)]
            /// <summary>
            /// First game of season was 34-29 win over the Green Bay Packers in Sao Paulo Brazil (they would also defeat the packers in the NFC playoffs) (level 8 scorigami)
            /// ---
            /// finished the season winning 15/16 games
            /// Cleveland Browns      20-16
            /// New York Giants       28-3
            /// Cincinnati Bengals    37-17
            /// Jacksonville Jaguars  28-23
            /// Dallas Cowboys        34-6
            /// Washington Commanders 26-18
            /// Los Angeles Rams      37-20
            /// Baltimore Ravens      24-19
            /// Carolina Panthers     22-16
            /// Pittsburgh Steelers   27-13
            /// Washington Commanders 33-36 (loss, but would defeat them in NFC title game) (level 7 scorigami)
            /// Dallas Cowboys        41-7
            /// New York Giants       20-13
            /// </summary>
            public static class PhiladelphiaEagles
            {
                [CoachType(CoachType.HeadCoach)]
                public static class NickSirianni { }

                [CoachType(CoachType.OffensiveCoordinator)]
                public static class KellenMoore { }

                [CoachType(CoachType.DefensiveCoordinator)]
                public static class VicFangio { }

                [PlayerType(Players.Offensive.PlayerType.Quarterback)]
                public static class JalenHurts { }

                [PlayerType(Players.Offensive.PlayerType.RunningBack)]
                public static class SaquonBarkley { }

                [PlayerType(Players.Offensive.PlayerType.TightEnd)]
                public static class DallasGoedert { }

                [PlayerType(Players.Offensive.PlayerType.Center)]
                public static class CreedHumphrey { }

                /// <summary>
                /// retired between the last and current season, so not playing for the Eagles
                /// </summary>
                [PlayerType(Players.Offensive.PlayerType.Center)]
                [RetiredWhen(2024, 3, 4)]
                [Married(true)]
                public static class JasonKelce { }
            }

            [CoverageType(CoverageType.Television)]
            [AnnouncerType(AnnouncerType.Color)]
            public static class TomBrady { }

            [CoverageType(CoverageType.Television)]
            [AnnouncerType(AnnouncerType.PlayByPlay)]
            public static class KevinBurkhardt { }

        }
    }
}
