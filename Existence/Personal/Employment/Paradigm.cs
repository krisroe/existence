using System;
using System.ComponentModel;
using Existence.Song;
using Existence.Time;

namespace Existence.Personal.Employment
{
    public enum Coworkers
    {
        [Workplaces((int)Workplaces.Paradigm)]
        [Description("Security")]
        BaconJosh,

        [Workplaces((int)Workplaces.Paradigm)]
        [Description("QA")]
        BerndtBryan,

        [Workplaces((int)Workplaces.Paradigm)]
        BulgrinJason,

        /// <summary>
        /// he was out after the BFS takeover, he tried to be an architect-type for a bit but it didn't work
        /// </summary>
        [Workplaces((int)Workplaces.Paradigm)]
        HerbstNathan,

        [Workplaces((int)Workplaces.Epic)]
        KimportKyleOrCathy,

        /// <summary>
        // was in UW-Madison band
        /// </summary>
        [Workplaces((int)Workplaces.Paradigm)]
        [MusicalInstrument(MusicalInstruments.Tuba)]
        KothBen,

        [Workplaces((int)Workplaces.Paradigm)]
        [MusicalInstrument(MusicalInstruments.PercussionDrumSet)]
        MarcAureleBruno,

        [Description("Development Management")]
        [Workplaces((int)Workplaces.Paradigm)]
        McCombsKristi,

        [Description("Software Test Engineer")]
        [Workplaces((int)Workplaces.Epic)]
        McConnellMichael,

        /// <summary>
        /// left after the shooting (she was shot but not seriously). I don't know if that's why she left.
        /// </summary>
        [Workplaces((int)Workplaces.Paradigm)]
        OCallaghanErin,

        /// <summary>
        /// let go in BFS 10% purge
        /// </summary>
        [Workplaces((int)Workplaces.Paradigm)]
        RodriguezNatalie,

        [Workplaces((int)Workplaces.Paradigm)]
        [Description("IT")]
        SieranJacob,

        [Workplaces((int)Workplaces.Paradigm)]
        [Description("Security")]
        Snyk,

        /// <summary>
        /// deceased
        /// </summary>
        [Workplaces((int)Workplaces.Paradigm)]
        [DeathDate(2018, 9, 19)]
        TongAnthony,

        [Workplaces((int)Workplaces.Paradigm)]
        [Description("IT Management")]
        TouchettEvan,

        /// <summary>
        /// let go in 10% BFS purge
        /// </summary>
        [Workplaces((int)Workplaces.Paradigm)]
        TrognerCory,

        [Workplaces((int)Workplaces.Paradigm)]
        [MusicalInstrument(MusicalInstruments.PercussionDrumSet)]
        VandersteenRob,

        [Description("Architect")]
        [Workplaces((int)Workplaces.Paradigm)]
        VavraNick,

        /// <summary>
        /// fluent in spanish, she left awhile after the shooting because it was too much for her
        /// </summary>
        [Workplaces((int)Workplaces.Paradigm)]
        VenegasRachel,

        [Workplaces((int)Workplaces.Paradigm)]
        [Description("IT")]
        WalesMichael,
    }

    public enum IndividualCustomers
    {
        /// <summary>
        /// Pella customer IT
        /// </summary>
        MooreMike,
    }

    public class WorkplacesAttribute : Attribute
    {
        public int[] Workplaces { get; set; }
        public WorkplacesAttribute(params int[] Workplaces)
        {
            this.Workplaces = Workplaces;
        }
    }
    
    public enum Workplaces
    {
        BOSSInternational,
        Epic,
        GrothmanAndAssociates,
        MyMothersParentsFarm,
        Paradigm,
        /// <summary>
        /// technically I was a temp
        /// </summary>
        PhilipsMedical,
    }
}
