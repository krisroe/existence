using Existence.Earth.Human.EthnicGroups;
using Existence.Earth.Human.EthnicGroups.Jewish.Level1;
using Existence.Earth.Human.EthnicGroups.Jewish.Level2;
using Existence.Earth.Human.EthnicGroups.Jewish.Level3;
using Existence.Earth.Human.People;
using Existence.Time;
using System;

namespace Existence.Earth.Countries.Israel.Politics
{
    public class ZionistAttribute : Attribute
    {
    }

    public enum ZionistTypes
    {
        /// <summary>
        /// embraces Zionism as an ideology
        /// </summary>
        Ideological,

        /// <summary>
        /// formally affiliated with the Zionist movement (e.g. World Zionist Organization membership) while
        /// keeping the traditional Haredi reservations about Zionist ideology
        /// </summary>
        Formal,
    }

    public class ZionistTypeAttribute : Attribute
    {
        public ZionistTypes ZionistType { get; set; }
        public ZionistTypeAttribute(ZionistTypes ZionistType)
        {
            this.ZionistType = ZionistType;
        }
    }

    public enum Politicians
    {
        [Gender(Gender.Male)]
        [EthnicGroups((int)WorldEthnicGroups.Arab)]
        AbbasMansour,

        [Gender(Gender.Male)]
        [EthnicGroups((int)WorldEthnicGroups.Arab)]
        AbuShehadehSami,

        /// <summary>
        /// born in Kfar Tavor to an Ashkenazi family
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel1.Ashkenazi)]
        AllonYigal,

        /// <summary>
        /// father from Lithuania, mother from Poland
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Litvak, (int)JewishEthnicDivisionsLevel2.Polish)]
        BarakEhud,

        /// <summary>
        /// born in Brest-Litovsk
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Litvak)]
        BeginMenachem,

        /// <summary>
        /// born in Plonsk, Poland
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Polish)]
        BenGurionDavid,

        /// <summary>
        /// father from Iraq, mother from Iraqi Kurdistan
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Bavlim, (int)JewishEthnicDivisionsLevel2.Kurdish)]
        BenGvirItamar,

        /// <summary>
        /// parents were American immigrants from San Francisco
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel1.Ashkenazi)]
        BennettNaftali,

        /// <summary>
        /// born in Meknes, Morocco
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Moroccan)]
        DeriAryeh,

        /// <summary>
        /// parents immigrated from Morocco
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Moroccan)]
        EisenkotGadi,

        /// <summary>
        /// born in Oratov, near Kyiv
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Ukrainian)]
        EshkolLevi,

        /// <summary>
        /// parents were Polish Holocaust survivors
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Polish)]
        GafniMoshe,

        /// <summary>
        /// born in Vilnius, Lithuania
        /// </summary>
        [Gender(Gender.Female)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Litvak)]
        GalonZehava,

        /// <summary>
        /// father from Transylvania, mother from Hungary
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Hungarian)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel3.Transylvanian)]
        GantzBenny,

        /// <summary>
        /// father's family fled Nazi Germany in 1935, maternal grandfather immigrated from Ukraine in 1921
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Yekke, (int)JewishEthnicDivisionsLevel2.Ukrainian)]
        GolanYair,

        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel1.Ashkenazi)]
        GoldknopfYitzhak,

        /// <summary>
        /// father, Tommy Lapid, was a Hungarian-speaking Jew from Novi Sad, Yugoslavia
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Hungarian)]
        LapidYair,

        /// <summary>
        /// born in Kishinev, Moldova
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Bessarabian)]
        LiebermanAvigdor,

        /// <summary>
        /// born Avigdor Fischheimer to Holocaust survivors
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel1.Ashkenazi)]
        MaozAvi,

        /// <summary>
        /// born in Kyiv
        /// </summary>
        [Gender(Gender.Female)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Ukrainian)]
        MeirGolda,

        /// <summary>
        /// father's family (Mileikowsky) from Kreva, mother's parents from Kaunas
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Litvak)]
        [CurrentPrimeMinister]
        NetanyahuBenjamin,

        [Gender(Gender.Male)]
        [EthnicGroups((int)WorldEthnicGroups.Arab)]
        OdehAyman,

        /// <summary>
        /// parents were Russian Jews who grew up in Harbin, China
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel1.Ashkenazi)]
        OlmertEhud,

        /// <summary>
        /// born in Wiszniew (Vishnyeva), now Belarus
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Litvak)]
        PeresShimon,

        /// <summary>
        /// father from Ukraine, mother from Mogilev, Belarus
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Ukrainian, (int)JewishEthnicDivisionsLevel2.Litvak)]
        RabinYitzhak,

        /// <summary>
        /// father an Ashkenazi immigrant from Argentina, mother from a Bukharan family
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel1.Ashkenazi)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Bukharan)]
        SaarGideon,

        /// <summary>
        /// born in Ruzhany, now Belarus
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Litvak)]
        ShamirYitzhak,

        /// <summary>
        /// born in Kherson, Ukraine
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Ukrainian)]
        SharettMoshe,

        /// <summary>
        /// parents from Brest-Litovsk and Mogilev, now Belarus
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Litvak)]
        SharonAriel,

        /// <summary>
        /// paternal ancestors from Smotrych, Ukraine; maternal grandfather from a 13th-generation Jerusalem family
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Ukrainian, (int)JewishEthnicDivisionsLevel2.Palestinian)]
        SmotrichBezalel,

        [Gender(Gender.Male)]
        [EthnicGroups((int)WorldEthnicGroups.Arab)]
        TibiAhmad,
    }

    /// <summary>
    /// prime ministerial tenures, counting non-consecutive terms separately and including interim and acting
    /// tenures, some of which overlap. Israel officially numbers prime ministers by person (Netanyahu is the 9th).
    /// The provisional government is v0, separate from Ben-Gurion's elected governments starting at v1
    /// </summary>
    public static class PrimeMinisters
    {
        /// <summary>
        /// provisional government, from independence until the 1st government took office after the 1949 election
        /// </summary>
        [PrimeMinister((int)Politicians.BenGurionDavid, 1948, 5, 14, 1949, 3, 10)]
        public static class v0 { }

        /// <summary>
        /// 1st-4th governments
        /// </summary>
        [PrimeMinister((int)Politicians.BenGurionDavid, 1949, 3, 10, 1953, 12, 7)]
        public static class v1 { }

        /// <summary>
        /// took over when Ben-Gurion stepped down on 1953-12-07, formed his own government on 1954-01-26
        /// </summary>
        [PrimeMinister((int)Politicians.SharettMoshe, 1953, 12, 7, 1955, 11, 3)]
        public static class v2 { }

        [PrimeMinister((int)Politicians.BenGurionDavid, 1955, 11, 3, 1963, 6, 26)]
        public static class v3 { }

        /// <summary>
        /// died in office
        /// </summary>
        [PrimeMinister((int)Politicians.EshkolLevi, 1963, 6, 26, 1969, 2, 26)]
        public static class v4 { }

        /// <summary>
        /// interim prime minister after Eshkol's death
        /// </summary>
        [PrimeMinister((int)Politicians.AllonYigal, 1969, 2, 26, 1969, 3, 17)]
        public static class v5 { }

        [PrimeMinister((int)Politicians.MeirGolda, 1969, 3, 17, 1974, 6, 3)]
        public static class v6 { }

        /// <summary>
        /// prime minister only on paper from 1977-04-22, after stepping aside over his wife's US bank account, while Peres
        /// was unofficially acting prime minister
        /// </summary>
        [PrimeMinister((int)Politicians.RabinYitzhak, 1974, 6, 3, 1977, 6, 21)]
        [PaperPrimeMinister((int)Politicians.RabinYitzhak, 1977, 4, 22, 1977, 6, 21)]
        public static class v7 { }

        /// <summary>
        /// unofficially acting prime minister after Rabin stepped aside, while Rabin remained prime minister on paper
        /// </summary>
        [ActingPrimeMinister((int)Politicians.PeresShimon, 1977, 4, 22, 1977, 6, 21)]
        public static class v8 { }

        [PrimeMinister((int)Politicians.BeginMenachem, 1977, 6, 21, 1983, 10, 10)]
        public static class v9 { }

        [PrimeMinister((int)Politicians.ShamirYitzhak, 1983, 10, 10, 1984, 9, 13)]
        public static class v10 { }

        /// <summary>
        /// rotation agreement with Shamir in a national unity government
        /// </summary>
        [PrimeMinister((int)Politicians.PeresShimon, 1984, 9, 13, 1986, 10, 20)]
        public static class v11 { }

        [PrimeMinister((int)Politicians.ShamirYitzhak, 1986, 10, 20, 1992, 7, 13)]
        public static class v12 { }

        /// <summary>
        /// assassinated in office
        /// </summary>
        [PrimeMinister((int)Politicians.RabinYitzhak, 1992, 7, 13, 1995, 11, 4)]
        public static class v13 { }

        /// <summary>
        /// interim prime minister after Rabin's assassination. The Knesset approved his government on 1995-11-22
        /// </summary>
        [PrimeMinister((int)Politicians.PeresShimon, 1995, 11, 4, 1996, 6, 18)]
        public static class v14 { }

        [PrimeMinister((int)Politicians.NetanyahuBenjamin, 1996, 6, 18, 1999, 7, 6)]
        public static class v15 { }

        [PrimeMinister((int)Politicians.BarakEhud, 1999, 7, 6, 2001, 3, 7)]
        public static class v16 { }

        /// <summary>
        /// incapacitated by a stroke on 2006-01-04 and prime minister only on paper until declared permanently
        /// incapacitated on 2006-04-14, while Olmert was acting prime minister
        /// </summary>
        [PrimeMinister((int)Politicians.SharonAriel, 2001, 3, 7, 2006, 4, 14)]
        [PaperPrimeMinister((int)Politicians.SharonAriel, 2006, 1, 4, 2006, 4, 14)]
        public static class v17 { }

        /// <summary>
        /// acting prime minister from 2006-01-04 while Sharon was incapacitated, interim from 2006-04-14 once Sharon was
        /// declared permanently incapacitated, prime minister from 2006-05-04
        /// </summary>
        [PrimeMinister((int)Politicians.OlmertEhud, 2006, 1, 4, 2009, 3, 31)]
        [ActingPrimeMinister((int)Politicians.OlmertEhud, 2006, 1, 4, 2006, 4, 14)]
        public static class v18 { }

        [PrimeMinister((int)Politicians.NetanyahuBenjamin, 2009, 3, 31, 2021, 6, 13)]
        public static class v19 { }

        /// <summary>
        /// rotation agreement with Lapid
        /// </summary>
        [PrimeMinister((int)Politicians.BennettNaftali, 2021, 6, 13, 2022, 6, 30)]
        public static class v20 { }

        [PrimeMinister((int)Politicians.LapidYair, 2022, 7, 1, 2022, 12, 29)]
        public static class v21 { }

        [PrimeMinister((int)Politicians.NetanyahuBenjamin, 2022, 12, 29)]
        [CurrentPrimeMinister]
        public static class v22 { }
    }

    public static class Knesset
    {
        [ElectionDate(2022, 11, 1)]
        [ParliamentaryElectoralThreshold(3.25)]
        public static class v25
        {
            /// <summary>
            /// Knesset factions, plus parties whose lists fell below the electoral threshold
            /// </summary>
            public enum PoliticalParties
            {
                /// <summary>
                /// Arab nationalist party that ran separately after the Joint List dissolved shortly before the 2022 election
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.AbuShehadehSami)]
                [VotePercentage(2.91)]
                [BelowElectoralThreshold]
                [NumberOfSeats(0)]
                Balad,

                /// <summary>
                /// formerly National Unity, which New Hope split from in 2024
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.GantzBenny)]
                [JointListVotePercentage(9.08)]
                [JointListNumberOfSeats(12)]
                BlueAndWhiteNationalUnity,

                /// <summary>
                /// joint faction of Hadash and Ta'al
                /// </summary>
                [Factions((int)Factions.Hadash, (int)Factions.Taal)]
                [VotePercentage(3.75)]
                [NumberOfSeats(5)]
                HadashTaal,

                /// <summary>
                /// approved a merger with Meretz into The Democrats in 2024, but its members still sit as Labor
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.GolanYair)]
                [VotePercentage(3.69)]
                [NumberOfSeats(4)]
                Labor,

                /// <summary>
                /// main Israeli conservative party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.NetanyahuBenjamin)]
                [VotePercentage(23.41)]
                [NumberOfSeats(32)]
                Likud,

                /// <summary>
                /// left-wing Zionist party that merged with Labor into The Democrats in 2024
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.GalonZehava)]
                [VotePercentage(3.16)]
                [BelowElectoralThreshold]
                [NumberOfSeats(0)]
                Meretz,

                /// <summary>
                /// ran on the National Unity list with Blue and White in 2022, then split into its own faction in 2024.
                /// Merger into Likud agreed in 2025, but not approved by the Knesset House Committee
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.SaarGideon)]
                [JointListVotePercentage(9.08)]
                [JointListNumberOfSeats(12)]
                NewHope,

                /// <summary>
                /// ran on the Religious Zionist slate in 2022, then split into its own faction
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.MaozAvi)]
                [JointListVotePercentage(10.84)]
                [JointListNumberOfSeats(14)]
                Noam,

                /// <summary>
                /// ran on the Religious Zionist slate in 2022, then split into its own faction
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.BenGvirItamar)]
                [JointListVotePercentage(10.84)]
                [JointListNumberOfSeats(14)]
                OtzmaYehudit,

                /// <summary>
                /// religious Zionist, pro-settlement party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.SmotrichBezalel)]
                [JointListVotePercentage(10.84)]
                [JointListNumberOfSeats(14)]
                ReligiousZionistParty,

                /// <summary>
                /// Sephardi and Mizrahi Haredi party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Formal)]
                [PoliticalPartyLeader((int)Politicians.DeriAryeh)]
                [VotePercentage(8.25)]
                [NumberOfSeats(11)]
                Shas,

                /// <summary>
                /// Ra'am
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.AbbasMansour)]
                [VotePercentage(4.07)]
                [NumberOfSeats(5)]
                UnitedArabList,

                /// <summary>
                /// joint faction of Agudat Yisrael and Degel HaTorah
                /// </summary>
                [Factions((int)Factions.AgudatYisrael, (int)Factions.DegelHaTorah)]
                [VotePercentage(5.88)]
                [NumberOfSeats(7)]
                UnitedTorahJudaism,

                /// <summary>
                /// centrist, largest opposition party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.LapidYair)]
                [VotePercentage(17.79)]
                [NumberOfSeats(24)]
                YeshAtid,

                /// <summary>
                /// secular right-wing party with a base among Russian-speaking immigrants
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.LiebermanAvigdor)]
                [VotePercentage(4.48)]
                [NumberOfSeats(6)]
                YisraelBeiteinu,
            }

            /// <summary>
            /// component parties of the joint factions in the 25th Knesset
            /// </summary>
            public enum Factions
            {
                /// <summary>
                /// Hasidic Haredi party, part of United Torah Judaism
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.GoldknopfYitzhak)]
                AgudatYisrael,

                /// <summary>
                /// Lithuanian (non-Hasidic) Haredi party, part of United Torah Judaism
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.GafniMoshe)]
                DegelHaTorah,

                /// <summary>
                /// Jewish-Arab socialist front led by the Israeli Communist Party, part of Hadash-Ta'al
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.OdehAyman)]
                Hadash,

                /// <summary>
                /// Arab Movement for Renewal, part of Hadash-Ta'al
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.TibiAhmad)]
                Taal,
            }

            /// <summary>
            /// how the leftover seats were distributed. Surplus vote agreements come first, ordered by the combined votes
            /// of both sides, with one PoliticalParties attribute per side listing every party on that side's list.
            /// Lists that passed the threshold without an agreement follow, ordered by votes. Under the Bader-Ofer
            /// method, the lists that passed the threshold had 4,347,342 votes between them, for a quota of about
            /// 36,228 votes per seat. Whole quotas filled 113 seats, and the 7 leftover seats went one at a time to the
            /// list (or pair of lists in an agreement) with the highest votes per seat if it got one more, then within
            /// a pair to the list with the higher average:
            /// 114th: Shas + UTJ -> Shas
            /// 115th: Yesh Atid + National Unity -> National Unity
            /// 116th: Likud + Religious Zionism -> Likud
            /// 117th: Hadash-Ta'al (no agreement)
            /// 118th: Yisrael Beiteinu (no agreement)
            /// 119th: Yesh Atid + National Unity -> Yesh Atid
            /// 120th: Likud + Religious Zionism -> Likud
            /// Without any agreements, the 120th seat would have gone to Labor instead of Likud.
            /// </summary>
            public static class LeftoverSeatDistribution
            {
                /// <summary>
                /// surplus vote agreement, 1,631,806 combined votes. Both leftover seats (116th and 120th) went to Likud:
                /// Likud 30 -> 32, Religious Zionism stayed at 14
                /// </summary>
                [PoliticalParties((int)PoliticalParties.Likud)]
                [PoliticalParties((int)PoliticalParties.ReligiousZionistParty, (int)PoliticalParties.OtzmaYehudit, (int)PoliticalParties.Noam)]
                public static class No1 { }

                /// <summary>
                /// surplus vote agreement, 1,279,917 combined votes. One leftover seat each: National Unity 11 -> 12
                /// (115th), Yesh Atid 23 -> 24 (119th)
                /// </summary>
                [PoliticalParties((int)PoliticalParties.YeshAtid)]
                [PoliticalParties((int)PoliticalParties.BlueAndWhiteNationalUnity, (int)PoliticalParties.NewHope)]
                public static class No2 { }

                /// <summary>
                /// surplus vote agreement, 673,158 combined votes. One leftover seat (114th) went to Shas: Shas 10 -> 11,
                /// UTJ stayed at 7
                /// </summary>
                [PoliticalParties((int)PoliticalParties.Shas)]
                [PoliticalParties((int)PoliticalParties.UnitedTorahJudaism)]
                public static class No3 { }

                /// <summary>
                /// surplus vote agreement, 326,785 combined votes. Annulled when Meretz fell below the threshold, so Labor
                /// competed for leftover seats alone and got none, staying at 4
                /// </summary>
                [PoliticalParties((int)PoliticalParties.Labor)]
                [PoliticalParties((int)PoliticalParties.Meretz)]
                public static class No4 { }

                /// <summary>
                /// no agreement, 213,687 votes. Got one leftover seat (118th): 5 -> 6
                /// </summary>
                [PoliticalParties((int)PoliticalParties.YisraelBeiteinu)]
                public static class No5 { }

                /// <summary>
                /// no agreement, 194,047 votes. Got no leftover seat, staying at 5
                /// </summary>
                [PoliticalParties((int)PoliticalParties.UnitedArabList)]
                public static class No6 { }

                /// <summary>
                /// no agreement, 178,735 votes. Got one leftover seat (117th): 4 -> 5
                /// </summary>
                [PoliticalParties((int)PoliticalParties.HadashTaal)]
                public static class No7 { }
            }
        }
    }
}
