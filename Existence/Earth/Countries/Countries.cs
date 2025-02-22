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
        [Capital((int)WorldCities.CyprusNicosia)]
        [LargestCity((int)WorldCities.CyprusNicosia)]
        public static class Cyprus
        {
            public static class Breakaway
            {
                public static class NorthernCyprus
                {
                    public static class SupportedByTurkey { }
                    public const string FullName = "Turkish Republic of Northern Cyprus";
                    public static class TRNC { }
                }
            }
        }

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
        public static class Panama { }

        [UnitedNationsMembership(1975, 10, 10)]
        public static class PapuaNewGuinea { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Paraguay { }

        [UnitedNationsMembership(1945, 10, 31)]
        public static class Peru { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Philippines { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Poland { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Portugal { }

        [UnitedNationsMembership(1971, 9, 21)]
        public static class Qatar { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Romania { }

        /// <summary>
        /// Russian Federation
        /// </summary>
        [UnitedNationsMembership(1945, 10, 24)]
        public static class Russia { }

        [UnitedNationsMembership(1962, 9, 18)]
        public static class Rwanda { }

        [UnitedNationsMembership(1983, 9, 23)]
        public static class SaintKittsAndNevis { }

        [UnitedNationsMembership(1979, 9, 18)]
        public static class SaintLucia { }

        [UnitedNationsMembership(1980, 9, 16)]
        public static class SaintVincentAndTheGrenadines { }

        [UnitedNationsMembership(1976, 12, 15)]
        public static class Samoa { }

        [UnitedNationsMembership(1992, 3, 2)]
        public static class SanMarino { }

        [UnitedNationsMembership(1975, 9, 16)]
        public static class SaoTomeAndPrincipe { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class SaudiArabia { }

        [UnitedNationsMembership(1960, 9, 28)]
        public static class Senegal { }

        [UnitedNationsMembership(2000, 11, 1)]
        public static class Serbia
        {
            public static class Breakaway
            {
                public static class Kosovo
                {
                    public static class SupportedByMostOfTheWorldButStatesWithOwnBreakawayProblemsDontAcknowledgeOtherBreakawayStates { }
                }
            }
        }

        [UnitedNationsMembership(1976, 9, 21)]
        public static class Seychelles { }

        [UnitedNationsMembership(1961, 9, 27)]
        public static class SierraLeone { }

        [UnitedNationsMembership(1965, 9, 21)]
        public static class Singapore { }

        [UnitedNationsMembership(1993, 1, 19)]
        public static class Slovakia { }

        [UnitedNationsMembership(1992, 5, 22)]
        public static class Slovenia { }

        [UnitedNationsMembership(1978, 9, 19)]
        public static class SolomonIslands { }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class Somalia { }

        [UnitedNationsMembership(1945, 11, 7)]
        public static class SouthAfrica { }

        /// <summary>
        /// Republic of Korea
        /// </summary>
        [UnitedNationsMembership(1991, 9, 17)]
        public static class SouthKorea
        {
            public static class SupportedByCountriesSupportingBothHumanFreedomAndCapitalism { }
        }

        [UnitedNationsMembership(2011, 7, 14)]
        public static class SouthSudan { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Spain { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class SriLanka { }

        [UnitedNationsMembership(1956, 11, 12)]
        public static class Sudan { }

        [UnitedNationsMembership(1975, 12, 4)]
        public static class Suriname { }

        [UnitedNationsMembership(1946, 11, 19)]
        public static class Sweden { }

        [UnitedNationsMembership(1968, 9, 24)]
        [LocalName("Eswatini")]
        public static class Swaziland { }

        [UnitedNationsMembership(2002, 9, 10)]
        public static class Switzerland { }

        /// <summary>
        /// Syrian Arab Republic
        /// </summary>
        [UnitedNationsMembership(1945, 10, 24)]
        public static class Syria { }

        [UnitedNationsMembership(1992, 3, 2)]
        public static class Tajikistan { }

        /// <summary>
        /// United Republic of Tanzania
        /// </summary>
        [UnitedNationsMembership(1961, 12, 14)]
        public static class Tanzania { }

        [UnitedNationsMembership(1946, 12, 15)]
        public static class Thailand { }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class Togo { }

        [UnitedNationsMembership(1999, 9, 14)]
        public static class Tonga { }

        [UnitedNationsMembership(1962, 9, 18)]
        public static class TrinidadAndTobago { }

        [UnitedNationsMembership(1956, 11, 12)]
        public static class Tunisia { }

        [UnitedNationsMembership(1945, 10, 24)]
        [LocalName("Türkiye")]
        public static class Turkey { }

        [UnitedNationsMembership(1992, 3, 2)]
        public static class Turkmenistan { }

        [UnitedNationsMembership(2000, 9, 5)]
        public static class Tuvalu { }

        [UnitedNationsMembership(1962, 10, 25)]
        public static class Uganda { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Ukraine { }

        [UnitedNationsMembership(1971, 12, 9)]
        public static class UnitedArabEmirates { }

        /// <summary>
        /// United Kingdom of Great Britain and Northern Ireland
        /// </summary>
        [UnitedNationsMembership(1945, 10, 24)]
        public static class UnitedKingdom { }

        /// <summary>
        /// United States of America
        /// </summary>
        [UnitedNationsMembership(1945, 10, 24)]
        public static class UnitedStates { }

        [UnitedNationsMembership(1945, 12, 18)]
        public static class Uruguay { }

        [UnitedNationsMembership(1992, 3, 2)]
        public static class Uzbekistan { }

        [UnitedNationsMembership(1981, 9, 15)]
        public static class Vanuatu { }

        /// <summary>
        /// Bolivarian Republic of Venezuela
        /// </summary>
        [UnitedNationsMembership(1945, 11, 15)]
        public static class Venezuela { }

        [UnitedNationsMembership(1977, 9, 20)]
        public static class Vietnam { }

        [UnitedNationsMembership(1947, 9, 30)]
        public static class Yemen { }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class Zaire
        {
            public const string FullName = "Democratic Republic of the Congo";
            public static class DRC { }
        }

        [UnitedNationsMembership(1964, 12, 1)]
        public static class Zambia { }

        [UnitedNationsMembership(1980, 8, 25)]
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

        [UnitedNationsMembership(1974, 11, 22)]
        public static class Palestine { }

        /// <summary>
        /// not a sovereign state but an entity, has observer status
        /// </summary>
        public static class SovereignMilitaryOrderOfMalta { }
    }

    public static class NuclearWeaponStates
    {
        /// <summary>
        /// 5044 total warheads, 1770 deployed warheads
        /// </summary>
        public static class UnitedStates { }

        /// <summary>
        /// 5580 total warheads, 1710 deployed warheads
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
        public static class Pakistn { }

        /// <summary>
        /// 90 total warheads, none deployed
        /// </summary>
        public static class Israel { }

        /// <summary>
        /// 50 total warheads, none deployed
        /// </summary>
        public static class NorthKorea { }
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
            public static class GazaStrip
            {
                public static class RuledByHamas { }
            }
            public static class WestBank
            {
                public static class RuledByFatah { }
            }
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

