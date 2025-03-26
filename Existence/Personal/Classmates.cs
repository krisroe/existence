
using System.Collections.Generic;

namespace Existence.Personal
{
    public class ClassmateBusinessLogic
    {
        public static List<KeyValuePair<ClassmateList, ClassmateList>> Friendships;
        public static List<int> SeventhGradeSundaySchoolClassmates;

        /// <summary>
        /// teacher: Kathy Anderson
        /// </summary>
        public static List<ClassmateList> EighthGradeEnglishClassmates;

        public static List<ClassmateList> HighSchoolGradeClassmates;

        /// <summary>
        /// teacher: Mr. Park
        /// </summary>
        public static List<int> TenthGradeUSHistoryClass;

        /// <summary>
        /// coach: Ed O'Brian (Quit your bitchin')
        /// </summary>
        public static List<ClassmateList> YouthSoccerTeam;

        static ClassmateBusinessLogic()
        {
            Friendships = new List<KeyValuePair<ClassmateList, ClassmateList>>()
            {
                new KeyValuePair<ClassmateList, ClassmateList>(ClassmateList.JasonWhite, ClassmateList.JustinRaudebush)
            };
            SeventhGradeSundaySchoolClassmates = new List<int>()
            {
                (int)ClassmateList.JessicaLloyd,
                (int)YearBelowClassmateList.CassieMattei,
                (int)ClassmateList.StephanieHartman,
                (int)ClassmateList.GregFarrington,
                (int)ClassmateList.JasonWhite,
            };
            EighthGradeEnglishClassmates = new List<ClassmateList>()
            {
                ClassmateList.MeganWaterman,
                ClassmateList.StephanieHartman,
                ClassmateList.WayneCoder,
                ClassmateList.KristinPearce,
            };
            HighSchoolGradeClassmates = new List<ClassmateList>()
            {
                ClassmateList.AbbyJoyce,
                ClassmateList.AbbyOBrien,
                ClassmateList.AlisaCantwell,
                ClassmateList.AmyKuklewicz,
                ClassmateList.AmberStrangstalien,
                ClassmateList.ChrisPulver,
                ClassmateList.DanSeiler,
                ClassmateList.DerekPoulin,
                ClassmateList.GregFarrington,
                ClassmateList.HeidiLaundrie,
                ClassmateList.JasonWhite,
                ClassmateList.JesseCapelle,
                ClassmateList.JessGraham,
                ClassmateList.JessicaLloyd,
                ClassmateList.JoshRybaski,
                ClassmateList.JudyMcFaul,
                ClassmateList.JustinRaudebush,
                ClassmateList.KimPoff,
                ClassmateList.KristinPearce,
                ClassmateList.LauraCummings,
                ClassmateList.LukePeyton,
                ClassmateList.MattBeard,
                ClassmateList.NickBremer,
                ClassmateList.OliviaMarshall,
                ClassmateList.RochelleBaldwin,
                ClassmateList.StephanieHartman,
                ClassmateList.TonyLeggett,
                ClassmateList.WayneCoder,
                ClassmateList.ZachNemitz,
            };
            YouthSoccerTeam = new List<ClassmateList>()
            {
                ClassmateList.BrittanyBorcher,
                ClassmateList.DerekPoulin,
            };
            TenthGradeUSHistoryClass = new List<int>()
            {
                (int)YearAboveClassmateList.BrianWimann,
                (int)YearBelowClassmateList.GregWisniewski,
                (int)YearAboveClassmateList.KatieWisniewski,                
            };
        }
    }

    public enum YearBelowClassmateList
    {
        GregWisniewski,
        CassieMattei,
    }

    public enum YearAboveClassmateList
    {
        BrianWimann,
        KatieWisniewski,
    }

    public enum ClassmateList
    {
        AbbyJoyce,
        /// <summary>
        /// something embarrassing related to "the jerk" happened in health class 7th grade? 8th grade?
        /// </summary>
        AbbyOBrien,
        AlisaCantwell,
        /// <summary>
        /// got pregnant
        /// </summary>
        AmberStrangstalien,
        AmyKuklewicz,
        BrittanyBorcher,
        /// <summary>
        /// formerly Chris Droste
        /// </summary>
        ChrisPulver,
        DanSeiler,
        DerekPoulin,
        GregFarrington,
        GregLagoda,
        HeidiLaundrie,
        JasonWhite,
        JesseCapelle,
        JessGraham,
        JessicaLloyd,
        JoshRybaski,
        JudyMcFaul,
        JustinRaudebush,
        KimPoff,
        KristinPearce,
        LauraCummings,
        LukePeyton,
        /// <summary>
        /// not sure on the spelling, he was Indian (presumably Ho Chunk)
        /// </summary>
        MatoMatalongo,
        MattBeard,
        MeganWaterman,
        NickBremer,
        OliviaMarshall,
        PaulMartinski,
        /// <summary>
        /// church of God
        /// </summary>
        RochelleBaldwin,
        RyanWalker,
        StephanieHartman,
        TamekaGray,
        TonyLeggett,
        WayneCoder,
        ZachNemitz,
    }
}
