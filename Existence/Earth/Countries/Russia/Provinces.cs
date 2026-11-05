using Existence.Earth.Alphabet;
using Existence.Earth.Human.Politics;

namespace Existence.Earth.Countries.Russia
{
    /// <summary>
    /// The federal subjects Russia claims, including those it claims from Ukraine, which are not
    /// internationally recognized as part of Russia (<see cref="Crimea"/>, <see cref="Donetsk"/>,
    /// <see cref="Kherson"/>, <see cref="Luhansk"/>, <see cref="Sevastopol"/>, <see cref="Zaporizhzhia"/>).
    /// Capital and largest city are only filled out for cities over 500,000 people (2021 census), plus
    /// the capital and largest city of the smaller contested regions (Crimea, Kherson, Luhansk).
    /// </summary>
    public enum StateSubsidiariesRussia
    {
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Adygeya", "Адыгея")]
        Adygea,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaBarnaul)]
        [LargestCity((int)WorldCities.RussiaBarnaul)]
        [Texts("Altayskiy Kray", "Алтайский край")]
        AltaiKrai,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Respublika Altay", "Республика Алтай")]
        AltaiRepublic,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Amurskaya Oblast", "Амурская область")]
        Amur,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Arkhangelskaya Oblast", "Архангельская область")]
        Arkhangelsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Astrakhanskaya Oblast", "Астраханская область")]
        Astrakhan,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaUfa)]
        [LargestCity((int)WorldCities.RussiaUfa)]
        [Texts("Bashkortostan", "Башкортостан")]
        Bashkortostan,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Belgorodskaya Oblast", "Белгородская область")]
        Belgorod,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Bryanskaya Oblast", "Брянская область")]
        Bryansk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Buryatiya", "Бурятия")]
        Buryatia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Chechnya", "Чечня")]
        Chechnya,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaChelyabinsk)]
        [LargestCity((int)WorldCities.RussiaChelyabinsk)]
        [Texts("Chelyabinskaya Oblast", "Челябинская область")]
        Chelyabinsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Chukotskiy Avtonomnyy Okrug", "Чукотский автономный округ")]
        Chukotka,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Chuvashiya", "Чувашия")]
        Chuvashia,

        /// <summary>
        /// Also listed as <see cref="Ukraine.StateSubsidiariesUkraine.Crimea"/>. Annexed by Russia in
        /// 2014 and under Russian control, but internationally recognized as part of Ukraine.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [DeFactoCapital((int)WorldCities.UkraineSimferopol)]
        [LargestCity((int)WorldCities.UkraineSimferopol)]
        [Texts("Respublika Krym", "Республика Крым")]
        Crimea,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaMakhachkala)]
        [LargestCity((int)WorldCities.RussiaMakhachkala)]
        [Texts("Dagestan", "Дагестан")]
        Dagestan,

        /// <summary>
        /// Also listed as <see cref="Ukraine.StateSubsidiariesUkraine.Donetsk"/>. Russia declared it
        /// annexed in 2022 but, as of November 2026, does not control all of it. Fighting continues.
        /// Internationally recognized as part of Ukraine.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [DeFactoCapital((int)WorldCities.UkraineDonetsk)]
        [LargestCity((int)WorldCities.UkraineDonetsk)]
        [Texts("Donetskaya Narodnaya Respublika", "Донецкая Народная Республика")]
        Donetsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Ingushetiya", "Ингушетия")]
        Ingushetia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaIrkutsk)]
        [LargestCity((int)WorldCities.RussiaIrkutsk)]
        [Texts("Irkutskaya Oblast", "Иркутская область")]
        Irkutsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Ivanovskaya Oblast", "Ивановская область")]
        Ivanovo,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Yevreyskaya Avtonomnaya Oblast", "Еврейская автономная область")]
        JewishAutonomousOblast,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Kabardino-Balkariya", "Кабардино-Балкария")]
        KabardinoBalkaria,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Kaliningradskaya Oblast", "Калининградская область")]
        Kaliningrad,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Kalmykiya", "Калмыкия")]
        Kalmykia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Kaluzhskaya Oblast", "Калужская область")]
        Kaluga,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Kamchatskiy Kray", "Камчатский край")]
        Kamchatka,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Karachayevo-Cherkesiya", "Карачаево-Черкесия")]
        KarachayCherkessia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Kareliya", "Карелия")]
        Karelia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaKemerovo)]
        [LargestCity((int)WorldCities.RussiaKemerovo)]
        [Texts("Kemerovskaya Oblast", "Кемеровская область")]
        Kemerovo,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaKhabarovsk)]
        [LargestCity((int)WorldCities.RussiaKhabarovsk)]
        [Texts("Khabarovskiy Kray", "Хабаровский край")]
        Khabarovsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Khakasiya", "Хакасия")]
        Khakassia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Khanty-Mansiyskiy Avtonomnyy Okrug", "Ханты-Мансийский автономный округ")]
        KhantyMansi,

        /// <summary>
        /// Also listed as <see cref="Ukraine.StateSubsidiariesUkraine.Kherson"/>. Russia declared it
        /// annexed in 2022 but, as of November 2026, Ukraine holds the city of Kherson and Russia holds
        /// Oleshky across the Dnipro River. Internationally recognized as part of Ukraine.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [ClaimedCapital((int)WorldCities.UkraineKherson)]
        [LargestCity((int)WorldCities.UkraineKherson)]
        [Texts("Khersonskaya Oblast", "Херсонская область")]
        Kherson,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Kirovskaya Oblast", "Кировская область")]
        Kirov,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Komi", "Коми")]
        Komi,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Kostromskaya Oblast", "Костромская область")]
        Kostroma,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaKrasnodar)]
        [LargestCity((int)WorldCities.RussiaKrasnodar)]
        [Texts("Krasnodarskiy Kray", "Краснодарский край")]
        Krasnodar,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaKrasnoyarsk)]
        [LargestCity((int)WorldCities.RussiaKrasnoyarsk)]
        [Texts("Krasnoyarskiy Kray", "Красноярский край")]
        Krasnoyarsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Kurganskaya Oblast", "Курганская область")]
        Kurgan,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Kurskaya Oblast", "Курская область")]
        Kursk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Leningradskaya Oblast", "Ленинградская область")]
        Leningrad,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Lipetskaya Oblast", "Липецкая область")]
        Lipetsk,

        /// <summary>
        /// Also listed as <see cref="Ukraine.StateSubsidiariesUkraine.Luhansk"/>. Russia declared it
        /// annexed in 2022 and holds nearly all of it. Internationally recognized as part of Ukraine.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [DeFactoCapital((int)WorldCities.UkraineLuhansk)]
        [LargestCity((int)WorldCities.UkraineLuhansk)]
        [Texts("Luganskaya Narodnaya Respublika", "Луганская Народная Республика")]
        Luhansk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Magadanskaya Oblast", "Магаданская область")]
        Magadan,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Mariy El", "Марий Эл")]
        MariEl,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Mordoviya", "Мордовия")]
        Mordovia,

        [StateSubsidiaryType(StateSubsidaryType.District)]
        [Capital((int)WorldCities.RussiaMoscow)]
        [LargestCity((int)WorldCities.RussiaMoscow)]
        [Texts("Moskva", "Москва")]
        MoscowCity,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [LargestCity((int)WorldCities.RussiaBalashikha)]
        [Texts("Moskovskaya Oblast", "Московская область")]
        MoscowOblast,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Murmanskaya Oblast", "Мурманская область")]
        Murmansk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Nenetskiy Avtonomnyy Okrug", "Ненецкий автономный округ")]
        Nenets,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaNizhnyNovgorod)]
        [LargestCity((int)WorldCities.RussiaNizhnyNovgorod)]
        [Texts("Nizhegorodskaya Oblast", "Нижегородская область")]
        NizhnyNovgorod,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Severnaya Osetiya - Alaniya", "Северная Осетия — Алания")]
        NorthOssetia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Novgorodskaya Oblast", "Новгородская область")]
        Novgorod,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaNovosibirsk)]
        [LargestCity((int)WorldCities.RussiaNovosibirsk)]
        [Texts("Novosibirskaya Oblast", "Новосибирская область")]
        Novosibirsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaOmsk)]
        [LargestCity((int)WorldCities.RussiaOmsk)]
        [Texts("Omskaya Oblast", "Омская область")]
        Omsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaOrenburg)]
        [LargestCity((int)WorldCities.RussiaOrenburg)]
        [Texts("Orenburgskaya Oblast", "Оренбургская область")]
        Orenburg,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Orlovskaya Oblast", "Орловская область")]
        Oryol,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaPenza)]
        [LargestCity((int)WorldCities.RussiaPenza)]
        [Texts("Penzenskaya Oblast", "Пензенская область")]
        Penza,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaPerm)]
        [LargestCity((int)WorldCities.RussiaPerm)]
        [Texts("Permskiy Kray", "Пермский край")]
        Perm,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaVladivostok)]
        [LargestCity((int)WorldCities.RussiaVladivostok)]
        [Texts("Primorskiy Kray", "Приморский край")]
        Primorsky,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Pskovskaya Oblast", "Псковская область")]
        Pskov,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaRostovOnDon)]
        [LargestCity((int)WorldCities.RussiaRostovOnDon)]
        [Texts("Rostovskaya Oblast", "Ростовская область")]
        Rostov,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaRyazan)]
        [LargestCity((int)WorldCities.RussiaRyazan)]
        [Texts("Ryazanskaya Oblast", "Рязанская область")]
        Ryazan,

        [StateSubsidiaryType(StateSubsidaryType.District)]
        [Capital((int)WorldCities.RussiaSaintPetersburg)]
        [LargestCity((int)WorldCities.RussiaSaintPetersburg)]
        [Texts("Sankt-Peterburg", "Санкт-Петербург")]
        SaintPetersburg,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Sakha (Yakutiya)", "Саха (Якутия)")]
        Sakha,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Sakhalinskaya Oblast", "Сахалинская область")]
        Sakhalin,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaSamara)]
        [LargestCity((int)WorldCities.RussiaSamara)]
        [Texts("Samarskaya Oblast", "Самарская область")]
        Samara,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaSaratov)]
        [LargestCity((int)WorldCities.RussiaSaratov)]
        [Texts("Saratovskaya Oblast", "Саратовская область")]
        Saratov,

        /// <summary>
        /// Also listed as <see cref="Ukraine.StateSubsidiariesUkraine.Sevastopol"/>. Annexed by Russia
        /// in 2014 and under Russian control, but internationally recognized as part of Ukraine.
        /// Home to a major naval base, the Russian Black Sea Fleet. Included despite population estimates
        /// straddling the 500,000 limit (393,304 in Ukraine's 2022 estimate, 547,820 in Russia's 2021 census).
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.District)]
        [DeFactoCapital((int)WorldCities.UkraineSevastopol)]
        [LargestCity((int)WorldCities.UkraineSevastopol)]
        [Texts("Sevastopol", "Севастополь")]
        Sevastopol,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Smolenskaya Oblast", "Смоленская область")]
        Smolensk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaStavropol)]
        [LargestCity((int)WorldCities.RussiaStavropol)]
        [Texts("Stavropolskiy Kray", "Ставропольский край")]
        Stavropol,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaYekaterinburg)]
        [LargestCity((int)WorldCities.RussiaYekaterinburg)]
        [Texts("Sverdlovskaya Oblast", "Свердловская область")]
        Sverdlovsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Tambovskaya Oblast", "Тамбовская область")]
        Tambov,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaKazan)]
        [LargestCity((int)WorldCities.RussiaKazan)]
        [Texts("Tatarstan", "Татарстан")]
        Tatarstan,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaTomsk)]
        [LargestCity((int)WorldCities.RussiaTomsk)]
        [Texts("Tomskaya Oblast", "Томская область")]
        Tomsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Tulskaya Oblast", "Тульская область")]
        Tula,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Tyva", "Тыва")]
        Tuva,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Tverskaya Oblast", "Тверская область")]
        Tver,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaTyumen)]
        [LargestCity((int)WorldCities.RussiaTyumen)]
        [Texts("Tyumenskaya Oblast", "Тюменская область")]
        Tyumen,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaIzhevsk)]
        [LargestCity((int)WorldCities.RussiaIzhevsk)]
        [Texts("Udmurtiya", "Удмуртия")]
        Udmurtia,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaUlyanovsk)]
        [LargestCity((int)WorldCities.RussiaUlyanovsk)]
        [Texts("Ulyanovskaya Oblast", "Ульяновская область")]
        Ulyanovsk,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Vladimirskaya Oblast", "Владимирская область")]
        Vladimir,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaVolgograd)]
        [LargestCity((int)WorldCities.RussiaVolgograd)]
        [Texts("Volgogradskaya Oblast", "Волгоградская область")]
        Volgograd,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Vologodskaya Oblast", "Вологодская область")]
        Vologda,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaVoronezh)]
        [LargestCity((int)WorldCities.RussiaVoronezh)]
        [Texts("Voronezhskaya Oblast", "Воронежская область")]
        Voronezh,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Yamalo-Nenetskiy Avtonomnyy Okrug", "Ямало-Ненецкий автономный округ")]
        YamaloNenets,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Capital((int)WorldCities.RussiaYaroslavl)]
        [LargestCity((int)WorldCities.RussiaYaroslavl)]
        [Texts("Yaroslavskaya Oblast", "Ярославская область")]
        Yaroslavl,

        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [Texts("Zabaykalskiy Kray", "Забайкальский край")]
        Zabaykalsky,

        /// <summary>
        /// Also listed as <see cref="Ukraine.StateSubsidiariesUkraine.Zaporizhzhia"/>. Russia declared
        /// it annexed in 2022 and holds the south, including Melitopol, but, as of November 2026, Ukraine
        /// holds the city of Zaporizhzhia. Internationally recognized as part of Ukraine.
        /// </summary>
        [StateSubsidiaryType(StateSubsidaryType.Province)]
        [ClaimedCapital((int)WorldCities.UkraineZaporizhzhia)]
        [LargestCity((int)WorldCities.UkraineZaporizhzhia)]
        [Texts("Zaporozhskaya Oblast", "Запорожская область")]
        Zaporizhzhia,
    }
}
