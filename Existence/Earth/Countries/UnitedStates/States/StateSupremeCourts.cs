using System;
using Existence.Earth.Alphabet;
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates.States
{
    public enum CourtCaseSubjects
    {
        Abortion
    }

    public class CourtCaseQuestionableAttribute : TextAttribute
    {
        public string Question
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }        }
        public CourtCaseQuestionableAttribute(string Question) : base(Question)
        {

        }
    }

    public class CourtCaseSubjectAttribute : Attribute
    {
        public CourtCaseSubjects Subject { get; set; }
        public CourtCaseSubjectAttribute(CourtCaseSubjects Subject)
        {
            this.Subject = Subject;
        }
    }

    internal class StateSupremeCourts
    {
        public static class Alaska
        {
            public static class v1997
            {
                /// <summary>
                /// The Alaska Supreme Court held that the right to privacy in the state constitution 
                /// includes the right to abortion, per Alaska Constitution, Article I, Section 22 (explicit 
                /// right to privacy)
                /// </summary>
                [CourtCaseSubject(CourtCaseSubjects.Abortion)]
                public static class ValleyHospitalAssocationvMatSuCoalitionForChoice { }
            }
        }

        public static class California
        {
            public static class v1981
            {
                /// <summary>
                /// The California Supreme Court ruled that the state constitution's right to privacy 
                /// protects abortion rights, per California Constitution, Article I, Section 1 
                /// (explicit right to privacy)
                /// </summary>
                [CourtCaseSubject(CourtCaseSubjects.Abortion)]
                public static class CommitteeToDefendReproductiveRightsvMyers { }
            }
        }

        public static class Florida
        {
            public static class v1989
            {
                /// <summary>
                /// The Florida Supreme Court ruled that the state constitution's privacy clause 
                /// protects abortion rights, per 
                /// Florida Constitution, Article I, Section 23 (explicit right to privacy).
                /// </summary>
                [CourtCaseQuestionable("Florida six-week abortion ban may survive future court scrutiny")]
                [CourtCaseSubject(CourtCaseSubjects.Abortion)]
                public static class InReTWAMinor {  }
            }
        }

        public static class Kansas
        {
            public static class v2019
            {
                /// <summary>
                /// 1. The Kansas Supreme Court ruled 6-1 that the Kansas Constitution guarantees the right to
                /// personal autonomy, including the right to make decisions about one's own body.
                /// 2. The court interpreted Section 1 of the Kansas Bill of Rights, which states that 
                /// "all men are possessed of equal and inalienable natural rights, among which are 
                /// life, liberty, and the pursuit of happiness," as protecting the right to abortion.
                /// 3. This ruling made abortion a constitutionally protected right in Kansas,
                /// independent of federal protections (such as Roe v. Wade, which was still in effect 
                /// at the time).
                /// 4. It prevented the state from enforcing a ban on D&E abortions and made it more 
                /// difficult for the Kansas legislature to restrict abortion access.
                /// per Kansas Constitution, Bill of Rights, Section 1 (natural rights and liberties)
                /// </summary>
                [YearDate(2019, 4, 26)]
                [CourtCaseSubject(CourtCaseSubjects.Abortion)]
                public static class HodesAndNauservSchmidt { }
            }
        }

        public class Massachusetts
        {
            public static class v1981
            {
                /// <summary>
                /// The Massachusetts Supreme Judicial Court ruled that the state constitution's 
                /// right to liberty and equal protection protects abortion
                /// per Massachusetts Declaration of Rights
                /// </summary>
                [CourtCaseSubject(CourtCaseSubjects.Abortion)]
                public static class MoevSecretaryOfAdministrationAndFinance { }
            }
        }

        public class Minnesota
        {
            public static class v1995
            {
                /// <summary>
                /// The Minnesota Supreme Court ruled that the state constitution protects abortion 
                /// as a fundamental right and that the government cannot restrict funding for the 
                /// procedure, per Minnesota Constitution’s guarantees of privacy and equal protection.
                /// </summary>
                [CourtCaseSubject(CourtCaseSubjects.Abortion)]
                public static class DoevGomez { }
            }
        }

        public class Montana
        {
            public static class v1999
            {
                /// <summary>
                /// The Montana Supreme Court ruled that the state constitution’s right to privacy includes abortion rights,
                /// per Montana Constitution, Article II, Section 10 (explicit right to privacy).
                /// </summary>
                [CourtCaseSubject(CourtCaseSubjects.Abortion)]
                public static class ArmstrongvState { }
            }
        }

        public static class NewJersey
        {
            public static class v1982
            {
                /// <summary>
                /// The New Jersey Supreme Court ruled that the state constitution’s right to equal 
                /// protection prohibits the government from restricting abortion access,
                /// per New Jersey Constitution’s guarantees of liberty and equal protection.
                /// </summary>
                [CourtCaseSubject(CourtCaseSubjects.Abortion)]
                public static class RightToChooseVByrne { }
            }
        }

        public static class Vermont
        {
            public static class v1972
            {
                /// <summary>
                /// The Vermont Supreme Court ruled that the state constitution protects reproductive autonomy,
                /// per Vermont Constitution’s protections of personal liberty
                /// </summary>
                [CourtCaseSubject(CourtCaseSubjects.Abortion)]
                public static class BeechamvLeahy { }
            }
        }
    }
}
