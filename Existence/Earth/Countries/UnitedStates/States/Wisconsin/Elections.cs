using Existence.Earth.Alphabet;
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates.States.Wisconsin
{
    internal class Elections
    {
        /// <summary>
        /// nonpartisan elections for 10 year terms
        /// </summary>
        public static class StateSupremeCourt
        {
            /// <summary>
            /// Ann Walsh Bradley (incumbent) 471,866 58.02%
            /// James P. Daley                340,632 41.89%
            /// Write-in                          702  0.09%
            /// </summary>
            [YearDate(2015, 4, 7)]
            public static class v2015 { }

            /// <summary>
            /// Rebecca Bradley (incumbent)  1,024,892 52.35%
            /// JoAnne Kloppenbert             929,377 47.47%
            /// Write-in                         3,678  0.19%
            /// </summary>
            [YearDate(2016, 4, 5)]
            public static class v2016 { }

            /// <summary>
            /// Annette Ziegler (incumbent)    492,352 97.20%
            /// Write-in                        14,165  2.80%
            /// </summary>
            [YearDate(2017, 4, 4)]
            public static class v2017 { }

            /// <summary>
            /// Rebecca Dallet                 555,848 55.72%
            /// Michael Screnock               440,808 44.19%
            /// Write-in                           829  0.08%
            /// </summary>
            [YearDate(2018, 4, 3)]
            public static class v2018 { }

            /// <summary>
            /// Brian Hagedorn                 606,414 50.22%
            /// Lisa Neubauer                  600,433 49.72%
            /// Write-in                           722  0.06%
            /// </summary>
            [YearDate(2019, 4, 2)]
            public static class v2019 { }

            /// <summary>
            /// Jill Karofsky                  855,573 55.21%
            /// Daniel Kelly                   693,134 44.73%
            /// Write-in                           990  0.06%
            /// </summary>
            [YearDate(2020, 4, 7)]
            public static class v2020 { }

            /// <summary>
            /// Janet Protasiewicz           1,021,822 55.43%
            /// Daniel Kelly                   818,391 44.39%
            /// Write-in                         3,267  0.18%
            /// </summary>
            [YearDate(2023, 4, 4)]
            public static class v2023 { }

            /// <summary>
            /// PENDING
            /// Brad Schimel
            /// Susan Crawford
            /// </summary>
            [TODO("Future Election")]
            public static class v2025 { }
        }

        public static class StateLegislature
        {
            public static class v2022
            {
                /// <summary>
                /// Republican: 64 (+3) (not quite a 2/3 supermajority)
                /// Democratic: 35 (-3)
                /// </summary>
                public static class Assembly { }

                /// <summary>
                /// Republican: 12 (+1) Total: 22 (2/3 supermajority)
                /// Democratic:  5 (-1)        11
                /// </summary>
                public static class Senate { }
            }

            /// <summary>
            /// first election after State Supreme Court ordered maps redrawn for continuousness
            /// </summary>
            public static class v2024
            {
                /// <summary>
                /// Republican: 54 (-10)
                /// Democratic: 45 (+10)
                /// </summary>
                public static class Assembly { }

                /// <summary>
                /// Republican:  6 (-4) Total: 18 (lost 2/3 supermajority)
                /// Democratic: 10 (+4)        15
                /// </summary>
                public static class Senate { }
            }
        }

        public static class BallotMeasures
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
                    public static class VoterPhotoIdentificationAmendment { }
                }
            }
        }
    }
}
