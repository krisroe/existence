using System;

namespace Existence.Earth.FieldsOfStudy.Mathematics
{
    public class NumberAttribute : Attribute
    {
        public int Number { get; set; }
        public NumberAttribute(int Number)
        {
            this.Number = Number;
        }
    }

    public class TotalAttribute : NumberAttribute
    {
        public TotalAttribute(int Total) : base(Total)
        {

        }
    }

    public class FavoriteNumberRangeAttribute : SingularObjectAttribute
    {
        public int Ordinal { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
        public FavoriteNumberRangeAttribute(int Ordinal, int Low, int High)
        {
            this.Ordinal = Ordinal;
            this.Low = Low;
            this.High = High;
        }
        public FavoriteNumberRangeAttribute(int Ordinal, int ExactValue)
        {
            this.Ordinal = Ordinal;
            this.Low = this.High = ExactValue;
        }
    }

    public class FavoriteNumberAttribute : NumberAttribute
    {
        public int FavoriteNumber
        {
            get
            {
                return base.Number;
            }
            set
            {
                base.Number = value;
            }
        }
        public FavoriteNumberAttribute(int FavoriteNumber) : base(FavoriteNumber)
        {

        }
    }

    public class FavoriteNumbersAttribute : Attribute
    {
        public int[] FavoriteNumbers { get; set; }

        public FavoriteNumbersAttribute(params int[] FavoriteNumbers)
        {
            this.FavoriteNumbers = FavoriteNumbers;
        }
    }

    public class SecondFavoriteNumberAttribute : NumberAttribute
    {
        public int SecondFavoriteNumber
        {
            get
            {
                return base.Number;
            }
            set
            {
                base.Number = value;
            }
        }
        public SecondFavoriteNumberAttribute(int SecondFavoriteNumber) : base(SecondFavoriteNumber)
        {

        }
    }

    public class ThirdFavoriteNumberAttribute : NumberAttribute
    {
        public int ThirdFavoriteNumber
        {
            get
            {
                return base.Number;
            }
            set
            {
                base.Number = value;
            }
        }
        public ThirdFavoriteNumberAttribute(int ThirdFavoriteNumber) : base(ThirdFavoriteNumber)
        {

        }
    }


    public class NumbersAttribute : Attribute
    {
        public int[] Numbers { get; set; }

        public NumbersAttribute(params int[] Numbers)
        {
            this.Numbers = Numbers;
        }
    }

    public class RomanNumeralAttribute : Attribute
    {
        public string RomanNumeral { get; set; }
        public RomanNumeralAttribute(string RomanNumeral)
        {
            this.RomanNumeral = RomanNumeral;
        }
    }
    public class NumbersBinary : Attribute
    {
        protected int NumberOne { get; set; }
        protected int NumberTwo { get; set; }

        public NumbersBinary(int NumberOne, int NumberTwo)
        {
            this.NumberOne = NumberOne;
            this.NumberTwo = NumberTwo;
        }
    }
    public class NumbersTrinary : Attribute
    {
        protected int NumberOne { get; set; }
        protected int NumberTwo { get; set; }
        protected int NumberThree { get; set; }

        public NumbersTrinary(int NumberOne, int NumberTwo, int NumberThree)
        {
            this.NumberOne = NumberOne;
            this.NumberTwo = NumberTwo;
            this.NumberThree = NumberThree;
        }
    }
}
