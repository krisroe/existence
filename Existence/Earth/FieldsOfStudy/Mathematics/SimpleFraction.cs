using System;

namespace Existence.Earth.FieldsOfStudy.Mathematics
{
    /// <summary>
    /// a fraction with a whole-number numerator and denominator, for exact math without decimals. It isn't reduced, so
    /// 14/10 stays 14/10
    /// </summary>
    public class SimpleFraction : IComparable<SimpleFraction>
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
        /// gets the same value in lowest terms with a positive denominator, so 15/5 becomes 3/1 and 2/-4 becomes -1/2
        /// </summary>
        public SimpleFraction Reduce()
        {
            long lA = Math.Abs(Numerator);
            long lB = Math.Abs(Denominator);
            while (lB != 0) (lA, lB) = (lB, lA % lB);
            long lSign = Denominator < 0 ? -1 : 1;
            return new SimpleFraction(lSign * Numerator / lA, lSign * Denominator / lA);
        }

        /// <summary>
        /// compares by value, exactly in whole numbers, so 14/10 and 7/5 are the same. Throws an
        /// <see cref="OverflowException"/> if multiplying out the fractions doesn't fit in a long
        /// </summary>
        /// <param name="other">the fraction to compare to, where null comes before any fraction</param>
        /// <returns>negative if this is less than <paramref name="other"/>, zero if they're equal, positive if this is
        /// greater</returns>
        public int CompareTo(SimpleFraction? other)
        {
            int ret;
            if (other is null)
            {
                ret = 1;
            }
            else //a/b vs c/d is a x d vs c x b, flipped if exactly one denominator is negative
            {
                int iResult = checked(Numerator * other.Denominator).CompareTo(checked(other.Numerator * Denominator));
                ret = (Denominator < 0) != (other.Denominator < 0) ? -iResult : iResult;
            }
            return ret;
        }

        /// <summary>
        /// whether one fraction is less than the other by value. Null comes before any fraction
        /// </summary>
        public static bool operator <(SimpleFraction? left, SimpleFraction? right) => Compare(left, right) < 0;

        /// <summary>
        /// whether one fraction is greater than the other by value. Null comes before any fraction
        /// </summary>
        public static bool operator >(SimpleFraction? left, SimpleFraction? right) => Compare(left, right) > 0;

        /// <summary>
        /// whether one fraction is less than or equal to the other by value. Null comes before any fraction
        /// </summary>
        public static bool operator <=(SimpleFraction? left, SimpleFraction? right) => Compare(left, right) <= 0;

        /// <summary>
        /// whether one fraction is greater than or equal to the other by value. Null comes before any fraction
        /// </summary>
        public static bool operator >=(SimpleFraction? left, SimpleFraction? right) => Compare(left, right) >= 0;

        /// <summary>
        /// compares two simple fractions
        /// </summary>
        /// <param name="left">left side of the equation</param>
        /// <param name="right">right side of the equation</param>
        /// <returns>comparison value</returns>
        private static int Compare(SimpleFraction? left, SimpleFraction? right)
        {
            int ret;
            if (left is null)
            {
                ret = right is null ? 0 : -1;
            }
            else
            {
                ret = left.CompareTo(right);
            }
            return ret;
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
