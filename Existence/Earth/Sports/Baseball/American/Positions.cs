using System;

namespace Existence.Earth.Sports.Baseball.American
{
    /// <summary>
    /// position types used in baseball
    /// </summary>
    public enum BaseballPositionType
    {
        /// <summary>
        /// outfield
        /// </summary>
        Outfield,
        /// <summary>
        /// 1st base
        /// </summary>
        FirstBase,
        /// <summary>
        /// 2nd base
        /// </summary>
        SecondBase,
        /// <summary>
        /// 3rd base
        /// </summary>
        ThirdBase,
        /// <summary>
        /// shortstop
        /// </summary>
        Shortstop,
        /// <summary>
        /// catcher
        /// </summary>
        Catcher,
        /// <summary>
        /// pitcher
        /// </summary>
        Pitcher,
        /// <summary>
        /// starting pitcher
        /// </summary>
        PitcherStarting,
        /// <summary>
        /// relief pitcher
        /// </summary>
        PitcherRelief,
        /// <summary>
        /// closing relief pitcher
        /// </summary>
        PitcherReliefCloser,
        /// <summary>
        /// middle relief pitcher (intermediate stretches)
        /// </summary>
        PitcherReliefMiddle,
        /// <summary>
        /// long relief pitcher (long stretches)
        /// </summary>
        PitcherReliefLong,
        /// <summary>
        /// designated hitter
        /// </summary>
        DesignatedHitter,
    }

    public class FielderTypeAttribute : Attribute
    {
        public BaseballPositionType FielderType { get; set; }
        public FielderTypeAttribute(BaseballPositionType FielderType)
        {
            this.FielderType = FielderType;
        }
    }

    /// <summary>
    /// the pitcher can come from different enums (e.g. PitchingAllStars), so it's stored as an int;
    /// apply once per team that started a pitcher in the game
    /// </summary>
    public class StartingPitcherAttribute : SingularObjectAttribute
    {
        public int Pitcher { get; set; }
        public StartingPitcherAttribute(int Pitcher)
        {
            this.Pitcher = Pitcher;
        }
    }

    /// <summary>
    /// same as StartingPitcher, but for a game that hasn't taken place yet;
    /// apply once per team that is expected to start a pitcher in the game
    /// </summary>
    public class ExpectedStartingPitcherAttribute : SingularObjectAttribute
    {
        public int Pitcher { get; set; }
        public ExpectedStartingPitcherAttribute(int Pitcher)
        {
            this.Pitcher = Pitcher;
        }
    }
}
