using Existence.Earth.Alphabet;
using Existence.Earth.Human.Politics;

namespace Existence.Earth.Countries.Ukraine
{
    /// <summary>
    /// The oblasts, autonomous republic, and special-status cities of Ukraine, as internationally
    /// recognized. Russia also claims <see cref="Crimea"/>, <see cref="Donetsk"/>, <see cref="Kherson"/>,
    /// <see cref="Luhansk"/>, <see cref="Sevastopol"/>, and <see cref="Zaporizhzhia"/>.
    /// Capital and largest city are only filled out for cities over 500,000 people (January 2022
    /// estimates, from before Russia's full-scale invasion).
    /// </summary>
    public enum StateSubsidiariesUkraine
    {
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Cherkaska Oblast", "Черкаська область")]
        Cherkasy,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Chernihivska Oblast", "Чернігівська область")]
        Chernihiv,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Chernivetska Oblast", "Чернівецька область")]
        Chernivtsi,

        /// <summary>
        /// Also listed as <see cref="Russia.StateSubsidiariesRussia.Crimea"/>. Annexed by Russia in 2014
        /// and under Russian control, but internationally recognized as part of Ukraine.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Avtonomna Respublika Krym", "Автономна Республіка Крим")]
        Crimea,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.UkraineDnipro)]
        [LargestCity((int)WorldCities.UkraineDnipro)]
        [Texts("Dnipropetrovska Oblast", "Дніпропетровська область")]
        Dnipropetrovsk,

        /// <summary>
        /// Also listed as <see cref="Russia.StateSubsidiariesRussia.Donetsk"/>. The city of Donetsk has
        /// been outside Ukrainian control since 2014, and Russia declared the oblast annexed in 2022.
        /// As of November 2026, Ukraine still holds part of the oblast and fighting continues.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [ClaimedCapital((int)WorldCities.UkraineDonetsk)]
        [LargestCity((int)WorldCities.UkraineDonetsk)]
        [Texts("Donetska Oblast", "Донецька область")]
        Donetsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Ivano-Frankivska Oblast", "Івано-Франківська область")]
        IvanoFrankivsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.UkraineKharkiv)]
        [LargestCity((int)WorldCities.UkraineKharkiv)]
        [Texts("Kharkivska Oblast", "Харківська область")]
        Kharkiv,

        /// <summary>
        /// Also listed as <see cref="Russia.StateSubsidiariesRussia.Kherson"/>. Russia declared it annexed
        /// in 2022 and held the city of Kherson until Ukraine retook it in November 2022. As of November
        /// 2026, Ukraine holds the city and Russia holds Oleshky across the Dnipro River. A six-day local
        /// ceasefire around Oleshky ended on November 1, 2026 without an extension.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Khersonska Oblast", "Херсонська область")]
        Kherson,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Khmelnytska Oblast", "Хмельницька область")]
        Khmelnytskyi,

        [StateSubsidiaryType(StateSubsidaryType.District)]
        [Capital((int)WorldCities.UkraineKiev)]
        [LargestCity((int)WorldCities.UkraineKiev)]
        [Texts("Kyiv", "Київ")]
        KievCity,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.UkraineKiev)]
        [Texts("Kyivska Oblast", "Київська область")]
        KievOblast,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Kirovohradska Oblast", "Кіровоградська область")]
        Kirovohrad,

        /// <summary>
        /// Also listed as <see cref="Russia.StateSubsidiariesRussia.Luhansk"/>. The city of Luhansk has
        /// been outside Ukrainian control since 2014, and Russia declared the oblast annexed in 2022.
        /// Russia holds nearly all of it.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Luhanska Oblast", "Луганська область")]
        Luhansk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.UkraineLviv)]
        [LargestCity((int)WorldCities.UkraineLviv)]
        [Texts("Lvivska Oblast", "Львівська область")]
        Lviv,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Mykolaivska Oblast", "Миколаївська область")]
        Mykolaiv,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.UkraineOdesa)]
        [LargestCity((int)WorldCities.UkraineOdesa)]
        [Texts("Odeska Oblast", "Одеська область")]
        Odesa,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Poltavska Oblast", "Полтавська область")]
        Poltava,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Rivnenska Oblast", "Рівненська область")]
        Rivne,

        /// <summary>
        /// Also listed as <see cref="Russia.StateSubsidiariesRussia.Sevastopol"/>. Annexed by Russia in
        /// 2014 and under Russian control, but internationally recognized as part of Ukraine.
        /// Home to a major naval base, the Russian Black Sea Fleet. Included despite population estimates
        /// straddling the 500,000 limit (393,304 in Ukraine's 2022 estimate, 547,820 in Russia's 2021 census).
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.District)]
        [ClaimedCapital((int)WorldCities.UkraineSevastopol)]
        [LargestCity((int)WorldCities.UkraineSevastopol)]
        [Texts("Sevastopol", "Севастополь")]
        Sevastopol,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Sumska Oblast", "Сумська область")]
        Sumy,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Ternopilska Oblast", "Тернопільська область")]
        Ternopil,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Vinnytska Oblast", "Вінницька область")]
        Vinnytsia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Volynska Oblast", "Волинська область")]
        Volyn,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Zakarpatska Oblast", "Закарпатська область")]
        Zakarpattia,

        /// <summary>
        /// Also listed as <see cref="Russia.StateSubsidiariesRussia.Zaporizhzhia"/>. Russia declared it
        /// annexed in 2022 and holds the south, including Melitopol, but, as of November 2026, Ukraine
        /// holds the city of Zaporizhzhia.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.UkraineZaporizhzhia)]
        [LargestCity((int)WorldCities.UkraineZaporizhzhia)]
        [Texts("Zaporizka Oblast", "Запорізька область")]
        Zaporizhzhia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Zhytomyrska Oblast", "Житомирська область")]
        Zhytomyr,
    }
}
