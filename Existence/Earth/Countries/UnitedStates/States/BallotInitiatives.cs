using Existence.Earth.Alphabet;
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates.States
{
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
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIDForVoting)]
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
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIDForVoting)]
                [BallotMeasurePassFail(true)]
                public static class Issue2 { }
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
                [BallotInitiativeSubjects(BallotInitiativeSubjects.BallotInitiatives)]
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
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIDForVoting)]
                [BallotMeasurePassFail(false)]
                public static class Amendment2 { }
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
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIDForVoting)]
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
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIDForVoting)]
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
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIDForVoting)]
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
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIDForVoting)]
                    [BallotMeasurePassFail(true)]
                    [RequiresAnotherSuccessfulVote(true)]
                    public static class Question7 { }
                }
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
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIDForVoting)]
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
                [BallotInitiativeSubjects(BallotInitiativeSubjects.PhotoIDForVoting)]
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
        }

        public static class Wisconsin
        {
            public static class v2000
            {
                /// <summary>
                /// A “yes” vote supported extending the right to vote in federal elections to the children of U.S. citizens
                /// living abroad who formerly resided in Wisconsin. A “no” vote opposed extending the right to vote in federal 
                /// elections to the children of U.S. citizens living abroad who formerly resided in Wisconsin.
                /// Result:
                /// Yes     1,293,458 61.99%
                /// No        792,975 38.01%
                /// </summary>
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                [YearDate(2000, 11, 7)]
                [BallotMeasurePassFail(true)]
                public static class WisconsinQuestion1 { }
            }

            public static class v2003
            {
                /// <summary>
                /// A “yes” vote supported adding a section to the constitution to provide the right to fish, hunt, trap, and take game.
                /// A “no” vote opposed adding a section to the constitution to provide the right to fish, hunt, trap, and take game.
                /// Result:
                /// Yes      668,459 82.06%
                /// No       146,182 17.94%
                /// </summary>
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [YearDate(2003, 4, 1)]
                [BallotMeasurePassFail(true)]
                public static class WisconsinQuestion1 { }
            }

            public static class v2005
            {
                /// <summary>
                /// A “yes” vote supported amending the constitution to provide that district attorneys, coroners, elected surveyors, 
                /// registers of deeds, treasurers, county clerks, and clerks of circuit court be elected to four-year terms.
                /// A “no” vote opposed amending the constitution to provide that district attorneys, coroners, elected surveyors, 
                /// registers of deeds, treasurers, county clerks, and clerks of circuit court be elected to four-year terms.
                /// Result:
                /// Yes   534,742 75.13%
                /// No    177,037 24.87%
                /// </summary>
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [YearDate(2005, 4, 5)]
                [BallotMeasurePassFail(true)]
                public static class Question1 { }
            }

            public static class v2006
            {
                [YearDate(2006, 11, 7)]
                public class November
                {
                    /// <summary>
                    /// A “yes” vote supported adding a section to the constitution to provide that only marriage between a man and a 
                    /// woman will be recognized as valid. A “no” vote opposed adding a section to the constitution to provide that 
                    /// only marriage between a man and a woman will be recognized as valid.
                    /// Result:
                    /// Yes  1,264,310 59.43%
                    /// No     862,924 40.57%
                    /// On June 6, 2014, Question 1 was overturned by District Court Judge Barbara Crabb.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Question1 { }

                    /// <summary>
                    /// A “yes” vote supported the enactment of the death penalty in first-degree intentional homicide convictions 
                    /// supported by DNA evidence. A “no” vote opposed the enactment of the death penalty in first-degree intentional 
                    /// homicide convictions supported by DNA evidence.
                    /// Result:
                    /// Yes   1,166,571 55.52%
                    /// No      934,508 44.48%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.AQ)]
                    [BallotMeasurePassFail(true)]
                    public static class Question2 { }
                }
            }

            public static class v2008
            {
                /// <summary>
                /// A "yes" vote supported amending the state constitution to remove the gubernatorial partial veto power to 
                /// create a new sentence by combining separate parts of the bill. A "no" vote opposed amending the state 
                /// constitution to remove the gubernatorial partial veto power to create a new sentence by combining separate 
                /// parts of the bill.
                /// Result:
                /// Yes   575,582 70.61%
                /// No    239,613 29.39%
                /// </summary>
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [YearDate(2008, 4, 1)]
                [BallotMeasurePassFail(true)]
                public static class Question1 { }
            }

            public static class v2014
            {
                /// <summary>
                /// The amendment required that revenue generated by transportation fees and taxes be deposited into the state's 
                /// transportation fund. According to the amendment, none of the revenue collected from transportation-related 
                /// levies could be appropriated to any program that is not directly administered by the Wisconsin Department of 
                /// Transportation. Therefore, the amendment guaranteed that revenue from transportation-related levies, 
                /// such as the gas tax and vehicle registration fee, would be allocated to transportation-related projects.
                /// While Question 1 supporters argued that the amendment would prohibit politicians from transferring money from 
                /// the state’s transportation fund to other parts of the budget, opponents contended that the measure would 
                /// create budget inflexibility and encourage politicians to raid non-constitutionalized funds, such as education 
                /// funds.
                /// Result:
                /// Yes   1,733,101 79.94%
                /// No      434,806 20.06%
                /// </summary>
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [YearDate(2014, 11, 4)]
                [BallotMeasurePassFail(true)]
                public static class Question1 { }
            }

            public static class v2015
            {
                /// <summary>
                /// The measure provided for the election of the Wisconsin Supreme Court Chief Justice by a majority of the justices 
                /// serving on the court. The chief justice chosen by the court would serve a two-year term. Before Question 1's 
                /// passage, the Wisconsin Constitution mandated that the chief justice be appointed based on seniority from the 
                /// pool of seven justices sitting on the Wisconsin Supreme Court. Chief Justice Shirley Abrahamson, at the time, 
                /// had served as the court's chief justice since 1996. She was considered a liberal, but the court majority was 
                /// considered conservative, according to the Milwaukee Journal Sentinel. Opponents argued that the amendment was a 
                /// political attack on Chief Justice Abrahamson and that the seniority method was more democratic because it allowed 
                /// the justice who had been elected by voters the most times to be chief justice, while supporters contended the 
                /// majority-vote system was more democratic because the justices would decide who would be the head of the court, 
                /// thereby decreasing conflict among the justices. In April 2015, Abrahamson filed a federal lawsuit seeking to block 
                /// the amendment and any action to remove her from the chief justice's seat, but this failed.
                /// Result:
                /// Yes     433,533 53.00%
                /// No      384,503 47.00%
                /// </summary>
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [YearDate(2015, 4, 7)]
                [BallotMeasurePassFail(true)]
                public static class Question1 { }
            }

            public static class v2018
            {
                /// <summary>
                /// A "yes" vote supported this amendment to eliminate the elected position of state treasurer.
                /// A "no" vote opposed this amendment to eliminate the elected position of state treasurer.
                /// Result:
                /// No     584,323 61.75%
                /// Yes    361,963 38.25%
                /// </summary>
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [YearDate(2018, 4, 3)]
                [BallotMeasurePassFail(false)]
                public static class Question1 { }
            }

            public static class v2020
            {
                /// <summary>
                /// A "yes" vote supported this measure to add specific rights of crime victims, together known as a Marsy's Law, 
                /// to the Wisconsin Constitution. A "no" vote opposed this measure to add specific rights of crime victims to the
                /// state constitution beyond those found in Section 9m of Article I of the Wisconsin Constitution.
                /// Result:
                /// Yes    1,107,067 74.90%
                /// No       371,013 25.10%
                /// </summary>
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [YearDate(2020, 4, 7)]
                [BallotMeasurePassFail(true)]
                public static class MarsysLawAmendment { }
            }

            public static class v2023
            {
                [YearDate(2023, 4, 4)]
                public static class April
                {
                    /// <summary>
                    /// A "yes" vote supported amending the state constitution to allow the state legislature to define what serious harm 
                    /// means in relation to the bail conditions that judges impose on accused persons released before their criminal 
                    /// trial, for the purpose of “[protecting] members of the community from serious harm." A "no" vote opposed amending 
                    /// the state constitution, thus continuing to consider serious bodily harm as statutorily defined in relation to the 
                    /// bail conditions that judges impose on accused persons released before their criminal trial.
                    /// Result:
                    /// Yes    1,163,303 66.55%
                    /// No       584,624 33.45%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Question1 { }

                    /// <summary>
                    /// A "yes" vote supported amending the state constitution to authorize judges to consider the totality of the 
                    /// circumstances when imposing and setting cash bail for persons accused of violent crimes, including circumstances 
                    /// related to:
                    /// * a previous conviction of a violent crime, 
                    /// * the probability the accused will not appear in court
                    /// * the need to protect the community from serious harm as defined by the state legislature
                    /// * the need to prevent witness intimidation
                    /// * the potential affirmative defenses of the accused
                    /// A "no" vote opposed this amendment, thereby maintaining the existing conditions for imposing cash bail, which 
                    /// are ensuring an accused person's appearance in court, protecting members of the community from serious bodily 
                    /// harm, and preventing the intimidation of witnesses.
                    /// Result:
                    /// Yes    1,186,025 67.57%
                    /// No       569,286 32.43%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Question2 { }

                    /// <summary>
                    /// A "yes" vote supported advising the state legislature to require "able-bodied, childless adults... to look for 
                    /// work in order to receive taxpayer-funded welfare benefits." A "no" vote opposed advising the state legislature to 
                    /// require "able-bodied, childless adults... to look for work in order to receive taxpayer-funded welfare benefits."
                    /// </summary>
                    /// Result:
                    /// Yes   1,417,035 79.57%
                    /// No      363,941 20.43%
                    [BallotMeasureType(BallotMeasureTypes.AQ)]
                    [BallotMeasurePassFail(true)]
                    public static class Question3 { }
                }
            }

            public static class v2024
            {
                [YearDate(2024, 4, 2)]
                public static class April
                {
                    /// <summary>
                    /// A "yes" vote supported this amendment to prohibit any level of government in the state from applying or 
                    /// accepting non-governmental funds or equipment for election administration. A "no" vote opposed this amendment 
                    /// to prohibit any level of government in the state from applying or accepting non-governmental funds or equipment 
                    /// for election administration.
                    /// Result:
                    /// Yes  638,555 54.43%
                    /// No   534,612 45.57%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Question1 { }

                    /// <summary>
                    /// A "yes" vote supported this amendment to provide that only election officials designated by law may administer 
                    /// elections. A "no" vote opposed this amendment to provide that only election officials designated by law may 
                    /// administer elections.
                    /// Result:
                    /// Yes   685,806 58.63%
                    /// No    483,900 41.37%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    public static class Question2 { }
                }
                [YearDate(2024, 8, 13)]
                public static class August
                {
                    /// <summary>
                    /// A "yes" vote supported amending the state constitution to prohibit the legislature from delegating its 
                    /// power to appropriate money. A "no" vote opposed amending the state constitution to prohibit the legislature 
                    /// from delegating its power to appropriate money.
                    /// Result:
                    /// No   704,260 57.45%
                    /// Yes  521,538 42.55%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(false)]
                    public static class Question1 { }

                    /// <summary>
                    /// A "yes" vote supported amending the state constitution to require legislative approval via a joint resolution 
                    /// before the governor can expend federal money appropriated to the state. A "no" vote opposed this amendment, 
                    /// thereby allowing the governor to accept and allocate federal funds without seeking legislative approval.
                    /// Result:
                    /// No   706,637 57.53%
                    /// Yes  521,639 42.47%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(false)]
                    public static class Question2 { }
                }
                [YearDate(2024, 11, 5)]
                public static class November
                {
                    /// <summary>
                    /// A "yes" vote supported this amendment to add language to the Wisconsin Constitution that only U.S. citizens 
                    /// who are 18 years old or older can vote in federal, state, local, or school elections. A "no" vote opposed this 
                    /// amendment to add language to the Wisconsin Constitution that only U.S. citizens who are 18 years old or older 
                    /// can vote in federal, state, local, or school elections.
                    /// Result:
                    /// Yes    2,272,446 70.51%
                    /// No       950,445 29.49%
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [BallotMeasurePassFail(true)]
                    [BallotInitiativeSubjects(BallotInitiativeSubjects.NonCitizenVoting)]
                    [Observation("This slammed the door on any-non-citizen voting permitted by the 2000 voting rights ballot initiative")]
                    public static class CitizenVotingRequirementAmendment { }
                }
            }

            public static class v2025
            {
                [YearDate(2025, 4, 1)]
                public static class April
                {
                    /// <summary>
                    /// A "yes" vote supports amending the state constitution to require valid photo identification to vote and 
                    /// authorizing the state legislature to pass laws to determine what qualifies as valid photo identification 
                    /// and exceptions to the requirement. A "no" vote opposes amending the state constitution to require valid 
                    /// photo identification to vote and authorizing the state legislature to pass laws to determine what qualifies 
                    /// as valid photo identification and exceptions to the requirement.
                    /// </summary>
                    [BallotMeasureType(BallotMeasureTypes.LRCA)]
                    [TODO("Update after this election is over.")]
                    public static class VoterPhotoIdentificationAmendment { }
                }
            }
        }
    }
}
