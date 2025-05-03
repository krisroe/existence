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
}
