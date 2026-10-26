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
                BlueAndWhiteNationalUnity,

                /// <summary>
                /// joint faction of Hadash and Ta'al
                /// </summary>
                HadashTaal,

                /// <summary>
                /// approved a merger with Meretz into The Democrats in 2024, but its members still sit as Labor
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                Labor,

                /// <summary>
                /// main Israeli conservative party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                Likud,

                /// <summary>
                /// merger into Likud agreed in 2025, but not approved by the Knesset House Committee
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                NewHope,

                /// <summary>
                /// ran on the Religious Zionist slate in 2022, then split into its own faction
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                Noam,

                /// <summary>
                /// ran on the Religious Zionist slate in 2022, then split into its own faction
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                OtzmaYehudit,

                /// <summary>
                /// religious Zionist, pro-settlement party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                ReligiousZionistParty,

                /// <summary>
                /// Sephardi and Mizrahi Haredi party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Formal)]
                Shas,

                /// <summary>
                /// Ra'am
                /// </summary>
                UnitedArabList,

                /// <summary>
                /// joint faction of Agudat Yisrael and Degel HaTorah
                /// </summary>
                UnitedTorahJudaism,

                /// <summary>
                /// centrist, largest opposition party
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                YeshAtid,

                /// <summary>
                /// secular right-wing party with a base among Russian-speaking immigrants
                /// </summary>
                [Zionist]
                [ZionistType(ZionistTypes.Ideological)]
                YisraelBeiteinu,
            }
        }
    }
}
