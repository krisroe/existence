using Existence.Beyond.JudgmentDay;
using Existence.Beyond.Infrastructure;
using Existence.Earth.Alphabet;
using Existence.Earth.Code;
using Existence.Earth.Countries;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human;
using Existence.Earth.Human.People;
using Existence.Earth;
using Existence.Logic;
using Existence.Personal.Infrastructure;
using Existence.Time;
using System;
using System.Drawing;

namespace Existence.Beyond.Timeless
{
    public class Timeless
    {
        private enum VersionHistory
        {
            /// <summary>
            /// first try. Set immutable characteristics, repository structure, last name,
            /// first nuclear family information. Note: There is not actually a contradiction
            /// involving my favorite color even though it looks that way.
            /// </summary>
            [BeyondObjectVersion(1, 0, 0, 0)]
            [PersonalFirst("Timeless Information")]
            [YearDate(2025, 3, 7)]
            Created,

            [BeyondObjectVersion(1, 1, 0, 0)]
            [YearDate(2025, 3, 8)]
            ReworkSexEnum,

            [BeyondObjectVersion(1, 2, 0, 0)]
            [YearDate(2025, 3, 10)]
            AddMyMothersMindAndBodyDeathDates,

            [BeyondObjectVersion(1, 3, 0, 0)]
            [YearDate(2025, 3, 10)]
            AddMothersPetGraveyardWithPersonalOwnership,

            /// <summary>
            /// restructure into self and humanity sections
            /// Add precise birth date/city/name information (evidence I am not any pope)
            /// Add I am the pope song I created and own with timeless purpose
            /// add second nuclear family
            /// </summary>
            [BeyondObjectVersion(2, 0, 0, 0)]
            [YearDate(2025, 3, 22)]
            IAmThePopeRelatedChanges,
        }

        [HumanSpeciesType(HomoSpecies.HomoSapiens)]
        [Archetypes(Archetypes.Programmer)]
        [FavoriteColor(KnownColor.Transparent)]
        [FavoriteNumber(24865)]
        [SecondFavoriteNumber(4)]
        [Sex(Sexes.Male)]
        [Birthdate(1980, 12, 6, 12, 53)]
        [Birthplace((int)CountryLikeThings.UnitedStates, (int)USCities.WisconsinMadison)]
        [BirthName("Christopher Scott Rowe")]
        [HumanGender(HumanGender.Male)]
        public class Self
        {
            [SourceCodeRepositoryUser(CloudRepositoryGitProvider.GitHub, "krisroe")]
            public static class Repositories
            {
                [RepositoryName("existence")]
                public static class Existence { }

                [RepositoryName("musicnotes")]
                public static class Music { }
            }

            [LastName("Rowe")]
            public static class NuclearFamilyUnit
            {
                [MarriageDate(1976, 6, 26)]
                public class v1
                {
                    [Birthdate(1952, 2, 18)]
                    [MindDeathdate(2024, 7, 21)]
                    [BodyDeathdate(2024, 7, 21)]
                    public class Mother
                    {
                        public static class SiblingsByAgeDescending
                        {
                            public static class Mother { }
                            public static class Sister1 { }
                            public static class Brother { }
                            public static class Sister2 { }
                        }
                    }

                    [FavoriteColor(KnownColor.Green)]
                    [Birthdate(1952, 7, 4)]
                    public class Father { }

                    [FavoriteColor(KnownColor.Red)]
                    public class Brother { }

                    [Birthdate(1982, 12, 31)]
                    public class Sister { }
                }
                [MarriageDate(2007, 4, 28)]
                public static class v2
                {
                    [Birthdate(1973, 7, 18)]
                    [Sex(Sexes.Female)]
                    public class Spouse1 { }

                    public class Spouse2 { }

                    [Birthdate(2011, 6, 28)]
                    public class Sister { }

                    [Birthdate(2013, 4, 11)]
                    public class Brother { }
                }
            }

            public class Songs
            {
                [TimelessPurpose("Detect/validate truth/untruth")]
                [Owners((int)PeopleEnumerated.RoweChris)]
                [Creators((int)PeopleEnumerated.RoweChris)]
                public class IAmThePope { }
            }

            [Owners(2025, 3, 10, int.MaxValue, 0, 0, (int)FamilyMembers.MyselfChris)]
            public class MyMothersPetGraveyard { }
        }

        [DistinctHumans(InterestingHumans.Self, InterestingHumans.ThePope)]
        public class Humanity { }
    }

    /// <summary>
    /// indicates two humans are distinct
    /// </summary>
    public class DistinctHumansAttribute : Attribute
    {
        /// <summary>
        /// first interesting human
        /// </summary>
        public InterestingHumans A { get; set; }
        /// <summary>
        /// second interesting human
        /// </summary>
        public InterestingHumans B { get; set; }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="A">first interesting human</param>
        /// <param name="B">second interesting human</param>
        public DistinctHumansAttribute(InterestingHumans A, InterestingHumans B)
        {
            this.A = A;
            this.B = B;
        }
    }

    /// <summary>
    /// interesting humans
    /// </summary>
    public enum InterestingHumans
    {
        /// <summary>
        /// myself
        /// </summary>
        Self = 0,
        /// <summary>
        /// the pope
        /// </summary>
        ThePope = 1,
    }
}