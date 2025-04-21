using Existence.Beyond.Infrastructure;
using Existence.Earth.Alphabet;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.Human.People;
using Existence.Earth;
using Existence.Logic;
using Existence.Personal;
using Existence.Time;
using System;
using System.Collections.Generic;

namespace Existence.Beyond.JudgmentDay
{
    internal class HumanZGrowingUp : JudgmentDayBase
    {
        private enum VersionHistory
        {
            /// <summary>
            /// initial release
            /// </summary>
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 3, 10)]
            Created,

            /// <summary>
            /// set contrafactumer of Stocco's Elegy
            /// </summary>
            [BeyondObjectVersion(1, 1, 0, 0)]
            [YearDate(2025, 3, 14)]
            AddDiscreteContrafactumerForStoccosElegy,

            /// <summary>
            /// remove father's origin story of the pets, not appropriate for this judgment day
            /// but could be useful in the future. also fix embarrassing beyond object version issue
            /// where v1 has the same version as v2.
            /// </summary>
            [BeyondObjectVersion(1, 2, 0, 0)]
            [YearDate(2025, 3, 22)]
            RemoveOriginStoryTODO,

            /// <summary>
            /// removes the family members enum, makes pet graveyard pets into objects
            /// </summary>
            [BeyondObjectVersion(1, 3, 0, 0)]
            [YearDate(2025, 3, 22)]
            RemoveFamilyMembersEnumAddPetObjectForPetGraveyard,

            [BeyondObjectVersion(1, 4, 0, 0)]
            [YearDate(2025, 3, 24)]
            MyMothersMotherAlsoOwnsTheFarmCatEyeColorsPetStructureUpdate,

            [BeyondObjectVersion(1, 5, 0, 0)]
            [YearDate(2025, 3, 24)]
            InternalizedAndRemovedTimelessVersion,

            [BeyondObjectVersion(1, 6, 0, 0)]
            [YearDate(2025, 3, 31)]
            AddPersonalHomesEnumeration,

            [BeyondObjectVersion(1, 7, 0, 0)]
            [YearDate(2025, 4, 21)]
            UpdateBasedOnMothersNotesAndViewOfPetGraveyard,
        }

        public TheseAreOurPets TheseAreOurPets;
        public StoccoElegy StoccoElegy;
        public PetGraveyard MyMothersPetGraveyard;

        public HumanZGrowingUp()
        {
            DefineLitters();

            List<string> nuclearFamilyPetList = new List<string>()
            {
                PetCats.April.ToString(),
                PetCats.Chaquita.ToString()
            };
            nuclearFamilyPetList.Add(PetCats.Spike.ToString()); //birth of Spike: 1978-05-24
            nuclearFamilyPetList.Add(PetDogs.Abe.ToString());

            new BaseEvent("Abe became an outside dog after he bit me (see previous Judgment Day)");

            //I think the family owned Morgan for a time but he went back to the farm (I remember a time when
            //the only two dogs were Abe and Morgan)
            nuclearFamilyPetList.Add(PetDogs.Morgan.ToString());
            nuclearFamilyPetList.Remove(PetDogs.Morgan.ToString());

            //got them very shortly after they were born on my mother's father's farm (1988-04-11)
            nuclearFamilyPetList.AddRange(PetDogs.Benji.ToString(), PetDogs.Teddy.ToString());

            nuclearFamilyPetList.Remove(PetDogs.Benji.ToString()); //1989-01-27
            nuclearFamilyPetList.Add(PetDogs.Prince.ToString()); //replacement for Benji

            nuclearFamilyPetList.Remove(PetCats.Chaquita.ToString()); //death of Chaquita: 1990-01-30
            nuclearFamilyPetList.Remove(PetCats.April.ToString()); //death of April: 1990-08-08

            nuclearFamilyPetList.Add(PetCats.Snowball.ToString()); //arrived pregnant, close to giving birth

            //The mother retreated to the old (non-addition) basement, gave birth alone (1990-04-10)
            nuclearFamilyPetList.AddRange(
                PetCats.Elsie.ToString(),
                PetCats.Snowflake.ToString(),
                PetCats.Tigger.ToString(),
                PetCats.Gretel.ToString());

            nuclearFamilyPetList.Remove(PetDogs.Abe.ToString()); //1992-06-17

            //I don't remember this but given Morgan ended up in the pet graveyard,
            //I think the family took him from the farm before he died (1993-06-04)
            nuclearFamilyPetList.Add(PetDogs.Morgan.ToString());
            nuclearFamilyPetList.Remove(PetDogs.Morgan.ToString());

            new BaseEvent("Parents separated");
            List<string> myMothersPets = nuclearFamilyPetList; //my mother assumed sole ownership of the pets

            myMothersPets.Remove(PetCats.Spike.ToString()); //1995-02-16

            //My mother had him euthanized, and I buried him while his body was still warm.
            myMothersPets.Remove(PetDogs.Prince.ToString()); //2002-09-28
            TheseAreOurPets = new TheseAreOurPetsSongComplete(); //both versions of the prince verse are usable so song is complete

            myMothersPets.Remove(PetDogs.Teddy.ToString()); //2003-08-19

            myMothersPets.Remove(PetCats.Tigger.ToString()); //2004-08-15
            myMothersPets.Remove(PetCats.Snowball.ToString()); //2005-01-12
            myMothersPets.Remove(PetCats.Gretel.ToString()); //2005-04-17

            //My sister knew these dogs would be euthanized, and got my mother to take them (a little after they were
            //born 2006-10-05). My sister may have regretted this later given it's difficult to take care of two big
            //dogs and have a long distance commuting job. My mother spent a significant amount of money ensuring the
            //dogs would be well cared for when she was gone.
            myMothersPets.AddRange(PetDogs.Riley.ToString(), PetDogs.Rewey.ToString());

            //I think my sister was unable to take care of Stocco and my mother took him from her.
            myMothersPets.Add(PetCats.Stocco.ToString());

            myMothersPets.Remove(PetCats.Elsie.ToString()); //2007-04-18
            myMothersPets.Remove(PetCats.Snowflake.ToString()); //2007-08-27

            myMothersPets.Add(PetCats.Toby.ToString());

            //The dogs were both in poor health, and once one of the was unable to walk, my mother had them both
            //euthanized, and I buried them in the pet graveyard (2021-06-19)
            myMothersPets.Remove(PetDogs.Riley.ToString());
            myMothersPets.Remove(PetDogs.Rewey.ToString());

            myMothersPets.Remove(PetCats.Toby.ToString());

            //It was winter so we were unable to bury him in the pet graveyard until sufficient thaw took place.
            //In the meantime his body resided stiff in the freezer, until burial the next year.
            myMothersPets.Remove(PetCats.Stocco.ToString()); //2023-12-24
            new ThisWasTheFirstTimeMyMotherDidntHaveAnyPetsSinceSheMarried();

            new StoccoElegyStarted();

            List<BaseEvent> personallyImportantEventsOfMothersHumanDeath = new List<BaseEvent>()
            {
                new MyMotherToldMySisterSheWasntGoingToDie(),
                new LastConversationWithMyMother(),
                new MyMotherMindDeath(),
                new MyMotherBodyDeath(),
                new ITookAPhotographOfMyDeadMotherWithMyFlipPhoneAndDeletedIt()
            };

            StoccoElegy = new StoccoElegyFinished();
            MyMothersPetGraveyard = new MyMothersPetGraveyard();

            new ITakeOwnershipOfMyMothersPetGraveyard();
        }

        private void DefineLitters()
        {
            List<int> litter;
            litter = new List<int>()
            {
                (int)PetDogs.Morgan,
                (int)PetDogs.Mickey
            };
            litter = new List<int>()
            {
                (int)PetDogs.Riley,
                (int)PetDogs.Rewey
            };
            litter = new List<int>()
            {
                (int)PetDogs.Benji,
                (int)PetDogs.Teddy
            };
            litter = new List<int>()
            {
                (int)PetCats.April,
                (int)PetCats.Chaquita
            };
            litter = new List<int>()
            {
                (int)PetCats.Elsie,
                (int)PetCats.Snowflake,
                (int)PetCats.Tigger,
                (int)PetCats.Gretel
            };
        }

        internal override List<LevelJustification> GetLevelJustifications()
        {
            return new List<LevelJustification>()
            {
                new ReleaseSongJustification(TheseAreOurPets, SongJustificationType.ReleaseSong),
                new ReleaseSongJustification(StoccoElegy, SongJustificationType.ReleaseSongMeaning)
            };
        }

        internal override List<TimelessChange>? GetTimelessChanges()
        {
            return new List<TimelessChange>()
            {
                new TimelessChange("Mother's Date of Mind+Body Death (2024-07-21)"),
                new TimelessChange("I take ownership of my mother's pet graveyard")
            };
        }
    }

    [Year(1994)]
    internal class ParentsSeparated : BaseEvent
    {
        public ParentsSeparated() : base("Parents Separated")
        {
        }
    }

    /// <summary>
    /// My mother never verbally acknowledged she was going to die (although through her actions she knew her situation was dire).
    /// This was the last piece of denial.
    /// </summary>
    [YearDate(2024, 7, 20)]
    internal class MyMotherToldMySisterSheWasntGoingToDie : BaseEvent
    {
        public SomeoneSaidSomethingAndIFoundOutViaHearsay Info { get; set; }
        public MyMotherToldMySisterSheWasntGoingToDie() : base("My Mother Claimed She Wasn't Going to Die")
        {
            this.Info = new SomeoneSaidSomethingAndIFoundOutViaHearsay("I'm not going to die.", (int)FamilyMembers.MyMotherSandy, (int)FamilyMembers.MySisterSonya, (int)PersonalHomes.EndeavorHome);
        }
    }

    /// <summary>
    /// My last conversation with my mother. It wasn't very productive (she told me not to use the clay on the piano for microphone purposes).
    /// I touched her and felt fear, not clear if it was my fear or her fear or both
    /// </summary>
    [YearDate(2024, 7, 20)]
    internal class LastConversationWithMyMother : BaseEvent
    {
        public SomeoneTouchedSomeoneElse TouchEvent { get; set; }
        public SomeoneFeltEmotion EmotionalInfo { get; set; }
        public LastConversationWithMyMother() : base("Last Conversation with My Mother")
        {
            EmotionalInfo = new SomeoneFeltEmotion("I felt fear.", (int)FamilyMembers.MyselfChris, Earth.FieldsOfStudy.Psychology.Emotions.Fear);
            TouchEvent = new SomeoneTouchedSomeoneElse("My mother touched my hand with her hand.", (int)FamilyMembers.MyMotherSandy, (int)FamilyMembers.MyselfChris);
        }
    }

    /// <summary>
    /// In the early morning, an anoxic event occurred and she lost agency and consciousness. I was not in the house,
    /// although my mother's older sister was.
    /// </summary>
    internal class MyMotherMindDeath : MindDeathEvent
    {
        public MyMotherMindDeath() : base("My Mother Mind Death", (int)FamilyMembers.MyMotherSandy, 2024, 7, 21, CausesOfDeath.AnoxicEvent)
        {
        }
    }

    /// <summary>
    /// I was sitting in the Endeavor house addition when she biologically died. She was sitting in her chair in the room.
    /// I didn't realize it immediately because there some involuntary head movements occured after this.
    /// It was realized once others entered the room.
    /// </summary>
    internal class MyMotherBodyDeath : BodyDeathEvent
    {
        public MyMotherBodyDeath() : base("My Mother Body Death in Front of Me", (int)FamilyMembers.MyMotherSandy, 2024, 7, 21, CausesOfDeath.NaturalCauses)
        {
        }
    }

    /// <summary>
    /// I took a photograph with my flip phone of my dead mother sitting in the room. There were others in the room at the 
    /// time but they didn't notice me take the picture. I deleted the picture shortly afterward because I thought it was inappropriate.
    /// </summary>
    [YearDate(2024, 7, 21)]
    internal class ITookAPhotographOfMyDeadMotherWithMyFlipPhoneAndDeletedIt : BaseEvent
    {
        public ITookAPhotographOfMyDeadMotherWithMyFlipPhoneAndDeletedIt() : base("Took+Deleted Photo of Dead Mother")
        {
        }
    }
    [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\008-StoccoElegy.txt", PeopleEnumerated.RoweChris)]
    internal class StoccoElegy : ContrafactumSongEvent
    {
        public StoccoElegy() : base(PeopleEnumerated.RoweChris, "Stocco Elegy", "Cats in the Cradle") { }
    }
    internal class StoccoElegyStarted : StoccoElegy {}
    internal class StoccoElegyFinished : StoccoElegy {}

    public class ThisWasTheFirstTimeMyMotherDidntHaveAnyPetsSinceSheMarried { }

    [MusicNotesRepositoryAudioFile(@"Released\Audio\003-TheseAreOurPets.wav", PeopleEnumerated.RoweChris)]
    [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\007-TheseAreOurPets.txt", PeopleEnumerated.RoweChris)]
    internal class TheseAreOurPets : SongEvent
    {
        public TheseAreOurPets() : base("These are our Pets")
        {
        }
    }

    /// <summary>
    /// song was logically complete once Prince died
    /// The personal/divine/cosmic flags are mentioned because this made them consistently GrowingUp
    /// </summary>
    [ZHumanLevel(HumanLevel.GrowingUp)] //This is the only flag that changed here
    [PersonalHumanLevel(HumanLevel.GrowingUp)]
    [DivineHumanLevel(HumanLevel.GrowingUp)]
    [CosmicHumanLevel(HumanLevel.GrowingUp)]
    internal class TheseAreOurPetsSongComplete : TheseAreOurPets {}

    public class PetMotherAttribute : Attribute
    {
        public int PetMother { get; set; }
        public PetMotherAttribute(int PetMother)
        {
            this.PetMother = PetMother;
        }
    }

    public class PetFatherAttribute : Attribute
    {
        public int PetFather { get; set; }
        public PetFatherAttribute(int PetFather)
        {
            this.PetFather = PetFather;
        }
    }

    public enum SpecificFarms
    {
        UnknownFarm,
        MyMothersParentsFarm,
        HilliardsFarm,
    }

    public enum NonFamilyMembers
    {
        Unknown,
        UnknownAnimalShelter,
    }

    /// <summary>
    /// initial date presumes Sammy was in the graveyard by the first day of autumn 1986. My mother's ownership ended on her human death.
    /// </summary>
    [Owners(1986, 9, 23, 2024, 7, 21, (int)FamilyMembers.MyMotherSandy)]
    internal class MyMothersPetGraveyard : PetGraveyard
    {
        public MyMothersPetGraveyard() : base(TruthClassification.Nonfictional)
        {
            TruthClassification real = TruthClassification.Nonfictional;
            AddPet(new Pet((int)AnimalsIDontKnow.Sammy, AnimalsIDontKnow.Sammy.ToString(), PetTypes.Cat, real)); //1986 (summer)
            AddPet(new Pet((int)PetDogs.Benji, PetDogs.Benji.ToString(), PetTypes.Dog, real)); //1989-01-27
            AddPet(new Pet((int)PetCats.Chaquita, PetCats.Chaquita.ToString(), PetTypes.Cat, real)); //1990-01-30
            AddPet(new Pet((int)PetCats.April, PetCats.April.ToString(), PetTypes.Cat, real)); //1990-08-08
            AddPet(new Pet((int)PetDogs.Abe, PetDogs.Abe.ToString(), PetTypes.Dog, real)); //1992-06-17
            AddPet(new Pet((int)PetDogs.Jenny, PetDogs.Jenny.ToString(), PetTypes.Dog, real)); //1993-04-23
            AddPet(new Pet((int)PetDogs.Morgan, PetDogs.Morgan.ToString(), PetTypes.Dog, real)); //1993-06-04
            AddPet(new Pet((int)PetCats.Spike, PetCats.Spike.ToString(), PetTypes.Cat, real)); //1995-02-16
            AddPet(new Pet((int)PetDogs.Prince, PetDogs.Prince.ToString(), PetTypes.Dog, real)); //2002-09-28
            AddPet(new Pet((int)AnimalsIDontKnow.Lance, AnimalsIDontKnow.Lance.ToString(), PetTypes.Cat, real)); //2003
            AddPet(new Pet((int)PetDogs.Teddy, PetDogs.Teddy.ToString(), PetTypes.Dog, real)); //2003-08-19
            AddPet(new Pet((int)PetCats.Tigger, PetCats.Tigger.ToString(), PetTypes.Cat, real)); //2004-08-15
            AddPet(new Pet((int)PetCats.Snowball, PetCats.Snowball.ToString(), PetTypes.Cat, real)); //2005-01-12
            AddPet(new Pet((int)FormerlyHadADifferentFamilyOwner.Chelsie, FormerlyHadADifferentFamilyOwner.Chelsie.ToString(), PetTypes.Dog, real)); //2005-04-10
            AddPet(new Pet((int)PetCats.Gretel, PetCats.Gretel.ToString(), PetTypes.Cat, real)); //2005-04-17
            AddPet(new Pet((int)FormerlyHadADifferentFamilyOwner.Kirby, FormerlyHadADifferentFamilyOwner.Kirby.ToString(), PetTypes.Dog, real)); //2006-11-21
            AddPet(new Pet((int)AnimalsIDontKnow.Hypie, AnimalsIDontKnow.Hypie.ToString(), PetTypes.Cat, real)); //2007-04-03
            AddPet(new Pet((int)PetCats.Elsie, PetCats.Elsie.ToString(), PetTypes.Cat, real)); //2007-04-18
            AddPet(new Pet((int)PetCats.Snowflake, PetCats.Snowflake.ToString(), PetTypes.Cat, real)); //2007-08-27
            AddPet(new Pet((int)FormerlyHadADifferentFamilyOwner.Scooter, FormerlyHadADifferentFamilyOwner.Scooter.ToString(), PetTypes.Cat, real)); //I think went before Tinker
            AddPet(new Pet((int)FormerlyHadADifferentFamilyOwner.Tinkerbell, FormerlyHadADifferentFamilyOwner.Tinkerbell.ToString(), PetTypes.Cat, real)); //2007-11-22
            AddPet(new Pet((int)PetDogs.Riley, PetDogs.Riley.ToString(), PetTypes.Dog, real)); //2021-06-19 (do not remember which of Riley/Rewey was first)
            AddPet(new Pet((int)PetDogs.Rewey, PetDogs.Rewey.ToString(), PetTypes.Dog, real)); //2021-06-19 (do not remember which of Riley/Rewey was first)
            AddPet(new Pet((int)PetCats.Toby, PetCats.Toby.ToString(), PetTypes.Cat, real)); //TODO: exact date uncertain
            AddPet(new Pet((int)PetCats.Stocco, PetCats.Stocco.ToString(), PetTypes.Cat, real)); //died 2023-12-24
        }
    }

    public class ITakeOwnershipOfMyMothersPetGraveyard() {}

    public class PetOwnersAttribute : Attribute
    {
        public int[] Owners { get; set; }
        public PetOwnersAttribute(params int[] Owners)
        {
            this.Owners = Owners;
        }
    }

    /// <summary>
    /// a pet can "belong" to a specific child even though the family unit has real ownership.
    /// </summary>
    public class ChildPetOwnerAttribute : Attribute
    {
        public int Owner { get; set; }
        public ChildPetOwnerAttribute(int Owner)
        {
            this.Owner = Owner;
        }
    }

    public class PreviousPetOwnerAttribute : Attribute
    {
        public int Owner { get; set; }
        public PreviousPetOwnerAttribute(int Owner)
        {
            this.Owner = Owner;
        }
    }

    public class PreviousPetOwnersAttribute : Attribute
    {
        public int[] Owners { get; set; }
        public PreviousPetOwnersAttribute(params int[] Owners)
        {
            this.Owners = Owners;
        }
    }

    public class FinalPetOwnerAttribute : Attribute
    {
        public int Owner { get; set; }
        public FinalPetOwnerAttribute(int Owner)
        {
            this.Owner = Owner;
        }
    }

    /// <summary>
    /// the precision for birth and death dates is due to my mother's recordkeeping, as well as photographs of the
    /// pet graveyard
    /// </summary>
    public enum PetDogs
    {
        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black, PetColors.White)]
        [DogBreed(DogBreeds.GermanShepherd)]
        [Birthdate(5, 19, 1979)]
        [Deathdate(6, 17, 1992)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Abe,
        /// <summary>
        /// My recollection is male (Benji is a boy's name), but female has preponderance of the evidence
        /// based on what I've heard from others.
        /// Death: Hearsay from my father is my mother drove to her mother's house with the dogs walking in
        /// front of them and a neighbor driving the other way hit the dog. My mother and sister were
        /// shaken up by the death (my mother had a lot of responsibility since her behavior was irresponsible).
        /// I felt nothing (not my dog).
        /// </summary>
        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black, PetColors.Brown)]
        [DogBreed(DogBreeds.Mutt)]
        [PetMother((int)PetDogs.Jenny)]
        [Birthdate(1988, 4, 11)]
        [Deathdate(1989, 1, 27)]
        [CauseOfDeath(CausesOfDeath.HitByACar)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [ChildPetOwner((int)FamilyMembers.MySisterSonya)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Benji,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black, PetColors.White)]
        [DogBreed(DogBreeds.Mutt)]
        [BirthdateUnknown]
        [Deathdate(1993, 4, 23)]
        [PetOwners((int)SpecificFarms.MyMothersParentsFarm)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Jenny,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Golden)]
        [DogBreed(DogBreeds.GoldenRetriever)]
        [Birthdate(1986, 5, 21)]
        [DeathdateUnknown]
        [PetOwners((int)SpecificFarms.MyMothersParentsFarm)]
        Mickey,

        /// <summary>
        /// I believe this dog split owner ship between the farm and my family over his lifetime
        /// </summary>
        [Sex(Sexes.Male)]
        [PetColors(PetColors.Golden)]
        [DogBreed(DogBreeds.GoldenRetriever)]
        [Birthdate(1986, 5, 21)]
        [Deathdate(1993, 6, 4)]
        [PetOwners((int)SpecificFarms.MyMothersParentsFarm, (int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Morgan,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black, PetColors.Brown)]
        [DogBreed(DogBreeds.Mutt)]
        [Birthdate(1988, 11, 11)]
        [Deathdate(2002, 9, 28)]
        [PreviousPetOwner((int)NonFamilyMembers.UnknownAnimalShelter)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [ChildPetOwner((int)FamilyMembers.MySisterSonya)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        [PersonallyKnowIBuriedInMothersPetGraveyard]
        Prince,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black)]
        [PetSecondaryColors(PetColors.White)]
        [Birthdate(2006, 10, 5)]
        [Deathdate(2021, 6, 19)]
        [PreviousPetOwner((int)SpecificFarms.UnknownFarm)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        [PersonallyKnowIBuriedInMothersPetGraveyard]
        Rewey,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black)]
        [PetSecondaryColors(PetColors.White)]
        [Birthdate(2006, 10, 5)]
        [Deathdate(2021, 6, 19)]
        [PreviousPetOwner((int)SpecificFarms.UnknownFarm)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        [PersonallyKnowIBuriedInMothersPetGraveyard]
        Riley,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Brown)]
        [DogBreed(DogBreeds.Mutt)]
        [PetMother((int)PetDogs.Jenny)]
        [Birthdate(1988, 4, 11)]
        [Deathdate(2003, 8, 19)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [ChildPetOwner((int)FamilyMembers.MyselfChris)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Teddy,

        /// <summary>
        /// placeholder for an unknown animal
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// the precision for birth and death dates is due to my mother's recordkeeping, as well as photographs of the
    /// pet graveyard
    /// </summary>
    public enum PetCats
    {
        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black)]
        [PetEyeColors(PetEyeColors.Green)]
        [Birthdate(1976, 4, 1)]
        [Deathdate(1990, 8, 8)]
        [CauseOfDeath(CausesOfDeath.Stroke)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        April,

        /// <summary>
        /// pronounciation of name is not what you'd expect: Chu-qua-tuh (Chu as in chuck, qua as in quack, tuh as in tug)
        /// </summary>
        [Sex(Sexes.Male)]
        [PetEyeColors(PetEyeColors.Green)]
        [PetColors(PetColors.Gray)]
        [Birthdate(1976, 4, 1)]
        [Deathdate(1990, 1, 30)]
        [CauseOfDeath(CausesOfDeath.HitByACar)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Chaquita,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black, PetColors.White)]
        [PetEyeColors(PetEyeColors.Green)]
        [PetMother((int)PetCats.Snowball)]
        [PetFather((int)PetCats.Ollie)]
        [Birthdate(1990, 4, 10)]
        [Deathdate(2007, 4, 18)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Elsie,

        /// <summary>
        /// The child pet owner information is a guess, my sister spelled her name differently for a time ("Gretal")
        /// </summary>
        [Sex(Sexes.Female)]
        [PetColors(PetColors.White)]
        [PetEyeColors(PetEyeColors.Green)]
        [PetMother((int)PetCats.Snowball)]
        [PetFather((int)PetCats.Ollie)]
        [Birthdate(1990, 4, 10)]
        [Deathdate(2005, 4, 17)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [ChildPetOwner((int)FamilyMembers.MySisterSonya)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Gretel,

        /// <summary>
        /// not in pet graveyard because he escaped the cat pen and was not seen again
        /// </summary>
        [Sex(Sexes.Male)]
        [BirthdateUnknown]
        [Missingdate(2004, 8, 26)]
        [PreviousPetOwners((int)FamilyMembers.MySisterSonya, (int)FamilyMembers.MyMotherSandy)]
        MrBean,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black, PetColors.Brown)]
        [PetOwners((int)SpecificFarms.MyMothersParentsFarm)]
        [BirthdateUnknown]
        [DeathdateUnknown]
        [FinalRestingPlaceUnknown]
        Ollie,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.White)]
        [PetEyeColors(PetEyeColors.Blue, PetEyeColors.Green)]
        [ApproximateBirthdate(1988)]
        [Deathdate(2005, 1, 12)]
        [PetOwners((int)SpecificFarms.MyMothersParentsFarm, (int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Snowball,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.White)]
        [PetEyeColors(PetEyeColors.Green)]
        [PetMother((int)PetCats.Snowball)]
        [PetFather((int)PetCats.Ollie)]
        [Birthdate(1990, 4, 10)]
        [Deathdate(2007, 8, 27)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Snowflake,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Gray)]
        [PetEyeColors(PetEyeColors.Green)]
        [PetMother((int)PetCats.April)]
        [PetFather((int)PetCats.Chaquita)]
        [Birthdate(1978, 5, 24)]
        [Deathdate(1995, 2, 16)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Spike,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Tabby)]
        [PetEyeColors(PetEyeColors.Green)]
        [Birthdate(2005, Seasons.Fall)]
        [DeathdateSignificantEvent((int)FixedDateHolidays.ChristmasEve)]
        [CauseOfDeath(CausesOfDeath.AnoxicEvent)] //I think this is correct, I'm not a veterinarian
        [PreviousPetOwner((int)FamilyMembers.MySisterSonya)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        [PersonallyKnowIBuriedInMothersPetGraveyard]
        Stocco,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Calico, PetColors.Black, PetColors.Orange, PetColors.White)]
        [PetEyeColors(PetEyeColors.Green)]
        [PetMother((int)PetCats.Snowball)]
        [PetFather((int)PetCats.Ollie)]
        [Birthdate(1990, 4, 10)]
        [Deathdate(2004, 8, 15)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [ChildPetOwner((int)FamilyMembers.MyselfChris)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Tigger,

        /// <summary>
        /// I don't remember specifically burying Toby, but given the size of the rock, I don't think my
        /// mother could have done it herself (I took the rocks from old farm field rocks, although the fields
        /// were no longer used for farming)
        /// </summary>
        [Sex(Sexes.Male)]
        [PetColors(PetColors.Orange, PetColors.White)]
        [PetEyeColors(PetEyeColors.Green)]
        [Birthdate(2005, Seasons.Spring)]
        [Deathdate(2018, 10, 24)]
        [PreviousPetOwner((int)SpecificFarms.HilliardsFarm)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        [PersonallyKnowIBuriedInMothersPetGraveyard]
        Toby,
    }

    /// <summary>
    /// My recollection is Scooter and Tinker were together
    /// </summary>
    
    public enum FormerlyHadADifferentFamilyOwner
    {
        [PetType(PetTypes.Dog)]
        [Sex(Sexes.Female)]
        [PetColors(PetColors.White, PetColors.Orange, PetColors.Black)]
        [BirthdateUnknown]
        [Deathdate(2005, 4, 10)]
        [DogBreed(DogBreeds.Beagle)]
        [PreviousPetOwner((int)FamilyMembers.MyMothersMothersMotherAda)]
        [PetOwners((int)FamilyMembers.MyMothersMotherDelores)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Chelsie,

        [PetType(PetTypes.Cat)]
        [Sex(Sexes.Male)]
        [Birthdate(1985)]
        [Deathdate(1995)]
        [PreviousPetOwner((int)FamilyMembers.MyMothersMothersMotherAda)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Scooter,

        /// <summary>
        /// the gravestone says born 1985, died 2007-11-22, does not seem plausible for a cat
        /// </summary>
        [PetType(PetTypes.Cat)]
        [Sex(Sexes.Female)]
        [Deathdate(2007, 11, 22)]
        [PreviousPetOwner((int)FamilyMembers.MyMothersMothersMotherAda)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Tinkerbell,

        [Sex(Sexes.Male)]
        [Deathdate(2006, 11, 12)]
        [PetType(PetTypes.Dog)]
        [PetOwners((int)FamilyMembers.MyMothersBrothersDaughterDenise)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Kirby,
    }

    /// <summary>
    /// these are animals my mother took care of for a time (sometimes taking in sick neighbor's cats),
    /// and ended up in my mother's pet graveyard
    /// </summary>
    [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
    public enum AnimalsIDontKnow
    {
        /// <summary>
        /// not 100% it was a cat or dog, I don't know if it was male or female
        /// </summary>
        [Deathdate(2007, 4, 3)]
        [PetType(PetTypes.Cat)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Hypie,

        /// <summary>
        /// not 100% sure it was a cat or dog. gravestone says "5 days" which means my mother took care of him for 5 days before he died
        /// </summary>
        [Sex(Sexes.Male)]
        [Deathdate(2003)]
        [PetType(PetTypes.Cat)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Lance,

        /// <summary>
        /// possibly a sick neighbor's animal my mother took care of during summer 1986
        /// </summary>
        [Sex(Sexes.Male)]
        [Deathdate(1986, Seasons.Summer)]
        [PetType(PetTypes.Cat)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Sammy,
    }

    /// <summary>
    /// I think there are others I buried (Snowflake/Elsie/Tigger are possibilities), 
    /// but only certain ones I specifically remember or know I did
    /// </summary>
    public class PersonallyKnowIBuriedInMothersPetGraveyardAttribute : Attribute
    {
        public PersonallyKnowIBuriedInMothersPetGraveyardAttribute() { }
    }
    
    public class FinalRestingPlaceInMyMothersPetGraveyardAttribute : Attribute { }
    public class FinalRestingPlaceUnknown : Attribute { }

    /// <summary>
    /// Morgan                         Jenny  Abe    April           Chaquita  Benji                 Sammy      Spike
    /// Riley+Rewey   Gretel  Snowball   Tigger  Teddy  Prince Lance Scooter   Chelsie   Kirby Hypie
    ///               Elsie   Snowflake    Tinkerbell   Toby   Stocco
    /// </summary>
    public class PetGraveyardRelativePositioning { }

    public enum PersonalHomes
    {
        HarmonyGroveHome,
        EndeavorHome,
    }
}
