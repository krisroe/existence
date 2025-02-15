using System;
using Existence.Earth.Alphabet;
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates.States
{
    public enum StateLawSubjects
    {
        Abortion
    }

    public class StateLawSubjectAttribute : Attribute
    {
        public StateLawSubjects Subject { get; set; }
        public StateLawSubjectAttribute(StateLawSubjects Subject)
        {
            this.Subject = Subject;
        }
    }

    public class LawEnactedAttribute : YearDateAttribute
    {
        public LawEnactedAttribute(int Year, int Month, int Day) : base(Year, Month, Day)
        {
        }
    }

    public static class StateLaws
    {
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
