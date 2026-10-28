using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Human;
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
        /// replaced Moshe Gafni as chairman of Degel HaTorah in September 2026
        /// </summary>
        [Gender(Gender.Male)]
        AsherYaakov,

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
        /// leader of Zehut
        /// </summary>
        [Gender(Gender.Male)]
        FeiglinMoshe,

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
        /// leader of The Reservists
        /// </summary>
        [Gender(Gender.Male)]
        HendelYoaz,

        /// <summary>
        /// replaced Ayman Odeh as chairman of Hadash
        /// </summary>
        [Gender(Gender.Male)]
        [EthnicGroups((int)WorldEthnicGroups.Arab)]
        JabareenYousef,

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
        SaʼarGideon,

        /// <summary>
        /// father's side Iraqi Jewish, mother's side Ashkenazi with Russian and Romanian roots
        /// </summary>
        [Gender(Gender.Female)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel1.Ashkenazi)]
        [EthnicGroups((int)JewishEthnicDivisionsLevel2.Bavlim, (int)JewishEthnicDivisionsLevel2.Romanian)]
        ShakedAyelet,

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

        /// <summary>
        /// former IDF general, leader of Amcha Yisrael
        /// </summary>
        [Gender(Gender.Male)]
        WinterOfer,

        /// <summary>
        /// economist, leader of the New Economic Party
        /// </summary>
        [Gender(Gender.Male)]
        ZelekhaYaron,
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

    /// <summary>
    /// parties that exist as independent things outside of the regular merging and joint listing that takes place
    /// from one election to the next. The franchises can be applied to parties and factions when not ambiguous.
    /// </summary>
    public enum PoliticalPartyFranchises
    {
        /// <summary>
        /// secular pan-Arab
        /// </summary>
        Balad,

        /// <summary>
        /// socialist and associated with the Israeli Communist Party, but has real Jewish presence
        /// </summary>
        Hadash,

        /// <summary>
        /// the primary Israeli conservative party
        /// </summary>
        Likud,

        /// <summary>
        /// religious Zionist (Hardal), focused on Jewish identity and the traditional family, and opposed to LGBT rights
        /// </summary>
        Noam,

        /// <summary>
        /// United Arab List. Islamist (religious)
        /// </summary>
        Raʼam,

        /// <summary>
        /// Sephardi and Mizrahi Haredi
        /// </summary>
        Shas,

        /// <summary>
        /// secular Arab nationalist
        /// </summary>
        Taʼal,
    }

    public static class Knesset
    {
        [ElectionDate(2022, 11, 1)]
        [ParliamentaryElectoralThreshold(3.25)]
        [NumberOfMembers(120)]
        public static class v25
        {
            /// <summary>
            /// Knesset factions, plus parties whose lists fell below the electoral threshold. The prime minister's party
            /// comes first, then the other parties in the initial coalition, then the parties outside it, with the Arab
            /// parties last. Largest number of seats first within each group
            /// </summary>
            public enum PoliticalParties
            {
                /// <summary>
                /// main Israeli conservative party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.NetanyahuBenjamin)]
                [VotePercentage(23.41)]
                [NumberOfSeats(32)]
                [Government]
                [InGovernmentCoalitionAtNextElection]
                [InGovernmentExecutiveAtNextElection]
                Likud,

                /// <summary>
                /// Sephardi and Mizrahi Haredi party. Its ministers resigned from the government in July 2025 over the
                /// failure to pass a draft exemption law for yeshiva students, but it stayed in the coalition
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Formal)]
                [PoliticalPartyLeader((int)Politicians.DeriAryeh)]
                [VotePercentage(8.25)]
                [NumberOfSeats(11)]
                [SometimesInGovernment]
                [InGovernmentCoalitionAtStart]
                [GovernmentTenure(2022, 12, 29, 2025, 7, 17)]
                [CoalitionOutsideGovernment(2025, 7, 17)]
                [InGovernmentCoalitionAtNextElection]
                Shas,

                /// <summary>
                /// joint faction of Agudat Yisrael and Degel HaTorah. Left the government and the coalition in July 2025
                /// over the failure to pass a draft exemption law for yeshiva students
                /// </summary>
                [Factions((int)Factions.AgudatYisrael, (int)Factions.DegelHaTorah)]
                [NumberOfSeats(7)]
                [JointList((int)JointLists.UnitedTorahJudaism)]
                [SometimesInGovernment]
                [InGovernmentCoalitionAtStart]
                [GovernmentTenure(2022, 12, 29, 2025, 7, 15)]
                UnitedTorahJudaism,

                /// <summary>
                /// pro-settlement party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.SmotrichBezalel)]
                [JointList((int)JointLists.ReligiousZionismOtzmaYehudit)]
                [RoughJointListVotePercentage(5.42)]
                [NumberOfSeats(7)]
                [Government]
                [InGovernmentCoalitionAtNextElection]
                [InGovernmentExecutiveAtNextElection]
                ReligiousZionistParty,

                /// <summary>
                /// ran on the Religious Zionist slate in 2022, then split into its own faction. Left the government over
                /// the January 2025 Gaza ceasefire, and returned when the fighting resumed in March 2025
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.BenGvirItamar)]
                [JointList((int)JointLists.ReligiousZionismOtzmaYehudit)]
                [RoughJointListVotePercentage(4.65)]
                [NumberOfSeats(6)]
                [SometimesInGovernment]
                [InGovernmentCoalitionAtStart]
                [GovernmentTenure(2022, 12, 29, 2025, 1, 19)]
                [GovernmentTenure(2025, 3, 19)]
                [InGovernmentCoalitionAtNextElection]
                [InGovernmentExecutiveAtNextElection]
                OtzmaYehudit,

                /// <summary>
                /// ran on the Religious Zionist slate in 2022, then split into its own faction. Maoz resigned as deputy
                /// minister in February 2023 over the Jewish National Identity Authority but stayed in the coalition,
                /// returned in May 2023, then quit the government and the coalition in March 2025
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.MaozAvi)]
                [JointList((int)JointLists.ReligiousZionismOtzmaYehudit)]
                [RoughJointListVotePercentage(0.77)]
                [NumberOfSeats(1)]
                [SometimesInGovernment]
                [InGovernmentCoalitionAtStart]
                [GovernmentTenure(2022, 12, 29, 2023, 2, 28)]
                [CoalitionOutsideGovernment(2023, 2, 28, 2023, 5, 25)]
                [GovernmentTenure(2023, 5, 25, 2025, 3, 24)]
                Noam,

                /// <summary>
                /// centrist, largest opposition party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.LapidYair)]
                [VotePercentage(17.79)]
                [NumberOfSeats(24)]
                [Opposition]
                YeshAtid,

                /// <summary>
                /// formerly National Unity, which New Hope split from in 2024. Joined the emergency war government after
                /// the October 7 attack, and left it in June 2024
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.GantzBenny)]
                [JointList((int)JointLists.NationalUnity)]
                [RoughJointListVotePercentage(5.78)]
                [NumberOfSeats(8)]
                [SometimesInGovernment]
                [GovernmentTenure(2023, 10, 12, 2024, 6, 9)]
                BlueAndWhiteNationalUnity,

                /// <summary>
                /// secular right-wing party with a base among Russian-speaking immigrants
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.LiebermanAvigdor)]
                [VotePercentage(4.48)]
                [NumberOfSeats(6)]
                [Opposition]
                YisraelBeiteinu,

                /// <summary>
                /// ran on the National Unity list with Blue and White in 2022, then split into its own faction in 2024.
                /// Merger into Likud agreed in 2025, but not approved by the Knesset House Committee. Joined the emergency
                /// war government as part of National Unity, split from it on 2024-03-13, and left the government on
                /// 2024-03-25 when Sa'ar was refused a seat in the war cabinet. Rejoined the government on its own
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.SaʼarGideon)]
                [JointList((int)JointLists.NationalUnity)]
                [RoughJointListVotePercentage(3.30)]
                [NumberOfSeats(4)]
                [SometimesInGovernment]
                [GovernmentTenure(2023, 10, 12, 2024, 3, 25)]
                [GovernmentTenure(2024, 9, 30)]
                [InGovernmentCoalitionAtNextElection]
                [InGovernmentExecutiveAtNextElection]
                NewHope,

                /// <summary>
                /// approved a merger with Meretz into The Democrats in 2024, but its members still sit as Labor
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.GolanYair)]
                [VotePercentage(3.69)]
                [NumberOfSeats(4)]
                [Opposition]
                Labor,

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
                /// religious Zionist party, led in 2022 by Ayelet Shaked after Yamina broke up. Shaked said she would
                /// probably recommend Netanyahu, and backed a Netanyahu-led right-wing government after the election
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.ShakedAyelet)]
                [VotePercentage(1.19)]
                [BelowElectoralThreshold]
                [NumberOfSeats(0)]
                TheJewishHome,

                [PoliticalPartyFranchise((int)PoliticalPartyFranchises.Raʼam)]
                [PoliticalPartyLeader((int)Politicians.AbbasMansour)]
                [VotePercentage(4.07)]
                [NumberOfSeats(5)]
                [Opposition]
                UnitedArabList,

                /// <summary>
                /// joint faction of Hadash and Ta'al
                /// </summary>
                [Factions((int)Factions.Hadash, (int)Factions.Taʼal)]
                [NumberOfSeats(5)]
                [JointList((int)JointLists.HadashTaʼal)]
                [Opposition]
                HadashTaʼal,

                /// <summary>
                /// Arab nationalist party that ran separately after the Joint List dissolved shortly before the 2022 election
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.AbuShehadehSami)]
                [VotePercentage(2.91)]
                [BelowElectoralThreshold]
                [NumberOfSeats(0)]
                Balad,
            }

            /// <summary>
            /// component parties of the joint factions in the 25th Knesset
            /// </summary>
            public enum Factions
            {
                /// <summary>
                /// Hasidic Haredi party, part of United Torah Judaism. Goldknopf resigned from the cabinet on 2025-06-12,
                /// and the party left the government the day after Degel HaTorah
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.GoldknopfYitzhak)]
                [JointList((int)JointLists.UnitedTorahJudaism)]
                [RoughJointListVotePercentage(3.36)]
                [NumberOfSeats(4)]
                [SometimesInGovernment]
                [InGovernmentCoalitionAtStart]
                [GovernmentTenure(2022, 12, 29, 2025, 7, 15)]
                AgudatYisrael,

                /// <summary>
                /// Lithuanian (non-Hasidic) Haredi party, part of United Torah Judaism
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.GafniMoshe)]
                [JointList((int)JointLists.UnitedTorahJudaism)]
                [RoughJointListVotePercentage(2.52)]
                [NumberOfSeats(3)]
                [SometimesInGovernment]
                [InGovernmentCoalitionAtStart]
                [GovernmentTenure(2022, 12, 29, 2025, 7, 14)]
                DegelHaTorah,

                /// <summary>
                /// Jewish-Arab socialist front led by the Israeli Communist Party, part of Hadash-Ta'al
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.OdehAyman)]
                [JointList((int)JointLists.HadashTaʼal)]
                [RoughJointListVotePercentage(2.81)]
                [NumberOfSeats(4)]
                [Opposition]
                Hadash,

                /// <summary>
                /// Arab Movement for Renewal, part of Hadash-Ta'al
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.TibiAhmad)]
                [JointList((int)JointLists.HadashTaʼal)]
                [RoughJointListVotePercentage(0.94)]
                [NumberOfSeats(1)]
                [Opposition]
                Taʼal,
            }

            /// <summary>
            /// joint lists in the 2022 election, each pointing to the parties or factions on it. Lists that split into
            /// separate Knesset factions point to PoliticalParties; lists that still sit as one faction point to that
            /// PoliticalParties entry and to their component Factions
            /// </summary>
            public enum JointLists
            {
                /// <summary>
                /// what remained of the Joint List after Balad and Ra'am ran separately. Still sits as one faction. Its
                /// leftover seat, 5th on the list, went to Youssef Atauna of Hadash, who gave it up in June 2025 to Ta'al's
                /// Samir Bin Said under a rotation agreement
                /// </summary>
                [PoliticalParties((int)PoliticalParties.HadashTaʼal)]
                [Factions((int)Factions.Hadash, (int)Factions.Taʼal)]
                [JointListVotePercentage(3.75)]
                [JointListNumberOfSeats(5)]
                HadashTaʼal,

                /// <summary>
                /// Blue and White and New Hope, joined by Gadi Eisenkot and Yamina MKs Matan Kahana and Shirly Pinto.
                /// New Hope split into its own faction in 2024. Its leftover seat, 12th on the list, went to Alon Schuster
                /// of Blue and White
                /// </summary>
                [PoliticalParties((int)PoliticalParties.BlueAndWhiteNationalUnity, (int)PoliticalParties.NewHope)]
                [JointListVotePercentage(9.08)]
                [JointListNumberOfSeats(12)]
                NationalUnity,

                /// <summary>
                /// technical bloc to pass the threshold. Split into three factions on 2022-11-20 under a pre-election
                /// agreement
                /// </summary>
                [PoliticalParties((int)PoliticalParties.ReligiousZionistParty, (int)PoliticalParties.OtzmaYehudit, (int)PoliticalParties.Noam)]
                [JointListVotePercentage(10.84)]
                [JointListNumberOfSeats(14)]
                ReligiousZionismOtzmaYehudit,

                /// <summary>
                /// long-standing Haredi alliance. Still sits as one faction
                /// </summary>
                [PoliticalParties((int)PoliticalParties.UnitedTorahJudaism)]
                [Factions((int)Factions.AgudatYisrael, (int)Factions.DegelHaTorah)]
                [JointListVotePercentage(5.88)]
                [JointListNumberOfSeats(7)]
                UnitedTorahJudaism,
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
                [PoliticalParties((int)PoliticalParties.HadashTaʼal)]
                public static class No7 { }
            }
        }

        [ElectionDate(2026, 10, 27)]
        [ParliamentaryElectoralThreshold(3.25)]
        [NumberOfMembers(120)]
        public static class v26
        {
            /// <summary>
            /// major lists running in the 2026 election, one entry per list on the ballot. The component parties of joint
            /// lists are in Factions. Minor lists not expected to pass the threshold are left out
            /// </summary>
            public enum PoliticalParties
            {
                /// <summary>
                /// new right-wing party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.WinterOfer)]
                [NumberOfSeatsIPredicted(0)]
                AmchaYisrael,

                /// <summary>
                /// submitted a list, then withdrew from the election on 2026-10-19
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.GantzBenny)]
                [NumberOfSeatsIPredicted(0)]
                BlueAndWhite,

                /// <summary>
                /// revived Joint List of Hadash, Ta'al and Balad
                /// </summary>
                [JointList((int)JointLists.JointList)]
                [Factions((int)Factions.Hadash, (int)Factions.Taʼal, (int)Factions.Balad)]
                [NumberOfSeatsIPredicted(9)]
                JointList,

                /// <summary>
                /// includes New Hope, which merged into Likud. Gideon Sa'ar is 7th on the list
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.NetanyahuBenjamin)]
                [NumberOfSeatsIPredicted(31)]
                Likud,

                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.MaozAvi)]
                [NumberOfSeatsIPredicted(0)]
                Noam,

                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.BenGvirItamar)]
                [NumberOfSeatsIPredicted(9)]
                OtzmaYehudit,

                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [JointList((int)JointLists.ReligiousZionistPartyZehut)]
                [Factions((int)Factions.ReligiousZionistParty, (int)Factions.Zehut)]
                [NumberOfSeatsIPredicted(6)]
                ReligiousZionistPartyZehut,

                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [JointList((int)JointLists.ReservistsNewEconomicParty)]
                [Factions((int)Factions.Reservists, (int)Factions.NewEconomicParty)]
                [NumberOfSeatsIPredicted(4)]
                ReservistsNewEconomicParty,

                [Zionist]
                [ZionistType(ZionistTypes.Formal)]
                [PoliticalPartyLeader((int)Politicians.DeriAryeh)]
                [NumberOfSeatsIPredicted(7)]
                Shas,

                /// <summary>
                /// merger of Labor and Meretz
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.GolanYair)]
                [NumberOfSeatsIPredicted(6)]
                TheDemocrats,

                /// <summary>
                /// B'Yachad, joint list of Bennett 2026 and Yesh Atid
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [JointList((int)JointLists.Together)]
                [Factions((int)Factions.Bennett2026, (int)Factions.YeshAtid)]
                [NumberOfSeatsIPredicted(11)]
                Together,

                [PoliticalPartyFranchise((int)PoliticalPartyFranchises.Raʼam)]
                [PoliticalPartyLeader((int)Politicians.AbbasMansour)]
                [NumberOfSeatsIPredicted(0)]
                UnitedArabList,

                [JointList((int)JointLists.UnitedTorahJudaism)]
                [Factions((int)Factions.AgudatYisrael, (int)Factions.DegelHaTorah)]
                [NumberOfSeatsIPredicted(6)]
                UnitedTorahJudaism,

                /// <summary>
                /// founded by Gadi Eisenkot after leaving National Unity. Includes Hili Tropper, Matan Kahana and Orit
                /// Farkash-Hacohen
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.EisenkotGadi)]
                [NumberOfSeatsIPredicted(21)]
                Yashar,

                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.LiebermanAvigdor)]
                [NumberOfSeatsIPredicted(10)]
                YisraelBeiteinu,
            }

            /// <summary>
            /// component parties of the joint lists in the 2026 election
            /// </summary>
            public enum Factions
            {
                /// <summary>
                /// Hasidic Haredi party, part of United Torah Judaism
                /// </summary>
                [JointList((int)JointLists.UnitedTorahJudaism)]
                [PoliticalPartyLeader((int)Politicians.GoldknopfYitzhak)]
                AgudatYisrael,

                /// <summary>
                /// Arab nationalist party, part of the Joint List. Its chairman withdrew as a candidate on 2026-10-02 after
                /// the Supreme Court indicated it would uphold his disqualification; Bakr Awawdeh, 4th on the list, is its
                /// top candidate
                /// </summary>
                [JointList((int)JointLists.JointList)]
                [PoliticalPartyLeader((int)Politicians.AbuShehadehSami)]
                Balad,

                /// <summary>
                /// Naftali Bennett's party, part of Together
                /// </summary>
                [JointList((int)JointLists.Together)]
                [PoliticalPartyLeader((int)Politicians.BennettNaftali)]
                Bennett2026,

                /// <summary>
                /// Lithuanian (non-Hasidic) Haredi party, part of United Torah Judaism
                /// </summary>
                [JointList((int)JointLists.UnitedTorahJudaism)]
                [PoliticalPartyLeader((int)Politicians.AsherYaakov)]
                DegelHaTorah,

                /// <summary>
                /// Jewish-Arab socialist front led by the Israeli Communist Party, part of the Joint List
                /// </summary>
                [JointList((int)JointLists.JointList)]
                [PoliticalPartyLeader((int)Politicians.JabareenYousef)]
                Hadash,

                /// <summary>
                /// part of Reservists-New Economic Party
                /// </summary>
                [JointList((int)JointLists.ReservistsNewEconomicParty)]
                [PoliticalPartyLeader((int)Politicians.ZelekhaYaron)]
                NewEconomicParty,

                /// <summary>
                /// part of Religious Zionist Party-Zehut
                /// </summary>
                [JointList((int)JointLists.ReligiousZionistPartyZehut)]
                [PoliticalPartyLeader((int)Politicians.SmotrichBezalel)]
                ReligiousZionistParty,

                /// <summary>
                /// part of Reservists-New Economic Party
                /// </summary>
                [JointList((int)JointLists.ReservistsNewEconomicParty)]
                [PoliticalPartyLeader((int)Politicians.HendelYoaz)]
                Reservists,

                /// <summary>
                /// Arab Movement for Renewal, part of the Joint List
                /// </summary>
                [JointList((int)JointLists.JointList)]
                [PoliticalPartyLeader((int)Politicians.TibiAhmad)]
                Taʼal,

                /// <summary>
                /// part of Together
                /// </summary>
                [JointList((int)JointLists.Together)]
                [PoliticalPartyLeader((int)Politicians.LapidYair)]
                YeshAtid,

                /// <summary>
                /// part of Religious Zionist Party-Zehut
                /// </summary>
                [JointList((int)JointLists.ReligiousZionistPartyZehut)]
                [PoliticalPartyLeader((int)Politicians.FeiglinMoshe)]
                Zehut,
            }

            /// <summary>
            /// joint lists in the 2026 election, each pointing to its PoliticalParties entry and component Factions, with
            /// the politician heading the list
            /// </summary>
            public enum JointLists
            {
                [PoliticalPartyLeader((int)Politicians.JabareenYousef)]
                [PoliticalParties((int)PoliticalParties.JointList)]
                [Factions((int)Factions.Hadash, (int)Factions.Taʼal, (int)Factions.Balad)]
                [JointListNumberOfSeatsIPredicted(9)]
                JointList,

                [PoliticalPartyLeader((int)Politicians.SmotrichBezalel)]
                [PoliticalParties((int)PoliticalParties.ReligiousZionistPartyZehut)]
                [Factions((int)Factions.ReligiousZionistParty, (int)Factions.Zehut)]
                [JointListNumberOfSeatsIPredicted(6)]
                ReligiousZionistPartyZehut,

                [PoliticalPartyLeader((int)Politicians.HendelYoaz)]
                [PoliticalParties((int)PoliticalParties.ReservistsNewEconomicParty)]
                [Factions((int)Factions.Reservists, (int)Factions.NewEconomicParty)]
                [JointListNumberOfSeatsIPredicted(4)]
                ReservistsNewEconomicParty,

                [PoliticalPartyLeader((int)Politicians.BennettNaftali)]
                [PoliticalParties((int)PoliticalParties.Together)]
                [Factions((int)Factions.Bennett2026, (int)Factions.YeshAtid)]
                [JointListNumberOfSeatsIPredicted(11)]
                Together,

                /// <summary>
                /// Degel HaTorah's turn to head the list
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.AsherYaakov)]
                [PoliticalParties((int)PoliticalParties.UnitedTorahJudaism)]
                [Factions((int)Factions.AgudatYisrael, (int)Factions.DegelHaTorah)]
                [JointListNumberOfSeatsIPredicted(6)]
                UnitedTorahJudaism,
            }

            //Found predicted number of seats on wikipedia
            /// <summary>
            /// my personal, simplified view of how the 2026 election shakes out: the change coalition, which I guess ends
            /// up winning, the conservative opposition (Likud and its allies, out of power after the election in my view),
            /// and each Arab party on its own. BeforePoliticalPartiesAndFactions points to v25's enums,
            /// AfterPoliticalPartiesAndFactions to v26's. The comments on each party or faction give its 2022 vote percentage,
            /// with v26 entries counting the v25 ones they came from.
            /// 
            /// Shas and UTJ's Degel faction move to the other side (with some kind of compromise on the draft deal)
            /// </summary>
            public enum MyPersonalView
            {
                /// <summary>
                /// a mixed coalition held together by replacing Netanyahu, running from the secular and nationalist right
                /// (Bennett 2026, Yisrael Beiteinu) through the center (Yashar, Yesh Atid) to the Zionist left (The
                /// Democrats). Before the election, these are the Zionist parties outside the outgoing government. Labor and
                /// Meretz merged into The Democrats, and Yashar was founded by Gadi Eisenkot after he left National Unity.
                /// In my view, Shas and Degel HaTorah join after the election through a draft deal protecting full-time
                /// yeshiva students, while Agudat Yisrael, the harder case on the draft, stays in ConservativeOpposition
                /// </summary>
                [BeforePoliticalPartiesAndFactions(v25.PoliticalParties.YeshAtid, //17.79
                                                   v25.PoliticalParties.BlueAndWhiteNationalUnity, //5.78
                                                   v25.PoliticalParties.YisraelBeiteinu, //4.48
                                                   v25.PoliticalParties.Labor, //3.69
                                                   v25.PoliticalParties.Meretz)] //3.16
                [BeforePreviousElectionVotePercentage(34.90)]
                [IRootedForThis]
                [AfterPoliticalPartiesAndFactions(PoliticalParties.Together, //17.79 (Yesh Atid; Bennett 2026 not in v25)
                                                  PoliticalParties.Shas, //8.25
                                                  PoliticalParties.TheDemocrats, //6.85 (Labor 3.69 + Meretz 3.16)
                                                  PoliticalParties.Yashar, //5.78 (Blue and White-National Unity, since Blue and White withdrew)
                                                  PoliticalParties.YisraelBeiteinu, //4.48
                                                  Factions.DegelHaTorah, //2.52 (UTJ)
                                                  PoliticalParties.ReservistsNewEconomicParty, //0 (not in v25)
                                                  PoliticalParties.AmchaYisrael)] //0 (not in v25)
                [AfterPreviousElectionVotePercentage(45.67)]
                ChangeCoalition,

                /// <summary>
                /// the parties of the outgoing government, along with Noam and United Torah Judaism, which left it. New
                /// Hope runs on the Likud list in 2026. The Jewish Home fell below the threshold in 2022 but backed a
                /// Netanyahu-led government; it has no v26 counterpart, so its 1.19 drops out after.
                /// </summary>
                [BeforePoliticalPartiesAndFactions(v25.PoliticalParties.Likud, //23.41
                                                   v25.PoliticalParties.Shas, //8.25
                                                   v25.PoliticalParties.ReligiousZionistParty, //5.42
                                                   v25.PoliticalParties.OtzmaYehudit, //4.65
                                                   v25.Factions.AgudatYisrael, //3.36 (UTJ)
                                                   v25.PoliticalParties.NewHope, //3.30
                                                   v25.Factions.DegelHaTorah, //2.52 (UTJ)
                                                   v25.PoliticalParties.TheJewishHome, //1.19
                                                   v25.PoliticalParties.Noam)] //0.77
                [BeforePreviousElectionVotePercentage(52.87)]
                [AfterPoliticalPartiesAndFactions(PoliticalParties.Likud, //26.71 (Likud 23.41 + New Hope 3.30)
                                                  PoliticalParties.ReligiousZionistPartyZehut, //5.42 (RZP; Zehut not in v25)
                                                  PoliticalParties.OtzmaYehudit, //4.65
                                                  Factions.AgudatYisrael, //3.36 (UTJ)
                                                  PoliticalParties.Noam)] //0.77
                [AfterPreviousElectionVotePercentage(40.91)]
                ConservativeOpposition,

                /// <summary>
                /// percentages are Hadash's RoughJointListVotePercentage on Hadash-Ta'al
                /// </summary>
                [BeforePoliticalPartiesAndFactions(v25.Factions.Hadash)]
                [BeforePreviousElectionVotePercentage(2.81)]
                [AfterPoliticalPartiesAndFactions(Factions.Hadash)]
                [AfterPreviousElectionVotePercentage(2.81)]
                Hadash,

                /// <summary>
                /// percentages are Ta'al's RoughJointListVotePercentage on Hadash-Ta'al
                /// </summary>
                [BeforePoliticalPartiesAndFactions(v25.Factions.Taʼal)]
                [BeforePreviousElectionVotePercentage(0.94)]
                [AfterPoliticalPartiesAndFactions(Factions.Taʼal)]
                [AfterPreviousElectionVotePercentage(0.94)]
                Taʼal,

                /// <summary>
                /// ran on its own list in 2022, and on the Joint List in 2026
                /// </summary>
                [BeforePoliticalPartiesAndFactions(v25.PoliticalParties.Balad)]
                [BeforePreviousElectionVotePercentage(2.91)]
                [AfterPoliticalPartiesAndFactions(Factions.Balad)]
                [AfterPreviousElectionVotePercentage(2.91)]
                Balad,

                /// <summary>
                /// Ra'am
                /// </summary>
                [BeforePoliticalPartiesAndFactions(v25.PoliticalParties.UnitedArabList)]
                [BeforePreviousElectionVotePercentage(4.07)]
                [AfterPoliticalPartiesAndFactions(PoliticalParties.UnitedArabList)]
                [AfterPreviousElectionVotePercentage(4.07)]
                UnitedArabList,
            }

            /// <summary>
            /// surplus vote agreements signed by the 2026-10-16 deadline, with one PoliticalParties attribute per side.
            /// Listed in the order reported before the election; reorder by combined votes once results are in, as in
            /// v25's LeftoverSeatDistribution. The agreement between two minor lists (Eternal Covenant and Fixing the
            /// Electoral and Governing System) is left out, since neither is in PoliticalParties
            /// </summary>
            public static class SurplusVoteAgreements
            {
                [PoliticalParties((int)PoliticalParties.Together)]
                [PoliticalParties((int)PoliticalParties.YisraelBeiteinu)]
                public static class No1 { }

                [PoliticalParties((int)PoliticalParties.Yashar)]
                [PoliticalParties((int)PoliticalParties.TheDemocrats)]
                public static class No2 { }

                [PoliticalParties((int)PoliticalParties.JointList)]
                [PoliticalParties((int)PoliticalParties.UnitedArabList)]
                public static class No3 { }

                [PoliticalParties((int)PoliticalParties.Likud)]
                [PoliticalParties((int)PoliticalParties.ReligiousZionistPartyZehut)]
                public static class No4 { }

                [PoliticalParties((int)PoliticalParties.Shas)]
                [PoliticalParties((int)PoliticalParties.UnitedTorahJudaism)]
                public static class No5 { }
            }
        }
    }
}
