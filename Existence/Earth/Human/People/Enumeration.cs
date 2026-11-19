using System;
using Existence.Earth.Countries;

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

    public class SexAndGenderAttribute : Attribute
    {
        public Sexes SexAndGender { get; set; }
        public SexAndGenderAttribute(Sexes SexAndGender)
        {
            this.SexAndGender = SexAndGender;
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
        /// <summary>
        /// the occupation
        /// </summary>
        public HumanOccupation Occupation { get; set; }

        /// <summary>
        /// country the occupation is held for, where it applies to a country (e.g. a prime minister)
        /// </summary>
        public CountryLikeThings? Country { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Occupation">the occupation</param>
        public HumanOccupationAttribute(HumanOccupation Occupation)
        {
            this.Occupation = Occupation;
            this.Country = null;
        }

        /// <summary>
        /// constructor for an occupation held for a country
        /// </summary>
        /// <param name="Occupation">the occupation</param>
        /// <param name="Country">country the occupation is held for</param>
        public HumanOccupationAttribute(HumanOccupation Occupation, CountryLikeThings Country)
        {
            this.Occupation = Occupation;
            this.Country = Country;
        }
    }

    /// <summary>
    /// occupations that can be held by humans
    /// </summary>
    /// <remarks>named general to specific (e.g. ScientistNuclear) so related occupations sort together</remarks>
    public enum HumanOccupation
    {
        Accountant,

        Agronomist,

        EngineerSoftware,

        GuardSecurity,

        /// <summary>
        /// head of a country who holds authority above the head of government and the elected head of state
        /// (e.g. the Supreme Leader of Iran)
        /// </summary>
        LeaderOfCountrySupreme,

        /// <summary>
        /// head of government of a country
        /// </summary>
        MinisterPrimeOfCountry,

        NurseVeterinary,

        ScientistNuclear,

        WorkerAgricultural,

        WorkerSocial,
    }

    /// <summary>
    /// a person who was retired, optionally with the occupation they retired from
    /// </summary>
    /// <remarks>
    /// used instead of <see cref="HumanOccupationAttribute"/>, which is for an occupation the person currently holds
    /// </remarks>
    public class RetiredAttribute : Attribute
    {
        /// <summary>
        /// occupation the person retired from, if known
        /// </summary>
        public HumanOccupation? FormerOccupation { get; set; }

        /// <summary>
        /// constructor for when the former occupation is unknown
        /// </summary>
        public RetiredAttribute()
        {
            this.FormerOccupation = null;
        }

        /// <summary>
        /// constructor for when the former occupation is known
        /// </summary>
        /// <param name="FormerOccupation">occupation the person retired from</param>
        public RetiredAttribute(HumanOccupation FormerOccupation)
        {
            this.FormerOccupation = FormerOccupation;
        }
    }

    /// <summary>
    /// a person who was a student
    /// </summary>
    /// <remarks>
    /// kept separate from <see cref="HumanOccupationAttribute"/>; use <see cref="StudentUniversityAttribute"/> for a university student
    /// </remarks>
    public class StudentAttribute : Attribute
    {
    }

    /// <summary>
    /// a person who was a university student
    /// </summary>
    public class StudentUniversityAttribute : StudentAttribute
    {
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
