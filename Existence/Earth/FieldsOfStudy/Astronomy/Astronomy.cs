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

                [Age("Solar System Age", "1000 years")]
                public static class ProtostarAndProtoplanetaryDiskForm
                {
                    /// <summary>
                    /// still collapsing
                    /// </summary>
                    public static class SolarNebula
                    {
                        /// <summary>
                        /// no hydrogen fusion has started but gravitational contraction produces heat
                        /// continues accreting mass, spinning, contracting, and heating up
                        /// </summary>
                        public static class CentralCoreBecomesDenserAndHotterMaking
                        {
                            public static class Protostar { }
                        }

                        public static class PGasOrganizesIntoFlattenedRotatingStructureMaking
                        {
                            /// <summary>
                            /// rotating disk of gas and dust. rich in hydrogen, helium, and heavy elements but no solid material yet.
                            /// becoming more structured (flattening), but still mostly gas (some dust)
                            /// materials beginning to settle into a rotating plane
                            /// rich in hydrogen, helium, and heavy elements but no solid material yet.
                            /// Turbulence and magnetic fields begin influencing material movement in the disk
                            /// </summary>
                            public static class ProtoplanetaryDisk { }
                        }
                    }
                }

                [Age("Solar System Age", "1,500 years")]
                public static class InnerVersusOuterDiskDifferentiationBegins
                {
                    public static class SolarNebula
                    {
                        /// <summary>
                        /// Still forming, not yet a T Tauri star, accumulating mass.
                        /// </summary>
                        public static class Protostar { }

                        /// <summary>
                        /// Beginning to form but still dense and thick with gas.
                        /// </summary>
                        public static class ProtoplanetaryDisk
                        {
                            /// <summary>
                            /// ~0.1-5 AU, extremely hot, no solid bodies yet, just gas and dust, allowing only metal and silicate grains to survive
                            /// </summary>
                            public static class InnerRegion { }

                            /// <summary>
                            /// ~5-50 AU, remain cooler, allowing ices and volatiles to start accumulating.
                            /// </summary>
                            public static class OuterRegion { }

                            /// <summary>
                            /// None yet; dust grains were still microscopic.
                            /// </summary>
                            public static class Planetisimals { }
                        }
                    }
                }

                [Age("Solar System Age", "2,000 years")]
                public static class StrongerMagneticAndSolarWindEffects
                {
                    public static class SolarNebula
                    {
                        /// <summary>
                        /// hot and growing, becoming more luminous
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

                            /// <summary>
                            /// No planetesimals (~1–10 km) had formed yet, but the conditions were improving for their emergence.
                            /// Gas and dust were beginning to clump together in some regions, the first step toward planetesimal formation.
                            /// The system was still dominated by gas and microscopic dust.
                            /// </summary>
                            public static class Planetisimals { }
                        }
                    }
                }

                [Age("Solar System Age", "3,000 years")]
                public static class DustGrainsStartToClumpTogether
                {
                    /// <summary>
                    /// structured, rotating disk
                    /// </summary>
                    public static class SolarNebula
                    {
                        /// <summary>
                        /// producing heat from gravitational contraction but not yet fusing hydrogen
                        /// heating up, rapidly spinning, producing heat from gravitational contraction
                        /// strong magnetic activity, and solar winds
                        /// </summary>
                        public static class Protostar { }
                        /// <summary>
                        /// continues spinning, with increasing density variations.
                        /// Microscopic dust particles begin sticking together, forming millimeter-sized grains
                        /// These will later merge into larger solid bodies (pebbles and planetisimals)
                        /// </summary>
                        public static class ProtoplanetaryDisk
                        {
                            /// <summary>
                            /// ~0.1-5 AU, extremely hot, allowing only metal and silicate grains to survive, favoring rocky planet formation
                            /// </summary>
                            public static class InnerRegion { }

                            /// <summary>
                            /// ~5-50 AU, remain cooler, where ices can persist, allowing ice-rich materials to accumulate
                            /// </summary>
                            public static class OuterRegion { }

                            /// <summary>
                            /// Microscopic dust grains begin sticking together, forming millimeter-sized particles,
                            /// first step toward planetisimal formation
                            /// Some denser areas in the disk begin accumulating pebbles (~mm to cm in size).
                            /// These pebbles are the precursors to larger planetesimals but are still loosely bound
                            /// </summary>
                            public static class Planetisimals { }
                        }
                    }
                }

                [Age("Solar System Age", "3,500 years")]
                public static class DustGrainsBeginGrowingIntoPebbles
                {
                    /// <summary>
                    /// Dust grains had begun merging into larger pebbles, a key step toward planetesimals.
                    /// Microscopic dust grains (~micron-sized) begin clumping together into millimeter-centimeter sized particles
                    /// These will later merge into larger solid objects like planetisimals
                    /// Density variations in the gas helped guide pebbles into clumps.
                    /// </summary>
                    public static class ProtoplanetaryDisk { }
                }

                [Age("Solar System Age", "4,000 years")]
                public static class SunActivityIntensifies
                {
                    /// <summary>
                    /// ~0.1-5 AU, Too hot for ice, leading to rocky/metallic pebble formation
                    /// </summary>
                    public static class InnerRegion { }

                    /// <summary>
                    /// ~5-50 AU, Cold, allowing icy material to accumulate into larger pebbles
                    /// </summary>
                    public static class OuterRegion { }

                    /// <summary>
                    /// First centimeter-sized solid aggregates forming (~1–3 cm).
                    /// Pebbles grew larger in high-density regions, setting up conditions for planetesimal formation.
                    /// Small-scale spirals and turbulence helped concentrate dust and pebbles into clusters.
                    /// </summary>
                    public static class Planetisimals { }
                }

                [Age("Solar System Age", "4,500 years")]
                public static class PebblesStartToAccumulateIntoLargerAggregate
                {
                    /// <summary>
                    /// First loosely bound clumps of pebbles (~10 cm scale)
                    /// Pebbles continued merging into larger aggregates, setting the stage for planetesimals (~1–10 km) to form soon.
                    /// Gas eddies and spiral arms helped concentrate pebbles in some regions, influencing future planetary growth.
                    /// </summary>
                    public static class Planetisimals { }
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
                        /// The disk was more structured, with spiral arms and turbulence helping to collect solid material.
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

                            /// <summary>
                            /// First weakly bound planetesimal precursors (~10 cm to 1 meter scale).
                            /// Pebbles were merging into larger clumps, forming the first pre-planetesimals.
                            /// These structures were fragile but represented the earliest stage of planetary building blocks.
                            /// </summary>
                            public static class Planetisimals { }
                        }
                    }
                }

                [Age("Solar System Age", "5,500 years")]
                public static class PebblesContinueGrowing
                {
                    /// <summary>
                    /// Near the T Tauri phase, meaning gas in the inner disk is starting to be influenced by solar winds.
                    /// </summary>
                    public static class Protostar { }

                    public static class ProtoplanetaryDisk
                    {
                        /// <summary>
                        /// ~0.1-5 AU, Too hot for ice, rock and metal-based solids accumulating
                        /// </summary>
                        public static class InnerRegionRocky { }

                        /// <summary>
                        /// ~5-50 AU, Colder, allowing icy material to accumulate into larger bodies
                        /// </summary>
                        public static class OuterRegionIcy { }

                        /// <summary>
                        /// First weak planetesimal precursors (~10 cm to 1 meter in size)
                        /// Small solid bodies were forming, but not yet full planetesimals (~1–10 km).
                        /// </summary>
                        public static class Planetisimals { }
                    }
                }

                [Age("Solar System Age", "6,000 years")]
                public static class InnerAndOuterDiskDifferentiationBecomesMorePronounced
                {
                    /// <summary>
                    /// First weak planetesimals (~1–10 km) may have started forming.
                    /// Some of the earliest full planetesimals (~1–10 km) may have begun forming in high-density regions
                    /// </summary>
                    public static class Planetisimals { }
                }

                [Age("Solar System Age", "7,000 years")]
                public static class FirstKilometerSizedObjectsStartToForm
                {
                    /// <summary>
                    /// fully active T Tauri star, producing stronger solar winds, radiation, and magnetic activity.
                    /// Solar winds begin dispersing lighter gas from the inner solar system.
                    /// </summary>
                    public static class TTauriStar { }

                    /// <summary>
                    /// First planetesimals (~1–10 km) forming
                    /// High-density regions in the disk now contain planetesimals (~1–10 km in size)
                    /// These early planetary building blocks will eventually grow into protoplanets.
                    /// Collisions between larger aggregates are beginning to form planetesimals.
                    /// </summary>
                    public static class Planetisimals { }
                }

                [Age("Solar System Age", "8,000 years")]
                public static class TTauriPhaseBeginsInfluencingDiskEvolution
                {
                    public class SolarNebula
                    {
                        /// <summary>
                        /// The Sun’s strong solar winds continued clearing gas from the inner solar system
                        /// This gas clearing slowed down terrestrial planet formation but had less impact on the outer solar system.
                        /// </summary>
                        public static class TTauriStar { }

                        /// <summary>
                        /// The inner disk was becoming more solid-heavy, while the outer disk retained more gas
                        /// </summary>
                        public static class ProtoplanetaryDisk
                        {
                            /// <summary>
                            /// ~0.1-5 AU: Gas is beginning to thin out, favoring rocky planet formation
                            /// </summary>
                            public static class InnerRegionRockyHot { }

                            /// <summary>
                            /// ~5-50 AU: Gas is still abundant, allowing for giant planet core formation
                            /// </summary>
                            public static class OuterRegionIcyCooler { }

                            /// <summary>
                            /// More planetesimals (~1–10 km) forming, some reaching ~50 km
                            /// High-density regions of the disk now contained many planetesimals, some exceeding 50 km in size.
                            /// These bodies were on their way to becoming protoplanets
                            /// </summary>
                            public static class Planetisimals { }
                        }
                    }
                }

                [Age("Solar System Age", "9,000 years")]
                public static class NineThousandYears
                {
                    public class SolarNebula
                    {
                        /// <summary>
                        /// The Sun’s strong solar wind continued clearing gas from the inner solar system.
                        /// This gas loss meant that terrestrial planets would form primarily from solid collisions
                        /// </summary>
                        public static class TTauriStar { }

                        public static class ProtoplanetaryDisk
                        {
                            /// <summary>
                            /// ~0.1-5 AU: Gas content was low, meaning planets would form from rocky planetesimals.
                            /// </summary>
                            public static class InnerRegionRockyHot { }

                            /// <summary>
                            /// ~5-50 AU: Still gas-rich, where gas giants could still form.
                            /// </summary>
                            public static class OuterRegionIcyCooler { }

                            /// <summary>
                            /// More planetesimals (~10–100 km) forming and colliding
                            /// Many objects grew larger through collisions and mergers, with some reaching 100 km
                            /// These larger bodies were the first gravitationally dominant solid objects
                            /// </summary>
                            public static class Planetisimals { }

                            /// <summary>
                            /// First protoplanets (~100+ km) likely forming
                            /// The largest planetesimals were transitioning into protoplanets (~100+ km in size)
                            /// Planetesimals were merging into large enough bodies (~100 km) that could eventually form planets
                            /// </summary>
                            public static class Protoplanets { }
                        }
                    }
                }


                [Age("Solar System Age", "10,000 years")]
                public static class CollisionsBetweenPlanetisimalsIncrease
                {
                    /// <summary>
                    /// Solar winds continued clearing gas from the inner solar system, favoring rocky planet growth
                    /// The outer disk still contained enough gas for future gas giant formation
                    /// </summary>
                    public static class TTauriStar { }

                    /// <summary>
                    /// structured, dominated by solids
                    /// </summary>
                    public static class ProtoplanetaryDisk
                    {
                        /// <summary>
                        /// ~0.1-5 AU: Mostly depleted of gas, making solid accretion the main growth method for rocky planets
                        /// </summary>
                        public static class InnerRegionRockyHot { }

                        /// <summary>
                        /// ~5-50 AU: Still gas-rich, where gas giant cores could begin forming
                        /// </summary>
                        public static class OuterRegionIcyCooler { }

                        /// <summary>
                        /// Widespread planetesimals (~10–100 km) and emerging protoplanets (~100–500 km)
                        /// Many planetesimals had merged into protoplanets (~100–500 km), the first dominant planetary building blocks
                        /// These objects began gravitationally influencing smaller planetesimals, driving more rapid growth
                        /// The largest bodies (~500 km) had begun runaway growth, accelerating their dominance over smaller planetesimals
                        /// The system was now transitioning toward an era of planetary embryos
                        /// the first protoplanets were beginning to emerge, setting the stage for larger planetary formation
                        /// </summary>
                        public static class Protoplanets { }


                        public static class JupiterPlanetarEmbryo { }

                        public static class EmbryoThatWouldBecomeSaturnExists { }
                        public static class EmbryosThatWouldFormUranusAndNeptuneExistButNotDominant { }
                    }
                }

                [Age("Solar System Age", "11,000 years")]
                public static class ProtostarContinuesContracting
                {
                    public static class TTauriStar { }

                    public static class ProtoplanetaryDisk
                    {
                        /// <summary>
                        /// ~0.1-5 AU: Low gas content, meaning planets formed by solid accretion rather than gas capture
                        /// </summary>
                        public static class InnerRegionRockyHot { }

                        /// <summary>
                        /// ~5-50 AU: Still gas-rich, where gas giant cores could begin forming
                        /// </summary>
                        public static class OuterRegionIcyCooler { }

                        /// <summary>
                        /// Widespread planetesimals (~10–100 km) and emerging protoplanets (~100–1,000 km)
                        /// Many planetesimals had merged into protoplanets (~100–500 km), and the first planetary embryos (~1,000 km) had appeared
                        /// Runaway growth was accelerating for the largest protoplanetsThe biggest objects (~500+ km) began rapidly pulling in material, leaving smaller planetesimals behind
                        /// The biggest objects (~500+ km) began rapidly pulling in material, leaving smaller planetesimals behind
                        /// </summary>
                        public static class Protoplanets { }

                        public static class MarsPlanetaryEmbryo { }

                        /// <summary>
                        /// still competing with other embryos
                        /// </summary>
                        public static class PlanetaryEmbryosThatWouldBecomeMarsVenusEarth { }

                        /// <summary>
                        /// embryo (or core) was forming
                        /// </summary>
                        public static class JupiterPlanetaryEmbryoBecomingCore { }

                        public static class EmbryosCompetingInSaturnUranusNeptuneRegions { }
                    }
                }

                [Age("Solar System Age", "11,400 years")]
                public static class ElevenThousandFourHunded
                {
                    /// <summary>
                    /// solar winds are rapidly depleting gas from the inner solar system
                    /// This means that inner planets will form entirely from solid body accretio
                    /// </summary>
                    public static class TTauriStar { }

                    /// <summary>
                    /// The largest planetary embryos (~2,000+ km) now dominate their regions.
                    /// Many smaller embryos (~1,000 km) are either merging or getting ejected.
                    /// </summary>
                    public static class PlanetaryEmbryos { }
                }

                [Age("Solar System Age", "11,800 years")]
                public static class ElevenThousandEightHundred
                {
                    /// <summary>
                    /// Large-scale collisions between planetary embryos (~1,000–3,000 km) are becoming more common
                    /// Some giant impacts may begin shaping future planets (like the Moon-forming impact much later).
                    /// </summary>
                    public static class PlanetaryEmbryos { }

                    /// <summary>
                    /// The largest planetary embryo in the outer solar system (~3,000+ km) continues to accumulate mass.
                    /// It is on its way to becoming Jupiter’s core but is not yet massive enough to start gas accretion.
                    /// </summary>
                    public static class JupiterPlanetaryEmbryoBecomingCore { }
                }

                [Age("Solar System Age", "12,000 years")]
                public static class TwelveThousand
                {
                    /// <summary>
                    /// The number of planetary embryos has significantly decreased, as larger bodies (~3,000 km) now dominate the inner and outer solar system.
                    /// </summary>
                    public static class PlanetaryEmbryos { }

                    /// <summary>
                    /// A large planetary embryo (~2,000–3,000 km) was growing at ~1 AU
                    /// Earth was still competing with several other large embryos.
                    /// A giant impact (like Theia) would later help define its final mass.
                    /// </summary>
                    public static class EarthEmbryo { }

                    /// <summary>
                    /// A planetary embryo (~2,000–3,000 km) existed at ~0.7 AU
                    /// Multiple embryos were likely competing in the Venusian region.
                    /// Collisions would determine the final size of Venus.
                    /// </summary>
                    public static class VenusEmbryo { }

                    /// <summary>
                    /// Small embryos (~500–1,500 km) existed near ~0.4 AU
                    /// Mercury’s final size was relatively small, meaning it likely lost mass in collisions.
                    ///  It may have started as a larger embryo that was later stripped of its mantle.
                    /// </summary>
                    public static class MercuryEmbryo { }

                    /// <summary>
                    /// Planetary embryo (~1,500 km) likely existed near 1.5 AU
                    /// Mars' final mass is small (~10% of Earth), meaning its embryo would have remained relatively small.
                    /// It likely faced less competition than Venus and Earth’s embryos, making it easier to connect to the final planet.
                    /// </summary>
                    public static class MarsEmbryoDistinct { }

                    /// <summary>
                    /// Large planetary embryo (~3,000 km) was growing at ~5 AU
                    /// Jupiter’s core had already begun forming, meaning it was the dominant embryo in the outer solar system.
                    /// While it had not yet started gas accretion, it was clearly on track to become Jupiter.
                    /// </summary>
                    public static class JupiterPlanetaryEmbryoBecomingCore { }


                    /// <summary>
                    /// Multiple large planetary embryos (~2,000+ km) were forming in the outer solar system
                    ///  Several large icy protoplanets (~1,500–3,500 km) were forming.
                    ///  It was not yet clear which one would become Saturn, Uranus, or Neptune.
                    /// </summary>
                    public static class SaturnEmbryoRapidlyGrowingNearingRegionalDominance { }
                    public static class UranusNeptuneEmbryosMergingAndCompeting { }
                }

                [Age("Solar System Age", "13,000 years")]
                public static class ThirteenThousand
                {
                    /// <summary>
                    /// Jupiter’s early core (~3,500+ km) was approaching the mass needed for runaway gas accretion
                    /// Jupiter’s core was still growing, but it had not yet reached the critical mass (~10–20 Earth masses) required to capture gas rapidly
                    /// </summary>
                    public static class JupiterCore { }

                    /// <summary>
                    /// dominating region
                    /// </summary>
                    public static class SaturnEmbryo { }

                    /// <summary>
                    /// Smaller than Neptune's, still competing in a lower-density region.
                    /// </summary>
                    public static class UranusEmbryo { }

                    /// <summary>
                    /// Still growing, competing with other large outer solar system embryos.
                    /// </summary>
                    public static class NeptuneEmbryo { }

                    /// <summary>
                    /// Still growing, competing with other rocky embryos (still competing)
                    /// </summary>
                    public static class VenusEmbryo { }

                    /// <summary>
                    /// Dominant but still competing with other embryos in the inner solar system 
                    /// </summary>
                    public static class EarthEmbryo { }

                    /// <summary>
                    /// Likely smaller than Earth’s and Venus’ embryos, already approaching final size.
                    /// </summary>
                    public static class MarsEmbryo { }

                    /// <summary>
                    /// Smaller, likely already past peak growth due to inner solar system mass depletion.
                    /// </summary>
                    public static class MercuryEmbryo { }
                }

                [Age("Solar System Age", "13,200 years")]
                public static class RunawayGrowthContinuesForTheLargestEmbryos
                {
                    /// <summary>
                    /// Some planetary embryos (~2,500–3,500 km) are growing much faster than smaller ones, solidifying their dominance.
                    /// </summary>
                    public static class PlanetaryEmbryos { }

                    /// <summary>
                    /// Mars' embryo (~1,500 km) was likely stable and near its final size.
                    /// </summary>
                    public static class MarsEmbryo { }
                }

                [Age("Solar System Age", "13,400 years")]
                public static class InnerSolarSystemBecomingMoreDefined
                {
                    /// <summary>
                    /// solar winds continue to clear gas, reducing the chance of gas accretion in the inner solar system.
                    /// </summary>
                    public static class TTauriSun { }

                    /// <summary>
                    /// Larger planetary embryos (~2,500–3,500 km) that will form Venus, Earth, and Mars continue to grow
                    /// </summary>
                    public static class VenusEarthMarsEmbryosContinueToGrow { }
                }

                [Age("Solar System Age", "13,600 years")]
                public static class JupitersCoreReachesCriticalMass
                {
                    /// <summary>
                    /// The largest planetary embryo in the outer solar system (Jupiter’s future core) reaches ~5 Earth masses.
                    /// Jupiter is nearing the mass necessary to begin attracting significant amounts of gas (~10 Earth masses needed for runaway accretion).
                    /// </summary>
                    public static class JupiterEmbryo { }
                }

                [Age("Solar System Age", "13,800 years")]
                public static class MoreProtoplanetaryCollisionsReduceTheNumberOfEmbryos
                {
                    /// <summary>
                    /// Large planetary embryos (~2,500+ km) are colliding, reducing the total number of embryos.
                    /// Some of these impacts may be similar to those that later form the Moon or strip Mercury’s mantle.
                    /// </summary>
                    public static class PlanetaryEmbryos { }
                }

                [Age("Solar System Age", "14,000 years")]
                public static class AMoreDefinedPlanetaryStructureIsEmerging
                {
                    /// <summary>
                    /// largest planetary embryos (~3,000+ km) are now clearly dominant in their respective regions.
                    /// </summary>
                    public static class PlanetaryEmbryos { }

                    /// <summary>
                    /// approaching the point where it will soon start runaway gas accretion.
                    /// </summary>
                    public static class JupiterCore { }

                    /// <summary>
                    /// Distinct core forming but still accumulating mass before gas accretion
                    /// </summary>
                    public static class SaturnEmbryo { }

                    /// <summary>
                    /// Still growing, now largely distinct from other planetary embryos.
                    /// </summary>
                    public static class NeptuneEmbryo { }

                    /// <summary>
                    /// Smaller than Neptune's, but likely no longer facing major competition.
                    /// </summary>
                    public static class UranusEmbryo { }

                    /// <summary>
                    /// Dominant but still accreting material, not yet in final form.
                    /// </summary>
                    public static class EarthEmbryo { }

                    /// <summary>
                    /// Still growing, nearing its final form.
                    /// </summary>
                    public static class VenusEmbryo { }

                    /// <summary>
                    /// Likely stable, already near its final mass and size.
                    /// </summary>
                    public static class MarsEmbryo { }

                    /// <summary>
                    /// Likely past peak growth, with some mass loss potential from later collision
                    /// </summary>
                    public static class MercuryEmbryo { }
                }

                [Age("Solar System Age", "14,200 years")]
                public static class RunawayGrowthContinuesForLargestEmbryos
                {
                    /// <summary>
                    /// Some planetary embryos (~2,500–3,500 km) are growing rapidly due to gravitational dominance
                    /// </summary>
                    public static class PlanetaryEmbryo { }

                    /// <summary>
                    /// Mars' embryo (~1,500 km) is fully formed and no longer growing significantly.
                    /// </summary>
                    public static class MarsEmbryo { }
                }

                [Age("Solar System Age", "14,400 years")]
                public static class InnerSolarSystemBecomesStructurallyMoreDefined
                {
                    /// <summary>
                    /// The T Tauri Sun’s solar winds continue clearing remaining gas in the inner solar system (~0.1–5 AU).
                    /// </summary>
                    public static class TTauriSun { }

                    /// <summary>
                    /// Earth (~3,000 km) and Venus (~3,000 km) are still competing for material, but their final planetary structures are nearly complete.
                    /// </summary>
                    public static class EarthAndVenus { }
                }

                /// <summary>
                /// The largest planetary embryo in the outer solar system (Jupiter’s future core) reaches ~9–10 Earth masses.
                /// Jupiter is at the lower boundary of the mass needed for runaway gas accretion (~10–20 M⊕).
                /// </summary>
                [Age("Solar System Age", "14,600 years")]
                public static class JupitersCoreReachesACriticalMass
                {
                    /// <summary>
                    /// Large planetary embryos (~2,500+ km) are still merging, further reducing the number of competing bodies.
                    /// Some of these collisions may be similar to the giant impacts that will later form Earth’s Moon or strip Mercury’s mantle.
                    /// </summary>
                    [Age("Solar System Age", "14,800 years")]
                    public static class MoreProtoplanetaryCollisionsReduceTheNumberOfEmbryos
                    {

                    }
                }

                /// <summary>
                /// The largest planetary embryos (~3,000+ km) now dominate their regions and will become the final planets.
                /// Jupiter’s core (~5,500 km, ~10 M⊕) is on the verge of starting runaway gas accretion.
                /// </summary>
                [Age("Solar System Age", "15,000 years")]
                public static class ANearlyFinalizedPlanetaryStrutureIsEmerging 
                {
                    /// <summary>
                    /// Fewer, but larger planetary embryos (~2,500–3,500 km) exist. The embryos of Mars, Venus, and Earth are almost fully formed.
                    /// Mars' embryo (~1,500 km) was likely stable and fully formed, while Earth (~3,000 km) and Venus (~3,000 km) were nearly finished accreting material.
                    /// Mercury’s embryo (~1,200–1,500 km) may have already experienced some early mass loss, but it was still present as a small planetary body.
                    /// </summary>
                    public static class InnerSolarSystem { }

                    /// <summary>
                    /// The largest planetary embryo (~5,500 km, ~10 M⊕) was growing into Jupiter’s core. Some other embryos were competing for Saturn, Uranus, and Neptune’s final sizes.
                    /// Saturn (~3,500 km, ~3–4 M⊕), Neptune (~2,800 km, ~2–3 M⊕), and Uranus (~2,500 km, ~1.5–2.5 M⊕) were in the final stages of forming their cores.
                    /// </summary>
                    public static class OuterSolarSystem { }
                }

                public static class FifteenThousand
                {
                    public static class SaturnEmbryoDominantInArea { }
                    public static class UranusNeptuneEmbryosStillInCompetitionNotYetFullyDistinct { }
                }

                public static class TwentyThousand
                {
                    public static class SaturnCoreGrowingNearingGasAccretion { }
                    public static class NeptuneAndUranusStillCompetingWithOtherProtoPlanets { }
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
