
namespace WorldConflict
{
    public class YearRangeAttribute : Attribute
    {
        public int Start { get; set; }
        public int End { get; set; }
        public YearRangeAttribute(int Start, int End)
        {
            this.Start = Start;
            this.End = End;
        }
    }

    public class LocationsAttribute : Attribute
    {
        public string[] Locations { get; set; }
        public LocationsAttribute(params string[] Locations)
        {
            this.Locations = Locations;
        }
    }

    public class ConflictRegionsAttribute : Attribute
    {
        public ConflictRegionFlags Regions { get; set; }
        public ConflictRegionsAttribute(ConflictRegionFlags Regions)
        {
            this.Regions = Regions;
        }
    }

    public enum WarEnum
    {
        /// <summary>
        /// part of the larger geopolitical struggle during World War II and its aftermath. This crisis involved the establishment of the Azerbaijan 
        /// People's Government, a Soviet-backed separatist movement in Iranian Azerbaijan. The crisis began in 1945 when the Soviets supported the 
        /// creation of autonomous governments in Northern Iran, namely the Azerbaijan People's Government and the Kurdish Republic of Mahabad.
        /// 
        /// The situation escalated as these puppet governments, under Soviet influence, aimed for greater autonomy or outright independence from Iran. 
        /// However, the crisis ended in 1946 when, after significant diplomatic pressure including from the United States, the Soviet troops withdrew 
        /// from Iran. This allowed Iranian forces to regain control over the regions, leading to the collapse of the separatist governments in Iranian 
        /// Azerbaijan and Kurdistan in late 1946.
        /// </summary>
        [YearRange(1946, 1946)]
        [Locations("Iran")]
        [ConflictRegions(ConflictRegionFlags.MiddleEast)]
        AzerbaijanCrisis = 206,

        /// <summary>
        /// The conflict between the United Kingdom and the Irgun Zvai Leumi (IZL), also known as Etzel, was part of the broader Jewish insurgency in 
        /// Mandatory Palestine. The Irgun was a Jewish underground paramilitary organization that opposed British rule in Palestine and sought to 
        /// establish a Jewish state.
        /// 
        /// This conflict involved a series of attacks by the Irgun against British military and police targets, as well as against infrastructure and 
        /// administration symbols of the British mandate. One of the most notable events was the bombing of the King David Hotel in Jerusalem in 1946, 
        /// which served as the headquarters for the British administrative and military presence in Palestine. This attack resulted in significant 
        /// casualties and marked a peak in the violent struggle.
        /// 
        /// The conflict did not formally "end" in 1946, as hostilities continued until the British government decided to withdraw from Palestine in 1948, 
        /// leading to the establishment of the State of Israel. The year 1946 was significant, however, for major attacks and for increasing the pressure 
        /// on British authorities, contributing to the eventual decision to leave Palestine.
        /// </summary>
        [YearRange(1946, 1946)]
        [Locations("Israel")]
        [ConflictRegions(ConflictRegionFlags.MiddleEast)]
        UnitedKingdomIrgunZvaiLeuJewishInsurgencyInMandatoryPalestine = 207,

        /// <summary>
        /// The war between the Soviet Union and the Lithuanian partisans, involving groups such as the Lithuanian Nationalist Party Army (LNPA) and the 
        /// Lithuanian Territorial Defense Force (LTS(p)A), did not precisely "end" in 1946 but rather began a period of intense activity around that time.
        /// 
        /// After World War II, Lithuania, which had been occupied by Nazi Germany, was re-occupied by the Soviet Union. This led to the emergence of 
        /// Lithuanian partisan groups who waged a guerrilla war against Soviet authorities aiming to re-establish an independent Lithuanian state. 
        /// These resistance efforts were part of a broader anti-Soviet resistance movement across the Baltic states.
        /// 
        /// The conflict between these Lithuanian partisans and the Soviet Union was particularly fierce from 1944 to the early 1950s, with 1946 being a 
        /// year of significant activity. However, it did not conclude in that year. The guerrilla warfare carried on until around 1953, with diminishing 
        /// intensity as the Soviets increased repression and gradually broke the resistance's capabilities.
        /// </summary>
        [YearRange(1946, 1946)]
        [Locations("Russia (Soviet Union)")]
        [ConflictRegions(ConflictRegionFlags.Europe)]
        SovietUnionVersusLithuanianPartisans = 211,

        /// <summary>
        /// Franco-Thai War or the French-Indochinese-Thai War. This conflict, which primarily occurred during 1940-1941, was rooted in Thai desires 
        /// to regain territories lost to France in the late 19th and early 20th centuries, which were then part of French Indochina.
        /// 
        /// The war consisted of several battles and skirmishes, with significant naval engagements and border clashes. The conflict was resolved through 
        /// mediation by Japan, leading to the Treaty of Tokyo in May 1941, in which France was forced to cede several territories in Laos and Cambodia 
        /// to Thailand.
        /// 
        /// However, after World War II, with France's attempt to reestablish control over its former colonial possessions and with the changing 
        /// international circumstances, the territories ceded to Thailand were returned to French control by the Treaty of Washington in 1946. 
        /// This effectively ended the territorial disputes initiated by the Franco-Thai War.
        /// </summary>
        [YearRange(1946, 1946)]
        [Locations("France", "Thailand")]
        [ConflictRegions(ConflictRegionFlags.Asia | ConflictRegionFlags.Europe)]
        FrancoIndochineseThaWar = 214,

        /// <summary>
        /// series of naval incidents in 1946
        /// 
        /// The Corfu Channel Incident involved the British Royal Navy and the People's Socialist Republic of Albania. On October 22, 1946, British 
        /// warships passing through the Corfu Channel along the Albanian coast struck mines. This event resulted in the sinking of two ships and the 
        /// loss of several sailors' lives.
        /// 
        /// The situation escalated as Albania and the United Kingdom exchanged diplomatic protests over the right of passage and the laying of mines in 
        /// international waters. The United Kingdom took the case to the International Court of Justice, which in 1949 ruled in favor of the United 
        /// Kingdom, ordering Albania to pay compensation for the damage and loss of life caused by the mines, which were laid in its territorial waters 
        /// without warning. This incident marked a significant point of tension between the two countries in the immediate post-war period.
        /// </summary>
        [YearRange(1946, 1946)]
        [Locations("Albania", "United Kingdom")]
        [ConflictRegions(ConflictRegionFlags.Europe)]
        CorfuChannelIncident = 215,

        /// <summary>
        /// The conflict began shortly after Myanmar gained independence from British colonial rule in January 1948. The newly formed nation-state 
        /// included a diverse mosaic of ethnic groups, with many ethnic minorities feeling marginalized and underrepresented in the central government 
        /// dominated by the Bamar (Burmese) majority. This led to armed insurgencies by various ethnic groups seeking greater autonomy or independence.
        /// 
        /// Several key ethnic armed organizations have been involved in the conflict, including the Karen National Union (KNU), the Kachin Independence 
        /// Organization (KIO), the Shan State Army (SSA), and the United Wa State Army (UWSA), among others. These groups control significant territories 
        /// within their respective regions and have been engaged in prolonged armed struggles against the central government.
        /// 
        /// The Myanmar military (Tatmadaw) has played a central role in the nation's politics and conflict dynamics. Military rulers have governed 
        /// Myanmar for most of the period since independence, implementing policies that often suppressed ethnic minority rights and political dissent. 
        /// The military's harsh tactics in dealing with ethnic insurgencies and civil opposition have led to widespread allegations of human rights 
        /// abuses, including forced labor, rape, and extrajudicial killings.
        /// 
        /// Various attempts at peace have been made, including numerous ceasefires and peace talks. The most significant recent effort was the Nationwide 
        /// Ceasefire Agreement (NCA) initiated in 2015, under the government of then-President Thein Sein. However, the agreement was only signed by
        /// some of the ethnic armed groups, with major organizations like the KIO and the UWSA abstaining, limiting its effectiveness.
        /// 
        /// The conflict took a dramatic turn with the military coup on February 1, 2021, when the military ousted the elected government led by 
        /// Aung San Suu Kyi's National League for Democracy (NLD), which had won a landslide victory in the November 2020 elections. The coup 
        /// led to massive civil unrest, widespread protests, and the formation of the Civil Disobedience Movement (CDM). In response to brutal 
        /// military suppression of protests, various groups formed the People’s Defense Forces (PDF), and some teamed up with established ethnic 
        /// armed groups, escalating the conflict to new levels of violence across the country.
        /// 
        /// The conflict has had a devastating humanitarian impact, resulting in thousands of deaths and displacements over the decades. Large numbers 
        /// of people have been internally displaced or have fled as refugees to neighboring countries. Civilian populations in conflict areas continue 
        /// to suffer from lack of access to basic services, food insecurity, and human rights violations.
        /// 
        /// International responses have included condemnation of human rights abuses, economic sanctions against the Myanmar military, and 
        /// humanitarian aid to displaced populations. However, geopolitical complexities, including the interests of major powers like China and 
        /// Russia, who have historically backed the Myanmar government, complicate international efforts to resolve the conflict.
        /// </summary>
        [YearRange(1948, 2023)]
        [Locations("Myanmar (Burma)")]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        OngoingConflictInMyanmarBurma = 222,

        /// <summary>
        /// An intra-party coup within the Ba'ath Party took place on February 23, 1966. This coup resulted in a radical shift of power within the 
        /// Syrian government, leading to the dominance of a more militant and radical faction of the Ba'ath Party.
        /// 
        /// The conflict in Syria between 1979 and 1982 involving the Muslim Brotherhood was one of the most significant and violent periods in modern 
        /// Syrian history. This confrontation was characterized by an armed insurgency led by the Muslim Brotherhood against the Ba'athist government of 
        /// Hafez al-Assad. It culminated in the notorious Hama massacre in February 1982.
        /// 
        /// A multi-sided civil war in Syria lasted from 2011 to 2024. There were many rebel factions including the Syrian Free Army, rebels allied with
        /// Turkey and a partial Turkish occupation, Syrian Democratic Forces. The conflict also involved Islamic state. The Syrian government fell in 
        /// December 2024, leading to a transitional government, although conflict continued between the SDF and Turkish-backed forces.
        /// </summary>
        [YearRange(1966, 2023)]
        [Locations("Syria")]
        [ConflictRegions(ConflictRegionFlags.MiddleEast)]
        OngoingConflictInSyrica = 299,

        /// <summary>
        /// The conflict initially began as resistance against the dictatorial regime of Siad Barre, who seized power in a military coup in 1969. By the 
        /// early 1980s, dissatisfaction with Barre’s oppressive rule had grown, leading to the formation of various armed opposition groups. One of the 
        /// earliest and most significant was the Somali Salvation Democratic Front (SSDF), followed by the Somali National Movement (SNM), United
        /// Somali Congress (USC), and others, each largely based on clan affiliations.
        /// 
        /// The situation escalated into a full-blown civil war by 1991 when Barre was ousted by rebel forces. His departure left a power vacuum with no
        /// central authority, leading to a period of intense and violent turmoil as various clan-based groups vied for control. The capital, Mogadishu, 
        /// and other areas split into zones controlled by rival warlords, leading to widespread anarchy and a humanitarian disaster, notably the famine 
        /// in 1992-1993.
        /// 
        /// The international community intervened in the early 1990s, most notably through the United Nations Operation in Somalia (UNOSOM) and the 
        /// US-led Unified Task Force (UNITAF), aiming to restore order and deliver humanitarian aid. However, these efforts faced significant challenges, 
        /// including armed opposition from Somali factions. The infamous Black Hawk Down incident in 1993, where 18 US soldiers were killed, led to a 
        /// shift in US and UN policies, eventually culminating in the withdrawal of international forces by 1995.
        /// 
        /// In the absence of effective government, the Islamic Courts Union (ICU) emerged in the early 2000s as a significant force attempting to impose
        /// order in Mogadishu and other areas through Sharia law. The ICU was largely successful in reducing piracy and improving security but was seen 
        /// as a threat by Ethiopia and the United States, leading to an Ethiopian invasion in 2006 with US support. The ICU was dismantled, but its 
        /// militant wing, Al-Shabaab, survived and transformed into a radical Islamist insurgency that has continued to wage a guerrilla war against 
        /// the Somali government and foreign troops.
        /// 
        /// Since 2012, efforts to establish a more stable federal government have made some progress, with the formation of the Federal Government of 
        /// Somalia. However, the government's authority is limited, with Al-Shabaab controlling significant portions of rural southern and central 
        /// Somalia and continuing to carry out terrorist attacks in urban centers, including Mogadishu.
        /// </summary>
        [YearRange(1982, 2023)]
        [Locations("Somalia")]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInSomalia = 337,

        /// <summary>
        /// A coup d'état occurred on October 15, 1987. This coup led to the overthrow of Thomas Sankara, the revolutionary leader of Burkina Faso, 
        /// who was often referred to as "Africa's Che Guevara" due to his progressive and pan-African policies.
        /// 
        /// This is separate from the JNIM conflict that has taken place since 2018:
        /// JNIM was formed in 2017 through the merger of several militant groups including Ansar Dine, the Macina Liberation Front, Al-Mourabitoun, 
        /// and the Saharan branch of AQIM. It aims to establish Islamic law across the Sahel region and has conducted numerous attacks against military 
        /// and civilian targets in Mali, Burkina Faso, and Niger.
        /// 
        /// Since 2018, Burkina Faso has experienced a significant deterioration in security due to the activities of JNIM and other militant groups 
        /// like the Islamic State in the Greater Sahara (ISGS). These groups exploit local grievances, inter-communal conflicts, and the absence of 
        /// strong governmental authority in rural areas to recruit fighters and expand their influence.
        /// 
        /// JNIM's operations in Burkina Faso have involved a combination of guerrilla warfare, terrorist attacks, and battles against government forces. 
        /// The group has targeted Burkinabe military outposts, police stations, and civilians, contributing to a rapidly worsening humanitarian situation 
        /// characterized by mass displacement and severe civilian casualties.
        /// 
        /// The Burkinabe government has responded with military operations aimed at curbing the insurgency and restoring state control. However, 
        /// challenges such as limited military capabilities, internal political instability, and the vast, porous borders that facilitate the movement 
        /// of militants and weapons have complicated these efforts.
        /// </summary>
        [YearRange(1987, 2023)]
        [Locations("Burkina Faso")]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInBurkinaFaso = 360,

        /// <summary>
        /// ISWAP (Islamic State in West Africa Province) originated as a faction within Boko Haram, the jihadist group that began 
        /// its violent campaign in 2009 with the aim of establishing Islamic law and opposing Western education. In 2015, this 
        /// faction split from Boko Haram, largely due to disagreements over tactical operations, particularly the use of 
        /// indiscriminate violence against Muslim civilians. The splinter group pledged allegiance to the Islamic State (ISIS) 
        /// and was formally recognized as the Islamic State’s West Africa Province.
        /// 
        /// The Nigerian government, under President Muhammadu Buhari and his successors, has struggled to effectively counter 
        /// ISWAP. The military efforts have been hampered by challenges such as inadequate funding, corruption, poor morale, and 
        /// human rights abuses by security forces, which have sometimes undermined local support for counterinsurgency efforts.
        /// 
        /// Regionally, the Multinational Joint Task Force (MNJTF), which includes forces from Nigeria, Niger, Chad, and Cameroon, 
        /// has been deployed to combat ISWAP and other insurgent groups in the Lake Chad region. This task force has had varying 
        /// degrees of success, with some significant victories but also considerable challenges in sustaining long-term security 
        /// and stability.
        /// 
        /// The conflict has had a devastating humanitarian impact on the region, with thousands of deaths and millions displaced. 
        /// The violence has exacerbated food insecurity and health crises, including malnutrition and outbreaks of disease. 
        /// Humanitarian access is often hampered by insecurity and attacks on aid workers.
        /// </summary>
        [YearRange(2015, 2023)]
        [Locations("Nigeria")]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        NigerianGovernmentvsIslamicState = 13641,

        /// <summary>
        /// The CSP-PSD was a coalition of separatist movements (CMA and Platform) related to Azawad. Platform left the group in September 2023 due
        /// to CMA's war with the Malian government. In April 2024, the CSP-PSD was renamed to CSP-DPA.
        /// </summary>
        [YearRange(2023, 2023)]
        [Locations("Mali")]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        MalivsCSPPSDOverAzawad = 16038,

        /// <summary>
        /// The conflict between the Ethiopian government and the Fano involves a complex and evolving situation primarily within the context of the 
        /// broader political and ethnic tensions in Ethiopia. The Fano are an informal Amhara militia group, and their interactions with the Ethiopian 
        /// government have been marked by both cooperation and confrontation, especially in the context of the recent conflicts in the Tigray region.
        /// 
        /// Historically, Fano militias have been community defense forces within the Amhara region, mobilized to protect local interests and counter 
        /// external threats. However, during the Tigray conflict that began in late 2020, the role of the Fano became more pronounced. They have been 
        /// reported to fight alongside federal forces against the Tigray People's Liberation Front (TPLF), but their relationship with the central 
        /// government is complicated by broader ethnic and regional dynamics.
        /// </summary>
        [YearRange(2023, 2023)]
        [Locations("Ethiopia")]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        EthiopianGovernmentvsFano = 16069,
    }
}
