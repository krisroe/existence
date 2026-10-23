using System;

namespace Existence.Earth.Human.EthnicGroups
{
    public class EthnicGroupAttribute : SingularObjectAttribute
    {
        public WorldEthnicGroups EthnicGroup { get; set; }
        public EthnicGroupAttribute(WorldEthnicGroups EthnicGroup)
        {
            this.EthnicGroup = EthnicGroup;
        }
    }

    public class EthnicGroupsAttribute : Attribute
    {
        public WorldEthnicGroups[] EthnicGroups { get; set; }
        public EthnicGroupsAttribute(params WorldEthnicGroups[] EthnicGroups)
        {
            this.EthnicGroups = EthnicGroups;
        }
    }

    /// <summary>
    /// ethnic groups separate from country or religion based ethnic groups
    /// 
    /// e.g.
    /// Somali isn't here because Somalia is a country (~25 million): Somalia, Ethiopia, Kenya, Djibouti
    /// Bengali isn't here because Bangledesh is a country (~280 million): Bangladesh, India (West Bengal)
    /// 
    /// </summary>
    public enum WorldEthnicGroups
    {
        /// <summary>
        /// China, Taiwan, Singapore, worldwide diaspora. Largest ethnic group in the world.
        /// Not the same as Chinese nationality, since China officially recognizes 56 ethnic groups.
        /// </summary>
        [NumberOfMembers(1350000000, 1400000000)] //1.35-1.4 billion
        Han,

        [NumberOfMembers(400000000, 450000000)] //400-450 million
        Arab,

        /// <summary>
        /// Pakistan and India
        /// </summary>
        [NumberOfMembers(140000000, 160000000)] //140-160 million
        Punjabi,

        /// <summary>
        /// Indonesia (Java)
        /// </summary>
        [NumberOfMembers(95000000, 110000000)] //95-110 million
        Javanese,

        /// <summary>
        /// India (Andhra Pradesh, Telangana)
        /// </summary>
        [NumberOfMembers(85000000, 95000000)] //85-95 million
        Telugu,

        /// <summary>
        /// India (Maharashtra)
        /// </summary>
        [NumberOfMembers(80000000, 90000000)] //80-90 million
        Marathi,

        /// <summary>
        /// India, Sri Lanka, Malaysia, Singapore
        /// </summary>
        [NumberOfMembers(75000000, 85000000)] //75-85 million
        Tamil,

        /// <summary>
        /// Nigeria, Niger, and across West Africa
        /// </summary>
        [NumberOfMembers(60000000, 85000000)] //60-85 million
        Hausa,

        /// <summary>
        /// Fula/Peul
        /// Spread across the Sahel and West Africa, from Senegal to Sudan
        /// </summary>
        [NumberOfMembers(40000000, 70000000)] //40-70 million
        Fulani,

        /// <summary>
        /// India, with diaspora in East Africa, the United Kingdom, and the United States
        /// </summary>
        [NumberOfMembers(55000000, 65000000)] //55-65 million
        Gujarati,

        /// <summary>
        /// Pakistan and Afghanistan
        /// </summary>
        [NumberOfMembers(50000000, 65000000)] //50-65 million
        Pashtun,

        /// <summary>
        /// Iran (about half its population), plus a diaspora of a few million, largest in the United States
        /// Not the same as Iranian nationality: many Iranians are Azerbaijani, Kurd, Lur, Arab, Baloch, etc.
        /// Persian-speaking Tajiks and Hazaras in Afghanistan and Tajikistan are separate ethnic groups.
        /// Included even though "Persia" was the Western name for Iran until 1935, since no country is named
        /// Persia today.
        /// </summary>
        [NumberOfMembers(45000000, 60000000)] //45-60 million
        Persian,

        /// <summary>
        /// Nigeria, Benin, Togo
        /// </summary>
        [NumberOfMembers(45000000, 55000000)] //45-55 million
        Yoruba,

        /// <summary>
        /// Nigeria
        /// </summary>
        [NumberOfMembers(40000000, 50000000)] //40-50 million
        Igbo,

        /// <summary>
        /// Ethiopia (its largest ethnic group), Kenya
        /// </summary>
        [NumberOfMembers(40000000, 50000000)] //40-50 million
        Oromo,

        /// <summary>
        /// Indonesia (West Java)
        /// </summary>
        [NumberOfMembers(40000000, 45000000)] //40-45 million
        Sundanese,

        /// <summary>
        /// Kurdistan is not a country - it is split between Turkey, Iraq, Iran, and Syria
        /// </summary>
        [NumberOfMembers(30000000, 45000000)] //30-45 million
        Kurd,

        /// <summary>
        /// India (Kerala), Gulf states
        /// </summary>
        [NumberOfMembers(35000000, 40000000)] //35-40 million
        Malayali,

        /// <summary>
        /// Amazigh
        /// Estimates vary widely because many North Africans of Berber descent now identify as Arab
        /// </summary>
        [NumberOfMembers(25000000, 40000000)] //25-40 million
        Berber,

        /// <summary>
        /// Ethiopia
        /// </summary>
        [NumberOfMembers(25000000, 35000000)] //25-35 million
        Amhara,

        /// <summary>
        /// Iran (the northwest, and a large share of Tehran) and Azerbaijan, plus Russia, Turkey, and Georgia
        /// Included even though Azerbaijan is a country, because more Azerbaijanis live in Iran than in Azerbaijan.
        /// </summary>
        [NumberOfMembers(25000000, 35000000)] //25-35 million
        Azerbaijani,

        /// <summary>
        /// Ghana, Ivory Coast
        /// </summary>
        [NumberOfMembers(20000000, 25000000)] //20-25 million
        Akan,

        /// <summary>
        /// Estimates vary widely depending on whether settled descendants of nomadic Bedouin are counted
        /// </summary>
        [NumberOfMembers(5000000, 25000000)] //5-25 million
        Bedouin,

        /// <summary>
        /// China (its largest ethnic minority)
        /// </summary>
        [NumberOfMembers(19000000, 20000000)] //19-20 million
        Zhuang,

        /// <summary>
        /// South Africa
        /// </summary>
        [NumberOfMembers(12000000, 15000000)] //12-15 million
        Zulu,

        /// <summary>
        /// Pakistan, Iran, Afghanistan
        /// </summary>
        [NumberOfMembers(10000000, 15000000)] //10-15 million
        Baloch,

        /// <summary>
        /// China (Xinjiang), Central Asia
        /// </summary>
        [NumberOfMembers(12000000, 13000000)] //12-13 million
        Uyghur,

        /// <summary>
        /// China, plus Dungan descendants in Kyrgyzstan and Kazakhstan
        /// Chinese-speaking Muslims. An officially recognized ethnic group in China, inherited by descent,
        /// so non-practicing Hui are still Hui, and Han Chinese who convert to Islam become Muslim but stay officially Han.
        /// </summary>
        [NumberOfMembers(11000000, 12000000)] //11-12 million
        Hui,

        /// <summary>
        /// Across Europe, with no homeland state
        /// </summary>
        [NumberOfMembers(10000000, 12000000)] //10-12 million
        Roma,

        /// <summary>
        /// Peru, Bolivia, Ecuador
        /// </summary>
        [NumberOfMembers(8000000, 10000000)] //8-10 million
        Quechua,

        /// <summary>
        /// China, India, Nepal
        /// </summary>
        [NumberOfMembers(6500000, 7500000)] //6.5-7.5 million
        Tibetan,

        /// <summary>
        /// Guatemala, Mexico
        /// </summary>
        [NumberOfMembers(6000000, 7000000)] //6-7 million
        Maya,

        /// <summary>
        /// China, Vietnam, Laos, Thailand, United States
        /// China counts the Hmong as part of its larger Miao ethnic group (about 11 million)
        /// </summary>
        [NumberOfMembers(4000000, 5000000)] //4-5 million
        Hmong,

        /// <summary>
        /// Sahara (Mali, Niger, Algeria, Libya)
        /// A nomadic Berber people
        /// </summary>
        [NumberOfMembers(2000000, 3500000)] //2-3.5 million
        Tuareg,
    }
}
