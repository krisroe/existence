using System;
using Existence.Earth.Sports.Football.American.Coaches;
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
    namespace Coaches
    {
        public enum CoachType
        {
            HeadCoach,
        }
    }
}
