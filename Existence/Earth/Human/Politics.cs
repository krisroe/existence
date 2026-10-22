using System;

namespace Existence.Earth.Human.Politics
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class StateSubsidiaryAttribute : Attribute
    {
        public int StateSubsidiary { get; set; }
        public StateSubsidiaryAttribute(int StateSubsidiary)
        {
            this.StateSubsidiary = StateSubsidiary;
        }
    }

    public class StateSubsidiariesAttribute : Attribute
    {
        public int[] StateSubsidiaries { get; set; }

        public StateSubsidiariesAttribute(params int[] StateSubsidiaries)
        {
            this.StateSubsidiaries = StateSubsidiaries;
        }
    }

    public class ProvincesAttribute : Attribute
    {
        public int[] Provinces { get; set; }
        public ProvincesAttribute(params int[] Provinces)
        {
            this.Provinces = Provinces;
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ProvinceAttribute : Attribute
    {
        public int Province { get; set; }
        public ProvinceAttribute(int Province)
        {
            this.Province = Province;
        }
    }

    public class TerritoriesAttribute : Attribute
    {
        public int[] Territories { get; set; }
        public TerritoriesAttribute(params int[] Territories)
        {
            this.Territories = Territories;
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class TerritoryAttribute : Attribute
    {
        public int Territory { get; set; }
        public TerritoryAttribute(int Territory)
        {
            this.Territory = Territory;
        }
    }

    public class StateSubsidiaryTypeAttribute : Attribute
    {
        public StateSubsidaryType StateSubsidiaryType { get; set; }
        public StateSubsidiaryTypeAttribute(StateSubsidaryType StateSubsidiaryType)
        {
            this.StateSubsidiaryType = StateSubsidiaryType;
        }
    }

    public enum StateSubsidaryType
    {
        Province,
        Territory,
        District,
    }

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
