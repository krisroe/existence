using System;

namespace Existence.Earth.Human.People
{
    public class MarriedAttribute : Attribute
    {
        public bool IsMarried { get; set; }
        public MarriedAttribute(bool IsMarried)
        {
            this.IsMarried = IsMarried;
        }
    }

    public class InRelationshipWithAttribute : Attribute
    {
        PeopleEnumerated Person { get; set; }
        Level Level { get; set; }
        public InRelationshipWithAttribute(PeopleEnumerated p)
        {
            Person = p;
        }
        public InRelationshipWithAttribute(PeopleEnumerated p, Level l) : this(p)
        {
            Level = l;
        }
    }

    public class SexAttribute : Attribute
    {
        public Sexes Sex { get; set; }
        public SexAttribute(Sexes Sex)
        {
            this.Sex = Sex;
        }
    }

    public enum Sexes
    {
        Female,
        Male
    }

    public class GenderAttribute : Attribute
    {
        public Gender Gender { get; set; }
        public GenderAttribute(Gender Gender)
        {
            this.Gender = Gender;
        }
    }

    public enum Gender
    {
        Female,
        Male,
        Nonbinary,
    }

    /// <summary>
    /// occupation held by a human
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class HumanOccupationAttribute : Attribute
    {
        public HumanOccupation Occupation { get; set; }
        public HumanOccupationAttribute(HumanOccupation Occupation)
        {
            this.Occupation = Occupation;
        }
    }

    /// <summary>
    /// occupations that can be held by humans
    /// </summary>
    /// <remarks>named general to specific (e.g. ScientistNuclear) so related occupations sort together</remarks>
    public enum HumanOccupation
    {
        /// <summary>
        /// head of a country who holds authority above the head of government and the elected head of state
        /// (e.g. the Supreme Leader of Iran)
        /// </summary>
        LeaderOfCountrySupreme,

        ScientistNuclear,
    }

    public enum Level
    {
        None,
        Serious,
    }

    /// <summary>
    /// people important enough to have their own enumeration value
    /// </summary>
    public enum PeopleEnumerated
    {
        DuninElonka,
        ParolinPietro,
        /// <summary>
        /// pope Leo XIV
        /// </summary>
        PrevostRobertFrancis,
        RoweChris,
        RoweSonya,
        SwiftTaylor,
        ZuppiMatteo,
    }
}
