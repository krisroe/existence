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

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
