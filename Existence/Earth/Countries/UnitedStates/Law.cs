using System;
using Existence.Earth.Human.People;
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates
{
    public enum FederalGovernmentBranches
    {
        Executive,
        Judicial,
        Legislative
    }

    public enum StateLawSubjects
    {
        Abortion,
        PhotoVoterID,
    }

    public enum BallotInitiativeSubjects
    {
        Abortion,
        BallotInitiatives,
        PrimaryElections,
        RankedChoiceVoting,
        PhotoIDForVoting,
        NonCitizenVoting,
    }

    public class BallotInitiativeSubjectsAttribute : Attribute
    {
        public BallotInitiativeSubjects[] Subjects { get; set; }
        public BallotInitiativeSubjectsAttribute(params BallotInitiativeSubjects[] Subjects)
        {
            this.Subjects = Subjects;
        }
    }

    public class StateLawSubjectAttribute : Attribute
    {
        public StateLawSubjects Subject { get; set; }
        public StateLawSubjectAttribute(StateLawSubjects Subject)
        {
            this.Subject = Subject;
        }
    }

    public class CourtCaseDecidedAttribute : YearDateAttribute
    {
        public CourtCaseDecidedAttribute(int Year, int Month, int Day) : base(Year, Month, Day)
        {
        }
    }

    public class CourtCaseOralArgumentAttribute : YearDateAttribute
    {
        public CourtCaseOralArgumentAttribute(int Year, int Month, int Day) : base(Year, Month, Day)
        {
        }
    }

    public class LawEnactedAttribute : YearDateAttribute
    {
        public LawEnactedAttribute(int Year, int Month, int Day) : base(Year, Month, Day)
        {
        }
    }

    public enum UnitedStatesPoliticians
    {
        [Gender(Gender.Male)]
        AdamsJohn,

        [Gender(Gender.Male)]
        BidenJoe,

        [Gender(Gender.Male)]
        BrowneHarry,

        [Gender(Gender.Male)]
        BushGeorgeW,

        [Gender(Gender.Female)]
        ClintonHillary,

        [Gender(Gender.Male)]
        DoleBob,

        [Gender(Gender.Male)]
        GoreAl,

        [Gender(Gender.Female)]
        HarrisKamala,

        [Gender(Gender.Male)]
        JayJohn,

        [Gender(Gender.Male)]
        JohnsonGary,

        [Gender(Gender.Male)]
        PaulRon,

        [Gender(Gender.Male)]
        PowellColin,

        [Gender(Gender.Male)]
        TrumpDonald,

        [Gender(Gender.Male)]
        TsongasPaul,

        [Gender(Gender.Male)]
        WalkerScott,

        [Gender(Gender.Male)]
        WashingtonGeorge,
    }
}
