
using Existence.Earth.Alphabet;
using Existence.Earth.Countries;
using Existence.Earth.Countries.Israel.Politics;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Gambling;
using Existence.Earth.Human.EthnicGroups;
using Existence.Earth.Human.People;
using Existence.Earth.Time;
using Existence.Earth.War;
using Existence.Song;
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
        public PostOctober7HostageAgreement Agreement { get; set; }
        public IsraeliHamasHostageAgreementAttribute(PostOctober7HostageAgreement Agreement)
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
    public enum PostOctober7HostageAgreement
    {
        /// <summary>
        /// Qatar/Egypt/United States mediated truce agreed November 22, 2023, in effect November 24 - December 1, 2023 (extended twice);
        /// hostages exchanged for Palestinian prisoners
        /// </summary>
        [Total(81)]
        [Countries(CountryLikeThings.Israel, CountryLikeThings.PalestineGaza, CountryLikeThings.Qatar, CountryLikeThings.Egypt, CountryLikeThings.UnitedStates)]
        November2023HostageReleaseAgreementIsrael,

        /// <summary>
        /// Informal efforts by Thailand to release farm worker hostages separate from Israeli-Hamas negotiations. One Filipino hostage
        /// possibly included in the agreement but not publicly known (not treated as part of the agreement here)
        /// </summary>
        [Total(23)]
        [Countries(CountryLikeThings.Thailand, CountryLikeThings.PalestineGaza)]
        November2023HostageReleaseAgreementThailand,

        /// <summary>
        /// Qatar/Egypt/United States mediated ceasefire agreed January 15, 2025, in effect January 19, 2025; only phase 1
        /// (through March 1, 2025) was carried out before fighting resumed March 18, 2025
        /// </summary>
        [Total(33)]
        [Countries(CountryLikeThings.Israel, CountryLikeThings.PalestineGaza, CountryLikeThings.Qatar, CountryLikeThings.Egypt, CountryLikeThings.UnitedStates)]
        January2025HostageReturnAgreement,

        /// <summary>
        /// first phase of the United States 20-point Gaza peace plan, agreed October 9, 2025, in effect October 10, 2025;
        /// all living hostages released October 13, 2025, with the remains of deceased hostages returned afterward
        /// </summary>
        [Total(47)]
        [Countries(CountryLikeThings.Israel, CountryLikeThings.PalestineGaza, CountryLikeThings.UnitedStates)]
        October2025HostageReturnAgreement,
    }

    /// <summary>
    /// category of a military rank
    /// </summary>
    public enum MilitaryRankCategory
    {
        /// <summary>
        /// enlisted personnel below the non-commissioned officer ranks
        /// </summary>
        Enlisted,

        /// <summary>
        /// non-commissioned officer
        /// </summary>
        NonCommissionedOfficer,

        /// <summary>
        /// commissioned officer
        /// </summary>
        Officer,
    }

    /// <summary>
    /// category of a military rank (enlisted, non-commissioned officer, officer)
    /// </summary>
    public class MilitaryRankCategoryAttribute : Attribute
    {
        public MilitaryRankCategory Category { get; set; }
        public MilitaryRankCategoryAttribute(MilitaryRankCategory Category)
        {
            this.Category = Category;
        }
    }

    /// <summary>
    /// primary ranks of the Israel Defence Forces, lowest to highest; the ranks are shared by the army, navy and air force
    /// (only the insignia differ). Specialist ranks (e.g. academic officer) are not included.
    /// </summary>
    /// <remarks>English names for the senior non-commissioned officer ranks vary between sources, the Hebrew names are noted on each value</remarks>
    public enum IsraelDefenceForcesRank
    {
        /// <summary>
        /// Turai
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Enlisted)]
        [Texts("Turai", "טוראי")]
        Private,

        /// <summary>
        /// Rav Turai
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Enlisted)]
        [Texts("Rav Turai", "רב טוראי")]
        Corporal,

        /// <summary>
        /// Samal
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Enlisted)]
        [Texts("Samal", "סמל")]
        Sergeant,

        /// <summary>
        /// Samal Rishon
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Enlisted)]
        [Texts("Samal Rishon", "סמל ראשון")]
        StaffSergeant,

        /// <summary>
        /// Rav Samal
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.NonCommissionedOfficer)]
        [Texts("Rav Samal", "רב סמל")]
        SergeantFirstClass,

        /// <summary>
        /// Rav Samal Rishon
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.NonCommissionedOfficer)]
        [Texts("Rav Samal Rishon", "רב סמל ראשון")]
        MasterSergeant,

        /// <summary>
        /// Rav Samal Mitkadem
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.NonCommissionedOfficer)]
        [Texts("Rav Samal Mitkadem", "רב סמל מתקדם")]
        SergeantMajor,

        /// <summary>
        /// Rav Samal Bakhir
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.NonCommissionedOfficer)]
        [Texts("Rav Samal Bakhir", "רב סמל בכיר")]
        CommandSergeantMajor,

        /// <summary>
        /// Rav Nagad
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.NonCommissionedOfficer)]
        [Texts("Rav Nagad", "רב נגד")]
        ChiefWarrantOfficer,

        /// <summary>
        /// Segen Mishne
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Officer)]
        [Texts("Segen Mishne", "סגן משנה")]
        SecondLieutenant,

        /// <summary>
        /// Segen
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Officer)]
        [Texts("Segen", "סגן")]
        Lieutenant,

        /// <summary>
        /// Seren
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Officer)]
        [Texts("Seren", "סרן")]
        Captain,

        /// <summary>
        /// Rav Seren
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Officer)]
        [Texts("Rav Seren", "רב סרן")]
        Major,

        /// <summary>
        /// Sgan Aluf
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Officer)]
        [Texts("Sgan Aluf", "סגן אלוף")]
        LieutenantColonel,

        /// <summary>
        /// Aluf Mishne
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Officer)]
        [Texts("Aluf Mishne", "אלוף משנה")]
        Colonel,

        /// <summary>
        /// Tat Aluf
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Officer)]
        [Texts("Tat Aluf", "תת אלוף")]
        BrigadierGeneral,

        /// <summary>
        /// Aluf
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Officer)]
        [Texts("Aluf", "אלוף")]
        MajorGeneral,

        /// <summary>
        /// Rav Aluf, held only by the Chief of the General Staff
        /// </summary>
        [MilitaryRankCategory(MilitaryRankCategory.Officer)]
        [Texts("Rav Aluf", "רב אלוף")]
        LieutenantGeneral,
    }

    /// <summary>
    /// Example source: https://www.israelhayom.com/2023/10/31/these-are-the-captives-held-by-hamas/
    /// The list has more than 256 values, so it does not fit in a byte and requires a short.
    /// </summary>
    [Total(257)]
    public enum HostageList : short
    {
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(38, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        AdarTamir = 0,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(85, TimePeriods.Years)]
        AdarYafa = 1,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.StaffSergeant)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(20, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        AhimasTomerYaakov = 2,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups((int)WorldEthnicGroups.Arab, (int)WorldEthnicGroups.Bedouin)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.SergeantMajor)]
        [Gender(Gender.Male)]
        [Age(39, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        AlAtreshMuhammad = 3,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(44, TimePeriods.Years)]
        AloniDaniel = 4,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(5, TimePeriods.Years)]
        AloniEmelia = 5,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups((int)WorldEthnicGroups.Arab, (int)WorldEthnicGroups.Bedouin)]
        [PreviouslyHeldAsHostage]
        [Gender(Gender.Male)]
        [Age(27, TimePeriods.Years)]
        [StartYear(2015)]
        AlSayedHishamShaaban = 6,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups((int)WorldEthnicGroups.Arab, (int)WorldEthnicGroups.Bedouin)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(22, TimePeriods.Years)]
        [DeathDateUnknown]
        AlZayadniHamzah = 7,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups((int)WorldEthnicGroups.Arab, (int)WorldEthnicGroups.Bedouin)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [ApproximateAgeInYears(52, 53)]
        [DeathDateUnknown]
        AlZayadniYosef = 8,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier()]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [Gender(Gender.Female)]
        [Age(18, TimePeriods.Years)]
        AlbagLiri = 9,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.StaffSergeant)]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [Gender(Gender.Male)]
        [Age(19, TimePeriods.Years)]
        AlexanderEdan = 10,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups((int)WorldEthnicGroups.Arab, (int)WorldEthnicGroups.Bedouin)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.GuardSecurity)]
        [Age(51, TimePeriods.Years)]
        AlkadiQaidFarhan = 11,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(28, TimePeriods.Years)]
        AngkaewAnucha = 12,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Bulgaria)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.StaffSergeant)]
        [KidnappedFrom(KidnappedFrom.ArmoredVehicle)]
        [Gender(Gender.Male)]
        [Age(20, TimePeriods.Years)]
        AngrestMatan = 13,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroup(WorldEthnicGroups.Han)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Female)]
        [StudentUniversity]
        [Age(25, TimePeriods.Years)]
        ArgamaniNoa = 14,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier()]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [Gender(Gender.Female)]
        [Age(19, TimePeriods.Years)]
        ArievKarina = 15,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(2, TimePeriods.Years)]
        AsherAviv = 16,

        /// <summary>
        /// daughter of <see cref="KatzEfrat"/>, mother of <see cref="AsherRaz"/> and <see cref="AsherAviv"/>, and half-sister of
        /// <see cref="KatzRavid"/>
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(34, TimePeriods.Years)]
        AsherDoronKatz = 17,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(4, TimePeriods.Years)]
        AsherRaz = 18,

        /// <summary>
        /// related to <see cref="BeininLiat"/>
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(49, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        AtziliAviv = 19,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(12, TimePeriods.Years)]
        AvigdoriNoam = 20,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(52, TimePeriods.Years)]
        AvigdoriSharon = 21,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NahalOz)]
        [Gender(Gender.Female)]
        [Age(84, TimePeriods.Years)]
        AvrihamElma = 22,

        [Countries(CountryLikeThings.Philippines, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(60, TimePeriods.Years)]
        BabadillaNoralin = 23,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Bulgaria)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Male)]
        [Age(24, TimePeriods.Years)]
        [DeathDate(2023, 12, 8)]
        BaruchSahar = 24,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(34, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        BaruchUriael = 25,

        /// <summary>
        /// related to <see cref="AtziliAviv"/>
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(49, TimePeriods.Years)]
        BeininLiat = 26,

        /// <summary>
        /// killed in IDF airstrike
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Corporal)]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [Gender(Gender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 11, 10)]
        BeizerNik = 27,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.Accountant)]
        [Age(54, TimePeriods.Years)]
        BenAmiOhad = 28,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Female)]
        [Age(56, TimePeriods.Years)]
        BenAmiRaz = 29,

        [Country(CountryLikeThings.Israel)]
        [Gender(Gender.Male)]
        [Age(53, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        BenjaminRon = 30,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier()]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [Gender(Gender.Female)]
        [Age(19, TimePeriods.Years)]
        BergerAgam = 31,

        /// <summary>
        /// twin of <see cref="BermanZiv"/>
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Male)]
        [Age(26, TimePeriods.Years)]
        BermanGali = 32,

        /// <summary>
        /// twin of <see cref="BermanGali"/>
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Male)]
        [Age(26, TimePeriods.Years)]
        BermanZiv = 33,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(4, TimePeriods.Years)]
        [DeathDate(2023, 11)]
        BibasAriel = 34,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(8, TimePeriods.Months)]
        [DeathDate(2023, 11)]
        BibasKfir = 35,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(32, TimePeriods.Years)]
        [DeathDate(2023, 11)]
        BibasShiri = 36,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(33, TimePeriods.Years)]
        BibasYarden = 37,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Colombia)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(34, TimePeriods.Years)]
        BohbotElkana = 38,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        BoonpromSanti = 39,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.GuardSecurity)]
        [Age(19, TimePeriods.Years)]
        BraslavskiRom = 40,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Sergeant)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        BrodskiKiril = 41,

        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Female)]
        [Age(40, TimePeriods.Years)]
        BrodutchHagar = 42,

        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Female)]
        [Age(9, TimePeriods.Years)]
        BrodutchOfri = 43,

        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Female)]
        [Age(4, TimePeriods.Years)]
        BrodutchOriya = 44,

        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Male)]
        [Age(9, TimePeriods.Years)]
        BrodutchYuval = 45,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Nirim)]
        [Gender(Gender.Female)]
        [Age(36, TimePeriods.Years)]
        BuchshtavRimonKirsht = 46,

        /// <summary>
        /// Buckshtav?
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Nirim)]
        [Gender(Gender.Male)]
        [Age(34, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        BuchshtabYagev = 47,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Female)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        BuskilaEstherAmit = 48,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany, CountryLikeThings.UnitedStates)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.StaffSergeant)]
        [Gender(Gender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        ChenItay = 49,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(29, TimePeriods.Years)]
        ChombuaKomkrit = 50,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(26, TimePeriods.Years)]
        CohenEliya = 51,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Sergeant)]
        [KidnappedFrom(KidnappedFrom.ArmoredVehicle)]
        [Gender(Gender.Male)]
        [Age(19, TimePeriods.Years)]
        CohenNimrod = 52,

        /// <summary>
        /// girlfriend of <see cref="TrufanovAlexanderSasha"/>
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(29, TimePeriods.Years)]
        CohenSapir = 53,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(84, TimePeriods.Years)]
        [DeathDateUnknown]
        CooperAmiram = 54,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(26, TimePeriods.Years)]
        CunioAriel = 55,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(33, TimePeriods.Years)]
        CunioDavid = 56,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(3, TimePeriods.Years)]
        CunioEmma = 57,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(34, TimePeriods.Years)]
        CunioSharonOlani = 58,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(3, TimePeriods.Years)]
        CunioYuli = 59,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.CommandSergeantMajor)]
        [Gender(Gender.Male)]
        [Age(36, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        DadoZiv = 60,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Sergeant)]
        [KidnappedFrom(KidnappedFrom.ArmoredVehicle)]
        [Gender(Gender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        DahanShaked = 61,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedKingdom)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Female)]
        [Age(27, TimePeriods.Years)]
        DamariEmily = 62,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(75, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        DancygAlexander = 63,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(24, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        DaninoOri = 64,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(22, TimePeriods.Years)]
        DavidEvyatar = 65,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(35, TimePeriods.Years)]
        DekelChenSagui = 66,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Female)]
        [Age(3, TimePeriods.Years)]
        EdanAbigail = 67,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(68, TimePeriods.Years)]
        [DeathDateUnknown]
        ElgaratItzhk = 68,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(15, TimePeriods.Years)]
        ElyakimDafna = 69,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(8, TimePeriods.Years)]
        ElyakimEla = 70,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(51, TimePeriods.Years)]
        EngelBartKarina = 71,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(18, TimePeriods.Years)]
        EngelMika = 72,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Netherlands)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(17, TimePeriods.Years)]
        EngelOfir = 73,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(54, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        EngelRonan = 74,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(11, TimePeriods.Years)]
        EngelYuval = 75,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(39, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        GatCarmel = 76,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(56, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GelerenterItzhak = 77,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Bulgaria)]
        [IsraelDefenceForcesSoldier()]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [Gender(Gender.Female)]
        [Age(19, TimePeriods.Years)]
        [AlsoKnownAs("Danielle")]
        GilboaDaniella = 78,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(22, TimePeriods.Years)]
        [FullName("Guy Gilboa-Dalal")]
        GilboaDalalGuy = 79,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Male)]
        [Age(73, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GodardManny = 80,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(23, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        GoldbergPolinHersh = 81,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Lieutenant)]
        [PreviouslyHeldAsHostage]
        [Gender(Gender.Male)]
        [Age(23, TimePeriods.Years)]
        [DeathDate(2014, 8, 1)]
        [Text(HostagesConstants.OPERATION_PROTECTIVE_EDGE)]
        [StartYear(2014)]
        GoldinHadar = 82,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirYitzhak)]
        [Gender(Gender.Male)]
        [Age(33, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GoldinOren = 83,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Female)]
        [Age(17, TimePeriods.Years)]
        GoldsteinAlmogAgam = 84,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Female)]
        [HumanOccupation(HumanOccupation.WorkerSocial)]
        [Age(48, TimePeriods.Years)]
        GoldsteinAlmogChen = 85,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Male)]
        [Age(11, TimePeriods.Years)]
        GoldsteinAlmogGal = 86,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Male)]
        [Age(9, TimePeriods.Years)]
        GoldsteinAlmogTal = 87,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Female)]
        [Age(23, TimePeriods.Years)]
        GonenRomi = 88,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(56, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        GorenMaya = 89,

        [Countries(CountryLikeThings.Uruguay, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(29, TimePeriods.Years)]
        GorenShani = 90,

        [Countries(CountryLikeThings.Mexico, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(30, TimePeriods.Years)]
        GritzewskyIlana = 91,

        /// <summary>
        /// last hostage accounted for
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(24, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        [AlsoKnownAs("Rani")]
        GviliRan = 92,

        /// <summary>
        /// former principal flautist in the IDF orchestra, and husband of <see cref="WeinsteinHaggaiJudith"/>
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [MusicalInstrumentGenre(MusicalInstruments.Flute, MusicGenres.Jazz)]
        [Gender(Gender.Male)]
        [Age(72, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        [AlsoKnownAs("Gadi")]
        HaggaiGad = 93,

        /// <summary>
        /// killed by friendly fire while surrendering
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Male)]
        [Age(28, TimePeriods.Years)]
        [DeathDate(2023, 12, 15)]
        HaimYotam = 94,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Romania)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirYitzhak)]
        [Gender(Gender.Male)]
        [Age(41, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        HaimiTal = 95,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Colonel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(40, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        HamamiAsaf = 96,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Ireland)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Female)]
        [Age(8, TimePeriods.Years)]
        HandEmily = 97,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Female)]
        [HumanOccupation(HumanOccupation.Agronomist)]
        [Age(67, TimePeriods.Years)]
        HaranShoshan = 98,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(70, TimePeriods.Years)]
        HarLuis = 99,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Female)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        HaymanInbar = 100,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Retired(HumanOccupation.WorkerSocial)]
        [Age(84, TimePeriods.Years)]
        HeimanDitza = 101,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia, CountryLikeThings.Ukraine)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(35, TimePeriods.Years)]
        HerkinMaxim = 102,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(37, TimePeriods.Years)]
        HornEitan = 103,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(45, TimePeriods.Years)]
        HornIair = 104,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NahalOz)]
        [Gender(Gender.Male)]
        [Age(49, TimePeriods.Years)]
        [DeathDate(2023, 12, 4)]
        IdanTsachi = 105,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(26, TimePeriods.Years)]
        [DeathDate(2023)]
        IluzGuy = 106,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(29, TimePeriods.Years)]
        JirachartManee = 107,

        [Country(CountryLikeThings.Nepal)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Student]
        [Age(22, TimePeriods.Years)]
        [DeathDate(2023)]
        JoshiBipin = 108,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(28, TimePeriods.Years)]
        KalapratVichai = 109,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(11, TimePeriods.Years)]
        KalderonErez = 110,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France, CountryLikeThings.Portugal)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(52, TimePeriods.Years)]
        KalderonOfer = 111,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(16, TimePeriods.Years)]
        KalderonSahar = 112,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(25, TimePeriods.Years)]
        KalfonSegev = 113,

        /// <summary>
        /// Partner of <see cref="MozesGadiMoshe"/>, mother of <see cref="AsherDoronKatz"/>, and grandmother of <see cref="AsherRaz"/>
        /// and <see cref="AsherAviv"/>. Kidnapped from her home with her daughter and granddaughters and filmed on the back of a truck,
        /// killed in crossfire before reaching Gaza. Buried in Kibbutz Revadim on 2023-10-25.
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(68, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        KatzEfrat = 256,

        /// <summary>
        /// Death (after release) was attributed to medical complications from time as a hostage
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(76, TimePeriods.Years)]
        [DeathDate(2024, 12, 24)]
        KatzirHannah = 114,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(47, TimePeriods.Years)]
        [DeathDate(2024, 1)]
        KatznirElad = 115,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.SergeantMajor, true)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(51, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        KatzRavid = 116,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Female)]
        [Age(70, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        KeidarOfra = 117,

        [Country(CountryLikeThings.Thailand)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        KesoognernSurin = 118,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        KongmaneeBancha = 119,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.GuardSecurity)]
        [Age(27, TimePeriods.Years)]
        KozlovAndrey = 120,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(25, TimePeriods.Years)]
        KriboyRoni = 121,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(21, TimePeriods.Years)]
        [AlsoKnownAs("Bar Kuperstein")]
        KupershteinBar = 122,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(59, TimePeriods.Years)]
        LeimbergGabriela = 123,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(17, TimePeriods.Years)]
        LeimbertMia = 124,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.StaffSergeant)]
        [Gender(Gender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        LevinsonShay = 125,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(53, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        LevyEitan = 126,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier()]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [Gender(Gender.Female)]
        [Age(19, TimePeriods.Years)]
        LevyNaama = 127,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(33, TimePeriods.Years)]
        LevyOr = 128,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Retired]
        [Age(83, TimePeriods.Years)]
        [DeathDate(2023)]
        LifshitzOded = 129,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Retired]
        [Age(85, TimePeriods.Years)]
        LifshitzYokheved = 130,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(32, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        LobanovAlexander = 131,

        [Countries(CountryLikeThings.Germany, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Female)]
        [Age(22, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        LoukShani = 132,

        /// <summary>
        /// Iraq-born
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Kissufim)]
        [Gender(Gender.Male)]
        [Age(85, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        MansourShlomo = 133,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Corporal)]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [Gender(Gender.Female)]
        [Age(18, TimePeriods.Years)]
        [DeathDate(2023)]
        MarcianoNoa = 134,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(75, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        MargalitEliyahu = 135,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(41, TimePeriods.Years)]
        MargalitNili = 136,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Private)]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [Gender(Gender.Female)]
        [Age(19, TimePeriods.Years)]
        MegidishOri = 137,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(21, TimePeriods.Years)]
        MeirJanAlmog = 138,

        [Countries(CountryLikeThings.Ethiopia, CountryLikeThings.Israel)]
        [PreviouslyHeldAsHostage]
        [Gender(Gender.Male)]
        [Age(28, TimePeriods.Years)]
        [StartYear(2014)]
        MengistuAvera = 139,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirYitzhak)]
        [Gender(Gender.Female)]
        [Age(62, TimePeriods.Years)]
        MermanClara = 140,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(60, TimePeriods.Years)]
        MermanFernandoSimon = 141,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(78, TimePeriods.Years)]
        MetzgerTamar = 142,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(80, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        MetzgerYoram = 143,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Hungary)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NahalOz)]
        [Gender(Gender.Male)]
        [Age(46, TimePeriods.Years)]
        MiranOmri = 144,

        [Country(CountryLikeThings.Tanzania)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(21, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        MollelJoshua = 145,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.GuardSecurity)]
        [Age(23, TimePeriods.Years)]
        MorEitanAbraham = 146,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(72, TimePeriods.Years)]
        MosheAdina = 147,

        /// <summary>
        /// ex-wife and close neighbour of <see cref="MozesGadiMoshe"/>
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [ApproximateAgeInYears(77, 78)]
        [FullName("Margalit Berta Mozes")]
        MosesMargalit = 148,

        /// <summary>
        /// partner of <see cref="KatzEfrat"/>, and ex-husband and close neighbour of <see cref="MosesMargalit"/>
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(79, TimePeriods.Years)]
        [AlsoKnownAs("Gadi Moses")]
        MozesGadiMoshe = 149,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(78, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        MunderAbraham = 150,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(54, TimePeriods.Years)]
        MunderKeren = 151,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(8, TimePeriods.Years)]
        MunderOhad = 152,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(78, TimePeriods.Years)]
        MunderRuth = 153,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(35, TimePeriods.Years)]
        MunkanNattawaree = 154,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Captain)]
        [KidnappedFrom(KidnappedFrom.ArmoredVehicle)]
        [Gender(Gender.Male)]
        [Age(21, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        NeutraOmerMaxim = 155,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.StaffSergeant)]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [Gender(Gender.Male)]
        [Age(18, TimePeriods.Years)]
        [DeathDate(2023, 10, 9)]
        NimrodTamir = 156,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Brazil)]
        [Gender(Gender.Male)]
        [Age(59, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        NisenbaumMichel = 157,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(30, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        OakkharasriSonthaya = 158,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(23, TimePeriods.Years)]
        [FullName("Yosef-Haim Ohana")]
        OhanaYosefHaim = 159,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Serbia, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(22, TimePeriods.Years)]
        OhelAlon = 160,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(26, TimePeriods.Years)]
        OnkaewNatthaporn = 161,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Female)]
        [Age(13, TimePeriods.Years)]
        OrAlma = 162,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(30, TimePeriods.Years)]
        OrAvinathan = 163,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Male)]
        [Age(48, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        OrDror = 164,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Male)]
        [Age(18, TimePeriods.Years)]
        OrLiam = 165,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Male)]
        [Age(17, TimePeriods.Years)]
        OrNoam = 166,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Sergeant)]
        [KidnappedFrom(KidnappedFrom.ArmoredVehicle)]
        [Gender(Gender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        OzDaniel = 167,

        [Country(CountryLikeThings.Philippines)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(33, TimePeriods.Years)]
        PachecoGelienorJimmy = 168,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(45, TimePeriods.Years)]
        PankhongBoonthom = 169,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.SouthAfrica)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Captain)]
        [Gender(Gender.Male)]
        [Age(22, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        PerezDaniel = 170,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Poland)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(79, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        PeriChaim = 171,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.SouthAfrica)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Nirim)]
        [Gender(Gender.Female)]
        [Age(79, TimePeriods.Years)]
        PeriChanna = 172,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        PhachuabboonMongkol = 173,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(33, TimePeriods.Years)]
        PhoomeVetoon = 174,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(30, TimePeriods.Years)]
        PinakalowPornsawan = 175,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [ApproximateAgeInYears(35, 36)]
        [DeathDate(2023, 12)]
        PintaNattapong = 176,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedKingdom)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Nirim)]
        [Gender(Gender.Male)]
        [Age(51, TimePeriods.Years)]
        [DeathDate(2024, 2, 14)]
        PopplewellNadav = 177,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(59, TimePeriods.Years)]
        RaananJudith = 178,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(17, TimePeriods.Years)]
        RaananNatalie = 179,

        [Countries(CountryLikeThings.Mexico, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(30, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        RadouxOriónHernández = 180,

        [Country(CountryLikeThings.Thailand)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(42, TimePeriods.Years)]
        RataninPaiboon = 181,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(18, TimePeriods.Years)]
        RegevItay = 182,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Female)]
        [Age(21, TimePeriods.Years)]
        RegevMaya = 183,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [ApproximateAgeInYears(42, 43)]
        [DeathDate(2023, 10, 7)]
        RinthalakSudthisak = 184,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(77, TimePeriods.Years)]
        RoitmanOfelia = 185,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(35, TimePeriods.Years)]
        RomanGatYarden = 186,

        [Country(CountryLikeThings.Thailand)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [ApproximateAgeInYears(30, 31)]
        RumnaoSurasak = 187,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Female)]
        [Age(54, TimePeriods.Years)]
        RotemRaaya = 188,

        [Countries(CountryLikeThings.Argentina, CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirYitzhak)]
        [Gender(Gender.Male)]
        [Age(61, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        RudaeffLior = 189,

        [Country(CountryLikeThings.Thailand)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(26, TimePeriods.Years)]
        SaelaoKong = 190,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SaengboonBuddhee = 191,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SaengnuanUthai = 192,

        [Country(CountryLikeThings.Thailand)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(27, TimePeriods.Years)]
        SaethaoBannawat = 193,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(74, TimePeriods.Years)]
        SagiAda = 194,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(21, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        SameranoYonatan = 195,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SangkaewChalermchai = 196,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(26, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        SarusiAlmog = 197,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Female)]
        [Age(21, TimePeriods.Years)]
        SchemMia = 198,

        /// <summary>
        /// killed by friendly fire while surrendering
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Male)]
        [Age(26, TimePeriods.Years)]
        [DeathDate(2023, 12, 15)]
        ShamrizAlon = 199,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Male)]
        [Age(15, TimePeriods.Years)]
        ShaniAmit = 200,

        /// <summary>
        /// Sibling of <see cref="SharabiYossi"/>
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Male)]
        [Age(51, TimePeriods.Years)]
        SharabiEli = 201,

        /// <summary>
        /// Sibling of <see cref="SharabiEli"/>
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Male)]
        [Age(53, TimePeriods.Years)]
        [DeathDate(2024, 1, 10)]
        SharabiYossi = 202,

        [Country(CountryLikeThings.Israel)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.StaffSergeant)]
        [PreviouslyHeldAsHostage]
        [Gender(Gender.Male)]
        [Age(20, TimePeriods.Years)]
        [DeathDate(2014, 7, 20)]
        [StartYear(2014)]
        [Text(HostagesConstants.OPERATION_PROTECTIVE_EDGE)]
        ShaulOron = 203,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(20, TimePeriods.Years)]
        ShemTovOmer = 204,

        /// <summary>
        /// killed in IDF airstrike
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Argentina)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Sergeant)]
        [KidnappedFrom(KidnappedFrom.MilitaryOutpost)]
        [Gender(Gender.Male)]
        [Age(19, TimePeriods.Years)]
        [DeathDate(2023, 11, 10)]
        ShermanRon = 205,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(38, TimePeriods.Years)]
        ShohamAdi = 206,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(8, TimePeriods.Years)]
        ShohamNave = 207,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Austria, CountryLikeThings.Italy)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(38, TimePeriods.Years)]
        ShohamTal = 208,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(3, TimePeriods.Years)]
        ShohamYahel = 209,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Female)]
        [Age(12, TimePeriods.Years)]
        ShoshaniHilaRotem = 210,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Portugal)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(28, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        ShtiviIdan = 211,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.SouthAfrica, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Female)]
        [Age(62, TimePeriods.Years)]
        SiegelAdrienneAviva = 212,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Male)]
        [Age(64, TimePeriods.Years)]
        SiegelSamuelKeith = 213,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Female)]
        [Age(40, TimePeriods.Years)]
        SoussanaAmit = 214,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(32, TimePeriods.Years)]
        SriaounWatchara = 215,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        SrikeinaJakkrapan = 216,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Romania)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.KfarAza)]
        [Gender(Gender.Female)]
        [HumanOccupation(HumanOccupation.NurseVeterinary)]
        [Age(30, TimePeriods.Years)]
        SteinbrecherDoron = 217,

        [Country(CountryLikeThings.Thailand)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(40, TimePeriods.Years)]
        SuriyasriOwas = 218,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(34, TimePeriods.Years)]
        SuwannakhamSathian = 219,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(38, TimePeriods.Years)]
        [DeathDate(2024, 1)]
        SvirskyItai = 220,

        /// <summary>
        /// killed by friendly fire while surrendering
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [EthnicGroups((int)WorldEthnicGroups.Arab, (int)WorldEthnicGroups.Bedouin)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(24, TimePeriods.Years)]
        [DeathDate(2023, 12, 15)]
        TalalkaSamer = 221,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(54, TimePeriods.Years)]
        TalMeirav = 222,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Female)]
        [Age(13, TimePeriods.Years)]
        TarshanskyGali = 223,

        /// <summary>
        /// mother of <see cref="TrufanovYelena"/> and <see cref="TrufanovAlexanderSasha"/>
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(73, TimePeriods.Years)]
        TatiIrena = 224,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(37, TimePeriods.Years)]
        TemthongVichian = 225,

        [Country(CountryLikeThings.Thailand)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(35, TimePeriods.Years)]
        ThaennaPongsak = 226,

        /// <summary>
        /// killed in IDF airstrike (civilian)
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023, 11, 10)]
        ToledanoElia = 227,

        [Country(CountryLikeThings.Thailand)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        ToonsriUthai = 228,

        [Country(CountryLikeThings.Thailand)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.WorkerAgricultural)]
        [Age(TimeStatic.UNKNOWN_TIME_PERIOD, TimePeriods.Years)]
        TornsokreePattanayut = 229,

        /// <summary>
        /// Trupanob is a transformation of the Hebrew.
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(50, TimePeriods.Years)]
        TrufanovYelena = 230,

        /// <summary>
        /// Trupanob is a transformation of the Hebrew.
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Russia)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [HumanOccupation(HumanOccupation.EngineerSoftware)]
        [Age(27, TimePeriods.Years)]
        TrufanovAlexanderSasha = 231,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023)]
        TzarfatiOfir = 232,

        /// <summary>
        /// wife of <see cref="HaggaiGad"/>
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(70, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        [FullName("Judith Weinstein-Haggai")]
        WeinsteinHaggaiJudith = 233,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Hungary)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Male)]
        [Age(55, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        WeissIlan = 234,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Hungary)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Female)]
        [Age(18, TimePeriods.Years)]
        WeissNoga = 235,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Female)]
        [Age(53, TimePeriods.Years)]
        WeissShiri = 236,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.Beeri)]
        [Gender(Gender.Female)]
        [Age(65, TimePeriods.Years)]
        [DeathDate(2023, 11)]
        WeissYehudit = 237,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(22, TimePeriods.Years)]
        WenkertOmer = 238,

        /// <summary>
        /// Jacob is alternate spelling of last name, related to <see cref="YaakovYagil"/> and <see cref="YaakovYair"/>
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(16, TimePeriods.Years)]
        YaakovOr = 239,

        /// <summary>
        /// Jacob is alternate spelling of last name, related to <see cref="YaakovOr"/> and <see cref="YaakovYair"/>
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(12, TimePeriods.Years)]
        YaakovYagil = 240,

        /// <summary>
        /// Jacob is alternate spelling of last name, related to <see cref="YaakovOr"/> and <see cref="YaakovYagil"/>
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(59, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        YaakovYair = 241,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(41, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        YablonkaHanan = 242,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(12, TimePeriods.Years)]
        YahalomiEitan = 243,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(49, TimePeriods.Years)]
        [DeathDate(2024, 1, 19)]
        YahalomiOhad = 244,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Female)]
        [Age(40, TimePeriods.Years)]
        YanaiMoranStela = 245,

        [Countries(CountryLikeThings.Israel, CountryLikeThings.Germany)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(28, TimePeriods.Years)]
        YehoudArbel = 246,

        /// <summary>
        /// killed during the October 7 attacks, but never taken into Gaza
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        [NotActuallyAHostage]
        [Gender(Gender.Male)]
        [Age(35, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        YehoudDolev = 247,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Female)]
        [Age(23, TimePeriods.Years)]
        [DeathDate(2024, 8)]
        [ExecutedByPalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
        YerushalmiEden = 248,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Female)]
        [Age(79, TimePeriods.Years)]
        YitzhakNuritCooper = 249,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(85, TimePeriods.Years)]
        [DeathDate(2023, 11)]
        ZalmanovitchArye = 250,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [IsraeliKibbutz(IsraeliKibbutz.NirOz)]
        [Gender(Gender.Male)]
        [Age(23, TimePeriods.Years)]
        ZangaukerMatan = 251,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Female)]
        [Age(27, TimePeriods.Years)]
        [DeathDate(2023, 10, 7)]
        ZechariahEden = 252,

        [Country(CountryLikeThings.Israel)]
        [KidnappedFrom(KidnappedFrom.MusicFestival)]
        [Gender(Gender.Male)]
        [Age(40, TimePeriods.Years)]
        ZivShlomi = 253,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups((int)WorldEthnicGroups.Arab, (int)WorldEthnicGroups.Bedouin)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Female)]
        [Age(17, TimePeriods.Years)]
        ZiyadneAisha = 254,

        [Country(CountryLikeThings.Israel)]
        [EthnicGroups((int)WorldEthnicGroups.Arab, (int)WorldEthnicGroups.Bedouin)]
        [KidnappedFrom(KidnappedFrom.Kibbutz)]
        [Gender(Gender.Male)]
        [Age(18, TimePeriods.Years)]
        ZiyadneBilal = 255,
    }

    /// <summary>
    /// people taken hostage by Palestinian militant groups before the 2023-10-07 attacks
    /// </summary>
    /// <remarks>
    /// not exhaustive: only includes people referenced elsewhere. Hostages taken earlier but still held on 2023-10-07
    /// (e.g. <see cref="HostageList.GoldinHadar"/>) are in <see cref="HostageList"/> instead
    /// </remarks>
    public enum PriorTo2023October7thHostageList
    {
        /// <summary>
        /// Captured on 2006-06-25 near the Kerem Shalom crossing by Palestinian militants who crossed into Israel through a tunnel
        /// from Gaza and attacked his tank crew. Held by Hamas at an undisclosed location in Gaza for over five years; Hamas refused
        /// Red Cross visits, and his only contact with the outside world was three letters, an audio tape and a video.
        /// Released alive on 2011-10-18 in exchange for 1,027 Palestinian prisoners, among them <see cref="IsraeliAssassinationTarget.SinwarYahya"/>.
        /// The raid was led in part by <see cref="IsraeliAssassinationTarget.GhandourAhmed"/>; early messages to his family went through
        /// <see cref="IsraeliHamasMostWantedTargets.HamadGhazi"/>. Promoted in captivity; his rank here is the rank at capture.
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.France)]
        [IsraelDefenceForcesSoldier(IsraelDefenceForcesRank.Corporal)]
        [KidnappedFrom(KidnappedFrom.ArmoredVehicle)]
        [Gender(Gender.Male)]
        [Age(19, TimePeriods.Years)]
        [StartDate(2006, 6, 25)]
        [EndDate(2011, 10, 18)]
        ShalitGilad,
    }

    /// <summary>
    /// see https://www.cnn.com/interactive/2023/12/world/hostage-israel-hamas-deal-dg/
    /// </summary>
    public class IsraelHamasHostages
    {
        [Total(122)]
        public static class v2023
        {
            [Hostages(
                HostageList.ShaulOron,
                HostageList.GoldinHadar,
                HostageList.MengistuAvera,
                HostageList.AlSayedHishamShaaban)]
            [Number(4)]
            public static class HeldPriorToOctober7 { }

            /// <summary>
            /// killed by Israeli fire while being taken to Gaza, most likely by Israeli Air Force helicopter fire according to an IDF
            /// investigation. Her captors left her body behind, later recovered.
            /// </summary>
            [Hostages(HostageList.KatzEfrat)]
            [Number(1)]
            [HostageOutcome(HostageOutcome.RecoveredBodyKilledByIsrael, CountryLikeThings.Israel)]
            public static class October7 { }

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

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.November2023HostageReleaseAgreementIsrael)]
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

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.November2023HostageReleaseAgreementThailand)]
            public static class November2023HostageReleaseAgreementThailandA
            {
                [Number(10)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
                [Hostages(
                    HostageList.MunkanNattawaree,
                    HostageList.BoonpromSanti,
                    HostageList.KalapratVichai,
                    HostageList.KongmaneeBancha,
                    HostageList.PankhongBoonthom,
                    HostageList.PhachuabboonMongkol,
                    HostageList.PhoomeVetoon,
                    HostageList.SaengboonBuddhee,
                    HostageList.SaengnuanUthai,
                    HostageList.ToonsriUthai)]
                public static class November24B { }
            }

            /// <summary>
            /// may or may not have been associated with the Thai informal agreement
            /// </summary>
            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
            [Hostages(HostageList.PachecoGelienorJimmy)]
            public static class November24C { }

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.November2023HostageReleaseAgreementIsrael)]
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

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.November2023HostageReleaseAgreementThailand)]
            public static class November2023HostageReleaseAgreementThailandB
            {
                [Number(4)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
                [Hostages(
                    HostageList.AngkaewAnucha,
                    HostageList.ChombuaKomkrit,
                    HostageList.JirachartManee,
                    HostageList.OnkaewNatthaporn)]
                public static class November25B { }
            }

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.November2023HostageReleaseAgreementIsrael)]
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

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.November2023HostageReleaseAgreementThailand)]
            public static class November2023HostageReleaseAgreementThailandC
            {
                [Number(3)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
                [Hostages(
                    HostageList.KesoognernSurin,
                    HostageList.PinakalowPornsawan,
                    HostageList.TemthongVichian)]
                public static class November26B { }
            }

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.November2023HostageReleaseAgreementIsrael)]
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

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.November2023HostageReleaseAgreementThailand)]
            public static class November2023HostageReleaseAgreementThailandD
            {
                [Number(2)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
                [Hostages(
                    HostageList.SuriyasriOwas,
                    HostageList.TornsokreePattanayut)]
                public static class November28B { }
            }

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.November2023HostageReleaseAgreementIsrael)]
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

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.November2023HostageReleaseAgreementThailand)]
            public static class November2023HostageReleaseAgreementThailandE
            {
                [Number(4)]
                [HostageOutcome(HostageOutcome.ReleasedAlive, CountryLikeThings.PalestineGaza)]
                [Hostages(
                    HostageList.RataninPaiboon,
                    HostageList.SaelaoKong,
                    HostageList.SangkaewChalermchai,
                    HostageList.SrikeinaJakkrapan)]
                public static class November29B { }
            }

            /// <summary>
            /// The IDF and Shin Bet announce they have recovered the body of deceased hostage in recent days
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.TzarfatiOfir)]
            [HostageOutcome(HostageOutcome.RecoveredBody, CountryLikeThings.PalestineGaza)]
            public static class November29 { }

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.November2023HostageReleaseAgreementIsrael)]
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
            /// An IDF airstrike targeting Hamas's northern Gaza brigade chief, <see cref="IsraeliAssassinationTarget.GhandourAhmed"/>, killed three hostages, but their
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

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.January2025HostageReturnAgreement)]
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

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.January2025HostageReturnAgreement)]
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

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.January2025HostageReturnAgreement)]
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

            [IsraeliHamasHostageAgreement(PostOctober7HostageAgreement.October2025HostageReturnAgreement)]
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
    /// <summary>
    /// rank, when it is one of the primary ranks
    /// </summary>
    public IsraelDefenceForcesRank? Rank { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the item is reserved.
    /// </summary>
    public bool IsReserve { get; set; }

    /// <summary>
    /// constructor for soldier with no rank
    /// </summary>
    public IsraelDefenceForcesSoldierAttribute()
    {
    }

    /// <summary>
    /// constructor for soldier with rank and optionally reserve status
    /// </summary>
    /// <param name="Rank">rank</param>
    /// <param name="IsReserve">reserve status</param>
    public IsraelDefenceForcesSoldierAttribute(IsraelDefenceForcesRank Rank, bool IsReserve = false)
    {
        this.Rank = Rank;
        this.IsReserve = IsReserve;
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
    MujahideenBrigades,
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

/// <summary>
/// kibbutzim attacked on 2023-10-07
/// </summary>
/// <remarks>casualty and hostage figures are from the Wikipedia article on each attack</remarks>
internal enum IsraeliKibbutz
{
    /// <summary>
    /// 101 civilians and 31 security personnel killed, 32 hostages taken
    /// </summary>
    [Text("Be'eri")]
    Beeri,

    /// <summary>
    /// attack directed by <see cref="IsraeliAssassinationTarget.AbuAjinaNasim"/>, according to the IDF; an IDF investigation said the
    /// army failed in its mission to protect the kibbutz. Casualty and hostage figures not confirmed
    /// </summary>
    [Text("Erez")]
    Erez,

    /// <summary>
    /// at least 62 residents killed, 19 hostages taken
    /// </summary>
    [Text("Kfar Aza")]
    KfarAza,

    /// <summary>
    /// at least 22 people killed (4 kibbutz security team members, 4 other residents, 6 Thai laborers and 8 soldiers),
    /// at least 4 hostages taken
    /// </summary>
    [Text("Kissufim")]
    Kissufim,

    /// <summary>
    /// 15 civilians killed, plus more than 60 soldiers at the adjacent military base; 8 civilians and some soldiers taken hostage
    /// </summary>
    [Text("Nahal Oz")]
    NahalOz,

    /// <summary>
    /// 47 people killed, 76 hostages taken
    /// </summary>
    [Text("Nir Oz")]
    NirOz,

    /// <summary>
    /// 6 members of the kibbutz security team and 1 soldier killed, 7 residents taken hostage
    /// (2 were freed before reaching Gaza). Attacked by the Hamas Nuseirat Battalion
    /// </summary>
    [Text("Nir Yitzhak")]
    NirYitzhak,

    /// <summary>
    /// 5 residents killed, 5 hostages taken
    /// </summary>
    [Text("Nirim")]
    Nirim,
}

/// <summary>
/// moshavim (cooperative farming villages, as distinct from a <see cref="IsraeliKibbutz"/>) attacked on 2023-10-07
/// </summary>
internal enum IsraeliMoshav
{
    /// <summary>
    /// at least 17 people killed by three Hamas militants who arrived on paragliders, no hostages reported; attack directed by
    /// <see cref="IsraeliAssassinationTarget.AbuAjinaNasim"/>, according to the IDF. An IDF investigation found that the 37 soldiers
    /// and security officers present failed to stop the attack despite outnumbering the militants
    /// </summary>
    [Text("Netiv HaAsara")]
    NetivHaAsara,
}

/// <summary>
/// card a person appears on in the unofficial IDF "most wanted" Hamas playing card deck
/// </summary>
/// <remarks>source: https://en.wikipedia.org/wiki/Hamas_most_wanted_playing_cards</remarks>
internal class HamasMostWantedAttribute : Attribute
{
    /// <summary>
    /// card the person appears on
    /// </summary>
    public StandardPlayingCard Card { get; set; }

    /// <summary>
    /// optional explanation of how the person is depicted
    /// </summary>
    public string? Explanation { get; set; }

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="Card">card the person appears on</param>
    public HamasMostWantedAttribute(StandardPlayingCard Card)
    {
        this.Card = Card;
        this.Explanation = null;
    }

    /// <summary>
    /// constructor with an explanation
    /// </summary>
    /// <param name="Card">card the person appears on</param>
    /// <param name="Explanation">explanation of how the person is depicted</param>
    public HamasMostWantedAttribute(StandardPlayingCard Card, string Explanation)
    {
        this.Card = Card;
        this.Explanation = Explanation;
    }
}

/// <summary>
/// brigades of Palestinian militant factions' military wings in the Gaza Strip from the 2023-10-07 attacks on: each faction's
/// military wing as a whole (<see cref="AlQassam"/> for Hamas, <see cref="AlQuds"/> for Palestinian Islamic Jihad), and the
/// regional brigades. Both factions organize their Gaza forces by the same regions, so the regional brigades are combined with
/// a faction (e.g. in <see cref="PalestinianMilitantAttribute"/>) to identify a particular faction's brigade
/// </summary>
/// <remarks>
/// regional brigades follow the Institute for the Study of War order of battle for the Qassam Brigades, as summarized at
/// https://en.wikipedia.org/wiki/Al-Qassam_Brigades; less is public about the al-Quds Brigades' regional structure
/// </remarks>
internal enum PalestinianGazaMilitaryBrigade
{
    /// <summary>
    /// the Qassam Brigades as a whole, i.e. the entire military structure rather than one regional brigade.
    /// No <see cref="HamasMilitaryBattalion"/> belongs directly to it
    /// </summary>
    AlQassam = 0,

    /// <summary>
    /// the al-Quds Brigades, Palestinian Islamic Jihad's military wing, as a whole rather than one regional brigade.
    /// No <see cref="HamasMilitaryBattalion"/> belongs to it
    /// </summary>
    AlQuds,

    /// <summary>
    /// Northern Gaza Brigade (North Gaza Governorate)
    /// </summary>
    NorthernGaza,

    /// <summary>
    /// Gaza City Brigade (Gaza Governorate)
    /// </summary>
    GazaCity,

    /// <summary>
    /// Central Camps Brigade (Deir al-Balah Governorate)
    /// </summary>
    CentralCamps,

    /// <summary>
    /// Khan Yunis Brigade (Khan Yunis Governorate)
    /// </summary>
    KhanYunis,

    /// <summary>
    /// Rafah Brigade (Rafah Governorate)
    /// </summary>
    Rafah,
}

/// <summary>
/// brigade a <see cref="HamasMilitaryBattalion"/> belongs to
/// </summary>
internal class PalestinianGazaMilitaryBrigadeAttribute : Attribute
{
    public PalestinianGazaMilitaryBrigade Brigade { get; set; }
    public PalestinianGazaMilitaryBrigadeAttribute(PalestinianGazaMilitaryBrigade Brigade)
    {
        this.Brigade = Brigade;
    }
}

/// <summary>
/// battalions of the Qassam Brigades, Hamas's military wing, in the Gaza Strip from the 2023-10-07 attacks on
/// </summary>
/// <remarks>
/// source: the Institute for the Study of War order of battle, as summarized at https://en.wikipedia.org/wiki/Al-Qassam_Brigades.
/// Each battalion is associated with a major settlement, but battalions may be relocated during the war.
/// Not included: unconfirmed elite battalions in the Gaza City and Central Camps brigades, and a possible fourth Rafah battalion whose name is unknown
/// </remarks>
internal enum HamasMilitaryBattalion
{
    /// <summary>
    /// Beit Lahia Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.NorthernGaza)]
    BeitLahia,

    /// <summary>
    /// Beit Hanoun Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.NorthernGaza)]
    BeitHanoun,

    /// <summary>
    /// al-Khalifa al-Rashidun Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.NorthernGaza)]
    AlKhalifaAlRashidun,

    /// <summary>
    /// Martyr Suhail Ziadeh Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.NorthernGaza)]
    SuhailZiadeh,

    /// <summary>
    /// Jabalia al-Balad (Abdul Raouf Nabhan) Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.NorthernGaza)]
    JabaliaAlBalad,

    /// <summary>
    /// Imad Aql (Western) Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.NorthernGaza)]
    ImadAql,

    /// <summary>
    /// Elite Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.NorthernGaza)]
    NorthernGazaElite,

    /// <summary>
    /// Sabra-Tal al-Islam Battalion (also romanized "Zabara")
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.GazaCity)]
    SabraTalAlIslam,

    /// <summary>
    /// Daraj wal-Tuffah Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.GazaCity)]
    DarajWalTuffah,

    /// <summary>
    /// Radwan (al-Furqan) Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.GazaCity)]
    Radwan,

    /// <summary>
    /// Shuja'iyya Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.GazaCity)]
    Shujaiyya,

    /// <summary>
    /// Zaytoun Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.GazaCity)]
    Zaytoun,

    /// <summary>
    /// Shati Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.GazaCity)]
    Shati,

    /// <summary>
    /// Deir al-Balah Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.CentralCamps)]
    DeirAlBalah,

    /// <summary>
    /// al-Bureij Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.CentralCamps)]
    Bureij,

    /// <summary>
    /// al-Maghazi Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.CentralCamps)]
    Maghazi,

    /// <summary>
    /// Nuseirat Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.CentralCamps)]
    Nuseirat,

    /// <summary>
    /// Camp (West Khan Yunis) Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.KhanYunis)]
    KhanYunisWest,

    /// <summary>
    /// North Khan Yunis Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.KhanYunis)]
    KhanYunisNorth,

    /// <summary>
    /// South Khan Yunis Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.KhanYunis)]
    KhanYunisSouth,

    /// <summary>
    /// Eastern (Khan Yunis) Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.KhanYunis)]
    KhanYunisEast,

    /// <summary>
    /// Qarara Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.KhanYunis)]
    Qarara,

    /// <summary>
    /// Elite Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.KhanYunis)]
    KhanYunisElite,

    /// <summary>
    /// Eastern Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.Rafah)]
    RafahEast,

    /// <summary>
    /// Khalid bin al-Walid (Yibna Camp) Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.Rafah)]
    KhalidBinAlWalid,

    /// <summary>
    /// Shaboura Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.Rafah)]
    Shaboura,

    /// <summary>
    /// Elite Battalion
    /// </summary>
    [PalestinianGazaMilitaryBrigade(PalestinianGazaMilitaryBrigade.Rafah)]
    RafahElite,
}

/// <summary>
/// role a person held in a Palestinian militant faction's military wing at the time of their assassination, assassination
/// attempt or death: the faction, plus the whole military wing (<see cref="PalestinianGazaMilitaryBrigade.AlQassam"/> or
/// <see cref="PalestinianGazaMilitaryBrigade.AlQuds"/>), a regional <see cref="PalestinianGazaMilitaryBrigade"/>, or a
/// <see cref="HamasMilitaryBattalion"/> within a brigade
/// </summary>
/// <remarks>
/// base for <see cref="PalestinianMilitantCommanderAttribute"/>, <see cref="PalestinianMilitantCommanderDeputyAttribute"/> and
/// <see cref="PalestinianMilitantSpokespersonAttribute"/>; a lookup of this attribute returns all of them.
/// Battalions are only modelled for Hamas
/// </remarks>
internal class PalestinianMilitantAttribute : Attribute
{
    /// <summary>
    /// faction whose military wing the unit belongs to
    /// </summary>
    public PalestinianMilitantGroups Faction { get; set; }

    /// <summary>
    /// the whole military wing, a regional brigade, or the brigade the battalion belongs to
    /// </summary>
    public PalestinianGazaMilitaryBrigade Brigade { get; set; }

    /// <summary>
    /// battalion, or null when the role covers a whole brigade or military wing
    /// </summary>
    public HamasMilitaryBattalion? Battalion { get; set; }

    /// <summary>
    /// constructor for a role covering a whole brigade or military wing
    /// </summary>
    /// <param name="Faction">faction whose military wing the unit belongs to</param>
    /// <param name="Brigade">the whole military wing or a regional brigade</param>
    public PalestinianMilitantAttribute(PalestinianMilitantGroups Faction, PalestinianGazaMilitaryBrigade Brigade)
    {
        this.Faction = Faction;
        this.Brigade = Brigade;
        this.Battalion = null;
    }

    /// <summary>
    /// constructor for a role in a battalion
    /// </summary>
    /// <param name="Faction">faction whose military wing the unit belongs to</param>
    /// <param name="Brigade">brigade the battalion belongs to</param>
    /// <param name="Battalion">the battalion</param>
    public PalestinianMilitantAttribute(PalestinianMilitantGroups Faction, PalestinianGazaMilitaryBrigade Brigade, HamasMilitaryBattalion Battalion)
    {
        this.Faction = Faction;
        this.Brigade = Brigade;
        this.Battalion = Battalion;
    }
}

/// <summary>
/// unit a person commanded, or was deputy commander of, at the time of their assassination, assassination attempt or death
/// </summary>
/// <remarks>
/// deputy commanders use the derived <see cref="PalestinianMilitantCommanderDeputyAttribute"/>, which sets <see cref="IsDeputy"/>;
/// a lookup of this attribute also returns deputies, so check <see cref="IsDeputy"/> to tell them apart.
/// Heads of functional branches (e.g. the rocket array) use <see cref="PalestinianMilitantSpecialtyHeadAttribute"/> instead
/// </remarks>
internal class PalestinianMilitantCommanderAttribute : PalestinianMilitantAttribute
{
    /// <summary>
    /// true for a deputy commander rather than the commander
    /// </summary>
    public bool IsDeputy { get; protected set; }

    /// <summary>
    /// constructor for a commander of a whole brigade or military wing
    /// </summary>
    /// <param name="Faction">faction whose military wing the unit belongs to</param>
    /// <param name="Brigade">the whole military wing or a regional brigade</param>
    public PalestinianMilitantCommanderAttribute(PalestinianMilitantGroups Faction, PalestinianGazaMilitaryBrigade Brigade) : base(Faction, Brigade)
    {
        this.IsDeputy = false;
    }

    /// <summary>
    /// constructor for a commander of a battalion
    /// </summary>
    /// <param name="Faction">faction whose military wing the unit belongs to</param>
    /// <param name="Brigade">brigade the battalion belongs to</param>
    /// <param name="Battalion">battalion commanded</param>
    public PalestinianMilitantCommanderAttribute(PalestinianMilitantGroups Faction, PalestinianGazaMilitaryBrigade Brigade, HamasMilitaryBattalion Battalion) : base(Faction, Brigade, Battalion)
    {
        this.IsDeputy = false;
    }
}

/// <summary>
/// unit a person was deputy commander of at the time of their assassination, assassination attempt or death
/// </summary>
/// <remarks>
/// a <see cref="PalestinianMilitantCommanderAttribute"/> with <see cref="PalestinianMilitantCommanderAttribute.IsDeputy"/> set
/// </remarks>
internal class PalestinianMilitantCommanderDeputyAttribute : PalestinianMilitantCommanderAttribute
{
    /// <summary>
    /// constructor for a deputy commander of a whole brigade or military wing
    /// </summary>
    /// <param name="Faction">faction whose military wing the unit belongs to</param>
    /// <param name="Brigade">the whole military wing or a regional brigade</param>
    public PalestinianMilitantCommanderDeputyAttribute(PalestinianMilitantGroups Faction, PalestinianGazaMilitaryBrigade Brigade) : base(Faction, Brigade)
    {
        this.IsDeputy = true;
    }

    /// <summary>
    /// constructor for a deputy commander of a battalion
    /// </summary>
    /// <param name="Faction">faction whose military wing the unit belongs to</param>
    /// <param name="Brigade">brigade the battalion belongs to</param>
    /// <param name="Battalion">battalion the person was deputy commander of</param>
    public PalestinianMilitantCommanderDeputyAttribute(PalestinianMilitantGroups Faction, PalestinianGazaMilitaryBrigade Brigade, HamasMilitaryBattalion Battalion) : base(Faction, Brigade, Battalion)
    {
        this.IsDeputy = true;
    }
}

/// <summary>
/// unit a person was the public spokesperson of at the time of their assassination, assassination attempt or death
/// </summary>
internal class PalestinianMilitantSpokespersonAttribute : PalestinianMilitantAttribute
{
    /// <summary>
    /// constructor for a spokesperson of a whole brigade or military wing
    /// </summary>
    /// <param name="Faction">faction whose military wing the unit belongs to</param>
    /// <param name="Brigade">the whole military wing or a regional brigade</param>
    public PalestinianMilitantSpokespersonAttribute(PalestinianMilitantGroups Faction, PalestinianGazaMilitaryBrigade Brigade) : base(Faction, Brigade)
    {
    }
}

/// <summary>
/// functional branches ("arrays", "systems" or "headquarters" in English sources) of a Palestinian militant faction's
/// military wing, organized alongside the regional brigades and battalions. A branch has a head for the whole military wing,
/// and may also have a head within a regional brigade
/// </summary>
internal enum PalestinianMilitantSpecialty
{
    /// <summary>
    /// aerial array: drones, paragliders, UAVs, aerial detection and defense systems
    /// </summary>
    Aerial,

    /// <summary>
    /// anti-tank array
    /// </summary>
    AntiTank,

    /// <summary>
    /// administrative and combat support headquarters
    /// </summary>
    CombatSupportAndAdministration,

    /// <summary>
    /// military intelligence
    /// </summary>
    Intelligence,

    /// <summary>
    /// naval force
    /// </summary>
    Naval,

    /// <summary>
    /// weapons production headquarters
    /// </summary>
    Production,

    /// <summary>
    /// rocket array
    /// </summary>
    Rockets,
}

/// <summary>
/// functional branch of a Palestinian militant faction's military wing that a person headed, or was deputy head of, at the time
/// of their assassination, assassination attempt or death
/// </summary>
/// <remarks>
/// separate from <see cref="PalestinianMilitantAttribute"/>, so a person can hold both a regional command and a functional branch.
/// Deputy heads use the derived <see cref="PalestinianMilitantSpecialtyHeadDeputyAttribute"/>, which sets <see cref="IsDeputy"/>.
/// Earlier posts are described in the person's documentation instead
/// </remarks>
internal class PalestinianMilitantSpecialtyHeadAttribute : Attribute
{
    /// <summary>
    /// faction whose military wing the branch belongs to
    /// </summary>
    public PalestinianMilitantGroups Faction { get; set; }

    /// <summary>
    /// the whole military wing for a head of the whole branch, or the regional brigade for a head within one brigade
    /// </summary>
    public PalestinianGazaMilitaryBrigade Brigade { get; set; }

    /// <summary>
    /// the functional branch
    /// </summary>
    public PalestinianMilitantSpecialty Specialty { get; set; }

    /// <summary>
    /// true for a deputy head rather than the head
    /// </summary>
    public bool IsDeputy { get; protected set; }

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="Faction">faction whose military wing the branch belongs to</param>
    /// <param name="Brigade">the whole military wing, or the regional brigade the person headed the branch within</param>
    /// <param name="Specialty">the functional branch</param>
    public PalestinianMilitantSpecialtyHeadAttribute(PalestinianMilitantGroups Faction, PalestinianGazaMilitaryBrigade Brigade, PalestinianMilitantSpecialty Specialty)
    {
        this.Faction = Faction;
        this.Brigade = Brigade;
        this.Specialty = Specialty;
        this.IsDeputy = false;
    }
}

/// <summary>
/// functional branch of a Palestinian militant faction's military wing that a person was deputy head of at the time of their
/// assassination, assassination attempt or death
/// </summary>
/// <remarks>
/// a <see cref="PalestinianMilitantSpecialtyHeadAttribute"/> with <see cref="PalestinianMilitantSpecialtyHeadAttribute.IsDeputy"/> set
/// </remarks>
internal class PalestinianMilitantSpecialtyHeadDeputyAttribute : PalestinianMilitantSpecialtyHeadAttribute
{
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="Faction">faction whose military wing the branch belongs to</param>
    /// <param name="Brigade">the whole military wing, or the regional brigade the person was deputy head of the branch within</param>
    /// <param name="Specialty">the functional branch</param>
    public PalestinianMilitantSpecialtyHeadDeputyAttribute(PalestinianMilitantGroups Faction, PalestinianGazaMilitaryBrigade Brigade, PalestinianMilitantSpecialty Specialty) : base(Faction, Brigade, Specialty)
    {
        this.IsDeputy = true;
    }
}

/// <summary>
/// position a person held on the Hamas Political Bureau, the movement's top political leadership body,
/// at the time of their assassination, assassination attempt or death
/// </summary>
internal class HamasPoliticalBureauAttribute : Attribute
{
    /// <summary>
    /// position held, e.g. "Chairman", "Deputy Chairman" or "Member"
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="Title">position held</param>
    public HamasPoliticalBureauAttribute(string Title)
    {
        this.Title = Title;
    }
}

/// <summary>
/// position a person held in one of Hamas's security services in Gaza at the time of their assassination, assassination attempt,
/// capture or death
/// </summary>
/// <remarks>
/// the security services are separate from the Qassam Brigades' military structure (<see cref="PalestinianMilitantAttribute"/>).
/// Use <see cref="HamasInteriorMinistryInternalSecurityAttribute"/> or <see cref="HamasGeneralSecurityAttribute"/> when sources
/// say which service the person belonged to, and this attribute directly when they do not, or disagree. The police are not included
/// </remarks>
internal class HamasSecurityAttribute : Attribute
{
    /// <summary>
    /// position held, e.g. "Head in Gaza" for the whole Gaza Strip or "Head in Khan Yunis" for one region
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="Title">position held</param>
    public HamasSecurityAttribute(string Title)
    {
        this.Title = Title;
    }
}

/// <summary>
/// position a person held in the Internal Security apparatus of the Hamas-run Interior Ministry in Gaza
/// </summary>
internal class HamasInteriorMinistryInternalSecurityAttribute : HamasSecurityAttribute
{
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="Title">position held</param>
    public HamasInteriorMinistryInternalSecurityAttribute(string Title) : base(Title)
    {
    }
}

/// <summary>
/// position a person held in Hamas's General Security apparatus (also called the General Security Mechanism) in Gaza, the
/// movement's own security and intelligence service rather than a government body
/// </summary>
internal class HamasGeneralSecurityAttribute : HamasSecurityAttribute
{
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="Title">position held</param>
    public HamasGeneralSecurityAttribute(string Title) : base(Title)
    {
    }
}

/// <summary>
/// Palestinian militant group a person is specifically associated with (as a member, leader or financier)
/// </summary>
/// <remarks>
/// not used on people who have a <see cref="PalestinianMilitantAttribute"/> role (commander, deputy commander or spokesperson)
/// or a <see cref="PalestinianMilitantSpecialtyHeadAttribute"/>, whose Faction already names the group
/// </remarks>
internal class PalestinianMilitantGroupAttribute : Attribute
{
    public PalestinianMilitantGroups Group { get; set; }
    public PalestinianMilitantGroupAttribute(PalestinianMilitantGroups Group)
    {
        this.Group = Group;
    }
}

/// <summary>
/// an Israeli assassination attempt the target survived that took place before the 2023-10-07 attacks
/// </summary>
/// <remarks>
/// not an exhaustive record: only applied where the earlier attempt is relevant to the list, e.g. the target is still alive
/// </remarks>
internal class AttemptedAssassinationPriorToOctober7Attribute : AssassinationAttemptAttribute
{
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="Year">year of the attempt</param>
    /// <param name="Month">month of the attempt</param>
    /// <param name="Day">day of the attempt</param>
    /// <param name="Country">country where the assassination attempt took place</param>
    /// <param name="City">city where the assassination attempt took place</param>
    public AttemptedAssassinationPriorToOctober7Attribute(int Year, int Month, int Day, CountryLikeThings Country, WorldCities City) : base(Year, Month, Day, Country, City)
    {
    }
}

/// <summary>
/// an Israeli assassination that took place before the 2023-10-07 attacks
/// </summary>
/// <remarks>
/// not an exhaustive record: only applied where the earlier assassination is relevant to the list
/// </remarks>
internal class AssassinatedPriorToOctober7Attribute : AssassinatedAttribute
{
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="Country">country where the assassination took place</param>
    /// <param name="City">city where the assassination took place</param>
    public AssassinatedPriorToOctober7Attribute(CountryLikeThings Country, WorldCities City) : base(Country, City)
    {
    }
}

/// <summary>
/// a target who was killed during the war, where it is not known whether they were the target of an assassination
/// or a casualty of the wider fighting
/// </summary>
/// <remarks>
/// deliberately does not inherit from <see cref="AssassinatedAttribute"/>, and is not counted in the
/// <see cref="TotalAssassinationAttemptsStemmingFrom2023OctoberAttacksAttribute"/>
/// </remarks>
internal class KilledButMayHaveBeenWarOrAssassinationCasualtyAttribute : Attribute
{
    /// <summary>
    /// country where the death took place
    /// </summary>
    public CountryLikeThings? Country { get; set; }

    /// <summary>
    /// constructor for when the country is unknown
    /// </summary>
    public KilledButMayHaveBeenWarOrAssassinationCasualtyAttribute()
    {
        this.Country = null;
    }

    /// <summary>
    /// constructor for when the country is known
    /// </summary>
    /// <param name="Country">country where the death took place</param>
    public KilledButMayHaveBeenWarOrAssassinationCasualtyAttribute(CountryLikeThings Country)
    {
        this.Country = Country;
    }
}

/// <summary>
/// a target who was killed by the party trying to assassinate them, but not in an assassination
/// (e.g. killed in a chance encounter rather than a planned strike)
/// </summary>
/// <remarks>
/// deliberately does not inherit from <see cref="AssassinatedAttribute"/> so that it is not treated as an assassination,
/// but it is counted in the <see cref="TotalAssassinationAttemptsStemmingFrom2023OctoberAttacksAttribute"/>
/// </remarks>
internal class AssassinatedButNotActuallyAssassinatedAttribute : Attribute
{
    /// <summary>
    /// country where the death took place
    /// </summary>
    public CountryLikeThings Country { get; set; }

    /// <summary>
    /// city where the death took place
    /// </summary>
    public WorldCities City { get; set; }

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="Country">country where the death took place</param>
    /// <param name="City">city where the death took place</param>
    public AssassinatedButNotActuallyAssassinatedAttribute(CountryLikeThings Country, WorldCities City)
    {
        this.Country = Country;
        this.City = City;
    }
}

/// <summary>
/// a target who was captured alive by Israeli forces rather than killed
/// </summary>
/// <remarks>
/// not an assassination or assassination attempt, so it is not counted in the
/// <see cref="TotalAssassinationAttemptsStemmingFrom2023OctoberAttacksAttribute"/>
/// </remarks>
internal class CapturedByIsraelAttribute : YearDateAttribute
{
    /// <summary>
    /// country where the capture took place
    /// </summary>
    public CountryLikeThings Country { get; set; }

    /// <summary>
    /// city where the capture took place
    /// </summary>
    public WorldCities City { get; set; }

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="Year">year of the capture</param>
    /// <param name="Month">month of the capture</param>
    /// <param name="Day">day of the capture</param>
    /// <param name="Country">country where the capture took place</param>
    /// <param name="City">city where the capture took place</param>
    public CapturedByIsraelAttribute(int Year, int Month, int Day, CountryLikeThings Country, WorldCities City) : base(Year, Month, Day)
    {
        this.Country = Country;
        this.City = City;
    }
}

/// <summary>
/// date a death was first reported, where the report came from the Israel Defence Forces (alone or jointly with the Shin Bet)
/// </summary>
internal class DeathDateReportedByIDFAttribute : DeathDateReportedAttribute
{
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="Year">year the IDF reported the death</param>
    /// <param name="Month">month the IDF reported the death</param>
    /// <param name="Day">day the IDF reported the death</param>
    /// <param name="Overnight">true when the death took place overnight before the report</param>
    public DeathDateReportedByIDFAttribute(int Year, int Month, int Day, bool Overnight = false) : base(Year, Month, Day, Overnight)
    {
    }
}

/// <summary>
/// a target who was still alive when the term of <see cref="IsraeliPoliticians.NetanyahuBenjamin"/> as prime minister of Israel ended,
/// which is the end date of the <see cref="IsraeliAssassinationTarget"/> list
/// </summary>
/// <remarks>
/// applied provisionally to the targets who are currently alive: the term has not ended yet
/// </remarks>
internal class SurvivedTheEndOfNetanyahusPostOctober7AttacksTermAttribute : Attribute
{
}

/// <summary>
/// a target where it has not been confirmed whether they are still alive
/// </summary>
internal class UnclearIfStillAliveAttribute : Attribute
{
}

/// <summary>
/// range of how many targets on a list could have survived
/// </summary>
/// <remarks>
/// the low end is the number of targets marked <see cref="SurvivedTheEndOfNetanyahusPostOctober7AttacksTermAttribute"/>;
/// the high end adds the targets marked <see cref="UnclearIfStillAliveAttribute"/>
/// </remarks>
internal class SurvivorCountRangeAttribute : Attribute
{
    /// <summary>
    /// number of targets known to have survived
    /// </summary>
    public int Low { get; set; }

    /// <summary>
    /// number of targets who could have survived, counting those whose fate is unconfirmed
    /// </summary>
    public int High { get; set; }

    public SurvivorCountRangeAttribute(int Low, int High)
    {
        this.Low = Low;
        this.High = High;
    }
}

/// <summary>
/// number of Israeli assassinations, survived assassination attempts and other killings of assassination targets
/// made after the 2023-10-07 attacks
/// </summary>
/// <remarks>
/// counts <see cref="AssassinatedAttribute"/>, <see cref="AssassinationAttemptAttribute"/> and
/// <see cref="AssassinatedButNotActuallyAssassinatedAttribute"/>, not targets: a target can have more than one.
/// Not counted: earlier assassinations and attempts that are only on the list because they are adjacent to it
/// (<see cref="AssassinatedPriorToOctober7Attribute"/>, <see cref="AttemptedAssassinationPriorToOctober7Attribute"/>),
/// and deaths that may have been war casualties rather than assassinations
/// (<see cref="KilledButMayHaveBeenWarOrAssassinationCasualtyAttribute"/>), which are not currently included,
/// and captures (<see cref="CapturedByIsraelAttribute"/>)
/// </remarks>
internal class TotalAssassinationAttemptsStemmingFrom2023OctoberAttacksAttribute : TotalAttribute
{
    public TotalAssassinationAttemptsStemmingFrom2023OctoberAttacksAttribute(int Total) : base(Total)
    {
    }
}

/// <summary>
/// targets of Israeli assassinations and assassination attempts since the 2023-10-07 attacks
/// </summary>
/// <remarks>
/// the list ends when <see cref="IsraeliPoliticians.NetanyahuBenjamin"/> leaves power in Israel; targets still alive at that point are
/// marked with <see cref="SurvivedTheEndOfNetanyahusPostOctober7AttacksTermAttribute"/>, and those whose fate is unconfirmed with <see cref="UnclearIfStillAliveAttribute"/>.
/// earlier assassinations and attempts are only included where they are relevant to someone on the list
/// (<see cref="AssassinatedPriorToOctober7Attribute"/>, <see cref="AttemptedAssassinationPriorToOctober7Attribute"/>),
/// and are not part of the <see cref="TotalAssassinationAttemptsStemmingFrom2023OctoberAttacksAttribute"/>.
/// Members of the Hamas "most wanted" playing card deck (<see cref="HamasMostWantedAttribute"/>) who were killed during the war
/// are included even when it is not known whether they were assassinated, marked with
/// <see cref="KilledButMayHaveBeenWarOrAssassinationCasualtyAttribute"/>. Those deaths (currently 17) are not currently included
/// in the <see cref="TotalAssassinationAttemptsStemmingFrom2023OctoberAttacksAttribute"/>; they could be added to it later
/// if they are confirmed as assassinations.
/// Targets captured alive by Israeli forces are also included, marked with <see cref="CapturedByIsraelAttribute"/>
/// </remarks>
[TotalAssassinationAttemptsStemmingFrom2023OctoberAttacks(122)]
[SurvivorCountRange(6, 7)]
internal enum IsraeliAssassinationTarget
{
    /// <summary>
    /// Killed in an Israeli airstrike in Tehran on the first day of the Twelve-Day War, in the opening wave of strikes on
    /// Iran's nuclear scientists and military commanders. Head of the Atomic Energy Organization of Iran from 2011 to 2013.
    /// 2010: wounded in Tehran when a man on a motorbike attached a bomb to his car as he drove to work; a similar attack
    /// the same day killed fellow scientist <see cref="ShahriariMajid"/>.
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [EthnicGroup(WorldEthnicGroups.Persian)]
    [HumanOccupation(HumanOccupation.ScientistNuclear)]
    [AttemptedAssassinationPriorToOctober7(2010, 11, 29, CountryLikeThings.Iran, WorldCities.IranTehran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    AbbasiFereydoon,

    /// <summary>
    /// Commander of Hezbollah's Nasr unit
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2024, 6, 11)]
    AbdullahTaleb,

    /// <summary>
    /// IRGC commander
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Syria)]
    [DeathDate(2024, 6, 3)]
    AbiyarSaeed,

    /// <summary>
    /// Killed in an IDF airstrike based on Shin Bet and military intelligence. The IDF said he commanded
    /// the October 7 attacks on <see cref="IsraeliKibbutz.Erez"/> and <see cref="IsraeliMoshav.NetivHaAsara"/>. Previously commanded
    /// Hamas's aerial forces (<see cref="PalestinianMilitantSpecialty.Aerial"/>), working on its drones and paragliders.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.NorthernGaza, HamasMilitaryBattalion.BeitLahia)]
    [HamasMostWanted(StandardPlayingCard.SpadesFive)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10)]
    [DeathDateReportedByIDF(2023, 10, 31)]
    AbuAjinaNasim,

    /// <summary>
    /// Killed with his wife and two children in an overnight Israeli strike on the Beach refugee camp, the day after
    /// <see cref="AbuNahelNaeem"/>; Hamas confirmed his death.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasInteriorMinistryInternalSecurity("Head in northern Gaza")]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2026, 11)]
    [DeathDateReported(2026, 11, 25, Overnight: true)]
    AbueloufMohammad,

    /// <summary>
    /// Killed with his wife in an Israeli night air raid in central Gaza on the day Israel resumed fighting and ended the
    /// January 2025 ceasefire.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantSpokesperson(PalestinianMilitantGroups.PalestinianIslamicJihad, PalestinianGazaMilitaryBrigade.AlQuds)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2025, 3, 18)]
    AbuHamza,

    /// <summary>
    /// Targeted in an overnight strike on Nasser Hospital in Khan Yunis that killed
    /// at least six people. Survived with a severe head injury and an amputated leg according to Israeli sources;
    /// neither the IDF nor Hamas has confirmed his condition.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.KhanYunis)]
    [AssassinationAttempt(2026, 11, 12, CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
    [UnclearIfStillAlive]
    AbuIsmailMuhammad,

    /// <summary>
    /// Killed in an Israeli air strike in the first days of the war that killed two members of Hamas's political office,
    /// according to a Hamas official.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Senior Member")]
    [HamasMostWanted(StandardPlayingCard.DiamondsNine)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10)]
    [DeathDateReported(2023, 10, 10)]
    AbuMaamarZakaria,

    /// <summary>
    /// Killed in an Israeli drone strike that also killed <see cref="AlQadiAli"/>. An operational commander in the October 7 attacks.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantSpecialtyHead(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam, PalestinianMilitantSpecialty.Aerial)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10, 14)]
    AbuMuradMurad,

    /// <summary>
    /// Killed in an Israeli strike in western Gaza City that <see cref="IsraeliPoliticians.NetanyahuBenjamin"/> said targeted him; Hamas confirmed his death. Took over in
    /// September 2026 after the capture of <see cref="AlArabidMuein"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasInteriorMinistryInternalSecurity("Head in Gaza")]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2026, 11, 24)]
    AbuNahelNaeem,

    /// <summary>
    /// Killed in an Israeli airstrike on his home in an apartment building in the Rimal neighborhood of Gaza City, which killed at least
    /// 11 people including children. Israel confirmed his death the next day; Hamas confirmed it on 2025-12-29, together with the deaths
    /// of <see cref="SinwarMohammed"/>, <see cref="ShabanaMuhammad"/>, <see cref="SaadRaad"/> and <see cref="AlIssaHakhamMuhammadIssa"/>,
    /// and gave his nom de guerre to a new spokesperson. Spokesperson from 2007; first appeared in 2006 announcing the capture of
    /// <see cref="PriorTo2023October7thHostageList.ShalitGilad"/>, and in 2014 announced the capture of <see cref="HostageList.ShaulOron"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantSpokesperson(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam)]
    [HamasMostWanted(StandardPlayingCard.SpadesAce)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2025, 8, 30)]
    AbuObeida,

    /// <summary>
    /// Succeeded <see cref="ShabanaMuhammad"/> as brigade commander. Killed by an IDF and Shin Bet drone strike
    /// in southern Gaza. Succeeded by <see cref="AbuYounisSamir"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.Rafah)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2026, 9, 15)]
    AbuObeidNael,

    /// <summary>
    /// Killed by Israeli fighter jets in an overnight operation, according to Israel.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantSpecialtyHead(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam, PalestinianMilitantSpecialty.Aerial)]
    [HamasMostWanted(StandardPlayingCard.HeartsKing)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10)]
    [DeathDateReportedByIDF(2023, 10, 28, Overnight: true)]
    AbuRakabaAsem,

    /// <summary>
    /// Secretary-General of the Mujahideen Brigades
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.MujahideenBrigades)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2025, 6, 7)]
    AbuShariaAsad,

    /// <summary>
    /// Killed in an Israeli airstrike on the Nuseirat refugee camp that also killed <see cref="IssaMarwan"/>. Hamas confirmed his death
    /// on 2025-01-30, together with that of <see cref="DeifMohammed"/>; thousands attended his funeral in Deir al-Balah.
    /// A member of the Qassam Brigades' military council.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantSpecialtyHead(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam, PalestinianMilitantSpecialty.CombatSupportAndAdministration)]
    [Texts("Ghazi Abu Tama’a", "غازي أبو طماعة")]
    [AlsoKnownAs("Abu Musa")]
    [HamasMostWanted(StandardPlayingCard.HeartsEight, "spelled \"Razi Abu Tama'ah\" on the card list")]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2024, 3, 10)]
    AbuTamaaGhazi,

    /// <summary>
    /// Head of the Hamas-run Interior Ministry in Gaza, overseeing its police and internal security services, and a major general.
    /// Killed with several members of his family in the early-morning Israeli strikes that ended the January 2025 ceasefire, which
    /// also killed <see cref="AlDaalisIssam"/>; Hamas named him among the officials killed.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2025, 3, 18)]
    AbuWatfaMahmoud,

    /// <summary>
    /// Commander of Hamas's Rafah Brigade for about two months, succeeding <see cref="AbuObeidNael"/>. Killed by an IDF and
    /// Shin Bet drone strike in southern Gaza; Hamas confirmed his death.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.Rafah)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2026, 11, 14)]
    AbuYounisSamir,

    /// <summary>
    /// A major. Killed with <see cref="AlLadawiWaelMousa"/> in an Israeli airstrike on their car.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasSecurity("Major")]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaDeirAlBalah)]
    [DeathDate(2026, 7, 26)]
    AbuZureiqRamezTawfiq,

    /// <summary>
    /// Head of Hezbollah's media relations
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 11, 17)]
    AfifMohammad,

    /// <summary>
    /// Head of Basij intelligence
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 3, 17)]
    AhmadiEsmail,

    /// <summary>
    /// Head of Hamas's media department, and described as the de facto Hamas leader in Gaza at the time of the attempt.
    /// Targeted by the IDF in a strike on an apartment in Gaza City that killed two church members; Hamas said on 2026-10-05
    /// that he was alive.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.SpadesNine)]
    [AssassinationAttempt(2026, 10, 3, CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [SurvivedTheEndOfNetanyahusPostOctober7AttacksTerm]
    AlAmoudiAli,

    /// <summary>
    /// Captured wounded in a Shin Bet special forces raid in Gaza City and taken to Israel for questioning; his wife was killed
    /// and two of his sons were wounded, according to Palestinian reports. Hamas said he was a lower-ranking security officer rather
    /// than the head of the apparatus. Succeeded by <see cref="AbuNahelNaeem"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasInteriorMinistryInternalSecurity("Head in Gaza")]
    [CapturedByIsrael(2026, 9, 1, CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [SurvivedTheEndOfNetanyahusPostOctober7AttacksTerm]
    AlArabidMuein,

    /// <summary>
    /// Killed in an Israeli strike on a Hamas office in the Dahieh suburbs of Beirut that also killed six others, including
    /// senior Hamas militants. One of the architects of the October 7 attacks, and responsible for expanding Hamas's activities in the
    /// West Bank, where <see cref="JabarinZaher"/> succeeded him. Israel did not confirm its involvement until May 2025.
    /// </summary>
    [Country(CountryLikeThings.PalestineWestBank)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Deputy Chairman")]
    [HamasMostWanted(StandardPlayingCard.Joker2)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 1, 2)]
    AlArouriSaleh,

    /// <summary>
    /// Killed with his wife in an Israeli drone strike on his tent west of Khan Yunis, days after Israel ended the
    /// January 2025 ceasefire. Also a Hamas spokesperson, and a member of the Palestinian Legislative Council for Khan Yunis from 2006.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Member")]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2025, 3, 23)]
    AlBardawilSalah,

    /// <summary>
    /// Head of Hamas's Government Administrative Committee in Gaza
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.SpadesKing)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2025, 3, 18)]
    AlDaalisIssam,

    /// <summary>
    /// Houthi chief of staff. Killed alongside several associates and his 13-year-old son; the Houthis did not confirm his
    /// death until 2025-10-16, when the IDF confirmed he was killed in the 2025-08-28 strike.
    /// 2025-06-14: targeted by the IDF on the second day of the Twelve-Day War. An Israeli official said he was wounded;
    /// the Houthis denied that anything happened to him.
    /// </summary>
    [Country(CountryLikeThings.YemenHouthi)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [AssassinationAttempt(2025, 6, 14, CountryLikeThings.YemenHouthi)]
    [Assassinated(CountryLikeThings.YemenHouthi, WorldCities.YemenSanaa)]
    [DeathDate(2025, 8, 28)]
    AlGhamariMuhammadAbdAlKarim,

    /// <summary>
    /// Hamas leader in Gaza and Al-Qassam Brigades commander
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam)]
    [HamasMostWanted(StandardPlayingCard.ClubsQueen)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2026, 5, 15)]
    AlHaddadIzzAlDin,

    /// <summary>
    /// Hamas chief negotiator.
    /// 2007: an Israeli strike on his home in Gaza City killed seven or eight of his relatives; he survived.
    /// 2025: survived the strike on the Hamas compound in Doha, which killed his son Himam and his office director.
    /// Other sons were killed by Israeli strikes in 2008, 2014 and 2026.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Deputy Chairman")]
    [HamasMostWanted(StandardPlayingCard.DiamondsKing)]
    [AttemptedAssassinationPriorToOctober7(2007, 5, 20, CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [AssassinationAttempt(2025, 9, 9, CountryLikeThings.Qatar, WorldCities.QatarDoha)]
    [SurvivedTheEndOfNetanyahusPostOctober7AttacksTerm]
    AlHayyaKhalil,

    /// <summary>
    /// Killed in an Israeli airstrike in Gaza City. Succeeded <see cref="AbuTamaaGhazi"/>, who was killed in 2024.
    /// </summary>
    [Country(CountryLikeThings.PalestineUnited)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantSpecialtyHead(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam, PalestinianMilitantSpecialty.CombatSupportAndAdministration)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2025, 6, 27)]
    AlIssaHakhamMuhammadIssa,

    /// <summary>
    /// Police colonel who led the anti-narcotics force in Khan Yunis, and described as a senior Interior Ministry officer. Killed in an
    /// Israeli strike on his vehicle near al-Mawasi, west of Khan Yunis, which wounded at least 17 others; Palestinian medics called
    /// it a targeted strike.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
    [DeathDate(2026, 5, 6)]
    AlKalazaniNaseem,

    /// <summary>
    /// Hamas commander of the Kfar Aza massacre
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10, 15)]
    AlKedraBillal,

    /// <summary>
    /// A colonel. Killed with <see cref="AbuZureiqRamezTawfiq"/> in an Israeli airstrike on their car; the IDF and Shin Bet confirmed the strike the next day.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasInteriorMinistryInternalSecurity("Head in central Gaza")]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaDeirAlBalah)]
    [DeathDate(2026, 7, 26)]
    AlLadawiWaelMousa,

    /// <summary>
    /// Chief of the Hamas-led police force; the IDF said he was also an al-Qassam Brigades militant. Killed in an Israeli strike in
    /// the Sheikh Radwan neighborhood of Gaza City.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2026, 7, 25)]
    AlMaqadmaAbdelNasser,

    /// <summary>
    /// Senior Hezbollah commander
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBaalbek)]
    [DeathDate(2026, 2, 20)]
    AlMoussawiAliZeid,

    /// <summary>
    /// Senior Hezbollah commander
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBaalbek)]
    [DeathDate(2026, 2, 20)]
    AlMoussawiMuhammadIbrahim,

    /// <summary>
    /// Senior Palestinian Islamic Jihad commander
    /// </summary>
    [Country(CountryLikeThings.PalestineUnited)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.PalestinianIslamicJihad)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2026, 3, 3)]
    AlOthmanAdhamAdnan,

    /// <summary>
    /// Hamas Nukhba company commander
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10, 14)]
    AlQadiAli,

    /// <summary>
    /// Killed with several companions in an Israeli airstrike on an apartment building in Sana'a, the same day as the strike
    /// that killed <see cref="AlGhamariMuhammadAbdAlKarim"/>; the Houthis confirmed his death two days later. Prime minister
    /// of the Houthi government from 2024-08-10, and a member of the General People's Congress party rather than a Houthi.
    /// Earlier survived several non-Israeli assassination attempts, and al-Qaeda blew up his house in 2015.
    /// </summary>
    [Country(CountryLikeThings.YemenHouthi)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [HumanOccupation(HumanOccupation.MinisterPrimeOfCountry, CountryLikeThings.YemenHouthi)]
    [Assassinated(CountryLikeThings.YemenHouthi, WorldCities.YemenSanaa)]
    [DeathDate(2025, 8, 28)]
    AlRahawiAhmed,

    /// <summary>
    /// Commander of explosive devices in the northern Gaza Strip
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.ClubsFive)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10)]
    AlSaharIbrahim,

    /// <summary>
    /// Killed in an IDF strike in July 2024 that the IDF only announced three months later, together with the deaths
    /// of <see cref="MushtahaRawhi"/> and <see cref="OdehSami"/>. Arab media had reported in August 2024 that the strike hit a tunnel under Gaza City and killed
    /// five Hamas leaders.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Member")]
    [HamasMostWanted(StandardPlayingCard.SpadesQueen)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2024, 7)]
    [DeathDateReportedByIDF(2024, 10, 3)]
    AlSarrajSameh,

    /// <summary>
    /// Senior Hezbollah Radwan Force commander
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2024, 1, 8)]
    AlTawilWissam,

    /// <summary>
    /// Killed by Israeli Air Force fighter jets under Shin Bet guidance, according to the IDF and Shin Bet.
    /// The same statement announced the killing of <see cref="HijaziAkram"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantSpecialtyHead(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.GazaCity, PalestinianMilitantSpecialty.AntiTank)]
    [HamasMostWanted(StandardPlayingCard.DiamondsTwo)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10)]
    [DeathDateReportedByIDF(2023, 10, 18)]
    AlwadiaMohammed,

    /// <summary>
    /// Head of Hezbollah's Radwan Force
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 20)]
    AqilIbrahim,

    /// <summary>
    /// Intelligence head
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    AsadiSaleh,

    /// <summary>
    /// Killed during the war, according to the IDF.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantSpecialtyHead(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.KhanYunis, PalestinianMilitantSpecialty.AntiTank)]
    [HamasMostWanted(StandardPlayingCard.SpadesThree)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 11)]
    [DeathDateReportedByIDF(2023, 11, 13)]
    AshurYakub,

    /// <summary>
    /// Killed by Israeli forces, who said he was involved in the October 7 attacks; the date,
    /// place and method of the killing were not given. Deputy commander of the Gaza City Brigade; also commanded the
    /// <see cref="HamasMilitaryBattalion.Zaytoun"/> Battalion from May 2021, after Israel killed its previous commander.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommanderDeputy(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.GazaCity)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2026, 5)]
    [DeathDateReportedByIDF(2026, 5, 29)]
    AslimImadHassanHussein,

    /// <summary>
    /// Killed in a joint IDF and Shin Bet airstrike on a building in the Jabalia refugee camp, based on specific
    /// intelligence according to the IDF. Planned Hamas's anti-tank missile attacks, according to Israeli sources.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantSpecialtyHead(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam, PalestinianMilitantSpecialty.AntiTank)]
    [HamasMostWanted(StandardPlayingCard.ClubsNine)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaJabalia)]
    [DeathDate(2023, 11, 1)]
    AtzarMuhammad,

    /// <summary>
    /// Hezbollah Nasr unit rocket and missile commander
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2024, 6, 17)]
    AyoubMuhammadMustafa,

    /// <summary>
    /// Senior member of Hezbollah's Unit 151
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Syria, WorldCities.SyriaAlQusayr)]
    [DeathDate(2024, 11, 9)]
    AyyashSalim,

    /// <summary>
    /// Killed by the IDF while hiding in a school in Gaza, according to the IDF.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.GazaCity, HamasMilitaryBattalion.Radwan)]
    [HamasMostWanted(StandardPlayingCard.DiamondsFive)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2024, 8)]
    [DeathDateReportedByIDF(2024, 8, 5)]
    AzizJaber,

    /// <summary>
    /// Chief of Staff of Iran's Armed Forces
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    BagheriMohammad,

    /// <summary>
    /// Commander of Hezbollah's aerial forces
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2024, 1, 9)]
    BarjiAliHussein,

    /// <summary>
    /// Killed by the IDF, according to the IDF.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantSpecialtyHeadDeputy(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam, PalestinianMilitantSpecialty.Intelligence)]
    [HamasMostWanted(StandardPlayingCard.ClubsEight)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10)]
    [DeathDateReportedByIDF(2023, 10, 26)]
    BaroudShadi,

    /// <summary>
    /// Hamas commander of Central Jabaliya
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.SpadesSix)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaJabalia)]
    [DeathDate(2023, 10, 31)]
    BiariIbrahim,

    /// <summary>
    /// Killed in IDF airstrikes on Gaza.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.GazaCity, HamasMilitaryBattalion.SabraTalAlIslam)]
    [HamasMostWanted(StandardPlayingCard.ClubsFour)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 11)]
    [DeathDateReported(2023, 11, 3)]
    DalulMustafa,

    /// <summary>
    /// Senior Hezbollah commander. Killed in southern Lebanon.
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [AssassinationAttempt(2024, 11, 9, CountryLikeThings.Syria)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2026, 6, 12)]
    DaqduqAliMusa,

    /// <summary>
    /// Head of Hamas's Shura Council. Reported (unconfirmed) target of the Doha strike.
    /// </summary>
    [Country(CountryLikeThings.PalestineUnited)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [AssassinationAttempt(2025, 9, 9, CountryLikeThings.Qatar, WorldCities.QatarDoha)]
    [SurvivedTheEndOfNetanyahusPostOctober7AttacksTerm]
    DarwishMuhammadIsmail,

    /// <summary>
    /// Killed in an airstrike on the family home of <see cref="SalamaRafa"/> in al-Mawasi, a camp for displaced people near Khan Yunis,
    /// which also killed Salama and at least 90 others. Hamas denied his death for over six months before confirming it on 2025-01-30.
    /// One of the planners of the October 7 attacks. Survived at least seven earlier Israeli assassination attempts since 2001;
    /// his wife, infant son and three-year-old daughter were killed in an Israeli airstrike in 2014.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam)]
    [HamasMostWanted(StandardPlayingCard.Joker1)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
    [DeathDate(2024, 7, 13)]
    DeifMohammed,

    /// <summary>
    /// Spelled "Ayman Atsalih" in IDF reports. Killed in Israeli airstrikes in
    /// the days after Israel ended the January 2025 ceasefire, in the same strikes as <see cref="JahjouhRashid"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasGeneralSecurity("Head in Khan Yunis")]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2025, 3)]
    [DeathDateReportedByIDF(2025, 3, 20)]
    EslaiahAmin,

    /// <summary>
    /// Killed in an IDF airstrike. The IDF said his battalion led the October 7 attack on Nahal Oz, and blamed him for a 2014
    /// incident in Shuja'iyya in which seven IDF soldiers were killed, including <see cref="HostageList.ShaulOron"/>. Son of Umm Nidal; three of his brothers
    /// were also killed for their Hamas activities.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.GazaCity, HamasMilitaryBattalion.Shujaiyya)]
    [HamasMostWanted(StandardPlayingCard.ClubsSix)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 12, 2)]
    FarhatWissam,

    /// <summary>
    /// Killed in an IDF airstrike together with his deputy <see cref="RajebWael"/>. Three Israeli hostages were also killed in the attack:
    /// <see cref="HostageList.ToledanoElia"/>, <see cref="HostageList.BeizerNik"/> and <see cref="HostageList.ShermanRon"/>.
    /// A close confidant of <see cref="DeifMohammed"/>; survived earlier Israeli assassination attempts in 2002 and 2012, and helped lead
    /// the 2006 raid in which Israeli soldier <see cref="PriorTo2023October7thHostageList.ShalitGilad"/> was abducted.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.NorthernGaza)]
    [HamasMostWanted(StandardPlayingCard.HeartsJack)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2023, 11, 10)]
    GhandourAhmed,

    /// <summary>
    /// Commander of the IRGC Aerospace Force
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    HajizadehAmirAli,

    /// <summary>
    /// Hamas commander
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2023, 11, 10)]
    HalifaFarsan,

    /// <summary>
    /// Killed with his bodyguard in his room at an IRGC-run guesthouse in Tehran, after attending the inauguration of Iranian
    /// president Masoud Pezeshkian. Accounts differ on whether a missile or an explosive device hidden in the room killed him; Iran's
    /// investigation led to more than two dozen arrests. The highest-ranking Hamas political leader killed in the war; formerly prime
    /// minister of the Palestinian Authority and Hamas chief in Gaza.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Chairman")]
    [HamasMostWanted(StandardPlayingCard.DiamondsAce)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2024, 7, 31)]
    HaniyehIsmail,

    /// <summary>
    /// Commander of Hezbollah's intelligence headquarters
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 10, 3)]
    HazimaAliHussein,

    /// <summary>
    /// Weapons dealer, financier and coordinator of attacks in Israel, and active in Hamas's naval operations. Killed by the IDF
    /// under Shin Bet guidance, according to the IDF and Shin Bet, who announced his death in the same statement as
    /// that of <see cref="AlwadiaMohammed"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10)]
    [DeathDateReportedByIDF(2023, 10, 18)]
    HijaziAkram,

    /// <summary>
    /// Killed in an Israeli airstrike in Nuseirat in central Gaza. Second-in-command to <see cref="DeifMohammed"/> and closely
    /// involved in planning the October 7 attacks; one of Israel's three most wanted Hamas militants with Deif and
    /// <see cref="SinwarYahya"/>. Survived earlier Israeli assassination attempts: seriously wounded in a 2006 strike on a meeting
    /// also attended by Deif, and his house was destroyed in 2014 and again in 2021, killing his brother. A son was killed in an
    /// Israeli airstrike in central Gaza in December 2023.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommanderDeputy(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam)]
    [HamasMostWanted(StandardPlayingCard.ClubsAce)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2024, 3, 10)]
    IssaMarwan,

    /// <summary>
    /// Iranian officer who headed the Palestine branch of the Quds Force, the foreign operations arm of the IRGC.
    /// Not a member of Hamas: he was Iran's liaison to it and to other Palestinian militant groups, responsible for
    /// Iranian funding and arming of them. Israel described him as one of the planners of the 2023-10-07 attacks.
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranQom)]
    [DeathDate(2025, 6, 21)]
    IzadiSaeed,

    /// <summary>
    /// Chairman of SPND (defensive innovation and research)
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    JabalAmelianHossein,

    /// <summary>
    /// Hamas leader. Reported (unconfirmed) target of the Doha strike.
    /// </summary>
    [Country(CountryLikeThings.PalestineWestBank)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Member")]
    [HamasMostWanted(StandardPlayingCard.ClubsSeven)]
    [AssassinationAttempt(2025, 9, 9, CountryLikeThings.Qatar, WorldCities.QatarDoha)]
    [SurvivedTheEndOfNetanyahusPostOctober7AttacksTerm]
    JabarinZaher,

    /// <summary>
    /// The IDF said he headed the General Security apparatus, while other reports called it the internal security agency.
    /// Succeeded <see cref="OdehSami"/>. Killed in Israeli airstrikes in the days after Israel ended the January 2025 ceasefire,
    /// together with <see cref="EslaiahAmin"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasSecurity("Head in Gaza")]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2025, 3)]
    [DeathDateReportedByIDF(2025, 3, 20)]
    JahjouhRashid,

    /// <summary>
    /// Commander of Hezbollah's Southern Front
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 27)]
    KarakiAli,

    /// <summary>
    /// Head of the IRGC Intelligence Organization
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 15)]
    KazemiMohammad,

    /// <summary>
    /// Head of IRGC intelligence
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 4, 6)]
    KhademiMajid,

    /// <summary>
    /// Killed on the first day of the 2026 Iran war, in a joint Israeli and United States operation that used CIA intelligence
    /// on his movements. Israeli jets hit his Tehran compound in daylight with about thirty precision munitions, timed to a
    /// meeting of senior officials that drew him above ground from his deep bunker. His daughter, granddaughter, son-in-law
    /// and daughter-in-law were also killed. Iran confirmed his death the next day, after first denying it.
    /// An Israeli plan to kill him during the Twelve-Day War in June 2025 was reportedly vetoed by <see cref="UnitedStatesPoliticians.TrumpDonald"/>.
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [EthnicGroups((int)WorldEthnicGroups.Azerbaijani, (int)WorldEthnicGroups.Persian)]
    [HumanOccupation(HumanOccupation.LeaderOfCountrySupreme, CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    KhameneiAli,

    /// <summary>
    /// Head of Iran's Strategic Council on Foreign Relations and former foreign minister. Seriously wounded when a targeted
    /// United States and Israeli airstrike hit his home in Tehran, which killed his wife; died of his wounds several days later.
    /// The attack date is the date the strike was first reported.
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran, 2026, 4, 1)]
    [DeathDate(2026, 4, 9)]
    KharaziKamal,

    /// <summary>
    /// Minister of Intelligence
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [EthnicGroup(WorldEthnicGroups.Persian)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 3, 18)]
    KhatibEsmaeil,

    /// <summary>
    /// Secretary of Iran's Supreme National Security Council
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 3, 17)]
    LarijaniAli,

    /// <summary>
    /// Killed in an overnight IDF strike
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.KhanYunis, HamasMilitaryBattalion.KhanYunisWest)]
    [HamasMostWanted(StandardPlayingCard.SpadesTwo)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10)]
    [DeathDateReported(2023, 10, 27, Overnight: true)]
    MabasherMadhat,

    /// <summary>
    /// Killed in an IDF airstrike. Previously commanded Hamas's naval force (<see cref="PalestinianMilitantSpecialty.Naval"/>).
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.KhanYunis, HamasMilitaryBattalion.KhanYunisNorth)]
    [HamasMostWanted(StandardPlayingCard.SpadesFour)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10)]
    [DeathDateReported(2023, 10, 25)]
    MabasherTaysir,

    /// <summary>
    /// Former Hamas Political Bureau chairman. Reported (unconfirmed) target of the Doha strike.
    /// 1997: Mossad agents, acting on the orders of <see cref="IsraeliPoliticians.NetanyahuBenjamin"/>
    /// and travelling on fake Canadian passports, poisoned him outside
    /// the Hamas office in Amman. Two agents were captured and he fell into a coma; he survived after King Hussein of Jordan,
    /// backed by <see cref="UnitedStatesPoliticians.ClintonBill"/>, forced Israel to hand over the antidote. Israel also released <see cref="YassinAhmed"/> to get the
    /// rest of the team back.
    /// </summary>
    [Countries(CountryLikeThings.PalestineWestBank, CountryLikeThings.Jordan)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Former Chairman")]
    [HamasMostWanted(StandardPlayingCard.HeartsAce)]
    [AttemptedAssassinationPriorToOctober7(1997, 9, 25, CountryLikeThings.Jordan, WorldCities.JordanAmman)]
    [AssassinationAttempt(2025, 9, 9, CountryLikeThings.Qatar, WorldCities.QatarDoha)]
    [SurvivedTheEndOfNetanyahusPostOctober7AttacksTerm]
    MashalKhaled,

    /// <summary>
    /// Deputy head of intelligence, Armed Forces General Staff
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    MehrabiGholamreza,

    /// <summary>
    /// Commander of the Quds Force's Unit 840
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 4, 6)]
    MirYazdan,

    /// <summary>
    /// Deputy head of the IRGC Intelligence Organization
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 15)]
    MohagheghHassan,

    /// <summary>
    /// Chief of Staff of Iran's Armed Forces (succeeded Bagheri)
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    MousaviAbdolrahim,

    /// <summary>
    /// IRGC Quds Force commander
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Syria, WorldCities.SyriaDamascus)]
    [DeathDate(2023, 12, 25)]
    MousaviRazi,

    /// <summary>
    /// Former chairman of SPND
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    MozaffariNiaReza,

    /// <summary>
    /// Chairman of the economic committee
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.ClubsKing)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2024, 7)]
    [DeathDateReportedByIDF(2024, 10, 3)]
    MushtahaRawhi,

    /// <summary>
    /// IRGC spokesperson
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 3, 20)]
    NainiAliMohammad,

    /// <summary>
    /// Minister of Defense
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    NasirzadehAziz,

    /// <summary>
    /// Secretary-General of Hezbollah
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 27)]
    NasrallahHassan,

    /// <summary>
    /// Commander of Hezbollah's Aziz unit
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2024, 7, 3)]
    NasserMohammedNehme,

    /// <summary>
    /// Quds Force commander in Lebanon
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [EthnicGroup(WorldEthnicGroups.Persian)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 27)]
    NilforoushanAbbas,

    /// <summary>
    /// Killed in an airstrike that destroyed four multi-story apartment buildings; Hamas confirmed his death the same day. An unnamed
    /// Israeli military source said the military knowingly authorized a strike it expected to kill about 300 other people.
    /// Also head of air operations and a member of the Qassam Brigades' General Military Council.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.CentralCamps)]
    [PalestinianMilitantSpecialtyHead(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam, PalestinianMilitantSpecialty.Aerial)]
    [HamasMostWanted(StandardPlayingCard.ClubsJack)]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2023, 10, 17)]
    NofalAyman,

    /// <summary>
    /// Hamas leader in Gaza and Al-Qassam Brigades commander
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam)]
    [HamasMostWanted(StandardPlayingCard.HeartsTen)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2026, 5, 26)]
    OdehMohammed,

    /// <summary>
    /// Killed in a joint IDF and
    /// Shin Bet strike in northern Gaza together with <see cref="MushtahaRawhi"/> and <see cref="AlSarrajSameh"/>.
    /// Succeeded by <see cref="JahjouhRashid"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasGeneralSecurity("Head in Gaza")]
    [Assassinated(CountryLikeThings.PalestineGaza)]
    [DeathDate(2024, 7)]
    [DeathDateReportedByIDF(2024, 10, 3)]
    OdehSami,

    /// <summary>
    /// Head of Quds Force intelligence in Syria
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Syria, WorldCities.SyriaDamascus)]
    [DeathDate(2024, 1, 20)]
    OmidzadehSadegh,

    /// <summary>
    /// Commander-in-Chief of the IRGC
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    PakpourMohammad,

    /// <summary>
    /// Deputy head of Hezbollah's Executive Council
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 28)]
    QaoukNabil,

    /// <summary>
    /// Killed in the strike on the tunnel complex under the European Hospital in Khan Yunis that also killed
    /// <see cref="SinwarMohammed"/> and <see cref="ShabanaMuhammad"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.KhanYunis, HamasMilitaryBattalion.KhanYunisSouth)]
    [HamasMostWanted(StandardPlayingCard.ClubsTwo)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
    [DeathDate(2025, 5, 13)]
    QuaraMahdi,

    /// <summary>
    /// Commander of Hezbollah's missile and rocket unit
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 24)]
    QubaisiIbrahim,

    /// <summary>
    /// Deputy head of operations, Armed Forces General Staff
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    RabbaniMehdi,

    /// <summary>
    /// Killed in the IDF airstrike that also killed his commander <see cref="GhandourAhmed"/>, along with three Israeli hostages:
    /// <see cref="HostageList.ToledanoElia"/>, <see cref="HostageList.BeizerNik"/> and <see cref="HostageList.ShermanRon"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommanderDeputy(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.NorthernGaza)]
    [HamasMostWanted(StandardPlayingCard.DiamondsSix)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2023, 11, 10)]
    RajebWael,

    /// <summary>
    /// Commander of Khatam al-Anbiya Central Headquarters
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    RashidGholamAli,

    /// <summary>
    /// Head of IRGC Navy intelligence
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranBandarAbbas)]
    [DeathDate(2026, 3, 26)]
    RezaeiBehnam,

    /// <summary>
    /// Killed in an Israeli drone strike on his car on Al-Rashid road west of Gaza City, which killed five people including his aide.
    /// <see cref="IsraeliPoliticians.NetanyahuBenjamin"/> and <see cref="IsraeliPoliticians.KatzIsrael"/> called it a response to an explosion that injured two IDF soldiers in southern Gaza, and called him an
    /// architect of the October 7 attacks. Survived an earlier strike targeting him in the Al-Shati camp on 2024-06-22.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantSpecialtyHead(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam, PalestinianMilitantSpecialty.Production)]
    [HamasMostWanted(StandardPlayingCard.HeartsFour)]
    [AssassinationAttempt(2024, 6, 22, CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2025, 12, 13)]
    SaadRaad,

    /// <summary>
    /// Head of Hezbollah's Executive Council
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 10, 3)]
    SafieddineHashem,

    /// <summary>
    /// Killed when Israel bombed his family home in al-Mawasi, a camp for displaced people near Khan Yunis, in the strike that also
    /// killed <see cref="DeifMohammed"/> and at least 90 others. Hamas called the claims that its leaders were targeted false allegations.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.KhanYunis)]
    [HamasMostWanted(StandardPlayingCard.DiamondsJack)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
    [DeathDate(2024, 7, 13)]
    SalamaRafa,

    /// <summary>
    /// Commander-in-Chief of the IRGC
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [EthnicGroup(WorldEthnicGroups.Persian)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    SalamiHossein,

    /// <summary>
    /// Hamas commander
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2023, 11, 10)]
    SalmanRafet,

    /// <summary>
    /// Killed with <see cref="SinwarMohammed"/> and <see cref="QuaraMahdi"/> in the strike on a tunnel under the European Hospital
    /// in Khan Yunis, which killed 26 people according to the Gaza Health Ministry; his body was reportedly recovered from the tunnel
    /// with Sinwar's. The IDF confirmed his death on 2025-05-31 and Hamas on 2025-12-29.
    /// According to Palestinian reports he survived two earlier attempts: a strike on his family home in eastern Rafah on 2023-12-20,
    /// and a strike on a tunnel complex where he was believed to be hiding on 2024-05-24. Two of his sons were killed in the first days
    /// of the war and a third in fighting in Rafah in 2024.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.Rafah)]
    [HamasMostWanted(StandardPlayingCard.HeartsSix)]
    [AssassinationAttempt(2023, 12, 20, CountryLikeThings.PalestineGaza, WorldCities.GazaRafah)]
    [AssassinationAttempt(2024, 5, 24, CountryLikeThings.PalestineGaza)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
    [DeathDate(2025, 5, 13)]
    ShabanaMuhammad,

    /// <summary>
    /// Commander of Khatam al-Anbiya Central Headquarters
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 17)]
    ShadmaniAli,

    /// <summary>
    /// Hamas head of operations in Lebanon
    /// </summary>
    [Country(CountryLikeThings.PalestineUnited)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonSidon)]
    [DeathDate(2025, 2, 18)]
    ShaheenMuhammad,

    /// <summary>
    /// Nuclear engineer at Shahid Beheshti University. Killed in Tehran when men on a motorbike attached a bomb to his car
    /// as he drove to work, the same day as the failed attempt on <see cref="AbbasiFereydoon"/>. Widely attributed to Israel,
    /// which never claimed it.
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [HumanOccupation(HumanOccupation.ScientistNuclear)]
    [AssassinatedPriorToOctober7(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2010, 11, 29)]
    ShahriariMajid,

    /// <summary>
    /// Senior IRGC official (Unit 190)
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranQom)]
    [DeathDate(2025, 6, 21)]
    ShahriyariBehnam,

    /// <summary>
    /// Killed in IDF airstrikes on Gaza that also killed a Hamas battalion commander, according to the IDF,
    /// days after Israel resumed fighting on 2025-03-18 and ended the January 2025 ceasefire.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommanderDeputy(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.GazaCity)]
    [HamasMostWanted(StandardPlayingCard.SpadesEight)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2025, 3)]
    [DeathDateReportedByIDF(2025, 3, 23)]
    ShamaliAhmed,

    /// <summary>
    /// Adviser to Khamenei and Secretary of the Defense Council
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [AssassinationAttempt(2025, 6, 13, CountryLikeThings.Iran, WorldCities.IranTehran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    ShamkhaniAli,

    /// <summary>
    /// Hamas commander in Lebanon
    /// </summary>
    [Country(CountryLikeThings.PalestineUnited)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 29)]
    SharifFatah,

    /// <summary>
    /// Chief of Khamenei's military bureau
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 2, 28)]
    ShiraziMohammad,

    /// <summary>
    /// Head of Hezbollah's Strategic Unit
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 7, 30)]
    ShukrFuad,

    /// <summary>
    /// Commander in the Al-Qassam Brigades
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.DiamondsSeven)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2024, 8)]
    SiamAbdAlHadi,

    /// <summary>
    /// Killed in an Israeli airstrike in Gaza City. Hamas confirmed his death on 2023-11-26, together with those of
    /// <see cref="GhandourAhmed"/>, <see cref="HalifaFarsan"/> and <see cref="RajebWael"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantSpecialtyHead(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam, PalestinianMilitantSpecialty.Rockets)]
    [HamasMostWanted(StandardPlayingCard.DiamondsQueen)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2023, 11, 10)]
    SiamAyman,

    /// <summary>
    /// Hamas leader in Gaza and Al-Qassam Brigades commander
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.AlQassam)]
    [HamasMostWanted(StandardPlayingCard.SpadesJack)]
    [Assassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaKhanYunis)]
    [DeathDate(2025, 5, 13)]
    SinwarMohammed,

    /// <summary>
    /// Hamas leader and Israel's most-wanted target. Killed in a chance encounter with IDF troops rather than a planned strike.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Chairman")]
    [HamasMostWanted(StandardPlayingCard.HeartsQueen)]
    [AssassinatedButNotActuallyAssassinated(CountryLikeThings.PalestineGaza, WorldCities.GazaRafah)]
    [DeathDate(2024, 10, 16)]
    SinwarYahya,

    /// <summary>
    /// Killed with his deputy in an IDF strike. The IDF said his battalion led the October 7 attack on <see cref="IsraeliKibbutz.Beeri"/>.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantCommander(PalestinianMilitantGroups.Hamas, PalestinianGazaMilitaryBrigade.CentralCamps, HamasMilitaryBattalion.Nuseirat)]
    [HamasMostWanted(StandardPlayingCard.DiamondsThree)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2024, 1)]
    [DeathDateReportedByIDF(2024, 1, 6)]
    SirajIsmail,

    /// <summary>
    /// Commander of the Basij
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2026, 3, 17)]
    SoleimaniGholamreza,

    /// <summary>
    /// Hamas financier. Not a member of Hamas: a Lebanese money changer who moved funds to Hamas.
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon)]
    [DeathDate(2024, 4, 9)]
    SrourMohammad,

    /// <summary>
    /// Commander of Hezbollah's drone unit
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 26)]
    SrourMuhammadHussein,

    /// <summary>
    /// Senior Hezbollah commander and chief of staff to Naim Qassem
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2025, 11, 23)]
    TabatabaiHaythamAli,

    /// <summary>
    /// Commander of the IRGC Navy
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [EthnicGroup(WorldEthnicGroups.Persian)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranBandarAbbas)]
    [DeathDate(2026, 3, 26)]
    TangsiriAlireza,

    /// <summary>
    /// Killed in the Israeli strikes on Iran's nuclear program on the first day of the Twelve-Day War, in the same opening wave
    /// as <see cref="AbbasiFereydoon"/>. Theoretical physicist and president of the Islamic Azad University.
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [HumanOccupation(HumanOccupation.ScientistNuclear)]
    [Assassinated(CountryLikeThings.Iran, WorldCities.IranTehran)]
    [DeathDate(2025, 6, 13)]
    TehranchiMohammadMehdi,

    /// <summary>
    /// Killed during the IDF raid on Al-Shifa Hospital in Gaza City, according to the IDF.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Member")]
    [HamasMostWanted(StandardPlayingCard.HeartsThree)]
    [KilledButMayHaveBeenWarOrAssassinationCasualty(CountryLikeThings.PalestineGaza)]
    [DeathDate(2024, 3)]
    [DeathDateReportedByIDF(2024, 3, 28)]
    ThabatRaad,

    /// <summary>
    /// Head of Hezbollah Radwan Force training
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBeirut)]
    [DeathDate(2024, 9, 20)]
    WahbiAhmed,

    /// <summary>
    /// Senior Hezbollah commander
    /// </summary>
    [Country(CountryLikeThings.Lebanon)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [Assassinated(CountryLikeThings.Lebanon, WorldCities.LebanonBaalbek)]
    [DeathDate(2026, 2, 20)]
    YaghiHussein,

    /// <summary>
    /// Founder and spiritual leader of Hamas; quadriplegic and nearly blind. Assassinated before the 2023-10-07 attacks:
    /// killed by an Israeli helicopter missile strike while leaving dawn prayers. Released from Israeli prison in 1997
    /// as part of the fallout from the attempt on <see cref="MashalKhaled"/>.
    /// 2003: lightly wounded when an Israeli F-16 bombed a building in Gaza City where Hamas leaders were meeting.
    /// </summary>
    [Country(CountryLikeThings.PalestineGaza)]
    [EthnicGroup(WorldEthnicGroups.Arab)]
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [AttemptedAssassinationPriorToOctober7(2003, 9, 6, CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [AssassinatedPriorToOctober7(CountryLikeThings.PalestineGaza, WorldCities.GazaGazaCity)]
    [DeathDate(2004, 3, 22)]
    YassinAhmed,

    /// <summary>
    /// Quds Force commander in Lebanon and Syria
    /// </summary>
    [Country(CountryLikeThings.Iran)]
    [EthnicGroup(WorldEthnicGroups.Persian)]
    [Assassinated(CountryLikeThings.Syria, WorldCities.SyriaDamascus)]
    [DeathDate(2024, 4, 1)]
    ZahediMohammadReza,
}

/// <summary>
/// Hamas members on the unofficial IDF "most wanted" playing card deck who are not on the <see cref="IsraeliAssassinationTarget"/> list:
/// those who are alive or whose fate is unconfirmed
/// </summary>
/// <remarks>
/// source: https://en.wikipedia.org/wiki/Hamas_most_wanted_playing_cards (card list and status as of November 2026).
/// Members of the deck who were killed during the war are on the <see cref="IsraeliAssassinationTarget"/> list, marked with
/// <see cref="KilledButMayHaveBeenWarOrAssassinationCasualtyAttribute"/> where it is not known whether the death was an assassination.
/// </remarks>
internal enum IsraeliHamasMostWantedTargets
{
    /// <summary>
    /// Deputy health minister
    /// </summary>
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.SpadesTen)]
    AbuAlRishYoussef,

    /// <summary>
    /// Head of the international relations office
    /// </summary>
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Member")]
    [HamasMostWanted(StandardPlayingCard.DiamondsEight)]
    AbuMarzookMousa,

    /// <summary>
    /// Member of the Hamas Political Bureau
    /// </summary>
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Member")]
    [HamasMostWanted(StandardPlayingCard.HeartsNine)]
    AlZaharMahmoud,

    /// <summary>
    /// Head of the rear headquarters
    /// </summary>
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.SpadesSeven)]
    AqelImad,

    /// <summary>
    /// Senior member of the Hamas Political Bureau
    /// </summary>
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Senior Member")]
    [HamasMostWanted(StandardPlayingCard.HeartsTwo)]
    AwadallahNizar,

    /// <summary>
    /// Member of the Executive Committee
    /// </summary>
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.HeartsFive, "spelled \"Hassam\" on the card list")]
    BadranHossam,

    /// <summary>
    /// Commander in the Al-Qassam Brigades
    /// </summary>
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.ClubsTen)]
    BaroudFaez,

    /// <summary>
    /// Head of office in the Executive Committee
    /// </summary>
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.DiamondsFour)]
    HamadFathi,

    /// <summary>
    /// Member of Hamas's Political Bureau
    /// </summary>
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasPoliticalBureau("Member")]
    [HamasMostWanted(StandardPlayingCard.ClubsThree)]
    HamadGhazi,

    /// <summary>
    /// Foreign relations officer
    /// </summary>
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.DiamondsTen)]
    HamdanOsama,

    /// <summary>
    /// Commander of the Shati Battalion (Al-Qassam Brigades).
    /// The IDF claimed it killed him in December 2023 but retracted the claim in February 2025.
    /// </summary>
    [PalestinianMilitantGroup(PalestinianMilitantGroups.Hamas)]
    [HamasMostWanted(StandardPlayingCard.HeartsSeven)]
    [UnclearIfStillAlive]
    KhuwajariHaitham,
}