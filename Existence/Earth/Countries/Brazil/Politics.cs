using Existence.Beyond.Infrastructure;
using Existence.Earth.Human.People;
using Existence.Time;

namespace Existence.Earth.Countries.Politics
{
    public enum VersionHistory
    {
        [BeyondObjectVersion(1, 0, 0, 0)]
        [YearDate(2026, 10, 25)]
        CreatedFor2026PresidentialElection,

        [BeyondObjectVersion(1, 1, 0, 0)]
        [YearDate(2026, 10, 25)]
        RootedForAndPredicted2026PresidentialElection,

        [BeyondObjectVersion(1, 2, 0, 0)]
        [YearDate(2026, 10, 26)]
        AddLulaBarredIn2018,

        [BeyondObjectVersion(1, 3, 0, 0)]
        [YearDate(2026, 11, 6)]
        AddPresidentsSince1989Election,

        [BeyondObjectVersion(1, 4, 0, 0)]
        [YearDate(2026, 11, 6)]
        AddPresidentialElectionsSince1989,
    }

    public enum Politicians
    {
        [Gender(Gender.Male)]
        AlckminGeraldo,

        [Gender(Gender.Male)]
        [Father((int)Politicians.BolsonaroJair)]
        BolsonaroFlávio,
        
        [Gender(Gender.Male)]
        [Child((int)Politicians.BolsonaroFlávio)]
        BolsonaroJair,

        [Gender(Gender.Male)]
        BrizolaLeonel,

        [Gender(Gender.Male)]
        CardosoFernandoHenrique,

        [Gender(Gender.Male)]
        CollorFernando,

        [Gender(Gender.Male)]
        CuryAugustoJorge,

        [Gender(Gender.Male)]
        daSilvaLula,
        
        [Gender(Gender.Male)]
        deMoraisPrudente,

        [Gender(Gender.Male)]
        FrancoItamar,

        [Gender(Gender.Male)]
        GarotinhoAnthony,

        [Gender(Gender.Male)]
        GomesCiro,
        
        [Gender(Gender.Male)]
        HaddadFernando,

        [Gender(Gender.Female)]
        HelenaHeloísa,

        [Gender(Gender.Male)]
        NevesAécio,
        
        [Gender(Gender.Male)]
        PenaAfonso,

        [Gender(Gender.Female)]
        RousseffDilma,

        [Gender(Gender.Male)]
        SerraJosé,

        [Gender(Gender.Female)]
        SilvaMarina,
        
        [Gender(Gender.Female)]
        TebetSimoneNassar,

        [Gender(Gender.Male)]
        TemerMichel,
    }

    /// <summary>
    /// presidential tenures since the 1989 election, the first where <see cref="Politicians.daSilvaLula"/> was a
    /// candidate, named by the year the tenure started. Consecutive terms are one tenure, non-consecutive terms are
    /// separate. Some tenures overlap while a suspended president awaited an impeachment trial
    /// </summary>
    public static class Presidents
    {
        /// <summary>
        /// winner of the 1989 election. Suspended on 1992-10-02 when the impeachment process reached the Senate, and
        /// president only on paper until resigning on the day of the Senate's final judgment, while
        /// <see cref="Politicians.FrancoItamar"/> was acting president
        /// </summary>
        [President((int)Politicians.CollorFernando, 1990, 3, 15, 1992, 12, 29)]
        [PaperPresident((int)Politicians.CollorFernando, 1992, 10, 2, 1992, 12, 29)]
        public static class v1990 { }

        /// <summary>
        /// vice president who acted as president from 1992-10-02 while <see cref="Politicians.CollorFernando"/> was
        /// suspended, and took over when Collor resigned on 1992-12-29
        /// </summary>
        [President((int)Politicians.FrancoItamar, 1992, 10, 2, 1995, 1, 1)]
        [ActingPresident((int)Politicians.FrancoItamar, 1992, 10, 2, 1992, 12, 29)]
        public static class v1992 { }

        [President((int)Politicians.CardosoFernandoHenrique, 1995, 1, 1, 2003, 1, 1)]
        public static class v1995 { }

        [President((int)Politicians.daSilvaLula, 2003, 1, 1, 2011, 1, 1)]
        public static class v2003 { }

        /// <summary>
        /// suspended on 2016-05-12 when the Senate accepted the impeachment case, and president only on paper until the
        /// Senate removed her on 2016-08-31, while <see cref="Politicians.TemerMichel"/> was acting president
        /// </summary>
        [President((int)Politicians.RousseffDilma, 2011, 1, 1, 2016, 8, 31)]
        [PaperPresident((int)Politicians.RousseffDilma, 2016, 5, 12, 2016, 8, 31)]
        public static class v2011 { }

        /// <summary>
        /// vice president who acted as president from 2016-05-12 while <see cref="Politicians.RousseffDilma"/> was
        /// suspended, and took over when she was removed on 2016-08-31
        /// </summary>
        [President((int)Politicians.TemerMichel, 2016, 5, 12, 2019, 1, 1)]
        [ActingPresident((int)Politicians.TemerMichel, 2016, 5, 12, 2016, 8, 31)]
        public static class v2016 { }

        [President((int)Politicians.BolsonaroJair, 2019, 1, 1, 2023, 1, 1)]
        public static class v2019 { }

        [President((int)Politicians.daSilvaLula, 2023, 1, 1)]
        [CurrentPresident]
        public static class v2023 { }
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

            [Omitted]public static class v1898 { }
            [Omitted]public static class v1902 { }
            [Omitted]public static class v1906 { }
            [Omitted]public static class v1910 { }
            [Omitted]public static class v1914 { }
            [Omitted]public static class v1918 { }
            [Omitted]public static class v1919 { }
            [Omitted]public static class v1922 { }
            [Omitted]public static class v1926 { }
            [Omitted]public static class v1930 { }
            [Omitted]public static class v1934 { }
            [Omitted]public static class v1945 { }
            [Omitted]public static class v1950 { }
            [Omitted]public static class v1955 { }
            [Omitted]public static class v1960 { }
            [Omitted]public static class v1964 { }
            [Omitted]public static class v1966 { }
            [Omitted]public static class v1969 { }
            [Omitted]public static class v1974 { }
            [Omitted]public static class v1978 { }
            [Omitted]public static class v1985 { }

            /// <summary>
            /// first election where <see cref="Politicians.daSilvaLula"/> was a candidate
            /// </summary>
            public static class v1989
            {
                [YearDate(1989, 11, 15)]
                [AmbiguousRunoffElectionResult((int)Politicians.CollorFernando, 30.48, (int)Politicians.daSilvaLula, 17.19, (int)Politicians.BrizolaLeonel, 16.51)]
                public static class FirstRound { }

                [YearDate(1989, 12, 17)]
                [HeadToHeadElectionResult((int)Politicians.CollorFernando, 53.03, (int)Politicians.daSilvaLula, 46.97)]
                public static class SecondRound { }
            }

            /// <summary>
            /// won a majority in the first round, so no second round was held
            /// </summary>
            [YearDate(1994, 10, 3)]
            [HeadToHeadElectionResult((int)Politicians.CardosoFernandoHenrique, 54.28, (int)Politicians.daSilvaLula, 27.04)]
            public static class v1994 { }

            /// <summary>
            /// won a majority in the first round, so no second round was held
            /// </summary>
            [Incumbent((int)Politicians.CardosoFernandoHenrique)]
            [YearDate(1998, 10, 4)]
            [HeadToHeadElectionResult((int)Politicians.CardosoFernandoHenrique, 53.06, (int)Politicians.daSilvaLula, 31.71)]
            public static class v1998 { }

            public static class v2002
            {
                [YearDate(2002, 10, 6)]
                [AmbiguousRunoffElectionResult((int)Politicians.daSilvaLula, 46.44, (int)Politicians.SerraJosé, 23.20, (int)Politicians.GarotinhoAnthony, 17.87)]
                public static class FirstRound { }

                [YearDate(2002, 10, 27)]
                [HeadToHeadElectionResult((int)Politicians.daSilvaLula, 61.27, (int)Politicians.SerraJosé, 38.73)]
                public static class SecondRound { }
            }

            [Incumbent((int)Politicians.daSilvaLula)]
            public static class v2006
            {
                [YearDate(2006, 10, 1)]
                [AmbiguousRunoffElectionResult((int)Politicians.daSilvaLula, 48.61, (int)Politicians.AlckminGeraldo, 41.64, (int)Politicians.HelenaHeloísa, 6.85)]
                public static class FirstRound { }

                [YearDate(2006, 10, 29)]
                [HeadToHeadElectionResult((int)Politicians.daSilvaLula, 60.83, (int)Politicians.AlckminGeraldo, 39.17)]
                public static class SecondRound { }
            }

            public static class v2010
            {
                [YearDate(2010, 10, 3)]
                [AmbiguousRunoffElectionResult((int)Politicians.RousseffDilma, 46.91, (int)Politicians.SerraJosé, 32.61, (int)Politicians.SilvaMarina, 19.33)]
                public static class FirstRound { }

                [YearDate(2010, 10, 31)]
                [HeadToHeadElectionResult((int)Politicians.RousseffDilma, 56.05, (int)Politicians.SerraJosé, 43.95)]
                public static class SecondRound { }
            }

            [Incumbent((int)Politicians.RousseffDilma)]
            public static class v2014
            {
                [YearDate(2014, 10, 5)]
                [AmbiguousRunoffElectionResult((int)Politicians.RousseffDilma, 41.59, (int)Politicians.NevesAécio, 33.55, (int)Politicians.SilvaMarina, 21.32)]
                public static class FirstRound { }

                [YearDate(2014, 10, 26)]
                [HeadToHeadElectionResult((int)Politicians.RousseffDilma, 51.64, (int)Politicians.NevesAécio, 48.36)]
                public static class SecondRound { }
            }

            public static class v2018
            {
                [YearDate(2018, 10, 7)]
                [CandidateBarred((int)Politicians.daSilvaLula, replacement: (int)Politicians.HaddadFernando, "Registered while in prison and leading the polls. Barred under the Ficha Limpa (Clean record) law")]
                [AmbiguousRunoffElectionResult((int)Politicians.BolsonaroJair, 46.03, (int)Politicians.HaddadFernando, 29.28, (int)Politicians.GomesCiro, 12.47)]
                public static class FirstRound { }

                [YearDate(2018, 10, 28)]
                [HeadToHeadElectionResult((int)Politicians.BolsonaroJair, 55.13, (int)Politicians.HaddadFernando, 44.87)]
                public static class SecondRound { }
            }

            [Incumbent((int)Politicians.BolsonaroJair)]
            public static class v2022
            {
                [YearDate(2022, 10, 2)]
                [AmbiguousRunoffElectionResult((int)Politicians.daSilvaLula, 48.43, (int)Politicians.BolsonaroJair, 43.20, (int)Politicians.TebetSimoneNassar, 4.16)]
                public static class FirstRound { }

                [YearDate(2022, 10, 30)]
                [HeadToHeadElectionResult((int)Politicians.daSilvaLula, 50.90, (int)Politicians.BolsonaroJair, 49.10)]
                [OnlyConcededPrivately((int)Politicians.BolsonaroJair, "Supreme Court justices", "acabou (it's over)")]
                public static class SecondRound { }

            }

            [Incumbent((int)Politicians.daSilvaLula)]
            public static class v2026
            {
                [YearDate(2026, 10, 4)]
                [AmbiguousRunoffElectionResult((int)Politicians.BolsonaroFlávio, 47.03, (int)Politicians.daSilvaLula, 45.16, (int)Politicians.CuryAugustoJorge, 2.89)]
                public static class FirstRound { }

                [IRootedFor((int)Politicians.BolsonaroFlávio)]
                [IPredictedElectionWinner((int)Politicians.BolsonaroFlávio)]
                [YearDate(2026, 10, 25)]
                [HeadToHeadElectionResult((int)Politicians.daSilvaLula, 51.79, (int)Politicians.BolsonaroFlávio, 48.21)]
                [VoteValidity(validPercent: 96.76, invalidPercent: 2.12, blankPercent: 1.12)]
                [LikelyElectionWinner((int)Politicians.daSilvaLula)]
                public static class SecondRound { }
            }
        }
    }
}
