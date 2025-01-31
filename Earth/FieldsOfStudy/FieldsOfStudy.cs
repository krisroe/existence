using System.Drawing;

namespace Existence.Earth.FieldsOfStudy
{
    public static class FieldsOfStudy
    {
        public static class Astronomy
        {
            public class LifeAttribute : Attribute
            {
                public bool Present { get; set; }
                public LifeAttribute(bool p)
                {
                    this.Present = p; ;
                }
            }

            public enum AstronomicalBodyType
            {
                BlackHole,
                Galaxy,
                SolarSystem,
                Star,
                Sun,
                Planet,
            }

            public enum PlanetType
            {
                Mercury,
                Venus,
                Earth,
                Mars,
                Saturn,
                Uranus,
                Neptune,
                Pluto,
            }

            public class AstronomicalBody
            {
                public AstronomicalBodyType Type;
                public AstronomicalBody(AstronomicalBodyType t)
                {
                    Type = t;
                }
            }

            public class Planet : AstronomicalBody
            {
                public PlanetType PlanetType;
                public Planet(PlanetType pt) : base(AstronomicalBodyType.Planet)
                {
                    PlanetType = pt;
                }
            }

            public class SolarSystem : AstronomicalBody
            {
                public Sun SolarSystemSun;
                public SolarSystem(Sun s) : base(AstronomicalBodyType.SolarSystem)
                {
                    this.SolarSystemSun = s;
                }
            }

            public class Sun : AstronomicalBody
            {
                public Sun() : base(AstronomicalBodyType.Sun)
                {
                }
            }

            public static class Planets
            {
                public class Mercury
                {
                    public Color c1;
                    public Color c2;
                    public Mercury()
                    {
                        c1 = Color.Gray;
                        c2 = Color.DarkGray;
                    }
                }
                public class Venus
                {
                    public Color c1;
                    public Color c2;
                    public Venus()
                    {
                        c1 = Color.Yellow;
                        c1 = Color.White;
                    }
                }

                [Life(true)]
                public class Earth
                {
                    public Color c1;
                    public Color c2;
                    public Earth()
                    {
                        c1 = Color.Blue;
                        c2 = Color.Green;
                    }
                }
                public class Mars 
                {
                    public Color c;
                    public Mars()
                    {
                        c = Color.Red;
                    }
                }
                public static class Jupiter { 
                    public static class Feature1
                    {
                        public static class Great { }
                        public static class Red { }
                        public static class Spot { }
                    }
                    public static class Feature2
                    {
                        public static class Faint { }
                        public static class Dust { }
                        public static class Rings { }
                    }
                }
                public static class Saturn 
                {
                    public static class  Feature
                    {
                        public static class Most { }
                        public static class ProminentAndSpectacularAndVisible { }
                        public static class Rings { }
                    }
                }
                public static class Uranus
                {
                    public static class  Feature1
                    {
                        public static class Funny { }
                        public static class Sounding { }
                        public static class Name { }
                        public static class In { }
                        public static class English { }
                        public static class Meaning
                        {
                            public static class Your { }
                            public static class Anus { }
                            public static class Or { }
                            public static class Urine { }
                            public static class Us { }
                        }
                    }
                    public static class Feature2
                    {
                        public static class Dark { }
                        public static class Narrow { }
                        public static class Rings { }
                    }
                }
                public static class Neptune { }
                public static class DefinitionOfPlanetWasChangedIn2006 { }
                public static class Pluto
                {
                    public static class NoLongerMeetsDefinitionOfPlanetButIConsiderItPlanetLikeEnoughToStayOnThePlanetList { }
                    public static class Moon {

                        public static class Charon { }
                    }
                }
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
        public static class Biology { }
        public static class Cosmology { }
        public static class Geography { }
        public static class Mathematics { }

    }
}
