using Existence.Logic.Games.Cards;
using Existence.Logic.Games.Cards.Rules;

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
    }
}
