
using Existence.Earth.Alphabet;
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

    /// <summary>
    /// https://www.israelhayom.com/2023/10/31/these-are-the-captives-held-by-hamas/
    /// </summary>
    public enum HostageList
    {
        /// <summary>
        /// released
        /// </summary>
        AdarYafa = 1,
        /// <summary>
        /// Staff Sergeant, body recovered
        /// </summary>
        AhimasTomerYaakov = 2,
        /// <summary>
        /// released
        /// </summary>
        AloniDaniel = 3,
        /// <summary>
        /// released
        /// </summary>
        AloniEmelia = 4,
        /// <summary>
        /// released, held by Hamas prior to 2023-10-7
        /// </summary>
        AlSayedHishamShaaban = 5,
        /// <summary>
        /// body recovered
        /// </summary>
        AlZayadniHamzah = 6,
        /// <summary>
        /// body recovered
        /// </summary>
        AlZayadniYosef = 7,
        /// <summary>
        /// released
        /// </summary>
        AlbagLiri = 8,

        [TODO("")]
        AlexanderEdan = 9,

        /// <summary>
        /// rescued
        /// </summary>
        AlkadiQaidFarhan = 10,
        /// <summary>
        /// released
        /// </summary>
        AngkaewAnucha = 11,

        [TODO("")]
        AngrestMatan = 12,

        /// <summary>
        /// rescued
        /// </summary>
        ArgamaniNoa = 13,
        /// <summary>
        /// released
        /// </summary>
        ArievKarina = 14,
        /// <summary>
        /// released
        /// </summary>
        AsherAviv = 15,
        /// <summary>
        /// released
        /// </summary>
        AsherDoronKatz = 16,
        /// <summary>
        /// released
        /// </summary>
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
        /// released
        /// </summary>
        BenAmiOhad = 24,
        /// <summary>
        /// released
        /// </summary>
        BenAmiRaz = 25,
        /// <summary>
        /// body recovered
        /// </summary>
        BenjaminRon = 26,
        /// <summary>
        /// released
        /// </summary>
        BergerAgam = 27,

        [TODO("")]
        BermanGali = 28,

        [TODO("")]
        BermanZiv = 29,

        /// <summary>
        /// released body
        /// </summary>
        BibasAriel = 30,
        /// <summary>
        /// released body
        /// </summary>
        BibasKfir = 31,
        /// <summary>
        /// released body
        /// </summary>
        BibasShiri = 32,
        /// <summary>
        /// released
        /// </summary>
        BibasYarden = 33,

        [TODO("")]
        BohbotElkana = 34,

        /// <summary>
        /// released
        /// </summary>
        BoonpromSanti = 35,

        [TODO("")]
        BraslavskiRom = 36,

        /// <summary>
        /// Sergeant, body recovered
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
        BuchshtavRimon = 42,
        /// <summary>
        /// body recovered (Buckshtav?)
        /// </summary>
        BuchshtabYagev = 43,
        /// <summary>
        /// body recovered
        /// </summary>
        BuskilaEstherAmit = 44,
        /// <summary>
        /// released
        /// </summary>
        ChombuaKomkrit = 45,
        /// <summary>
        /// released
        /// </summary>
        CohenEliya = 46,

        [TODO("")]
        CohenNimrod = 47,

        /// <summary>
        /// released (girlfriend of Alexandre (Sasha) Troufanov)
        /// </summary>
        CohenSapir = 48,

        [TODO("")]
        CooperAmiram = 49,

        [TODO("")]
        CunioAriel = 50,

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
        /// released
        /// </summary>
        DamariEmily = 56,
        /// <summary>
        /// body recovered
        /// </summary>
        DancygAlexander = 57,
        /// <summary>
        /// body recovered, executed by Hamas
        /// </summary>
        DaninoOri = 58,

        [TODO("")]
        DavidEvyatar = 59,

        /// <summary>
        /// released
        /// </summary>
        DekelChenSagui = 60,
        /// <summary>
        /// released
        /// </summary>
        EdanAbigail = 61,
        /// <summary>
        /// body released
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
        /// body recovered, executed by Hamas
        /// </summary>
        GatCarmel = 69,
        /// <summary>
        /// body recovered
        /// </summary>
        GelerenterItzhak = 70,
        /// <summary>
        /// released
        /// </summary>
        GilboaDaniella = 71, //site said Daniel

        [TODO("")]
        GilboaDalalGuy = 72,

        /// <summary>
        /// body recovered, executed by Hamas (American)
        /// </summary>
        GoldbergPolinHersh = 73,

        [TODO("")]
        GoldinHadar = 74,

        /// <summary>
        /// body recovered
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
        /// released
        /// </summary>
        GonenRomi = 80,
        /// <summary>
        /// body recovered
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

        [TODO("")]
        GviliRan = 84,

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
        /// rescued
        /// </summary>
        HarLuis = 89,
        /// <summary>
        /// released
        /// </summary>
        HeimanDitza = 90,

        [TODO("")]
        HerkinMaxim = 91,

        [TODO("")]
        HernandezOryon = 92,

        [TODO("")]
        HornEitan = 93,

        /// <summary>
        /// released
        /// </summary>
        HornIair = 94,
        /// <summary>
        /// body released
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

        [TODO("")]
        JoshiBipin = 99,

        /// <summary>
        /// released
        /// </summary>
        KalapratVichai = 100,
        /// <summary>
        /// released
        /// </summary>
        KalderonErez = 101,
        /// <summary>
        /// released
        /// </summary>
        KalderonOfer = 102,
        /// <summary>
        /// released
        /// </summary>
        KalderonSahar = 103,

        [TODO("")]
        KalfonSegev = 104,

        /// <summary>
        /// released
        /// </summary>
        KatzirHannah = 105,
        /// <summary>
        /// body recovered
        /// </summary>
        KatznirElad = 106,
        /// <summary>
        /// body recovered
        /// </summary>
        KatzRavid = 107,
        /// <summary>
        /// released
        /// </summary>
        KesoognernSurin = 108,
        /// <summary>
        /// released
        /// </summary>
        KirshtRimon = 109,
        /// <summary>
        /// released
        /// </summary>
        KongmaneeBancha = 110,
        /// <summary>
        /// rescued
        /// </summary>
        KozlovAndrey = 111,
        /// <summary>
        /// released
        /// </summary>
        KriboyRoni = 112,

        [TODO("")]
        KupershteinBar = 113,

        /// <summary>
        /// released
        /// </summary>
        LeimbergGabriela = 114,
        /// <summary>
        /// released
        /// </summary>
        LeimbertMia = 115,
        /// <summary>
        /// released
        /// </summary>
        LevyNaama = 116,
        /// <summary>
        /// released
        /// </summary>
        LevyOr = 117,
        /// <summary>
        /// released body
        /// </summary>
        LifshitzOded = 118,
        /// <summary>
        /// released elderly Israli woman
        /// </summary>
        LifshitzYokheved = 119,
        /// <summary>
        /// body recovered, executed by Hamas
        /// </summary>
        LobanovAlexander = 120,
        /// <summary>
        /// body recovered
        /// </summary>
        LoukShani = 121,
        /// <summary>
        /// body released
        /// </summary>
        MansourShlomo = 122,
        /// <summary>
        /// recovered body (corporal)
        /// </summary>
        MarcianoNoa = 123,
        /// <summary>
        /// released
        /// </summary>
        MargalitNili = 124,
        /// <summary>
        /// rescued female Israeli soldier
        /// </summary>
        MegidishOri = 125,
        /// <summary>
        /// rescued
        /// </summary>
        MeirJanAlmog = 126,
        /// <summary>
        /// released (held by Hamas prior to 2023-10-7)
        /// </summary>
        MengistuAvera = 127,
        /// <summary>
        /// released
        /// </summary>
        MermanClara = 128,
        /// <summary>
        /// rescued
        /// </summary>
        MermanFernandoSimon = 129,
        /// <summary>
        /// released
        /// </summary>
        MetzgerTamar = 130,
        /// <summary>
        /// body recovered
        /// </summary>
        MetzgerYoram = 131,

        [TODO("")]
        MiranOmri = 132,

        [TODO("")]
        MorEitanAbraham = 133,

        /// <summary>
        /// released
        /// </summary>
        MosheAdina = 134,
        /// <summary>
        /// released, 77-year-old member of Kibbutz Nir Or
        /// </summary>
        MosesMargalit = 135,
        /// <summary>
        /// released
        /// </summary>
        MozesGadiMoshe = 136,
        /// <summary>
        /// body recovered
        /// </summary>
        MunderAbraham = 137,
        /// <summary>
        /// released
        /// </summary>
        MunderKeren = 138,
        /// <summary>
        /// released 
        /// </summary>
        MunderOhad = 139,
        /// <summary>
        /// released
        /// </summary>
        MunderRuth = 140,
        /// <summary>
        /// released
        /// </summary>
        MunkanNattaware = 141,

        [TODO("")]
        NeutraOmer = 142,

        [TODO("")]
        NimrodTamir = 143,

        /// <summary>
        /// rescued
        /// </summary>
        NisenbaumMichel = 144,

        [TODO("")]
        OhanaYosef = 145,

        [TODO("")]
        OhelAlon = 146,

        /// <summary>
        /// released
        /// </summary>
        OnkaewNatthaporn = 147,
        /// <summary>
        /// released
        /// </summary>
        OrAlma = 148,

        [TODO("")]
        OrAvinathan = 149,

        [TODO("")]
        OrDror = 150,

        /// <summary>
        /// released
        /// </summary>
        OrLiam = 151,
        /// <summary>
        /// released
        /// </summary>
        OrNoam = 152,
        /// <summary>
        /// released
        /// </summary>
        PachecoGelienorJimmy = 153,
        /// <summary>
        /// released
        /// </summary>
        PankhongBoonthom = 154,
        /// <summary>
        /// body recovered
        /// </summary>
        PeriChaim = 155,
        /// <summary>
        /// released
        /// </summary>
        PeriHanna = 156,
        /// <summary>
        /// released
        /// </summary>
        PhachuabboonMongkol = 157,
        /// <summary>
        /// released
        /// </summary>
        PhoomeVetoon = 158,
        /// <summary>
        /// released
        /// </summary>
        PinakalowPornsawan = 159,
        /// <summary>
        /// body recovered
        /// </summary>
        PopplewellNadav = 160,
        /// <summary>
        /// Israeli-American, released
        /// </summary>
        RaananJudith = 161,
        /// <summary>
        /// Israeli-American, released
        /// </summary>
        RaananNatalie = 162,
        /// <summary>
        /// rescued
        /// </summary>
        RadouxOriónHernández = 163,
        /// <summary>
        /// released
        /// </summary>
        RataninPaiboon = 164,
        /// <summary>
        /// released
        /// </summary>
        RegevItay = 165,
        /// <summary>
        /// released
        /// </summary>
        RegevMaya = 166,
        /// <summary>
        /// released
        /// </summary>
        RoitmanOfelia = 167,
        /// <summary>
        /// released
        /// </summary>
        RomanGatYarden = 168,
        /// <summary>
        /// released
        /// </summary>
        RomneoSurasak = 169,
        /// <summary>
        /// released
        /// </summary>
        RotemRaaya = 170,

        [TODO("")]
        RudaeffLior = 171,

        /// <summary>
        /// released
        /// </summary>
        SaelaoKong = 172,
        /// <summary>
        /// released
        /// </summary>
        SaengboonBuddhee = 173,
        /// <summary>
        /// released
        /// </summary>
        SaengnuanUthai = 174,
        /// <summary>
        /// released
        /// </summary>
        SaethaoBannawat = 175,
        /// <summary>
        /// released
        /// </summary>
        SagiAda = 176,
        /// <summary>
        /// released
        /// </summary>
        SangkaewChalermchai = 177,
        /// <summary>
        /// body recovered
        /// </summary>
        SarfatiOphir = 178,
        /// <summary>
        /// body recovered, executed by Hamas
        /// </summary>
        SarusiAlmog = 179,
        /// <summary>
        /// released
        /// </summary>
        SchemMia = 180,
        /// <summary>
        /// body recovered, killed by friendly fire while surrendering
        /// </summary>
        ShamrizAlon = 181,
        /// <summary>
        /// released
        /// </summary>
        ShaniAmit = 182,
        /// <summary>
        /// released
        /// </summary>
        SharabiEli = 183,

        [TODO("")]
        ShaulOron = 184,

        /// <summary>
        /// released
        /// </summary>
        ShemTovOmer = 185,
        /// <summary>
        /// bodies recovered, killed in IDF airstrike (Sergeant)
        /// </summary>
        ShermanRon = 186,
        /// <summary>
        /// released
        /// </summary>
        ShohamAdi = 187,
        /// <summary>
        /// released
        /// </summary>
        ShohamNave = 188,
        /// <summary>
        /// released
        /// </summary>
        ShohamTal = 189,
        /// <summary>
        /// released
        /// </summary>
        ShohamYahel = 190,
        /// <summary>
        /// released
        /// </summary>
        ShoshaniHilaRotem = 191,

        [TODO("")]
        ShtiviIdan = 192,

        /// <summary>
        /// released
        /// </summary>
        SiegelAdrienne = 193,
        /// <summary>
        /// released
        /// </summary>
        SiegelSamuelKeith = 194,
        /// <summary>
        /// released
        /// </summary>
        SoussanaAmit = 195,
        /// <summary>
        /// released
        /// </summary>
        SriaounWatchara = 196,
        /// <summary>
        /// released
        /// </summary>
        SrikeinaJakkrapan = 197,
        /// <summary>
        /// released
        /// </summary>
        SteinbrecherDoron = 198,
        /// <summary>
        /// released
        /// </summary>
        SuriyasriOwas = 199,
        /// <summary>
        /// released
        /// </summary>
        SuwannakhamSathian = 200,
        /// <summary>
        /// body recovered
        /// </summary>
        SvirskyItai = 201,
        /// <summary>
        /// body recovered, killed by friendly fire while surrendering
        /// </summary>
        TalalkaSamer = 202,
        /// <summary>
        /// released
        /// </summary>
        TalMeirav = 203,
        /// <summary>
        /// released
        /// </summary>
        TarshanskyGali = 204,
        /// <summary>
        /// released, mother of Yelena Troufanov
        /// </summary>
        TatiIrena = 205,
        /// <summary>
        /// released
        /// </summary>
        TemthongVichian = 206,
        /// <summary>
        /// released
        /// </summary>
        ThaennaPongsak = 207,
        /// <summary>
        /// body recovered, killed in IDF airstrike (civilian)
        /// </summary>
        ToledanoElia = 208,
        /// <summary>
        /// released
        /// </summary>
        ToonsriUthai = 209,
        /// <summary>
        /// released
        /// </summary>
        TornsokreePattanayut = 210,
        /// <summary>
        /// released
        /// </summary>
        TroufanovYelena = 211,
        /// <summary>
        /// released
        /// </summary>
        TrupanobAlexanderSasha = 212,
        /// <summary>
        /// released
        /// </summary>
        TzarfatiOfir = 213,

        [TODO("")]
        WeissIlan = 214,

        /// <summary>
        /// released
        /// </summary>
        WeissNoga = 215,
        /// <summary>
        /// released
        /// </summary>
        WeissShiri = 216,
        /// <summary>
        /// recovered body
        /// </summary>
        WeissYehudit = 217,
        /// <summary>
        /// released
        /// </summary>
        WenkertOmer = 218,
        /// <summary>
        /// rescued (hanan?)
        /// </summary>
        YablonkaChanan = 219,
        /// <summary>
        /// released
        /// </summary>
        YahalomiEitan = 220,
        /// <summary>
        /// body released
        /// </summary>
        YahalomiOhad = 221,
        /// <summary>
        /// released
        /// </summary>
        YanaiMoranStela = 222,
        /// <summary>
        /// released
        /// </summary>
        YehoudArbel = 223,

        [TODO("")]
        YehoudDolev = 224,

        /// <summary>
        /// body recovered, executed by Hamas
        /// </summary>
        YerushalmiEden = 225,
        /// <summary>
        /// released elderly Israli woman (goes by Cooper)
        /// </summary>
        YitzhakNuritCooper = 226,

        [TODO("")]
        ZangaukerMatan = 227,

        /// <summary>
        /// body recovered
        /// </summary>
        ZechariahEden = 228,
        /// <summary>
        /// rescued
        /// </summary>
        ZivShlomi = 229,
        /// <summary>
        /// released
        /// </summary>
        ZiyadneAisha = 230,
        /// <summary>
        /// released
        /// </summary>
        ZiyadneBilal = 231,
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

            /// <summary>
            /// released
            /// </summary>
            [Hostages(HostageList.RaananJudith, HostageList.RaananNatalie)]
            [Number(2)]
            public static class October20 { }

            /// <summary>
            /// released elderly Israeli women (Yokheved Lifshitz and Nurit Yitzhak [Nurit Cooper])
            /// </summary>
            [Hostages(HostageList.LifshitzYokheved, HostageList.YitzhakNuritCooper)]
            [Number(2)]
            public static class October23 { }

            /// <summary>
            /// Israeli forces rescued soldier Ori Megidish (female soldier)
            /// </summary>
            [Hostages(HostageList.MegidishOri)]
            [Number(1)]
            public static class October30 { }

            /// <summary>
            /// recovered bodies of Yehudit Weiss and Corporal Noa Marciano, from buildings adjacent to Al-Shifa hospital
            /// </summary>
            [Hostages(HostageList.WeissYehudit, HostageList.MarcianoNoa)]
            [Number(2)]
            public static class November1617 { }

            /// <summary>
            /// Ceasefire agreement led to releases over several days (81 Israelis, 23 Thais, 1 Filipino), November 24-30.
            /// </summary>
            [Number(105)]
            public static class November21
            {
                /// <summary>
                /// Yafa Adar, Daniel Aloni, Emilia Aloni, Aviv Asher, Doron Katz Asher, Raz Asher, Hannah Katzir, Margalit Moses (77-year-old member of Kibbutz Nir Or)
                /// Adina Moshe, Keren Munder, Ohad Munder, Ruth Munder, Nattaware Munkan, Hanna Peri, Santi Boonprom, Vichai Kalaprat
                /// Bancha Kongmanee, Gelienor "Jimmy" Pacheco, Boonthom Pankhong, Mongkol Phachuabboon, Vetoon Phoome, Buddhee Saengboon, Uthai Saengnuan, Uthai Toonsri
                /// </summary>
                [Number(24)]
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
                    HostageList.MunkanNattaware,
                    HostageList.PeriHanna,
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
                    HostageList.SiegelAdrienne,
                    HostageList.KesoognernSurin,
                    HostageList.PinakalowPornsawan,
                    HostageList.TemthongVichian)]
                public static class November26 { }

                /// <summary>
                /// Sharon Olani Cunio, Emma Cunion, Yuli Cunio, Karina Engel-Bart, Mika Engel, Yuval Engel, Or Jacob, Yagil Jacob
                /// Erez Kalderon, Sahar Kalderon, Eitan Yahaloni
                /// </summary>
                [Number(11)]
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
                [Hostages(
                    HostageList.BabadillaNoralin,
                    HostageList.HeimanDitza,
                    HostageList.KirshtRimon,
                    HostageList.LeimbergGabriela,
                    HostageList.LeimbertMia,
                    HostageList.MermanClara,
                    HostageList.MetzgerTamar,
                    HostageList.RoitmanOfelia,
                    HostageList.SagiAda,
                    HostageList.SuriyasriOwas,
                    HostageList.TalMeirav,
                    HostageList.TornsokreePattanayut)]
                public static class November28A { }

                /// <summary>
                /// Rimon Buchshstav (not listed on CNN site)
                /// </summary>
                [Number(1)]
                [Hostages(HostageList.BuchshtavRimon)]
                public static class November28B { }

                /// <summary>
                /// Ofir Tzarfati, Liat Beinin, Raz Ben-Ami, Ofir Engel, Yarden Roman-Gat, Liam Or, Itay Regev, Raaya Rotem
                /// Amit Shani, Gali Tarshansky, Moran Stela Yanai, Paiboon Ratanin, Kong Saelao, Chalermchai Sangkaew, Jakkrapan Srikeina
                /// Yelena Troufanov, Irena Tati (mother of Yelena Troufanov)
                /// </summary>
                [Number(17)]
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
            public static class November29 { }

            /// <summary>
            /// The IDF recovers the bodies of Eden Zechariah and Staff Sergeant Major Ziv Dado in underground tunnels in Jabalia, Gaza
            /// </summary>
            [Number(2)]
            [Hostages(HostageList.ZechariahEden, HostageList.DadoZiv)]
            public static class December12 { }

            /// <summary>
            /// An IDF airstrike targeting Hamas's northern Gaza brigade chief, Ahmed Ghandour, killed three hostages, but their
            /// bodies were not recovered until December 15th (Sgt. Ron Sherman, Cpl. Nik Beizer, and civilian Elia Toledano)
            /// </summary>
            [Number(3)]
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
            public static class February12 { }

            /// <summary>
            ///	The IDF announces it has recovered the body of deceased hostage Elad Katzir 
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.KatznirElad)]
            public static class April6 { }

            /// <summary>
            /// Shani Louk, Amit Buskila, and Itzhak Gelerenter, reportedly kidnapped during the attack on the Nova festival
            /// All three were killed near the site of the attack and their bodies were taken into Gaza and later recovered in a Hamas tunnel
            /// </summary>
            [Hostages(HostageList.LoukShani, HostageList.BuskilaEstherAmit, HostageList.GelerenterItzhak)]
            [Number(3)]
            public static class May17 { }

            /// <summary>
            /// It was announced by the IDF that they had also recovered the body of deceased hostage Ron Benjamin, and his body was recovered 
            /// alongside those announced the day before. Benjamin was 53-years-old and abducted from the Be'eri kibbutz while riding his bike 
            /// on the day of the attack
            /// </summary>
            [Hostages(HostageList.BenjaminRon)]
            [Number(1)]
            public static class May18 { }

            /// <summary>
            /// The Israel Defense Forces has recovered the bodies of three more hostages from the northern Gaza Strip in an overnight operation,
            /// Orión Hernández Radoux, 30, Hanan Yablonka, 42, and Michel Nisenbaum, 59, were all killed on October 7,
            /// </summary>
            [Number(3)]
            [Hostages(HostageList.RadouxOriónHernández, HostageList.YablonkaChanan, HostageList.NisenbaumMichel)]
            public static class May24 { }

            /// <summary>
            /// rescued from Nuseirat refugee camp: Noa Argamani, Almog Meir Jan, Andrey Kozlov, and Shlomi Ziv
            /// </summary>
            [Number(4)]
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
            public static class August27 { }

            /// <summary>
            /// recovered the bodies of these hostages from a tunnel in Rafah, Gaza
            /// Believed to be executed by Hamas, shot at close range 1-2 days prior to discovery.
            /// Hersh Goldberg-Polin (23, American), Eden Yerushalmi, 24, Ori Danino, 25, Alex Lobanov, 32, Carmel Gat, 40, and Almog Sarusi, 27.
            /// </summary>
            [Hostages(
                HostageList.GoldbergPolinHersh,
                HostageList.YerushalmiEden,
                HostageList.DaninoOri,
                HostageList.LobanovAlexander,
                HostageList.GatCarmel,
                HostageList.SarusiAlmog)]
            [Number(6)]
            public static class August31 { }

            /// <summary>
            /// The remains of Itai Svirsky, taken hostage from kibbutz Be'eri on October 7, was recovered by the IDF
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.SvirskyItai)]
            public static class December4 { }
        }
        public static class v2025
        {
            /// <summary>
            /// Body recovered by Israeli Military: Yousef Alziadana
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.AlZayadniYosef)]
            public static class January8 { }

            /// <summary>
            /// Body Recovered by Israeli Military: Hamza Alziadana
            /// </summary>
            [Number(1)]
            [Hostages(HostageList.AlZayadniHamzah)]
            public static class January10 { }

            [Number(33)] //?
            public static class January15HostageReturnAgreementPhase1
            {
                /// <summary>
                /// Released: Emily Damari 28, Romi Gonen 24, Doron Steinbrecher 31
                /// </summary>
                [Number(3)]
                [Hostages(HostageList.DamariEmily, HostageList.GonenRomi, HostageList.SteinbrecherDoron)]
                public static class January19Release { }

                /// <summary>
                /// Released: Liri Albag, Karina Ariev, Daniella Gilboa, Naama Levy
                /// </summary>
                [Number(4)]
                [Hostages(HostageList.AlbagLiri, 
                    HostageList.ArievKarina, 
                    HostageList.GilboaDaniella, 
                    HostageList.LevyNaama)]
                public static class January25 { }

                /// <summary>
                /// Released: Arbel Yehoud 29, Agam Berger 20, Gadi Moses 80, Surasak Romneo, Bannawat Saethao, Watchara Sriaoun, Pongsak Thaenna, Sathian Suwannakham
                /// </summary>
                [Hostages(HostageList.YehoudArbel, 
                    HostageList.BergerAgam, 
                    HostageList.MozesGadiMoshe, //had listed as Gadi Moses
                    HostageList.RomneoSurasak,
                    HostageList.SaethaoBannawat,
                    HostageList.SriaounWatchara,
                    HostageList.ThaennaPongsak,
                    HostageList.SuwannakhamSathian)]
                [Number(8)]
                public static class January30 { }

                /// <summary>
                /// Released: Ofer Kalderon 54, Yarden Bibas 35, Keith Siegel 65
                /// </summary>
                [Hostages(HostageList.KalderonOfer, HostageList.BibasYarden, HostageList.SiegelSamuelKeith)]
                [Number(3)]
                public static class February1 { }

                /// <summary>
                /// Released: Ohad Ben Ami, Eli Sharabi, Or Levy
                /// </summary>
                [Hostages(HostageList.BenAmiOhad, HostageList.SharabiEli, HostageList.LevyOr)]
                [Number(3)]
                public static class February8 { }

                /// <summary>
                /// Released: Sagui Dekel-Chen, Alexandre (Sasha) Troufanov, Iair Horn 46
                /// </summary>
                [Hostages(HostageList.DekelChenSagui, 
                    HostageList.TrupanobAlexanderSasha, 
                    HostageList.HornIair)]
                [Number(3)]
                public static class February15 { }

                /// <summary>
                /// released bodies: Oded Lifshitz, Ariel/Kfir Bibas
                /// </summary>
                [Number(3)]
                [Hostages(HostageList.LifshitzOded, HostageList.BibasAriel, HostageList.BibasKfir)]
                public static class February20 { }

                /// <summary>
                /// released body: Shiri Bibas
                /// </summary>
                [Hostages(HostageList.BibasShiri)]
                [Number(1)]
                public static class February21 { }

                /// <summary>
                /// released: Omer Wenkert, Omer Shem Tov, Eliya Cohen, Tal Shoham
                /// Avera Mengistu (held by Hamas prior to 2023-10-7)
                /// Hisham al-Sayed (held by Hamas prior to 2023-10-7)
                /// </summary>
                [Number(6)]
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
                [Hostages(
                    HostageList.MansourShlomo,
                    HostageList.YahalomiOhad,
                    HostageList.IdanTsachi,
                    HostageList.ElgaratItzhk)]
                public static class February26 { }
            }

            public static class BelievedDeceased
            {
                /// <summary>
                /// Efrat Katz was likely killed 2023-10-7 by an Israeli helicopter gunship responding to the assault. The helicopter targeted a vehicle 
                /// carrying Hamas gunmen, unaware that hostages were also inside.
                /// </summary>
                public static class EfratKatz { }
            }
        }
    }
}
