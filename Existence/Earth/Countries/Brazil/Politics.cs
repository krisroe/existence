using Existence.Earth.Human.People;
using Existence.Time;

namespace Existence.Earth.Countries.Politics
{
    public enum Politicians
    {
        [Gender(Gender.Male)]
        [Father((int)Politicians.BolsonaroJair)]
        BolsonaroFlávio,
        [Gender(Gender.Male)]
        BolsonaroJair,
        [Gender(Gender.Male)]
        daSilvaLula,
        [Gender(Gender.Male)]
        deMoraisPrudente,
        [Gender(Gender.Male)]
        HaddadFernando,
        [Gender(Gender.Male)]
        PenaAfonso,
    }

    public static class Elections
    {
        /// <summary>
        /// first Presidential election in 1894
        /// </summary>
        public static class Presidential
        {
            [YearDate(1894, 3, 1)]
            [HeadToHeadElectionResult((int)Politicians.deMoraisPrudente, 80.15, (int)Politicians.PenaAfonso, 11.10)]
            public static class v1894 { }

            [Omitted]
            public static class v1898 { }
            [Omitted]
            public static class v1902 { }
            [Omitted]
            public static class v1906 { }
            [Omitted]
            public static class v1910 { }
            [Omitted]
            public static class v1914 { }
            [Omitted]
            public static class v1918 { }
            [Omitted]
            public static class v1919 { }
            [Omitted]
            public static class v1922 { }
            [Omitted]
            public static class v1926 { }
            [Omitted]
            public static class v1930 { }
            [Omitted]
            public static class v1934 { }
            [Omitted]
            public static class v1945 { }
            [Omitted]
            public static class v1950 { }
            [Omitted]
            public static class v1955 { }
            [Omitted]
            public static class v1960 { }
            [Omitted]
            public static class v1964 { }
            [Omitted]
            public static class v1966 { }
            [Omitted]
            public static class v1969 { }
            [Omitted]
            public static class v1974 { }
            [Omitted]
            public static class v1978 { }
            [Omitted]
            public static class v1985 { }
            [Omitted]
            public static class v1989 { }
            [Omitted]
            public static class v1994 { }
            [Omitted]
            public static class v1998 { }
            [Omitted]
            public static class v2002 { }
            [Omitted]
            public static class v2006 { }
            [Omitted]
            public static class v2010 { }
            [Omitted]
            public static class v2014 { }

            public static class v2018
            {
                [YearDate(2018, 10, 7)]
                [AmbiguousRunoffElectionResult((int)Politicians.BolsonaroJair, 46.03, (int)Politicians.HaddadFernando, 29.28)]
                public static class FirstRound { }

                [YearDate(2018, 10, 28)]
                [HeadToHeadElectionResult((int)Politicians.BolsonaroJair, 55.13, (int)Politicians.HaddadFernando, 44.87)]
                public static class SecondRound { }
            }

            [Incumbent((int)Politicians.BolsonaroJair)]
            public static class v2022
            {
                [YearDate(2022, 10, 2)]
                [AmbiguousRunoffElectionResult((int)Politicians.daSilvaLula, 48.43, (int)Politicians.BolsonaroJair, 43.20)]
                public static class FirstRound { }

                [YearDate(2022, 10, 30)]
                [HeadToHeadElectionResult((int)Politicians.daSilvaLula, 50.90, (int)Politicians.BolsonaroJair, 49.10)]
                public static class SecondRound { }

            }

            [Incumbent((int)Politicians.daSilvaLula)]
            public static class v2026
            {
                [YearDate(2026, 10, 4)]
                [AmbiguousRunoffElectionResult((int)Politicians.BolsonaroFlávio, 47.03, (int)Politicians.daSilvaLula, 45.16)]
                public static class FirstRound { }

                /// <summary>
                /// Flávio Bolsonaro vs Lula; result not yet known
                /// </summary>
                [YearDate(2026, 10, 25)]
                public static class SecondRound { }
            }
        }
    }
}
