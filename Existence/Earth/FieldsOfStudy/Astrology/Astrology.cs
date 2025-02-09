using System;

namespace Existence.Earth.FieldsOfStudy.Astrology
{
    public enum AstrologicalSigns
    {
        Aries,
        Taurus,
        Gemini,
        Cancer,
        Leo,
        Virgo,
        Libra,
        Scorpio,
        Sagittarius,
        Capricorn,
        Aquarius,
        Pisces
    }

    public class AstrologicalSignAttribute : Attribute
    {
        public AstrologicalSigns Sign { get; set; }
        public AstrologicalSignAttribute(AstrologicalSigns Sign)
        {
            this.Sign = Sign;
        }
    }


    public static class Astrology
    {
        public static class NotScienceAnymore { }
        public static class NowReasonablyConsideredBullshit { }
        public static class AstrologicalSigns
        {
            public static class Aries
            {
                public static class Ram { }
                public static class Fire { }
                public static class Mars { }
            }

            public static class Taurus
            {
                public static class Bull { }
                public static class Earth { }
                public static class Venus { }
            }

            public static class Gemini
            {
                public static class Twins { }
                public static class Air { }
                public static class Mercury { }
            }
            public static class Cancer
            {
                public static class Crab { }
                public static class Water { }
                public static class Moon { }
            }
            public static class Leo
            {
                public static class Lion { }
                public static class Fire { }
                public static class Sun { }
            }
            public static class Virgo
            {
                public static class VirginOrMaiden { }
                public static class Earth { }
                public static class Mercury { }
            }
            public static class Libra
            {
                public static class Scales { }
                public static class Air { }
                public static class Venus { }
            }
            public static class Scorpio
            {
                public static class Scorpion { }
                public static class Water { }
                public static class Mars { }
                public static class Pluto { }
            }
            public static class Sagittarius
            {
                public static class Archer { }
                public static class Fire { }
                public static class Jupiter { }
            }
            public static class Capricorn
            {
                public static class Goat { }
                public static class Earth { }
                public static class Saturn { }
            }
            public static class Aquarius
            {
                public static class WaterBearer { }
                public static class Air { }
                public static class Saturn { }
                public static class Uranus { }
            }
            public static class Pisces
            {
                public static class Fish { }
                public static class Water { }
                public static class Jupiter { }
                public static class Neptune { }
            }
        }
    }
}
