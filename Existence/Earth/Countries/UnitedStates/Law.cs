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
        BallotInitiativesLimitation,
        ElderlyPeople,
        PrimaryElections,
        RankedChoiceVoting,
        PhotoIdentificationNeededForVoting,
        IdentificationNeededForVoting,
        NonCitizenVoting,
        StateExecutiveElections,
        PublicEducationGovernance,
        LocalGovernmentOrganization,
        StateSymbols,
        ReligionInPublicSchools,
        PoliticsInPublicSchools,
        CampaignFinance,
        VehicleAndDriverRegulations,
        RaceAndEthnicityIssues,
        ConstitutionalRights,
        ConstitutionalRightsGuns,
        ConstitutionalRightsProtectedGroups,
        HigherEducationGovernance,
        AffirmativeAction,
        EarlyVoting,
        ElectionAdministrationAndGovernance,
        AbsenteeAndMailVoting,
        CriminalSentencing,
        ImmigrationPolicy,
        AthleticsAndSports,
        LGBTQIssues,
        TransgenderIssues,
        SexAndGenderIssues,
        LawEnforcementOfficersAndDepartments,
        PublicEducationFunding,
        FirearmsPolicy,
        LocalGovernmentFinanceAndTaxes,
        PublicEconomicInvestmentPolicy,
        ParksLandAndNaturalAreaConservation,
        WaterIrrigationPolicy,
        BondIssues,
        FloodInfrastructureAndManagement,
        SewageAndStormwater,
        StormInfrastructure,
        PollutionWasteAndRecyclingPolicy,
        HousingAssistancePrograms,
        BudgetStabilizationFunds,
        HigherEducationFunding,
        VaccinationsAndDiseasePolicy,
        HealthcareGovernance,
        HealthcareFacilityFunding,
        PublicHealthInsurance,
        TaxAndRevenueAdministration,
        RevenueAndSpendingLimits,
        BallotMeasureSupermajorityRequirements,
        BusinessRegulations,
        LandUseAndDevelopmentPolicy,
        AdministrativePowersAndRulemaking,
        StateExecutiveBranchStructure,
        RecallProcess,
        FossilFuelEnergy,
        RightToHuntAndFish,
        RedistrictingPolicy,
        MidCycleRedistricting,
        EarlyChildhoodEducation,
        PublicAssistancePrograms,
        DrugCrimePolicy,
        RestrictedUseFunds,
        WildfireManagement,
        AgriculturePolicy,
        ForestryAndTimber,
        StateJudicialSelection,
        StateLegislativeProcessesAndSessions,
        HousingDevelopmentFunding,
        BondIssueRequirements,
        StateLegislativeAuthority,
        MarijuanaLaws,
        DrugLegalization,
        EnglishLanguagePolicy,
        CriminalTrials,
        BailPolicy,
        LocalGovernmentOfficialsAndElections,
        StateLegislativeVoteRequirements,
        StateJudiciaryOversight,
        MinimumWage,
        CrimeVictimsRights,
        CollectiveBargaining,
        ReligionRelatedPolicy,
        FamilyRelatedPolicy,
        VotingRightsForPersonsWithCriminalConvictions,
        ResidencyVotingRequirements,
        TermLengths,
        DeathPenalty,
        VetoPowers,
        StateJudiciaryStructure,
        PrivateElectionFunding,
        FederalFunds,
        EmergencyPowers,
        SalariesOfGovernmentOfficials,
        StateExecutivePowersAndDuties,
        VeteransPolicy,
        ExecutiveOfficialTermLimits,
        PublicEmployeeRetirementFunds,
        DrinkingWaterSystems,
        EminentDomain,
        CivilService,
        PublicSchoolTeachersAndStaff,
        AgeLimitsForOfficials,
        PublicWorksLaborAndContracting,
        LaborDisputesAndStrikes,
        OpenMeetingsAndPublicInformation,
        VoterRegistration,
        RevenueAllocation,
        StateConstitutionalConventions,
        StateLegislativeTermLimits,
        GamblingPolicy,
        AdministrativeOrganization,
        ConstitutionalWordingChanges,
        PardonsAndCommutations,
        Taxes,
        TaxesBusiness,
        TaxesFoodAndBeverage,
        TaxesFuel,
        TaxesIncome,
        TaxesProperty,
        TaxesPropertyHomesteadExemptions,
        TaxesPropertyExemptions,
        TaxesSales,
        TaxesAndFeesTransportation,
    }

    public class  BallotInitiativeSubjectAttribute : SingularObjectAttribute
    {
        public BallotInitiativeSubjects Subject { get; set; }
        public BallotInitiativeSubjectAttribute(BallotInitiativeSubjects Subject)
        {
            this.Subject = Subject;
        }
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
        BentsenLloyd,

        [Gender(Gender.Male)]
        BidenJoe,

        [Gender(Gender.Male)]
        BrownSherrod,

        [Gender(Gender.Male)]
        BrowneHarry,

        [Gender(Gender.Male)]
        [Child((int)UnitedStatesPoliticians.BushGeorgeW)]
        BushGeorgeHW,

        [Gender(Gender.Male)]
        [Father((int)UnitedStatesPoliticians.BushGeorgeHW)]
        BushGeorgeW,

        [Gender(Gender.Male)]
        CheneyDick,

        [Gender(Gender.Female)]
        CollinsSusan,

        [Gender(Gender.Female)]
        ClintonHillary,

        [Gender(Gender.Male)]
        DoleBob,

        [Gender(Gender.Male)]
        DukakisMichael,

        [Gender(Gender.Male)]
        ElSayedAbdul,

        [Gender(Gender.Female)]
        EmersonJoAnn,

        [Gender(Gender.Male)]
        FrankenAl,

        [Gender(Gender.Male)]
        GoodeVirgil,

        [Gender(Gender.Male)]
        GoreAl,

        [Gender(Gender.Male)]
        GrahamDarline,

        [Gender(Gender.Male)]
        GrahamLindsey,

        [Gender(Gender.Female)]
        HarrisKamala,

        [Gender(Gender.Male)]
        JayJohn,

        [Gender(Gender.Male)]
        JeffordsJim,

        [Gender(Gender.Male)]
        JacksonTroy,

        [Gender(Gender.Male)]
        JohnsonGary,

        [Gender(Gender.Male)]
        KingAngus,

        [Gender(Gender.Male)]
        LiebermanJoe,

        [Gender(Gender.Male)]
        McCainJohn,

        [Gender(Gender.Male)]
        ObamaBarack,

        [Gender(Gender.Female)]
        PeltolaMary,

        [Gender(Gender.Male)]
        PaulRon,

        [Gender(Gender.Male)]
        PaxtonKen,

        [Gender(Gender.Male)]
        PlatnerGraham,

        [Gender(Gender.Male)]
        PowellColin,

        [Gender(Gender.Male)]
        RogersMike,

        [Gender(Gender.Male)]
        RomneyMitt,

        [Gender(Gender.Male)]
        SandersBernie,

        [Gender(Gender.Male)]
        ShelbyRichard,

        [Gender(Gender.Female)]
        SinemaKyrsten,

        /// <summary>
        /// has had to face nonserious doppelganger candidate
        /// </summary>
        [Gender(Gender.Male)]
        SullivanDan,

        [Gender(Gender.Male)]
        TalaricoJames,

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
