using Existence.Earth.Alphabet;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Time;
using System;

namespace Existence.Earth.Countries
{
    public class CapitalAttribute : Attribute
    {
        public int Capital { get; set; }
        public CapitalAttribute(int Capital)
        {
            this.Capital = Capital;
        }
    }

    public class UnofficialCapitalAttribute : CapitalAttribute
    {
        public UnofficialCapitalAttribute(int Capital) : base(Capital)
        {

        }
    }

    public class AdministrativeCapitalAttribute : CapitalAttribute
    {
        public AdministrativeCapitalAttribute(int Capital) : base(Capital)
        {
        }
    }

    public class ConstitutionalCapitalAttribute : CapitalAttribute
    {
        public ConstitutionalCapitalAttribute(int Capital): base(Capital)
        {
        }
    }

    public class LegislativeCapitalAttribute : CapitalAttribute
    {
        public LegislativeCapitalAttribute(int Capital) : base(Capital)
        {
        }
    }

    public class JudicialCapitalAttribute : CapitalAttribute
    {
        public JudicialCapitalAttribute(int Capital) : base(Capital)
        {
        }
    }

    public class RoyalCapitalAttribute : CapitalAttribute
    {
        public RoyalCapitalAttribute(int Capital) : base(Capital)
        {
        }
    }

    public class DeFactoCapitalAttribute : CapitalAttribute
    {
        public DeFactoCapitalAttribute(int Capital) : base(Capital)
        {
        }
    }

    public class ClaimedCapitalAttribute : CapitalAttribute
    {
        public ClaimedCapitalAttribute(int Capital) : base(Capital)
        {
        }
    }

    public class PlannedCapitalAttribute : CapitalAttribute
    {
        public PlannedCapitalAttribute(int Capital) : base(Capital)
        {
        }
    }

    public class UnitedNationsMembershipAttribute : YearDateAttribute
    {
        public UnitedNationsMembershipAttribute(int year, int month, int day) : base(year, month, day)
        {
        }
    }

    public class LargestCityAttribute : WorldCityAttribute
    {
        public int LargestCity
        {
            get
            {
                return City;
            }
            set
            {
                City = value;
            }
        }
        public LargestCityAttribute(int LargestCity) : base(LargestCity)
        {
        }
    }

    public class WorldCityAttribute : NumberAttribute
    {
        public int City
        { 
            get
            {
                return base.Number;
            }
            set
            {
                base.Number = value;
            }
        }
        public WorldCityAttribute(int City) : base(City)
        {
        }
    }

    public class LocalNameAttribute : TextAttribute
    {
        public string LocalName
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
        public LocalNameAttribute(string LocalName) : base(LocalName)
        {

        }
    }

    /// <summary>
    /// suggest: https://www.populationof.net/
    /// </summary>
    public class PopulationEstimateAttribute : Attribute
    {
        public int Number { get; set; }

        public PopulationEstimateAttribute(int Number)
        {
            this.Number = Number;
        }
    }

    public class CountryAttribute : Attribute
    {
        public CountryLikeThings Country { get; set; }
        public CountryAttribute(CountryLikeThings Country)
        {
            this.Country = Country;
        }
    }

    public class CountriesAttribute : Attribute
    {
        public CountryLikeThings[] Countries { get; set; }
        public CountriesAttribute(params CountryLikeThings[] Countries)
        {
            this.Countries = Countries;
        }
    }

    /// <summary>
    /// A stateless person is someone who is not recognized as a citizen by any country, meaning they have 
    /// no nationality and no legal protection from any government.
    /// </summary>
    public static class Stateless { }

    /// <summary>
    /// Subjective definition of a country
    /// 1. An entity other countries think of as a country
    /// Objective definition of a country
    /// 1. Permanent Population
    /// 2. Defined Territory
    /// 3. Government
    /// 4. Capacity to enter into relations with other states
    /// </summary>
    public enum CountryLikeThings
    {
        [UnitedNationsMembership(1946, 11, 19)]
        [Capital((int)WorldCities.AfghanistanKabul)]
        [LargestCity((int)WorldCities.AfghanistanKabul)]
        [PopulationEstimate(43000000)] //43 million
        Afghanistan,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.AlbaniaTirana)]
        [LargestCity((int)WorldCities.AlbaniaTirana)]
        [PopulationEstimate(2800000)] //2.8 million
        Albania,

        [UnitedNationsMembership(1962, 10, 8)]
        [Capital((int)WorldCities.AlgeriaAlgiers)]
        [LargestCity((int)WorldCities.AlgeriaAlgiers)]
        [PopulationEstimate(46000000)]
        Algeria,

        [UnitedNationsMembership(1993, 7, 28)]
        [Capital((int)WorldCities.AndorraAndorraLaVella)]
        [LargestCity((int)WorldCities.AndorraAndorraLaVella)]
        [PopulationEstimate(80000)]
        Andorra,

        [UnitedNationsMembership(1976, 12, 1)]
        [Capital((int)WorldCities.AngolaLuanda)]
        [LargestCity((int)WorldCities.AngolaLuanda)]
        [PopulationEstimate(37000000)] //37 million
        Angola,

        [UnitedNationsMembership(1981, 11, 11)]
        [Capital((int)WorldCities.AntiguaAndBarbudaStJohns)]
        [LargestCity((int)WorldCities.AntiguaAndBarbudaStJohns)]
        [PopulationEstimate(100000)]
        AntiguaAndBarbuda,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.ArgentinaBuenosAires)]
        [LargestCity((int)WorldCities.ArgentinaBuenosAires)]
        [PopulationEstimate(46000000)] //46 million
        Argentina,

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.ArmeniaYerevan)]
        [LargestCity((int)WorldCities.ArmeniaYerevan)]
        [PopulationEstimate(2800000)] //2.8 million
        Armenia,

        [UnitedNationsMembership(1945, 11, 1)]
        [Capital((int)WorldCities.AustraliaCanberra)]
        [LargestCity((int)WorldCities.AustraliaSydney)]
        [PopulationEstimate(26500000)] //26.5 million
        Australia,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.AustriaVienna)]
        [LargestCity((int)WorldCities.AustriaVienna)]
        [PopulationEstimate(9100000)] //9.1 million
        Austria,

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.AzerbaijanBaku)]
        [LargestCity((int)WorldCities.AzerbaijanBaku)]
        [PopulationEstimate(10400000)] //10.4 million
        Azerbaijan,

        [UnitedNationsMembership(1973, 9, 18)]
        [Capital((int)WorldCities.BahamasNassau)]
        [LargestCity((int)WorldCities.BahamasNassau)]
        [PopulationEstimate(400000)]
        Bahamas,

        [UnitedNationsMembership(1971, 9, 21)]
        [Capital((int)WorldCities.BahrainManama)]
        [LargestCity((int)WorldCities.BahrainManama)]
        [PopulationEstimate(1500000)] //1.5 million
        Bahrain,

        [UnitedNationsMembership(1974, 9, 17)]
        [Capital((int)WorldCities.BangladeshDhaka)]
        [LargestCity((int)WorldCities.BangladeshDhaka)]
        [PopulationEstimate(174950000)] //174.95 million
        Bangladesh,

        [UnitedNationsMembership(1966, 12, 9)]
        [Capital((int)WorldCities.BarbadosBridgetown)]
        [LargestCity((int)WorldCities.BarbadosBridgetown)]
        [PopulationEstimate(280000)]
        Barbados,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.BelarusMinsk)]
        [LargestCity((int)WorldCities.BelarusMinsk)]
        [PopulationEstimate(9200000)] //9.2 million
        Belarus,

        [UnitedNationsMembership(1945, 12, 27)]
        [Capital((int)WorldCities.BelgiumBrussels)]
        [LargestCity((int)WorldCities.BelgiumBrussels)]
        [PopulationEstimate(11700000)] //11.7 million
        Belgium,

        [UnitedNationsMembership(1981, 9, 25)]
        [Capital((int)WorldCities.BelizeBelmopan)]
        [LargestCity((int)WorldCities.BelizeBelizeCity)]
        [PopulationEstimate(420000)]
        Belize,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.BeninPortoNovo)]
        [LargestCity((int)WorldCities.BeninCotonou)]
        [PopulationEstimate(13700000)] //13.7 million
        Benin,

        [UnitedNationsMembership(1971, 9, 21)]
        [Capital((int)WorldCities.BhutanThimphu)]
        [LargestCity((int)WorldCities.BhutanThimphu)]
        [PopulationEstimate(780000)]
        Bhutan,

        [FullName("Plurinational State of Bolivia")]
        [UnitedNationsMembership(1945, 11, 14)]
        [ConstitutionalCapital((int)WorldCities.BoliviaSucre)]
        [AdministrativeCapital((int)WorldCities.BoliviaLaPaz)]
        [LargestCity((int)WorldCities.BoliviaSantaCruzDeLaSierra)]
        [PopulationEstimate(12200000)] //12.2 million
        Bolivia,

        [UnitedNationsMembership(1992, 5, 22)]
        [Capital((int)WorldCities.BosniaAndHerzegovinaSarajevo)]
        [LargestCity((int)WorldCities.BosniaAndHerzegovinaSarajevo)]
        [PopulationEstimate(3200000)] //3.2 million
        BosniaAndHerzegovina,

        [UnitedNationsMembership(1966, 10, 17)]
        [Capital((int)WorldCities.BotswanaGaborone)]
        [LargestCity((int)WorldCities.BotswanaGaborone)]
        [PopulationEstimate(2600000)] //2.6 million
        Botswana,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.BrazilBrasilia)]
        [LargestCity((int)WorldCities.BrazilSaoPaulo)]
        [PopulationEstimate(218800000)] //218.8 million
        Brazil,

        [FullName("Brunei Darussalam")]
        [UnitedNationsMembership(1984, 9, 21)]
        [Capital((int)WorldCities.BruneiBandarSeriBegawan)]
        [LargestCity((int)WorldCities.BruneiBandarSeriBegawan)]
        [PopulationEstimate(460000)]
        Brunei,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.BulgariaSofia)]
        [LargestCity((int)WorldCities.BulgariaSofia)]
        [PopulationEstimate(6500000)] //6.5 million
        Bulgaria,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.BurkinaFasoOuagadougou)]
        [LargestCity((int)WorldCities.BurkinaFasoOuagadougou)]
        [PopulationEstimate(22500000)] //22.5 million
        BurkinaFaso,

        [UnitedNationsMembership(1948, 4, 19)]
        [Capital((int)WorldCities.BurmaNaypyidaw)]
        [LargestCity((int)WorldCities.BurmaRangoon)]
        [LocalName("Myanmar")]
        [PopulationEstimate(55000000)] //55 million
        Burma,

        [UnitedNationsMembership(1962, 9, 18)]
        [Capital((int)WorldCities.BurundiGitega)]
        [LargestCity((int)WorldCities.BurundiBujumbura)]
        [PopulationEstimate(13000000)] //13 million
        Burundi,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.CambodiaPhnomPenh)]
        [LargestCity((int)WorldCities.CambodiaPhnomPenh)]
        [PopulationEstimate(17000000)] //17 million
        Cambodia,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.CameroonYaounde)]
        [LargestCity((int)WorldCities.CameroonDouala)]
        [PopulationEstimate(30150000)] //30.15 million
        Cameroon,

        [UnitedNationsMembership(1945, 11, 9)]
        [Capital((int)WorldCities.CanadaOttawa)]
        [LargestCity((int)WorldCities.CanadaToronto)]
        [PopulationEstimate(41700000)] //41.7 million
        Canada,

        [UnitedNationsMembership(1975, 9, 16)]
        [Capital((int)WorldCities.CapeVerdePraia)]
        [LargestCity((int)WorldCities.CapeVerdePraia)]
        [LocalName("Cabo Verde")]
        [PopulationEstimate(527326)]
        CapeVerde,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.CentralAfricanRepublicBangui)]
        [LargestCity((int)WorldCities.CentralAfricanRepublicBangui)]
        [PopulationEstimate(6100000)] //6.1 million
        CentralAfricanRepublic,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.ChadNDjamena)]
        [LargestCity((int)WorldCities.ChadNDjamena)]
        [PopulationEstimate(19400000)] //19.4 million
        Chad,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.ChileSantiago)]
        [LargestCity((int)WorldCities.ChileSantiago)]
        [PopulationEstimate(19700000)] //19.7 million
        Chile,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.ChinaBeijing)]
        [LargestCity((int)WorldCities.ChinaShanghai)]
        [FullName("People's Republic of China")]
        [Abbreviation("PRC")]
        [PopulationEstimate(1408000000)] //1.408 billion
        China,

        [UnitedNationsMembership(1945, 11, 5)]
        [Capital((int)WorldCities.ColombiaBogota)]
        [LargestCity((int)WorldCities.ColombiaBogota)]
        [PopulationEstimate(53100000)] //53.1 million
        Colombia,

        [UnitedNationsMembership(1975, 11, 12)]
        [Capital((int)WorldCities.ComorosMoroni)]
        [LargestCity((int)WorldCities.ComorosMoroni)]
        [PopulationEstimate(969315)]
        Comoros,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.CongoBrazzaville)]
        [LargestCity((int)WorldCities.CongoBrazzaville)]
        [FullName("Republic of the Congo")]
        [Abbreviation("ROC")]
        [PopulationEstimate(6380000)] //6.38 million
        Congo,

        [UnitedNationsMembership(1945, 11, 2)]
        [Capital((int)WorldCities.CostaRicaSanJose)]
        [LargestCity((int)WorldCities.CostaRicaSanJose)]
        [PopulationEstimate(5280199)]
        CostaRica,

        [UnitedNationsMembership(1992, 5, 22)]
        [Capital((int)WorldCities.CroatiaZagreb)]
        [LargestCity((int)WorldCities.CroatiaZagreb)]
        [PopulationEstimate(3960000)] //3.96 million
        Croatia,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.CubaHavana)]
        [LargestCity((int)WorldCities.CubaHavana)]
        [PopulationEstimate(11411842)] //11.4 million
        Cuba,

        /// <summary>
        /// 1974: A Greek-backed coup attempted to unite Cyprus with Greece.
        /// Turkey invaded the northern part of the island, citing protection of Turkish Cypriots.
        /// 1975: The Turkish Republic of Northern Cyprus (TRNC) was declared, and in 1983, it 
        /// declared full independence.
        /// Only Turkey recognizes Northern Cyprus as an independent state. The United Nations, 
        /// the European Union, and most countries consider it part of the Republic of Cyprus.
        /// The UN has a buffer zone ("Green Line") separating North and South Cyprus, patrolled 
        /// by peacekeepers.
        /// Cyprus is a member of the European Union (EU), but EU laws do not apply in Northern 
        /// Cyprus due to the division. The UN supports reunification efforts through 
        /// negotiations, such as the Annan Plan (2004) and later talks, but no agreement has 
        /// been reached.
        /// Northern Cyprus relies heavily on Turkey for economic, political, and military support.
        /// It uses the Turkish lira and is economically dependent on Turkey.
        /// </summary>
        [ClaimedCapital((int)WorldCities.NorthernCyprusNorthNicosia)]
        [LargestCity((int)WorldCities.NorthernCyprusNorthNicosia)]
        [PopulationEstimate(400000)]
        CyprusNorth,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.CyprusSouthNicosia)]
        [LargestCity((int)WorldCities.CyprusSouthNicosia)]
        [PopulationEstimate(1269748)] //1.27 million
        CyprusSouth,

        [UnitedNationsMembership(1993, 1, 19)]
        [LocalName("Czechia")]
        [Capital((int)WorldCities.CzechRepublicPrague)]
        [LargestCity((int)WorldCities.CzechRepublicPrague)]
        [PopulationEstimate(10509965)] //10.5 million
        CzechRepublic,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.DenmarkCopenhagen)]
        [LargestCity((int)WorldCities.DenmarkCopenhagen)]
        [PopulationEstimate(5800000)] //5.8 million
        Denmark,

        [UnitedNationsMembership(1977, 9, 20)]
        [Capital((int)WorldCities.DjiboutiDjiboutiCity)]
        [LargestCity((int)WorldCities.DjiboutiDjiboutiCity)]
        [PopulationEstimate(1000000)] //1 million
        Djibouti,

        [UnitedNationsMembership(1978, 12, 18)]
        [Capital((int)WorldCities.DominicaRoseau)]
        [LargestCity((int)WorldCities.DominicaRoseau)]
        [PopulationEstimate(72000)]
        Dominica,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.DominicanRepublicSantoDomingo)]
        [LargestCity((int)WorldCities.DominicanRepublicSantoDomingo)]
        [PopulationEstimate(11000000)] //11 million
        DominicanRepublic,

        [UnitedNationsMembership(2002, 9, 27)]
        [LocalName("Timor-Leste")]
        [Capital((int)WorldCities.EastTimorDili)]
        [LargestCity((int)WorldCities.EastTimorDili)]
        [PopulationEstimate(1300000)] //1.3 million
        EastTimor,

        [UnitedNationsMembership(1945, 12, 21)]
        [Capital((int)WorldCities.EcuadorQuito)]
        [LargestCity((int)WorldCities.EcuadorGuayaquil)]
        [PopulationEstimate(17700000)] //17.7 million
        Ecuador,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.EgyptCairo)]
        [LargestCity((int)WorldCities.EgyptCairo)]
        [PopulationEstimate(104000000)] //104 million
        Egypt,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.ElSalvadorSanSalvador)]
        [LargestCity((int)WorldCities.ElSalvadorSanSalvador)]
        [PopulationEstimate(6500000)] //6.5 million
        ElSalvador,

        [UnitedNationsMembership(1968, 11, 12)]
        [Capital((int)WorldCities.EquatorialGuineaMalabo)]
        [PlannedCapital((int)WorldCities.EquatorialGuineaCiudadDeLaPaz)]
        [LargestCity((int)WorldCities.EquatorialGuineaBata)]
        [PopulationEstimate(1400000)] //1.4 million
        EquitorialGuinea,

        [UnitedNationsMembership(1993, 5, 28)]
        [Capital((int)WorldCities.EritreaAsmara)]
        [LargestCity((int)WorldCities.EritreaAsmara)]
        [PopulationEstimate(3600000)] //3.6 million
        Eritrea,

        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.EstoniaTalinn)]
        [LargestCity((int)WorldCities.EstoniaTalinn)]
        [PopulationEstimate(1300000)] //1.3 million
        Estonia,

        [UnitedNationsMembership(1945, 11, 13)]
        [Capital((int)WorldCities.EthiopiaAddisAbaba)]
        [LargestCity((int)WorldCities.EthiopiaAddisAbaba)]
        [PopulationEstimate(120000000)] //120 million
        Ethiopia,

        [UnitedNationsMembership(1970, 10, 13)]
        [Capital((int)WorldCities.FijiSuva)]
        [LargestCity((int)WorldCities.FijiSuva)]
        [PopulationEstimate(896000)]
        Fiji,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.FinlandHelsinki)]
        [LargestCity((int)WorldCities.FinlandHelsinki)]
        [PopulationEstimate(5500000)] //5.5 million
        Finland,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.FranceParis)]
        [LargestCity((int)WorldCities.FranceParis)]
        [PopulationEstimate(67000000)] //67 million
        France,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.GabonLibreville)]
        [LargestCity((int)WorldCities.GabonLibreville)]
        [PopulationEstimate(2300000)] //2.3 million
        Gabon,

        [UnitedNationsMembership(1965, 9, 21)]
        [Capital((int)WorldCities.GambiaBanjul)]
        [LargestCity((int)WorldCities.GambiaSerekunda)]
        [FullName("Republic of the Gambia")]
        [PopulationEstimate(2400000)] //2.4 million
        Gambia,

        [UnitedNationsMembership(1992, 7, 31)]
        [Capital((int)WorldCities.GeorgiaTbilisi)]
        [LargestCity((int)WorldCities.GeorgiaTbilisi)]
        [PopulationEstimate(3700000)] //3.7 million
        Georgia,

        [UnitedNationsMembership(1973, 9, 18)]
        [Capital((int)WorldCities.GermanyBerlin)]
        [LargestCity((int)WorldCities.GermanyBerlin)]
        [PopulationEstimate(83000000)] //83 million
        Germany,

        [UnitedNationsMembership(1957, 3, 8)]
        [Capital((int)WorldCities.GhanaAccra)]
        [LargestCity((int)WorldCities.GhanaAccra)]
        [PopulationEstimate(32000000)] //32 million
        Ghana,

        [UnitedNationsMembership(1945, 10, 25)]
        [Capital((int)WorldCities.GreeceAthens)]
        [LargestCity((int)WorldCities.GreeceAthens)]
        [PopulationEstimate(10400000)] //10.4 million
        Greece,

        [UnitedNationsMembership(1974, 9, 17)]
        [Capital((int)WorldCities.GrenadaStGeorges)]
        [LargestCity((int)WorldCities.GrenadaStGeorges)]
        [PopulationEstimate(113000)]
        Greneda,

        [UnitedNationsMembership(1945, 11, 21)]
        [Capital((int)WorldCities.GuatemalaGuatemalaCity)]
        [LargestCity((int)WorldCities.GuatemalaGuatemalaCity)]
        [PopulationEstimate(18500000)] //18.5 million
        Guatemala,

        [UnitedNationsMembership(1958, 12, 12)]
        [Capital((int)WorldCities.GuineaConakry)]
        [LargestCity((int)WorldCities.GuineaConakry)]
        [PopulationEstimate(13500000)] //13.5 million
        Guinea,

        [UnitedNationsMembership(1974, 9, 17)]
        [Capital((int)WorldCities.GuineaBissauBissau)]
        [LargestCity((int)WorldCities.GuineaBissauBissau)]
        [PopulationEstimate(2000000)] //2 million
        GuineaBissau,

        [UnitedNationsMembership(1966, 9, 20)]
        [Capital((int)WorldCities.GuyanaGeorgetown)]
        [LargestCity((int)WorldCities.GuyanaGeorgetown)]
        [PopulationEstimate(790000)]
        Guyana,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.HaitiPortauPrince)]
        [LargestCity((int)WorldCities.HaitiPortauPrince)]
        [PopulationEstimate(11400000)] //11.4 million
        Haiti,

        [UnitedNationsMembership(1945, 12, 17)]
        [Capital((int)WorldCities.HondurasTegucigalpa)]
        [LargestCity((int)WorldCities.HondurasSanPedroSula)]
        [PopulationEstimate(10000000)] //10 million
        Honduras,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.HungaryBudapest)]
        [LargestCity((int)WorldCities.HungaryBudapest)]
        [PopulationEstimate(9600000)] //9.6 million
        Hungary,

        [UnitedNationsMembership(1946, 11, 19)]
        [Capital((int)WorldCities.IcelandReykjavik)]
        [LargestCity((int)WorldCities.IcelandReykjavik)]
        [PopulationEstimate(380000)]
        Iceland,

        [UnitedNationsMembership(1945, 10, 30)]
        [Capital((int)WorldCities.IndiaNewDelhi)]
        [LargestCity((int)WorldCities.IndiaMumbai)]
        [PopulationEstimate(1454000000)] //1.454 billion
        India,

        [UnitedNationsMembership(1950, 9, 28)]
        [Capital((int)WorldCities.IndonesiaJakarta)]
        [LargestCity((int)WorldCities.IndonesiaJakarta)]
        [PopulationEstimate(282000000)] //282-290 million
        Indonesia,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.IranTehran)]
        [LargestCity((int)WorldCities.IranTehran)]
        [FullName("Islamic Republic of Iran")]
        [PopulationEstimate(92420000)] //92.42 million
        Iran,

        [UnitedNationsMembership(1945, 12, 21)]
        [Capital((int)WorldCities.IraqBaghdad)]
        [LargestCity((int)WorldCities.IraqBaghdad)]
        [PopulationEstimate(46680000)] //46.68 million
        Iraq,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.IrelandDublin)]
        [LargestCity((int)WorldCities.IrelandDublin)]
        [PopulationEstimate(5290000)] //5.29 million
        Ireland,

        [UnitedNationsMembership(1949, 5, 11)]
        [Capital((int)WorldCities.IsraelJerusalem)]
        [LargestCity((int)WorldCities.IsraelTelAviv)]
        [PopulationEstimate(10000000)] //10 million
        Israel,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.ItalyRome)]
        [LargestCity((int)WorldCities.ItalyRome)]
        [PopulationEstimate(59212298)] //59 million
        Italy,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.IvoryCoastYamoussoukro)]
        [LargestCity((int)WorldCities.IvoryCoastAbidjan)]
        [LocalName("Côte D'Ivoire")]
        [PopulationEstimate(32440000)] //32.44 million
        IvoryCoast,

        [UnitedNationsMembership(1962, 9, 18)]
        [Capital((int)WorldCities.JamaicaKingston)]
        [LargestCity((int)WorldCities.JamaicaKingston)]
        [PopulationEstimate(2837783)] //2.8 million
        Jamaica,

        [UnitedNationsMembership(1956, 12, 18)]
        [Capital((int)WorldCities.JapanTokyo)]
        [LargestCity((int)WorldCities.JapanTokyo)]
        [PopulationEstimate(123321241)] //123 million
        Japan,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.JordanAmman)]
        [LargestCity((int)WorldCities.JordanAmman)]
        [PopulationEstimate(11531768)] //11.5 million
        Jordan,

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.KazakhstanNurSultan)]
        [LargestCity((int)WorldCities.KazakhstanAlmaty)]
        [PopulationEstimate(20758104)] //20.8 million
        Kazakhstan,

        [UnitedNationsMembership(1963, 12, 16)]
        [Capital((int)WorldCities.KenyaNairobi)]
        [LargestCity((int)WorldCities.KenyaNairobi)]
        [PopulationEstimate(57532493)] //57.5 million
        Kenya,

        [UnitedNationsMembership(1999, 9, 14)]
        [Capital((int)WorldCities.KiribatiTarawa)]
        [LargestCity((int)WorldCities.KiribatiTarawa)]
        [PopulationEstimate(137984)]
        Kiribati,

        [UnitedNationsMembership(1963, 5, 14)]
        [Capital((int)WorldCities.KuwaitKuwaitCity)]
        [LargestCity((int)WorldCities.KuwaitKuwaitCity)]
        [PopulationEstimate(4390000)] //4.39 million
        Kuwait,

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.KyrgyzstanBishkek)]
        [LargestCity((int)WorldCities.KyrgyzstanBishkek)]
        [PopulationEstimate(7027900)] //7.0 million
        Kyrgyzstan,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.LaosVientiane)]
        [LargestCity((int)WorldCities.LaosVientiane)]
        [FullName("Lao People’s Democratic Republic")]
        [PopulationEstimate(7840000)] //7.84 million
        Laos,

        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.LatviaRiga)]
        [LargestCity((int)WorldCities.LatviaRiga)]
        [PopulationEstimate(1790000)] //1.79 million
        Latvia,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.LebanonBeirut)]
        [LargestCity((int)WorldCities.LebanonBeirut)]
        [PopulationEstimate(5850000)] //5.85 million
        Lebanon,

        [UnitedNationsMembership(1966, 10, 17)]
        [Capital((int)WorldCities.LesothoMaseru)]
        [LargestCity((int)WorldCities.LesothoMaseru)]
        [PopulationEstimate(2380000)] //2.38 million
        Lesotho,

        [UnitedNationsMembership(1945, 11, 2)]
        [Capital((int)WorldCities.LiberiaMonrovia)]
        [LargestCity((int)WorldCities.LiberiaMonrovia)]
        [PopulationEstimate(5680000)] //5.68 million
        Liberia,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.LibyaTripoli)]
        [LargestCity((int)WorldCities.LibyaTripoli)]
        [PopulationEstimate(7038380)] //7.0 million
        Libya,

        [UnitedNationsMembership(1990, 9, 18)]
        [Capital((int)WorldCities.LiechtensteinVaduz)]
        [LargestCity((int)WorldCities.LiechtensteinVaduz)]
        [PopulationEstimate(40000)]
        Liechtenstein,

        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.LithuaniaVilnius)]
        [LargestCity((int)WorldCities.LithuaniaVilnius)]
        [PopulationEstimate(2890000)] //2.89 million
        Lithuania,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.LuxembourgLuxembourgCity)]
        [LargestCity((int)WorldCities.LuxembourgLuxembourgCity)]
        [PopulationEstimate(672050)]
        Luxembourg,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.MadagascarAntananarivo)]
        [LargestCity((int)WorldCities.MadagascarAntananarivo)]
        [PopulationEstimate(31800000)] //31.8 million
        Madagascar,

        [UnitedNationsMembership(1964, 12, 1)]
        [Capital((int)WorldCities.MalawiLilongwe)]
        [LargestCity((int)WorldCities.MalawiLilongwe)]
        [PopulationEstimate(22000000)] //22 million
        Malawi,

        [UnitedNationsMembership(1957, 9, 17)]
        [Capital((int)WorldCities.MalaysiaKualaLumpur)]
        [AdministrativeCapital((int)WorldCities.MalaysiaPutrajaya)]
        [LargestCity((int)WorldCities.MalaysiaKualaLumpur)]
        [PopulationEstimate(35800000)] //35.8 million
        Malaysia,

        [UnitedNationsMembership(1965, 9, 21)]
        [Capital((int)WorldCities.MaldivesMale)]
        [LargestCity((int)WorldCities.MaldivesMale)]
        [PopulationEstimate(585332)]
        Maldives,

        [UnitedNationsMembership(1960, 9, 28)]
        [Capital((int)WorldCities.MaliBamako)]
        [LargestCity((int)WorldCities.MaliBamako)]
        [PopulationEstimate(24760000)] //24.76 million
        Mali,

        [UnitedNationsMembership(1964, 12, 1)]
        [Capital((int)WorldCities.MaltaValletta)]
        [LargestCity((int)WorldCities.MaltaValletta)]
        [PopulationEstimate(538297)]
        Malta,

        /// <summary>
        /// not a sovereign state but an entity, has observer status
        /// </summary>
        [UnitedNationsMembership(1994, 8, 24)]
        [FullName("Sovereign Military Order of Malta")]
        [PopulationEstimate(13500)]
        MaltaSovereignMilitaryOrder,

        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.MarshallIslandsMajuro)]
        [LargestCity((int)WorldCities.MarshallIslandsMajuro)]
        [PopulationEstimate(42819)]
        MarshallIslands,

        [UnitedNationsMembership(1961, 10, 27)]
        [Capital((int)WorldCities.MauritaniaNouakchott)]
        [LargestCity((int)WorldCities.MauritaniaNouakchott)]
        [PopulationEstimate(5130000)] //5.13 million
        Mauritania,

        [UnitedNationsMembership(1968, 4, 24)]
        [Capital((int)WorldCities.MauritiusPortLouis)]
        [LargestCity((int)WorldCities.MauritiusPortLouis)]
        [PopulationEstimate(1303210)] //1.3 million
        Mauritius,

        [UnitedNationsMembership(1945, 11, 7)]
        [Capital((int)WorldCities.MexicoMexicoCity)]
        [LargestCity((int)WorldCities.MexicoMexicoCity)]
        [PopulationEstimate(131700000)] //131.7 million
        Mexico,

        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.MicronesiaPalikir)]
        [LargestCity((int)WorldCities.MicronesiaPalikir)]
        [FullName("Federated States of Micronesia")]
        [PopulationEstimate(115536)]
        Micronesia,

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.MoldovaChișinău)]
        [LargestCity((int)WorldCities.MoldovaChișinău)]
        [FullName("Republic of Moldova")]
        [PopulationEstimate(2600000)] //2.6 million
        Moldova,

        [UnitedNationsMembership(1993, 5, 28)]
        [Capital((int)WorldCities.MonacoMonacoCity)]
        [LargestCity((int)WorldCities.MonacoMonacoCity)]
        [PopulationEstimate(38000)]
        Monoco,

        [UnitedNationsMembership(1961, 10, 27)]
        [Capital((int)WorldCities.MongoliaUlaanbaatar)]
        [LargestCity((int)WorldCities.MongoliaUlaanbaatar)]
        [PopulationEstimate(3300000)] //3.3 million
        Mongolia,

        [UnitedNationsMembership(2006, 6, 28)]
        [Capital((int)WorldCities.MontenegroPodgorica)]
        [LargestCity((int)WorldCities.MontenegroPodgorica)]
        [PopulationEstimate(620000)]
        Montenegro,

        [UnitedNationsMembership(1956, 11, 12)]
        [Capital((int)WorldCities.MoroccoRabat)]
        [LargestCity((int)WorldCities.MoroccoCasablanca)]
        [PopulationEstimate(37000000)] //37 million
        Morocco,

        [UnitedNationsMembership(1975, 9, 16)]
        [Capital((int)WorldCities.MozambiqueMaputo)]
        [LargestCity((int)WorldCities.MozambiqueMaputo)]
        [PopulationEstimate(33000000)] //33 million
        Mozambique,

        [UnitedNationsMembership(1990, 4, 23)]
        [Capital((int)WorldCities.NamibiaWindhoek)]
        [LargestCity((int)WorldCities.NamibiaWindhoek)]
        [PopulationEstimate(2600000)] //2.6 million
        Namibia,

        [UnitedNationsMembership(1999, 9, 14)]
        [UnofficialCapital((int)WorldCities.NauruYaren)]
        [LargestCity((int)WorldCities.NauruYaren)]
        [PopulationEstimate(10000)]
        Nauru,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.NepalKathmandu)]
        [LargestCity((int)WorldCities.NepalKathmandu)]
        [PopulationEstimate(30000000)] //30 million
        Nepal,

        [UnitedNationsMembership(1945, 12, 10)]
        [Capital((int)WorldCities.NetherlandsAmsterdam)]
        [LargestCity((int)WorldCities.NetherlandsTheHague)]
        [FullName("Kingdom of the Netherlands")]
        [PopulationEstimate(17500000)] //17.5 million
        Netherlands,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.NewZealandWellington)]
        [LargestCity((int)WorldCities.NewZealandAuckland)]
        [PopulationEstimate(5100000)] //5.1 million
        NewZealand,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.NicaraguaManagua)]
        [LargestCity((int)WorldCities.NicaraguaManagua)]
        [PopulationEstimate(6700000)] //6.7 million
        Nicaragua,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.NigerNiamey)]
        [LargestCity((int)WorldCities.NigerNiamey)]
        [PopulationEstimate(25000000)] //25 million
        Niger,

        [UnitedNationsMembership(1960, 10, 7)]
        [Capital((int)WorldCities.NigeriaAbuja)]
        [LargestCity((int)WorldCities.NigeriaLagos)]
        [PopulationEstimate(234600000)] //234.6 million
        Nigeria,

        /// <summary>
        /// Northern Ireland was created in 1921 as a separate entity within the United Kingdom,
        /// with a Protestant majority and a Catholic minority. The partition of Ireland divided
        /// the island into two entities: Northern Ireland (which remained part of the UK) and 
        /// the Republic of Ireland (which became an independent state). For much of the 20th 
        /// century, the conflict in Northern Ireland, known as The Troubles (1968-1998), 
        /// revolved around issues of national identity, with Protestants generally supporting 
        /// unionism (remaining part of the UK) and Catholics generally supporting nationalism 
        /// (joining the Republic of Ireland). The Good Friday Agreement (Belfast Agreement) 
        /// of 1998 helped end the violence of The Troubles, establishing a devolved government
        /// in Northern Ireland and allowing for the possibility of a peaceful unification with 
        /// the Republic of Ireland if there was sufficient support. The Sinn Féin party, 
        /// which is the largest Irish republican party in Northern Ireland, 
        /// has long advocated for Irish unification. In the 2022 Northern Ireland Assembly elections, 
        /// the party became the largest party, signaling a shift toward greater support for nationalism 
        /// and potential unification. The Democratic Unionist Party (DUP) and other unionist 
        /// parties strongly oppose unification and favor Northern Ireland's continued 
        /// membership in the United Kingdom.
        /// </summary>
        [Capital((int)WorldCities.NorthernIrelandBelfast)]
        [LargestCity((int)WorldCities.NorthernIrelandBelfast)]
        [PopulationEstimate(1920400)] //1.92 million
        NorthernIreland,

        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.NorthKoreaPyongyang)]
        [LargestCity((int)WorldCities.NorthKoreaPyongyang)]
        [FullName("Democratic People's Republic of Korea")]
        [PopulationEstimate(25000000)] //25 million
        NorthKorea,

        [UnitedNationsMembership(1993, 4, 8)]
        [Capital((int)WorldCities.NorthMacedoniaSkopje)]
        [LargestCity((int)WorldCities.NorthMacedoniaSkopje)]
        [PopulationEstimate(2100000)] //2.1 million
        NorthMacedonia,

        [UnitedNationsMembership(1945, 11, 27)]
        [Capital((int)WorldCities.NorwayOslo)]
        [LargestCity((int)WorldCities.NorwayOslo)]
        [PopulationEstimate(5400000)] //5.4 million
        Norway,

        [UnitedNationsMembership(1971, 10, 7)]
        [Capital((int)WorldCities.OmanMuscat)]
        [LargestCity((int)WorldCities.OmanMuscat)]
        [PopulationEstimate(4800000)] //4.8 million
        Oman,

        [UnitedNationsMembership(1947, 9, 30)]
        [Capital((int)WorldCities.PakistanIslamabad)]
        [LargestCity((int)WorldCities.PakistanKarachi)]
        [PopulationEstimate(250000000)] //250 million
        Pakistan,

        [UnitedNationsMembership(1994, 12, 15)]
        [Capital((int)WorldCities.PalauNgerulmud)]
        [LargestCity((int)WorldCities.PalauKoror)]
        [PopulationEstimate(18000)]
        Palau,

        /// <summary>
        /// Hamas-controlled area of Palestine
        /// not internationally recognized as an independent country, but it functions as a de 
        /// facto self-governing entity. It is officially considered part of the State of 
        /// Palestine, but since 2007, Hamas has governed Gaza separately from the West Bank, 
        /// which is controlled by Fatah. The ongoing Israel-Gaza conflict and lack of formal 
        /// international recognition keep Gaza from being a fully sovereign state.
        /// </summary>
        [Capital((int)WorldCities.GazaGazaCity)]
        [LargestCity((int)WorldCities.GazaGazaCity)]
        [PopulationEstimate(2000000)] //2 million
        PalestineGaza,

        /// <summary>
        /// west bank area of palestine (~3.19 million Palestinians, 670000 Israeli settlers)
        /// </summary>
        [UnitedNationsMembership(1974, 11, 22)]
        [DeFactoCapital((int)WorldCities.WestBankRamallah)]
        [ClaimedCapital((int)WorldCities.IsraelEastJerusalem)]
        [LargestCity((int)WorldCities.WestBankRamallah)]
        [PopulationEstimate(3800000)] //3.8 million
        PalestineWestBank,

        [UnitedNationsMembership(1945, 11, 13)]
        [Capital((int)WorldCities.PanamaPanamaCity)]
        [LargestCity((int)WorldCities.PanamaPanamaCity)]
        [PopulationEstimate(4300000)] //4.3 million
        Panama,

        [UnitedNationsMembership(1975, 10, 10)]
        [Capital((int)WorldCities.PapuaNewGuineaPortMoresby)]
        [LargestCity((int)WorldCities.PapuaNewGuineaPortMoresby)]
        [PopulationEstimate(9200000)] //9.2 million
        PapuaNewGuinea,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.ParaguayAsunción)]
        [LargestCity((int)WorldCities.ParaguayAsunción)]
        [PopulationEstimate(7300000)] //7.3 million
        Paraguay,

        [UnitedNationsMembership(1945, 10, 31)]
        [Capital((int)WorldCities.PeruLima)]
        [LargestCity((int)WorldCities.PeruLima)]
        [PopulationEstimate(33000000)] //33 million
        Peru,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.PhilippinesManila)]
        [LargestCity((int)WorldCities.PhilippinesQuezonCity)]
        [PopulationEstimate(117730000)] //117.73 million
        Philippines,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.PolandWarsaw)]
        [LargestCity((int)WorldCities.PolandWarsaw)]
        [PopulationEstimate(38000000)] //38 million
        Poland,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.PortugalLisbon)]
        [LargestCity((int)WorldCities.PortugalLisbon)]
        [PopulationEstimate(10300000)] //10.3 million
        Portugal,

        [UnitedNationsMembership(1971, 9, 21)]
        [Capital((int)WorldCities.QatarDoha)]
        [LargestCity((int)WorldCities.QatarDoha)]
        [PopulationEstimate(2900000)] //2.9 million
        Qatar,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.RomaniaBucharest)]
        [LargestCity((int)WorldCities.RomaniaBucharest)]
        [PopulationEstimate(19000000)] //19 million
        Romania,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.RussiaMoscow)]
        [LargestCity((int)WorldCities.RussiaMoscow)]
        [FullName("Russian Federation")]
        [PopulationEstimate(146000000)] //146 million
        Russia,

        [UnitedNationsMembership(1962, 9, 18)]
        [Capital((int)WorldCities.RwandaKigali)]
        [LargestCity((int)WorldCities.RwandaKigali)]
        [PopulationEstimate(14740000)] //14.7 million
        Rwanda,

        [UnitedNationsMembership(1983, 9, 23)]
        [Capital((int)WorldCities.SaintKittsAndNevisBasseterre)]
        [LargestCity((int)WorldCities.SaintKittsAndNevisBasseterre)]
        [PopulationEstimate(55229)]
        SaintKittsAndNevis,

        [UnitedNationsMembership(1979, 9, 18)]
        [Capital((int)WorldCities.SaintLuciaCastries)]
        [LargestCity((int)WorldCities.SaintLuciaCastries)]
        [PopulationEstimate(191029)]
        SaintLucia,

        [UnitedNationsMembership(1980, 9, 16)]
        [Capital((int)WorldCities.SaintVincentAndTheGrenadinesKingstown)]
        [LargestCity((int)WorldCities.SaintVincentAndTheGrenadinesKingstown)]
        [PopulationEstimate(112000)]
        SaintVincentAndTheGrenadines,

        [UnitedNationsMembership(1976, 12, 15)]
        [Capital((int)WorldCities.SamoaApia)]
        [LargestCity((int)WorldCities.SamoaApia)]
        [PopulationEstimate(207000)]
        Samoa,

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.SanMarinoSanMarinoCity)]
        [LargestCity((int)WorldCities.SanMarinoSanMarinoCity)]
        [PopulationEstimate(34000)]
        SanMarino,

        [UnitedNationsMembership(1975, 9, 16)]
        [Capital((int)WorldCities.SãoToméandPríncipeSãoTomé)]
        [LargestCity((int)WorldCities.SãoToméandPríncipeSãoTomé)]
        [PopulationEstimate(247000)]
        SãoToméandPríncipe,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.SaudiArabiaRiyadh)]
        [LargestCity((int)WorldCities.SaudiArabiaJeddah)]
        [PopulationEstimate(37757000)] //37.757 million
        SaudiArabia,

        /// <summary>
        /// Scotland is currently a part of the United Kingdom, but there is a significant independence movement, 
        /// primarily led by the Scottish National Party (SNP). Scotland held a referendum on 
        /// independence in 2014, where 55% voted to stay in the UK. However, since then, the 
        /// SNP has continued to push for another referendum, particularly in light of the 
        /// Brexit vote in 2016 (which Scotland voted against). While the UK government has 
        /// refused to authorize another referendum, the issue of Scottish independence remains 
        /// a central political debate, and public opinion has fluctuated, with some polls 
        /// suggesting growing support for independence.
        /// </summary>
        [Capital((int)WorldCities.ScotlandEdinburgh)]
        [LargestCity((int)WorldCities.ScotlandEdinburgh)]
        [PopulationEstimate(5490100)] //5.49 million
        Scotland,
        
        [UnitedNationsMembership(1960, 9, 28)]
        [Capital((int)WorldCities.SenegalDakar)]
        [LargestCity((int)WorldCities.SenegalDakar)]
        [PopulationEstimate(20072000)] //20.072 million
        Senegal,

        [UnitedNationsMembership(2000, 11, 1)]
        [Capital((int)WorldCities.SerbiaBelgrade)]
        [LargestCity((int)WorldCities.SerbiaBelgrade)]
        [PopulationEstimate(6782000)] //6.782 milllion
        Serbia,

        [UnitedNationsMembership(1976, 9, 21)]
        [Capital((int)WorldCities.SeychellesVictoria)]
        [LargestCity((int)WorldCities.SeychellesVictoria)]
        [PopulationEstimate(96000)]
        Seychelles,

        [UnitedNationsMembership(1961, 9, 27)]
        [Capital((int)WorldCities.SierraLeoneFreetown)]
        [LargestCity((int)WorldCities.SierraLeoneFreetown)]
        [PopulationEstimate(9042000)] //9.042 million
        SierraLeone,

        /// <summary>
        /// city-state
        /// </summary>
        [UnitedNationsMembership(1965, 9, 21)]
        [Capital((int)WorldCities.SingaporeSingapore)]
        [LargestCity((int)WorldCities.SingaporeSingapore)]
        [PopulationEstimate(6129000)] //6.129 million
        Singapore,

        [UnitedNationsMembership(1993, 1, 19)]
        [Capital((int)WorldCities.SlovakiaBratislava)]
        [LargestCity((int)WorldCities.SlovakiaBratislava)]
        [PopulationEstimate(5402000)] //5.402 million
        Slovakia,

        [UnitedNationsMembership(1992, 5, 22)]
        [Capital((int)WorldCities.SloveniaLjubljana)]
        [LargestCity((int)WorldCities.SloveniaLjubljana)]
        [PopulationEstimate(2063000)] //2.063 million
        Slovenia,

        [UnitedNationsMembership(1978, 9, 19)]
        [Capital((int)WorldCities.SolomanIslandsHoniara)]
        [LargestCity((int)WorldCities.SolomanIslandsHoniara)]
        [PopulationEstimate(721000)]
        SolomonIslands,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.SomaliaMogadishu)]
        [LargestCity((int)WorldCities.SomaliaMogadishu)]
        [PopulationEstimate(19216000)] //19.216 million
        Somalia,

        [UnitedNationsMembership(1945, 11, 7)]
        [AdministrativeCapital((int)WorldCities.SouthAfricaPretoria)]
        [LegislativeCapital((int)WorldCities.SouthAfricaCapeTown)]
        [JudicialCapital((int)WorldCities.SouthAfricaBloemfontein)]
        [LargestCity((int)WorldCities.SouthAfricaJohannesburg)]
        [PopulationEstimate(62781000)] //62.781 million
        SouthAfrica,

        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.SouthKoreaSeoul)]
        [LargestCity((int)WorldCities.SouthKoreaSeoul)]
        [FullName("Republic of Korea")]
        [PopulationEstimate(52789000)] //52.789 million
        SouthKorea,

        [UnitedNationsMembership(2011, 7, 14)]
        [Capital((int)WorldCities.SouthSudanJuba)]
        [LargestCity((int)WorldCities.SouthSudanJuba)]
        [PopulationEstimate(15761000)] //15.761 million
        SouthSudan,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.SpainMadrid)]
        [LargestCity((int)WorldCities.SpainMadrid)]
        [PopulationEstimate(46324000)] //46.324 million
        Spain,

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.SriLankaSriJayawardenepuraKotte)]
        [LargestCity((int)WorldCities.SriLankaColombo)]
        [PopulationEstimate(21837000)]
        SriLanka,

        [UnitedNationsMembership(1956, 11, 12)]
        [Capital((int)WorldCities.SudanKhartoum)]
        [LargestCity((int)WorldCities.SudanKhartoum)]
        [PopulationEstimate(50141000)] //50.141 million
        Sudan,

        [UnitedNationsMembership(1975, 12, 4)]
        [Capital((int)WorldCities.SurinameParamaribo)]
        [LargestCity((int)WorldCities.SurinameParamaribo)]
        [PopulationEstimate(603000)]
        Suriname,

        [UnitedNationsMembership(1968, 9, 24)]
        [AdministrativeCapital((int)WorldCities.SwazilandMbabane)]
        [LegislativeCapital((int)WorldCities.SwazilandLobamba)]
        [RoyalCapital((int)WorldCities.SwazilandLobamba)]
        [LargestCity((int)WorldCities.SwazilandManzini)]
        [LocalName("Eswatini")]
        [PopulationEstimate(1578000)] //1.578 million
        Swaziland,

        [UnitedNationsMembership(1946, 11, 19)]
        [Capital((int)WorldCities.SwedenStockholm)]
        [LargestCity((int)WorldCities.SwedenStockholm)]
        [PopulationEstimate(10586000)] //10.586 million
        Sweden,

        [UnitedNationsMembership(2002, 9, 10)]
        [Capital((int)WorldCities.SwitzerlandBern)]
        [LargestCity((int)WorldCities.SwitzerlandZurich)]
        [PopulationEstimate(8986000)]
        Switzerland,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.SyriaDamascus)]
        [LargestCity((int)WorldCities.SyriaDamascus)]
        [FullName("Syrian Arab Republic")]
        [PopulationEstimate(24212000)] //24.212 million
        Syria,

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.TajikistanDushanbe)]
        [LargestCity((int)WorldCities.TajikistanDushanbe)]
        [PopulationEstimate(10530000)]
        Tajikistan,

        [UnitedNationsMembership(1961, 12, 14)]
        [Capital((int)WorldCities.TanzaniaDodoma)]
        [LargestCity((int)WorldCities.TanzaniaDaresSalaam)]
        [FullName("United Republic of Tanzania")]
        [PopulationEstimate(74794000)] //74.794 million
        Tanzania,

        [UnitedNationsMembership(1946, 12, 15)]
        [Capital((int)WorldCities.ThailandBangkok)]
        [LargestCity((int)WorldCities.ThailandBangkok)]
        [PopulationEstimate(71950000)] //71.95 million
        Thailand,

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.TogoLomé)]
        [LargestCity((int)WorldCities.TogoLomé)]
        [PopulationEstimate(9625000)] //9.625 million
        Togo,

        [UnitedNationsMembership(1999, 9, 14)]
        [Capital((int)WorldCities.TongaNukualofa)]
        [LargestCity((int)WorldCities.TongaNukualofa)]
        [PopulationEstimate(117000)]
        Tonga,

        [UnitedNationsMembership(1962, 9, 18)]
        [Capital((int)WorldCities.TrinidadAndTobagoPortofSpain)]
        [LargestCity((int)WorldCities.TrinidadAndTobagoSanFernando)]
        [PopulationEstimate(1380000)]
        TrinidadAndTobago,

        [UnitedNationsMembership(1956, 11, 12)]
        [Capital((int)WorldCities.TunisiaTunis)]
        [LargestCity((int)WorldCities.TunisiaTunis)]
        [PopulationEstimate(12523000)]
        Tunisia,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.TurkeyAnkara)]
        [LargestCity((int)WorldCities.TurkeyIstanbul)]
        [LocalName("Türkiye")]
        [PopulationEstimate(86538000)] //86.538 million
        Turkey,

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.TurkmenistanAshgabat)]
        [LargestCity((int)WorldCities.TurkmenistanAshgabat)]
        [PopulationEstimate(6502000)]
        Turkmenistan,

        [UnitedNationsMembership(2000, 9, 5)]
        [Capital((int)WorldCities.TuvaluFunafuti)]
        [LargestCity((int)WorldCities.TuvaluFunafuti)]
        [PopulationEstimate(12000)]
        Tuvalu,

        [UnitedNationsMembership(1962, 10, 25)]
        [Capital((int)WorldCities.UgandaKampala)]
        [LargestCity((int)WorldCities.UgandaKampala)]
        [PopulationEstimate(56769000)] //56.769 million
        Uganda,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.UkraineKiev)]
        [LargestCity((int)WorldCities.UkraineKiev)]
        [PopulationEstimate(42472000)]
        Ukraine,

        [UnitedNationsMembership(1971, 12, 9)]
        [Capital((int)WorldCities.UnitedArabEmiratesAbuDhabi)]
        [LargestCity((int)WorldCities.UnitedArabEmiratesDubai)]
        [PopulationEstimate(10560000)] //10.560 million
        UnitedArabEmirates,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.EnglandLondon)]
        [LargestCity((int)WorldCities.EnglandLondon)]
        [FullName("United Kingdom of Great Britain and Northern Ireland")]
        [PopulationEstimate(69111000)] //69.111 million
        UnitedKingdom,

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.UnitedStatesWashingtonDC)]
        [LargestCity((int)WorldCities.UnitedStatesNewYorkCity)]
        [FullName("United States of America")]
        [PopulationEstimate(341145670)]
        UnitedStates,

        [UnitedNationsMembership(1945, 12, 18)]
        [Capital((int)WorldCities.UruguayMontevideo)]
        [LargestCity((int)WorldCities.UruguayMontevideo)]
        [PopulationEstimate(3559000)] //3.559 million
        Uruguay,

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.UzbekistanTashkent)]
        [LargestCity((int)WorldCities.UzbekistanTashkent)]
        [PopulationEstimate(35311000)] //35.311 million
        Uzbekistan,

        [UnitedNationsMembership(1981, 9, 15)]
        [Capital((int)WorldCities.VanuatuPortVila)]
        [LargestCity((int)WorldCities.VanuatuPortVila)]
        [PopulationEstimate(330000)]
        Vanuatu,

        /// <summary>
        /// Holy See holds sovereignty over Vatican City
        /// gained all rights of full UN membership except voting on 2004-07-01
        /// </summary>
        [UnitedNationsMembership(1964, 4, 6)]
        [PopulationEstimate(764)]
        [FullName("Holy See")]
        VaticanCity,

        [UnitedNationsMembership(1945, 11, 15)]
        [Capital((int)WorldCities.VenezuelaCaracas)]
        [LargestCity((int)WorldCities.VenezuelaCaracas)]
        [FullName("Bolivarian Republic of Venezuela")]
        [PopulationEstimate(35396000)] //35.396 million
        Venezuela,

        [UnitedNationsMembership(1977, 9, 20)]
        [Capital((int)WorldCities.VietnamHanoi)]
        [LargestCity((int)WorldCities.VietnamHoChiMinhCity)]
        [PopulationEstimate(100918000)] //100.918 million
        Vietnam,

        /// <summary>
        /// de facto capital is Aden since the Houthi's control Sana'a
        /// </summary>
        [UnitedNationsMembership(1947, 9, 30)]
        [Capital((int)WorldCities.YemenSanaa)]
        [DeFactoCapital((int)WorldCities.YemenAden)]
        [LargestCity((int)WorldCities.YemenSanaa)]
        [PopulationEstimate(34218000)] //34.218 million
        Yemen,

        [FullName("Democratic Republic of the Congo")]
        [Abbreviation("DRC")]
        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.ZaireKinshasa)]
        [LargestCity((int)WorldCities.ZaireKinshasa)]
        [PopulationEstimate(107343000)] //107.343 million
        Zaire,

        [UnitedNationsMembership(1964, 12, 1)]
        [Capital((int)WorldCities.ZambiaLusaka)]
        [LargestCity((int)WorldCities.ZambiaLusaka)]
        [PopulationEstimate(22219000)] //22.219 million
        Zambia,

        [UnitedNationsMembership(1980, 8, 25)]
        [Capital((int)WorldCities.ZimbabweHarare)]
        [LargestCity((int)WorldCities.ZimbabweHarare)]
        [PopulationEstimate(19956000)] //19.956 million
        Zimbabwe,
    }

    public static class CountryLikeThingsThatAreNotCountries
    {
        /// <summary>
        /// In 2008, Kosovo declared independence from Serbia, but Serbia does not recognize it 
        /// as an independent state and still claims it as part of its territory.
        /// To be a fully recognized country, Kosovo would need UN membership, which requires 
        /// approval from the UN Security Council (currently blocked by Russia and China)
        /// Some key countries do not recognize Kosovo, including India/Brazil.
        /// Within the EU, five member states do not recognize Kosovo due to concerns with their
        /// own separatist movements (Spain, Greece, Slovakia, Romania, and Cyprus).
        /// Kosovo has been recognized by International Monetary Fund (IMF) and the World Bank
        /// </summary>
        [Capital((int)WorldCities.KosovoPristina)]
        [LargestCity((int)WorldCities.KosovoPristina)]
        [PopulationEstimate(1800000)] //1.8 million
        public static class Kosovo { }

        /// <summary>
        /// Taiwan has functioned as an independent state since 1949 when ROC government
        /// retreated to the island after losing the Chinese Civil War
        /// In 1971, China's UN seat transferred from ROC to PRC.
        /// China (PRC) considers it a breakaway province, insisting on "One China", and 
        /// pressures other countries not to recognize it, and blocks UN membership
        /// Only about 12-13 countries (mostly small nations like Paraguay, Palau, and the 
        /// Vatican) recognize Taiwan diplomatically.
        /// Most other nations (including the U.S. and Japan) engage with Taiwan unofficially 
        /// through trade, defense cooperation, and informal diplomatic relations.
        /// Taiwan’s government officially calls itself the Republic of China (ROC) and has never 
        /// formally declared full independence, partly to avoid provoking a military response 
        /// from China.
        /// Some Taiwanese politicians favor formal independence, while others prefer to maintain 
        /// the current ambiguous status to prevent conflict.
        /// </summary>
        [Capital((int)WorldCities.TaiwanTaipei)]
        [LargestCity((int)WorldCities.TaiwanTaipei)]
        [PopulationEstimate(23500000)] //23.5 million
        public static class Taiwan { }

        /// <summary>
        /// Somaliland declared independence unilaterally on May 18, 1991, following the collapse 
        /// of the Somali government. Somalia still claims Somaliland as part of its territory 
        /// and strongly opposes its independence.
        /// No UN member state or major international organization recognizes Somaliland as an 
        /// independent country.
        /// The African Union (AU) opposes recognizing breakaway states, fearing it could 
        /// encourage separatist movements in other African countries.
        /// Somaliland operates as an independent country in practice:
        /// 1. It has its own democratically elected government and functions separately from Somalia.
        /// 2. It maintains its own military and security forces.
        /// 3. It has an independent economy, uses the Somaliland shilling, and trades with neighboring 
        /// countries.
        /// 4. Somaliland has been relatively peaceful and stable for over 30 years.
        /// </summary>
        [Capital((int)WorldCities.SomalilandHargeisa)]
        [LargestCity((int)WorldCities.SomalilandHargeisa)]
        [PopulationEstimate(4500000)] //4.5 million
        public static class Somaliland { }

        /// <summary>
        /// Abkhazia has a distinct ethnic identity, with the Abkhaz people being its primary 
        /// ethnic group, with a long history of autonomous status within Georgia.
        /// declared independence from Georgia following the 1990s conflicts, particularly 
        /// after the collapse of the Soviet Union. Not internationally recognized 
        /// as an independent country, except by Russia, and a few other countries that follow 
        /// Russia's lead (such as Nicaragua, Venezuela, and a few others). Georgia, along with
        /// most of the international community, considers tit to be part of Georgian territory.
        /// relies heavily on Russian support, both in terms of military and economic aid.
        /// Russian military presence is significant.
        /// </summary>
        [Capital((int)WorldCities.AbkhaziaSukhumi)]
        [LargestCity((int)WorldCities.AbkhaziaSukhumi)]
        [PopulationEstimate(250000)] //250,000
        public static class Abkhazia { }

        /// <summary>
        /// Post-Spanish-Colonial-Withdrawal, Sahrawi Arab Democratic Republic (SADR), led by the 
        /// Polisario Front, declared independence.
        /// Morocco annexed most of Western Sahara and continues to control about 80% of the 
        /// territory today, considering it as "Southern Provinces".
        /// Western Sahara is not a UN member state, and the UN does not recognize Moroccan 
        /// sovereignty over the region.
        /// About 40 countries have recognized SADR at some point, but many later withdrew or
        /// froze recognition. The African Union (AU) recognizes the SADR, but the UN and most countries 
        /// do not. Countries with close ties to Morocco avoid recognizing Western Sahara’s independence.
        /// The UN has maintained a peacekeeping mission (MINURSO) since 1991 to oversee a potential referendum on 
        /// independence. No referendum has taken place due to disputes over voter eligibility.
        /// Morocco has proposed autonomy under Moroccan sovereignty, while the Polisario Front 
        /// insists on full independence.
        /// </summary>
        [DeFactoCapital((int)WorldCities.WesternSaharaLaayoune)] //under Moroccan control
        [ClaimedCapital((int)WorldCities.WesternSaharaBirLehlou)] //not under Moroccan control
        [PopulationEstimate(600000)] //600,000
        public static class WesternSahara { }

        /// <summary>
        /// Transnistria declared independence from Moldova in 1990, following the collapse of 
        /// the Soviet Union, but it has never been recognized by any UN member state.
        /// It calls itself the Pridnestrovian Moldavian Republic (PMR) and has its own government, 
        /// military, and currency (the Transnistrian ruble). Moldova considers Transnistria to 
        /// be part of its territory, and the international community largely recognizes 
        /// Transnistria as part of Moldova. The region is heavily supported by Russia, which 
        /// provides political, economic, and military backing, but Russia does not officially 
        /// recognize Transnistria as an independent state. Transnistria has a Russian-speaking 
        /// majority and has maintained strong political, economic, and military ties to Russia, 
        /// further complicating its relationship with Moldova and the international community.
        /// </summary>
        [Capital((int)WorldCities.TransnistriaTiraspol)]
        [LargestCity((int)WorldCities.TransnistriaTiraspol)]
        [PopulationEstimate(500000)] //500,000
        public static class Transnistria { }

        /// <summary>
        /// Nagorno-Karabakh declared independence from Azerbaijan in 1991, following the collapse 
        /// of the Soviet Union. The region's Armenian-majority population sought to break away 
        /// from Azerbaijan, which led to a bloody conflict. Despite declaring independence, 
        /// Nagorno-Karabakh is not internationally recognized as a sovereign state by any 
        /// country, including Armenia, which only offers strong political, economic, and 
        /// military support. The Republic of Nagorno-Karabakh (Artsakh) is not recognized by 
        /// the United Nations and is considered by most of the world to be part of Azerbaijan.
        /// Nagorno-Karabakh is considered an autonomous region of Azerbaijan by international 
        /// law, but it operates like an independent country on the ground, with its own 
        /// government, parliament, and president.
        /// Nagorno-Karabakh maintains its own military forces, largely made up of ethnic
        /// Armenians, which fought against Azerbaijan in the 1990s and 2016 clashes, and 
        /// participated in the 2020 Nagorno-Karabakh War. Armenia is believed to provide military 
        /// support to Nagorno-Karabakh, including training, arms supplies, and troops.
        /// Azerbaijan, on the other hand, has a strong military and continues to assert control 
        /// over the region, leading to frequent outbreaks of conflict. The 2020 Nagorno-Karabakh 
        /// War was a six-week conflict between Armenia and Azerbaijan. The war resulted in 
        /// significant Azerbaijani territorial gains and a ceasefire agreement brokered by Russia.
        /// </summary>
        [ClaimedCapital((int)WorldCities.ArtsakhStepanakert)]
        [LargestCity((int)WorldCities.ArtsakhStepanakert)]
        [PopulationEstimate(160000)]
        public static class Artsakh { }
        
        /// <summary>
        /// tied to the Ossetian people, who are ethnically and culturally related to the Ossetians in Russia’s 
        /// North Ossetia-Alania region. Acts as a buffer zone between Russia and Georgia.
        /// Russian military presence in South Ossetia is not as extensive as Abkhazia.
        /// </summary>
        [Capital((int)WorldCities.SouthOssetiaTskhinvali)]
        [LargestCity((int)WorldCities.SouthOssetiaTskhinvali)]
        [PopulationEstimate(60000)] //60,000
        public static class SouthOssetia { }
    }

    public static class LessCountryLikeThings
    {
        /// <summary>
        /// an autonomous community within Spain, with significant powers under the Statute of 
        /// Autonomy and the Spanish Constitution, has its own parliament, president, and 
        /// government (Generalitat de Catalunya), but its powers are limited by the Spanish 
        /// constitution, which defines Spain as a unitary state.
        /// Catalonia has pushed for independence through various referendums and political
        /// movements, especially since the 2000s. In 2017, Catalonia held a unilateral referendum 
        /// on independence, which was declared illegal by Spain's Constitutional Court.
        /// The Catalan government declared independence following the referendum, but the 
        /// Spanish government quickly rejected the declaration, dissolved the Catalan 
        /// parliament, and imposed direct rule through Article 155 of the Spanish Constitution.
        /// </summary>
        [Capital((int)WorldCities.SpainBarcelona)]
        [LargestCity((int)WorldCities.SpainBarcelona)]
        public static class Catalonia { }

        /// <summary>
        /// Flanders, the Dutch-speaking region in the northern part of Belgium, has a long 
        /// history of seeking greater autonomy from the French-speaking southern region of 
        /// Wallonia. This desire for autonomy grew after Belgium's creation in 1830, as 
        /// linguistic and economic differences between the Dutch-speaking Flemings and 
        /// French-speaking Walloons became more pronounced. The Belgian Constitution and political 
        /// system have evolved to give Flanders significant autonomy, but the movement for 
        /// greater independence or a more federal structure has remained prominent.
        /// The New Flemish Alliance (N-VA) is the largest political party advocating for Flemish 
        /// independence or greater autonomy. The party is a key player in the Flemish nationalist 
        /// movement and supports the creation of a confederation in which Flanders would have 
        /// greater control over its own affairs, potentially leading to full independence. 
        /// Other political parties, such as the Flemish Interest (Vlaams Belang), also advocate 
        /// for Flemish independence but with a more hardline stance. While these 
        /// independence-minded parties have gained significant support, they face opposition 
        /// from more centralist parties that seek to maintain Belgium’s unitary structure and 
        /// keep the country united, including the French-speaking parties of Wallonia.
        /// </summary>
        [LargestCity((int)WorldCities.BelgiumAntwerp)]
        public static class Flanders { }

        /// <summary>
        /// The Basque Country is a region with both parts in Spain and France, and it has a long 
        /// history of nationalist sentiment and separatism. In Spain, the region has significant 
        /// autonomy, with the Basque Autonomous Community having its own government and police 
        /// force. The ETA (Euskadi Ta Askatasuna), a Basque separatist group, was active in the 
        /// late 20th century and early 2000s, advocating for independence through violence. 
        /// The group officially disbanded in 2018. The political party EH Bildu advocates for 
        /// Basque independence, though public support for full independence is mixed. There is 
        /// also a desire for greater autonomy for the Basque regions in both Spain and France.
        /// </summary>
        [LargestCity((int)WorldCities.SpainBilbao)]
        public static class BasqueCountry { }

        public static class Italy
        {
            /// <summary>
            /// Veneto and Lombardy are two wealthy regions in northern Italy where regionalist 
            /// movements have pushed for greater autonomy or even independence. In 2017, both Veneto 
            /// and Lombardy held referenda on autonomy, with over 90% of voters in both regions 
            /// supporting the idea of more independence from the central Italian government. 
            /// However, these referenda were non-binding. The League (Lega Nord) party, which 
            /// historically supported independence for northern Italy, has evolved towards more 
            /// federalism rather than full secession. However, the desire for greater autonomy 
            /// remains significant in these regions.
            /// </summary>
            [Capital((int)WorldCities.ItalyVenice)]
            [LargestCity((int)WorldCities.ItalyVerona)]
            public static class Veneto { }
            [Capital((int)WorldCities.ItalyMilan)]
            [LargestCity((int)WorldCities.ItalyMilan)]
            public static class Lombardy { }

            /// <summary>
            /// Sardinia, an island off the coast of Italy, has seen several regionalist and 
            /// independence movements. Sardinia has its own distinct cultural identity, and 
            /// while the independence movement is not as strong as in other regions of Italy, 
            /// there have been periodic calls for greater autonomy or full independence.
            /// Political groups such as the Sardinian Action Party have called for Sardinian 
            /// independence or federalism within Italy. While support for full independence 
            /// remains relatively low, the desire for greater autonomy continues.
            /// </summary>
            [Capital((int)WorldCities.ItalyCagliari)]
            [LargestCity((int)WorldCities.ItalyCagliari)]
            public static class Sardinia { }
        }

        public static class France
        {
            /// <summary>
            /// Corsica, a French island, has long had a separatist movement, with a desire for 
            /// autonomy or independence. The FLNC (National Front for the Liberation of Corsica) 
            /// was an armed separatist group that sought independence through violent means but 
            /// officially disbanded in 2014. Corsican nationalism now focuses more on cultural 
            /// and political autonomy rather than full independence. The Corsican Nationalist 
            /// Party, Femu a Corsica, advocates for greater self-governance, including 
            /// recognition of the Corsican language and more economic control. While full 
            /// independence is not universally supported, the desire for autonomy remains strong.
            /// </summary>
            [Capital((int)WorldCities.FranceAjaccio)]
            [LargestCity((int)WorldCities.FranceAjaccio)]
            public static class Corsica { }
        }

        public static class Denmark
        {
            /// <summary>
            /// Greenland is an autonomous territory of Denmark, with its own government, but it 
            /// remains part of the Kingdom of Denmark. Greenland has had increasing calls for full 
            /// independence, especially in recent years as the Greenlandic government has sought 
            /// more control over its natural resources and economic affairs. The issue has gained 
            /// traction due to climate change and Greenland's importance in global geopolitics.
            /// While full independence has not yet been achieved, there has been growing support for 
            /// greater self-determination. In 2009, Greenland's Home Rule Act gave the region more 
            /// autonomy, and a referendum on independence could take place in the future, depending 
            /// on political developments.
            /// </summary>
            [Capital((int)WorldCities.GreenlandNuuk)]
            [LargestCity((int)WorldCities.GreenlandNuuk)]
            public static class Greenland { }

            /// <summary>
            /// The Faroe Islands are an autonomous territory of Denmark, with a self-governing parliament.
            /// While there is no immediate push for independence, the Faroe Islands have continued 
            /// to develop as an autonomous region, and there are periodic discussions about full 
            /// independence. The Independence Party in the Faroe Islands advocates for a future 
            /// referendum on independence, although the majority of the population still favors 
            /// maintaining ties with Denmark, at least for the time being.
            /// </summary>
            [Capital((int)WorldCities.FaroeIslandsTórshavn)]
            [LargestCity((int)WorldCities.FaroeIslandsTórshavn)]
            public static class FaroeIslands { }
        }

        public static class Kurdistan
        {
            /// <summary>
            /// The Kurdish population in Turkey is estimated to be around 15-20 million, 
            /// making up about 20% of the country’s total population. Kurds in Turkey live mainly 
            /// in the southeastern region, which is often referred to as "Kurdish-majority areas".
            /// However, Turkey does not officially recognize the existence of a Kurdish region 
            /// or a Kurdish state within its borders. The Kurdistan Workers’ Party (PKK), which 
            /// has been involved in an armed insurgency against the Turkish state since the 1980s, 
            /// has called for greater autonomy or independence for Kurds in Turkey. The PKK has 
            /// been labeled a terrorist organization by Turkey, the U.S., and the EU. While there 
            /// is no official Kurdish autonomy in Turkey, some local governance areas have seen 
            /// Kurdish political representation. The HDP (People’s Democratic Party), a left-wing 
            /// Turkish political party with Kurdish support, has been a key advocate for Kurdish 
            /// rights and greater autonomy. Turkey's constitution and laws oppose the recognition 
            /// of Kurdish as an official language, though Kurdish culture and language are 
            /// increasingly accepted in some urban areas.
            /// </summary>
            [LargestCity((int)WorldCities.TurkeyDiyarbakır)]
            public static class Turkey { }

            /// <summary>
            /// Kurdish Population: Kurds in Syria number around 2-3 million, making up about
            /// 10-15% of the Syrian population. Rojava (also known as Syrian Kurdistan) is a 
            /// Kurdish-majority region in northern Syria. In the wake of Syria’s civil war, 
            /// Kurdish forces (the YPG and YPJ) took control of large parts of northern Syria, 
            /// particularly in the regions of Afrin, Kobani, and Jazira. The Kurdish region in 
            /// Syria declared autonomy and established a system of self-rule in these areas, 
            /// although it is not officially recognized by the Syrian government or other 
            /// international actors. It operates under a decentralized system with autonomous 
            /// Kurdish governance, focusing on democratic confederalism, which is based on local 
            /// councils and cooperatives. The region has faced challenges from both Syria and 
            /// neighboring countries like Turkey, which sees Kurdish forces (especially the YPG) 
            /// as linked to the PKK. Turkey has carried out several military operations in 
            /// northern Syria, especially in areas like Afrin, to push back against Kurdish 
            /// influence.
            /// </summary>
            [LargestCity((int)WorldCities.SyriaQamishli)]
            public static class RojavaInsideSyria { }

            /// <summary>
            /// The Kurdish population in Iraq is about 6-7 million, around 15-20% of Iraq’s total population.
            /// Iraqi Kurdistan is the most established Kurdish region in the Middle East in terms 
            /// of autonomy. The Kurdish Regional Government (KRG), based in Erbil, governs an 
            /// autonomous Kurdish-controlled region in the northern part of Iraq. Since the 1990s, 
            /// and particularly after the fall of Saddam Hussein’s regime in 2003, Iraq’s 
            /// constitution recognizes Iraqi Kurdistan as an autonomous region with its own 
            /// parliament, military (Peshmerga), and budget. In 2017, the KRG held a referendum on
            /// independence, in which the vast majority of voters supported secession. However, 
            /// the vote was opposed by the Iraqi government, neighboring countries (Turkey and 
            /// Iran), and international powers. As a result, Iraq’s central government regained 
            /// some control over disputed territories (such as Kirkuk), but Iraqi Kurdistan 
            /// continues to function with significant autonomy.
            /// </summary>
            [LargestCity((int)WorldCities.IraqErbil)]
            public static class Iraq { }

            /// <summary>
            /// Iran is home to about 8-10 million Kurds, making up roughly 10% of Iran's population.
            /// Kurds in Iran mostly live in the northwestern provinces, including Kurdistan, 
            /// Kermanshah, and West Azerbaijan. Kurds in Iran have faced significant repression 
            /// and are not granted official autonomy. There is no recognized Kurdish political 
            /// entity or autonomous region within Iran. The Kurdish Democratic Party of Iran 
            /// (KDPI) and the PJAK (Party for a Free Life in Kurdistan), both of which seek 
            /// Kurdish rights and autonomy, operate from the Iraqi Kurdish region but face 
            /// repression inside Iran. The Iranian government maintains a strict stance against 
            /// any movement toward Kurdish independence and views such movements as separatist 
            /// threats. Kurdish political groups in Iran often face military and political 
            /// crackdowns.
            /// </summary>
            [LargestCity((int)WorldCities.IranSanandaj)]
            public static class Iran { }
        }

        /// <summary>
        /// National Movement for the Liberation of Azawad (MNLA), a Tuareg separatist group, declared the independence of Azawad in April 2012. 
        /// Islamist groups took over the region by mid-2012 (Ansar Dine, Al-Qaeda in the Islamic Maghreb (AQIM), and the Movement for 
        /// Oneness and Jihad in West Africa (MOJWA))
        /// In January 2013, at the request of the Malian government, French military forces intervened in Mali to help regain control 
        /// of the northern regions from Islamist militant groups. This intervention, known as Operation Serval, was later succeeded 
        /// by Operation Barkhane and supported by a UN peacekeeping mission (MINUSMA).
        /// The region remains under the official jurisdiction of the Malian government, but the security situation is volatile.
        /// </summary>
        public static class Azawad { }

        /// <summary>
        /// 1995 Referendum: The Yes side (for independence) lost by a narrow margin of 50.6% to 
        /// 49.4%, but the result showed that separatist sentiment remained strong.
        /// Polls today show that public support for independence hovers at around 30-35%.
        /// Quebec’s French language and distinct culture remain central to the province’s 
        /// identity. However, the separatist movement now focuses more on cultural preservation 
        /// and self-governance rather than a complete break from Canada. Bill 101 (the Charter of 
        /// the French Language) continues to be an important piece of legislation that ensures 
        /// French remains the dominant language in Quebec's public life. Most Quebecers today 
        /// prefer to stay within Canada but with increased powers for Quebec. The focus has 
        /// shifted from secession to federal reform, including calls for Quebec to have more 
        /// control over areas like immigration, taxation, and natural resources. The CAQ government 
        /// has emphasized Quebec's autonomy within the Canadian federation, prioritizing nationalism 
        /// and cultural preservation while not advocating for outright separation.
        /// </summary>
        [Capital((int)WorldCities.CanadaQuebecCity)]
        [LargestCity((int)WorldCities.CanadaMontreal)]
        public static class Quebec { }

        /// <summary>
        /// Public support for full independence has always been a minority viewpoint. 
        /// Historically, it has never exceeded 5-10% in polls, and the most popular choices 
        /// among Puerto Ricans have been statehood or the maintenance of the current commonwealth 
        /// status. In recent years, however, the question of Puerto Rico’s status has come to the 
        /// forefront due to issues like economic challenges, financial debt, and disaster recovery 
        /// (e.g., following Hurricane Maria in 2017). Political and social activism in Puerto Rico, 
        /// particularly among the younger population, has become more visible, with more people calling 
        /// for greater self-determination or for addressing the territorial status more decisively, but
        /// full independence remains a minority stance.
        /// </summary>
        [Capital((int)WorldCities.PuertoRicoSanJuan)]
        [LargestCity((int)WorldCities.PuertoRicoSanJuan)]
        public static class PuertoRico { }

        /// <summary>
        /// considers itself an autonomous state within Somalia
        /// recognizes the Somali federal government, but it operates with its own government, 
        /// security forces, and administration.
        /// has border disputes with Somaliland, especially over the Sool, Sanaag, and Cayn regions.
        /// </summary>
        [Capital((int)WorldCities.SomaliaGarowe)]
        [LargestCity((int)WorldCities.SomaliaGarowe)]
        public static class Puntland { }
    }

    /// <summary>
    /// western sahara is on the list but covered above
    /// </summary>
    public static class UNNonSelfGoverningTerritories
    {
        public static class FranceOVerseasCollectivities
        {
            /// <summary>
            /// New Caledonia has been on the UN list since 1946. It has a high degree of autonomy 
            /// but remains a French territory. In recent years, there have been referenda on 
            /// independence (2018, 2020), with the majority voting to stay with France, but a 
            /// new vote is expected in the future. The Kanak independence movement seeks full 
            /// sovereignty, but the region is politically divided between those in favor of 
            /// independence and those wishing to remain part of France.
            /// </summary>
            [Capital((int)WorldCities.NewCaledoniaNouméa)]
            [PopulationEstimate(252000)]
            public static class NewCaledonia { }

            /// <summary>
            /// French Polynesia has a unique political status within France, with autonomy over 
            /// its internal affairs, although France maintains control over defense, foreign 
            /// affairs, and security. The territory has local autonomy but is still listed by the 
            /// UN as non-self-governing. While there are pro-independence movements, French 
            /// Polynesia has not held a referendum on independence, and the political atmosphere 
            /// leans toward maintaining the relationship with France.
            /// </summary>
            [Capital((int)WorldCities.FrenchPolynesiaPapeete)]
            [PopulationEstimate(271000)]
            public static class FrenchPolynesia { }
        }

        public static class UnitedKingdomBritishOverseasTerritories
        {
            /// <summary>
            /// Bermuda is an autonomous territory, but its defense and foreign affairs are 
            /// managed by the United Kingdom. It has a parliamentary system and exercises 
            /// self-governance in most internal matters. There are pro-independence groups in 
            /// Bermuda, though full independence has not been pursued in any serious capacity, 
            /// and the current relationship with the UK is seen as beneficial by the majority.
            /// </summary>
            [Capital((int)WorldCities.BermudaHamilton)]
            [PopulationEstimate(62000)]
            public static class Bermuda { }

            /// <summary>
            /// The Cayman Islands has a high degree of self-governance, with a local government 
            /// and parliament. The UK retains control over matters of defense, foreign affairs, 
            /// and internal security. The Cayman Islands is listed as a non-self-governing 
            /// territory due to its continued dependence on the UK for certain key matters.
            /// </summary>
            [Capital((int)WorldCities.CaymanIslandsGeorgeTown)]
            [PopulationEstimate(55500)]
            public static class CaymanIslands { }

            /// <summary>
            /// Gibraltar is a small territory located at the southern tip of the Iberian 
            /// Peninsula. It has self-governance over most internal affairs, but the UK manages 
            /// its defense and foreign relations. Spain claims sovereignty over the territory, 
            /// which has led to long-standing political tensions. The Gibraltarians overwhelmingly 
            /// voted in favor of remaining a British territory in referenda, and there is no 
            /// strong independence movement, though the question of its status remains an ongoing 
            /// diplomatic issue, especially in the context of Brexit.
            /// </summary>
            [Capital((int)WorldCities.GibraltarGibraltar)]
            [PopulationEstimate(29752)]
            public static class Gibraltar { }

            /// <summary>
            /// The Falkland Islands are an archipelago in the South Atlantic Ocean. They have a 
            /// high degree of self-governance, but the UK retains control over defense, foreign
            /// policy, and internal security. The Argentine government claims sovereignty over 
            /// the islands, leading to a long-standing dispute. The islands' population 
            /// overwhelmingly favors maintaining the British connection, with a strong sentiment 
            /// against Argentine sovereignty claims. However, their non-self-governing status 
            /// remains contentious in international diplomacy.
            /// </summary>
            [Capital((int)WorldCities.FalklandIslandsStanley)]
            [PopulationEstimate(3662)]
            public static class FalklandIslands { }

            /// <summary>
            /// The Turks and Caicos Islands enjoys a degree of self-governance, with its own 
            /// elected government. The UK retains control over key areas such as defense, 
            /// foreign affairs, and internal security.
            /// </summary>
            [Capital((int)WorldCities.TurksandCaicosIslandsCockburnTown)]
            [PopulationEstimate(31458)]
            public static class TurksAndCaicosIslands { }

            /// <summary>
            /// The British Virgin Islands has significant self-governance, with its own government,
            /// assembly, and elected officials. However, the UK retains control over defense, 
            /// foreign relations, and internal security. The BVI remains on the UN list because 
            /// it is not fully sovereign and is under British administration.
            /// </summary>
            [Capital((int)WorldCities.BritishVirginIslandsRoadTown)]
            [PopulationEstimate(28103)]
            public static class BritishVirginIslands { }

            /// <summary>
            /// Anguilla is a small Caribbean island under British sovereignty. The island has its 
            /// own government, but defense and foreign affairs are managed by the UK. Anguilla has 
            /// experienced periods of civil unrest in the past over its political status. The 
            /// independence movement in Anguilla is relatively small, and there is no major push 
            /// for full independence at this time. The political focus remains on autonomy and 
            /// improving local governance under the British connection.
            /// </summary>
            [Capital((int)WorldCities.AnguillaTheValley)]
            [PopulationEstimate(14108)]
            public static class Anguilla { }

            /// <summary>
            /// Saint Helena and its associated islands are remote territories in the South 
            /// Atlantic Ocean. They are under British sovereignty but have their own governments 
            /// that handle most local affairs. The UK maintains responsibility for defense and 
            /// foreign relations. There is no significant independence movement, as the islands 
            /// are very small in population and rely on the UK for key infrastructure and 
            /// economic support.
            /// </summary>
            [Capital((int)WorldCities.SaintHelenaAscensionTristandaCunhaJamestown)]
            [PopulationEstimate(5396)]
            public static class SaintHelenaAscensionTristandaCunha { }

            /// <summary>
            /// Montserrat has self-governance in many aspects, but it is still heavily reliant 
            /// on the UK, particularly for defense and foreign relations. Despite the island’s 
            /// internal autonomy, Montserrat remains on the UN non-self-governing list.
            /// </summary>
            [Capital((int)WorldCities.MontserratPlymouth)] //disruptive volcanic eruptions here
            [DeFactoCapital((int)WorldCities.MontserratBrades)]
            [PopulationEstimate(5000)]
            public static class Montserrat { }

            /// <summary>
            /// The Pitcairn Islands are a small group of islands in the South Pacific. The 
            /// population is extremely small, mostly descendants of the HMS Bounty mutineers. 
            /// The British government oversees defense and foreign policy, while local affairs 
            /// are handled by the Island Council. The Pitcairn Islands have no significant 
            /// autonomy, and independence is not a prominent political issue. However, some 
            /// islanders have expressed the desire for greater local decision-making.
            /// </summary>
            [Capital((int)WorldCities.PitcairnIslandsAdamstown)]
            [PopulationEstimate(50)]
            public static class PitcairnIslands { }

            /// <summary>
            /// No permanent population — only temporary researchers and British government officials.
            /// South Georgia Island is an island 170 km long
            /// Smaller islands and islets: Annenkov Island, Bird Island (important for wildlife research), Cooper Island, Grass Island,
            /// Pickersgill Islands (small group of islets), Welcome Islands
            /// </summary>
            [PopulationEstimate(0)]
            public static class SouthGeorgia { }

            /// <summary>
            /// No permanent population — only temporary researchers and British government officials.
            /// 11 main islands
            /// Traversay Islands: Zavodovski, Leskov, Visokoi
            /// Candlemas Islands: Candlemas, Vindication, and several small rocks
            /// Central Islands: Saunders, Montagu (largest of South Sandwich Islands), Bristol
            /// Southern Group: Bellingshausen, Cook, Thule
            /// </summary>
            [PopulationEstimate(0)]
            public static class SouthSandwichIslands { }

            /// <summary>
            /// Diego Garcia atoll
            /// Military base (Diego Garcia) operated jointly by the UK and USA; native Chagossian population was displaced in the 1960s-70s (controversial history).
            /// primarily a U.S. base, despite being under British sovereignty — the UK retains "residual sovereignty" but does not station many personnel there.
            /// </summary>
            [PopulationEstimate(2000)]
            public static class BritishIndianOceanTerritory { }
        }

        public static class NewZealand
        {
            /// <summary>
            /// Tokelau is a small group of atolls in the South Pacific. It is a self-governing 
            /// territory under the sovereignty of New Zealand, but it is listed as 
            /// non-self-governing because it does not have full sovereignty. The New Zealand 
            /// government handles defense, foreign relations, and economic matters. There have 
            /// been discussions about potential independence, but Tokelau has voted to remain 
            /// under New Zealand's sovereignty in recent referenda (2006, 2007).
            /// </summary>
            [Capital((int)WorldCities.TokelauFakaofo)]
            [PopulationEstimate(1411)]
            public static class Tokelau { }
        }
    }

    public enum Micronations
    {
        /// <summary>
        /// Principality of Sealand
        /// An abandoned WWII sea fort (HM Fort Roughs) in the North Sea, about 12 km (7.5 miles) off the coast of Suffolk, England.
        /// Founded: 1967 by Paddy Roy Bates, who occupied the fort and declared it an independent state. 1-5 people on site at a time.
        /// </summary>
        [PopulationEstimate(5)]
        Sealand,

        /// <summary>
        /// Principality of Hutt River
        /// Founded: 1970 (Western Australia)
        /// Declared independence over a dispute with the Australian government. Operated for 50 years before dissolving in 2020.
        /// 20-30 people lived there while it existed
        /// </summary>
        HuttRiverProvince,

        /// <summary>
        /// Free Republic of Liberland
        /// Disputed land between Croatia and Serbia
        /// Claimed uninhabited "terra nullius" on the Danube River. Popular in libertarian circles.
        /// Founded: 2015
        /// </summary>
        [PopulationEstimate(0)]
        Liberland,
    }

    /// <summary>
    /// population estimates are maximum during the warmer season
    /// </summary>
    public static class Antarctica
    {
        /// <summary>
        /// Operating Country: USA
        /// Location: Ross Island, near the Antarctic coast
        /// Operational Since: 1956
        /// Purpose: It is the largest research station in Antarctica and serves 
        /// as a logistics hub for scientific expeditions. McMurdo supports 
        /// research in glaciology, biology, astronomy, and environmental science.
        /// 150-200 population in winter
        /// </summary>
        [PopulationEstimate(1200)]
        public static class McMurdoStation { }

        /// <summary>
        /// Operating Country: USA
        /// Location: At the geographic South Pole
        /// Operational Since: 1956
        /// Purpose: This station is dedicated to scientific research related to 
        /// astronomy, climate studies, and glaciology. It is also a critical hub 
        /// for studying the Earth's climate history.
        /// ~50 population in winter
        /// </summary>
        [PopulationEstimate(250)]
        public static class AmundsenScottSouthPoleStation { }

        /// <summary>
        /// Operating Country: USA
        /// Location: Antarctic Peninsula
        /// Operational Since: 1965
        /// Purpose: This station is smaller than McMurdo and Amundsen-Scott but 
        /// plays a vital role in marine biology, glaciology, and environmental 
        /// monitoring.
        /// </summary>
        [PopulationEstimate(50)]
        public static class PalmerStation { }

        /// <summary>
        /// Operating Country: Russia
        /// Location: Central East Antarctica, near Lake Vostok
        /// Operational Since: 1957
        /// Purpose: This Russian station is known for its work in glaciology, 
        /// especially studying the subglacial lake beneath the station. It is 
        /// one of the coldest places on Earth, with temperatures reaching below 
        /// -70°C (-94°F).
        /// </summary>
        [PopulationEstimate(30)]
        public static class VostokStation { }

        /// <summary>
        /// Operating Country: United Kingdom
        /// Location: Antarctic Peninsula
        /// Operational Since: 1975
        /// Purpose: The station supports research on biology, glaciology, 
        /// meteorology, and environmental science, particularly focusing on 
        /// the Antarctic marine ecosystem.
        /// </summary>
        [PopulationEstimate(100)]
        public static class RotheraResearchStation { }

        /// <summary>
        /// Operating Country: Australia
        /// Location: Antarctic coast on the Atka Bay, East Antarctica
        /// Operational Since: 1954
        /// Purpose: Mawson is involved in research in glaciology, marine biology, 
        /// and atmospheric science, with an emphasis on climate change.
        /// </summary>
        [PopulationEstimate(100)]
        public static class MawsonStation { }

        /// <summary>
        /// Operating Country: Argentina
        /// Location: Antarctic Peninsula
        /// Operational Since: 1953
        /// Purpose: Esperanza is one of the few stations with a permanent 
        /// Argentine population and is involved in a wide range of studies, 
        /// including biology, geology, and atmospheric sciences.
        /// </summary>
        [PopulationEstimate(70)]
        public static class EsperanzaBase { }

        /// <summary>
        /// Operating Country: Argentina
        /// Location: Interior of the Antarctic Peninsula
        /// Operational Since: 1979
        /// Purpose: This Argentine base is focused on research related to ice 
        /// cores, meteorology, and glaciology.
        /// </summary>
        [PopulationEstimate(25)]
        public static class BelgranoIIStation { }

        /// <summary>
        /// Operating Countries: France/Italy
        /// Location: Dome C, Central Antarctica
        /// Operational Since: 2005
        /// Purpose: Concordia is a joint French-Italian station dedicated to 
        /// studying ice cores, astronomy, climate research, and long-term 
        /// environmental changes in Antarctica.
        /// </summary>
        [PopulationEstimate(30)]
        public static class ConcordiaStation { }

        /// <summary>
        /// Operating Country: Japan
        /// Location: East Antarctica, near the coast
        /// Operational Since: 1957
        /// Purpose: This Japanese station conducts research on glaciology, 
        /// geology, and biology, as well as the effects of climate change.
        /// </summary>
        [PopulationEstimate(30)]
        public static class ShowaStation { }

        /// <summary>
        /// Operating Country: Chile
        /// Location: on King George Island, near the Antarctic Peninsula
        /// Operational Since: 1969
        /// Chile operates this station, which supports research in biology, 
        /// atmospheric studies, and glaciology.
        /// </summary>
        [PopulationEstimate(100)]
        public static class BasePresidenteFreiMontalva { }

        /// <summary>
        /// Operating Country: Brazil
        /// Location: King George Island
        /// Operational Since: 1984
        /// Brazil's station conducts research on biology, glaciology, and 
        /// climate change, and it plays an important role in regional 
        /// cooperation with other Latin American countries.
        /// </summary>
        [PopulationEstimate(70)]
        public static class ComandanteFerrazAntarcticStation { }

        /// <summary>
        /// Operating Country: Germany
        /// Location: At the coast of the Weddell Sea
        /// Operational Since: 2009
        /// The station focuses on atmospheric science, ice research, and geophysics. 
        /// Germany also operates several smaller scientific projects on the continent.
        /// </summary>
        [PopulationEstimate(50)]
        public static class NeumayerIIIStation { }

        /// <summary>
        /// Operating Country: Belgium
        /// Location: East Antarctica
        /// Operational Since: 2009
        /// This is a modern station focused on climate research, atmospheric studies, 
        /// and environmental monitoring, with a focus on sustainability.
        /// </summary>
        [PopulationEstimate(25)]
        public static class PrincessElisabethAntarctica { }

        /// <summary>
        /// Operating Country: New Zealand
        /// Location: on the Ross Sea, near McMurdo Station
        /// Operational Since: 1957
        /// Scott Base supports research in glaciology, marine biology, and climate change, 
        /// often collaborating with other nations, including the United States.
        /// </summary>
        [PopulationEstimate(100)]
        public static class ScottBase { }

        /// <summary>
        /// Operating Country: South Korea
        /// Location: King George Island
        /// Operational Since: 1988
        /// South Korea's station conducts research in biology, geology, and meteorology.
        /// </summary>
        [PopulationEstimate(30)]
        public static class KingSejongStation { }

        /// <summary>
        /// Operating Country: China
        /// Location: King George Island
        /// Operational Since: 1985
        /// China's station supports a wide range of scientific disciplines, including 
        /// biology, environmental studies, and geophysics. China also operates other 
        /// research initiatives in Antarctica.
        /// </summary>
        [PopulationEstimate(50)]
        public static class GreatWallStation { }

        /// <summary>
        /// Operating Country: Poland
        /// Location: King George Island
        /// Operational Since: 1977
        /// Poland's research station focuses on geology, ice studies, and marine biology.
        /// </summary>
        [PopulationEstimate(30)]
        public static class HenrykArctowskiAntarcticStation { }

        /// <summary>
        /// Operating Country: Ukraine
        /// Location: on Galindez Island, near the Antarctic Peninsula
        /// Operational Since: 1996 (formerly British-operated as Faraday Station)
        /// Ukraine's base is involved in biological, geological, and meteorological 
        /// research, especially in the Antarctic marine environment.
        /// </summary>
        [PopulationEstimate(25)]
        public static class VernadskyResearchBase { }

        /// <summary>
        /// Operating Country: India
        /// Location: in Schirmacher Oasis
        /// Operational Since: 1989
        /// India’s Maitri Station focuses on glaciology, climate science, and 
        /// atmospheric research.
        /// </summary>
        [PopulationEstimate(150)]
        public static class MaitriStation { }

        /// <summary>
        /// Operating Country: India
        /// Location: Larsen Ice Shelf, East Antarctica
        /// Coordinates: 69° 24′S 76° 11′E
        /// Inaugurated: 2012
        /// Bharati Station is used for research in several scientific fields, including:
        /// Glaciology: Studying ice sheets and glaciers to understand global sea level rise.
        /// Meteorology: Collecting data on atmospheric pressure, temperature, and wind 
        /// patterns.
        /// Environmental Monitoring: Observing the impacts of climate change in the polar 
        /// region.
        /// Astronomy: Bharati also contributes to international efforts to understand 
        /// cosmic phenomena, benefiting from the clear skies over Antarctica.
        /// Biology and Ecology: Studying life forms in extreme environments and their 
        /// adaptations to cold temperatures.
        /// The station contributes to the International Polar Year and broader research 
        /// efforts related to global climate change and Antarctic ecosystems.
        /// </summary>
        [PopulationEstimate(30)]
        public static class BharatiStation { }

        /// <summary>
        /// Operating Country: South Africa
        /// Location: coastal region of the Antarctic continent
        /// Operational Since: 1997
        /// South Africa's research station supports studies in geology, atmospheric 
        /// science, and meteorology.
        /// </summary>
        [PopulationEstimate(15)]
        public static class SANAEIV { }

        /// <summary>
        /// Operating Country: Norway
        /// Location: in Queen Maud Land, East Antarctica
        /// Operational Since: 1990
        /// Norway’s station is involved in research on climate change, glaciology, and 
        /// atmospheric sciences.
        /// </summary>
        [PopulationEstimate(40)]
        public static class TrollStation { }

        /// <summary>
        /// Operating Country: Czech Republic
        /// Location: on James Ross Island
        /// Operational since: 2006
        /// The Czech station focuses on biological and environmental research.
        /// </summary>
        [PopulationEstimate(20)]
        public static class CzechAntarcticStation { }

        /// <summary>
        /// Operating Country: Spain
        /// Location: on Livingston Island
        /// Operational Since: 1988
        /// Spain’s research focuses on marine biology, meteorology, and geology, 
        /// particularly in relation to the Antarctic ecosystem.
        /// </summary>
        [PopulationEstimate(25)]
        public static class JuanCarlosIStation { }
    }

    public static class IntegratedCountries
    {
        /// <summary>
        /// The Kingdom of Hawaii was established in 1810 when King Kamehameha I unified the Hawaiian 
        /// Islands under a single monarchy. This kingdom maintained its sovereignty and was 
        /// internationally recognized until 1893. ​In 1893, Queen Liliʻuokalani was overthrown by a 
        /// group of American and European businessmen, leading to the establishment of the Republic of 
        /// Hawaii in 1894. The Republic existed until 1898, when Hawaii was annexed by the United 
        /// States, becoming the Territory of Hawaii. Hawaii remained a U.S. territory until it was 
        /// admitted as the 50th state on August 21, 1959.
        /// </summary>
        public static class Hawaii { }

        /// <summary>
        /// On March 2, 1836, during the Convention of 1836 at Washington-on-the-Brazos, delegates 
        /// declared Texas' independence from Mexico, establishing the Republic of Texas. Following 
        /// several key battles, including the fall of the Alamo and the victory at the Battle of San 
        /// Jacinto, where General Sam Houston's forces captured Mexican President Antonio López de 
        /// Santa Anna, Texas secured its independence.​ Economic difficulties, security concerns, and 
        /// the desire for U.S. statehood led Texas to pursue annexation. However, its status as a 
        /// slaveholding nation made annexation a contentious issue in the United States. After years 
        /// of debate, Texas was admitted to the Union as the 28th state on December 29, 1845.
        /// </summary>
        public static class Texas { }

        /// <summary>
        /// On January 15, 1777, representatives from the New Hampshire Grants declared independence, 
        /// initially naming the territory "New Connecticut." The name was later changed to "Vermont" 
        /// on June 2, 1777, upon the suggestion of Dr. Thomas Young. The Vermont Republic operated 
        /// with its own constitution, which notably abolished slavery and provided for universal male 
        /// suffrage, regardless of property ownership. The republic also issued its own currency and 
        /// maintained a postal service. Despite its independence, Vermont sought to join the United 
        /// States and was admitted as the 14th state on March 4, 1791.
        /// </summary>
        public static class Vermont { }

        /// <summary>
        /// ​The California Republic, often referred to as the Bear Flag Republic, was a short-lived, 
        /// unrecognized state that existed from June 14 to July 9, 1846, in what is now Northern 
        /// California.
        /// </summary>
        public static class California { }

        /// <summary>
        /// The idea of unifying the two German-speaking nations gained traction, but the Treaty of 
        /// Saint-Germain (1919) and the Treaty of Versailles (1919) explicitly prohibited such a 
        /// union. Despite this, the notion of Anschluss remained popular among certain political 
        /// factions in both countries. In early 1938, Austrian Chancellor Kurt Schuschnigg, under 
        /// increasing pressure from pro-Nazi elements within Austria and from Adolf Hitler, 
        /// announced a referendum for March 13 to decide on Austrian independence. In response, 
        /// Hitler demanded the cancellation of the referendum and Schuschnigg's resignation. Facing 
        /// immense pressure, Schuschnigg resigned on March 11, and Arthur Seyss-Inquart, a pro-Nazi 
        /// politician, was appointed Chancellor. The following day, March 12, German troops entered 
        /// Austria without facing resistance, and were welcomed by many Austrians. On March 13, 1938, 
        /// the annexation was officially declared, and Austria became a province of the Third Reich, 
        /// renamed "Ostmark." A controlled plebiscite held on April 10, 1938, reported that 
        /// approximately 99.7% of Austrians approved the annexation, though the fairness of this vote 
        /// is widely disputed due to the oppressive political climate and lack of secret ballot.
        /// </summary>
        public static class Anschluss { }

        /// <summary>
        /// Bessarabia, a region between the Prut and Dniester rivers, was part of the 
        /// Principality of Moldavia until 1812, when it was annexed by the Russian Empire 
        /// following the Treaty of Bucharest. After more than a century under Russian rule, 
        /// the political landscape shifted dramatically with the Russian Revolution of 1917, 
        /// leading to the destabilization of imperial authority. In this context, Bessarabia 
        /// sought greater autonomy and self-determination. In December 1917, amid the chaos 
        /// of the collapsing Russian Empire, Bessarabian leaders established the "Sfatul 
        /// Țării" (Council of the Country), which declared the creation of the Moldavian 
        /// Democratic Republic, initially as an autonomous entity within Russia. However, 
        /// facing internal unrest and external threats, the council sought support from 
        /// neighboring Romania. Romanian forces entered Bessarabia to stabilize the region, 
        /// and on March 27, 1918, "Sfatul Țării" voted to unite Bessarabia with Romania, 
        /// subject to certain conditions, including local autonomy, which were later 
        /// nullified.
        /// </summary>
        public static class Bessarabia { }
    }

    public static class MergedCountries
    {
        /// <summary>
        /// On May 22, 1990, North Yemen (Yemen Arab Republic) and South Yemen (People's Democratic 
        /// Republic of Yemen) merged
        /// </summary>
        public static class Yemen
        {
            /// <summary>
            /// South Yemen gained independence on November 30, 1967. The NLF assumed control, 
            /// proclaiming the establishment of the People's Republic of South Yemen. In 
            /// June 1969, a radical Marxist faction within the NLF seized power, leading to 
            /// the country's rebranding as the People's Democratic Republic of Yemen on 
            /// December 1, 1970. 
            /// </summary>
            public static class SouthYemen { }

            /// <summary>
            /// Following the Ottoman Empire's collapse after World War I, Imam Yahya 
            /// Muhammad Hamid ed-Din declared northern Yemen's independence in 1918, 
            /// establishing the Mutawakkilite Kingdom of Yemen. This kingdom functioned 
            /// as a theocratic absolute monarchy, with Zaydi Shia Islam as the state 
            /// religion. Imam Yahya centralized power, maintaining a conservative and 
            /// isolationist stance, which limited modernization efforts. Yemen joined 
            /// the Arab League in 1945 and the United Nations in 1947. Imam Yahya's 
            /// assassination during a failed coup in 1948 led to his son, Ahmad bin Yahya, 
            /// ascending the throne. Ahmad's reign continued the autocratic governance, 
            /// facing internal dissent and external pressures for reform. After Imam Ahmad's 
            /// death in 1962, his son, Muhammad al-Badr, briefly assumed power. Later 
            /// that year, a group of military officers, inspired by Arab nationalist 
            /// ideologies, orchestrated a coup d'état, deposing the monarchy and proclaiming 
            /// the Yemen Arab Republic (YAR) on September 26, 1962. This event triggered 
            /// the North Yemen Civil War, with royalist forces, backed by Saudi Arabia 
            /// and Jordan, clashing against republicans supported by Egypt. The conflict 
            /// persisted until 1970, concluding with the establishment of the republic 
            /// and international recognition.
            /// </summary>
            public static class NorthYemen { }
        }
    }

    public static class FictionCountries
    {
        /// <summary>
        /// Santa Claus/Mrs. Claus/Dasher/Dancer/Prancer/Vixen/Comet/Cupid/Donner/Blitzen/Rudolph
        /// Countless Elves (500-10000)
        /// Is it a country:
        /// 1. Permanent population: Yes (mostly elves)
        /// 2. Defined territory: Yes (it's a village)
        /// 3. Government: Yes (Santa is an absolute monarch or benevolent dictator with an organized workforce)
        /// 4. Relations with other states: Yes (NORAD keeps tabs on Santa, must have an agreement allowing airspace use)
        /// 
        /// Postal code recognized worldwide (Santa Claus, North Pole)
        /// 
        /// North Pole last ice free:
        /// Pliocene Warm Period. 3-5 million years ago, Arctic may have had significantly less ice, but probably some seasonal ice remaining.
        /// Eocene Epoch. 34-56 million years ago, Much warmer global temperatures; fossils suggest tropical and subtropical flora and fauna near the pole.
        /// </summary>
        [PopulationEstimate(511)] //511 = 2^9 - 1 (a Mersenne number)
        public static class SantasVillageAtTheNorthPole { }
    }

    public static class NuclearWeaponStates
    {
        /// <summary>
        /// 5044 total warheads, 1770 deployed warheads
        /// </summary>
        public static class UnitedStates { }

        /// <summary>
        /// 5580 total warheads, 1710 deployed warheads
        /// sole nuclear successor of the Soviet Union
        /// </summary>
        public static class Russia { }

        /// <summary>
        /// 225 total warheads, 120 deployed warheads
        /// </summary>
        public static class UnitedKingdom { }

        /// <summary>
        /// 290 total warheads, 280 deployed warheads
        /// </summary>
        public static class France { }

        /// <summary>
        /// 500 total warheads, 24 deployed warheads
        /// </summary>
        public static class China { }

        /// <summary>
        /// 172 total warheads, none deployed
        /// </summary>
        public static class India { }

        /// <summary>
        /// 170 total warheads, none deployed
        /// 
        /// In December 2024, the United States imposed sanctions on entities involved in Pakistan's missile program, citing concerns over the development of long-range ballistic missiles 
        /// capable of reaching U.S. targets. Pakistan denied these allegations, asserting that its nuclear and missile programs are intended solely as deterrents against Indian aggression.
        /// </summary>
        public static class Pakistan { }

        /// <summary>
        /// 90 total warheads, none deployed
        /// </summary>
        public static class Israel { }

        /// <summary>
        /// 50 total warheads, none deployed
        /// </summary>
        public static class NorthKorea { }

        /// <summary>
        /// 1970s–1980s: secretly developed nuclear weapons, producing six fully operational bombs.
        /// 1989: President F.W. de Klerk orders the dismantling of the nuclear arsenal.
        /// 1991: South Africa signs the Nuclear Non-Proliferation Treaty (NPT) and discloses 
        /// its past nuclear program to the International Atomic Energy Agency (IAEA).
        /// 1993: De Klerk publicly announces that South Africa had developed and voluntarily 
        /// dismantled its nuclear weapons.
        /// 
        /// South Africa remains the only country to have developed nuclear weapons and then 
        /// voluntarily dismantled them completely.
        /// </summary>
        public static class SouthAfrica { }

        /// <summary>
        /// 1992 – Lisbon Protocol: Ukraine, Belarus, and Kazakhstan agreed to join the Nuclear 
        /// Non-Proliferation Treaty (NPT) as non-nuclear states and transfer their nuclear 
        /// weapons to Russia.
        /// 1994 – Budapest Memorandum:
        /// In exchange for giving up nuclear weapons, Ukraine, Belarus, and Kazakhstan received 
        /// security assurances from Russia, the U.S., and the U.K. (including respect for their 
        /// sovereignty and borders).
        /// 1995-1996 nuclear weapons transferred to Russia
        /// Ukraine, Belarus, and Kazakhstan became non-nuclear states and joined the NPT.
        /// </summary>
        public static class UkraineBelarusKazahkstan { }
    }

    public static class NuclearWeaponsCooperation
    {
        /// <summary>
        /// India and Pakistan have been exchanging information about their nuclear assets annually since 1992. This practice is part of an agreement known as the Prohibition of Attack against 
        /// Nuclear Installations and Facilities Agreement. The agreement was signed by both countries in 1988 and came into effect in 1991.
        /// </summary>
        public static class IndiaPakistanCooperation { }
    }

    public static class HistoricalPalestine
    {
        public static class CurrentlyBelieveUnsolvableProblem { }
        public static class OneStateSolutionWhereIsraelAbsorbsPalestineWouldMeanIsraelNotJewishStateAnymore { }
        public static class TwoStateSolutionWhereIsraelCoexistsWithPalestineWouldLeavePalestineAsNonFunctionalState { }
        public static class EgyptDoesntWantToAbsorbGazaStripBecauseHamasAreTerroristsToThem { }
        public static class JordanHasManyReasonsNotToAbsorbWestBank
        {
            public static class DemographicChangesLeadingToLossOfStability { }
            public static class RelinquishedClaimsIn1988 { }
        }
        public static class Palestine
        {
            public static class NotClearWhatGovernmentWouldEmergeIfMergedIntoSingleState { }
            public static class ResidentsWantToBeSeparateStateAndNotAbsorbedIntoIsraelOrEgyptOrJordan { }
        }
    }

    public static class Korea
    {
        public static class CivilWarAtStalemate { }
        public static class CouldEventuallyBeAbsorbedIntoSouthKorea { }
        public static class OrMaybeChinaWillAssumeControl { }

        public static class NorthKorea
        {
            public static class SupportedByRussiaToSomeExtent { }
            public static class SupportedByChinaToSomeExtent { }
            public static class PursuingNuclearWeapons { }
        }
        public static class SouthKorea
        {
            public static class SupportedByCountriesSupportingBothHumanFreedomAndCapitalism { }
        }
    }

    public static class Taiwan
    {
        public static class SupportedByCountriesSupportingBothHumanFreedomAndCapitalism { }
        public static class ButSupportIsTacitToAvoidOffendingChina { }
        public static class DeFactoIndependent { }
        public const string FullName = "Republic of China";
        public static class ROC { }
        public static class PresumablyWillBeEventuallyIndependent { }
    }

    public static class ChinaDetail
    {
        public static class AcknowledgesOnlyOneChina { }
        public static class ManyCountriesSupportBecauseBigAndPowerful { }
        public static class EconomicSystemHasABunchOfCapitalism { }
        public static class CommunistGovernmentSeverelyRestrictsDissentAgainstTheGovernment { }
    }

    public static class Israel
    {
        public static class ParliamentaryDemocracy { }
        public static class JewishReligionState { }
    }
}

