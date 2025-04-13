
using Existence.Beyond.Infrastructure;
using Existence.Beyond.JudgmentDay;
using System;

namespace Existence.Personal
{
    public class ChurchChoirDirectorEvent : BaseEvent
    {
        public ChurchChoirDirectors Director { get; set; }
        public ChoirType ChoirType { get; set; }
        public ChurchChoirDirectorEvent(ChurchChoirDirectors Director, ChoirType ChoirType) : base(ChoirType.ToString() + " Choir Director: " + Director.ToString())
        {
            this.Director = Director;
            this.ChoirType = ChoirType;
        }
    }

    public enum ChoirType
    {
        Childrens,
        Adult
    }

    public class ChoirTypeAttribute : Attribute
    {
        public ChoirType ChoirType { get; set; }
        public ChoirTypeAttribute(ChoirType ChoirType)
        {
            this.ChoirType = ChoirType;
        }
    }

    public enum ArrangementType
    {
        SATBVoiceAndPiano,
        SoloVoiceAndPiano,
    }

    public class ArrangementAttribute : Attribute
    {
        public ImportantSongs Song { get; set; }
        public ArrangementType ArrangementType { get; set; }
        public ArrangementAttribute(ImportantSongs Song, ArrangementType ArrangementType)
        {
            this.Song = Song;
            this.ArrangementType = ArrangementType;
        }
    }

    public enum ChurchChoirDirectors
    {
        /// <summary>
        /// paperless philosophy collided with my preference for technical difficulty
        /// </summary>
        DeannaClement,
        /// <summary>
        /// childishly tried to annoy her a bunch
        /// </summary>
        EleanorCollins,
        /// <summary>
        /// most competent choir director I've had, not great bedside manner
        /// </summary>
        MartinGanschow,
        /// <summary>
        /// my spouse's favorite, he was not as competent as martin but had
        /// better bedside matter.
        /// </summary>
        MitchellPatton
    }

    public enum PersonalInstruments
    {
        Piano,
        Voice,
        Clarinet,

        /// <summary>
        /// I would have preferred this to clarinet, but it wasn't meant
        /// to be (one part may have been that mr. spargo's daughter had
        /// a lock on it)
        /// </summary>
        Oboe,

        /// <summary>
        /// I wasn't in percussion in band, but I was an extra for
        /// multiple person xylophone pieces (e.g. solo & ensemble)
        Xylophone,

        /// <summary>
        /// under Mr. Yerke in Portage, I believe we once played publicly
        /// in Wisconsin Dells (Bethany Lutheran Church)
        /// </summary>
        Handbells,

        /// <summary>
        /// took group lessons in Portage, never took
        /// </summary>
        Guitar,
    }
}
