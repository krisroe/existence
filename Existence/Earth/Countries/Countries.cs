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

    public static class CountriesAlphabetical
    {
        [UnitedNationsMembership(1946, 11, 19)]
        [Capital((int)WorldCities.AfghanistanKabul)]
        [LargestCity((int)WorldCities.AfghanistanKabul)]
        public static class Afghanistan { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Albania { }

        [UnitedNationsMembership(1962, 10, 8)]
        public static class Algeria { }

        [UnitedNationsMembership(1993, 7, 28)]
        public static class Andorra { }

        [UnitedNationsMembership(1976, 12, 1)]
        public static class Angola { }

        [UnitedNationsMembership(1981, 11, 11)]
        public static class AntiguaAndBarbuda { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Argentina { }

        [UnitedNationsMembership(1992, 3, 2)]
        public static class Armenia { }

        [UnitedNationsMembership(1945, 11, 1)]
        public static class Australia { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Austria { }

        [UnitedNationsMembership(1992, 3, 2)]
        public static class Azerbaijan { }

        [UnitedNationsMembership(1973, 9, 18)]
        public static class Bahamas { }

        [UnitedNationsMembership(1971, 9, 21)]
        public static class Bahrain { }

        [UnitedNationsMembership(1974, 9, 17)]
        public static class Bangladesh { }

        [UnitedNationsMembership(1966, 12, 9)]
        public static class Barbados { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Belarus { }

        [UnitedNationsMembership(1945, 12, 27)]
        public static class Belgium { }

        [UnitedNationsMembership(1981, 9, 25)]
        public static class Belize { }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class Benin { }

        [UnitedNationsMembership(1971, 9, 21)]
        public static class Bhutan { }

        /// <summary>
        /// Plurinational State of Bolivia
        /// </summary>
        [UnitedNationsMembership(1945, 11, 14)]
        public static class Bolivia { }

        [UnitedNationsMembership(1992, 5, 22)]
        public static class BosniaAndHerzegovina { }

        [UnitedNationsMembership(1966, 10, 17)]
        public static class Botswana { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Brazil { }

        /// <summary>
        /// Brunei Darussalam
        /// </summary>
        [UnitedNationsMembership(1984, 9, 21)]
        public static class Brunei { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Bulgaria { }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class BurkinaFaso { }

        public static class Burma
        {
            public const string LocalName = "Myanmar";
            public const bool LocalNameIsOfficialName = true;
        }

        [UnitedNationsMembership(1962, 9, 18)]
        public static class Burundi { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Cambodia { }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class Cameroon { }

        [UnitedNationsMembership(1945, 11, 9)]
        public static class Canada { }

        [UnitedNationsMembership(1975, 9, 16)]
        public static class CapeVerde
        {
            public const string LocalName = "CaboVerde";
        }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class CentralAfricanRepublic { }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class Chad { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Chile { }

        [UnitedNationsMembership(1945, 10, 24)]
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
        public static class Colombia { }

        [UnitedNationsMembership(1975, 11, 12)]
        public static class Comoros { }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class Congo
        {
            public const string FullName = "Republic of the Congo";
            public static class ROC { }
        }

        [UnitedNationsMembership(1945, 11, 2)]
        public static class CostaRica { }

        [UnitedNationsMembership(1992, 5, 22)]
        public static class Croatia { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Cuba { }

        [UnitedNationsMembership(1960, 9, 20)]
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
        public static class CzechRepublic
        {
            public const string LocalName = "Czechia";
        }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Denmark { }

        [UnitedNationsMembership(1977, 9, 20)]
        public static class Djibouti { }

        [UnitedNationsMembership(1978, 12, 18)]
        public static class Dominica { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class DominicanRepublic { }

        [UnitedNationsMembership(2002, 9, 27)]
        public static class EastTimor
        {
            public const string LocalName = "Timor-Leste";
        }

        [UnitedNationsMembership(1945, 12, 21)]
        public static class Ecuador { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Egypt { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class ElSalvador { }

        [UnitedNationsMembership(1968, 11, 12)]
        public static class EquatorialGuinea { }

        [UnitedNationsMembership(1993, 5, 28)]
        public static class Eritrea { }

        [UnitedNationsMembership(1991, 9, 17)]
        public static class Estonia { }

        [UnitedNationsMembership(1945, 11, 13)]
        public static class Ethiopia { }

        [UnitedNationsMembership(1970, 10, 13)]
        public static class Fiji { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Finland { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class France { }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class Gabon { }

        /// <summary>
        /// Republic of the Gambia
        /// </summary>
        [UnitedNationsMembership(1965, 9, 21)]
        public static class Gambia { }

        [UnitedNationsMembership(1992, 7, 31)]
        public static class Georgia { }

        [UnitedNationsMembership(1973, 9, 18)]
        public static class Germany { }

        [UnitedNationsMembership(1957, 3, 8)]
        public static class Ghana { }

        [UnitedNationsMembership(1945, 10, 25)]
        public static class Greece { }

        [UnitedNationsMembership(1974, 9, 17)]
        public static class Grenada { }

        [UnitedNationsMembership(1945, 11, 21)]
        public static class Guatemala { }

        [UnitedNationsMembership(1958, 12, 12)]
        public static class Guinea { }

        [UnitedNationsMembership(1974, 9, 17)]
        public static class GuineaBissau { }

        [UnitedNationsMembership(1966, 9, 20)]
        public static class Guyana { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Haiti { }

        [UnitedNationsMembership(1945, 12, 17)]
        public static class Honduras { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Hungary { }

        [UnitedNationsMembership(1946, 11, 19)]
        public static class Iceland { }

        [UnitedNationsMembership(1945, 10, 30)]
        public static class India { }

        [UnitedNationsMembership(1950, 9, 28)]
        public static class Indonesia { }

        /// <summary>
        /// Islamic Republic of Iran
        /// </summary>
        [UnitedNationsMembership(1945, 10, 24)]
        public static class Iran { }

        [UnitedNationsMembership(1945, 12, 21)]
        public static class Iraq { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Ireland { }

        [UnitedNationsMembership(1949, 5, 11)]
        public static class Israel
        {
            public static class ParliamentaryDemocracy { }
            public static class JewishReligionState { }
        }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Italy { }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class IvoryCoast
        {
            public const string LocalName = "Côte D'Ivoire";
        }

        [UnitedNationsMembership(1962, 9, 18)]
        public static class Jamaica { }

        [UnitedNationsMembership(1956, 12, 18)]
        public static class Japan { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Jordan { }

        [UnitedNationsMembership(1992, 3, 2)]
        public static class Kazakhstan { }

        [UnitedNationsMembership(1963, 12, 16)]
        public static class Kenya { }

        [UnitedNationsMembership(1999, 9, 14)]
        public static class Kiribati { }

        [UnitedNationsMembership(1963, 5, 14)]
        public static class Kuwait { }

        [UnitedNationsMembership(1992, 3, 2)]
        public static class Kyrgyzstan { }

        /// <summary>
        /// Lao People’s Democratic Republic
        /// </summary>
        [UnitedNationsMembership(1955, 12, 14)]
        public static class Laos { }

        [UnitedNationsMembership(1991, 9, 17)]
        public static class Latvia { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Lebanon { }

        [UnitedNationsMembership(1966, 10, 17)]
        public static class Lesotho { }

        [UnitedNationsMembership(1945, 11, 2)]
        public static class Liberia { }

        [UnitedNationsMembership(1955, 12, 14)]
        public static class Libya { }

        [UnitedNationsMembership(1990, 9, 18)]
        public static class Liechtenstein { }

        [UnitedNationsMembership(1991, 9, 17)]
        public static class Lithuania { }

        [UnitedNationsMembership(1945, 10, 24)]
        public static class Luxembourg { }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class Madagascar { }

        [UnitedNationsMembership(1964, 12, 1)]
        public static class Malawi { }

        [UnitedNationsMembership(1957, 9, 17)]
        public static class Malaysia { }

        [UnitedNationsMembership(1965, 9, 21)]
        public static class Maldives { }

        [UnitedNationsMembership(1960, 9, 28)]
        public static class Mali { }

        [UnitedNationsMembership(1964, 12, 1)]
        public static class Malta { }

        [UnitedNationsMembership(1991, 9, 17)]
        public static class MarshallIslands { }

        [UnitedNationsMembership(1961, 10, 27)]
        public static class Mauritania { }

        [UnitedNationsMembership(1968, 4, 24)]
        public static class Mauritius { }

        public static class Mexico { }
        public static class Micronesia { }
        public static class Moldova { }
        public static class Monaco { }
        public static class Mongolia { }
        public static class Mozambique { }
        public static class Montenegro { }
        public static class Morocco { }
        public static class Namibia { }
        public static class Nauru { }
        public static class Nepal { }
        public static class Netherlands { }
        public static class NewZealand { }
        public static class Nicaragua { }
        public static class Niger { }
        public static class Nigeria { }

        [UnitedNationsMembership(1991, 9, 17)]
        public static class NorthKorea
        {
            public static class SupportedByRussiaToSomeExtent { }
            public static class SupportedByChinaToSomeExtent { }
            public static class PursuingNuclearWeapons { }
        }

        public static class NorthMacedonia { }
        public static class Norway { }
        public static class Oman { }
        public static class Pakistan { }
        public static class Palau { }
        public static class Panama { }
        public static class PapuaNewGuinea { }
        public static class Paraguay { }
        public static class Peru { }
        public static class Philippines { }
        public static class Poland { }
        public static class Portugal { }
        public static class Qatar { }
        public static class Romania { }
        public static class Russia { }
        public static class Rwanda { }
        public static class SaintKittsAndNevis { }
        public static class SaintLucia { }
        public static class SaintVincentAndTheGrenadines { }
        public static class Samoa { }
        public static class SanMarino { }
        public static class SaoTomeAndPrincipe { }
        public static class SaudiArabia { }
        public static class Senegal { }
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
        public static class Seychelles { }
        public static class SierraLeone { }
        public static class Singapore { }
        public static class Slovakia { }
        public static class Slovenia { }
        public static class SolomonIslands { }
        public static class Somalia { }
        public static class SouthAfrica { }
        public static class SouthKorea
        {
            public static class SupportedByCountriesSupportingBothHumanFreedomAndCapitalism { }
        }
        public static class SouthSudan { }
        public static class Spain { }
        public static class SriLanka { }
        public static class Sudan { }
        public static class Suriname { }
        public static class Sweden { }

        [UnitedNationsMembership(1968, 9, 24)]
        public static class Swaziland
        {
            public const string LocalName = "Eswatini";
        }
        public static class Switzerland { }
        public static class Syria { }

        public static class Taiwan
        {
            public static class SupportedByCountriesSupportingBothHumanFreedomAndCapitalism { }
            public static class ButSupportIsTacitToAvoidOffendingChina { }
            public static class DeFactoIndependent { }
            public const string FullName = "Republic of China";
            public static class ROC { }
            public static class PresumablyWillBeEventuallyIndependent { }
        }

        public static class Tajikistan { }
        public static class Tanzania { }
        public static class Thailand { }
        public static class Togo { }
        public static class Tonga { }
        public static class TrinidadAndTobago { }
        public static class Tunisia { }
        public static class Turkey { }
        public static class Tuvalu { }
        public static class Turkmenistan { }
        public static class Uganda { }
        public static class Ukraine { }
        public static class UnitedArabEmirates { }
        public static class UnitedKingdom { }
        public static class UnitedStates { }
        public static class Uruguay { }
        public static class Uzbekistan { }
        public static class Vanuatu { }
        public static class VaticanCity { }
        public static class Venezuela { }
        public static class Vietnam { }
        public static class Yemen { }

        [UnitedNationsMembership(1960, 9, 20)]
        public static class Zaire
        {
            public const string FullName = "Democratic Republic of the Congo";
            public static class DRC { }
        }
        public static class Zambia { }
        public static class Zimbabwe { }
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
        public static class EventuallyNorthKoreaWillBeAbsorbedIntoSouthKorea { }
    }
}
