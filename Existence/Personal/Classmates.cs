
using System.Collections.Generic;

namespace Existence.Personal
{
    public class ClassmateBusinessLogic
    {
        public static List<KeyValuePair<ClassmateList, ClassmateList>> Friendships;
        public static List<ClassmateList> SeventhGradeSundaySchoolClassmates;

        /// <summary>
        /// teacher: Kathy Anderson
        /// </summary>
        public static List<ClassmateList> EighthGradeEnglishClassmates;

        public static List<ClassmateList> HighSchoolGradeClassmates;
        static ClassmateBusinessLogic()
        {
            Friendships = new List<KeyValuePair<ClassmateList, ClassmateList>>()
            {
                new KeyValuePair<ClassmateList, ClassmateList>(ClassmateList.JasonWhite, ClassmateList.JustinRaudebush)
            };
            SeventhGradeSundaySchoolClassmates = new List<ClassmateList>()
            {
                ClassmateList.JessicaLloyd,
                ClassmateList.CassieMattei,
                ClassmateList.StephanieHartman,
                ClassmateList.GregFarrington,
                ClassmateList.JasonWhite,
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
                ClassmateList.AlisaCantwell,
                ClassmateList.AmyKuklewicz,
                ClassmateList.AmberStrangstalien,
                ClassmateList.ChrisPulver,
                ClassmateList.DanSeiler,
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
        }
    }

    public enum ClassmateList
    {
        AbbyJoyce,
        AlisaCantwell,
        AmberStrangstalien,
        AmyKuklewicz,
        CassieMattei,
        /// <summary>
        /// formerly Chris Droste
        /// </summary>
        ChrisPulver,
        DanSeiler,
        GregFarrington,
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
        RochelleBaldwin,
        RyanWalker,
        StephanieHartman,
        TamekaGray,
        TonyLeggett,
        WayneCoder,
        ZachNemitz,
    }
}
