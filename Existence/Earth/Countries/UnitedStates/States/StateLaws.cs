using System;
using System.Collections.Generic;
using Existence.Earth.Alphabet;
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates.States
{
    public static class StateLaws
    {
        public static class AbortionLists
        {
            public static List<USStatesAndTerritories> OverturningRoevWadeHadNoEffectPerStateLaw = new List<USStatesAndTerritories>()
        {
            USStatesAndTerritories.Alaska, //1997 state supreme court ruling that state right to privacy protects abortion rights
            USStatesAndTerritories.California, //State constitution guarantees abortion rights (affirmed by Proposition 1, 2022).
            USStatesAndTerritories.Colorado, //State law (Reproductive Health Equity Act, 2022) explicitly protects abortion rights.
            USStatesAndTerritories.Connecticut, //State law (1990 law) codifies Roe v. Wade protections.
            USStatesAndTerritories.Delaware, //State law (2017 law) protects abortion rights.
            USStatesAndTerritories.Hawaii, //State law (1970 law, before Roe) guarantees abortion rights.
            USStatesAndTerritories.Illinois, //State law (Reproductive Health Act, 2019) protects abortion access.
            USStatesAndTerritories.Kansas, //state supreme court decision from 2019, although poltical battle continued
            USStatesAndTerritories.Maine, //State law (1993 law) guarantees abortion access.
            USStatesAndTerritories.Maryland, //State law (1991 law, confirmed by a 1992 referendum) protects abortion rights.
            USStatesAndTerritories.Massachusetts, //State law (ROE Act, 2020) guarantees abortion access.
            USStatesAndTerritories.Minnesota, //State constitution protects abortion rights (Doe v. Gomez, 1995).
            USStatesAndTerritories.Nevada, //State law (1990 voter referendum) guarantees abortion rights.
            USStatesAndTerritories.NewHampshire, //limited effect because law only bans abortion after 24 weeks
            USStatesAndTerritories.NewJersey, //State law (Freedom of Reproductive Choice Act, 2022) protects abortion access.
            USStatesAndTerritories.NewMexico, //State law (2021 repeal of pre-Roe ban) protects abortion access.
            USStatesAndTerritories.NewYork, //State law (Reproductive Health Act, 2019) protects abortion rights.
            USStatesAndTerritories.Oregon, //	State law (Reproductive Health Equity Act, 2017) guarantees abortion access.
            USStatesAndTerritories.Pennsylvania, //abortion banned after 24 weeks
            USStatesAndTerritories.RhodeIsland, //State law (Reproductive Privacy Act, 2019) protects abortion rights.
            USStatesAndTerritories.Vermont, //State constitution guarantees abortion rights (affirmed by Proposal 5, 2022).
            USStatesAndTerritories.Washington, //State law (1991 voter-approved law) guarantees abortion rights.
            USStatesAndTerritories.WashingtonDC, //right to access abortion services without mandatory waiting periods, parental involvement, or spousal consent since 1970s
            USStatesAndTerritories.PuertoRico,
            USStatesAndTerritories.Guam, //abortion is legal but no local healthcare provider support it
            USStatesAndTerritories.UnitedStatesVirginIslands, //legal up to 24 weeks
        };
            public static List<USStatesAndTerritories> PostDobbsAbortionRights = new List<USStatesAndTerritories>()
        {
            USStatesAndTerritories.Arizona, //2024 ballot initiative Proposition 139
            USStatesAndTerritories.Michigan, //2022 ballot initiative Proposal 3
            USStatesAndTerritories.Missouri, //2024 ballot initiative Amendment 3
            USStatesAndTerritories.Montana, //2024 ballot initiative
            USStatesAndTerritories.Ohio, //2023 ballot initiative Issue 1
        };
            public static List<USStatesAndTerritories> PerhapsResolvedByFutureBallotInitiative = new List<USStatesAndTerritories>()
        {
            USStatesAndTerritories.Virginia
        };
            public static List<USStatesAndTerritories> LawsYetToBeResolvedInLegalSystem = new List<USStatesAndTerritories>()
        {
            USStatesAndTerritories.Georgia, //6 weeks
            USStatesAndTerritories.NorthDakota, //total
            USStatesAndTerritories.SouthCarolina, //6 weeks
            USStatesAndTerritories.Utah, //18 weeks or total
            USStatesAndTerritories.Wisconsin, //1849 ban treated as total ban
            USStatesAndTerritories.Wyoming //fetal viability or total
        };
            public static List<USStatesAndTerritories> AbortionGenerallyIllegalPerStateLaw = new List<USStatesAndTerritories>()
        {
            USStatesAndTerritories.Alabama, //total
            USStatesAndTerritories.Arkansas, //total
            USStatesAndTerritories.Florida, //6 weeks
            USStatesAndTerritories.Idaho, //total
            USStatesAndTerritories.Iowa, //6 weeks
            USStatesAndTerritories.Indiana, //total
            USStatesAndTerritories.Kentucky, //total
            USStatesAndTerritories.Louisiana, //total
            USStatesAndTerritories.Mississippi, //total
            USStatesAndTerritories.Nebraska, //12 week ban
            USStatesAndTerritories.NorthCarolina, //12 week ban (less restrictive than other southern states)
            USStatesAndTerritories.Oklahoma, //total
            USStatesAndTerritories.SouthDakota, //total
            USStatesAndTerritories.Tennessee, //total
            USStatesAndTerritories.Texas, //total
            USStatesAndTerritories.WestVirginia, //total
            USStatesAndTerritories.NorthernMarianaIslands, //total
            USStatesAndTerritories.AmericanSamoa, //total
        };
        }
        public static List<USStatesAndTerritories> RankedChoiceVotingIllegal = new List<USStatesAndTerritories>()
        {
            USStatesAndTerritories.Alabama, //SB 1886 (2024-05-10)
            USStatesAndTerritories.Florida, //S 524 (2022-04-26)
            USStatesAndTerritories.Idaho, //H 179 (2023-03-24)
            USStatesAndTerritories.Kentucky, //HB 44 (2024-04-12)
            USStatesAndTerritories.Louisiana, //SB 101 (2024-05-28)
            USStatesAndTerritories.Mississippi, //SB 2144 (2024-05-13)
            USStatesAndTerritories.Mississippi, //2024-11-05 ballot initiative Amendment 7
            USStatesAndTerritories.Montana, //HB 598 (2023-04-27)
            USStatesAndTerritories.Oklahoma, //HB 3156 (2024-04-29)
            USStatesAndTerritories.SouthDakota, //SB 55 (2023-03-27)
            USStatesAndTerritories.Tennessee, //HB 1868, SB 1820 (2022-03-07)
        };
        //taken from ballotpedia
        public static List<USStatesAndTerritories> VoterPhotoIDRequired = new List<USStatesAndTerritories>()
        {
            USStatesAndTerritories.Alabama,
            USStatesAndTerritories.Arkansas,
            USStatesAndTerritories.Florida,
            USStatesAndTerritories.Georgia,
            USStatesAndTerritories.Idaho,
            USStatesAndTerritories.Indiana,
            USStatesAndTerritories.Kansas,
            USStatesAndTerritories.Kentucky,
            USStatesAndTerritories.Louisiana,
            USStatesAndTerritories.Michigan,
            USStatesAndTerritories.Mississippi,
            USStatesAndTerritories.Missouri,
            USStatesAndTerritories.Montana,
            USStatesAndTerritories.Nebraska,
            USStatesAndTerritories.NewHampshire,
            USStatesAndTerritories.NorthCarolina,
            USStatesAndTerritories.Ohio,
            USStatesAndTerritories.RhodeIsland,
            USStatesAndTerritories.SouthDakota,
            USStatesAndTerritories.SouthCarolina,
            USStatesAndTerritories.Texas,
            USStatesAndTerritories.Tennessee,
            USStatesAndTerritories.Wisconsin,
        };
        //from ballotpedia
        public static List<USStatesAndTerritories> VoterNonPhotoIDRequired = new List<USStatesAndTerritories>()
        {
            USStatesAndTerritories.Alaska,
            USStatesAndTerritories.Arizona,
            USStatesAndTerritories.Colorado,
            USStatesAndTerritories.Connecticut,
            USStatesAndTerritories.Delaware,
            USStatesAndTerritories.Iowa,
            USStatesAndTerritories.NorthDakota,
            USStatesAndTerritories.Oklahoma,
            USStatesAndTerritories.Utah,
            USStatesAndTerritories.Virginia,
            USStatesAndTerritories.WestVirginia,
            USStatesAndTerritories.Wyoming,
        };
        //from ballotpedia
        public static List<USStatesAndTerritories> NoVoterIDRequired = new List<USStatesAndTerritories>()
        {
            USStatesAndTerritories.California,
            USStatesAndTerritories.Hawaii,
            USStatesAndTerritories.Illinois,
            USStatesAndTerritories.Maine,
            USStatesAndTerritories.Maryland,
            USStatesAndTerritories.Massachusetts,
            USStatesAndTerritories.Minnesota,
            USStatesAndTerritories.Nevada,
            USStatesAndTerritories.NewJersey,
            USStatesAndTerritories.NewMexico,
            USStatesAndTerritories.NewYork,
            USStatesAndTerritories.Oregon,
            USStatesAndTerritories.Pennsylvania,
            USStatesAndTerritories.Vermont,
            USStatesAndTerritories.Washington,
            USStatesAndTerritories.WashingtonDC,
        };
        public static List<USStatesAndTerritories> NonCitizenVotingProhibitedStateAndLocalLevelWithStateConstitutionalAmendments = new List<USStatesAndTerritories>()
        {
            USStatesAndTerritories.Alabama,
            USStatesAndTerritories.Arizona,
            USStatesAndTerritories.Colorado,
            USStatesAndTerritories.Florida,
            USStatesAndTerritories.Idaho,
            USStatesAndTerritories.Iowa,
            USStatesAndTerritories.Kentucky,
            USStatesAndTerritories.Louisiana,
            USStatesAndTerritories.Missouri,
            USStatesAndTerritories.NorthCarolina,
            USStatesAndTerritories.NorthDakota,
            USStatesAndTerritories.Ohio,
            USStatesAndTerritories.Oklahoma,
            USStatesAndTerritories.SouthCarolina,
            USStatesAndTerritories.Wisconsin
        };

        public static class Alabama
        {
            public static class v2022
            {
                /// <summary>
                /// Total Ban on Abortion: Outlaws nearly all abortions in the state.
                /// Exception: Only allowed if necessary to prevent a serious health risk to the pregnant person.
                /// No Exceptions: No allowances for rape or incest.
                /// Performing an abortion is a Class A felony (punishable by up to 99 years in prison).
                /// Attempting to perform an abortion is a Class C felony (up to 10 years in prison).
                /// Penalties for Doctors Only: Pregnant individuals cannot be prosecuted for receiving an abortion.
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                [LawEnacted(2019, 5, 15)]
                public static class AlabamaHumanLifeProtectionAct { }
            }
        }

        public static class Arkansas
        {
            public static class v2019
            {
                /// <summary>
                /// Roe v Wade trigger law, total abortion ban, immediate upon attorney general certification
                /// Act 180
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class ArkansasHumanLifeProtectionAct { }
            }
        }

        public static class Florida
        {
            public static class v2022
            {
                /// <summary>
                /// House Bill 5 (HB 5) 
                /// 15-week abortion ban (previous restriction before the 6-week law).
                /// Only exceptions for fatal fetal abnormalities or serious risk to the pregnant woman.
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class ReducingFetalAndInfantMortalityAct { }
            }

            public static class v2023
            {
                /// <summary>
                /// Senate Bill 300 (SB 300)
                /// 6-week abortion ban, replacing HB 5.
                /// Includes limited exceptions (rape, incest, human trafficking) but only up to 15 weeks.
                /// Enforced as of May 2024, after a Florida Supreme Court ruling upheld abortion restrictions.
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class HeartbeatProtectionAct { }
            }
        }

        public static class Idaho
        {
            public static class v2020
            {
                /// <summary>
                /// Roe v Wade trigger law, total abortion ban, 30 days after ruling
                /// SB 1385
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class TriggerLaw { }
            }
        }

        public static class Indiana
        {
            public static class v2023
            {
                /// <summary>
                /// Senate Enrolled Act 1 (SEA 1)
                /// Total abortion ban with limited exceptions:
                /// 1. Rape or incest (only allowed up to 10 weeks post-fertilization).
                /// 2. Fetal anomalies (if the fetus has a lethal abnormality).
                /// 3. To save the life or prevent serious harm to the pregnant individual.
                /// Abortions can only be performed in hospitals or hospital-owned outpatient centers.
                /// Abortion clinics were forced to close (Planned Parenthood clinics in Indiana no longer perform abortions).
                /// Felony charges for doctors who perform abortions outside of exceptions.
                /// License revocation for violating the law.
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class NearTotalAbortionBan { }
            }
        }

        public static class Iowa
        {
            public static class v2023
            {
                /// <summary>
                /// Ban on abortion after 6 weeks
                /// Exceptions:
                /// 1. Rape (must be reported within 45 days).
                /// 2. Incest (must be reported within 140 days).
                /// 3. Fetal abnormalities deemed "incompatible with life".
                /// 4. To save the life of the pregnant woman or prevent serious risk of substantial bodily harm.
                /// Doctors who perform an abortion in violation of the law could lose their medical license.
                /// House File 732
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class FetalHeartbeatLaw { }
            }
        }

        public static class Kentucky
        {
            public static class v2019
            {
                /// <summary>
                /// Roe v Wade trigger law, total abortion ban, immediate upon attorney general certification
                /// KRS 311.772
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class KentuckyHumanLifeProtectionAct { }
            }
        }

        public static class Louisiana
        {
            public static class v2006
            {
                /// <summary>
                /// Roe v Wade trigger law, total abortion ban, immediate upon attorney general certification
                /// SB 184
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class LouisianaHumanLifeProtectionAct { }
            }
        }

        public static class Massachusetts
        {
            public static class v2022
            {
                /// <summary>
                /// Chapter 127 of the Acts of 2022
                /// 1. Shields abortion providers from criminal or civil liability if they provide 
                /// care to individuals from states where abortion is restricted.
                /// 2. Prevents Massachusetts courts from cooperating with out-of-state investigations 
                /// related to abortion or gender-affirming care.
                /// 3. Requires insurance companies to cover abortion care without co-pays or 
                /// deductibles.
                /// 4. Ensures access to medication abortion at public colleges and universities.
                /// 5. Clarifies that abortions after 24 weeks are allowed in cases of fatal fetal 
                /// anomalies or when necessary to protect the health of the pregnant person.
                /// 6. Protects healthcare providers who offer gender-affirming care from legal actions 
                /// brought by states with anti-LGBTQ+ laws.
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]

                public static class ActExpandingProtectionsForReproductiveAndGenderAffirmingCare { }
            }
        }

        public static class Minnesota
        {
            public static class v2023
            {
                /// <summary>
                /// This law affirms the fundamental right of individuals to make autonomous decisions
                /// about their reproductive health, including the right to abortion. 
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class ProtectReproductiveOptionsPROAct { }
            }
        }

        public static class Mississippi
        {
            public static class v2007
            {
                /// <summary>
                /// Roe v Wade trigger law, total abortion ban, taking effect 10 days after attorney general certification
                /// HB 1510
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class MississippiTriggerLaw { }
            }
        }

        public static class Missouri
        {
            public static class v2019
            {
                /// <summary>
                /// Roe v Wade trigger law, total abortion ban, taking effect immediately on attorney general certification
                /// HB 126
                /// </summary>
                [Observation("Only partially in force due to 2024 ballot initiative (still relevent for parental notification and bans post-viability abortion)")]
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class MissouriStandsForTheUnbornAct { }
            }
        }

        public static class NewHampshire
        {
            public static class v2021
            {
                /// <summary>
                /// House Bill 2 (HB 2) 
                /// Bans abortion after 24 weeks of pregnancy except in cases of
                /// * Fatal fetal anomalies
                /// * Risk to the life or health of the pregnant person
                /// No exceptions for rape or incest.
                /// Requires an ultrasound before any abortion, regardless of gestational age.
                /// Doctors who perform an abortion after 24 weeks face felony charges (Class B felony).
                /// The law allows civil lawsuits to be filed against doctors who perform post-24-week abortions.
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class FetalLifeProtectionAct { }
            }
        }

        public static class NorthCarolina
        {
            public static class v2023
            {
                /// <summary>
                /// 12-Week Limit: Abortions are permitted up to 12 weeks of pregnancy.
                /// Rape or Incest Exception: Allowed up to 20 weeks.
                /// "Life-Limiting" Fetal Anomalies Exception: Permitted up to 24 weeks.
                /// Maternal Health Exception: No gestational limit if the pregnant person's life or health is at
                /// serious risk.
                /// Mandatory Counseling: Requires an in-person counseling session at least 72 hours before the 
                /// procedure.
                /// Parental Consent: Minors under 18 must obtain consent from a parent or guardian, though a 
                /// judicial bypass is available.
                /// SB 20
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                [LawEnacted(2023, 5, 16)]
                [Observation("North Carolina remains one of the few Southern states allowing abortions beyond six weeks, making it a critical access point for residents of neighboring states with more restrictive laws.")]
                public static class CareForWomenChildrenAndFamiliesAct { }
            }
        }

        public static class NorthDakota
        {
            public static class v2007
            {
                /// <summary>
                /// Roe v Wade trigger law, total abortion ban
                /// SB 2193
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                [TODO("Legal challenges have yet to be resolved (2025-02-15")]
                public static class NorthDakotaAbortionBan { }
            }
        }

        public static class Oklahoma
        {
            public static class v2021
            {
                /// <summary>
                /// Roe v Wade trigger law, total abortion ban, immediately after Roe v Wade overturned
                /// SB 918
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class OklahomaAbortionBan { }
            }
        }

        public static class SouthDakota
        {
            public static class v2005
            {
                /// <summary>
                /// Roe v Wade trigger law, total abortion ban, immediately after Roe v Wade overturned
                /// SDCL 22-17-5.1
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class SouthDakotaTriggerLaw { }
            }
        }

        public static class Tennessee
        {
            public static class v2019
            {
                /// <summary>
                /// Roe v Wade trigger law, total abortion ban, taking effect 30 days after Roe v Wade overturned
                /// HB 2263
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class TennesseeHumanLifeProtectionAct { }
            }
        }

        public static class Texas
        {
            public static class v2021
            {
                /// <summary>
                /// Senate Bill 8 (SB 8) 
                /// Bans most abortions after about six weeks of pregnancy.
                /// Enforced through civil lawsuits by private citizens rather than state prosecution.
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                [LawEnacted(2021, 5, 19)]
                public static class TexasHeartbeatAct { }

                /// <summary>
                /// Senate Bill 4 (SB 4)
                /// Prohibits the use of abortion pills (mifepristone and misoprostol) after seven weeks of pregnancy.
                /// Criminalizes mail-order abortion pills.
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                [LawEnacted(2021, 9, 24)]
                public static class AbortionMedicationBan { }

                /// <summary>
                /// House Bill 1280 (HB 1280) 
                /// Took effect 30 days after Roe v. Wade was overturned in June 2022.
                /// Total abortion ban with exceptions only for saving the life of the pregnant woman
                /// Enforces criminal penalties (up to life in prison for doctors performing abortions).
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                [LawEnacted(2021, 6, 16)]
                public static class TriggerLaw { }
            }
        }

        public static class Utah
        {
            public static class v2020
            {
                /// <summary>
                /// Roe v Wade trigger law, total abortion ban
                /// SB 174
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                [TODO("Legal challenges have yet to be resolved (2025-02-15")]
                public static class UtahTriggerLaw { }
            }
        }

        public static class WestVirginia
        {
            public static class v2022
            {
                /// <summary>
                /// banned nearly all abortions in West Virginia, with exceptions for medical emergencies, 
                /// nonviable pregnancies, and limited cases of rape/incest (up to 8 weeks for adults and 14 
                /// weeks for minors, with law enforcement reporting requirements).
                /// HB 302
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                [LawEnacted(2022, 9, 16)]
                public static class UnbornChildProtectionAct { }
            }
        }

        public static class Wisconsin
        {
            public static class v1849
            {
                /// <summary>
                /// Wisconsin Statute § 940.04
                /// 1. Made it a felony to perform an abortion at any stage of pregnancy, except when necessary to save the 
                /// life of the mother.
                /// 2. Physicians or anyone assisting in an abortion could face up to six years in prison and fines.
                /// 3. The law did not explicitly penalize the pregnant person seeking an abortion.
                /// 4. Originally based on 19th-century common law perspectives that criminalized abortion once 
                /// pregnancy was detectable.
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                [Year(1849)]
                public static class WisconsinAbortionBan { }
            }
            public static class v2011
            {
                /// <summary>
                /// mandates that voters provide a government-issued photo identification before casting a ballot
                /// </summary>
                [StateLawSubject(StateLawSubjects.PhotoVoterID)]
                [YearDate(2011, 5, 25)]
                public static class Act23 { }
            }
        }

        public static class Wyoming
        {
            public static class v2022
            {
                /// <summary>
                /// Roe v Wade trigger law, total abortion ban
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                [TODO("Legal challenges have yet to be resolved (2025-02-15")]
                public static class WyomingAbortionBan { }
            }
        }
    }
}
