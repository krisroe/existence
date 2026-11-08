using System;

namespace Existence.Earth.FieldsOfStudy.Mathematics
{
    /// <summary>
    /// a fraction with a whole-number numerator and denominator, for exact math without decimals. It isn't reduced, so
    /// 14/10 stays 14/10
    /// </summary>
    public class SimpleFraction
    {
        /// <summary>
        /// the number on top
        /// </summary>
        public long Numerator { get; set; }

        /// <summary>
        /// the number on the bottom, which isn't zero
        /// </summary>
        public long Denominator { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Numerator">the number on top</param>
        /// <param name="Denominator">the number on the bottom, which can't be zero</param>
        public SimpleFraction(long Numerator, long Denominator)
        {
            if (Denominator == 0) throw new ArgumentException("the denominator can't be zero", nameof(Denominator));
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }

        /// <summary>
        /// converts a decimal to the same value exactly, over a power of ten, so 3.25 becomes 325/100 and 5 becomes 5/1
        /// </summary>
        /// <param name="Value">the decimal to convert, which can have at most 18 decimal places so the denominator fits
        /// in a long</param>
        public static SimpleFraction FromDecimal(decimal Value)
        {
            if (Value.Scale > 18) throw new ArgumentException($"{Value} has more than 18 decimal places", nameof(Value));
            long lDenominator = 1;
            for (int i = 0; i < Value.Scale; i++) lDenominator *= 10;
            return new SimpleFraction(checked((long)(Value * lDenominator)), lDenominator);
        }

        /// <summary>
        /// generates a readable description of the fraction (in its original terms, not reduced unless the caller has ensured this)
        /// </summary>
        /// <returns>text version of the fraction</returns>
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
