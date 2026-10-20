
using Existence.Earth.Alphabet;
using Existence.Earth.Countries;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Time;
using System;

namespace Existence.Earth.War
{
    public class HostagesAttribute : Attribute
    {
        public HostageList[] Hostages { get; set; }
        public HostagesAttribute(params HostageList[] Hostages)
        {
            this.Hostages = Hostages;
        }
    }

    public class HostageOutcomeAttribute : Attribute
    {
        public HostageOutcome Outcome { get; set; }
        public HostageOutcomeAttribute(HostageOutcome Outcome)
        {
            this.Outcome = Outcome;
        }
    }

    public enum HostageOutcome
    {
        ReleasedBody,
        ReleasedAlive,
        RemainsIdentified,
        RecoveredBody,
        RecoveredBodyKilledByIsrael,
        RescuedAlive,
    }

    /// <summary>
    /// https://www.israelhayom.com/2023/10/31/these-are-the-captives-held-by-hamas/
    /// </summary>
    public enum HostageList
    {
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(38, TimePeriods.Years)]
        AdarTamir = 1,
        [Country(CountryLikeThings.Israel)]
        [Age(85, TimePeriods.Years)]
        AdarYafa = 2,
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [Age(20, TimePeriods.Years)]
        AhimasTomerYaakov = 3,
        /// <summary>
        /// Bedouin
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant Major")]
        [Age(39, TimePeriods.Years)]
        AlAtreshMuhammad = 4,
        [Country(CountryLikeThings.Israel)]
        [Age(44, TimePeriods.Years)]
        AloniDaniel = 5,
        [Country(CountryLikeThings.Israel)]
        [Age(5, TimePeriods.Years)]
        AloniEmelia = 6,
        [Country(CountryLikeThings.Israel)]
        [PreviouslyHeldAsHostage]
        [Age(27, TimePeriods.Years)]
        AlSayedHishamShaaban = 7,
        [Country(CountryLikeThings.Israel)]
        [Age(22, TimePeriods.Years)]
        AlZayadniHamzah = 8,
        [Country(CountryLikeThings.Israel)]
        [ApproximateAgeInYears(52, 53)]
        AlZayadniYosef = 9,
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [Age(18, TimePeriods.Years)]
        AlbagLiri = 10,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [Age(19, TimePeriods.Years)]
        AlexanderEdan = 11,

        [Country(CountryLikeThings.Israel)]
        [Age(51, TimePeriods.Years)]
        AlkadiQaidFarhan = 12,
        [Country(CountryLikeThings.Thailand)]
        [Age(28, TimePeriods.Years)]
        AngkaewAnucha = 13,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Bulgaria)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [Age(20, TimePeriods.Years)]
        AngrestMatan = 14,
        [Country(CountryLikeThings.Israel)]
        [Age(25, TimePeriods.Years)]
        ArgamaniNoa = 15,
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [Age(19, TimePeriods.Years)]
        ArievKarina = 16,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(2, TimePeriods.Years)]
        AsherAviv = 17,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(34, TimePeriods.Years)]
        AsherDoronKatz = 18,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(4, TimePeriods.Years)]
        AsherRaz = 19,
        /// <summary>
        /// related to BeininLiat
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(49, TimePeriods.Years)]
        AtziliAviv = 20,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(12, TimePeriods.Years)]
        AvigdoriNoam = 21,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(52, TimePeriods.Years)]
        AvigdoriSharon = 22,
        [Country(CountryLikeThings.Israel)]
        [Age(84, TimePeriods.Years)]
        AvrihamElma = 23,
        [Countries(CountryLikeThings.Philippines, CountryLikeThings.Israel)]
        [Age(60, TimePeriods.Years)]
        BabadillaNoralin = 24,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Bulgaria)]
        [Age(24, TimePeriods.Years)]
        BaruchSahar = 25,
        [Country(CountryLikeThings.Israel)]
        [Age(34, TimePeriods.Years)]
        BaruchUriael = 26,
        /// <summary>
        /// related to Aviv Atzili
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [Age(49, TimePeriods.Years)]
        BeininLiat = 27,
        /// <summary>
        /// killed in IDF airstrike
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Corporal")]
        [Age(19, TimePeriods.Years)]
        BeizerNik = 28,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(54, TimePeriods.Years)]
        BenAmiOhad = 29,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(56, TimePeriods.Years)]
        BenAmiRaz = 30,
        [Country(CountryLikeThings.Israel)]
        [Age(53, TimePeriods.Years)]
        BenjaminRon = 31,
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [Age(19, TimePeriods.Years)]
        BergerAgam = 32,

        /// <summary>
        /// Gali/Ziv Berman are twins
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(26, TimePeriods.Years)]
        BermanGali = 33,

        /// <summary>
        /// Gali/Ziv Berman are twins
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(26, TimePeriods.Years)]
        BermanZiv = 34,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina, CountryLikeThings.Germany)]
        [Age(4, TimePeriods.Years)]
        BibasAriel = 35,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina, CountryLikeThings.Germany)]
        [Age(8, TimePeriods.Months)]
        BibasKfir = 36,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina, CountryLikeThings.Germany)]
        [Age(32, TimePeriods.Years)]
        BibasShiri = 37,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(33, TimePeriods.Years)]
        BibasYarden = 38,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Colombia)]
        [Age(34, TimePeriods.Years)]
        BohbotElkana = 39,

        [Country(CountryLikeThings.Thailand)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        BoonpromSanti = 40,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(19, TimePeriods.Years)]
        BraslavskiRom = 41,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [Age(19, TimePeriods.Years)]
        BrodskiKiril = 42,
        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(40, TimePeriods.Years)]
        BrodutchHagar = 43,
        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(9, TimePeriods.Years)]
        BrodutchOfri = 44,
        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(4, TimePeriods.Years)]
        BrodutchOriya = 45,
        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(9, TimePeriods.Years)]
        BrodutchYuval = 46,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(36, TimePeriods.Years)]
        BuchshtavRimonKirsht = 47,
        /// <summary>
        /// Buckshtav?
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(34, TimePeriods.Years)]
        BuchshtabYagev = 48,
        [Country(CountryLikeThings.Israel)]
        [Age(27, TimePeriods.Years)]
        BuskilaEstherAmit = 49,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany, CountryLikeThings.UnitedStates)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [Age(19, TimePeriods.Years)]
        ChenItay = 50,
        [Country(CountryLikeThings.Thailand)]
        [Age(29, TimePeriods.Years)]
        ChombuaKomkrit = 51,
        [Country(CountryLikeThings.Israel)]
        [Age(26, TimePeriods.Years)]
        CohenEliya = 52,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [Age(19, TimePeriods.Years)]
        CohenNimrod = 53,

        /// <summary>
        /// girlfriend of Alexandre (Sasha) Troufanov
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(29, TimePeriods.Years)]
        CohenSapir = 54,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [Age(84, TimePeriods.Years)]
        CooperAmiram = 55,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(26, TimePeriods.Years)]
        CunioAriel = 56,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(33, TimePeriods.Years)]
        CunioDavid = 57,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(3, TimePeriods.Years)]
        CunioEmma = 58,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(34, TimePeriods.Years)]
        CunioSharonOlani = 59,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(3, TimePeriods.Years)]
        CunioYuli = 60,
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Command Sergeant Major")]
        [Age(36, TimePeriods.Years)]
        DadoZiv = 61,
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [Age(19, TimePeriods.Years)]
        DahanShaked = 62,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedKingdom)]
        [Age(27, TimePeriods.Years)]
        DamariEmily = 63,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [Age(75, TimePeriods.Years)]
        DancygAlexander = 64,
        /// <summary>
        /// executed by Hamas
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(24, TimePeriods.Years)]
        DaninoOri = 65,

        [Country(CountryLikeThings.Israel)]
        [Age(22, TimePeriods.Years)]
        DavidEvyatar = 66,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [Age(35, TimePeriods.Years)]
        DekelChenSagui = 67,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [Age(3, TimePeriods.Years)]
        EdanAbigail = 68,
        [Country(CountryLikeThings.Israel)]
        [Age(68, TimePeriods.Years)]
        ElgaratItzhk = 69,
        [Country(CountryLikeThings.Israel)]
        [Age(15, TimePeriods.Years)]
        ElyakimDafna = 70,
        [Country(CountryLikeThings.Israel)]
        [Age(8, TimePeriods.Years)]
        ElyakimEla = 71,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(51, TimePeriods.Years)]
        EngelBartKarina = 72,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(18, TimePeriods.Years)]
        EngelMika = 73,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Netherlands)]
        [Age(17, TimePeriods.Years)]
        EngelOfir = 74,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(54, TimePeriods.Years)]
        EngelRonan = 75,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(11, TimePeriods.Years)]
        EngelYuval = 76,
        /// <summary>
        /// executed by Hamas
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(39, TimePeriods.Years)]
        GatCarmel = 77,
        [Country(CountryLikeThings.Israel)]
        [Age(56, TimePeriods.Years)]
        GelerenterItzhak = 78,
        /// <summary>
        /// originally named Danielle
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Bulgaria)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [Age(19, TimePeriods.Years)]
        GilboaDaniella = 79,

        /// <summary>
        /// Guy Gilboa-Dalal
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(22, TimePeriods.Years)]
        GilboaDalalGuy = 80,

        [Country(CountryLikeThings.Israel)]
        [Age(73, TimePeriods.Years)]
        GodardManny = 81,

        /// <summary>
        /// executed by Hamas
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [Age(23, TimePeriods.Years)]
        GoldbergPolinHersh = 82,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Lieutenant")]
        [PreviouslyHeldAsHostage]
        [Age(23, TimePeriods.Years)]
        GoldinHadar = 83,

        [Country(CountryLikeThings.Israel)]
        [Age(33, TimePeriods.Years)]
        GoldinOren = 84,
        [Country(CountryLikeThings.Israel)]
        [Age(17, TimePeriods.Years)]
        GoldsteinAlmogAgam = 85,
        [Country(CountryLikeThings.Israel)]
        [Age(48, TimePeriods.Years)]
        GoldsteinAlmogChen = 86,
        [Country(CountryLikeThings.Israel)]
        [Age(11, TimePeriods.Years)]
        GoldsteinAlmogGal = 87,
        [Country(CountryLikeThings.Israel)]
        [Age(9, TimePeriods.Years)]
        GoldsteinAlmogTal = 88,
        [Country(CountryLikeThings.Israel)]
        [Age(23, TimePeriods.Years)]
        GonenRomi = 89,
        [Country(CountryLikeThings.Israel)]
        [Age(56, TimePeriods.Years)]
        GorenMaya = 90,
        [Countries(CountryLikeThings.Uruguay, CountryLikeThings.Israel)]
        [Age(29, TimePeriods.Years)]
        GorenShani = 91,
        [Countries(CountryLikeThings.Mexico, CountryLikeThings.Israel)]
        [Age(30, TimePeriods.Years)]
        GritzewskyIlana = 92,

        /// <summary>
        /// aka Rani, last hostage accounted for
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(24, TimePeriods.Years)]
        GviliRan = 93,

        /// <summary>
        /// aka Gadi
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [Age(72, TimePeriods.Years)]
        HaggaiGad = 94,

        /// <summary>
        /// killed by friendly fire while surrendering
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [Age(28, TimePeriods.Years)]
        HaimYotam = 95,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Romania)]
        [Age(41, TimePeriods.Years)]
        HaimiTal = 96,
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Colonel")]
        [Age(40, TimePeriods.Years)]
        HamamiAsaf = 97,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Ireland)]
        [Age(8, TimePeriods.Years)]
        HandEmily = 98,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(67, TimePeriods.Years)]
        HaranShoshan = 99,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(70, TimePeriods.Years)]
        HarLuis = 100,
        [Country(CountryLikeThings.Israel)]
        [Age(27, TimePeriods.Years)]
        HaymanInbar = 101,
        [Country(CountryLikeThings.Israel)]
        [Age(84, TimePeriods.Years)]
        HeimanDitza = 102,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia, CountryLikeThings.Ukraine)]
        [Age(35, TimePeriods.Years)]
        HerkinMaxim = 103,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(37, TimePeriods.Years)]
        HornEitan = 104,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(45, TimePeriods.Years)]
        HornIair = 105,
        [Country(CountryLikeThings.Israel)]
        [Age(49, TimePeriods.Years)]
        IdanTsachi = 106,
        [Country(CountryLikeThings.Israel)]
        [Age(26, TimePeriods.Years)]
        IluzGuy = 107,
        [Country(CountryLikeThings.Thailand)]
        [Age(29, TimePeriods.Years)]
        JirachartManee = 108,

        [Country(CountryLikeThings.Nepal)]
        [Age(22, TimePeriods.Years)]
        JoshiBipin = 109,

        [Country(CountryLikeThings.Thailand)]
        [Age(28, TimePeriods.Years)]
        KalapratVichai = 110,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [Age(11, TimePeriods.Years)]
        KalderonErez = 111,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.France, CountryLikeThings.Portugal)]
        [Age(52, TimePeriods.Years)]
        KalderonOfer = 112,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [Age(16, TimePeriods.Years)]
        KalderonSahar = 113,

        [Country(CountryLikeThings.Israel)]
        [Age(25, TimePeriods.Years)]
        KalfonSegev = 114,

        [Country(CountryLikeThings.Israel)]
        [Age(76, TimePeriods.Years)]
        KatzirHannah = 115,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [Age(47, TimePeriods.Years)]
        KatznirElad = 116,
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant Major (res.)")]
        [Age(51, TimePeriods.Years)]
        KatzRavid = 117,
        [Country(CountryLikeThings.Israel)]
        [Age(70, TimePeriods.Years)]
        KeidarOfra = 118,
        [Country(CountryLikeThings.Thailand)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        KesoognernSurin = 119,
        [Country(CountryLikeThings.Thailand)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        KongmaneeBancha = 120,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [Age(27, TimePeriods.Years)]
        KozlovAndrey = 121,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [Age(25, TimePeriods.Years)]
        KriboyRoni = 122,

        /// <summary>
        /// aka Kuperstein
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(21, TimePeriods.Years)]
        KupershteinBar = 123,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(59, TimePeriods.Years)]
        LeimbergGabriela = 124,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(17, TimePeriods.Years)]
        LeimbertMia = 125,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [Age(19, TimePeriods.Years)]
        LevinsonShay = 126,
        [Country(CountryLikeThings.Israel)]
        [Age(53, TimePeriods.Years)]
        LevyEitan = 127,
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [Age(19, TimePeriods.Years)]
        LevyNaama = 128,
        [Country(CountryLikeThings.Israel)]
        [Age(33, TimePeriods.Years)]
        LevyOr = 129,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland, CountryLikeThings.Germany)]
        [Age(83, TimePeriods.Years)]
        LifshitzOded = 130,
        /// <summary>
        /// woman
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(85, TimePeriods.Years)]
        LifshitzYokheved = 131,
        /// <summary>
        /// executed by Hamas
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [Age(32, TimePeriods.Years)]
        LobanovAlexander = 132,
        [Countries(CountryLikeThings.Germany, CountryLikeThings.Israel)]
        [Age(22, TimePeriods.Years)]
        LoukShani = 133,
        [Country(CountryLikeThings.Israel)]
        [Age(85, TimePeriods.Years)]
        MansourShlomo = 134,
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Corporal")]
        [Age(18, TimePeriods.Years)]
        MarcianoNoa = 135,
        [Country(CountryLikeThings.Israel)]
        [Age(75, TimePeriods.Years)]
        MargalitEliyahu = 136,
        [Country(CountryLikeThings.Israel)]
        [Age(41, TimePeriods.Years)]
        MargalitNili = 137,
        /// <summary>
        /// female
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Private")]
        [Age(19, TimePeriods.Years)]
        MegidishOri = 138,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [Age(21, TimePeriods.Years)]
        MeirJanAlmog = 139,
        [Countries(CountryLikeThings.Ethiopia, CountryLikeThings.Israel)]
        [PreviouslyHeldAsHostage]
        [Age(28, TimePeriods.Years)]
        MengistuAvera = 140,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(62, TimePeriods.Years)]
        MermanClara = 141,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(60, TimePeriods.Years)]
        MermanFernandoSimon = 142,
        [Country(CountryLikeThings.Israel)]
        [Age(78, TimePeriods.Years)]
        MetzgerTamar = 143,
        [Country(CountryLikeThings.Israel)]
        [Age(80, TimePeriods.Years)]
        MetzgerYoram = 144,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Hungary)]
        [Age(46, TimePeriods.Years)]
        MiranOmri = 145,

        [Country(CountryLikeThings.Tanzania)]
        [Age(21, TimePeriods.Years)]
        MollelJoshua = 146,

        [Country(CountryLikeThings.Israel)]
        [Age(23, TimePeriods.Years)]
        MorEitanAbraham = 147,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [Age(72, TimePeriods.Years)]
        MosheAdina = 148,
        /// <summary>
        /// member of Kibbutz Nir Or
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [ApproximateAgeInYears(77, 78)]
        MosesMargalit = 149,
        /// <summary>
        /// [sometimes refered to as Gadi Moses]
        /// His partner, Efrat Katz was presumed captive as well, but was likely killed
        /// 2023-10-07 by an Israeli helicopter gunship responding to the assault. The
        /// helicopter targeted a vehicle carrying Hamas gunmen, unaware that hostages
        /// were also inside.
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(79, TimePeriods.Years)]
        MozesGadiMoshe = 150,
        [Country(CountryLikeThings.Israel)]
        [Age(78, TimePeriods.Years)]
        MunderAbraham = 151,
        [Country(CountryLikeThings.Israel)]
        [Age(54, TimePeriods.Years)]
        MunderKeren = 152,
        [Country(CountryLikeThings.Israel)]
        [Age(8, TimePeriods.Years)]
        MunderOhad = 153,
        [Country(CountryLikeThings.Israel)]
        [Age(78, TimePeriods.Years)]
        MunderRuth = 154,
        [Country(CountryLikeThings.Thailand)]
        [Age(35, TimePeriods.Years)]
        MunkanNattawaree = 155,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [IsraelDefenceForcesSoldier("Captain")]
        [Age(21, TimePeriods.Years)]
        NeutraOmerMaxim = 156,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [Age(18, TimePeriods.Years)]
        NimrodTamir = 157,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Brazil)]
        [Age(59, TimePeriods.Years)]
        NisenbaumMichel = 158,

        [Country(CountryLikeThings.Thailand)]
        [Age(30, TimePeriods.Years)]
        OakkharasriSonthaya = 159,

        /// <summary>
        /// Yosek-Haim Ohana
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(23, TimePeriods.Years)]
        OhanaYosefHaim = 160,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Serbia, CountryLikeThings.Germany)]
        [Age(22, TimePeriods.Years)]
        OhelAlon = 161,

        [Country(CountryLikeThings.Thailand)]
        [Age(26, TimePeriods.Years)]
        OnkaewNatthaporn = 162,
        [Country(CountryLikeThings.Israel)]
        [Age(13, TimePeriods.Years)]
        OrAlma = 163,

        [Country(CountryLikeThings.Israel)]
        [Age(30, TimePeriods.Years)]
        OrAvinathan = 164,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [Age(48, TimePeriods.Years)]
        OrDror = 165,

        [Country(CountryLikeThings.Israel)]
        [Age(18, TimePeriods.Years)]
        OrLiam = 166,
        [Country(CountryLikeThings.Israel)]
        [Age(17, TimePeriods.Years)]
        OrNoam = 167,
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [Age(19, TimePeriods.Years)]
        OzDaniel = 168,
        [Country(CountryLikeThings.Philippines)]
        [Age(33, TimePeriods.Years)]
        PachecoGelienorJimmy = 169,
        [Country(CountryLikeThings.Thailand)]
        [Age(45, TimePeriods.Years)]
        PankhongBoonthom = 170,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.SouthAfrica)]
        [IsraelDefenceForcesSoldier("Captain")]
        [Age(22, TimePeriods.Years)]
        PerezDaniel = 171,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [Age(79, TimePeriods.Years)]
        PeriChaim = 172,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.SouthAfrica)]
        [Age(79, TimePeriods.Years)]
        PeriChanna = 173,
        [Country(CountryLikeThings.Thailand)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        PhachuabboonMongkol = 174,
        [Country(CountryLikeThings.Thailand)]
        [Age(33, TimePeriods.Years)]
        PhoomeVetoon = 175,
        [Country(CountryLikeThings.Thailand)]
        [Age(30, TimePeriods.Years)]
        PinakalowPornsawan = 176,
        [Country(CountryLikeThings.Thailand)]
        [ApproximateAgeInYears(35, 36)]
        PintaNattapong = 177,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedKingdom)]
        [Age(51, TimePeriods.Years)]
        PopplewellNadav = 178,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [Age(59, TimePeriods.Years)]
        RaananJudith = 179,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [Age(17, TimePeriods.Years)]
        RaananNatalie = 180,
        [Countries(CountryLikeThings.Mexico, CountryLikeThings.France)]
        [Age(30, TimePeriods.Years)]
        RadouxOriónHernández = 181,
        [Country(CountryLikeThings.Thailand)]
        [Age(42, TimePeriods.Years)]
        RataninPaiboon = 182,
        [Country(CountryLikeThings.Israel)]
        [Age(18, TimePeriods.Years)]
        RegevItay = 183,
        [Country(CountryLikeThings.Israel)]
        [Age(21, TimePeriods.Years)]
        RegevMaya = 184,
        [Country(CountryLikeThings.Thailand)]
        [ApproximateAgeInYears(42, 43)]
        RinthalakSudthisak = 185,
        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(77, TimePeriods.Years)]
        RoitmanOfelia = 186,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(35, TimePeriods.Years)]
        RomanGatYarden = 187,
        [Country(CountryLikeThings.Thailand)]
        [ApproximateAgeInYears(30, 31)]
        RumnaoSurasak = 188,
        [Country(CountryLikeThings.Israel)]
        [Age(54, TimePeriods.Years)]
        RotemRaaya = 189,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [Age(61, TimePeriods.Years)]
        RudaeffLior = 190,

        [Country(CountryLikeThings.Thailand)]
        [Age(26, TimePeriods.Years)]
        SaelaoKong = 191,
        [Country(CountryLikeThings.Thailand)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SaengboonBuddhee = 192,
        [Country(CountryLikeThings.Thailand)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SaengnuanUthai = 193,
        [Country(CountryLikeThings.Thailand)]
        [Age(27, TimePeriods.Years)]
        SaethaoBannawat = 194,
        [Country(CountryLikeThings.Israel)]
        [Age(74, TimePeriods.Years)]
        SagiAda = 195,
        [Country(CountryLikeThings.Israel)]
        [Age(21, TimePeriods.Years)]
        SameranoYonatan = 196,
        [Country(CountryLikeThings.Thailand)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SangkaewChalermchai = 197,
        /// <summary>
        /// executed by Hamas
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(26, TimePeriods.Years)]
        SarusiAlmog = 198,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [Age(21, TimePeriods.Years)]
        SchemMia = 199,
        /// <summary>
        /// killed by friendly fire while surrendering
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(26, TimePeriods.Years)]
        ShamrizAlon = 200,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(15, TimePeriods.Years)]
        ShaniAmit = 201,
        /// <summary>
        /// Sibling of Yossi Sharabi
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(51, TimePeriods.Years)]
        SharabiEli = 202,
        /// <summary>
        /// Sibling of Eli Sharabi
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [Age(53, TimePeriods.Years)]
        SharabiYossi = 203,
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [PreviouslyHeldAsHostage]
        [Age(20, TimePeriods.Years)]
        ShaulOron = 204,
        [Country(CountryLikeThings.Israel)]
        [Age(20, TimePeriods.Years)]
        ShemTovOmer = 205,
        /// <summary>
        /// killed in IDF airstrike
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [Age(19, TimePeriods.Years)]
        ShermanRon = 206,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(38, TimePeriods.Years)]
        ShohamAdi = 207,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(8, TimePeriods.Years)]
        ShohamNave = 208,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Austria, CountryLikeThings.Italy)]
        [Age(38, TimePeriods.Years)]
        ShohamTal = 209,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(3, TimePeriods.Years)]
        ShohamYahel = 210,
        [Country(CountryLikeThings.Israel)]
        [Age(12, TimePeriods.Years)]
        ShoshaniHilaRotem = 211,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [Age(28, TimePeriods.Years)]
        ShtiviIdan = 212,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.SouthAfrica, CountryLikeThings.UnitedStates)]
        [Age(62, TimePeriods.Years)]
        SiegelAdrienneAviva = 213,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [Age(64, TimePeriods.Years)]
        SiegelSamuelKeith = 214,
        [Country(CountryLikeThings.Israel)]
        [Age(40, TimePeriods.Years)]
        SoussanaAmit = 215,
        [Country(CountryLikeThings.Thailand)]
        [Age(32, TimePeriods.Years)]
        SriaounWatchara = 216,
        [Country(CountryLikeThings.Thailand)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SrikeinaJakkrapan = 217,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Romania)]
        [Age(30, TimePeriods.Years)]
        SteinbrecherDoron = 218,
        [Country(CountryLikeThings.Thailand)]
        [Age(40, TimePeriods.Years)]
        SuriyasriOwas = 219,
        [Country(CountryLikeThings.Thailand)]
        [Age(34, TimePeriods.Years)]
        SuwannakhamSathian = 220,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(38, TimePeriods.Years)]
        SvirskyItai = 221,
        /// <summary>
        /// killed by friendly fire while surrendering
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(24, TimePeriods.Years)]
        TalalkaSamer = 222,
        [Country(CountryLikeThings.Israel)]
        [Age(54, TimePeriods.Years)]
        TalMeirav = 223,
        [Country(CountryLikeThings.Israel)]
        [Age(13, TimePeriods.Years)]
        TarshanskyGali = 224,
        /// <summary>
        /// mother of Yelena Trufanov and Alexander (Sasha) Trufanov
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [Age(73, TimePeriods.Years)]
        TatiIrena = 225,
        [Country(CountryLikeThings.Thailand)]
        [Age(37, TimePeriods.Years)]
        TemthongVichian = 226,
        [Country(CountryLikeThings.Thailand)]
        [Age(35, TimePeriods.Years)]
        ThaennaPongsak = 227,
        /// <summary>
        /// killed in IDF airstrike (civilian)
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [Age(27, TimePeriods.Years)]
        ToledanoElia = 228,
        [Country(CountryLikeThings.Thailand)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        ToonsriUthai = 229,
        [Country(CountryLikeThings.Thailand)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        TornsokreePattanayut = 230,
        /// <summary>
        /// Trupanob is a transformation of the Hebrew.
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [Age(50, TimePeriods.Years)]
        TrufanovYelena = 231,
        /// <summary>
        /// Trupanob is a transformation of the Hebrew.
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [Age(27, TimePeriods.Years)]
        TrufanovAlexanderSasha = 232,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [Age(27, TimePeriods.Years)]
        TzarfatiOfir = 233,
        /// <summary>
        /// Judith Weinstein-Haggai
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [Age(70, TimePeriods.Years)]
        WeinsteinHaggaiJudith = 234,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Hungary)]
        [Age(55, TimePeriods.Years)]
        WeissIlan = 235,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Hungary)]
        [Age(18, TimePeriods.Years)]
        WeissNoga = 236,
        [Country(CountryLikeThings.Israel)]
        [Age(53, TimePeriods.Years)]
        WeissShiri = 237,
        [Country(CountryLikeThings.Israel)]
        [Age(65, TimePeriods.Years)]
        WeissYehudit = 238,
        [Country(CountryLikeThings.Israel)]
        [Age(22, TimePeriods.Years)]
        WenkertOmer = 239,
        /// <summary>
        /// Jacob is alternate spelling of last name, related to the other Yaakovs
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(16, TimePeriods.Years)]
        YaakovOr = 240,
        /// <summary>
        /// Jacob is alternate spelling of last name, related to the other Yaakovs
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(12, TimePeriods.Years)]
        YaakovYagil = 241,
        /// <summary>
        /// Jacob is alternate spelling of last name, related to the other Yaakovs
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(59, TimePeriods.Years)]
        YaakovYair = 242,
        [Country(CountryLikeThings.Israel)]
        [Age(41, TimePeriods.Years)]
        YablonkaHanan = 243,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [Age(12, TimePeriods.Years)]
        YahalomiEitan = 244,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [Age(49, TimePeriods.Years)]
        YahalomiOhad = 245,
        [Country(CountryLikeThings.Israel)]
        [Age(40, TimePeriods.Years)]
        YanaiMoranStela = 246,
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [Age(28, TimePeriods.Years)]
        YehoudArbel = 247,

        /// <summary>
        /// killed during the October 7 attacks, but never taken into Gaza
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [NotActuallyAHostage]
        [Age(35, TimePeriods.Years)]
        YehoudDolev = 248,

        /// <summary>
        /// executed by Hamas
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(23, TimePeriods.Years)]
        YerushalmiEden = 249,
        /// <summary>
        /// woman
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [Age(79, TimePeriods.Years)]
        YitzhakNuritCooper = 250,
        [Country(CountryLikeThings.Israel)]
        [Age(85, TimePeriods.Years)]
        ZalmanovitchArye = 251,
        [Country(CountryLikeThings.Israel)]
        [Age(23, TimePeriods.Years)]
        ZangaukerMatan = 252,

        [Country(CountryLikeThings.Israel)]
        [Age(27, TimePeriods.Years)]
        ZechariahEden = 253,
        [Country(CountryLikeThings.Israel)]
        [Age(40, TimePeriods.Years)]
        ZivShlomi = 254,
        [Country(CountryLikeThings.Israel)]
        [Age(17, TimePeriods.Years)]
        ZiyadneAisha = 255,
        [Country(CountryLikeThings.Israel)]
        [Age(18, TimePeriods.Years)]
        ZiyadneBilal = 256,
    }

    /// <summary>
    /// see https://www.cnn.com/interactive/2023/12/world/hostage-israel-hamas-deal-dg/
    /// </summary>
    public class IsraelHamasHostages
    {
        public static class v2023
        {
            /// <summary>
            ///  Hamas had also held the bodies of two slain Israeli soldiers (since 2014 Operation Protective Edge)
            ///  Hadar Goldin
            ///  Oron Shaul (reovered by Israeli military 1-19-2025)
            ///  Hamas was already holding two Israelis hostage
            ///  Ethiopian Israeli Avera Mengistu (since 2014). Released February 22, 2025.
            ///  Bedouin Israeli Hisham al-Sayed (since 2015). Released February 22, 2025.
            /// </summary>
            public static class PriorToOctober7 { }

            [Hostages(HostageList.RaananJudith, HostageList.RaananNatalie)]
            [Number(2)]
            [HostageOutcome(HostageOutcome.ReleasedAlive)]
            public static class October20 { }

            /// <summary>
            /// released elderly Israeli women (Yokheved Lifshitz and Nurit Yitzhak [Nurit Cooper])
            /// </summary>
            [Hostages(HostageList.LifshitzYokheved, HostageList.YitzhakNuritCooper)]
            [Number(2)]
            [HostageOutcome(HostageOutcome.ReleasedAlive)]
            public static class October23 { }

            /// <summary>
            /// Israeli forces rescued soldier Ori Megidish (female soldier)
            /// </summary>
            [Hostages(HostageList.MegidishOri)]
            [Number(1)]
            [HostageOutcome(HostageOutcome.RescuedAlive)]
            public static class October30 { }

            /// <summary>
            /// recovered bodies of Yehudit Weiss and Corporal Noa Marciano, from buildings adjacent to Al-Shifa hospital
            /// </summary>
            [Hostages(HostageList.WeissYehudit, HostageList.MarcianoNoa)]
            [Number(2)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            public static class November1617 { }

            /// <summary>
            /// Ceasefire agreement led to releases over several days (81 Israelis, 23 Thais, 1 Filipino), November 24-30.
            /// 
            /// published number is 105, while the numbers below add to 106
            /// </summary>
            public static class November21
            {
                /// <summary>
                /// Yafa Adar, Daniel Aloni, Emilia Aloni, Aviv Asher, Doron Katz Asher, Raz Asher, Hannah Katzir, Margalit Moses (77-year-old member of Kibbutz Nir Or)
                /// Adina Moshe, Keren Munder, Ohad Munder, Ruth Munder, Nattaware Munkan, Hanna Peri, Santi Boonprom, Vichai Kalaprat
                /// Bancha Kongmanee, Gelienor "Jimmy" Pacheco, Boonthom Pankhong, Mongkol Phachuabboon, Vetoon Phoome, Buddhee Saengboon, Uthai Saengnuan, Uthai Toonsri
                /// </summary>
                [Number(24)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(
                    HostageList.AdarYafa,
                    HostageList.AloniDaniel,
                    HostageList.AloniEmelia,
                    HostageList.AsherAviv,
                    HostageList.AsherDoronKatz,
                    HostageList.AsherRaz,
                    HostageList.KatzirHannah,
                    HostageList.MosesMargalit,
                    HostageList.MosheAdina,
                    HostageList.MunderKeren,
                    HostageList.MunderOhad,
                    HostageList.MunderRuth,
                    HostageList.MunkanNattawaree,
                    HostageList.PeriChanna,
                    HostageList.BoonpromSanti,
                    HostageList.KalapratVichai,
                    HostageList.KongmaneeBancha,
                    HostageList.PachecoGelienorJimmy,
                    HostageList.PankhongBoonthom,
                    HostageList.PhachuabboonMongkol,
                    HostageList.PhoomeVetoon,
                    HostageList.SaengboonBuddhee,
                    HostageList.SaengnuanUthai,
                    HostageList.ToonsriUthai)]
                public static class November24 { }

                /// <summary>
                /// Noam Avigdori, Sharon Avigdori, Emily Hand, Shoshan Haran, Alma Or, Noam Or, Maya Regev, Adi Shoham
                /// Nave Shoham, Yahel Shoham, Hila Rotem Shoshani, Noga Weiss, Shiri Weiss, Anucha Angkaew, Komkrit Chombua, Manee Jirachart
                /// Natthaporn Onkaew
                /// </summary>
                [Number(17)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(
                    HostageList.AvigdoriNoam,
                    HostageList.AvigdoriSharon,
                    HostageList.HandEmily,
                    HostageList.HaranShoshan,
                    HostageList.OrAlma,
                    HostageList.OrNoam,
                    HostageList.RegevMaya,
                    HostageList.ShohamAdi,
                    HostageList.ShohamNave,
                    HostageList.ShohamYahel,
                    HostageList.ShoshaniHilaRotem,
                    HostageList.WeissNoga,
                    HostageList.WeissShiri,
                    HostageList.AngkaewAnucha,
                    HostageList.ChombuaKomkrit,
                    HostageList.JirachartManee,
                    HostageList.OnkaewNatthaporn)]
                public static class November25 { }

                /// <summary>
                /// Elma Avraham, Hagar Brodutch, Ofri Brodutch, Uriah Brodutch, Yuval Brodutch, Abigail Edan, Dafna Elyakim, Ela Elyakim
                /// Agam Goldstein-Almog, Chen Goldstein-Almog, Gal Goldstein-Almog, Tal Goldstein-Almog, Roni Kriboy, Adrienne Siegel, Surin Kesoognern, Pornsawan Pinakalow
                /// Vichian Temthong
                /// </summary>
                [Number(17)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(
                    HostageList.AvrihamElma,
                    HostageList.BrodutchHagar,
                    HostageList.BrodutchOfri,
                    HostageList.BrodutchOriya,
                    HostageList.BrodutchYuval,
                    HostageList.EdanAbigail,
                    HostageList.ElyakimDafna,
                    HostageList.ElyakimEla,
                    HostageList.GoldsteinAlmogAgam,
                    HostageList.GoldsteinAlmogChen,
                    HostageList.GoldsteinAlmogGal,
                    HostageList.GoldsteinAlmogTal,
                    HostageList.KriboyRoni,
                    HostageList.SiegelAdrienneAviva,
                    HostageList.KesoognernSurin,
                    HostageList.PinakalowPornsawan,
                    HostageList.TemthongVichian)]
                public static class November26 { }

                /// <summary>
                /// Sharon Olani Cunio, Emma Cunion, Yuli Cunio, Karina Engel-Bart, Mika Engel, Yuval Engel, Or Jacob, Yagil Jacob
                /// Erez Kalderon, Sahar Kalderon, Eitan Yahaloni
                /// </summary>
                [Number(11)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(
                    HostageList.CunioSharonOlani,
                    HostageList.CunioEmma,
                    HostageList.CunioYuli,
                    HostageList.EngelBartKarina,
                    HostageList.EngelMika,
                    HostageList.EngelYuval,
                    HostageList.YaakovOr,
                    HostageList.YaakovYagil,
                    HostageList.KalderonErez,
                    HostageList.KalderonSahar,
                    HostageList.YahalomiEitan)]
                public static class November27 { }

                /// <summary>
                /// Noralin Babadilla, Ditza Heiman, Rimon Kirsht, Gabriela Leimberg, Mia Leimbert, Clara Merman, Tamar Metzger, Ofelia Roitman
                /// Ada Sagi, Owas Suriyasri, Meirav Tal, Pattanayut Tornsokree
                /// </summary>
                [Number(12)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(
                    HostageList.BabadillaNoralin,
                    HostageList.HeimanDitza,
                    HostageList.BuchshtavRimonKirsht,
                    HostageList.LeimbergGabriela,
                    HostageList.LeimbertMia,
                    HostageList.MermanClara,
                    HostageList.MetzgerTamar,
                    HostageList.RoitmanOfelia,
                    HostageList.SagiAda,
                    HostageList.SuriyasriOwas,
                    HostageList.TalMeirav,
                    HostageList.TornsokreePattanayut)]
                public static class November28 { }

                [Number(16)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(
                    HostageList.BeininLiat,
                    HostageList.BenAmiRaz,
                    HostageList.EngelOfir,
                    HostageList.RomanGatYarden,
                    HostageList.OrLiam,
                    HostageList.RegevItay,
                    HostageList.RotemRaaya,
                    HostageList.ShaniAmit,
                    HostageList.TarshanskyGali,
                    HostageList.YanaiMoranStela,
                    HostageList.RataninPaiboon,
                    HostageList.SaelaoKong,
                    HostageList.SangkaewChalermchai,
                    HostageList.SrikeinaJakkrapan,
                    HostageList.TrufanovYelena,
                    HostageList.TatiIrena)]
                public static class November29 { }

                /// <summary>
                /// Siblings Bilal (18) and Aisha Ziyadne (17), Ilana Gritzewsky, Nili Margalit; Shani Goren, Amit Soussana (50), Mia Schem (21)
                /// Sapir Cohen (girlfriend of Alexandre (Sasha) Troufanov)
                /// </summary>
                [Number(8)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(
                    HostageList.ZiyadneAisha,
                    HostageList.ZiyadneBilal,
                    HostageList.GritzewskyIlana,
                    HostageList.MargalitNili,
                    HostageList.GorenShani,
                    HostageList.SoussanaAmit,
                    HostageList.SchemMia,
                    HostageList.CohenSapir)]
                public static class November30 { }
            }

            /// <summary>
            /// The IDF and Shin Bet announce they have recovered the body of deceased hostage Ophir Sarfati in recent days
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.TzarfatiOfir)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            public static class November29 { }

            /// <summary>
            /// The IDF recovers the bodies of Eden Zechariah and Staff Sergeant Major Ziv Dado in underground tunnels in Jabalia, Gaza
            /// </summary>
            [Number(2)]
            [Hostages(HostageList.ZechariahEden, HostageList.DadoZiv)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            public static class December12 { }

            /// <summary>
            /// An IDF airstrike targeting Hamas's northern Gaza brigade chief, Ahmed Ghandour, killed three hostages, but their
            /// bodies were not recovered until December 15th (Sgt. Ron Sherman, Cpl. Nik Beizer, and civilian Elia Toledano)
            /// </summary>
            [Number(3)]
            [HostageOutcome(HostageOutcome.RecoveredBodyKilledByIsrael)]
            [Hostages(
                HostageList.ShermanRon,
                HostageList.BeizerNik,
                HostageList.ToledanoElia
                )]
            public static class December15A { }

            /// <summary>
            /// During the Battle of Shuja'iyya, Israeli Defense Forces (IDF) mistakenly identified three Israeli hostages—Alon Shamriz, Yotam Haim, 
            /// and Samer Talalka—as threats and opened fire, resulting in their deaths. The hostages were reportedly waving a white flag at the time. 
            /// </summary>
            [Number(3)]
            [HostageOutcome(HostageOutcome.RecoveredBodyKilledByIsrael)]
            [Hostages(
                HostageList.ShamrizAlon,
                HostageList.HaimYotam,
                HostageList.TalalkaSamer)]
            public static class December15B { }
        }
        public static class v2024
        {
            /// <summary>
            /// Operation Golden Hand: rescued Fernando Simon Merman (60) and Luis Har (70) in Rafah, Gaza
            /// </summary>
            [Number(2)]
            [Hostages(HostageList.MermanFernandoSimon, HostageList.HarLuis)]
            [HostageOutcome(HostageOutcome.RescuedAlive)]
            public static class February12 { }

            /// <summary>
            ///	The IDF announces it has recovered the body of deceased hostage Elad Katzir 
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.KatznirElad)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            public static class April6 { }

            /// <summary>
            /// Shani Louk, Amit Buskila, and Itzhak Gelerenter, reportedly kidnapped during the attack on the Nova festival
            /// All three were killed near the site of the attack and their bodies were taken into Gaza and later recovered in a Hamas tunnel
            /// </summary>
            [Hostages(HostageList.LoukShani, HostageList.BuskilaEstherAmit, HostageList.GelerenterItzhak)]
            [Number(3)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            public static class May17 { }

            /// <summary>
            /// It was announced by the IDF that they had also recovered the body of deceased hostage Ron Benjamin, and his body was recovered 
            /// alongside those announced the day before. Benjamin was 53-years-old and abducted from the Be'eri kibbutz while riding his bike 
            /// on the day of the attack
            /// </summary>
            [Hostages(HostageList.BenjaminRon)]
            [Number(1)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            public static class May18 { }

            /// <summary>
            /// The Israel Defense Forces has recovered the bodies of three more hostages from the northern Gaza Strip in an overnight operation,
            /// Orión Hernández Radoux, 30, Hanan Yablonka, 42, and Michel Nisenbaum, 59, were all killed on October 7,
            /// </summary>
            [Number(3)]
            [Hostages(HostageList.RadouxOriónHernández, HostageList.YablonkaHanan, HostageList.NisenbaumMichel)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            public static class May24 { }

            [Number(1)]
            [Hostages(HostageList.YehoudDolev)]
            [HostageOutcome(HostageOutcome.RemainsIdentified)]
            public static class June3 { }

            /// <summary>
            /// rescued from Nuseirat refugee camp: Noa Argamani, Almog Meir Jan, Andrey Kozlov, and Shlomi Ziv
            /// </summary>
            [Number(4)]
            [HostageOutcome(HostageOutcome.RescuedAlive)]
            [Hostages(
                HostageList.ArgamaniNoa,
                HostageList.MeirJanAlmog,
                HostageList.KozlovAndrey,
                HostageList.ZivShlomi)]
            public static class June8 { }

            /// <summary>
            /// bodies recovered from a tunnel located in the Israeli-designated humanitarian zone in the southern Gaza Strip,
            /// Ravid Katz, 51, Oren Goldin, 33, Maya Goren, 56, Sgt. Kiril Brodski, 19, and Staff Sgt. Tomer Yaakov Ahimas, 20
            /// </summary>
            [Number(5)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            [Hostages(
                HostageList.KatzRavid,
                HostageList.GoldinOren,
                HostageList.GorenMaya,
                HostageList.BrodskiKiril,
                HostageList.AhimasTomerYaakov)]
            public static class July24 { }

            /// <summary>
            ///  bodies of the six hostages recovered by the IDF from southern Gaza’s Khan Younis 
            ///  (Alexander Dancyg, Yagev Buchshtav, Chaim Peri, Yoram Metzger, Nadav Popplewell, and Avraham Munder)
            /// </summary>
            [Number(6)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            [Hostages(
                HostageList.DancygAlexander,
                HostageList.BuchshtabYagev,
                HostageList.PeriChaim,
                HostageList.MetzgerYoram,
                HostageList.PopplewellNadav,
                HostageList.MunderAbraham)]
            public static class August1920 { }

            /// <summary>
            /// Qaid Farhan al-Qadi (Israeli-Bedouin), rescued in a tunnel in southern Gaza during a joint op by IDF and Shin Bet
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.AlkadiQaidFarhan)]
            [HostageOutcome(HostageOutcome.RescuedAlive)]
            public static class August27 { }

            [Number(1)]
            [Hostages(HostageList.DahanShaked)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            public static class August28 { }

            /// <summary>
            /// recovered the bodies of these hostages from a tunnel in Rafah, Gaza
            /// Believed to be executed by Hamas, shot at close range 1-2 days prior to discovery.
            /// Hersh Goldberg-Polin (23, American), Eden Yerushalmi, 24, Ori Danino, 25, Alex Lobanov, 32, Carmel Gat, 40, and Almog Sarusi, 27.
            /// </summary>
            [Number(6)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            [Hostages(
                HostageList.GoldbergPolinHersh,
                HostageList.YerushalmiEden,
                HostageList.DaninoOri,
                HostageList.LobanovAlexander,
                HostageList.GatCarmel,
                HostageList.SarusiAlmog)]
            public static class August31 { }

            /// <summary>
            /// The remains of Itai Svirsky, taken hostage from kibbutz Be'eri on October 7, was recovered by the IDF
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.SvirskyItai)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            public static class December4 { }
        }
        public static class v2025
        {
            /// <summary>
            /// Body recovered by Israeli Military: Yousef Alziadana
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.AlZayadniYosef)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            public static class January8 { }

            /// <summary>
            /// Body Recovered by Israeli Military: Hamza Alziadana
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.AlZayadniHamzah)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            public static class January10 { }

            [Number(1)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            [Hostages(HostageList.ShaulOron)]
            public static class January19RecoveredBody { }

            //30 living hostages and 8 bodies were returned
            public static class January15HostageReturnAgreementPhase1
            {
                /// <summary>
                /// Released: Emily Damari 28, Romi Gonen 24, Doron Steinbrecher 31
                /// </summary>
                [Number(3)]
                [Hostages(HostageList.DamariEmily, HostageList.GonenRomi, HostageList.SteinbrecherDoron)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                public static class January19ReleasedAlive { }

                /// <summary>
                /// Released: Liri Albag, Karina Ariev, Daniella Gilboa, Naama Levy
                /// </summary>
                [Number(4)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(HostageList.AlbagLiri,
                    HostageList.ArievKarina,
                    HostageList.GilboaDaniella,
                    HostageList.LevyNaama)]
                public static class January25 { }

                /// <summary>
                /// Released: Arbel Yehoud 29, Agam Berger 20, Gadi Moses 80, Surasak Romneo, Bannawat Saethao, Watchara Sriaoun, Pongsak Thaenna, Sathian Suwannakham
                /// </summary>
                [Number(8)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(HostageList.YehoudArbel,
                    HostageList.BergerAgam,
                    HostageList.MozesGadiMoshe, //had listed as Gadi Moses
                    HostageList.RumnaoSurasak,
                    HostageList.SaethaoBannawat,
                    HostageList.SriaounWatchara,
                    HostageList.ThaennaPongsak,
                    HostageList.SuwannakhamSathian)]
                public static class January30 { }

                /// <summary>
                /// Released: Ofer Kalderon 54, Yarden Bibas 35, Keith Siegel 65
                /// </summary>
                [Hostages(HostageList.KalderonOfer, HostageList.BibasYarden, HostageList.SiegelSamuelKeith)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Number(3)]
                public static class February1 { }

                /// <summary>
                /// Released: Ohad Ben Ami, Eli Sharabi, Or Levy
                /// </summary>
                [Hostages(HostageList.BenAmiOhad, HostageList.SharabiEli, HostageList.LevyOr)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Number(3)]
                public static class February8 { }

                /// <summary>
                /// Released: Sagui Dekel-Chen, Alexandre (Sasha) Troufanov, Iair Horn 46
                /// </summary>
                [Hostages(HostageList.DekelChenSagui,
                    HostageList.TrufanovAlexanderSasha,
                    HostageList.HornIair)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Number(3)]
                public static class February15 { }

                /// <summary>
                /// released body: Oded Lifshitz, Ariel/Kfir Bibas
                /// </summary>
                [Number(3)]
                [Hostages(HostageList.LifshitzOded, HostageList.BibasAriel, HostageList.BibasKfir)]
                [HostageOutcome(HostageOutcome.ReleasedBody)]
                public static class February20 { }

                /// <summary>
                /// released body: Shiri Bibas
                /// </summary>
                [Hostages(HostageList.BibasShiri)]
                [HostageOutcome(HostageOutcome.ReleasedBody)]
                [Number(1)]
                public static class February21 { }

                /// <summary>
                /// released: Omer Wenkert, Omer Shem Tov, Eliya Cohen, Tal Shoham
                /// Avera Mengistu (held by Hamas prior to 2023-10-7)
                /// Hisham al-Sayed (held by Hamas prior to 2023-10-7)
                /// </summary>
                [Number(6)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(
                    HostageList.WenkertOmer,
                    HostageList.ShemTovOmer,
                    HostageList.CohenEliya,
                    HostageList.ShohamTal,
                    HostageList.MengistuAvera,
                    HostageList.AlSayedHishamShaaban)]
                public static class February22 { }

                /// <summary>
                /// bodies released
                /// Shlomo Mansour 86 (Iraq-born from Kibbutz Kissufim)
                /// Ohad Yahalomi, 50, Tsachi Idan, 50, and Itzik Elgarat, 69
                /// </summary>
                [Number(4)]
                [HostageOutcome(HostageOutcome.ReleasedBody)]
                [Hostages(
                    HostageList.MansourShlomo,
                    HostageList.YahalomiOhad,
                    HostageList.IdanTsachi,
                    HostageList.ElgaratItzhk)]
                public static class February26 { }
            }

            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedAlive)]
            [Hostages(HostageList.AlexanderEdan)]
            public static class May12 { }

            [Number(2)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            [Hostages(HostageList.HaggaiGad,
                      HostageList.WeinsteinHaggaiJudith)]
            public static class June5 { }

            [Number(1)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            [Hostages(HostageList.PintaNattapong)]
            public static class June7 { }

            [Number(2)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            [Hostages(HostageList.AtziliAviv,
                      HostageList.YaakovYair)]
            public static class June11 { }

            [Number(3)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            [Hostages(HostageList.KeidarOfra,
                      HostageList.LevinsonShay,
                      HostageList.SameranoYonatan)]
            public static class June22 { }

            [Number(2)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            [Hostages(HostageList.ShtiviIdan,
                      HostageList.WeissIlan)]
            public static class August29 { }

            [Number(20)]
            [HostageOutcome(HostageOutcome.ReleasedAlive)]
            [Hostages(HostageList.OhelAlon,
                      HostageList.CunioAriel,
                      HostageList.OrAvinathan,
                      HostageList.KupershteinBar,
                      HostageList.CunioDavid,
                      HostageList.HornEitan,
                      HostageList.MorEitanAbraham,
                      HostageList.BohbotElkana,
                      HostageList.DavidEvyatar,
                      HostageList.BermanGali,
                      HostageList.GilboaDalalGuy,
                      HostageList.AngrestMatan,
                      HostageList.ZangaukerMatan,
                      HostageList.HerkinMaxim,
                      HostageList.CohenNimrod,
                      HostageList.MiranOmri,
                      HostageList.BraslavskiRom,
                      HostageList.KalfonSegev,
                      HostageList.OhanaYosefHaim,
                      HostageList.BermanZiv)]
            public static class October13ReleasedAlive { }

            [Number(4)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.JoshiBipin,
                      HostageList.IluzGuy,
                      HostageList.PerezDaniel,
                      HostageList.SharabiYossi)]
            public static class October13ReleasedBody { }

            /// <summary>
            /// a fourth body was also released, but was an unidentified Palestinian
            /// </summary>
            [Number(3)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.BaruchUriael,
                      HostageList.LevyEitan,
                      HostageList.NimrodTamir)]
            public static class October14 { }

            [Number(2)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.AlAtreshMuhammad,
                      HostageList.HaymanInbar)]
            public static class October15 { }

            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.MargalitEliyahu)]
            public static class October17 { }

            [Number(2)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.EngelRonan,
                      HostageList.OakkharasriSonthaya)]
            public static class October18 { }

            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.HaimiTal)]
            public static class October20 { }

            [Number(2)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.AdarTamir,
                      HostageList.ZalmanovitchArye)]
            public static class October21 { }

            [Number(2)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.BaruchSahar,
                      HostageList.CooperAmiram)]
            public static class October30 { }

            [Number(3)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.OzDaniel,
                      HostageList.HamamiAsaf,
                      HostageList.NeutraOmerMaxim)]
            public static class November2 { }

            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.ChenItay)]
            public static class November4 { }

            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.MollelJoshua)]
            public static class November5 { }

            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.RudaeffLior)]
            public static class November7 { }

            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.GoldinHadar)]
            public static class November9 { }

            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.GodardManny)]
            public static class November13 { }

            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.OrDror)]
            public static class November26 { }

            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.RinthalakSudthisak)]
            public static class December3 { }
        }

        public static class v2026
        {
            [Number(1)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            [Hostages(HostageList.GviliRan)]
            public static class January26 { }
        }
    }
}

internal class NotActuallyAHostageAttribute : Attribute
{
    public NotActuallyAHostageAttribute()
    {
    }
}

internal class PreviouslyHeldAsHostageAttribute : Attribute
{
    public PreviouslyHeldAsHostageAttribute()
    {

    }
}

internal class IsraelDefenceForcesSoldierAttribute : Attribute
{
    public const string UNKNOWN_RANK = "Unknown";
    public string Rank { get; set; }
    public IsraelDefenceForcesSoldierAttribute(string Rank)
    {
        this.Rank = Rank;
    }
}
