using Existence.Logic.Games.Cards;
using Existence.Logic.Games.Cards.Rules;
using System.Collections.Generic;

namespace Existence.Logic.Games.Cards.Rules.Game.Bridge
{
    public class Rules : SpecificRules
    {
        public Rules() : base(GameType.Bridge)
        {
            MaximumNumberOfCards = 52;
            MinimumNumberOfCards = 52;
            MaximumNumberOfPlayers = 4;
            MinimumNumberOfPlayers = 4;
            MaximumNumberOfSuits = 4;
            MinimumNumberOfSuits = 4;
            SuitsOrdered = true;
        }

        public override List<Suit.Logic.Suits> GetSuits()
        {
            return Suit.Logic.GetSuits(MinimumNumberOfSuits, this, null);
        }
    }
}
