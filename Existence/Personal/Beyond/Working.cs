using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Existence.Beyond.Infrastructure;
using Existence.Beyond.JudgmentDay;
using Existence.Beyond.Timeless;
using Existence.Earth;
using Existence.Earth.Alphabet;
using Existence.Earth.Code;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.Countries;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human;
using Existence.Earth.Human.People;
using Existence.Logic;
using Existence.Personal;
using Existence.Personal.Infrastructure;
using Existence.Time;

namespace Existence.Personal.Beyond
{


    /// <summary>
    /// I created Pet House at personal cosmic Level probably 7, human-scale nonfiction
    /// I handed off Pet House to my daughter, she probably got it to cosmic level 8, human-scale fiction
    /// alternate titles: Creating a level 8 thing and handing it off responsibly?
    /// 
    /// </summary>
    internal class IndividualZGrowingUp
    {
        public IndividualZGrowingUp()
        {
        }

    }
}


internal class WorkingIdeas
{

    /// <summary>
    /// This refers to an incident (addition of endeavor house) with sticking my finger in exposed light outlets.
    /// There were no discernable consequences, but the lesson was learned nonetheless.
    /// 
    /// We also have the flashcards domination incident, which had the cosmic consequences of the T.G. loss
    /// also the 2nd grade teacher with "She's dead" and "It might be true" situation.
    /// 
    /// People are inherently Stupid
    /// Psychology is BS
    /// Become atheist (Antichrist)
    /// 
    /// Blanket (sonya and I) incident
    /// HAlloween getting out of
    /// HAlloween as ghost and myself
    /// 
    /// WEt the bed as a child, got over it with assistance from calendar sticker incentives
    /// last wet the bed incident was at Pine Lake camp (camp counselor washed the sleeping bag)
    /// 
    /// son took forever to get over wetting the bed (wore pullup like forever, his mother really didn't
    /// want to clean it up and appeared to have no idea what would be helpful and never asked me about it). He Didn't seem to
    /// consider it important when asked. Eventually he just stopped wearing the pullup and it was fine.
    /// 
    /// Guarantee incident: Once when mother told us to put on our seat belts for a trip to grandma's house
    /// I refused, saying I guaranteed we would make it to grandma's house without an accident (it was only
    /// a couple of miles). I put on my seat belt, and we made it to grandma's house without incident, and
    /// when we were done I said something to the effect of "see, I was right" (not exact words).
    /// 
    /// childhood nativity play - went from respectful to disrespectful of Christianity over time
    /// 
    /// Sang "Silent Night" in real church nativity play (respectful, but what was my religion at the time?)
    /// 
    /// I do not remember ever believing in Santa Claus.
    /// 
    /// March 16, 1998: worst day of my life. Car wouldn't start and walked 13.5 miles home from school.
    /// (March 15 is called the ides of march, which comports with the roman calendar). The modern day
    /// Ides of March fall on March 16.
    /// 
    /// Moved to Endeavor home: 1985-08-17
    /// 
    /// When my parents moved to Oshkosh there's a story about how my Mother brought April in the car,
    /// and got Chaquita also, although my father didn't want them.
    /// </summary>
    private class ActionsHaveConsequences : BaseEvent
    {
        public ActionsHaveConsequences() : base("Actions Have Consequences")
        {
        }
    }

    private static class Reference
    {
        [TODO("This needs to be in I am the Pope thing")]
        public static class PromisedChatGPTAJudgmentDayReferenceForAssistanceWithIAmNotThePopeDeclaration
        {

        }
    }

    /// <summary>
    /// Pet House is a comic stric created and owned by my daughter with characters based on pets I
    /// had growing up.
    /// </summary>
    [Creators((int)FamilyMembers.MyDaughterBeverly)]
    [Owners((int)FamilyMembers.MyDaughterBeverly)]
    [FloatingTimeline(1990)]
    public class PetHouse : SubmissionBase
    {
        [Creators((int)FamilyMembers.MyselfChris)]
        [Owners((int)FamilyMembers.MyselfChris)]
        public TheseAreOurPets InspirationalSongPrimary { get; set; }

        [Creators((int)FamilyMembers.MyselfChris)]
        [Owners((int)FamilyMembers.MyselfChris)]
        public SongEvent[] InspirationalSongsSecondary { get; set; }

        /// <summary>
        /// main pet characters
        /// </summary>
        public int[] MainPetCharacters { get; set; }

        /// <summary>
        /// main human characters
        /// </summary>
        public int[] MainHumanCharacters { get; set; }

        /// <summary>
        /// secondary pet characters
        /// </summary>
        public List<int> SecondaryPetCharacters { get; set; }

        /// <summary>
        /// original pet characters
        /// </summary>
        public List<int> OriginalPetCharacters { get; set; }

        /// <summary>
        /// characters that are in the
        /// </summary>
        public List<int> TimeTravelPetCharacters { get; set; }

        PetHouse()
        {
            InspirationalSongPrimary = new TheseAreOurPets();
            InspirationalSongsSecondary = [new IfYouAreFatThenYouAreNotElsie(), new HeIsTed()];
            MainPetCharacters = new int[8];
            MainPetCharacters[0] = (int)PetHousePetCats.Elsie;
            MainPetCharacters[1] = (int)PetHousePetCats.Snowflake;
            MainPetCharacters[2] = (int)PetHousePetCats.Tigger;
            MainPetCharacters[3] = (int)PetHousePetCats.Gretel;
            MainPetCharacters[4] = (int)PetHousePetCats.Snowball;
            MainPetCharacters[5] = (int)PetHousePetDogs.Ted;
            MainPetCharacters[6] = (int)PetHousePetDogs.Prince;
            MainPetCharacters[7] = (int)PetHousePetCats.Spike;
            MainHumanCharacters = new int[3];
            MainHumanCharacters[0] = (int)PetHouseHumans.HumanNumber1Mother;
            MainHumanCharacters[1] = (int)PetHouseHumans.HumanNumber2Brother;
            MainHumanCharacters[2] = (int)PetHouseHumans.HumanNumber3Sister;
            SecondaryPetCharacters = new List<int>()
            {
                (int)PetHousePetCats.Ollie,
                (int)PetHousePetDogs.Morgan,
                (int)PetHousePetCats.Sarah,
            };
            TimeTravelPetCharacters = new List<int>()
            {
                (int)PetHousePetDogs.Abe,
                (int)PetHousePetCats.April,
                (int)PetHousePetDogs.Benji,
                (int)PetHousePetCats.Chaquita,
                (int)PetHousePetDogs.Indie,
                (int)PetHousePetDogs.Riley,
                (int)PetHousePetDogs.Rewey,
                (int)PetHousePetCats.Scooter,
                (int)PetHousePetCats.Stocco,
                (int)PetHousePetCats.Tinkerbell,
                (int)PetHousePetCats.Toby,
            };
            OriginalPetCharacters = new List<int>()
            {
                (int)PetHouseOriginalCharacters.Misty,
                (int)PetHouseOriginalCharacters.Mittentoes,
                (int)PetHouseOriginalCharacters.Samantha,
            };
        }
    }

    public enum PetHousePetCats
    {
        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black)]
        April,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Gray)]
        Chaquita,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black, PetColors.White)]
        [PetMother((int)PetHousePetCats.Snowball)]
        [PetFather((int)PetHousePetCats.Ollie)]
        [Birthdate(1990)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Fatness", "Eats refrigerators and restaurants")]
        Elsie,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.White)]
        [PetMother((int)PetHousePetCats.Snowball)]
        [PetFather((int)PetHousePetCats.Ollie)]
        [Birthdate(1990)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Mathematical Talent", "Red Spot")]
        Gretel,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black, PetColors.Brown)]
        [PetOwners((int)SpecificFarms.MyMothersParentsFarm)]
        Ollie,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Tabby)]
        Phoebe,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Tabby)]
        Rosie,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Gray)]
        [PetOwners((int)SpecificFarms.MyMothersParentsFarm)]
        Sarah,

        [PetType(PetTypes.Cat)]
        [Sex(Sexes.Male)]
        [PetOwners((int)SpecificFarms.MyMothersParentsFarm)]
        Scooter,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.White)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Cooks Healthy")]
        Snowball,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.White)]
        [PetMother((int)PetHousePetCats.Snowball)]
        [PetFather((int)PetHousePetCats.Ollie)]
        [Birthdate(1990)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Makes Potions", "Time Travel", "Steals Ted's Food")]
        Snowflake,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Gray)]
        [PetMother((int)PetHousePetCats.April)]
        [PetFather((int)PetHousePetCats.Chaquita)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Curmudgeonly")]
        Spike,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Tabby)]
        [DefiningCharacteristics("King of Cats")]
        Stocco,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Calico, PetColors.Black, PetColors.Orange, PetColors.White)]
        [PetMother((int)PetHousePetCats.Snowball)]
        [PetFather((int)PetHousePetCats.Ollie)]
        [Birthdate(1990)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Drives Impossibly Fast", "Friendly")]
        Tigger,

        [PetType(PetTypes.Cat)]
        [Sex(Sexes.Female)]
        [PetOwners((int)SpecificFarms.MyMothersParentsFarm)]
        Tinkerbell,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Orange, PetColors.White)]
        Toby,
    }

    public enum PetHousePetDogs
    {
        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black, PetColors.White)]
        Abe,

        /// <summary>
        /// pet house color is grey, real world is brown
        /// </summary>
        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black, PetColors.Gray)]
        Benji,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Brown, PetColors.White)]
        Indie,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Golden)]
        [DogBreed(DogBreeds.GoldenRetriever)]
        Morgan,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black, PetColors.Brown)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Painfully Colorful Wardrobe")]
        Prince,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black)]
        [PetSecondaryColors(PetColors.White)]
        Rewey,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black)]
        [PetSecondaryColors(PetColors.White)]
        Riley,

        /// <summary>
        /// real world name is Teddy, fictional version is Ted
        /// </summary>
        [Sex(Sexes.Male)]
        [PetColors(PetColors.Brown)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Confused", "Stupid", "Becomes Smart when Defending Food from Snowflake")]
        [CatchPhrase("What was that noise?")]
        Ted,
    }

    public enum PetHouseHumans
    {
        [CorrespondsTo((int)FamilyMembers.MyMotherSandy)]
        HumanNumber1Mother,

        [CorrespondsTo((int)FamilyMembers.MyselfChris)]
        HumanNumber2Brother,

        [CorrespondsTo((int)FamilyMembers.MySisterSonya)]
        HumanNumber3Sister,

        /// <summary>
        /// "Human Number 4" may not be correct here like it is for humans 1 through 3
        /// </summary>
        [CorrespondsTo((int)FamilyMembers.MyMothersMotherDelores)]
        HumanNumber4Grandma,
    }

    public enum PetHouseOriginalCharacters
    {
        /// <summary>
        /// One of the three Calico Kitties
        /// </summary>
        [Sex(Sexes.Female)]
        [PetColors(PetColors.Calico, PetColors.Black, PetColors.Orange, PetColors.White)]
        [DefiningCharacteristics("Spotted")]
        Misty,

        /// <summary>
        /// One of the three Calico Kitties
        /// </summary>
        [Sex(Sexes.Female)]
        [PetColors(PetColors.Calico, PetColors.Black, PetColors.Orange, PetColors.White)]
        [DefiningCharacteristics("Cynical")]
        Mittentoes,

        /// <summary>
        /// One of the three Calico Kitties
        /// </summary>
        [Sex(Sexes.Female)]
        [PetColors(PetColors.Calico, PetColors.Black, PetColors.Orange, PetColors.White)]
        [DefiningCharacteristics("Striped")]
        Samantha,
    }

    [MusicNotesRepositoryAudioFile(@"Released\Audio\005-IfYouAreFatThenYouAreNotElsie.wav", PeopleEnumerated.RoweChris)]
    [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\010-IfYouAreFatThenYouAreNotElsie.txt", PeopleEnumerated.RoweChris)]
    public class IfYouAreFatThenYouAreNotElsie : SongEvent
    {
        public IfYouAreFatThenYouAreNotElsie() : base("If You are Fat then You are Not Elsie")
        {
        }
    }

    [MusicNotesRepositoryAudioFile(@"Released\Audio\006-HeIsTed.wav", PeopleEnumerated.RoweChris)]
    [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\011-HeIsTed.txt", PeopleEnumerated.RoweChris)]
    public class HeIsTed : SongEvent
    {
        public HeIsTed() : base("He is Ted")
        {
        }
    }

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

            /// <summary>
            /// add generic self, change interesting humans to relevant humans
            /// </summary>
            [BeyondObjectVersion(3, 0, 0, 0)]
            [YearDate(2025, 3, 22)]
            AddGenericSelf,
        }

        /// <summary>
        /// mapping from pet name to fictional pet version
        /// </summary>
        private static Dictionary<string, Pet> PetHouseFictionalPetMapping;

        /// <summary>
        /// mapping from pet name to nonfictional pet version
        /// </summary>
        private static Dictionary<string, Pet> PetHouseNonFictionalPetMapping;

        /// <summary>
        /// pet house litters - establish they are the same for real and fictional
        /// </summary>
        private static List<List<Pet>> PetHouseLitters;

        static Timeless()
        {
            PetHouseFictionalPetMapping = new Dictionary<string, Pet>(8);
            PetHouseNonFictionalPetMapping = new Dictionary<string, Pet>(8);
            PetHouseLitters = new List<List<Pet>>(2) { new List<Pet>(4), new List<Pet>(4) };
            foreach (string n in new string[] {
                PetHouse.ELSIE_NAME,
                PetHouse.SNOWFLAKE_NAME,
                PetHouse.TIGGER_NAME,
                PetHouse.GRETEL_NAME,
                PetHouse.SNOWBALL_NAME,
                PetHouse.TED_NAME,
                PetHouse.PRINCE_NAME,
                PetHouse.SPIKE_NAME})
            {
                PetTypes pt = n == PetHouse.TED_NAME || n == PetHouse.PRINCE_NAME ? PetTypes.Dog : PetTypes.Cat;
                bool isMainKitten = n == PetHouse.ELSIE_NAME || n == PetHouse.SNOWFLAKE_NAME || n == PetHouse.TIGGER_NAME || n == PetHouse.GRETEL_NAME;
                HandleFictionalPetHousePet(n, isMainKitten, pt);
                HandleNonFictionalPetHousePet(n, isMainKitten, pt);
            }
        }

        private static void HandleNonFictionalPetHousePet(string n, bool isMainKitten, PetTypes pt)
        {
            Pet p = new Pet(n, pt, TruthClassification.Nonfictional);
            if (n == PetHouse.TEDDY_NAME) p.Names.Add(PetHouse.TED_NAME);
            foreach (string nextName in p.Names)
            {
                PetHouseNonFictionalPetMapping[n] = p;
            }
            if (isMainKitten)
            {
                p.BirthYear = 1990;
                PetHouseLitters[1].Add(p);
            }
            if (n == PetHouse.ELSIE_NAME)
            {
                p.DefiningCharacteristics = "Fatness";
            }
            else if (n == PetHouse.TED_NAME)
            {
                p.DefiningCharacteristics = "Confused";
            }
            else if (n == PetHouse.SNOWFLAKE_NAME)
            {
                p.DefiningCharacteristics = "Chases human hands, falls off table";
            }
            else if (n == PetHouse.SNOWBALL_NAME)
            {
                p.DefiningCharacteristics = "Odd-eyed";
                p.EyeColors = [PetEyeColors.Blue, PetEyeColors.Green];
            }
            else if (n == PetHouse.TIGGER_NAME)
            {
                p.DefiningCharacteristics = "Temporarily escaped the house";
            }
            else if (n == PetHouse.GRETEL_NAME)
            {
                p.DefiningCharacteristics = "Red spot";
            }
            else if (n == PetHouse.PRINCE_NAME)
            {
                p.DefiningCharacteristics = "Looked like a prince with blanket around neck";
            }
        }

        private static void HandleFictionalPetHousePet(string n, bool isMainKitten, PetTypes pt)
        {
            Pet p = new Pet(n, pt, TruthClassification.Fictional);
            if (isMainKitten)
            {
                p.BirthYear = 1990;
                PetHouseLitters[0].Add(p);
            }
            if (n == PetHouse.TED_NAME) p.Names.Add(PetHouse.TEDDY_NAME);
            foreach (string nextName in p.Names)
            {
                PetHouseFictionalPetMapping[n] = p;
            }
            string definingCharacteristics = string.Empty;
            switch (n)
            {
                case PetHouse.ELSIE_NAME:
                    definingCharacteristics = "Fatness,eats refrigerators and restaurants";
                    break;
                case PetHouse.SNOWFLAKE_NAME:
                    definingCharacteristics = "Makes Potions, time travel, steals Ted's food";
                    break;
                case PetHouse.TIGGER_NAME:
                    definingCharacteristics = "Drives impossibly fast, friendly";
                    break;
                case PetHouse.GRETEL_NAME:
                    definingCharacteristics = "Smart, mathematical talent, red spot";
                    break;
                case PetHouse.SNOWBALL_NAME:
                    definingCharacteristics = "Odd-eyed, cooks healthy";
                    p.EyeColors = [PetEyeColors.Blue, PetEyeColors.Green];
                    break;
                case PetHouse.TED_NAME:
                    definingCharacteristics = "Confused, stupid, becomes smart when defending food from Snowflake";
                    p.CatchPhrase = "What was that noise?";
                    break;
                case PetHouse.PRINCE_NAME:
                    definingCharacteristics = "Painfully colorful wardrobe";
                    break;
                case PetHouse.SPIKE_NAME:
                    definingCharacteristics = "Curmudgeonly";
                    break;
            }
            p.DefiningCharacteristics = definingCharacteristics;
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
        [Description("Pet Graveyard for Pets My Mother Owned")]
        [Owners(2025, 3, 10, int.MaxValue, 0, 0, (int)FamilyMembers.MyselfChris)]
        public class MyMothersPetGraveyard
        {
            public List<Pet> FinalRestingPlacePets;
            public MyMothersPetGraveyard()
            {
                FinalRestingPlacePets = new List<Pet>()
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

        [TruthClassification(TruthClassification.Fictional)]
        [Description("Comic Strip with Former Family Pets as Characters")]
        [FloatingTimeline(1990)]
        public class PetHouse
        {
            public const string ELSIE_NAME = "Elsie";
            public const string SNOWFLAKE_NAME = "Snowflake";
            public const string TIGGER_NAME = "Tigger";
            public const string GRETEL_NAME = "Gretel";
            public const string SNOWBALL_NAME = "Snowball";
            public const string TED_NAME = "Ted";
            public const string TEDDY_NAME = "Teddy";
            public const string PRINCE_NAME = "Prince";
            public const string SPIKE_NAME = "Spike";

            public SongEvent InspirationalSongPrimary;
            public List<SongEvent> InspirationalSongSecondary;
            public Dictionary<SongEvent, List<Pet>> SongsToPets;
            public List<Pet> MainCharacterPets { get; set; }
            public PetHouse()
            {
                SongsToPets = new Dictionary<SongEvent, List<Pet>>();
                InspirationalSongPrimary = new SongEvent(TimelessStatic.TO_BE_DETERMINED);
                SongsToPets[InspirationalSongPrimary] = new List<Pet>()
                {
                    PetHouseNonFictionalPetMapping[ELSIE_NAME],
                    PetHouseNonFictionalPetMapping[TED_NAME],
                    PetHouseNonFictionalPetMapping[SNOWFLAKE_NAME],
                    PetHouseNonFictionalPetMapping[SNOWBALL_NAME],
                    PetHouseNonFictionalPetMapping[TIGGER_NAME],
                    PetHouseNonFictionalPetMapping[GRETEL_NAME],
                    PetHouseNonFictionalPetMapping[PRINCE_NAME],
                };
                InspirationalSongSecondary = new List<SongEvent>()
                {
                    new SongEvent(TimelessStatic.TO_BE_DETERMINED),
                    new SongEvent(TimelessStatic.TO_BE_DETERMINED),
                };
                SongsToPets[InspirationalSongSecondary[0]] = new List<Pet>()
                {
                    PetHouseNonFictionalPetMapping[ELSIE_NAME],
                };
                SongsToPets[InspirationalSongSecondary[1]] = new List<Pet>()
                {
                    PetHouseNonFictionalPetMapping[TED_NAME],
                };
                MainCharacterPets = new List<Pet>()
                {
                    PetHouseFictionalPetMapping[ELSIE_NAME],
                    PetHouseFictionalPetMapping[SNOWFLAKE_NAME],
                    PetHouseFictionalPetMapping[TIGGER_NAME],
                    PetHouseFictionalPetMapping[GRETEL_NAME],
                    PetHouseFictionalPetMapping[SNOWBALL_NAME],
                    PetHouseFictionalPetMapping[TED_NAME],
                    PetHouseFictionalPetMapping[PRINCE_NAME],
                    PetHouseFictionalPetMapping[SPIKE_NAME]
                };
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

