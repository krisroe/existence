using System;

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

    public static class StateLaws
    {
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
                public static class TexasHeartbeatAct { }

                /// <summary>
                /// Senate Bill 4 (SB 4)
                /// Prohibits the use of abortion pills (mifepristone and misoprostol) after seven weeks of pregnancy.
                /// Criminalizes mail-order abortion pills.
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class AbortionMedicationBan { }
            }
            public static class v2022
            {
                /// <summary>
                /// House Bill 1280 (HB 1280) 
                /// Took effect after Roe v. Wade was overturned in June 2022.
                /// Total abortion ban with exceptions only for saving the life of the pregnant woman
                /// Enforces criminal penalties (up to life in prison for doctors performing abortions).
                /// </summary>
                [StateLawSubject(StateLawSubjects.Abortion)]
                public static class TriggerLaw { }
            }
        }
    }
}
