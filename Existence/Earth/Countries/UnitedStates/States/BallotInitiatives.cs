using System;
using Existence.Earth.Alphabet;
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates.States
{
    public enum BallotInitiativeSubjects
    {
        Abortion,
        BallotInitiatives,
        VotingMethod,
    }

    public class BallotInitiativeSubject : Attribute
    {
        public BallotInitiativeSubjects Subject { get; set; }
        public BallotInitiativeSubject(BallotInitiativeSubjects Subject)
        {
            this.Subject = Subject;
        }
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
                [BallotMeasurePassFail(false)]
                [Observation("This effectively kept ranked choice voting in place")]
                public static class BallotMeasure2 { }
            }
        }

        public static class Arizona
        {
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
                    [BallotMeasurePassFail(false)]
                    public static class Proposition140 { }
                }
            }
        }

        public static class California
        {
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Proposition1 { }
            }
        }

        public static class Colorado
        {
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.BallotInitiatives)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(false)]
                public static class Amendment6 { }
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(false)]
                public static class Amendment4 { }
            }
        }

        public static class Idaho
        {
            public static class v2024
            {
                /// <summary>
                /// A "yes" vote supported establishing top-four primaries and ranked-choice voting for general
                /// elections, which would apply to congressional, gubernatorial, and state, and county elected 
                /// offices.
                /// Result:
                /// No : 618,753 69.62%
                /// Yes: 269,960 30.38%
                /// </summary>
                [YearDate(2024, 11, 5)]
                [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
                [BallotMeasureType(BallotMeasureTypes.CISS)]
                [BallotMeasurePassFail(false)]
                public static class Proposition1 { }
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
                [BallotMeasureType(BallotMeasureTypes.LRCA)]
                [BallotMeasurePassFail(false)]
                public static class ConstitutionalAmendment2 { }
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Amendment1 { }
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Proposal3 { }
            }
        }

        public static class Missouri
        {
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
                    [BallotMeasureType(BallotMeasureTypes.CICA)]
                    [BallotMeasurePassFail(true)]
                    public static class CitizenInitiative128 { }
                }
            }
        }

        public static class Nebraska
        {
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
                [BallotMeasurePassFail(true)]
                [Observation("Failed to be approved in a second referendum in 2024")]
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
                    [BallotMeasurePassFail(true)]
                    public static class Question6 { }
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
                public static class Proposal1 { }
            }
        }

        public static class Ohio
        {
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
                [BallotMeasureType(BallotMeasureTypes.CICA)]
                [BallotMeasurePassFail(true)]
                public static class Issue1RightToMakeReproductiveDecisionsIncludingAbortionInitiative { }
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
                [BallotMeasureType(BallotMeasureTypes.LRSS)]
                [BallotMeasurePassFail(false)]
                public static class Measure117 { }
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                    [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
                [BallotMeasureType(BallotMeasureTypes.ITL)]
                [BallotMeasurePassFail(true)]
                public static class Initiative120 { }
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.VotingMethod)]
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
                [BallotInitiativeSubject(BallotInitiativeSubjects.Abortion)]
                [BallotMeasurePassFail(true)]
                public static class Amendment1 { }
            }
        }
    }
}
