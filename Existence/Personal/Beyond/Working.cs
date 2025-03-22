using System.Collections.Generic;
using Existence.Beyond.Infrastructure;
using Existence.Beyond.JudgmentDay;
using Existence.Earth;
using Existence.Earth.Human.People;
using Existence.Logic;
using Existence.Time;

namespace Existence.Personal.Beyond
{
    [Creators((int)FamilyMembers.MyDaughterBeverly)]
    [Owners((int)FamilyMembers.MyDaughterBeverly)]
    internal class PetHouse : SubmissionBase
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
                (int)PetHousePetCats.April,
                (int)PetHousePetCats.Chaquita,
                (int)PetHousePetCats.Ollie,
                (int)PetHousePetDogs.Abe,
                (int)PetHousePetDogs.Morgan,
                (int)PetHousePetDogs.Benji,
            };
        }
    }

    //questions: is pet owners after parents' separation correct? Stocco? Toby? Riley? Rewey?
    //Teddy vs Ted
    //Calico Kitties
    public enum PetHousePetCats
    {
        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black)]
        [Birthdate(1976, 4, 1)]
        April,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Gray)]
        [Birthdate(1976, 4, 1)]
        Chaquita,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black, PetColors.White)]
        [PetMother((int)PetHousePetCats.Snowball)]
        [PetFather((int)PetHousePetCats.Ollie)]
        [Birthdate(1990, 4, 10)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Fatness", "Eats refrigerators and restaurants")]
        Elsie,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.White)]
        [PetMother((int)PetHousePetCats.Snowball)]
        [PetFather((int)PetHousePetCats.Ollie)]
        [Birthdate(1990, 4, 10)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Mathematical Talent", "Red Spot")]
        Gretel,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black, PetColors.Brown)]
        [PetOwners((int)SpecificFarms.MyMothersFatherSkipsFarm)]
        Ollie,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.White)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Cooks Healthy")]
        Snowball,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.White)]
        [PetMother((int)PetHousePetCats.Snowball)]
        [PetFather((int)PetHousePetCats.Ollie)]
        [Birthdate(1990, 4, 10)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Makes Potions", "Time Travel", "Steals Ted's Food")]
        Snowflake,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Gray)]
        [PetMother((int)PetHousePetCats.April)]
        [PetFather((int)PetHousePetCats.Chaquita)]
        [Birthdate(1978, 5, 24)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Curmudgeonly")]
        Spike,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Calico, PetColors.Black, PetColors.Orange, PetColors.White)]
        [PetMother((int)PetCats.Snowball)]
        [PetFather((int)PetCats.Ollie)]
        [Birthdate(1990, 4, 10)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Drives Impossibly Fast", "Friendly")]
        Tigger,
    }

    public enum PetHousePetDogs
    {
        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black, PetColors.White)]
        [Birthdate(5, 19, 1979)]
        Abe,

        /// <summary>
        /// pet house color is grey, real world is brown
        /// </summary>
        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black, PetColors.Gray)]
        [Birthdate(1988, 4, 11)]
        Benji,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Golden)]
        [DogBreed(DogBreeds.GoldenRetriever)]
        [Birthdate(1986, 5, 21)]
        Morgan,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black, PetColors.Brown)]
        [Birthdate(1988, 11, 11)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Painfully Colorful Wardrobe")]
        Prince,

        /// <summary>
        /// real world name is Teddy, fictional version is Ted
        /// </summary>
        [Sex(Sexes.Male)]
        [PetColors(PetColors.Brown)]
        [Birthdate(1988, 4, 11)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhoodAfterParentsSeparation)]
        [DefiningCharacteristics("Stupid", "Becomes Smart when Defending Food from Snowflake")]
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
    }

    [MusicNotesRepositoryAudioFile(@"Released\Audio\XXX-IfYouAreFatThenYouAreNotElsie.wav", PeopleEnumerated.RoweChris)]
    [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\XXX-IfYouAreFatThenYouAreNotElsie.txt", PeopleEnumerated.RoweChris)]
    public class IfYouAreFatThenYouAreNotElsie : SongEvent
    {
        public IfYouAreFatThenYouAreNotElsie() : base("If You are Fat then You are Not Elsie")
        {
        }
    }

    [MusicNotesRepositoryAudioFile(@"Released\Audio\XXX-HeIsTed.wav", PeopleEnumerated.RoweChris)]
    [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\XXX-HeIsTed.txt", PeopleEnumerated.RoweChris)]
    public class HeIsTed : SongEvent
    {
        public HeIsTed() : base("He is Ted")
        {
        }
    }


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
}

