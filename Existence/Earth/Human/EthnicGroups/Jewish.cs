
using System;
using System.Reflection.Metadata;
using Existence.Earth.Countries;
using Existence.Earth.Human.EthnicGroups.Jewish.Level1;
using Existence.Earth.Human.EthnicGroups.Jewish.Level2;
using Existence.Earth.Human.EthnicGroups.Jewish.Level3;

namespace Existence.Earth.Human.EthnicGroups.Jewish
{
    public class IndependentJewishSubdivisionAttribute : Attribute
    {
    }

    public class HigherLevelJewishSubdivisionLevel1Attribute : Attribute
    {
        public JewishEthnicDivisionsLevel1 Subdivision { get; set; }
        public HigherLevelJewishSubdivisionLevel1Attribute(JewishEthnicDivisionsLevel1 Subdivision)
        {
            this.Subdivision = Subdivision;
        }
    }

    /// <summary>
    /// for subdivisions with significant populations from two higher level subdivisions. The percentages are rough
    /// estimates of the share of the community from each. They need not add up to exactly 100, since a small
    /// remainder from other groups is not worth tracking.
    /// </summary>
    public class HigherLevelJewishSubdivisionsLevel1Attribute : Attribute
    {
        public JewishEthnicDivisionsLevel1 Subdivision1 { get; set; }
        public int Subdivision1Percentage { get; set; }
        public JewishEthnicDivisionsLevel1 Subdivision2 { get; set; }
        public int Subdivision2Percentage { get; set; }
        public HigherLevelJewishSubdivisionsLevel1Attribute(JewishEthnicDivisionsLevel1 Subdivision1, int Subdivision1Percentage, JewishEthnicDivisionsLevel1 Subdivision2, int Subdivision2Percentage)
        {
            this.Subdivision1 = Subdivision1;
            this.Subdivision1Percentage = Subdivision1Percentage;
            this.Subdivision2 = Subdivision2;
            this.Subdivision2Percentage = Subdivision2Percentage;
        }
    }

    public class HigherLevelJewishSubdivisionLevel2Attribute : Attribute
    {
        public JewishEthnicDivisionsLevel2 Subdivision { get; set; }
        public HigherLevelJewishSubdivisionLevel2Attribute(JewishEthnicDivisionsLevel2 Subdivision)
        {
            this.Subdivision = Subdivision;
        }
    }

    public class HigherLevelJewishSubdivisionLevel3Attribute : Attribute
    {
        public JewishEthnicDivisionsLevel3 Subdivision { get; set; }
        public HigherLevelJewishSubdivisionLevel3Attribute(JewishEthnicDivisionsLevel3 Subdivision)
        {
            this.Subdivision = Subdivision;
        }
    }
}

namespace Existence.Earth.Human.EthnicGroups.Jewish.Level1
{

    /// <summary>
    /// high level ethnic subdivisions of Jewish people
    /// Member counts are rough and add up to more than the world's ~16 million Jews, since many Jews
    /// (especially in Israel) have mixed ancestry and are counted in more than one group.
    /// </summary>
    public enum JewishEthnicDivisionsLevel1
    {
        /// <summary>
        /// Central and Eastern Europe (originally the Rhineland, later Poland, Lithuania, and Russia), now mostly the United States and Israel
        /// The majority of the world's Jews. Traditional language is Yiddish.
        /// </summary>
        [NumberOfMembers(10000000, 11500000)] //10-11.5 million
        [OriginatedFrom(JewishEthnicDivisionsLevel2.Yekke, HierarchyItemOriginTypes.Main)]
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
        [OriginatedFrom(JewishEthnicDivisionsLevel1.Sephardi, HierarchyItemOriginTypes.Significant)]
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
}

namespace Existence.Earth.Human.EthnicGroups.Jewish.Level2
{

    /// <summary>
    /// main level ethnic subdivisions of Jewish people
    /// </summary>
    public enum JewishEthnicDivisionsLevel2
    {
        /// <summary>
        /// Aden, in southern Yemen, a British colony from 1839 to 1967
        /// Ties to British India set them apart from the Jews of inland Yemen.
        /// Most left for Israel and the United Kingdom after riots in 1947 and 1967.
        /// No modern count exists; the estimate is based on the community's size of about 8,000 in 1947.
        /// </summary>
        [NumberOfMembers(10000, 25000)] //10,000-25,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Teimani)]
        [Country(CountryLikeThings.Yemen)]
        Adeni,

        /// <summary>
        /// Afghanistan (mainly Herat, Kabul, and Balkh), now mostly Israel and New York
        /// Closely tied to Persian Jews and spoke a Judeo-Persian dialect; many came from Mashhad, Iran, after its Jews were
        /// forced to convert in 1839. Most left for Israel after 1948, and the last known Jew left Afghanistan in 2021.
        /// No modern count exists; the estimate is based on a population of about 5,000 in 1948.
        /// </summary>
        [NumberOfMembers(10000, 20000)] //10,000-20,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Mizrahi)]
        [Country(CountryLikeThings.Afghanistan)]
        [OriginatedFrom(JewishEthnicDivisionsLevel2.Persian, HierarchyItemOriginTypes.Main)]
        Afghan,

        /// <summary>
        /// Algeria, now mostly France
        /// An ancient community joined by Sephardic exiles after 1492. The Cremieux Decree of 1870 made them French citizens,
        /// so nearly all left for France rather than Israel when Algeria became independent in 1962.
        /// No modern count exists; the estimate is based on a population of about 140,000 in 1948.
        /// </summary>
        [NumberOfMembers(200000, 350000)] //200,000-350,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Maghrebi)]
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
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Mizrahi)]
        [Country(CountryLikeThings.Iraq)]
        Bavlim,

        /// <summary>
        /// Belmonte, a small town in eastern Portugal
        /// Crypto-Jews whose ancestors were forced to convert to Catholicism in 1497, but who secretly kept Jewish prayers and
        /// customs, passed down mostly by women, for nearly 500 years. Discovered by outsiders in 1917, they formally
        /// returned to Judaism in the late 20th century and opened a synagogue in 1996.
        /// </summary>
        [NumberOfMembers(100, 300)] //100-300
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Sephardi)]
        [Country(CountryLikeThings.Portugal)]
        Belmonte,

        /// <summary>
        /// India (the Konkan coast of Maharashtra, later Mumbai), now mostly Israel
        /// By tradition descended from Jews shipwrecked on the Konkan coast about 2,000 years ago. Spoke Marathi, and lived
        /// largely cut off from other Jews, keeping the Sabbath, circumcision, and dietary laws, until contact was renewed
        /// in the 18th century. Most moved to Israel in the 1950s and 1960s; about 4,000-5,000 remain in India.
        /// No modern count exists; the estimate is based on a population of about 20,000-30,000 in 1948.
        /// </summary>
        [NumberOfMembers(60000, 85000)] //60,000-85,000
        [IndependentJewishSubdivision]
        [Country(CountryLikeThings.India)]
        BeneIsrael,

        /// <summary>
        /// Ethiopia (mostly around Gondar, also Tigray and Qwara), now nearly all Israel
        /// Developed separately from other Jewish communities for centuries, with scriptures and prayers in Ge'ez.
        /// Most were brought to Israel in Operation Moses (1984) and Operation Solomon (1991).
        /// The count includes Israeli-born children and the Falash Mura.
        /// </summary>
        [NumberOfMembers(160000, 180000)] //160,000-180,000
        [IndependentJewishSubdivision]
        [Country(CountryLikeThings.Ethiopia)]
        BetaIsrael,

        /// <summary>
        /// Central Asia, mainly Uzbekistan (Bukhara, Samarkand, Tashkent) and Tajikistan (Dushanbe), now mostly Israel and New York (Queens)
        /// Named for the old Emirate of Bukhara. Descended from Persian Jews, and spoke Bukhori, a Jewish dialect of Tajik.
        /// Nearly all left after the fall of the Soviet Union in 1991; only a few hundred remain in Central Asia.
        /// </summary>
        [NumberOfMembers(150000, 250000)] //150,000-250,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Mizrahi)]
        [Countries(CountryLikeThings.Tajikistan, CountryLikeThings.Uzbekistan)]
        [OriginatedFrom(JewishEthnicDivisionsLevel2.Persian, HierarchyItemOriginTypes.Main)]
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
        [IndependentJewishSubdivision]
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
        /// </summary>
        [NumberOfMembers(1000, 3000)] //1,000-3,000
        [IndependentJewishSubdivision]
        [Country(CountryLikeThings.Ukraine)]
        CrimeanKaraite,

        /// <summary>
        /// Egypt (mainly Cairo and Alexandria), now mostly Israel, France, the United States, and Brazil
        /// One of the oldest diaspora communities; Maimonides lived in Cairo, and its Ben Ezra Synagogue held the Cairo Geniza,
        /// a vast store of medieval manuscripts. By the 20th century it mixed Arabic-speaking native Jews, Sephardic and Italian
        /// families, Ashkenazi immigrants, and a community of Karaites. Nearly all left or were expelled after 1948, 1956, and 1967;
        /// only a handful remain.
        /// No modern count exists; the estimate is based on a population of about 75,000-80,000 in 1948.
        /// The Mizrahi/Sephardi split is a rough estimate: by the 20th century most families were immigrants, many of them
        /// Sephardic from Ottoman lands and Italy, alongside native, Syrian, and Iraqi Jews and the Karaites. The remaining
        /// ~10% of the community was Ashkenazi.
        /// </summary>
        [NumberOfMembers(150000, 250000)] //150,000-250,000
        [HigherLevelJewishSubdivisionsLevel1(JewishEthnicDivisionsLevel1.Mizrahi, 40, JewishEthnicDivisionsLevel1.Sephardi, 50)]
        [Country(CountryLikeThings.Egypt)]
        Egyptian,

        /// <summary>
        /// Galician Jews
        /// Galicia, an Austrian province from 1772 to 1918, now southeastern Poland (Krakow, Tarnow, Rzeszow) and western Ukraine
        /// (Lviv, Brody, Ternopil), now mostly the United States and Israel
        /// A stronghold of Hasidism and the home of the Belz, Bobov, and Sanz dynasties. Known for a long-running friendly rivalry
        /// with the Litvaks over Yiddish pronunciation, religious style, and food (Galitzianers sweeten their gefilte fish).
        /// Hundreds of thousands emigrated, mostly to the United States, before World War I; most of those who stayed were murdered
        /// in the Holocaust.
        /// No modern count exists; the estimate is of descendants of a population of about 870,000 in 1910.
        /// </summary>
        [NumberOfMembers(1000000, 2000000)] //1-2 million
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Ashkenazi)]
        [Countries(CountryLikeThings.Poland, CountryLikeThings.Ukraine)]
        Galitzianer,

        /// <summary>
        /// Georgian Jews
        /// Georgia (mainly Tbilisi, Kutaisi, and Oni), now mostly Israel
        /// One of the oldest diaspora communities, by tradition arriving after the Babylonian exile about 2,600 years ago.
        /// Spoke Georgian, and lived for centuries with little of the persecution Jews faced elsewhere. Among the first Soviet Jews
        /// to openly demand the right to emigrate, in 1969; most left for Israel in the 1970s and after 1991, and a few
        /// thousand remain in Georgia.
        /// </summary>
        [NumberOfMembers(100000, 140000)] //100,000-140,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Mizrahi)]
        [Country(CountryLikeThings.Georgia)]
        Gruzim,

        /// <summary>
        /// Habban, in eastern Yemen
        /// A small, isolated community with its own customs and dress. Nearly all moved to Israel around 1950.
        /// No modern count exists; the estimate is based on the few hundred who emigrated around 1950.
        /// </summary>
        [NumberOfMembers(3000, 10000)] //3,000-10,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Teimani)]
        [Country(CountryLikeThings.Yemen)]
        Habbani,

        /// <summary>
        /// Western Sephardim (the more common name), Spanish and Portuguese Jews
        /// Spain and Portugal, resettled in Amsterdam, London, Hamburg, southwestern France, and the Americas
        /// Descendants of Iberian Jews forced to convert to Catholicism, many of whom fled in the 16th and 17th centuries and
        /// returned to Judaism openly where it was tolerated. Kept a Portuguese and Spanish rather than a Ladino tradition.
        /// Founded some of the oldest synagogues still in use in the Western world, including the Portuguese Synagogue in
        /// Amsterdam (1675), Bevis Marks in London (1701), and Shearith Israel, New York's oldest Jewish congregation.
        /// The count is of those still in Western Sephardic families and congregations, which today also include many
        /// members of other origins; far more people have some Western Sephardic ancestry.
        /// </summary>
        [NumberOfMembers(10000, 30000)] //10,000-30,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Sephardi)]
        [Countries(CountryLikeThings.Portugal, CountryLikeThings.Spain)]
        Iberian,

        /// <summary>
        /// Italian Jews
        /// Italy (mainly Rome, also Venice, Florence, Livorno, and Turin), now mostly Italy and Israel
        /// The oldest Jewish community in Europe: Jews have lived in Rome continuously since the 2nd century BCE. Follow their own
        /// Italian rite, neither Ashkenazi nor Sephardi. Venice's Jewish quarter of 1516 gave the world the word "ghetto".
        /// Italy also had separate Sephardic and Ashkenazi communities, which are not counted here.
        /// </summary>
        [NumberOfMembers(20000, 40000)] //20,000-40,000
        [IndependentJewishSubdivision]
        [Country(CountryLikeThings.Italy)]
        Italkim,

        /// <summary>
        /// Mountain Jews, Juhuro
        /// The eastern Caucasus: northern Azerbaijan (Quba) and Dagestan and Kabardino-Balkaria in Russia (Derbent, Makhachkala, Nalchik), now mostly Israel,
        /// plus Russia, Azerbaijan, and New York
        /// Descended from Persian Jews who settled in the Caucasus more than a thousand years ago. Speak Juhuri (Judeo-Tat),
        /// a Persian language. The Red Village (Qirmizi Qasaba) near Quba, Azerbaijan, is one of the only all-Jewish towns
        /// outside Israel. Not the same as Georgian Jews (Gruzim), who live in the western Caucasus and speak Georgian.
        /// </summary>
        [NumberOfMembers(150000, 250000)] //150,000-250,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Mizrahi)]
        [Countries(CountryLikeThings.Azerbaijan, CountryLikeThings.Russia)]
        [OriginatedFrom(JewishEthnicDivisionsLevel2.Persian, HierarchyItemOriginTypes.Main)]
        Juhurim,

        /// <summary>
        /// Crimea, mainly Karasubazar (now Bilohirsk). Now mostly Israel, Russia, and Ukraine
        /// Rabbinic Jews who speak Krymchak, a Turkic language close to Crimean Tatar. Formed from ancient Black Sea and Byzantine
        /// Jewish communities, later joined by Italian, Ashkenazi, and Sephardic Jews. Not the same as the Crimean Karaites,
        /// who share their region and Turkic language but follow Karaite Judaism. Unlike the Karaites, the Nazis classed them as
        /// Jews, and about three quarters were murdered in 1941-1942.
        /// </summary>
        [NumberOfMembers(1000, 2000)] //1,000-2,000
        [IndependentJewishSubdivision]
        [Country(CountryLikeThings.Ukraine)]
        Krymchak,

        /// <summary>
        /// Kurdistan: northern Iraq (Zakho, Amadiya, Erbil), northwestern Iran (Urmia, Sanandaj), and southeastern Turkey,
        /// now mostly Israel
        /// By tradition descended from the Israelites exiled by the Assyrians in the 8th century BCE. Spoke Jewish dialects of
        /// Neo-Aramaic, the language of the Talmud, rather than Kurdish. Asenath Barzani, a 17th-century scholar who headed a
        /// yeshiva in Mosul, is often called the first female rabbi. Nearly all left for Israel in the early 1950s.
        /// </summary>
        [NumberOfMembers(150000, 200000)] //150,000-200,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Mizrahi)]
        [Countries(CountryLikeThings.Iran, CountryLikeThings.Iraq, CountryLikeThings.Turkey)]
        Kurdish,

        /// <summary>
        /// Lebanon (mainly Beirut's Wadi Abu Jamil quarter, also Sidon and Mount Lebanon), now mostly France, the United States,
        /// Brazil, Mexico, Canada, and Israel
        /// An ancient community, joined by Sephardic exiles after 1492 and by many Jews from Syria. Unusually, it grew after 1948,
        /// as Jews fleeing Syria and Iraq arrived, peaking at about 10,000. Most left after 1967 and during the civil war of
        /// 1975-1990; only a few dozen remain. Beirut's Maghen Abraham Synagogue was restored in the 2010s.
        /// No modern count exists; the estimate is of descendants of a community that peaked at about 10,000.
        /// The Mizrahi/Sephardi split is a rough estimate: the Sephardic exiles were a minority, and the later arrivals
        /// from Syria and Iraq added mostly Mizrahi ancestry.
        /// </summary>
        [NumberOfMembers(20000, 40000)] //20,000-40,000
        [HigherLevelJewishSubdivisionsLevel1(JewishEthnicDivisionsLevel1.Mizrahi, 70, JewishEthnicDivisionsLevel1.Sephardi, 30)]
        [Country(CountryLikeThings.Lebanon)]
        [OriginatedFrom(JewishEthnicDivisionsLevel2.Syrian, HierarchyItemOriginTypes.Significant)]
        Lebanese,

        /// <summary>
        /// Libya (mainly Tripoli and Benghazi, also villages in the Nafusa Mountains), now mostly Israel and Italy
        /// One of the oldest communities in North Africa, dating to the Greek city of Cyrene. Under Italian rule in World War II,
        /// Jews in Cyrenaica were sent to the Giado camp, where hundreds died. Riots in 1945 and 1948 killed well over a hundred;
        /// about 30,000 left for Israel in 1949-1951, and the rest left for Italy after riots in 1967. None remain.
        /// No modern count exists; the estimate is based on a population of about 35,000-38,000 in 1948.
        /// </summary>
        [NumberOfMembers(100000, 150000)] //100,000-150,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Maghrebi)]
        [Countries(CountryLikeThings.LibyaEast, CountryLikeThings.LibyaWest)]
        Libyan,

        /// <summary>
        /// Lithuanian Jews
        /// The lands of the old Grand Duchy of Lithuania: Lithuania, Belarus, eastern Latvia, and northeastern Poland
        /// (Vilnius, Minsk, Grodno, Bialystok), now mostly the United States, Israel, and South Africa
        /// Centered on Vilnius, the "Jerusalem of Lithuania", home of the Vilna Gaon, who led the opposition to Hasidism
        /// in the 18th century. Known for their great yeshivas and for scholarship. Most South African Jews are of Litvak descent.
        /// About 95% of Lithuania's Jews were murdered in the Holocaust. "Litvish" is also used today for any non-Hasidic
        /// Haredi Jew in the yeshiva tradition, regardless of ancestry.
        /// No modern count exists; the estimate is of descendants of a population of about 1.5 million in 1897.
        /// </summary>
        [NumberOfMembers(2000000, 4000000)] //2-4 million
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Ashkenazi)]
        [Countries(CountryLikeThings.Belarus, CountryLikeThings.Latvia, CountryLikeThings.Lithuania, CountryLikeThings.Poland)]
        Litvak,

        /// <summary>
        /// Morocco (mainly Casablanca, Fez, Marrakesh, Meknes, Tetouan, and the Atlas villages), now mostly Israel, France, and Canada (Montreal)
        /// The largest Jewish community in the Muslim world in the 20th century, about 250,000-265,000 in 1948. A mix of ancient
        /// native Jews (toshavim) and Sephardic exiles (megorashim) who arrived after 1492; northern Moroccan Jews spoke Haketia,
        /// a form of Judeo-Spanish, while others spoke Judeo-Arabic or Judeo-Berber. Fez's mellah of 1438 was the first walled
        /// Jewish quarter in Morocco. Most left from the 1950s on, about 97,000 of them secretly in Operation Yachin (1961-1964).
        /// About 2,000 remain, the largest Jewish community left in the Arab world. Moroccan Jews are the largest Mizrahi or
        /// Maghrebi group in Israel. The count includes the Berber Jews.
        /// </summary>
        [NumberOfMembers(900000, 1200000)] //900,000-1.2 million
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Maghrebi)]
        [Country(CountryLikeThings.Morocco)]
        [HasSubdivisions]
        Moroccan,

        /// <summary>
        /// The "Oberland" of the old Kingdom of Hungary: western Hungary (Sopron, Gyor), Burgenland (now Austria), and western
        /// Slovakia (Bratislava, then Pressburg), now mostly the United States and Israel
        /// Descended mainly from Moravian and Austrian Jews who moved east in the 17th and 18th centuries, keeping German and
        /// Western Yiddish speech. Orthodox but not Hasidic, unlike the Unterlander Jews of eastern Hungary. Pressburg's yeshiva,
        /// led by the Chatam Sofer (Moses Sofer, 1762-1839), made the region the center of Orthodox opposition to Reform Judaism.
        /// Burgenland's Jews were expelled after Austria's annexation in 1938, and most others were murdered in the Holocaust in 1944.
        /// No modern count exists; the estimate is of descendants of a population of roughly 100,000-150,000 before World War II.
        /// </summary>
        [NumberOfMembers(100000, 200000)] //100,000-200,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Ashkenazi)]
        [Countries(CountryLikeThings.Austria, CountryLikeThings.Hungary, CountryLikeThings.Slovakia)]
        [OriginatedFrom(JewishEthnicDivisionsLevel2.Yekke, HierarchyItemOriginTypes.Main)]
        Oberlander,

        /// <summary>
        /// Old Yishuv ("the old settlement" in Hebrew), Palestinian Jews, Jewish Palestinians
        /// Ottoman Palestine, mainly the four holy cities of Jerusalem, Hebron, Safed, and Tiberias, now Israel
        /// The Jews who lived in the Land of Israel before Zionist immigration began in 1881, about 25,000 at the time.
        /// Included the Musta'arabim, Arabic-speaking Jews whose families had stayed through the centuries (some families in
        /// Peki'in claim unbroken residence since ancient times), who were largely absorbed into the Sephardic exiles who settled
        /// there after 1492, especially in Safed. Ashkenazi groups arrived from the 18th century on, and by the 1880s made up
        /// close to half. Mostly lived on charity from abroad (the halukka) and devoted to religious study.
        /// Under the British Mandate (1920-1948) all residents of Palestine, Jews included, were called Palestinians.
        /// No modern count exists; the estimate is of descendants of the community of about 25,000 in 1881.
        /// The Ashkenazi/Sephardi split is a rough estimate, with a small Mizrahi remainder.
        /// </summary>
        [NumberOfMembers(150000, 300000)] //150,000-300,000
        [HigherLevelJewishSubdivisionsLevel1(JewishEthnicDivisionsLevel1.Ashkenazi, 40, JewishEthnicDivisionsLevel1.Sephardi, 55)]
        [Countries(CountryLikeThings.Israel, CountryLikeThings.PalestineWestBank)]
        Palestinian,

        /// <summary>
        /// Iranian Jews
        /// Iran (mainly Tehran, Isfahan, Shiraz, Hamadan, and Mashhad), now mostly Israel and the United States (Los Angeles, New York)
        /// One of the oldest diaspora communities, dating to the Babylonian exile and the Persian Empire; the Book of Esther is set
        /// in the Persian capital of Susa. Spoke Judeo-Persian dialects. About 80,000-100,000 lived in Iran before the 1979
        /// revolution, after which most left; about 8,000-10,000 remain, the largest Jewish community in the Middle East outside Israel.
        /// </summary>
        [NumberOfMembers(250000, 350000)] //250,000-350,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Mizrahi)]
        [Country(CountryLikeThings.Iran)]
        Persian,

        /// <summary>
        /// Romaniote Jews, Greek Jews
        /// Greece (mainly Ioannina, also Chalkis, Arta, and Corfu) and the old Byzantine Empire, now mostly Israel, Greece, and New York
        /// Greek-speaking Jews who have lived in Greece for over 2,000 years, among the oldest Jewish communities in Europe.
        /// Named for the "Romans", as the Byzantines called themselves. Spoke Yevanic (Judeo-Greek), now nearly extinct, and kept
        /// their own prayer rite. After 1492 the far larger Sephardic arrivals absorbed most Romaniote communities, including that
        /// of Thessaloniki; Ioannina remained the main exception. Most of the remaining Romaniotes were murdered in the Holocaust
        /// in 1944. Kehila Kedosha Janina in New York is the only Romaniote synagogue in the Western Hemisphere.
        /// No modern count exists; the estimate is a rough figure for those who still identify as Romaniote.
        /// </summary>
        [NumberOfMembers(5000, 15000)] //5,000-15,000
        [IndependentJewishSubdivision]
        [Country(CountryLikeThings.Greece)]
        Romaniote,

        /// <summary>
        /// Sudan (mostly Khartoum and Omdurman)
        /// A small community, at most about a thousand people, mostly Sephardic families from Egypt and the Ottoman Empire
        /// who arrived in the late 19th and early 20th centuries. Nearly all left by the 1960s, for Israel, the United Kingdom,
        /// the United States, and Switzerland.
        /// No modern count exists; the estimate is based on the community's peak of about a thousand.
        /// The Mizrahi/Sephardi split is a rough estimate: most families were Sephardic, with a smaller number of
        /// Mizrahi families from Egypt and Iraq.
        /// </summary>
        [NumberOfMembers(2000, 5000)] //2,000-5,000
        [HigherLevelJewishSubdivisionsLevel1(JewishEthnicDivisionsLevel1.Mizrahi, 30, JewishEthnicDivisionsLevel1.Sephardi, 70)]
        [Country(CountryLikeThings.Sudan)]
        [OriginatedFrom(JewishEthnicDivisionsLevel2.Egyptian, HierarchyItemOriginTypes.Main)]
        Sudanese,

        /// <summary>
        /// Syria, mainly Aleppo (Halabi Jews) and Damascus (Shami Jews), now mostly Israel, Brooklyn, and Latin America
        /// An ancient community joined by Sephardic exiles after 1492. Nearly all left after 1948, with the last few
        /// thousand allowed out in 1992.
        /// The count covers the Halabi and Shami communities combined.
        /// The Mizrahi/Sephardi split is a rough estimate: the ancient native community was the majority, and the Sephardic
        /// exiles merged into it over the following centuries, so most families have some of both.
        /// </summary>
        [NumberOfMembers(150000, 250000)] //150,000-250,000
        [HigherLevelJewishSubdivisionsLevel1(JewishEthnicDivisionsLevel1.Mizrahi, 70, JewishEthnicDivisionsLevel1.Sephardi, 30)]
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
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Ashkenazi)]
        [Country(CountryLikeThings.Russia)]
        Tatar,

        /// <summary>
        /// Tunisia, now mostly Israel and France
        /// Split historically between the Twansa, an ancient native community, and the Granas, who came from Livorno, Italy,
        /// from the 17th century on. About a thousand remain, mostly on the island of Djerba, home of the El Ghriba synagogue.
        /// No modern count exists; the estimate is based on a population of about 105,000 in 1948.
        /// </summary>
        [NumberOfMembers(250000, 350000)] //250,000-350,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Maghrebi)]
        [Country(CountryLikeThings.Tunisia)]
        [HasSubdivisions]
        Tunisian,

        /// <summary>
        /// The "Unterland" of the old Kingdom of Hungary: northeastern Hungary, Carpathian Ruthenia, eastern Slovakia, and Maramures
        /// Mostly Hasidic, unlike the more modernized Oberlander Jews of western Hungary. Most were murdered in the Holocaust
        /// in 1944, but several major Hasidic dynasties, such as Satmar and Munkacs, come from here.
        /// No modern count exists; the estimate is of survivors' descendants, mostly in Hasidic communities in New York and Israel.
        /// </summary>
        [NumberOfMembers(100000, 300000)] //100,000-300,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Ashkenazi)]
        [Countries(CountryLikeThings.Hungary, CountryLikeThings.Romania, CountryLikeThings.Slovakia, CountryLikeThings.Ukraine)]
        [OriginatedFrom(JewishEthnicDivisionsLevel2.Galitzianer, HierarchyItemOriginTypes.Main)]
        Unterlander,

        /// <summary>
        /// Majorcan Jews, Chuetas (spanish spelling), from Majorca (Balearic Islands, Spain)
        /// The medieval Jewish community of Majorca was known for its mapmakers, such as Cresques Abraham, who made the Catalan
        /// Atlas of 1375. It ended in forced conversions after the 1391 massacres and in 1435; some fled to North Africa,
        /// especially Algiers, and are counted as Algerian Jews.
        /// Descendants of Majorcan Jews forced to convert to Catholicism in the 14th and 15th centuries. Mostly Catholic today,
        /// but long discriminated against as a separate group. Israel's Chief Rabbinate recognized them as Jews in 2011.
        /// The count is of Majorcans who carry one of the traditional Xueta surnames.
        /// </summary>
        [NumberOfMembers(15000, 20000)] //15,000-20,000
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Sephardi)]
        [Country(CountryLikeThings.Spain)]
        Xuetes,

        /// <summary>
        /// Germany, plus the German-speaking Jews of Austria and the Czech lands, now mostly the United States, Israel, and the United Kingdom
        /// The original Ashkenazi Jews: "Ashkenaz" was the medieval Hebrew name for Germany, and Ashkenazi Jewry began in the
        /// Rhineland towns of Speyer, Worms, and Mainz. In the 19th century they became highly assimilated, and gave rise to the
        /// Jewish Enlightenment (Haskalah) and Reform Judaism. Most fled after the Nazis took power in 1933, and those who stayed
        /// were mostly murdered in the Holocaust. Germany's Jewish community today is mostly from the former Soviet Union.
        /// No modern count exists; the estimate is of descendants of a population of about 525,000 in Germany in 1933,
        /// about 190,000 in Austria, and the German-speaking share of about 120,000 in the Czech lands.
        /// </summary>
        [NumberOfMembers(700000, 1400000)] //700,000-1.4 million
        [HigherLevelJewishSubdivisionLevel1(JewishEthnicDivisionsLevel1.Ashkenazi)]
        [Countries(CountryLikeThings.Austria, CountryLikeThings.CzechRepublic, CountryLikeThings.Germany)]
        Yekke,
    }
}

namespace Existence.Earth.Human.EthnicGroups.Jewish.Level3
{
    /// <summary>
    /// smaller level ethnic subdivisions of Jewish people
    /// </summary>
    public enum JewishEthnicDivisionsLevel3
    {
        /// <summary>
        /// Livornese Jews, Tunis, Tunisia, now mostly France, Italy, and Israel
        /// From "Grana", the Arabic name for Livorno, Italy. Merchant families of Portuguese Sephardic descent who came from
        /// Livorno from the 17th century on, speaking Italian and keeping European dress and customs. Founded their own
        /// congregation in 1710, and kept separate synagogues, rabbis, and courts from the Twansa into the 20th century.
        /// No census exists; the estimate is roughly a tenth of the Tunisian Jewish population.
        /// </summary>
        [NumberOfMembers(20000, 35000)] //20,000-35,000
        [HigherLevelJewishSubdivisionLevel2(JewishEthnicDivisionsLevel2.Tunisian)]
        [OriginatedFrom(JewishEthnicDivisionsLevel2.Iberian, HierarchyItemOriginTypes.Main)]
        Granas,

        /// <summary>
        /// Aleppo (Halab in Arabic), now mostly Brooklyn, Israel, Mexico, Panama, and Argentina
        /// One of the oldest Jewish communities in the world, joined by Sephardic exiles after 1492. For about 600 years it kept
        /// the Aleppo Codex, the oldest near-complete Hebrew Bible manuscript, until riots in 1947 damaged it.
        /// Kept separate synagogues and community institutions from Shami Jews, even in the diaspora.
        /// No census exists; the estimate is the larger share of the Syrian Jewish diaspora
        /// </summary>
        [NumberOfMembers(100000, 160000)] //100,000-160,000
        [HigherLevelJewishSubdivisionLevel2(JewishEthnicDivisionsLevel2.Syrian)]
        Halabi,

        /// <summary>
        /// Kerala, India (mainly Ernakulam, Parur, Mala, and Chendamangalam), now mostly Israel
        /// The older and much larger of the two Cochin Jewish communities, descended from the ancient settlers of the Malabar Coast.
        /// Historically called "Black Jews" by English-language sources. Kept their own synagogues and did not intermarry with the Paradesi Jews.
        /// No census exists; the estimate is most of the Cochin Jewish population.
        /// </summary>
        [NumberOfMembers(6500, 9500)] //6,500-9,500
        [HigherLevelJewishSubdivisionLevel2(JewishEthnicDivisionsLevel2.Cochin)]
        Malabari,

        /// <summary>
        /// "The expelled" in Hebrew; mainly Fez, Tetouan, Tangier, Rabat, and Meknes, Morocco, now mostly Israel, France, and Canada
        /// Sephardic exiles who arrived after 1391 and 1492, and their descendants. Northern communities spoke Haketia, a form of
        /// Judeo-Spanish. Their Castilian customs and religious law came to dominate Moroccan Judaism, and in most places they
        /// gradually merged with the Toshavim, so the line between the two is blurry today.
        /// No census exists; the estimate is roughly 30% of the Moroccan Jewish population.
        /// </summary>
        [NumberOfMembers(250000, 400000)] //250,000-400,000
        [HigherLevelJewishSubdivisionLevel2(JewishEthnicDivisionsLevel2.Moroccan)]
        [OriginatedFrom(JewishEthnicDivisionsLevel1.Sephardi, HierarchyItemOriginTypes.Main)]
        Megorashim,

        /// <summary>
        /// Jew Town in Kochi, Kerala, India, now mostly Israel, plus Australia and the United States
        /// "Foreigners": Jews who arrived from the 16th century on, mainly Sephardic exiles from Spain and Portugal, plus Jews
        /// from the Netherlands, Germany, Iraq, and Syria. Historically called "White Jews" by English-language sources. Built the Paradesi
        /// Synagogue in 1568, still standing today.
        /// No census exists; the estimate is based on a community of a few hundred in 1948.
        /// </summary>
        [NumberOfMembers(300, 600)] //300-600
        [HigherLevelJewishSubdivisionLevel2(JewishEthnicDivisionsLevel2.Cochin)]
        [HasSubdivisions]
        [OriginatedFrom(JewishEthnicDivisionsLevel1.Sephardi, HierarchyItemOriginTypes.Main)]
        Paradesi,

        /// <summary>
        /// Damascus (al-Sham in Arabic), now mostly Brooklyn, Israel, and Argentina
        /// An ancient community, smaller than the Halabi Jews, that also absorbed Sephardic exiles after 1492. Known for the
        /// Damascus affair of 1840, a blood libel that drew international protest.
        /// Not the same as the Shami prayer rite of Yemenite Jews, which is named for the Levant as a whole.
        /// No census exists; the estimate is the smaller share of the Syrian Jewish diaspora
        /// </summary>
        [NumberOfMembers(50000, 90000)] //50,000-90,000
        [HigherLevelJewishSubdivisionLevel2(JewishEthnicDivisionsLevel2.Syrian)]
        Shami,

        /// <summary>
        /// "Residents" in Hebrew; Morocco, especially the interior, the south, and the Atlas villages, now mostly Israel
        /// The native Moroccan Jews, descended from communities that were there before the Sephardic exiles arrived; some may
        /// descend partly from Berbers who converted to Judaism. Spoke Judeo-Arabic or Judeo-Berber. The majority of Moroccan
        /// Jews, though many adopted the Megorashim's customs over time. Includes the Berber Jews.
        /// No census exists; the estimate is roughly 70% of the Moroccan Jewish population.
        /// </summary>
        [NumberOfMembers(600000, 850000)] //600,000-850,000
        [HigherLevelJewishSubdivisionLevel2(JewishEthnicDivisionsLevel2.Moroccan)]
        [HasSubdivisions]
        Toshavim,

        /// <summary>
        /// Touansa; "Tunisians" in Arabic; Tunis's Hara quarter, Djerba, Sfax, Sousse, and other towns, now mostly Israel and France
        /// The native Tunisian Jews, including the ancient community of Djerba, home of the El Ghriba synagogue. Spoke Judeo-Arabic.
        /// Absorbed some Iberian exiles after 1391 and 1492, but kept separate institutions from the Granas into the 20th century.
        /// No census exists; the estimate is roughly 90% of the Tunisian Jewish population.
        /// </summary>
        [NumberOfMembers(220000, 320000)] //220,000-320,000
        [HigherLevelJewishSubdivisionLevel2(JewishEthnicDivisionsLevel2.Tunisian)]
        Twansa,
    }
}

namespace Existence.Earth.Human.EthnicGroups.Jewish.Level4
{
    /// <summary>
    /// smallest level ethnic subdivision(s) of Jewish people
    /// </summary>
    public enum JewishEthnicDivisionsLevel4
    {
        /// <summary>
        /// Amazigh Jews
        /// Villages of the Atlas Mountains and the valleys south of them (Draa, Sous, Todra), Morocco, now mostly Israel
        /// Rural Jews who lived among Berber tribes and spoke Judeo-Berber rather than Judeo-Arabic. Whether they descend
        /// partly from Berbers who converted to Judaism is debated. Nearly all left for Israel in the 1950s and 1960s.
        /// No modern count exists; the estimate is based on a rural Atlas population of a few tens of thousands in 1948.
        /// </summary>
        [NumberOfMembers(50000, 150000)] //50,000-150,000
        [HigherLevelJewishSubdivisionLevel3(JewishEthnicDivisionsLevel3.Toshavim)]
        Berber,

        /// <summary>
        /// Meshuchrarim ("freed" in Hebrew), Kochi, Kerala, India, now mostly Israel
        /// Descendants of servants of Cochin Jews who were freed and converted to Judaism. Attached to the Paradesi community,
        /// but treated as lower status: they could not be called up to read the Torah or sit with other members in the Paradesi
        /// Synagogue. Abraham Barak Salem, a Meshuchrari lawyer, led a Gandhi-style campaign against this in the 1930s.
        /// No census exists; the estimate is based on a community of a few dozen families in 1948.
        /// The term "Brown Jews" was sometimes used to apply to them, but not as prevalent as for "White Jews" and "Black Jews".
        /// </summary>
        [NumberOfMembers(100, 300)] //100-300
        [HigherLevelJewishSubdivisionLevel3(JewishEthnicDivisionsLevel3.Paradesi)]
        Meshuchrari,
    }
}

namespace Existence.Earth.Human.EthnicGroups.Jewish.Historical
{
    /// <summary>
    /// Jewish communities that no longer exist as distinct groups, so they have no member counts
    /// Ordered from the most recent to die out to the oldest.
    /// </summary>
    public enum JewishEthnicDivisionsHistorical
    {
        /// <summary>
        /// Oman, mainly the port cities of Sohar and Muscat
        /// Jewish merchants lived in Sohar, a major Indian Ocean trading port, in the Middle Ages. A small community in Muscat
        /// in the 19th century included Jews who had fled persecution in Baghdad. It disappeared by the early 20th century, its
        /// members moving on to Aden, India, and elsewhere. Sources on the community are sparse.
        /// </summary>
        [Country(CountryLikeThings.Oman)]
        Omani,

        /// <summary>
        /// Medieval French Jews, from Tzarfat, the Hebrew name for France; mainly northern France and Champagne (Troyes, Paris, Rouen)
        /// Home of Rashi (1040-1105), the most widely studied Bible and Talmud commentator, and of the Tosafists who followed him.
        /// Wrote French in Hebrew letters (Judeo-French). Expelled in 1182, readmitted in 1198, expelled again in 1306, and
        /// finally in 1394; the survivors were absorbed into the Ashkenazi Jews of Germany and into the Jews of Provence and Italy.
        /// </summary>
        [Country(CountryLikeThings.France)]
        Zarphatim,

        /// <summary>
        /// The Khazar Khaganate, a Turkic empire between the Black Sea, the Caspian Sea, and the Volga, 7th-10th centuries
        /// Its ruling class converted to Judaism around the 8th-9th centuries; how far Judaism spread among ordinary Khazars is
        /// debated. Known in Jewish tradition through the Khazar Correspondence and Judah Halevi's book the Kuzari. The empire
        /// collapsed after the Rus destroyed its capital, Atil, in the 960s, and left no identifiable descendants. Genetic studies
        /// have ruled out the theory that Ashkenazi Jews descend mainly from the Khazars.
        /// </summary>
        [Countries(CountryLikeThings.Kazakhstan, CountryLikeThings.Russia, CountryLikeThings.Ukraine)]
        Khazar,

        /// <summary>
        /// The Hejaz in western Arabia: Medina (then Yathrib), the oasis of Khaybar, and towns such as Tayma and Fadak
        /// Jewish tribes, including the Banu Qaynuqa, Banu Nadir, and Banu Qurayza of Medina, who lived there before Islam.
        /// The Qaynuqa and Nadir were expelled from Medina in 624 and 625, the men of the Qurayza were killed in 627, and
        /// Khaybar was conquered in 628. The remaining Jews were expelled from the Hejaz under the caliph Umar in the 640s;
        /// some resettled in Syria and Iraq.
        /// </summary>
        [Country(CountryLikeThings.SaudiArabia)]
        Arabian,

        /// <summary>
        /// The Kingdom of Himyar in Yemen
        /// Himyar's rulers adopted Judaism in the late 4th century. Its last Jewish king, Dhu Nuwas, massacred the Christians
        /// of Najran in 523, and an invasion from the Christian kingdom of Aksum, in Ethiopia, ended the kingdom in about 525.
        /// Some of its people may have been absorbed into the Yemenite Jewish community.
        /// </summary>
        [Country(CountryLikeThings.Yemen)]
        Himyarite,

        /// <summary>
        /// Alexandria, Egypt
        /// The great Greek-speaking Jewish community of the ancient world, founded soon after the city in 331 BCE and one of
        /// the largest in the diaspora. The Septuagint, the Greek translation of the Bible, was made there, and the philosopher
        /// Philo lived there. It suffered riots in 38 CE and was largely destroyed in the diaspora revolt of 115-117 CE.
        /// Later Jewish communities in Alexandria were founded anew and are counted as Egyptian Jews.
        /// </summary>
        [Country(CountryLikeThings.Egypt)]
        Alexandrian,
    }
}