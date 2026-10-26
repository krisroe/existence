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
        AbbasMansour,

        [Gender(Gender.Male)]
        BenGvirItamar,

        [Gender(Gender.Male)]
        BennettNaftali,

        [Gender(Gender.Male)]
        DeriAryeh,

        [Gender(Gender.Male)]
        EisenkotGadi,

        [Gender(Gender.Male)]
        GafniMoshe,

        [Gender(Gender.Male)]
        GantzBenny,

        [Gender(Gender.Male)]
        GolanYair,

        [Gender(Gender.Male)]
        GoldknopfYitzhak,

        [Gender(Gender.Male)]
        LapidYair,

        [Gender(Gender.Male)]
        LiebermanAvigdor,

        [Gender(Gender.Male)]
        MaozAvi,

        [Gender(Gender.Male)]
        NetanyahuBenjamin,

        [Gender(Gender.Male)]
        OdehAyman,

        [Gender(Gender.Male)]
        SaarGideon,

        [Gender(Gender.Male)]
        SmotrichBezalel,

        [Gender(Gender.Male)]
        TibiAhmad,
    }

    public static class Knesset
    {
        [ElectionDate(2022, 11, 1)]
        public static class v25
        {
            /// <summary>
            /// factions in the 25th Knesset (elected 2022-11-01)
            /// </summary>
            public enum PoliticalParties
            {
                /// <summary>
                /// formerly National Unity, which New Hope split from in 2024
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.GantzBenny)]
                BlueAndWhiteNationalUnity,

                /// <summary>
                /// joint faction of Hadash and Ta'al
                /// </summary>
                [Factions((int)Factions.Hadash, (int)Factions.Taal)]
                HadashTaal,

                /// <summary>
                /// approved a merger with Meretz into The Democrats in 2024, but its members still sit as Labor
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.GolanYair)]
                Labor,

                /// <summary>
                /// main Israeli conservative party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.NetanyahuBenjamin)]
                Likud,

                /// <summary>
                /// merger into Likud agreed in 2025, but not approved by the Knesset House Committee
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.SaarGideon)]
                NewHope,

                /// <summary>
                /// ran on the Religious Zionist slate in 2022, then split into its own faction
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.MaozAvi)]
                Noam,

                /// <summary>
                /// ran on the Religious Zionist slate in 2022, then split into its own faction
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.BenGvirItamar)]
                OtzmaYehudit,

                /// <summary>
                /// religious Zionist, pro-settlement party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.SmotrichBezalel)]
                ReligiousZionistParty,

                /// <summary>
                /// Sephardi and Mizrahi Haredi party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Formal)]
                [PoliticalPartyLeader((int)Politicians.DeriAryeh)]
                Shas,

                /// <summary>
                /// Ra'am
                /// </summary>
                [PoliticalPartyLeader((int)Politicians.AbbasMansour)]
                UnitedArabList,

                /// <summary>
                /// joint faction of Agudat Yisrael and Degel HaTorah
                /// </summary>
                [Factions((int)Factions.AgudatYisrael, (int)Factions.DegelHaTorah)]
                UnitedTorahJudaism,

                /// <summary>
                /// centrist, largest opposition party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.LapidYair)]
                YeshAtid,

                /// <summary>
                /// secular right-wing party with a base among Russian-speaking immigrants
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                [PoliticalPartyLeader((int)Politicians.LiebermanAvigdor)]
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
        }
    }
}
