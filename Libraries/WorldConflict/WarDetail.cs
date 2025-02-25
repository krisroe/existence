
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
        Algeria,
        Angola,
        Australlia,
        Azerbaijan,
        BosniaHerzegovina,
        BurkinaFaso,
        Burundi,
        Chad,
        Colombia,
        Congo,
        Croatia,
        DRCongoZaire,
        Eritrea,
        Ethiopia,
        France,
        India,
        Iraq,
        Iran,
        Israel,
        Liberia,
        Libya,
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

        Nepal,
        Nigeria,
        Pakistan,
        Philippines,
        RussiaSovietUnion,
        Rwanda,
        SerbiaYugoslavia,
        SierraLeone,
        Somalia,
        SouthSudan,
        SriLanka,
        Sudan,
        Syria,
        Tajikistan,
        Thailand,
        Turkey,
        Uganda,
        Ukraine,
        UnitedKingdom,
        UnitedStatesOfAmerica,
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
        /// 1958 Iraqi Coup (July 14 Revolution)
        /// 1963 Ba'athist Coup and Political Instability (1963–1968)
        /// 1968: The Ba'ath Party, led by Ahmed Hassan al-Bakr and Saddam Hussein, seized power.
        /// Kurdish Insurgencies (1961–1991)
        /// Iran-Iraq War (1980–1988)
        /// Gulf War (1990–1991)
        /// U.S. Invasion and Iraq War (2003–2011)
        /// 2014: ISIS captured Mosul, Fallujah, and large parts of Iraq.
        /// 2014–2017: Iraqi forces, backed by U.S. airstrikes and Iran-backed militias, defeated ISIS.
        /// 2017: Mosul was liberated; ISIS lost its last Iraqi stronghold.
        /// </summary>
        [YearRange(1958, 2023)]
        [Locations(ConflictLocations.Iraq)]
        [ConflictRegions(ConflictRegionFlags.MiddleEast)]
        OngoingConflictInIraq = 259,

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
        /// 1960: King Mahendra dissolved the democratic government and established the Panchayat system, banning political parties.
        /// 1979–1980: Protests led to a referendum, but the monarchy retained control.
        /// 1990: A popular movement forced King Birendra to allow a constitutional monarchy with multi-party democracy.
        /// 1996: The Maoist Communist Party of Nepal (CPN-M), led by Prachanda, launched an armed insurgency demanding the abolition 
        /// of the monarchy and land reforms.
        /// 2001: The Nepalese royal massacre killed King Birendra and the royal family, bringing King Gyanendra to power.
        /// 2002–2005: King Gyanendra dismissed the government and ruled directly, intensifying conflict
        /// 2006: The People’s Movement (Jana Andolan II) forced King Gyanendra to restore democracy
        /// November 2006: The government and Maoists signed the Comprehensive Peace Agreement (CPA), ending the war.
        /// 2008: Nepal abolished the monarchy, becoming a federal democratic republic.
        /// 2015: A new Constitution of Nepal was adopted, but tensions with Madhesi ethnic groups led to protests.
        /// 2017: The Maoist and Communist parties merged, forming a dominant political force.
        /// 2020–2023: Political instability continued with frequent leadership changes and conflicts over governance.
        /// Ethnic tensions and border disputes with India persist.
        /// </summary>
        [YearRange(1960, 2006)]
        [Locations(ConflictLocations.Nepal)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        ConflictInNepal = 269,

        /// <summary>
        /// Congo Crisis (1960–1965). Background: Following independence from Belgium in 1960, the DRC faced immediate instability.
        /// Mobutu's Coup (1965) – General Mobutu Sese Seko seized power in a coup, establishing a dictatorship.
        /// Mobutu’s Dictatorship and Insurgencies (1965–1996)
        /// First Congo War (1996–1997). Rwanda and Uganda, along with other regional actors, supported a rebellion against Mobutu.
        /// 1997: Kabila’s forces overthrew Mobutu, ending 32 years of dictatorship.
        /// Second Congo War (1998–2003). Kabila turned against Rwanda and Uganda, leading to a regional war. Estimated 5.4 million deaths (deadliest 
        /// war since World War II).
        /// Kivu Conflict & Ongoing Insurgencies (2004–Present)
        /// </summary>
        [YearRange(1964, 2023)]
        [Locations(ConflictLocations.DRCongoZaire)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInZaire = 283,

        /// <summary>
        /// 1965: A failed Hutu-led coup against the Tutsi-dominated government led to mass killings of Hutu leaders.
        /// 1966: Tutsi military officer Michel Micombero staged a coup, establishing a Tutsi-led military dictatorship.
        /// April 1972: A Hutu uprising led to massacres of Tutsis.
        /// August 1988: Ethnic violence erupted between Hutu rebels and the Tutsi military.
        /// 1993: Melchior Ndadaye, the first democratically elected Hutu president, was assassinated by Tutsi soldiers.
        /// 1993–2005: A full-scale civil war erupted between Hutu rebel groups (e.g., FDD, FNL) and the Tutsi-led army.
        /// 2000: The Arusha Accords were signed but fighting continued.
        /// 2005: A peace agreement led to Hutu rebel leader Pierre Nkurunziza becoming president.
        /// 2015: Nkurunziza ran for a third term, violating the constitution.
        /// 2020: Nkurunziza died; Évariste Ndayishimiye became president.
        /// </summary>
        [YearRange(1965, 2023)]
        [Locations(ConflictLocations.Burundi)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInBurundi = 287,

        /// <summary>
        /// 1966: The FROLINAT (Front for the National Liberation of Chad), a rebel group from the Muslim north, began an insurgency 
        /// against the government of François Tombalbaye.
        /// 1975: Tombalbaye was assassinated in a coup led by General Félix Malloum.
        /// 1979: The war ended with rebels capturing N'Djamena, leading to a power struggle.
        /// 1979: Rebel factions fought for power, leading to a collapse of central authority
        /// 1982: Hissène Habré seized power with U.S. and French support
        /// 1983–1987: Libya, under Muammar Gaddafi, intervened, occupying northern Chad
        /// 1987: Chad defeated Libya in the "Toyota War", pushing Libyan forces out
        /// 1990: Idriss Déby overthrew Habré and became president
        /// 2005–2010: Rebel groups, including UFDD and FUC, launched attacks
        /// 2008: Rebels reached N'Djamena but were repelled with French military support.
        /// 2015–2020: Chad faced attacks from Boko Haram and ISIS-West Africa in the Lake Chad region.
        /// April 2021: Déby was killed in battle against FACT rebels; his son Mahamat Déby took power.
        /// 2022: Protests erupted against military rule.
        /// 2023–Present: Armed groups continue to challenge the government, but Chad remains under military control.
        /// </summary>
        [YearRange(1966, 2023)]
        [Locations(ConflictLocations.Chad)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInChad = 288,

        /// <summary>
        /// 1964: The Revolutionary Armed Forces of Colombia (FARC) and the National Liberation Army (ELN) were founded as Marxist guerrilla groups.
        /// 1970s: Drug cartels, including Medellín (Pablo Escobar) and Cali Cartels, became powerful.
        /// 1980s: Right-wing paramilitary groups (AUC) formed to fight guerrillas.
        /// 1984: The first peace talks failed.
        /// 1990s: FARC, ELN, and paramilitaries increased attacks, kidnappings, and drug trafficking.
        /// 2002: President Álvaro Uribe launched a major military offensive against FARC.
        /// 2003: The AUC demobilized, reducing paramilitary violence.
        /// 2008: FARC leader Raúl Reyes was killed; the group weakened.
        /// 2012–2016: Peace talks between the government and FARC.
        /// 2016: The FARC peace deal was signed, officially ending its insurgency.
        /// 2017: FARC disarmed, but dissident factions and ELN continued fighting.
        /// 2018–2023: Drug cartels, ELN, and new paramilitary groups controlled rural areas.
        /// 2022: President Gustavo Petro began peace talks with ELN and FARC dissidents.
        /// </summary>
        [YearRange(1964, 2023)]
        [Locations(ConflictLocations.Colombia)]
        [ConflictRegions(ConflictRegionFlags.Americas)]
        OngoingConflictInColombia = 289,

        /// <summary>
        /// an early phase of the Mizo National Front (MNF) insurgency against the Government of India, spanning from 1966 to 1968. This episode marked the beginning 
        /// of armed resistance in the Mizo Hills, driven by long-standing grievances among the Mizo people.
        /// </summary>
        [YearRange(1966, 1968)]
        [Locations(ConflictLocations.India)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IndiaMNF = 296,

        /// <summary>
        /// There were two coups in Nigeria in 1966, this entry refers to Boko Haram conflict from 2009-2023
        ///The conflict between the Government of Nigeria and Jama'atu Ahlis Sunna Lidda'awati wal-Jihad (JAS), commonly known as 
        ///Boko Haram, began in 2009 and has evolved into one of the deadliest insurgencies in Africa. Below is a structured
        ///timeline outlining key phases of the conflict.
        ///2002: Boko Haram was founded by Mohammed Yusuf in Maiduguri, Borno State, advocating for an Islamic state and 
        ///rejecting Western education.
        ///July 2009: A violent uprising led by Boko Haram resulted in a government crackdown; Yusuf was killed in police custody, 
        ///and the group went underground.
        ///2010–2011: Under new leader Abubakar Shekau, Boko Haram re-emerged, launching deadly attacks, including:
        ///2011: Suicide bombing of the UN headquarters in Abuja.
        ///2013: Nigerian President Goodluck Jonathan declared a state of emergency in Borno, Yobe, and Adamawa States.
        ///Chibok Schoolgirls Kidnapping – Over 276 girls were abducted, sparking global outrage (#BringBackOurGirls).
        ///2015: The Nigerian military, supported by Chad, Cameroon, and Niger, launched counter-offensives, regaining key towns.
        ///2016: A leadership dispute led to a split in Boko Haram
        ///JAS (Boko Haram) under Shekau – Continued targeting civilians and using suicide bombers.
        ///ISIS-West Africa Province (ISWAP) under Abu Musab al-Barnawi – Focused on attacking military and government targets.
        ///2017–2018
        ///Nigerian forces recaptured Boko Haram strongholds, but insurgents resorted to hit-and-run tactics.
        ///Abduction of 110 schoolgirls in Dapchi, with most later released except Leah Sharibu.
        ///ISWAP became more powerful, gaining support from ISIS.
        ///Intensified Violence and Shekau’s Death (2019–2021)
        ///2019: President Muhammadu Buhari claimed Boko Haram was "technically defeated," but attacks continued.
        ///2020: Boko Haram massacred over 110 farmers in Zabarmari, Borno.
        /// </summary>
        [YearRange(1966, 2023)]
        [Locations(ConflictLocations.Nigeria)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        NigeriaBokoHaram = 297,

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
        /// MIM – Mindanao Independence Movement (1970s). Founded in 1968,  Independence for Muslim Mindanao from the Philippine government
        /// MILF – Moro Islamic Liberation Front (1980s–2019). Objective: Establish an autonomous Islamic state in Mindanao.
        /// ASG – Abu Sayyaf Group (1991–Present). Objective: Establish an Islamic caliphate in Mindanao.
        /// </summary>
        [YearRange(1970, 2020)]
        [Locations(ConflictLocations.Philippines)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IslamistAndSeparatistMovementsInMindanao = 308,

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
        /// 1971: General Idi Amin overthrew President Milton Obote in a coup.
        /// 1972–1979: Amin’s regime committed mass killings, with an estimated 300,000 deaths.
        /// 1978–1979: Amin invaded Tanzania, but Tanzania and Ugandan exiles defeated him.
        /// April 1979: Amin was overthrown; he fled into exile.
        /// 1979–1980: Political instability after Amin’s fall; multiple factions vied for power.
        /// 1980: Milton Obote returned to power, but his rule was met with armed resistance.
        /// 1981–1986: Ugandan Bush War. Yoweri Museveni’s National Resistance Army (NRA) fought against Obote’s government.
        /// 1985: Obote was overthrown in a coup by General Tito Okello.
        /// 1986: Museveni’s NRA defeated Okello and seized power.
        /// 1987: Joseph Kony formed the Lord’s Resistance Army (LRA) in northern Uganda.
        /// 1990s–2000s: LRA committed mass killings, child soldier recruitment, and abductions.
        /// 2002–2006: Uganda launched military operations against the LRA
        /// 2006–2008: LRA peace talks failed, and Kony fled into Central Africa.
        /// 2000s: Armed cattle raiders in Karamoja caused local conflicts.
        /// 2010: Al-Shabaab bombed Kampala, killing over 70 people.
        /// 2020s: Uganda continues counterterrorism efforts against Islamist extremists.
        /// </summary>
        [YearRange(1971, 2017)]
        [Locations(ConflictLocations.Uganda)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInUganda = 314,

        /// <summary>
        /// Angolan War of Independence (1961–1975) against Portuguese colonial rule
        /// November 11, 1975: Angola gained independence, but the three factions turned on each other, starting a civil war.
        /// 1975–1976: The MPLA seized power in Luanda and declared itself the government. Cuba sent 36,000 troops to support the MPLA
        /// South Africa and the U.S. supported UNITA, fearing Soviet expansion.
        /// 1980s: Heavy fighting between MPLA and UNITA across the country. South Africa invaded Angola to target Namibian SWAPO rebels.
        /// The Soviet Union provided weapons, while the U.S. supplied UNITA via Zaire.
        /// 1988: The Battle of Cuito Cuanavale – The largest battle in Africa since World War II
        /// 1991: The Bicesse Accords led to a temporary ceasefire and elections.
        /// 1992 Elections: MPLA’s José Eduardo dos Santos won, but UNITA rejected the results, restarting the war.
        /// 1993–1994: Heavy fighting; UNITA lost key cities.
        /// 1994: Lusaka Protocol signed but failed to stop fighting.
        /// 1997–1999: UNITA resumed war after failed peace agreements.
        /// Jonas Savimbi (UNITA leader) was killed in battle on February 22, 2022
        /// UNITA surrendered; a peace agreement was signed in April.
        /// </summary>
        [YearRange(1975, 2002)]
        [Locations(ConflictLocations.Angola)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        CivilWarInAngola = 327,

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
        /// 1980: Master Sergeant Samuel Doe led a military coup against President William R. Tolbert Jr.
        /// December 24, 1989: Charles Taylor’s National Patriotic Front of Liberia (NPFL) launched a rebellion against President Samuel Doe.
        /// Taylor’s forces gained territory, but a splinter group, the Independent National Patriotic Front of Liberia (INPFL), led by Prince Johnson, 
        /// also fought against Doe.
        /// September 1990: Prince Johnson’s forces captured and executed Samuel Doe.
        /// A transitional government was formed, but fighting between factions continued.
        /// 1991–1996: The war became a multi-faction conflict, with various rebel groups fighting for power. The ECOWAS peacekeeping force (ECOMOG) 
        /// intervened but struggled to restore order.
        /// 1996: A final peace agreement was reached after years of failed ceasefires.
        /// 1997: Charles Taylor won elections, effectively ending the war.
        /// Taylor’s presidency was marked by dictatorship and war crimes, leading to a second civil war (1999-2003)
        /// In 2003, Taylor was forced to resign and go into exile in Nigeria.
        /// </summary>
        [YearRange(1980, 2003)]
        [Locations(ConflictLocations.Liberia)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        ConflictInLiberia = 341,

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
        /// Ethnic tensions between the Sinhalese majority and the Tamil minority escalated after independence in 1948.
        /// The LTTE (Tamil Tigers), led by Velupillai Prabhakaran, launched an armed struggle for an independent Tamil state (Tamil Eelam).
        /// 1984–1987: LTTE insurgency escalated in northern and eastern Sri Lanka.
        /// 1987–1990: Indian Peacekeeping Force (IPKF) intervened but withdrew after fighting the LTTE.
        /// 1991–2001: LTTE carried out suicide bombings and assassinations, including
        /// - 1991: Assassination of Indian PM Rajiv Gandhi.
        /// - 1993: Assassination of Sri Lankan President Ranasinghe Premadasa.
        /// 2001: Attack on Bandaranaike International Airport.
        /// 2002–2005: A ceasefire was signed, but peace talks collapsed.
        /// 2006: The Sri Lankan military launched a major counteroffensive.
        /// 2008: Government forces captured LTTE strongholds
        /// May 18, 2009: LTTE leader Prabhakaran was killed, ending the war.
        /// Allegations of war crimes against the government and LTTE
        /// Tamil political activism and demands for autonomy continued.
        /// 2019 Easter Bombings: Islamist extremists carried out suicide bombings, killing over 250 people.
        /// 2022 Sri Lankan Protests
        /// - Economic collapse led to mass protests against the Rajapaksa government.
        /// - President Gotabaya Rajapaksa fled the country; a new government was formed.
        /// 2023–Present: Political instability continues, but Sri Lanka remains at peace.
        /// </summary>
        [YearRange(1984, 2009)]
        [Locations(ConflictLocations.SriLanka)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        OngoingConflictInSriLanka = 352,

        /// <summary>
        /// 1978: Abdullah Öcalan founded the PKK (Partiya Karkerên Kurdistanê), advocating for Kurdish independence from Turkey.
        /// 1980: The Turkish military coup led to crackdowns on Kurdish activism.
        /// 1984: The PKK launched armed attacks against Turkish security forces, marking the official start of the insurgency.
        /// 1980s–1990s: The PKK conducted ambushes, bombings, and assassinations.
        /// 1992–1995: Turkey launched large-scale military operations, including cross-border strikes in northern Iraq, where the 
        /// PKK had bases.
        /// 1995–1998: Turkish forces invaded northern Iraq multiple times to destroy PKK strongholds.
        /// 1999: Abdullah Öcalan was captured in Kenya (with CIA help) and sentenced to death (later commuted to life imprisonment).
        /// The PKK declared a unilateral ceasefire.
        /// 2000–2004: A period of relative calm, with PKK reducing attacks
        /// 2004: The PKK resumed attacks, citing government failure to recognize Kurdish rights.
        /// 2009–2013: Peace Process: The Turkish government and Öcalan engaged in negotiations. 2013: A ceasefire was declared.
        /// 2015: Peace talks collapsed after deadly bombings and assassinations
        /// 2015–2016: Turkey launched massive counterinsurgency operations in southeastern Turkey.
        /// 2016–2018: Turkish offensives in northern Syria targeted the YPG, considered an affiliate of the PKK.
        /// 2019: Operation Peace Spring targeted Kurdish-controlled areas in Syria.
        /// 2020s: Turkey intensified cross-border strikes in Iraq and Syria.
        /// </summary>
        [YearRange(1984, 2023)]
        [Locations(ConflictLocations.Turkey)]
        [ConflictRegions(ConflictRegionFlags.MiddleEast)]
        TurkeyPKKConflict = 354,

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
        /// October 1, 1990: The Rwandan Patriotic Front (RPF), led by Paul Kagame, launched an invasion from Uganda to overthrow the 
        /// Hutu-led government.
        /// 1991–1993: The war continued with periodic ceasefires, but violence escalated.
        /// August 1993: The Arusha Accords were signed, aiming for a power-sharing government.
        /// April 6, 1994: The plane carrying President Juvénal Habyarimana (Hutu) was shot down, triggering mass killings.
        /// April–July 1994: Hutu extremists (Interahamwe militias and government forces) massacred 800,000–1,000,000 Tutsis and 
        /// moderate Hutus.
        /// July 1994: The RPF defeated the government forces and took control of Rwanda.
        /// Aftermath: Two million Hutus fled to Zaire (now DRC), fearing reprisals.
        /// 1996: The Rwandan government, under Paul Kagame, supported an invasion of Zaire to remove Hutu militias (ex-FAR, 
        /// Interahamwe).
        /// 1997: Zaire’s leader, Mobutu Sese Seko, was overthrown; Laurent-Désiré Kabila took power in what became the Democratic 
        /// Republic of the Congo (DRC).
        /// 1998: Rwanda supported a rebel movement (RCD) against Kabila, leading to a regional war involving nine African countries.
        /// 2003: Rwanda officially withdrew from the DRC, but conflicts continued.
        /// 2004–2009: Rwanda was accused of supporting the CNDP, a rebel group in eastern DRC.
        /// 2012–2013: Rwanda allegedly backed the M23 rebellion in DRC, leading to international condemnation.
        /// 2021–Present: M23 resurfaced, with Rwanda and DRC exchanging accusations of supporting rival militias.
        /// </summary>
        [YearRange(1990, 2023)]
        [Locations(ConflictLocations.Rwanda)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInRwanda = 374,

        /// <summary>
        /// 1991: The Revolutionary United Front (RUF), led by Foday Sankoh, launched a rebellion against the government of Joseph Momoh.
        /// 1991–1993: RUF, backed by Liberia, seized large areas in eastern and southern Sierra Leone.
        /// 1995–1996: South African mercenaries (Executive Outcomes) helped push back RUF.
        /// 1996 Peace Agreement (Abidjan Accord) failed.
        /// 1997: A military coup by Major Johnny Paul Koroma allied with RUF.
        /// 1998: West African peacekeepers (ECOMOG) intervened, restoring civilian rule under Ahmad Tejan Kabbah.
        /// 1999: RUF attacked Freetown ("Operation No Living Thing"). Lomé Peace Agreement was signed, granting RUF political power.
        /// 2000: British troops intervened (Operation Palliser), defeating RUF.
        /// 2001: United Nations disarmed rebels, war officially ended
        /// </summary>
        [YearRange(1991, 2001)]
        [Locations(ConflictLocations.SierraLeone)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        ConflictInSierraLeone = 382,

        /// <summary>
        /// 1988: Anti-government protests led to political reforms allowing multiparty elections.
        /// 1991: The Islamic Salvation Front (FIS) won the first round of elections, threatening to establish an Islamist state.
        /// 1992: The military canceled elections, banned the FIS, and took power.
        /// Islamist insurgents, including the Armed Islamic Group (GIA), launched a violent rebellion.
        /// 1994-1996: Massacres of civilians, particularly in rural areas. GIA and other jihadist groups attacked civilians, journalists, and foreigners.
        /// Government crackdowns intensified.
        /// 1997: Moderate Islamist factions negotiated a ceasefire.
        /// 1999: President Abdelaziz Bouteflika offered amnesty to militants.
        /// 2002: The civil war officially ended, but terrorism continued.
        /// 2003: GIA remnants rebranded as Al-Qaeda in the Islamic Maghreb (AQIM).
        /// 2007: AQIM carried out suicide bombings in Algiers.
        /// 2013: AQIM and allied militants seized the In Amenas gas plant, leading to an Algerian military assault.
        /// 2019: Mass protests ("Hirak Movement") forced President Bouteflika to resign after 20 years.
        /// </summary>
        [YearRange(1991, 2020)]
        [Locations(ConflictLocations.Algeria)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInAlgeria = 386,

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
        /// 1991: Yugoslavia began to break apart; Slovenia and Croatia declared independence.
        /// March 1992: Bosnia held a referendum for independence, which was boycotted by Bosnian Serbs.
        /// April 1992: Bosnia was recognized as an independent state, but Bosnian Serbs opposed secession.
        /// April 1992: The Bosnian Serb Army of Republika Srpska (VRS), led by Ratko Mladić, began an offensive.
        /// Siege of Sarajevo (April 1992–1996): Serbian forces besieged Bosnia’s capital, cutting off supplies and bombarding civilians.
        /// Ethnic Cleansing and Massacres: Serb forces expelled and killed Bosniak civilians in eastern Bosnia.
        /// 1993: Fighting escalated between Bosniak and Croat forces, despite their common enemy (Serbs)
        /// 1994: Washington Agreement: The U.S. brokered a Bosniak-Croat alliance, ending their infighting
        /// UN declared “safe zones” in cities like Srebrenica, Goražde, and Žepa, but these areas were poorly defended.
        /// July 1995: Srebrenica Massacre – Over 8,000 Bosniak men and boys were executed by Serb forces.
        /// August 1995: Operation Storm: Croatia recaptured Serb-held Krajina, weakening Serb forces.
        /// August–September 1995: NATO Airstrikes: NATO bombed Bosnian Serb positions, forcing them into negotiations.
        /// December 1995: The Dayton Peace Agreement was signed, ending the war.
        /// Bosnia was divided into two entities:Federation of Bosnia and Herzegovina (Bosniak-Croat controlled),Republika Srpska (Serb-controlled).
        /// </summary>
        [YearRange(1992, 1995)]
        [Locations(ConflictLocations.BosniaHerzegovina)]
        [ConflictRegions(ConflictRegionFlags.Europe)]
        ConflictInBosniaHerzegovina = 389,

        /// <summary>
        /// 1991: Croatia declared independence from Yugoslavia, leading to war.
        /// 1992: United Nations-brokered ceasefire (Vance Plan) led to the deployment of UN peacekeepers (UNPROFOR).
        /// Croatia was internationally recognized as an independent state, but Serb forces controlled one-third of the country.
        /// 1992-1994: Croatia launched small-scale operations to regain territory from the Republic of Serbian Krajina (RSK).
        /// 1993: Operation Maslenica – Croatia recaptured key coastal areas.
        /// 1994: Operation Winter '94 – Croatia advanced against Serb positions in Bosnia.
        /// May 1995: Operation Flash – Croatia recaptured Western Slavonia.
        /// August 1995: Operation Storm: Largest battle of the war; Croatia retook Krajina in four days.
        /// November 1995: Erdut Agreement – Croatia and Serb forces agreed to a peaceful reintegration of Eastern Slavonia.
        /// </summary>
        [YearRange(1992, 1995)]
        [Locations(ConflictLocations.Croatia)]
        [ConflictRegions(ConflictRegionFlags.Europe)]
        ConflictInCroatia = 390,

        /// <summary>
        /// 1991: Tajikistan gained independence from the Soviet Union.
        /// 1992: Power struggles between pro-communist force and Islamists/democrats (Islamist-led United Tajik Opposition (UTO))
        /// May 1992: War broke out between government forces and the UTO.
        /// 1992-1994: Fighting concentrated in Dushanbe and southern Tajikistan. Ethnic cleansing, mass displacement, and warlord rule.
        /// Russia and Uzbekistan supported the government, while UTO received backing from Afghanistan and Iran.
        /// 1994-1997: Government offensives pushed UTO fighters into Afghanistan.
        /// 1997 Peace Agreement signed in Moscow under UN mediation.
        /// </summary>
        [YearRange(1992, 2011)]
        [Locations(ConflictLocations.Tajikistan)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        ConflictInTajikistan = 395,

        /// <summary>
        /// 1991: After the fall of the Soviet Union, Chechnya declared independence under Dzhokhar Dudayev.
        /// 1994: Russia, under Boris Yeltsin, refused to recognize Chechen independence and launched a military offensive.
        /// December 1994: Russian troops invaded Chechnya.
        /// 1995: Heavy fighting in Grozny; Russia faced fierce resistance.
        /// June 1995: Budennovsk hospital hostage crisis—Chechen rebels took 1,500 hostages in southern Russia.
        /// August 1996: Battle of Grozny—Chechen forces recaptured the capital.
        /// 1996 Khasavyurt Accord ended the war; Russia withdrew
        /// Chechnya gained de facto independence, but instability remained.
        /// 1999: Chechen militants, led by Shamil Basayev, invaded Dagestan, prompting Russian intervention.
        /// September 1999: Apartment bombings in Moscow and other cities (blamed on Chechen rebels) led to a new war.
        /// October 1999: Russian forces invaded Chechnya under Vladimir Putin.
        /// February 2000: Russia recaptured Grozny, declaring victory.
        /// 2000–2002: Chechen rebels shifted to guerrilla warfare and terrorism.
        /// 2003: Russia established a pro-Moscow government in Chechnya
        /// 2005: Chechen leader Aslan Maskhadov was killed
        /// 2006: Shamil Basayev was killed, weakening the insurgency.
        /// 2004: Beslan school siege—Chechen terrorists took 1,100 hostages; over 330 people died.
        /// 2005–2007: Russian forces suppressed most rebel groups
        /// 2007: Russia declared the war officially over.
        /// </summary>
        [YearRange(1994, 2007)]
        [Locations(ConflictLocations.RussiaSovietUnion)]
        [ConflictRegions(ConflictRegionFlags.Europe)]
        ChechnyaSeparatism = 401,

        /// <summary>
        /// The MQM (Muttahida Qaumi Movement) was founded in 1984 by Altaf Hussain as a political movement for Muhajirs (Indian 
        /// immigrants in Pakistan).
        /// By the 1990s, the MQM had armed factions and was accused of organized crime, extortion, and violence in Karachi.
        /// 1995: Prime Minister Benazir Bhutto intensified military-police operations, targeting MQM strongholds.
        /// 1999: General Pervez Musharraf took power in a coup; MQM tensions reduced temporarily.
        /// The Tehrik-i-Taliban Pakistan (TTP) was formed in 2007, inspired by the Afghan Taliban.
        /// The TTP aimed to impose Sharia law and overthrow the Pakistani government.
        /// 2014: Peshawar school massacre – TTP militants killed over 140 children.
        /// 2015–2016: Pakistan’s military launched "Operation Zarb-e-Azb", killing thousands of militants.
        /// </summary>
        [YearRange(1990, 2023)]
        [Locations(ConflictLocations.Pakistan)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        OngoingConflictInPakistan = 404,

        /// <summary>
        /// 1993: Presidential elections, Lissouba’s victory led to violent clashes between militias backing different candidates.
        /// 1994: A peace agreement was signed, but tensions remained.
        /// First Congolese Civil War (1997)
        /// 1997: Lissouba attempted to disarm militias, triggering war. Denis Sassou Nguesso, backed by Angola, overthrew Lissouba and returned to power.
        /// Second Congolese Civil War (1998–1999)
        /// 1998: Militias loyal to Lissouba and former PM Bernard Kolélas launched an insurgency.
        /// 1999: Government forces, with Angolan military support, crushed the rebellion.
        /// 2002: "Ninja" rebels, led by Frédéric Bintsamou (Pastor Ntumi), resumed fighting against the government.
        /// 2003-2016: Ongoing clashes between government forces and Ninja militias in the Pool region.
        /// 2016: Sassou Nguesso won a disputed election, sparking new rebel attacks.
        /// </summary>
        [YearRange(1993, 2016)]
        [Locations(ConflictLocations.Congo)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        ConflictInCongo = 408,

        /// <summary>
        /// 1993: Eritrea gained independence from Ethiopia after a 30-year war.
        /// 1998: Border disputes over the town of Badme led to war.
        /// May 1998: Eritrean troops occupied Badme; Ethiopia launched a counteroffensive.
        /// 1999: Ethiopia recaptured Badme.
        /// 2000: Ethiopia launched a final offensive, pushing deep into Eritrea. The Algiers Peace Agreement was signed in December, ending active fighting.
        /// </summary>
        [YearRange(1998, 2016)]
        [Locations(ConflictLocations.Eritrea)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        EritreaEthiopiaWar = 409,

        /// <summary>
        /// Kosovo, a province of Serbia, had a majority ethnic Albanian population.
        /// 1990s: Serbian President Slobodan Milošević imposed harsh repression on Kosovo Albanians.
        /// 1996: The UÇK emerged, launching attacks on Serbian police and military.
        /// February 1998: Serbia began a military crackdown in Kosovo.
        /// March–June 1998: Serbian forces launched major offensives, targeting UÇK strongholds.
        /// September 1998: NATO issued warnings to Serbia but took no immediate action.
        /// January 1999: The Račak massacre (45 Albanians killed) intensified global outrage.
        /// March 24, 1999: NATO launched a 78-day bombing campaign against Serbian forces
        /// April–June 1999: Ethnic cleansing intensified: Over 800,000 Kosovars were expelled by Serbian forces.
        /// June 10, 1999: Serbia agreed to withdraw from Kosovo, and NATO troops entered as peacekeepers.
        /// </summary>
        [YearRange(1998, 1999)]
        [Locations(ConflictLocations.SerbiaYugoslavia)]
        [ConflictRegions(ConflictRegionFlags.Europe)]
        SerbiaKosovoLiberationArmyWar = 412,

        /// <summary>
        /// 9/11 Attacks and U.S. Response (2001)
        /// U.S. Invasion of Afghanistan and Al-Qaida’s Dispersal (2001–2006)
        /// Iraq War and Rise of Al-Qaida in Iraq (2003–2011)
        /// Global Drone Strikes and Special Operations (2006–2011)
        /// Al-Qaida’s Fragmentation and Decline (2012–2019). Al-Qaida lost influence as ISIS emerged as a rival group.
        /// </summary>
        [YearRange(2001, 2019)]
        [Locations(ConflictLocations.UnitedStatesOfAmerica)]
        [ConflictRegions(ConflictRegionFlags.Americas)]
        UnitedStatesvsalQaida = 418,

        /// <summary>
        /// Invasion of Iraq per intelligence believing there were weapons of mass destruction present
        /// </summary>
        [YearRange(2003, 2003)]
        [Locations(ConflictLocations.Australlia, ConflictLocations.Iraq, ConflictLocations.UnitedKingdom, ConflictLocations.UnitedStatesOfAmerica)]
        [ConflictRegions(ConflictRegionFlags.Europe | ConflictRegionFlags.MiddleEast | ConflictRegionFlags.Asia | ConflictRegionFlags.Americas)]
        InvasionOfIraqIn2003 = 420,

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
        /// July 9, 2011: South Sudan became an independent country after a referendum.
        /// President Salva Kiir (Dinka ethnic group) and Vice President Riek Machar (Nuer ethnic group) had political rivalries.
        /// 2012: South Sudan and Sudan clashed over oil-rich border regions (e.g., Heglig).
        /// December 2013: Kiir accused Machar of plotting a coup, sparking civil war.
        /// December 2013: Fighting erupted in Juba, spreading nationwide.
        /// 2014: Rebels loyal to Machar captured parts of Jonglei, Unity, and Upper Nile states.
        /// 2015: A peace agreement was signed but quickly collapsed.
        /// July 2016: Renewed fighting in Juba forced Machar to flee.
        /// 2017–2018: Famine and mass displacement affected millions.
        /// September 2018: The Revitalized Peace Agreement was signed.
        /// 2019: Ceasefires largely held, but local clashes persisted.
        /// 2020: A unity government was formed, with Machar reinstated as Vice President.
        /// 2021–2022: Ethnic and militia violence continued, especially in Jonglei and Upper Nile.
        /// 2023: Delays in implementing peace agreements raised concerns about elections in 2024.
        /// </summary>
        [YearRange(2011, 2021)]
        [Locations(ConflictLocations.SouthSudan)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        OngoingConflictInSouthSudan = 11345,

        /// <summary>
        /// October 2011: The National Transitional Council (NTC) took control of Libya after Qaddafi’s fall.
        /// 2012: Libya held elections for the General National Congress (GNC), but the government struggled to control armed militias, many of which had 
        /// fought against Qaddafi.
        /// 2013–2014: Islamist and secular factions within the GNC clashed, leading to political gridlock.
        /// 2014: General Khalifa Haftar, a former Qaddafi-era officer, launched "Operation Dignity" against Islamist militias in Benghazi. This 
        /// triggered the Second Libyan Civil War.
        /// 2014: Libya split into two competing governments:
        /// 1. Tripoli-based Government of National Accord (GNA) – backed by the United Nations, Turkey, and Qatar.
        /// 2. Tobruk-based House of Representatives (HoR) – allied with Khalifa Haftar’s Libyan National Army (LNA), supported by Egypt, the UAE, and Russia.
        /// 2015: The Skhirat Agreement, brokered by the UN, attempted to unify the rival factions but failed to end the fighting.
        /// 2016: Haftar’s LNA captured Benghazi, strengthening his control over eastern Libya
        /// 2018: Haftar took control of the oil-rich Sirte Basin.
        /// April 2019: Haftar launched an offensive on Tripoli, seeking to overthrow the GNA
        /// 2019–2020: Heavy fighting in Tripoli led to thousands of casualties and displacement.
        /// Turkey intervened in early 2020, sending troops and drones to support the GNA.
        /// Russia, through the Wagner Group, increased its backing of Haftar’s LNA.
        /// June 2020: The GNA counteroffensive, backed by Turkish drones, pushed Haftar’s forces back from Tripoli.
        /// October 2020: A ceasefire agreement was signed under UN mediation, ending large-scale fighting.
        /// </summary>
        [YearRange(2011, 2020)]
        [Locations(ConflictLocations.Libya)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        LibyaPostQaddafiInstability = 11346,

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
        /// see 13247
        /// </summary>
        [YearRange(2014, 2014)]
        [Locations(ConflictLocations.Ukraine)]
        [ConflictRegions(ConflictRegionFlags.Europe)]
        UkrainevsDPRIn2014 = 13246,

        /// <summary>
        /// February 2014: Ukraine’s Euromaidan Revolution led to the overthrow of pro-Russian President Viktor Yanukovych.
        /// March 2014: Russia annexed Crimea, escalating tensions.
        /// April 2014: Pro-Russian separatists in Donetsk and Luhansk declared independence, forming the DPR and LPR.
        /// Armed militants seized government buildings in Donetsk, Luhansk, and Sloviansk.
        /// April 13, 2014: Ukraine launched the "Anti-Terrorist Operation" (ATO) against separatists.
        /// Heavy clashes occurred in Sloviansk, Kramatorsk, and Mariupol.
        /// The Ukrainian military recaptured Sloviansk in July.
        /// June 2014: The separatists received Russian fighters and weapons.
        /// July 17, 2014: Malaysia Airlines Flight MH17 was shot down over DPR-held territory by a Russian-supplied Buk missile.
        /// August 2014: Ukrainian forces made major gains but were countered by Russian troops, who entered Donbas in late August.
        /// August 2014: Ukraine launched an offensive to retake Ilovaisk but was ambushed by Russian forces.
        /// Ukrainian troops suffered heavy losses, with over 300 killed.
        /// September 2014: The Minsk I ceasefire was signed, but fighting continued.
        /// </summary>
        [YearRange(2014, 2014)]
        [Locations(ConflictLocations.Ukraine)]
        [ConflictRegions(ConflictRegionFlags.Europe)]
        UkrainevsLPRIn2014 = 13247,

        /// <summary>
        /// Since 2014, DPR and LPR controlled parts of Donetsk and Luhansk in eastern Ukraine, backed by Russia.
        /// 2021: Russia massed troops along Ukraine’s border, raising fears of an invasion.
        /// February 2022:
        /// DPR and LPR declared full independence, with Russia recognizing them.
        /// Russia sent “peacekeeping forces”, effectively setting the stage for a wider conflict.
        /// </summary>
        [YearRange(2014, 2022)]
        [Locations(ConflictLocations.Ukraine)]
        [ConflictRegions(ConflictRegionFlags.Europe)]

        SeparatismOfDonetskAndLuhanskInUkraine = 13306,

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
        /// 2015: ISIS-K was founded as a regional branch of the Islamic State, operating mainly in eastern Afghanistan (Nangarhar and Kunar provinces).
        /// 2015–2021: The Afghan Republic vs. ISIS-K. The Afghan government fought ISIS-K with the support of U.S. airstrikes and special forces.
        /// 2021–Present: Taliban Rule and ISIS-K Insurgency
        /// August 2021: The Taliban took over Afghanistan after the U.S. withdrawal and the fall of the Afghan Republic.
        /// August 26, 2021: ISIS-K bombed Kabul airport, killing over 180 people, including 13 U.S. soldiers.
        /// The Taliban government launched an anti-ISIS campaign, using both military force and intelligence operations.
        /// ISIS-K responded with assassinations, bombings, and attacks on Taliban targets, foreign embassies, and religious minorities.
        /// </summary>
        [YearRange(2015, 2023)]
        [Locations(ConflictLocations.Afghanistan)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        IslamicStateInAfghanistan = 13637,

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
        /// post 9/11 invasion of Afghanistan against al-Qaida and the Taliban who ruled Afghanistan at the time
        /// </summary>
        [YearRange(2001, 2001)]
        [Locations(ConflictLocations.Afghanistan, ConflictLocations.UnitedKingdom, ConflictLocations.UnitedStatesOfAmerica)]
        [ConflictRegions(ConflictRegionFlags.Europe | ConflictRegionFlags.Asia | ConflictRegionFlags.Americas)]
        InvasionOfAfghanistanPostNineEleven = 13692,

        /// <summary>
        /// 2015: ISIS captured Sirte, establishing it as its main stronghold outside Iraq and Syria.
        /// January: ISIS attacked the Corinthia Hotel in Tripoli, killing 10 people.
        /// February: ISIS executed 21 Egyptian Christians on a Libyan beach.
        /// March–June: ISIS seized Nofaliya and Harawa near Sirte
        /// Late 2015: The Government of National Accord (GNA), backed by the UN, was formed but was too weak to counter ISIS effectively.
        /// March 2016: ISIS began expanding from Sirte toward Misrata but faced resistance from Libyan forces.
        /// May–December 2016: Battle of Sirte. The GNA, backed by U.S. airstrikes, launched an offensive to retake Sirte.
        /// December 2016: ISIS was expelled from Sirte, marking its biggest territorial loss in Libya.
        /// 2017: ISIS retreated into the desert and southern Libya, resorting to hit-and-run attacks.
        /// 2018: ISIS regrouped and carried out
        /// 1.Bombings and assassinations in Tripoli, Misrata, and the Fezzan region.
        /// 2. May 2018: ISIS attacked the Electoral Commission in Tripoli, killing 14.
        /// 3. September 2018: Attack on NOC headquarters in Tripoli.
        /// 2019: ISIS targeted Libyan National Army (LNA) forces under Khalifa Haftar in the south.
        /// April 2019: LNA launched a crackdown on ISIS in Fezzan, reducing its operational capacity
        /// </summary>
        [YearRange(2015, 2019)]
        [Locations(ConflictLocations.Libya)]
        [ConflictRegions(ConflictRegionFlags.Africa)]
        IslamicStateInLibya = 13694,

        /// <summary>
        /// October 10, 2015: Ankara bombing – ISIS suicide bombers killed over 100 people, Turkey’s deadliest terror attack.
        /// Turkey allowed the U.S. to use Incirlik Air Base for airstrikes against ISIS.
        /// Turkish forces began airstrikes and artillery attacks on ISIS positions in Syria.
        /// January 2016: ISIS bombing in Istanbul killed 13 tourists.
        /// March 2016: ISIS attacked Ankara and Istanbul, killing civilians.
        /// August 2016: Turkey launched Operation Euphrates Shield:
        /// December 2016–January 2017
        /// Istanbul nightclub attack (New Year's Eve) – An ISIS gunman killed 39 people.
        /// Turkish forces launched final operations in Al-Bab, one of ISIS’s last strongholds in Syria.
        /// February 2017: Turkish-backed forces captured Al-Bab, effectively ending ISIS’s presence near the Turkish border.
        /// </summary>
        [YearRange(2015, 2017)]
        [Locations(ConflictLocations.Turkey)]
        [ConflictRegions(ConflictRegionFlags.MiddleEast)]
        IslamicStateInTurkey = 13902,

        /// <summary>
        /// The Abu Sayyaf Group (ASG) and other extremist groups were active in Mindanao since the 1990s.
        /// In 2014–2015, several Islamist groups pledged allegiance to ISIS, forming ISIS-Philippines.
        /// 2016–2017: Rise of ISIS in Mindanao
        /// 2018–2020: ISIS Resurgence and Counterinsurgency
        /// </summary>
        [YearRange(2016, 2023)]
        [Locations(ConflictLocations.Philippines)]
        [ConflictRegions(ConflictRegionFlags.Asia)]
        PhilippinesAgainstIslamicState = 14275,

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
