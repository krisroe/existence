using Existence.Time;

namespace Existence.Earth.Countries.Politics
{
    public enum Politicians
    {
        BolsonaroFlávio,
        BolsonaroJair,
        daSilvaLula,
        HaddadFernando,
    }

    public static class Elections
    {
        /// <summary>
        /// first Presidential election in 1894
        /// </summary>
        public static class Presidential
        {
            public static class v2018
            {
                [YearDate(2018, 10, 7)]
                public static class FirstRound { }

                [YearDate(2018, 10, 28)]
                [RunoffElectionResult((int)Politicians.BolsonaroJair, 55.13, (int)Politicians.HaddadFernando, 44.87)]
                public static class SecondRound { }
            }

            [Incumbent((int)Politicians.BolsonaroJair)]
            public static class v2022
            {
                [YearDate(2022, 10, 2)]
                public static class FirstRound { }

                [YearDate(2022, 10, 30)]
                [RunoffElectionResult((int)Politicians.daSilvaLula, 50.90, (int)Politicians.BolsonaroJair, 49.10)]
                public static class SecondRound { }

            }

            [Incumbent((int)Politicians.daSilvaLula)]
            public static class v2026
            {
                [YearDate(2026, 10, 4)]
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
