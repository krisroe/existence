using System;

namespace Existence.Earth.Human.EthnicGroups
{
    /// <summary>
    /// ethnic groups separate from country or religion based ethnic groups
    /// 
    /// e.g.
    /// Azerbaijani isn't here because Azerbaijan is a country (even though there are more Azerbaijanis in Iran) (~35 million)
    /// Somali isn't here because Somalia is a country (~25 million): Somalia, Ethiopia, Kenya, Djibouti
    /// Bengali isn't here because Bangledesh is a country (~280 million): Bangladesh, India (West Bengal)
    /// 
    /// </summary>
    public enum WorldEthnicGroups
    {
        Arab,

        /// <summary>
        /// Kurdistan is not a country - it is split between Turkey, Iraq, Iran, and Syria
        /// </summary>
        Kurd,

        /// <summary>
        /// Amazigh
        /// </summary>
        Berber,

        Bedouin,
    }
}
