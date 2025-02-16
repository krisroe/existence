using Existence.Earth.Alphabet;
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates.States.Wisconsin
{
    public static class StateSupremeCourt
    {
        public static class Cases
        {
            public static class Term20212022
            {
                /// <summary>
                /// this addressed whether Frederick Prehn (appointed by Republican governor) could lawfully remain on the Wisconsin Natural Resources Board after his 
                /// term expired (Democratic governor wanted to replace him). However the governor and Republican controlled legislature could not confirm a
                /// replacement.
                /// The Court held that, under Wis. Stat. § 17.03, the expiration of Prehn's term did not create a vacancy. Therefore, Prehn could lawfully continue 
                /// to serve as a holdover member until a successor was both appointed by the Governor and confirmed by the Senate. During this period, Prehn could 
                /// only be removed by the Governor for cause, as stipulated in Wis. Stat. § 17.07(3).
                /// Justice Rebecca Dallet, joined by Justices Ann Walsh Bradley and Jill Karofsky, dissented, arguing that the majority's interpretation led to an 
                /// "absurd result" by allowing Prehn's expired six-year term to extend indefinitely, effectively granting him life tenure as long as he refused to 
                /// leave and the Senate didn't confirm a successor nominated by the Governor. The dissent emphasized that such a reading undermines the democratic 
                /// process and disrupts the intended balance of power, as it enables appointed officials to unilaterally extend their terms beyond the period 
                /// authorized by law. The dissenting justices contended that the expiration of a term should create a vacancy, allowing the Governor to appoint a 
                /// provisional replacement to ensure the proper functioning of government boards and agencies.
                /// </summary>
                [CourtCaseOralArgument(2022, 3, 10)]
                [CourtCaseDecided(2022, 6, 29)]
                public static class StateExRelKaulvPrehn { }
            }
            public static class Term20232024
            {
                /// <summary>
                /// The existing legislative district maps were found to be unconstitutional 
                /// because they failed the requirement for "contiguous territory" per the
                /// Constitution of Wisconsin
                /// </summary>
                [CourtCaseOralArgument(2023, 11, 21)]
                [CourtCaseDecided(2023, 12, 22)]
                public static class ClarkevWisconsinElectionsCommission { }
            }
            public static class Term20242025
            {
                /// <summary>
                /// Attorney General Kaul argues that the 1849 statute criminalizing abortion is 
                /// unenforceable for consensual abortions, especially in light of more recent 
                /// legislation. The outcome of this case is poised to have significant implications 
                /// for abortion rights in Wisconsin.
                /// </summary>
                [TODO("Future Case")]
                [CourtCaseOralArgument(2024, 11, 11)]
                public static class KaulvUrmanski { }

                /// <summary>
                /// ruled Meagan Wolfe lawfully continues as the Administrator of the Wisconsin Elections Commission (WEC), even though her term expired in June 2023. 
                /// The Court determined that the expiration of Wolfe's term did not create a vacancy necessitating a new appointment, and thus, the WEC is not obligated 
                /// to appoint a new administrator under these circumstances. This was consistent with the 2022 decision in State ex rel Kaul vs Prehn, although
                /// in a concurrence three justices agreed with the result even though they maintained Prehn was decided incorrectly.
                /// </summary>
                [CourtCaseOralArgument(2024, 11, 18)]
                [CourtCaseDecided(2025, 2, 7)]
                public static class WisconsinElectionsCommissionvLeMahieu { }
            }
        }
    }
}
