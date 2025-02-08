using Existence.Earth.Alphabet;
using Existence.Earth.Companies.Insurance;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.People;

namespace Existence.Earth.Sports.Football.American
{
    [Number(59)]
    [RomanNumeral("LIX")]
    [AlsoKnownAs("Taylor Swift Bowl")]
    public class SuperBowl
    {
        /// <summary>
        /// One score regular season games (11-0) and One score playoff games (1-0), making 12-0 in one score games for the season
        /// Week 1 (Sep 5): vs. Baltimore Ravens, 27–20
        /// Week 2 (Sep 15): vs. Cincinnati Bengals, 26–25
        /// Week 3 (Sep 22): at Atlanta Falcons, 22–17
        /// Week 4 (Sep 29): at Los Angeles Chargers, 17–10
        /// Week 8 (Oct 27): at Las Vegas Raiders, 27–20
        /// Week 9 (Nov 4): vs. Tampa Bay Buccaneers, 30–24 (OT)
        /// Week 10 (Nov 10): vs. Denver Broncos, 16–14
        /// Week 11 (Nov 17): at Buffalo Bills, 21–30 (a close loss, but not a one-score game)
        /// Week 12 (Nov 24): at Carolina Panthers, 30–27
        /// Week 13 (Nov 29): vs. Las Vegas Raiders, 19–17
        /// Week 14 (Dec 8): vs. Los Angeles Chargers, 19–17
        /// Week 16 (Dec 21): vs. Houston Texans, 27–19
        /// Divisional win over the Texans (23-14 win, not a one-score game)
        /// Conference championship over the Bills (32-29 win, is a one-score game)
        /// </summary>
        [TeamWinLossTieRecord(15, 2, 0)]
        [Record("17 consecutive one-score victories dating back to last season")]
        public static class KansasCityChiefs
        {
            [CoachType(Coaches.CoachType.HeadCoach)]
            [Insurance(InsuranceCompanies.StateFarm)]
            public static class AndyReid { }

            [PlayerType(Players.Offensive.PlayerType.Quarterback)]
            [Insurance(InsuranceCompanies.StateFarm)]
            public static class PatrickMahomes { }

            [PlayerType(Players.Offensive.PlayerType.RunningBack)]
            public static class IsaiahPacheco { }

            [PlayerType(Players.Offensive.PlayerType.TightEnd)]
            [InRelationshipWith(PeopleEnumerated.TaylorSwift, Level.Serious)]
            public static class TravisKelce { }

            [PlayerType(Players.Offensive.PlayerType.Center)]
            public static class CamJurgens { }
        }

        [TeamWinLossTieRecord(14, 3, 0)]
        public static class PhiladelphiaEagles
        {
            [CoachType(Coaches.CoachType.HeadCoach)]
            public static class NickSirianni { }

            [PlayerType(Players.Offensive.PlayerType.Quarterback)]
            public static class JalenHurts { }

            [PlayerType(Players.Offensive.PlayerType.RunningBack)]
            public static class SaquonBarkley { }

            [PlayerType(Players.Offensive.PlayerType.TightEnd)]
            public static class DallasGoedert { }

            [PlayerType(Players.Offensive.PlayerType.Center)]
            public static class CreedHumphrey { }

            /// <summary>
            /// retired 2024-03-04, between the last and current season
            /// </summary>
            [PlayerType(Players.Offensive.PlayerType.Center)]
            [Retired(true)]
            public static class JasonKelce { }            
        }        
    }
}
