using Existence.Earth.Alphabet;
using Existence.Time;
using System;

namespace Existence.Earth.Sports.Baseball.American
{
    public enum MajorLeagueBaseballFranchises
    {
        /// <summary>
        /// a 1961 American League expansion team: Los Angeles Angels from 1961 to 1964, California Angels from 1965 to
        /// 1996, Anaheim Angels from 1997 to 2004, Los Angeles Angels of Anaheim from 2005 to 2015, and Los Angeles Angels
        /// from 2016 on. The team has played in Anaheim since 1966
        /// </summary>
        AnaheimAngels,
        /// <summary>
        /// started in the National Association as the Boston Red Stockings in 1871, and joined the National League at its
        /// founding in 1876. Boston Red Stockings (or Red Caps) from 1876 to 1882, Boston Beaneaters from 1883 to 1906,
        /// Boston Doves from 1907 to 1910, Boston Rustlers in 1911, Boston Braves from 1912 to 1935, Boston Bees from 1936
        /// to 1940, Boston Braves again from 1941 to 1952, Milwaukee Braves from 1953 to 1965, and Atlanta Braves from 1966
        /// on
        /// </summary>
        AtlantaBraves,
        /// <summary>
        /// an American League charter member in 1901: Milwaukee Brewers in 1901, St. Louis Browns from 1902 to 1953, and
        /// Baltimore Orioles from 1954 on. Unrelated to the National League's Baltimore Orioles, who folded after 1899
        /// </summary>
        BaltimoreOriolesAmericanLeague,
        /// <summary>
        /// an American League charter member in 1901 with John McGraw as player-manager. In 1902 McGraw jumped to the
        /// National League's New York Giants, and the Giants and Cincinnati Reds gained control of the club and took its
        /// best players; the American League restocked it with players on loan from its other teams for the rest of the
        /// season. The American League replaced it with a new New York team, which became the Yankees, in 1903, though few
        /// players carried over
        /// </summary>
        [FranchiseFoldedAfterSeason(1902)]
        BaltimoreOriolesAmericanLeagueOriginal,
        /// <summary>
        /// Baltimore Orioles in the American Association from 1882 to 1891, apart from part of 1890 in the minor league
        /// Atlantic Association, then in the National League from 1892 on when the American Association folded. Under
        /// manager Ned Hanlon, won National League pennants from 1894 to 1896 and the Temple Cup in 1896 and 1897. Its
        /// owners bought into Brooklyn in 1899 and moved Hanlon and the best players there, and the club was dropped after
        /// 1899 when the National League cut from 12 teams to 8
        /// </summary>
        [FranchiseFoldedAfterSeason(1899)]
        BaltimoreOriolesNationalLeague,
        /// <summary>
        /// an American League charter member in 1901 that has always played in Boston: Boston Americans from 1901 to 1907,
        /// and Boston Red Sox from 1908 on
        /// </summary>
        BostonRedSox,
        /// <summary>
        /// a National League charter member in 1876: Chicago White Stockings from 1876 to 1889, Chicago Colts from 1890 to
        /// 1897, Chicago Orphans from 1898 to 1902, and Chicago Cubs from 1903 on. Has always played in Chicago, on the
        /// North Side at Wrigley Field from 1916 on. ChicagoNorthCubs is the franchise's name because Chicago has two
        /// franchises, and the side of the city tells them apart
        /// </summary>
        ChicagoNorthCubs,
        /// <summary>
        /// a Western League minor league team that Charles Comiskey bought in Sioux City in 1894 and moved to St. Paul for
        /// 1895 to 1899, then moved to Chicago's South Side in 1900, the year the Western League renamed itself the
        /// American League, a major league from 1901. Chicago White Stockings at first, shortened to Chicago White Sox by
        /// 1904. Played at South Side Park from 1900 to 1910, Comiskey Park from 1910 to 1990, and from 1991 on at the new
        /// ballpark across the street (later U.S. Cellular Field, Guaranteed Rate Field, and Rate Field), apart from 20 home
        /// games in Milwaukee in 1968 and 1969. ChicagoSouthWhiteSox is the franchise's name because Chicago has two
        /// franchises, and the side of the city tells them apart
        /// </summary>
        ChicagoSouthWhiteSox,
        /// <summary>
        /// Cincinnati Red Stockings in the American Association from 1882 to 1889, then Cincinnati Reds after joining the
        /// National League in 1890. Officially the Cincinnati Redlegs for most of the 1950s, through 1958
        /// </summary>
        CincinnatiReds,
        /// <summary>
        /// names since the American League became a major league in 1901: Cleveland Bluebirds (or Blues) in 1901,
        /// Cleveland Bronchos in 1902, Cleveland Naps (after Nap Lajoie) from 1903 to 1914, Cleveland Indians from 1915 to
        /// 2021, and Cleveland Guardians from 2022 on. ClevelandIndiansAmericanLeague is the franchise's name because it
        /// was the name for the bulk of the franchise's early history and no team will use the Indians name going forward
        /// because of the negative connotations associated with it. The franchise has always played in Cleveland, and is
        /// unrelated to the National League's Cleveland Spiders, who folded after 1899
        /// </summary>
        ClevelandIndiansAmericanLeague,
        /// <summary>
        /// Cleveland Blues in the American Association in 1887 and 1888, then Cleveland Spiders in the National League from
        /// 1889 on, at League Park on the East Side from 1891. Won the Temple Cup in 1895. Its owners, the Robisons, bought
        /// the St. Louis Browns (later the Cardinals) in 1899 and moved Cy Young and the best players there; the 1899
        /// Spiders went 20-134, the worst record in major league history, and the club was dropped after 1899 when the
        /// National League cut from 12 teams to 8
        /// </summary>
        [FranchiseFoldedAfterSeason(1899)]
        ClevelandSpidersNationalLeague,
        /// <summary>
        /// a 1961 American League expansion team: Washington Senators from 1961 to 1971, at Griffith Stadium in 1961 and
        /// D.C. Stadium (renamed RFK Stadium in 1968) from 1962 to 1971, then Texas Rangers from 1972 on in Arlington, at
        /// Arlington Stadium from 1972 to 1993, The Ballpark in Arlington (later Globe Life Park) from 1994 to 2019, and
        /// Globe Life Field from 2020 on. Unrelated to the 1890s National League Washington Senators and to the original
        /// American League Washington Senators, who became the Minnesota Twins. DallasFortWorthRangers is the franchise's
        /// name because Arlington is in the Dallas-Fort Worth metro area, between the two cities
        /// </summary>
        DallasFortWorthRangers,
        /// <summary>
        /// a 1993 National League expansion team that has always been the Colorado Rockies and has always played in
        /// Denver: at Mile High Stadium in 1993 and 1994, and at Coors Field from 1995 on. DenverRockies is the
        /// franchise's name because it names the team's city rather than its state
        /// </summary>
        DenverRockies,
        /// <summary>
        /// an American League charter member in 1901 that has always been the Detroit Tigers
        /// </summary>
        DetroitTigers,
        /// <summary>
        /// a 1962 National League expansion team that has always played in Houston: Houston Colt .45s from 1962 to 1964,
        /// and Houston Astros from 1965 on. Moved from the National League to the American League in 2013
        /// </summary>
        HoustonAstros,
        /// <summary>
        /// a 1969 American League expansion team that has always been the Kansas City Royals
        /// </summary>
        KansasCityRoyals,
        /// <summary>
        /// Louisville Eclipse in the American Association from 1882 to 1884 and Louisville Colonels from 1885 on, winning
        /// the 1890 American Association pennant, then in the National League from 1892 when the American Association
        /// folded. Its owner, Barney Dreyfuss, bought into Pittsburgh and moved Honus Wagner, Fred Clarke, and the best
        /// players there, and the club was dropped after 1899 when the National League cut from 12 teams to 8. Unrelated
        /// to the Louisville Grays, a National League team in 1876 and 1877
        /// </summary>
        [FranchiseFoldedAfterSeason(1899)]
        LouisvilleColonels,
        /// <summary>
        /// a 1993 National League expansion team: Florida Marlins from 1993 to 2011, and Miami Marlins from 2012 on
        /// </summary>
        MiamiMarlins,
        /// <summary>
        /// started as the Seattle Pilots, a 1969 American League expansion team, then moved to Milwaukee just before the
        /// 1970 season and became the Milwaukee Brewers. The name has been unchanged since, though the team moved from the
        /// American League to the National League in 1998
        /// </summary>
        MilwaukeeBrewers,
        /// <summary>
        /// an American League charter member in 1901 as the Washington Senators (officially the Washington Nationals for
        /// much of that time), then moved to Minnesota and became the Minnesota Twins in 1961, named for the Twin Cities of
        /// Minneapolis and St. Paul. Played at Metropolitan Stadium in Bloomington from 1961 to 1981, then in Minneapolis
        /// at the Metrodome from 1982 to 2009 and Target Field from 2010 on. Unrelated to the 1890s National League
        /// Washington Senators and to the 1961 American League expansion Washington Senators, who became the Texas Rangers
        /// </summary>
        MinneapolisTwins,
        /// <summary>
        /// a 1969 National League expansion team and the first major league team in Canada: Montreal Expos from 1969 to
        /// 2004, at Jarry Park from 1969 to 1976 and Olympic Stadium from 1977 to 2004, with 22 home games a season at
        /// Hiram Bithorn Stadium in San Juan, Puerto Rico in 2003 and 2004. Washington Nationals from 2005 on, at RFK
        /// Stadium from 2005 to 2007 and Nationals Park from 2008 on
        /// </summary>
        MontrealExpos,
        /// <summary>
        /// New York Highlanders at Hilltop Park in Manhattan from 1903 to 1912, then New York Yankees from 1913 on: at the
        /// Polo Grounds in Manhattan as the Giants' tenants from 1913 to 1922, at Yankee Stadium in the Bronx from 1923 to
        /// 1973, at Shea Stadium in Queens during Yankee Stadium's renovation in 1974 and 1975, back at the renovated Yankee
        /// Stadium from 1976 to 2008, and at the new Yankee Stadium from 2009 on. The team took the place of the American
        /// League's 1901-1902 Baltimore Orioles, which some histories count as the franchise's start, but it's generally
        /// counted from 1903. The borough tells it apart from New York City's other franchises
        /// </summary>
        NewYorkCityBronxYankees,
        /// <summary>
        /// started in Brooklyn in the American Association in 1884 and joined the National League in 1890. The Brooklyn
        /// team went by a series of names: Atlantics in 1884, Grays from 1885 to 1887, Bridegrooms from 1888 to 1890,
        /// Grooms from 1891 to 1895, Bridegrooms again from 1896 to 1898, Superbas from 1899 to 1910, Dodgers from 1911 to
        /// 1913, Robins from 1914 to 1931, and Dodgers again from 1932 to 1957. Los Angeles Dodgers from 1958 on.
        /// </summary>
        NewYorkCityBrooklynDodgers,
        /// <summary>
        /// a 1962 National League expansion team that has always been the New York Mets, created after the Giants and
        /// Dodgers left for California: at the Polo Grounds in Manhattan in 1962 and 1963, Shea Stadium in Queens from 1964
        /// to 2008, and Citi Field in Queens from 2009 on. The borough tells it apart from New York City's other franchises
        /// </summary>
        NewYorkCityQueensMets,
        /// <summary>
        /// Philadelphia Athletics from 1901 to 1954, Kansas City Athletics from 1955 to 1967, Oakland Athletics from 1968
        /// to 2024, and Athletics (no city) from 2025 on, playing temporarily in West Sacramento while awaiting a move to
        /// Las Vegas. OaklandAthletics is the franchise's name because Philadelphia was taken by the Phillies
        /// </summary>
        OaklandAthletics,
        /// <summary>
        /// joined the National League in 1883 and has always played in Philadelphia: officially the Philadelphia Quakers
        /// through 1889, though also called the Phillies from the start, and Philadelphia Phillies from 1890 on
        /// </summary>
        PhiladelphiaPhillies,
        /// <summary>
        /// a 1998 National League expansion team that has always been the Arizona Diamondbacks and has always played in
        /// Phoenix, at the ballpark that opened as Bank One Ballpark and was renamed Chase Field in 2005.
        /// PhoenixDiamondbacks is the franchise's name because it names the team's city rather than its state
        /// </summary>
        PhoenixDiamondbacks,
        /// <summary>
        /// Pittsburgh Alleghenys in the American Association from 1882 to 1886 and in the National League from 1887 to
        /// 1890, then Pittsburgh Pirates from 1891 on
        /// </summary>
        PittsburghPirates,
        /// <summary>
        /// a 1969 National League expansion team that has always been the San Diego Padres
        /// </summary>
        SanDiegoPadres,
        /// <summary>
        /// joined the National League in 1883 as the New York Gothams, New York Giants from 1885 to 1957, and San
        /// Francisco Giants from 1958 on
        /// </summary>
        SanFranciscoGiants,
        /// <summary>
        /// a 1977 American League expansion team that has always been the Seattle Mariners. Unrelated to the Seattle
        /// Pilots, who became the Milwaukee Brewers
        /// </summary>
        SeattleMariners,
        /// <summary>
        /// St. Louis Brown Stockings in the American Association in 1882, St. Louis Browns from 1883 (joining the National
        /// League in 1892) to 1898, St. Louis Perfectos in 1899, and St. Louis Cardinals from 1900 on. Unrelated to the
        /// American League's St. Louis Browns (1902-1953), who became the Baltimore Orioles
        /// </summary>
        StLouisCardinals,
        /// <summary>
        /// Tampa Bay Devil Rays from the franchise's 1998 American League expansion season through 2007, and Tampa Bay Rays
        /// from 2008 on.
        /// </summary>
        TampaBayDevilRays,
        /// <summary>
        /// a 1977 American League expansion team that has always been the Toronto Blue Jays
        /// </summary>
        TorontoBlueJays,
        /// <summary>
        /// Washington Statesmen in the American Association in 1891, then Washington Senators after joining the National
        /// League in 1892 when the American Association folded. Dropped after 1899 when the National League cut from 12
        /// teams to 8. The Senators name was later used by two unrelated American League franchises, which became the
        /// Minnesota Twins and the Texas Rangers
        /// </summary>
        [FranchiseFoldedAfterSeason(1899)]
        WashingtonDCSenatorsOriginal,
    }

    public enum MinorLeagueBaseballFranchises
    {
        /// <summary>
        /// the current St. Paul Saints, founded in 1993 in the independent Northern League. Played at Midway Stadium from
        /// 1993 to 2014 and CHS Field from 2015 on, moved to the independent American Association in 2006, and became the
        /// Minnesota Twins' Triple-A affiliate in 2021, in the International League from 2022 on. Earlier St. Paul Saints
        /// teams were separate franchises: the 1884 Union Association team, a major league team that played all of its
        /// games on the road; Charles Comiskey's Western League team from 1895 to 1899, which moved to Chicago in 1900
        /// and became the Chicago White Sox; and the minor league American Association team from 1902 to 1960, which
        /// left when the Twins arrived in 1961
        /// </summary>
        StPaulSaints,
    }

    public enum MajorLeagueBaseballTeams
    {
        /// <summary>
        /// the Angels' name from 1997 to 2004, between the California Angels and the Los Angeles Angels of Anaheim
        /// </summary>
        AnaheimAngels,
        ArizonaDiamondbacks,
        Athletics,
        AtlantaBraves,
        /// <summary>
        /// used by multiple franchises: the National League team that folded after 1899, the American League team of
        /// 1901 and 1902, and the American League team that moved from St. Louis in 1954
        /// </summary>
        BaltimoreOrioles,
        /// <summary>
        /// the Boston Red Sox's name from 1901 to 1907
        /// </summary>
        BostonAmericans,
        BostonBeaneaters,
        /// <summary>
        /// the Atlanta Braves' name in Boston from 1912 to 1935 and from 1941 to 1952
        /// </summary>
        BostonBraves,
        BostonRedSox,
        BrooklynGrooms,
        /// <summary>
        /// the Los Angeles Dodgers' name in Brooklyn from 1914 to 1931, after manager Wilbert Robinson
        /// </summary>
        BrooklynRobins,
        BrooklynSuperbas,
        CaliforniaAngels,
        ChicagoColts,
        ChicagoCubs,
        ChicagoOrphans,
        ChicagoWhiteSox,
        /// <summary>
        /// the Chicago White Sox's name when they first played in Chicago, before it was shortened; also the Chicago Cubs'
        /// name from 1876 to 1889
        /// </summary>
        ChicagoWhiteStockings,
        CincinnatiReds,
        /// <summary>
        /// the Cleveland Guardians' name in 1901, the American League's first season as a major league
        /// </summary>
        ClevelandBlues,
        /// <summary>
        /// the Cleveland Guardians' name in 1902
        /// </summary>
        ClevelandBronchos,
        ClevelandGuardians,
        ClevelandIndians,
        /// <summary>
        /// the Cleveland Guardians' name from 1903 to 1914, after Nap Lajoie
        /// </summary>
        ClevelandNaps,
        ClevelandSpiders,
        ColoradoRockies,
        DetroitTigers,
        FloridaMarlins,
        HoustonAstros,
        KansasCityAthletics,
        KansasCityRoyals,
        LosAngelesAngels,
        LosAngelesAngelsOfAnaheim,
        LosAngelesDodgers,
        LouisvilleColonels,
        MiamiMarlins,
        /// <summary>
        /// used by multiple franchises: the American League team of 1901 that became the Baltimore Orioles, and the team
        /// that moved from Seattle in 1970
        /// </summary>
        MilwaukeeBrewers,
        MinnesotaTwins,
        MontrealExpos,
        NewYorkGiants,
        /// <summary>
        /// the New York Yankees' name from 1903 to 1912
        /// </summary>
        NewYorkHighlanders,
        NewYorkMets,
        NewYorkYankees,
        OaklandAthletics,
        PhiladelphiaAthletics,
        PhiladelphiaPhillies,
        PittsburghPirates,
        SanDiegoPadres,
        SanFranciscoGiants,
        SeattleMariners,
        /// <summary>
        /// the 1969 American League expansion team that moved to Milwaukee in 1970 and became the Milwaukee Brewers
        /// </summary>
        SeattlePilots,
        /// <summary>
        /// used by multiple franchises: the National League team that later became the St. Louis Cardinals, and the
        /// American League team (1902-1953) that later became the Baltimore Orioles
        /// </summary>
        StLouisBrowns,
        StLouisCardinals,
        StLouisPerfectos,
        /// <summary>
        /// the 1998 American League expansion team's name through 2007, before it became the Tampa Bay Rays
        /// </summary>
        TampaBayDevilRays,
        TampaBayRays,
        TexasRangers,
        TorontoBlueJays,
        WashingtonNationals,
        /// <summary>
        /// used by multiple franchises: the National League team of the 1890s, the American League team (1901-1960) that
        /// became the Minnesota Twins, and the American League team (1961-1971) that became the Texas Rangers
        /// </summary>
        WashingtonSenators,
    }

    public class MajorLeagueBaseballTeamAttribute : SingularObjectAttribute
    {
        public MajorLeagueBaseballTeams Team { get; set; }
        public MajorLeagueBaseballTeamAttribute(MajorLeagueBaseballTeams Team)
        {
            this.Team = Team;
        }
    }

    /// <summary>
    /// the team in a season's standings was an expansion team that season, its franchise's first. Later seasons use
    /// FranchiseAttribute instead; a team never has both
    /// </summary>
    public class ExpansionAttribute : Attribute
    {
        public MajorLeagueBaseballFranchises Franchise { get; set; }
        public ExpansionAttribute(MajorLeagueBaseballFranchises Franchise)
        {
            this.Franchise = Franchise;
        }
    }

    /// <summary>
    /// the team in a season's standings belonged to the franchise, in a season after the franchise's first season,
    /// which uses ExpansionAttribute or LeagueCharterMemberAttribute instead; a team has only one of them. Some team
    /// names were used by more than one franchise, so the team name alone doesn't identify the franchise
    /// </summary>
    public class FranchiseAttribute : Attribute
    {
        public MajorLeagueBaseballFranchises Franchise { get; set; }
        public FranchiseAttribute(MajorLeagueBaseballFranchises Franchise)
        {
            this.Franchise = Franchise;
        }
    }

    /// <summary>
    /// the team in a season's standings was a charter member of its league, in the league's first season as a major
    /// league (e.g. the American League in 1901), and its franchise's first. Like ExpansionAttribute, later seasons use
    /// FranchiseAttribute instead; a team never has both
    /// </summary>
    public class LeagueCharterMemberAttribute : Attribute
    {
        public MajorLeagueBaseballFranchises Franchise { get; set; }
        public LeagueCharterMemberAttribute(MajorLeagueBaseballFranchises Franchise)
        {
            this.Franchise = Franchise;
        }
    }

    /// <summary>
    /// the franchise folded after the season, its last; no later season's standings have a team in the franchise. Used
    /// on the franchise with the season, and without one on the franchise's team in that season's standings, where the
    /// season is the one the team is in
    /// </summary>
    public class FranchiseFoldedAfterSeasonAttribute : Attribute
    {
        public int? Season { get; set; }
        public FranchiseFoldedAfterSeasonAttribute()
        {
        }
        public FranchiseFoldedAfterSeasonAttribute(int Season)
        {
            this.Season = Season;
        }
    }

    public enum MajorLeagueBaseballLeagues
    {
        AmericanLeague,
        NationalLeague,
        /// <summary>
        /// all of the major leagues together
        /// </summary>
        MajorLeagueBaseball,
    }

    /// <summary>
    /// the team had the worst full-season record in its league, or in all of Major League Baseball, which also covers
    /// its league. Teams tied for the worst record each get the attribute, and in a split season it goes on the team in
    /// each half's standings
    /// </summary>
    public class WorstRecordInLeagueAttribute : Attribute
    {
        public MajorLeagueBaseballLeagues League { get; set; }
        public WorstRecordInLeagueAttribute(MajorLeagueBaseballLeagues League)
        {
            this.League = League;
        }
    }

    /// <summary>
    /// the manager can come from different enums (e.g. a season's Managers), so it's stored as an int;
    /// a team with more than one manager in a season gets one attribute per manager with the date range of their
    /// tenure. EndDate is null while still in the job
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ManagerAttribute : Attribute
    {
        public int Manager { get; set; }
        public StartDateAttribute? StartDate { get; set; }
        public EndDateAttribute? EndDate { get; set; }
        public ManagerAttribute(int Manager)
        {
            this.Manager = Manager;
        }
        public ManagerAttribute(int Manager, int StartYear, int StartMonth, int StartDay) : this(Manager)
        {
            this.StartDate = new StartDateAttribute(StartYear, StartMonth, StartDay);
        }
        public ManagerAttribute(int Manager, int StartYear, int StartMonth, int StartDay, int EndYear, int EndMonth, int EndDay) : this(Manager, StartYear, StartMonth, StartDay)
        {
            this.EndDate = new EndDateAttribute(EndYear, EndMonth, EndDay);
        }
    }

    /// <summary>
    /// the manager was the interim manager over the date range; pairs with a ManagerAttribute covering the whole
    /// tenure. EndDate is null while still the interim manager
    /// </summary>
    public class InterimManagerAttribute : ManagerAttribute
    {
        public InterimManagerAttribute(int Manager, int StartYear, int StartMonth, int StartDay) : base(Manager, StartYear, StartMonth, StartDay)
        {
        }
        public InterimManagerAttribute(int Manager, int StartYear, int StartMonth, int StartDay, int EndYear, int EndMonth, int EndDay) : base(Manager, StartYear, StartMonth, StartDay, EndYear, EndMonth, EndDay)
        {
        }
    }

    /// <summary>
    /// how a team let its manager go
    /// </summary>
    public enum ManagerDismissalType
    {
        /// <summary>
        /// the manager was fired
        /// </summary>
        Fired,
        /// <summary>
        /// it was reported that the manager's contract was not renewed
        /// </summary>
        ContractNotRenewed,
    }

    /// <summary>
    /// the team let the manager go on the date, during or after the season
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class FiredManagerAttribute : Attribute
    {
        public int Manager { get; set; }
        public YearDateAttribute Date { get; set; }
        public ManagerDismissalType DismissalType { get; set; }
        public FiredManagerAttribute(int Manager, int Year, int Month, int Day) : this(Manager, Year, Month, Day, ManagerDismissalType.Fired)
        {
        }
        public FiredManagerAttribute(int Manager, int Year, int Month, int Day, ManagerDismissalType DismissalType)
        {
            this.Manager = Manager;
            this.Date = new YearDateAttribute(Year, Month, Day);
            this.DismissalType = DismissalType;
        }
    }

    public class AlternateMajorLeagueBaseballGameResultAttribute : MajorLeagueBaseballGameResultAttribute
    {
        public AlternateMajorLeagueBaseballGameResultAttribute(MajorLeagueBaseballTeams WinningTeam, int WinningTeamRuns, MajorLeagueBaseballTeams LosingTeam, int LosingTeamRuns, string AlternateExplanation, BaseballHalfInningEndingPoint HalfInningEndingPoint) : base(WinningTeam, WinningTeamRuns, LosingTeam, LosingTeamRuns, AlternateExplanation, HalfInningEndingPoint)
        {
        }
    }


    /// <summary>
    /// the final score of a game; ResultExplanation can describe anything notable about how the result came about
    /// </summary>
    public class MajorLeagueBaseballGameResultAttribute : Attribute
    {
        public MajorLeagueBaseballTeams WinningTeam { get; set; }
        public int WinningTeamRuns { get; set; }
        public MajorLeagueBaseballTeams LosingTeam { get; set; }
        public int LosingTeamRuns { get; set; }
        public string? ResultExplanation { get; set; }
        public BaseballHalfInningEndingPoint? HalfInningEndingPoint { get; set; }
        public MajorLeagueBaseballGameResultAttribute(MajorLeagueBaseballTeams WinningTeam, int WinningTeamRuns, MajorLeagueBaseballTeams LosingTeam, int LosingTeamRuns)
        {
            this.WinningTeam = WinningTeam;
            this.WinningTeamRuns = WinningTeamRuns;
            this.LosingTeam = LosingTeam;
            this.LosingTeamRuns = LosingTeamRuns;
        }
        public MajorLeagueBaseballGameResultAttribute(MajorLeagueBaseballTeams WinningTeam, int WinningTeamRuns, MajorLeagueBaseballTeams LosingTeam, int LosingTeamRuns, string? ResultExplanation = null, object? HalfInningEndingPoint = null) : this(WinningTeam, WinningTeamRuns, LosingTeam, LosingTeamRuns)
        {
            this.ResultExplanation = ResultExplanation;
            this.HalfInningEndingPoint = HalfInningEndingPoint == null ? null : (BaseballHalfInningEndingPoint)HalfInningEndingPoint;
        }
    }

    /// <summary>
    /// the playoff series standing (e.g. 2-1) after the game it is applied to; when the series is tied, the team with
    /// home field advantage is listed as the leading team
    /// </summary>
    public class MajorLeagueBaseballPlayoffSeriesAttribute : Attribute
    {
        public MajorLeagueBaseballTeams LeadingTeam { get; set; }
        public int LeadingTeamWins { get; set; }
        public MajorLeagueBaseballTeams TrailingTeam { get; set; }
        public int TrailingTeamWins { get; set; }
        public MajorLeagueBaseballPlayoffSeriesAttribute(MajorLeagueBaseballTeams LeadingTeam, int LeadingTeamWins, MajorLeagueBaseballTeams TrailingTeam, int TrailingTeamWins)
        {
            this.LeadingTeam = LeadingTeam;
            this.LeadingTeamWins = LeadingTeamWins;
            this.TrailingTeam = TrailingTeam;
            this.TrailingTeamWins = TrailingTeamWins;
        }
    }

    /// <summary>
    /// the game isn't finished; the winning and losing teams are the teams leading and trailing so far. HalfInningEndingPoint
    /// is set when the score is as of a half inning boundary, and InProgressExplanation can describe when the score was
    /// taken otherwise (e.g. mid inning)
    /// </summary>
    public class MajorLeagueBaseballGameResultInProgressAttribute : MajorLeagueBaseballGameResultAttribute
    {
        public MajorLeagueBaseballGameResultInProgressAttribute(MajorLeagueBaseballTeams WinningTeam, int WinningTeamRuns, MajorLeagueBaseballTeams LosingTeam, int LosingTeamRuns) : base(WinningTeam, WinningTeamRuns, LosingTeam, LosingTeamRuns)
        {
        }
        public MajorLeagueBaseballGameResultInProgressAttribute(MajorLeagueBaseballTeams WinningTeam, int WinningTeamRuns, MajorLeagueBaseballTeams LosingTeam, int LosingTeamRuns, BaseballHalfInningEndingPoint HalfInningEndingPoint) : base(WinningTeam, WinningTeamRuns, LosingTeam, LosingTeamRuns, null, HalfInningEndingPoint)
        {
        }
        public MajorLeagueBaseballGameResultInProgressAttribute(MajorLeagueBaseballTeams WinningTeam, int WinningTeamRuns, MajorLeagueBaseballTeams LosingTeam, int LosingTeamRuns, BaseballHalfInningEndingPoint HalfInningEndingPoint, string InProgressExplanation) : base(WinningTeam, WinningTeamRuns, LosingTeam, LosingTeamRuns, InProgressExplanation, HalfInningEndingPoint)
        {
        }
        public MajorLeagueBaseballGameResultInProgressAttribute(MajorLeagueBaseballTeams WinningTeam, int WinningTeamRuns, MajorLeagueBaseballTeams LosingTeam, int LosingTeamRuns, string InProgressExplanation) : base(WinningTeam, WinningTeamRuns, LosingTeam, LosingTeamRuns, InProgressExplanation)
        {
        }
    }

    public static class MajorLeagueBaseball
    {
        /// <summary>
        /// DivisionWinner tiebreaker explanations
        /// </summary>
        public const string ONE_GAME_TIEBREAKER = "Won a one-game tiebreaker which counted as a regular season game";
        public const string HEAD_TO_HEAD_SEASON_SERIES_TIEBREAKER = "Won the head-to-head season series tiebreaker";

        public static class v1892
        {
            public static class NationalLeague
            {
                /// <summary>
                /// standings for the first half of the season, April 12 to July 13; the league had no divisions
                /// </summary>
                public static class SplitSeason1
                {
                    [TeamWinLossRecord(52, 22)]
                    [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                    public static class BostonBeaneaters { }
                    [TeamWinLossRecord(51, 26)]
                    [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                    public static class BrooklynGrooms { }
                    [TeamWinLossRecord(46, 30)]
                    [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                    public static class PhiladelphiaPhillies { }
                    [TeamWinLossRecord(44, 31)]
                    [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                    public static class CincinnatiReds { }
                    [TeamWinLossRecord(40, 33)]
                    [Franchise(MajorLeagueBaseballFranchises.ClevelandSpidersNationalLeague)]
                    public static class ClevelandSpiders { }
                    [TeamWinLossRecord(37, 39)]
                    [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                    public static class PittsburghPirates { }
                    [TeamWinLossRecord(35, 41)]
                    [Franchise(MajorLeagueBaseballFranchises.WashingtonDCSenatorsOriginal)]
                    public static class WashingtonSenators { }
                    [TeamWinLossRecord(31, 39)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                    public static class ChicagoColts { }
                    [TeamWinLossRecord(31, 42)]
                    [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                    public static class StLouisBrowns { }
                    [TeamWinLossRecord(31, 43)]
                    [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                    public static class NewYorkGiants { }
                    [TeamWinLossRecord(30, 47)]
                    [Franchise(MajorLeagueBaseballFranchises.LouisvilleColonels)]
                    public static class LouisvilleColonels { }
                    [TeamWinLossRecord(20, 55)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                    [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesNationalLeague)]
                    public static class BaltimoreOrioles { }
                }

                /// <summary>
                /// standings for the second half of the season, July 15 to October 15; the league had no divisions
                /// </summary>
                public static class SplitSeason2
                {
                    [TeamWinLossRecord(53, 23)]
                    [Franchise(MajorLeagueBaseballFranchises.ClevelandSpidersNationalLeague)]
                    public static class ClevelandSpiders { }
                    [TeamWinLossRecord(50, 26)]
                    [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                    public static class BostonBeaneaters { }
                    [TeamWinLossRecord(44, 33)]
                    [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                    public static class BrooklynGrooms { }
                    [TeamWinLossRecord(43, 34)]
                    [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                    public static class PittsburghPirates { }
                    [TeamWinLossRecord(41, 36)]
                    [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                    public static class PhiladelphiaPhillies { }
                    [TeamWinLossRecord(40, 37)]
                    [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                    public static class NewYorkGiants { }
                    [TeamWinLossRecord(39, 37)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                    public static class ChicagoColts { }
                    [TeamWinLossRecord(38, 37)]
                    [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                    public static class CincinnatiReds { }
                    [TeamWinLossRecord(33, 42)]
                    [Franchise(MajorLeagueBaseballFranchises.LouisvilleColonels)]
                    public static class LouisvilleColonels { }
                    [TeamWinLossRecord(26, 46)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                    [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesNationalLeague)]
                    public static class BaltimoreOrioles { }
                    [TeamWinLossRecord(25, 52)]
                    [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                    public static class StLouisBrowns { }
                    [TeamWinLossRecord(23, 52)]
                    [Franchise(MajorLeagueBaseballFranchises.WashingtonDCSenatorsOriginal)]
                    public static class WashingtonSenators { }
                }
            }
        }

        /// <summary>
        /// the National League's last season with 12 teams; it dropped Baltimore, Cleveland, Louisville, and Washington
        /// afterward
        /// </summary>
        public static class v1899
        {
            public static class NationalLeague
            {
                /// <summary>
                /// standings for the whole season; the league had no divisions
                /// </summary>
                public static class Standings
                {
                    [TeamWinLossRecord(101, 47)]
                    [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                    public static class BrooklynSuperbas { }
                    [TeamWinLossRecord(95, 57)]
                    [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                    public static class BostonBeaneaters { }
                    [TeamWinLossRecord(94, 58)]
                    [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                    public static class PhiladelphiaPhillies { }
                    [TeamWinLossRecord(86, 62)]
                    [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesNationalLeague)]
                    [FranchiseFoldedAfterSeason]
                    public static class BaltimoreOrioles { }
                    [TeamWinLossRecord(84, 67)]
                    [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                    public static class StLouisPerfectos { }
                    [TeamWinLossRecord(83, 67)]
                    [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                    public static class CincinnatiReds { }
                    [TeamWinLossRecord(76, 73)]
                    [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                    public static class PittsburghPirates { }
                    [TeamWinLossRecord(75, 73)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                    public static class ChicagoOrphans { }
                    [TeamWinLossRecord(75, 77)]
                    [Franchise(MajorLeagueBaseballFranchises.LouisvilleColonels)]
                    [FranchiseFoldedAfterSeason]
                    public static class LouisvilleColonels { }
                    [TeamWinLossRecord(60, 90)]
                    [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                    public static class NewYorkGiants { }
                    [TeamWinLossRecord(54, 98)]
                    [Franchise(MajorLeagueBaseballFranchises.WashingtonDCSenatorsOriginal)]
                    [FranchiseFoldedAfterSeason]
                    public static class WashingtonSenators { }
                    [TeamWinLossRecord(20, 134)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                    [Franchise(MajorLeagueBaseballFranchises.ClevelandSpidersNationalLeague)]
                    [FranchiseFoldedAfterSeason]
                    public static class ClevelandSpiders { }
                }
            }
        }

        /// <summary>
        /// the National League's first season with 8 teams. The American League played as a minor league, before
        /// becoming a major league in 1901
        /// </summary>
        public static class v1900
        {
            public static class NationalLeague
            {
                /// <summary>
                /// standings for the whole season; the league had no divisions
                /// </summary>
                public static class Standings
                {
                    [TeamWinLossRecord(82, 54)]
                    [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                    public static class BrooklynSuperbas { }
                    [TeamWinLossRecord(79, 60)]
                    [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                    public static class PittsburghPirates { }
                    [TeamWinLossRecord(75, 63)]
                    [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                    public static class PhiladelphiaPhillies { }
                    [TeamWinLossRecord(66, 72)]
                    [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                    public static class BostonBeaneaters { }
                    [TeamWinLossRecord(65, 75)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                    public static class ChicagoOrphans { }
                    [TeamWinLossRecord(65, 75)]
                    [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                    public static class StLouisCardinals { }
                    [TeamWinLossRecord(62, 77)]
                    [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                    public static class CincinnatiReds { }
                    [TeamWinLossRecord(60, 78)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                    [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                    public static class NewYorkGiants { }
                }
            }
        }

        /// <summary>
        /// the American League's first season as a major league, alongside the National League; neither league had
        /// divisions, and the first World Series was in 1903
        /// </summary>
        public static class v1901
        {
            public static class AmericanLeague
            {
                /// <summary>
                /// standings for the whole season; the league had no divisions
                /// </summary>
                public static class Standings
                {
                    [TeamWinLossRecord(83, 53)]
                    [LeagueCharterMember(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                    public static class ChicagoWhiteStockings { }
                    [TeamWinLossRecord(79, 57)]
                    [LeagueCharterMember(MajorLeagueBaseballFranchises.BostonRedSox)]
                    public static class BostonAmericans { }
                    [TeamWinLossRecord(74, 61)]
                    [LeagueCharterMember(MajorLeagueBaseballFranchises.DetroitTigers)]
                    public static class DetroitTigers { }
                    [TeamWinLossRecord(74, 62)]
                    [LeagueCharterMember(MajorLeagueBaseballFranchises.OaklandAthletics)]
                    public static class PhiladelphiaAthletics { }
                    [TeamWinLossRecord(68, 65)]
                    [LeagueCharterMember(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeagueOriginal)]
                    public static class BaltimoreOrioles { }
                    [TeamWinLossRecord(61, 72)]
                    [LeagueCharterMember(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                    public static class WashingtonSenators { }
                    [TeamWinLossRecord(54, 82)]
                    [LeagueCharterMember(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                    public static class ClevelandBlues { }
                    [TeamWinLossRecord(48, 89)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                    [LeagueCharterMember(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                    public static class MilwaukeeBrewers { }
                }
            }

            public static class NationalLeague
            {
                /// <summary>
                /// standings for the whole season; the league had no divisions
                /// </summary>
                public static class Standings
                {
                    [TeamWinLossRecord(90, 49)]
                    [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                    public static class PittsburghPirates { }
                    [TeamWinLossRecord(83, 57)]
                    [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                    public static class PhiladelphiaPhillies { }
                    [TeamWinLossRecord(79, 57)]
                    [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                    public static class BrooklynSuperbas { }
                    [TeamWinLossRecord(76, 64)]
                    [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                    public static class StLouisCardinals { }
                    [TeamWinLossRecord(69, 69)]
                    [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                    public static class BostonBeaneaters { }
                    [TeamWinLossRecord(53, 86)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                    public static class ChicagoOrphans { }
                    [TeamWinLossRecord(52, 85)]
                    [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                    public static class NewYorkGiants { }
                    [TeamWinLossRecord(52, 87)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                    [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                    public static class CincinnatiReds { }
                }
            }
        }

        /// <summary>
        /// the American League Baltimore Orioles' last season: John McGraw left for the New York Giants in the middle of
        /// it, the Giants and Cincinnati Reds took the club's best players, and the American League restocked it with
        /// players on loan from its other teams. The American League replaced it with a New York team in 1903
        /// </summary>
        public static class v1902
        {
            public static class AmericanLeague
            {
                /// <summary>
                /// standings for the whole season; the league had no divisions
                /// </summary>
                public static class Standings
                {
                    [TeamWinLossRecord(83, 53)]
                    [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                    public static class PhiladelphiaAthletics { }
                    [TeamWinLossRecord(78, 58)]
                    [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                    public static class StLouisBrowns { }
                    [TeamWinLossRecord(77, 60)]
                    [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                    public static class BostonAmericans { }
                    [TeamWinLossRecord(74, 60)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                    public static class ChicagoWhiteStockings { }
                    [TeamWinLossRecord(69, 67)]
                    [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                    public static class ClevelandBronchos { }
                    [TeamWinLossRecord(61, 75)]
                    [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                    public static class WashingtonSenators { }
                    [TeamWinLossRecord(52, 83)]
                    [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                    public static class DetroitTigers { }
                    [TeamWinLossRecord(50, 88)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                    [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeagueOriginal)]
                    [FranchiseFoldedAfterSeason]
                    public static class BaltimoreOrioles { }
                }
            }

            public static class NationalLeague
            {
                /// <summary>
                /// standings for the whole season; the league had no divisions
                /// </summary>
                public static class Standings
                {
                    [TeamWinLossRecord(103, 36)]
                    [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                    public static class PittsburghPirates { }
                    [TeamWinLossRecord(75, 63)]
                    [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                    public static class BrooklynSuperbas { }
                    [TeamWinLossRecord(73, 64)]
                    [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                    public static class BostonBeaneaters { }
                    [TeamWinLossRecord(70, 70)]
                    [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                    public static class CincinnatiReds { }
                    [TeamWinLossRecord(68, 69)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                    public static class ChicagoOrphans { }
                    [TeamWinLossRecord(56, 78)]
                    [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                    public static class StLouisCardinals { }
                    [TeamWinLossRecord(56, 81)]
                    [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                    public static class PhiladelphiaPhillies { }
                    [TeamWinLossRecord(48, 88)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                    [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                    public static class NewYorkGiants { }
                }
            }
        }

        /// <summary>
        /// the New York Highlanders replaced the Baltimore Orioles in the American League, and the first World Series was
        /// played, after the American and National Leagues made peace
        /// </summary>
        public static class v1903
        {
            public static class AmericanLeague
            {
                /// <summary>
                /// standings for the whole season; the league had no divisions
                /// </summary>
                public static class Standings
                {
                    [TeamWinLossRecord(91, 47)]
                    [WorldSeries(TwoPlayerGameOutcome.Win)]
                    [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                    public static class BostonAmericans { }
                    [TeamWinLossRecord(75, 60)]
                    [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                    public static class PhiladelphiaAthletics { }
                    [TeamWinLossRecord(77, 63)]
                    [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                    public static class ClevelandNaps { }
                    [TeamWinLossRecord(72, 62)]
                    [Expansion(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                    public static class NewYorkHighlanders { }
                    [TeamWinLossRecord(65, 71)]
                    [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                    public static class DetroitTigers { }
                    [TeamWinLossRecord(65, 74)]
                    [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                    public static class StLouisBrowns { }
                    [TeamWinLossRecord(60, 77)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                    public static class ChicagoWhiteStockings { }
                    [TeamWinLossRecord(43, 94)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                    [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                    public static class WashingtonSenators { }
                }
            }

            public static class NationalLeague
            {
                /// <summary>
                /// standings for the whole season; the league had no divisions
                /// </summary>
                public static class Standings
                {
                    [TeamWinLossRecord(91, 49)]
                    [WorldSeries(TwoPlayerGameOutcome.Loss)]
                    [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                    public static class PittsburghPirates { }
                    [TeamWinLossRecord(84, 55)]
                    [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                    public static class NewYorkGiants { }
                    [TeamWinLossRecord(82, 56)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                    public static class ChicagoCubs { }
                    [TeamWinLossRecord(74, 65)]
                    [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                    public static class CincinnatiReds { }
                    [TeamWinLossRecord(70, 66)]
                    [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                    public static class BrooklynSuperbas { }
                    [TeamWinLossRecord(58, 80)]
                    [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                    public static class BostonBeaneaters { }
                    [TeamWinLossRecord(49, 86)]
                    [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                    public static class PhiladelphiaPhillies { }
                    [TeamWinLossRecord(43, 94)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                    [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                    public static class StLouisCardinals { }
                }
            }

            [BestOf(9)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.BostonAmericans)]
                public static class AmericanLeagueTeam { }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.PittsburghPirates)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                public static class Game5 { }

                public static class Game6 { }

                public static class Game7 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.BostonAmericans, 5, MajorLeagueBaseballTeams.PittsburghPirates, 3)]
                public static class Game8 { }
            }
        }

        public static class v1904
        {
            [Text("No World Series was played because the National League champion New York Giants refused to play the American League champion Boston Americans")]
            public static class WorldSeries { }
        }

        public static class v1919
        {
            [BestOf(9)]
            public static class WorldSeries { }
        }

        public static class v1920
        {
            [BestOf(9)]
            public static class WorldSeries { }
        }

        /// <summary>
        /// the first Subway Series, between the New York Giants and the New York Yankees, with every game at the Polo
        /// Grounds, where the Yankees were the Giants' tenants
        /// </summary>
        public static class v1921
        {
            public static class AmericanLeague
            {
                /// <summary>
                /// standings for the whole season; the league had no divisions
                /// </summary>
                public static class Standings
                {
                    [TeamWinLossRecord(98, 55)]
                    [WorldSeries(TwoPlayerGameOutcome.Loss)]
                    [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                    public static class NewYorkYankees { }
                    [TeamWinLossRecord(94, 60)]
                    [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                    public static class ClevelandIndians { }
                    [TeamWinLossRecord(81, 73)]
                    [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                    public static class StLouisBrowns { }
                    [TeamWinLossRecord(80, 73)]
                    [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                    public static class WashingtonSenators { }
                    [TeamWinLossRecord(75, 79)]
                    [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                    public static class BostonRedSox { }
                    [TeamWinLossRecord(71, 82)]
                    [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                    public static class DetroitTigers { }
                    [TeamWinLossRecord(62, 92)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                    public static class ChicagoWhiteSox { }
                    [TeamWinLossRecord(53, 100)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                    [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                    public static class PhiladelphiaAthletics { }
                }
            }

            public static class NationalLeague
            {
                /// <summary>
                /// standings for the whole season; the league had no divisions
                /// </summary>
                public static class Standings
                {
                    [TeamWinLossRecord(94, 59)]
                    [WorldSeries(TwoPlayerGameOutcome.Win)]
                    [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                    public static class NewYorkGiants { }
                    [TeamWinLossRecord(90, 63)]
                    [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                    public static class PittsburghPirates { }
                    [TeamWinLossRecord(87, 66)]
                    [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                    public static class StLouisCardinals { }
                    [TeamWinLossRecord(79, 74)]
                    [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                    public static class BostonBraves { }
                    [TeamWinLossRecord(77, 75)]
                    [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                    public static class BrooklynRobins { }
                    [TeamWinLossRecord(70, 83)]
                    [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                    public static class CincinnatiReds { }
                    [TeamWinLossRecord(64, 89)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                    public static class ChicagoCubs { }
                    [TeamWinLossRecord(51, 103)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                    [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                    public static class PhiladelphiaPhillies { }
                }
            }

            [BestOf(9)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.NewYorkYankees)]
                public static class AmericanLeagueTeam { }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.NewYorkGiants)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                public static class Game5 { }

                public static class Game6 { }

                public static class Game7 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.NewYorkGiants, 5, MajorLeagueBaseballTeams.NewYorkYankees, 3)]
                public static class Game8 { }
            }
        }

        /// <summary>
        /// the last season before divisions, with 10 teams in each league; known as the "Year of the Pitcher"
        /// </summary>
        public static class v1968
        {
            public static class AmericanLeague
            {
                /// <summary>
                /// standings for the whole season; the league had no divisions
                /// </summary>
                public static class Standings
                {
                    [TeamWinLossRecord(103, 59)]
                    [WorldSeries(TwoPlayerGameOutcome.Win)]
                    [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                    public static class DetroitTigers { }
                    [TeamWinLossRecord(91, 71)]
                    [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                    public static class BaltimoreOrioles { }
                    [TeamWinLossRecord(86, 75)]
                    [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                    public static class ClevelandIndians { }
                    [TeamWinLossRecord(86, 76)]
                    [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                    public static class BostonRedSox { }
                    [TeamWinLossRecord(83, 79)]
                    [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                    public static class NewYorkYankees { }
                    [TeamWinLossRecord(82, 80)]
                    [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                    public static class OaklandAthletics { }
                    [TeamWinLossRecord(79, 83)]
                    [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                    public static class MinnesotaTwins { }
                    [TeamWinLossRecord(67, 95)]
                    [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                    public static class CaliforniaAngels { }
                    [TeamWinLossRecord(67, 95)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                    public static class ChicagoWhiteSox { }
                    [TeamWinLossRecord(65, 96)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                    [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                    public static class WashingtonSenators { }
                }
            }

            public static class NationalLeague
            {
                /// <summary>
                /// standings for the whole season; the league had no divisions
                /// </summary>
                public static class Standings
                {
                    [TeamWinLossRecord(97, 65)]
                    [WorldSeries(TwoPlayerGameOutcome.Loss)]
                    [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                    public static class StLouisCardinals { }
                    [TeamWinLossRecord(88, 74)]
                    [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                    public static class SanFranciscoGiants { }
                    [TeamWinLossRecord(84, 78)]
                    [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                    public static class ChicagoCubs { }
                    [TeamWinLossRecord(83, 79)]
                    [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                    public static class CincinnatiReds { }
                    [TeamWinLossRecord(81, 81)]
                    [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                    public static class AtlantaBraves { }
                    [TeamWinLossRecord(80, 82)]
                    [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                    public static class PittsburghPirates { }
                    [TeamWinLossRecord(76, 86)]
                    [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                    public static class LosAngelesDodgers { }
                    [TeamWinLossRecord(76, 86)]
                    [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                    public static class PhiladelphiaPhillies { }
                    [TeamWinLossRecord(73, 89)]
                    [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                    public static class NewYorkMets { }
                    [TeamWinLossRecord(72, 90)]
                    [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                    [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                    public static class HoustonAstros { }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.LolichMickey, (int)MajorLeagueBaseballTeams.DetroitTigers)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.DetroitTigers)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        LolichMickey,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                public static class Game5 { }

                public static class Game6 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.DetroitTigers, 4, MajorLeagueBaseballTeams.StLouisCardinals, 3)]
                public static class Game7 { }
            }
        }

        /// <summary>
        /// the first season with divisions, after each league expanded to 12 teams
        /// </summary>
        public static class v1969
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(109, 53)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class WashingtonSenators { }
                        [TeamWinLossRecord(80, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(62, 99)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(97, 65)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                        [TeamWinLossRecord(69, 93)]
                        [Expansion(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(68, 94)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(64, 98)]
                        [Expansion(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class SeattlePilots { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(100, 62)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(92, 70)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(63, 99)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(52, 110)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Expansion(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(93, 69)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(85, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(52, 110)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Expansion(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.ClendenonDonn, (int)MajorLeagueBaseballTeams.NewYorkMets)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.BaltimoreOrioles)]
                public static class AmericanLeagueTeam { }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.NewYorkMets)]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.FirstBase)]
                        ClendenonDonn,
                    }
                }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.NewYorkMets, 4, MajorLeagueBaseballTeams.BaltimoreOrioles, 1)]
                public static class Game5 { }
            }
        }

        /// <summary>
        /// the Seattle Pilots moved to Milwaukee and became the Milwaukee Brewers just before the season
        /// </summary>
        public static class v1970
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(108, 54)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(93, 69)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(70, 92)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class WashingtonSenators { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(98, 64)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                        [TeamWinLossRecord(65, 97)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(65, 97)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(56, 106)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(84, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(73, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(102, 60)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(87, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(63, 99)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.RobinsonBrooks, (int)MajorLeagueBaseballTeams.BaltimoreOrioles)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.BaltimoreOrioles)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.ThirdBase)]
                        RobinsonBrooks,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.CincinnatiReds)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.BaltimoreOrioles, 4, MajorLeagueBaseballTeams.CincinnatiReds, 1)]
                public static class Game5 { }
            }
        }

        /// <summary>
        /// the Oakland Athletics' third straight World Series title, over the Los Angeles Dodgers in an all-California
        /// World Series
        /// </summary>
        public static class v1974
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(91, 71)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(84, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(90, 72)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(84, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(80, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(68, 94)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(86, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(80, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(79, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(66, 96)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(102, 60)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(98, 64)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(60, 102)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.FingersRollie, (int)MajorLeagueBaseballTeams.OaklandAthletics)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.OaklandAthletics)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.PitcherReliefCloser)]
                        FingersRollie,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.LosAngelesDodgers)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.OaklandAthletics, 4, MajorLeagueBaseballTeams.LosAngelesDodgers, 1)]
                public static class Game5 { }
            }
        }

        /// <summary>
        /// the last season before the American League expanded to 14 teams, with 12 teams in each league
        /// </summary>
        public static class v1976
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(97, 62)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(81, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(74, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(66, 95)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(87, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(85, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(64, 97)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(101, 61)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(92, 70)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(75, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(55, 107)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(102, 60)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(92, 70)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(80, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(70, 92)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.BenchJohnny, (int)MajorLeagueBaseballTeams.CincinnatiReds)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.NewYorkYankees)]
                public static class AmericanLeagueTeam { }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.CincinnatiReds)]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.Catcher)]
                        BenchJohnny,
                    }
                }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.CincinnatiReds, 4, MajorLeagueBaseballTeams.NewYorkYankees, 0)]
                public static class Game4 { }
            }
        }

        /// <summary>
        /// the American League expanded to 14 teams with the Seattle Mariners and Toronto Blue Jays
        /// </summary>
        public static class v1977
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(100, 62)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(97, 64)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(97, 64)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(71, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(67, 95)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(54, 107)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Expansion(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(102, 60)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(94, 68)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(84, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                        [TeamWinLossRecord(64, 98)]
                        [Expansion(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(63, 98)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(101, 61)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(96, 66)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(75, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(64, 98)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(98, 64)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(75, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(69, 93)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(61, 101)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.JacksonReggie, (int)MajorLeagueBaseballTeams.NewYorkYankees)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.NewYorkYankees)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.Outfield)]
                        JacksonReggie,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.LosAngelesDodgers)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                public static class Game5 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.NewYorkYankees, 4, MajorLeagueBaseballTeams.LosAngelesDodgers, 2)]
                public static class Game6 { }
            }
        }

        public static class v1981
        {
            public static class AmericanLeague
            {
                /// <summary>
                /// standings for the first half of the season, before the players' strike that began on June 12
                /// </summary>
                public static class SplitSeason1Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(34, 22)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(31, 23)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(31, 25)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(31, 26)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(30, 26)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(26, 24)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(16, 42)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(37, 23)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(33, 22)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(31, 22)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(31, 29)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                        [TeamWinLossRecord(20, 30)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(21, 36)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(17, 39)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                    }
                }

                /// <summary>
                /// standings for the second half of the season, after play resumed on August 10
                /// </summary>
                public static class SplitSeason2Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(31, 22)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(29, 23)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(29, 23)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(28, 23)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(26, 27)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(25, 26)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(21, 27)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(30, 23)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(27, 22)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(24, 26)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(24, 29)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(23, 29)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(23, 30)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(20, 30)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                    }
                }
            }

            /// <summary>
            /// The Reds had the best full-season record in baseball (66-42) and the Cardinals the best in the NL East
            /// (59-43). Neither made the playoffs, because neither won a half.
            /// </summary>
            public static class NationalLeague
            {
                /// <summary>
                /// standings for the first half of the season, before the players' strike that began on June 12
                /// </summary>
                public static class SplitSeason1Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(34, 21)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(30, 20)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(30, 25)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(25, 23)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(17, 34)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(15, 37)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(36, 21)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(35, 21)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(28, 29)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(25, 29)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(27, 32)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(23, 33)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                    }
                }

                /// <summary>
                /// standings for the second half of the season, after play resumed on August 10
                /// </summary>
                public static class SplitSeason2Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(30, 23)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(29, 23)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(25, 27)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(24, 28)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(23, 28)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(21, 33)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(33, 20)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(31, 21)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(29, 23)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(27, 26)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(25, 27)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(18, 36)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                    }
                }
            }

            /// <summary>
            /// the only World Series with more than one MVP; the award was shared by three Dodgers
            /// </summary>
            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.CeyRon, (int)MajorLeagueBaseballTeams.LosAngelesDodgers)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.GuerreroPedro, (int)MajorLeagueBaseballTeams.LosAngelesDodgers)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.YeagerSteve, (int)MajorLeagueBaseballTeams.LosAngelesDodgers)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.NewYorkYankees)]
                public static class AmericanLeagueTeam { }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.LosAngelesDodgers)]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.ThirdBase)]
                        CeyRon,
                        [FielderType(BaseballPositionType.Outfield)]
                        GuerreroPedro,
                        [FielderType(BaseballPositionType.Catcher)]
                        YeagerSteve,
                    }
                }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                public static class Game5 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.LosAngelesDodgers, 4, MajorLeagueBaseballTeams.NewYorkYankees, 2)]
                public static class Game6 { }
            }
        }

        public static class v1982
        {
            public enum Managers
            {
                HerzogWhitey,
                /// <summary>
                /// replaced Buck Rodgers in early June
                /// </summary>
                KuennHarvey,
            }

            public static class AmericanLeague
            {
                public enum PitchingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    FingersRollie,
                    /// <summary>
                    /// not actually an All-Star
                    /// </summary>
                    [CyYoung]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    VuckovichPete,
                }

                public enum BattingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    [FielderType(BaseballPositionType.FirstBase)]
                    CooperCecil,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    [FielderType(BaseballPositionType.Outfield)]
                    OglivieBen,
                    [MostValuablePlayer]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    [FielderType(BaseballPositionType.Shortstop)]
                    YountRobin,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(95, 67)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(94, 68)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(93, 69)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(68, 94)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(64, 98)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(60, 102)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                    }
                }
            }

            public static class NationalLeague
            {
                public enum PitchingAllStars
                {
                    [CyYoung]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.PhiladelphiaPhillies)]
                    CarltonSteve,
                }

                public enum BattingAllStars
                {
                    [MostValuablePlayer]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.AtlantaBraves)]
                    [FielderType(BaseballPositionType.Outfield)]
                    MurphyDale,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
                    [FielderType(BaseballPositionType.Outfield)]
                    SmithLonnie,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
                    [FielderType(BaseballPositionType.Shortstop)]
                    SmithOzzie,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(92, 70)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(84, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(65, 97)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(61, 101)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.PorterDarrell, (int)MajorLeagueBaseballTeams.StLouisCardinals)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                [Manager((int)Managers.KuennHarvey)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        /// <summary>
                        /// started games 1 and 5
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        CaldwellMike,
                        /// <summary>
                        /// started games 2 and 6
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        SuttonDon,
                        /// <summary>
                        /// started games 3 and 7
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        VuckovichPete,
                        /// <summary>
                        /// started game 4
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        HaasMoose,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
                [Manager((int)Managers.HerzogWhitey)]
                [HomeFieldAdvantage]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        /// <summary>
                        /// started games 1 and 5
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        ForschBob,
                        /// <summary>
                        /// started games 2 and 6
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        StuperJohn,
                        /// <summary>
                        /// started games 3 and 7
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        AndujarJoaquin,
                        /// <summary>
                        /// started game 4
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        LaPointDave,
                        [FielderType(BaseballPositionType.Catcher)]
                        PorterDarrell,
                    }
                }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.CaldwellMike)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.ForschBob)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 10, MajorLeagueBaseballTeams.StLouisCardinals, 0)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.MilwaukeeBrewers, 1, MajorLeagueBaseballTeams.StLouisCardinals, 0)]
                public static class Game1 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.SuttonDon)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.StuperJohn)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.StLouisCardinals, 5, MajorLeagueBaseballTeams.MilwaukeeBrewers, 4)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.StLouisCardinals, 1, MajorLeagueBaseballTeams.MilwaukeeBrewers, 1)]
                public static class Game2 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.VuckovichPete)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.AndujarJoaquin)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.StLouisCardinals, 6, MajorLeagueBaseballTeams.MilwaukeeBrewers, 2)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.StLouisCardinals, 2, MajorLeagueBaseballTeams.MilwaukeeBrewers, 1)]
                public static class Game3 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.HaasMoose)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.LaPointDave)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 7, MajorLeagueBaseballTeams.StLouisCardinals, 5)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.StLouisCardinals, 2, MajorLeagueBaseballTeams.MilwaukeeBrewers, 2)]
                public static class Game4 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.CaldwellMike)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.ForschBob)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 6, MajorLeagueBaseballTeams.StLouisCardinals, 4)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.MilwaukeeBrewers, 3, MajorLeagueBaseballTeams.StLouisCardinals, 2)]
                public static class Game5 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.SuttonDon)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.StuperJohn)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.StLouisCardinals, 13, MajorLeagueBaseballTeams.MilwaukeeBrewers, 1)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.StLouisCardinals, 3, MajorLeagueBaseballTeams.MilwaukeeBrewers, 3)]
                public static class Game6 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.VuckovichPete)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.AndujarJoaquin)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.StLouisCardinals, 6, MajorLeagueBaseballTeams.MilwaukeeBrewers, 3)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.StLouisCardinals, 4, MajorLeagueBaseballTeams.MilwaukeeBrewers, 3)]
                public static class Game7 { }
            }
        }

        /// <summary>
        /// the I-70 Series between the Kansas City Royals and St. Louis Cardinals, an all-Missouri World Series. The
        /// Royals came back from three games to one down for their first World Series title
        /// </summary>
        public static class v1985
        {
            public enum Managers
            {
                HerzogWhitey,
                HowserDick,
            }

            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(99, 62)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(97, 64)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(84, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(83, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(71, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(60, 102)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(91, 71)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                        [TeamWinLossRecord(85, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(62, 99)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(101, 61)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(98, 64)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(84, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(77, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(75, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(57, 104)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(95, 67)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(89, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(66, 96)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(62, 100)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.SaberhagenBret, (int)MajorLeagueBaseballTeams.KansasCityRoyals)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.KansasCityRoyals)]
                [Manager((int)Managers.HowserDick)]
                [HomeFieldAdvantage]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        JacksonDanny,
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        LeibrandtCharlie,
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        SaberhagenBret,
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        BlackBud,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
                [Manager((int)Managers.HerzogWhitey)]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        TudorJohn,
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        CoxDanny,
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        AndujarJoaquin,
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        ForschBob,
                    }
                }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.JacksonDanny)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.TudorJohn)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.StLouisCardinals, 3, MajorLeagueBaseballTeams.KansasCityRoyals, 1,
                    HalfInningEndingPoint: BaseballHalfInningEndingPoint.AfterRegularSizedGameFinal)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.StLouisCardinals, 1, MajorLeagueBaseballTeams.KansasCityRoyals, 0)]
                public static class Game1 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.LeibrandtCharlie)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.CoxDanny)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.StLouisCardinals, 4, MajorLeagueBaseballTeams.KansasCityRoyals, 2,
                    "The Cardinals scored all four runs in the top of the ninth inning off Charlie Leibrandt, who had taken a 2-0 lead into the inning",
                    HalfInningEndingPoint: BaseballHalfInningEndingPoint.AfterRegularSizedGameFinal)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.StLouisCardinals, 2, MajorLeagueBaseballTeams.KansasCityRoyals, 0)]
                public static class Game2 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.SaberhagenBret)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.AndujarJoaquin)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.KansasCityRoyals, 6, MajorLeagueBaseballTeams.StLouisCardinals, 1,
                    HalfInningEndingPoint: BaseballHalfInningEndingPoint.AfterRegularSizedGameFinal)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.StLouisCardinals, 2, MajorLeagueBaseballTeams.KansasCityRoyals, 1)]
                public static class Game3 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.BlackBud)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.TudorJohn)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.StLouisCardinals, 3, MajorLeagueBaseballTeams.KansasCityRoyals, 0,
                    "John Tudor pitched a complete game shutout",
                    HalfInningEndingPoint: BaseballHalfInningEndingPoint.AfterGameFinalBecauseHomeTeamAheadWithNoNeedToBat)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.StLouisCardinals, 3, MajorLeagueBaseballTeams.KansasCityRoyals, 1)]
                public static class Game4 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.JacksonDanny)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.ForschBob)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.KansasCityRoyals, 6, MajorLeagueBaseballTeams.StLouisCardinals, 1,
                    HalfInningEndingPoint: BaseballHalfInningEndingPoint.AfterRegularSizedGameFinal)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.StLouisCardinals, 3, MajorLeagueBaseballTeams.KansasCityRoyals, 2)]
                public static class Game5 { }

                /// <summary>
                /// the Royals rallied in the bottom of the ninth after umpire Don Denkinger's missed call at first base
                /// </summary>
                [StartingPitcher((int)AmericanLeagueTeam.Roster.LeibrandtCharlie)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.CoxDanny)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.KansasCityRoyals, 2, MajorLeagueBaseballTeams.StLouisCardinals, 1,
                    "Winning run scored in the bottom of the ninth inning with one out on Dane Iorg's two-run pinch-hit single",
                    HalfInningEndingPoint: BaseballHalfInningEndingPoint.WalkoffNinthInningOneOut)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.StLouisCardinals, 3, MajorLeagueBaseballTeams.KansasCityRoyals, 3)]
                public static class Game6 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.SaberhagenBret)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.TudorJohn)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.KansasCityRoyals, 11, MajorLeagueBaseballTeams.StLouisCardinals, 0,
                    "Bret Saberhagen pitched a complete game shutout",
                    HalfInningEndingPoint: BaseballHalfInningEndingPoint.AfterGameFinalBecauseHomeTeamAheadWithNoNeedToBat)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.KansasCityRoyals, 4, MajorLeagueBaseballTeams.StLouisCardinals, 3)]
                public static class Game7 { }
            }
        }

        /// <summary>
        /// the Los Angeles Dodgers beat the Oakland Athletics in an all-California World Series, after Kirk Gibson's
        /// pinch-hit walk-off home run won Game 1
        /// </summary>
        public static class v1988
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(85, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(54, 107)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(104, 58)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(91, 71)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(84, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(75, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                        [TeamWinLossRecord(71, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(70, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(68, 93)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(100, 60)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(85, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(65, 96)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(94, 67)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(87, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(83, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(54, 106)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.HershiserOrel, (int)MajorLeagueBaseballTeams.LosAngelesDodgers)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.OaklandAthletics)]
                public static class AmericanLeagueTeam { }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.LosAngelesDodgers)]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        HershiserOrel,
                    }
                }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.LosAngelesDodgers, 4, MajorLeagueBaseballTeams.OaklandAthletics, 1)]
                public static class Game5 { }
            }
        }

        /// <summary>
        /// the Bay Bridge Series between the Oakland Athletics and San Francisco Giants, known as the Earthquake Series:
        /// the Loma Prieta earthquake struck on October 17 just before Game 3 at Candlestick Park, postponing the series
        /// for 10 days
        /// </summary>
        public static class v1989
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(74, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(59, 103)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(99, 63)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(92, 70)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(91, 71)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(80, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(69, 92)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(93, 69)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(67, 95)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(92, 70)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(77, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(75, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(63, 97)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.StewartDave, (int)MajorLeagueBaseballTeams.OaklandAthletics)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.OaklandAthletics)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        StewartDave,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.SanFranciscoGiants)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                /// <summary>
                /// postponed from October 17, when the Loma Prieta earthquake struck about half an hour before the first
                /// pitch, to October 27
                /// </summary>
                public static class Game3 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.OaklandAthletics, 4, MajorLeagueBaseballTeams.SanFranciscoGiants, 0)]
                public static class Game4 { }
            }
        }

        /// <summary>
        /// the last season before the National League expanded to 14 teams, with 14 teams in the American League and 12
        /// in the National League
        /// </summary>
        public static class v1992
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(96, 66)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(92, 70)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(75, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(96, 66)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(64, 98)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(96, 66)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(70, 92)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(98, 64)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(63, 99)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.BordersPat, (int)MajorLeagueBaseballTeams.TorontoBlueJays)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TorontoBlueJays)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.Catcher)]
                        BordersPat,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.AtlantaBraves)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                public static class Game5 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.TorontoBlueJays, 4, MajorLeagueBaseballTeams.AtlantaBraves, 2)]
                public static class Game6 { }
            }
        }

        /// <summary>
        /// the National League expanded to 14 teams with the Colorado Rockies and Florida Marlins; the last season with
        /// two divisions in each league
        /// </summary>
        public static class v1993
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(95, 67)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(85, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(85, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(80, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(69, 93)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(94, 68)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(84, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class CaliforniaAngels { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(68, 94)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(97, 65)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(94, 68)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(84, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(75, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(64, 98)]
                        [Expansion(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class FloridaMarlins { }
                        [TeamWinLossRecord(59, 103)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(104, 58)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(103, 59)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(85, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(67, 95)]
                        [Expansion(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(61, 101)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.MolitorPaul, (int)MajorLeagueBaseballTeams.TorontoBlueJays)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TorontoBlueJays)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.DesignatedHitter)]
                        MolitorPaul,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.PhiladelphiaPhillies)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                public static class Game5 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.TorontoBlueJays, 4, MajorLeagueBaseballTeams.PhiladelphiaPhillies, 2)]
                public static class Game6 { }
            }
        }

        public static class v1994
        {
            [Text("No World Series was played because the players' strike that began on August 12 led to the rest of the season and the postseason being canceled")]
            public static class WorldSeries { }
        }

        /// <summary>
        /// the Milwaukee Brewers' last season in the American League before moving to the National League Central in
        /// 1998. The Florida Marlins won the World Series as the National League wild card
        /// </summary>
        public static class v1997
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(98, 64)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(96, 66)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(86, 75)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(80, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(78, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(68, 94)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(67, 94)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(84, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class AnaheimAngels { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(65, 97)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(101, 61)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(92, 70)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class FloridaMarlins { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(68, 94)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(84, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(68, 94)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.HernandezLivan, (int)MajorLeagueBaseballTeams.FloridaMarlins)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.ClevelandIndians)]
                public static class AmericanLeagueTeam { }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.FloridaMarlins)]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        HernandezLivan,
                    }
                }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                public static class Game5 { }

                public static class Game6 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.FloridaMarlins, 4, MajorLeagueBaseballTeams.ClevelandIndians, 3)]
                public static class Game7 { }
            }
        }

        /// <summary>
        /// the Milwaukee Brewers' first season in the National League after moving from the American League Central, and
        /// the Detroit Tigers moved from the American League East to the Central. The Arizona Diamondbacks and Tampa Bay
        /// Devil Rays began play as expansion teams
        /// </summary>
        public static class v1998
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(114, 48)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(92, 70)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(63, 99)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Expansion(MajorLeagueBaseballFranchises.TampaBayDevilRays)]
                        public static class TampaBayDevilRays { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(80, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(72, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(70, 92)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(65, 97)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(85, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class AnaheimAngels { }
                        [TeamWinLossRecord(76, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(106, 56)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(75, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(65, 97)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(54, 108)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class FloridaMarlins { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(102, 60)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        /// <summary>
                        /// won the wild card in a one-game tiebreaker against the San Francisco Giants, which counted as a
                        /// regular season game
                        /// </summary>
                        [TeamWinLossRecord(90, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(69, 93)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(98, 64)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(89, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(65, 97)]
                        [Expansion(MajorLeagueBaseballFranchises.PhoenixDiamondbacks)]
                        public static class ArizonaDiamondbacks { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.BrosiusScott, (int)MajorLeagueBaseballTeams.NewYorkYankees)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.NewYorkYankees)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.ThirdBase)]
                        BrosiusScott,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.SanDiegoPadres)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.NewYorkYankees, 4, MajorLeagueBaseballTeams.SanDiegoPadres, 0)]
                public static class Game4 { }
            }
        }

        /// <summary>
        /// the first Subway Series since 1956, and the first between the New York Yankees and the New York Mets
        /// </summary>
        public static class v2000
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(87, 74)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(85, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(69, 92)]
                        [Franchise(MajorLeagueBaseballFranchises.TampaBayDevilRays)]
                        public static class TampaBayDevilRays { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(95, 67)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(69, 93)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(91, 70)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(91, 71)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class AnaheimAngels { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(95, 67)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(94, 68)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(79, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class FloridaMarlins { }
                        [TeamWinLossRecord(67, 95)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(65, 97)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(95, 67)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(85, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(69, 93)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(65, 97)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(97, 65)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(85, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.PhoenixDiamondbacks)]
                        public static class ArizonaDiamondbacks { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.JeterDerek, (int)MajorLeagueBaseballTeams.NewYorkYankees)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.NewYorkYankees)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.Shortstop)]
                        JeterDerek,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.NewYorkMets)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.NewYorkYankees, 4, MajorLeagueBaseballTeams.NewYorkMets, 1)]
                public static class Game5 { }
            }
        }

        /// <summary>
        /// the Anaheim Angels' first World Series title, over the San Francisco Giants in an all-California World Series,
        /// after coming back from five runs down in the seventh inning of Game 6
        /// </summary>
        public static class v2002
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(103, 58)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(93, 69)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(67, 95)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(55, 106)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.TampaBayDevilRays)]
                        public static class TampaBayDevilRays { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(94, 67)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(62, 100)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(55, 106)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(103, 59)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(99, 63)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class AnaheimAngels { }
                        [TeamWinLossRecord(93, 69)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(101, 59)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(80, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class FloridaMarlins { }
                        [TeamWinLossRecord(75, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(97, 65)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(84, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(72, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(67, 95)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(56, 106)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(98, 64)]
                        [Franchise(MajorLeagueBaseballFranchises.PhoenixDiamondbacks)]
                        public static class ArizonaDiamondbacks { }
                        [TeamWinLossRecord(95, 66)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(92, 70)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(66, 96)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.GlausTroy, (int)MajorLeagueBaseballTeams.AnaheimAngels)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.AnaheimAngels)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.ThirdBase)]
                        GlausTroy,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.SanFranciscoGiants)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                public static class Game5 { }

                public static class Game6 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.AnaheimAngels, 4, MajorLeagueBaseballTeams.SanFranciscoGiants, 3)]
                public static class Game7 { }
            }
        }

        public static class v2008
        {
            public enum Managers
            {
                MaddonJoe,
                ManuelCharlie,
            }

            public static class AmericanLeague
            {
                public enum PitchingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    KazmirScott,
                    [CyYoung]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.ClevelandIndians)]
                    LeeCliff,
                }

                public enum BattingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    [FielderType(BaseballPositionType.ThirdBase)]
                    LongoriaEvan,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    [FielderType(BaseballPositionType.Catcher)]
                    NavarroDioner,
                    [MostValuablePlayer]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.BostonRedSox)]
                    [FielderType(BaseballPositionType.SecondBase)]
                    PedroiaDustin,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(97, 65)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.TampaBayDevilRays)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(95, 67)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(68, 93)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                    }
                    public static class Central
                    {
                        /// <summary>
                        /// tied with the Minnesota Twins at 88-74 and beat them 1-0 in the tiebreaker on September 30
                        /// </summary>
                        [TeamWinLossRecord(89, 74)]
                        [DivisionWinner(ONE_GAME_TIEBREAKER)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(88, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(75, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(100, 62)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class LosAngelesAngelsOfAnaheim { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(75, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(61, 101)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                    }
                }
            }

            public static class NationalLeague
            {
                public enum PitchingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.PhiladelphiaPhillies)]
                    LidgeBrad,
                    /// <summary>
                    /// selected, but did not pitch due to flu-like symptoms
                    /// </summary>
                    [CyYoung]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.SanFranciscoGiants)]
                    LincecumTim,
                }

                public enum BattingAllStars
                {
                    /// <summary>
                    /// fan-elected starter at designated hitter
                    /// </summary>
                    [MostValuablePlayer]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
                    [FielderType(BaseballPositionType.DesignatedHitter)]
                    PujolsAlbert,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.PhiladelphiaPhillies)]
                    [FielderType(BaseballPositionType.SecondBase)]
                    UtleyChase,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(92, 70)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(84, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class FloridaMarlins { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(59, 102)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class WashingtonNationals { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(97, 64)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(86, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(67, 95)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(84, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.PhoenixDiamondbacks)]
                        public static class ArizonaDiamondbacks { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(63, 99)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.HamelsCole, (int)MajorLeagueBaseballTeams.PhiladelphiaPhillies)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                [Manager((int)Managers.MaddonJoe)]
                [HomeFieldAdvantage]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        /// <summary>
                        /// started games 1 and 5
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        KazmirScott,
                        /// <summary>
                        /// started game 2
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        ShieldsJames,
                        /// <summary>
                        /// started game 3
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        GarzaMatt,
                        /// <summary>
                        /// started game 4
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        SonnanstineAndy,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.PhiladelphiaPhillies)]
                [Manager((int)Managers.ManuelCharlie)]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        /// <summary>
                        /// started games 1 and 5
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        HamelsCole,
                        /// <summary>
                        /// started game 2
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        MyersBrett,
                        /// <summary>
                        /// started game 3
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        MoyerJamie,
                        /// <summary>
                        /// started game 4
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        BlantonJoe,
                    }
                }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.KazmirScott)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.HamelsCole)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.PhiladelphiaPhillies, 3, MajorLeagueBaseballTeams.TampaBayRays, 2)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.PhiladelphiaPhillies, 1, MajorLeagueBaseballTeams.TampaBayRays, 0)]
                public static class Game1 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.ShieldsJames)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.MyersBrett)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.TampaBayRays, 4, MajorLeagueBaseballTeams.PhiladelphiaPhillies, 2)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.TampaBayRays, 1, MajorLeagueBaseballTeams.PhiladelphiaPhillies, 1)]
                public static class Game2 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.GarzaMatt)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.MoyerJamie)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.PhiladelphiaPhillies, 5, MajorLeagueBaseballTeams.TampaBayRays, 4)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.PhiladelphiaPhillies, 2, MajorLeagueBaseballTeams.TampaBayRays, 1)]
                public static class Game3 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.SonnanstineAndy)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.BlantonJoe)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.PhiladelphiaPhillies, 10, MajorLeagueBaseballTeams.TampaBayRays, 2)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.PhiladelphiaPhillies, 3, MajorLeagueBaseballTeams.TampaBayRays, 1)]
                public static class Game4 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.KazmirScott)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.HamelsCole)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.PhiladelphiaPhillies, 4, MajorLeagueBaseballTeams.TampaBayRays, 3, "Suspended due to rain in the middle of the 6th inning with the score tied 2-2, and completed two days later")]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.PhiladelphiaPhillies, 4, MajorLeagueBaseballTeams.TampaBayRays, 1)]
                public static class Game5 { }
            }
        }

        public static class v2011
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(97, 65)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(91, 71)]
                        [Franchise(MajorLeagueBaseballFranchises.TampaBayDevilRays)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(69, 93)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(95, 67)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(80, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(63, 99)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(96, 66)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class LosAngelesAngelsOfAnaheim { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(67, 95)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(102, 60)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(80, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class WashingtonNationals { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class FloridaMarlins { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(96, 66)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(90, 72)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(56, 106)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(94, 68)]
                        [Franchise(MajorLeagueBaseballFranchises.PhoenixDiamondbacks)]
                        public static class ArizonaDiamondbacks { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(82, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.FreeseDavid, (int)MajorLeagueBaseballTeams.StLouisCardinals)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TexasRangers)]
                public static class AmericanLeagueTeam { }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.ThirdBase)]
                        FreeseDavid,
                    }
                }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                public static class Game5 { }

                public static class Game6 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.StLouisCardinals, 4, MajorLeagueBaseballTeams.TexasRangers, 3)]
                public static class Game7 { }
            }
        }

        public static class v2018
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(108, 54)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(100, 62)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.TampaBayDevilRays)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(47, 115)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(91, 71)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(64, 98)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(62, 100)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(58, 104)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(103, 59)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(97, 65)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(80, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class LosAngelesAngels { }
                        [TeamWinLossRecord(67, 95)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class WashingtonNationals { }
                        [TeamWinLossRecord(80, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(63, 98)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class MiamiMarlins { }
                    }
                    public static class Central
                    {
                        /// <summary>
                        /// tied with the Chicago Cubs at 95-67 and beat them 3-1 in the tiebreaker at Wrigley Field on October 1
                        /// </summary>
                        [TeamWinLossRecord(96, 67)]
                        [DivisionWinner(ONE_GAME_TIEBREAKER)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(95, 68)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(82, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(67, 95)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                    }
                    public static class West
                    {
                        /// <summary>
                        /// tied with the Colorado Rockies at 91-71 and beat them 5-2 in the tiebreaker at Dodger Stadium on October 1
                        /// </summary>
                        [TeamWinLossRecord(92, 71)]
                        [DivisionWinner(ONE_GAME_TIEBREAKER)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(91, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.PhoenixDiamondbacks)]
                        public static class ArizonaDiamondbacks { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(66, 96)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.PearceSteve, (int)MajorLeagueBaseballTeams.BostonRedSox)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.BostonRedSox)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.FirstBase)]
                        PearceSteve,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.LosAngelesDodgers)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.BostonRedSox, 4, MajorLeagueBaseballTeams.LosAngelesDodgers, 1)]
                public static class Game5 { }
            }
        }

        public static class v2020
        {
            public enum Managers
            {
                CashKevin,
                RobertsDave,
            }

            public static class AmericanLeague
            {
                // the 2020 All-Star Game was canceled due to COVID-19, so no All-Stars were selected
                public enum PitchingAllStars
                {
                    /// <summary>
                    /// not actually an All-Star
                    /// </summary>
                    [CyYoung]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.ClevelandIndians)]
                    BieberShane,
                }

                public enum BattingAllStars
                {
                    /// <summary>
                    /// not actually an All-Star
                    /// </summary>
                    [MostValuablePlayer]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.ChicagoWhiteSox)]
                    [FielderType(BaseballPositionType.FirstBase)]
                    AbreuJose,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(40, 20)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.TampaBayDevilRays)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(33, 27)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(32, 28)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(25, 35)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(24, 36)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(36, 24)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(35, 25)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(35, 25)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(26, 34)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(23, 35)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(36, 24)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(29, 31)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(27, 33)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(26, 34)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class LosAngelesAngels { }
                        [TeamWinLossRecord(22, 38)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                    }
                }
            }

            public static class NationalLeague
            {
                // the 2020 All-Star Game was canceled due to COVID-19, so no All-Stars were selected
                public enum PitchingAllStars
                {
                    /// <summary>
                    /// not actually an All-Star
                    /// </summary>
                    [CyYoung]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.CincinnatiReds)]
                    BauerTrevor,
                }

                public enum BattingAllStars
                {
                    /// <summary>
                    /// not actually an All-Star
                    /// </summary>
                    [MostValuablePlayer]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.AtlantaBraves)]
                    [FielderType(BaseballPositionType.FirstBase)]
                    FreemanFreddie,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(35, 25)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(31, 29)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class MiamiMarlins { }
                        [TeamWinLossRecord(28, 32)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(26, 34)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(26, 34)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class WashingtonNationals { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(34, 26)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(30, 28)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(31, 29)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(29, 31)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(19, 41)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(43, 17)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(37, 23)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(29, 31)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(26, 34)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(25, 35)]
                        [Franchise(MajorLeagueBaseballFranchises.PhoenixDiamondbacks)]
                        public static class ArizonaDiamondbacks { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.SeagerCorey, (int)MajorLeagueBaseballTeams.LosAngelesDodgers)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                [Manager((int)Managers.CashKevin)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        /// <summary>
                        /// started games 1 and 5
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        GlasnowTyler,
                        /// <summary>
                        /// started games 2 and 6
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        SnellBlake,
                        /// <summary>
                        /// started game 3
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        MortonCharlie,
                        /// <summary>
                        /// started game 4
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        YarbroughRyan,
                    }
                }

                /// <summary>
                /// the series was played at a neutral site, but the Dodgers were the designated home team for games 1, 2, 6, and 7
                /// </summary>
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.LosAngelesDodgers)]
                [Manager((int)Managers.RobertsDave)]
                [HomeFieldAdvantage]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        /// <summary>
                        /// started games 1 and 5
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        KershawClayton,
                        /// <summary>
                        /// started games 2 and 6
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        GonsolinTony,
                        /// <summary>
                        /// started game 3
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        BuehlerWalker,
                        /// <summary>
                        /// started game 4
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        UriasJulio,
                        [FielderType(BaseballPositionType.Shortstop)]
                        SeagerCorey,
                    }
                }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.GlasnowTyler)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.KershawClayton)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.LosAngelesDodgers, 8, MajorLeagueBaseballTeams.TampaBayRays, 3)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.LosAngelesDodgers, 1, MajorLeagueBaseballTeams.TampaBayRays, 0)]
                public static class Game1 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.SnellBlake)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.GonsolinTony)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.TampaBayRays, 6, MajorLeagueBaseballTeams.LosAngelesDodgers, 4)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.LosAngelesDodgers, 1, MajorLeagueBaseballTeams.TampaBayRays, 1)]
                public static class Game2 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.MortonCharlie)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.BuehlerWalker)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.LosAngelesDodgers, 6, MajorLeagueBaseballTeams.TampaBayRays, 2)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.LosAngelesDodgers, 2, MajorLeagueBaseballTeams.TampaBayRays, 1)]
                public static class Game3 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.YarbroughRyan)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.UriasJulio)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.TampaBayRays, 8, MajorLeagueBaseballTeams.LosAngelesDodgers, 7)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.LosAngelesDodgers, 2, MajorLeagueBaseballTeams.TampaBayRays, 2)]
                public static class Game4 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.GlasnowTyler)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.KershawClayton)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.LosAngelesDodgers, 4, MajorLeagueBaseballTeams.TampaBayRays, 2)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.LosAngelesDodgers, 3, MajorLeagueBaseballTeams.TampaBayRays, 2)]
                public static class Game5 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.SnellBlake)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.GonsolinTony)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.LosAngelesDodgers, 3, MajorLeagueBaseballTeams.TampaBayRays, 1)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.LosAngelesDodgers, 4, MajorLeagueBaseballTeams.TampaBayRays, 2)]
                public static class Game6 { }
            }
        }

        public static class v2021
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(100, 62)]
                        [Franchise(MajorLeagueBaseballFranchises.TampaBayDevilRays)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(92, 70)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(92, 70)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(91, 71)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(52, 110)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(93, 69)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(80, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(95, 67)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class LosAngelesAngels { }
                        [TeamWinLossRecord(60, 102)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(88, 73)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(67, 95)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class MiamiMarlins { }
                        [TeamWinLossRecord(65, 97)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class WashingtonNationals { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(95, 67)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(61, 101)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(107, 55)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(106, 56)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(74, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(52, 110)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.PhoenixDiamondbacks)]
                        public static class ArizonaDiamondbacks { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.SolerJorge, (int)MajorLeagueBaseballTeams.AtlantaBraves)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.HoustonAstros)]
                public static class AmericanLeagueTeam { }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.AtlantaBraves)]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.DesignatedHitter)]
                        SolerJorge,
                    }
                }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                public static class Game5 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.AtlantaBraves, 4, MajorLeagueBaseballTeams.HoustonAstros, 2)]
                public static class Game6 { }
            }
        }

        public static class v2023
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(101, 61)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(99, 63)]
                        [Franchise(MajorLeagueBaseballFranchises.TampaBayDevilRays)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandGuardians { }
                        [TeamWinLossRecord(61, 101)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(56, 106)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                    }
                    public static class West
                    {
                        /// <summary>
                        /// tied with the Texas Rangers at 90-72 and won the season series against them 9-4
                        /// </summary>
                        [TeamWinLossRecord(90, 72)]
                        [DivisionWinner(HEAD_TO_HEAD_SEASON_SERIES_TIEBREAKER)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(90, 72)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(73, 89)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class LosAngelesAngels { }
                        [TeamWinLossRecord(50, 112)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(104, 58)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(84, 78)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class MiamiMarlins { }
                        [TeamWinLossRecord(75, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class WashingtonNationals { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(92, 70)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(100, 62)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(84, 78)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.PhoenixDiamondbacks)]
                        public static class ArizonaDiamondbacks { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(59, 103)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)AmericanLeagueTeam.Roster.SeagerCorey, (int)MajorLeagueBaseballTeams.TexasRangers)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TexasRangers)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.Shortstop)]
                        SeagerCorey,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.ArizonaDiamondbacks)]
                public static class NationalLeagueTeam { }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.TexasRangers, 4, MajorLeagueBaseballTeams.ArizonaDiamondbacks, 1)]
                public static class Game5 { }
            }
        }

        public static class v2024
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(94, 68)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(91, 71)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(80, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.TampaBayDevilRays)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(74, 88)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(92, 69)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandGuardians { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(86, 76)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        /// <summary>
                        /// The 2024 White Sox went 41-121, the most losses by any team since 1900.
                        /// </summary>
                        [TeamWinLossRecord(41, 121)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(88, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(85, 77)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(69, 93)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(63, 99)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class LosAngelesAngels { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(95, 67)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class WashingtonNationals { }
                        [TeamWinLossRecord(62, 100)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class MiamiMarlins { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(93, 69)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(98, 64)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(93, 69)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.PhoenixDiamondbacks)]
                        public static class ArizonaDiamondbacks { }
                        [TeamWinLossRecord(80, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(61, 101)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.NationalLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.FreemanFreddie, (int)MajorLeagueBaseballTeams.LosAngelesDodgers)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.NewYorkYankees)]
                public static class AmericanLeagueTeam { }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.LosAngelesDodgers)]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.FirstBase)]
                        FreemanFreddie,
                    }
                }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.LosAngelesDodgers, 4, MajorLeagueBaseballTeams.NewYorkYankees, 1)]
                public static class Game5 { }
            }
        }

        public static class v2025
        {
            public static class AmericanLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        /// <summary>
                        /// tied with the New York Yankees at 94-68 and won the season series against them 8-5
                        /// </summary>
                        [TeamWinLossRecord(94, 68)]
                        [DivisionWinner(HEAD_TO_HEAD_SEASON_SERIES_TIEBREAKER)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                        [TeamWinLossRecord(94, 68)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(89, 73)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(77, 85)]
                        [Franchise(MajorLeagueBaseballFranchises.TampaBayDevilRays)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(75, 87)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(88, 74)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandGuardians { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(82, 80)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(70, 92)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(60, 102)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(87, 75)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class Athletics { }
                        [TeamWinLossRecord(72, 90)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class LosAngelesAngels { }
                    }
                }
            }

            public static class NationalLeague
            {
                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(96, 66)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(79, 83)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class MiamiMarlins { }
                        [TeamWinLossRecord(76, 86)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(66, 96)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class WashingtonNationals { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(97, 65)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(92, 70)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(83, 79)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(78, 84)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(71, 91)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(93, 69)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(90, 72)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(81, 81)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(80, 82)]
                        [Franchise(MajorLeagueBaseballFranchises.PhoenixDiamondbacks)]
                        public static class ArizonaDiamondbacks { }
                        /// <summary>
                        /// The 2025 Rockies went 43-119, tied with the 2003 Tigers for the third-most losses by any team since
                        /// 1900, after the 2024 White Sox (121) and the 1962 Mets (120).
                        /// </summary>
                        [TeamWinLossRecord(43, 119)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.YamamotoYoshinobu, (int)MajorLeagueBaseballTeams.LosAngelesDodgers)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TorontoBlueJays)]
                public static class AmericanLeagueTeam { }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.LosAngelesDodgers)]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        YamamotoYoshinobu,
                    }
                }

                public static class Game1 { }

                public static class Game2 { }

                public static class Game3 { }

                public static class Game4 { }

                public static class Game5 { }

                public static class Game6 { }

                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.LosAngelesDodgers, 4, MajorLeagueBaseballTeams.TorontoBlueJays, 3)]
                public static class Game7 { }
            }
        }

        public static class v2026
        {
            public enum Managers
            {
                AlbernazCraig,
                BooneAaron,
                ButeraBlake,
                CashKevin,
                /// <summary>
                /// fired on April 25 after a 10-17 start
                /// </summary>
                CoraAlex,
                CounsellCraig,
                EspadaJoe,
                FranconaTerry,
                /// <summary>
                /// interim manager after Carlos Mendoza was fired; named full-time manager on September 22
                /// </summary>
                GreenAndy,
                HinchAJ,
                KellyDon,
                KotsayMark,
                LovulloTorey,
                MarmolOliver,
                /// <summary>
                /// interim manager after Rob Thomson was fired; named full-time manager on October 14
                /// </summary>
                MattinglyDon,
                McCulloughClayton,
                /// <summary>
                /// fired on June 26 after a 34-47 start
                /// </summary>
                MendozaCarlos,
                MurphyPat,
                QuatraroMatt,
                RobertsDave,
                SchaefferWarren,
                SchneiderJohn,
                SchumakerSkip,
                SheltonDerek,
                StammenCraig,
                SuzukiKurt,
                /// <summary>
                /// fired on April 28 after a 9-19 start
                /// </summary>
                ThomsonRob,
                /// <summary>
                /// interim manager after Alex Cora was fired; named full-time manager on September 22
                /// </summary>
                TracyChad,
                VenableWill,
                VitelloTony,
                VogtStephen,
                WeissWalt,
                WilsonDan,
            }

            public static class AmericanLeague
            {
                public enum PitchingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    BakerBryan,
                    /// <summary>
                    /// injury replacement for Ranger Suárez
                    /// </summary>
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    MartinezNick,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    RasmussenDrew,
                }

                public enum BattingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    [FielderType(BaseballPositionType.ThirdBase)]
                    CamineroJunior,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    [FielderType(BaseballPositionType.DesignatedHitter)]
                    DiazYandy,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(98, 64)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        [Manager((int)Managers.CashKevin)]
                        [Franchise(MajorLeagueBaseballFranchises.TampaBayDevilRays)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(93, 68)]
                        [Manager((int)Managers.BooneAaron)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBronxYankees)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(87, 75)]
                        [Manager((int)Managers.CoraAlex, 2020, 11, 6, 2026, 4, 25)]
                        [FiredManager((int)Managers.CoraAlex, 2026, 4, 25)]
                        [Manager((int)Managers.TracyChad, 2026, 4, 26)]
                        [InterimManager((int)Managers.TracyChad, 2026, 4, 26, 2026, 9, 22)]
                        [Franchise(MajorLeagueBaseballFranchises.BostonRedSox)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(79, 82)]
                        [Manager((int)Managers.AlbernazCraig)]
                        [Franchise(MajorLeagueBaseballFranchises.BaltimoreOriolesAmericanLeague)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(79, 83)]
                        [Manager((int)Managers.SchneiderJohn)]
                        [Franchise(MajorLeagueBaseballFranchises.TorontoBlueJays)]
                        public static class TorontoBlueJays { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(85, 77)]
                        [Manager((int)Managers.VogtStephen)]
                        [Franchise(MajorLeagueBaseballFranchises.ClevelandIndiansAmericanLeague)]
                        public static class ClevelandGuardians { }
                        [TeamWinLossRecord(84, 78)]
                        [Manager((int)Managers.VenableWill)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoSouthWhiteSox)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(77, 85)]
                        [Manager((int)Managers.SheltonDerek)]
                        [Franchise(MajorLeagueBaseballFranchises.MinneapolisTwins)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(76, 86)]
                        [Manager((int)Managers.HinchAJ)]
                        [Franchise(MajorLeagueBaseballFranchises.DetroitTigers)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(69, 93)]
                        [Manager((int)Managers.QuatraroMatt)]
                        [Franchise(MajorLeagueBaseballFranchises.KansasCityRoyals)]
                        public static class KansasCityRoyals { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(81, 81)]
                        [Manager((int)Managers.EspadaJoe)]
                        [FiredManager((int)Managers.EspadaJoe, 2026, 10, 14, ManagerDismissalType.ContractNotRenewed)]
                        [Franchise(MajorLeagueBaseballFranchises.HoustonAstros)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(80, 82)]
                        [Manager((int)Managers.SchumakerSkip)]
                        [Franchise(MajorLeagueBaseballFranchises.DallasFortWorthRangers)]
                        public static class TexasRangers { }
                        [TeamWinLossRecord(76, 86)]
                        [Manager((int)Managers.WilsonDan)]
                        [FiredManager((int)Managers.WilsonDan, 2026, 9, 27)]
                        [Franchise(MajorLeagueBaseballFranchises.SeattleMariners)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(64, 98)]
                        [Manager((int)Managers.KotsayMark)]
                        [Franchise(MajorLeagueBaseballFranchises.OaklandAthletics)]
                        public static class Athletics { }
                        [TeamWinLossRecord(62, 100)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.AmericanLeague)]
                        [Manager((int)Managers.SuzukiKurt)]
                        [FiredManager((int)Managers.SuzukiKurt, 2026, 10, 21)]
                        [Franchise(MajorLeagueBaseballFranchises.AnaheimAngels)]
                        public static class LosAngelesAngels { }
                    }
                }
            }

            public static class NationalLeague
            {
                public enum PitchingAllStars
                {
                    /// <summary>
                    /// selected, but ineligible to pitch due to a recent start; replaced by Braxton Ashcraft
                    /// </summary>
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    MisiorowskiJacob,
                }

                public enum BattingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    [FielderType(BaseballPositionType.Catcher)]
                    ContrerasWilliam,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(94, 68)]
                        [Manager((int)Managers.WeissWalt)]
                        [Franchise(MajorLeagueBaseballFranchises.AtlantaBraves)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(88, 74)]
                        [Manager((int)Managers.ThomsonRob, 2022, 6, 3, 2026, 4, 28)]
                        [FiredManager((int)Managers.ThomsonRob, 2026, 4, 28)]
                        [Manager((int)Managers.MattinglyDon, 2026, 4, 28)]
                        [InterimManager((int)Managers.MattinglyDon, 2026, 4, 28, 2026, 10, 14)]
                        [Franchise(MajorLeagueBaseballFranchises.PhiladelphiaPhillies)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(80, 82)]
                        [Manager((int)Managers.McCulloughClayton)]
                        [Franchise(MajorLeagueBaseballFranchises.MiamiMarlins)]
                        public static class MiamiMarlins { }
                        [TeamWinLossRecord(77, 85)]
                        [Manager((int)Managers.ButeraBlake)]
                        [Franchise(MajorLeagueBaseballFranchises.MontrealExpos)]
                        public static class WashingtonNationals { }
                        [TeamWinLossRecord(74, 88)]
                        [Manager((int)Managers.MendozaCarlos, 2023, 11, 13, 2026, 6, 26)]
                        [FiredManager((int)Managers.MendozaCarlos, 2026, 6, 26)]
                        [Manager((int)Managers.GreenAndy, 2026, 6, 26)]
                        [InterimManager((int)Managers.GreenAndy, 2026, 6, 26, 2026, 9, 22)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityQueensMets)]
                        public static class NewYorkMets { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(103, 59)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        [Manager((int)Managers.MurphyPat)]
                        [Franchise(MajorLeagueBaseballFranchises.MilwaukeeBrewers)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(89, 73)]
                        [Manager((int)Managers.CounsellCraig)]
                        [Franchise(MajorLeagueBaseballFranchises.ChicagoNorthCubs)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(82, 80)]
                        [Manager((int)Managers.KellyDon)]
                        [Franchise(MajorLeagueBaseballFranchises.PittsburghPirates)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(77, 85)]
                        [Manager((int)Managers.MarmolOliver)]
                        [Franchise(MajorLeagueBaseballFranchises.StLouisCardinals)]
                        public static class StLouisCardinals { }
                        [TeamWinLossRecord(75, 87)]
                        [Manager((int)Managers.FranconaTerry)]
                        [Franchise(MajorLeagueBaseballFranchises.CincinnatiReds)]
                        public static class CincinnatiReds { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(100, 62)]
                        [Manager((int)Managers.RobertsDave)]
                        [Franchise(MajorLeagueBaseballFranchises.NewYorkCityBrooklynDodgers)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(91, 71)]
                        [Manager((int)Managers.StammenCraig)]
                        [Franchise(MajorLeagueBaseballFranchises.SanDiegoPadres)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(86, 76)]
                        [Manager((int)Managers.LovulloTorey)]
                        [Franchise(MajorLeagueBaseballFranchises.PhoenixDiamondbacks)]
                        public static class ArizonaDiamondbacks { }
                        [TeamWinLossRecord(65, 97)]
                        [Manager((int)Managers.VitelloTony)]
                        [Franchise(MajorLeagueBaseballFranchises.SanFranciscoGiants)]
                        public static class SanFranciscoGiants { }
                        [TeamWinLossRecord(58, 104)]
                        [WorstRecordInLeague(MajorLeagueBaseballLeagues.MajorLeagueBaseball)]
                        [Manager((int)Managers.SchaefferWarren)]
                        [Franchise(MajorLeagueBaseballFranchises.DenverRockies)]
                        public static class ColoradoRockies { }
                    }
                }
            }

            [BestOf(7)]
            [MostValuablePlayer((int)NationalLeagueTeam.Roster.ContrerasWilliam, (int)MajorLeagueBaseballTeams.MilwaukeeBrewers)]
            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                [Manager((int)Managers.CashKevin)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        MartinezNick,
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        RasmussenDrew,
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        PeraltaFreddy,
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        JaxGriffin,
                    }
                }

                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                [Manager((int)Managers.MurphyPat)]
                [HomeFieldAdvantage]
                public static class NationalLeagueTeam
                {
                    public enum Roster
                    {
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        MisiorowskiJacob,
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        HendersonLogan,
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        GasserRobert,
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        MayDustin,
                        [FielderType(BaseballPositionType.Catcher)]
                        ContrerasWilliam,
                    }
                }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.MartinezNick)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.MisiorowskiJacob)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 3, MajorLeagueBaseballTeams.TampaBayRays, 2,
                    HalfInningEndingPoint: BaseballHalfInningEndingPoint.AfterGameFinalBecauseHomeTeamAheadWithNoNeedToBat)]
                [AlternateMajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 3, MajorLeagueBaseballTeams.TampaBayRays, 1, 
                    "The simulation could have split at the 2nd to last at-bat with the possibility of watching the game from another universe with a different outcome", 
                    BaseballHalfInningEndingPoint.AfterGameFinalBecauseHomeTeamAheadWithNoNeedToBat)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.MilwaukeeBrewers, 1, MajorLeagueBaseballTeams.TampaBayRays, 0)]
                public static class Game1 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.RasmussenDrew)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.HendersonLogan)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 5, MajorLeagueBaseballTeams.TampaBayRays, 4,
                    HalfInningEndingPoint: BaseballHalfInningEndingPoint.AfterGameFinalBecauseHomeTeamAheadWithNoNeedToBat)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.MilwaukeeBrewers, 2, MajorLeagueBaseballTeams.TampaBayRays, 0)]
                public static class Game2 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.PeraltaFreddy)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.GasserRobert)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 10, MajorLeagueBaseballTeams.TampaBayRays, 1, 
                    "Brewers pitchers facing the minimum number of batters (pseudoperfect game) became impossible after a strikeout for the 27th batter with a runner on first base",
                    HalfInningEndingPoint: BaseballHalfInningEndingPoint.AfterRegularSizedGameFinal)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.MilwaukeeBrewers, 3, MajorLeagueBaseballTeams.TampaBayRays, 0)]
                public static class Game3 { }

                /// <summary>
                /// interesting moment
                /// In extra innings, Devil Rays at bat, score 2-2, 2 outs, runner on 2nd, 1-2 count, only needed a ball for 6 significant 2's, but the batter swung so that didn't happen (I don't remember if the pitch was in the strike zone)
                /// </summary>
                [StartingPitcher((int)AmericanLeagueTeam.Roster.JaxGriffin)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.MayDustin)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.TampaBayRays, 4, MajorLeagueBaseballTeams.MilwaukeeBrewers, 3, 
                    "Winning run scored in the bottom of the twelfth inning with no outs",
                    HalfInningEndingPoint: BaseballHalfInningEndingPoint.WalkoffTwelfthInningZeroOuts)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.MilwaukeeBrewers, 3, MajorLeagueBaseballTeams.TampaBayRays, 1)]
                public static class Game4 { }

                /// <summary>
                /// interesting fact: both the series result and the final game score was 4-1
                /// </summary>
                [StartingPitcher((int)AmericanLeagueTeam.Roster.RasmussenDrew)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.MisiorowskiJacob)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 4, MajorLeagueBaseballTeams.TampaBayRays, 1, 
                    HalfInningEndingPoint: BaseballHalfInningEndingPoint.AfterRegularSizedGameFinal)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.MilwaukeeBrewers, 4, MajorLeagueBaseballTeams.TampaBayRays, 1)]
                public static class Game5 { }
            }
        }
    }
}
