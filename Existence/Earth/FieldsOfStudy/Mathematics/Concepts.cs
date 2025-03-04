using System;
using System.Collections.Generic;

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

    public class AgeAttribute : NumberAttribute
    {
        public int Age
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
        public AgeAttribute(int Age) : base(Age)
        {

        }
    }

    public class ApproximateAgeAttribute : AgeAttribute
    {
        public int ApproximateAge
        {
            get
            {
                return base.Age;
            }
            set
            {
                base.Age = value;
            }
        }
        public ApproximateAgeAttribute(int ApproximateAge) : base(ApproximateAge)
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
