using Existence.Earth.Alphabet;
using Existence.Earth.Human.Politics;

namespace Existence.Earth.Countries.Ukraine
{
    /// <summary>
    /// The oblasts, autonomous republic, and special-status cities of Ukraine, as internationally
    /// recognized. Russia also claims <see cref="Crimea"/>, <see cref="Donetsk"/>, <see cref="Kherson"/>,
    /// <see cref="Luhansk"/>, <see cref="Sevastopol"/>, and <see cref="Zaporizhzhia"/>.
    /// Capital and largest city are only filled out for cities over 500,000 people (January 2022
    /// estimates, from before Russia's full-scale invasion), plus the capital and largest city of the smaller
    /// contested regions (Crimea, Kherson, Luhansk).
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
        [ClaimedCapital((int)WorldCities.UkraineSimferopol)]
        [LargestCity((int)WorldCities.UkraineSimferopol)]
        [ActualControl(0, 2026, 11, 15)]
        [Texts("Avtonomna Respublika Krym", "Автономна Республіка Крим")]
        Crimea,

        /// <summary>
        /// Russia pushed into the eastern edge of the oblast in 2025. Ukraine retook most of it by March
        /// 2026, and as of August 2026 Russia fully controls only one settlement, Dachne.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.UkraineDnipro)]
        [LargestCity((int)WorldCities.UkraineDnipro)]
        [ActualControl(99.9, 2026, 8, 12)]
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
        [ActualControl(20.3, 2026, 10, 30)]
        [Texts("Donetska Oblast", "Донецька область")]
        Donetsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Ivano-Frankivska Oblast", "Івано-Франківська область")]
        IvanoFrankivsk,

        /// <summary>
        /// Russia holds a strip along the border and east of the Oskil River. The control percentage is
        /// DeepState's year-end 2025 figure, and fighting continues.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.UkraineKharkiv)]
        [LargestCity((int)WorldCities.UkraineKharkiv)]
        [ActualControl(95.3, 2025, 12, 31)]
        [Texts("Kharkivska Oblast", "Харківська область")]
        Kharkiv,

        /// <summary>
        /// Also listed as <see cref="Russia.StateSubsidiariesRussia.Kherson"/>. Russia declared it annexed
        /// in 2022 and held the city of Kherson until Ukraine retook it in November 2022. As of November
        /// 2026, Ukraine holds the city and Russia holds Oleshky across the Dnipro River. A six-day local
        /// ceasefire around Oleshky ended on November 1, 2026 without an extension.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.UkraineKherson)]
        [LargestCity((int)WorldCities.UkraineKherson)]
        [ActualControl(27.9, 2026, 10, 30)]
        [Texts("Khersonska Oblast", "Херсонська область")]
        Kherson,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Khmelnytska Oblast", "Хмельницька область")]
        Khmelnytskyi,

        /// <summary>
        /// Russian name used in this repository per repository maintainer's preference
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.District)]
        [Capital((int)WorldCities.UkraineKiev)]
        [LargestCity((int)WorldCities.UkraineKiev)]
        [Texts("Kyiv", "Київ")]
        KievCity,

        /// <summary>
        /// Russian name used in this repository per repository maintainer's preference
        /// </summary>
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
        [ClaimedCapital((int)WorldCities.UkraineLuhansk)]
        [LargestCity((int)WorldCities.UkraineLuhansk)]
        [ActualControl(0.4, 2025, 12, 31)]
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
        [ActualControl(0, 2026, 11, 15)]
        [Texts("Sevastopol", "Севастополь")]
        Sevastopol,

        /// <summary>
        /// Russia holds a small strip along the border. The control percentage is DeepState's year-end 2025
        /// figure, and fighting continues.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [ActualControl(99.0, 2025, 12, 31)]
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
        [ActualControl(24.2, 2026, 10, 30)]
        [Texts("Zaporizka Oblast", "Запорізька область")]
        Zaporizhzhia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Zhytomyrska Oblast", "Житомирська область")]
        Zhytomyr,
    }
}
