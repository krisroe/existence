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
