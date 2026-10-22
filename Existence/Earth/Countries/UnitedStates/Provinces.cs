using System;

namespace Existence.Earth.Countries.UnitedStates
{
    public class StateSubsidiaryAttribute : Attribute
    {
        public int StateSubsidiary { get; set; }
        public StateSubsidiaryAttribute(int StateSubsidiary)
        {
            this.StateSubsidiary = StateSubsidiary;
        }
    }

    public class StateSubsidiariesAttribute : Attribute
    {
        public int[] StateSubsidiaries { get; set; }

        public StateSubsidiariesAttribute(params int[] StateSubsidiaries)
        {
            this.StateSubsidiaries = StateSubsidiaries;
        }
    }

    public class ProvincesAttribute : Attribute
    {
        public int[] Provinces { get; set; }
        public ProvincesAttribute(params int[] Provinces)
        {
            this.Provinces = Provinces;
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ProvinceAttribute : Attribute
    {
        public int Province { get; set; }
        public ProvinceAttribute(int Province)
        {
            this.Province = Province;
        }
    }

    public class TerritoriesAttribute : Attribute
    {
        public int[] Territories { get; set; }
        public TerritoriesAttribute(params int[] Territories)
        {
            this.Territories = Territories;
        }
    }

    public class TerritoryAttribute : Attribute
    {
        public int Territory { get; set; }
        public TerritoryAttribute(int Territory)
        {
            this.Territory = Territory;
        }
    }

    public class StateSubsidiaryTypeAttribute : Attribute
    {
        public StateSubsidaryType StateSubsidiaryType { get; set; }
        public StateSubsidiaryTypeAttribute(StateSubsidaryType StateSubsidiaryType)
        {
            this.StateSubsidiaryType = StateSubsidiaryType;
        }
    }

    public enum StateSubsidaryType
    {
        Province,
        Territory,
        District,
    }

    public enum StateSubsidiariesUnitedStates
    {
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.AlabamaMontgomery)]
        [LargestCity((int)USCities.AlabamaHuntsville)]
        Alabama,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.AlaskaJuneau)]
        [LargestCity((int)USCities.AlaskaAnchorage)]
        Alaska,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.ArizonaPhoenix)]
        [LargestCity((int)USCities.ArizonaPhoenix)]
        Arizona,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.ArkansasLittleRock)]
        [LargestCity((int)USCities.ArkansasLittleRock)]
        Arkansas,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.CaliforniaSacramento)]
        [LargestCity((int)USCities.CaliforniaLosAngeles)]
        California,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.ColoradoDenver)]
        [LargestCity((int)USCities.ColoradoDenver)]
        Colorado,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.ConnecticutHartford)]
        [LargestCity((int)USCities.ConnectucutBridgeport)]
        Connecticut,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.DelawareDover)]
        [LargestCity((int)USCities.DelawareWilmington)]
        Delaware,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.FloridaTallahassee)]
        [LargestCity((int)USCities.FloridaJacksonville)]
        Florida,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.GeorgiaAtlanta)]
        [LargestCity((int)USCities.GeorgiaAtlanta)]
        Georgia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.HawaiiHonolulu)]
        [LargestCity((int)USCities.HawaiiHonolulu)]
        Hawaii,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.IdahoBoise)]
        [LargestCity((int)USCities.IdahoBoise)]
        Idaho,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.IllinoisSpringfield)]
        [LargestCity((int)USCities.IllinoisChicago)]
        Illinois,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.IndianaIndianapolis)]
        [LargestCity((int)USCities.IndianaIndianapolis)]
        Indiana,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.IowaDesMoines)]
        [LargestCity((int)USCities.IowaDesMoines)]
        Iowa,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.KansasTopeka)]
        [LargestCity((int)USCities.KansasWichita)]
        Kansas,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.KentuckyFrankfort)]
        [LargestCity((int)USCities.KentuckyLouisville)]
        Kentucky,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.LouisianaBatonRouge)]
        [LargestCity((int)USCities.LouisianaNewOrleans)]
        Louisiana,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.MaineAugusta)]
        [LargestCity((int)USCities.MainePortland)]
        Maine,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.MarylandAnnapolis)]
        [LargestCity((int)USCities.MarylandBaltimore)]
        Maryland,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.MassachusettsBoston)]
        [LargestCity((int)USCities.MassachusettsBoston)]
        Massachusetts,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.MichiganLansing)]
        [LargestCity((int)USCities.MichiganDetroit)]
        Michigan,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.MinnesotaSaintPaul)]
        [LargestCity((int)USCities.MinnesotaMinneapolis)]
        Minnesota,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.MississippiJackson)]
        [LargestCity((int)USCities.MississippiJackson)]
        Mississippi,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.MissouriJeffersonCity)]
        [LargestCity((int)USCities.MissouriKansasCity)]
        Missouri,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.MontanaHelena)]
        [LargestCity((int)USCities.MontanaBillings)]
        Montana,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.NebraskaLincoln)]
        [LargestCity((int)USCities.NebraskaOmaha)]
        Nebraska,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.NevadaCarsonCity)]
        [LargestCity((int)USCities.NevadaLasVegas)]
        Nevada,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.NewHampshireConcord)]
        [LargestCity((int)USCities.NewHampshireManchester)]
        NewHampshire,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.NewJerseyTrenton)]
        [LargestCity((int)USCities.NewJerseyNewark)]
        NewJersey,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.NewMexicoSantaFe)]
        [LargestCity((int)USCities.NewMexicoAlbuquerque)]
        NewMexico,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.NewYorkAlbany)]
        [LargestCity((int)USCities.NewYorkNewYorkCity)]
        NewYork,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.NorthCarolinaRaleigh)]
        [LargestCity((int)USCities.NorthCarolinaCharlotte)]
        NorthCarolina,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.NorthDakotaBismarck)]
        [LargestCity((int)USCities.NorthDakotaFargo)]
        NorthDakota,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.OhioColumbus)]
        [LargestCity((int)USCities.OhioColumbus)]
        Ohio,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.OklahomaOklahomaCity)]
        [LargestCity((int)USCities.OklahomaOklahomaCity)]
        Oklahoma,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.OregonSalem)]
        [LargestCity((int)USCities.OregonPortland)]
        Oregon,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.PennsylvaniaHarrisburg)]
        [LargestCity((int)USCities.PennsylvaniaPhiladelphia)]
        Pennsylvania,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.RhodeIslandProvidence)]
        [LargestCity((int)USCities.RhodeIslandProvidence)]
        RhodeIsland,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.SouthCarolinaColumbia)]
        [LargestCity((int)USCities.SouthCarolinaCharleston)]
        SouthCarolina,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.SouthDakotaPierre)]
        [LargestCity((int)USCities.SouthDakotaSiouxFalls)]
        SouthDakota,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.TennesseeNashville)]
        [LargestCity((int)USCities.TennesseeNashville)]
        Tennessee,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.TexasAustin)]
        [LargestCity((int)USCities.TexasHouston)]
        Texas,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.UtahSaltLakeCity)]
        [LargestCity((int)USCities.UtahSaltLakeCity)]
        Utah,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.VermontMontpelier)]
        [LargestCity((int)USCities.VermontBurlington)]
        Vermont,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.VirginiaRichmond)]
        [LargestCity((int)USCities.VirginiaVirginiaBeach)]
        Virginia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.WashingtonOlympia)]
        [LargestCity((int)USCities.WashingtonSeattle)]
        Washington,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.WestVirginiaCharleston)]
        [LargestCity((int)USCities.WestVirginiaCharleston)]
        WestVirginia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.WisconsinMadison)]
        [LargestCity((int)USCities.WisconsinMilwaukee)]
        Wisconsin,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)USCities.WyomingCheyenne)]
        [LargestCity((int)USCities.WyomingCheyenne)]
        Wyoming,

        /// <summary>
        /// district of columbia (is a city)
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.District)]
        [Capital((int)USCities.WashingtonDistrictOfColumbia)]
        [LargestCity((int)USCities.WashingtonDistrictOfColumbia)]
        WashingtonDC,

        /// <summary>
        /// commonwealth
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Territory)]
        [Capital((int)USCities.PuertoRicoSanJuan)]
        [LargestCity((int)USCities.PuertoRicoSanJuan)]
        PuertoRico,

        /// <summary>
        /// commonwealth
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Territory)]
        [Capital((int)USCities.NorthernMarianaIslandsSaipan)]
        [LargestCity((int)USCities.NorthernMarianaIslandsSaipan)]
        NorthernMarianaIslands,

        /// <summary>
        /// unincorporated territory
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Territory)]
        [Capital((int)USCities.GuamHagåtña)]
        [LargestCity((int)USCities.GuamDededo)]
        [PopulationEstimate(159358)]
        Guam,

        /// <summary>
        /// unincorporated territory
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Territory)]
        [Capital((int)USCities.UnitedStatesVirginIslandsCharlotteAmalie)]
        [LargestCity((int)USCities.UnitedStatesVirginIslandsCharlotteAmalie)]
        [PopulationEstimate(106405)]
        UnitedStatesVirginIslands,

        /// <summary>
        /// unincorporated territory
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Territory)]
        [Capital((int)USCities.AmericanSamoaPagoPago)]
        [LargestCity((int)USCities.AmericanSamoaTafuna)]
        [PopulationEstimate(55519)]
        AmericanSamoa,
    }
}
