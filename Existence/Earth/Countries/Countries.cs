using Existence.Earth.Alphabet;
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

    public class LargestCityAttribute : Attribute
    {
        public int LargestCity { get; set; }
        public LargestCityAttribute(int LargestCity)
        {
            this.LargestCity = LargestCity;
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

    public class PopulationEstimateAttribute : Attribute
    {
        public int Number { get; set; }

        public PopulationEstimateAttribute(int Number)
        {
            this.Number = Number;
        }
    }

    public static class UnitedNationsCountries
    {
        [UnitedNationsMembership(1946, 11, 19)]
        [Capital((int)WorldCities.AfghanistanKabul)]
        [LargestCity((int)WorldCities.AfghanistanKabul)]
        public static class Afghanistan { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.AlbaniaTirana)]
        [LargestCity((int)WorldCities.AlbaniaTirana)]
        public static class Albania { }

        [UnitedNationsMembership(1962, 10, 8)]
        [Capital((int)WorldCities.AlgeriaAlgiers)]
        [LargestCity((int)WorldCities.AlgeriaAlgiers)]
        public static class Algeria { }

        [UnitedNationsMembership(1993, 7, 28)]
        [Capital((int)WorldCities.AndorraAndorraLaVella)]
        [LargestCity((int)WorldCities.AndorraAndorraLaVella)]
        public static class Andorra { }

        [UnitedNationsMembership(1976, 12, 1)]
        [Capital((int)WorldCities.AngolaLuanda)]
        [LargestCity((int)WorldCities.AngolaLuanda)]
        public static class Angola { }

        [UnitedNationsMembership(1981, 11, 11)]
        [Capital((int)WorldCities.AntiguaAndBarbudaStJohns)]
        [LargestCity((int)WorldCities.AntiguaAndBarbudaStJohns)]
        public static class AntiguaAndBarbuda { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.ArgentinaBuenosAires)]
        [LargestCity((int)WorldCities.ArgentinaBuenosAires)]
        public static class Argentina { }

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.ArmeniaYerevan)]
        [LargestCity((int)WorldCities.ArmeniaYerevan)]
        public static class Armenia { }

        [UnitedNationsMembership(1945, 11, 1)]
        [Capital((int)WorldCities.AustraliaCanberra)]
        [LargestCity((int)WorldCities.AustraliaSydney)]
        public static class Australia { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.AustriaVienna)]
        [LargestCity((int)WorldCities.AustriaVienna)]
        public static class Austria { }

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.AzerbaijanBaku)]
        [LargestCity((int)WorldCities.AzerbaijanBaku)]
        public static class Azerbaijan { }

        [UnitedNationsMembership(1973, 9, 18)]
        [Capital((int)WorldCities.BahamasNassau)]
        [LargestCity((int)WorldCities.BahamasNassau)]
        public static class Bahamas { }

        [UnitedNationsMembership(1971, 9, 21)]
        [Capital((int)WorldCities.BahrainManama)]
        [LargestCity((int)WorldCities.BahrainManama)]
        public static class Bahrain { }

        [UnitedNationsMembership(1974, 9, 17)]
        [Capital((int)WorldCities.BangladeshDhaka)]
        [LargestCity((int)WorldCities.BangladeshDhaka)]
        public static class Bangladesh { }

        [UnitedNationsMembership(1966, 12, 9)]
        [Capital((int)WorldCities.BarbadosBridgetown)]
        [LargestCity((int)WorldCities.BarbadosBridgetown)]
        public static class Barbados { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.BelarusMinsk)]
        [LargestCity((int)WorldCities.BelarusMinsk)]
        public static class Belarus { }

        [UnitedNationsMembership(1945, 12, 27)]
        [Capital((int)WorldCities.BelgiumBrussels)]
        [LargestCity((int)WorldCities.BelgiumBrussels)]
        public static class Belgium { }

        [UnitedNationsMembership(1981, 9, 25)]
        [Capital((int)WorldCities.BelizeBelmopan)]
        [LargestCity((int)WorldCities.BelizeBelizeCity)]
        public static class Belize { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.BeninPortoNovo)]
        [LargestCity((int)WorldCities.BeninCotonou)]
        public static class Benin { }

        [UnitedNationsMembership(1971, 9, 21)]
        [Capital((int)WorldCities.BhutanThimphu)]
        [LargestCity((int)WorldCities.BhutanThimphu)]
        public static class Bhutan { }

        /// <summary>
        /// Plurinational State of Bolivia
        /// </summary>
        [UnitedNationsMembership(1945, 11, 14)]
        [ConstitutionalCapital((int)WorldCities.BoliviaSucre)]
        [AdministrativeCapital((int)WorldCities.BoliviaLaPaz)]
        [LargestCity((int)WorldCities.BoliviaSantaCruzDeLaSierra)]
        public static class Bolivia { }

        [UnitedNationsMembership(1992, 5, 22)]
        [Capital((int)WorldCities.BosniaAndHerzegovinaSarajevo)]
        [LargestCity((int)WorldCities.BosniaAndHerzegovinaSarajevo)]
        public static class BosniaAndHerzegovina { }

        [UnitedNationsMembership(1966, 10, 17)]
        [Capital((int)WorldCities.BotswanaGaborone)]
        [LargestCity((int)WorldCities.BotswanaGaborone)]
        public static class Botswana { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.BrazilBrasilia)]
        [LargestCity((int)WorldCities.BrazilSaoPaulo)]
        public static class Brazil { }

        /// <summary>
        /// Brunei Darussalam
        /// </summary>
        [UnitedNationsMembership(1984, 9, 21)]
        [Capital((int)WorldCities.BruneiBandarSeriBegawan)]
        [LargestCity((int)WorldCities.BruneiBandarSeriBegawan)]
        public static class Brunei { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.BulgariaSofia)]
        [LargestCity((int)WorldCities.BulgariaSofia)]
        public static class Bulgaria { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.BurkinaFasoOuagadougou)]
        [LargestCity((int)WorldCities.BurkinaFasoOuagadougou)]
        public static class BurkinaFaso { }

        /// <summary>
        /// official name is Myanmar
        /// </summary>
        [UnitedNationsMembership(1948, 4, 19)]
        [Capital((int)WorldCities.BurmaNaypyidaw)]
        [LargestCity((int)WorldCities.BurmaRangoon)]
        [LocalName("Myanmar")]
        public static class Burma { }

        [UnitedNationsMembership(1962, 9, 18)]
        [Capital((int)WorldCities.BurundiGitega)]
        [LargestCity((int)WorldCities.BurundiBujumbura)]
        public static class Burundi { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.CambodiaPhnomPenh)]
        [LargestCity((int)WorldCities.CambodiaPhnomPenh)]
        public static class Cambodia { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.CameroonYaounde)]
        [LargestCity((int)WorldCities.CameroonDouala)]
        public static class Cameroon { }

        [UnitedNationsMembership(1945, 11, 9)]
        [Capital((int)WorldCities.CanadaOttawa)]
        [LargestCity((int)WorldCities.CanadaToronto)]
        public static class Canada { }

        [UnitedNationsMembership(1975, 9, 16)]
        [Capital((int)WorldCities.CapeVerdePraia)]
        [LargestCity((int)WorldCities.CapeVerdePraia)]
        [LocalName("Cabo Verde")]
        public static class CapeVerde { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.CentralAfricanRepublicBangui)]
        [LargestCity((int)WorldCities.CentralAfricanRepublicBangui)]
        public static class CentralAfricanRepublic { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.ChadNDjamena)]
        [LargestCity((int)WorldCities.ChadNDjamena)]
        public static class Chad { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.ChileSantiago)]
        [LargestCity((int)WorldCities.ChileSantiago)]
        public static class Chile { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.ChinaBeijing)]
        [LargestCity((int)WorldCities.ChinaShanghai)]
        public static class China
        {
            public const string FullName = "People's Republic of China";
            public static class PRC { }
            public static class AcknowledgesOnlyOneChina { }
            public static class ManyCountriesSupportBecauseBigAndPowerful { }
            public static class EconomicSystemHasABunchOfCapitalism { }
            public static class CommunistGovernmentSeverelyRestrictsDissentAgainstTheGovernment { }
        }

        [UnitedNationsMembership(1945, 11, 5)]
        [Capital((int)WorldCities.ColombiaBogota)]
        [LargestCity((int)WorldCities.ColombiaBogota)]
        public static class Colombia { }

        [UnitedNationsMembership(1975, 11, 12)]
        [Capital((int)WorldCities.ComorosMoroni)]
        [LargestCity((int)WorldCities.ComorosMoroni)]
        public static class Comoros { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.CongoBrazzaville)]
        [LargestCity((int)WorldCities.CongoBrazzaville)]
        public static class Congo
        {
            public const string FullName = "Republic of the Congo";
            public static class ROC { }
        }

        [UnitedNationsMembership(1945, 11, 2)]
        [Capital((int)WorldCities.CostaRicaSanJose)]
        [LargestCity((int)WorldCities.CostaRicaSanJose)]
        public static class CostaRica { }

        [UnitedNationsMembership(1992, 5, 22)]
        [Capital((int)WorldCities.CroatiaZagreb)]
        [LargestCity((int)WorldCities.CroatiaZagreb)]
        public static class Croatia { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.CubaHavana)]
        [LargestCity((int)WorldCities.CubaHavana)]
        public static class Cuba { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.CyprusSouthNicosia)]
        [LargestCity((int)WorldCities.CyprusSouthNicosia)]
        public static class Cyprus { }

        [UnitedNationsMembership(1993, 1, 19)]
        [LocalName("Czechia")]
        [Capital((int)WorldCities.CzechRepublicPrague)]
        [LargestCity((int)WorldCities.CzechRepublicPrague)]
        public static class CzechRepublic { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.DenmarkCopenhagen)]
        [LargestCity((int)WorldCities.DenmarkCopenhagen)]
        public static class Denmark { }

        [UnitedNationsMembership(1977, 9, 20)]
        [Capital((int)WorldCities.DjiboutiDjiboutiCity)]
        [LargestCity((int)WorldCities.DjiboutiDjiboutiCity)]
        public static class Djibouti { }

        [UnitedNationsMembership(1978, 12, 18)]
        [Capital((int)WorldCities.DominicaRoseau)]
        [LargestCity((int)WorldCities.DominicaRoseau)]
        public static class Dominica { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.DominicanRepublicSantoDomingo)]
        [LargestCity((int)WorldCities.DominicanRepublicSantoDomingo)]
        public static class DominicanRepublic { }

        [UnitedNationsMembership(2002, 9, 27)]
        [LocalName("Timor-Leste")]
        [Capital((int)WorldCities.EastTimorDili)]
        [LargestCity((int)WorldCities.EastTimorDili)]
        public static class EastTimor { }

        [UnitedNationsMembership(1945, 12, 21)]
        [Capital((int)WorldCities.EcuadorQuito)]
        [LargestCity((int)WorldCities.EcuadorGuayaquil)]
        public static class Ecuador { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.EgyptCairo)]
        [LargestCity((int)WorldCities.EgyptCairo)]
        public static class Egypt { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.ElSalvadorSanSalvador)]
        [LargestCity((int)WorldCities.ElSalvadorSanSalvador)]
        public static class ElSalvador { }

        [UnitedNationsMembership(1968, 11, 12)]
        [Capital((int)WorldCities.EquatorialGuineaMalabo)]
        [PlannedCapital((int)WorldCities.EquatorialGuineaCiudadDeLaPaz)]
        [LargestCity((int)WorldCities.EquatorialGuineaBata)]
        public static class EquatorialGuinea { }

        [UnitedNationsMembership(1993, 5, 28)]
        [Capital((int)WorldCities.EritreaAsmara)]
        [LargestCity((int)WorldCities.EritreaAsmara)]
        public static class Eritrea { }

        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.EstoniaTalinn)]
        [LargestCity((int)WorldCities.EstoniaTalinn)]
        public static class Estonia { }

        [UnitedNationsMembership(1945, 11, 13)]
        [Capital((int)WorldCities.EthiopiaAddisAbaba)]
        [LargestCity((int)WorldCities.EthiopiaAddisAbaba)]
        public static class Ethiopia { }

        [UnitedNationsMembership(1970, 10, 13)]
        [Capital((int)WorldCities.FijiSuva)]
        [LargestCity((int)WorldCities.FijiSuva)]
        public static class Fiji { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.FinlandHelsinki)]
        [LargestCity((int)WorldCities.FinlandHelsinki)]
        public static class Finland { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.FranceParis)]
        [LargestCity((int)WorldCities.FranceParis)]
        public static class France { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.GabonLibreville)]
        [LargestCity((int)WorldCities.GabonLibreville)]
        public static class Gabon { }

        /// <summary>
        /// Republic of the Gambia
        /// </summary>
        [UnitedNationsMembership(1965, 9, 21)]
        [Capital((int)WorldCities.GambiaBanjul)]
        [LargestCity((int)WorldCities.GambiaSerekunda)]
        public static class Gambia { }

        [UnitedNationsMembership(1992, 7, 31)]
        [Capital((int)WorldCities.GeorgiaTbilisi)]
        [LargestCity((int)WorldCities.GeorgiaTbilisi)]
        public static class Georgia { }

        [UnitedNationsMembership(1973, 9, 18)]
        [Capital((int)WorldCities.GermanyBerlin)]
        [LargestCity((int)WorldCities.GermanyBerlin)]
        public static class Germany { }

        [UnitedNationsMembership(1957, 3, 8)]
        [Capital((int)WorldCities.GhanaAccra)]
        [LargestCity((int)WorldCities.GhanaAccra)]
        public static class Ghana { }

        [UnitedNationsMembership(1945, 10, 25)]
        [Capital((int)WorldCities.GreeceAthens)]
        [LargestCity((int)WorldCities.GreeceAthens)]
        public static class Greece { }

        [UnitedNationsMembership(1974, 9, 17)]
        [Capital((int)WorldCities.GrenadaStGeorges)]
        [LargestCity((int)WorldCities.GrenadaStGeorges)]
        public static class Grenada { }

        [UnitedNationsMembership(1945, 11, 21)]
        [Capital((int)WorldCities.GuatemalaGuatemalaCity)]
        [LargestCity((int)WorldCities.GuatemalaGuatemalaCity)]
        public static class Guatemala { }

        [UnitedNationsMembership(1958, 12, 12)]
        [Capital((int)WorldCities.GuineaConakry)]
        [LargestCity((int)WorldCities.GuineaConakry)]
        public static class Guinea { }

        [UnitedNationsMembership(1974, 9, 17)]
        [Capital((int)WorldCities.GuineaBissauBissau)]
        [LargestCity((int)WorldCities.GuineaBissauBissau)]
        public static class GuineaBissau { }

        [UnitedNationsMembership(1966, 9, 20)]
        [Capital((int)WorldCities.GuyanaGeorgetown)]
        [LargestCity((int)WorldCities.GuyanaGeorgetown)]
        public static class Guyana { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.HaitiPortauPrince)]
        [LargestCity((int)WorldCities.HaitiPortauPrince)]
        public static class Haiti { }

        [UnitedNationsMembership(1945, 12, 17)]
        [Capital((int)WorldCities.HondurasTegucigalpa)]
        [LargestCity((int)WorldCities.HondurasSanPedroSula)]
        public static class Honduras { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.HungaryBudapest)]
        [LargestCity((int)WorldCities.HungaryBudapest)]
        public static class Hungary { }

        [UnitedNationsMembership(1946, 11, 19)]
        [Capital((int)WorldCities.IcelandReykjavik)]
        [LargestCity((int)WorldCities.IcelandReykjavik)]
        public static class Iceland { }

        [UnitedNationsMembership(1945, 10, 30)]
        [Capital((int)WorldCities.IndiaNewDelhi)]
        [LargestCity((int)WorldCities.IndiaMumbai)]
        public static class India { }

        [UnitedNationsMembership(1950, 9, 28)]
        [Capital((int)WorldCities.IndonesiaJakarta)]
        [LargestCity((int)WorldCities.IndonesiaJakarta)]
        public static class Indonesia { }

        /// <summary>
        /// Islamic Republic of Iran
        /// </summary>
        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.IranTehran)]
        [LargestCity((int)WorldCities.IranTehran)]
        public static class Iran { }

        [UnitedNationsMembership(1945, 12, 21)]
        [Capital((int)WorldCities.IraqBaghdad)]
        [LargestCity((int)WorldCities.IraqBaghdad)]
        public static class Iraq { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.IrelandDublin)]
        [LargestCity((int)WorldCities.IrelandDublin)]
        public static class Ireland { }

        [UnitedNationsMembership(1949, 5, 11)]
        [Capital((int)WorldCities.IsraelJerusalem)]
        [LargestCity((int)WorldCities.IsraelTelAviv)]
        public static class Israel
        {
            public static class ParliamentaryDemocracy { }
            public static class JewishReligionState { }
        }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.ItalyRome)]
        [LargestCity((int)WorldCities.ItalyRome)]
        public static class Italy { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.IvoryCoastYamoussoukro)]
        [LargestCity((int)WorldCities.IvoryCoastAbidjan)]
        [LocalName("Côte D'Ivoire")]
        public static class IvoryCoast { }

        [UnitedNationsMembership(1962, 9, 18)]
        [Capital((int)WorldCities.JamaicaKingston)]
        [LargestCity((int)WorldCities.JamaicaKingston)]
        public static class Jamaica { }

        [UnitedNationsMembership(1956, 12, 18)]
        [Capital((int)WorldCities.JapanTokyo)]
        [LargestCity((int)WorldCities.JapanTokyo)]
        public static class Japan { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.JordanAmman)]
        [LargestCity((int)WorldCities.JordanAmman)]
        public static class Jordan { }

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.KazakhstanNurSultan)]
        [LargestCity((int)WorldCities.KazakhstanAlmaty)]
        public static class Kazakhstan { }

        [UnitedNationsMembership(1963, 12, 16)]
        [Capital((int)WorldCities.KenyaNairobi)]
        [LargestCity((int)WorldCities.KenyaNairobi)]
        public static class Kenya { }

        [UnitedNationsMembership(1999, 9, 14)]
        [Capital((int)WorldCities.KiribatiTarawa)]
        [LargestCity((int)WorldCities.KiribatiTarawa)]
        public static class Kiribati { }

        [UnitedNationsMembership(1963, 5, 14)]
        [Capital((int)WorldCities.KuwaitKuwaitCity)]
        [LargestCity((int)WorldCities.KuwaitKuwaitCity)]
        public static class Kuwait { }

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.KyrgyzstanBishkek)]
        [LargestCity((int)WorldCities.KyrgyzstanBishkek)]
        public static class Kyrgyzstan { }

        /// <summary>
        /// Lao People’s Democratic Republic
        /// </summary>
        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.LaosVientiane)]
        [LargestCity((int)WorldCities.LaosVientiane)]
        public static class Laos { }

        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.LatviaRiga)]
        [LargestCity((int)WorldCities.LatviaRiga)]
        public static class Latvia { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.LebanonBeirut)]
        [LargestCity((int)WorldCities.LebanonBeirut)]
        public static class Lebanon { }

        [UnitedNationsMembership(1966, 10, 17)]
        [Capital((int)WorldCities.LesothoMaseru)]
        [LargestCity((int)WorldCities.LesothoMaseru)]
        public static class Lesotho { }

        [UnitedNationsMembership(1945, 11, 2)]
        [Capital((int)WorldCities.LiberiaMonrovia)]
        [LargestCity((int)WorldCities.LiberiaMonrovia)]
        public static class Liberia { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.LibyaTripoli)]
        [LargestCity((int)WorldCities.LibyaTripoli)]
        public static class Libya { }

        [UnitedNationsMembership(1990, 9, 18)]
        [Capital((int)WorldCities.LiechtensteinVaduz)]
        [LargestCity((int)WorldCities.LiechtensteinVaduz)]
        public static class Liechtenstein { }

        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.LithuaniaVilnius)]
        [LargestCity((int)WorldCities.LithuaniaVilnius)]
        public static class Lithuania { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.LuxembourgLuxembourgCity)]
        [LargestCity((int)WorldCities.LuxembourgLuxembourgCity)]
        public static class Luxembourg { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.MadagascarAntananarivo)]
        [LargestCity((int)WorldCities.MadagascarAntananarivo)]
        public static class Madagascar { }

        [UnitedNationsMembership(1964, 12, 1)]
        [Capital((int)WorldCities.MalawiLilongwe)]
        [LargestCity((int)WorldCities.MalawiLilongwe)]
        public static class Malawi { }

        [UnitedNationsMembership(1957, 9, 17)]
        [Capital((int)WorldCities.MalaysiaKualaLumpur)]
        [AdministrativeCapital((int)WorldCities.MalaysiaPutrajaya)]
        [LargestCity((int)WorldCities.MalaysiaKualaLumpur)]
        public static class Malaysia { }

        [UnitedNationsMembership(1965, 9, 21)]
        [Capital((int)WorldCities.MaldivesMale)]
        [LargestCity((int)WorldCities.MaldivesMale)]
        public static class Maldives { }

        [UnitedNationsMembership(1960, 9, 28)]
        [Capital((int)WorldCities.MaliBamako)]
        [LargestCity((int)WorldCities.MaliBamako)]
        public static class Mali { }

        [UnitedNationsMembership(1964, 12, 1)]
        [Capital((int)WorldCities.MaltaValletta)]
        [LargestCity((int)WorldCities.MaltaValletta)]
        public static class Malta { }

        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.MarshallIslandsMajuro)]
        [LargestCity((int)WorldCities.MarshallIslandsMajuro)]
        public static class MarshallIslands { }

        [UnitedNationsMembership(1961, 10, 27)]
        [Capital((int)WorldCities.MauritaniaNouakchott)]
        [LargestCity((int)WorldCities.MauritaniaNouakchott)]
        public static class Mauritania { }

        [UnitedNationsMembership(1968, 4, 24)]
        [Capital((int)WorldCities.MauritiusPortLouis)]
        [LargestCity((int)WorldCities.MauritiusPortLouis)]
        public static class Mauritius { }

        [UnitedNationsMembership(1945, 11, 7)]
        [Capital((int)WorldCities.MexicoMexicoCity)]
        [LargestCity((int)WorldCities.MexicoMexicoCity)]
        public static class Mexico { }

        /// <summary>
        /// Federated States of Micronesia
        /// </summary>
        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.MicronesiaPalikir)]
        [LargestCity((int)WorldCities.MicronesiaPalikir)]
        public static class Micronesia { }

        /// <summary>
        /// Republic of Moldova
        /// </summary>
        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.MoldovaChișinău)]
        [LargestCity((int)WorldCities.MoldovaChișinău)]
        public static class Moldova { }

        [UnitedNationsMembership(1993, 5, 28)]
        [Capital((int)WorldCities.MonacoMonacoCity)]
        [LargestCity((int)WorldCities.MonacoMonacoCity)]
        public static class Monaco { }

        [UnitedNationsMembership(1961, 10, 27)]
        [Capital((int)WorldCities.MongoliaUlaanbaatar)]
        [LargestCity((int)WorldCities.MongoliaUlaanbaatar)]
        public static class Mongolia { }

        [UnitedNationsMembership(2006, 6, 28)]
        [Capital((int)WorldCities.MontenegroPodgorica)]
        [LargestCity((int)WorldCities.MontenegroPodgorica)]
        public static class Montenegro { }

        [UnitedNationsMembership(1956, 11, 12)]
        [Capital((int)WorldCities.MoroccoRabat)]
        [LargestCity((int)WorldCities.MoroccoCasablanca)]
        public static class Morocco { }

        [UnitedNationsMembership(1975, 9, 16)]
        [Capital((int)WorldCities.MozambiqueMaputo)]
        [LargestCity((int)WorldCities.MozambiqueMaputo)]
        public static class Mozambique { }

        [UnitedNationsMembership(1990, 4, 23)]
        [Capital((int)WorldCities.NamibiaWindhoek)]
        [LargestCity((int)WorldCities.NamibiaWindhoek)]
        public static class Namibia { }

        /// <summary>
        /// does not have an official capital city
        /// </summary>
        [UnitedNationsMembership(1999, 9, 14)]
        [Capital((int)WorldCities.NauruYaren)]
        [LargestCity((int)WorldCities.NauruYaren)]
        public static class Nauru { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.NepalKathmandu)]
        [LargestCity((int)WorldCities.NepalKathmandu)]
        public static class Nepal { }

        /// <summary>
        /// Kingdom of the Netherlands
        /// </summary>
        [UnitedNationsMembership(1945, 12, 10)]
        [Capital((int)WorldCities.NetherlandsAmsterdam)]
        [LargestCity((int)WorldCities.NetherlandsTheHague)]
        public static class Netherlands { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.NewZealandWellington)]
        [LargestCity((int)WorldCities.NewZealandAuckland)]
        public static class NewZealand { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.NicaraguaManagua)]
        [LargestCity((int)WorldCities.NicaraguaManagua)]
        public static class Nicaragua { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.NigerNiamey)]
        [LargestCity((int)WorldCities.NigerNiamey)]
        public static class Niger { }

        [UnitedNationsMembership(1960, 10, 7)]
        [Capital((int)WorldCities.NigeriaAbuja)]
        [LargestCity((int)WorldCities.NigeriaLagos)]
        public static class Nigeria { }

        /// <summary>
        /// Democratic People's Republic of Korea
        /// </summary>

        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.NorthKoreaPyongyang)]
        [LargestCity((int)WorldCities.NorthKoreaPyongyang)]
        public static class NorthKorea
        {
            public static class SupportedByRussiaToSomeExtent { }
            public static class SupportedByChinaToSomeExtent { }
            public static class PursuingNuclearWeapons { }
        }

        [UnitedNationsMembership(1993, 4, 8)]
        [Capital((int)WorldCities.NorthMacedoniaSkopje)]
        [LargestCity((int)WorldCities.NorthMacedoniaSkopje)]
        public static class NorthMacedonia { }

        [UnitedNationsMembership(1945, 11, 27)]
        [Capital((int)WorldCities.NorwayOslo)]
        [LargestCity((int)WorldCities.NorwayOslo)]
        public static class Norway { }

        [UnitedNationsMembership(1971, 10, 7)]
        [Capital((int)WorldCities.OmanMuscat)]
        [LargestCity((int)WorldCities.OmanMuscat)]
        public static class Oman { }

        [UnitedNationsMembership(1947, 9, 30)]
        [Capital((int)WorldCities.PakistanIslamabad)]
        [LargestCity((int)WorldCities.PakistanKarachi)]
        public static class Pakistan { }

        [UnitedNationsMembership(1994, 12, 15)]
        [Capital((int)WorldCities.PalauNgerulmud)]
        [LargestCity((int)WorldCities.PalauKoror)]
        public static class Palau { }

        [UnitedNationsMembership(1945, 11, 13)]
        [Capital((int)WorldCities.PanamaPanamaCity)]
        [LargestCity((int)WorldCities.PanamaPanamaCity)]
        public static class Panama { }

        [UnitedNationsMembership(1975, 10, 10)]
        [Capital((int)WorldCities.PapuaNewGuineaPortMoresby)]
        [LargestCity((int)WorldCities.PapuaNewGuineaPortMoresby)]
        public static class PapuaNewGuinea { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.ParaguayAsunción)]
        [LargestCity((int)WorldCities.ParaguayAsunción)]
        public static class Paraguay { }

        [UnitedNationsMembership(1945, 10, 31)]
        [Capital((int)WorldCities.PeruLima)]
        [LargestCity((int)WorldCities.PeruLima)]
        public static class Peru { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.PhilippinesManila)]
        [LargestCity((int)WorldCities.PhilippinesQuezonCity)]
        public static class Philippines { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.PolandWarsaw)]
        [LargestCity((int)WorldCities.PolandWarsaw)]
        public static class Poland { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.PortugalLisbon)]
        [LargestCity((int)WorldCities.PortugalLisbon)]
        public static class Portugal { }

        [UnitedNationsMembership(1971, 9, 21)]
        [Capital((int)WorldCities.QatarDoha)]
        [LargestCity((int)WorldCities.QatarDoha)]
        public static class Qatar { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.RomaniaBucharest)]
        [LargestCity((int)WorldCities.RomaniaBucharest)]
        public static class Romania { }

        /// <summary>
        /// Russian Federation
        /// </summary>
        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.RussiaMoscow)]
        [LargestCity((int)WorldCities.RussiaMoscow)]
        public static class Russia { }

        [UnitedNationsMembership(1962, 9, 18)]
        [Capital((int)WorldCities.RwandaKigali)]
        [LargestCity((int)WorldCities.RwandaKigali)]
        public static class Rwanda { }

        [UnitedNationsMembership(1983, 9, 23)]
        [Capital((int)WorldCities.SaintKittsAndNevisBasseterre)]
        [LargestCity((int)WorldCities.SaintKittsAndNevisBasseterre)]
        public static class SaintKittsAndNevis { }

        [UnitedNationsMembership(1979, 9, 18)]
        [Capital((int)WorldCities.SaintLuciaCastries)]
        [LargestCity((int)WorldCities.SaintLuciaCastries)]
        public static class SaintLucia { }

        [UnitedNationsMembership(1980, 9, 16)]
        [Capital((int)WorldCities.SaintVincentAndTheGrenadinesKingstown)]
        [LargestCity((int)WorldCities.SaintVincentAndTheGrenadinesKingstown)]
        public static class SaintVincentAndTheGrenadines { }

        [UnitedNationsMembership(1976, 12, 15)]
        [Capital((int)WorldCities.SamoaApia)]
        [LargestCity((int)WorldCities.SamoaApia)]
        public static class Samoa { }

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.SanMarinoSanMarinoCity)]
        [LargestCity((int)WorldCities.SanMarinoSanMarinoCity)]
        public static class SanMarino { }

        [UnitedNationsMembership(1975, 9, 16)]
        [Capital((int)WorldCities.SãoToméandPríncipeSãoTomé)]
        [LargestCity((int)WorldCities.SãoToméandPríncipeSãoTomé)]
        public static class SãoToméandPríncipe { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.SaudiArabiaRiyadh)]
        [LargestCity((int)WorldCities.SaudiArabiaJeddah)]
        public static class SaudiArabia { }

        [UnitedNationsMembership(1960, 9, 28)]
        [Capital((int)WorldCities.SenegalDakar)]
        [LargestCity((int)WorldCities.SenegalDakar)]
        public static class Senegal { }

        [UnitedNationsMembership(2000, 11, 1)]
        [Capital((int)WorldCities.SerbiaBelgrade)]
        [LargestCity((int)WorldCities.SerbiaBelgrade)]
        public static class Serbia { }

        [UnitedNationsMembership(1976, 9, 21)]
        [Capital((int)WorldCities.SeychellesVictoria)]
        [LargestCity((int)WorldCities.SeychellesVictoria)]
        public static class Seychelles { }

        [UnitedNationsMembership(1961, 9, 27)]
        [Capital((int)WorldCities.SierraLeoneFreetown)]
        [LargestCity((int)WorldCities.SierraLeoneFreetown)]
        public static class SierraLeone { }

        /// <summary>
        /// city-state
        /// </summary>
        [UnitedNationsMembership(1965, 9, 21)]
        [Capital((int)WorldCities.SingaporeSingapore)]
        [LargestCity((int)WorldCities.SingaporeSingapore)]
        public static class Singapore { }

        [UnitedNationsMembership(1993, 1, 19)]
        [Capital((int)WorldCities.SlovakiaBratislava)]
        [LargestCity((int)WorldCities.SlovakiaBratislava)]
        public static class Slovakia { }

        [UnitedNationsMembership(1992, 5, 22)]
        [Capital((int)WorldCities.SloveniaLjubljana)]
        [LargestCity((int)WorldCities.SloveniaLjubljana)]
        public static class Slovenia { }

        [UnitedNationsMembership(1978, 9, 19)]
        [Capital((int)WorldCities.SolomanIslandsHoniara)]
        [LargestCity((int)WorldCities.SolomanIslandsHoniara)]
        public static class SolomonIslands { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.SomaliaMogadishu)]
        [LargestCity((int)WorldCities.SomaliaMogadishu)]
        public static class Somalia { }

        [UnitedNationsMembership(1945, 11, 7)]
        [AdministrativeCapital((int)WorldCities.SouthAfricaPretoria)]
        [LegislativeCapital((int)WorldCities.SouthAfricaCapeTown)]
        [JudicialCapital((int)WorldCities.SouthAfricaBloemfontein)]
        [LargestCity((int)WorldCities.SouthAfricaJohannesburg)]
        public static class SouthAfrica { }

        /// <summary>
        /// Republic of Korea
        /// </summary>
        [UnitedNationsMembership(1991, 9, 17)]
        [Capital((int)WorldCities.SouthKoreaSeoul)]
        [LargestCity((int)WorldCities.SouthKoreaSeoul)]
        public static class SouthKorea
        {
            public static class SupportedByCountriesSupportingBothHumanFreedomAndCapitalism { }
        }

        [UnitedNationsMembership(2011, 7, 14)]
        [Capital((int)WorldCities.SouthSudanJuba)]
        [LargestCity((int)WorldCities.SouthSudanJuba)]
        public static class SouthSudan { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.SpainMadrid)]
        [LargestCity((int)WorldCities.SpainMadrid)]
        public static class Spain { }

        [UnitedNationsMembership(1955, 12, 14)]
        [Capital((int)WorldCities.SriLankaSriJayawardenepuraKotte)]
        [LargestCity((int)WorldCities.SriLankaColombo)]
        public static class SriLanka { }

        [UnitedNationsMembership(1956, 11, 12)]
        [Capital((int)WorldCities.SudanKhartoum)]
        [LargestCity((int)WorldCities.SudanKhartoum)]
        public static class Sudan { }

        [UnitedNationsMembership(1975, 12, 4)]
        [Capital((int)WorldCities.SurinameParamaribo)]
        [LargestCity((int)WorldCities.SurinameParamaribo)]
        public static class Suriname { }

        [UnitedNationsMembership(1946, 11, 19)]
        [Capital((int)WorldCities.SwedenStockholm)]
        [LargestCity((int)WorldCities.SwedenStockholm)]
        public static class Sweden { }

        [UnitedNationsMembership(1968, 9, 24)]
        [AdministrativeCapital((int)WorldCities.SwazilandMbabane)]
        [LegislativeCapital((int)WorldCities.SwazilandLobamba)]
        [RoyalCapital((int)WorldCities.SwazilandLobamba)]
        [LargestCity((int)WorldCities.SwazilandManzini)]
        [LocalName("Eswatini")]
        public static class Swaziland { }

        [UnitedNationsMembership(2002, 9, 10)]
        [Capital((int)WorldCities.SwitzerlandBern)]
        [LargestCity((int)WorldCities.SwitzerlandZurich)]
        public static class Switzerland { }

        /// <summary>
        /// Syrian Arab Republic
        /// </summary>
        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.SyriaDamascus)]
        [LargestCity((int)WorldCities.SyriaDamascus)]
        public static class Syria { }

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.TajikistanDushanbe)]
        [LargestCity((int)WorldCities.TajikistanDushanbe)]
        public static class Tajikistan { }

        /// <summary>
        /// United Republic of Tanzania
        /// </summary>
        [UnitedNationsMembership(1961, 12, 14)]
        [Capital((int)WorldCities.TanzaniaDodoma)]
        [LargestCity((int)WorldCities.TanzaniaDaresSalaam)]
        public static class Tanzania { }

        [UnitedNationsMembership(1946, 12, 15)]
        [Capital((int)WorldCities.ThailandBangkok)]
        [LargestCity((int)WorldCities.ThailandBangkok)]
        public static class Thailand { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.TogoLomé)]
        [LargestCity((int)WorldCities.TogoLomé)]
        public static class Togo { }

        [UnitedNationsMembership(1999, 9, 14)]
        [Capital((int)WorldCities.TongaNukualofa)]
        [LargestCity((int)WorldCities.TongaNukualofa)]
        public static class Tonga { }

        [UnitedNationsMembership(1962, 9, 18)]
        [Capital((int)WorldCities.TrinidadAndTobagoPortofSpain)]
        [LargestCity((int)WorldCities.TrinidadAndTobagoSanFernando)]
        public static class TrinidadAndTobago { }

        [UnitedNationsMembership(1956, 11, 12)]
        [Capital((int)WorldCities.TunisiaTunis)]
        [LargestCity((int)WorldCities.TunisiaTunis)]
        public static class Tunisia { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.TurkeyAnkara)]
        [LargestCity((int)WorldCities.TurkeyIstanbul)]
        [LocalName("Türkiye")]
        public static class Turkey { }

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.TurkmenistanAshgabat)]
        [LargestCity((int)WorldCities.TurkmenistanAshgabat)]
        public static class Turkmenistan { }

        [UnitedNationsMembership(2000, 9, 5)]
        [Capital((int)WorldCities.TuvaluFunafuti)]
        [LargestCity((int)WorldCities.TuvaluFunafuti)]
        public static class Tuvalu { }

        [UnitedNationsMembership(1962, 10, 25)]
        [Capital((int)WorldCities.UgandaKampala)]
        [LargestCity((int)WorldCities.UgandaKampala)]
        public static class Uganda { }

        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.UkraineKiev)]
        [LargestCity((int)WorldCities.UkraineKiev)]
        public static class Ukraine { }

        [UnitedNationsMembership(1971, 12, 9)]
        [Capital((int)WorldCities.UnitedArabEmiratesAbuDhabi)]
        [LargestCity((int)WorldCities.UnitedArabEmiratesDubai)]
        public static class UnitedArabEmirates { }

        /// <summary>
        /// United Kingdom of Great Britain and Northern Ireland
        /// </summary>
        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.UnitedKingdomLondon)]
        [LargestCity((int)WorldCities.UnitedKingdomLondon)]
        public static class UnitedKingdom { }

        /// <summary>
        /// United States of America
        /// </summary>
        [UnitedNationsMembership(1945, 10, 24)]
        [Capital((int)WorldCities.UnitedStatesWashingtonDC)]
        [LargestCity((int)WorldCities.UnitedStatesNewYorkCity)]
        public static class UnitedStates { }

        [UnitedNationsMembership(1945, 12, 18)]
        [Capital((int)WorldCities.UruguayMontevideo)]
        [LargestCity((int)WorldCities.UruguayMontevideo)]
        public static class Uruguay { }

        [UnitedNationsMembership(1992, 3, 2)]
        [Capital((int)WorldCities.UzbekistanTashkent)]
        [LargestCity((int)WorldCities.UzbekistanTashkent)]
        public static class Uzbekistan { }

        [UnitedNationsMembership(1981, 9, 15)]
        [Capital((int)WorldCities.VanuatuPortVila)]
        [LargestCity((int)WorldCities.VanuatuPortVila)]
        public static class Vanuatu { }

        /// <summary>
        /// Bolivarian Republic of Venezuela
        /// </summary>
        [UnitedNationsMembership(1945, 11, 15)]
        [Capital((int)WorldCities.VenezuelaCaracas)]
        [LargestCity((int)WorldCities.VenezuelaCaracas)]
        public static class Venezuela { }

        [UnitedNationsMembership(1977, 9, 20)]
        [Capital((int)WorldCities.VietnamHanoi)]
        [LargestCity((int)WorldCities.VietnamHoChiMinhCity)]
        public static class Vietnam { }

        /// <summary>
        /// de facto capital is Aden since the Houthi's control Sana'a
        /// </summary>
        [UnitedNationsMembership(1947, 9, 30)]
        [Capital((int)WorldCities.YemenSanaa)]
        [DeFactoCapital((int)WorldCities.YemenAden)]
        [LargestCity((int)WorldCities.YemenSanaa)]
        public static class Yemen { }

        [UnitedNationsMembership(1960, 9, 20)]
        [Capital((int)WorldCities.ZaireKinshasa)]
        [LargestCity((int)WorldCities.ZaireKinshasa)]
        public static class Zaire
        {
            public const string FullName = "Democratic Republic of the Congo";
            public static class DRC { }
        }

        [UnitedNationsMembership(1964, 12, 1)]
        [Capital((int)WorldCities.ZambiaLusaka)]
        [LargestCity((int)WorldCities.ZambiaLusaka)]
        public static class Zambia { }

        [UnitedNationsMembership(1980, 8, 25)]
        [Capital((int)WorldCities.ZimbabweHarare)]
        [LargestCity((int)WorldCities.ZimbabweHarare)]
        public static class Zimbabwe { }
    }

    public static class UnitedNationsNonMemberObserverStates
    {
        /// <summary>
        /// holds sovereignty over Vatican City
        /// gained all rights of full membership except voting on 2004-07-01
        /// </summary>
        [UnitedNationsMembership(1964, 4, 6)]
        public static class HolySee { }

        /// <summary>
        /// the fatah controlled element of palestine
        /// </summary>
        [UnitedNationsMembership(1974, 11, 22)]
        [DeFactoCapital((int)WorldCities.WestBankRamallah)]
        [ClaimedCapital((int)WorldCities.IsraelEastJerusalem)]
        [LargestCity((int)WorldCities.WestBankRamallah)]
        public static class Palestine { }

        /// <summary>
        /// not a sovereign state but an entity, has observer status
        /// </summary>
        public static class SovereignMilitaryOrderOfMalta { }
    }

    public static class CountryLikeThings
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
        /// Some Taiwanese politicians favor formal independence, while others prefer to maintain the current ambiguous status to prevent conflict.
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
        public static class Gaza { }

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
        [PopulationEstimate(400000)] //400,000
        public static class NorthernCyprus { }

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
        /// considers itself an autonomous state within Somalia
        /// recognizes the Somali federal government, but it operates with its own government, 
        /// security forces, and administration.
        /// has border disputes with Somaliland, especially over the Sool, Sanaag, and Cayn regions.
        /// </summary>
        [Capital((int)WorldCities.SomaliaGarowe)]
        [LargestCity((int)WorldCities.SomaliaGarowe)]
        public static class Puntland { }

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
}

