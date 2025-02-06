using System;
using System.Drawing;

namespace Existence.Earth.FieldsOfStudy.Astronomy
{
    public static class Astronomy
    {
        public class LifeAttribute : Attribute
        {
            public bool Present { get; set; }
            public LifeAttribute(bool p)
            {
                Present = p; ;
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

        /// <summary>
        /// Each type of black hole plays a unique role in astrophysics, influencing galaxy formation, star evolution, and
        /// the structure of the universe
        /// </summary>
        public enum BlackHoleType
        {
            /// <summary>
            /// Acronym: IMBH
            /// Mass: 100-100,000 the mass of the sun
            /// Formation: Thought to form through mergers of stellar-mass black holes or from the collapse of massive star clusters
            /// Evidence: Observations of dense star clusters and gravitational wave signals suggest their existence
            /// </summary>
            IntermediateMass,

            /// <summary>
            /// Hypothetical
            /// Mass: Can range from microscopic to planetary-sized
            /// Formation: Theorized to have formed in the early universe due to high-density fluctuations
            /// Evidence: No confirmed detection, but they are a possible candidate for dark matter
            /// </summary>
            Primordial,

            /// <summary>
            /// Mass: 3-100 times the mass of the sun
            /// Formation: These black holes form when massive stars collapse at the end of their life cycle in a supernova explosion
            /// Examples: Cygnus X-1 (first confirmed)
            /// </summary>
            StellarMass,

            /// <summary>
            /// Acronym: SMBH
            /// Mass: Millions to billions of times the mass of the sun
            /// Formation: Theories include gradual accretion of matter, mergers of intermediate-mass black holes, or direct
            /// collapse of massive gas clous in the early universe
            /// Location: Found at the centers of most galaxies, including the Milky Way
            /// Example: Sagittarius A* (center of Milky Way), M87* (first directly imaged black hole)
            /// </summary>
            SuperMassive,
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

        public enum StarType
        {
            Sun,
        }

        public class AstronomicalBody
        {
            public AstronomicalBodyType Type;
            public AstronomicalBody(AstronomicalBodyType t)
            {
                Type = t;
            }
        }


        public class BlackHole : AstronomicalBody
        {
            public BlackHole() : base(AstronomicalBodyType.BlackHole)
            {
            }
        }

        public class Galaxy : AstronomicalBody
        {
            public Galaxy() : base(AstronomicalBodyType.Galaxy)
            {
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
                SolarSystemSun = s;
            }

            /// <summary>
            /// This process took millions of years and led to the structured solar system we see today, with the Sun at
            /// its center surrounded by planets, moons, and other celestial objects
            /// </summary>
            public static class Formation
            {
                /// <summary>
                /// ~4.6 billion years ago
                /// Giant rotating cloud of gas and dust
                /// Likely triggered by a nearby supernova explosion, provided a shockwave that set the nebula into motion
                /// </summary>
                public static class SolarNebula { }

                /// <summary>
                /// Gravity caused the nebula to collapse, and as it contracted, it spun faster due to the conservation of
                /// angular momentum. Most of the mass accumulated at the center.
                /// </summary>
                public static class NebularCollapseAndProtosunFormation
                {
                    /// <summary>
                    /// most of the mass, young sun that had not yet begun nuclear fission
                    /// </summary>
                    public static class Protosun { }
                    /// <summary>
                    /// surrounding flat material
                    /// </summary>
                    public static class ProtoplanetaryDisk { }
                }

                public static class PlanetaryAccretion
                {
                    /// <summary>
                    /// tiny dust and ice particles within the disk stuck together through electrostatic forces
                    /// </summary>
                    public static class Planetismals
                    {
                        /// <summary>
                        /// over time, collided and merged into larger bodies, forming protoplanets
                        /// </summary>
                        public static class Protoplanets { }
                    }
                }

                /// <summary>
                /// the growing planets heated up due to collisions and radioactive decay, allowing heavier elements
                /// (like iron and nickel) to sink to their cores, while lighter materials formed their crusts
                /// </summary>
                public static class DifferentiationOfPlanets { }

                /// <summary>
                /// The sun ignited nuclear fusion, releasing powerful solar winds
                /// These windws blew away the remaining gas and dust, leaving behind only planets, moons, asteroids, and comets
                /// </summary>
                public static class ClearingOfTheSolarSystem { }

                /// <summary>
                /// ~4 billion years ago
                /// Residual planetesimals continued colliding with planets and moons, shaping their surfaces.
                /// This period helped form many craters on the Moon and other celestial bodies
                /// </summary>
                public static class LateHeavyBombardment { }

                /// <summary>
                /// ~3.8 billion years ago
                /// The solar system gradually settled into its current structure, with planets orbiting the Sun in stable paths.
                /// The conditions on Earth eventually allowed for the emergence of life.
                /// </summary>
                public static class Stabilization { }
            }
        }

        public class Star : AstronomicalBody
        {
            public StarType StarType;
            public Star(StarType starType) : base(AstronomicalBodyType.Star)
            {
                this.StarType = starType;
            }
        }

        public class Sun : Star
        {
            public Sun() : base(StarType.Sun)
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
