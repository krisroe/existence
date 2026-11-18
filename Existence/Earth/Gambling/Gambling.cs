using System;
using Existence.Earth.Countries;

namespace Existence.Earth.Gambling
{
    public class OddsAttribute : Attribute
    {
        public double OddsFirstNumber { get; set; }
        public double OddsToNumber { get; set; }
        public OddsAttribute(double OddsFirstNumber, double OddsToNumber)
        {
            this.OddsFirstNumber = OddsFirstNumber;
            this.OddsToNumber = OddsToNumber;
        }
    }
    public class BetAttribute : Attribute
    {
        public string Target { get; set; }
        public double Amount { get; set; }
        public Currencies Currency { get; set; }

        public BetAttribute(string Target, double Amount, Currencies Currency)
        {
            this.Target = Target;
            this.Amount = Amount;
            this.Currency = Currency;
        }
    }

    /// <summary>
    /// cards in a standard deck of playing cards: 52 cards in four French suits plus two jokers
    /// </summary>
    /// <remarks>
    /// the two jokers are often distinguished (e.g. by colour) but not consistently between decks, so they are only numbered here
    /// </remarks>
    public enum StandardPlayingCard
    {
        SpadesAce,
        SpadesTwo,
        SpadesThree,
        SpadesFour,
        SpadesFive,
        SpadesSix,
        SpadesSeven,
        SpadesEight,
        SpadesNine,
        SpadesTen,
        SpadesJack,
        SpadesQueen,
        SpadesKing,

        HeartsAce,
        HeartsTwo,
        HeartsThree,
        HeartsFour,
        HeartsFive,
        HeartsSix,
        HeartsSeven,
        HeartsEight,
        HeartsNine,
        HeartsTen,
        HeartsJack,
        HeartsQueen,
        HeartsKing,

        DiamondsAce,
        DiamondsTwo,
        DiamondsThree,
        DiamondsFour,
        DiamondsFive,
        DiamondsSix,
        DiamondsSeven,
        DiamondsEight,
        DiamondsNine,
        DiamondsTen,
        DiamondsJack,
        DiamondsQueen,
        DiamondsKing,

        ClubsAce,
        ClubsTwo,
        ClubsThree,
        ClubsFour,
        ClubsFive,
        ClubsSix,
        ClubsSeven,
        ClubsEight,
        ClubsNine,
        ClubsTen,
        ClubsJack,
        ClubsQueen,
        ClubsKing,

        Joker1,
        Joker2,
    }
}
