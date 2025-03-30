using System;
using System.Collections.Generic;
using Existence.Earth.Time;

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
        public TimePeriods Period { get; set; }
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
        public AgeAttribute(int Age, TimePeriods Period) : base(Age)
        {
            this.Period = Period;
        }
    }

    public class ApproximateAgeInYearsAttribute : Attribute
    {
        public int StartAge { get; set; }
        public int EndAge { get; set; }
        public ApproximateAgeInYearsAttribute(int StartAge, int EndAge)
        {
            this.StartAge = StartAge;
            this.EndAge = EndAge;
        }
        public ApproximateAgeInYearsAttribute(int Age)
        {
            StartAge = EndAge = StartAge;
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
