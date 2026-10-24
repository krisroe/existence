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

    public class HigherLevelJewishEthnicSubdivisionsAttribute : Attribute
    {
        public JewishEthnicSubdivisions[] Subdivisions { get; set; }
        public HigherLevelJewishEthnicSubdivisionsAttribute(params JewishEthnicSubdivisions[] Subdivisions)
        {
            this.Subdivisions = Subdivisions;
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

    public class HigherLevelJewishEthnicSubSubSubdivisionAttribute : Attribute
    {
        public JewishEthnicSubSubSubdivisions Subdivision { get; set; }
        public HigherLevelJewishEthnicSubSubSubdivisionAttribute(JewishEthnicSubSubSubdivisions Subdivision)
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
    /// main level ethnic subdivisions of Jewish people
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
        /// Afghanistan (mainly Herat, Kabul, and Balkh), now mostly Israel and New York
        /// Closely tied to Persian Jews and spoke a Judeo-Persian dialect; many came from Mashhad, Iran, after its Jews were
        /// forced to convert in 1839. Most left for Israel after 1948, and the last known Jew left Afghanistan in 2021.
        /// No modern count exists; the estimate is based on a population of about 5,000 in 1948.
        /// </summary>
        [NumberOfMembers(10000, 20000)] //10,000-20,000
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Mizrahi)]
        [Country(CountryLikeThings.Afghanistan)]
        Afghan,

        /// <summary>
        /// Algeria, now mostly France
        /// An ancient community joined by Sephardic exiles after 1492. The Cremieux Decree of 1870 made them French citizens,
        /// so nearly all left for France rather than Israel when Algeria became independent in 1962.
        /// No modern count exists; the estimate is based on a population of about 140,000 in 1948.
        /// </summary>
        [NumberOfMembers(200000, 350000)] //200,000-350,000
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Maghrebi)]
        [Country(CountryLikeThings.Algeria)]
        Algerian,

        /// <summary>
        /// Babylonian Jews, Iraqi Jews
        /// Iraq (mainly Baghdad, also Basra and Mosul), now mostly Israel, plus the United Kingdom and the United States
        /// Descended from the Babylonian exile of 586 BCE, and for centuries the center of Jewish scholarship, where the Babylonian
        /// Talmud was written. Spoke Judeo-Arabic. After the Farhud pogrom of 1941 and the founding of Israel, about 120,000 were
        /// airlifted to Israel in 1950-1951. Kurdish Jews of northern Iraq are a separate community.
        /// No modern count exists; the estimate is based on a population of about 135,000 in 1948.
        /// </summary>
        [NumberOfMembers(450000, 600000)] //450,000-600,000
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Mizrahi)]
        [Country(CountryLikeThings.Iraq)]
        Bavlim,

        /// <summary>
        /// Belmonte, a small town in eastern Portugal
        /// Crypto-Jews whose ancestors were forced to convert to Catholicism in 1497, but who secretly kept Jewish prayers and
        /// customs, passed down mostly by women, for nearly 500 years. Discovered by outsiders in 1917, they formally
        /// returned to Judaism in the late 20th century and opened a synagogue in 1996.
        /// </summary>
        [NumberOfMembers(100, 300)] //100-300
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Sephardi)]
        [Country(CountryLikeThings.Portugal)]
        Belmonte,

        /// <summary>
        /// India (the Konkan coast of Maharashtra, later Mumbai), now mostly Israel
        /// By tradition descended from Jews shipwrecked on the Konkan coast about 2,000 years ago. Spoke Marathi, and lived
        /// largely cut off from other Jews, keeping the Sabbath, circumcision, and dietary laws, until contact was renewed
        /// in the 18th century. Most moved to Israel in the 1950s and 1960s; about 4,000-5,000 remain in India.
        /// Not part of any of the higher level subdivisions.
        /// No modern count exists; the estimate is based on a population of about 20,000-30,000 in 1948.
        /// </summary>
        [NumberOfMembers(60000, 85000)] //60,000-85,000
        [Country(CountryLikeThings.India)]
        BeneIsrael,

        /// <summary>
        /// Amazigh Jews
        /// Villages of the Atlas Mountains and the valleys south of them (Draa, Sous, Todra), Morocco, now mostly Israel
        /// Rural Jews who lived among Berber tribes and spoke Judeo-Berber rather than Judeo-Arabic. Whether they descend
        /// partly from Berbers who converted to Judaism is debated. Nearly all left for Israel in the 1950s and 1960s.
        /// No modern count exists; the estimate is based on a rural Atlas population of a few tens of thousands in 1948.
        /// </summary>
        [NumberOfMembers(50000, 150000)] //50,000-150,000
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Maghrebi)]
        [Country(CountryLikeThings.Morocco)]
        Berber,

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
        /// Central Asia, mainly Uzbekistan (Bukhara, Samarkand, Tashkent) and Tajikistan (Dushanbe), now mostly Israel and New York (Queens)
        /// Named for the old Emirate of Bukhara. Descended from Persian Jews, and spoke Bukhori, a Jewish dialect of Tajik.
        /// Nearly all left after the fall of the Soviet Union in 1991; only a few hundred remain in Central Asia.
        /// </summary>
        [NumberOfMembers(150000, 250000)] //150,000-250,000
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Mizrahi)]
        [Countries(CountryLikeThings.Tajikistan, CountryLikeThings.Uzbekistan)]
        Bukharan,

        /// <summary>
        /// Malabar Jews
        /// Kerala, India (mainly Kochi, also Ernakulam, Parur, and Mala), now mostly Israel
        /// The oldest Jewish community in India, by tradition founded by traders in ancient times. Spoke Judeo-Malayalam.
        /// Split historically between the older Malabari Jews and the Paradesi ("foreign") Jews, who arrived from Europe and
        /// the Middle East from the 16th century on. Nearly all left for Israel in the 1950s; only a handful remain in Kerala.
        /// No modern count exists; the estimate is based on a population of about 2,500 in 1948.
        /// </summary>
        [NumberOfMembers(7000, 10000)] //7,000-10,000
        [Country(CountryLikeThings.India)]
        [HasSubdivisions]
        Cochin,

        /// <summary>
        /// Crimean Karaims (Qaraylar in their own language). From Crimea, mainly Yevpatoria and Chufut-Kale
        /// Followers of Karaite Judaism, which accepts the Hebrew Bible but rejects the rabbinic Talmud. Speak Karaim, a Turkic
        /// language. In 1863 the Russian Empire recognized them as separate from Jews, exempting them from anti-Jewish laws, and
        /// in World War II the Nazis classified them as non-Jews, sparing most of them. Many today identify as a Turkic people
        /// rather than as Jews. Related to, but separate from, the Karaims of Lithuania and western Ukraine, and not the same as
        /// the Krymchaks, the Turkic-speaking rabbinic Jews of Crimea.
        /// Not part of any of the higher level subdivisions.
        /// </summary>
        [NumberOfMembers(1000, 3000)] //1,000-3,000
        [Country(CountryLikeThings.Ukraine)]
        CrimeanKaraite,

        /// <summary>
        /// Egypt (mainly Cairo and Alexandria), now mostly Israel, France, the United States, and Brazil
        /// One of the oldest diaspora communities; Maimonides lived in Cairo, and its Ben Ezra Synagogue held the Cairo Geniza,
        /// a vast store of medieval manuscripts. By the 20th century it mixed Arabic-speaking native Jews, Sephardic and Italian
        /// families, Ashkenazi immigrants, and a community of Karaites. Nearly all left or were expelled after 1948, 1956, and 1967;
        /// only a handful remain.
        /// No modern count exists; the estimate is based on a population of about 75,000-80,000 in 1948.
        /// </summary>
        [NumberOfMembers(150000, 250000)] //150,000-250,000
        [HigherLevelJewishEthnicSubdivisions(JewishEthnicSubdivisions.Mizrahi, JewishEthnicSubdivisions.Sephardi)]
        [Country(CountryLikeThings.Egypt)]
        Egyptian,

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
        /// No modern count exists; the estimate is based on the community's peak of about a thousand.
        /// </summary>
        [NumberOfMembers(2000, 5000)] //2,000-5,000
        [HigherLevelJewishEthnicSubdivisions(JewishEthnicSubdivisions.Mizrahi, JewishEthnicSubdivisions.Sephardi)]
        [Country(CountryLikeThings.Sudan)]
        Sudanese,

        /// <summary>
        /// Syria, mainly Aleppo (Halabi Jews) and Damascus (Shami Jews), now mostly Israel, Brooklyn, and Latin America
        /// An ancient community joined by Sephardic exiles after 1492. Nearly all left after 1948, with the last few
        /// thousand allowed out in 1992.
        /// The count covers the Halabi and Shami communities combined.
        /// </summary>
        [NumberOfMembers(150000, 250000)] //150,000-250,000
        [HigherLevelJewishEthnicSubdivisions(JewishEthnicSubdivisions.Mizrahi, JewishEthnicSubdivisions.Sephardi)]
        [Country(CountryLikeThings.Syria)]
        [HasSubdivisions]
        Syrian,

        /// <summary>
        /// Udmurt and Tatar Jews
        /// Tatarstan and neighboring Udmurtia, in Russia's Volga-Ural region (mainly Kazan, Izhevsk, and Sarapul)
        /// Ashkenazi Jews who settled there in the 19th century, many of them former cantonists
        /// (boys conscripted into the Russian army). Their Yiddish dialect picked up Udmurt and Tatar words.
        /// Russian censuses count only a few thousand Jews in the two republics; the high estimate includes emigrants to Israel.
        /// </summary>
        [NumberOfMembers(3000, 10000)] //3,000-10,000
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Ashkenazi)]
        [Country(CountryLikeThings.Russia)]
        Tatar,

        /// <summary>
        /// Tunisia, now mostly Israel and France
        /// Split historically between the Twansa, an ancient native community, and the Granas, who came from Livorno, Italy,
        /// from the 17th century on. About a thousand remain, mostly on the island of Djerba, home of the El Ghriba synagogue.
        /// No modern count exists; the estimate is based on a population of about 105,000 in 1948.
        /// </summary>
        [NumberOfMembers(250000, 350000)] //250,000-350,000
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Maghrebi)]
        [Country(CountryLikeThings.Tunisia)]
        Tunisian,

        /// <summary>
        /// The "Unterland" of the old Kingdom of Hungary: northeastern Hungary, Carpathian Ruthenia, eastern Slovakia, and Maramures
        /// Mostly Hasidic, unlike the more modernized Oberlander Jews of western Hungary. Most were murdered in the Holocaust
        /// in 1944, but several major Hasidic dynasties, such as Satmar and Munkacs, come from here.
        /// No modern count exists; the estimate is of survivors' descendants, mostly in Hasidic communities in New York and Israel.
        /// </summary>
        [NumberOfMembers(100000, 300000)] //100,000-300,000
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Ashkenazi)]
        [Countries(CountryLikeThings.Hungary, CountryLikeThings.Romania, CountryLikeThings.Slovakia, CountryLikeThings.Ukraine)]
        Unterlander,

        /// <summary>
        /// Chuetas (spanish spelling), from Majorca (Balearic Islands, Spain)
        /// Descendants of Majorcan Jews forced to convert to Catholicism in the 14th and 15th centuries. Mostly Catholic today,
        /// but long discriminated against as a separate group. Israel's Chief Rabbinate recognized them as Jews in 2011.
        /// The count is of Majorcans who carry one of the traditional Xueta surnames.
        /// </summary>
        [NumberOfMembers(15000, 20000)] //15,000-20,000
        [HigherLevelJewishEthnicSubdivision(JewishEthnicSubdivisions.Sephardi)]
        [Country(CountryLikeThings.Spain)]
        Xuetes,
    }

    /// <summary>
    /// smaller level ethnic subdivisions of Jewish people
    /// </summary>
    public enum JewishEthnicSubSubSubdivisions
    {
        /// <summary>
        /// Aleppo (Halab in Arabic), now mostly Brooklyn, Israel, Mexico, Panama, and Argentina
        /// One of the oldest Jewish communities in the world, joined by Sephardic exiles after 1492. For about 600 years it kept
        /// the Aleppo Codex, the oldest near-complete Hebrew Bible manuscript, until riots in 1947 damaged it.
        /// Kept separate synagogues and community institutions from Shami Jews, even in the diaspora.
        /// No census exists; the estimate is the larger share of the Syrian Jewish diaspora
        /// </summary>
        [NumberOfMembers(100000, 160000)] //100,000-160,000
        [HigherLevelJewishEthnicSubSubdivision(JewishEthnicSubSubdivisions.Syrian)]
        Halabi,

        /// <summary>
        /// Kerala, India (mainly Ernakulam, Parur, Mala, and Chendamangalam), now mostly Israel
        /// The older and much larger of the two Cochin Jewish communities, descended from the ancient settlers of the Malabar Coast.
        /// Historically called "Black Jews" by English-language sources. Kept their own synagogues and did not intermarry with the Paradesi Jews.
        /// No census exists; the estimate is most of the Cochin Jewish population.
        /// </summary>
        [NumberOfMembers(6500, 9500)] //6,500-9,500
        [HigherLevelJewishEthnicSubSubdivision(JewishEthnicSubSubdivisions.Cochin)]
        Malabari,

        /// <summary>
        /// Jew Town in Kochi, Kerala, India, now mostly Israel, plus Australia and the United States
        /// "Foreigners": Jews who arrived from the 16th century on, mainly Sephardic exiles from Spain and Portugal, plus Jews
        /// from the Netherlands, Germany, Iraq, and Syria. Historically called "White Jews" by English-language sources. Built the Paradesi
        /// Synagogue in 1568, still standing today.
        /// No census exists; the estimate is based on a community of a few hundred in 1948.
        /// </summary>
        [NumberOfMembers(300, 600)] //300-600
        [HigherLevelJewishEthnicSubSubdivision(JewishEthnicSubSubdivisions.Cochin)]
        [HasSubdivisions]
        Paradesi,

        /// <summary>
        /// Damascus (al-Sham in Arabic), now mostly Brooklyn, Israel, and Argentina
        /// An ancient community, smaller than the Halabi Jews, that also absorbed Sephardic exiles after 1492. Known for the
        /// Damascus affair of 1840, a blood libel that drew international protest.
        /// Not the same as the Shami prayer rite of Yemenite Jews, which is named for the Levant as a whole.
        /// No census exists; the estimate is the smaller share of the Syrian Jewish diaspora
        /// </summary>
        [NumberOfMembers(50000, 90000)] //50,000-90,000
        [HigherLevelJewishEthnicSubSubdivision(JewishEthnicSubSubdivisions.Syrian)]
        Shami,
    }

    /// <summary>
    /// smallest level ethnic subdivision(s) of Jewish people
    /// </summary>
    public enum JewishEthnicSubSubSubSubdivisions
    {
        /// <summary>
        /// Meshuchrarim ("freed" in Hebrew), Kochi, Kerala, India, now mostly Israel
        /// Descendants of servants of Cochin Jews who were freed and converted to Judaism. Attached to the Paradesi community,
        /// but treated as lower status: they could not be called up to read the Torah or sit with other members in the Paradesi
        /// Synagogue. Abraham Barak Salem, a Meshuchrari lawyer, led a Gandhi-style campaign against this in the 1930s.
        /// No census exists; the estimate is based on a community of a few dozen families in 1948.
        /// The term "Brown Jews" was sometimes used to apply to them, but not as prevalent as for "White Jews" and "Black Jews".
        /// </summary>
        [NumberOfMembers(100, 300)] //100-300
        [HigherLevelJewishEthnicSubSubSubdivision(JewishEthnicSubSubSubdivisions.Paradesi)]
        Meshuchrari,
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
