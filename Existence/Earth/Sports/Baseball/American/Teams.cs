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

    public class MajorLeagueBaseballTeamAttribute : Attribute
    {
        public MajorLeagueBaseballTeams Team { get; set; }
        public MajorLeagueBaseballTeamAttribute(MajorLeagueBaseballTeams Team)
        {
            this.Team = Team;
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
                    /// not actually an All-Star; included as the AL Cy Young Award winner
                    /// </summary>
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    PeteVuckovich,
                }

                public enum BattingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    [FielderType(FielderType.FirstBase)]
                    CecilCooper,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    [FielderType(FielderType.Outfield)]
                    BenOglivie,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.MilwaukeeBrewers)]
                    [FielderType(FielderType.Shortstop)]
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
                    /// <summary>
                    /// NL Cy Young Award winner
                    /// </summary>
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.PhiladelphiaPhillies)]
                    SteveCarlton,
                }

                public enum BattingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
                    [FielderType(FielderType.Outfield)]
                    LonnieSmith,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.StLouisCardinals)]
                    [FielderType(FielderType.Shortstop)]
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
        }

        public static class v2008
        {
            public static class AmericanLeague
            {
                public enum PitchingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    ScottKazmir,
                    /// <summary>
                    /// AL Cy Young Award winner
                    /// </summary>
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.ClevelandIndians)]
                    CliffLee,
                }

                public enum BattingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    [FielderType(FielderType.ThirdBase)]
                    EvanLongoria,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    [FielderType(FielderType.Catcher)]
                    DionerNavarro,
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
                    /// NL Cy Young Award winner; selected, but did not pitch due to flu-like symptoms
                    /// </summary>
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.SanFranciscoGiants)]
                    TimLincecum,
                }

                public enum BattingAllStars
                {
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.PhiladelphiaPhillies)]
                    [FielderType(FielderType.SecondBase)]
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
        }

        public static class v2020
        {
            public static class AmericanLeague
            {
                // the 2020 All-Star Game was canceled due to COVID-19, so no All-Stars were selected
                public enum PitchingAllStars
                {
                    /// <summary>
                    /// not actually an All-Star; included as the AL Cy Young Award winner
                    /// </summary>
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.ClevelandIndians)]
                    ShaneBieber,
                }

                public enum BattingAllStars
                {
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
                    /// not actually an All-Star; included as the NL Cy Young Award winner
                    /// </summary>
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.CincinnatiReds)]
                    TrevorBauer,
                }

                public enum BattingAllStars
                {
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
                    [FielderType(FielderType.ThirdBase)]
                    JuniorCaminero,
                    [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                    [FielderType(FielderType.DesignatedHitter)]
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
                    [FielderType(FielderType.Catcher)]
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
        }
    }
}
