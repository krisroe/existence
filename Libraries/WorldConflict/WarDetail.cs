
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
        public ConflictLocations[] Locations { get; set; }
        public LocationsAttribute(params ConflictLocations[] Locations)
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

    public enum ConflictLocations
    {
        Afghanistan,
        Albania,
        Azerbaijan,
        BurkinaFaso,
        Ethiopia,
        France,
        India,
        Iran,
        Israel,
        Mali,

        /// <summary>
        /// The conflict began shortly after Myanmar gained independence from British colonial rule in January 1948. The newly formed nation-state 
        /// included a diverse mosaic of ethnic groups, with many ethnic minorities feeling marginalized and underrepresented in the central government 
        /// dominated by the Bamar (Burmese) majority. This led to armed insurgencies by various ethnic groups seeking greater autonomy or independence.
        /// 
        /// Several key ethnic armed organizations have been involved in the conflict, controlling significant territories 
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
        MyanmarBurma,

        Nigeria,
        Philippines,
        RussiaSovietUnion,
        Somalia,
        Sudan,
        Syria,
        Thailand,
        Ukraine,
        UnitedKingdom,
        YemenNorthYemen,
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
        [Locations(ConflictLocations.Iran)]
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
        [Locations(ConflictLocations.Israel)]
        [ConflictRegions(ConflictRegionFlags.MiddleEast)]
        UnitedKingdomIrgunZvaiLeuJewishInsurgencyInMandatoryPalestine = 207,

        /// <summary>
        /// Hukbalahap Rebellion (1946-1954): The Huks, short for Hukbong Bayan Laban sa Hapon (People's Army Against the Japanese), initially formed 
        /// during World War II to fight the Japanese occupation. After the war, the movement transitioned into a struggle against the landed elite 
        /// and the central government. Land reform was a central issue, as the Huks sought to address the grievances of poor, landless peasants in 
        /// Central Luzon. The conflict with the government intensified under the presidency of Elpidio Quirino. The government's response combined 
        /// military action with some attempts at land reform. The rebellion waned in the mid-1950s due to a combination of military pressure and reforms 
        /// that addressed some of the peasants' concerns.
        /// New People’s Army and Communist Party of the Philippines (1969-present): Founded by Jose Maria Sison in 1968, the CPP established its armed 
        /// wing, the New People's Army (NPA), in 1969. This group aimed to overthrow the government through protracted guerrilla warfare. Inspired by 
        /// Maoist principles, the NPA sought to mobilize support among the rural poor, addressing issues such as land reform, human rights abuses, and 
        /// corruption. The conflict escalated during the martial law period under Ferdinand Marcos, who used the insurgency as a pretext to crack down 
        /// on all forms of dissent.
        /// </summary>
        [YearRange(1946, 2023)]
        [Locations(ConflictLocations.Philippines)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        PhilippinesLeftWingInsurgency = 209,

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
        [Locations(ConflictLocations.RussiaSovietUnion)]
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
        [Locations(ConflictLocations.France, ConflictLocations.Thailand)]
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
        [Locations(ConflictLocations.Albania, ConflictLocations.UnitedKingdom)]
        [ConflictRegions(ConflictRegionFlags.Europe)]
        CorfuChannelIncident = 215,

        /// <summary>
        /// Groups operating in Myanmar conflict, Karent state
        /// KNU (Karen National Union)
        /// KNUP (Karen National Union Peace Council)
        /// God's Army
        /// DKBA 5 (Democratic Karen Buddhist Army 5)
        /// </summary>
        [YearRange(1949, 2023)]
        [Locations(ConflictLocations.MyanmarBurma)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        OngoingConflictInMyanmarBurmaKarenState = 221,

        /// <summary>
        /// Groups operating in Myanmar conflict
        /// CPB (Communist Party of Burma): 1948-1988
        /// ABSDF (All Burma Students' Democratic Front): 1990-1994
        /// PSLF (Palaung State Liberation Front): 2013-2019,2022-2023)
        /// NUG (National Unity Government): 2021-2023
        /// CNF (Chin National Front): 2023
        /// </summary>
        [YearRange(1948, 2023)]
        [Locations(ConflictLocations.MyanmarBurma)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        OngoingConflictInMyanmarBurma = 222,

        /// <summary>
        /// The sides listed operate in Rakhine State (APLP, Mujahid Party, ANLP, RPF, ALP, RSO, ARSA, ULA)
        /// APLP (Arakan People's Liberation Party) (1948-1957): Specifically focuses on Rakhine State and the rights of the Rakhine people.
        /// Mujahid Party (1948-1961): Operated in Rakhine State, advocating for the Rohingya Muslim minority's rights, particularly in the earlier decades 
        /// following Myanmar's independence.
        /// ANLP (Arakan National Liberation Party)(1964-1972): Also centered in Rakhine State, focusing on autonomy and rights for the local population.
        /// RPF (Rakhine Patriotic Front)(1973-1978): Engages in activities within Rakhine State, focusing on issues pertinent to the Rakhine ethnic group.
        /// ALP (Arakan Liberation Party)(1977): Its activities are also concentrated in Rakhine State, working for the rights and autonomy of the Rakhine people.
        /// RSO (Rohingya Solidarity Organization)(1991,1994): Primarily active in Rakhine State, particularly among the Rohingya communities.
        /// ARSA (Arakan Rohingya Salvation Army)(2016-2017): Specifically operates in Rakhine State and is known for its focus on Rohingya rights and responses 
        /// to military actions.
        /// ULA (United League of Arakan)(2018-2023): Closely associated with the Arakan Army, which is a major insurgent group in Rakhine State seeking greater 
        /// autonomy for the Rakhine people.
        /// CPA (Chin Progressive Alliance)(1964-1973) operates in Chin State, which borders India and Rakhine State
        /// </summary>
        [YearRange(1948, 2023)]
        [Locations(ConflictLocations.MyanmarBurma)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        OngoingConflictInMyanmarBurmaRakhineState = 223,

        /// <summary>
        /// MFL-MUF (Myanmar Federal League – Myanmar United Front)
        /// MPF (Mon People’s Front)
        /// NMSP (New Mon State Party)
        /// BMA (Burmese Muslim Army)
        /// </summary>
        [YearRange(1949, 1996)]
        [Locations(ConflictLocations.MyanmarBurma)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        OngoingConflictInMyanmarBurmaMonState = 224,

        /// <summary>
        /// Naxalbari Uprising (1967): A major turning point was the peasant revolt in Naxalbari, West Bengal, where local farmers and landless laborers 
        /// took up arms against what they perceived as feudal exploitation. This uprising was inspired by Maoist ideology—emphasizing a protracted 
        /// people's war—and marked the departure of a radical faction from the mainstream communist movement.
        /// 
        /// In 2004, two major groups—the People’s War Group and the Maoist Communist Centre—merged to form the Communist Party of India (Maoist).
        /// This unification significantly intensified the insurgency by creating a more cohesive organization capable of operating over a wider 
        /// geographical area.
        /// </summary>
        [YearRange(1948, 2023)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaCommunistConflict = 227,

        /// <summary>
        /// 1948: Yemeni Imamate Revolution (1948 Civil War). involved a coup attempt against Imam Yahya, the ruler of the Kingdom of Mutawakkilite Yemen, 
        /// by radical forces within the Yemeni military and government. Coup was initially successful but Ahmad bin Yahya mounted a counter-coup weeks later.
        /// 1962-1970: North Yemen Civil War. began shortly after a coup d'état that overthrew the reigning Imam, Muhammad al-Badr, marking a decisive 
        /// shift from a theocratic imamate to a republic, led to the recognition of the Yemen Arab Republic by Saudi Arabia
        /// Border Conflict between North Yemen and South Yemen (1979)
        /// Internal Struggles and Plots (1980-1982). North Yemen experienced various internal power struggles and plots against its leadership, 
        /// particularly against President Ali Abdullah Saleh, who had come to power in 1978.
        /// 2009+: Houthi conflict. Houthis fought against President Ali Abdullah Saleh's regime. Saudi Arabia intervened in 2009. President Salah
        /// resigned in 2012 after the Arab Spring uprisings of 2011. In 2014, Houthis took the capital Sana'a. 2015 saw full-blown civil war.
        /// </summary>
        [YearRange(1948, 2023)]
        [Locations(ConflictLocations.YemenNorthYemen)]
        [ConflictRegions(ConflictRegionFlags.MiddleEast)]
        OngoingConflictInYemen = 230,

        /// <summary>
        /// PNDF (People’s National Defense Force)
        /// KIO (Kachin Independence Organization)
        /// </summary>
        [YearRange(1948, 2023)]
        [Locations(ConflictLocations.MyanmarBurma)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        OngoingConflictInMyanmarKachinState = 231,

        /// <summary>
        /// The 1948 Arab-Israeli War (November 1947 - July 1949). resulted in significant territorial changes and established the armistice lines known as the 
        /// Green Line
        /// The Suez Crisis (1956). led to a UN peacekeeping presence in the region
        /// The Six-Day War (1967). Israel attacked preemptively, captured the Sinai Peninsula, the Gaza Strip, the West Bank, East Jerusalem, and the 
        /// Golan Heights during this conflict.
        /// The War of Attrition (1967-1970)
        /// The Yom Kippur War (1973)
        /// The 1982 Lebanon War. led to the occupation of southern Lebanon, which lasted until 2000, and the infamous siege of Beirut.
        /// The First Intifada (1987-1993)
        /// Oslo Accords: September 13, 1993 and September 28, 1995
        /// The Hebron Protocol (1997) and the Wye River Memorandum (1998), addressed issues such as Israeli troop withdrawals and security cooperation
        /// The Second Intifada (2000-2005)
        /// Operation Cast Lead (2008-2009)
        /// Operation Pillar of Defense (2012) and Operation Protective Edge (2014)
        /// </summary>
        [YearRange(1949, 2023)]
        [Locations(ConflictLocations.Israel)]
        [ConflictRegions(ConflictRegionFlags.MiddleEast)]
        OngoingConflictInIsraelAndPalestine = 234,

        /// <summary>
        /// Naga National Council (NNC): Formed in the mid-20th century, the NNC was the principal body representing Naga aspirations soon after India’s independence.
        /// 
        /// In 1980, disillusionment with the moderate tactics of the NNC led to the birth of a more radical faction. Leaders such as Isak Chishi Swu and 
        /// Thuingaleng Muivah broke away to form what eventually evolved into the NSCN, with the NSCN-IM (Isak-Muivah faction) emerging as the dominant wing. 
        /// This group promoted a more expansive vision of Naga self-determination, arguing for a “Greater Nagaland” that would include Naga-inhabited areas 
        /// across several states.
        /// </summary>
        [YearRange(1956, 2000)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaNagaConflict = 251,

        /// <summary>
        /// KNPP (Karenni National Progressive Party)
        /// </summary>
        [YearRange(1957, 2023)]
        [Locations(ConflictLocations.MyanmarBurma)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        OngoingConflictInMyanmarKarenniState = 253,

        /// <summary>
        /// NSH (Naga Solidarity Union)
        /// SSIA (Shan State Progressive Army)
        /// SNUF (Shan Nationalities Unity Front)
        /// SSA (Shan State Army)
        /// SSNLO (Shan State National Liberation Organization)
        /// SURA (Southern Shan State Armed Resistance)
        /// SSRA (Shan State Restoration Army)
        /// TRC (Ta'ang National Liberation Army)
        /// MTA (Myanmar Tiger Army)
        /// RCSS (Restoration Council of Shan State)
        /// SSPP (Shan State Progressive Party)
        /// </summary>
        [YearRange(1959, 2015)]
        [Locations(ConflictLocations.MyanmarBurma)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        OngoingConflictInMyanmarShanState = 264,

        /// <summary>
        /// 1960: attempted coup d'état against Emperor Haile Selassie
        /// 1976-1991: Ethiopian Civil War
        /// 2020-2022: Tigray War, between the Ethiopian federal government and the Tigray People's Liberation Front (TPLF)
        /// </summary>
        [YearRange(1960, 2022)]
        [Locations(ConflictLocations.Ethiopia)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInEthopia = 267,

        /// <summary>
        /// an early phase of the Mizo National Front (MNF) insurgency against the Government of India, spanning from 1966 to 1968. This episode marked the beginning 
        /// of armed resistance in the Mizo Hills, driven by long-standing grievances among the Mizo people.
        /// </summary>
        [YearRange(1966, 1968)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaMNF = 296,

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
        [Locations(ConflictLocations.Syria)]
        [ConflictRegions(ConflictRegionFlags.MiddleEast)]
        OngoingConflictInSyria = 299,

        /// <summary>
        /// 1971: failed coup attempt against President Jaafar Nimeiry
        /// 1976: attempted coup against President Jaafar Nimeiry, orchestrated by opponents of Nimeiry who were exiled in Libya and supported by the Libyan 
        /// government under Muammar Gaddafi
        /// 1983-2005: Second Sudanese Civil War
        /// 2003+: Darfur conflict
        /// 2005+: South Kordofan and Blue Nile Conflicts involving SPLM-North (these regions have ties to South Sudan)
        /// April 2019: popular uprising led to the overthrow of longtime President Omar al-Bashir
        /// October 2020: Juba Peace Agreement, but implementation is challenging and some groups didn't sign the agreement
        /// </summary>
        [YearRange(1971, 2023)]
        [Locations(ConflictLocations.Sudan)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInSudan = 309,

        /// <summary>
        /// Saur Revolution (1978). People's Democratic Party of Afghanistan (PDPA) overthrew the government of President Mohammed Daoud Khan in a coup.
        /// Soviet-Afghan War (1979-1989). The Soviet Union invaded Afghanistan to support the faltering communist regime, sparking a brutal decade-long 
        /// conflict. The Soviets withdrew in 1989, leaving a devastated and fragmented country.
        /// Afghan Civil War (1989-1996)
        /// Taliban Ascendancy and Islamic Emirate of Afghanistan (1996-2001)
        /// US Invasion and NATO-led Intervention (2001-2014)
        /// Resurgence of the Taliban and Continued Conflict (2014-2021)
        /// US-Taliban Agreement and Withdrawal of US Troops (2020-2021)
        /// </summary>
        [YearRange(1978, 2023)]
        [Locations(ConflictLocations.Afghanistan)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        OngoingConflictInAfghanistan = 333,

        /// <summary>
        /// TNV (Tripura National Volunteers): Emerging in the late 1970s, TNV was one of the early militant outfits that took up arms to highlight the 
        /// grievances of the indigenous Tripuri people. The group’s activities were marked by guerrilla warfare tactics aimed at challenging state 
        /// authority and drawing attention to perceived cultural and economic subjugation.
        /// ATTF (All Tripura Tiger Force): Operating alongside other insurgent groups, ATTF also sought to secure greater autonomy or outright independence 
        /// for Tripura. It employed similar tactics—including ambushes and targeted attacks—designed to destabilize government control and assert the demands 
        /// of the indigenous population.
        /// NLFT (National Liberation Front of Tripura): NLFT further broadened the insurgency’s scope by calling for a complete break from Indian rule. 
        /// The group’s ideology was rooted in the belief that only an independent Tripura could safeguard the cultural, political, and economic interests 
        /// of the Tripuri people.
        /// </summary>
        [YearRange(1979, 2004)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaTripuraInsurgencyTNV_ATTF_NLFT = 335,

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
        [Locations(ConflictLocations.Somalia)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInSomalia = 337,

        /// <summary>
        /// In Tripura, the indigenous Tripuri population increasingly felt marginalized by the influx of non-tribal settlers, especially Bengalis, which altered
        /// the demographic and cultural balance of the state. Many indigenous Tripuris perceived these changes as a threat to their identity, traditions, and 
        /// political power.
        /// 
        /// United National Liberation Front (UNLF): Formed as a response to the socio-political challenges, the UNLF positioned itself as the main insurgent outfit 
        /// advocating for an independent Tripura or, at a minimum, significant autonomy. It sought to address long-standing grievances through armed struggle, 
        /// rejecting what it saw as an unresponsive political process.
        /// 
        /// People’s Liberation Army (PLA): Often understood as the armed wing or an affiliated faction within the broader Tripura insurgency framework, the PLA 
        /// worked in tandem with groups like the UNLF. Its activities included guerrilla warfare tactics aimed at challenging state authority, disrupting 
        /// administrative functions, and undermining the security apparatus.
        /// </summary>
        [YearRange(1982, 2009)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaTripuraInsurgencyUNLF_PLA = 347,

        /// <summary>
        /// In the early 1980s, militant groups began forming in response to growing discontent. Their activities initially included targeted attacks and 
        /// demonstrations meant to assert Sikh demands.
        /// Operation Blue Star (June 1984): The turning point came when the Indian government launched Operation Blue Star to flush out militants holed up in the 
        /// Golden Temple, Sikhism’s holiest shrine. The operation resulted in significant casualties and extensive damage, deepening Sikh resentment and 
        /// radicalizing more individuals.
        /// Assassination and Backlash: The aftermath of Operation Blue Star set off a chain reaction. In October 1984, the assassination of Prime Minister 
        /// Indira Gandhi by her Sikh bodyguards led to widespread anti-Sikh riots, further polarizing the community and fueling the insurgency.
        /// </summary>
        [YearRange(1983, 1993)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaSikhInsurgents = 351,

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
        [Locations(ConflictLocations.BurkinaFaso)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInBurkinaFaso = 360,

        /// <summary>
        /// The roots of the Kashmir issue date back to the partition of India in 1947, when the princely state of Jammu and Kashmir became a disputed territory 
        /// between India and Pakistan. While previous decades saw sporadic unrest and political agitation, the insurgency dramatically escalated in the late 1980s 
        /// and early 1990s.
        /// 
        /// While the intensity of violence has seen fluctuations over the years—with periods of relative calm followed by spikes in militancy—the underlying issues 
        /// remain unresolved. The revocation of Jammu and Kashmir’s special status in 2019 is one example of how political maneuvers continue to reshape the conflict’s 
        /// dynamics, though its full impact is still unfolding.
        /// </summary>
        [YearRange(1990, 2023)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaKashmirInsurgentsConflict = 364,

        /// <summary>
        /// Founded in 1979, ULFA emerged as a response to what many in Assam saw as neglect by the central government. The group’s primary demand was for a sovereign 
        /// Assam or, at the very least, greater autonomy that could safeguard the region's cultural and economic interests. By the 1990s, the insurgency had gained 
        /// momentum. Many indigenous Assamese felt threatened by demographic changes, illegal migration, and policies that they believed undermined local culture and 
        /// economic opportunities. These grievances provided a fertile ground for ULFA’s armed struggle.
        /// </summary>
        [YearRange(1990, 2010)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaAssamConflict = 365,

        /// <summary>
        /// First Nagorno-Karabakh War (1991-1994)
        /// Intermittent Skirmishes (1994-2016)
        /// Second Nagorno-Karabakh War (2020). Ended in ceasefire November 10, 2020.
        /// The ceasefire agreement included the deployment of Russian peacekeepers and the ceding of certain territories controlled by Armenians to 
        /// Azerbaijan. Tensions and minor skirmishes continue, as the political status of Artsakh remains unresolved and a source of ongoing dispute.
        /// </summary>
        [YearRange(1991, 2023)]
        [Locations(ConflictLocations.Azerbaijan)]
        [ConflictRegions(ConflictRegionFlags.Europe)]
        OngoingConflictForArtsakh = 388,

        /// <summary>
        /// All Bodo Students' Union (ABSU): Initially emerging as a mass mobilization and political advocacy group, ABSU organized protests, strikes, and other 
        /// non-violent demonstrations to highlight Bodo grievances. Over time, ABSU became a key player in articulating the demands for greater autonomy and the 
        /// formation of a separate Bodoland, influencing both regional politics and public sentiment.
        /// National Democratic Front of Bodoland (NDFB): Formed in the late 1980s, the NDFB took a more radical route, engaging in an armed insurgency aimed at 
        /// carving out an independent Bodoland. The NDFB’s tactics included guerrilla warfare, ambushes, and targeted attacks on government forces and infrastructure. 
        /// Their insurgency was marked by intermittent bursts of violence throughout the 1990s and early 2000s.
        /// </summary>
        [YearRange(1989, 2014)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaAssamBodoConflict = 421,

        /// <summary>
        /// UWSA (United Wa State Army). The UWSA is the military wing 
        /// of the United Wa State Party (UWSP), a political 
        /// organization that represents the Wa ethnic group, which 
        /// resides primarily in northern Shan State along the 
        /// Myanmar-China border. The Wa people are one of the ethnic 
        /// minorities in Myanmar, with a population that spans both 
        /// Myanmar and China.
        /// </summary>
        [YearRange(1997, 1997)]
        [Locations(ConflictLocations.MyanmarBurma)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        ConflictInMyanmarUnitedWaStateArmy = 422,

        /// <summary>
        /// Hezbollah was founded in 1982 during the Lebanese Civil War 
        /// as a response to the Israeli invasion of Lebanon.
        /// 1993: Operation Accountability
        /// 1996: Operation Grapes of Wrath
        /// 2006 Lebanon War
        /// Israel opened a front with Hezbollah at the same time
        /// as the war with Hamas following the October 7 2023 attacks
        /// </summary>
        [YearRange(1990, 2023)]
        [Locations(ConflictLocations.Israel)]
        [ConflictRegions(ConflictRegionFlags.MiddleEast)]
        ConflictBetweenIsraelAndHezbollah = 426,

        /// <summary>
        /// captures a 2008 confrontation between the Government of India and the PULF, a localized insurgent group. Rooted in regional grievances, the 
        /// conflict was characterized by sporadic, guerrilla-style attacks and a swift counterinsurgency response by the state. Although the violence was 
        /// relatively contained, the episode underscores the ongoing challenges of addressing localized demands for autonomy and justice within India’s 
        /// complex socio-political landscape.
        /// </summary>
        [YearRange(2008, 2008)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaConflictPULF,

        /// <summary>
        /// MNDAA (Myanmar National Democratic Alliance Army)
        /// The group was initially established to represent the 
        /// political and ethnic interests of the Kokang people,
        /// who have long sought greater autonomy and
        /// self-determination within Myanmar.
        /// </summary>
        [YearRange(1991, 2007)]
        [Locations(ConflictLocations.MyanmarBurma)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        ConflictInMyanmarMyanmarNationalDemocraticAllianceArmy = 439,

        /// <summary>
        /// The LNUP emerged as a political organization 
        /// primarily advocating for the rights of the Lahu 
        /// people, aiming to secure autonomy and 
        /// self-determination for the Lahu ethnic group in the 
        /// broader context of ethnic federalism.
        /// </summary>
        [YearRange(1973, 1982)]
        [Locations(ConflictLocations.MyanmarBurma)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        ConflictInMyanmarLahuNationalUnitedParty = 440,

        /// <summary>
        /// relatively low‐intensity, localized insurgency that occurred between 2012 and 2014 in the Darjeeling region. This conflict pitted the Government of 
        /// India against the GNLA—the United National Liberation Front of Gorkhaland (commonly abbreviated as GNLA)—a militant outfit associated with the 
        /// longstanding demand for a separate state of Gorkhaland.
        /// </summary>
        [YearRange(2012, 2014)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaConflictInGorkhaland = 11342,

        /// <summary>
        /// 2009-2011: The presence and activities of AQIM in northern Mali were primarily focused on kidnappings and small-scale skirmishes with Malian 
        /// security forces.
        /// 2012 Rebellion and Coup: The conflict intensified dramatically in 2012 following a rebellion by the MNLA (a secular Tuareg nationalist group),
        /// which quickly spiraled into a full-scale insurgency as Islamist groups, including Ansar Dine and later AQIM and MUJAO, took control of 
        /// significant portions of northern Mali, including cities like Timbuktu, Gao, and Kidal.
        /// French Intervention in 2013: In response to the Islamist advance towards the capital, Bamako, France launched Operation Serval in January 2013, 
        /// which rapidly dislodged the jihadists from major urban centers.
        /// Post-2013 Insurgency: Despite the success of French and African troops in reclaiming territory, the jihadist groups morphed into a guerrilla 
        /// insurgency, conducting terrorist attacks, ambushes, and IED explosions against military and civilian targets.
        /// Formation of JNIM: The formation of JNIM in 2017 marked a significant shift, as it unified major jihadist factions in Mali, enhancing their 
        /// operational capabilities and strategic reach.
        /// Ongoing Violence and International Response: The conflict has persisted with varying intensity, involving Malian forces, French troops (later 
        /// reorganized under Operation Barkhane), UN peacekeepers (MINUSMA), and increasingly, other international partners including the G5 Sahel Joint 
        /// Force
        /// </summary>
        [YearRange(2009, 2023)]
        [Locations(ConflictLocations.Mali)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        IslamicInsurgencyInMali = 11347,

        /// <summary>
        /// NSCN-K is a faction of the National Socialist Council
        /// of Nagaland (NSCN), which was originally formed in 
        /// 1980 to advocate for the independence of the Naga 
        /// people and the creation of a Greater Nagaland 
        /// (called Nagalim), which would span parts of India's 
        /// Nagaland state and the Naga-inhabited areas of 
        /// Myanmar.
        /// </summary>
        [YearRange(1991, 2007)]
        [Locations(ConflictLocations.MyanmarBurma)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        ConflictInMyanmarNationalSocialistCouncilOfNagaland = 11475,

        /// <summary>
        /// Major Russian invasion of Ukraine in Februrary 2002, advances toward Kiev/Kharkiv/Kherson, Crimea land corridor, failed to topple
        /// Ukrainian government. By the end of 2022 Ukraine had recaptured most territory outside of Donetsk/Luhansk oblasts and the Crimea land
        /// corridor. August 2024, Ukraine invaded Russia in Kursk oblast.
        /// </summary>
        [YearRange(2022, 2023)]
        [Locations(ConflictLocations.RussiaSovietUnion, ConflictLocations.Ukraine)]
        [ConflictRegions(ConflictRegionFlags.Europe)]
        RussianInvasionOfUkraine = 13243,

        /// <summary>
        /// Islamic State Emergence and Expansion (2013-2014). In June 2014, after capturing large swaths of territory in Iraq and Syria, including the 
        /// major cities of Raqqa in Syria and Mosul in Iraq, ISIS declared the establishment of a caliphate.
        /// International Response and Initial Counteroffensives (2014-2016). US-Led Coalition and Kurdish Forces (SDF) fought against Islamic State.
        /// Turning Point and Major Setbacks (2016-2017). Islamic State lost Palmyra, Dabiq, Mosul, and Raqqa.
        /// Territorial Defeat and Insurgency Shift (2018-2019). Battle of Baghuz Fawqan meant the loss of significant territory.
        /// ISIS has continued to operate as an insurgent force.
        /// </summary>
        [YearRange(2013, 2023)]
        [Locations(ConflictLocations.Syria)]
        [ConflictRegions(ConflictRegionFlags.MiddleEast)]
        IslamicStateInSyria = 13604,

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
        [Locations(ConflictLocations.Nigeria)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        NigerianGovernmentvsIslamicState = 13641,

        /// <summary>
        /// The UNLFW emerged as an insurgent outfit representing ethnic and regional groups in parts of India’s northeastern or border areas. Claiming that the 
        /// Indian state had long marginalized their political and cultural interests, the group sought either greater autonomy or outright independence for 
        /// what they viewed as Western South East Asian territories.
        /// 
        /// Although the overall casualty numbers were relatively low compared to higher-intensity conflicts, local communities experienced disruption to daily life, 
        /// intermittent violence, and the uncertainty that accompanies any prolonged low-level insurgency. Economic activities, particularly in border and rural areas, 
        /// were adversely affected.
        /// </summary>
        [YearRange(2015, 2018)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaUNLFW = 13653,

        /// <summary>
        /// The CSP-PSD was a coalition of separatist movements (CMA and Platform) related to Azawad. Platform left the group in September 2023 due
        /// to CMA's war with the Malian government. In April 2024, the CSP-PSD was renamed to CSP-DPA.
        /// </summary>
        [YearRange(2023, 2023)]
        [Locations(ConflictLocations.Mali)]
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
        [Locations(ConflictLocations.Ethiopia)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        EthiopianGovernmentvsFano = 16069,
    }
}
