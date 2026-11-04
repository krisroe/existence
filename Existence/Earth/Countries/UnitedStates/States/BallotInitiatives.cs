using Existence.Beyond.Infrastructure;
using Existence.Earth.Alphabet;
using Existence.Earth.Countries.UnitedStates.Politics;
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates.States
{
    /// <summary>
    /// the options in Idaho's 2026 Official State Gun Question, in ballot order
    /// </summary>
    public enum IdahoPotentialStateGuns
    {
        /// <summary>
        /// Winchester Model 1894 (.30-30)
        /// </summary>
        WinchesterModel1894,

        /// <summary>
        /// Winchester Model 1873 "Gun that Won the West" (.44-40)
        /// </summary>
        WinchesterModel1873,

        /// <summary>
        /// 1873 Colt Single Action Army Revolver "Peacemaker" (.45 Colt)
        /// </summary>
        ColtSingleActionArmyRevolver1873,

        /// <summary>
        /// M1 Garand rifle (.30-06)
        /// </summary>
        M1Garand,

        /// <summary>
        /// Colt M1911 .45 automatic Colt pistol (.45 ACP)
        /// </summary>
        ColtM1911,

        /// <summary>
        /// Remington Model 700 bolt-action rifle (.30-06)
        /// </summary>
        RemingtonModel700,
    }

    public static class BallotInitiatives
    {
        public static class Alabama
        {
            public static class v2018
            {
                /// <summary>
                /// A "yes" vote supported this amendment to make it state policy to "recognize and
                /// support the sanctity of unborn life and the rights of unborn children, including 
                /// the right to life" and to state that no provisions of the constitution provide a 
                /// right to an abortion or require funding of abortions.
                /// Result:
                /// Yes: 916,061 59.01%
                /// No : 636,438 40.99%
                /// </summary>
                [YearDate(2018, 11, 6)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Amendment2 { }
            }
            public static class v2020
            {
                /// <summary>
                /// A "yes" vote supported amending the Alabama Constitution to state that “only a citizen” of the U.S. who is 18 years old or older can vote in Alabama.
                /// Result:
                /// Yes: 1,535,862 77.01%
                /// No :   458,487 22.99%
                /// </summary>
                [YearDate(2020, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                [BallotMeasurePassFail(true)]
                public static class Amendment2 { }
            }
            public static class v2026
            {
                [YearDate(2026, 5, 19)]
                public static class May
                {
                    /// <summary>
                    /// A "yes" vote supported adding discharging a firearm in an occupied dwelling or other occupied space
                    /// and any solicitation, attempt, or conspiracy to commit murder to the list of crimes for which a judge
                    /// may deny bail.
                    /// Result:
                    /// Yes: 691,002 81.58%
                    /// No : 155,985 18.42%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.CriminalTrials, BallotInitiativeSubjects.BailPolicy)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment1 { }

                    /// <summary>
                    /// A "yes" vote supported prohibiting any reduction in a district attorney's compensation during their
                    /// term in office.
                    /// Result:
                    /// Yes: 474,839 57.75%
                    /// No : 347,379 42.25%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.SalariesOfGovernmentOfficials)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment2 { }
                }

                [YearDate(2026, 11, 3)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supports providing for the election of a lieutenant governor if the office of lieutenant
                    /// governor becomes vacant during the first two years of a term (Alabama Fair Ballot Commission). Ballotpedia
                    /// instead describes it as requiring an election if a vacancy occurs more than 60 days before the next
                    /// general election.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.StateExecutiveElections)]
                    public static class Amendment1 { }

                    /// <summary>
                    /// A "yes" vote supports establishing a process for consolidating two or more county school districts.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicEducationGovernance, BallotInitiativeSubjects.LocalGovernmentOrganization)]
                    public static class Amendment2 { }

                    /// <summary>
                    /// A "yes" vote supports requiring public schools to conduct the pledge of allegiance each day, and allowing
                    /// student-led prayer to be conducted.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.StateFlagsSymbolsAndHolidays, BallotInitiativeSubjects.ReligionInPublicSchools)]
                    public static class Amendment3 { }

                    /// <summary>
                    /// A "yes" vote supports requiring all public schools to broadcast or arrange for the performance of the
                    /// first stanza of the Star-Spangled Banner at least once per week.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicEducationGovernance, BallotInitiativeSubjects.StateFlagsSymbolsAndHolidays)]
                    public static class Amendment4 { }
                }
            }
        }

        public static class Alaska
        {
            public static class v2020
            {
                /// <summary>
                /// A "yes" vote supported making changes to Alaska's election policies, including:
                /// 1. requiring persons and entities that contribute more than $2,000 that were themselves derived 
                /// from donations, contributions, dues, or gifts to disclose the true sources(as defined in law) 
                /// of the political contributions;
                /// 2. replacing partisan primaries with open top-four primaries for state executive, 
                /// state legislative, and congressional offices; and
                /// 3. establishing ranked-choice voting for general elections, including the presidential election, 
                /// in which voters would rank the candidates.
                /// Result:
                /// Yes: 174,032 50.55%
                /// No : 170,251 49.45%
                /// </summary>
                [YearDate(2020, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections, BallotInitiativeSubjects.RankedChoiceVoting)]
                [BallotMeasurePassFail(true)]
                public static class BallotMeasure2 { }
            }
            public static class v2024
            {
                /// <summary>
                /// A "yes" vote supported eliminating the top-four primaries and ranked-choice voting general 
                /// elections in Alaska, which were adopted in 2020, and establishing a party primary system.
                /// Result:
                /// Yes: 160,230 49.88%
                /// No : 160,973 50.12%
                /// </summary>
                [YearDate(2024, 11, 5)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections, BallotInitiativeSubjects.RankedChoiceVoting)]
                [BallotMeasurePassFail(false)]
                [Observation("This kept the primary system and ranked choice voting in place")]
                public static class BallotMeasure2 { }
            }
            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports repealing the top-four ranked-choice voting (RCV) system that was adopted in 2020.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RankedChoiceVoting, BallotInitiativeSubjects.PrimaryElections, BallotInitiativeSubjects.CampaignFinance)]
                public static class BallotMeasure2 { }

                /// <summary>
                /// A "yes" vote supports amending state law to provide that "Only a person who is a citizen of the United
                /// States" may vote in any election.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                public static class BallotMeasure3 { }
            }
        }

        public static class Arizona
        {
            public static class v2004
            {
                /// <summary>
                /// requires
                /// (a) persons to provide proof of citizenship to register to vote; 
                /// (b) voters to present a photo identification before receiving a ballot at the polling place; and 
                /// (c) state and local agencies to verify the identity and eligibility, based on immigration status, 
                /// of applicants for non-federally mandated public benefits
                /// Result:
                /// Yes (56%) (wikipedia)
                /// No  (44%)
                /// </summary>
                [YearDate(2004, 11, 2)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                [BallotMeasurePassFail(true)]
                public static class Proposition200 { }
            }

            public static class v2022
            {
                /// <summary>
                /// A "yes" vote supported making multiple changes to Arizona's voter identification and mail-in 
                /// ballot policies, including requiring dates of birth and voter identification numbers for mail-in 
                /// ballots and eliminating the existing two-document alternative to photo ID for in-person voting.
                /// </summary>
                [YearDate(2022, 11, 8)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIdentificationNeededForVoting)]
                [BallotMeasurePassFail(false)]
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                public static class Proposition309 { }
            }

            public static class v2024
            {

                [YearDate(2024, 11, 5)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supported this constitutional amendment to:
                    /// 1. require partisan primary elections for partisan offices;
                    /// 2. prohibit primary elections where all candidates, regardless of political party affiliation,
                    /// run in the same primary election, such as top-two, top-four, and top-five primaries;
                    /// 3. provide that the state's direct primary election law supersedes local charters and 
                    /// ordinances that are inconsistent with that law.
                    /// Result:
                    /// No : 1,763,711 57.82%
                    /// Yes: 1,286,640 42.18%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections)]
                    [BallotMeasurePassFail(false)]
                    public static class Proposition133 { }

                    /// <summary>
                    /// A "yes" vote supported amending the state constitution to provide for the fundamental right to 
                    /// abortion, among other provisions.
                    /// Result:
                    /// Yes: 2,000,287 61.61%
                    /// No : 1,246,202 38.39%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                    [BallotMeasurePassFail(true)]
                    public static class Proposition139 { }

                    /// <summary>
                    /// A "yes" vote supported this ballot initiative to change the state's electoral system, including:
                    /// 1. replacing partisan primaries with primaries in which candidates, regardless of partisan 
                    /// affiliation, appear on a single ballot and a certain number advance to the general election, 
                    /// such as top-two or top-four primaries;
                    /// 2. requiring candidates to receive a majority of votes in general elections
                    /// 3. requiring the use of ranked-choice voting in general elections when three or more candidates 
                    /// advance from the primaries(for one-winner general elections); and
                    /// 4. prohibiting using public funds to administer partisan primaries at the federal, state, and 
                    /// local levels, except for presidential preference primaries that allow independents to participate.
                    /// Result:
                    /// No : 1,823,445 58.68%
                    /// Yes: 1,284,176 41.32%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections, BallotInitiativeSubjects.RankedChoiceVoting)]
                    [BallotMeasurePassFail(false)]
                    public static class Proposition140 { }
                }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports prohibiting the government from imposing taxes or fees based on vehicle miles
                /// traveled and from enacting rules to monitor or limit vehicle miles traveled without the person's consent.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.VehicleAndDriverRegulations, BallotInitiativeSubjects.TransportationTaxesAndFees)]
                public static class Proposition141 { }

                /// <summary>
                /// A "yes" vote supports prohibiting the government from requiring an individual to endorse preferential
                /// treatment toward or discrimination against an individual on the basis of race or ethnicity.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RaceAndEthnicityIssues, BallotInitiativeSubjects.ConstitutionalRights, BallotInitiativeSubjects.HigherEducationGovernance, BallotInitiativeSubjects.AffirmativeAction, BallotInitiativeSubjects.PublicEducationGovernance)]
                public static class Proposition142 { }

                /// <summary>
                /// A "yes" vote supports making a number of changes to the state's election laws, including 
                /// 1. specifying that "only citizens may register and vote in state elections"
                /// 2. prohibit a foreign national from making contributions in an effort to influence a state election, and prohibit others from knowingly accepting such contributions;
                /// 3. require voters to provide government-issued identification to cast a ballot
                /// 4. grant voters the right to have their vote tabulated at their voting location
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting,
                    BallotInitiativeSubjects.CampaignFinance,
                    BallotInitiativeSubjects.IdentificationNeededForVoting,
                    BallotInitiativeSubjects.EarlyVoting,
                    BallotInitiativeSubjects.AbsenteeAndMailVoting)]
                public static class Proposition144 { }

                /// <summary>
                /// A "yes" vote supports prohibiting local government from imposing or increasing a tax on the sale of food
                /// items without voter approval and capping the tax rate at 2%.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.SalesTaxes, BallotInitiativeSubjects.FoodAndBeverageTaxes)]
                public static class Proposition316 { }

                /// <summary>
                /// A "yes" vote supports declaring drug cartels to be terrorist organizations.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.CriminalSentencing, BallotInitiativeSubjects.ImmigrationPolicy)]
                public static class Proposition317 { }

                /// <summary>
                /// A "yes" vote supports prohibiting schools and athletic associations from allowing a student, athlete,
                /// employee, or other individual from using a restroom, locker room, shower room, or other private space that
                /// is not designated for their sex.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicEducationGovernance, BallotInitiativeSubjects.AthleticsAndSports, BallotInitiativeSubjects.LGBTQIssues, BallotInitiativeSubjects.SexAndGenderIssues)]
                public static class Proposition318 { }

                /// <summary>
                /// A "yes" vote supports prohibiting the government from using traffic photo enforcement systems without
                /// voter approval.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.LawEnforcementOfficersAndDepartments, BallotInitiativeSubjects.VehicleAndDriverRegulations)]
                public static class Proposition319 { }

                /// <summary>
                /// A "yes" vote supports requiring certain school districts to spend at least 60% of their budget on direct
                /// instructional expenses.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicEducationFunding, BallotInitiativeSubjects.PublicEducationGovernance)]
                public static class Proposition320 { }
            }
        }

        public static class Arkansas
        {
            public static class v2018
            {
                /// <summary>
                /// A "yes" vote supported this amendment to require individuals to present valid photo ID to 
                /// cast non provisional ballots in person or absentee.
                /// Result:
                /// Yes: 692,622 79.47%
                /// No : 178,936 20.53%
                /// </summary>
                [YearDate(2018, 11, 6)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIdentificationNeededForVoting)]
                [BallotMeasurePassFail(true)]
                public static class Issue2 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports providing that "Only a citizen of the United States ... may vote in an election in
                /// this state".
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                public static class Issue1 { }

                /// <summary>
                /// A "yes" vote supports providing that the right to keep and bear arms is "a natural, fundamental, and
                /// individual right that shall not be infringed".
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.FirearmsPolicy, BallotInitiativeSubjects.ConstitutionalRights)]
                public static class Issue2 { }

                /// <summary>
                /// A "yes" vote supports allowing the legislature to create programs, including Economic Development
                /// Districts, and make loans and grants of public money to develop the state economy.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.LocalGovernmentFinanceAndTaxes, BallotInitiativeSubjects.LocalGovernmentOrganization, BallotInitiativeSubjects.PublicEconomicInvestmentPolicy)]
                public static class Issue3 { }

                /// <summary>
                /// A "yes" vote supports authorizing the Arkansas Natural Resources Commission to issue up to $500 million
                /// in general obligation bonds to fund water-related infrastructure projects including water treatment and
                /// transportation, waste disposal, pollution abatement, drainage, irrigation, flood control, and wetlands
                /// and aquatic resources infrastructure.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.ParksLandAndNaturalAreaConservation, BallotInitiativeSubjects.WaterIrrigationPolicy, BallotInitiativeSubjects.BondIssues, BallotInitiativeSubjects.FloodInfrastructureAndManagement, BallotInitiativeSubjects.SewageAndStormwater, BallotInitiativeSubjects.StormInfrastructure, BallotInitiativeSubjects.PollutionWasteAndRecyclingPolicy)]
                public static class Issue4 { }
            }
        }

        public static class California
        {
            public static class v2010
            {
                /// <summary>
                /// A "yes" vote supported adopting a top-two primary system for congressional or state elective 
                /// offices.
                /// Result:
                /// Yes: 2,868,945 53.73%
                /// No : 2,470,658 46.27%
                /// </summary>
                [YearDate(2010, 6, 8)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections)]
                [BallotMeasurePassFail(true)]
                public static class Proposition14 { }
            }

            public static class v2022
            {
                /// <summary>
                /// A "yes" vote supported amending the state constitution to prohibit the state from 
                /// interfering with or denying an individual's reproductive freedom, which is defined 
                /// to include a right to an abortion and a right to contraceptives.
                /// Result:
                /// Yes: 7,176,883 66.88%
                /// No : 3,553,561 33.12%
                /// </summary>
                [YearDate(2022, 11, 8)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Proposition1 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports issuing $11.25 billion in bonds to fund the Multifamily Housing Program, the CalVet
                /// Home Loan Program, and youth housing.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.BI)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.HousingAssistancePrograms, BallotInitiativeSubjects.BondIssues)]
                public static class Proposition1 { }

                /// <summary>
                /// A "yes" vote supports increasing the Budget Stabilization Account (BSA) cap from 10% of general fund
                /// revenue to 20% and excluding deposits into the BSA from the Gann Limit.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BudgetStabilizationFunds)]
                public static class Proposition2 { }

                /// <summary>
                /// A "yes" vote supports renewing the additional income taxes enacted with the approval of Proposition 30 in
                /// 2012 that fund education and early childhood programs.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.HigherEducationFunding, BallotInitiativeSubjects.IncomeTaxes, BallotInitiativeSubjects.PublicEducationFunding)]
                public static class Proposition3 { }

                /// <summary>
                /// A "yes" vote supports allowing the state and local governments to create programs that provide candidates
                /// with public funds under spending limits and eligibility rules.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.ElectionAdministrationAndGovernance, BallotInitiativeSubjects.CampaignFinance)]
                public static class Proposition4 { }

                /// <summary>
                /// A "yes" vote supports eliminating the successor election when a state officer is recalled, thereby
                /// leaving the office vacant until it is filled according to state law.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.StateExecutiveBranchStructure, BallotInitiativeSubjects.RecallProcess)]
                public static class Proposition5 { }

                /// <summary>
                /// A "yes" vote supports establishing a second mortgage homebuyer program for qualified homebuyers on
                /// qualifying homes and issuing $25 billion in bonds to fund the program.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.HousingAssistancePrograms)]
                public static class Proposition37 { }

                /// <summary>
                /// A "yes" vote supports issuing $8.4 billion in general obligation bonds to fund immunology and
                /// immunotherapy research.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BondIssues, BallotInitiativeSubjects.VaccinationsAndDiseasePolicy, BallotInitiativeSubjects.HealthcareGovernance, BallotInitiativeSubjects.HealthcareFacilityFunding)]
                public static class Proposition38 { }

                /// <summary>
                /// A "yes" vote supports requiring voters to present government-issued identification when casting ballots
                /// and requiring election officials to use government data to confirm voter citizenship and report
                /// verification rates.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.ElectionAdministrationAndGovernance, BallotInitiativeSubjects.IdentificationNeededForVoting)]
                public static class Proposition39 { }

                /// <summary>
                /// A "yes" vote supports levying a one-time 5% tax on the accumulated wealth of taxpayers and trusts with
                /// covered assets valued over $1 billion to fund state health care programs, food assistance programs, and
                /// public education.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICASS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.IncomeTaxes, BallotInitiativeSubjects.PublicHealthInsurance)]
                public static class Proposition40 { }

                /// <summary>
                /// A "yes" vote supports requiring state laws or ballot initiatives levying a new special tax enacted after
                /// January 1, 2026 to require the government entities or departments receiving revenue from the new tax to
                /// eliminate their lowest-performing programs and reinvest those savings in higher-performing programs.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.TaxAndRevenueAdministration, BallotInitiativeSubjects.RevenueAndSpendingLimits)]
                public static class Proposition41 { }

                /// <summary>
                /// A "yes" vote supports prohibiting the enactment of new taxes after January 1, 2026 on ownership or
                /// accumulation of retirement holdings, individually-owned assets, and other forms of personal savings.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.IncomeTaxes)]
                public static class Proposition42 { }

                /// <summary>
                /// A "yes" vote supports requiring a two-thirds vote by the electorate to enact, extend, or increase local
                /// special tax initiatives and prohibiting local governments and ballot initiatives from enacting ad valorem
                /// property taxes except those authorized elsewhere in the state constitution.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.LocalGovernmentFinanceAndTaxes, BallotInitiativeSubjects.BallotMeasureSupermajorityRequirements)]
                public static class Proposition43 { }

                /// <summary>
                /// A "yes" vote supports prohibiting healthcare clinics, specifically federally-qualified health centers and
                /// related organizations, from spending less than 90% of their annual revenue on mission-related purposes.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.HealthcareGovernance, BallotInitiativeSubjects.BusinessRegulations)]
                public static class Proposition44 { }

                /// <summary>
                /// A "yes" vote supports establishing timelines for local and state agencies to review plans and solicit
                /// public comment for essential projects, such as housing, improvements to water supply, transportation,
                /// energy, and facilities for health and public safety.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.LandUseAndDevelopmentPolicy, BallotInitiativeSubjects.AdministrativePowersAndRulemaking)]
                public static class Proposition45 { }
            }
        }

        public static class Colorado
        {
            public static class v2020
            {
                /// <summary>
                /// A "yes" vote supported amending the Colorado Constitution to state that “only a citizen” of the U.S. who is 18 years of age or older can vote in 
                /// Colorado. This replaces language saying "every citizen" who is 18 years of age or older can vote in Colorado.
                /// Result:
                /// Yes: 1,985,239 62.90% (55% supermajority achieved)
                /// No : 1,171,137 37.10%
                /// </summary>
                [YearDate(2020, 11, 3)]

                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                [BallotMeasurePassFail(true)]
                public static class Amendment76 { }
            }

            public static class v2024
            {
                [YearDate(2024, 11, 5)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supported creating a right to abortion in the state constitution and allowing the use of public funds for abortion.
                    /// Result:
                    /// Yes: 1,921,593 61.97%
                    /// No : 1,179,261 38.03%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment79 { }

                    /// <summary>
                    /// A "yes" vote supported establishing top-four primary elections and ranked-choice voting for 
                    /// U.S. Senate, U.S. House of Representatives, governor, attorney general, secretary of state, 
                    /// treasurer, Colorado University board of regents, state board of education, and state 
                    /// legislature.
                    /// Result:
                    /// No : 1,595,256 53.53%
                    /// Yes: 1,385,060 46.47%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.CISS)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections, BallotInitiativeSubjects.RankedChoiceVoting)]
                    [BallotMeasurePassFail(false)]
                    public static class Proposition131 { }
                }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports requiring law enforcement to notify the U.S. Department of Homeland Security when a
                /// person is charged with a crime of violence or has a prior felony conviction and the person's immigration
                /// status cannot be determined.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.ImmigrationPolicy, BallotInitiativeSubjects.LawEnforcementOfficersAndDepartments)]
                public static class Amendment81 { }

                /// <summary>
                /// A "yes" vote supports providing a constitutional right for consumers to purchase natural gas for cooking
                /// or heating in homes and businesses and for distributors and utilities to sell natural gas for those
                /// purposes.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BusinessRegulations, BallotInitiativeSubjects.ConstitutionalRights, BallotInitiativeSubjects.FossilFuelEnergy)]
                public static class Amendment82 { }

                /// <summary>
                /// A "yes" vote supports establishing a right to hunt, fish, and take fish and wildlife in the state
                /// constitution, through traditional methods, and allowing the state legislature and executive agencies to
                /// regulate it.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RightToHuntAndFish)]
                public static class Amendment83 { }

                /// <summary>
                /// A "yes" vote supports requiring voters casting ballots by mail to place their signature and some form of
                /// real ID on their ballot.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.AbsenteeAndMailVoting, BallotInitiativeSubjects.PhotoIdentificationNeededForVoting)]
                public static class Amendment84 { }

                /// <summary>
                /// A "yes" vote supports requiring ballot questions to be in plain language, at no more than an eighth-grade
                /// reading level.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BallotInitiatives)]
                public static class Amendment85 { }

                /// <summary>
                /// A "yes" vote supports requiring congressional maps drawn in 2028 to be approved by both a nonpolitical
                /// commission and the state supreme court.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.MidCycleRedistricting)]
                public static class Amendment86 { }

                /// <summary>
                /// A "yes" vote supports establishing a graduated income tax within the state.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICASS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.EarlyChildhoodEducation, BallotInitiativeSubjects.IncomeTaxes, BallotInitiativeSubjects.PublicAssistancePrograms, BallotInitiativeSubjects.PublicEducationFunding)]
                public static class Amendment87 { }

                /// <summary>
                /// A "yes" vote supports increasing penalties for fentanyl-related felonies, requiring treatment for certain
                /// drug offenses, and limiting sentencing exceptions in fentanyl-related crimes that cause another person's
                /// death.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.CriminalSentencing, BallotInitiativeSubjects.DrugCrimePolicy)]
                public static class Proposition132 { }

                /// <summary>
                /// A "yes" vote supports requiring life in prison without parole or release for persons convicted of human
                /// trafficking a child for sexual servitude.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.CriminalSentencing)]
                public static class Proposition133 { }

                /// <summary>
                /// A "yes" vote supports requiring all K-12 and collegiate school sports teams to be separated based on
                /// biological sex, unless the team is co-ed.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.SexAndGenderIssues, BallotInitiativeSubjects.LGBTQIssues, BallotInitiativeSubjects.AthleticsAndSports, BallotInitiativeSubjects.PublicEducationGovernance, BallotInitiativeSubjects.HigherEducationGovernance)]
                public static class Proposition134 { }

                /// <summary>
                /// A "yes" vote supports prohibiting healthcare professionals from providing surgeries to persons under age
                /// 18 for the purpose of "treatment in response to a minor's perception of sex or gender".
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.HealthcareGovernance, BallotInitiativeSubjects.SexAndGenderIssues, BallotInitiativeSubjects.LGBTQIssues)]
                public static class Proposition135 { }

                /// <summary>
                /// A "yes" vote supports establishing a 4.4% cap on individual and corporate income tax rates.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BusinessTaxes, BallotInitiativeSubjects.IncomeTaxes)]
                public static class Proposition136 { }

                /// <summary>
                /// A "yes" vote supports allowing the state to retain and spend sales tax revenue from sporting goods and
                /// equipment for water, land, forest, wildfire prevention, and outdoor recreation purposes.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.SalesTaxes, BallotInitiativeSubjects.RestrictedUseFunds, BallotInitiativeSubjects.ParksLandAndNaturalAreaConservation, BallotInitiativeSubjects.WildfireManagement)]
                public static class Proposition137 { }

                /// <summary>
                /// A "yes" vote supports increasing the TABOR cap and using surplus funds for K-12 education expenses.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RevenueAndSpendingLimits, BallotInitiativeSubjects.PublicEducationFunding)]
                public static class PropositionNN { }
            }
        }

        public static class Florida
        {
            public static class v2006
            {
                /// <summary>
                /// A “yes” vote supported requiring a 60% vote for voters to approve constitutional 
                /// amendments.
                /// Result:
                /// Yes:  2,600,969 57.78%
                /// No :  1,900,359 42.22%
                /// </summary>
                [YearDate(2006, 11, 7)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BallotMeasureSupermajorityRequirements)]
                [BallotMeasurePassFail(true)]
                public static class Amendment3 { }
            }
            public static class v2012
            {
                /// <summary>
                /// A “yes” vote supported this constitutional amendment to:
                /// • prohibit the state from spending public funds for abortions or health insurance 
                /// that includes abortion coverage, with certain exceptions, and
                /// • add language to the Florida Constitution providing that the state constitution 
                /// cannot be interpreted to "create broader rights to an abortion" than the 
                /// U.S. Constitution.
                /// Result: 
                /// No : 4,308,408 55.10%
                /// Yes: 3,511,354 44.90%
                /// </summary>
                [YearDate(2012, 11, 7)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(false)]
                public static class Amendment6 { }
            }

            public static class v2020
            {

                /// <summary>
                /// A "yes" vote supports amending the Florida Constitution to state that “only a citizen” of the U.S. who is 18 years old or older can vote in Florida.
                /// </summary>
                [YearDate(2020, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                [BallotMeasurePassFail(true)]
                public static class Amendment1 { }
            }

            public static class v2024
            {
                /// <summary>
                /// A "yes" vote supported adding the following language to the Florida Constitution’s Declaration 
                /// of Rights: “… no law shall prohibit, penalize, delay, or restrict abortion before viability or 
                /// when necessary to protect the patient’s health, as determined by the patient’s healthcare 
                /// provider.” Amendment 4 maintained the existing constitutional provision that permitted a law 
                /// requiring parents to be notified before a minor can receive an abortion.
                /// Result:
                /// Yes: 6,070,759 57.17% (defeated as 60% was required for passage)
                /// No : 4,548,379 42.83%
                /// </summary>
                [YearDate(2024, 11, 5)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(false)]
                public static class Amendment4 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports increasing the amount of funds that may be retained in the budget stabilization
                /// fund from 10% to 25% of net general revenue, among other changes.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(false)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BudgetStabilizationFunds)]
                public static class Amendment1 { }

                /// <summary>
                /// A "yes" vote supports exempting agricultural-related tangible personal property, such as farm equipment
                /// or tools, from property taxes.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(false)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.AgriculturePolicy, BallotInitiativeSubjects.PropertyTaxExemptions)]
                public static class Amendment2 { }

                /// <summary>
                /// A "yes" vote supports increasing the homestead tax exemption, decreasing the cap on how much the assessed
                /// value of non-homestead properties can increase, and limiting how municipalities can spend property tax
                /// revenue.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PropertyTaxes, BallotInitiativeSubjects.LocalGovernmentFinanceAndTaxes, BallotInitiativeSubjects.HomesteadTaxExemptions, BallotInitiativeSubjects.PropertyTaxExemptions)]
                public static class Amendment3 { }
            }
        }

        public static class Georgia
        {
            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports increasing the maximum acreage of agricultural and timber property that can be
                /// classified as bona fide conservation use property, which is taxed at 40% of the land's value, from 2,000
                /// acres to 4,000 acres.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.ForestryAndTimber, BallotInitiativeSubjects.PropertyTaxExemptions, BallotInitiativeSubjects.AgriculturePolicy)]
                public static class Amendment1 { }

                /// <summary>
                /// A "yes" vote supports requiring that probate judges be elected on a nonpartisan basis.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.StateJudicialSelection)]
                public static class Amendment2 { }

                /// <summary>
                /// A "yes" vote supports allowing the state legislature to create and dedicate revenue to a fund titled the
                /// Georgia Next Generation 9-1-1 Fund, intended to be used to transitioning the existing 9-1-1 emergency response 
                /// system into a new IP-based network system.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RestrictedUseFunds)]
                public static class Amendment3 { }
            }
        }

        public static class Hawaii
        {
            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports increasing the timeframe for the Senate to consider and act on appointments of
                /// judges and justices from 30 days to 60 days for appointments made between April 1 and December 31 when
                /// the Senate is not in regular session or is soon to adjourn the regular session.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.StateLegislativeProcessesAndSessions, BallotInitiativeSubjects.StateJudicialSelection)]
                public static class Question1 { }

                /// <summary>
                /// A "yes" vote supports authorizing the state legislature to empower the counties and municipalities of the
                /// state to issue housing infrastructure growth bonds for specified public works, public improvements, and
                /// community development.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.LocalGovernmentFinanceAndTaxes, BallotInitiativeSubjects.HousingDevelopmentFunding, BallotInitiativeSubjects.BondIssueRequirements, BallotInitiativeSubjects.PublicEconomicInvestmentPolicy, BallotInitiativeSubjects.BondIssues)]
                public static class Question2 { }
            }
        }

        public static class Idaho
        {
            public static class v2024
            {
                [YearDate(2024, 11, 5)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supported establishing top-four primaries and ranked-choice voting for general
                    /// elections, which would apply to congressional, gubernatorial, and state, and county elected 
                    /// offices.
                    /// Result:
                    /// No : 618,753 69.62%
                    /// Yes: 269,960 30.38%
                    /// </summary>
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections, BallotInitiativeSubjects.RankedChoiceVoting)]
                    [BallotMeasureType(BallotMeasureTypes.CISS)]
                    [BallotMeasurePassFail(false)]
                    public static class Proposition1 { }

                    /// <summary>
                    /// A "yes" vote supported amending the Idaho Constitution to provide that only a citizen of the United States can vote in the state.
                    /// Result:
                    /// Yes: 572,865 64.93%
                    /// No : 309.456 35.07%
                    /// </summary>
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class HJR5 { }
                }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports providing that only the state legislature has the authority to legalize marijuana,
                /// narcotics, or other psychoactive substances (this cannot be done by ballot initiative)
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.DrugCrimePolicy, BallotInitiativeSubjects.StateLegislativeAuthority, BallotInitiativeSubjects.MarijuanaLaws, BallotInitiativeSubjects.PsychedelicSubstancesLaws)]
                public static class HJR4 { }

                /// <summary>
                /// A "yes" vote supports adding constitutional language designating English as the official language of
                /// Idaho.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.EnglishLanguagePolicy)]
                public static class HJR6 { }

                /// <summary>
                /// Asks voters to choose the official state gun of Idaho. Options:
                /// 1. <see cref="IdahoPotentialStateGuns.WinchesterModel1894"/>: Winchester Model 1894 (.30-30)
                /// 2. <see cref="IdahoPotentialStateGuns.WinchesterModel1873"/>: Winchester Model 1873 "Gun that Won the West" (.44-40)
                /// 3. <see cref="IdahoPotentialStateGuns.ColtSingleActionArmyRevolver1873"/>: 1873 Colt Single Action Army Revolver "Peacemaker" (.45 Colt)
                /// 4. <see cref="IdahoPotentialStateGuns.M1Garand"/>: M1 Garand rifle (.30-06)
                /// 5. <see cref="IdahoPotentialStateGuns.ColtM1911"/>: Colt M1911 .45 automatic Colt pistol (.45 ACP)
                /// 6. <see cref="IdahoPotentialStateGuns.RemingtonModel700"/>: Remington Model 700 bolt-action rifle (.30-06)
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRAQ)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.StateFlagsSymbolsAndHolidays)]
                [IRootedFor((int)IdahoPotentialStateGuns.RemingtonModel700, "More Idahoans actually use this (looking past the company's history)")]
                public static class OfficialStateGunQuestion { }

                /// <summary>
                /// A "yes" vote supports providing, in statute, that people have a right to reproductive freedom and
                /// privacy, defined as "the right to make and carry out one's own reproductive decisions".
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [IRootedForYesBallotInitiative("Generally I think abortion should be legal")]
                [IPredictedNoBallotInitiative(Correctness.Future, "But this is too liberal for Idaho as it stands, even just as a statute, not a constitutional amendment, even in a good Democratic year")]
                public static class Proposition1 { }
            }
        }

        public static class Indiana
        {
            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports providing for the denial of bail when the accused is found to pose a substantial
                /// risk to another person.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.CriminalTrials, BallotInitiativeSubjects.BailPolicy)]
                public static class PublicQuestion1 { }

                /// <summary>
                /// A "yes" vote supports requiring city and town court judges to reside in either the county where the court
                /// is located or the bordering county closest to the court.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.StateJudicialSelection, BallotInitiativeSubjects.LocalGovernmentOfficialsAndElections)]
                public static class PublicQuestion2 { }
            }
        }

        public static class Iowa
        {
            public static class v2024
            {
                /// <summary>
                /// A "yes" vote supported prohibiting local governments from allowing noncitizens to vote by providing in the state constitution that only a citizen 
                /// of the U.S., rather than every citizen of the U.S., can vote; and supported allowing 17-year-olds who will be 18 by the general election to vote 
                /// in primary elections.
                /// Result:
                /// Yes: 1,150,332 77.13%
                /// No :   341,034 22.87%
                /// </summary>
                [YearDate(2024, 11, 5)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                [BallotMeasurePassFail(true)]
                public static class Amendment1 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports requiring a two-thirds vote of both legislative chambers to pass a bill that would
                /// increase the individual or corporate income tax rate.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.IncomeTaxes, BallotInitiativeSubjects.StateLegislativeVoteRequirements)]
                public static class Amendment1 { }
            }
        }

        public static class Kansas
        {
            public static class v2022
            {
                /// <summary>
                /// A "yes" vote supported amending the Kansas Constitution to:
                /// 1. State that nothing in the state constitution creates a right to abortion or
                /// requires government funding for abortion and
                /// 2. state that the legislature has the authority to pass laws regarding abortion.
                /// Result:
                /// No :  543,855 58.97%
                /// Yes:  378,466 41.03%
                /// </summary>
                [YearDate(2022, 8, 2)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(false)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                public static class NoStateConstitutionalRightToAbortionAndLegislativePowerToRegulateAbortionAmendment { }
            }

            public static class v2026
            {
                [YearDate(2026, 8, 4)]
                public static class August
                {
                    /// <summary>
                    /// A "yes" vote supported making the Kansas Supreme Court an elected office and abolishing the court's
                    /// nominating commission.
                    /// Result:
                    /// No : 382,118 61.36%
                    /// Yes: 240,603 38.64%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.StateJudicialSelection)]
                    [BallotMeasurePassFail(false)]
                    public static class ElectionsForSupremeCourtJusticesAmendment { }
                }

                [YearDate(2026, 11, 3)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supports amending the state constitution to state that only a citizen of the United States
                    /// is eligible to vote.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                    [BallotMeasurePassFail(true)]
                    public static class CitizenshipVotingRequirementAmendment { }
                }
            }
        }

        public static class Kentucky
        {
            public static class v2022
            {
                /// <summary>
                /// A "yes" vote supported amending the Kentucky Constitution to state that nothing 
                /// in the state constitution creates a right to abortion or requires government 
                /// funding for abortion.
                /// Result:
                /// No : 742,232
                /// Yes: 675,634
                /// </summary>
                [YearDate(2022, 11, 8)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(false)]
                public static class ConstitutionalAmendment2 { }
            }

            public static class v2024
            {
                /// <summary>
                /// A "yes" vote supported amending the constitution to require U.S. citizenship to be able to vote in the state.
                /// Result:
                /// Yes: 1,208,898 62.43%
                /// No :   727,515 37.57%
                /// </summary>
                [YearDate(2024, 11, 5)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                public static class ConstitutionalAmendment1 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports prohibiting the governor from issuing a pardon or commuting a sentence 60 days
                /// prior to the gubernatorial election and until after the fifth Tuesday succeeding the election.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PardonsAndCommutations)]
                public static class ConstitutionalAmendment1 { }
            }
        }

        public static class Louisiana
        {
            public static class v2020
            {
                /// <summary>
                /// A "yes" vote supported adding language to the Louisiana Constitution stating that 
                /// "nothing in this constitution shall be construed to secure or protect a right to 
                /// abortion or require the funding of abortion."
                /// Result:
                /// Yes: 1,274,167 62.06%
                /// No :   779,005 37.94%
                /// </summary>
                [YearDate(2020, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Amendment1 { }
            }
            public static class v2022
            {
                [YearDate(2022, 11, 8)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supported adopting the following changes to property tax exemptions for certain disabled veterans and their surviving spouses:
                    /// 1. after the first $7,500 homestead property tax exemption, exempting the next $2,500 of assessed value from property taxes for veterans with a 
                    /// service-related disability rating of 50% or more but below 70%;
                    /// 2. after the first $7,500 homestead property tax exemption, exempting the next $4,500 of assessed value from property taxes for veterans with a 
                    /// service-related disability rating of 70% or more but below 100%;
                    /// 3. exempting the total assessed value from property taxes for veterans that are totally disabled or that are 100% unemployable; and
                    /// 4. extending the property tax exemptions to the surviving spouse of a deceased disabled veteran whether or not the exemption was claimed on the 
                    /// property prior to the veteran's death.
                    /// Result:
                    /// Yes: 973,937 72.94%
                    /// No : 361,378 27.06%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment2 { }

                    /// <summary>
                    /// A "yes" vote supported allowing local governments to waive water charges for customers if water is lost due to water delivery infrastructure 
                    /// damages that were not caused by the customer's actions or the customer's failure to act.
                    /// Result:
                    /// Yes: 994,361 74.95%
                    /// No : 332,306 25.05%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment4 { }

                    /// <summary>
                    /// A "yes" vote supported removing the requirement to annually recertify income for homeowners that are permanently and totally disabled in 
                    /// order to keep their special assessment level for property taxes.
                    /// Result:
                    /// Yes: 717,702 54.72%
                    /// No : 593,863 45.28%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment8 { }
                }

                [YearDate(2022, 12, 10)]
                public static class December
                {
                    /// <summary>
                    /// A "yes" vote supported amending the Louisiana Constitution to provide that "No person who is not a citizen of the United States shall be allowed to register and vote 
                    /// in this state."
                    /// Result:
                    /// Yes: 314,678 73.44%
                    /// No : 113.808 26.56%
                    /// </summary>
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment1 { }

                    /// <summary>
                    /// A "yes" vote supported requiring senate confirmation of State Civil Service Commission appointees after they are appointed by the governor.
                    /// Result:
                    /// Yes: 300,635 70.92%
                    /// No : 123,250 29.08%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment2 { }

                    /// <summary>
                    /// A "yes" vote supported requiring Senate confirmation of State Police Commission appointees after they are appointed by the governor.
                    /// Result:
                    /// Yes: 305,007 72.01%
                    /// No : 118,538 27.99%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment3 { }
                }
            }

            public static class v2023
            {
                [YearDate(2023, 10, 14)]
                public static class October
                {
                    /// <summary>
                    /// A "yes" vote supported prohibiting state and local governments from using funds, goods, and services donated by foreign governments or 
                    /// nongovernmental (private) sources for the purpose of conducting elections.
                    /// Result:
                    /// Yes: 734,324 72.57%
                    /// No : 277,564 27.43%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment1 { }

                    /// <summary>
                    /// A "yes" vote supported:
                    /// 1. providing in the state constitution that "the freedom to worship in a church or other place of worship is a fundamental right that is 
                    /// worthy of the highest order of protection;" and
                    /// 2. providing that a legal challenge brought against a state or a local government action for conflicting with the right would be required to be 
                    /// examined by a court with strict scrutiny.
                    /// Result:
                    /// Yes: 805,676 79.20%
                    /// No : 211,621 20.80%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment2 { }

                    /// <summary>
                    /// A "yes" vote supported requiring a minimum of 25% of state revenue that is designated as nonrecurring  to be applied to the balance of the 
                    /// unfunded liability of the state retirement system.
                    /// Result:
                    /// Yes: 559,540 56.16%
                    /// No : 436,717 43.84%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment3 { }

                    /// <summary>
                    /// A "yes" vote supported prohibiting a nonprofit organization from receiving a property tax exemption if they own residential property that is in 
                    /// such a state of disrepair that it is dangerous to the public's health or safety, as determined by the governing authority of the municipality or 
                    /// parish the property is located in.
                    /// Result:
                    /// Yes: 661,332 66.00%
                    /// No : 340,632 34.00%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment4 { }
                }
                [YearDate(2023, 11, 18)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supported providing that:
                    /// 1. the governor's deadline to act on a bill is based on the legislative session in which the bill was passed rather than whether or not the 
                    /// legislature is in session; and
                    /// 2. the legislature may consider vetoed bills during a regular or extraordinary session rather than convening a separate veto session.
                    /// Result:
                    /// Yes: 387,207 61.03%
                    /// No : 247,266 38.97%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment1 { }

                    /// <summary>
                    /// A "yes" vote supported repealing constitutional provisions establishing various state funds that are now inactive and allows for remaining 
                    /// money in the funds to be transferred to the state general fund.
                    /// Result:
                    /// Yes: 346,766 54.70%
                    /// No : 287,211 45.30%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment2 { }

                    /// <summary>
                    /// A "yes" vote supported authorizing local governments to provide an additional property tax exemption of up to $2,500 for first responders 
                    /// including fire fighters, emergency medical service personnel, emergency response dispatchers, peace officers, police officers, and sheriffs.
                    /// Result:
                    /// Yes: 338,823 53.00%
                    /// No : 300,477 47.00%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment3 { }

                    /// <summary>
                    /// A "yes" vote supported allowing the state legislature, through a two-thirds supermajority vote, to use up to $250 million of funds in the 
                    /// Revenue Stabilization Trust Fund to alleviate a budget deficit.
                    /// Result:
                    /// No : 353,622 55.99%
                    /// Yes: 278,009 44.01%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(false)]
                    public static class Amendment4 { }
                }
            }

            public static class v2024
            {
                [YearDate(2024, 11, 5)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supported requiring federal revenue received from alternative and renewable energy production in the Outer Continental Shelf (OCS) 
                    /// to be deposited in the Coastal Protection and Restoration Fund.
                    /// Result:
                    /// Yes: 1,367,876 73.10%
                    /// No :   503,275 26.90%
                    /// </summary>
                    [BallotMeasurePassFail(true)]
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    public static class OuterContinentalShelfRevenuesForCoastalProtectionAndRestorationFundAmendment { }
                }
                [YearDate(2024, 12, 7)]
                public static class December
                {
                    /// <summary>
                    /// A "yes" vote supported:
                    /// 1. increasing the membership of the judiciary commission by five members;
                    /// 2. adding malfeasance while in office to the list of specific actions that the state supreme court can pursue disciplinary action against a 
                    /// judge; and
                    /// 3. providing that the judiciary commission is responsible for investigating and recommending disciplinary actions.
                    /// Result:
                    /// Yes: 176,864 53%
                    /// No : 155,252 47%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment1 { }

                    /// <summary>
                    /// A "yes" vote supported prohibiting the consideration of a conference committee report or senate amendments on an appropriations bill until 
                    /// 48 hours after the bill and a summary of the proposed changes is distributed to all legislators.
                    /// Result:
                    /// Yes: 219,103 66%
                    /// No : 112,938 34%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment2 { }

                    /// <summary>
                    /// A  "yes" vote supported allowing the state legislature to extend its regular session by two-day increments, up to a maximum of six days, 
                    /// in order to pass a bill appropriating money.
                    /// Result:
                    /// Yes: 191,729 58%
                    /// No : 140,452 42%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment3 { }

                    /// <summary>
                    /// A "yes" vote supported:
                    /// 1. authorizing the state legislature to provide for property tax sales in state law;
                    /// 2. providing that tax payment postponements can only be granted during emergencies declared by the governor under the Louisiana Homeland Security
                    /// and Emergency Assistance and Disaster Act; and
                    /// 3. allowing the state legislature to give tax collectors the authority to waive penalties for good cause.
                    /// Result:
                    /// Yes: 180,856 55%
                    /// No : 150,423 45%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment4 { }
                }
            }

            public static class v2025
            {
                [YearDate(2025, 3, 29)]
                public static class March
                {
                    /// <summary>
                    /// A "yes" vote supports this constitutional amendment to: 
                    /// 1. provide the Louisiana Supreme Court with original jurisdiction to discipline out-of-state lawyers, not just members of the state bar, and
                    /// 2. allow the state legislature to establish trial courts with limited or specialized jurisdiction, such as business courts, through a 
                    /// two-thirds vote in both the House and Senate.
                    /// </summary>
                    [TODO("result")]
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    public static class Amendment1 { }

                    /// <summary>
                    /// A "yes" vote supports amending the state constitution concerning taxes and the state budget, including the following:
                    /// 1. reduce the maximum income tax rate;
                    /// 2. increase income tax deductions for individuals 65 and older;
                    /// 3. establish a government growth limit; and
                    /// 4. provide a permanent increase to teacher salaries by requiring a surplus payment to teacher retirement debt.
                    /// </summary>
                    [TODO("result")]
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    public static class Amendment2 { }

                    /// <summary>
                    /// A "yes" vote supports allowing the state legislature to determine in state law which specific felony crimes can result in a juvenile being 
                    /// tried as an adult.
                    /// </summary>
                    [TODO("result")]
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    public static class Amendment3 { }

                    /// <summary>
                    /// A "yes" vote supports providing that judicial vacancies should be filled in a special election at earliest available date pursuant to state law, 
                    /// and shall be held at the next gubernatorial or congressional election if the election is within twelve months of the date the vacancy occurred, 
                    /// rather than current law, which provides for calling a special election within 12 months after the day the vacancy occurs.
                    /// </summary>
                    [TODO("result")]
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    public static class Amendment4 { }
                }
            }

            public static class v2026
            {
                [YearDate(2026, 5, 16)]
                public static class May
                {
                    /// <summary>
                    /// A "yes" vote supported allowing the legislature to add officers, positions, and employees to the
                    /// unclassified civil service.
                    /// Result:
                    /// No : 630,337 78.42%
                    /// Yes: 173,487 21.58%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.StateLegislativeAuthority, BallotInitiativeSubjects.CivilService)]
                    [BallotMeasurePassFail(false)]
                    public static class Amendment1 { }

                    /// <summary>
                    /// A "yes" vote supported adding the St. George Community School System to the list of school
                    /// systems that are regarded and treated as parishes for purposes of operating a school system.
                    /// Result:
                    /// No : 511,787 64.02%
                    /// Yes: 287,614 35.98%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.LocalGovernmentOrganization, BallotInitiativeSubjects.PublicEducationGovernance)]
                    [BallotMeasurePassFail(false)]
                    public static class Amendment2 { }

                    /// <summary>
                    /// A "yes" vote supported repealing the three education revenue funds and applying that money to
                    /// the Teachers' Retirement System.
                    /// Result:
                    /// No : 470,837 58.04%
                    /// Yes: 340,362 41.96%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicSchoolTeachersAndStaff, BallotInitiativeSubjects.PublicEmployeeRetirementFunds, BallotInitiativeSubjects.RestrictedUseFunds)]
                    [BallotMeasurePassFail(false)]
                    public static class Amendment3 { }

                    /// <summary>
                    /// A "yes" vote supported allowing parishes to exempt business inventory from property taxes.
                    /// Result:
                    /// No : 530,799 66.08%
                    /// Yes: 272,515 33.92%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.LocalGovernmentFinanceAndTaxes, BallotInitiativeSubjects.PropertyTaxExemptions)]
                    [BallotMeasurePassFail(false)]
                    public static class Amendment4 { }

                    /// <summary>
                    /// A "yes" vote supported increasing the judicial retirement age from 70 to 75.
                    /// Result:
                    /// No : 618,097 76.61%
                    /// Yes: 188,765 23.39%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.AgeLimitsForOfficials)]
                    [BallotMeasurePassFail(false)]
                    public static class Amendment5 { }
                }

                [YearDate(2026, 11, 3)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supports allowing the surviving spouse of a disabled veteran to transfer the
                    /// homestead property tax exemption one time to a new homestead.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.HomesteadTaxExemptions, BallotInitiativeSubjects.PropertyTaxExemptions, BallotInitiativeSubjects.VeteransPolicy)]
                    public static class Amendment1 { }

                    /// <summary>
                    /// A "yes" vote supports authorizing taxing authorities to levy a millage at a rate above the rate
                    /// set by the previous year's assessment of the maximum amount of taxable property within each
                    /// parish, but below the maximum permitted by the state constitution.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PropertyTaxes, BallotInitiativeSubjects.StateLegislativeAuthority)]
                    public static class Amendment2 { }

                    /// <summary>
                    /// A "yes" vote supports prohibiting post-conviction bail for a defendant who is convicted of an
                    /// aggravated offense against a victim who is a minor.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.CriminalSentencing, BallotInitiativeSubjects.BailPolicy)]
                    public static class Amendment3 { }

                    /// <summary>
                    /// A "yes" vote supports changing the gubernatorial term limit from two consecutive terms to a
                    /// lifetime maximum of two terms.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.ExecutiveOfficialTermLimits)]
                    public static class Amendment4 { }

                    /// <summary>
                    /// A "yes" vote supports removing the requirement that a state retirement system receiving
                    /// nonrecurring state funds apply those funds to its oldest outstanding unfunded accrued liability
                    /// first.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicEmployeeRetirementFunds)]
                    public static class Amendment5 { }

                    /// <summary>
                    /// A "yes" vote supports authorizing a property tax exemption of up to $30,000 of assessed property
                    /// value, increasing with age, for homeowners 65 and older who qualify for the income-based
                    /// assessment freeze.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PropertyTaxes, BallotInitiativeSubjects.HomesteadTaxExemptions, BallotInitiativeSubjects.PropertyTaxExemptions)]
                    public static class Amendment6 { }

                    /// <summary>
                    /// A "yes" vote supports authorizing the use of public funds for the maintenance of drinking water
                    /// utility service lines affected by hazardous materials on property owned by utility customers.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.LocalGovernmentFinanceAndTaxes, BallotInitiativeSubjects.DrinkingWaterSystems, BallotInitiativeSubjects.PollutionWasteAndRecyclingPolicy)]
                    public static class Amendment7 { }

                    /// <summary>
                    /// A "yes" vote supports prohibiting expropriation of property by foreign adversaries or agents of
                    /// a foreign adversary, as defined by law.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.EminentDomainPolicy)]
                    public static class Amendment8 { }

                    /// <summary>
                    /// A "yes" vote supports raising the income limit to qualify for the property tax special
                    /// assessment level from $100,000 to $150,000.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PropertyTaxExemptions, BallotInitiativeSubjects.HomesteadTaxExemptions)]
                    public static class Amendment9 { }

                    /// <summary>
                    /// A "yes" vote supports authorizing a tax exemption for derelict or blighted property that has
                    /// been rehabilitated.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PropertyTaxExemptions, BallotInitiativeSubjects.PropertyTaxes)]
                    public static class Amendment10 { }
                }
            }
        }

        public static class Maine
        {
            public static class v2016
            {
                /// <summary>
                /// A "yes" vote supported adopting ranked-choice voting for congressional, state legislative, and 
                /// gubernatorial elections.
                /// Result:
                /// Yes: 388,273 52.12%
                /// No : 356,621 47.88%
                /// </summary>
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [YearDate(2016, 11, 8)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RankedChoiceVoting)]
                [BallotMeasurePassFail(true)]
                public static class Question5 { }
            }

            public static class v2018
            {
                /// <summary>
                /// A "yes" vote was a vote to overturn sections of Legislative Document 1646 (LD 1646), which was 
                /// written to postpone and repeal ranked-choice voting (RCV) unless a constitutional amendment was 
                /// passed before December 1, 2021, to enable the legislature to determine election methods.
                /// Result:
                /// Yes: 149,900 53.88%
                /// No : 128,291 46.12%
                /// </summary>
                [Observation("This kept ranked choice voting in place.")]
                [BallotMeasureType(BallotMeasureTypes.VR)]
                [YearDate(2018, 6, 12)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RankedChoiceVoting)]
                [BallotMeasurePassFail(true)]
                public static class Question1 { }
            }
        }

        public static class Maryland
        {
            public static class v1992
            {
                /// <summary>
                /// A "yes" vote was to uphold the contested legislation, Senate Bill 162, which said 
                /// "the state may not interfere with the decision of a woman to terminate a pregnancy" 
                /// before fetal viability.
                /// Result:
                /// Yes: 1,114,377 61.74%
                /// No :   690,542 38.26%
                /// </summary>
                [YearDate(1992, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.VR)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Question6 { }
            }

            public static class v2024
            {
                /// <summary>
                /// A "yes" vote supported adding a new article to the Maryland Constitution's Declaration of Rights 
                /// establishing a right to reproductive freedom, defined to include "the ability to make and 
                /// effectuate decisions to prevent, continue, or end one's own pregnancy."
                /// Result:
                /// Yes: 2,199,319 76.06%
                /// No :   692,219 23.94%
                /// </summary>
                [YearDate(2024, 11, 5)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Question1 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports requiring the budget submitted by the governor to provide for expenditures for
                /// wages, hours, benefits, and other terms and conditions of employment provided by a memorandum of
                /// understanding that covers state employees, and providing for statutory changes to collective
                /// bargaining for state employees, including requiring the selection of a neutral arbitrator and
                /// establishing a process of arbitration.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicWorksLaborAndContracting, BallotInitiativeSubjects.LaborDisputesAndStrikes, BallotInitiativeSubjects.CollectiveBargaining)]
                public static class Question1 { }

                /// <summary>
                /// A "yes" vote supports allowing the chair of the Commission on Judicial Disabilities to appoint
                /// former members to temporarily fill vacancies, or allowing the governor to appoint a substitute
                /// member or extend the term of an existing member.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.StateJudiciaryOversight)]
                public static class Question2 { }

                /// <summary>
                /// A "yes" vote supports providing that constitutional requirements for legislative districts apply
                /// only to state legislative districts and not to congressional districts.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RedistrictingPolicy)]
                public static class Question3 { }
            }
        }

        public static class Massachusetts
        {
            public static class v2020
            {
                /// <summary>
                /// A "yes" vote supported enacting ranked-choice voting (RCV) for primary and general elections for
                /// state executive officials, state legislators, federal congressional and senate seats, and certain 
                /// county offices beginning in 2022.
                /// Result:
                /// No : 1,877,447 54.78%
                /// Yes: 1,549,919 45.22%
                /// </summary>
                [YearDate(2020, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RankedChoiceVoting)]
                [BallotMeasurePassFail(false)]
                public static class Question2 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports making records held by the state legislature and the governor's office public
                /// records.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.OpenMeetingsAndPublicInformation)]
                public static class Question1 { }

                /// <summary>
                /// A "yes" vote supports permitting employees of the Committee for Public Counsel Services (CPCS) to
                /// participate in collective bargaining.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.CollectiveBargaining)]
                public static class Question2 { }

                /// <summary>
                /// A "yes" vote supports eliminating political party primaries for state elections and creating a
                /// single primary where candidates are listed regardless of their political party.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections)]
                public static class Question3 { }

                /// <summary>
                /// A "yes" vote supports providing for same-day voter registration.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.VoterRegistration)]
                public static class Question4 { }

                /// <summary>
                /// A "yes" vote supports changing the limit on how much revenue the state can collect in a given year.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RevenueAndSpendingLimits)]
                public static class Question5 { }

                /// <summary>
                /// A "yes" vote supports creating a fund for state money, titled the Nature for All Fund, to be used to
                /// further nature conservation efforts.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RevenueAllocation, BallotInitiativeSubjects.ParksLandAndNaturalAreaConservation, BallotInitiativeSubjects.RestrictedUseFunds)]
                public static class Question6 { }

                /// <summary>
                /// A "yes" vote supports requiring cities and towns to allow single-family homes on residentially zoned
                /// lots of at least 5,000 square feet that meet minimum standards.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.LandUseAndDevelopmentPolicy)]
                public static class Question7 { }

                /// <summary>
                /// A "yes" vote supports repealing the laws that permit the sale of recreational marijuana and the
                /// personal cultivation of cannabis in homes.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.MarijuanaLaws, BallotInitiativeSubjects.DrugCrimePolicy)]
                public static class Question8 { }

                /// <summary>
                /// A "yes" vote supports upholding An Act Modernizing Firearm Laws (H. 4885), passed in 2024.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.VR)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.FirearmsPolicy)]
                public static class Question9 { }
            }
        }

        public static class Michigan
        {
            public static class v2022
            {
                /// <summary>
                /// A "yes" vote supported providing a state constitutional right to reproductive 
                /// freedom, which is defined as "the right to make and effectuate decisions about 
                /// all matters relating to pregnancy, including but not limited to prenatal care, 
                /// childbirth, postpartum care, contraception, sterilization, abortion care, 
                /// miscarriage management, and infertility care."
                /// Result:
                /// Yes:  2,482,382 56.66%
                /// No :  1,898,906 43.34%
                /// </summary>
                [YearDate(2022, 11, 8)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Proposal3 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports holding a state constitutional convention.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.ACCQ)]
                [BallotMeasurePassFail(false)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.StateConstitutionalConventions)]
                public static class Proposal1 { }

                /// <summary>
                /// A "yes" vote supports prohibiting certain regulated electric and gas utilities, government
                /// contractors with more than $250,000 annually in government contracts, and certain associated
                /// individuals and organizations from making specified campaign contributions, and expanding campaign
                /// finance requirements to cover additional public communications about candidates or ballot questions,
                /// including certain communications that do not expressly advocate voting for or against them.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotMeasurePassFail(true)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.CampaignFinance)]
                public static class Proposal2 { }
            }
        }

        public static class Minnesota
        {
            public static class v2012
            {
                /// <summary>
                /// A "yes" vote supported amending the Minnesota Constitution to require voters to present a valid 
                /// photo ID when voting in person or government-issued proof of identity when voting by other methods.
                /// Result:
                /// No : 1,539,044 53.05%
                /// Yes: 1,362,009 46.95%
                /// </summary>
                [YearDate(2012, 11, 6)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIdentificationNeededForVoting)]
                [BallotMeasurePassFail(false)]
                public static class Amendment2 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports changing the administrative policies for investing and distributing the
                /// Minnesota Permanent School Fund.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicEducationFunding, BallotInitiativeSubjects.RestrictedUseFunds)]
                public static class AlterInvestmentAndDistributionPoliciesForPermanentSchoolFundAmendment { }
            }
        }

        public static class Mississippi
        {
            public static class v2011
            {
                /// <summary>
                /// require a person to submit government issued photo identification in order to vote
                /// Result:
                /// Yes: 538,656 62.07%
                /// No : 329,105 37.93%
                /// </summary>
                [YearDate(2011, 11, 8)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIdentificationNeededForVoting)]
                [BallotMeasurePassFail(true)]
                public static class Initiative27 { }
            }
        }

        public static class Missouri
        {
            public static class v2016
            {
                /// <summary>
                /// A "yes" vote supported allowing the state government to require the presentation of voter 
                /// IDs at public elections in order to prove national and state citizenship.
                /// Result:
                /// Yes: 1,712,274 63.01%
                /// No : 1,005,234 36.99%
                /// </summary>
                [YearDate(2016, 11, 8)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.IdentificationNeededForVoting)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                public static class Amendment6 { }
            }

            public static class v2024
            {
                [YearDate(2024, 11, 5)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supported adding a fundamental right to reproductive freedom, defined to include 
                    /// abortion and “all matters relating to reproductive health care,” to the Missouri Constitution, 
                    /// among other provisions.
                    /// Result: 
                    /// Yes: 1,538,659 51.60%
                    /// No : 1,443,022 48.40%
                    /// </summary>
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment3 { }

                    /// <summary>
                    /// A "yes" vote supported amending the state constitution to:
                    /// 1. provide that only U.S.citizens 18 years or older can vote, thereby prohibiting the 
                    /// state or local governments from allowing non-citizen voting;
                    /// 2. establish that each voter has one vote per issue or open seat;
                    /// 3. prohibit ranked-choice voting; and
                    /// 4. require plurality primary elections, where one winner advances to the general election.
                    /// Result:
                    /// Yes: 1,966,852 68.44%
                    /// No :   906,851 31.56%
                    /// </summary>
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections, BallotInitiativeSubjects.RankedChoiceVoting, BallotInitiativeSubjects.NonCitizenVoting)]
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment7 { }
                }
            }

            public static class v2026
            {
                [YearDate(2026, 8, 4)]
                public static class August
                {
                    /// <summary>
                    /// A "yes" vote supported renewing the existing sales and use tax of 0.1% for 10 years to fund
                    /// state parks and soil and water conservation.
                    /// Result:
                    /// Yes: 1,141,865 82.29%
                    /// No : 245,778 17.71%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.ABR)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.SalesTaxes, BallotInitiativeSubjects.ParksLandAndNaturalAreaConservation)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment1 { }

                    /// <summary>
                    /// A "yes" vote supported requiring the Jackson County Assessor to be an elected position.
                    /// Result:
                    /// Yes: 1,042,413 76.92%
                    /// No : 312,713 23.08%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.LocalGovernmentOfficialsAndElections)]
                    [BallotMeasurePassFail(true)]
                    public static class Amendment2 { }

                    /// <summary>
                    /// A "yes" vote supported requiring the majority of voters from each congressional district to
                    /// approve initiative petitions to amend the constitution, and prohibiting foreign nationals from
                    /// contributing to ballot measure campaigns, among other provisions.
                    /// Result:
                    /// No : 1,122,748 80.32%
                    /// Yes: 275,040 19.68%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.CampaignFinance, BallotInitiativeSubjects.BallotMeasureSupermajorityRequirements)]
                    [BallotMeasurePassFail(false)]
                    public static class Amendment4 { }

                    /// <summary>
                    /// A "yes" vote supported phasing out the individual income tax based on revenue growth and making
                    /// other tax-related changes.
                    /// Result:
                    /// No : 1,165,085 83.28%
                    /// Yes: 233,965 16.72%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.IncomeTaxes, BallotInitiativeSubjects.SalesTaxes)]
                    [BallotMeasurePassFail(false)]
                    public static class Amendment5 { }
                }

                [YearDate(2026, 11, 3)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supports prohibiting abortion in most cases, and prohibiting gender transition
                    /// procedures for minors under eighteen. Would largely reverse <see
                    /// cref="v2024.November.Amendment3"/>.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.SexAndGenderIssues, BallotInitiativeSubjects.Abortion, BallotInitiativeSubjects.ConstitutionalRights, BallotInitiativeSubjects.LGBTQIssues, BallotInitiativeSubjects.HealthcareGovernance)]
                    [IPredictedNoBallotInitiative(Correctness.Correct, "Adding gender transition procedures is too aggressive, and this is a good Democratic year")]
                    [TODO("Need hindsight correctness on this")]
                    [IPutThumbOnTheScaleForNoBallotInitiative(ThumbOnTheScaleAmount.Half, ThumbOnTheScaleImportance.High, "Reversing this would be a backslide")]
                    [BallotMeasurePassFail(false)]
                    public static class Amendment3 { }

                    /// <summary>
                    /// A "yes" vote supports prohibiting the legislature from repealing or amending a citizen
                    /// initiative unless at least 80% of both the House and Senate vote to refer a proposed change to
                    /// the ballot and voters then approve the change, and prohibiting the legislature from making
                    /// changes to the citizen initiative and referendum process, among other changes.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.BallotInitiatives)]
                    public static class Amendment6 { }

                    /// <summary>
                    /// A "yes" vote supports creating a permanent public endowment fund managed by the state to
                    /// generate revenue, and using the earnings to eliminate state-imposed taxes when sufficient to
                    /// replace them.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.TaxAndRevenueAdministration, BallotInitiativeSubjects.RestrictedUseFunds)]
                    public static class Amendment7 { }

                    /// <summary>
                    /// A "yes" vote supports requiring the election of county sheriffs.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.LocalGovernmentOfficialsAndElections, BallotInitiativeSubjects.LawEnforcementOfficersAndDepartments)]
                    public static class Amendment8 { }

                    /// <summary>
                    /// A "yes" vote supports upholding House Bill 1, which provided for new congressional districts (a
                    /// "no" vote repeals it).
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.VR)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.MidCycleRedistricting)]
                    [BallotMeasurePassFail(false)]
                    public static class PropositionA { }
                }
            }
        }

        public static class Montana
        {
            public static class v2024
            {
                [YearDate(2024, 11, 5)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supported creating a top-four primary system for elections for governor, 
                    /// lieutenant governor, state executives, state legislators, and congressional offices, in 
                    /// which all candidates would run in one primary and the top-four vote getters would advance 
                    /// to the general election regardless of party.
                    /// Result:
                    /// No : 300,664 51.09%
                    /// Yes: 287,837 48.91%
                    /// </summary>
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections)]
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotMeasurePassFail(false)]
                    public static class CitizenInitiative126 { }

                    /// <summary>
                    /// A "yes" vote supported requiring that candidates for the following offices must receive a 
                    /// majority of votes (instead of just a plurality) to win the election, as specified by law: 
                    /// governor, lieutenant governor, secretary of state, auditor, attorney general, superintendent 
                    /// of public instruction, state legislature, and Congress.
                    /// Result:
                    /// No : 348,805 60.38%
                    /// Yes: 228,908 39.62%
                    /// </summary>
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections)]
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotMeasurePassFail(false)]
                    public static class CitizenInitiative127 { }

                    /// <summary>
                    /// A "yes" vote supported amending the Montana Constitution to:
                    /// 1. Provide a state constitutional "right to make and carry out decisions about one’s own pregnancy, 
                    /// including the right to abortion"
                    /// 2. allow the state to regulate abortion after fetal viability, except when "medically indicated 
                    /// to protect the life or health of the pregnant patient."
                    /// Result:
                    /// Yes: 345,070 57.76%
                    /// No : 252,300 42.24%
                    /// </summary>
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotMeasurePassFail(true)]
                    public static class CitizenInitiative128 { }
                }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports adding a new section to the Montana Constitution to require that all judicial
                /// elections are nonpartisan.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.StateJudicialSelection)]
                public static class CitizenInitiative132 { }

                /// <summary>
                /// A "yes" vote supports adding the power of initiative and referendum to the state's Declaration of
                /// Rights, giving constitutional protection to initiative and referendum.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BallotInitiatives)]
                public static class CitizenInitiative133 { }

                /// <summary>
                /// A "yes" vote supports prohibiting artificial persons, as defined in the initiative, from
                /// contributing to campaigns, ballot measure elections, or political parties.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BusinessRegulations, BallotInitiativeSubjects.CampaignFinance)]
                public static class Initiative194 { }
            }
        }

        public static class Nebraska
        {
            public static class v2022
            {
                /// <summary>
                /// A "yes" vote supported amending the state constitution to require valid photo identification in 
                /// order to vote and authorize the state legislature to pass laws to specify the photo identification 
                /// requirements.
                /// Result:
                /// Yes: 432,028 65.45%
                /// No : 228,031 34.55%
                /// </summary>
                [YearDate(2022, 11, 8)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIdentificationNeededForVoting)]
                [BallotMeasurePassFail(true)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                public static class Initiative432 { }
            }

            public static class v2024
            {
                [YearDate(2024, 11, 5)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supported amending the state constitution to prohibit abortions after the first 
                    /// trimester unless necessitated by a medical emergency or the pregnancy is a result of sexual
                    /// assault or incest.
                    /// Result:
                    /// Yes: 509,288 54.94%
                    /// No : 417,624 45.06%
                    /// </summary>
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotMeasurePassFail(true)]
                    public static class Initiative434 { }

                    /// <summary>
                    /// A "yes" vote supported amending the state constitution to establish a right to abortion until 
                    /// fetal viability.
                    /// Result:
                    /// No : 473,652 50.99%
                    /// Yes: 455,184 49.01%
                    /// </summary>
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotMeasurePassFail(false)]
                    public static class Initiative439 { }
                }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports changing the legislative term limit from two consecutive four-year terms to
                /// three.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.StateLegislativeTermLimits)]
                [BallotMeasurePassFail(false)]
                public static class ConstitutionalAmendment1 { }

                /// <summary>
                /// A "yes" vote supports authorizing laws to govern sports betting.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.GamblingPolicy)]
                public static class Initiative440 { }

                /// <summary>
                /// A "yes" vote supports authorizing online sports betting in the state and authorizing the state
                /// gaming commission to adopt rules and regulations governing the gaming operators.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.GamblingPolicy)]
                public static class Initiative441 { }

                /// <summary>
                /// A "yes" vote supports requiring schools to designate sports teams as male, female, or co-ed, and
                /// prohibiting male participation on female sports teams.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicEducationGovernance, BallotInitiativeSubjects.SexAndGenderIssues, BallotInitiativeSubjects.AthleticsAndSports, BallotInitiativeSubjects.LGBTQIssues)]
                public static class Initiative442 { }
            }
        }

        public static class Nevada
        {
            public static class v1990
            {
                /// <summary>
                /// A "yes" vote was to uphold NRS 442.250, a statute that permits abortion up to 24 
                /// weeks gestation, and prohibit the Legislature from amending or repealing 
                /// NRS 442.250 without sending the proposed changes to the ballot for voters to 
                /// decide. 
                /// Result:
                /// Yes: 200,645 63.47%
                /// No : 115,495 36.53%
                /// </summary>
                [YearDate(1990, 11, 6)]
                [BallotMeasureType(BallotMeasureTypes.VR)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Question7 { }
            }

            public static class v2022
            {
                /// <summary>
                /// A "yes" vote supported establishing open top-five primaries and ranked-choice voting for general 
                /// elections, which would apply to congressional, gubernatorial, state executive official, and state
                /// legislative elections.
                /// Result:
                /// Yes: 524,868 52.94%
                /// No : 466,635 47.06%
                /// </summary>
                [YearDate(2022, 11, 8)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections, BallotInitiativeSubjects.RankedChoiceVoting)]
                [BallotMeasurePassFail(true)]
                [RequiresAnotherSuccessfulVote(true)]
                public static class Question3 { }
            }

            public static class v2024
            {
                [YearDate(2024, 11, 5)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supported establishing open top-five primaries and ranked-choice voting for 
                    /// general elections, which would apply to congressional, gubernatorial, state executive official, 
                    /// and state legislative elections.
                    /// Result:
                    /// No : 747,719 52.96%
                    /// Yes: 664,011 47.04%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections, BallotInitiativeSubjects.RankedChoiceVoting)]
                    [BallotMeasurePassFail(false)]
                    public static class Question3 { }

                    /// <summary>
                    /// A "yes" vote supported providing for a state constitutional right to an abortion, providing 
                    /// for the state to regulate abortion after fetal viability, except where medically indicated to 
                    /// "protect the life or health of the pregnant patient."
                    /// Result:
                    /// Yes: 905,170 64.36%
                    /// No : 501,232 35.64%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                    [BallotMeasurePassFail(true)]
                    [RequiresAnotherSuccessfulVote(true)]
                    public static class Question6 { }

                    /// <summary>
                    /// A "yes" vote supported amending the constitution to require that Nevada residents present a 
                    /// form of photo identification to verify their identity while voting in person, or to verify 
                    /// their identity using the last four digits of their driver's license or social security number 
                    /// when voting by mail.
                    /// Result:
                    /// Yes: 1,031,153 73.23%
                    /// No :   376,873 26.77%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIdentificationNeededForVoting)]
                    [BallotMeasurePassFail(true)]
                    [RequiresAnotherSuccessfulVote(true)]
                    public static class Question7 { }
                }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports providing for a state constitutional right to abortion before fetal viability.
                /// This is the second vote, after <see cref="v2024.November.Question6"/> passed in 2024.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion, BallotInitiativeSubjects.ConstitutionalRights)]
                [IPredictedYesBallotInitiative(Correctness.Future, "Maintains the status quo (constitutional amendment > statute")]
                public static class Question6 { }

                /// <summary>
                /// A "yes" vote supports requiring voters to present photo identification when voting in person or to
                /// provide the last four digits of their driver's license or Social Security number when voting by mail.
                /// This is the second vote, after <see cref="v2024.November.Question7"/> passed in 2024.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIdentificationNeededForVoting)]
                public static class Question7 { }
            }
        }
       
        public static class NewHampshire
        {
            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports eliminating the office of the register of probate.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.AdministrativeOrganization)]
                public static class EliminateOfficeOfRegisterOfProbateAmendment { }
            }
        }

        public static class NewMexico
        {
            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports authorizing $30 million in general obligation bonds for senior citizen
                /// facility improvement, construction, and equipment acquisition projects, funded by a statewide
                /// property tax.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.BI)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BondIssues)]
                public static class BondQuestion1 { }

                /// <summary>
                /// A "yes" vote supports authorizing up to $20 million in general obligation bonds for academic, public
                /// school, tribal, and public library resource acquisitions, funded by a statewide property tax.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.BI)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BondIssues, BallotInitiativeSubjects.PublicEducationFunding)]
                public static class BondQuestion2 { }

                /// <summary>
                /// A "yes" vote supports authorizing up to $230 million in general obligation bonds for capital
                /// improvements and acquisitions at higher education institutions, special schools, and tribal schools,
                /// funded by a statewide property tax.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.BI)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.HigherEducationFunding, BallotInitiativeSubjects.PublicEducationFunding, BallotInitiativeSubjects.BondIssues)]
                public static class BondQuestion3 { }

                /// <summary>
                /// A "yes" vote supports requiring bills to become law if the governor does not sign or veto them
                /// within the required timeframe, eliminating the governor's pocket veto.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.StateExecutivePowersAndDuties)]
                public static class ConstitutionalAmendment1 { }

                /// <summary>
                /// A "yes" vote supports repealing the constitutional provision requiring that school elections be held
                /// at different times from partisan elections.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicEducationGovernance, BallotInitiativeSubjects.LocalGovernmentOfficialsAndElections)]
                public static class ConstitutionalAmendment2 { }

                /// <summary>
                /// A "yes" vote supports making changes to the Board of Regents, including establishing nominating
                /// committees to provide lists of candidates, providing that student members are appointed from a list
                /// provided by the student governing body, and prohibiting non-student members from changing political
                /// party in the 12 months preceding appointment.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.HigherEducationGovernance)]
                public static class ConstitutionalAmendment3 { }

                /// <summary>
                /// A "yes" vote supports establishing a salary for state legislators equal to the annual median
                /// household income of the state.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.SalariesOfGovernmentOfficials)]
                public static class ConstitutionalAmendment4 { }
            }
        }

        public static class NewYork
        {
            public static class v2024
            {
                /// <summary>
                /// A "yes" vote supported adding language to the New York Bill of Rights to provide that people 
                /// cannot be denied rights based on their "ethnicity, national origin, age, and disability" or 
                /// "sex, including sexual orientation, gender identity, gender expression, pregnancy, pregnancy 
                /// outcomes, and reproductive healthcare and autonomy."
                /// Result:
                /// Yes: 4,757,097 62.47%
                /// No : 2,857,663 37.53%
                /// </summary>
                [YearDate(2024, 11, 5)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Proposal1 { }
            }
        }

        public static class NorthCarolina
        {
            public static class v2018
            {
                /// <summary>
                /// A "yes" vote supported creating a constitutional requirement that voters present a photo ID
                /// to vote in person.
                /// Result:
                /// Yes: 2,049,121 55.49%
                /// No : 1,643,983 44.51%
                /// </summary>
                [YearDate(2018, 11, 6)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIdentificationNeededForVoting)]
                [BallotMeasurePassFail(true)]
                public static class VoterIDAmendment { }
            }

            public static class v2024
            {
                /// <summary>
                /// A "yes" vote supported amending the state constitution to provide that only U.S. citizens who are 18 years old or older can vote in elections.
                /// Result:
                /// Yes: 4,184,680 77.59%
                /// No : 1,208,865 22.41%
                /// </summary>
                [YearDate(2024, 11, 5)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                [BallotMeasurePassFail(true)]
                public static class CitizenRequirementForVotingAmendment { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports requiring the state legislature to pass laws limiting the amount that property
                /// taxes may increase (HB 1089)
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PropertyTaxes)]
                public static class PropertyTaxLevyLimitAmendment { }

                /// <summary>
                /// A "yes" vote supports reducing the maximum allowable income tax rate from 7% to 3.5%.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.IncomeTaxes)]
                public static class ReduceIncomeTaxRateCapFrom7To3Point5Amendment { }

                /// <summary>
                /// A "yes" vote supports requiring photographic identification to vote for all voters, not just those
                /// voting in person. Extends <see cref="v2018.VoterIDAmendment"/>, which only covered in-person voting.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIdentificationNeededForVoting)]
                public static class RequireVoterIdentificationAmendment { }
            }
        }

        public static class NorthDakota
        {
            public static class v2018
            {
                /// <summary>
                /// A "yes" vote supported amending the North Dakota Constitution to state that “only a citizen” of the U.S. can vote in federal, state, and 
                /// local elections.
                /// Result:
                /// Yes: 208,499 65.93%
                /// No : 107,751 34.07%
                /// </summary>
                [YearDate(2018, 11, 6)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                [BallotMeasurePassFail(true)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                public static class Measure2 { }
            }

            public static class v2026
            {
                [YearDate(2026, 6, 9)]
                public static class June
                {
                    /// <summary>
                    /// A "yes" vote supported creating a single-subject requirement for initiated constitutional
                    /// amendments and legislatively referred constitutional amendments
                    /// Result:
                    /// Yes: 77,141 66.42%
                    /// No : 38,995 33.58%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.BallotInitiatives)]
                    [BallotMeasurePassFail(true)]
                    public static class ConstitutionalMeasure1 { }
                }

                [YearDate(2026, 11, 3)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supports requiring constitutional amendments to receive a 60% supermajority vote to
                    /// be adopted.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.BallotMeasureSupermajorityRequirements)]
                    public static class ConstitutionalMeasure1 { }

                    /// <summary>
                    /// A "yes" vote supports requiring public schools to provide one free breakfast and one free lunch
                    /// to students.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicEducationFunding)]
                    public static class ConstitutionalMeasure2 { }
                }
            }
        }

        public static class Ohio
        {
            public static class v2022
            {
                /// <summary>
                /// A "yes" vote supported prohibiting local governments from allowing noncitizens or those who lack the qualifications of an elector 
                /// to vote in local elections.
                /// Result:
                /// Yes: 3,099,868 76.90%
                /// No :   931,205 23.10%
                /// </summary>
                [YearDate(2022, 11, 8)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                public static class Issue1 { }
            }

            public static class v2023
            {
                /// <summary>
                /// A "yes" vote supported amending the Ohio Constitution to:
                /// 1. provide a state constitutional right to "make and carry out one’s own reproductive 
                /// decisions, including but not limited to" decisions about abortion, contraception, 
                /// fertility treatment, miscarriage care, and continuing pregnancy, and
                /// 2. allow the state to restrict abortion after fetal viability, except when 
                /// “necessary to protect the pregnant patient’s life or health.” 
                /// Result:
                /// Yes: 2,227,384 56.78%
                /// No : 1,695,480 43.22%
                /// </summary>
                [YearDate(2023, 11, 7)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotMeasurePassFail(true)]
                public static class Issue1RightToMakeReproductiveDecisionsIncludingAbortionInitiative { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports requiring photo ID to vote.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIdentificationNeededForVoting)]
                public static class Issue3 { }
            }
        }

        public static class Oklahoma
        {
            public static class v2010
            {
                /// <summary>
                /// A "yes" vote supported requiring voters to present a government-issued photo ID or a voter 
                /// ID card issued by the County Election Board to vote, allowing provisional ballots for those 
                /// without ID, and making false sworn statements a felony.
                /// Result:
                /// Yes: 746,053 74.34%
                /// No : 257,523 25.66%
                /// </summary>
                [YearDate(2010, 11, 2)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIdentificationNeededForVoting, BallotInitiativeSubjects.IdentificationNeededForVoting)]
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                [BallotMeasurePassFail(true)]
                public static class Question746 { }
            }

            public static class v2024
            {
                /// <summary>
                /// A "yes" vote supported amending the state constitution to provide that only U.S. citizens who are 18 years old or older can vote in elections.
                /// Result:
                /// Yes: 1,207,520 80.73%
                /// No :   288,267 19.27%
                /// </summary>
                [YearDate(2024, 11, 5)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                public static class StateQuestion834 { }
            }

            public static class v2026
            {
                [YearDate(2026, 6, 16)]
                public static class June
                {
                    /// <summary>
                    /// A "yes" vote supported increasing the minimum wage to $15.00 per hour.
                    /// Result:
                    /// No : 349,102 55.37%
                    /// Yes: 281,386 44.63%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.CISS)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.MinimumWageLaws)]
                    [BallotMeasurePassFail(false)]
                    public static class StateQuestion832 { }
                }

                [YearDate(2026, 8, 25)]
                public static class August
                {
                    /// <summary>
                    /// A "yes" vote supported requiring the state legislature to establish a methodology for reimbursing
                    /// schools, local governments, service districts, and other local organizations for revenues lost due
                    /// to a manufacturing tax exemption.
                    /// Result:
                    /// No : 389,886 73.74%
                    /// Yes: 138,814 26.26%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.TaxAndRevenueAdministration)]
                    [BallotMeasurePassFail(false)]
                    public static class StateQuestion844 { }

                    /// <summary>
                    /// A "yes" vote supported requiring voters to provide proof of identity when voting in any election in
                    /// the state.
                    /// Result:
                    /// Yes: 292,599 54.61%
                    /// No : 243,159 45.39%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.IdentificationNeededForVoting)]
                    [BallotMeasurePassFail(true)]
                    public static class StateQuestion846 { }
                }

                [YearDate(2026, 11, 3)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supports making changes to the judicial nominating commission, including that
                    /// appointments shall be made according to current congressional districts.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.StateJudiciaryOversight)]
                    public static class StateQuestion845 { }

                    /// <summary>
                    /// A "yes" vote supports reducing the annual growth limit of the calculated fair cash value of property.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PropertyTaxes, BallotInitiativeSubjects.HomesteadTaxExemptions, BallotInitiativeSubjects.PropertyTaxExemptions)]
                    public static class StateQuestion847 { }
                }
            }
        }

        public static class Oregon
        {
            public static class v2024
            {
                /// <summary>
                /// A "yes" vote supported implementing ranked-choice voting primary and general elections for federal 
                /// and state executive offices beginning in 2028.
                /// Result:
                /// No : 1,219,013 57.70%
                /// Yes:   893,668 42.30%
                /// </summary>
                [YearDate(2024, 11, 5)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RankedChoiceVoting)]
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                [BallotMeasurePassFail(false)]
                public static class Measure117 { }
            }

            public static class v2026
            {
                [YearDate(2026, 5, 19)]
                public static class May
                {
                    /// <summary>
                    /// A "yes" vote supported upholding the sections of House Bill 3991 (2025) that increased the gas
                    /// tax from $0.40 to $0.46 per gallon, the transportation payroll tax from 0.1% to 0.2%, and
                    /// vehicle registration and title fees. A "no" vote repealed those sections.
                    /// Result:
                    /// No : 1,012,663 83.02%
                    /// Yes: 207,066 16.98%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.VR)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.TransportationTaxesAndFees, BallotInitiativeSubjects.FuelTaxes, BallotInitiativeSubjects.BusinessTaxes)]
                    [BallotMeasurePassFail(false)]
                    public static class Referendum120 { }
                }
            }
        }

        public static class RhodeIsland
        {
            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports issuing $275 million in bonds to fund the construction and improvement of
                /// higher education facilities.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.BI)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BondIssues, BallotInitiativeSubjects.HigherEducationFunding)]
                public static class Question1 { }

                /// <summary>
                /// A "yes" vote supports issuing $120 million in bonds to fund the construction and development of
                /// affordable housing projects.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.BI)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.HousingDevelopmentFunding, BallotInitiativeSubjects.BondIssues)]
                public static class Question2 { }

                /// <summary>
                /// A "yes" vote supports issuing $100 million in bonds to fund infrastructure and economic development
                /// projects.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.BI)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BondIssues)]
                public static class Question3 { }

                /// <summary>
                /// A "yes" vote supports issuing $50 million in bonds to fund cultural and historical projects.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.BI)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BondIssues)]
                public static class Question4 { }

                /// <summary>
                /// A "yes" vote supports issuing $55 million in bonds to fund environmental preservation and water
                /// infrastructure projects.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.BI)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BondIssues, BallotInitiativeSubjects.ParksLandAndNaturalAreaConservation, BallotInitiativeSubjects.SewageAndStormwater)]
                public static class Question5 { }
            }
        }

        public static class SouthCarolina
        {
            public static class v2024
            {
                /// <summary>
                /// A "yes" vote supported amending the state constitution to add language that only U.S. citizens who are 18 years old or older can vote in elections.
                /// Result:
                /// Yes: 1,982,956 85.94%
                /// No :   324,432 14.06%
                /// </summary>
                [YearDate(2024, 11, 5)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                public static class CitizenshipRequiredForVotingAmendment { }
            }
        }

        public static class SouthDakota
        {
            public static class v2024
            {
                [YearDate(2024, 11, 5)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supported providing for a state constitutional right to abortion in South Dakota,
                    /// using a trimester framework for regulation:
                    /// 1. During the first trimester, the state would be prohibited from regulating a woman's decision 
                    /// to have an abortion
                    /// 2. During the second trimester, the state may regulate abortion, but "only in ways that are 
                    /// reasonably related to the physical health of the pregnant woman"
                    /// 3. During the third trimester, the state may regulate or prohibit abortion, except "when abortion 
                    /// is necessary, in the medical judgment of the woman's physician, to preserve the life and health 
                    /// of the pregnant woman."
                    /// Result:
                    /// No : 250,136 58.59%
                    /// Yes: 176,809 41.41%
                    /// </summary>
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotMeasurePassFail(false)]
                    public static class ConstitutionalAmendmentG { }

                    /// <summary>
                    /// A "yes" vote supported replacing partisan primaries with top-two primaries for state executive, 
                    /// state legislative, congressional, and county offices.
                    /// Result:
                    /// No : 270,048 65.61%
                    /// Yes: 141,570 34.39%
                    /// </summary>
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections)]
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotMeasurePassFail(false)]
                    public static class ConstitutionalAmendmentH { }
                }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports conditioning Medicaid expansion on federal funding remaining at least 90%.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicHealthInsurance, BallotInitiativeSubjects.PublicAssistancePrograms)]
                public static class ConstitutionalAmendmentI { }

                /// <summary>
                /// A "yes" vote supports providing that "[an] individual who is not a citizen of the United States is
                /// disqualified from voting in any election or upon any question submitted to the voters".
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                public static class ConstitutionalAmendmentJ { }

                /// <summary>
                /// A "yes" vote supports establishing an unclaimed property trust fund.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RestrictedUseFunds)]
                public static class ConstitutionalAmendmentK { }

                /// <summary>
                /// A "yes" vote supports requiring a 60% supermajority by voters to approve constitutional amendments.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BallotMeasureSupermajorityRequirements)]
                public static class ConstitutionalAmendmentL { }
            }
        }

        public static class Tennessee
        {
            public static class v2014
            {
                /// <summary>
                /// A "yes" vote supported this constitutional amendment to:
                ///• provide that nothing in the Tennessee Constitution "secures or protects a right 
                ///to abortion or requires the funding of an abortion" and
                ///• state that the Legislature has the power to pass laws regulating abortion.
                /// Result:
                /// Yes: 729,163 52.60%
                /// No : 657,192 47.40%
                /// </summary>
                [YearDate(2014, 11, 4)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(true)]
                public static class Amendment1 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports removing the right to bail for specified criminal offenses.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BailPolicy, BallotInitiativeSubjects.CriminalTrials)]
                public static class Amendment1 { }

                /// <summary>
                /// A "yes" vote supports prohibiting the legislature from enacting taxes on property.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.StateLegislativeAuthority, BallotInitiativeSubjects.PropertyTaxes)]
                public static class Amendment2 { }

                /// <summary>
                /// A "yes" vote supports amending the list of crime victims' rights in the constitution.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.CriminalTrials, BallotInitiativeSubjects.CrimeVictimsRights)]
                public static class Amendment3 { }
            }
        }

        public static class Utah
        {
            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports requiring that constitutional amendments appearing on the ballot be published for
                /// a period of 60 days.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BallotInitiatives)]
                public static class ConstitutionalAmendmentA { }

                /// <summary>
                /// A "yes" vote supports requiring a 60% supermajority of voters for citizen-initiated ballot measures that
                /// create new taxes, increase existing tax rates, or are for a property tax.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Taxes, BallotInitiativeSubjects.PropertyTaxes, BallotInitiativeSubjects.BallotMeasureSupermajorityRequirements)]
                public static class ConstitutionalAmendmentB { }
            }
        }

        public static class Vermont
        {
            public static class v2022
            {
                /// <summary>
                /// A "yes" vote supported amending the Vermont Constitution to add language protecting 
                /// the right to personal reproductive autonomy and prohibiting government infringement
                /// unless justified by a compelling state interest.
                /// Result: 
                /// Yes: 212,323 76.77%
                /// No :  64,239 23.23%
                /// </summary>
                [YearDate(2022, 11, 8)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Proposal5 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports establishing a state constitutional right to organize or join a labor organization
                /// for the purpose of collective bargaining.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.ConstitutionalRights, BallotInitiativeSubjects.CollectiveBargaining)]
                public static class Proposal3 { }

                /// <summary>
                /// A "yes" vote supports prohibiting the denial of rights to an individual based on their race, ethnicity,
                /// sex, religion, disability, sexual orientation, gender identity, gender expression, or national origin.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.LGBTQIssues, BallotInitiativeSubjects.ReligionRelatedPolicy, BallotInitiativeSubjects.RaceAndEthnicityIssues, BallotInitiativeSubjects.SexAndGenderIssues, BallotInitiativeSubjects.ConstitutionalRights)]
                public static class Proposal4 { }
            }
        }

        public static class Virginia
        {
            public static class v2026
            {
                [YearDate(2026, 4, 21)]
                public static class April
                {
                    /// <summary>
                    /// A "yes" vote supported allowing the state legislature to conduct congressional redistricting between
                    /// 2025 and 2030.
                    /// Result:
                    /// Yes: 1,604,276 51.69%
                    /// No : 1,499,393 48.31%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.MidCycleRedistricting)]
                    [BallotMeasurePassFail(true)]
                    [Observation("Overturned: on 2026-05-08 the Supreme Court of Virginia ruled 4-3 that the legislature skipped the required intervening election between its two votes on the amendment, voiding the result and keeping the existing congressional maps")]
                    public static class UseOfLegislativeCongressionalRedistrictingMapAmendment { }
                }

                [YearDate(2026, 11, 3)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supports providing a state constitutional right to reproductive freedom, defined as "the
                    /// right to make and effectuate one's own decisions about all matters related to one's pregnancy".
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion, BallotInitiativeSubjects.ConstitutionalRights)]
                    [BallotMeasurePassFail(true)]
                    [IPredictedYesBallotInitiative(Correctness.Correct, "This more than maintains the status quo (constitutional amendment > statute")]
                    public static class Question1 { }

                    /// <summary>
                    /// A "yes" vote supports repealing the provision defining marriage as between one man and one woman and
                    /// prohibiting the state from denying a marriage license to two adult persons based on sex, gender, or
                    /// race.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.LGBTQIssues, BallotInitiativeSubjects.SexAndGenderIssues, BallotInitiativeSubjects.RaceAndEthnicityIssues, BallotInitiativeSubjects.FamilyRelatedPolicy, BallotInitiativeSubjects.ConstitutionalRights)]
                    public static class Question2 { }

                    /// <summary>
                    /// A "yes" vote supports providing that persons convicted of felonies have their voting rights restored
                    /// upon release from incarceration.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.ConstitutionalRights, BallotInitiativeSubjects.VotingRightsForPersonsWithCriminalConvictions)]
                    public static class Question3 { }
                }
            }
        }

        public static class Washington
        {
            public static class v1991
            {
                /// <summary>
                /// A "yes" vote supported providing, in statute, that "The state may not deny or 
                /// interfere with a woman's right to choose to have an abortion prior to viability 
                /// of the fetus, or to protect her life or health."
                /// Result:
                /// Yes: 756,653 50.14%
                /// No : 752,354 49.86%
                /// </summary>
                [YearDate(1991, 11, 5)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasureType(BallotMeasureTypes.ITL)]
                [BallotMeasurePassFail(true)]
                public static class Initiative120 { }
            }
            public static class v2004
            {
                /// <summary>
                /// A “yes” vote supported replacing the system of separate primaries with a top-two primary system.
                /// </summary>
                [YearDate(2004, 11, 2)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PrimaryElections)]
                [BallotMeasureType(BallotMeasureTypes.ITP)]
                [BallotMeasurePassFail(true)]
                public static class Initiative872 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports re-enacting Initiative to the Legislature 2081 (2024), related to parental rights to
                /// review educational materials, receive specific notifications, and opt their children out of sexual
                /// health education.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PublicEducationGovernance)]
                public static class Initiative1 { }

                /// <summary>
                /// A "yes" vote supports requiring school and voluntary nonprofit athletics to prohibit biologically male
                /// students from competing with and against biologically female students.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.IndISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.AthleticsAndSports, BallotInitiativeSubjects.PublicEducationGovernance, BallotInitiativeSubjects.SexAndGenderIssues, BallotInitiativeSubjects.LGBTQIssues)]
                public static class Initiative638 { }

                /// <summary>
                /// A "yes" vote supports repealing the tax on household income over $1 million and prohibiting state and
                /// local taxes on individual income.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.IncomeTaxes)]
                public static class Initiative645 { }
            }
        }

        public static class WashingtonDC
        {
            public static class v2024
            {
                /// <summary>
                /// A "yes" vote supported this initiative to:
                /// 1. create a semi-open primary system allowing voters who are unaffiliated with a political party 
                /// to vote in a party primary election and
                /// 2. establish ranked-choice voting for elections in Washington, D.C., beginning in 2026.
                /// Result:
                /// Yes: 212,332 72.89%
                /// No :  78,961 27.11%
                /// </summary>
                [YearDate(2024, 11, 5)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.RankedChoiceVoting)]
                [BallotMeasureType(BallotMeasureTypes.Initiative)]
                [BallotMeasurePassFail(true)]
                public static class Initiative83 { }
            }
        }

        public static class WestVirginia
        {
            public static class v2018
            {
                /// <summary>
                /// A "yes" vote supported this amendment to add language to the West Virginia 
                /// Constitution stating that "nothing in this Constitution secures or protects a 
                /// right to abortion or requires the funding of abortion."
                /// Result:
                /// Yes: 295,536 51.73%
                /// No : 275,748 48.27%
                /// </summary>
                [YearDate(2018, 11, 6)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Amendment1 { }
            }

            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports amending the constitution to state that only citizens may vote in elections.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                [BallotMeasurePassFail(true)]
                public static class CitizenshipVotingRequirementAmendment { }
            }
        }

        public static class Wyoming
        {
            public static class v2026
            {
                /// <summary>
                /// A "yes" vote supports creating a homeowner's property tax exemption that exempts 50% of a primary
                /// residence's assessed value from property taxation.
                /// </summary>
                [YearDate(2026, 11, 3)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PropertyTaxExemptions, BallotInitiativeSubjects.PropertyTaxes, BallotInitiativeSubjects.HomesteadTaxExemptions)]
                public static class Initiative1 { }
            }
        }
    }
}
