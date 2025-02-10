using System;
using Existence.Earth.Sports.Football.American.Players.Defensive;

namespace Existence.Earth.Sports.Football.American
{
    public class PlayerTypeAttribute : Attribute
    {
        public string PlayerType { get; set; }
        public PlayerTypeAttribute(Players.Offensive.PlayerType PlayerType)
        {
            this.PlayerType = PlayerType.ToString();
        }
        public PlayerTypeAttribute(Players.Defensive.PlayerType PlayerType)
        {
            this.PlayerType = PlayerType.ToString();
        }
        public PlayerTypeAttribute(Players.SpecialTeams.PlayerType PlayerType)
        {
            this.PlayerType = PlayerType.ToString();
        }
    }

    public class CoachTypeAttribute : Attribute
    {
        public CoachType CoachType { get; set; }
        public CoachTypeAttribute(CoachType CoachType)
        {
            this.CoachType = CoachType;
        }
    }

    public class AnnouncerTypeAttribute : Attribute
    {
        public AnnouncerType AnnouncerType { get; set; }
        public AnnouncerTypeAttribute(AnnouncerType AnnouncerType)
        {
            this.AnnouncerType = AnnouncerType;
        }
    }

    public class CoverageTypeAttribute : Attribute
    {
        public CoverageType CoverageType { get; set; }
        public CoverageTypeAttribute(CoverageType CoverageType)
        {
            this.CoverageType = CoverageType;
        }
    }

    namespace Players
    {
        namespace Offensive
        {
            public enum PlayerType
            {
                Center,
                Fullback,
                OffensiveGuard,
                OffensiveTackle,
                RunningBack,
                Quarterback,
                TightEnd,
                WideReceiver,
            }
        }
        namespace Defensive
        {
            public enum PlayerType
            {
                DefensiveEnd,
                DefensiveTackle,
                NoseTackle,
                OutsideLinebacker,
                MiddleLinebacker,
                Cornerback,
                FreeSafety,
                StrongSafety,
            }
        }
        namespace SpecialTeams
        {
            public enum PlayerType
            {
                Kicker,
                LongSnapper,
                Punter
            }
        }
    }
    public enum CoverageType
    {
        Radio,
        Television,
    }
    public enum AnnouncerType
    {
        Color,
        PlayByPlay,
    }
    public enum CoachType
    {
        HeadCoach,
        OffensiveCoordinator,
        DefensiveCoordinator,
    }
}
