using System;
using System.Drawing;

namespace Existence.Earth.FieldsOfStudy.Astrology
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
            public static class Jupiter
            {
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
                public static class Feature
                {
                    public static class Most { }
                    public static class ProminentAndSpectacularAndVisible { }
                    public static class Rings { }
                }
            }
            public static class Uranus
            {
                public static class Feature1
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
                public static class Moon
                {

                    public static class Charon { }
                }
            }
        }
    }
}
