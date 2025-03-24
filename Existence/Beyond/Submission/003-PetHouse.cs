using System.Collections.Generic;
using Existence.Beyond.Infrastructure;
using Existence.Beyond.JudgmentDay;
using Existence.Earth.Human.People;
using Existence.Earth;
using Existence.Logic;
using Existence.Personal;
using Existence.Personal.Infrastructure;
using Existence.Time;

namespace Existence.Beyond.Submission
{
    /// <summary>
    /// Pet House is a comic stric created and owned by my daughter with characters based on pets I
    /// had growing up.
    /// </summary>
    [Creators((int)FamilyMembers.MyDaughterBeverly)]
    [Owners((int)FamilyMembers.MyDaughterBeverly)]
    [FloatingTimeline(1990)]
    internal class PetHouse : SubmissionBase
    {
        public enum VersionHistory
        {
            /// <summary>
            /// created
            /// </summary>
            [PersonalFirst("Human Submission")]
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 3, 24)]
            Created,

            [BeyondObjectVersion(1, 1, 0, 0)]
            [YearDate(2025, 3, 24)]
            ClarifyTimelessChangesAndAddVersionHistory
        }

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
        /// secondary human characters
        /// </summary>
        public List<int> SecondaryHumanCharacters { get; set; }

        /// <summary>
        /// characters that are in the
        /// </summary>
        public List<int> TimeTravelPetCharacters { get; set; }

        /// <summary>
        /// secondary songs that are released
        /// </summary>
        public SongEvent[] ReleasedPetHouseSecondarySongs;

        /// <summary>
        /// constructor
        /// </summary>
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
                (int)PetHousePetCats.Phoebe,
                (int)PetHousePetDogs.Riley,
                (int)PetHousePetDogs.Rewey,
                (int)PetHousePetCats.Rosie,
                (int)PetHousePetCats.Scooter,
                (int)PetHousePetCats.Stocco,
                (int)PetHousePetCats.Tinkerbell,
                (int)PetHousePetCats.Toby,
            };
            OriginalPetCharacters = new List<int>()
            {
                (int)PetHouseCalicoKittiesOriginalCharacters.Misty,
                (int)PetHouseCalicoKittiesOriginalCharacters.Mittentoes,
                (int)PetHouseCalicoKittiesOriginalCharacters.Samantha,
            };
            SecondaryHumanCharacters = new List<int>()
            {
                (int)PetHouseHumans.HumanNumber4Grandma
            };
            ReleasedPetHouseSecondarySongs = [new IfYouAreFatThenYouAreNotElsie(), new HeIsTed()];
        }

        internal override List<LevelJustification> GetLevelJustifications()
        {
            List<LevelJustification> unused = new List<LevelJustification>()
            {
                new ReleaseSongJustification(ReleasedPetHouseSecondarySongs[0], SongJustificationType.ReleaseSong),
                new ReleaseSongJustification(ReleasedPetHouseSecondarySongs[1], SongJustificationType.ReleaseSong),
            };
            return new List<LevelJustification>()
            {
                new NumberJustification(8, "Pet House", "Origin Song has 7 characters, now has 8 characters")
            };
        }

        internal override List<TimelessChange>? GetTimelessChanges()
        {
            TimelessChange internalize = new TimelessChange("Internalize (this is a freebie)");
            return new List<TimelessChange>()
            {
                new TimelessChange("Add Self Year Z Deviation without explanation"),
                new TimelessChange("Separate My Mother's Pet Graveyard from Myself"),
                new TimelessChange("Timeless Version of Pet House"),
                new TimelessChange("Timeless Version of My Mother's Pet Graveyard with association to Pet House"),
                new TimelessChange("Generic Self has wider range of my mother's siblings (allow for 1 sister instead of the real 2)"),
                new TimelessChange("Generic Self increase range of where to put my sister (allow to be older than me)"),
                new TimelessChange("Generic Self: My first marriage wider date range (earth legal gay marriage to personal z boundary)"),
                new TimelessChange("Generic Self: I am younger than spouse"),
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
        [PetEyeColors(PetEyeColors.Blue, PetEyeColors.Green)]
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
        /// "Human Number 4" may not be correct here like it is for humans 1 through 3 since
        /// this is not as central a character.
        /// </summary>
        [CorrespondsTo((int)FamilyMembers.MyMothersMotherDelores)]
        HumanNumber4Grandma,
    }

    public enum PetHouseCalicoKittiesOriginalCharacters
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
    internal class IfYouAreFatThenYouAreNotElsie : SongEvent
    {
        public IfYouAreFatThenYouAreNotElsie() : base("If You are Fat then You are Not Elsie")
        {
        }
    }

    [MusicNotesRepositoryAudioFile(@"Released\Audio\006-HeIsTed.wav", PeopleEnumerated.RoweChris)]
    [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\011-HeIsTed.txt", PeopleEnumerated.RoweChris)]
    internal class HeIsTed : SongEvent
    {
        public HeIsTed() : base("He is Ted")
        {
        }
    }
}
