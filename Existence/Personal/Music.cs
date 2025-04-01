
using Existence.Beyond.Infrastructure;

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
}
