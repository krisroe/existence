
namespace Existence.Earth.Countries.UnitedStates
{
    public enum FederalGovernmentBranches
    {
        Executive,
        Judicial,
        Legislative
    }

    //per the Presidential Succession Act of 1947, referenced in the 25th amendment
    public static class PresidentialSuccession
    {
        public static class VicePresident { }
        public static class SpeakerOfTheHouseOfRepresentatives { }
        public static class PresidentProTemporeOfTheSenate { }
        public static class SecretaryOfState { }
        public static class SecretaryOfTreasury { }
        public static class SecretaryOfDefense { }
        public static class AttorneyGeneral { }
        public static class SecretaryOfTheInterior { }
        public static class SecretaryOfAgriculture { }
        public static class SecretaryOfCommerce { }
        public static class SecretaryOfLabor { }
        public static class SecretaryOfHealthAndHumanServices { }
        public static class SecretaryOfHousingAndUrbanDevelopment { }
        public static class SecretaryOfTransportation { }
        public static class SecretaryOfEnergy { }
        public static class SecretaryOfEducation { }
        public static class SecretaryOfVeteransAffairs { }
        public static class SecretaryOfHomelandSecurity { }
    }

    public static class FederalCourtSystem
    {
        public static class AppealsCourts
        {
            [USCity(USCities.MassachusettsBoston)]
            public static class FirstCircuit
            {
                [USCity(USCities.MainePortland)]
                public static class Maine { }

                [USCity(USCities.NewHampshireConcord)]
                public static class NewHampshire { }

                [USCity(USCities.MassachusettsBoston)]
                public static class Massachusetts { }

                [USCity(USCities.RhodeIslandProvidence)]
                public static class RhodeIsland { }

                /// <summary>
                /// Article III court (Puerto Rico was given "judicial parity" with the states), per
                /// Federal Judgeship Act of 1966 (Public Law 89-571) (September 12, 1966)
                /// </summary>
                [USCity(USCities.PuertoRicoSanJuan)]
                public static class PuertoRico { }
            }

            [USCity(USCities.NewYorkNewYorkCity)]
            public static class SecondCircuit
            {
                [USCity(USCities.VermontBurlington)]
                public static class Vermont { }

                [USCity(USCities.NewYorkSyracuse)]
                public static class NewYorkNorthern { }

                [USCity(USCities.NewYorkBuffalo)]
                public static class NewYorkWestern { }

                [USCity(USCities.NewYorkBrooklyn)]
                public static class NewYorkEastern { }

                [USCity(USCities.NewYorkNewYorkCity)]
                public static class NewYorkSouthern { }

                [USCity(USCities.ConnecticutNewHaven)]
                public static class Connecticut { }
            }

            [USCity(USCities.PennsylvaniaPhiladelphia)]
            public static class ThirdCircuit
            {
                [USCities(USCities.NewJerseyNewark)]
                public static class NewJersey { }

                [USCities(USCities.DelawareWilmington)]
                public static class Delaware { }

                [USCities(USCities.PennsylvaniaPhiladelphia)]
                public static class PennsylvaniaEastern { }

                [USCities(USCities.PennsylvaniaScranton)]
                public static class PennsylvaniaMiddle { }

                [USCities(USCities.PennsylvaniaPittsburgh)]
                public static class PennsylvaniaWestern { }

                /// <summary>
                /// Article IV Territorial Court
                /// </summary>

                [USCities(USCities.UnitedStatesVirginIslandsSaintCroix, USCities.UnitedStatesVirginIslandsSaintThomas)]
                public static class UnitedStatesVirginIslands { }
            }

            [USCities(USCities.VirginiaRichmond)]
            public static class FourthCircuit
            {
                [USCity(USCities.MarylandBaltimore)]
                public static class Maryland { }

                [USCity(USCities.WestVirginiaWheeling)]
                public static class WestVirginiaNorthern { }

                [USCity(USCities.WestVirginiaCharleston)]
                public static class WestVirginiaSouthern { }

                [USCity(USCities.VirginiaRichmond)]
                public static class VirginiaEastern { }

                [USCity(USCities.VirginiaRoanoke)]
                public static class VirginiaWestern { }

                [USCity(USCities.NorthCarolinaCharlotte)]
                public static class NorthCarolinaWestern { }

                [USCity(USCities.NorthCarolinaGreensboro)]
                public static class NorthCarolinaMiddle { }

                [USCity(USCities.NorthCarolinaRaleigh)]
                public static class NorthCarolinaEastern { }

                [USCity(USCities.SouthCarolinaColumbia)]
                public static class SouthCarolina { }
            }

            /// <summary>
            /// has additional courthouses beyond the circuit HQ
            /// </summary>
            [USCity(USCities.LouisianaNewOrleans)]
            [USCities(USCities.MississippiJackson, USCities.TexasHouston)]
            public static class FifthCircuit
            {
                [USCity(USCities.TexasSanAntonio)]
                public static class TexasWestern { }

                [USCity(USCities.TexasDallas)]
                public static class TexasNorthern { }

                [USCity(USCities.TexasHouston)]
                public static class TexasSouthern { }

                [USCities(USCities.TexasTyler)]
                public static class TexasEastern { }

                [USCity(USCities.LouisianaShreveport)]
                public static class LouisianaWestern { }

                [USCity(USCities.LouisianaBatonRouge)]
                public static class LouisianaMiddle { }

                [USCity(USCities.LouisianaNewOrleans)]
                public static class LouisianaEastern { }

                [USCity(USCities.MississippiOxford)]
                public static class MississippiNorthern { }

                [USCity(USCities.MississippiJackson)]
                public static class MississippiSouthern { }
            }

            [USCity(USCities.OhioCincinnati)]
            public static class SixthCircuit
            {
                [USCity(USCities.MichiganGrandRapids)]
                public static class MichiganWestern { }

                [USCity(USCities.MichiganDetroit)]
                public static class MichiganEastern { }

                [USCity(USCities.OhioCleveland)]
                public static class OhioNorthern { }

                [USCity(USCities.OhioColumbus)]
                public static class OhioSouthern { }

                [USCity(USCities.KentuckyLouisville)]
                public static class KentuckyWestern { }

                [USCity(USCities.KentuckyLexington)]
                public static class KentuckyEastern { }

                [USCity(USCities.TennesseeMemphis)]
                public static class TennesseeWestern { }

                [USCity(USCities.TennesseeNashville)]
                public static class TennesseeMiddle { }

                [USCity(USCities.TennesseeKnoxville)]
                public static class TennesseeEastern { }
            }

            [USCity(USCities.IllinoisChicago)]
            public static class SeventhCircuit
            {
                [USCity(USCities.WisconsinMilwaukee)]
                public static class WisconsinEastern { }

                [USCity(USCities.WisconsinMadison)]
                public static class WisconsinWestern { }

                [USCity(USCities.IllinoisChicago)]
                public static class IllinoisNorthern { }

                [USCity(USCities.IllinoisSpringfield)]
                public static class IllinoisCentral { }

                [USCity(USCities.IllinoisEastSaintLouis)]
                public static class IllinoisSouthern { }

                [USCity(USCities.IndianaSouthBend)]
                public static class IndianaNorthern { }

                [USCity(USCities.IndianaIndianapolis)]
                public static class IndianaSouthern { }
            }

            /// <summary>
            /// has additional courthouses beyond the circuit HQ
            /// </summary>
            [USCity(USCities.MissouriSaintLouis)]
            [USCities(USCities.MinnesotaSaintPaul, USCities.MissouriKansasCity)]
            public static class EighthCircuit
            {
                [USCity(USCities.NorthDakotaBismarck)]
                public static class NorthDakota { }

                [USCity(USCities.SouthDakotaSiouxFalls)]
                public static class SouthDakota { }

                [USCity(USCities.MinnesotaSaintPaul)]
                public static class Minnesota { }

                [USCity(USCities.NebraskaOmaha)]
                public static class Nebraska { }

                [USCity(USCities.IowaCedarRapids)]
                public static class IowaNorthern { }

                [USCity(USCities.IowaDesMoines)]
                public static class IowaSouthern { }

                [USCity(USCities.MissouriKansasCity)]
                public static class MissouriWestern { }

                [USCity(USCities.MissouriSaintLouis)]
                public static class MissouriEastern { }

                [USCity(USCities.ArkansasFortSmith)]
                public static class ArkansasWestern { }

                [USCity(USCities.ArkansasLittleRock)]
                public static class ArkansasEastern { }
            }

            /// <summary>
            /// has additional courthouses beyond the circuit HQ
            /// </summary>
            [USCity(USCities.CaliforniaSanFrancisco)]
            [USCities(USCities.CaliforniaPasadena, USCities.OregonPortland, USCities.WashingtonSeattle)]
            public static class NinthCircuit
            {
                [USCity(USCities.AlaskaAnchorage)]
                public static class Alaska { }

                [USCity(USCities.WashingtonSeattle)]
                public static class WashingtonWestern { }

                [USCity(USCities.WashingtonSpokane)]
                public static class WashingtonEastern { }

                [USCity(USCities.IdahoBoise)]
                public static class Idaho { }

                [USCity(USCities.MontanaBillings)]
                public static class Montana { }

                [USCity(USCities.OregonPortland)]
                public static class Oregon { }

                [USCity(USCities.CaliforniaSanFrancisco)]
                public static class CaliforniaNorthern { }

                [USCity(USCities.CaliforniaSacramento)]
                public static class CaliforniaEastern { }

                [USCity(USCities.CaliforniaLosAngeles)]
                public static class CaliforniaCentral { }

                [USCity(USCities.CaliforniaSanDiego)]
                public static class CaliforniaSouthern { }

                [USCity(USCities.NevadaLasVegas)]
                public static class Nevada { }

                [USCity(USCities.ArizonaPhoenix)]
                public static class Arizona { }

                [USCity(USCities.HawaiiHonolulu)]
                public static class Hawaii { }

                /// <summary>
                /// Article IV Territorial Court
                /// </summary>
                [USCity(USCities.GuamHagåtña)]
                public static class Guam { }

                /// <summary>
                /// Article IV Territorial Court
                /// </summary>
                [USCity(USCities.NorthernMarianaIslandsSaipan)]
                public static class NorthernMarianaIslands { }
            }

            /// <summary>
            /// has additional courthouses beyond the circuit HQ
            /// </summary>
            [USCity(USCities.ColoradoDenver)]
            [USCities(USCities.NewMexicoAlbuquerque, USCities.UtahSaltLakeCity)]
            public static class TenthCircuit
            {
                [USCity(USCities.WyomingCheyenne)]
                public static class Wyoming { }

                [USCity(USCities.ColoradoDenver)]
                public static class Colorado { }

                [USCity(USCities.UtahSaltLakeCity)]
                public static class Utah { }

                [USCity(USCities.NewMexicoAlbuquerque)]
                public static class NewMexico { }

                [USCity(USCities.KansasTopeka)]
                public static class Kansas { }

                [USCity(USCities.OklahomaOklahomaCity)]
                public static class OklahomaWestern { }

                [USCity(USCities.OklahomaTulsa)]
                public static class OklahomaNorthern { }

                [USCity(USCities.OklahomaMuskogee)]
                public static class OklahomaEastern { }
            }

            [USCity(USCities.GeorgiaAtlanta)]
            public static class EleventhCircuit
            {
                [USCity(USCities.AlabamaBirmingham)]
                public static class AlabamaNorthern { }

                [USCity(USCities.AlabamaMontgomery)]
                public static class AlabamaMiddle { }

                [USCity(USCities.AlabamaMobile)]
                public static class AlabamaSouthern { }

                [USCity(USCities.GeorgiaAtlanta)]
                public static class GeorgiaNorthern { }

                [USCity(USCities.GeorgiaMacon)]
                public static class GeorgiaMiddle { }

                [USCity(USCities.GeorgiaSavannah)]
                public static class GeorgiaSouthern { }

                [USCity(USCities.FloridaTallahassee)]
                public static class FloridaNorthern { }

                [USCity(USCities.FloridaOrlando)]
                public static class FloridaMiddle { }

                [USCity(USCities.FloridaMiami)]
                public static class FloridaSouthern { }
            }

            [USCity(USCities.WashingtonDistrictOfColumbia)]
            public static class DistrictOfColumbiaCircuit
            {
                [USCity(USCities.WashingtonDistrictOfColumbia)]
                public static class DistrictOfColumnbiaWashingtonDC { }
            }
            /// <summary>
            /// Non-geographical jurisdiction over certain federal district courts (e.g. patent cases).
            /// And handles appeals from certain federal courts:
            /// 1. US Court of Federal Claims
            /// 2. US Court of International Trade
            /// 3. US Patent and Trademark Office (USPTO)
            /// 4. US Merit Systems Protection Board
            /// 5. US International Trade Commission
            /// </summary>
            [USCity(USCities.WashingtonDistrictOfColumbia)]
            public static class FederalCircuit { }
        }
    }
}
