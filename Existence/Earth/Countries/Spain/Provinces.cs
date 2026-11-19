using Existence.Earth.Alphabet;
using Existence.Earth.Human.Politics;
using System;

namespace Existence.Earth.Countries.Spain
{
    /// <summary>
    /// the autonomous community, or autonomous city, that a <see cref="StateSubsidiariesProvincesSpain"/>
    /// belongs to
    /// </summary>
    public class AutonomousCommunityAttribute : Attribute
    {
        public StateSubsidiariesSpain AutonomousCommunity { get; set; }
        public AutonomousCommunityAttribute(StateSubsidiariesSpain AutonomousCommunity)
        {
            this.AutonomousCommunity = AutonomousCommunity;
        }
    }

    /// <summary>
    /// The autonomous communities and autonomous cities of Spain, its first-level subdivisions (the 50
    /// provinces are a level below them, in <see cref="StateSubsidiariesProvincesSpain"/>). Morocco
    /// claims <see cref="Ceuta"/> and <see cref="Melilla"/>.
    /// Texts are the Spanish name, followed by the name in the community's co-official language where
    /// it has one. Capital and largest city are only filled out for cities over 500,000 people (INE
    /// January 2024 estimates).
    /// </summary>
    public enum StateSubsidiariesSpain
    {
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.SpainSeville)]
        [LargestCity((int)WorldCities.SpainSeville)]
        [Texts("Andalucía")]
        Andalusia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.SpainZaragoza)]
        [LargestCity((int)WorldCities.SpainZaragoza)]
        [Texts("Aragón")]
        Aragon,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Principado de Asturias")]
        Asturias,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Islas Baleares", "Illes Balears")]
        BalearicIslands,

        /// <summary>
        /// See also <see cref="LessCountryLikeThings.BasqueCountry"/> for its separatist movement.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("País Vasco", "Euskadi")]
        BasqueCountry,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Canarias")]
        CanaryIslands,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Cantabria")]
        Cantabria,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Castilla y León")]
        CastileAndLeon,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Castilla-La Mancha")]
        CastileLaMancha,

        /// <summary>
        /// See also <see cref="LessCountryLikeThings.Catalonia"/> for its independence movement.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.SpainBarcelona)]
        [LargestCity((int)WorldCities.SpainBarcelona)]
        [Texts("Cataluña", "Catalunya")]
        Catalonia,

        /// <summary>
        /// An autonomous city on the North African coast, claimed by Morocco.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.District)]
        [Texts("Ceuta")]
        Ceuta,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Extremadura")]
        Extremadura,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Galicia")]
        Galicia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("La Rioja")]
        LaRioja,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.SpainMadrid)]
        [LargestCity((int)WorldCities.SpainMadrid)]
        [Texts("Comunidad de Madrid")]
        Madrid,

        /// <summary>
        /// An autonomous city on the North African coast, claimed by Morocco.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.District)]
        [Texts("Melilla")]
        Melilla,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Región de Murcia")]
        Murcia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Comunidad Foral de Navarra", "Nafarroako Foru Komunitatea")]
        Navarre,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.SpainValencia)]
        [LargestCity((int)WorldCities.SpainValencia)]
        [Texts("Comunidad Valenciana", "Comunitat Valenciana")]
        Valencia,
    }

    /// <summary>
    /// The 50 provinces of Spain, plus the autonomous cities of Ceuta and Melilla. These 52 are the
    /// constituencies for the Congress of Deputies, and (apart from the island provinces) for the
    /// directly elected seats in the Senate. Texts follow the same convention as
    /// <see cref="StateSubsidiariesSpain"/>. Capital and largest city are only filled out for cities
    /// over 500,000 people (INE January 2024 estimates).
    /// </summary>
    public enum StateSubsidiariesProvincesSpain
    {
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Galicia)]
        [Texts("La Coruña", "A Coruña")]
        ACoruna,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.BasqueCountry)]
        [Texts("Álava", "Araba")]
        Alava,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileLaMancha)]
        [Texts("Albacete")]
        Albacete,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Valencia)]
        [Texts("Alicante", "Alacant")]
        Alicante,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Andalusia)]
        [Texts("Almería")]
        Almeria,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Asturias)]
        [Texts("Asturias")]
        Asturias,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileAndLeon)]
        [Texts("Ávila")]
        Avila,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Extremadura)]
        [Texts("Badajoz")]
        Badajoz,

        /// <summary>
        /// For the Senate, the islands vote separately (Mallorca, Menorca, and Ibiza-Formentera).
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.BalearicIslands)]
        [Texts("Islas Baleares", "Illes Balears")]
        BalearicIslands,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Catalonia)]
        [Capital((int)WorldCities.SpainBarcelona)]
        [LargestCity((int)WorldCities.SpainBarcelona)]
        [Texts("Barcelona")]
        Barcelona,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.BasqueCountry)]
        [Texts("Vizcaya", "Bizkaia")]
        Biscay,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileAndLeon)]
        [Texts("Burgos")]
        Burgos,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Extremadura)]
        [Texts("Cáceres")]
        Caceres,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Andalusia)]
        [Texts("Cádiz")]
        Cadiz,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Cantabria)]
        [Texts("Cantabria")]
        Cantabria,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Valencia)]
        [Texts("Castellón", "Castelló")]
        Castellon,

        /// <summary>
        /// Not a province, but an autonomous city that votes as its own constituency. Claimed by Morocco.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.District)]
        [AutonomousCommunity(StateSubsidiariesSpain.Ceuta)]
        [Texts("Ceuta")]
        Ceuta,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileLaMancha)]
        [Texts("Ciudad Real")]
        CiudadReal,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Andalusia)]
        [Texts("Córdoba")]
        Cordoba,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileLaMancha)]
        [Texts("Cuenca")]
        Cuenca,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.BasqueCountry)]
        [Texts("Guipúzcoa", "Gipuzkoa")]
        Gipuzkoa,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Catalonia)]
        [Texts("Gerona", "Girona")]
        Girona,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Andalusia)]
        [Texts("Granada")]
        Granada,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileLaMancha)]
        [Texts("Guadalajara")]
        Guadalajara,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Andalusia)]
        [Texts("Huelva")]
        Huelva,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Aragon)]
        [Texts("Huesca")]
        Huesca,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Andalusia)]
        [Texts("Jaén")]
        Jaen,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.LaRioja)]
        [Texts("La Rioja")]
        LaRioja,

        /// <summary>
        /// For the Senate, the islands vote separately (Gran Canaria, Lanzarote, and Fuerteventura).
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CanaryIslands)]
        [Texts("Las Palmas")]
        LasPalmas,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileAndLeon)]
        [Texts("León")]
        Leon,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Catalonia)]
        [Texts("Lérida", "Lleida")]
        Lleida,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Galicia)]
        [Texts("Lugo")]
        Lugo,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Madrid)]
        [Capital((int)WorldCities.SpainMadrid)]
        [LargestCity((int)WorldCities.SpainMadrid)]
        [Texts("Madrid")]
        Madrid,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Andalusia)]
        [Capital((int)WorldCities.SpainMalaga)]
        [LargestCity((int)WorldCities.SpainMalaga)]
        [Texts("Málaga")]
        Malaga,

        /// <summary>
        /// Not a province, but an autonomous city that votes as its own constituency. Claimed by Morocco.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.District)]
        [AutonomousCommunity(StateSubsidiariesSpain.Melilla)]
        [Texts("Melilla")]
        Melilla,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Murcia)]
        [Texts("Murcia")]
        Murcia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Navarre)]
        [Texts("Navarra", "Nafarroa")]
        Navarre,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Galicia)]
        [Texts("Orense", "Ourense")]
        Ourense,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileAndLeon)]
        [Texts("Palencia")]
        Palencia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Galicia)]
        [Texts("Pontevedra")]
        Pontevedra,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileAndLeon)]
        [Texts("Salamanca")]
        Salamanca,

        /// <summary>
        /// For the Senate, the islands vote separately (Tenerife, La Palma, La Gomera, and El Hierro).
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CanaryIslands)]
        [Texts("Santa Cruz de Tenerife")]
        SantaCruzDeTenerife,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileAndLeon)]
        [Texts("Segovia")]
        Segovia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Andalusia)]
        [Capital((int)WorldCities.SpainSeville)]
        [LargestCity((int)WorldCities.SpainSeville)]
        [Texts("Sevilla")]
        Seville,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileAndLeon)]
        [Texts("Soria")]
        Soria,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Catalonia)]
        [Texts("Tarragona")]
        Tarragona,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Aragon)]
        [Texts("Teruel")]
        Teruel,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileLaMancha)]
        [Texts("Toledo")]
        Toledo,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Valencia)]
        [Capital((int)WorldCities.SpainValencia)]
        [LargestCity((int)WorldCities.SpainValencia)]
        [Texts("Valencia", "València")]
        Valencia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileAndLeon)]
        [Texts("Valladolid")]
        Valladolid,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.CastileAndLeon)]
        [Texts("Zamora")]
        Zamora,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [AutonomousCommunity(StateSubsidiariesSpain.Aragon)]
        [Capital((int)WorldCities.SpainZaragoza)]
        [LargestCity((int)WorldCities.SpainZaragoza)]
        [Texts("Zaragoza")]
        Zaragoza,
    }
}
