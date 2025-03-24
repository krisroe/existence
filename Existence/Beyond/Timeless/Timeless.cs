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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Existence.Beyond.Timeless
{
    internal class Timeless
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

            /// <summary>
            /// add generic self, change interesting humans to relevant humans
            /// </summary>
            [BeyondObjectVersion(3, 0, 0, 0)]
            [YearDate(2025, 3, 22)]
            AddGenericSelf,

            /// <summary>
            /// internalize, add timeless pet graveyard and pet house
            /// </summary>
            [BeyondObjectVersion(4, 0, 0, 0)]
            [YearDate(2025, 3, 24)]
            AddPetHouse,
        }

        /// <summary>
        /// mapping from pet name to fictional pet version
        /// </summary>
        internal static readonly Dictionary<string, Pet> PetHouseFictionalPetMapping;

        /// <summary>
        /// mapping from pet name to nonfictional pet version
        /// </summary>
        internal static readonly Dictionary<string, Pet> PetHouseNonFictionalPetMapping;

        /// <summary>
        /// pet house litters (mother and litter members)
        /// </summary>
        internal static readonly List<Tuple<Pet, List<Pet>>> PetHouseLittersMotherAndKittens;

        /// <summary>
        /// static constructor
        /// </summary>
        static Timeless()
        {
            PetHouseFictionalPetMapping = new Dictionary<string, Pet>(8);
            PetHouseNonFictionalPetMapping = new Dictionary<string, Pet>(8);
            PetHouseLittersMotherAndKittens = new List<Tuple<Pet, List<Pet>>>(2);

            List<Tuple<string, string, string, Sexes, int?, PetTypes>> petInfo = new List<Tuple<string, string, string, Sexes, int?, PetTypes>>()
            {
                new Tuple<string, string, string, Sexes, int?, PetTypes>(PetHouse.ELSIE_NAME, "Fatness", "Fatness, eats refrigerators and restaurants", Sexes.Female, 1990, PetTypes.Cat),
                new Tuple<string, string, string, Sexes, int?, PetTypes>(PetHouse.SNOWFLAKE_NAME, "Chased human hands causing falls off table", "Makes Potions, time travel, steals Ted's food", Sexes.Female, 1990, PetTypes.Cat),
                new Tuple<string, string, string, Sexes, int?, PetTypes>(PetHouse.TIGGER_NAME, "Temporarily escaped the house", "Drives impossibly fast, friendly", Sexes.Female, 1990, PetTypes.Cat),
                new Tuple<string, string, string, Sexes, int?, PetTypes>(PetHouse.GRETEL_NAME, "Red spot", "Smart, mathematical talent, red spot", Sexes.Female, 1990, PetTypes.Cat),
                new Tuple<string, string, string, Sexes, int?, PetTypes>(PetHouse.SNOWBALL_NAME, "Odd-eyed", "Cooks healthy", Sexes.Female, null, PetTypes.Cat),
                new Tuple<string, string, string, Sexes, int?, PetTypes>(PetHouse.TED_NAME, "Confused", "Confused, stupid, becomes smart when defending food from Snowflake", Sexes.Male, null, PetTypes.Dog),
                new Tuple<string, string, string, Sexes, int?, PetTypes>(PetHouse.PRINCE_NAME, "Looked like a prince with blanket around neck", "Painfully colorful wardrobe", Sexes.Male, null, PetTypes.Dog),
                new Tuple<string, string, string, Sexes, int?, PetTypes>(PetHouse.SPIKE_NAME, string.Empty, "Curmudgeonly", Sexes.Male, null, PetTypes.Cat)
            };

            List<Pet> fictionalLitter = new List<Pet>();
            List<Pet> nonFictionalLitter = new List<Pet>();
            foreach (var nextPet in petInfo)
            {
                HandlePetHousePet(TruthClassification.Fictional, nextPet, fictionalLitter, nonFictionalLitter);
                HandlePetHousePet(TruthClassification.Nonfictional, nextPet, fictionalLitter, nonFictionalLitter);
            }
            PetHouseLittersMotherAndKittens[0] = new Tuple<Pet, List<Pet>>(PetHouseFictionalPetMapping[PetHouse.SNOWBALL_NAME], fictionalLitter);
            PetHouseLittersMotherAndKittens[1] = new Tuple<Pet, List<Pet>>(PetHouseNonFictionalPetMapping[PetHouse.SNOWBALL_NAME], nonFictionalLitter);
        }

        private static void HandlePetHousePet(TruthClassification truthClass, Tuple<string, string, string, Sexes, int?, PetTypes> petInfo, List<Pet> fictionalLitter, List<Pet> nonfictionalLitter)
        {
            string n = petInfo.Item1;
            Pet p = new Pet(petInfo.Item1, petInfo.Item6, truthClass);
            if (n == PetHouse.TED_NAME) p.Names.Add(PetHouse.TEDDY_NAME);
            Dictionary<string, Pet> mapping;
            List<Pet> litter;
            if (truthClass == TruthClassification.Fictional)
            {
                mapping = PetHouseFictionalPetMapping;
                litter = fictionalLitter;
            }
            else
            {
                mapping = PetHouseNonFictionalPetMapping;
                litter = nonfictionalLitter;
            }
            foreach (string nextName in p.Names)
            {
                mapping[n] = p;
            }
            if (petInfo.Item5.HasValue) //only the child kittens have birth year specified
            {
                p.BirthYear = 1990;
                litter.Add(p);
            }
            if (n == PetHouse.SNOWBALL_NAME)
            {
                p.EyeColors = [PetEyeColors.Blue, PetEyeColors.Green];
            }
            else if (n == PetHouse.TED_NAME)
            {
                p.CatchPhrase = "What was that noise?";
            }
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
        public class HumanSelf
        {
            public const int YEAR_Z_DEVIATION = 2024;

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
        }

        [TruthClassification(TruthClassification.Nonfictional)]
        [Description("Pet Graveyard for Pets My Mother Took Care of")]
        [Owners(2025, 3, 10, int.MaxValue, 0, 0, (int)FamilyMembersGeneric.Myself)]
        [GoalOwner((int)FamilyMembersGeneric.MyMother)]
        public class MyMothersPetGraveyard
        {
            public List<Pet> FinalRestingPlacePets;
            public MyMothersPetGraveyard()
            {
                FinalRestingPlacePets = new List<Pet>() //death order
                {
                    PetHouseNonFictionalPetMapping[PetHouse.SPIKE_NAME],
                    PetHouseNonFictionalPetMapping[PetHouse.PRINCE_NAME],
                    PetHouseNonFictionalPetMapping[PetHouse.TEDDY_NAME],
                    PetHouseNonFictionalPetMapping[PetHouse.TIGGER_NAME],
                    PetHouseNonFictionalPetMapping[PetHouse.SNOWBALL_NAME],
                    PetHouseNonFictionalPetMapping[PetHouse.GRETEL_NAME],
                    PetHouseNonFictionalPetMapping[PetHouse.ELSIE_NAME],
                    PetHouseNonFictionalPetMapping[PetHouse.SNOWFLAKE_NAME]
                };
            }
        }

        [BeyondOwner((int)FamilyMembersGeneric.Myself)]
        [TruthClassification(TruthClassification.Fictional)]
        [Description("Comic Strip with Former Family Pets as Characters")]
        [FloatingTimeline(1990)]
        [HumanOwner((int)FamilyMembersGeneric.MyFirstbornChild)]
        public class PetHouse
        {
            //pet house order
            public const string ELSIE_NAME = "Elsie";
            public const string SNOWFLAKE_NAME = "Snowflake";
            public const string TIGGER_NAME = "Tigger";
            public const string GRETEL_NAME = "Gretel";
            public const string SNOWBALL_NAME = "Snowball";
            public const string TED_NAME = "Ted";
            public const string TEDDY_NAME = "Teddy";
            public const string PRINCE_NAME = "Prince";
            public const string SPIKE_NAME = "Spike";

            public static string[] PETHOUSE_MAIN_CHARACTER_ORDER = new string[]
            {
                ELSIE_NAME,
                SNOWFLAKE_NAME,
                TIGGER_NAME,
                GRETEL_NAME,
                SNOWBALL_NAME,
                TED_NAME,
                PRINCE_NAME,
                SPIKE_NAME
            };
            public static string[] PETHOUSE_ORIGIN_SONG_PET_ORDER = new string[]
            {
                ELSIE_NAME,
                TED_NAME,
                SNOWFLAKE_NAME,
                SNOWBALL_NAME,
                TIGGER_NAME,
                GRETEL_NAME,
                PRINCE_NAME
            };

            public TimelessSongEvent InspirationalOriginSongPrimary;
            public List<TimelessSongEvent> InspirationalSongSecondary;
            public Dictionary<TimelessSongEvent, List<Pet>> SongsToPets;
            public List<Pet> MainCharacterPets { get; set; }
            public PetHouse()
            {
                SongsToPets = new Dictionary<TimelessSongEvent, List<Pet>>();
                InspirationalOriginSongPrimary = new TimelessSongEvent(TimelessStatic.TO_BE_DETERMINED, (int)FamilyMembersGeneric.Myself);
                List<Pet> pets = SongsToPets[InspirationalOriginSongPrimary] = new List<Pet>();
                foreach (string n in PETHOUSE_ORIGIN_SONG_PET_ORDER)
                {
                    pets.Add(PetHouseNonFictionalPetMapping[n]);
                }
                InspirationalSongSecondary = new List<TimelessSongEvent>()
                {
                    new TimelessSongEvent(TimelessStatic.TO_BE_DETERMINED, (int)FamilyMembersGeneric.Myself),
                    new TimelessSongEvent(TimelessStatic.TO_BE_DETERMINED, (int)FamilyMembersGeneric.Myself),
                };
                SongsToPets[InspirationalSongSecondary[0]] = new List<Pet>()
                {
                    PetHouseNonFictionalPetMapping[ELSIE_NAME],
                };
                SongsToPets[InspirationalSongSecondary[1]] = new List<Pet>()
                {
                    PetHouseNonFictionalPetMapping[TED_NAME],
                };
                MainCharacterPets = new List<Pet>();
                foreach (string n in PETHOUSE_MAIN_CHARACTER_ORDER)
                {
                    MainCharacterPets.Add(PetHouseFictionalPetMapping[n]);
                }
            }
        }

        [HumanSpeciesType(HomoSpecies.HomoSapiens)]
        [Archetypes(Archetypes.Programmer)]
        [FavoriteColor(KnownColor.Transparent)]
        [FavoriteNumber(24865)]
        [SecondFavoriteNumber(4)]
        [Sex(Sexes.Male)]
        [HumanGender(HumanGender.Male)]
        public class GenericHumanSelf
        {
            public static class NuclearFamilyUnit
            {
                [Marriage]
                public class v1
                {
                    [FemaleSiblingCount(1, 2)]
                    [MaleSiblingCount(1, 1)]
                    [Sex(Sexes.Female)]
                    public class Parent1 { }

                    [Sex(Sexes.Male)]
                    public class Parent2 { }

                    [FavoriteColor(KnownColor.Red)]
                    [FemaleSiblingCount(1, 1)]
                    [MaleSiblingCount(0, 0)]
                    [Me]
                    public class Brother { }
                }
                [MarriageDateRange(Humanity.YEAR_OF_FIRST_NATION_DE_JURE_LEGAL_HOMOSEXUAL_MARRIAGE,
                                   HumanSelf.YEAR_Z_DEVIATION)]
                public static class v2
                {
                    public class SpouseOlder { }

                    [Me]
                    public class SpouseYounger { }

                    [Sex(Sexes.Female)]
                    public class SiblingOlder { }

                    [Sex(Sexes.Male)]
                    public class SiblingYounger { }
                }
            }
        }

        [DistinctHumans(RelevantHumans.Self, RelevantHumans.ThePope)]
        public class Humanity
        {
            public const int YEAR_OF_FIRST_NATION_DE_JURE_LEGAL_HOMOSEXUAL_MARRIAGE = 2001;
        }
    }

    /// <summary>
    /// indicates two humans are distinct
    /// </summary>
    public class DistinctHumansAttribute : Attribute
    {
        /// <summary>
        /// first interesting human
        /// </summary>
        public RelevantHumans A { get; set; }
        /// <summary>
        /// second interesting human
        /// </summary>
        public RelevantHumans B { get; set; }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="A">first interesting human</param>
        /// <param name="B">second interesting human</param>
        public DistinctHumansAttribute(RelevantHumans A, RelevantHumans B)
        {
            this.A = A;
            this.B = B;
        }
    }

    /// <summary>
    /// interesting humans
    /// </summary>
    public enum RelevantHumans
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