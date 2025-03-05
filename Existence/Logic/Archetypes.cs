using System;
using System.Runtime.InteropServices;

namespace Existence.Logic
{
    public class ArchetypesAttribute : Attribute
    {
        public Archetypes[] Archetypes { get; set; }
        public ArchetypesAttribute(params Archetypes[] Archetypes)
        {
            this.Archetypes = Archetypes;
        }
    }

    public enum Archetypes
    {
        /// <summary>
        /// archetype of an anti-hero
        /// </summary>
        AntiHero,

        /// <summary>
        /// archetype of a hero
        /// </summary>
        Hero,

        /// <summary>
        /// archetype of a programmer
        /// </summary>
        Programmer
    }
}
