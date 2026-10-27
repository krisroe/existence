using Existence.Time;
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
        public string AlternateExplanation { get; set; }
        public AlternateMajorLeagueBaseballGameResultAttribute(MajorLeagueBaseballTeams WinningTeam, int WinningTeamRuns, MajorLeagueBaseballTeams LosingTeam, int LosingTeamRuns, string AlternateExplanation) : base(WinningTeam, WinningTeamRuns, LosingTeam, LosingTeamRuns)
        {
            this.AlternateExplanation = AlternateExplanation;
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

                /// <summary>
                /// suspended due to rain in the middle of the 6th inning with the score tied 2-2, and completed two days later
                /// </summary>
                [StartingPitcher((int)AmericanLeagueTeam.Roster.KazmirScott)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.HamelsCole)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.PhiladelphiaPhillies, 4, MajorLeagueBaseballTeams.TampaBayRays, 3)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.PhiladelphiaPhillies, 4, MajorLeagueBaseballTeams.TampaBayRays, 1)]
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
                        [TeamWinLossRecord(79, 82)]
                        [Manager((int)Managers.AlbernazCraig)]
                        public static class BaltimoreOrioles { }
                        [TeamWinLossRecord(87, 75)]
                        [Manager((int)Managers.CoraAlex, 2020, 11, 6, 2026, 4, 25)]
                        [FiredManager((int)Managers.CoraAlex, 2026, 4, 25)]
                        [Manager((int)Managers.TracyChad, 2026, 4, 26)]
                        [InterimManager((int)Managers.TracyChad, 2026, 4, 26, 2026, 9, 22)]
                        public static class BostonRedSox { }
                        [TeamWinLossRecord(93, 68)]
                        [Manager((int)Managers.BooneAaron)]
                        public static class NewYorkYankees { }
                        [TeamWinLossRecord(98, 64)]
                        [WorldSeries(TwoPlayerGameOutcome.Future)]
                        [Manager((int)Managers.CashKevin)]
                        public static class TampaBayRays { }
                        [TeamWinLossRecord(79, 83)]
                        [Manager((int)Managers.SchneiderJohn)]
                        public static class TorontoBlueJays { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(84, 78)]
                        [Manager((int)Managers.VenableWill)]
                        public static class ChicagoWhiteSox { }
                        [TeamWinLossRecord(85, 77)]
                        [Manager((int)Managers.VogtStephen)]
                        public static class ClevelandGuardians { }
                        [TeamWinLossRecord(76, 86)]
                        [Manager((int)Managers.HinchAJ)]
                        public static class DetroitTigers { }
                        [TeamWinLossRecord(69, 93)]
                        [Manager((int)Managers.QuatraroMatt)]
                        public static class KansasCityRoyals { }
                        [TeamWinLossRecord(77, 85)]
                        [Manager((int)Managers.SheltonDerek)]
                        public static class MinnesotaTwins { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(64, 98)]
                        [Manager((int)Managers.KotsayMark)]
                        public static class Athletics { }
                        [TeamWinLossRecord(81, 81)]
                        [Manager((int)Managers.EspadaJoe)]
                        [FiredManager((int)Managers.EspadaJoe, 2026, 10, 14, ManagerDismissalType.ContractNotRenewed)]
                        public static class HoustonAstros { }
                        [TeamWinLossRecord(62, 100)]
                        [Manager((int)Managers.SuzukiKurt)]
                        [FiredManager((int)Managers.SuzukiKurt, 2026, 10, 21)]
                        public static class LosAngelesAngels { }
                        [TeamWinLossRecord(76, 86)]
                        [Manager((int)Managers.WilsonDan)]
                        [FiredManager((int)Managers.WilsonDan, 2026, 9, 27)]
                        public static class SeattleMariners { }
                        [TeamWinLossRecord(80, 82)]
                        [Manager((int)Managers.SchumakerSkip)]
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
                        public static class AtlantaBraves { }
                        [TeamWinLossRecord(80, 82)]
                        [Manager((int)Managers.McCulloughClayton)]
                        public static class MiamiMarlins { }
                        [TeamWinLossRecord(74, 88)]
                        [Manager((int)Managers.MendozaCarlos, 2023, 11, 13, 2026, 6, 26)]
                        [FiredManager((int)Managers.MendozaCarlos, 2026, 6, 26)]
                        [Manager((int)Managers.GreenAndy, 2026, 6, 26)]
                        [InterimManager((int)Managers.GreenAndy, 2026, 6, 26, 2026, 9, 22)]
                        public static class NewYorkMets { }
                        [TeamWinLossRecord(88, 74)]
                        [Manager((int)Managers.ThomsonRob, 2022, 6, 3, 2026, 4, 28)]
                        [FiredManager((int)Managers.ThomsonRob, 2026, 4, 28)]
                        [Manager((int)Managers.MattinglyDon, 2026, 4, 28)]
                        [InterimManager((int)Managers.MattinglyDon, 2026, 4, 28, 2026, 10, 14)]
                        public static class PhiladelphiaPhillies { }
                        [TeamWinLossRecord(77, 85)]
                        [Manager((int)Managers.ButeraBlake)]
                        public static class WashingtonNationals { }
                    }
                    public static class Central
                    {
                        [TeamWinLossRecord(89, 73)]
                        [Manager((int)Managers.CounsellCraig)]
                        public static class ChicagoCubs { }
                        [TeamWinLossRecord(75, 87)]
                        [Manager((int)Managers.FranconaTerry)]
                        public static class CincinnatiReds { }
                        [TeamWinLossRecord(103, 59)]
                        [WorldSeries(TwoPlayerGameOutcome.Future)]
                        [Manager((int)Managers.MurphyPat)]
                        public static class MilwaukeeBrewers { }
                        [TeamWinLossRecord(82, 80)]
                        [Manager((int)Managers.KellyDon)]
                        public static class PittsburghPirates { }
                        [TeamWinLossRecord(77, 85)]
                        [Manager((int)Managers.MarmolOliver)]
                        public static class StLouisCardinals { }
                    }
                    public static class West
                    {
                        [TeamWinLossRecord(86, 76)]
                        [Manager((int)Managers.LovulloTorey)]
                        public static class ArizonaDiamondbacks { }
                        [TeamWinLossRecord(58, 104)]
                        [Manager((int)Managers.SchaefferWarren)]
                        public static class ColoradoRockies { }
                        [TeamWinLossRecord(100, 62)]
                        [Manager((int)Managers.RobertsDave)]
                        public static class LosAngelesDodgers { }
                        [TeamWinLossRecord(91, 71)]
                        [Manager((int)Managers.StammenCraig)]
                        public static class SanDiegoPadres { }
                        [TeamWinLossRecord(65, 97)]
                        [Manager((int)Managers.VitelloTony)]
                        public static class SanFranciscoGiants { }
                    }
                }
            }

            public static class WorldSeries
            {
                [MajorLeagueBaseballTeam(MajorLeagueBaseballTeams.TampaBayRays)]
                [Manager((int)Managers.CashKevin)]
                public static class AmericanLeagueTeam
                {
                    public enum Roster
                    {
                        /// <summary>
                        /// started game 1
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        MartinezNick,
                        /// <summary>
                        /// expected to start game 2
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        RasmussenDrew,
                        /// <summary>
                        /// expected to start game 3
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        PeraltaFreddy,
                        /// <summary>
                        /// expected to start game 4
                        /// </summary>
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
                        /// <summary>
                        /// started game 1
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        MisiorowskiJacob,
                        /// <summary>
                        /// expected to start game 2
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        HendersonLogan,
                        /// <summary>
                        /// expected to start game 3
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        GasserRobert,
                        /// <summary>
                        /// expected to start game 4, though the Brewers may use an opener in front of him
                        /// </summary>
                        [FielderType(BaseballPositionType.PitcherStarting)]
                        MayDustin,
                    }
                }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.MartinezNick)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.MisiorowskiJacob)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 3, MajorLeagueBaseballTeams.TampaBayRays, 2)]
                [AlternateMajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 3, MajorLeagueBaseballTeams.TampaBayRays, 1, "The simulation could have split at the 2nd to last at-bat with the possibility of watching the game from another universe with a different outcome")]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.MilwaukeeBrewers, 1, MajorLeagueBaseballTeams.TampaBayRays, 0)]
                public static class Game1 { }

                [StartingPitcher((int)AmericanLeagueTeam.Roster.RasmussenDrew)]
                [StartingPitcher((int)NationalLeagueTeam.Roster.HendersonLogan)]
                [MajorLeagueBaseballGameResult(MajorLeagueBaseballTeams.MilwaukeeBrewers, 5, MajorLeagueBaseballTeams.TampaBayRays, 4)]
                [MajorLeagueBaseballPlayoffSeries(MajorLeagueBaseballTeams.MilwaukeeBrewers, 2, MajorLeagueBaseballTeams.TampaBayRays, 0)]
                public static class Game2 { }

                [ExpectedStartingPitcher((int)AmericanLeagueTeam.Roster.PeraltaFreddy)]
                [ExpectedStartingPitcher((int)NationalLeagueTeam.Roster.GasserRobert)]
                public static class Game3 { }

                [ExpectedStartingPitcher((int)AmericanLeagueTeam.Roster.JaxGriffin)]
                [ExpectedStartingPitcher((int)NationalLeagueTeam.Roster.MayDustin)]
                public static class Game4 { }
            }
        }
    }
}
