using Existence.Logic.Games.Cards.Rules;

namespace Existence.Logic.Games.Cards.Rules.Suit
{
    public static class Logic
    {
        /// <summary>
        /// the standard suits
        /// </summary>
        public enum Suits
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades,
        }

        /// <summary>
        /// whether the suits are ordered
        /// </summary>
        public enum SuitOrderType
        {
            Random,
            Ordered,
        }

        /// <summary>
        /// retrieves a list of suits given the base rules
        /// </summary>
        /// <param name="n">number of suits</param>
        /// <param name="r">base rules</param>
        /// <returns>list of suits</returns>
        public static List<Suits> GetSuits(int n, BaseRules rules, bool? randomize)
        {
            List<Suits> r = new List<Suits>(n);
            if (n == 4)
            {
                r.Add(Suits.Spades);
                r.Add(Suits.Hearts);
                r.Add(Suits.Diamonds);
                r.Add(Suits.Clubs);
            }
            else
            {
                throw new InvalidOperationException();
            }

            if (randomize.HasValue && randomize.Value)
            {

            }

            return r;
        }
    }
}
