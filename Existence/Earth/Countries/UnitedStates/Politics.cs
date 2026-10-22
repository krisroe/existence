using Existence.Earth.Human.Politics;
using System;

namespace Existence.Earth.Countries.UnitedStates.Politics
{
    public enum BallotMeasureTypes
    {
        /// <summary>
        /// advisory question
        /// </summary>
        AQ,

        /// <summary>
        /// citizen initiated constitutional amendment
        /// </summary>
        CICA,

        /// <summary>
        /// citizen initiated state statute
        /// </summary>
        CISS,

        /// <summary>
        /// indirect initiated state statute
        /// </summary>
        IndISS,

        /// <summary>
        /// initiative
        /// </summary>
        Initiative,

        /// <summary>
        /// initiative to the legislature
        /// </summary>
        ITL,

        /// <summary>
        /// initiative to the people
        /// </summary>
        ITP,

        /// <summary>
        /// Legislatively Referred Constitutional Amendment
        /// </summary>
        LRCA,

        /// <summary>
        /// Legislatively Referred State Statute
        /// </summary>
        LRSS,

        /// <summary>
        /// veto referendum
        /// </summary>
        VR,
    }

    public class BallotMeasureTypeAttribute : Attribute
    {
        public BallotMeasureTypes Type { get; set; }
        public BallotMeasureTypeAttribute(BallotMeasureTypes Type)
        {
            this.Type = Type;
        }
    }

    public class BallotMeasurePassFailAttribute : Attribute
    {
        public bool Passed { get; set; }
        public BallotMeasurePassFailAttribute(bool Passed)
        {
            this.Passed = Passed;
        }
    }

    public class RequiresAnotherSuccessfulVoteAttribute : Attribute
    {
        public bool RequiresAnotherSuccessfulVote { get; set; }
        public RequiresAnotherSuccessfulVoteAttribute(bool RequiresAnotherSuccessfulVote)
        {
            this.RequiresAnotherSuccessfulVote = RequiresAnotherSuccessfulVote;
        }
    }

    /// <summary>
    /// mandatory retirement age, in years
    /// </summary>
    public enum StateSupremeCourtJusticeMandatoryRetirementAge
    {
        [Province((int)StateSubsidiariesUnitedStates.Alaska)]
        [Province((int)StateSubsidiariesUnitedStates.Arizona)]
        [Province((int)StateSubsidiariesUnitedStates.Connecticut)]
        [Province((int)StateSubsidiariesUnitedStates.Delaware)]
        [Province((int)StateSubsidiariesUnitedStates.Hawaii)]
        [Province((int)StateSubsidiariesUnitedStates.Kansas)]
        [Province((int)StateSubsidiariesUnitedStates.Maine)]
        [Province((int)StateSubsidiariesUnitedStates.Maryland)]
        [Province((int)StateSubsidiariesUnitedStates.Massachusetts)]
        [Province((int)StateSubsidiariesUnitedStates.Missouri)]
        [Province((int)StateSubsidiariesUnitedStates.NewHampshire)]
        [Province((int)StateSubsidiariesUnitedStates.NewJersey)]
        [Province((int)StateSubsidiariesUnitedStates.NewMexico)]
        [Province((int)StateSubsidiariesUnitedStates.SouthDakota)]
        [Province((int)StateSubsidiariesUnitedStates.Utah)]
        [Province((int)StateSubsidiariesUnitedStates.Vermont)]
        [Province((int)StateSubsidiariesUnitedStates.Virginia)]
        [Province((int)StateSubsidiariesUnitedStates.Wyoming)]
        [Province((int)StateSubsidiariesUnitedStates.PuertoRico)]
        [Province((int)StateSubsidiariesUnitedStates.Guam)]
        [Province((int)StateSubsidiariesUnitedStates.NorthernMarianaIslands)]
        Seventy,

        [Province((int)StateSubsidiariesUnitedStates.Colorado)]
        SeventyTwo,

        [Province((int)StateSubsidiariesUnitedStates.Florida)]
        [Province((int)StateSubsidiariesUnitedStates.Oregon)]
        [Province((int)StateSubsidiariesUnitedStates.Pennsylvania)]
        [Province((int)StateSubsidiariesUnitedStates.Washington)]
        [Province((int)StateSubsidiariesUnitedStates.Wisconsin)]
        SeventyFive,

        /// <summary>
        /// election (retention or otherwise) or legislative confirmation required to serve additional terms
        /// New York note: New York Supreme Court uses partisan elections, while the New York Court of Appeals uses gubernatorial/legislative process.
        /// </summary>
        [Province((int)StateSubsidiariesUnitedStates.Alabama)]
        [Province((int)StateSubsidiariesUnitedStates.Arkansas)]
        [Province((int)StateSubsidiariesUnitedStates.California)]
        [Province((int)StateSubsidiariesUnitedStates.Georgia)]
        [Province((int)StateSubsidiariesUnitedStates.Idaho)]
        [Province((int)StateSubsidiariesUnitedStates.Illinois)]
        [Province((int)StateSubsidiariesUnitedStates.Indiana)]
        [Province((int)StateSubsidiariesUnitedStates.Iowa)]
        [Province((int)StateSubsidiariesUnitedStates.Kentucky)]
        [Province((int)StateSubsidiariesUnitedStates.Louisiana)]
        [Province((int)StateSubsidiariesUnitedStates.Michigan)]
        [Province((int)StateSubsidiariesUnitedStates.Minnesota)]
        [Province((int)StateSubsidiariesUnitedStates.Mississippi)]
        [Province((int)StateSubsidiariesUnitedStates.Montana)]
        [Province((int)StateSubsidiariesUnitedStates.Nebraska)]
        [Province((int)StateSubsidiariesUnitedStates.Nevada)]
        [Province((int)StateSubsidiariesUnitedStates.NewYork)]
        [Province((int)StateSubsidiariesUnitedStates.NorthCarolina)]
        [Province((int)StateSubsidiariesUnitedStates.NorthDakota)]
        [Province((int)StateSubsidiariesUnitedStates.Ohio)]
        [Province((int)StateSubsidiariesUnitedStates.Oklahoma)]
        [Province((int)StateSubsidiariesUnitedStates.SouthCarolina)]
        [Province((int)StateSubsidiariesUnitedStates.Tennessee)]
        [Province((int)StateSubsidiariesUnitedStates.Texas)]
        [Province((int)StateSubsidiariesUnitedStates.WestVirginia)]
        [Province((int)StateSubsidiariesUnitedStates.WashingtonDC)]
        [Province((int)StateSubsidiariesUnitedStates.UnitedStatesVirginIslands)]
        NoneButHaveProcessToServeMoreTerms,

        /// <summary>
        /// life term and can only be removed by impeachment
        /// </summary>
        [Province((int)StateSubsidiariesUnitedStates.RhodeIsland)]

        NoneImpeachmentOnly,
    }

    public enum StateSupremeCourtJusticeTermLength
    {
        [Province((int)StateSubsidiariesUnitedStates.Alabama)]
        [Province((int)StateSubsidiariesUnitedStates.Kentucky)]
        [Province((int)StateSubsidiariesUnitedStates.Louisiana)]
        [Province((int)StateSubsidiariesUnitedStates.Michigan)]
        [Province((int)StateSubsidiariesUnitedStates.Minnesota)]
        [Province((int)StateSubsidiariesUnitedStates.Mississippi)]
        [Province((int)StateSubsidiariesUnitedStates.Nebraska)]
        [Province((int)StateSubsidiariesUnitedStates.Nevada)]
        [Province((int)StateSubsidiariesUnitedStates.NorthCarolina)]
        [Province((int)StateSubsidiariesUnitedStates.Ohio)]
        [Province((int)StateSubsidiariesUnitedStates.Oregon)]
        [Province((int)StateSubsidiariesUnitedStates.Texas)]
        [Province((int)StateSubsidiariesUnitedStates.Vermont)]
        [Province((int)StateSubsidiariesUnitedStates.Washington)]
        [Province((int)StateSubsidiariesUnitedStates.Wisconsin)]
        SixYear,

        [Province((int)StateSubsidiariesUnitedStates.Arkansas)]
        [Province((int)StateSubsidiariesUnitedStates.Idaho)]
        [Province((int)StateSubsidiariesUnitedStates.Indiana)]
        [Province((int)StateSubsidiariesUnitedStates.Maryland)]
        [Province((int)StateSubsidiariesUnitedStates.Missouri)]
        [Province((int)StateSubsidiariesUnitedStates.Montana)]
        [Province((int)StateSubsidiariesUnitedStates.NewMexico)]
        [Province((int)StateSubsidiariesUnitedStates.Oklahoma)]
        [Province((int)StateSubsidiariesUnitedStates.SouthCarolina)]
        [Province((int)StateSubsidiariesUnitedStates.SouthDakota)]
        [Province((int)StateSubsidiariesUnitedStates.Tennessee)]
        [Province((int)StateSubsidiariesUnitedStates.Wyoming)]
        EightYear,

        [Province((int)StateSubsidiariesUnitedStates.Alaska)]
        [Province((int)StateSubsidiariesUnitedStates.Colorado)]
        [Province((int)StateSubsidiariesUnitedStates.Hawaii)]
        [Province((int)StateSubsidiariesUnitedStates.Iowa)]
        [Province((int)StateSubsidiariesUnitedStates.NorthDakota)]
        [Province((int)StateSubsidiariesUnitedStates.Pennsylvania)]
        [Province((int)StateSubsidiariesUnitedStates.WestVirginia)]
        [Province((int)StateSubsidiariesUnitedStates.UnitedStatesVirginIslands)]
        TenYear,

        [Province((int)StateSubsidiariesUnitedStates.Arizona)]
        [Province((int)StateSubsidiariesUnitedStates.California)]
        [Province((int)StateSubsidiariesUnitedStates.Connecticut)]
        [Province((int)StateSubsidiariesUnitedStates.Delaware)]
        [Province((int)StateSubsidiariesUnitedStates.Florida)]
        [Province((int)StateSubsidiariesUnitedStates.Illinois)]
        [Province((int)StateSubsidiariesUnitedStates.Kansas)]
        [Province((int)StateSubsidiariesUnitedStates.Maine)]
        [Province((int)StateSubsidiariesUnitedStates.NewJersey)]
        [Province((int)StateSubsidiariesUnitedStates.Utah)]
        [Province((int)StateSubsidiariesUnitedStates.Virginia)]
        TwelveYear,

        /// <summary>
        /// 14 year terms for both the New York Supreme Court and New York Court of Appeals
        /// </summary>
        [Province((int)StateSubsidiariesUnitedStates.NewYork)]
        FourteenYear,

        [Province((int)StateSubsidiariesUnitedStates.WashingtonDC)]
        FifteenYear,

        [Province((int)StateSubsidiariesUnitedStates.Georgia)]
        SixteenYear,

        [Province((int)StateSubsidiariesUnitedStates.Massachusetts)]
        [Province((int)StateSubsidiariesUnitedStates.NewHampshire)]
        [Province((int)StateSubsidiariesUnitedStates.PuertoRico)]
        [Province((int)StateSubsidiariesUnitedStates.Guam)]
        [Province((int)StateSubsidiariesUnitedStates.NorthernMarianaIslands)]
        UntilRetirementAge,

        /// <summary>
        /// only removable by impeachment
        /// </summary>
        [Province((int)StateSubsidiariesUnitedStates.RhodeIsland)]
        Lifetime,
    }

    /// <summary>
    /// New York note: The New York Supreme Court is actually a trial court of general jurisdiction and uses partisan elections
    /// </summary>
    public enum StateSupremeCourtElectionType
    {
        [Province((int)StateSubsidiariesUnitedStates.Arkansas)]
        [Province((int)StateSubsidiariesUnitedStates.Georgia)]
        [Province((int)StateSubsidiariesUnitedStates.Idaho)]
        [Province((int)StateSubsidiariesUnitedStates.Kentucky)]
        [Province((int)StateSubsidiariesUnitedStates.Michigan)]
        [Province((int)StateSubsidiariesUnitedStates.Minnesota)]
        [Province((int)StateSubsidiariesUnitedStates.Mississippi)]
        [Province((int)StateSubsidiariesUnitedStates.Montana)]
        [Province((int)StateSubsidiariesUnitedStates.Nevada)]
        [Province((int)StateSubsidiariesUnitedStates.NorthDakota)]
        [Province((int)StateSubsidiariesUnitedStates.Oregon)]
        [Province((int)StateSubsidiariesUnitedStates.Washington)]
        [Province((int)StateSubsidiariesUnitedStates.Wisconsin)]
        [Province((int)StateSubsidiariesUnitedStates.WestVirginia)]
        NonpartisanElections,

        [Province((int)StateSubsidiariesUnitedStates.Alabama)]
        [Province((int)StateSubsidiariesUnitedStates.Louisiana)]
        [Province((int)StateSubsidiariesUnitedStates.NorthCarolina)]
        [Province((int)StateSubsidiariesUnitedStates.Ohio)]
        [Province((int)StateSubsidiariesUnitedStates.Texas)]
        PartisanElections,

        /// <summary>
        /// First term won through partisan election (in New Mexico may be appointed first until next partisan election)
        /// </summary>
        [Province((int)StateSubsidiariesUnitedStates.Illinois)]
        [Province((int)StateSubsidiariesUnitedStates.NewMexico)]
        [Province((int)StateSubsidiariesUnitedStates.Pennsylvania)]
        PartisanElectionsWithRetention,

        [Province((int)StateSubsidiariesUnitedStates.Alaska)]
        [Province((int)StateSubsidiariesUnitedStates.Arizona)]
        [Province((int)StateSubsidiariesUnitedStates.California)]
        [Province((int)StateSubsidiariesUnitedStates.Colorado)]
        [Province((int)StateSubsidiariesUnitedStates.Florida)]
        [Province((int)StateSubsidiariesUnitedStates.Indiana)]
        [Province((int)StateSubsidiariesUnitedStates.Iowa)]
        [Province((int)StateSubsidiariesUnitedStates.Kansas)]
        [Province((int)StateSubsidiariesUnitedStates.Maryland)]
        [Province((int)StateSubsidiariesUnitedStates.Missouri)]
        [Province((int)StateSubsidiariesUnitedStates.Nebraska)]
        [Province((int)StateSubsidiariesUnitedStates.Oklahoma)]
        [Province((int)StateSubsidiariesUnitedStates.SouthDakota)]
        [Province((int)StateSubsidiariesUnitedStates.Tennessee)]
        [Province((int)StateSubsidiariesUnitedStates.Utah)]
        [Province((int)StateSubsidiariesUnitedStates.Wyoming)]
        RetentionElections,

        [Province((int)StateSubsidiariesUnitedStates.Connecticut)]
        [Province((int)StateSubsidiariesUnitedStates.Delaware)]
        [Province((int)StateSubsidiariesUnitedStates.Hawaii)]
        [Province((int)StateSubsidiariesUnitedStates.Maine)]
        [Province((int)StateSubsidiariesUnitedStates.Massachusetts)]
        [Province((int)StateSubsidiariesUnitedStates.NewHampshire)]
        [Province((int)StateSubsidiariesUnitedStates.NewJersey)]
        [Province((int)StateSubsidiariesUnitedStates.NewYork)] //New York Court of Appeals is the anologue to other State Supreme Courts
        [Province((int)StateSubsidiariesUnitedStates.RhodeIsland)]
        [Province((int)StateSubsidiariesUnitedStates.SouthCarolina)]
        [Province((int)StateSubsidiariesUnitedStates.Vermont)]
        [Province((int)StateSubsidiariesUnitedStates.Virginia)]
        [Province((int)StateSubsidiariesUnitedStates.WashingtonDC)]
        [Province((int)StateSubsidiariesUnitedStates.PuertoRico)]
        [Province((int)StateSubsidiariesUnitedStates.Guam)]
        [Province((int)StateSubsidiariesUnitedStates.UnitedStatesVirginIslands)]
        [Province((int)StateSubsidiariesUnitedStates.NorthernMarianaIslands)]
        NoElections,
    }

    public enum StateSupremeCourtJusticeChoice
    {
        [Province((int)StateSubsidiariesUnitedStates.Arkansas)]
        [Province((int)StateSubsidiariesUnitedStates.Georgia)]
        [Province((int)StateSubsidiariesUnitedStates.Idaho)]
        [Province((int)StateSubsidiariesUnitedStates.Kentucky)]
        [Province((int)StateSubsidiariesUnitedStates.Michigan)]
        [Province((int)StateSubsidiariesUnitedStates.Minnesota)]
        [Province((int)StateSubsidiariesUnitedStates.Mississippi)]
        [Province((int)StateSubsidiariesUnitedStates.Montana)]
        [Province((int)StateSubsidiariesUnitedStates.Nevada)]
        [Province((int)StateSubsidiariesUnitedStates.Oregon)]
        [Province((int)StateSubsidiariesUnitedStates.Washington)]
        [Province((int)StateSubsidiariesUnitedStates.WestVirginia)]
        [Province((int)StateSubsidiariesUnitedStates.Wisconsin)]
        NonPartisanElectionsWithoutRetention,

        [Province((int)StateSubsidiariesUnitedStates.Ohio)]
        NonpartisanElectionsWithRetention,

        /// <summary>
        /// First term won through partisan election (in New Mexico may be appointed first until next partisan election)
        /// </summary>
        [Province((int)StateSubsidiariesUnitedStates.Illinois)]
        [Province((int)StateSubsidiariesUnitedStates.NewMexico)]
        [Province((int)StateSubsidiariesUnitedStates.Pennsylvania)]
        PartisanElectionsWithRetention,

        [Province((int)StateSubsidiariesUnitedStates.Alabama)]
        [Province((int)StateSubsidiariesUnitedStates.Louisiana)]
        [Province((int)StateSubsidiariesUnitedStates.NorthCarolina)]
        [Province((int)StateSubsidiariesUnitedStates.Texas)]
        PartisanElectionsWithoutRetention,

        [Province((int)StateSubsidiariesUnitedStates.Alaska)]
        [Province((int)StateSubsidiariesUnitedStates.Arizona)]
        [Province((int)StateSubsidiariesUnitedStates.Colorado)]
        [Province((int)StateSubsidiariesUnitedStates.Florida)]
        [Province((int)StateSubsidiariesUnitedStates.Indiana)]
        [Province((int)StateSubsidiariesUnitedStates.Iowa)]
        [Province((int)StateSubsidiariesUnitedStates.Kansas)]
        [Province((int)StateSubsidiariesUnitedStates.Missouri)]
        [Province((int)StateSubsidiariesUnitedStates.Nebraska)]
        [Province((int)StateSubsidiariesUnitedStates.NorthDakota)]
        [Province((int)StateSubsidiariesUnitedStates.Oklahoma)]
        [Province((int)StateSubsidiariesUnitedStates.SouthDakota)]
        [Province((int)StateSubsidiariesUnitedStates.Tennessee)]
        [Province((int)StateSubsidiariesUnitedStates.Utah)]
        [Province((int)StateSubsidiariesUnitedStates.Wyoming)]
        CommissionRecommendationsGubernatorialAppointmentFromListRetentionElection,

        [Province((int)StateSubsidiariesUnitedStates.Connecticut)]
        [Province((int)StateSubsidiariesUnitedStates.Maryland)]
        CommissionRecommendationsGubernatorialAppointmentPotentiallyNotFromListLegislativeConfirmationRepeatProcessAfterTerm,

        [Province((int)StateSubsidiariesUnitedStates.California)]
        GubernatorialAppointmentCommissionConfirmationRepeatProcessAfterTerm,

        [Province((int)StateSubsidiariesUnitedStates.Maine)]
        [Province((int)StateSubsidiariesUnitedStates.UnitedStatesVirginIslands)]
        GubernatorialAppointmentLegislatureConfirmationRepeatProcessAfterTerm,

        [Province((int)StateSubsidiariesUnitedStates.NewJersey)]
        GubernatorialAppointmentLegislativeConfirmationRepeatAfterNextTermAndThenGetLifeTermToRetirementAge,

        [Province((int)StateSubsidiariesUnitedStates.Delaware)]
        [Province((int)StateSubsidiariesUnitedStates.NewYork)] //New York Court of Appeals
        [Province((int)StateSubsidiariesUnitedStates.Vermont)]
        [Province((int)StateSubsidiariesUnitedStates.WashingtonDC)] //US president performs governor-equivalent work
        CommissionRecommendationsGubernatorialAppointmentFromListLegislativeConfirmationRepeatProcessAfterTerm,

        /// <summary>
        /// commission decides on retention, not requiring the same confirmation process for subsequent terms
        /// </summary>
        [Province((int)StateSubsidiariesUnitedStates.Hawaii)]
        CommissionRecommendationsGubernatorialAppointmentFromListLegislativeConfirmationCommissionDecidesRetention,

        /// <summary>
        /// legislative appointment must be redone at the end of the next term
        /// </summary>
        [Province((int)StateSubsidiariesUnitedStates.SouthCarolina)]
        [Province((int)StateSubsidiariesUnitedStates.Virginia)]
        LegislativeAppointmentRepeatProcessAfterTerm,

        /// <summary>
        /// no need to repeat any process for successive terms, but leave office at retirement age
        /// </summary>
        [Province((int)StateSubsidiariesUnitedStates.Massachusetts)]
        [Province((int)StateSubsidiariesUnitedStates.NewHampshire)]
        [Province((int)StateSubsidiariesUnitedStates.PuertoRico)]
        [Province((int)StateSubsidiariesUnitedStates.Guam)]
        [Province((int)StateSubsidiariesUnitedStates.NorthernMarianaIslands)]
        GubernatorialAppointmentLegislativeConfirmationTermUntilRetirementAge,

        /// <summary>
        /// life term, can only be removed via impeachment
        /// </summary>
        [Province((int)StateSubsidiariesUnitedStates.RhodeIsland)]
        CommissionRecommendationsGubernatorialAppointmentFromListLegislativeConfirmationLifeTerm,
    }
}
