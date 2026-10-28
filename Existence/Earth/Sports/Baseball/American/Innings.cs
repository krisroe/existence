namespace Existence.Earth.Sports.Baseball.American
{
    /// <summary>
    /// points in a baseball game where a half inning ends; the number is how many half innings have been completed
    /// </summary>
    public enum BaseballHalfInningEndingPoint
    {
        Start = 0,
        AfterFirstTop = 1,
        AfterFirstBottom = 2,
        AfterSecondTop = 3,
        AfterSecondBottom = 4,
        AfterThirdTop = 5,
        AfterThirdBottom = 6,
        /// <summary>
        /// one third of the way through a regular nine inning game (6 of 18 half innings)
        /// </summary>
        OneThird = 6,
        AfterFourthTop = 7,
        AfterFourthBottom = 8,
        AfterFifthTop = 9,
        /// <summary>
        /// halfway through a regular nine inning game (9 of 18 half innings)
        /// </summary>
        Halfway = 9,
        AfterFifthBottom = 10,
        AfterSixthTop = 11,
        AfterSixthBottom = 12,
        /// <summary>
        /// two thirds of the way through a regular nine inning game (12 of 18 half innings)
        /// </summary>
        TwoThirds = 12,
        AfterSeventhTop = 13,
        /// <summary>
        /// where traditionally "Take me out to the Ballgame" is perfomed
        /// </summary>
        SeventhInningStretch = 13,
        AfterSeventhBottom = 14,
        AfterEighthTop = 15,
        AfterEighthBottom = 16,
        AfterNinthTop = 17,
        AfterNinthBottom = 18,
        AfterTenthTop = 19,
        AfterTenthBottom = 20,
        AfterEleventhTop = 21,
        AfterEleventhBottom = 22,
        AfterTwelfthTop = 23,
        AfterTwelfthBottom = 24,
        AfterThirteenthTop = 25,
        AfterThirteenthBottom = 26,
        AfterFourteenthTop = 27,
        AfterFourteenthBottom = 28,
        AfterFifteenthTop = 29,
        AfterFifteenthBottom = 30,
        AfterSixteenthTop = 31,
        AfterSixteenthBottom = 32,
        AfterSeventeenthTop = 33,
        AfterSeventeenthBottom = 34,
        AfterEighteenthTop = 35,
        AfterEighteenthBottom = 36,
        AfterNineteenthTop = 37,
        AfterNineteenthBottom = 38,
        AfterTwentiethTop = 39,
        AfterTwentiethBottom = 40,
        AfterTwentyFirstTop = 41,
        AfterTwentyFirstBottom = 42,
        AfterTwentySecondTop = 43,
        AfterTwentySecondBottom = 44,
        AfterTwentyThirdTop = 45,
        AfterTwentyThirdBottom = 46,
        AfterTwentyFourthTop = 47,
        AfterTwentyFourthBottom = 48,
        AfterTwentyFifthTop = 49,
        AfterTwentyFifthBottom = 50,
        AfterTwentySixthTop = 51,
        /// <summary>
        /// the end of the longest major league game by innings: the Brooklyn Robins and Boston Braves played to a 1-1
        /// tie over 26 innings on 1920-05-01
        /// </summary>
        AfterTwentySixthBottom = 52,
        AfterTwentySeventhTop = 53,
        AfterTwentySeventhBottom = 54,
        AfterTwentyEighthTop = 55,
        AfterTwentyEighthBottom = 56,
        AfterTwentyNinthTop = 57,
        AfterTwentyNinthBottom = 58,
        AfterThirtiethTop = 59,
        AfterThirtiethBottom = 60,
        AfterThirtyFirstTop = 61,
        AfterThirtyFirstBottom = 62,
        AfterThirtySecondTop = 63,
        /// <summary>
        /// where the longest professional game, Rochester Red Wings at Pawtucket Red Sox (Triple-A), was suspended
        /// early on 1981-04-19 with the score tied 2-2
        /// </summary>
        AfterThirtySecondBottom = 64,
        AfterThirtyThirdTop = 65,
        /// <summary>
        /// the end of the longest professional game by innings: Pawtucket beat Rochester 3-2 when the game resumed on
        /// 1981-06-23
        /// </summary>
        AfterThirtyThirdBottom = 66,
        /// <summary>
        /// uncharted territory
        /// </summary>
        AfterThirtyFourthTop = 67,
        /// <summary>
        /// more uncharted territory, the enum stops here
        /// </summary>
        AfterThirtyFourthBottom = 68,
    }
}
