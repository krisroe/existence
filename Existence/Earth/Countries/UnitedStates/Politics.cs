using Existence.Earth.Human.Politics;
using Existence.Time;
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

    /// <summary>
    /// top two (optionally three) recipients of electoral votes for President
    /// </summary>
    public class UnitedStatesElectoralCollegeResultAttribute : Attribute
    {
        public int FirstPlace { get; set; }
        public int FirstPlaceElectoralVotes { get; set; }
        public int SecondPlace { get; set; }
        public int SecondPlaceElectoralVotes { get; set; }
        public int? ThirdPlace { get; set; }
        public int? ThirdPlaceElectoralVotes { get; set; }
        public UnitedStatesElectoralCollegeResultAttribute(int FirstPlace, int FirstPlaceElectoralVotes, int SecondPlace, int SecondPlaceElectoralVotes)
        {
            this.FirstPlace = FirstPlace;
            this.FirstPlaceElectoralVotes = FirstPlaceElectoralVotes;
            this.SecondPlace = SecondPlace;
            this.SecondPlaceElectoralVotes = SecondPlaceElectoralVotes;
        }
        public UnitedStatesElectoralCollegeResultAttribute(int FirstPlace, int FirstPlaceElectoralVotes, int SecondPlace, int SecondPlaceElectoralVotes, int ThirdPlace, int ThirdPlaceElectoralVotes) : this(FirstPlace, FirstPlaceElectoralVotes, SecondPlace, SecondPlaceElectoralVotes)
        {
            this.ThirdPlace = ThirdPlace;
            this.ThirdPlaceElectoralVotes = ThirdPlaceElectoralVotes;
        }
    }

    public static class Elections
    {
        /// <summary>
        /// results are the national popular vote; the winner is the Electoral College winner
        /// </summary>
        public static class Presidential
        {
            /// <summary>
            /// First Presidential election. Washington was unopposed and received an electoral vote from every voter.
            /// Each elector cast two votes; the runner-up became Vice President
            /// </summary>
            [YearRange(1788, 1789)]
            [UnitedStatesElectoralCollegeResult((int)UnitedStatesPoliticians.WashingtonGeorge, 69, (int)UnitedStatesPoliticians.AdamsJohn, 34, (int)UnitedStatesPoliticians.JayJohn, 9)]
            public static class v1788 { }

            [Omitted]public static class v1792 { }
            [Omitted]public static class v1796 { }
            [Omitted]public static class v1800 { }
            [Omitted]public static class v1804 { }
            [Omitted]public static class v1808 { }
            [Omitted]public static class v1812 { }
            [Omitted]public static class v1816 { }
            [Omitted]public static class v1820 { }
            [Omitted]public static class v1824 { }
            [Omitted]public static class v1828 { }
            [Omitted]public static class v1832 { }
            [Omitted]public static class v1836 { }
            [Omitted]public static class v1840 { }
            [Omitted]public static class v1844 { }
            [Omitted]public static class v1848 { }
            [Omitted]public static class v1852 { }
            [Omitted]public static class v1856 { }
            [Omitted]public static class v1860 { }
            [Omitted]public static class v1864 { }
            [Omitted]public static class v1868 { }
            [Omitted]public static class v1872 { }
            [Omitted]public static class v1876 { }
            [Omitted]public static class v1880 { }
            [Omitted]public static class v1884 { }
            [Omitted]public static class v1888 { }
            [Omitted]public static class v1892 { }
            [Omitted]public static class v1896 { }
            [Omitted]public static class v1900 { }
            [Omitted]public static class v1904 { }
            [Omitted]public static class v1908 { }
            [Omitted]public static class v1912 { }
            [Omitted]public static class v1916 { }
            [Omitted]public static class v1920 { }
            [Omitted]public static class v1924 { }
            [Omitted]public static class v1928 { }
            [Omitted]public static class v1932 { }
            [Omitted]public static class v1936 { }
            [Omitted]public static class v1940 { }
            [Omitted]public static class v1944 { }
            [Omitted]public static class v1948 { }
            [Omitted]public static class v1952 { }
            [Omitted]public static class v1956 { }
            [Omitted]public static class v1960 { }
            [Omitted]public static class v1964 { }
            [Omitted]public static class v1968 { }
            [Omitted]public static class v1972 { }
            [Omitted]public static class v1976 { }
            [Omitted]public static class v1980 { }
            [Omitted]public static class v1984 { }

            /// <summary>
            /// a West Virginia faithless elector cast a vote for Bentsen for President (and Dukakis for Vice President)
            /// </summary>
            [YearDate(1988, 11, 8)]
            [HeadToHeadElectionResult((int)UnitedStatesPoliticians.BushGeorgeHW, 53.37, (int)UnitedStatesPoliticians.DukakisMichael, 45.65)]
            [UnitedStatesElectoralCollegeResult((int)UnitedStatesPoliticians.BushGeorgeHW, 426, (int)UnitedStatesPoliticians.DukakisMichael, 111, (int)UnitedStatesPoliticians.BentsenLloyd, 1)]
            [ElectionNightConcession((int)UnitedStatesPoliticians.DukakisMichael)]
            public static class v1988 { }

            [Omitted]public static class v1992 { }
            [Omitted]public static class v1996 { }

            /// <summary>
            /// Gore won the popular vote; Florida decided the Electoral College after Bush v. Gore (December 12).
            /// Gore privately conceded to Bush on election night, then retracted it. One D.C. elector pledged to Gore
            /// cast a blank ballot in protest of D.C.'s lack of voting representation in Congress
            /// </summary>
            [YearDate(2000, 11, 7)]
            [HeadToHeadElectionResult((int)UnitedStatesPoliticians.BushGeorgeW, 47.87, (int)UnitedStatesPoliticians.GoreAl, 48.38)]
            [UnitedStatesElectoralCollegeResult((int)UnitedStatesPoliticians.BushGeorgeW, 271, (int)UnitedStatesPoliticians.GoreAl, 266)]
            [LaterConcession((int)UnitedStatesPoliticians.GoreAl, 2000, 12, 13)]
            public static class v2000 { }

            [Omitted]public static class v2004 { }
            [Omitted]public static class v2008 { }
            [Omitted]public static class v2012 { }

            /// <summary>
            /// Trump won the Electoral College while losing the popular vote. Powell's 3 electoral votes came from
            /// faithless electors (Kasich, Ron Paul, Sanders, and Faith Spotted Eagle received 1 each)
            /// </summary>
            [YearDate(2016, 11, 8)]
            [HeadToHeadElectionResult((int)UnitedStatesPoliticians.TrumpDonald, 46.09, (int)UnitedStatesPoliticians.ClintonHillary, 48.18)]
            [UnitedStatesElectoralCollegeResult((int)UnitedStatesPoliticians.TrumpDonald, 304, (int)UnitedStatesPoliticians.ClintonHillary, 227, (int)UnitedStatesPoliticians.PowellColin, 3)]
            [LaterConcession((int)UnitedStatesPoliticians.ClintonHillary, 2016, 11, 9)]
            public static class v2016 { }

            [YearDate(2020, 11, 3)]
            [Incumbent((int)UnitedStatesPoliticians.TrumpDonald)]
            [HeadToHeadElectionResult((int)UnitedStatesPoliticians.BidenJoe, 51.31, (int)UnitedStatesPoliticians.TrumpDonald, 46.85)]
            [UnitedStatesElectoralCollegeResult((int)UnitedStatesPoliticians.BidenJoe, 306, (int)UnitedStatesPoliticians.TrumpDonald, 232)]
            [DidNotConcede((int)UnitedStatesPoliticians.TrumpDonald)]
            public static class v2020 { }

            [YearDate(2024, 11, 5)]
            [HeadToHeadElectionResult((int)UnitedStatesPoliticians.TrumpDonald, 49.80, (int)UnitedStatesPoliticians.HarrisKamala, 48.32)]
            [UnitedStatesElectoralCollegeResult((int)UnitedStatesPoliticians.TrumpDonald, 312, (int)UnitedStatesPoliticians.HarrisKamala, 226)]
            [LaterConcession((int)UnitedStatesPoliticians.HarrisKamala, 2024, 11, 6)]
            public static class v2024 { }
        }
    }
}
