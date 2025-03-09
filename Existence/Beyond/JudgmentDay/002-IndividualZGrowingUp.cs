using Existence.Beyond.Infrastructure;
using Existence.Earth.Human.People;
using Existence.Earth;
using Existence.Time;
using System;
using Existence.Earth.Alphabet;
using Existence.Earth.Countries.UnitedStates;
using System.Collections.Generic;

namespace Existence.Beyond.JudgmentDay
{
    [IsReleased(false)]
    public class IndividualZGrowingUp
    {
        public IndividualZGrowingUp()
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

            new TODOAttribute("There's a story here about how my father didn't want any pets but April and Chaquita jumped in the car");
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

            nuclearFamilyPetList.Remove(PetCats.Chaquita.ToString()); //death of Chaquita: 1990-01-30
            nuclearFamilyPetList.Remove(PetCats.April.ToString()); //death of April: 1990-08-08
            nuclearFamilyPetList.Add(PetCats.Snowball.ToString()); //pregnant, close to giving birth

            //The mother retreated to the old (non-addition) basement, gave birth alone (1990-04-10)
            nuclearFamilyPetList.AddRange(
                PetCats.Elsie.ToString(),
                PetCats.Snowflake.ToString(),
                PetCats.Tigger.ToString(),
                PetCats.Gretel.ToString());

            nuclearFamilyPetList.Remove(PetDogs.Benji.ToString()); //1989-01-27
            nuclearFamilyPetList.Add(PetDogs.Prince.ToString()); //replacement for Benji

            nuclearFamilyPetList.Remove(PetDogs.Abe.ToString()); //1992-06-17

            //I don't remember this but given he ended up in the pet graveyard,
            //I think the family took him from the farm before he died (1993-06-04)
            nuclearFamilyPetList.Add(PetDogs.Morgan.ToString());
            nuclearFamilyPetList.Remove(PetDogs.Morgan.ToString());

            //when my parents separated, my mother assumed sole ownership of the pets
            List<string> myMothersPets = nuclearFamilyPetList;

            myMothersPets.Remove(PetCats.Spike.ToString()); //1995-02-16

            //My mother had him euthanized, and I buried him while his body was still warm.
            myMothersPets.Remove(PetDogs.Prince.ToString()); //2002-09-28
            
            myMothersPets.Remove(PetDogs.Teddy.ToString()); //2003-08-19
            myMothersPets.Remove(PetCats.Tigger.ToString()); //2004-08-15
            myMothersPets.Remove(PetCats.Snowball.ToString()); //2005-01-12
            myMothersPets.Remove(PetCats.Gretel.ToString()); //2005-04-17

            //My sister knew these dogs would be euthanized, and got my mother to take them (a little after they were
            //born 2006-10-05). My sister may have regretted this later given it's difficult to take care of two big
            //dogs and have a long distance commuting job. My mother spent a significant amount of money ensuring the
            //dogs would be well cared for when she was gone.
            myMothersPets.AddRange(PetDogs.Rewey.ToString(), PetDogs.Riley.ToString());

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
            //In the meantime his body resided stiff in the freezer.
            myMothersPets.Remove(PetCats.Stocco.ToString()); //2023-12-24
        }
    }

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
        MyMothersFatherSkipsFarm,
        HilliardsFarm,
    }

    public enum NonFamilyMembers
    {
        Unknown,
        UnknownAnimalShelter,
    }

    public enum FamilyMembers
    {
        MyMothersBrotherGerald,
        MyMothersBrothersDaughterDenise,
        MyMothersBrothersSonDennis,
        MyMotherSandy,
        MyMothersFatherSkip,
        MyMothersMotherDelores,
        MyMothersMothersMotherAda,
        MyFatherJerry,
        MyselfChris,
        MySisterSonya,
        MyNuclearFamilyChildhood,
    }

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
        /// shaken up by the death. I felt nothing (not my dog).
        /// </summary>
        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black, PetColors.Brown)]
        [DogBreed(DogBreeds.Mutt)]
        [PetMother((int)PetDogs.Jenny)]
        [Birthdate(1988, 4, 11)]
        [Deathdate(1989, 1, 27)]
        [CauseOfDeath("Hit by a car, my mother bears a lot of responsibility per her irresponsible behavior")]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [ChildPetOwner((int)FamilyMembers.MySisterSonya)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Benji,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black, PetColors.White)]
        [DogBreed(DogBreeds.Mutt)]
        [BirthdateUnknown]
        [Deathdate(1993, 4, 23)]
        [PetOwners((int)SpecificFarms.MyMothersFatherSkipsFarm)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Jenny,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Golden)]
        [DogBreed(DogBreeds.GoldenRetriever)]
        [Birthdate(1986, 5, 21)]
        [DeathdateUnknown]
        [PetOwners((int)SpecificFarms.MyMothersFatherSkipsFarm)]
        Mickey,

        /// <summary>
        /// I believe this dog split owner ship between the farm and my family over his lifetime
        /// </summary>
        [Sex(Sexes.Male)]
        [PetColors(PetColors.Golden)]
        [DogBreed(DogBreeds.GoldenRetriever)]
        [Birthdate(1986, 5, 21)]
        [Deathdate(1993, 6, 4)]
        [PetOwners((int)SpecificFarms.MyMothersFatherSkipsFarm, (int)FamilyMembers.MyNuclearFamilyChildhood)]
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
        [PersonallyRememberBuriedInMothersPetGraveyard]
        Prince,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black)]
        [PetSecondaryColors(PetColors.White)]
        [Birthdate(2006, 10, 5)]
        [Deathdate(2021, 6, 19)]
        [PreviousPetOwner((int)SpecificFarms.UnknownFarm)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        [PersonallyRememberBuriedInMothersPetGraveyard]
        Rewey,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black)]
        [PetSecondaryColors(PetColors.White)]
        [Birthdate(2006, 10, 5)]
        [Deathdate(2021, 6, 19)]
        [PreviousPetOwner((int)SpecificFarms.UnknownFarm)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        [PersonallyRememberBuriedInMothersPetGraveyard]
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
        [Birthdate(1976, 4, 1)]
        [Deathdate(1990, 8, 8)]
        [CauseOfDeath("Stroke")]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        April,

        /// <summary>
        /// pronounciation of name is not what you'd expect: Chu-qua-tuh (Chu as in chuck, qua as in quack, tuh as in tug)
        /// </summary>
        [Sex(Sexes.Male)]
        [PetColors(PetColors.Gray)]
        [Birthdate(1976, 4, 1)]
        [Deathdate(1990, 1, 30)]
        [CauseOfDeath("Run over by a car")]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Chaquita,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Black, PetColors.White)]
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
        [PetMother((int)PetCats.Snowball)]
        [PetFather((int)PetCats.Ollie)]
        [Birthdate(1990, 4, 10)]
        [Deathdate(2005, 4, 17)]
        [PetOwners((int)FamilyMembers.MyNuclearFamilyChildhood)]
        [ChildPetOwner((int)FamilyMembers.MySisterSonya)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Gretel,

        [Sex(Sexes.Male)]
        [PetColors(PetColors.Black, PetColors.Brown)]
        [PetOwners((int)SpecificFarms.MyMothersFatherSkipsFarm)]
        [BirthdateUnknown]
        [DeathdateUnknown]
        [FinalRestingPlaceUnknown]
        Ollie,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.White)]
        [ApproximateBirthdate(1988)]
        [Deathdate(2005, 1, 12)]
        [PetOwners((int)SpecificFarms.MyMothersFatherSkipsFarm, (int)FamilyMembers.MyNuclearFamilyChildhood)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Snowball,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.White)]
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
        [BirthdateUnknown]
        [DeathdateSignificantEvent((int)FixedDateHolidays.ChristmasEve)]
        [CauseOfDeath("Stroke")] //I think this is correct, I'm not a veterinarian
        [PreviousPetOwner((int)FamilyMembers.MySisterSonya)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        [PersonallyRememberBuriedInMothersPetGraveyard]
        Stocco,

        [Sex(Sexes.Female)]
        [PetColors(PetColors.Calico, PetColors.Black, PetColors.Orange, PetColors.White)]
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
        [PetColors(PetColors.Orange, PetColors.Red)]
        [TODO("birth/death date - picture looks like Spring 2006 - Oct ?")]
        [PreviousPetOwner((int)SpecificFarms.HilliardsFarm)]
        [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        [PersonallyRememberBuriedInMothersPetGraveyard]
        Toby,
    }

    /// <summary>
    /// My recollection is Scooter and Tinker were together
    /// </summary>
    [PreviousPetOwner((int)FamilyMembers.MyMothersMothersMotherAda)]
    public enum FormerlyHadADifferentFamilyOwner
    {
        [PetType(PetTypes.Dog)]
        [Sex(Sexes.Female)]
        [PetColors(PetColors.White, PetColors.Orange, PetColors.Black)]
        [BirthdateUnknown]
        [Deathdate(2005, 4, 10)]
        [DogBreed(DogBreeds.Beagle)]
        [PetOwners((int)FamilyMembers.MyMothersMotherDelores)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Chelsie,

        [PetType(PetTypes.Cat)]
        [Sex(Sexes.Male)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Scooter,

        /// <summary>
        /// the gravestone says born 1985, died 2007-11-22, does not seem plausible for a cat
        /// </summary>
        [PetType(PetTypes.Cat)]
        [Sex(Sexes.Female)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Tinkerbell,
    }

    /// <summary>
    /// these are animals my mother took care of for a time (sometimes taking in sick neighbor's cats),
    /// and ended up in my mother's pet graveyard
    /// </summary>
    [FinalPetOwner((int)FamilyMembers.MyMotherSandy)]
    public enum AnimalsIDontKnow
    {
        /// <summary>
        /// not 100% it was a cat, I don't know if it was male or female
        /// </summary>
        [Deathdate(2007, 4, 3)]
        [PetType(PetTypes.Cat)]
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Hypie,

        [Sex(Sexes.Male)]
        [Deathdate(2006, 11, 21)]
        [PetType(PetTypes.Dog)]
        [PetOwners((int)FamilyMembers.MyMothersBrothersDaughterDenise)] //I think this is the correct owner
        [FinalRestingPlaceInMyMothersPetGraveyard]
        Kirby,

        /// <summary>
        /// gravestone says "5 days" which means my mother took care of him for 5 days before he died
        /// </summary>
        [Sex(Sexes.Male)]
        [Deathdate(2003)]
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
    /// but only certain ones I specifically remember
    /// </summary>
    public class PersonallyRememberBuriedInMothersPetGraveyardAttribute : Attribute
    {
        public PersonallyRememberBuriedInMothersPetGraveyardAttribute() { }
    }
    
    public class FinalRestingPlaceInMyMothersPetGraveyardAttribute : Attribute { }
    public class FinalRestingPlaceUnknown : Attribute { }

    /// <summary>
    /// Morgan                         Jenny  Abe    April           Chaquita  Benji                 Sammy      Spike
    /// Riley+Rewey   Gretel  Snowball   Tigger  Teddy  Prince Lance Scooter   Chelsie   Kirby Hypie
    ///               Elsie   Snowflake    Tinkerbell   Toby
    /// </summary>
    public class PetGraveyardRelativePositioning { }
}
