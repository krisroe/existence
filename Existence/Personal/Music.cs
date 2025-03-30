
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
        DeannaClement,
        EleanorCollins,
        MartinGanschow,
        MitchellPatton
    }
}
