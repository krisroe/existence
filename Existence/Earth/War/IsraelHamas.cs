
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
        /// Staff Sergeant, body recovered
        /// </summary>
        AhimasTomerYaakov,
        /// <summary>
        /// released, held by Hamas prior to 2023-10-7
        /// </summary>
        AlSayedHishamShaaban,
        /// <summary>
        /// body recovered
        /// </summary>
        AlZayadniHamzah,
        /// <summary>
        /// body recovered
        /// </summary>
        AlZayadniYosef,
        /// <summary>
        /// released
        /// </summary>
        AlbagLiri,
        AlexanderEdan,
        /// <summary>
        /// rescued
        /// </summary>
        AlkadiQaidFarhan,
        AngrestMatan,
        /// <summary>
        /// rescued
        /// </summary>
        ArgamaniNoa,
        /// <summary>
        /// released
        /// </summary>
        ArievKarina,
        /// <summary>
        /// body recovered, killed in IDF airstrike (Corporal)
        /// </summary>
        BeizerNik,
        /// <summary>
        /// released
        /// </summary>
        BenAmiOhad,
        /// <summary>
        /// body recovered
        /// </summary>
        BenjaminRon,
        /// <summary>
        /// released
        /// </summary>
        BergerAgam,
        BermanGali,
        BermanZiv,
        /// <summary>
        /// released body
        /// </summary>
        BibasAriel,
        /// <summary>
        /// released body
        /// </summary>
        BibasKfir,
        /// <summary>
        /// released body
        /// </summary>
        BibasShiri,
        /// <summary>
        /// released
        /// </summary>
        BibasYarden,
        BohbotElkana,
        BraslavskiRom,
        /// <summary>
        /// Sergeant, body recovered
        /// </summary>
        BrodskiKiril,
        /// <summary>
        /// body recovered (Buckshtav?)
        /// </summary>
        BuchshtabYagev,
        /// <summary>
        /// body recovered
        /// </summary>
        BuskilaEstherAmit,
        /// <summary>
        /// released
        /// </summary>
        CohenEliya,
        CohenNimrod,
        CooperAmiram,
        CunioAriel,
        CunioDavid,
        /// <summary>
        /// released
        /// </summary>
        DamariEmily,
        /// <summary>
        /// body recovered
        /// </summary>
        DancygAlexander,
        /// <summary>
        /// body recovered, executed by Hamas
        /// </summary>
        DaninoOri,
        DavidEvyatar,
        /// <summary>
        /// released
        /// </summary>
        DekelChenSagui,
        /// <summary>
        /// body released
        /// </summary>
        ElgaratItzhk,
        /// <summary>
        /// body recovered, executed by Hamas
        /// </summary>
        GatCarmel,
        /// <summary>
        /// body recovered
        /// </summary>
        GelerenterItzhak,
        /// <summary>
        /// released
        /// </summary>
        GilboaDaniella, //site said Daniel
        GilboaDalalGuy,
        /// <summary>
        /// body recovered, executed by Hamas (American)
        /// </summary>
        GoldbergPolinHersh,
        GoldinHadar,
        /// <summary>
        /// body recovered
        /// </summary>
        GoldinOren,
        /// <summary>
        /// released
        /// </summary>
        GonenRomi,
        /// <summary>
        /// body recovered
        /// </summary>
        GorenMaya,
        GviliRan,
        HaggaiGad,
        /// <summary>
        /// body recovered, killed by friendly fire while surrendering
        /// </summary>
        HaimYotam,
        /// <summary>
        /// rescued
        /// </summary>
        HarLuis,
        HerkinMaxim,
        HernandezOryon,
        HornEitan,
        /// <summary>
        /// released
        /// </summary>
        HornIair,
        /// <summary>
        /// body released
        /// </summary>
        IdanTsachi,
        JoshiBipin,
        /// <summary>
        /// released
        /// </summary>
        KalderonOfer,
        KalfonSegev,
        /// <summary>
        /// body recovered
        /// </summary>
        KatznirElad,
        /// <summary>
        /// body recovered
        /// </summary>
        KatzRavid,
        /// <summary>
        /// rescued
        /// </summary>
        KozlovAndrey,
        KupershteinBar,
        /// <summary>
        /// released
        /// </summary>
        LevyNaama,
        /// <summary>
        /// released
        /// </summary>
        LevyOr,
        /// <summary>
        /// released body
        /// </summary>
        LifshitzOded,
        /// <summary>
        /// released elderly Israli woman
        /// </summary>
        LifshitzYokheved,
        /// <summary>
        /// body recovered, executed by Hamas
        /// </summary>
        LobanovAlexander,
        /// <summary>
        /// body recovered
        /// </summary>
        LoukShani,
        /// <summary>
        /// body released
        /// </summary>
        MansourShlomo,
        /// <summary>
        /// recovered body (corporal)
        /// </summary>
        MarcianoNoa,
        /// <summary>
        /// rescued female Israeli soldier
        /// </summary>
        MegidishOri,
        /// <summary>
        /// rescued
        /// </summary>
        MeirJanAlmog,
        /// <summary>
        /// released (held by Hamas prior to 2023-10-7)
        /// </summary>
        MengistuAvera,
        /// <summary>
        /// rescued
        /// </summary>
        MermanFernandoSimon,
        /// <summary>
        /// body recovered
        /// </summary>
        MetzgerYoram,
        MiranOmri,
        MorEitanAbraham,
        /// <summary>
        /// released
        /// </summary>
        MozesGadiMoshe,
        /// <summary>
        /// body recovered
        /// </summary>
        MunderAbraham,
        NeutraOmer,
        NimrodTamir,
        /// <summary>
        /// rescued
        /// </summary>
        NisenbaumMichel,
        OhanaYosef,
        OhelAlon,
        OrAvinathan,
        OrDror,
        /// <summary>
        /// body recovered
        /// </summary>
        PeriChaim,
        /// <summary>
        /// body recovered
        /// </summary>
        PopplewellNadav,
        /// <summary>
        /// Israeli-American, released
        /// </summary>
        RaananJudith,
        /// <summary>
        /// Israeli-American, released
        /// </summary>
        RaananNatalie,
        /// <summary>
        /// rescued
        /// </summary>
        RadouxOriónHernández,
        RudaeffLior,
        /// <summary>
        /// body recovered, executed by Hamas
        /// </summary>
        SarusiAlmog,
        /// <summary>
        /// body recovered, killed by friendly fire while surrendering
        /// </summary>
        ShamrizAlon,
        /// <summary>
        /// released
        /// </summary>
        SharabiEli,
        ShaulOron,
        /// <summary>
        /// released
        /// </summary>
        ShemTovOmer,
        /// <summary>
        /// bodies recovered, killed in IDF airstrike (Sergeant)
        /// </summary>
        ShermanRon,
        /// <summary>
        /// released
        /// </summary>
        ShohamTal,
        ShtiviIdan,
        /// <summary>
        /// released
        /// </summary>
        SiegelSamuelKeith,
        /// <summary>
        /// released
        /// </summary>
        SteinbrecherDoron,
        /// <summary>
        /// body recovered
        /// </summary>
        SvirskyItai,
        /// <summary>
        /// body recovered, killed by friendly fire while surrendering
        /// </summary>
        TalalkaSamer,
        /// <summary>
        /// body recovered, killed in IDF airstrike (civilian)
        /// </summary>
        ToledanoElia,
        /// <summary>
        /// released
        /// </summary>
        TrupanobAlexanderSasha,
        WeissIlan,
        /// <summary>
        /// recovered body
        /// </summary>
        WeissYehudit,
        /// <summary>
        /// released
        /// </summary>
        WenkertOmer,
        /// <summary>
        /// rescued (hanan?)
        /// </summary>
        YablonkaChanan,
        /// <summary>
        /// body released
        /// </summary>
        YahalomiOhad,
        /// <summary>
        /// released
        /// </summary>
        YehoudArbel,
        YehoudDolev,
        /// <summary>
        /// body recovered, executed by Hamas
        /// </summary>
        YerushalmiEden,
        /// <summary>
        /// released elderly Israli woman (goes by Cooper)
        /// </summary>
        YitzhakNuritCooper,
        ZangaukerMatan,
        /// <summary>
        /// rescued
        /// </summary>
        ZivShlomi,

        /// <summary>
        /// released
        /// </summary>
        RomneoSurasak,
        /// <summary>
        /// released
        /// </summary>
        SaethaoBannawat,
        /// <summary>
        /// released
        /// </summary>
        SriaounWatchara,
        /// <summary>
        /// released
        /// </summary>
        ThaennaPongsak,
        /// <summary>
        /// released
        /// </summary>
        SuwannakhamSathian,
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
                public static class November24 { }

                /// <summary>
                /// Noam Avigdori, Sharon Avigdori, Emily Hand, Shoshan Haran, Alma Or, Noam Or, Maya Regev, Adi Shoham
                /// Nave Shoham, Yahel Shoham, Hila Rotem Shoshani, Noga Weiss, Shiri Weiss, Anucha Angkaew, Komkrit Chombua, Manee Jirachart
                /// Natthaporn Onkaew
                /// </summary>
                [Number(17)]
                public static class November25 { }

                /// <summary>
                /// Elma Avraham, Hagar Brodutch, Ofri Brodutch, Uriah Brodutch, Yuval Brodutch, Abigail Edan, Dafna Elyakim, Ela Elyakim
                /// Agam Goldstein-Almog, Chen Goldstein-Almog, Gal Goldstein-Almog, Tal Goldstein-Almog, Roni Kriboy, Adrienne Siegel, Surin Kesoognern, Pornsawan Pinakalow
                /// Vichian Temthong
                /// </summary>
                [Number(17)]
                public static class November26 { }

                /// <summary>
                /// Sharon Olani Cunio, Emma Cunion, Yuli Cunio, Karina Engel-Bart, Mika Engel, Yuval Engel, Or Jacob, Yagil Jacob
                /// Erez Kalderon, Sahar Kalderon, Eitan Yahaloni
                /// </summary>
                [Number(11)]
                public static class November27 { }

                /// <summary>
                /// Noralin Babadilla, Ditza Heiman, Rimon Kirsht, Gabriela Leimberg, Mia Leimbert, Clara Merman, Tamar Metzger, Ofelia Roitman
                /// Ada Sagi, Owas Suriyasri, Meirav Tal, Pattanayut Tornsokree
                /// </summary>
                [Number(12)]
                public static class November28A { }

                /// <summary>
                /// Rimon Buchshstav (not listed on CNN site)
                /// </summary>
                [Number(1)]
                public static class November28B { }

                /// <summary>
                /// Ofir Tzarfati, Liat Beinin, Raz Ben-Ami, Ofir Engel, Yarden Roman-Gat, Liam Or, Itay Regev, Raaya Rotem
                /// Amit Shani, Gali Tarshansky, Moran Stela Yanai, Paiboon Ratanin, Kong Saelao, Chalermchai Sangkaew, Jakkrapan Srikeina
                /// Yelena Troufanov, Irena Tati (mother of Yelena Troufanov)
                /// </summary>
                [Number(17)]
                public static class November29 { }

                /// <summary>
                /// Siblings Bilal (18) and Aisha Ziyadne (17), Ilana Gritzewsky, Nili Margalit; Shani Goren, Amit Soussana (50), Mia Schem (21)
                /// Sapir Cohen (girlfriend of Alexandre (Sasha) Troufanov)
                /// </summary>
                [Number(8)]
                public static class November30 { }
            }

            /// <summary>
            /// The IDF and Shin Bet announce they have recovered the body of deceased hostage Ophir Sarfati in recent days
            /// </summary>
            [Number(1)]
            public static class November29 { }

            /// <summary>
            /// The IDF recovers the bodies of Eden Zechariah and Staff Sergeant Major Ziv Dado in underground tunnels in Jabalia, Gaza
            /// </summary>
            [Number(2)]
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
