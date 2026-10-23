
using Existence.Earth.Alphabet;
using Existence.Earth.Countries;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human.EthnicGroups;
using Existence.Earth.Human.People;
using Existence.Earth.Time;
using Existence.Earth.War;
using Existence.Time;
using System;

namespace Existence.Earth.War
{
    public class HostagesConstants
    {
        public const string OPERATION_PROTECTIVE_EDGE = "Operation Protective Edge";
    }

    public class HostagesAttribute : Attribute
    {
        public HostageList[] Hostages { get; set; }
        public HostagesAttribute(params HostageList[] Hostages)
        {
            this.Hostages = Hostages;
        }
    }

    /// <summary>
    /// contains the outcome of a hostage situation
    /// </summary>
    public class HostageOutcomeAttribute : Attribute
    {
        /// <summary>
        /// outcome type
        /// </summary>
        public HostageOutcome Outcome { get; set; }

        /// <summary>
        /// country where the outcome took place (general rule being this is where the transfer away from the hostage-taker took place)
        /// 1. Released body or released alive, this is where the transfer happened
        /// 2. Remains identified: This is where the remains were found
        /// 3. Recovered or rescued: This is where the recovery or rescue tookplace
        /// </summary>
        public CountryLikeThings? Country { get; set; }

        /// <summary>
        /// city where the outcome took place
        /// </summary>
        /// <remarks>see country documentation for the rules around city assignment</remarks>
        public WorldCities? City { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Outcome">outcome of the hostage situation</param>
        public HostageOutcomeAttribute(HostageOutcome Outcome)
        {
            this.Outcome = Outcome;
            this.Country = null;
            this.City = null;
        }

        /// <summary>
        /// constructor for a country
        /// </summary>
        /// <param name="Outcome">outcome of the hostage situation</param>
        /// <param name="Country">country where the outcome took place</param>
        public HostageOutcomeAttribute(HostageOutcome Outcome, CountryLikeThings Country) : this(Outcome)
        {
            this.Country = Country;
        }

        /// <summary>
        /// constructor for a country and city
        /// </summary>
        /// <param name="Outcome">outcome of the hostage situation</param>
        /// <param name="Country">country where the outcome took place</param>
        /// <param name="City">city where the outcome took place</param>
        public HostageOutcomeAttribute(HostageOutcome Outcome, CountryLikeThings Country, WorldCities City) : this (Outcome, Country)
        {
            this.City = City;
        }

    }

    /// <summary>
    /// marks a class grouping hostage outcomes that took place under an agreement negotiated between Israel and Hamas
    /// </summary>
    public class IsraeliHamasHostageAgreementAttribute : Attribute
    {
        public IsraeliHamasHostageAgreement Agreement { get; set; }
        public IsraeliHamasHostageAgreementAttribute(IsraeliHamasHostageAgreement Agreement)
        {
            this.Agreement = Agreement;
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
    /// agreements negotiated between Israel and Hamas under which hostages were returned
    /// </summary>
    /// <remarks>
    /// returns outside of an Israel-Hamas agreement are not included, e.g. the October 2023 releases
    /// releases of Thai nationals negotiated separately by Thailand, and the May 2025 release of a United States hostage (negotiated between the US and Hamas)
    /// </remarks>
    public enum IsraeliHamasHostageAgreement
    {
        /// <summary>
        /// Qatar/Egypt/United States mediated truce agreed November 22, 2023, in effect November 24 - December 1, 2023 (extended twice);
        /// hostages exchanged for Palestinian prisoners; 81 hostages released under the agreement, with 23 Thai nationals and
        /// 1 Filipino released on the same days through separate negotiations
        /// </summary>
        [Total(81)]
        November2023HostageReleaseAgreement,

        /// <summary>
        /// Qatar/Egypt/United States mediated ceasefire agreed January 15, 2025, in effect January 19, 2025; only phase 1
        /// (through March 1, 2025) was carried out before fighting resumed March 18, 2025
        /// </summary>
        [Total(33)]
        January2025HostageReturnAgreement,

        /// <summary>
        /// first phase of the United States 20-point Gaza peace plan, agreed October 9, 2025, in effect October 10, 2025;
        /// all living hostages released October 13, 2025, with the remains of deceased hostages returned afterward
        /// </summary>
        [Total(47)]
        October2025HostageReturnAgreement,
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
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(38, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        AdarTamir = 0,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(85, TimePeriods.Years)]
        AdarYafa = 1,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(20, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        AhimasTomerYaakov = 2,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups(WorldEthnicGroups.Arab, WorldEthnicGroups.Bedouin)]
        [IsraelDefenceForcesSoldier("Sergeant Major")]
        [HumanGender(HumanGender.Male)]
        [Age(39, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        AlAtreshMuhammad = 3,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(44, TimePeriods.Years)]
        AloniDaniel = 4,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(5, TimePeriods.Years)]
        AloniEmelia = 5,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups(WorldEthnicGroups.Arab, WorldEthnicGroups.Bedouin)]
        [PreviouslyHeldAsHostage]
        [HumanGender(HumanGender.Male)]
        [Age(27, TimePeriods.Years)]
        [StartYear(2015)]
        AlSayedHishamShaaban = 6,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups(WorldEthnicGroups.Arab, WorldEthnicGroups.Bedouin)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        [DeathDateUnknown]
        AlZayadniHamzah = 7,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups(WorldEthnicGroups.Arab, WorldEthnicGroups.Bedouin)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [ApproximateAgeInYears(52, 53)]
        [DeathDateUnknown]
        AlZayadniYosef = 8,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [HumanGender(HumanGender.Female)]
        [Age(18, TimePeriods.Years)]
        AlbagLiri = 9,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        AlexanderEdan = 10,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups(WorldEthnicGroups.Arab, WorldEthnicGroups.Bedouin)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(51, TimePeriods.Years)]
        AlkadiQaidFarhan = 11,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(28, TimePeriods.Years)]
        AngkaewAnucha = 12,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Bulgaria)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [KidnappedFrom(KidnappedFrom.ArmoredVehicle)]
        [HumanGender(HumanGender.Male)]
        [Age(20, TimePeriods.Years)]
        AngrestMatan = 13,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroup(WorldEthnicGroups.Han)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Female)]
        [Age(25, TimePeriods.Years)]
        ArgamaniNoa = 14,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [HumanGender(HumanGender.Female)]
        [Age(19, TimePeriods.Years)]
        ArievKarina = 15,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(2, TimePeriods.Years)]
        AsherAviv = 16,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(34, TimePeriods.Years)]
        AsherDoronKatz = 17,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(4, TimePeriods.Years)]
        AsherRaz = 18,

        /// <summary>
        /// related to BeininLiat
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(49, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        AtziliAviv = 19,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(12, TimePeriods.Years)]
        AvigdoriNoam = 20,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(52, TimePeriods.Years)]
        AvigdoriSharon = 21,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NahalOz)]
        [HumanGender(HumanGender.Female)]
        [Age(84, TimePeriods.Years)]
        AvrihamElma = 22,

        [Countries(CountryLikeThings.Philippines, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(60, TimePeriods.Years)]
        BabadillaNoralin = 23,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Bulgaria)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Male)]
        [Age(24, TimePeriods.Years)]
        [DeathDate(2023, 12, 8)]
        BaruchSahar = 24,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(34, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        BaruchUriael = 25,

        /// <summary>
        /// related to Aviv Atzili
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(49, TimePeriods.Years)]
        BeininLiat = 26,

        /// <summary>
        /// killed in IDF airstrike
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Corporal")]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 11, 10)]
        BeizerNik = 27,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Male)]
        [Age(54, TimePeriods.Years)]
        BenAmiOhad = 28,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
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
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [HumanGender(HumanGender.Female)]
        [Age(19, TimePeriods.Years)]
        BergerAgam = 31,

        /// <summary>
        /// Gali/Ziv Berman are twins
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        BermanGali = 32,

        /// <summary>
        /// Gali/Ziv Berman are twins
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        BermanZiv = 33,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(4, TimePeriods.Years)]
        [DeathDate(2023, 11)]
        BibasAriel = 34,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(8, TimePeriods.Months)]
        [DeathDate(2023, 11)]
        BibasKfir = 35,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(32, TimePeriods.Years)]
        [DeathDate(2023, 11)]
        BibasShiri = 36,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(33, TimePeriods.Years)]
        BibasYarden = 37,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Colombia)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(34, TimePeriods.Years)]
        BohbotElkana = 38,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        BoonpromSanti = 39,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        BraslavskiRom = 40,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        BrodskiKiril = 41,

        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Female)]
        [Age(40, TimePeriods.Years)]
        BrodutchHagar = 42,

        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Female)]
        [Age(9, TimePeriods.Years)]
        BrodutchOfri = 43,

        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Female)]
        [Age(4, TimePeriods.Years)]
        BrodutchOriya = 44,

        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Male)]
        [Age(9, TimePeriods.Years)]
        BrodutchYuval = 45,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Nirim)]
        [HumanGender(HumanGender.Female)]
        [Age(36, TimePeriods.Years)]
        BuchshtavRimonKirsht = 46,

        /// <summary>
        /// Buckshtav?
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Nirim)]
        [HumanGender(HumanGender.Male)]
        [Age(34, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        BuchshtabYagev = 47,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
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
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(29, TimePeriods.Years)]
        ChombuaKomkrit = 50,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        CohenEliya = 51,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [KidnappedFrom(KidnappedFrom.ArmoredVehicle)]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        CohenNimrod = 52,

        /// <summary>
        /// girlfriend of Alexandre (Sasha) Troufanov
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(29, TimePeriods.Years)]
        CohenSapir = 53,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(84, TimePeriods.Years)]
        [DeathDateUnknown]
        CooperAmiram = 54,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        CunioAriel = 55,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(33, TimePeriods.Years)]
        CunioDavid = 56,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(3, TimePeriods.Years)]
        CunioEmma = 57,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(34, TimePeriods.Years)]
        CunioSharonOlani = 58,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
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
        [KidnappedFrom(KidnappedFrom.ArmoredVehicle)]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        DahanShaked = 61,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedKingdom)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Female)]
        [Age(27, TimePeriods.Years)]
        DamariEmily = 62,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(75, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        DancygAlexander = 63,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(24, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        DaninoOri = 64,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        DavidEvyatar = 65,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(35, TimePeriods.Years)]
        DekelChenSagui = 66,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Female)]
        [Age(3, TimePeriods.Years)]
        EdanAbigail = 67,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(68, TimePeriods.Years)]
        [DeathDateUnknown]
        ElgaratItzhk = 68,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(15, TimePeriods.Years)]
        ElyakimDafna = 69,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(8, TimePeriods.Years)]
        ElyakimEla = 70,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(51, TimePeriods.Years)]
        EngelBartKarina = 71,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(18, TimePeriods.Years)]
        EngelMika = 72,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Netherlands)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(17, TimePeriods.Years)]
        EngelOfir = 73,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(54, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        EngelRonan = 74,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(11, TimePeriods.Years)]
        EngelYuval = 75,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(39, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        GatCarmel = 76,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(56, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GelerenterItzhak = 77,

        /// <summary>
        /// originally named Danielle
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Bulgaria)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [HumanGender(HumanGender.Female)]
        [Age(19, TimePeriods.Years)]
        GilboaDaniella = 78,

        /// <summary>
        /// Guy Gilboa-Dalal
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        GilboaDalalGuy = 79,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Male)]
        [Age(73, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GodardManny = 80,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
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
        [Text(HostagesConstants.OPERATION_PROTECTIVE_EDGE)]
        [StartYear(2014)]
        GoldinHadar = 82,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirYitzhak)]
        [HumanGender(HumanGender.Male)]
        [Age(33, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GoldinOren = 83,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Female)]
        [Age(17, TimePeriods.Years)]
        GoldsteinAlmogAgam = 84,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Female)]
        [Age(48, TimePeriods.Years)]
        GoldsteinAlmogChen = 85,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Male)]
        [Age(11, TimePeriods.Years)]
        GoldsteinAlmogGal = 86,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Male)]
        [Age(9, TimePeriods.Years)]
        GoldsteinAlmogTal = 87,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Female)]
        [Age(23, TimePeriods.Years)]
        GonenRomi = 88,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(56, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GorenMaya = 89,

        [Countries(CountryLikeThings.Uruguay, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(29, TimePeriods.Years)]
        GorenShani = 90,

        [Countries(CountryLikeThings.Mexico, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(30, TimePeriods.Years)]
        GritzewskyIlana = 91,

        /// <summary>
        /// aka Rani, last hostage accounted for
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(24, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GviliRan = 92,

        /// <summary>
        /// aka Gadi
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(72, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        HaggaiGad = 93,

        /// <summary>
        /// killed by friendly fire while surrendering
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Male)]
        [Age(28, TimePeriods.Years)]
        [DeathDate(2023, 12, 15)]
        HaimYotam = 94,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Romania)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirYitzhak)]
        [HumanGender(HumanGender.Male)]
        [Age(41, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        HaimiTal = 95,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Colonel")]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(40, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        HamamiAsaf = 96,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Ireland)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Female)]
        [Age(8, TimePeriods.Years)]
        HandEmily = 97,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Female)]
        [Age(67, TimePeriods.Years)]
        HaranShoshan = 98,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(70, TimePeriods.Years)]
        HarLuis = 99,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Female)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        HaymanInbar = 100,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(84, TimePeriods.Years)]
        HeimanDitza = 101,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia, CountryLikeThings.Ukraine)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(35, TimePeriods.Years)]
        HerkinMaxim = 102,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(37, TimePeriods.Years)]
        HornEitan = 103,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(45, TimePeriods.Years)]
        HornIair = 104,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NahalOz)]
        [HumanGender(HumanGender.Male)]
        [Age(49, TimePeriods.Years)]
        [DeathDate(2023, 12, 4)]
        IdanTsachi = 105,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        [DeathDate(2023)]
        IluzGuy = 106,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(29, TimePeriods.Years)]
        JirachartManee = 107,

        [Country(CountryLikeThings.Nepal)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        [DeathDate(2023)]
        JoshiBipin = 108,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(28, TimePeriods.Years)]
        KalapratVichai = 109,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(11, TimePeriods.Years)]
        KalderonErez = 110,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France, CountryLikeThings.Portugal)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(52, TimePeriods.Years)]
        KalderonOfer = 111,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(16, TimePeriods.Years)]
        KalderonSahar = 112,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(25, TimePeriods.Years)]
        KalfonSegev = 113,

        /// <summary>
        /// Death (after release) was attributed to medical complications from her time as a hostage
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(76, TimePeriods.Years)]
        [DeathDate(2024, 12, 24)]
        KatzirHannah = 114,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(47, TimePeriods.Years)]
        [DeathDate(2024, 1)]
        KatznirElad = 115,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant Major (res.)")]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(51, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        KatzRavid = 116,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Female)]
        [Age(70, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        KeidarOfra = 117,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        KesoognernSurin = 118,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        KongmaneeBancha = 119,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(27, TimePeriods.Years)]
        KozlovAndrey = 120,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(25, TimePeriods.Years)]
        KriboyRoni = 121,

        /// <summary>
        /// aka Kuperstein
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(21, TimePeriods.Years)]
        KupershteinBar = 122,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(59, TimePeriods.Years)]
        LeimbergGabriela = 123,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
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
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(53, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        LevyEitan = 126,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesSoldierAttribute.UNKNOWN_RANK)]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [HumanGender(HumanGender.Female)]
        [Age(19, TimePeriods.Years)]
        LevyNaama = 127,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(33, TimePeriods.Years)]
        LevyOr = 128,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(83, TimePeriods.Years)]
        [DeathDate(2023)]
        LifshitzOded = 129,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(85, TimePeriods.Years)]
        LifshitzYokheved = 130,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(32, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        LobanovAlexander = 131,

        [Countries(CountryLikeThings.Germany, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Female)]
        [Age(22, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        LoukShani = 132,

        /// <summary>
        /// Iraq-born
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Kissufim)]
        [HumanGender(HumanGender.Male)]
        [Age(85, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        MansourShlomo = 133,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Corporal")]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [HumanGender(HumanGender.Female)]
        [Age(18, TimePeriods.Years)]
        [DeathDate(2023)]
        MarcianoNoa = 134,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(75, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        MargalitEliyahu = 135,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(41, TimePeriods.Years)]
        MargalitNili = 136,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Private")]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [HumanGender(HumanGender.Female)]
        [Age(19, TimePeriods.Years)]
        MegidishOri = 137,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(21, TimePeriods.Years)]
        MeirJanAlmog = 138,

        [Countries(CountryLikeThings.Ethiopia, CountryLikeThings.Israel)]
        [PreviouslyHeldAsHostage]
        [HumanGender(HumanGender.Male)]
        [Age(28, TimePeriods.Years)]
        [StartYear(2014)]
        MengistuAvera = 139,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirYitzhak)]
        [HumanGender(HumanGender.Female)]
        [Age(62, TimePeriods.Years)]
        MermanClara = 140,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(60, TimePeriods.Years)]
        MermanFernandoSimon = 141,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(78, TimePeriods.Years)]
        MetzgerTamar = 142,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(80, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        MetzgerYoram = 143,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Hungary)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NahalOz)]
        [HumanGender(HumanGender.Male)]
        [Age(46, TimePeriods.Years)]
        MiranOmri = 144,

        [Country(CountryLikeThings.Tanzania)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(21, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        MollelJoshua = 145,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(23, TimePeriods.Years)]
        MorEitanAbraham = 146,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(72, TimePeriods.Years)]
        MosheAdina = 147,

        /// <summary>
        /// member of Kibbutz Nir Or
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
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
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(79, TimePeriods.Years)]
        MozesGadiMoshe = 149,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(78, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        MunderAbraham = 150,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(54, TimePeriods.Years)]
        MunderKeren = 151,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(8, TimePeriods.Years)]
        MunderOhad = 152,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(78, TimePeriods.Years)]
        MunderRuth = 153,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(35, TimePeriods.Years)]
        MunkanNattawaree = 154,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [IsraelDefenceForcesSoldier("Captain")]
        [KidnappedFrom(KidnappedFrom.ArmoredVehicle)]
        [HumanGender(HumanGender.Male)]
        [Age(21, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        NeutraOmerMaxim = 155,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [IsraelDefenceForcesSoldier("Staff Sergeant")]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
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
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(30, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        OakkharasriSonthaya = 158,

        /// <summary>
        /// Yosek-Haim Ohana
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(23, TimePeriods.Years)]
        OhanaYosefHaim = 159,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Serbia, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        OhelAlon = 160,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        OnkaewNatthaporn = 161,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Female)]
        [Age(13, TimePeriods.Years)]
        OrAlma = 162,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(30, TimePeriods.Years)]
        OrAvinathan = 163,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Male)]
        [Age(48, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        OrDror = 164,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Male)]
        [Age(18, TimePeriods.Years)]
        OrLiam = 165,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Male)]
        [Age(17, TimePeriods.Years)]
        OrNoam = 166,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [KidnappedFrom(KidnappedFrom.ArmoredVehicle)]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        OzDaniel = 167,

        [Country(CountryLikeThings.Philippines)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(33, TimePeriods.Years)]
        PachecoGelienorJimmy = 168,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
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
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(79, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        PeriChaim = 171,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.SouthAfrica)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Nirim)]
        [HumanGender(HumanGender.Female)]
        [Age(79, TimePeriods.Years)]
        PeriChanna = 172,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        PhachuabboonMongkol = 173,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(33, TimePeriods.Years)]
        PhoomeVetoon = 174,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(30, TimePeriods.Years)]
        PinakalowPornsawan = 175,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [ApproximateAgeInYears(35, 36)]
        [DeathDate(2023, 12)]
        PintaNattapong = 176,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedKingdom)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Nirim)]
        [HumanGender(HumanGender.Male)]
        [Age(51, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        PopplewellNadav = 177,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(59, TimePeriods.Years)]
        RaananJudith = 178,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(17, TimePeriods.Years)]
        RaananNatalie = 179,

        [Countries(CountryLikeThings.Mexico, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(30, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        RadouxOriónHernández = 180,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(42, TimePeriods.Years)]
        RataninPaiboon = 181,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(18, TimePeriods.Years)]
        RegevItay = 182,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Female)]
        [Age(21, TimePeriods.Years)]
        RegevMaya = 183,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [ApproximateAgeInYears(42, 43)]
        [DeathDate(2023, 10, 7)]
        RinthalakSudthisak = 184,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(77, TimePeriods.Years)]
        RoitmanOfelia = 185,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(35, TimePeriods.Years)]
        RomanGatYarden = 186,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [ApproximateAgeInYears(30, 31)]
        RumnaoSurasak = 187,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Female)]
        [Age(54, TimePeriods.Years)]
        RotemRaaya = 188,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirYitzhak)]
        [HumanGender(HumanGender.Male)]
        [Age(61, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        RudaeffLior = 189,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        SaelaoKong = 190,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SaengboonBuddhee = 191,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SaengnuanUthai = 192,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(27, TimePeriods.Years)]
        SaethaoBannawat = 193,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(74, TimePeriods.Years)]
        SagiAda = 194,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(21, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        SameranoYonatan = 195,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SangkaewChalermchai = 196,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        SarusiAlmog = 197,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Female)]
        [Age(21, TimePeriods.Years)]
        SchemMia = 198,

        /// <summary>
        /// killed by friendly fire while surrendering
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Male)]
        [Age(26, TimePeriods.Years)]
        [DeathDate(2023, 12, 15)]
        ShamrizAlon = 199,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Male)]
        [Age(15, TimePeriods.Years)]
        ShaniAmit = 200,

        /// <summary>
        /// Sibling of Yossi Sharabi
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Male)]
        [Age(51, TimePeriods.Years)]
        SharabiEli = 201,

        /// <summary>
        /// Sibling of Eli Sharabi
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
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
        [StartYear(2014)]
        [Text(HostagesConstants.OPERATION_PROTECTIVE_EDGE)]
        ShaulOron = 203,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(20, TimePeriods.Years)]
        ShemTovOmer = 204,

        /// <summary>
        /// killed in IDF airstrike
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina)]
        [IsraelDefenceForcesSoldier("Sergeant")]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [HumanGender(HumanGender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 11, 10)]
        ShermanRon = 205,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(38, TimePeriods.Years)]
        ShohamAdi = 206,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(8, TimePeriods.Years)]
        ShohamNave = 207,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Austria, CountryLikeThings.Italy)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(38, TimePeriods.Years)]
        ShohamTal = 208,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(3, TimePeriods.Years)]
        ShohamYahel = 209,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Female)]
        [Age(12, TimePeriods.Years)]
        ShoshaniHilaRotem = 210,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(28, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        ShtiviIdan = 211,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.SouthAfrica, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Female)]
        [Age(62, TimePeriods.Years)]
        SiegelAdrienneAviva = 212,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Male)]
        [Age(64, TimePeriods.Years)]
        SiegelSamuelKeith = 213,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Female)]
        [Age(40, TimePeriods.Years)]
        SoussanaAmit = 214,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(32, TimePeriods.Years)]
        SriaounWatchara = 215,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SrikeinaJakkrapan = 216,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Romania)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [HumanGender(HumanGender.Female)]
        [Age(30, TimePeriods.Years)]
        SteinbrecherDoron = 217,

        [Country(CountryLikeThings.Thailand)]
        [HumanGender(HumanGender.Male)]
        [Age(40, TimePeriods.Years)]
        SuriyasriOwas = 218,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(34, TimePeriods.Years)]
        SuwannakhamSathian = 219,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(38, TimePeriods.Years)]
        [DeathDate(2024, 1)]
        SvirskyItai = 220,

        /// <summary>
        /// killed by friendly fire while surrendering
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [EthnicGroups(WorldEthnicGroups.Arab, WorldEthnicGroups.Bedouin)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(24, TimePeriods.Years)]
        [DeathDate(2023, 12, 15)]
        TalalkaSamer = 221,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(54, TimePeriods.Years)]
        TalMeirav = 222,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Female)]
        [Age(13, TimePeriods.Years)]
        TarshanskyGali = 223,

        /// <summary>
        /// mother of Yelena Trufanov and Alexander (Sasha) Trufanov
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(73, TimePeriods.Years)]
        TatiIrena = 224,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
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
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023, 11, 10)]
        ToledanoElia = 227,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
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
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(50, TimePeriods.Years)]
        TrufanovYelena = 230,

        /// <summary>
        /// Trupanob is a transformation of the Hebrew.
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(27, TimePeriods.Years)]
        TrufanovAlexanderSasha = 231,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023)]
        TzarfatiOfir = 232,

        /// <summary>
        /// Judith Weinstein-Haggai
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(70, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        WeinsteinHaggaiJudith = 233,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Hungary)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Male)]
        [Age(55, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        WeissIlan = 234,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Hungary)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Female)]
        [Age(18, TimePeriods.Years)]
        WeissNoga = 235,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Female)]
        [Age(53, TimePeriods.Years)]
        WeissShiri = 236,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [HumanGender(HumanGender.Female)]
        [Age(65, TimePeriods.Years)]
        [DeathDate(2023, 11)]
        WeissYehudit = 237,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(22, TimePeriods.Years)]
        WenkertOmer = 238,

        /// <summary>
        /// Jacob is alternate spelling of last name, related to the other Yaakovs
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(16, TimePeriods.Years)]
        YaakovOr = 239,

        /// <summary>
        /// Jacob is alternate spelling of last name, related to the other Yaakovs
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(12, TimePeriods.Years)]
        YaakovYagil = 240,

        /// <summary>
        /// Jacob is alternate spelling of last name, related to the other Yaakovs
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(59, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        YaakovYair = 241,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(41, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        YablonkaHanan = 242,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(12, TimePeriods.Years)]
        YahalomiEitan = 243,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(49, TimePeriods.Years)]
        [DeathDate(2024, 1, 19)]
        YahalomiOhad = 244,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Female)]
        [Age(40, TimePeriods.Years)]
        YanaiMoranStela = 245,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
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
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Female)]
        [Age(23, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        YerushalmiEden = 248,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Female)]
        [Age(79, TimePeriods.Years)]
        YitzhakNuritCooper = 249,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(85, TimePeriods.Years)]
        [DeathDate(2023, 11)]
        ZalmanovitchArye = 250,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [HumanGender(HumanGender.Male)]
        [Age(23, TimePeriods.Years)]
        ZangaukerMatan = 251,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Female)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        ZechariahEden = 252,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [HumanGender(HumanGender.Male)]
        [Age(40, TimePeriods.Years)]
        ZivShlomi = 253,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups(WorldEthnicGroups.Arab, WorldEthnicGroups.Bedouin)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Female)]
        [Age(17, TimePeriods.Years)]
        ZiyadneAisha = 254,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups(WorldEthnicGroups.Arab, WorldEthnicGroups.Bedouin)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [HumanGender(HumanGender.Male)]
        [Age(18, TimePeriods.Years)]
        ZiyadneBilal = 255,
    }

    /// <summary>
    /// see https://www.cnn.com/interactive/2023/12/world/hostage-israel-hamas-deal-dg/
    /// </summary>
    public class IsraelHamasHostages
    {
        [Total(121)]
        public static class v2023
        {
            [Hostages(
                HostageList.ShaulOron,
                HostageList.GoldinHadar,
                HostageList.MengistuAvera,
                HostageList.AlSayedHishamShaaban)]
            [Number(4)]
            public static class HeldPriorToOctober7 { }

            [Hostages(HostageList.RaananJudith, HostageList.RaananNatalie)]
            [Number(2)]
            [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
            public static class October20 { }

            [Hostages(HostageList.LifshitzYokheved, HostageList.YitzhakNuritCooper)]
            [Number(2)]
            [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
            public static class October23 { }

            [Hostages(HostageList.MegidishOri)]
            [Number(1)]
            [HostageOutcome(HostageOutcome.RescuedAlive, CountryLikeThings.PalestineGaza)]
            public static class October30 { }

            /// <summary>
            /// recovered bodies from buildings adjacent to Al-Shifa hospital
            /// </summary>
            [Hostages(HostageList.WeissYehudit, HostageList.MarcianoNoa)]
            [Number(2)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
            public static class November1617 { }

            [IsraeliHamasHostageAgreement(IsraeliHamasHostageAgreement.November2023HostageReleaseAgreement)]
            public static class November2023HostageReleaseAgreementA
            {
                [Number(13)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
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
                    HostageList.PeriChanna)]
                public static class November24A { }
            }

            /// <summary>
            /// not part of the November 2023 agreement (Thai and Filipino nationals released through separate negotiations)
            /// </summary>
            [Number(11)]
            [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
            [Hostages(
                HostageList.MunkanNattawaree,
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
            public static class November24B { }

            [IsraeliHamasHostageAgreement(IsraeliHamasHostageAgreement.November2023HostageReleaseAgreement)]
            public static class November2023HostageReleaseAgreementB
            {
                [Number(13)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
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
                    HostageList.WeissShiri)]
                public static class November25A { }
            }

            /// <summary>
            /// not part of the November 2023 agreement (Thai nationals released through separate negotiations)
            /// </summary>
            [Number(4)]
            [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
            [Hostages(
                HostageList.AngkaewAnucha,
                HostageList.ChombuaKomkrit,
                HostageList.JirachartManee,
                HostageList.OnkaewNatthaporn)]
            public static class November25B { }

            [IsraeliHamasHostageAgreement(IsraeliHamasHostageAgreement.November2023HostageReleaseAgreement)]
            public static class November2023HostageReleaseAgreementC
            {
                [Number(14)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
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
                    HostageList.SiegelAdrienneAviva)]
                public static class November26A { }
            }

            /// <summary>
            /// not part of the November 2023 agreement (Thai nationals released through separate negotiations)
            /// </summary>
            [Number(3)]
            [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
            [Hostages(
                HostageList.KesoognernSurin,
                HostageList.PinakalowPornsawan,
                HostageList.TemthongVichian)]
            public static class November26B { }

            [IsraeliHamasHostageAgreement(IsraeliHamasHostageAgreement.November2023HostageReleaseAgreement)]
            public static class November2023HostageReleaseAgreementD
            {
                [Number(11)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
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

                [Number(10)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
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
                    HostageList.TalMeirav)]
                public static class November28A { }
            }

            /// <summary>
            /// not part of the November 2023 agreement (Thai nationals released through separate negotiations)
            /// </summary>
            [Number(2)]
            [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
            [Hostages(
                HostageList.SuriyasriOwas,
                HostageList.TornsokreePattanayut)]
            public static class November28B { }

            [IsraeliHamasHostageAgreement(IsraeliHamasHostageAgreement.November2023HostageReleaseAgreement)]
            public static class November2023HostageReleaseAgreementE
            {
                [Number(12)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
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
                    HostageList.TrufanovYelena,
                    HostageList.TatiIrena)]
                public static class November29A { }
            }

            /// <summary>
            /// not part of the November 2023 agreement (Thai nationals released through separate negotiations)
            /// </summary>
            [Number(4)]
            [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
            [Hostages(
                HostageList.RataninPaiboon,
                HostageList.SaelaoKong,
                HostageList.SangkaewChalermchai,
                HostageList.SrikeinaJakkrapan)]
            public static class November29B { }

            /// <summary>
            /// The IDF and Shin Bet announce they have recovered the body of deceased hostage in recent days
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.TzarfatiOfir)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza)]
            public static class November29 { }

            [IsraeliHamasHostageAgreement(IsraeliHamasHostageAgreement.November2023HostageReleaseAgreement)]
            public static class November2023HostageReleaseAgreementF
            {
                [Number(8)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
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
            /// The IDF recovers bodies in underground tunnels in Jabalia, Gaza
            /// </summary>
            [Number(2)]
            [Hostages(HostageList.ZechariahEden, HostageList.DadoZiv)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaJabalia)]
            public static class December12 { }

            /// <summary>
            /// An IDF airstrike targeting Hamas's northern Gaza brigade chief, Ahmed Ghandour, killed three hostages, but their
            /// bodies were not recovered until December 15th
            /// </summary>
            [Number(3)]
            [HostageOutcome(HostageOutcome.RecoveredBodyKilledByIsrael, CountryLikeThings.PalestineGaza, WorldCities.GazaJabalia)]
            [Hostages(
                HostageList.ShermanRon,
                HostageList.BeizerNik,
                HostageList.ToledanoElia
                )]
            public static class December15A { }

            /// <summary>
            /// During the Battle of Shuja'iyya, Israeli Defense Forces (IDF) mistakenly identified three Israeli hostages
            /// and opened fire, resulting in their deaths. The hostages were reportedly waving a white flag at the time. 
            /// </summary>
            [Number(3)]
            [HostageOutcome(HostageOutcome.RecoveredBodyKilledByIsrael, CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
            [Hostages(
                HostageList.ShamrizAlon,
                HostageList.HaimYotam,
                HostageList.TalalkaSamer)]
            public static class December15B { }
        }
        [Total(35)]
        public static class v2024
        {
            /// <summary>
            /// Operation Golden Hand: rescued in Rafah, Gaza
            /// </summary>
            [Number(2)]
            [Hostages(HostageList.MermanFernandoSimon, HostageList.HarLuis)]
            [HostageOutcome(HostageOutcome.RescuedAlive, CountryLikeThings.PalestineGaza, WorldCities.GazaRafah)]
            public static class February12 { }

            /// <summary>
            ///	The IDF announces it has recovered one body
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.KatznirElad)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
            public static class April6 { }

            /// <summary>
            /// Reportedly kidnapped during the attack on the Nova festival
            /// All three were killed near the site of the attack and their bodies were taken into Gaza and later recovered in a Hamas tunnel
            /// JPost says they were recovered in Jabalia (what the IDF reported at the time), JNS says Rafah.
            /// </summary>
            [Hostages(HostageList.LoukShani, HostageList.BuskilaEstherAmit, HostageList.GelerenterItzhak)]
            [Number(3)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza)]
            public static class May17 { }

            /// <summary>
            /// It was announced by the IDF that they had also recovered the body of a deceased hostage whose body was recovered 
            /// alongside those announced the day before. The hostage was abducted while riding his bike on the day of the attack
            /// </summary>
            [Hostages(HostageList.BenjaminRon)]
            [Number(1)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaJabalia)]
            public static class May18 { }

            /// <summary>
            /// The Israel Defense Forces has recovered the bodies of three more hostages from the northern Gaza Strip in an overnight operation.
            /// </summary>
            [Number(3)]
            [Hostages(HostageList.RadouxOriónHernández, HostageList.YablonkaHanan, HostageList.NisenbaumMichel)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaJabalia)]
            public static class May24 { }

            [Number(1)]
            [Hostages(HostageList.YehoudDolev)]
            [HostageOutcome(HostageOutcome.RemainsIdentified, CountryLikeThings.Israel)]
            public static class June3 { }

            /// <summary>
            /// rescued from Nuseirat refugee camp
            /// </summary>
            [Number(4)]
            [HostageOutcome(HostageOutcome.RescuedAlive, CountryLikeThings.PalestineGaza)]
            [Hostages(
                HostageList.ArgamaniNoa,
                HostageList.MeirJanAlmog,
                HostageList.KozlovAndrey,
                HostageList.ZivShlomi)]
            public static class June8 { }

            /// <summary>
            /// bodies recovered from a tunnel located in the Israeli-designated humanitarian zone in the southern Gaza Strip
            /// </summary>
            [Number(5)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
            [Hostages(
                HostageList.KatzRavid,
                HostageList.GoldinOren,
                HostageList.GorenMaya,
                HostageList.BrodskiKiril,
                HostageList.AhimasTomerYaakov)]
            public static class July24 { }

            /// <summary>
            ///  bodies of the six hostages recovered by the IDF from southern Gaza’s Khan Younis 
            /// </summary>
            [Number(6)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
            [Hostages(
                HostageList.DancygAlexander,
                HostageList.BuchshtabYagev,
                HostageList.PeriChaim,
                HostageList.MetzgerYoram,
                HostageList.PopplewellNadav,
                HostageList.MunderAbraham)]
            public static class August1920 { }

            /// <summary>
            /// rescued in a tunnel in southern Gaza during a joint op by IDF and Shin Bet
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.AlkadiQaidFarhan)]
            [HostageOutcome(HostageOutcome.RescuedAlive, CountryLikeThings.PalestineGaza)]
            public static class August27 { }

            [Number(1)]
            [Hostages(HostageList.DahanShaked)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza)]
            public static class August28 { }

            /// <summary>
            /// recovered the bodies of these hostages from a tunnel in Rafah, Gaza
            /// Believed to be executed by Hamas, shot at close range 1-2 days prior to discovery.
            /// </summary>
            [Number(6)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaRafah)]
            [Hostages(
                HostageList.GoldbergPolinHersh,
                HostageList.YerushalmiEden,
                HostageList.DaninoOri,
                HostageList.LobanovAlexander,
                HostageList.GatCarmel,
                HostageList.SarusiAlmog)]
            public static class August31 { }

            /// <summary>
            /// Remains taken hostage on October 7, was recovered by the IDF
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.SvirskyItai)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza)]
            public static class December4 { }
        }
        [Total(99)]
        public static class v2025
        {
            [Number(1)]
            [Hostages(HostageList.AlZayadniYosef)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaRafah)]
            public static class January8 { }

            [Number(1)]
            [Hostages(HostageList.AlZayadniHamzah)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaRafah)]
            public static class January10 { }

            [IsraeliHamasHostageAgreement(IsraeliHamasHostageAgreement.January2025HostageReturnAgreement)]
            public static class January2025HostageReturnAgreementA
            {
                [Number(3)]
                [Hostages(HostageList.DamariEmily, HostageList.GonenRomi, HostageList.SteinbrecherDoron)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
                public static class January19ReleasedAlive { }
            }

            [Number(1)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza)]
            [Hostages(HostageList.ShaulOron)]
            public static class January19RecoveredBody { }

            [IsraeliHamasHostageAgreement(IsraeliHamasHostageAgreement.January2025HostageReturnAgreement)]
            public static class January2025HostageReturnAgreementB
            {
                [Number(4)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
                [Hostages(HostageList.AlbagLiri,
                    HostageList.ArievKarina,
                    HostageList.GilboaDaniella,
                    HostageList.LevyNaama)]
                public static class January25 { }

                [Number(3)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.YehoudArbel,
                    HostageList.BergerAgam,
                    HostageList.MozesGadiMoshe)]
                public static class January30A { }
            }

            /// <summary>
            /// not part of 2025-01-15 return agreement (home country negotiated their release separately)
            /// </summary>
            [Number(5)]
            [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
            [Hostages(HostageList.RumnaoSurasak,
                HostageList.SaethaoBannawat,
                HostageList.SriaounWatchara,
                HostageList.ThaennaPongsak,
                HostageList.SuwannakhamSathian)]
            public static class January30B { }

            [IsraeliHamasHostageAgreement(IsraeliHamasHostageAgreement.January2025HostageReturnAgreement)]
            public static class January2025HostageReturnAgreementC
            {
                [Hostages(HostageList.KalderonOfer, HostageList.BibasYarden, HostageList.SiegelSamuelKeith)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
                [Number(3)]
                public static class February1 { }

                [Hostages(HostageList.BenAmiOhad, HostageList.SharabiEli, HostageList.LevyOr)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza, WorldCities.GazaDeirAlBalah)]
                [Number(3)]
                public static class February8 { }

                [Hostages(HostageList.DekelChenSagui,
                    HostageList.TrufanovAlexanderSasha,
                    HostageList.HornIair)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
                [Number(3)]
                public static class February15 { }

                [Number(3)]
                [Hostages(HostageList.LifshitzOded, HostageList.BibasAriel, HostageList.BibasKfir)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
                public static class February20 { }

                [Hostages(HostageList.BibasShiri)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Number(1)]
                public static class February21 { }

                [Number(6)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
                [Hostages(
                    HostageList.WenkertOmer,
                    HostageList.ShemTovOmer,
                    HostageList.CohenEliya,
                    HostageList.ShohamTal,
                    HostageList.MengistuAvera,
                    HostageList.AlSayedHishamShaaban)]
                public static class February22 { }

                [Number(4)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(
                    HostageList.MansourShlomo,
                    HostageList.YahalomiOhad,
                    HostageList.IdanTsachi,
                    HostageList.ElgaratItzhk)]
                public static class February26 { }
            }

            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
            [Hostages(HostageList.AlexanderEdan)]
            public static class May12 { }

            [Number(2)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
            [Hostages(HostageList.HaggaiGad,
                      HostageList.WeinsteinHaggaiJudith)]
            public static class June5 { }

            [Number(1)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaRafah)]
            [Hostages(HostageList.PintaNattapong)]
            public static class June7 { }

            [Number(2)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
            [Hostages(HostageList.AtziliAviv,
                      HostageList.YaakovYair)]
            public static class June11 { }

            [Number(3)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza)]
            [Hostages(HostageList.KeidarOfra,
                      HostageList.LevinsonShay,
                      HostageList.SameranoYonatan)]
            public static class June22 { }

            [Number(2)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza)]
            [Hostages(HostageList.ShtiviIdan,
                      HostageList.WeissIlan)]
            public static class August29 { }

            [IsraeliHamasHostageAgreement(IsraeliHamasHostageAgreement.October2025HostageReturnAgreement)]
            public static class October2025HostageReturnAgreementA
            {
                [Number(20)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
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
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.JoshiBipin,
                          HostageList.IluzGuy,
                          HostageList.PerezDaniel,
                          HostageList.SharabiYossi)]
                public static class October13ReleasedBody { }

                /// <summary>
                /// a fourth body was also released, but was an unidentified Palestinian
                /// </summary>
                [Number(3)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.BaruchUriael,
                          HostageList.LevyEitan,
                          HostageList.NimrodTamir)]
                public static class October14 { }

                [Number(2)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.AlAtreshMuhammad,
                          HostageList.HaymanInbar)]
                public static class October15 { }

                [Number(1)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.MargalitEliyahu)]
                public static class October17 { }

                [Number(2)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.EngelRonan,
                          HostageList.OakkharasriSonthaya)]
                public static class October18 { }

                [Number(1)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.HaimiTal)]
                public static class October20 { }

                [Number(2)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.AdarTamir,
                          HostageList.ZalmanovitchArye)]
                public static class October21 { }

                [Number(2)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.BaruchSahar,
                          HostageList.CooperAmiram)]
                public static class October30 { }

                [Number(3)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.OzDaniel,
                          HostageList.HamamiAsaf,
                          HostageList.NeutraOmerMaxim)]
                public static class November2 { }

                [Number(1)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.ChenItay)]
                public static class November4 { }

                [Number(1)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.MollelJoshua)]
                public static class November5 { }

                [Number(1)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.RudaeffLior)]
                public static class November7 { }

                [Number(1)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.GoldinHadar)]
                public static class November9 { }

                [Number(1)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.GodardManny)]
                public static class November13 { }

                [Number(1)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.OrDror)]
                public static class November26 { }

                [Number(1)]
                [HostageOutcome(HostageOutcome.ReleasedBody, CountryLikeThings.PalestineGaza)]
                [Hostages(HostageList.RinthalakSudthisak)]
                public static class December3 { }
            }
        }

        [Total(1)]
        public static class v2026
        {
            [Number(1)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
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

internal class IsraeliKibbutzAttribute : Attribute
{
    public IsraeliKibbutz Kibbutz { get; set; }
    public IsraeliKibbutzAttribute(IsraeliKibbutz kibbutz)
    {
        Kibbutz = kibbutz;
    }
}

internal class KidnappedFromAttribute : Attribute
{
    public KidnappedFrom KidnappedFrom { get; set; }
    public KidnappedFromAttribute(KidnappedFrom kidnappedFrom)
    {
        KidnappedFrom = kidnappedFrom;
    }
}

internal enum KidnappedFrom
{
    Kibbutz,
    MusicFestival,
    MilitaryOutpost,
    ArmoredVehicle,
}

internal enum IsraeliMusicFestivals
{
    /// <summary>
    /// roughly 364 people killed, several hostages taken
    /// </summary>
    Nova,
    /// <summary>
    /// 17 people killed, no hostages taken
    /// </summary>
    Psyduck,
}

internal enum IsraeliKibbutz
{
    Beeri,
    KfarAza,
    Kissufim,
    NahalOz,
    NirOz,
    NirYitzhak,
    Nirim,
}

internal enum IsraeliAssassinationTarget
{
    /// <summary>
    /// Iranian nuclear scientist
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    AbbasiFereydoon,

    /// <summary>
    /// Commander of Hezbollah's Nasr unit
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2024, 6, 11)]
    AbdullahTaleb,

    /// <summary>
    /// IRGC commander
    /// </summary>
    [Assassinated(CountryLikeThings.Syria)]
    [DeathDate(2024, 6, 3)]
    AbiyarSaeed,

    /// <summary>
    /// Al-Quds Brigades (Palestinian Islamic Jihad) spokesperson
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2025, 3, 18)]
    AbuHamza,

    /// <summary>
    /// Head of Hamas's aerial array
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10, 14)]
    AbuMuradMurad,

    /// <summary>
    /// Qassam Brigades (Hamas) spokesperson
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2025, 8, 30)]
    AbuObeida,

    /// <summary>
    /// Secretary-General of the Mujahideen Brigades
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2025, 6, 7)]
    AbuShariaAsad,

    /// <summary>
    /// Head of Hamas's administrative and combat support staff
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2024, 3, 10)]
    AbuTamaaGhazi,

    /// <summary>
    /// Head of Hezbollah's media relations
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 11, 17)]
    AfifMohammad,

    /// <summary>
    /// Head of Basij intelligence
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 3, 17)]
    AhmadiEsmail,

    /// <summary>
    /// Deputy chairman of the Hamas Political Bureau
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 1, 2)]
    AlArouriSaleh,

    /// <summary>
    /// Hamas Political Bureau member
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2025, 3, 23)]
    AlBardawilSalah,

    /// <summary>
    /// Head of Hamas's Government Administrative Committee in Gaza
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2025, 3, 18)]
    AlDaalisIssam,

    /// <summary>
    /// Houthi chief of staff
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Yemen, WorldCities.YemenSanaa)]
    [DeathDate(2025, 8, 28)]
    AlGhamariMuhammadAbdAlKarim,

    /// <summary>
    /// Hamas leader in Gaza and Qassam Brigades commander
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2026, 5, 15)]
    AlHaddadIzzAlDin,

    /// <summary>
    /// Hamas chief negotiator. Targeted 2025-09-09 in Doha; survived.
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    AlHayyaKhalil,

    /// <summary>
    /// Head of Hamas's combat support and administrative headquarters
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2025, 6, 27)]
    AlIssaHakhamMuhammadIssa,

    /// <summary>
    /// Hamas commander of the Kfar Aza massacre
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10, 15)]
    AlKedraBillal,

    /// <summary>
    /// Senior Hezbollah commander
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBaalbek)]
    [DeathDate(2026, 2, 20)]
    AlMoussawiAliZeid,

    /// <summary>
    /// Senior Hezbollah commander
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBaalbek)]
    [DeathDate(2026, 2, 20)]
    AlMoussawiMuhammadIbrahim,

    /// <summary>
    /// Senior Palestinian Islamic Jihad commander
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2026, 3, 3)]
    AlOthmanAdhamAdnan,

    /// <summary>
    /// Hamas Nukhba company commander on 2023-10-07
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10, 14)]
    AlQadiAli,

    /// <summary>
    /// Houthi prime minister
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Yemen, WorldCities.YemenSanaa)]
    [DeathDate(2025, 8, 28)]
    AlRahawiAhmed,

    /// <summary>
    /// Senior Hezbollah Radwan Force commander
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2024, 1, 8)]
    AlTawilWissam,

    /// <summary>
    /// Head of Hezbollah's Radwan Force
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 20)]
    AqilIbrahim,

    /// <summary>
    /// Iranian intelligence head
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    AsadiSaleh,

    /// <summary>
    /// Hezbollah Nasr unit rocket and missile commander
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2024, 6, 17)]
    AyoubMuhammadMustafa,

    /// <summary>
    /// Senior member of Hezbollah's Unit 151. Killed in Al-Qusayr, Syria.
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Syria)]
    [DeathDate(2024, 11, 9)]
    AyyashSalim,

    /// <summary>
    /// Chief of Staff of Iran's Armed Forces
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    BagheriMohammad,

    /// <summary>
    /// Commander of Hezbollah's aerial forces
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2024, 1, 9)]
    BarjiAliHussein,

    /// <summary>
    /// Hamas commander of Central Jabaliya
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaJabalia)]
    [DeathDate(2023, 10, 31)]
    BiariIbrahim,

    /// <summary>
    /// Senior Hezbollah commander. Targeted 2024-11-09 in Syria; killed in southern Lebanon.
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2026, 6, 12)]
    DaqduqAliMusa,

    /// <summary>
    /// Head of Hamas's Shura Council. Reported target 2025-09-09 in Doha; survived.
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    DarwishMuhammadIsmail,

    /// <summary>
    /// Commander of the Qassam Brigades (Hamas)
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
    [DeathDate(2024, 7, 13)]
    DeifMohammed,

    /// <summary>
    /// Commander of Hamas's Northern Gaza Brigade
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2023, 11, 10)]
    GhandourAhmed,

    /// <summary>
    /// Commander of the IRGC Aerospace Force
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    HajizadehAmirAli,

    /// <summary>
    /// Hamas commander
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2023, 11, 10)]
    HalifaFarsan,

    /// <summary>
    /// Chairman of the Hamas Political Bureau
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2024, 7, 31)]
    HaniyehIsmail,

    /// <summary>
    /// Commander of Hezbollah's intelligence headquarters
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 10, 3)]
    HazimaAliHussein,

    /// <summary>
    /// Deputy commander of the Qassam Brigades (Hamas)
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2024, 3, 10)]
    IssaMarwan,

    /// <summary>
    /// Head of the Quds Force's Palestine branch
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranQom)]
    [DeathDate(2025, 6, 21)]
    IzadiSaeed,

    /// <summary>
    /// Chairman of SPND (defensive innovation and research)
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    JabalAmelianHossein,

    /// <summary>
    /// Hamas leader. Reported target 2025-09-09 in Doha; survived.
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    JabarinZaher,

    /// <summary>
    /// Commander of Hezbollah's Southern Front
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 27)]
    KarakiAli,

    /// <summary>
    /// Head of the IRGC Intelligence Organization
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 15)]
    KazemiMohammad,

    /// <summary>
    /// Head of IRGC intelligence
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 4, 6)]
    KhademiMajid,

    /// <summary>
    /// Supreme Leader of Iran
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    KhameneiAli,

    /// <summary>
    /// Head of Iran's Strategic Council on Foreign Relations
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 4, 1)]
    KharaziKamal,

    /// <summary>
    /// Iranian Minister of Intelligence
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 3, 18)]
    KhatibEsmaeil,

    /// <summary>
    /// Secretary of Iran's Supreme National Security Council
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 3, 17)]
    LarijaniAli,

    /// <summary>
    /// Former Hamas Political Bureau chairman. Reported target 2025-09-09 in Doha; survived.
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    MashalKhaled,

    /// <summary>
    /// Deputy head of intelligence, Armed Forces General Staff
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    MehrabiGholamreza,

    /// <summary>
    /// Commander of the Quds Force's Unit 840
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 4, 6)]
    MirYazdan,

    /// <summary>
    /// Deputy head of the IRGC Intelligence Organization
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 15)]
    MohagheghHassan,

    /// <summary>
    /// Chief of Staff of Iran's Armed Forces (succeeded Bagheri)
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    MousaviAbdolrahim,

    /// <summary>
    /// IRGC Quds Force commander
    /// </summary>
    [Assassinated(CountryLikeThings.Syria, WorldCities.SyriaDamascus)]
    [DeathDate(2023, 12, 25)]
    MousaviRazi,

    /// <summary>
    /// Former chairman of SPND
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    MozaffariNiaReza,

    /// <summary>
    /// IRGC spokesperson
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 3, 20)]
    NainiAliMohammad,

    /// <summary>
    /// Iranian Minister of Defense
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    NasirzadehAziz,

    /// <summary>
    /// Secretary-General of Hezbollah
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 27)]
    NasrallahHassan,

    /// <summary>
    /// Commander of Hezbollah's Aziz unit
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2024, 7, 3)]
    NasserMohammedNehme,

    /// <summary>
    /// Quds Force commander in Lebanon
    /// </summary>
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 27)]
    NilforoushanAbbas,

    /// <summary>
    /// Commander of Hamas's Central Gaza Brigade
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10, 17)]
    NofalAyman,

    /// <summary>
    /// Hamas leader in Gaza and Qassam Brigades commander
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2026, 5, 26)]
    OdehMohammed,

    /// <summary>
    /// Head of Quds Force intelligence in Syria
    /// </summary>
    [Assassinated(CountryLikeThings.Syria, WorldCities.SyriaDamascus)]
    [DeathDate(2024, 1, 20)]
    OmidzadehSadegh,

    /// <summary>
    /// Commander-in-Chief of the IRGC
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    PakpourMohammad,

    /// <summary>
    /// Deputy head of Hezbollah's Executive Council
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 28)]
    QaoukNabil,

    /// <summary>
    /// Commander of Hamas's South Khan Younis Battalion
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
    [DeathDate(2025, 5, 13)]
    QuaraMahdi,

    /// <summary>
    /// Commander of Hezbollah's missile and rocket unit
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 24)]
    QubaisiIbrahim,

    /// <summary>
    /// Deputy head of operations, Armed Forces General Staff
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    RabbaniMehdi,

    /// <summary>
    /// Deputy commander of Hamas's Northern Gaza Brigade
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2023, 11, 10)]
    RajebWael,

    /// <summary>
    /// Commander of Khatam al-Anbiya Central Headquarters
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    RashidGholamAli,

    /// <summary>
    /// Head of IRGC Navy intelligence
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranBandarAbbas)]
    [DeathDate(2026, 3, 26)]
    RezaeiBehnam,

    /// <summary>
    /// Head of the Qassam Brigades' production headquarters (Hamas)
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2025, 12, 13)]
    SaadRaad,

    /// <summary>
    /// Head of Hezbollah's Executive Council
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 10, 3)]
    SafieddineHashem,

    /// <summary>
    /// Commander of Hamas's Khan Yunis Brigade
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
    [DeathDate(2024, 7, 13)]
    SalamaRafa,

    /// <summary>
    /// Commander-in-Chief of the IRGC
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    SalamiHossein,

    /// <summary>
    /// Hamas commander
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2023, 11, 10)]
    SalmanRafet,

    /// <summary>
    /// Commander of Hamas's Rafah Brigade
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
    [DeathDate(2025, 5, 13)]
    ShabanaMuhammad,

    /// <summary>
    /// Commander of Khatam al-Anbiya Central Headquarters
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 17)]
    ShadmaniAli,

    /// <summary>
    /// Hamas head of operations in Lebanon
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonSidon)]
    [DeathDate(2025, 2, 18)]
    ShaheenMuhammad,

    /// <summary>
    /// Senior IRGC official (Unit 190)
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranQom)]
    [DeathDate(2025, 6, 21)]
    ShahriyariBehnam,

    /// <summary>
    /// Adviser to Khamenei and Secretary of the Defense Council. Targeted 2025-06-13 and survived; killed in Tehran.
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    ShamkhaniAli,

    /// <summary>
    /// Hamas commander in Lebanon
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 29)]
    SharifFatah,

    /// <summary>
    /// Chief of Khamenei's military bureau
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    ShiraziMohammad,

    /// <summary>
    /// Head of Hezbollah's Strategic Unit
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 7, 30)]
    ShukrFuad,

    /// <summary>
    /// Head of Hamas's rocket array
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2023, 11, 10)]
    SiamAyman,

    /// <summary>
    /// Hamas leader in Gaza and Qassam Brigades commander
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
    [DeathDate(2025, 5, 13)]
    SinwarMohammed,

    /// <summary>
    /// Hamas leader and Israel's most-wanted target. Killed 2024-10-16, Rafah, in a chance encounter with IDF troops rather than a planned strike.
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    SinwarYahya,

    /// <summary>
    /// Commander of the Basij
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 3, 17)]
    SoleimaniGholamreza,

    /// <summary>
    /// Hamas financier.
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2024, 4, 9)]
    SrourMohammad,

    /// <summary>
    /// Commander of Hezbollah's drone unit
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 26)]
    SrourMuhammadHussein,

    /// <summary>
    /// Senior Hezbollah commander and chief of staff to Naim Qassem
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2025, 11, 23)]
    TabatabaiHaythamAli,

    /// <summary>
    /// Commander of the IRGC Navy
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranBandarAbbas)]
    [DeathDate(2026, 3, 26)]
    TangsiriAlireza,

    /// <summary>
    /// Iranian nuclear scientist
    /// </summary>
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    TehranchiMohammadMehdi,

    /// <summary>
    /// Head of Hezbollah Radwan Force training
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 20)]
    WahbiAhmed,

    /// <summary>
    /// Senior Hezbollah commander
    /// </summary>
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBaalbek)]
    [DeathDate(2026, 2, 20)]
    YaghiHussein,

    /// <summary>
    /// Quds Force commander in Lebanon and Syria
    /// </summary>
    [Assassinated(CountryLikeThings.Syria, WorldCities.SyriaDamascus)]
    [DeathDate(2024, 4, 1)]
    ZahediMohammadReza,
}