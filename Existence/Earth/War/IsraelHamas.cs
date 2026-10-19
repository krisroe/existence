
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
        /// <summary>
        /// released body
        /// </summary>
        AdarTamir = 1,
        /// <summary>
        /// released (85 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        AdarYafa = 2,
        /// <summary>
        /// Staff Sergeant, body recovered (20 yr)
        /// </summary>
        AhimasTomerYaakov = 3,
        /// <summary>
        /// 39 yr, released body, Israeli Bedouin soldier
        /// </summary>
        AlAtreshMuhammad = 4,
        /// <summary>
        /// released (45 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        AloniDaniel = 5,
        /// <summary>
        /// released (5 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        AloniEmelia = 6,
        /// <summary>
        /// released, held by Hamas prior to 2023-10-7 (36 yr)
        /// </summary>
        AlSayedHishamShaaban = 7,
        /// <summary>
        /// body recovered (22 yr)
        /// </summary>
        AlZayadniHamzah = 8,
        /// <summary>
        /// body recovered (53 yr)
        /// </summary>
        AlZayadniYosef = 9,
        /// <summary>
        /// released (19 yr)
        /// </summary>
        AlbagLiri = 10,

        /// <summary>
        /// 18 yr
        /// </summary>
        [Countries(CountryLikeThings.Israel, CountryLikeThings.UnitedStates)]
        AlexanderEdan = 11,

        /// <summary>
        /// rescued (53 yr)
        /// </summary>
        AlkadiQaidFarhan = 12,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        AngkaewAnucha = 13,

        /// <summary>
        /// Israeli solder captured during the October 7 attacks, 32 yr, released
        /// </summary>
        AngrestMatan = 14,

        /// <summary>
        /// rescued (26 yr)
        /// </summary>
        ArgamaniNoa = 15,
        /// <summary>
        /// released (20 yr)
        /// </summary>
        ArievKarina = 16,
        /// <summary>
        /// released (2 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        AsherAviv = 17,
        /// <summary>
        /// released (34 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        AsherDoronKatz = 18,
        /// <summary>
        /// released (4 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        AsherRaz = 19,
        /// <summary>
        /// released
        /// </summary>
        AvigdoriNoam = 20,
        /// <summary>
        /// released
        /// </summary>
        AvigdoriSharon = 21,
        /// <summary>
        /// released
        /// </summary>
        AvrihamElma = 22,
        /// <summary>
        /// released
        /// </summary>
        BabadillaNoralin = 23,
        /// <summary>
        /// released body
        /// </summary>
        BaruchSahar = 24,
        /// <summary>
        /// released body
        /// </summary>
        BaruchUriael = 25,
        /// <summary>
        /// released
        /// </summary>
        BeininLiat = 26,
        /// <summary>
        /// body recovered, killed in IDF airstrike (Corporal)
        /// </summary>
        BeizerNik = 27,
        /// <summary>
        /// released (56 yr)
        /// </summary>
        BenAmiOhad = 28,
        /// <summary>
        /// released
        /// </summary>
        BenAmiRaz = 29,
        /// <summary>
        /// body recovered (53 yr)
        /// </summary>
        BenjaminRon = 30,
        /// <summary>
        /// released (20 yr)
        /// </summary>
        BergerAgam = 31,

        /// <summary>
        /// 26 yr, released, Gali/Ziv Berman are twins
        /// </summary>
        BermanGali = 32,

        /// <summary>
        /// 26 yr, released, Gali/Ziv Berman are twins
        /// </summary>
        BermanZiv = 33,

        /// <summary>
        /// released body (4 yr)
        /// </summary>
        BibasAriel = 34,
        /// <summary>
        /// released body (9 mo)
        /// </summary>
        BibasKfir = 35,
        /// <summary>
        /// released body (32 yr)
        /// </summary>
        BibasShiri = 36,
        /// <summary>
        /// released (35 yr)
        /// </summary>
        BibasYarden = 37,

        /// <summary>
        /// 34 yr, released
        /// </summary>
        BohbotElkana = 38,

        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        BoonpromSanti = 39,

        /// <summary>
        /// released
        /// </summary>
        BraslavskiRom = 40,

        /// <summary>
        /// Sergeant, body recovered (19 yr)
        /// </summary>
        BrodskiKiril = 41,
        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        BrodutchHagar = 42,
        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        BrodutchOfri = 43,
        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        BrodutchOriya = 44,
        /// <summary>
        /// Brodetz is a transformation of the Hebrew.
        /// </summary>
        BrodutchYuval = 45,
        /// <summary>
        /// released
        /// </summary>
        BuchshtavRimonKirsht = 46,
        /// <summary>
        /// body recovered (Buckshtav?) (34 yr)
        /// </summary>
        BuchshtabYagev = 47,
        /// <summary>
        /// body recovered (28 yr)
        /// </summary>
        BuskilaEstherAmit = 48,
        /// <summary>
        /// body recovered
        /// </summary>
        ChenItay = 49,
        /// <summary>
        /// released
        /// </summary>
        ChombuaKomkrit = 50,
        /// <summary>
        /// released (27 yr)
        /// </summary>
        CohenEliya = 51,

        /// <summary>
        /// Israeli solder captured during the October 7 attacks, 19 yr, released
        /// </summary>
        CohenNimrod = 52,

        /// <summary>
        /// released (girlfriend of Alexandre (Sasha) Troufanov)
        /// </summary>
        CohenSapir = 53,

        /// <summary>
        /// 84 yr, released body
        /// </summary>
        CooperAmiram = 54,

        /// <summary>
        /// 26 yr, released
        /// </summary>
        CunioAriel = 55,

        /// <summary>
        /// 33 yr, released
        /// </summary>
        CunioDavid = 56,

        /// <summary>
        /// released? cunio?
        /// </summary>
        CunionEmma = 57,
        /// <summary>
        /// released
        /// </summary>
        CunioSharonOlani = 58,
        /// <summary>
        /// released
        /// </summary>
        CunioYuli = 59,
        /// <summary>
        /// body recovered, staff sergeant major
        /// </summary>
        DadoZiv = 60,
        /// <summary>
        /// released (28 yr)
        /// </summary>
        DamariEmily = 61,
        /// <summary>
        /// body recovered (75 yr)
        /// </summary>
        DancygAlexander = 62,
        /// <summary>
        /// body recovered, executed by Hamas (24 yr)
        /// </summary>
        DaninoOri = 63,

        /// <summary>
        /// 23 yr, released
        /// </summary>
        DavidEvyatar = 64,

        /// <summary>
        /// released (36 yr)
        /// </summary>
        DekelChenSagui = 65,
        /// <summary>
        /// released
        /// </summary>
        EdanAbigail = 66,
        /// <summary>
        /// body released (68 yr)
        /// </summary>
        ElgaratItzhk = 67,
        /// <summary>
        /// released
        /// </summary>
        ElyakimDafna = 68,
        /// <summary>
        /// released
        /// </summary>
        ElyakimEla = 69,
        /// <summary>
        /// released
        /// </summary>
        EngelBartKarina = 70,
        /// <summary>
        /// released
        /// </summary>
        EngelMika = 71,
        /// <summary>
        /// released
        /// </summary>
        EngelOfir = 72,
        /// <summary>
        /// released body
        /// </summary>
        EngelRonan = 73,
        /// <summary>
        /// released
        /// </summary>
        EngelYuval = 74,
        /// <summary>
        /// body recovered, executed by Hamas (39 yr)
        /// </summary>
        GatCarmel = 75,
        /// <summary>
        /// body recovered (56 yr)
        /// </summary>
        GelerenterItzhak = 76,
        /// <summary>
        /// released (20 yr)
        /// </summary>
        GilboaDaniella = 77, //(originally named Danielle)

        /// <summary>
        /// 22 yr, released, Guy Gilboa-Dalal
        /// </summary>
        GilboaDalalGuy = 78,

        /// <summary>
        /// released body
        /// </summary>
        GodardManny = 79,

        /// <summary>
        /// body recovered, executed by Hamas (American) (23 yr)
        /// </summary>
        GoldbergPolinHersh = 80,

        /// <summary>
        /// 32 yr, body released
        /// </summary>
        GoldinHadar = 81,

        /// <summary>
        /// body recovered (33 yr)
        /// </summary>
        GoldinOren = 82,
        /// <summary>
        /// released
        /// </summary>
        GoldsteinAlmogAgam = 83,
        /// <summary>
        /// released
        /// </summary>
        GoldsteinAlmogChen = 84,
        /// <summary>
        /// released
        /// </summary>
        GoldsteinAlmogGal = 85,
        /// <summary>
        /// released
        /// </summary>
        GoldsteinAlmogTal = 86,
        /// <summary>
        /// released (24 yr)
        /// </summary>
        GonenRomi = 87,
        /// <summary>
        /// body recovered (56 yr)
        /// </summary>
        GorenMaya = 88,
        /// <summary>
        /// released
        /// </summary>
        GorenShani = 89,
        /// <summary>
        /// released
        /// </summary>
        GritzewskyIlana = 90,

        /// <summary>
        /// 24 yr, aka Rani, body recovered, last hostage accounted for
        /// </summary>
        GviliRan = 91,

        /// <summary>
        /// 73 yr, aka Gadi, released body
        /// </summary>
        HaggaiGad = 92,

        /// <summary>
        /// body recovered, killed by friendly fire while surrendering
        /// </summary>
        HaimYotam = 93,
        /// <summary>
        /// body recovered
        /// </summary>
        HaimiTal = 94,
        /// <summary>
        /// body released
        /// </summary>
        HamamiAsaf = 95,
        /// <summary>
        /// released
        /// </summary>
        HandEmily = 96,
        /// <summary>
        /// released
        /// </summary>
        HaranShoshan = 97,
        /// <summary>
        /// rescued (70 yr)
        /// </summary>
        HarLuis = 98,
        /// <summary>
        /// released body, 26 yr
        /// </summary>
        HaymanInbar = 99,
        /// <summary>
        /// released
        /// </summary>
        HeimanDitza = 100,

        /// <summary>
        /// 35 yr, released
        /// </summary>
        HerkinMaxim = 101,

        /// <summary>
        /// 37 yr, released
        /// </summary>
        HornEitan = 102,

        /// <summary>
        /// released (46 yr)
        /// </summary>
        HornIair = 103,
        /// <summary>
        /// body released (49 yr)
        /// </summary>
        IdanTsachi = 104,
        /// <summary>
        /// released
        /// </summary>
        JacobOr = 105,
        /// <summary>
        /// released
        /// </summary>
        JacobYagil = 106,
        /// <summary>
        /// released
        /// </summary>
        JirachartManee = 107,

        /// <summary>
        /// 23 yr, released body
        /// </summary>
        JoshiBipin = 108,

        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        KalapratVichai = 109,
        /// <summary>
        /// released
        /// </summary>
        KalderonErez = 110,
        /// <summary>
        /// released (54 yr)
        /// </summary>
        KalderonOfer = 111,
        /// <summary>
        /// released
        /// </summary>
        KalderonSahar = 112,

        /// <summary>
        /// 25 yr, released
        /// </summary>
        KalfonSegev = 113,

        /// <summary>
        /// released (76 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        KatzirHannah = 114,
        /// <summary>
        /// body recovered
        /// </summary>
        KatznirElad = 115,
        /// <summary>
        /// body recovered (51 yr)
        /// </summary>
        KatzRavid = 116,
        /// <summary>
        /// released
        /// </summary>
        KesoognernSurin = 117,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        KongmaneeBancha = 118,
        /// <summary>
        /// rescued (27 yr)
        /// </summary>
        KozlovAndrey = 119,
        /// <summary>
        /// released
        /// </summary>
        KriboyRoni = 120,

        /// <summary>
        /// 22 yr, aka Kuperstein, released
        /// </summary>
        KupershteinBar = 121,

        /// <summary>
        /// released
        /// </summary>
        LeimbergGabriela = 122,
        /// <summary>
        /// released
        /// </summary>
        LeimbertMia = 123,
        /// <summary>
        /// rleeased body
        /// </summary>
        LevyEitan = 124,
        /// <summary>
        /// released (20 yr)
        /// </summary>
        LevyNaama = 125,
        /// <summary>
        /// released (34 yr)
        /// </summary>
        LevyOr = 126,
        /// <summary>
        /// released body (84 yr)
        /// </summary>
        LifshitzOded = 127,
        /// <summary>
        /// released elderly Israli woman
        /// </summary>
        LifshitzYokheved = 128,
        /// <summary>
        /// body recovered, executed by Hamas (32 yr)
        /// </summary>
        LobanovAlexander = 129,
        /// <summary>
        /// body recovered
        /// </summary>
        LoukShani = 130,
        /// <summary>
        /// body released (85 yr)
        /// </summary>
        MansourShlomo = 131,
        /// <summary>
        /// recovered body (corporal)
        /// </summary>
        MarcianoNoa = 132,
        /// <summary>
        /// recovered body
        /// </summary>
        MargalitEliyahu = 133,
        /// <summary>
        /// released
        /// </summary>
        MargalitNili = 134,
        /// <summary>
        /// rescued female Israeli soldier
        /// </summary>
        MegidishOri = 135,
        /// <summary>
        /// rescued (21 yr)
        /// </summary>
        MeirJanAlmog = 136,
        /// <summary>
        /// released (held by Hamas prior to 2023-10-7) (38 yr)
        /// </summary>
        MengistuAvera = 137,
        /// <summary>
        /// released
        /// </summary>
        MermanClara = 138,
        /// <summary>
        /// rescued (60 yr)
        /// </summary>
        MermanFernandoSimon = 139,
        /// <summary>
        /// released
        /// </summary>
        MetzgerTamar = 140,
        /// <summary>
        /// body recovered (80 yr)
        /// </summary>
        MetzgerYoram = 141,

        /// <summary>
        /// 46 yr, released
        /// </summary>
        MiranOmri = 142,

        /// <summary>
        /// body released
        /// </summary>
        MollelJoshua = 143,

        /// <summary>
        /// 23 yr, released
        /// </summary>
        MorEitanAbraham = 144,

        /// <summary>
        /// released (72 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        MosheAdina = 145,
        /// <summary>
        /// released, 77-year-old member of Kibbutz Nir Or
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        MosesMargalit = 146,
        /// <summary>
        /// released (79 yr) [sometimes refered to as Gadi Moses]
        /// His partner, Efrat Katz was presumed captive as well, but was likely killed
        /// 2023-10-07 by an Israeli helicopter gunship responding to the assault. The
        /// helicopter targeted a vehicle carrying Hamas gunmen, unaware that hostages
        /// were also inside.
        /// </summary>
        MozesGadiMoshe = 147,
        /// <summary>
        /// body recovered (78 yr)
        /// </summary>
        MunderAbraham = 148,
        /// <summary>
        /// released (54 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        MunderKeren = 149,
        /// <summary>
        /// released (9 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        MunderOhad = 150,
        /// <summary>
        /// released (78 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        MunderRuth = 151,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        MunkanNattawaree = 152,

        /// <summary>
        /// 22 yr, released body
        /// </summary>
        NeutraOmerMaxim = 153,

        /// <summary>
        /// 19 yr, released body
        /// </summary>
        NimrodTamir = 154,

        /// <summary>
        /// rescued (59 yr)
        /// </summary>
        NisenbaumMichel = 155,

        /// <summary>
        /// released body, 30 yr
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        OakkharasriSonthaya = 156,

        /// <summary>
        /// Yosek-Haim Ohana, 23 yr, released
        /// </summary>
        OhanaYosefHaim = 157,

        /// <summary>
        /// 22 yr, released
        /// </summary>
        OhelAlon = 158,

        /// <summary>
        /// released
        /// </summary>
        OnkaewNatthaporn = 159,
        /// <summary>
        /// released
        /// </summary>
        OrAlma = 160,

        /// <summary>
        /// 30 yr, released
        /// </summary>
        OrAvinathan = 161,

        /// <summary>
        /// 48 yr, released body
        /// </summary>
        OrDror = 162,

        /// <summary>
        /// released
        /// </summary>
        OrLiam = 163,
        /// <summary>
        /// released
        /// </summary>
        OrNoam = 164,
        /// <summary>
        /// released body
        /// </summary>
        OzDaniel = 165,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Philippines)]
        PachecoGelienorJimmy = 166,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        PankhongBoonthom = 167,
        /// <summary>
        /// body recovered (79 yr)
        /// </summary>
        PeriChaim = 168,
        /// <summary>
        /// released (79 yr)
        /// </summary>
        [Country(CountryLikeThings.Israel)]
        PeriChanna = 169,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        PhachuabboonMongkol = 170,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        PhoomeVetoon = 171,
        /// <summary>
        /// released
        /// </summary>
        PinakalowPornsawan = 172,
        /// <summary>
        /// body recovered (51 yr)
        /// </summary>
        PopplewellNadav = 173,
        /// <summary>
        /// Israeli-American, released
        /// </summary>
        RaananJudith = 174,
        /// <summary>
        /// Israeli-American, released
        /// </summary>
        RaananNatalie = 175,
        /// <summary>
        /// rescued (30 yr)
        /// </summary>
        RadouxOriónHernández = 176,
        /// <summary>
        /// released
        /// </summary>
        RataninPaiboon = 177,
        /// <summary>
        /// released
        /// </summary>
        RegevItay = 178,
        /// <summary>
        /// released
        /// </summary>
        RegevMaya = 179,
        /// <summary>
        /// body released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        RinthalakSudthisak = 180,
        /// <summary>
        /// released
        /// </summary>
        RoitmanOfelia = 181,
        /// <summary>
        /// released
        /// </summary>
        RomanGatYarden = 182,
        /// <summary>
        /// released (32 yr)
        /// </summary>
        RumnaoSurasak = 183,
        /// <summary>
        /// released
        /// </summary>
        RotemRaaya = 184,

        /// <summary>
        /// 61 yr, released body
        /// </summary>
        RudaeffLior = 185,

        /// <summary>
        /// released
        /// </summary>
        SaelaoKong = 186,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        SaengboonBuddhee = 187,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        SaengnuanUthai = 188,
        /// <summary>
        /// released (27 yr)
        /// </summary>
        SaethaoBannawat = 189,
        /// <summary>
        /// released
        /// </summary>
        SagiAda = 190,
        /// <summary>
        /// released
        /// </summary>
        SangkaewChalermchai = 191,
        /// <summary>
        /// body recovered, executed by Hamas (26 yr)
        /// </summary>
        SarusiAlmog = 193,
        /// <summary>
        /// released
        /// </summary>
        SchemMia = 194,
        /// <summary>
        /// body recovered, killed by friendly fire while surrendering
        /// </summary>
        ShamrizAlon = 195,
        /// <summary>
        /// released
        /// </summary>
        ShaniAmit = 196,
        /// <summary>
        /// released (52 yr)
        /// </summary>
        SharabiEli = 197,

        /// <summary>
        /// 30 yr, recovered body
        /// </summary>
        ShaulOron = 198,

        /// <summary>
        /// released (22 yr)
        /// </summary>
        ShemTovOmer = 199,
        /// <summary>
        /// bodies recovered, killed in IDF airstrike (Sergeant)
        /// </summary>
        ShermanRon = 200,
        /// <summary>
        /// released
        /// </summary>
        ShohamAdi = 201,
        /// <summary>
        /// released
        /// </summary>
        ShohamNave = 202,
        /// <summary>
        /// released (40 yr)
        /// </summary>
        ShohamTal = 203,
        /// <summary>
        /// released
        /// </summary>
        ShohamYahel = 204,
        /// <summary>
        /// released
        /// </summary>
        ShoshaniHilaRotem = 205,

        /// <summary>
        /// 28 yr, recovered body
        /// </summary>
        ShtiviIdan = 206,

        /// <summary>
        /// released (62 yr)
        /// </summary>
        SiegelAdrienneAviva = 207,
        /// <summary>
        /// released (65 yr)
        /// </summary>
        SiegelSamuelKeith = 208,
        /// <summary>
        /// released (50 yr)
        /// </summary>
        SoussanaAmit = 209,
        /// <summary>
        /// released (33 yr)
        /// </summary>
        SriaounWatchara = 210,
        /// <summary>
        /// released
        /// </summary>
        SrikeinaJakkrapan = 211,
        /// <summary>
        /// released 31 yr (seen 35 but that looks wrong)
        /// </summary>
        SteinbrecherDoron = 212,
        /// <summary>
        /// released
        /// </summary>
        SuriyasriOwas = 213,
        /// <summary>
        /// released (35 yr)
        /// </summary>
        SuwannakhamSathian = 214,
        /// <summary>
        /// body recovered
        /// </summary>
        SvirskyItai = 215,
        /// <summary>
        /// body recovered, killed by friendly fire while surrendering
        /// </summary>
        TalalkaSamer = 216,
        /// <summary>
        /// released
        /// </summary>
        TalMeirav = 217,
        /// <summary>
        /// released
        /// </summary>
        TarshanskyGali = 218,
        /// <summary>
        /// released, mother of Yelena Trufanov and Alexander (Sasha) Trufanov
        /// </summary>
        TatiIrena = 219,
        /// <summary>
        /// released
        /// </summary>
        TemthongVichian = 220,
        /// <summary>
        /// released (36 yr)
        /// </summary>
        ThaennaPongsak = 221,
        /// <summary>
        /// body recovered, killed in IDF airstrike (civilian)
        /// </summary>
        ToledanoElia = 222,
        /// <summary>
        /// released
        /// </summary>
        [Country(CountryLikeThings.Thailand)]
        ToonsriUthai = 223,
        /// <summary>
        /// released
        /// </summary>
        TornsokreePattanayut = 224,
        /// <summary>
        /// Trupanob is a transformation of the Hebrew.
        /// </summary>
        TrufanovYelena = 225,
        /// <summary>
        /// Trupanob is a transformation of the Hebrew. (29 yr)
        /// </summary>
        TrufanovAlexanderSasha = 226,
        /// <summary>
        /// body recovered
        /// </summary>
        TzarfatiOfir = 227,
        /// <summary>
        /// released body, Judith Weinstein-Haggai
        /// </summary>
        WeinsteinHaggaiJudith = 228,

        /// <summary>
        /// 56 yr, recovered body
        /// </summary>
        WeissIlan = 229,

        /// <summary>
        /// released
        /// </summary>
        WeissNoga = 230,
        /// <summary>
        /// released
        /// </summary>
        WeissShiri = 231,
        /// <summary>
        /// recovered body
        /// </summary>
        WeissYehudit = 232,
        /// <summary>
        /// released (23 yr)
        /// </summary>
        WenkertOmer = 233,
        /// <summary>
        /// rescued (42 yr)
        /// </summary>
        YablonkaHanan = 234,
        /// <summary>
        /// released (12 yr)
        /// </summary>
        YahalomiEitan = 235,
        /// <summary>
        /// body released (49 yr)
        /// </summary>
        YahalomiOhad = 236,
        /// <summary>
        /// released
        /// </summary>
        YanaiMoranStela = 237,
        /// <summary>
        /// released (29 yr)
        /// </summary>
        YehoudArbel = 238,

        /// <summary>
        /// 35 yr, killed during the October 7 attacks, but never taken into Gaza
        /// </summary>
        [NotActuallyAHostage]
        YehoudDolev = 239,

        /// <summary>
        /// body recovered, executed by Hamas (24 yr)
        /// </summary>
        YerushalmiEden = 240,
        /// <summary>
        /// released elderly Israli woman (goes by Cooper)
        /// </summary>
        YitzhakNuritCooper = 241,
        /// <summary>
        /// released body
        /// </summary>
        ZalmanovitchArye = 242,
        /// <summary>
        /// 24 yr, released
        /// </summary>
        ZangaukerMatan = 243,

        /// <summary>
        /// body recovered
        /// </summary>
        ZechariahEden = 244,
        /// <summary>
        /// rescued
        /// </summary>
        ZivShlomi = 245,
        /// <summary>
        /// released (17 yr)
        /// </summary>
        ZiyadneAisha = 246,
        /// <summary>
        /// released (18 yr)
        /// </summary>
        ZiyadneBilal = 247,
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

                [Number(17)]
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
            public static class March12 { }

            [Number(2)]
            [HostageOutcome(HostageOutcome.RecoveredBody)]
            [Hostages(HostageList.HaggaiGad,
                      HostageList.WeinsteinHaggaiJudith)]
            public static class June5 { }

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

            [Number(1)]
            [HostageOutcome(HostageOutcome.ReleasedBody)]
            [Hostages(HostageList.JoshiBipin)]
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

