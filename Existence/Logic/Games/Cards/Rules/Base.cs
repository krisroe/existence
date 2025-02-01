using Existence.Logic.Games.Cards;

namespace Existence.Logic.Games.Cards.Rules
{
    public class BaseRules
    {
        /// <summary>
        /// minimum number of players
        /// </summary>
        protected int MinimumNumberOfPlayers { get; set; }
        /// <summary>
        /// maximum number of players
        /// </summary>
        protected int MaximumNumberOfPlayers { get; set; }
        /// <summary>
        /// minimum number of cards
        /// </summary>
        protected int MinimumNumberOfCards { get; set; }
        /// <summary>
        /// maximum number of cards
        /// </summary>
        protected int MaximumNumberOfCards { get; set; }
        /// <summary>
        /// minimum number of suits
        /// </summary>
        protected int MinimumNumberOfSuits { get; set; }
        /// <summary>
        /// maximum number of suits
        /// </summary>
        protected int MaximumNumberOfSuits { get; set; }
        /// <summary>
        /// whether suits are ordered
        /// </summary>
        protected bool SuitsOrdered { get; set; }
    }

    public class SpecificRules : BaseRules
    {
        public SpecificRules(GameType g)
        {
        }

        public virtual List<Suit.Logic.Suits> GetSuits()
        {
            return new List<Suit.Logic.Suits>();
        }
    }
}
