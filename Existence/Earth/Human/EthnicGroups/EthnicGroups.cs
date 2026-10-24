using Existence.Earth.Countries;
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

    public class HigherLevelJewishEthnicSubdivisionAttribute : Attribute
    {
        public JewishEthnicSubdivisions Subdivision { get; set; }
        public HigherLevelJewishEthnicSubdivisionAttribute(JewishEthnicSubdivisions Subdivision)
        {
            this.Subdivision = Subdivision;
        }
    }

    public class HigherLevelJewishEthnicSubSubdivisionAttribute : Attribute
    {
        public JewishEthnicSubSubdivisions Subdivision { get; set; }
        public HigherLevelJewishEthnicSubSubdivisionAttribute(JewishEthnicSubSubdivisions Subdivision)
        {
            this.Subdivision = Subdivision;
        }
    }

    public class HasSubdivisionsAttribute : Attribute { }

    /// <summary>
    /// high level ethnic subdivisions of Jewish people
    /// Member counts are rough and add up to more than the world's ~16 million Jews, since many Jews
    /// (especially in Israel) have mixed ancestry and are counted in more than one group.
    /// </summary>
    public enum JewishEthnicSubdivisions
    {
        /// <summary>
        /// Central and Eastern Europe (originally the Rhineland, later Poland, Lithuania, and Russia), now mostly the United States and Israel
        /// The majority of the world's Jews. Traditional language is Yiddish.
        /// </summary>
        [NumberOfMembers(10000000, 11500000)] //10-11.5 million
        Ashkenazi,

        /// <summary>
        /// Descendants of the Jews of Spain and Portugal, expelled in 1492 and 1497, who resettled in the Ottoman Empire,
        /// North Africa, the Netherlands, Italy, and the Americas. Traditional language is Ladino (Judeo-Spanish).
        /// In Israel the term is often used loosely for all non-Ashkenazi Jews, since most follow the Sephardic religious rite.
        /// The count here is for the narrower sense: descendants of the Iberian exiles.
        /// </summary>
        [NumberOfMembers(1000000, 2500000)] //1-2.5 million
        [Countries(CountryLikeThings.Portugal, CountryLikeThings.Spain)]
        Sephardi,

        /// <summary>
        /// "Easterners": Jews of the Middle East, the Caucasus, and Central Asia (Iraq, Iran, Syria, Kurdistan, Bukhara, Georgia)
        /// Mostly descended from communities that stayed in the region since ancient times, rather than from Spanish exiles.
        /// Nearly all left for Israel after 1948. In Israel the term often includes Maghrebi and Teimani Jews,
        /// but the count here does not, since they are listed separately.
        /// </summary>
        [NumberOfMembers(1500000, 2500000)] //1.5-2.5 million
        Mizrahi,

        /// <summary>
        /// North Africa (Morocco, Algeria, Tunisia, Libya), now mostly Israel and France
        /// A mix of ancient local communities and Sephardic exiles who arrived after 1492.
        /// Often counted as Mizrahi or Sephardi rather than as a separate group.
        /// </summary>
        [NumberOfMembers(1500000, 2000000)] //1.5-2 million
        [Countries(CountryLikeThings.Algeria, CountryLikeThings.Morocco, CountryLikeThings.LibyaWest, CountryLikeThings.LibyaEast, CountryLikeThings.Tunisia)]
        Maghrebi,

        /// <summary>
        /// Yemen, now mostly Israel
        /// Isolated from other Jewish communities for centuries, keeping their own traditions, Hebrew pronunciation,
        /// and prayer rites (Baladi and Shami). Nearly all were airlifted to Israel in Operation Magic Carpet (1949-1950).
        /// The count includes the Adeni and Habbani communities.
        /// </summary>
        [NumberOfMembers(400000, 500000)] //400,000-500,000
        [Country(CountryLikeThings.Yemen)]
        Teimani,
    }

    /// <summary>
    /// lower level ethnic subdivisions of Jewish people
    /// </summary>
    public enum JewishEthnicSubSubdivisions
    {
        /// <summary>
        /// Aden, in southern Yemen, a British colony from 1839 to 1967
        /// Ties to British India set them apart from the Jews of inland Yemen.
        /// Most left for Israel and the United Kingdom after riots in 1947 and 1967.
        /// No modern count exists; the estimate is based on the community's size of about 8,000 in 1947.
        /// </summary>
        [NumberOfMembers(10000, 25000)] //10,000-25,000
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Teimani)]
        [Country(CountryLikeThings.Yemen)]
        Adeni,

        /// <summary>
        /// Ethiopia (mostly around Gondar, also Tigray and Qwara), now nearly all Israel
        /// Developed separately from other Jewish communities for centuries, with scriptures and prayers in Ge'ez.
        /// Most were brought to Israel in Operation Moses (1984) and Operation Solomon (1991).
        /// The count includes Israeli-born children and the Falash Mura.
        /// </summary>
        [NumberOfMembers(160000, 180000)] //160,000-180,000
        [Country(CountryLikeThings.Ethiopia)]
        BetaIsrael,

        /// <summary>
        /// Habban, in eastern Yemen
        /// A small, isolated community with its own customs and dress. Nearly all moved to Israel around 1950.
        /// No modern count exists; the estimate is based on the few hundred who emigrated around 1950.
        /// </summary>
        [NumberOfMembers(3000, 10000)] //3,000-10,000
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Teimani)]
        [Country(CountryLikeThings.Yemen)]
        Habbani,

        /// <summary>
        /// Sudan (mostly Khartoum and Omdurman)
        /// A small community, at most about a thousand people, mostly Sephardic families from Egypt and the Ottoman Empire
        /// who arrived in the late 19th and early 20th centuries. Nearly all left by the 1960s, for Israel, the United Kingdom,
        /// the United States, and Switzerland.
        /// </summary>
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Sephardi)]
        [Country(CountryLikeThings.Sudan)]
        Sudanese,

        /// <summary>
        /// Syria, mainly Aleppo (Halabi Jews) and Damascus (Shami Jews), now mostly Israel, Brooklyn, and Latin America
        /// An ancient community joined by Sephardic exiles after 1492. Nearly all left after 1948, with the last few
        /// thousand allowed out in 1992.
        /// </summary>
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Mizrahi)]
        [Country(CountryLikeThings.Syria)]
        [HasSubdivisions]
        Syrian,

        /// <summary>
        /// Udmurt and Tatar Jews
        /// Tatarstan and neighboring Udmurtia, in Russia's Volga-Ural region (mainly Kazan, Izhevsk, and Sarapul)
        /// Ashkenazi Jews who settled there in the 19th century, many of them former cantonists
        /// (boys conscripted into the Russian army). Their Yiddish dialect picked up Udmurt and Tatar words.
        /// </summary>
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Ashkenazi)]
        [Country(CountryLikeThings.Russia)]
        Tatar,

        /// <summary>
        /// Tunisia, now mostly Israel and France
        /// Split historically between the Twansa, an ancient native community, and the Granas, who came from Livorno, Italy,
        /// from the 17th century on. About a thousand remain, mostly on the island of Djerba, home of the El Ghriba synagogue.
        /// </summary>
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Maghrebi)]
        [Country(CountryLikeThings.Tunisia)]
        Tunisian,

        /// <summary>
        /// The "Unterland" of the old Kingdom of Hungary: northeastern Hungary, Carpathian Ruthenia, eastern Slovakia, and Maramures
        /// Mostly Hasidic, unlike the more modernized Oberlander Jews of western Hungary. Most were murdered in the Holocaust
        /// in 1944, but several major Hasidic dynasties, such as Satmar and Munkacs, come from here.
        /// </summary>
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Ashkenazi)]
        [Countries(CountryLikeThings.Hungary, CountryLikeThings.Romania, CountryLikeThings.Slovakia, CountryLikeThings.Ukraine)]
        Unterlander,

        /// <summary>
        /// Chuetas (spanish spelling), from Majorca (Balearic Islands, Spain)
        /// Descendants of Majorcan Jews forced to convert to Catholicism in the 14th and 15th centuries. Mostly Catholic today,
        /// but long discriminated against as a separate group. Israel's Chief Rabbinate recognized them as Jews in 2011.
        /// </summary>
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Sephardi)]
        [Country(CountryLikeThings.Spain)]
        Xuetes,
    }

    /// <summary>
    /// smallest level ethnic subdivisions of Jewish people
    /// </summary>
    public enum JewishEthnicSubSubSubdivisions
    {
        /// <summary>
        /// 
        /// </summary>
        [HigherLevelJewishEthnicSubSubdivision(JewishEthnicSubSubdivisions.Syrian)]
        Halabi,

        /// <summary>
        /// Represents the Shami type.
        /// </summary>
        [HigherLevelJewishEthnicSubSubdivision(JewishEthnicSubSubdivisions.Syrian)]
        Shami,
    }

    /// <summary>
    /// ethnic groups mostly separate from religion based ethnic groups
    /// </summary>
    public enum WorldEthnicGroups
    {
        /// <summary>
        /// China, Taiwan, Singapore, worldwide diaspora. Largest ethnic group in the world.
        /// Not the same as Chinese nationality, since China officially recognizes 56 ethnic groups.
        /// </summary>
        [NumberOfMembers(1350000000, 1400000000)] //1.35-1.4 billion
        Han,

        /// <summary>
        /// Middle East and North Africa (most of the Arab League countries), plus a worldwide diaspora, largest in the Americas and Europe
        /// Defined mainly by the Arabic language and culture rather than descent, so it includes peoples
        /// of many origins who became Arabic-speaking after the Arab conquests of the 7th century onward.
        /// </summary>
        [NumberOfMembers(400000000, 450000000)] //400-450 million
        Arab,

        /// <summary>
        /// Bangladesh (about 170 million) and India (about 100 million, mostly West Bengal, Tripura, and Assam),
        /// plus a diaspora of several million, largest in the United Kingdom and the Gulf states
        /// Included even though Bangladesh is a country, because over a third of Bengalis live in India.
        /// </summary>
        [NumberOfMembers(270000000, 300000000)] //270-300 million
        Bengali,

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
        /// Somalia, Ethiopia (Somali Region), Kenya, Djibouti, plus a diaspora of 1-2 million
        /// Included even though Somalia is a country, because about a third of Somalis live outside it.
        /// </summary>
        [NumberOfMembers(25000000, 30000000)] //25-30 million
        Somali,

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
