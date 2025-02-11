using System;

namespace Existence.Earth.Countries.UnitedStates
{
    public class USCityAttribute : Attribute
    {
        public USCities City { get; set; }
        public USCityAttribute(USCities City)
        {
            this.City = City;
        }
    }

    public class USCitiesAttribute : Attribute
    {
        public USCities[] Cities { get; set; }
        public USCitiesAttribute(params USCities[] Cities)
        {
            this.Cities = Cities;
        }
    }

    public enum USCities
    {
        AlabamaBirmingham,
        AlabamaMobile,
        AlabamaMontgomery,
        AlaskaAnchorage,
        ArizonaPhoenix,
        ArkansasFortSmith,
        ArkansasLittleRock,
        CaliforniaLosAngeles,
        CaliforniaPasadena,
        CaliforniaSacramento,
        CaliforniaSanDiego,
        CaliforniaSanFrancisco,
        CheyenneWyoming,
        ColoradoDenver,
        ConnecticutNewHaven,
        DelawareWilmington,
        FloridaMiami,
        FloridaOrlando,
        FloridaTallahassee,
        GeorgiaAtlanta,
        GeorgiaMacon,
        GeorgiaSavannah,
        GuamHagåtña,
        HawaiiHonolulu,
        IdahoBoise,
        IllinoisChicago,
        IllinoisEastSaintLouis,
        IllinoisSpringfield,
        IndianaIndianapolis,
        IndianaSouthBend,
        IowaCedarRapids,
        IowaDesMoines,
        KansasTopeka,
        KentuckyLexington,
        KentuckyLouisville,
        LouisianaBatonRouge,
        LouisianaNewOrleans,
        LouisianaShreveport,
        MainePortland,
        MarylandBaltimore,
        MassachusettsBoston,
        MichiganDetroit,
        MichiganGrandRapids,
        MinnesotaSaintPaul,
        MississippiJackson,
        MississippiOxford,
        MissouriKansasCity,
        MissouriSaintLouis,
        MontanaBillings,
        NebraskaOmaha,
        NevadaLasVegas,
        NewHampshireConcord,
        NewJerseyNewark,
        NewMexicoAlbuquerque,
        NewYorkBrooklyn,
        NewYorkBuffalo,
        NewYorkNewYorkCity,
        NewYorkSyracuse,
        NorthCarolinaCharlotte,
        NorthCarolinaGreensboro,
        NorthCarolinaRaleigh,
        NorthDakotaBismarck,
        NorthernMarianaIslandsSaipan,
        OhioCincinnati,
        OhioCleveland,
        OhioColumbus,
        OklahomaMuskogee,
        OklahomaOklahomaCity,
        OklahomaTulsa,
        OregonPortland,
        PennsylvaniaPhiladelphia,
        PennsylvaniaPittsburgh,
        PennsylvaniaScranton,
        PuertoRicoSanJuan,
        RhodeIslandProvidence,
        SouthCarolinaColumbia,
        SouthDakotaSiouxFalls,
        TexasDallas,
        TexasHouston,
        TexasSanAntonio,
        TexasTyler,
        TennesseeKnoxville,
        TennesseeMemphis,
        TennesseeNashville,
        UtahSaltLakeCity,
        VermontBurlington,
        VirginiaRichmond,
        VirginiaRoanoke,
        UnitedStatesVirginIslandsSaintThomas,
        UnitedStatesVirginIslandsSaintCroix,
        WashingtonDistrictOfColumbia,
        WashingtonSeattle,
        WashingtonSpokane,
        WestVirginiaCharleston,
        WestVirginiaWheeling,
        WisconsinMadison,
        WisconsinMilwaukee,
    }
}
