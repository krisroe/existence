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

    public class HumanGenderAttribute : Attribute
    {
        public HumanGender Gender { get; set; }
        public HumanGenderAttribute(HumanGender Gender)
        {
            this.Gender = Gender;
        }
    }

    public enum HumanGender
    {
        Female,
        Male,
        Nonbinary,
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
        RoweChris,
        RoweSonya,
        SwiftTaylor,
        ZuppiMatteo,
    }
}
