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

        public class AgeAttribute : Attribute
        {
            public string From { get; set; }
            public string Age { get; set; }
            public AgeAttribute(string From, string Age)
            {
                this.Age = Age;
                this.From = From;
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
            public BlackHoleType BlackHoleType { get; set; }
            public BlackHole(BlackHoleType blackHoleType) : base(AstronomicalBodyType.BlackHole)
            {
                BlackHoleType = blackHoleType;
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
                /// Hydrogen: (H2) and Helium (He) with some heavier elements
                /// </summary>
                [Age("Past", "~4.567 Billion Years Ago")]
                public static class SolarNebulaCollapseBegins
                {
                    public static class MassiveMolecularCloudCollapsesUnderGravityLikelyTriggeredBySupernovaOrOtherShockwave
                    {
                        public static class Elements
                        {
                            public static class Dust { }
                            public static class Hydrogen { }
                            public static class Helium { }
                        }

                        public static class CentralCoreFormsFromDensestPart { }
                    }

                    

                    public static class CollapsingSolarNebula
                    {
                        public static class DenseSpinningCore { }
                    }
                }

                [Age("Solar System Age", "100 years")]
                public static class CloudBeginsToFlattenAndSpinFaster
                {
                    public static class SolarNebulaSpinsFasterDueToConservationOfAngularMomentum
                    {
                        public static class CentralCoreFromDensestPart { }
                        public static class FirstSignsOfAProtoplanetaryDiskAppearAsGasOrganizesIntoFlattenedRotatingStructure { }
                    }
                }

                [Age("Solar System Age", "500 years")]
                public static class ProtostarFormsAtTheCenter
                {
                    public static class SolarNebula
                    {
                        /// <summary>
                        /// no hydrogen fusion has started but gravitational contraction produces heat
                        /// </summary>
                        public static class CentralCoreBecomesDenserAndHotterMakingProtostar { }

                        public static class ProtoplanetaryDiskFormingAsGasOrganizesIntoFlattenedRotatingStructure { }
                    }
                }

                [Age("Solar System Age", "700 years")]
                public static class ProtoplanetaryDiskTakesShape
                {
                    public static class SolarNebula
                    {
                        public static class Protostar { }
                        /// <summary>
                        /// rotating disk of gas and dust. rich in hydrogen, helium, and heavy elements but no solid material yet.
                        /// </summary>
                        public static class ProtoplanetaryDisk { }
                    }
                }

                [Age("Solar System Age", "1,000 years")]
                public static class ProtoplanetaryDiskContinuesToEvolveAndProtostarGrows
                {
                    /// <summary>
                    /// still collapsing
                    /// </summary>
                    public static class SolarNebula
                    {
                        /// <summary>
                        /// continues accreting mass, spinning, contracting, and heating up
                        /// </summary>
                        public static class Protostar { }

                        /// <summary>
                        /// becoming more structured (flattening), but still mostly gas (some dust)
                        /// materials beginning to settle into a rotating plane
                        /// rich in hydrogen, helium, and heavy elements but no solid material yet.
                        /// Turbulence and magnetic fields begin influencing material movement in the disk
                        /// </summary>
                        public static class ProtoplanetaryDisk { }
                    }
                }

                [Age("Solar System Age", "1,500 years")]
                public static class InnerVersusOuterDiskDifferentiationBegins
                {
                    public static class SolarNebula
                    {
                        public static class Protostar { }

                        public static class ProtoplanetaryDisk
                        {
                            /// <summary>
                            /// ~0.1-5 AU, extremely hot, allowing only metal and silicate grains to survive
                            /// </summary>
                            public static class InnerRegion { }

                            /// <summary>
                            /// ~5-50 AU, remain cooler, where ices can persist
                            /// </summary>
                            public static class OuterRegion { }
                        }
                    }
                }

                [Age("Solar System Age", "2,000 years")]
                public static class StrongerMagneticAndSolarWindEffects
                {
                    public static class SolarNebula
                    {
                        /// <summary>
                        /// magnetic field and stellar winds intensify, influencing the movement of gas and dust in the planetary disk
                        /// </summary>
                        public static class Protostar { }

                        /// <summary>
                        /// lighter gas is pushed outward affecting future planetary composition
                        /// </summary>
                        public static class ProtoplanetaryDisk
                        {
                            /// <summary>
                            /// ~0.1-5 AU, extremely hot, allowing only metal and silicate grains to survive
                            /// </summary>
                            public static class InnerRegion { }

                            /// <summary>
                            /// ~5-50 AU, remain cooler, where ices can persist
                            /// </summary>
                            public static class OuterRegion { }
                        }
                    }
                }

                public static class DustGrainsStartToClumpTogether
                {
                    public static class SolarNebula
                    {
                        public static class Protostar { }
                        /// <summary>
                        /// Microscopic dust particles begin sticking together, forming millimeter-sized grains
                        /// These will later merge into larger solid bodies (pebbles and planetisimals)
                        /// </summary>
                        public static class ProtoplanetaryDisk
                        {
                            /// <summary>
                            /// ~0.1-5 AU, extremely hot, allowing only metal and silicate grains to survive
                            /// </summary>
                            public static class InnerRegion { }

                            /// <summary>
                            /// ~5-50 AU, remain cooler, where ices can persist
                            /// </summary>
                            public static class OuterRegion { }
                        }
                    }
                }

                [Age("Solar System Age", "3,000 years")]
                public static class ProtoplanetaryDiskIsStructurallyComplete
                {
                    /// <summary>
                    /// structured, rotating disk
                    /// </summary>
                    public static class SolarNebula
                    {
                        /// <summary>
                        /// not yet fusing hydrogen but heating up, rapidly spinning, producing heat from gravitational contraction
                        /// </summary>
                        public static class Protostar { }
                        /// <summary>
                        /// Fully formed and rotating disk-shape
                        /// Dust grains beginning to stick together.
                        /// Millimeter-sized dust particles have formed, but no larger solid bodies existed yet.
                        /// Planetisimals (1-10 km) have to wait until more dust accumulation.
                        /// </summary>
                        public static class ProtoplanetaryDisk
                        {
                            /// <summary>
                            /// ~0.1-5 AU, hot and dry, favoring rocky planet formation
                            /// </summary>
                            public static class InnerRegionRocky { }

                            /// <summary>
                            /// ~5-50 AU, cooler, allowing ice-rich materials to accumulate
                            /// </summary>
                            public static class OuterRegionIcy { }
                        }
                    }
                }

                [Age("Solar System Age", "3,500 years")]
                public static class DustGrainsBeginGrowingIntoPebbles
                {
                    /// <summary>
                    /// Microscopic dust grains (~micron-sized) begin clumping together into millimeter-centimeter sized particles
                    /// These will later merge into larger solid objects like planetisimals
                    /// </summary>
                    public static class ProtoplanetaryDisk { }
                }

                [Age("Solar System Age", "4,000 years")]
                public static class SunActivityIntensifies
                {
                    /// <summary>
                    /// Not yet fusing hydrogen but heating up, rapidly spinning, producing heat from gravitational contraction
                    /// Increasing temperature and solar wind strength
                    /// Solar radiation starts influencing the inner disk, pushing lighter materials outward.
                    /// </summary>
                    public static class Protostar { }
                }

                [Age("Solar System Age", "4,500 years")]
                public static class PebblesStartToAccumulateIntoLargerAggregate
                {
                    /// <summary>
                    /// Small pebble-sized particles (~1 cm) collide and grow into clumps several centimeters to meters across.
                    /// These will later merge into the first planetisimals.
                    /// </summary>
                    public static class ProtoplanetaryDisk { }
                }

                [Age("Solar System Age", "5,000 years")]
                public static class ProtoplanetaryDiskBeginsToFormSunIsAdvancedProtostar
                {
                    /// <summary>
                    /// structured, rotating disk
                    /// </summary>
                    public class SolarNebula
                    {
                        /// <summary>
                        /// Not yet fusing hydrogen, hot, rapidly spinning, generating significant heat and solar winds
                        /// </summary>
                        public static class Protostar { }

                        /// <summary>
                        /// fully formed and rotating-disk shape
                        /// contains all the raw material that will eventually form planets
                        /// Millimeter- to centimeter-sized pebbles had formed, beginning the process of planetesimal formation.
                        /// No planets, moons, or large planetesimals yet.
                        /// </summary>
                        public static class ProtoplanetaryDisk
                        {
                            /// <summary>
                            /// ~0.1-5 AU, hot and dry, too hot for ice, leaving only metals and silicates, favoring rocky planet formation
                            /// </summary>
                            public static class InnerRegionRocky { }

                            /// <summary>
                            /// ~5-50 AU, remained cool, allowing ice-rich materials to accumulate
                            /// </summary>
                            public static class OuterRegionIcy { }
                        }
                    }
                }

                [Age("Solar System Age", "5,500 years")]
                public static class PebblesContinueGrowing
                {
                    /// <summary>
                    /// Small pebble-sized particles (~1 cm) collide and form larger aggregates (~10 cm - 1 m).
                    /// These growing bodies are the first precursors to planetesimals (~1–10 km).
                    /// </summary>
                    public static class ProtoplanetaryDisk { }
                }

                [Age("Solar System Age", "6,000 years")]
                public static class InnerAndOuterDiskDifferentiationBecomesMorePronounced
                {
                    /// <summary>
                    /// ~0.1-5 AU, hot and dry, only metals and silicates survive, favoring rocky planet formation
                    /// </summary>
                    public static class InnerRegionRocky { }

                    /// <summary>
                    /// ~5-50 AU, remained cooler, allowing ice-rich materials to accumulate
                    /// </summary>
                    public static class OuterRegionIcy { }
                }

                public static class FirstKilometerSizedObjectsStartToForm
                {
                    /// <summary>
                    /// Some larger pebbles and aggregates begin reaching kilometer-scale sizes (~1–10 km).
                    /// These are the first planetesimals, the building blocks of future planets.
                    /// </summary>
                    public static class ProtoplanetaryDisk { }
                }

                [Age("Solar System Age", "7,000 years")]
                public static class TTauriPhaseBeginsInfluencingDiskEvolution
                {
                    public class SolarNebula
                    {
                        /// <summary>
                        /// hot, rapidly spinning
                        /// still not fusing hydrogen, but generating significant heat and solar winds
                        /// Enters T Tauri phase, which will influence gas and dust movement, pushing lighter gas out of the inner solar system
                        /// </summary>
                        public static class Protostar { }

                        /// <summary>
                        /// structured disk
                        /// </summary>
                        public static class ProtoplanetaryDisk
                        {
                            /// <summary>
                            /// ~0.1-5 AU: Too hot for ice, leaving only metals and silicates
                            /// </summary>
                            public static class InnerRegionRockyHot { }

                            /// <summary>
                            /// ~5-50 AU: cooler, allowing icy material to accumulate
                            /// </summary>
                            public static class OuterRegionIcyCooler { }

                            /// <summary>
                            /// beginning to form
                            /// Some solid objects were now kilometer-sized, marking the transition from pebbles to planetesimals.
                            /// first true solid planetary building blocks
                            /// small and scattered
                            /// </summary>
                            public static class Planetisimals { }
                        }
                    }
                }

                [Age("Solar System Age", "7,500 years")]
                public static class FirstLargerPlanetesimalsForm
                {
                    /// <summary>
                    /// Small pebble clusters merge into kilometer-sized planetesimals (~10+ km).
                    /// These bodies are large enough to gravitationally attract more material, increasing their growth rate.
                    /// </summary>
                    public static class Planetisimals { }
                }

                [Age("Solar System Age", "8,000 years")]
                public static class InnerAndOuterSolarSystemDifferencesBecomeStronger
                {
                    /// <summary>
                    /// ~0.1-5 AU: Too hot for ice, favoring metal and silicate-rich material
                    /// </summary>
                    public static class InnerRegionRockyHot { }

                    /// <summary>
                    /// ~5-50 AU: remains colder, allowing icy material to accumulate
                    /// </summary>
                    public static class OuterRegionIcyCooler { }
                }

                [Age("Solar System Age", "8,500 years")]
                public static class CollisionsBetweenPlanetisimalsIncrease
                {
                    /// <summary>
                    /// The first significant collisions occur between planetesimals.
                    /// Some bodies break apart, while others merge into larger protoplanetary seeds (~50+ km).
                    /// </summary>
                    public static class Planetisimals { }
                }

                [Age("Solar System Age", "9,000 years")]
                public static class FirstProtoplanetaryEmbryosBeginForming
                {
                    /// <summary>
                    /// Some planetesimals continue merging, forming larger protoplanetary embryos (~50–100 km).
                    /// These bodies are still too small to be planets, but they represent the early building blocks of future planets.
                    /// </summary>
                    public static class Planetisimals { }
                }

                [Age("Solar System Age", "10,000 years")]
                public static class ProtoplanetaryDiskStillGasRichButEvolving
                {
                    public static class SolarNebula
                    {
                        /// <summary>
                        /// not yet fusing hydrogen, but producing strong solar winds and radiation
                        /// Clearing gas from the inner solar system
                        /// </summary>
                        public static class TTauriSun { }

                        /// <summary>
                        /// extending beyond 100 AU
                        /// rich in hydrogen, helium and dust grains, gas remains dominant
                        /// The first Moon-sized bodies (~100 km) may be starting to emerge.
                        /// </summary>
                        public static class ProtoplanetaryDisk
                        {
                            /// <summary>
                            /// ~0.1-5 AU: Too hot for ice, favoring metal and silicate-rich material
                            /// </summary>
                            public static class InnerRegionRockyHot { }

                            /// <summary>
                            /// ~5-50 AU: remains colder, allowing icy material to accumulate
                            /// </summary>
                            public static class OuterRegionIcyCooler { }
                        }

                        /// <summary>
                        /// Protoplanetary Embryo: (~10–100 km)
                        /// Kilometer-sized solid objects had formed, setting the stage for planetary growth.
                        /// Some protoplanetary embryos (~50–100 km) were beginning to form, but no planets yet.
                        /// </summary>
                        public static class PlanetisimalsAndProtoplanetaryEmbryos { }
                    }
                }

                [Age("Solar System Age", "15,000 years")]
                public static class ProtostarContinuesContracting
                {
                    public static class ProtostarNotYetFusingHydrogenButHeatingUpGatheringMassContinuesContractingSolarWindsAndMagneticFieldsStronger { }
                }

                [Age("Solar System Age", "20,000 years")]
                public static class RegionsOfThePlanetaryDiskBecomeMoreDefined
                {
                    /// <summary>
                    /// ~0.1-5 AU. Hot, only metal and rock can survive, ices prevented from forming
                    /// </summary>
                    public static class InnerDiskRockyHot { }

                    /// <summary>
                    /// ~5-50 AU. Cooler, allowing ices to remain solid, benefiting giant planet formation
                    /// </summary>
                    public static class OuterDiskIcyCold { }
                }

                [Age("Solar System Age", "50,000 years")]
                public static class ProtostarGrowthAndEarlyDustClumping
                {
                    /// <summary>
                    /// dust grains in the disk begin sticking together, forming millimeter to centimeter sized particles
                    /// </summary>
                    public static class ProtoplanetaryDisk
                    {
                        /// <summary>
                        /// continues to contract, increasing in temperature and pressure
                        /// </summary>
                        public static class Protostar { }

                        public static class InnerRegions { }
                        public static class OuterRegions { }
                    }
                }

                [Age("Solar System Age", "100,000")]
                public static class SolarSystemTakesShape
                {
                    public static class SolarSystem
                    {
                        /// <summary>
                        /// protosun is brighter and hotter, but not yet fusing hydrogen, emitted strong solar winds and magnetic fields, shaping the disk
                        /// </summary>
                        public static class TTauriStar { }

                        /// <summary>
                        /// contained gas, dust and early solid material, but no planets or large protoplanets yet
                        /// </summary>
                        public static class ProtoplanetaryDisk
                        {
                            /// <summary>
                            /// small rocky and icy bodies (1-100km in size)
                            /// </summary>
                            public static class Planetesimals { }

                            /// <summary>
                            /// ~0-5 AU: Too hot for water and ice; mostly silicate and metal-rich dust
                            /// </summary>
                            public static class InnerSolarSystem { }

                            /// <summary>
                            /// ~5-50 AU: Colder: contained water ice, methane, ammonia, and carbon-rich compounds
                            /// </summary>
                            public static class OuterSolarSystem { }
                        }
                    }
                }
            

                [Age("Solar System Age", "500,000")]
                public static class ProtostarSystem
                {
                    public static class ProtoplanetaryDisk
                    {

                        public static class SolarNebula { }

                        /// <summary>
                        /// Protostar formed
                        /// </summary>
                        public static class Protostar { }


                        /// <summary>
                        /// tiny solid particles bein clumping together
                        /// Dust grains stuck together through static electricity and weak forces, forming millimeter to centimeter
                        /// sized pebbles. These pebbles collided and merged, growing into kilometer-sized planetisimals
                        /// </summary>
                        public static class PlanetisimalFormation { }

                        /// <summary>
                        /// over time, planetisimals collide and merge into larger bodies, forming protoplanets
                        /// </summary>
                        public static class PlanetaryAccretion { }

                        /// <summary>
                        /// inner solar system
                        /// </summary>
                        public static class InnerSolarSystem
                        {
                            /// <summary>
                            /// ~1% of Earth mass
                            /// </summary>
                            public static class EarlyProtoplanetForming { }
                        }

                        /// <summary>
                        /// outer solar system
                        /// </summary>
                        public static class OuterSolarSystem
                        {
                            /// <summary>
                            /// 1 Earth mass
                            /// </summary>
                            public static class JupiterProtoplanetForming { }

                            /// <summary>
                            /// Giant planets had not yet formed, but solid material beginning to accumulate.
                            /// </summary>
                            public static class PlanetFormation { }
                        }
                    }
                }

                [Age("Solar System Age", "1 Million")]
                public static class OneMillionYearsAfterSolarSystemFormation
                {
                    /// <summary>
                    /// still present, extended from the Sun to 100s of AU, full of hydrogen, helium, and dust grains.
                    /// There was still enough gas for giant planets to form, but solid material was beginning to take shape.
                    /// </summary>
                    public static class SolarNebula { }

                    /// <summary>
                    /// still dense with gas and dust, extending beyond 100 AU
                    /// </summary>
                    public static class ProtoplanetaryDisk { }

                    /// <summary>
                    /// Still in T Tauri phase (~1 million years old)
                    /// Starting to ignite full hydrogen fusion, already producing energy though gravitational contraction.
                    /// Spinning rapidly and blasting out strong solar winds, which would eventually clear the solar nebula.
                    /// Magnetic fields were influencing the surrounding disk, affecting planetary formation.
                    /// </summary>
                    public static class ProtostarIgniting { }

                    /// <summary>
                    /// ~0.1 - 5 AU: Hotter, only metal and silicate materials could survive.
                    /// </summary>
                    public static class InnerSolarSystem
                    {
                        public static class Planetisimals
                        {
                            /// <summary>
                            /// 5-10% of final mass
                            /// </summary>
                            public static class Earth { }

                            /// <summary>
                            /// 2-5% of Earth mass
                            /// </summary>
                            public static class Mars { }

                            /// <summary>
                            /// ~5% of Earth mass
                            /// </summary>
                            public static class Mercury { }

                            /// <summary>
                            /// ~5-10% of Earth mass
                            /// </summary>
                            public static class Venus { }
                        }
                    }

                    /// <summary>
                    /// still filled with planetisimals, no large gaps yet
                    /// </summary>
                    public static class AsteroidBelt { }

                    /// <summary>
                    /// ~5 - 50 AU: Cooler, allowing ice and volatile compounds to exist.
                    /// </summary>
                    public static class OuterSolarSystem
                    {
                        public static class GapsFormingInProtoplanetaryDisk { }

                        /// <summary>
                        /// 3 Earth masses
                        /// </summary>
                        public static class JupiterCoreForming { }

                        public static class IcyPlanetisimals
                        {
                            public static class SaturnUranusNeptune { }
                        }
                    }

                    /// <summary>
                    /// full of icy planetesimals, not yet structured
                    /// </summary>
                    public static class KuiperBelt { }
                }

                public static class TwoMillionYearsAfterSolarSystemFormation
                {
                    /// <summary>
                    /// still present but beginning to thin out
                    /// </summary>
                    public static class SolarNebula { }

                    /// <summary>
                    /// still in protoplanetary disk phase, but significant progress made toward planet formation
                    /// Intense solar winds and magnetic interactions pushing lighter material outward
                    /// This influenced the distribution of material, shaping early planetary orbits
                    /// </summary>
                    public static class ProtoplanetaryDisk { }

                    /// <summary>
                    /// completed protostar phase
                    /// full T Tauri Star
                    /// Not in main-sequence hydrogen fusion yet, but core heating up
                    /// radiating energy and strong solar winds, which were slowly clearing the remaining solar nebula gas
                    /// </summary>
                    public static class Sun { }

                    public static class InnerSolarSystem
                    {
                        /// <summary>
                        /// 10-20% of final mass
                        /// </summary>
                        public static class EarthProtoplanetGrows { }

                        public static class MarsProtoplanetGrows { }
                        /// <summary>
                        /// ~10% of Earth mass
                        /// </summary>
                        public static class MercuryProtoplanetGrows { }
                        public static class VenusProtoplanetGrows { }
                    }
                    public static class OuterSolarSystem
                    {
                        /// <summary>
                        /// 5 Earth masses
                        /// </summary>
                        public static class JupiterCoreFormedStartingGasAccretion { }
                        public static class SaturnCoreForming { }
                        public static class NeptuneAndUranusProtoplanetsFormingProbablyNeptuneFirst { }
                    }
                }

                public static class ThreeMillionYearsAfterSolarSystemFormation
                {
                    public static class SolarNebulaClearing
                    {
                        public static class ProtostarIgniting { }
                        public static class InnerSolarSystem
                        {
                            /// <summary>
                            /// 20-30% of final mass
                            /// </summary>
                            public static class EarthProtoplanetGrows { }

                            /// <summary>
                            /// ~20% of Earth mass
                            /// </summary>
                            public static class MarsProtoplanetGrows { }

                            /// <summary>
                            /// ~20% of Earth mass
                            /// </summary>
                            public static class MercuryProtoplanetGrows { }

                            /// <summary>
                            /// 20-30% of Earth mass
                            /// </summary>
                            public static class VenusProtoplanetGrows { }
                        }
                        public static class OuterSolarSystem
                        {
                            /// <summary>
                            /// 10-15 Earth masses
                            /// </summary>
                            public static class JupiterCoreFormedSlowGasAccretion { }
                            public static class SaturnCoreFormedSlowGasAccretion { }
                            public static class TwoPlanetsCoreFormingThatEventuallyBecomeUranusAndNeptune { }
                        }
                    }
                }

                public static class FourMillionYearsAfterSolarSystemFormation
                {
                    public static class SolarNebulaClearing
                    {
                        public static class ProtostarIgniting { }
                        public static class InnerSolarSystem
                        {
                            public static class EarthProtoplanetGrows { }

                            public static class MarsProtoplanetGrows { }

                            /// <summary>
                            /// ~30% of Earth mass
                            /// </summary>
                            public static class MercuryProtoplanetGrows { }

                            public static class VenusProtoplanetGrows { }
                        }
                        public static class OuterSolarSystem
                        {
                            public static class JupiterRunawayGasAccretion { }
                            public static class SaturnCoreFormedRunawayGasAccretion { }
                            public static class TwoPlanetsCoreFormingThatEventuallyBecomeUranusAndNeptune { }
                        }
                    }
                }

                public static class FourAndAHalfMillionYearsAfterSolarSystemFormation
                {
                    public static class SolarNebulaClearing
                    {
                        public static class ProtostarIgniting { }
                        public static class InnerSolarSystem
                        {
                            public static class EarthProtoplanetGrows { }
                            public static class MarsProtoplanetGrows { }
                            public static class MercuryProtoplanetGrows { }

                            public static class VenusProtoplanetGrows { }
                        }
                        public static class OuterSolarSystem
                        {
                            public static class JupiterExtremeGasAccretion { }
                            public static class SaturnCoreFormedRunawayGasAccretion { }
                            public static class TwoPlanetsCoreFormingThatEventuallyBecomeUranusAndNeptune { }
                        }
                    }
                }

                public static class FiveMillionYearsAfterSolarSystemFormation
                {
                    public static class SolarNebulaClearing
                    {
                        public static class ProtostarIgniting { }
                        public static class InnerSolarSystem
                        {
                            /// <summary>
                            /// ~40-50% of final mass
                            /// </summary>
                            public static class EarthProtoplanetGrows { }

                            /// <summary>
                            /// ~50%-60% of Earth mass
                            /// </summary>
                            public static class MarsProtoplanetGrows { }

                            /// <summary>
                            /// ~40% of Earth mass
                            /// </summary>
                            public static class MercuryProtoplanetGrows { }

                            /// <summary>
                            /// ~40%-50% of Earth mass
                            /// </summary>
                            public static class VenusProtoplanetGrows { }
                        }
                        public static class OuterSolarSystem
                        {
                            /// <summary>
                            /// ~318 Earth Masses
                            /// </summary>
                            public static class JupiterFinalMass { }
                            public static class SaturnCoreFormedRapidGasAccretion { }
                            public static class TwoPlanetsCoreFormedThatEventuallyBecomeUranusAndNeptune { }
                        }
                    }
                }

                public static class SixMillionYearsAfterSolarSystemFormation
                {
                    public static class SolarNebulaClearing
                    {
                        public static class ProtostarIgniting { }
                        public static class InnerSolarSystem
                        {
                            public static class EarthProtoplanetGrows { }
                            public static class MarsProtoplanetGrows { }
                            public static class MercuryProtoplanetGrows { }
                            public static class VenusProtoplanetGrows { }
                        }
                        public static class OuterSolarSystem
                        {
                            public static class JupiterFinalMassGasAccretionSlowsSignificantly { }
                            /// <summary>
                            /// ~95 earth masses
                            /// </summary>
                            public static class SaturnFinalMass { }
                            public static class TwoPlanetsCoreFormedThatEventuallyBecomeUranusAndNeptuneStartingGasAccretion { }
                        }
                    }
                }

                public static class SevenMillionYearsAfterSolarSystemFormation
                {
                    public static class SolarNebulaClearing
                    {
                        public static class ProtostarIgniting { }
                        public static class InnerSolarSystem
                        {
                            /// <summary>
                            /// 60-70% of final mass
                            /// </summary>
                            public static class EarthProtoplanetGrows { }

                            /// <summary>
                            /// ~80% Earth mass
                            /// </summary>
                            public static class MarsProtoplanetGrows { }

                            /// <summary>
                            /// 50-60% of Earth's mass
                            /// </summary>
                            public static class MercuryProtoplanetGrows { }

                            /// <summary>
                            /// 60-70% Earth mass
                            /// </summary>
                            public static class VenusProtoplanetGrows { }
                        }
                        public static class OuterSolarSystem
                        {
                            public static class JupiterFinalMassGasAccretionSlowsSignificantly { }
                            public static class SaturnFinalMassGasAccretionSlowsSignificantly { }
                            public static class TwoPlanetsCoreFormedThatEventuallyBecomeUranusAndNeptuneStartingGasAccretion { }
                        }
                    }
                }

                public static class EightMillionYearsAfterSolarSystemFormation
                {
                    public static class SolarNebulaClearing
                    {
                        public static class ProtostarIgniting { }
                        public static class InnerSolarSystem
                        {
                            public static class EarthProtoplanetGrows { }
                            public static class MarsProtoplanetGrows { }
                            public static class MercuryProtoplanetGrows { }
                            public static class VenusProtoplanetGrows { }
                        }
                        public static class OuterSolarSystem
                        {
                            public static class JupiterFinalMassGasAccretionSlowsSignificantly { }
                            public static class SaturnFinalMassGasAccretionSlowsSignificantly { }
                            public static class TwoPlanetsCoreFormedThatEventuallyBecomeUranusAndNeptuneSlowGasAccretion { }
                        }
                    }
                }

                public static class TenMillionYearsAfterSolarSystemFormation
                {
                    /// <summary>
                    /// solar nebula cleared
                    /// </summary>
                    public static class SolarSystem
                    {
                        public static class MainSequenceStar { }
                        public static class InnerSolarSystem
                        {
                            /// <summary>
                            /// ~80-90% of final mass (~0.04-0.05 Earth mass). Likely already the innermost planet, although orbital distance may have slightly changed later.
                            /// </summary>
                            public static class MercuryProtoplanetGrows { }

                            /// <summary>
                            /// ~80%-90 of final mass. Nearly final in 2nd position.
                            /// </summary>
                            public static class VenusProtoplanetGrows { }

                            /// <summary>
                            /// ~85-90% final mass. near. Nearly final in 3rd position.
                            /// </summary>
                            public static class EarthProtoplanetGrows { }

                            /// <summary>
                            /// ~0.107 Earth Masses (final mass). Mars fully settled in 4th position.
                            /// </summary>
                            public static class Mars { }
                        }
                        public static class OuterSolarSystem
                        {
                            /// <summary>
                            /// ~318 Earth masses (final mass)
                            /// </summary>
                            public static class Jupiter { }

                            /// <summary>
                            /// ~95 Earth masses (final mass)
                            /// </summary>
                            public static class Saturn { }

                            public static class OrderNotDeterminedYet
                            {
                                /// <summary>
                                /// 14.5 Earth masses (final mass)
                                /// </summary>
                                public static class Uranus { }

                                /// <summary>
                                /// 17.1 Earth masses (final mass)
                                /// </summary>
                                public static class Neptune { }
                            }
                        }
                    }
                }

                public static class OneHundredMillionYearsAfterSolarSystemFormation
                {
                    public static class SolarSystem
                    {
                        public static class MainSequenceStar { }
                        public static class InnerSolarSystem
                        {
                            public static class MercuryVenusEarthMarsPlanets { }
                        }
                        public static class OuterSolarSystem
                        {
                            public static class Jupiter { }
                            public static class Saturn { }
                            public static class UranusAndNeptuneInSomeOrder { }
                        }
                    }
                }

                public static class FiveHundredMillionYearsAfterSolarSystemFormation
                {
                    public static class SolarSystem
                    {
                        public static class MainSequenceStar { }
                        public static class InnerSolarSystem
                        {
                            public static class MercuryVenusEarthMarsPlanets { }
                        }
                        public static class OuterSolarSystem
                        {
                            public static class Jupiter { }
                            public static class Saturn { }
                            public static class UranusAndNeptunePositioning { }
                        }
                    }
                }

                public static class SevenHundredMillionYearsAfterSolarSystemFormation
                {
                    public static class SolarSystem
                    {
                        public static class MainSequenceStar { }
                        public static class InnerSolarSystem
                        {
                            public static class MercuryVenusEarthMarsPlanets { }
                        }
                        public static class OuterSolarSystem
                        {
                            public static class Jupiter { }
                            public static class Saturn { }
                            public static class Uranus { }
                            public static class Neptune { }
                        }
                    }
                }
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
