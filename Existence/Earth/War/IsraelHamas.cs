
using Existence.Earth.Alphabet;
using Existence.Earth.Countries;
using Existence.Earth.FieldsOfStudy.Mathematics;
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
        RecoveredBody,
        RecoveredBodyKilledByIsrael,
        RescuedAlive,
    }

    /// <summary>
    /// https://www.israelhayom.com/2023/10/31/these-are-the-captives-held-by-hamas/
    /// </summary>
    public enum HostageList
    {
        /// <summary>
        /// released (85 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        AdarYafa = 1,
        /// <summary>
        /// Staff Sergeant, body recovered (20 yr)
        /// </summary>
        AhimasTomerYaakov = 2,
        /// <summary>
        /// released (45 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        AloniDaniel = 3,
        /// <summary>
        /// released (5 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        AloniEmelia = 4,
        /// <summary>
        /// released, held by Hamas prior to 2023-10-7 (36 yr)
        /// </summary>
        AlSayedHishamShaaban = 5,
        /// <summary>
        /// body recovered (22 yr)
        /// </summary>
        AlZayadniHamzah = 6,
        /// <summary>
        /// body recovered (53 yr)
        /// </summary>
        AlZayadniYosef = 7,
        /// <summary>
        /// released (19 yr)
        /// </summary>
        AlbagLiri = 8,

        /// <summary>
        /// 18 yr
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        AlexanderEdan = 9,

        /// <summary>
        /// rescued (53 yr)
        /// </summary>
        AlkadiQaidFarhan = 10,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        AngkaewAnucha = 11,

        /// <summary>
        /// 32 yr
        /// </summary>
        [TODO("")]
        AngrestMatan = 12,

        /// <summary>
        /// rescued (26 yr)
        /// </summary>
        ArgamaniNoa = 13,
        /// <summary>
        /// released (20 yr)
        /// </summary>
        ArievKarina = 14,
        /// <summary>
        /// released (2 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        AsherAviv = 15,
        /// <summary>
        /// released (34 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        AsherDoronKatz = 16,
        /// <summary>
        /// released (4 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        AsherRaz = 17,
        /// <summary>
        /// released
        /// </summary>
        AvigdoriNoam = 18,
        /// <summary>
        /// released
        /// </summary>
        AvigdoriSharon = 19,
        /// <summary>
        /// released
        /// </summary>
        AvrihamElma = 20,
        /// <summary>
        /// released
        /// </summary>
        BabadillaNoralin = 21,
        /// <summary>
        /// released
        /// </summary>
        BeininLiat = 22,
        /// <summary>
        /// body recovered, killed in IDF airstrike (Corporal)
        /// </summary>
        BeizerNik = 23,
        /// <summary>
        /// released (56 yr)
        /// </summary>
        BenAmiOhad = 24,
        /// <summary>
        /// released
        /// </summary>
        BenAmiRaz = 25,
        /// <summary>
        /// body recovered (53 yr)
        /// </summary>
        BenjaminRon = 26,
        /// <summary>
        /// released (20 yr)
        /// </summary>
        BergerAgam = 27,

        /// <summary>
        /// 26 yr
        /// </summary>
        [TODO("")]
        BermanGali = 28,

        /// <summary>
        /// 26 yr
        /// </summary>
        [TODO("")]
        BermanZiv = 29,

        /// <summary>
        /// released body (4 yr)
        /// </summary>
        BibasAriel = 30,
        /// <summary>
        /// released body (9 mo)
        /// </summary>
        BibasKfir = 31,
        /// <summary>
        /// released body (32 yr)
        /// </summary>
        BibasShiri = 32,
        /// <summary>
        /// released (35 yr)
        /// </summary>
        BibasYarden = 33,

        /// <summary>
        /// 34 yr
        /// </summary>
        [TODO("")]
        BohbotElkana = 34,

        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        BoonpromSanti = 35,

        [TODO("")]
        BraslavskiRom = 36,

        /// <summary>
        /// Sergeant, body recovered (19 yr)
        /// </summary>
        BrodskiKiril = 37,
        /// <summary>
        /// released
        /// </summary>
        BrodutchHagar = 38,
        /// <summary>
        /// released
        /// </summary>
        BrodutchOfri = 39,
        /// <summary>
        /// released
        /// </summary>
        BrodutchUriah = 40,
        /// <summary>
        /// released
        /// </summary>
        BrodutchYuval = 41,
        /// <summary>
        /// released
        /// </summary>
        BuchshtavRimonKirsht = 42,
        /// <summary>
        /// body recovered (Buckshtav?) (34 yr)
        /// </summary>
        BuchshtabYagev = 43,
        /// <summary>
        /// body recovered (28 yr)
        /// </summary>
        BuskilaEstherAmit = 44,
        /// <summary>
        /// released
        /// </summary>
        ChombuaKomkrit = 45,
        /// <summary>
        /// released (27 yr)
        /// </summary>
        CohenEliya = 46,

        /// <summary>
        /// 19 yr
        /// </summary>
        [TODO("")]
        CohenNimrod = 47,

        /// <summary>
        /// released (girlfriend of Alexandre (Sasha) Troufanov)
        /// </summary>
        CohenSapir = 48,

        /// <summary>
        /// 84 yr
        /// </summary>
        [TODO("")]
        CooperAmiram = 49,

        /// <summary>
        /// 26 yr
        /// </summary>
        [TODO("")]
        CunioAriel = 50,

        /// <summary>
        /// 33 yr
        /// </summary>
        [TODO("")]
        CunioDavid = 51,

        /// <summary>
        /// released? cunio?
        /// </summary>
        CunionEmma = 52,
        /// <summary>
        /// released
        /// </summary>
        CunioSharonOlani = 53,
        /// <summary>
        /// released
        /// </summary>
        CunioYuli = 54,
        /// <summary>
        /// body recovered, staff sergeant major
        /// </summary>
        DadoZiv = 55,
        /// <summary>
        /// released (28 yr)
        /// </summary>
        DamariEmily = 56,
        /// <summary>
        /// body recovered (75 yr)
        /// </summary>
        DancygAlexander = 57,
        /// <summary>
        /// body recovered, executed by Hamas (24 yr)
        /// </summary>
        DaninoOri = 58,

        /// <summary>
        /// 23 yr
        /// </summary>
        [TODO("")]
        DavidEvyatar = 59,

        /// <summary>
        /// released (36 yr)
        /// </summary>
        DekelChenSagui = 60,
        /// <summary>
        /// released
        /// </summary>
        EdanAbigail = 61,
        /// <summary>
        /// body released (68 yr)
        /// </summary>
        ElgaratItzhk = 62,
        /// <summary>
        /// released
        /// </summary>
        ElyakimDafna = 63,
        /// <summary>
        /// released
        /// </summary>
        ElyakimEla = 64,
        /// <summary>
        /// released
        /// </summary>
        EngelBartKarina = 65,
        /// <summary>
        /// released
        /// </summary>
        EngelMika = 66,
        /// <summary>
        /// released
        /// </summary>
        EngelOfir = 67,
        /// <summary>
        /// released
        /// </summary>
        EngelYuval = 68,
        /// <summary>
        /// body recovered, executed by Hamas (39 yr)
        /// </summary>
        GatCarmel = 69,
        /// <summary>
        /// body recovered (56 yr)
        /// </summary>
        GelerenterItzhak = 70,
        /// <summary>
        /// released (20 yr)
        /// </summary>
        GilboaDaniella = 71, //(orignally named Danielle)

        /// <summary>
        /// 22 yr
        /// </summary>
        [TODO("")]
        GilboaDalalGuy = 72,

        /// <summary>
        /// body recovered, executed by Hamas (American) (23 yr)
        /// </summary>
        GoldbergPolinHersh = 73,

        /// <summary>
        /// 32 yr
        /// </summary>
        [TODO("")]
        GoldinHadar = 74,

        /// <summary>
        /// body recovered (33 yr)
        /// </summary>
        GoldinOren = 75,
        /// <summary>
        /// released
        /// </summary>
        GoldsteinAlmogAgam = 76,
        /// <summary>
        /// released
        /// </summary>
        GoldsteinAlmogChen = 77,
        /// <summary>
        /// released
        /// </summary>
        GoldsteinAlmogGal = 78,
        /// <summary>
        /// released
        /// </summary>
        GoldsteinAlmogTal = 79,
        /// <summary>
        /// released (24 yr)
        /// </summary>
        GonenRomi = 80,
        /// <summary>
        /// body recovered (56 yr)
        /// </summary>
        GorenMaya = 81,
        /// <summary>
        /// released
        /// </summary>
        GorenShani = 82,
        /// <summary>
        /// released
        /// </summary>
        GritzewskyIlana = 83,

        /// <summary>
        /// 24 yr
        /// </summary>
        [TODO("")]
        GviliRan = 84,

        /// <summary>
        /// 73 yr
        /// </summary>
        [TODO("")]
        HaggaiGad = 85,

        /// <summary>
        /// body recovered, killed by friendly fire while surrendering
        /// </summary>
        HaimYotam = 86,
        /// <summary>
        /// released
        /// </summary>
        HandEmily = 87,
        /// <summary>
        /// released
        /// </summary>
        HaranShoshan = 88,
        /// <summary>
        /// rescued (70 yr)
        /// </summary>
        HarLuis = 89,
        /// <summary>
        /// released
        /// </summary>
        HeimanDitza = 90,

        /// <summary>
        /// 35 yr
        /// </summary>
        [TODO("")]
        HerkinMaxim = 91,

        /// <summary>
        /// 30 yr
        /// </summary>
        [TODO("")]
        HernandezOryon = 92,

        /// <summary>
        /// 37 yr
        /// </summary>
        [TODO("")]
        HornEitan = 93,

        /// <summary>
        /// released (46 yr)
        /// </summary>
        HornIair = 94,
        /// <summary>
        /// body released (49 yr)
        /// </summary>
        IdanTsachi = 95,
        /// <summary>
        /// released
        /// </summary>
        JacobOr = 96,
        /// <summary>
        /// released
        /// </summary>
        JacobYagil = 97,
        /// <summary>
        /// released
        /// </summary>
        JirachartManee = 98,

        /// <summary>
        /// 23 yr
        /// </summary>
        [TODO("")]
        JoshiBipin = 99,

        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        KalapratVichai = 100,
        /// <summary>
        /// released
        /// </summary>
        KalderonErez = 101,
        /// <summary>
        /// released (54 yr)
        /// </summary>
        KalderonOfer = 102,
        /// <summary>
        /// released
        /// </summary>
        KalderonSahar = 103,

        /// <summary>
        /// 25 yr
        /// </summary>
        [TODO("")]
        KalfonSegev = 104,

        /// <summary>
        /// released (76 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        KatzirHannah = 105,
        /// <summary>
        /// body recovered
        /// </summary>
        KatznirElad = 106,
        /// <summary>
        /// body recovered (51 yr)
        /// </summary>
        KatzRavid = 107,
        /// <summary>
        /// released
        /// </summary>
        KesoognernSurin = 108,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        KongmaneeBancha = 109,
        /// <summary>
        /// rescued (27 yr)
        /// </summary>
        KozlovAndrey = 110,
        /// <summary>
        /// released
        /// </summary>
        KriboyRoni = 111,

        /// <summary>
        /// 22 yr
        /// </summary>
        [TODO("")]
        KupershteinBar = 112,

        /// <summary>
        /// released
        /// </summary>
        LeimbergGabriela = 113,
        /// <summary>
        /// released
        /// </summary>
        LeimbertMia = 114,
        /// <summary>
        /// released (20 yr)
        /// </summary>
        LevyNaama = 115,
        /// <summary>
        /// released (34 yr)
        /// </summary>
        LevyOr = 116,
        /// <summary>
        /// released body (84 yr)
        /// </summary>
        LifshitzOded = 117,
        /// <summary>
        /// released elderly Israli woman
        /// </summary>
        LifshitzYokheved = 118,
        /// <summary>
        /// body recovered, executed by Hamas (32 yr)
        /// </summary>
        LobanovAlexander = 119,
        /// <summary>
        /// body recovered
        /// </summary>
        LoukShani = 120,
        /// <summary>
        /// body released (85 yr)
        /// </summary>
        MansourShlomo = 121,
        /// <summary>
        /// recovered body (corporal)
        /// </summary>
        MarcianoNoa = 122,
        /// <summary>
        /// released
        /// </summary>
        MargalitNili = 123,
        /// <summary>
        /// rescued female Israeli soldier
        /// </summary>
        MegidishOri = 124,
        /// <summary>
        /// rescued (21 yr)
        /// </summary>
        MeirJanAlmog = 125,
        /// <summary>
        /// released (held by Hamas prior to 2023-10-7) (38 yr)
        /// </summary>
        MengistuAvera = 126,
        /// <summary>
        /// released
        /// </summary>
        MermanClara = 127,
        /// <summary>
        /// rescued (60 yr)
        /// </summary>
        MermanFernandoSimon = 128,
        /// <summary>
        /// released
        /// </summary>
        MetzgerTamar = 129,
        /// <summary>
        /// body recovered (80 yr)
        /// </summary>
        MetzgerYoram = 130,

        /// <summary>
        /// 46 yr
        /// </summary>
        [TODO("")]
        MiranOmri = 131,

        /// <summary>
        /// 23 yr
        /// </summary>
        [TODO("")]
        MorEitanAbraham = 132,

        /// <summary>
        /// released (72 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        MosheAdina = 133,
        /// <summary>
        /// released, 77-year-old member of Kibbutz Nir Or
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        MosesMargalit = 134,
        /// <summary>
        /// released (79 yr) [sometimes refered to as Gadi Moses]
        /// His partner, Efrat Katz was presumed captive as well, but was likely killed
        /// 2023-10-07 by an Israeli helicopter gunship responding to the assault. The
        /// helicopter targeted a vehicle carrying Hamas gunmen, unaware that hostages
        /// were also inside.
        /// </summary>
        MozesGadiMoshe = 135,
        /// <summary>
        /// body recovered (78 yr)
        /// </summary>
        MunderAbraham = 136,
        /// <summary>
        /// released (54 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        MunderKeren = 137,
        /// <summary>
        /// released (9 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        MunderOhad = 138,
        /// <summary>
        /// released (78 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        MunderRuth = 139,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        MunkanNattawaree = 140,

        /// <summary>
        /// 22 yr
        /// </summary>
        [TODO("")]
        NeutraOmer = 141,

        /// <summary>
        /// 19 yr
        /// </summary>
        [TODO("")]
        NimrodTamir = 142,

        /// <summary>
        /// rescued (59 yr)
        /// </summary>
        NisenbaumMichel = 143,

        /// <summary>
        /// 23 yr
        /// </summary>
        [TODO("")]
        OhanaYosef = 144,

        /// <summary>
        /// 22 yr
        /// </summary>
        [TODO("")]
        OhelAlon = 145,

        /// <summary>
        /// released
        /// </summary>
        OnkaewNatthaporn = 146,
        /// <summary>
        /// released
        /// </summary>
        OrAlma = 147,

        /// <summary>
        /// 30 yr
        /// </summary>
        [TODO("")]
        OrAvinathan = 148,

        /// <summary>
        /// 48 yr
        /// </summary>
        [TODO("")]
        OrDror = 149,

        /// <summary>
        /// released
        /// </summary>
        OrLiam = 150,
        /// <summary>
        /// released
        /// </summary>
        OrNoam = 151,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Philippines)]
        PachecoGelienorJimmy = 152,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        PankhongBoonthom = 153,
        /// <summary>
        /// body recovered (79 yr)
        /// </summary>
        PeriChaim = 154,
        /// <summary>
        /// released (79 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        PeriChanna = 155,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        PhachuabboonMongkol = 156,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        PhoomeVetoon = 157,
        /// <summary>
        /// released
        /// </summary>
        PinakalowPornsawan = 158,
        /// <summary>
        /// body recovered (51 yr)
        /// </summary>
        PopplewellNadav = 159,
        /// <summary>
        /// Israeli-American, released
        /// </summary>
        RaananJudith = 160,
        /// <summary>
        /// Israeli-American, released
        /// </summary>
        RaananNatalie = 161,
        /// <summary>
        /// rescued (30 yr)
        /// </summary>
        RadouxOriónHernández = 162,
        /// <summary>
        /// released
        /// </summary>
        RataninPaiboon = 163,
        /// <summary>
        /// released
        /// </summary>
        RegevItay = 164,
        /// <summary>
        /// released
        /// </summary>
        RegevMaya = 165,
        /// <summary>
        /// released
        /// </summary>
        RoitmanOfelia = 166,
        /// <summary>
        /// released
        /// </summary>
        RomanGatYarden = 167,
        /// <summary>
        /// released (32 yr)
        /// </summary>
        RumnaoSurasak = 168,
        /// <summary>
        /// released
        /// </summary>
        RotemRaaya = 169,

        /// <summary>
        /// 61 yr
        /// </summary>
        [TODO("")]
        RudaeffLior = 170,

        /// <summary>
        /// released
        /// </summary>
        SaelaoKong = 171,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        SaengboonBuddhee = 172,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        SaengnuanUthai = 173,
        /// <summary>
        /// released (27 yr)
        /// </summary>
        SaethaoBannawat = 174,
        /// <summary>
        /// released
        /// </summary>
        SagiAda = 175,
        /// <summary>
        /// released
        /// </summary>
        SangkaewChalermchai = 176,
        /// <summary>
        /// body recovered
        /// </summary>
        SarfatiOphir = 177,
        /// <summary>
        /// body recovered, executed by Hamas (26 yr)
        /// </summary>
        SarusiAlmog = 178,
        /// <summary>
        /// released
        /// </summary>
        SchemMia = 179,
        /// <summary>
        /// body recovered, killed by friendly fire while surrendering
        /// </summary>
        ShamrizAlon = 180,
        /// <summary>
        /// released
        /// </summary>
        ShaniAmit = 181,
        /// <summary>
        /// released (52 yr)
        /// </summary>
        SharabiEli = 182,

        /// <summary>
        /// 30 yr
        /// </summary>
        [TODO("")]
        ShaulOron = 183,

        /// <summary>
        /// released (22 yr)
        /// </summary>
        ShemTovOmer = 184,
        /// <summary>
        /// bodies recovered, killed in IDF airstrike (Sergeant)
        /// </summary>
        ShermanRon = 185,
        /// <summary>
        /// released
        /// </summary>
        ShohamAdi = 186,
        /// <summary>
        /// released
        /// </summary>
        ShohamNave = 187,
        /// <summary>
        /// released (40 yr)
        /// </summary>
        ShohamTal = 188,
        /// <summary>
        /// released
        /// </summary>
        ShohamYahel = 189,
        /// <summary>
        /// released
        /// </summary>
        ShoshaniHilaRotem = 190,

        /// <summary>
        /// 28 yr
        /// </summary>
        [TODO("")]
        ShtiviIdan = 191,

        /// <summary>
        /// released (62 yr)
        /// </summary>
        SiegelAdrienneAviva = 192,
        /// <summary>
        /// released (65 yr)
        /// </summary>
        SiegelSamuelKeith = 193,
        /// <summary>
        /// released (50 yr)
        /// </summary>
        SoussanaAmit = 194,
        /// <summary>
        /// released (33 yr)
        /// </summary>
        SriaounWatchara = 195,
        /// <summary>
        /// released
        /// </summary>
        SrikeinaJakkrapan = 196,
        /// <summary>
        /// released 31 yr (seen 35 but that looks wrong)
        /// </summary>
        SteinbrecherDoron = 197,
        /// <summary>
        /// released
        /// </summary>
        SuriyasriOwas = 198,
        /// <summary>
        /// released (35 yr)
        /// </summary>
        SuwannakhamSathian = 199,
        /// <summary>
        /// body recovered
        /// </summary>
        SvirskyItai = 200,
        /// <summary>
        /// body recovered, killed by friendly fire while surrendering
        /// </summary>
        TalalkaSamer = 201,
        /// <summary>
        /// released
        /// </summary>
        TalMeirav = 202,
        /// <summary>
        /// released
        /// </summary>
        TarshanskyGali = 203,
        /// <summary>
        /// released, mother of Yelena Troufanov
        /// </summary>
        TatiIrena = 204,
        /// <summary>
        /// released
        /// </summary>
        TemthongVichian = 205,
        /// <summary>
        /// released (36 yr)
        /// </summary>
        ThaennaPongsak = 206,
        /// <summary>
        /// body recovered, killed in IDF airstrike (civilian)
        /// </summary>
        ToledanoElia = 207,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        ToonsriUthai = 208,
        /// <summary>
        /// released
        /// </summary>
        TornsokreePattanayut = 209,
        /// <summary>
        /// released
        /// </summary>
        TroufanovYelena = 210,
        /// <summary>
        /// released (29 yr)
        /// </summary>
        TrupanobAlexanderSasha = 211,
        /// <summary>
        /// released
        /// </summary>
        TzarfatiOfir = 212,

        /// <summary>
        /// 56 yr
        /// </summary>
        [TODO("")]
        WeissIlan = 213,

        /// <summary>
        /// released
        /// </summary>
        WeissNoga = 214,
        /// <summary>
        /// released
        /// </summary>
        WeissShiri = 215,
        /// <summary>
        /// recovered body
        /// </summary>
        WeissYehudit = 216,
        /// <summary>
        /// released (23 yr)
        /// </summary>
        WenkertOmer = 217,
        /// <summary>
        /// rescued (42 yr)
        /// </summary>
        YablonkaHanan = 218,
        /// <summary>
        /// released (12 yr)
        /// </summary>
        YahalomiEitan = 219,
        /// <summary>
        /// body released (49 yr)
        /// </summary>
        YahalomiOhad = 220,
        /// <summary>
        /// released
        /// </summary>
        YanaiMoranStela = 221,
        /// <summary>
        /// released (29 yr)
        /// </summary>
        YehoudArbel = 222,

        /// <summary>
        /// 35 yr
        /// </summary>
        [TODO("")]
        YehoudDolev = 223,

        /// <summary>
        /// body recovered, executed by Hamas (24 yr)
        /// </summary>
        YerushalmiEden = 224,
        /// <summary>
        /// released elderly Israli woman (goes by Cooper)
        /// </summary>
        YitzhakNuritCooper = 225,

        /// <summary>
        /// 24 yr
        /// </summary>
        [TODO("")]
        ZangaukerMatan = 226,

        /// <summary>
        /// body recovered
        /// </summary>
        ZechariahEden = 227,
        /// <summary>
        /// rescued
        /// </summary>
        ZivShlomi = 228,
        /// <summary>
        /// released (17 yr)
        /// </summary>
        ZiyadneAisha = 229,
        /// <summary>
        /// released (18 yr)
        /// </summary>
        ZiyadneBilal = 230,
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
                    HostageList.BrodutchUriah,
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
                    HostageList.CunionEmma,
                    HostageList.CunioYuli,
                    HostageList.EngelBartKarina,
                    HostageList.EngelMika,
                    HostageList.EngelYuval,
                    HostageList.JacobOr,
                    HostageList.JacobYagil,
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

                /// <summary>
                /// Ofir Tzarfati, Liat Beinin, Raz Ben-Ami, Ofir Engel, Yarden Roman-Gat, Liam Or, Itay Regev, Raaya Rotem
                /// Amit Shani, Gali Tarshansky, Moran Stela Yanai, Paiboon Ratanin, Kong Saelao, Chalermchai Sangkaew, Jakkrapan Srikeina
                /// Yelena Troufanov, Irena Tati (mother of Yelena Troufanov)
                /// </summary>
                [Number(17)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(
                    HostageList.TzarfatiOfir,
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
                    HostageList.TroufanovYelena,
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
            [Hostages(HostageList.SarfatiOphir)]
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

            [Number(33)] //?
            public static class January15HostageReturnAgreementPhase1
            {
                /// <summary>
                /// Released: Emily Damari 28, Romi Gonen 24, Doron Steinbrecher 31
                /// </summary>
                [Number(3)]
                [Hostages(HostageList.DamariEmily, HostageList.GonenRomi, HostageList.SteinbrecherDoron)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                public static class January19Release { }

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
                    HostageList.TrupanobAlexanderSasha, 
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

                [Number(1)]
                [HostageOutcome(HostageOutcome.ReleasedAlive)]
                [Hostages(HostageList.AlexanderEdan)]
                public static class March12 { }
            }
        }
    }
}
