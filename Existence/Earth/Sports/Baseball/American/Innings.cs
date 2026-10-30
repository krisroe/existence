namespace Existence.Earth.Sports.Baseball.American
{
    /// <summary>
    /// points in a baseball game where a half inning ends; through the top of the ninth the number is how many half
    /// innings have been completed, and from the ninth inning on it's offset by the walkoff entries (three per inning
    /// for the ninth through thirty-fourth innings)
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
        AfterGameFinalBecauseHomeTeamAheadWithNoNeedToBat = 17,
        WalkoffNinthInningZeroOuts = 18,
        WalkoffNinthInningOneOut = 19,
        WalkoffNinthInningTwoOuts = 20,
        AfterNinthBottom = 21,
        /// <summary>
        /// full 9 inning game (most common length)
        /// </summary>
        AfterRegularSizedGameFinal = 21,
        /// <summary>
        /// full 9 inning game but it's tied (so it either goes to extra innings or the tie is final)
        /// </summary>
        EndOfRegulation = 21,
        AfterTenthTop = 22,
        WalkoffTenthInningZeroOuts = 23,
        WalkoffTenthInningOneOut = 24,
        WalkoffTenthInningTwoOuts = 25,
        AfterTenthBottom = 26,
        AfterEleventhTop = 27,
        WalkoffEleventhInningZeroOuts = 28,
        WalkoffEleventhInningOneOut = 29,
        WalkoffEleventhInningTwoOuts = 30,
        AfterEleventhBottom = 31,
        AfterTwelfthTop = 32,
        WalkoffTwelfthInningZeroOuts = 33,
        WalkoffTwelfthInningOneOut = 34,
        WalkoffTwelfthInningTwoOuts = 35,
        AfterTwelfthBottom = 36,
        /// <summary>
        /// extra innings containing an extra one third of a regular game (either a win for the visitors or a tie)
        /// </summary>
        ExtraOneThird = 36,
        AfterThirteenthTop = 37,
        WalkoffThirteenthInningZeroOuts = 38,
        WalkoffThirteenthInningOneOut = 39,
        WalkoffThirteenthInningTwoOuts = 40,
        AfterThirteenthBottom = 41,
        AfterFourteenthTop = 42,
        WalkoffFourteenthInningZeroOuts = 43,
        WalkoffFourteenthInningOneOut = 44,
        WalkoffFourteenthInningTwoOuts = 45,
        AfterFourteenthBottom = 46,
        AfterFifteenthTop = 47,
        WalkoffFifteenthInningZeroOuts = 48,
        WalkoffFifteenthInningOneOut = 49,
        WalkoffFifteenthInningTwoOuts = 50,
        AfterFifteenthBottom = 51,
        AfterSixteenthTop = 52,
        WalkoffSixteenthInningZeroOuts = 53,
        WalkoffSixteenthInningOneOut = 54,
        WalkoffSixteenthInningTwoOuts = 55,
        AfterSixteenthBottom = 56,
        AfterSeventeenthTop = 57,
        WalkoffSeventeenthInningZeroOuts = 58,
        WalkoffSeventeenthInningOneOut = 59,
        WalkoffSeventeenthInningTwoOuts = 60,
        AfterSeventeenthBottom = 61,
        AfterEighteenthTop = 62,
        WalkoffEighteenthInningZeroOuts = 63,
        WalkoffEighteenthInningOneOut = 64,
        WalkoffEighteenthInningTwoOuts = 65,
        AfterEighteenthBottom = 66,
        AfterNineteenthTop = 67,
        WalkoffNineteenthInningZeroOuts = 68,
        WalkoffNineteenthInningOneOut = 69,
        WalkoffNineteenthInningTwoOuts = 70,
        AfterNineteenthBottom = 71,
        AfterTwentiethTop = 72,
        WalkoffTwentiethInningZeroOuts = 73,
        WalkoffTwentiethInningOneOut = 74,
        WalkoffTwentiethInningTwoOuts = 75,
        AfterTwentiethBottom = 76,
        AfterTwentyFirstTop = 77,
        WalkoffTwentyFirstInningZeroOuts = 78,
        WalkoffTwentyFirstInningOneOut = 79,
        WalkoffTwentyFirstInningTwoOuts = 80,
        AfterTwentyFirstBottom = 81,
        AfterTwentySecondTop = 82,
        WalkoffTwentySecondInningZeroOuts = 83,
        WalkoffTwentySecondInningOneOut = 84,
        WalkoffTwentySecondInningTwoOuts = 85,
        AfterTwentySecondBottom = 86,
        AfterTwentyThirdTop = 87,
        WalkoffTwentyThirdInningZeroOuts = 88,
        WalkoffTwentyThirdInningOneOut = 89,
        WalkoffTwentyThirdInningTwoOuts = 90,
        AfterTwentyThirdBottom = 91,
        AfterTwentyFourthTop = 92,
        WalkoffTwentyFourthInningZeroOuts = 93,
        WalkoffTwentyFourthInningOneOut = 94,
        WalkoffTwentyFourthInningTwoOuts = 95,
        AfterTwentyFourthBottom = 96,
        AfterTwentyFifthTop = 97,
        WalkoffTwentyFifthInningZeroOuts = 98,
        WalkoffTwentyFifthInningOneOut = 99,
        WalkoffTwentyFifthInningTwoOuts = 100,
        AfterTwentyFifthBottom = 101,
        AfterTwentySixthTop = 102,
        WalkoffTwentySixthInningZeroOuts = 103,
        WalkoffTwentySixthInningOneOut = 104,
        WalkoffTwentySixthInningTwoOuts = 105,
        /// <summary>
        /// the end of the longest major league game by innings: the Brooklyn Robins and Boston Braves played to a 1-1
        /// tie over 26 innings on 1920-05-01
        /// </summary>
        AfterTwentySixthBottom = 106,
        AfterTwentySeventhTop = 107,
        WalkoffTwentySeventhInningZeroOuts = 108,
        WalkoffTwentySeventhInningOneOut = 109,
        WalkoffTwentySeventhInningTwoOuts = 110,
        AfterTwentySeventhBottom = 111,
        AfterTwentyEighthTop = 112,
        WalkoffTwentyEighthInningZeroOuts = 113,
        WalkoffTwentyEighthInningOneOut = 114,
        WalkoffTwentyEighthInningTwoOuts = 115,
        AfterTwentyEighthBottom = 116,
        AfterTwentyNinthTop = 117,
        WalkoffTwentyNinthInningZeroOuts = 118,
        WalkoffTwentyNinthInningOneOut = 119,
        WalkoffTwentyNinthInningTwoOuts = 120,
        AfterTwentyNinthBottom = 121,
        AfterThirtiethTop = 122,
        WalkoffThirtiethInningZeroOuts = 123,
        WalkoffThirtiethInningOneOut = 124,
        WalkoffThirtiethInningTwoOuts = 125,
        AfterThirtiethBottom = 126,
        AfterThirtyFirstTop = 127,
        WalkoffThirtyFirstInningZeroOuts = 128,
        WalkoffThirtyFirstInningOneOut = 129,
        WalkoffThirtyFirstInningTwoOuts = 130,
        AfterThirtyFirstBottom = 131,
        AfterThirtySecondTop = 132,
        WalkoffThirtySecondInningZeroOuts = 133,
        WalkoffThirtySecondInningOneOut = 134,
        WalkoffThirtySecondInningTwoOuts = 135,
        /// <summary>
        /// where the longest professional game, Rochester Red Wings at Pawtucket Red Sox (Triple-A), was suspended
        /// early on 1981-04-19 with the score tied 2-2
        /// </summary>
        AfterThirtySecondBottom = 136,
        AfterThirtyThirdTop = 137,
        /// <summary>
        /// the end of the longest professional game by innings: Pawtucket beat Rochester 3-2 when the game resumed on
        /// 1981-06-23
        /// </summary>
        WalkoffThirtyThirdInningZeroOuts = 138,
        WalkoffThirtyThirdInningOneOut = 139,
        WalkoffThirtyThirdInningTwoOuts = 140,
        AfterThirtyThirdBottom = 141,
        /// <summary>
        /// uncharted territory
        /// </summary>
        AfterThirtyFourthTop = 142,
        /// <summary>
        /// uncharted territory
        /// </summary>
        WalkoffThirtyFourthInningZeroOuts = 143,
        /// <summary>
        /// uncharted territory
        /// </summary>
        WalkoffThirtyFourthInningOneOut = 144,
        /// <summary>
        /// uncharted territory
        /// </summary>
        WalkoffThirtyFourthInningTwoOuts = 145,
        /// <summary>
        /// more uncharted territory, the enum stops here
        /// </summary>
        AfterThirtyFourthBottom = 146,
    }
}
