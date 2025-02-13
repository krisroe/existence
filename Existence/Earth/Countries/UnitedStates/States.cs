using System;

namespace Existence.Earth.Countries.UnitedStates
{
    public enum BallotMeasureTypes
    {
        /// <summary>
        /// advisory question
        /// </summary>
        AQ,

        /// <summary>
        /// Legislatively Referred Constitutional Amendment
        /// </summary>
        LRCA,

        /// <summary>
        /// Legislatively Referred State Statute
        /// </summary>
        LRSS,
    }

    public class BallotMeasureTypeAttribute : Attribute
    {
        public BallotMeasureTypes Type { get; set; }
        public BallotMeasureTypeAttribute(BallotMeasureTypes Type)
        {
            this.Type = Type;
        }
    }

    public class BallotMeasurePassFailAttribute : Attribute
    {
        public bool Passed { get; set; }
        public BallotMeasurePassFailAttribute(bool Passed)
        {
            this.Passed = Passed;
        }
    }

    public class USStatesAndTerritoriesAttribute : Attribute
    {
        public USStatesAndTerritories[] Locations { get; set; }
        public USStatesAndTerritoriesAttribute(params USStatesAndTerritories[] Locations)
        {
            this.Locations = Locations;
        }
    }

    public enum USStatesAndTerritories
    {
        [Capital((int)USCities.AlabamaMontgomery)]
        [LargestCity((int)USCities.AlabamaHuntsville)]
        Alabama,

        [Capital((int)USCities.AlaskaJuneau)]
        [LargestCity((int)USCities.AlaskaAnchorage)]
        Alaska,

        [Capital((int)USCities.ArizonaPhoenix)]
        [LargestCity((int)USCities.ArizonaPhoenix)]
        Arizona,

        [Capital((int)USCities.ArkansasLittleRock)]
        [LargestCity((int)USCities.ArkansasLittleRock)]
        Arkansas,

        [Capital((int)USCities.CaliforniaSacramento)]
        [LargestCity((int)USCities.CaliforniaLosAngeles)]
        California,

        [Capital((int)USCities.ColoradoDenver)]
        [LargestCity((int)USCities.ColoradoDenver)]
        Colorado,

        [Capital((int)USCities.ConnecticutHartford)]
        [LargestCity((int)USCities.ConnectucutBridgeport)]
        Connecticut,

        [Capital((int)USCities.DelawareDover)]
        [LargestCity((int)USCities.DelawareWilmington)]
        Delaware,

        [Capital((int)USCities.FloridaTallahassee)]
        [LargestCity((int)USCities.FloridaJacksonville)]
        Florida,

        [Capital((int)USCities.GeorgiaAtlanta)]
        [LargestCity((int)USCities.GeorgiaAtlanta)]
        Georgia,

        [Capital((int)USCities.HawaiiHonolulu)]
        [LargestCity((int)USCities.HawaiiHonolulu)]
        Hawaii,

        [Capital((int)USCities.IdahoBoise)]
        [LargestCity((int)USCities.IdahoBoise)]
        Idaho,

        [Capital((int)USCities.IllinoisSpringfield)]
        [LargestCity((int)USCities.IllinoisChicago)]
        Illinois,

        [Capital((int)USCities.IndianaIndianapolis)]
        [LargestCity((int)USCities.IndianaIndianapolis)]
        Indiana,

        [Capital((int)USCities.IowaDesMoines)]
        [LargestCity((int)USCities.IowaDesMoines)]
        Iowa,

        [Capital((int)USCities.KansasTopeka)]
        [LargestCity((int)USCities.KansasWichita)]
        Kansas,

        [Capital((int)USCities.KentuckyFrankfort)]
        [LargestCity((int)USCities.KentuckyLouisville)]
        Kentucky,

        [Capital((int)USCities.LouisianaBatonRouge)]
        [LargestCity((int)USCities.LouisianaNewOrleans)]
        Louisiana,

        [Capital((int)USCities.MaineAugusta)]
        [LargestCity((int)USCities.MainePortland)]
        Maine,

        [Capital((int)USCities.MarylandAnnapolis)]
        [LargestCity((int)USCities.MarylandBaltimore)]
        Maryland,

        [Capital((int)USCities.MassachusettsBoston)]
        [LargestCity((int)USCities.MassachusettsBoston)]
        Massachusetts,

        [Capital((int)USCities.MichiganLansing)]
        [LargestCity((int)USCities.MichiganDetroit)]
        Michigan,

        [Capital((int)USCities.MinnesotaSaintPaul)]
        [LargestCity((int)USCities.MinnesotaMinneapolis)]
        Minnesota,

        [Capital((int)USCities.MississippiJackson)]
        [LargestCity((int)USCities.MississippiJackson)]
        Mississippi,

        [Capital((int)USCities.MissouriJeffersonCity)]
        [LargestCity((int)USCities.MissouriKansasCity)]
        Missouri,

        [Capital((int)USCities.MontanaHelena)]
        [LargestCity((int)USCities.MontanaBillings)]
        Montana,

        [Capital((int)USCities.NebraskaLincoln)]
        [LargestCity((int)USCities.NebraskaOmaha)]
        Nebraska,

        [Capital((int)USCities.NevadaCarsonCity)]
        [LargestCity((int)USCities.NevadaLasVegas)]
        Nevada,

        [Capital((int)USCities.NewHampshireConcord)]
        [LargestCity((int)USCities.NewHampshireManchester)]
        NewHampshire,

        [Capital((int)USCities.NewJerseyTrenton)]
        [LargestCity((int)USCities.NewJerseyNewark)]
        NewJersey,

        [Capital((int)USCities.NewMexicoSantaFe)]
        [LargestCity((int)USCities.NewMexicoAlbuquerque)]
        NewMexico,

        [Capital((int)USCities.NewYorkAlbany)]
        [LargestCity((int)USCities.NewYorkNewYorkCity)]
        NewYork,

        [Capital((int)USCities.NorthCarolinaRaleigh)]
        [LargestCity((int)USCities.NorthCarolinaCharlotte)]
        NorthCarolina,

        [Capital((int)USCities.NorthDakotaBismarck)]
        [LargestCity((int)USCities.NorthDakotaFargo)]
        NorthDakota,

        [Capital((int)USCities.OhioColumbus)]
        [LargestCity((int)USCities.OhioColumbus)]
        Ohio,

        [Capital((int)USCities.OklahomaOklahomaCity)]
        [LargestCity((int)USCities.OklahomaOklahomaCity)]
        Oklahoma,

        [Capital((int)USCities.OregonSalem)]
        [LargestCity((int)USCities.OregonPortland)]
        Oregon,

        [Capital((int)USCities.PennsylvaniaHarrisburg)]
        [LargestCity((int)USCities.PennsylvaniaPhiladelphia)]
        Pennsylvania,

        [Capital((int)USCities.RhodeIslandProvidence)]
        [LargestCity((int)USCities.RhodeIslandProvidence)]
        RhodeIsland,

        [Capital((int)USCities.SouthCarolinaColumbia)]
        [LargestCity((int)USCities.SouthCarolinaCharleston)]
        SouthCarolina,

        [Capital((int)USCities.SouthDakotaPierre)]
        [LargestCity((int)USCities.SouthDakotaSiouxFalls)]
        SouthDakota,

        [Capital((int)USCities.TennesseeNashville)]
        [LargestCity((int)USCities.TennesseeNashville)]
        Tennessee,

        [Capital((int)USCities.TexasAustin)]
        [LargestCity((int)USCities.TexasHouston)]
        Texas,

        [Capital((int)USCities.UtahSaltLakeCity)]
        [LargestCity((int)USCities.UtahSaltLakeCity)]
        Utah,

        [Capital((int)USCities.VermontMontpelier)]
        [LargestCity((int)USCities.VermontBurlington)]
        Vermont,

        [Capital((int)USCities.VirginiaRichmond)]
        [LargestCity((int)USCities.VirginiaVirginiaBeach)]
        Virginia,

        [Capital((int)USCities.WashingtonOlympia)]
        [LargestCity((int)USCities.WashingtonSeattle)]
        Washington,

        [Capital((int)USCities.WestVirginiaCharleston)]
        [LargestCity((int)USCities.WestVirginiaCharleston)]
        WestVirginia,

        [Capital((int)USCities.WisconsinMadison)]
        [LargestCity((int)USCities.WisconsinMilwaukee)]
        Wisconsin,

        [Capital((int)USCities.WyomingCheyenne)]
        [LargestCity((int)USCities.WyomingCheyenne)]
        Wyoming,

        /// <summary>
        /// district of columbia (is a city)
        /// </summary>
        [Capital((int)USCities.WashingtonDistrictOfColumbia)]
        [LargestCity((int)USCities.WashingtonDistrictOfColumbia)]
        WashingtonDC,

        /// <summary>
        /// commonwealth
        /// </summary>
        [Capital((int)USCities.PuertoRicoSanJuan)]
        [LargestCity((int)USCities.PuertoRicoSanJuan)]
        PuertoRico,

        /// <summary>
        /// commonwealth
        /// </summary>
        [Capital((int)USCities.NorthernMarianaIslandsSaipan)]
        [LargestCity((int)USCities.NorthernMarianaIslandsSaipan)]
        NorthernMarianaIslands,

        /// <summary>
        /// unincorporated territory
        /// </summary>
        [Capital((int)USCities.GuamHagåtña)]
        [LargestCity((int)USCities.GuamDededo)]
        Guam,

        /// <summary>
        /// unincorporated territory
        /// </summary>
        [Capital((int)USCities.UnitedStatesVirginIslandsCharlotteAmalie)]
        [LargestCity((int)USCities.UnitedStatesVirginIslandsCharlotteAmalie)]
        UnitedStatesVirginIslands,

        /// <summary>
        /// unincorporated territory
        /// </summary>
        [Capital((int)USCities.AmericanSamoaPagoPago)]
        [LargestCity((int)USCities.AmericanSamoaTafuna)]
        AmericanSamoa,
    }

    /// <summary>
    /// mandatory retirement age, in years
    /// </summary>
    public enum StateSupremeCourtJusticeMandatoryRetirementAge
    {
        [USStatesAndTerritories(
            USStatesAndTerritories.Alaska,
            USStatesAndTerritories.Arizona,
            USStatesAndTerritories.Connecticut,
            USStatesAndTerritories.Delaware,
            USStatesAndTerritories.Hawaii,
            USStatesAndTerritories.Kansas,
            USStatesAndTerritories.Maine,
            USStatesAndTerritories.Maryland,
            USStatesAndTerritories.Massachusetts,
            USStatesAndTerritories.Missouri,
            USStatesAndTerritories.NewHampshire,
            USStatesAndTerritories.NewJersey,
            USStatesAndTerritories.NewMexico,
            USStatesAndTerritories.SouthDakota,
            USStatesAndTerritories.Utah,
            USStatesAndTerritories.Vermont,
            USStatesAndTerritories.Virginia,
            USStatesAndTerritories.Wyoming,
            USStatesAndTerritories.PuertoRico,
            USStatesAndTerritories.Guam,
            USStatesAndTerritories.NorthernMarianaIslands
            )]
        Seventy,

        [USStatesAndTerritories(USStatesAndTerritories.Colorado)]
        SeventyTwo,

        [USStatesAndTerritories(
            USStatesAndTerritories.Florida,
            USStatesAndTerritories.Oregon,
            USStatesAndTerritories.Pennsylvania,
            USStatesAndTerritories.Washington,
            USStatesAndTerritories.Wisconsin
            )]
        SeventyFive,

        /// <summary>
        /// election (retention or otherwise) or legislative confirmation required to serve additional terms
        /// New York note: New York Supreme Court uses partisan elections, while the New York Court of Appeals uses gubernatorial/legislative process.
        /// </summary>
        [USStatesAndTerritories(
            USStatesAndTerritories.Alabama,
            USStatesAndTerritories.Arkansas,
            USStatesAndTerritories.California,
            USStatesAndTerritories.Georgia,
            USStatesAndTerritories.Idaho,
            USStatesAndTerritories.Illinois,
            USStatesAndTerritories.Indiana,
            USStatesAndTerritories.Iowa,
            USStatesAndTerritories.Kentucky,
            USStatesAndTerritories.Louisiana,
            USStatesAndTerritories.Michigan,
            USStatesAndTerritories.Minnesota,
            USStatesAndTerritories.Mississippi,
            USStatesAndTerritories.Montana,
            USStatesAndTerritories.Nebraska, 
            USStatesAndTerritories.Nevada,
            USStatesAndTerritories.NewYork,
            USStatesAndTerritories.NorthCarolina,
            USStatesAndTerritories.NorthDakota,
            USStatesAndTerritories.Ohio,
            USStatesAndTerritories.Oklahoma,
            USStatesAndTerritories.SouthCarolina,
            USStatesAndTerritories.Tennessee,
            USStatesAndTerritories.Texas,
            USStatesAndTerritories.WestVirginia,
            USStatesAndTerritories.WashingtonDC,
            USStatesAndTerritories.UnitedStatesVirginIslands
            )]
        NoneButHaveProcessToServeMoreTerms,

        /// <summary>
        /// life term and can only be removed by impeachment
        /// </summary>
        [USStatesAndTerritories(USStatesAndTerritories.RhodeIsland)]

        NoneImpeachmentOnly,
    }

    public enum StateSupremeCourtJusticeTermLength
    {
        [USStatesAndTerritories(
            USStatesAndTerritories.Alabama,
            USStatesAndTerritories.Kentucky,
            USStatesAndTerritories.Louisiana,
            USStatesAndTerritories.Michigan,
            USStatesAndTerritories.Minnesota,
            USStatesAndTerritories.Mississippi,
            USStatesAndTerritories.Nebraska,
            USStatesAndTerritories.Nevada,
            USStatesAndTerritories.NorthCarolina,
            USStatesAndTerritories.Ohio,
            USStatesAndTerritories.Oregon,
            USStatesAndTerritories.Texas,
            USStatesAndTerritories.Vermont,
            USStatesAndTerritories.Washington,
            USStatesAndTerritories.Wisconsin
            )]
        SixYear,

        [USStatesAndTerritories(
            USStatesAndTerritories.Arkansas,
            USStatesAndTerritories.Idaho,
            USStatesAndTerritories.Indiana,
            USStatesAndTerritories.Maryland,
            USStatesAndTerritories.Missouri,
            USStatesAndTerritories.Montana,
            USStatesAndTerritories.NewMexico,
            USStatesAndTerritories.Oklahoma,
            USStatesAndTerritories.SouthCarolina,
            USStatesAndTerritories.SouthDakota,
            USStatesAndTerritories.Tennessee,
            USStatesAndTerritories.Wyoming
            )]
        EightYear,

        [USStatesAndTerritories(
            USStatesAndTerritories.Alaska,
            USStatesAndTerritories.Colorado,
            USStatesAndTerritories.Hawaii,
            USStatesAndTerritories.Iowa,
            USStatesAndTerritories.NorthDakota,
            USStatesAndTerritories.Pennsylvania,
            USStatesAndTerritories.WestVirginia,
            USStatesAndTerritories.UnitedStatesVirginIslands
            )]
        TenYear,

        [USStatesAndTerritories(
            USStatesAndTerritories.Arizona,
            USStatesAndTerritories.California,
            USStatesAndTerritories.Connecticut,
            USStatesAndTerritories.Delaware,
            USStatesAndTerritories.Florida,
            USStatesAndTerritories.Illinois,
            USStatesAndTerritories.Kansas,
            USStatesAndTerritories.Maine,
            USStatesAndTerritories.NewJersey,
            USStatesAndTerritories.Utah,
            USStatesAndTerritories.Virginia
            )]
        TwelveYear,

        /// <summary>
        /// 14 year terms for both the New York Supreme Court and New York Court of Appeals
        /// </summary>
        [USStatesAndTerritories(USStatesAndTerritories.NewYork)]
        FourteenYear,

        [USStatesAndTerritories(USStatesAndTerritories.WashingtonDC)]
        FifteenYear,

        [USStatesAndTerritories(USStatesAndTerritories.Georgia)]
        SixteenYear,

        [USStatesAndTerritories(
            USStatesAndTerritories.Massachusetts,
            USStatesAndTerritories.NewHampshire,
            USStatesAndTerritories.PuertoRico,
            USStatesAndTerritories.Guam,
            USStatesAndTerritories.NorthernMarianaIslands
            )]
        UntilRetirementAge,

        /// <summary>
        /// only removable by impeachment
        /// </summary>
        [USStatesAndTerritories(USStatesAndTerritories.RhodeIsland)]
        Lifetime,
    }

    /// <summary>
    /// New York note: The New York Supreme Court is actually a trial court of general jurisdiction and uses partisan elections
    /// </summary>
    public enum StateSupremeCourtElectionType
    {
        [USStatesAndTerritories(
            USStatesAndTerritories.Arkansas,
            USStatesAndTerritories.Georgia,
            USStatesAndTerritories.Idaho,
            USStatesAndTerritories.Kentucky,
            USStatesAndTerritories.Michigan,
            USStatesAndTerritories.Minnesota,
            USStatesAndTerritories.Mississippi,
            USStatesAndTerritories.Montana,
            USStatesAndTerritories.Nevada,
            USStatesAndTerritories.NorthDakota,
            USStatesAndTerritories.Oregon,
            USStatesAndTerritories.Washington,
            USStatesAndTerritories.Wisconsin,
            USStatesAndTerritories.WestVirginia)]
        NonpartisanElections,

        [USStatesAndTerritories(
            USStatesAndTerritories.Alabama,
            USStatesAndTerritories.Louisiana,
            USStatesAndTerritories.NorthCarolina,
            USStatesAndTerritories.Ohio,
            USStatesAndTerritories.Texas)]
        PartisanElections,

        /// <summary>
        /// First term won through partisan election (in New Mexico may be appointed first until next partisan election)
        /// </summary>
        [USStatesAndTerritories(
            USStatesAndTerritories.Illinois, 
            USStatesAndTerritories.NewMexico, 
            USStatesAndTerritories.Pennsylvania)]
        PartisanElectionsWithRetention,

        [USStatesAndTerritories(
            USStatesAndTerritories.Alaska,
            USStatesAndTerritories.Arizona,
            USStatesAndTerritories.California,
            USStatesAndTerritories.Colorado,
            USStatesAndTerritories.Florida,
            USStatesAndTerritories.Indiana,
            USStatesAndTerritories.Iowa,
            USStatesAndTerritories.Kansas,
            USStatesAndTerritories.Maryland,
            USStatesAndTerritories.Missouri,
            USStatesAndTerritories.Nebraska,
            USStatesAndTerritories.Oklahoma,
            USStatesAndTerritories.SouthDakota,
            USStatesAndTerritories.Tennessee,
            USStatesAndTerritories.Utah,
            USStatesAndTerritories.Wyoming
            )]
        RetentionElections,

        [USStatesAndTerritories(
            USStatesAndTerritories.Connecticut,
            USStatesAndTerritories.Delaware,
            USStatesAndTerritories.Hawaii,
            USStatesAndTerritories.Maine,
            USStatesAndTerritories.Massachusetts,
            USStatesAndTerritories.NewHampshire,
            USStatesAndTerritories.NewJersey,
            USStatesAndTerritories.NewYork, //New York Court of Appeals is the anologue to other State Supreme Courts
            USStatesAndTerritories.RhodeIsland,
            USStatesAndTerritories.SouthCarolina,
            USStatesAndTerritories.Vermont,
            USStatesAndTerritories.Virginia,
            USStatesAndTerritories.WashingtonDC,
            USStatesAndTerritories.PuertoRico,
            USStatesAndTerritories.Guam,
            USStatesAndTerritories.UnitedStatesVirginIslands,
            USStatesAndTerritories.NorthernMarianaIslands
            )]
        NoElections,
    }

    public enum StateSupremeCourtJusticeChoice
    {
        [USStatesAndTerritories(
            USStatesAndTerritories.Arkansas,
            USStatesAndTerritories.Georgia,
            USStatesAndTerritories.Idaho,
            USStatesAndTerritories.Kentucky,
            USStatesAndTerritories.Michigan,
            USStatesAndTerritories.Minnesota,
            USStatesAndTerritories.Mississippi,
            USStatesAndTerritories.Montana,
            USStatesAndTerritories.Nevada,
            USStatesAndTerritories.Oregon,
            USStatesAndTerritories.Washington,
            USStatesAndTerritories.WestVirginia,
            USStatesAndTerritories.Wisconsin
            )]
        NonPartisanElectionsWithoutRetention,

        [USStatesAndTerritories(USStatesAndTerritories.Ohio)]
        NonpartisanElectionsWithRetention,

        /// <summary>
        /// First term won through partisan election (in New Mexico may be appointed first until next partisan election)
        /// </summary>
        [USStatesAndTerritories(
            USStatesAndTerritories.Illinois,
            USStatesAndTerritories.NewMexico,
            USStatesAndTerritories.Pennsylvania)]
        PartisanElectionsWithRetention,

        [USStatesAndTerritories(
            USStatesAndTerritories.Alabama,
            USStatesAndTerritories.Louisiana,
            USStatesAndTerritories.NorthCarolina,
            USStatesAndTerritories.Texas
            )]
        PartisanElectionsWithoutRetention,

        [USStatesAndTerritories(
            USStatesAndTerritories.Alaska,
            USStatesAndTerritories.Arizona,
            USStatesAndTerritories.Colorado,
            USStatesAndTerritories.Florida,
            USStatesAndTerritories.Indiana,
            USStatesAndTerritories.Iowa,
            USStatesAndTerritories.Kansas,
            USStatesAndTerritories.Missouri,
            USStatesAndTerritories.Nebraska,
            USStatesAndTerritories.NorthDakota,
            USStatesAndTerritories.Oklahoma,
            USStatesAndTerritories.SouthDakota,
            USStatesAndTerritories.Tennessee,
            USStatesAndTerritories.Utah,
            USStatesAndTerritories.Wyoming
            )]
        CommissionRecommendationsGubernatorialAppointmentFromListRetentionElection,

        [USStatesAndTerritories(
            USStatesAndTerritories.Connecticut,
            USStatesAndTerritories.Maryland
            )]
        CommissionRecommendationsGubernatorialAppointmentPotentiallyNotFromListLegislativeConfirmationRepeatProcessAfterTerm,

        [USStatesAndTerritories(USStatesAndTerritories.California)]
        GubernatorialAppointmentCommissionConfirmationRepeatProcessAfterTerm,

        [USStatesAndTerritories(
            USStatesAndTerritories.Maine, 
            USStatesAndTerritories.UnitedStatesVirginIslands)]
        GubernatorialAppointmentLegislatureConfirmationRepeatProcessAfterTerm,

        [USStatesAndTerritories(USStatesAndTerritories.NewJersey)]
        GubernatorialAppointmentLegislativeConfirmationRepeatAfterNextTermAndThenGetLifeTermToRetirementAge,

        [USStatesAndTerritories(
            USStatesAndTerritories.Delaware,
            USStatesAndTerritories.NewYork, //New York Court of Appeals
            USStatesAndTerritories.Vermont,
            USStatesAndTerritories.WashingtonDC //US president performs governor-equivalent work
            )]
        CommissionRecommendationsGubernatorialAppointmentFromListLegislativeConfirmationRepeatProcessAfterTerm,

        /// <summary>
        /// commission decides on retention, not requiring the same confirmation process for subsequent terms
        /// </summary>
        [USStatesAndTerritories(USStatesAndTerritories.Hawaii)]
        CommissionRecommendationsGubernatorialAppointmentFromListLegislativeConfirmationCommissionDecidesRetention,

        /// <summary>
        /// legislative appointment must be redone at the end of the next term
        /// </summary>
        [USStatesAndTerritories(USStatesAndTerritories.SouthCarolina, USStatesAndTerritories.Virginia)]
        LegislativeAppointmentRepeatProcessAfterTerm,

        /// <summary>
        /// no need to repeat any process for successive terms, but leave office at retirement age
        /// </summary>
        [USStatesAndTerritories(
            USStatesAndTerritories.Massachusetts,
            USStatesAndTerritories.NewHampshire,
            USStatesAndTerritories.PuertoRico,
            USStatesAndTerritories.Guam,
            USStatesAndTerritories.NorthernMarianaIslands
            )]
        GubernatorialAppointmentLegislativeConfirmationTermUntilRetirementAge,

        /// <summary>
        /// life term, can only be removed via impeachment
        /// </summary>
        [USStatesAndTerritories(USStatesAndTerritories.RhodeIsland)]
        CommissionRecommendationsGubernatorialAppointmentFromListLegislativeConfirmationLifeTerm,
    }
}
