
using System.Collections.Generic;
using Existence.Song;

namespace Existence.Personal
{
    public class ClassmateBusinessLogic
    {
        public static List<KeyValuePair<ClassmateList, ClassmateList>> Friendships;

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
                new KeyValuePair<ClassmateList, ClassmateList>(ClassmateList.WhiteJason, ClassmateList.RaudebushJustin)
            };
            EighthGradeEnglishClassmates = new List<ClassmateList>()
            {
                ClassmateList.WatermanMegan,
                ClassmateList.HartmanStephanie,
                ClassmateList.CoderWayne,
                ClassmateList.PearceKristin,
            };
            HighSchoolGradeClassmates = new List<ClassmateList>()
            {
                ClassmateList.JoyceAbby,
                ClassmateList.OBrienAbby,
                ClassmateList.CantwellAlisa,
                ClassmateList.KuklewiczAmy,
                ClassmateList.StrangstalienAmber,
                ClassmateList.PulverChris,
                ClassmateList.SeilerDan,
                ClassmateList.PoulinDerek,
                ClassmateList.FarringtonGreg,
                ClassmateList.LaundrieHeidi,
                ClassmateList.WhiteJason,
                ClassmateList.CapelleJesse,
                ClassmateList.GrahamJess,
                ClassmateList.LloydJessica,
                ClassmateList.RybaskiJosh,
                ClassmateList.McFaulJudy,
                ClassmateList.RaudebushJustin,
                ClassmateList.PoffKim,
                ClassmateList.PearceKristin,
                ClassmateList.CummingsLaura,
                ClassmateList.PeytonLuke,
                ClassmateList.BeardMatt,
                ClassmateList.BremerNick,
                ClassmateList.MarshallOlivia,
                ClassmateList.BaldwinRochelle,
                ClassmateList.HartmanStephanie,
                ClassmateList.LeggettTony,
                ClassmateList.CoderWayne,
                ClassmateList.NemitzZach,
            };
            YouthSoccerTeam = new List<ClassmateList>()
            {
                ClassmateList.BorcherBrittany,
                ClassmateList.PoulinDerek,
            };
            TenthGradeUSHistoryClass = new List<int>()
            {
                (int)YearAboveClassmateList.WimannBrian,
                (int)YearBelowClassmateList.WisniewskiGreg,
                (int)YearAboveClassmateList.WisniewskiKatie,
            };
        }
    }

    public enum TwoYearBelowClassmateList
    {
        [MusicalInstrument(MusicalInstruments.Percussion)]
        RoweSonya,

        [MusicalInstrument(MusicalInstruments.Percussion)]
        SchlakeJason,
    }

    public enum YearBelowClassmateList
    {
        [MusicalInstrument(MusicalInstruments.SaxophoneTenor)]
        [MusicalGenre(MusicGenres.Jazz)]
        GuessJay,

        /// <summary>
        /// Mattei family owned Familyland around the time
        /// </summary>
        MatteiCassie,

        /// <summary>
        /// probably was 1st chair clarinet after me, third chair clarinet when I was a senior
        /// </summary>
        [MusicalInstrument(MusicalInstruments.Clarinet)]
        RotorMaria,

        [MusicalInstrument(MusicalInstruments.Trombone)]
        [MusicalGenre(MusicGenres.Jazz)]
        WisniewskiGreg,
    }

    public enum TwoYearAboveClassmateList
    {
        /// <summary>
        /// first chair clarinet before me (beat me in the test because of older privilege)
        /// </summary>
        [MusicalInstrument(MusicalInstruments.Clarinet)]
        CamposMelinda,

        [MusicalInstrument(MusicalInstruments.Clarinet)]
        CamposMelissa,

        [MusicalInstrument(MusicalInstruments.Trumpet)]
        JoyceAmy,
    }

    public enum YearAboveClassmateList
    {
        [MusicalInstrument(MusicalInstruments.Trombone)]
        BorudDavid,

        BraunCarol,

        DakterHeather,

        HamburgMelissa,

        /// <summary>
        /// third chair clarinet when I was a junior
        /// </summary>
        [MusicalInstrument(MusicalInstruments.Clarinet)]
        HammAnna,

        /// <summary>
        /// fourth chair clarinet when I was a junior
        /// </summary>
        [MusicalInstrument(MusicalInstruments.Clarinet)]
        JermierMegan,

        MitchellLisa,

        /// <summary>
        /// high school biology seatmate
        /// </summary>
        [MusicalInstrument(MusicalInstruments.Flute)]
        ScullyKatie,

        [MusicalInstrument(MusicalInstruments.Flute)]
        [MusicalInstrument(MusicalInstruments.Piccolo)]
        ToenjesMolly,

        [MusicalInstrument(MusicalInstruments.Trumpet)]
        [MusicalGenre(MusicGenres.Jazz)]
        WimannBrian,

        [MusicalInstrument(MusicalInstruments.SaxophoneTenor)]
        [MusicalGenre(MusicGenres.Jazz)]
        WisniewskiKatie,
    }

    public enum ClassmateList
    {
        /// <summary>
        /// church of God
        /// </summary>
        [MusicalInstrument(MusicalInstruments.Flute)]
        BaldwinRochelle,

        /// <summary>
        /// second chair clarinet when I was a junior and senior
        /// </summary>
        [MusicalInstrument(MusicalInstruments.Clarinet)]
        [MusicalInstrument(MusicalInstruments.Bassoon)]
        BeardMatt,

        BorcherBrittany,

        /// <summary>
        /// first chair trumpet when I was a senior
        /// </summary>
        [MusicalGenre(MusicGenres.Jazz)]
        [MusicalInstrument(MusicalInstruments.Trumpet)]
        BremerNick,

        CantwellAlisa,

        CapelleJesse,

        ClarkTJ,

        CoderWayne,

        [MusicalInstrument(MusicalInstruments.Trombone)]
        CummingsLaura,

        FarringtonGreg,

        FelaMark,

        GrahamJess,

        GrayTameka,

        HartmanStephanie,

        [MusicalInstrument(MusicalInstruments.Percussion)]
        JoyceAbby,

        /// <summary>
        /// second chair flute when I was a senior
        /// </summary>
        [MusicalInstrument(MusicalInstruments.Flute)]
        KuklewiczAmy,

        LagodaGreg,

        [MusicalInstrument(MusicalInstruments.Flute)]
        LaundrieHeidi,

        LeggettTony,

        LloydJessica,

        /// <summary>
        /// first chair flute when I was a senior
        /// </summary>
        [MusicalInstrument(MusicalInstruments.Flute)]
        MarshallOlivia,

        MartinskiPaul,

        /// <summary>
        /// not sure on the spelling, he was Indian (presumably Ho Chunk)
        /// </summary>
        MatalongoMato,

        McFaulJudy,

        /// <summary>
        /// second chair trumpet when I was a senior
        /// </summary>
        [MusicalInstrument(MusicalInstruments.Trumpet)]
        [MusicalGenre(MusicGenres.Jazz)]
        NemitzZach,

        /// <summary>
        /// something embarrassing related to "the jerk" happened in health class 7th grade? 8th grade?
        /// </summary>
        OBrienAbby,

        PearceKristin,

        PeytonLuke,

        PoffKim,

        PoulinDerek,

        /// <summary>
        /// formerly Chris Droste
        /// </summary>
        PulverChris,

        RaudebushJustin,

        [MusicalInstrumentGenre(MusicalInstruments.Piano, MusicGenres.Jazz)]
        [MusicalInstrument(MusicalInstruments.Clarinet)]
        RoweChris,

        [MusicalInstrument(MusicalInstruments.SaxophoneAlto)]
        [MusicalGenre(MusicGenres.Jazz)]
        RybaskiJosh,

        [MusicalInstrument(MusicalInstruments.Tuba)]
        SeilerDan,

        /// <summary>
        /// got pregnant as a teenager
        /// </summary>
        StrangstalienAmber,

        /// <summary>
        /// left-handed, ticklish
        /// </summary>
        WalkerRyan,

        /// <summary>
        /// Family owned Noah's Ark around the time
        /// </summary>
        WatermanMegan,

        WhiteJason,
    }
}
