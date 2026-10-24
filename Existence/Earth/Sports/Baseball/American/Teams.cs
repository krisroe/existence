using System;

namespace Existence.Earth.Sports.Baseball.American
{
    public enum MajorLeagueBaseballTeams
    {
        ArizonaDiamondbacks,
        Athletics,
        AtlantaBraves,
        BaltimoreOrioles,
        BostonRedSox,
        CaliforniaAngels,
        ChicagoCubs,
        ChicagoWhiteSox,
        CincinnatiReds,
        ClevelandGuardians,
        ClevelandIndians,
        ColoradoRockies,
        DetroitTigers,
        FloridaMarlins,
        HoustonAstros,
        KansasCityRoyals,
        LosAngelesAngels,
        LosAngelesAngelsOfAnaheim,
        LosAngelesDodgers,
        MiamiMarlins,
        MilwaukeeBrewers,
        MinnesotaTwins,
        MontrealExpos,
        NewYorkMets,
        NewYorkYankees,
        OaklandAthletics,
        PhiladelphiaPhillies,
        PittsburghPirates,
        SanDiegoPadres,
        SanFranciscoGiants,
        SeattleMariners,
        StLouisCardinals,
        TampaBayRays,
        TexasRangers,
        TorontoBlueJays,
        WashingtonNationals,
    }

    public class MajorLeagueBaseballTeamAttribute : SingularObjectAttribute
    {
        public MajorLeagueBaseballTeams Team { get; set; }
        public MajorLeagueBaseballTeamAttribute(MajorLeagueBaseballTeams Team)
        {
            this.Team = Team;
        }
    }

    public class MajorLeagueBaseballGameResultAttribute : Attribute
    {
        public MajorLeagueBaseballTeams WinningTeam { get; set; }
        public int WinningTeamRuns { get; set; }
        public MajorLeagueBaseballTeams LosingTeam { get; set; }
        public int LosingTeamRuns { get; set; }
        public MajorLeagueBaseballGameResultAttribute(MajorLeagueBaseballTeams WinningTeam, int WinningTeamRuns, MajorLeagueBaseballTeams LosingTeam, int LosingTeamRuns)
        {
            this.WinningTeam = WinningTeam;
            this.WinningTeamRuns = WinningTeamRuns;
            this.LosingTeam = LosingTeam;
            this.LosingTeamRuns = LosingTeamRuns;
        }
    }

    /// <summary>
    /// the game isn't finished; the winning and losing teams are the teams leading and trailing so far
    /// </summary>
    public class MajorLeagueBaseballGameResultInProgressAttribute : MajorLeagueBaseballGameResultAttribute
    {
        public MajorLeagueBaseballGameResultInProgressAttribute(MajorLeagueBaseballTeams WinningTeam, int WinningTeamRuns, MajorLeagueBaseballTeams LosingTeam, int LosingTeamRuns) : base(WinningTeam, WinningTeamRuns, LosingTeam, LosingTeamRuns)
        {
        }
    }

    public static class MajorLeagueBaseball
    {
        public static class v1982
        {
            public static class AmericanLeague
            {
                public enum PitchingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    RollieFingers,
                    /// <summary>
                    /// not actually an All-Star
                    /// </summary>
                    [CyYoung]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    PeteVuckovich,
                }

                public enum BattingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    [FielderType(BaseballPositionType.FirstBase)]
                    CecilCooper,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    [FielderType(BaseballPositionType.Outfield)]
                    BenOglivie,
                    [MostValuablePlayer]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    [FielderType(BaseballPositionType.Shortstop)]
                    RobinYount,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(94, 68)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(89, 73)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(78, 84)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(83, 79)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(95, 67)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(79, 83)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(78, 84)]
                        public static class TorontoBlueJays { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(93, 69)]
                        public static class CaliforniaAngels { }
                        [TeamWinLossRecord(87, 75)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(90, 72)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(60, 102)]
                        public static class MinnesotaTwins { }
                        [TeamWinLossRecord(68, 94)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(76, 86)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(64, 98)]
                        public static class TexasRangers { }
                    }
                }
            }

            public static class NationalLeague
            {
                public enum PitchingAllStars
                {
                    [CyYoung]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.PhiladelphiaPhillies)]
                    SteveCarlton,
                }

                public enum BattingAllStars
                {
                    [MostValuablePlayer]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.AtlantaBraves)]
                    [FielderType(BaseballPositionType.Outfield)]
                    DaleMurphy,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
                    [FielderType(BaseballPositionType.Outfield)]
                    LonnieSmith,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
                    [FielderType(BaseballPositionType.Shortstop)]
                    OzzieSmith,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(73, 89)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(86, 76)]
                        public static class MontrealExpos { }
                        [TeamWinLossRecord(65, 97)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(89, 73)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(84, 78)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(92, 70)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        public static class StLouisCardinals { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(89, 73)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(61, 101)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(77, 85)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(88, 74)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(81, 81)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(87, 75)]
                        public static class SanFranciscoGiants { }
                    }
                }
            }

            [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
            [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
            public static class WorldSeries
            {
                // Mike Caldwell started for the Brewers and Bob Forsch for the Cardinals, but neither is in an enum yet
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 10, MajorLeagueBaseballTeams.StLouisCardinals, 0)]
                public static class Game1 { }
            }
        }

        public static class v2008
        {
            public static class AmericanLeague
            {
                public enum PitchingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    ScottKazmir,
                    [CyYoung]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.ClevelandIndians)]
                    CliffLee,
                }

                public enum BattingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    [FielderType(BaseballPositionType.ThirdBase)]
                    EvanLongoria,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    [FielderType(BaseballPositionType.Catcher)]
                    DionerNavarro,
                    [MostValuablePlayer]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.BostonRedSox)]
                    [FielderType(BaseballPositionType.SecondBase)]
                    DustinPedroia,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(68, 93)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(95, 67)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(89, 73)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(97, 65)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(86, 76)]
                        public static class TorontoBlueJays { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(89, 74)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(81, 81)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(74, 88)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(75, 87)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(88, 75)]
                        public static class MinnesotaTwins { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(100, 62)]
                        public static class LosAngelesAngelsOfAnaheim { }
                        [TeamWinLossRecord(75, 86)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(61, 101)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(79, 83)]
                        public static class TexasRangers { }
                    }
                }
            }

            public static class NationalLeague
            {
                public enum PitchingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.PhiladelphiaPhillies)]
                    BradLidge,
                    /// <summary>
                    /// selected, but did not pitch due to flu-like symptoms
                    /// </summary>
                    [CyYoung]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.SanFranciscoGiants)]
                    TimLincecum,
                }

                public enum BattingAllStars
                {
                    /// <summary>
                    /// fan-elected starter at designated hitter
                    /// </summary>
                    [MostValuablePlayer]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
                    [FielderType(BaseballPositionType.DesignatedHitter)]
                    AlbertPujols,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.PhiladelphiaPhillies)]
                    [FielderType(BaseballPositionType.SecondBase)]
                    ChaseUtley,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(72, 90)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(84, 77)]
                        public static class FloridaMarlins { }
                        [TeamWinLossRecord(89, 73)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(92, 70)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(59, 102)]
                        public static class WashingtonNationals { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(97, 64)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(74, 88)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(86, 75)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(90, 72)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(67, 95)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(86, 76)]
                        public static class StLouisCardinals { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(82, 80)]
                        public static class ArizonaDiamondbacks { }
                        [TeamWinLossRecord(74, 88)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(84, 78)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(63, 99)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(72, 90)]
                        public static class SanFranciscoGiants { }
                    }
                }
            }

            [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
            [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.PhiladelphiaPhillies)]
            public static class WorldSeries
            {
                // Cole Hamels started for the Phillies, but isn't in an enum yet
                [StartingPitcher((int)AmericanLeague.PitchingAllStars.ScottKazmir)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.PhiladelphiaPhillies, 3, MajorLeagueBaseballTeams.TampaBayRays, 2)]
                public static class Game1 { }
            }
        }

        public static class v2020
        {
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
                    ShaneBieber,
                }

                public enum BattingAllStars
                {
                    /// <summary>
                    /// not actually an All-Star
                    /// </summary>
                    [MostValuablePlayer]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.ChicagoWhiteSox)]
                    [FielderType(BaseballPositionType.FirstBase)]
                    JoseAbreu,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(25, 35)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(24, 36)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(33, 27)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(40, 20)]
                        [WorldSeries(TwoPlayerGameOutcome.Loss)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(32, 28)]
                        public static class TorontoBlueJays { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(35, 25)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(35, 25)]
                        public static class ClevelandIndians { }
                        [TeamWinLossRecord(23, 35)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(26, 34)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(36, 24)]
                        public static class MinnesotaTwins { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(29, 31)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(26, 34)]
                        public static class LosAngelesAngels { }
                        [TeamWinLossRecord(36, 24)]
                        public static class OaklandAthletics { }
                        [TeamWinLossRecord(27, 33)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(22, 38)]
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
                    TrevorBauer,
                }

                public enum BattingAllStars
                {
                    /// <summary>
                    /// not actually an All-Star
                    /// </summary>
                    [MostValuablePlayer]
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.AtlantaBraves)]
                    [FielderType(BaseballPositionType.FirstBase)]
                    FreddieFreeman,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(35, 25)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(31, 29)]
                        public static class MiamiMarlins { }
                        [TeamWinLossRecord(26, 34)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(28, 32)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(26, 34)]
                        public static class WashingtonNationals { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(34, 26)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(31, 29)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(29, 31)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(19, 41)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(30, 28)]
                        public static class StLouisCardinals { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(25, 35)]
                        public static class ArizonaDiamondbacks { }
                        [TeamWinLossRecord(26, 34)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(43, 17)]
                        [WorldSeries(TwoPlayerGameOutcome.Win)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(37, 23)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(29, 31)]
                        public static class SanFranciscoGiants { }
                    }
                }
            }

            [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
            [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.LosAngelesDodgers)]
            public static class WorldSeries
            {
                // Tyler Glasnow started for the Rays and Clayton Kershaw for the Dodgers, but neither is in an enum yet
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.LosAngelesDodgers, 8, MajorLeagueBaseballTeams.TampaBayRays, 3)]
                public static class Game1 { }
            }
        }

        public static class v2026
        {
            public static class AmericanLeague
            {
                public enum PitchingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    BryanBaker,
                    /// <summary>
                    /// injury replacement for Ranger Suárez
                    /// </summary>
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    NickMartinez,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    DrewRasmussen,
                }

                public enum BattingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    [FielderType(BaseballPositionType.ThirdBase)]
                    JuniorCaminero,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    [FielderType(BaseballPositionType.DesignatedHitter)]
                    YandyDiaz,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(79, 82)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(87, 75)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(93, 68)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(98, 64)]
                        [WorldSeries(TwoPlayerGameOutcome.Future)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(79, 83)]
                        public static class TorontoBlueJays { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(84, 78)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(85, 77)]
                        public static class ClevelandGuardians { }
                        [TeamWinLossRecord(76, 86)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(69, 93)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(77, 85)]
                        public static class MinnesotaTwins { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(64, 98)]
                        public static class Athletics { }
                        [TeamWinLossRecord(81, 81)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(62, 100)]
                        public static class LosAngelesAngels { }
                        [TeamWinLossRecord(76, 86)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(80, 82)]
                        public static class TexasRangers { }
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
                    JacobMisiorowski,
                }

                public enum BattingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    [FielderType(BaseballPositionType.Catcher)]
                    WilliamContreras,
                }

                public static class Divisions
                {
                    public static class East
                    {
                        [TeamWinLossRecord(94, 68)]
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(80, 82)]
                        public static class MiamiMarlins { }
                        [TeamWinLossRecord(74, 88)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(88, 74)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(77, 85)]
                        public static class WashingtonNationals { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(89, 73)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(75, 87)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(103, 59)]
                        [WorldSeries(TwoPlayerGameOutcome.Future)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(82, 80)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(77, 85)]
                        public static class StLouisCardinals { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(86, 76)]
                        public static class ArizonaDiamondbacks { }
                        [TeamWinLossRecord(58, 104)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(100, 62)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(91, 71)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(65, 97)]
                        public static class SanFranciscoGiants { }
                    }
                }
            }

            [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
            [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
            public static class WorldSeries
            {
                [StartingPitcher((int)AmericanLeague.PitchingAllStars.NickMartinez)]
                [StartingPitcher((int)NationalLeague.PitchingAllStars.JacobMisiorowski)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 3, MajorLeagueBaseballTeams.TampaBayRays, 2)]
                public static class Game1 { }
            }
        }
    }
}
