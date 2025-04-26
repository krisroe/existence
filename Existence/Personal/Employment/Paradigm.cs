using System;
using System.ComponentModel;

namespace Existence.Personal.Employment
{
    public enum Coworkers
    {
        [Workplaces((int)Workplaces.Paradigm)]
        [Description("Security")]
        JoshBacon,

        [Workplaces((int)Workplaces.Paradigm)]
        [Description("QA")]
        BryanBerndt,

        [Workplaces((int)Workplaces.Paradigm)]
        JasonBulgrin,

        /// <summary>
        /// he was out after the BFS takeover, he tried to be an architect-type for a bit but it didn't work
        /// </summary>
        [Workplaces((int)Workplaces.Paradigm)]
        NathanHerbst,

        [Workplaces((int)Workplaces.Epic)]
        KyleOrCathyKimport,

        [Description("Development Management")]
        [Workplaces((int)Workplaces.Paradigm)]
        KristiMcCombs,

        [Description("Software Test Engineer")]
        [Workplaces((int)Workplaces.Epic)]
        MichaelMcConnell,

        /// <summary>
        /// left after the shooting (she was shot but not seriously). I don't know if that's why she left.
        /// </summary>
        [Workplaces((int)Workplaces.Paradigm)]
        ErinOCallaghan,

        [Workplaces((int)Workplaces.Paradigm)]
        [Description("IT")]
        JacobSieran,

        /// <summary>
        /// deceased
        /// </summary>
        [Workplaces((int)Workplaces.Paradigm)]
        AnthonyTong,

        [Workplaces((int)Workplaces.Paradigm)]
        [Description("IT Management")]
        EvanTouchett,

        [Description("Architect")]
        [Workplaces((int)Workplaces.Paradigm)]
        NickVavra,

        /// <summary>
        /// fluent in spanish, she left awhile after the shooting because it was too much for her
        /// </summary>
        [Workplaces((int)Workplaces.Paradigm)]
        RachelVenegas,

        [Workplaces((int)Workplaces.Paradigm)]
        [Description("IT")]
        MichaelWales,

        [Workplaces((int)Workplaces.Paradigm)]
        [Description("Security")]
        Snyk,
    }

    public enum IndividualCustomers
    {
        /// <summary>
        /// Pella customer IT
        /// </summary>
        MikeMoore,
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
