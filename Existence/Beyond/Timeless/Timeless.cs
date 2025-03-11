using Existence.Beyond.JudgmentDay;
using Existence.Beyond.Infrastructure;
using Existence.Earth.Alphabet;
using Existence.Earth.Code;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.People;
using Existence.Earth;
using Existence.Logic;
using Existence.Personal.Infrastructure;
using Existence.Time;
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
        }


        [Archetypes(Archetypes.Programmer)]
        [FavoriteColor(KnownColor.Transparent)]
        [HumanGender(HumanGender.Male)]
        [Sex(Sexes.Male)]
        [FavoriteNumber(24865)]
        [SecondFavoriteNumber(4)]
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
        }

        [LastName("Rowe")]
        public static class NuclearFamilyUnit
        {
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
                [Birthdate(1980, 12, 6)]
                public class Brother { }

                [Birthdate(1982, 12, 31)]
                public class Sister { }
            }
        }

        [Owners(2025, 3, 10, int.MaxValue, 0, 0, (int)FamilyMembers.MyselfChris)]
        public class MyMothersPetGraveyard { }
    }
}
