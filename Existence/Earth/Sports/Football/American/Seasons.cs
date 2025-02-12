using Existence.Earth.Alphabet;
using Existence.Earth.Companies.Insurance;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.People;
using Existence.Time;

namespace Existence.Earth.Sports.Football.American
{
    [Year(1920)]
    [Champion("AkronPros")]
    public class v001 { }

    /// <summary>
    /// championship disputed by the Buffalo All-Americans (lost second game to Chicago Staleys which was decisive)
    /// [Staley Swindle]
    /// </summary>
    [Year(1921)]
    [Champion("ChicagoStaleys")]
    public class v002 { }

    [Year(1922)]
    [Champion("CantonBulldogs")]
    public class v003 { }

    [Year(1923)]
    [Champion("CantonBulldogs")]
    public class v004 { }

    [Year(1924)]
    [Champion("ClevelandBulldogs")]
    public class v005 { }

    [Year(1925)]
    [Champion("ChicagoCardinals")]
    public class v006 { }

    [Year(1926)]
    [Champion("FrankfordYellowJackets")]
    public class v007 { }

    [Year(1927)]
    [Champion("NewYorkGiants")]
    public class v008 { }

    [Year(1928)]
    [Champion("ProvidenceSteamRoller")]
    public class v009 { }

    [Year(1929)]
    [Champion("GreenBayPackers")]
    public class v010 { }

    [Year(1930)]
    [Champion("GreenBayPackers")] //2nd
    public class v011 { }

    [Year(1931)]
    [Champion("GreenBayPackers")] //3rd
    public class v012 { }

    [Year(1932)]
    [Champion("ChicagoBears")] //2nd, won ad hoc championship game
    [ChampionshipLoser("PortsmouthSpartans")]
    public class v013 { }

    /// <summary>
    /// 1933-12-17 New York Giants 21 at 23 Chicago Bears
    /// </summary>
    [Year(1933)]
    [Champion("ChicagoBears")] //3rd
    [ChampionshipLoser("NewYorkGiants")]
    public class v014 { }

    /// <summary>
    /// 1934-12-09 Chicago Bears 13 at 30 New York Giants
    /// </summary>
    [Year(1934)]
    [Champion("NewYorkGiants")] //2nd
    [ChampionshipLoser("ChicagoBears")]
    public class v015 { }

    /// <summary>
    /// 1935-12-15 New York Giants 7 at 26 Detroit Lions
    /// </summary>
    [Year(1935)]
    [RegularSeasonGameCount(12)]
    [Champion("DetroitLions")]
    [ChampionshipLoser("NewYorkGiants")]
    public class v016 { }

    /// <summary>
    /// 1936-12-13 Green Bay Packers 21 at 6 Boston Redskins
    /// </summary>
    [Year(1936)]
    [RegularSeasonGameCount(12)]
    [Champion("GreenBayPackers")] //4rd
    [ChampionshipLoser("BostonRedskins")]
    public class v017 { }

    /// <summary>
    /// 1937-12-12 Washington Redskins 28 at 21 Chicago Bears
    /// </summary>
    [Year(1937)]
    [RegularSeasonGameCount(12)]
    [Champion("WashingtonRedskins")]
    [ChampionshipLoser("ChicagoBears")]
    public class v018 { }

    /// <summary>
    /// 1938-12-11 Green Bay Packers 17 at 23 New York Giants
    /// </summary>
    [Year(1938)]
    [RegularSeasonGameCount(12)]
    [Champion("NewYorkGiants")] //3rd
    [ChampionshipLoser("GreenBayPackers")]
    public class v019 { }

    /// <summary>
    /// 1939-12-10 New York Giants 0 at 27 Green Bay Packers
    /// </summary>
    [Year(1939)]
    [RegularSeasonGameCount(12)]
    [Champion("GreenBayPackers")] //5th
    [ChampionshipLoser("NewYorkGiants")]
    public class v020 { }

    /// <summary>
    /// 1940-12-08 Chicago Bears 73 at 0 Washington Redskins
    /// </summary>
    [Year(1940)]
    [RegularSeasonGameCount(12)]
    [Champion("ChicagoBears")] //4th
    [ChampionshipLoser("WashingtonRedskins")]
    public class v021 { }

    /// <summary>
    /// 1941-12-21 New York Giants 9 at 37 Chicago Bears
    /// </summary>
    [Year(1941)]
    [RegularSeasonGameCount(12)]
    [Champion("ChicagoBears")] //5th
    [ChampionshipLoser("NewYorkGiants")]
    public class v022 { }

    /// <summary>
    /// 1942-12-13 Chicago Bears 6 at 14 Washington Redskins
    /// </summary>
    [Year(1942)]
    [RegularSeasonGameCount(12)]
    [Champion("WashingtonRedskins")] //x2
    [ChampionshipLoser("ChicagoBears")]
    public class v023 { }

    /// <summary>
    /// 1943-12-26 Washington Redskins 21 at 41 Chicago Bears
    /// </summary>
    [Year(1943)]
    [RegularSeasonGameCount(10)]
    [Champion("ChicagoBears")] //x6
    [ChampionshipLoser("WashingtonRedskins")]
    public class v024 { }

    /// <summary>
    /// 1944-12-17 Green Bay Packers 14 at 7 New York Giants
    /// </summary>
    [Year(1944)]
    [RegularSeasonGameCount(10)]
    [Champion("GreenBayPackers")] //x6
    [ChampionshipLoser("NewYorkGiants")]
    public class v025 { }

    /// <summary>
    /// 1945-12-16 Washington Redskins 14 at 15 Cleveland Rams
    /// </summary>
    [Year(1945)]
    [RegularSeasonGameCount(10)]
    [Champion("ClevelandRams")]
    [ChampionshipLoser("WashingtonRedskins")]
    public class v026 { }

    [Year(1946)]
    public class v027
    {
        /// <summary>
        /// 1946-12-22 New York Yankees 9 at 14 Cleveland Browns
        /// </summary>
        [Champion("ClevelandBrowns")] //not recognized as an NFL championship
        [ChampionshipLoser("NewYorkYankees")]
        [RegularSeasonGameCount(14)]
        public static class AAFC { }

        /// <summary>
        /// 1946-12-15 Chicago Bears 24 at 14 New York Giants
        /// </summary>
        [Champion("ChicagoBears")] //x7
        [ChampionshipLoser("NewYorkGiants")]
        [RegularSeasonGameCount(12)]
        public static class NFL { }
    }

    [Year(1947)]
    public class v028
    {
        /// <summary>
        /// 1947-12-14 Cleveland Browns 14 at 3 New York Yankees
        /// </summary>
        [Champion("ClevelandBrowns")] //not recognized as an NFL championship
        [ChampionshipLoser("NewYorkYankees")]
        [RegularSeasonGameCount(14)]
        public static class AAFC { }

        /// <summary>
        /// 1947-12-28 Philadelphia Eagles 21 at 28 Chicago Cardinals
        /// </summary>
        [Champion("ChicagoCardinals")]
        [ChampionshipLoser("PhiladelphiaEagles")]
        [RegularSeasonGameCount(12)]
        public static class NFL { }
    }

    [Year(1948)]
    public class v029
    {
        /// <summary>
        /// 1948-12-19 Buffalo Bills 7 at 49 Cleveland Browns
        /// </summary>
        [Champion("ClevelandBrowns")] //not recognized as an NFL championship
        [ChampionshipLoser("BuffaloBills")]
        [RegularSeasonGameCount(14)]
        public static class AAFC { }

        /// <summary>
        /// 1948-12-19 Chicago Cardinals 0 at 7 Philadelphia Eagles
        /// </summary>
        [Champion("PhiladelphiaEagles")]
        [ChampionshipLoser("ChicagoCardinals")]
        [RegularSeasonGameCount(12)]
        public static class NFL { }
    }

    [Year(1949)]
    [RegularSeasonGameCount(12)]
    public class v030
    {
        /// <summary>
        /// 1949-12-11 San Francisco 49ers 7 at 21 Cleveland Browns
        /// </summary>
        [Champion("ClevelandBrowns")] //not recognized as an NFL championship
        [ChampionshipLoser("SanFrancisco49ers")]
        public static class AAFC { }

        /// <summary>
        /// 1949-12-18 Philadelphia Eagles 14 at 0 Los Angeles Rams
        /// </summary>
        [Champion("PhiladelphiaEagles")] //x2
        [ChampionshipLoser("LosAngelesRams")]
        public static class NFL { }
    }

    /// <summary>
    /// 1950-12-24 Los Angeles Rams 28 at 30 Cleveland Browns
    /// </summary>
    [Year(1950)]
    [RegularSeasonGameCount(12)]
    [Champion("ClevelandBrowns")]
    [ChampionshipLoser("LosAngelesRams")]
    public class v031 { }

    /// <summary>
    /// 1951-12-23 Cleveland Browns 17 at 24 Los Angeles Rams
    /// </summary>
    [Year(1951)]
    [RegularSeasonGameCount(12)]
    [Champion("LosAngelesRams")] //x2
    [ChampionshipLoser("ClevelandBrowns")]
    public class v032 { }

    /// <summary>
    /// 1952-12-28 Detroit Lions 17 at 7 Cleveland Browns
    /// </summary>
    [Year(1952)]
    [RegularSeasonGameCount(12)]
    [Champion("DetroitLions")] //x2
    [ChampionshipLoser("ClevelandBrowns")]
    public class v033 { }

    /// <summary>
    /// 1953-12-27 Cleveland Browns 16 at 17 Detroit Lions
    /// </summary>
    [Year(1953)]
    [RegularSeasonGameCount(12)]
    [Champion("DetroitLions")] //x3
    [ChampionshipLoser("ClevelandBrowns")]
    public class v034 { }

    /// <summary>
    /// 1954-12-26 Detroit Lions 10 at 56 Cleveland Browns
    /// </summary>
    [Year(1954)]
    [RegularSeasonGameCount(12)]
    [Champion("ClevelandBrowns")] //x2
    [ChampionshipLoser("DetroitLions")]
    public class v035 { }

    /// <summary>
    /// 1955-12-26 Cleveland Browns 38 at 14 Los Angeles Rams
    /// </summary>
    [Year(1955)]
    [RegularSeasonGameCount(12)]
    [Champion("ClevelandBrowns")] //x3
    [ChampionshipLoser("LosAngelesRams")]
    public class v036 { }

    /// <summary>
    /// 1956-12-30 Chicago Bears 7 at 47 New York Giants
    /// </summary>
    [Year(1956)]
    [RegularSeasonGameCount(12)]
    [Champion("NewYorkGiants")] //x4
    [ChampionshipLoser("ChicagoBears")]
    public class v037 { }

    /// <summary>
    /// 1957-12-29 Cleveland Browns 14 at 59 Detroit Lions
    /// </summary>
    [Year(1957)]
    [RegularSeasonGameCount(12)]
    [Champion("DetroitLions")] //x4
    [ChampionshipLoser("ClevelandBrowns")]
    public class v038 { }

    /// <summary>
    /// 1958-12-28 Baltimore Colts 23 at 17 New York Giants
    /// </summary>
    [Year(1958)]
    [RegularSeasonGameCount(12)]
    [Champion("BaltimoreColts")]
    [ChampionshipLoser("NewYorkGiants")]
    public class v39 { }

    /// <summary>
    /// 1959-12-27 New York Giants 16 at 31 Baltimore Colts
    /// </summary>
    [Year(1959)]
    [Champion("BaltimoreColts")] //x2
    [ChampionshipLoser("NewYorkGiants")]
    public class v40 { }

    [YearRange(1960, 1961)]
    public class v041
    {
        /// <summary>
        /// 1961-01-01 Los Angeles Chargers 16 at 24 Houston Oilers
        /// </summary>
        [Champion("HoustonOilers")]
        [ChampionshipLoser("LosAngelesChargers")]
        [RegularSeasonGameCount(14)]
        public class AFL { }

        /// <summary>
        /// 1960-12-26 Green Bay Packers 13 at 17 Philadelphia Eagles
        /// </summary>
        [Champion("PhiladelphiaEagles")] //x3
        [ChampionshipLoser("GreenBayPackers")]
        [RegularSeasonGameCount(12)]
        public class NFL { }
    }

    [Year(1961)]
    [RegularSeasonGameCount(14)]
    public class v042
    {
        /// <summary>
        /// 1961-12-24 Houston Oilers 10 at 3 San Diego Chargers
        /// </summary>
        [Champion("HoutonOilers")] //x2
        [ChampionshipLoser("SanDiegoChargers")]
        public class AFL { }

        /// <summary>
        /// 1961-12-31 New York Giants 0 at 37 Green Bay Packers
        /// </summary>
        [Champion("GreenBayPackers")] //x7
        [ChampionshipLoser("NewYorkGiants")]
        public class NFL { }
    }

    [Year(1962)]
    [RegularSeasonGameCount(14)]
    public class v043
    {
        /// <summary>
        /// 1962-12-23 Dallas Texans 20 at 17 Houston Oilers
        /// </summary>
        [Champion("DallasTexans")]
        [ChampionshipLoser("HoustonOilers")]
        public class AFL { }

        /// <summary>
        /// 1962-12-30 Green Bay Packers 16 at 7 New York Giants
        /// </summary>
        [Champion("GreenBayPackers")] //x8
        [ChampionshipLoser("NewYorkGiants")]
        public class NFL { }
    }

    [YearRange(1963, 1964)]
    [RegularSeasonGameCount(14)]
    public class v044
    {
        /// <summary>
        /// 1964-01-05 Boston Patriots 10 at 51 San Diego Chargers
        /// </summary>
        [Champion("SanDiegoChargers")]
        [ChampionshipLoser("BostonPatriots")]
        public class AFL { }

        /// <summary>
        /// 1963-12-29 New York Giants 10 at 14 Chicago Bears
        /// </summary>
        [Champion("ChicagoBears")] //x8
        [ChampionshipLoser("NewYorkGiants")]
        public class NFL { }
    }

    [Year(1964)]
    [RegularSeasonGameCount(14)]
    public class v045
    {
        /// <summary>
        /// 1964-12-26 San Diego Chargers 7 at 20 Buffalo Bills
        /// </summary>
        [Champion("BuffaloBills")]
        [ChampionshipLoser("SanDiegoChargers")]
        public class AFL { }

        /// <summary>
        /// 1964-12-27 Baltimore Colts 0 at 27 Cleveland Browns
        /// </summary>
        [Champion("ClevelandBrowns")]
        [ChampionshipLoser("BaltimoreColts")]
        public class NFL { }
    }

    [YearRange(1965, 1966)]
    [RegularSeasonGameCount(14)]
    public class v046
    {
        /// <summary>
        /// 1965-12-26 Buffalo Bills 23 at 0 San Diego Chargers
        /// </summary>
        [Champion("BuffaloBills")] //x2
        [ChampionshipLoser("SanDiegoChargers")]
        public class AFL { }
        /// <summary>
        /// 1966-01-02 Cleveland Browns 12 at 23 Green Bay Packers
        /// </summary>
        [Champion("GreenBayPackers")] //x9
        [ChampionshipLoser("ClevelandBrowns")]
        public class NFL { }
    }

    [YearRange(1966, 1967)]
    [RegularSeasonGameCount(14)]
    public class v047
    {
        /// <summary>
        /// 1967-01-15 Green Bay Packers 35 vs 10 Kansas City Chiefs
        /// </summary>
        [Champion("GreenBayPackers")] //x10
        [ChampionshipLoser("KansasCityChiefs")]
        [SuperBowlNumber(1)]
        public class SuperBowl
        {
            /// <summary>
            /// 1967-01-01 Kansas City Chiefs 31 at 7 Buffalo Bills
            /// </summary>
            [Champion("KansasCityChiefs")]
            [ChampionshipLoser("BuffaloBills")]
            public class AFL { }

            /// <summary>
            /// 1967-01-01 Green Bay Packers 34 at 27 Dallas Cowboys
            /// </summary>
            [Champion("GreenBayPackers")]
            [ChampionshipLoser("DallasCowboys")]
            public class NFL { }
        }
    }

    [YearRange(1967, 1968)]
    [RegularSeasonGameCount(14)]
    public class v049
    {
        /// <summary>
        /// 1968-01-14 Green Bay Packers 33 vs 14 Oakland Raiders
        /// </summary>
        [Champion("GreenBayPackers")] //x11
        [ChampionshipLoser("OaklandRaiders")]
        [SuperBowlNumber(2)]
        public class SuperBowl
        {
            /// <summary>
            /// 1967-12-31 Houston Oilers 7 at 40 Oakland Raiders
            /// </summary>
            [Champion("OaklandRaiders")]
            [ChampionshipLoser("HoustonOilers")]
            public class AFL { }
            /// <summary>
            /// 1967-12-31 Dallas Cowboys 17 at 21 Green Bay Packers (Ice Bowl)
            /// </summary>
            [Champion("GreenBayPackers")]
            [ChampionshipLoser("DallasCowboys")]
            public class NFL { }
        }
    }

    [YearRange(1968, 1969)]
    [RegularSeasonGameCount(14)]
    public class v050
    {
        /// <summary>
        /// 1969-01-12 New York Jets 16 vs 7 Baltimore Colts
        /// </summary>
        [Champion("NewYorkJets")]
        [ChampionshipLoser("BaltimoreColts")]
        [SuperBowlNumber(3)]
        public class SuperBowl
        {
            /// <summary>
            /// 1968-12-29 Oakland Raiders 23 at 27 New York Jets
            /// </summary>
            [Champion("NewYorkJets")]
            [ChampionshipLoser("OaklandRaiders")]
            public class AFL { }
            /// <summary>
            /// 1968-12-29 Baltimore Colts 34 at 0 Cleveland Browns
            /// </summary>
            [Champion("BaltimoreColts")]
            [ChampionshipLoser("ClevelandBrowns")]
            public class NFL { }
        }
    }

    [YearRange(1969, 1970)]
    [RegularSeasonGameCount(14)]
    public class v051
    {
        /// <summary>
        /// 1970-01-11 Kansas City Chiefs 23 vs 7 Minnesota Vikings
        /// </summary>
        [Champion("KansasCityChiefs")] //x2
        [ChampionshipLoser("MinnesotaVikings")]
        [SuperBowlNumber(4)]
        public class SuperBowl
        {
            /// <summary>
            /// 1970-01-04 Kansas City Chiefs 17 at 7 Oakland Raiders
            /// </summary>
            [Champion("KansasCityChiefs")]
            [ChampionshipLoser("OaklandRaiders")]
            public class AFL { }
            /// <summary>
            /// 1970-01-04 Cleveland Browns 7 at 27 Minnesota Vikings
            /// </summary>
            [Champion("MinnesotaVikings")]
            [ChampionshipLoser("ClevelandBrowns")]
            public class NFL { }
        }
    }

    /// <summary>
    /// first season after the NFL/NFL merger
    /// </summary>
    [YearRange(1970, 1971)]
    [RegularSeasonGameCount(14)]
    public class v052
    {
        /// <summary>
        /// 1971-01-17 Baltimore Colts 16 vs 13 Dallas Cowboys
        /// </summary>
        [Champion("BaltimoreColts")] //x3
        [ChampionshipLoser("DallasCowboys")]
        [SuperBowlNumber(5)]
        public class NFL
        {
            /// <summary>
            /// 1971-01-03 Oakland Raiders 17 at 27 Baltimore Colts
            /// </summary>
            [Champion("BaltimoreColts")]
            [ChampionshipLoser("OaklandRaiders")]
            public class AFC { }
            /// <summary>
            /// 1971-01-03 Dallas Cowboys 17 at 10 San Francisco 49ers
            /// </summary>
            [Champion("DallasCowboys")]
            [ChampionshipLoser("SanFrancisco49ers")]
            public class NFC { }
        }
    }

    [YearRange(1971, 1972)]
    [RegularSeasonGameCount(14)]
    public class v053
    {
        /// <summary>
        /// 1972-01-16 Dallas Cowboys 24 vs 3 Miami Dolphins
        /// </summary>
        [SuperBowlNumber(6)]
        [Champion("DallasCowboys")]
        [ChampionshipLoser("MiamiDolphins")]
        public class NFL
        {
            /// <summary>
            /// 1972-01-02 San Francisco 49ers 3 at 14 Dallas Cowboys
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1972-01-02 Baltimore Colts 0 at 21 Miami Dolphins
            /// </summary>
            public class NFC { }
        }
    }

    /// <summary>
    /// Miami Dolphins undefeated season
    /// </summary>
    [YearRange(1972, 1973)]
    [RegularSeasonGameCount(14)]
    public class v054
    {
        /// <summary>
        /// 1973-01-14 Miami Dolphins 14 vs 7 Washington Redskins
        /// </summary>
        [Champion("MiamiDolphins")]
        [ChampionshipLoser("WashingtonRedskins")]
        [SuperBowlNumber(7)]
        public class NFL
        {
            /// <summary>
            /// 1972-12-31 Miami Dolphins 21 at 17 Pittsburgh Steelers
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1972-12-31 Dallas Cowboys 3 at 26 Washington Redskins
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1973, 1974)]
    [RegularSeasonGameCount(14)]
    public class v055
    {
        /// <summary>
        /// 1974-01-13 Miami Dolphins 24 vs 7 Minnesota Vikings
        /// </summary>
        [Champion("MiamiDolphins")] //x2
        [ChampionshipLoser("MinnesotaVikings")]
        [SuperBowlNumber(8)]
        public class NFL
        {
            /// <summary>
            /// 1973-12-30 Oakland Raiders 10 at 27 Miami Dolphins
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1973-12-30 Minnesota Vikings 27 at 10 Dallas Cowboys
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1974, 1975)]
    [RegularSeasonGameCount(14)]
    public class v056
    {
        /// <summary>
        /// 1975-01-12 Pittsburgh Steelers 16 vs 6 Minnesota Vikings
        /// </summary>
        [Champion("PittsburghSteelers")]
        [ChampionshipLoser("MinnesotaVikings")]
        [SuperBowlNumber(9)]
        public class NFL
        {
            /// <summary>
            /// 1974-12-29 Pittsburgh Steelers 24 at 13 Oakland Raiders
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1974-12-29 Los Angeles Rams 10 at 14 Minnesota Vikings
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1975, 1976)]
    [RegularSeasonGameCount(14)]
    public class v057
    {
        /// <summary>
        /// 1976-01-18 Pittsburgh Steelers 21 vs 17 Dallas Cowboys
        /// </summary>
        [Champion("PittsburghSteelers")] //x2
        [ChampionshipLoser("DallasCowboys")]
        [SuperBowlNumber(10)]
        public class NFL
        {
            /// <summary>
            /// 1976-01-04 Oakland Raiders 10 at 16 Pittsburgh Steelers
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1976-01-04 Dallas Cowboys 37 at 7 Los Angeles Rams
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1976, 1977)]
    [RegularSeasonGameCount(14)]
    public class v058
    {
        /// <summary>
        /// 1977-01-09 Oakland Raiders 32 vs 14 Minnesota Vikings
        /// </summary>
        [SuperBowlNumber(11)]
        [Champion("OaklandRaiders")]
        [ChampionshipLoser("MinnesotaVikings")]
        public class NFL
        {
            /// <summary>
            /// 1976-12-26 Pittsburgh Steelers 7 at 24 Oakland Raiders
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1976-12-26 Los Angeles Rams 13 at 24 Minnesota Vikings
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1977, 1978)]
    [RegularSeasonGameCount(14)]
    public class v059
    {
        /// <summary>
        /// 1978-01-15 Dallas Cowboys 27 vs 10 Denver Broncos
        /// </summary>
        [SuperBowlNumber(12)]
        [Champion("DallasCowboys")] //x2
        [ChampionshipLoser("DenverBroncos")]
        public class NFL
        {
            /// <summary>
            /// 1978-01-01 Oakland Raiders 17 at 20 Denver Broncos
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1978-01-01 Minnesota Vikings 6 at 23 Dallas Cowboys
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1978, 1979)]
    [RegularSeasonGameCount(16)]
    public class v060
    {
        /// <summary>
        /// 1979-01-21 Pittsburgh Steelers 35 vs 31 Dallas Cowboys
        /// </summary>
        [SuperBowlNumber(13)]
        [Champion("PittsburghSteelers")] //x3
        [ChampionshipLoser("DallasCowboys")]
        public class NFL
        {
            /// <summary>
            /// 1979-01-07 Houston Oilers 5 at 34 Pittsburgh Steelers
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1979-01-07 Dallas Cowboys 28 at 0 Los Angeles Rams
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1979, 1980)]
    [RegularSeasonGameCount(16)]
    public class v061
    {
        /// <summary>
        /// 1980-01-20 Pittsburgh Steelers 31 vs 19 Los Angeles Rams
        /// </summary>
        [SuperBowlNumber(14)]
        [Champion("PittsburghSteelers")] //x4
        [ChampionshipLoser("LosAngelesRams")]
        public class NFL
        {
            /// <summary>
            /// 1980-01-06 Houston Oilers 13 at 27 Pittsburgh Steelers
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1980-01-06 Los Angeles Rams 9 at 0 Tampa Bay Buccaneers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1980, 1981)]
    [RegularSeasonGameCount(16)]
    public class v062
    {
        /// <summary>
        /// 1981-01-25 Oakland Raiders 27 vs 10 Philadelphia Eagles
        /// </summary>
        [SuperBowlNumber(15)]
        [Champion("OaklandRaiders")] //x2
        [ChampionshipLoser("PhiladelphiaEagles")]
        public class NFL
        {
            /// <summary>
            /// 1981-01-11 Oakland Raiders 34 at 27 San Diego Chargers
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1981-01-11 Dallas Cowboys 7 at 20 Philadelphia Eagles
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1981, 1982)]
    [RegularSeasonGameCount(16)]
    public class v063
    {
        /// <summary>
        /// 1982-01-24 San Francisco 49ers 26 vs 21 Cincinnati Bengals
        /// </summary>
        [SuperBowlNumber(16)]
        [Champion("SanFrancisco49ers")]
        [ChampionshipLoser("CincinnatiBengals")]
        public class NFL
        {
            /// <summary>
            /// 1982-01-10 San Diego Chargers 7 at 27 Cincinnati Bengals
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1982-01-10 Dallas Cowboys 27 at 28 San Francisco 49ers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1982, 1983)]
    [RegularSeasonGameCount(16)]
    public class v064
    {
        /// <summary>
        /// 1983-01-30 Washington Redskins 27 vs 17 Miami Dolphins
        /// </summary>
        [SuperBowlNumber(17)]
        [Champion("WashingtonRedskins")] //x3
        [ChampionshipLoser("MiamiDolphins")]
        public class NFL
        {
            /// <summary>
            /// 1983-01-23 New York Jets 0 at 14 Miami Dolphins
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1983-01-22 Dallas Cowboys 17 at 31 Washington Redskins
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1983, 1984)]
    [RegularSeasonGameCount(16)]
    public class v065
    {
        /// <summary>
        /// 1984-01-22 Los Angeles Raiders 38 vs 9 Washington Redskins
        /// </summary>
        [SuperBowlNumber(18)]
        [Champion("LosAngelesRaiders")] //x3
        [ChampionshipLoser("WashingtonRedskins")]
        public class NFL
        {
            /// <summary>
            /// 1984-01-08 Seattle Seahawks 14 at 30 Los Angeles Raiders
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1984-01-08 San Francisco 49ers 21 at 24 Washington Redskins
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1984, 1985)]
    [RegularSeasonGameCount(16)]
    public class v066
    {
        /// <summary>
        /// 1985-01-20 San Francisco 49ers 38 vs 16 Miami Dolphins
        /// </summary>
        [SuperBowlNumber(19)]
        [Champion("SanFrancisco49ers")] //x2
        [ChampionshipLoser("MiamiDolphins")]
        public class NFL
        {
            /// <summary>
            /// 1985-01-06 Pittsburgh Steelers 28 at 45 Miami Dolphins
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1985-01-06 Chicago Bears 0 at 23 San Francisco 49ers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1985, 1986)]
    [RegularSeasonGameCount(16)]
    public class v067
    {
        /// <summary>
        /// 1986-01-26 Chicago Bears 46 vs 10 New England Patriots
        /// </summary>
        [SuperBowlNumber(20)]
        [Champion("ChicagoBears")] //x9
        [ChampionshipLoser("NewEnglandPatriots")]
        public class NFL
        {
            /// <summary>
            /// 1986-01-12 New England Patriots 31 at 14 Miami Dolphins
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1986-01-12 Los Angeles Rams 0 at 24 Chicago Bears
            /// </summary>
            public class NFC { }
        }
    }


    [YearRange(1986, 1987)]
    [RegularSeasonGameCount(16)]
    public class v068
    {
        /// <summary>
        /// 1987-01-25 New York Giants 39 vs 20 Denver Broncos
        /// </summary>
        [SuperBowlNumber(21)]
        [Champion("NewYorkGiants")] //x5
        [ChampionshipLoser("DenverBroncos")]
        public class NFL
        {
            /// <summary>
            /// 1987-01-11 Denver Broncos 23 at 20 Cleveland Browns
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1987-01-11 Washington Redskins 0 at 17 New York Giants
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1987, 1988)]
    [RegularSeasonGameCount(16)]
    public class v069
    {
        /// <summary>
        /// 1988-01-31 Washington Redskins 42 vs 10 Denver Broncos
        /// </summary>
        [SuperBowlNumber(22)]
        [Champion("WashingtonRedskins")] //x4
        [ChampionshipLoser("DenverBroncos")]
        public class NFL
        {
            /// <summary>
            /// 1988-01-17 Cleveland Browns 33 at 38 Denver Broncos
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1988-01-17 Minnesota Vikings 10 at 17 Washington Redskins
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1988, 1989)]
    [RegularSeasonGameCount(16)]
    public class v070
    {
        /// <summary>
        /// 1989-01-22 San Francisco 49ers 20 vs 16 Cincinnati Bengals
        /// </summary>
        [SuperBowlNumber(23)]
        [Champion("SanFrancisco49ers")] //x3
        [ChampionshipLoser("CincinnatiBengals")]
        public class NFL
        {
            /// <summary>
            /// 1989-01-08 Buffalo Bills 10 at 21 Cincinnati Bengals
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1989-01-08 San Francisco 49ers 28 at 3 Chicago Bears
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1989, 1990)]
    [RegularSeasonGameCount(16)]
    public class v071
    {
        /// <summary>
        /// 1990-01-28 San Francisco 49ers 55 vs 10 Denver Broncos
        /// </summary>
        [SuperBowlNumber(24)]
        [Champion("SanFrancisco49ers")] //x4
        [ChampionshipLoser("DenverBroncos")]
        public class NFL
        {
            /// <summary>
            /// 1990-01-14 Cleveland Browns 21 at 37 Denver Broncos
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1990-01-14 Los Angeles Rams 3 at 30 San Francisco 49ers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1990, 1991)]
    [RegularSeasonGameCount(16)]
    public class v072
    {
        /// <summary>
        /// 1991-01-27 New York Giants 20 vs 19 Buffalo Bills
        /// </summary>
        [SuperBowlNumber(25)]
        [Champion("NewYorkGiants")]
        [ChampionshipLoser("BuffaloBills")]
        public class NFL
        {
            /// <summary>
            /// 1991-01-20 Los Angeles Raiders 3 at 51 Buffalo Bills
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1991-01-20 New York Giants 15 at 13 San Francisco 49ers
            /// </summary>
            public class NFC { }
        }
    }


    [YearRange(1991, 1992)]
    [RegularSeasonGameCount(16)]
    public class v073
    {
        /// <summary>
        /// 1992-01-26 Washington Redskins 37 vs 24 Buffalo Bills
        /// </summary>
        [SuperBowlNumber(26)]
        [Champion("WashingtonRedskins")] //x5
        [ChampionshipLoser("BuffaloBills")]
        public class NFL
        {
            /// <summary>
            /// 1992-01-12 Denver Broncos 7 at 10 Buffalo Bills
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1992-01-12 Detroit Lions 10 at 41 Washington Redskins
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1992, 1993)]
    [RegularSeasonGameCount(16)]
    public class v074
    {
        /// <summary>
        /// 1993-01-31 Dallas Cowboys 52 vs 17 Buffalo Bills
        /// </summary>
        [SuperBowlNumber(27)]
        [Champion("DallasCowboys")] //x3
        [ChampionshipLoser("BuffaloBills")]
        public class NFL
        {
            /// <summary>
            /// 1993-01-17 Buffalo Bills 29 at 10 Miami Dolphins
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1993-01-17 Dallas Cowboys 30 at 20 San Francisco 49ers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1993, 1994)]
    [RegularSeasonGameCount(16)]
    public class v075
    {
        /// <summary>
        /// 1994-01-30 Dallas Cowboys 30 vs 13 Buffalo Bills
        /// </summary>
        [SuperBowlNumber(28)]
        [Champion("DallasCowboys")] //x4
        [ChampionshipLoser("BuffaloBills")]
        public class NFL
        {
            /// <summary>
            /// 1994-01-23 Kansas City Chiefs 13 at 30 Buffalo Bills
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1994-01-23 San Francisco 49ers 21 at 38 Dallas Cowboys
            /// </summary>
            public class NFC { }
        }
    }


    [YearRange(1994, 1995)]
    [RegularSeasonGameCount(16)]
    public class v076
    {
        /// <summary>
        /// 1995-01-29 San Francisco 49ers 49 vs 26 San Diego Chargers
        /// </summary>
        [SuperBowlNumber(29)]
        [Champion("SanFrancisco49ers")] //x5
        [ChampionshipLoser("SanDiegoChargers")]
        public class NFL
        {
            /// <summary>
            /// 1995-01-15 San Diego Chargers 17 at 13 Pittsburgh Steelers
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1995-01-15 Dallas Cowboys 28 at 38 San Francisco 49ers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1995, 1996)]
    [RegularSeasonGameCount(16)]
    public class v077
    {
        /// <summary>
        /// 1996-01-28 Dallas Cowboys 27 vs 17 Pittsburgh Steelers
        /// </summary>
        [SuperBowlNumber(30)]
        [Champion("DallasCowboys")] //x5
        [ChampionshipLoser("PittsburghSteelers")]
        public class NFL
        {
            /// <summary>
            /// 1996-01-14 Indianapolis Colts 16 at 20 Pittsburgh Steelers
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1996-01-14 Green Bay Packers 27 at 38 Dallas Cowboys
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1996, 1997)]
    [RegularSeasonGameCount(16)]
    public class v078
    {
        /// <summary>
        /// 1997-01-26 Green Bay Packers 35 vs 21 New England Patriots
        /// </summary>
        [SuperBowlNumber(31)]
        [Champion("GreenBayPackers")] //x12
        [ChampionshipLoser("NewEnglandPatriots")]
        public class NFL
        {
            /// <summary>
            /// 1997-01-12 Jacksonville Jaguars 6 at 20 New England Patriots
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1997-01-12 Carolina Panthers 13 at 30 Green Bay Packers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1997, 1998)]
    [RegularSeasonGameCount(16)]
    public class v079
    {
        /// <summary>
        /// 1998-01-25 Denver Broncos 31 vs 24 Green Bay Packers
        /// </summary>
        [SuperBowlNumber(32)]
        [Champion("DenverBroncos")]
        [ChampionshipLoser("GreenBayPackers")]
        public class NFL
        {
            /// <summary>
            /// 1998-01-11 Denver Broncos 24 at 21 Pittsburgh Steelers
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1998-01-11 Green Bay Packers 23 at 10 San Francisco 49ers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1998, 1999)]
    [RegularSeasonGameCount(16)]
    public class v080
    {
        /// <summary>
        /// 1999-01-31 Denver Broncos 34 vs 19 Atlanta Falcons
        /// </summary>
        [SuperBowlNumber(33)]
        [Champion("DenverBroncos")] //x2
        [ChampionshipLoser("AtlantaFalcons")]
        public class NFL
        {
            /// <summary>
            /// 1999-01-17 New York Jets 10 at 23 Denver Broncos
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 1999-01-17 Atlanta Falcons 30 at 27 Minnesota Vikings
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(1999, 2000)]
    [RegularSeasonGameCount(16)]
    public class v081
    {
        /// <summary>
        /// 2000-01-30 St. Louis Rams 23 vs 16 Tennessee Titans
        /// </summary>
        [SuperBowlNumber(34)]
        [Champion("StLouisRams")] //x3
        [ChampionshipLoser("TennesseeTitans")]
        public class NFL
        {
            /// <summary>
            /// 2000-01-23 Tennessee Titans 33 at 14 Jacksonville Jaguars
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2000-01-23 Tampa Bay Buccaneers 6 at 11 St. Louis Rams
            /// </summary>
            public class NFC { }
        }
    }


    [YearRange(2000, 2001)]
    [RegularSeasonGameCount(16)]
    public class v082
    {
        /// <summary>
        /// 2001-01-28 Baltimore Ravens 34 vs 7 New York Giants
        /// </summary>
        [SuperBowlNumber(35)]
        [Champion("BaltimoreRavens")]
        [ChampionshipLoser("NewYorkGiants")]
        public class NFL
        {
            /// <summary>
            /// 2001-01-14 Baltimore Ravens 16 at 3 Oakland Raiders
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2001-01-14 Minnesota Vikings 0 at 41 New York Giants
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2001, 2002)]
    [RegularSeasonGameCount(16)]
    public class v083
    {
        /// <summary>
        /// 2002-02-03 New England Patriots 20 vs 17 St. Louis Rams
        /// </summary>
        [SuperBowlNumber(36)]
        [Champion("NewEnglandPatriots")]
        [ChampionshipLoser("StLouisRams")]
        public class NFL
        {
            /// <summary>
            /// 2002-01-27 New England Patriots 24 at 17 Pittsburgh Steelers
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2002-01-27 Philadelphia Eagles 24 at 29 St. Louis Rams
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2002, 2003)]
    [RegularSeasonGameCount(16)]
    public class v084
    {
        /// <summary>
        /// 2003-01-26 Tampa Bay Buccaneers 48 vs 21 Oakland Raiders
        /// </summary>
        [SuperBowlNumber(37)]
        [Champion("TampaBayBuccaneers")]
        [ChampionshipLoser("OaklandRaiders")]
        public class NFL
        {
            /// <summary>
            /// 2003-01-19 Tennessee Titans 24 at 41 Oakland Raiders
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2003-01-19 Tampa Bay Buccaneers 27 at 10 Philadelphia Eagles
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2003, 2004)]
    [RegularSeasonGameCount(16)]
    public class v085
    {
        /// <summary>
        /// 2004-02-01 New England Patriots 32 vs 29 Carolina Panthers
        /// </summary>
        [SuperBowlNumber(38)]
        [Champion("NewEnglandPatriots")] //x2
        [ChampionshipLoser("CarolinaPanthers")]
        public class NFL
        {
            /// <summary>
            /// 2004-01-18 Indianapolis Colts 14 at 24 New England Patriots
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2004-01-18 Carolina Panthers 14 at 3 Philadelphia Eagles
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2004, 2005)]
    [RegularSeasonGameCount(16)]
    public class v086
    {
        /// <summary>
        /// 2005-02-06 New England Patriots 24 vs 21 Philadelphia Eagles
        /// </summary>
        [SuperBowlNumber(39)]
        [Champion("NewEnglandPatriots")] //x3
        [ChampionshipLoser("PhiladelphiaEagles")]
        public class NFL
        {
            /// <summary>
            /// 2005-01-23 New England Patriots 41 at 27 Pittsburgh Steelers
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2005-01-23 Atlanta Falcons 10 at 27 Philadelphia Eagles
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2005, 2006)]
    [RegularSeasonGameCount(16)]
    public class v087
    {
        /// <summary>
        /// 2006-02-05 Pittsburgh Steelers 21 vs 10 Seattle Seahawks
        /// </summary>
        [SuperBowlNumber(40)]
        [Champion("PittsburghSteelers")] //x5
        [ChampionshipLoser("SeattleSeahawks")]
        public class NFL
        {
            /// <summary>
            /// 2006-01-22 Pittsburgh Steelers 34 at 17 Denver Broncos
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2006-01-22 Carolina Panthers 14 at 34 Seattle Seahawks
            /// </summary>
            public class NFC { }
        }
    }


    [YearRange(2006, 2007)]
    [RegularSeasonGameCount(16)]
    public class v088
    {
        /// <summary>
        /// 2007-02-04 Indianapolis Colts 29 vs 17 Chicago Bears
        /// </summary>
        [SuperBowlNumber(41)]
        [Champion("IndianapolisColts")] //x4
        [ChampionshipLoser("ChicagoBears")]
        public class NFL
        {
            /// <summary>
            /// 2007-01-21 New England Patriots 34 at 38 Indianapolis Colts
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2007-01-21 New Orleans Saints 14 at 39 Chicago Bears
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2007, 2008)]
    [RegularSeasonGameCount(16)]
    public class v089
    {
        /// <summary>
        /// 2008-02-03 New York Giants 17 vs 14 New England Patriots
        /// </summary>
        [SuperBowlNumber(42)]
        [Champion("NewYorkGiants")] //x7
        [ChampionshipLoser("NewEnglandPatriots")]
        public class NFL
        {
            /// <summary>
            /// 2008-01-20 San Diego Chargers 12 at 21 New England Patriots
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2008-01-20 New York Giants 23 at 20 Green Bay Packers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2008, 2009)]
    [RegularSeasonGameCount(16)]
    public class v090
    {
        /// <summary>
        /// 2009-02-01 Pittsburgh Steelers 27 vs 23 Arizona Cardinals
        /// </summary>
        [SuperBowlNumber(43)]
        [Champion("PittsburghSteelers")] //x6
        [ChampionshipLoser("ArizonaCardinals")]
        public class NFL
        {
            /// <summary>
            /// 2009-01-18 Baltimore Ravens 14 at 23 Pittsburgh Steelers
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2009-01-18 Philadelphia Eagles 25 at 32 Arizona Cardinals
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2009, 2010)]
    [RegularSeasonGameCount(16)]
    public class v091
    {
        /// <summary>
        /// 2010-02-07 New Orleans Saints 31 vs 17 Indianapolis Colts
        /// </summary>
        [SuperBowlNumber(44)]
        [Champion("NewOrleansSaints")]
        [ChampionshipLoser("IndianapolisColts")]
        public class NFL
        {
            /// <summary>
            /// 2010-01-24 New York Jets 17 at 30 Indianapolis Colts
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2010-01-24 Minnesota Vikings 28 at 31 New Orleans Saints
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2010, 2011)]
    [RegularSeasonGameCount(16)]
    public class v092
    {
        /// <summary>
        /// 2011-02-06 Green Bay Packers 31 vs 25 Pittsburgh Steelers
        /// </summary>
        [SuperBowlNumber(45)]
        [Champion("GreenBayPackers")] //x13
        [ChampionshipLoser("PittsburghSteelers")]
        public class NFL
        {
            /// <summary>
            /// 2011-01-23 New York Jets 19 at 24 Pittsburgh Steelers
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2011-01-23 Green Bay Packers 21 at 14 Chicago Bears
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2011, 2012)]
    [RegularSeasonGameCount(16)]
    public class v093
    {
        /// <summary>
        /// 2012-02-05 New York Giants 21 vs 17 New England Patriots
        /// </summary>
        [SuperBowlNumber(46)]
        [Champion("NewYorkGiants")] //x8
        [ChampionshipLoser("NewEnglandPatriots")]
        public class NFL
        {
            /// <summary>
            /// 2012-01-22 Baltimore Ravens 20 at 23 New England Patriots
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2012-01-22 New York Giants 20 at 17 San Francisco 49ers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2012, 2013)]
    [RegularSeasonGameCount(16)]
    public class v094
    {
        /// <summary>
        /// 2013-02-03 Baltimore Ravens 34 vs 31 San Francisco 49ers
        /// </summary>
        [SuperBowlNumber(47)]
        [Champion("BaltimoreRavens")] //x2
        [ChampionshipLoser("SanFrancisco49ers")]
        public class NFL
        {
            /// <summary>
            /// 2013-01-20 Baltimore Ravens 28 at 13 New England Patriots
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2013-01-20 San Francisco 49ers 28 at 24 Atlanta Falcons
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2013, 2014)]
    [RegularSeasonGameCount(16)]
    public class v095
    {
        /// <summary>
        /// 2014-02-02 Seattle Seahawks 43 vs 8 Denver Broncos
        /// </summary>
        [SuperBowlNumber(48)]
        [Champion("SeattleSeahawks")]
        [ChampionshipLoser("DenverBroncos")]
        public class NFL
        {
            /// <summary>
            /// 2014-01-19 New England Patriots 16 at 26 Denver Broncos
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2014-01-19 San Francisco 49ers 17 at 23 Seattle Seahawks
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2014, 2015)]
    [RegularSeasonGameCount(16)]
    public class v096
    {
        /// <summary>
        /// 2015-02-01 New England Patriots 28 vs 24 Seattle Seahawks
        /// </summary>
        [SuperBowlNumber(49)]
        [Champion("NewEnglandPatriots")] //x4
        [ChampionshipLoser("SeattleSeahawks")]
        public class NFL
        {
            /// <summary>
            /// 2015-01-18 Indianapolis Colts 7 at 45 New England Patriots
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2015-01-18 Green Bay Packers 22 at 28 Seattle Seahawks
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2015, 2016)]
    [RegularSeasonGameCount(16)]
    public class v097
    {
        /// <summary>
        /// 2016-02-07 Denver Broncos 24 vs 10 Carolina Panthers
        /// </summary>
        [SuperBowlNumber(50)]
        [Champion("DenverBroncos")] //x3
        [ChampionshipLoser("CarolinaPanthers")]
        public class NFL
        {
            /// <summary>
            /// 2016-01-24 New England Patriots 18 at 20 Denver Broncos
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2016-01-24 Arizona Cardinals 15 at 49 Carolina Panthers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2016, 2017)]
    [RegularSeasonGameCount(16)]
    public class v098
    {
        /// <summary>
        /// 2017-02-05 New England Patriots 34 vs 28 Atlanta Falcons
        /// </summary>
        [SuperBowlNumber(51)]
        [Champion("NewEnglandPatriots")] //x5
        [ChampionshipLoser("AtlantaFalcons")]
        public class NFL
        {
            /// <summary>
            /// 2017-01-22 Pittsburgh Steelers 17 at 36 New England Patriots
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2017-01-22 Green Bay Packers 21 at 44 Atlanta Falcons
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2017, 2018)]
    [RegularSeasonGameCount(16)]
    public class v099
    {
        /// <summary>
        /// 2018-02-04 Philadelphia Eagles 41 vs 33 New England Patriots
        /// </summary>
        [SuperBowlNumber(52)]
        [Champion("PhiladelphiaEagles")] //x4
        [ChampionshipLoser("NewEnglandPatriots")]
        public class NFL
        {
            /// <summary>
            /// 2018-01-21 Jacksonville Jaguars 20 at 24 New England Patriots
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2018-01-21 Minnesota Vikings 7 at 38 Philadelphia Eagles
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2018, 2019)]
    [RegularSeasonGameCount(16)]
    public class v100
    {
        /// <summary>
        /// 2019-02-03 New England Patriots 13 vs 3 Los Angeles Rams
        /// </summary>
        [SuperBowlNumber(53)]
        [Champion("NewEnglandPatriots")] //x6
        [ChampionshipLoser("LosAngelesRams")]
        public class NFL
        {
            /// <summary>
            /// 2019-01-20 Los Angeles Rams 26 at 23 New Orleans Saints
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2019-01-20 New England Patriots 37 at 31 Kansas City Chiefs
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2019, 2020)]
    [RegularSeasonGameCount(16)]
    public class v101
    {
        /// <summary>
        /// 2020-02-02 Kansas City Chiefs 31 vs 20 San Francisco 49ers
        /// </summary>
        [SuperBowlNumber(54)]
        [Champion("Kansas City Chiefs")] //x3
        [ChampionshipLoser("San Francisco 49ers")]
        public class NFL
        {
            /// <summary>
            /// 2020-01-19 Tennessee Titans 24 at 35 Kansas City Chiefs
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2020-01-19 Green Bay Packers 20 at 37 San Francisco 49ers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2020, 2021)]
    [RegularSeasonGameCount(16)]
    public class v102
    {
        /// <summary>
        /// 2021-02-07 Tampa Bay Buccaneers 31 vs 9 Kansas City Chiefs
        /// </summary>
        [SuperBowlNumber(55)]
        [Champion("TampaBayBuccaneers")] //x2
        [ChampionshipLoser("KansasCityChiefs")]
        public class NFL
        {
            /// <summary>
            /// 2021-01-24 Buffalo Bills 24 at 38 Kansas City Chiefs
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2021-01-24 Tampa Bay Buccaneers 31 at 26 Green Bay Packers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2021, 2022)]
    [RegularSeasonGameCount(17)]
    public class v103
    {
        /// <summary>
        /// 2022-02-13 Los Angeles Rams 23 vs 20 Cincinnati Bengals
        /// </summary>
        [SuperBowlNumber(56)]
        [Champion("LosAngelesRams")] //x4
        [ChampionshipLoser("CincinnatiBengals")]
        public class NFL
        {
            /// <summary>
            /// 2022-01-30 Cincinnati Bengals 27 at 24 Kansas City Chiefs
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2022-01-30 San Francisco 49ers 17 at 20 Los Angeles Rams
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2022, 2023)]
    [RegularSeasonGameCount(17)]
    public class v104
    {
        /// <summary>
        /// 2023-02-12 Kansas City Chiefs 38 vs 35 Philadelphia Eagles
        /// </summary>
        [SuperBowlNumber(57)]
        [Champion("KansasCityChiefs")] //x4
        [ChampionshipLoser("PhiladelphiaEagles")]
        public class NFL
        {
            /// <summary>
            /// 2023-01-29 Cincinnati Bengals 20 at 23 Kansas City Chiefs
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2023-01-29 San Francisco 49ers 7 at 31 Philadelphia Eagles
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2023, 2024)]
    [RegularSeasonGameCount(17)]
    public class v105
    {
        /// <summary>
        /// 2024-02-11 Kansas City Chiefs 25 vs 22 San Francisco 49ers
        /// </summary>
        [SuperBowlNumber(58)]
        [Champion("KansasCityChiefs")] //x5
        [ChampionshipLoser("SanFrancisco49ers")]
        public class NFL
        {
            /// <summary>
            /// 2024-01-28 Kansas City Chiefs 17 at 10 Baltimore Ravens
            /// </summary>
            public class AFC { }
            /// <summary>
            /// 2024-01-28 Detroit Lions 31 at 34 San Francisco 49ers
            /// </summary>
            public class NFC { }
        }
    }

    [YearRange(2024, 2025)]
    [RegularSeasonGameCount(17)]
    public class v106
    {
        public class NFL
        {
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

                [AlsoKnownAs("Taylor Swift Bowl")]
                [Number(59)]
                [RomanNumeral("LIX")]
                [Location("New Orleans, Louisiana")]
                [YearDate(2025, (int)Months.February, 9)]
                [GamePointsWinnerAndLoserScore(40, 22)]
                [ScorigamiLevel(2)]
                [Winner("PhiladelphiaEagles")] //5th NFL championship
                [MVP("JalenHurts")]
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
    }
}
