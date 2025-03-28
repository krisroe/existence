using System;

namespace Existence.Earth.Human
{
    public enum PoliticalPhilosophies
    {
        Communist,
        Conservative,
        Environmentalist,
        Liberal,
        Libertarian,
        Socialist,
    }

    [Flags]
    public enum PoliticalPhilosophiesFlags
    {
        None = 0,
        Communist = 1,
        Environmentalist = 2,
        Socialist = 4,
        Liberal = 8,
        Conservative = 16,
        Libertarian = 32,
    }

    public class PoliticalPhilosophiesAttribute : Attribute
    {
        public PoliticalPhilosophies[] PoliticalPhilosophies;
        public PoliticalPhilosophiesAttribute(params PoliticalPhilosophies[] PoliticalPhilosophies)
        {
            this.PoliticalPhilosophies = PoliticalPhilosophies;
        }
    }

    public class PoliticalPhilosophyFlagsAttribute : Attribute
    {
        public PoliticalPhilosophiesFlags Flags { get; set; }
        public PoliticalPhilosophyFlagsAttribute(PoliticalPhilosophiesFlags Flags)
        {
            this.Flags = Flags;
        }
    }
}
