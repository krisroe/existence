using System;

namespace Existence.Earth.Human
{
    public class HumanSpeciesTypeAttribute : Attribute
    {
        public HomoSpecies HomoSpecies { get; set; }
        public HumanSpeciesTypeAttribute(HomoSpecies HomoSpecies)
        {
            this.HomoSpecies = HomoSpecies;
        }
    }

    public enum HomoSpecies
    {
        /// <summary>
        /// last surviving homo species
        /// </summary>
        HomoSapiens,

        /// <summary>
        /// Coexisted and interbred with homo sapiens in Europe and Western Asia for tens of thousands of years.
        /// Extinct ~40,000 years ago.
        /// </summary>
        HomoNeanderthalensis,

        /// <summary>
        /// Known mostly from DNA and a few fossils in Siberia, China, and Tibet.
        /// Distinct from Neanderthals and Homo sapiens.
        /// Interbred with both species.
        /// Extinct likely ~40,000–30,000 years ago, but exact date unclear.
        /// 
        /// Formal species name is SPECULATIVE, paleoanthropologists have not yet assigned a formal species name
        /// since it has been primarily identified through DNA
        /// </summary>
        HomoDenisovaensis,

        /// <summary>
        /// “Hobbit” species from Flores Island, Indonesia.
        /// Dated to as recent as ~50,000 years ago.
        /// Tiny size, distinct morphology.
        /// </summary>
        HomoFloresiensis,

        /// <summary>
        /// Discovered in the Philippines.
        /// Dated to ~50,000–67,000 years ago.
        /// Distinct dental and bone traits.
        /// </summary>
        HomoLuzonensis,
    }
}
