using System;
using Existence.Earth.FieldsOfStudy.Mathematics;

namespace Existence.Earth.Countries
{
    public enum Currencies
    {
        UnitedStatesDollar,
    }

    public class CurrencyAmountAttribute : Attribute
    {
        public Currencies Currency { get; set; }
        public int Amount { get; set; }
        public CurrencyAmountAttribute(Currencies Currency, int Amount)
        {
            this.Currency = Currency;
            this.Amount = Amount;
        }
    }

}
