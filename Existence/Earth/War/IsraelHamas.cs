
using Existence.Earth.Alphabet;
using Existence.Earth.Countries;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.People;
using Existence.Earth.Time;
using Existence.Time;
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
    ///
    /// short rather than byte: the 256 entries currently fill 0-255, and others who belong on this list
    /// (e.g. people marked with <see cref="NotActuallyAHostageAttribute"/>) may still need to be added.
    /// </summary>
    public enum HostageList : short
    {
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(38, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        AdarTamir = 0,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(85, TimePeriods.Years)]
        AdarYafa = 1,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [HumanGender(HumanGender.Male)]
        [Age(20, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        AhimasTomerYaakov = 2,

        /// <summary>
        /// Bedouin
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant Major")]
        [HumanGender(HumanGender.Male)]
        [Age(39, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        AlAtreshMuhammad = 3,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(44, TimePeriods.Years)]
        AloniDaniel = 4,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(5, TimePeriods.Years)]
        AloniEmelia = 5,

        [Country(CountryLikeThings.Israel)]
        [PreviouslyHeldAsHostage]
        [HumanGender(HumanGender.Male)]
        [Age(27, TimePeriods.Years)]
        AlSayedHishamShaaban = 6,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        [DeathDateUnknown]
        AlZayadniHamzah = 7,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [ApproximateAgeInYears(52, 53)]
        [DeathDateUnknown]
        AlZayadniYosef = 8,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [HumanGender(HumanGender.Female)]
        [Age(18, TimePeriods.Years)]
        AlbagLiri = 9,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        AlexanderEdan = 10,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(51, TimePeriods.Years)]
        AlkadiQaidFarhan = 11,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(28, TimePeriods.Years)]
        AngkaewAnucha = 12,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Bulgaria)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [HumanGender(HumanGender.Male)]
        [Age(20, TimePeriods.Years)]
        AngrestMatan = 13,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(25, TimePeriods.Years)]
        ArgamaniNoa = 14,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [HumanGender(HumanGender.Female)]
        [Age(19, TimePeriods.Years)]
        ArievKarina = 15,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(2, TimePeriods.Years)]
        AsherAviv = 16,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(34, TimePeriods.Years)]
        AsherDoronKatz = 17,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(4, TimePeriods.Years)]
        AsherRaz = 18,

        /// <summary>
        /// related to BeininLiat
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(49, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        AtziliAviv = 19,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(12, TimePeriods.Years)]
        AvigdoriNoam = 20,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(52, TimePeriods.Years)]
        AvigdoriSharon = 21,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(84, TimePeriods.Years)]
        AvrihamElma = 22,

        [Countries(CountryLikeThings.Philippines, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(60, TimePeriods.Years)]
        BabadillaNoralin = 23,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Bulgaria)]
        [HumanGender(HumanGender.Male)]
        [Age(24, TimePeriods.Years)]
        [DeathDate(2023, 12, 8)]
        BaruchSahar = 24,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(34, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        BaruchUriael = 25,

        /// <summary>
        /// related to Aviv Atzili
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [HumanGender(HumanGender.Female)]
        [Age(49, TimePeriods.Years)]
        BeininLiat = 26,

        /// <summary>
        /// killed in IDF airstrike
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Corporal")]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 11, 10)]
        BeizerNik = 27,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(54, TimePeriods.Years)]
        BenAmiOhad = 28,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(56, TimePeriods.Years)]
        BenAmiRaz = 29,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(53, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        BenjaminRon = 30,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [HumanGender(HumanGender.Female)]
        [Age(19, TimePeriods.Years)]
        BergerAgam = 31,

        /// <summary>
        /// Gali/Ziv Berman are twins
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        BermanGali = 32,

        /// <summary>
        /// Gali/Ziv Berman are twins
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        BermanZiv = 33,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(4, TimePeriods.Years)]
        [DeathDate(2023, 11)]
        BibasAriel = 34,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(8, TimePeriods.Months)]
        [DeathDate(2023, 11)]
        BibasKfir = 35,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(32, TimePeriods.Years)]
        [DeathDate(2023, 11)]
        BibasShiri = 36,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(33, TimePeriods.Years)]
        BibasYarden = 37,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Colombia)]
        [HumanGender(HumanGender.Male)]
        [Age(34, TimePeriods.Years)]
        BohbotElkana = 38,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        BoonpromSanti = 39,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        BraslavskiRom = 40,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        BrodskiKiril = 41,

        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(40, TimePeriods.Years)]
        BrodutchHagar = 42,

        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(9, TimePeriods.Years)]
        BrodutchOfri = 43,

        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(4, TimePeriods.Years)]
        BrodutchOriya = 44,

        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(9, TimePeriods.Years)]
        BrodutchYuval = 45,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(36, TimePeriods.Years)]
        BuchshtavRimonKirsht = 46,

        /// <summary>
        /// Buckshtav?
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(34, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        BuchshtabYagev = 47,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        BuskilaEstherAmit = 48,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany, CountryLikeThings.UnitedStates)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        ChenItay = 49,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(29, TimePeriods.Years)]
        ChombuaKomkrit = 50,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        CohenEliya = 51,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        CohenNimrod = 52,

        /// <summary>
        /// girlfriend of Alexandre (Sasha) Troufanov
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(29, TimePeriods.Years)]
        CohenSapir = 53,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [HumanGender(HumanGender.Male)]
        [Age(84, TimePeriods.Years)]
        [DeathDateUnknown]
        CooperAmiram = 54,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        CunioAriel = 55,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(33, TimePeriods.Years)]
        CunioDavid = 56,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(3, TimePeriods.Years)]
        CunioEmma = 57,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(34, TimePeriods.Years)]
        CunioSharonOlani = 58,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(3, TimePeriods.Years)]
        CunioYuli = 59,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Command Sergeant Major")]
        [HumanGender(HumanGender.Male)]
        [Age(36, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        DadoZiv = 60,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        DahanShaked = 61,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedKingdom)]
        [HumanGender(HumanGender.Female)]
        [Age(27, TimePeriods.Years)]
        DamariEmily = 62,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [HumanGender(HumanGender.Male)]
        [Age(75, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        DancygAlexander = 63,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(24, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        DaninoOri = 64,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        DavidEvyatar = 65,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [HumanGender(HumanGender.Male)]
        [Age(35, TimePeriods.Years)]
        DekelChenSagui = 66,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [HumanGender(HumanGender.Female)]
        [Age(3, TimePeriods.Years)]
        EdanAbigail = 67,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(68, TimePeriods.Years)]
        [DeathDateUnknown]
        ElgaratItzhk = 68,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(15, TimePeriods.Years)]
        ElyakimDafna = 69,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(8, TimePeriods.Years)]
        ElyakimEla = 70,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(51, TimePeriods.Years)]
        EngelBartKarina = 71,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(18, TimePeriods.Years)]
        EngelMika = 72,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Netherlands)]
        [HumanGender(HumanGender.Male)]
        [Age(17, TimePeriods.Years)]
        EngelOfir = 73,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(54, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        EngelRonan = 74,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(11, TimePeriods.Years)]
        EngelYuval = 75,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(39, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        GatCarmel = 76,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(56, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GelerenterItzhak = 77,

        /// <summary>
        /// originally named Danielle
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Bulgaria)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [HumanGender(HumanGender.Female)]
        [Age(19, TimePeriods.Years)]
        GilboaDaniella = 78,

        /// <summary>
        /// Guy Gilboa-Dalal
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        GilboaDalalGuy = 79,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(73, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GodardManny = 80,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [HumanGender(HumanGender.Male)]
        [Age(23, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        GoldbergPolinHersh = 81,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Lieutenant")]
        [PreviouslyHeldAsHostage]
        [HumanGender(HumanGender.Male)]
        [Age(23, TimePeriods.Years)]
        [DeathDate(2014, 8, 1)]
        GoldinHadar = 82,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(33, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GoldinOren = 83,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(17, TimePeriods.Years)]
        GoldsteinAlmogAgam = 84,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(48, TimePeriods.Years)]
        GoldsteinAlmogChen = 85,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(11, TimePeriods.Years)]
        GoldsteinAlmogGal = 86,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(9, TimePeriods.Years)]
        GoldsteinAlmogTal = 87,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(23, TimePeriods.Years)]
        GonenRomi = 88,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(56, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GorenMaya = 89,

        [Countries(CountryLikeThings.Uruguay, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(29, TimePeriods.Years)]
        GorenShani = 90,

        [Countries(CountryLikeThings.Mexico, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(30, TimePeriods.Years)]
        GritzewskyIlana = 91,

        /// <summary>
        /// aka Rani, last hostage accounted for
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(24, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GviliRan = 92,

        /// <summary>
        /// aka Gadi
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [HumanGender(HumanGender.Male)]
        [Age(72, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        HaggaiGad = 93,

        /// <summary>
        /// killed by friendly fire while surrendering
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [HumanGender(HumanGender.Male)]
        [Age(28, TimePeriods.Years)]
        [DeathDate(2023, 12, 15)]
        HaimYotam = 94,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Romania)]
        [HumanGender(HumanGender.Male)]
        [Age(41, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        HaimiTal = 95,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Colonel")]
        [HumanGender(HumanGender.Male)]
        [Age(40, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        HamamiAsaf = 96,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Ireland)]
        [HumanGender(HumanGender.Female)]
        [Age(8, TimePeriods.Years)]
        HandEmily = 97,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(67, TimePeriods.Years)]
        HaranShoshan = 98,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(70, TimePeriods.Years)]
        HarLuis = 99,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        HaymanInbar = 100,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(84, TimePeriods.Years)]
        HeimanDitza = 101,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia, CountryLikeThings.Ukraine)]
        [HumanGender(HumanGender.Male)]
        [Age(35, TimePeriods.Years)]
        HerkinMaxim = 102,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(37, TimePeriods.Years)]
        HornEitan = 103,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(45, TimePeriods.Years)]
        HornIair = 104,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(49, TimePeriods.Years)]
        [DeathDate(2023, 12, 4)]
        IdanTsachi = 105,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        [DeathDate(2023)]
        IluzGuy = 106,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(29, TimePeriods.Years)]
        JirachartManee = 107,

        [Country(CountryLikeThings.Nepal)]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        [DeathDate(2023)]
        JoshiBipin = 108,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(28, TimePeriods.Years)]
        KalapratVichai = 109,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [HumanGender(HumanGender.Male)]
        [Age(11, TimePeriods.Years)]
        KalderonErez = 110,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France, CountryLikeThings.Portugal)]
        [HumanGender(HumanGender.Male)]
        [Age(52, TimePeriods.Years)]
        KalderonOfer = 111,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [HumanGender(HumanGender.Female)]
        [Age(16, TimePeriods.Years)]
        KalderonSahar = 112,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(25, TimePeriods.Years)]
        KalfonSegev = 113,

        /// <summary>
        /// Death (after release) was attributed to medical complications from her time as a hostage
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(76, TimePeriods.Years)]
        [DeathDate(2024, 12, 24)]
        KatzirHannah = 114,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [HumanGender(HumanGender.Male)]
        [Age(47, TimePeriods.Years)]
        [DeathDate(2024, 1)]
        KatznirElad = 115,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant Major (res.)")]
        [HumanGender(HumanGender.Male)]
        [Age(51, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        KatzRavid = 116,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(70, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        KeidarOfra = 117,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        KesoognernSurin = 118,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        KongmaneeBancha = 119,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [HumanGender(HumanGender.Male)]
        [Age(27, TimePeriods.Years)]
        KozlovAndrey = 120,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [HumanGender(HumanGender.Male)]
        [Age(25, TimePeriods.Years)]
        KriboyRoni = 121,

        /// <summary>
        /// aka Kuperstein
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(21, TimePeriods.Years)]
        KupershteinBar = 122,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(59, TimePeriods.Years)]
        LeimbergGabriela = 123,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(17, TimePeriods.Years)]
        LeimbertMia = 124,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        LevinsonShay = 125,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(53, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        LevyEitan = 126,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [HumanGender(HumanGender.Female)]
        [Age(19, TimePeriods.Years)]
        LevyNaama = 127,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(33, TimePeriods.Years)]
        LevyOr = 128,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(83, TimePeriods.Years)]
        [DeathDate(2023)]
        LifshitzOded = 129,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(85, TimePeriods.Years)]
        LifshitzYokheved = 130,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [HumanGender(HumanGender.Male)]
        [Age(32, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        LobanovAlexander = 131,

        [Countries(CountryLikeThings.Germany, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(22, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        LoukShani = 132,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(85, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        MansourShlomo = 133,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Corporal")]
        [HumanGender(HumanGender.Female)]
        [Age(18, TimePeriods.Years)]
        [DeathDate(2023)]
        MarcianoNoa = 134,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(75, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        MargalitEliyahu = 135,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(41, TimePeriods.Years)]
        MargalitNili = 136,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Private")]
        [HumanGender(HumanGender.Female)]
        [Age(19, TimePeriods.Years)]
        MegidishOri = 137,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [HumanGender(HumanGender.Male)]
        [Age(21, TimePeriods.Years)]
        MeirJanAlmog = 138,

        [Countries(CountryLikeThings.Ethiopia, CountryLikeThings.Israel)]
        [PreviouslyHeldAsHostage]
        [HumanGender(HumanGender.Male)]
        [Age(28, TimePeriods.Years)]
        MengistuAvera = 139,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(62, TimePeriods.Years)]
        MermanClara = 140,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(60, TimePeriods.Years)]
        MermanFernandoSimon = 141,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(78, TimePeriods.Years)]
        MetzgerTamar = 142,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(80, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        MetzgerYoram = 143,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Hungary)]
        [HumanGender(HumanGender.Male)]
        [Age(46, TimePeriods.Years)]
        MiranOmri = 144,

        [Country(CountryLikeThings.Tanzania)]
        [HumanGender(HumanGender.Male)]
        [Age(21, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        MollelJoshua = 145,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(23, TimePeriods.Years)]
        MorEitanAbraham = 146,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [HumanGender(HumanGender.Female)]
        [Age(72, TimePeriods.Years)]
        MosheAdina = 147,

        /// <summary>
        /// member of Kibbutz Nir Or
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [ApproximateAgeInYears(77, 78)]
        MosesMargalit = 148,

        /// <summary>
        /// [sometimes refered to as Gadi Moses]
        /// His partner, Efrat Katz was presumed captive as well, but was likely killed
        /// 2023-10-07 by an Israeli helicopter gunship responding to the assault. The
        /// helicopter targeted a vehicle carrying Hamas gunmen, unaware that hostages
        /// were also inside.
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(79, TimePeriods.Years)]
        MozesGadiMoshe = 149,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(78, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        MunderAbraham = 150,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(54, TimePeriods.Years)]
        MunderKeren = 151,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(8, TimePeriods.Years)]
        MunderOhad = 152,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(78, TimePeriods.Years)]
        MunderRuth = 153,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Female)]
        [Age(35, TimePeriods.Years)]
        MunkanNattawaree = 154,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [IsraelDefenceForcesSoldier("Captain")]
        [HumanGender(HumanGender.Male)]
        [Age(21, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        NeutraOmerMaxim = 155,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [HumanGender(HumanGender.Male)]
        [Age(18, TimePeriods.Years)]
        [DeathDate(2023, 10, 9)]
        NimrodTamir = 156,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Brazil)]
        [HumanGender(HumanGender.Male)]
        [Age(59, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        NisenbaumMichel = 157,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(30, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        OakkharasriSonthaya = 158,

        /// <summary>
        /// Yosek-Haim Ohana
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(23, TimePeriods.Years)]
        OhanaYosefHaim = 159,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Serbia, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        OhelAlon = 160,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        OnkaewNatthaporn = 161,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(13, TimePeriods.Years)]
        OrAlma = 162,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(30, TimePeriods.Years)]
        OrAvinathan = 163,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [HumanGender(HumanGender.Male)]
        [Age(48, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        OrDror = 164,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(18, TimePeriods.Years)]
        OrLiam = 165,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(17, TimePeriods.Years)]
        OrNoam = 166,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        OzDaniel = 167,

        [Country(CountryLikeThings.Philippines)]
        [HumanGender(HumanGender.Male)]
        [Age(33, TimePeriods.Years)]
        PachecoGelienorJimmy = 168,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(45, TimePeriods.Years)]
        PankhongBoonthom = 169,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.SouthAfrica)]
        [IsraelDefenceForcesSoldier("Captain")]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        PerezDaniel = 170,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [HumanGender(HumanGender.Male)]
        [Age(79, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        PeriChaim = 171,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.SouthAfrica)]
        [HumanGender(HumanGender.Female)]
        [Age(79, TimePeriods.Years)]
        PeriChanna = 172,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        PhachuabboonMongkol = 173,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(33, TimePeriods.Years)]
        PhoomeVetoon = 174,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(30, TimePeriods.Years)]
        PinakalowPornsawan = 175,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [ApproximateAgeInYears(35, 36)]
        [DeathDate(2023, 12)]
        PintaNattapong = 176,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedKingdom)]
        [HumanGender(HumanGender.Male)]
        [Age(51, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        PopplewellNadav = 177,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [HumanGender(HumanGender.Female)]
        [Age(59, TimePeriods.Years)]
        RaananJudith = 178,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [HumanGender(HumanGender.Female)]
        [Age(17, TimePeriods.Years)]
        RaananNatalie = 179,

        [Countries(CountryLikeThings.Mexico, CountryLikeThings.France)]
        [HumanGender(HumanGender.Male)]
        [Age(30, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        RadouxOriónHernández = 180,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(42, TimePeriods.Years)]
        RataninPaiboon = 181,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(18, TimePeriods.Years)]
        RegevItay = 182,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(21, TimePeriods.Years)]
        RegevMaya = 183,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [ApproximateAgeInYears(42, 43)]
        [DeathDate(2023, 10, 7)]
        RinthalakSudthisak = 184,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(77, TimePeriods.Years)]
        RoitmanOfelia = 185,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(35, TimePeriods.Years)]
        RomanGatYarden = 186,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [ApproximateAgeInYears(30, 31)]
        RumnaoSurasak = 187,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(54, TimePeriods.Years)]
        RotemRaaya = 188,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(61, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        RudaeffLior = 189,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        SaelaoKong = 190,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SaengboonBuddhee = 191,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SaengnuanUthai = 192,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(27, TimePeriods.Years)]
        SaethaoBannawat = 193,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(74, TimePeriods.Years)]
        SagiAda = 194,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(21, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        SameranoYonatan = 195,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SangkaewChalermchai = 196,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        SarusiAlmog = 197,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [HumanGender(HumanGender.Female)]
        [Age(21, TimePeriods.Years)]
        SchemMia = 198,

        /// <summary>
        /// killed by friendly fire while surrendering
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        [DeathDate(2023, 12, 15)]
        ShamrizAlon = 199,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(15, TimePeriods.Years)]
        ShaniAmit = 200,

        /// <summary>
        /// Sibling of Yossi Sharabi
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(51, TimePeriods.Years)]
        SharabiEli = 201,

        /// <summary>
        /// Sibling of Eli Sharabi
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [HumanGender(HumanGender.Male)]
        [Age(53, TimePeriods.Years)]
        [DeathDate(2024, 1, 10)]
        SharabiYossi = 202,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [PreviouslyHeldAsHostage]
        [HumanGender(HumanGender.Male)]
        [Age(20, TimePeriods.Years)]
        [DeathDate(2014, 7, 20)]
        ShaulOron = 203,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(20, TimePeriods.Years)]
        ShemTovOmer = 204,

        /// <summary>
        /// killed in IDF airstrike
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 11, 10)]
        ShermanRon = 205,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(38, TimePeriods.Years)]
        ShohamAdi = 206,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(8, TimePeriods.Years)]
        ShohamNave = 207,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Austria, CountryLikeThings.Italy)]
        [HumanGender(HumanGender.Male)]
        [Age(38, TimePeriods.Years)]
        ShohamTal = 208,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(3, TimePeriods.Years)]
        ShohamYahel = 209,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(12, TimePeriods.Years)]
        ShoshaniHilaRotem = 210,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [HumanGender(HumanGender.Male)]
        [Age(28, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        ShtiviIdan = 211,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.SouthAfrica, CountryLikeThings.UnitedStates)]
        [HumanGender(HumanGender.Female)]
        [Age(62, TimePeriods.Years)]
        SiegelAdrienneAviva = 212,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [HumanGender(HumanGender.Male)]
        [Age(64, TimePeriods.Years)]
        SiegelSamuelKeith = 213,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(40, TimePeriods.Years)]
        SoussanaAmit = 214,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(32, TimePeriods.Years)]
        SriaounWatchara = 215,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SrikeinaJakkrapan = 216,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Romania)]
        [HumanGender(HumanGender.Female)]
        [Age(30, TimePeriods.Years)]
        SteinbrecherDoron = 217,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(40, TimePeriods.Years)]
        SuriyasriOwas = 218,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(34, TimePeriods.Years)]
        SuwannakhamSathian = 219,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(38, TimePeriods.Years)]
        [DeathDate(2024, 1)]
        SvirskyItai = 220,

        /// <summary>
        /// killed by friendly fire while surrendering
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(24, TimePeriods.Years)]
        [DeathDate(2023, 12, 15)]
        TalalkaSamer = 221,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(54, TimePeriods.Years)]
        TalMeirav = 222,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(13, TimePeriods.Years)]
        TarshanskyGali = 223,

        /// <summary>
        /// mother of Yelena Trufanov and Alexander (Sasha) Trufanov
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [HumanGender(HumanGender.Female)]
        [Age(73, TimePeriods.Years)]
        TatiIrena = 224,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(37, TimePeriods.Years)]
        TemthongVichian = 225,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(35, TimePeriods.Years)]
        ThaennaPongsak = 226,

        /// <summary>
        /// killed in IDF airstrike (civilian)
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [HumanGender(HumanGender.Male)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023, 11, 10)]
        ToledanoElia = 227,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        ToonsriUthai = 228,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        TornsokreePattanayut = 229,

        /// <summary>
        /// Trupanob is a transformation of the Hebrew.
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [HumanGender(HumanGender.Female)]
        [Age(50, TimePeriods.Years)]
        TrufanovYelena = 230,

        /// <summary>
        /// Trupanob is a transformation of the Hebrew.
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [HumanGender(HumanGender.Male)]
        [Age(27, TimePeriods.Years)]
        TrufanovAlexanderSasha = 231,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [HumanGender(HumanGender.Male)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023)]
        TzarfatiOfir = 232,

        /// <summary>
        /// Judith Weinstein-Haggai
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [HumanGender(HumanGender.Female)]
        [Age(70, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        WeinsteinHaggaiJudith = 233,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Hungary)]
        [HumanGender(HumanGender.Male)]
        [Age(55, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        WeissIlan = 234,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Hungary)]
        [HumanGender(HumanGender.Female)]
        [Age(18, TimePeriods.Years)]
        WeissNoga = 235,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(53, TimePeriods.Years)]
        WeissShiri = 236,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(65, TimePeriods.Years)]
        [DeathDate(2023, 11)]
        WeissYehudit = 237,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        WenkertOmer = 238,

        /// <summary>
        /// Jacob is alternate spelling of last name, related to the other Yaakovs
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(16, TimePeriods.Years)]
        YaakovOr = 239,

        /// <summary>
        /// Jacob is alternate spelling of last name, related to the other Yaakovs
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Male)]
        [Age(12, TimePeriods.Years)]
        YaakovYagil = 240,

        /// <summary>
        /// Jacob is alternate spelling of last name, related to the other Yaakovs
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(59, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        YaakovYair = 241,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(41, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        YablonkaHanan = 242,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [HumanGender(HumanGender.Male)]
        [Age(12, TimePeriods.Years)]
        YahalomiEitan = 243,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [HumanGender(HumanGender.Male)]
        [Age(49, TimePeriods.Years)]
        [DeathDate(2024, 1, 19)]
        YahalomiOhad = 244,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(40, TimePeriods.Years)]
        YanaiMoranStela = 245,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [HumanGender(HumanGender.Female)]
        [Age(28, TimePeriods.Years)]
        YehoudArbel = 246,

        /// <summary>
        /// killed during the October 7 attacks, but never taken into Gaza
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [NotActuallyAHostage]
        [HumanGender(HumanGender.Male)]
        [Age(35, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        YehoudDolev = 247,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(23, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        YerushalmiEden = 248,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(79, TimePeriods.Years)]
        YitzhakNuritCooper = 249,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(85, TimePeriods.Years)]
        [DeathDate(2023, 11)]
        ZalmanovitchArye = 250,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(23, TimePeriods.Years)]
        ZangaukerMatan = 251,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        ZechariahEden = 252,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(40, TimePeriods.Years)]
        ZivShlomi = 253,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Female)]
        [Age(17, TimePeriods.Years)]
        ZiyadneAisha = 254,

        [Country(CountryLikeThings.Israel)]
        [HumanGender(HumanGender.Male)]
        [Age(18, TimePeriods.Years)]
        ZiyadneBilal = 255,
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
            [Number(1)]
            [Hostages(HostageList.AlZayadniYosef)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            public static class January8 { }

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
                [Number(3)]
                [Hostages(HostageList.DamariEmily, HostageList.GonenRomi, HostageList.SteinbrecherDoron)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                public static class January19ReleasedAlive { }

                [Number(4)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(HostageList.AlbagLiri,
                    HostageList.ArievKarina,
                    HostageList.GilboaDaniella,
                    HostageList.LevyNaama)]
                public static class January25 { }

                [Number(8)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(HostageList.YehoudArbel,
                    HostageList.BergerAgam,
                    HostageList.MozesGadiMoshe,
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

internal class ExecutedByPalestinianMilitantGroup : ExecutedAttribute
{
    public PalestinianMilitantGroups PalestinianMilitantGroup { get; set; }
    public ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups palestinianMiltantGroup)
    {
        PalestinianMilitantGroup = palestinianMiltantGroup;
    }
}

internal enum PalestinianMilitantGroups
{
    Hamas,
    PalestinianIslamicJihad,
    Other,
}
