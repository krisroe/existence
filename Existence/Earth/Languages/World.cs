using System;
using Existence.Earth.Alphabet;

namespace Existence.Earth.Languages
{
    public enum OfficialLanguageContext
    {
        UnitedNations,
        Vatican,
    }

    public class OfficialLanguageOfAttribute : Attribute
    {
        public OfficialLanguageContext[] Contexts { get; set; }
        public OfficialLanguageOfAttribute(params OfficialLanguageContext[] Contexts)
        {
            this.Contexts = Contexts;
        }
    }

    public class NumberOfSpeakersAttribute : Attribute
    {
        public int LowEstimate { get; set; }
        public int HighEstimate { get; set; }
        public NumberOfSpeakersAttribute(int LowEstimate, int HighEstimate)
        {
            this.LowEstimate = LowEstimate;
            this.HighEstimate = HighEstimate;
        }
    }

    public class NumberOfFluentSpeakersAttribute : NumberOfSpeakersAttribute
    {
        public NumberOfFluentSpeakersAttribute(int LowEstimate, int HighEstimate) : base(LowEstimate, HighEstimate)
        {
        }
    }

    public class NumberOfNativeSpeakersAttribute : NumberOfSpeakersAttribute
    {
        public NumberOfNativeSpeakersAttribute(int LowEstimate, int HighEstimate) : base(LowEstimate, HighEstimate)
        {
        }
    }

    public class NumberOfSomewhatFunctionalSpeakers : NumberOfSpeakersAttribute
    {
        public NumberOfSomewhatFunctionalSpeakers(int LowEstimate, int HighEstimate) : base(LowEstimate, HighEstimate)
        {
        }
    }

    [TODO("Ladino/Bukhori/Tajik, Get all languages supported by Google Translate on this list, all wikipedia wikis would be better but any improvement is valuable")]
    public enum WorldLanguages
    {
        [NumberOfFluentSpeakers(1500000000, 1900000000)] //1.5-1.9 billion
        [NumberOfNativeSpeakers(380000000, 400000000)] //380-400 million
        [OfficialLanguageOf(OfficialLanguageContext.UnitedNations)]
        English,

        [NumberOfFluentSpeakers(1100000000, 1300000000)] //1.1-1.3 billion
        [NumberOfNativeSpeakers(940000000, 1000000000)] //0.94-1 billion
        [OfficialLanguageOf(OfficialLanguageContext.UnitedNations)]
        Mandarin,

        [NumberOfFluentSpeakers(600000000, 700000000)] //600-700 million
        [NumberOfNativeSpeakers(345000000, 370000000)] //345-370 million
        Hindi,

        [NumberOfFluentSpeakers(590000000, 600000000)] //590-600 million
        [NumberOfNativeSpeakers(495000000, 500000000)] //495-500 million
        [OfficialLanguageOf(OfficialLanguageContext.UnitedNations)]
        Spanish,

        [NumberOfFluentSpeakers(390000000, 460000000)] //390-460 million
        [NumberOfNativeSpeakers(360000000, 400000000)] //360-400 million
        [OfficialLanguageOf(OfficialLanguageContext.UnitedNations)]
        Arabic,

        [NumberOfFluentSpeakers(300000000, 390000000)] //300-390 million
        [NumberOfNativeSpeakers(80000000, 90000000)] //80-90 million
        [OfficialLanguageOf(OfficialLanguageContext.UnitedNations)]
        French,

        [NumberOfFluentSpeakers(260000000, 290000000)] //260-290 million
        [NumberOfNativeSpeakers(230000000, 250000000)] //230-250 million
        Bengali,

        [NumberOfFluentSpeakers(260000000, 285000000)] //260-285 million
        [NumberOfNativeSpeakers(150000000, 160000000)] //150-160 million
        [OfficialLanguageOf(OfficialLanguageContext.UnitedNations)]
        Russian,

        [NumberOfFluentSpeakers(255000000, 280000000)] //255-280 million
        [NumberOfNativeSpeakers(235000000, 250000000)] //235-250 million
        Portuguese,

        /// <summary>
        /// grouping with Malay
        /// </summary>
        [NumberOfFluentSpeakers(250000000, 270000000)] //250-270 million
        [NumberOfNativeSpeakers(60000000, 70000000)] //60-70 million
        Indonesian,

        [NumberOfFluentSpeakers(230000000, 270000000)] //230-270 million
        [NumberOfNativeSpeakers(70000000, 100000000)] //70-100 million
        Urdu,

        /// <summary>
        /// including farsi
        /// </summary>
        [NumberOfFluentSpeakers(125000000, 140000000)] //125-140 million
        [NumberOfNativeSpeakers(75000000, 80000000)] //75-80 million
        Persian,

        [NumberOfFluentSpeakers(120000000, 130000000)] //120-130 million
        [NumberOfNativeSpeakers(110000000, 115000000)] //110-115 million
        Punjabi,

        [NumberOfFluentSpeakers(121000000, 127000000)] //121-127 million
        [NumberOfNativeSpeakers(120000000, 125000000)] //120-125 million
        Japanese,

        [NumberOfFluentSpeakers(90000000, 135000000)] //90-135 million
        [NumberOfNativeSpeakers(75000000, 80000000)] //75-80 million
        German,

        [NumberOfFluentSpeakers(80000000, 120000000)] //80-120 million
        [NumberOfNativeSpeakers(16000000, 20000000)] //16-20 million
        Swahili,

        [NumberOfFluentSpeakers(90000000, 110000000)] //90-110 million
        [NumberOfNativeSpeakers(85000000, 100000000)] //85-100 million
        Cantonese,

        [NumberOfFluentSpeakers(88000000, 95000000)] //88-95 million
        [NumberOfNativeSpeakers(85000000, 90000000)] //85-90 million
        Vietnamese,

        [NumberOfFluentSpeakers(88000000, 93000000)] //88-93 million
        [NumberOfNativeSpeakers(85000000, 88000000)] //85-88 million
        Turkish,

        [NumberOfFluentSpeakers(85000000, 100000000)] //85-100 million
        [NumberOfNativeSpeakers(84000000, 95000000)] //84-95 million
        Javanese,

        [NumberOfFluentSpeakers(85000000, 100000000)] //85-100 million
        [NumberOfNativeSpeakers(82000000, 95000000)] //82-95 million
        Telugu,

        [NumberOfFluentSpeakers(86000000, 90000000)] //86-90 million
        [NumberOfNativeSpeakers(83000000, 85000000)] //83-85 million
        Marathi,

        [NumberOfFluentSpeakers(80000000, 100000000)] //80-100 million
        [NumberOfNativeSpeakers(60000000, 70000000)] //60-70 million
        Thai,
        
        [NumberOfFluentSpeakers(85000000, 90000000)] //85-90 million
        [NumberOfNativeSpeakers(75000000, 80000000)] //75-80 million
        Tamil,

        [NumberOfFluentSpeakers(78000000, 82000000)] //78-82 million
        [NumberOfNativeSpeakers(77000000, 80000000)] //77-80 million
        Korean,

        [NumberOfFluentSpeakers(75000000, 80000000)] //75-80 million
        [NumberOfNativeSpeakers(28000000, 30000000)] //28-30 million
        Tagalog,

        [NumberOfFluentSpeakers(67000000, 72000000)] //67-72 million
        [NumberOfNativeSpeakers(64000000, 67000000)] //64-67 million
        [OfficialLanguageOf(OfficialLanguageContext.Vatican)]
        Italian,

        [NumberOfFluentSpeakers(60000000, 65000000)] //60-65 million
        [NumberOfNativeSpeakers(56000000, 60000000)] //56-60 million
        Gujarati,

        [NumberOfFluentSpeakers(41000000, 48000000)] //41-48 million
        [NumberOfNativeSpeakers(40000000, 45000000)] //40-45 million
        Polish,

        [NumberOfFluentSpeakers(40000000, 50000000)] //40-50 million
        [NumberOfNativeSpeakers(30000000, 35000000)] //30-35 million
        Ukrainian,

        [NumberOfFluentSpeakers(28000000, 32000000)] //28-32 million
        [NumberOfNativeSpeakers(24000000, 26000000)] //24-26 million
        Romanian,

        /// <summary>
        /// ethiopia
        /// </summary>
        [NumberOfFluentSpeakers(26000000, 32000000)] //26-32 million
        [NumberOfNativeSpeakers(22000000, 25000000)] //22-25 million
        Amharic,

        [NumberOfFluentSpeakers(27000000, 29000000)] //27-29 million
        [NumberOfNativeSpeakers(23000000, 24000000)] //23-24 million
        Dutch,

        [NumberOfFluentSpeakers(13000000, 15000000)] //13-15 million
        [NumberOfNativeSpeakers(12000000, 13000000)] //12-13 million
        Hungarian,

        [NumberOfFluentSpeakers(13000000, 15000000)] //13-15 million
        [NumberOfNativeSpeakers(12000000, 13000000)] //12-13 million
        Greek,

        [NumberOfFluentSpeakers(11000000, 13000000)] //11-13 million
        [NumberOfNativeSpeakers(9000000, 10000000)] //9-10 million
        Hebrew,

        [NumberOfFluentSpeakers(10000000, 12000000)] //10-12 million
        [NumberOfNativeSpeakers(9000000, 10000000)] //9-10 million
        Swedish,

        [NumberOfFluentSpeakers(8000000, 10000000)] //8-10 million
        [NumberOfNativeSpeakers(7000000, 8000000)] //7-8 million
        Tigrinya,

        [NumberOfFluentSpeakers(700000, 950000)]
        [NumberOfNativeSpeakers(600000, 750000)]
        Yiddish,

        [NumberOfFluentSpeakers(120000, 170000)]
        [NumberOfNativeSpeakers(100000, 120000)]
        Navajo,

        /// <summary>
        /// most successful constructed (planned) language in the world. Created in 1887.
        /// </summary>
        [NumberOfFluentSpeakers(10000, 100000)]
        [NumberOfNativeSpeakers(1000, 2000)]
        Esperanto,

        /// <summary>
        /// Alaska Native language, spoken mainly in western Alaska.
        /// </summary>
        [NumberOfSpeakers(10000, 13000)]
        Yupik,

        /// <summary>
        /// Athabaskan family, spoken in Arizona, New Mexico.
        /// </summary>
        [NumberOfSpeakers(2000, 3000)]
        Apache,

        /// <summary>
        /// Siouan language family
        /// </summary>
        [NumberOfSpeakers(2000, 2000)]
        Lakota,

        /// <summary>
        /// Significant revitalization efforts, including language immersion schools in Oklahoma and North Carolina.
        /// </summary>
        [NumberOfSpeakers(1500, 2000)]
        Cherokee,

        /// <summary>
        /// Siouan language family
        /// </summary>
        [NumberOfSpeakers(290, 300)]
        Dakota,

        /// <summary>
        /// less than 100 fluent speakers
        /// Hello: Hąąp
        /// Thank you: Wąąkšhą
        /// Ho-Chunk people (self-name): Hoocąk
        /// </summary>
        [NumberOfSpeakers(100, 100)]
        HoChunk,

        /// <summary>
        /// Mexico. Apparently the remaining two native speakers are reported to no longer speak to each other
        /// Language family: Mixe–Zoquean
        /// Chance of "Hidden" Native speakers: Extremely unlikely
        /// Speaker names: Manuel Segovia, Isidro Velázquez (also seen as Isidro Velásquez)
        /// </summary>
        [NumberOfNativeSpeakers(2, 2)]
        Ayapaneco,

        /// <summary>
        /// Peru: Amadeo García García
        /// Language family: Isolate (no known relatives)
        /// Chance of "Hidden" Native speakers: Very unlikely, though small remote chance
        /// </summary>
        [NumberOfNativeSpeakers(1, 1)]
        Taushiro,

        /// <summary>
        /// USA - California
        /// Last known fluent speaker Marie Wilcox died in 2021
        /// She did not maintain fluency thoughout her entire life, she lost fluency and gained it back later
        /// Language family (Yokutsan)
        /// Chance of "Hidden" Native speakers: Extremely unlikely
        /// </summary>
        [NumberOfFluentSpeakers(0, 0)]
        [NumberOfNativeSpeakers(0, 0)]
        Wukchumni,

        /// <summary>
        /// USA - North Dakota
        /// Last known native speaker: Edwin Benson (died 2016)
        /// Functionally extinct as a native language, though limited revitalization.
        /// </summary>
        [NumberOfFluentSpeakers(0, 0)]
        [NumberOfNativeSpeakers(0, 0)]
        Mandan,

        /// <summary>
        /// USA (Washington State)
        /// Last known native speaker: Hazel Sampson (died 2014)
        /// Extinct as a native language, but actively taught and being revitalized. Culturally alive.
        /// </summary>
        [NumberOfFluentSpeakers(0, 0)]
        [NumberOfNativeSpeakers(0, 0)]
        Klallam,

        /// <summary>
        /// Andaman Islands, India
        /// Last Known Native Speaker: Boa Sr. (died 2010)
        /// Completely extinct. Bo is considered fully dead. One of the clearest modern examples of language extinction.
        /// </summary>
        [NumberOfFluentSpeakers(0, 0)]
        [NumberOfNativeSpeakers(0, 0)]
        Bo,

        /// <summary>
        /// USA  - Alaska
        /// Last Known Native Speaker: Marie Smith Jones (died 2008)
        /// Extinct as a native language, but revitalization is active. Language learners but no native speakers.
        /// </summary>
        [NumberOfFluentSpeakers(0, 0)]
        [NumberOfNativeSpeakers(0, 0)]
        Eyak,

        /// <summary>
        /// Caucasus/Turkey
        /// Last Known Native Speaker: Tevfik Esenç (died 1992)
        /// Fully extinct, though well-documented by linguists like Georges Dumézil.
        /// </summary>
        [NumberOfFluentSpeakers(0, 0)]
        [NumberOfNativeSpeakers(0, 0)]
        Ubykh,

        /// <summary>
        /// USA - California
        /// Last Known Native Speaker: Laura Fish Somersal (died 1990)
        /// Completely extinct.
        /// </summary>
        [NumberOfFluentSpeakers(0, 0)]
        [NumberOfNativeSpeakers(0, 0)]
        Wappo,

        /// <summary>
        /// USA - California
        /// Last Known Native Speaker: Ishi (died 1916)
        /// Fully extinct. One of the earliest and best-documented "last speaker" cases
        /// </summary>
        [NumberOfFluentSpeakers(0, 0)]
        [NumberOfNativeSpeakers(0, 0)]
        Yana,

        /// <summary>
        /// vulgar latin vs classical latin (modern speakers are trained on the older classical latin)
        /// most functional latin speakers today are academics
        /// the pope(s)' latin capabilities are functionl, not conversational
        /// There might not be any true native speakers of classical latin, as it was an artificial, formal, high register langue, maybe some aristocratic
        /// or elites might have gotten the closest
        /// last native speaking latin speaker died: 800-900 CE
        /// </summary>
        [NumberOfFluentSpeakers(0, 0)]
        [NumberOfNativeSpeakers(0, 0)]
        [NumberOfSomewhatFunctionalSpeakers(1000, 5000)]
        [OfficialLanguageOf(OfficialLanguageContext.Vatican)]
        Latin,
    }

    public static class World
    {
        public static class English
        {
            public static class Countries
            {
                public static class UnitedStates { }
                public static class UnitedKingdom { }
                public static class Australia { }
            }
        }
        public static class French
        {
            public static class Diplomacy { }
        }

        public static class Swedish
        {
            public static class Embassy
            {
                public static class Universal { }
            }
        }

        public static class Arabic
        {
            public static class Religion
            {
                public static class Islam
                {
                    public static class Person
                    {
                        public static class Muslim { }
                    }
                    public static class Divided
                    {
                        public static class Sunni { }
                        public static class Shiite { }
                    }
                }
            }
        }

        public static class Spanish
        {
            public static class Influenza { }
            public static class Flu { }
            public static class Epidemic { }
            public static class Over { }
        }

        public static class Vietnamese
        {
            public static class War { }
            public static class Over { }
            public static class Communism { }
            public static class Won { }
        }

        public static class Korean
        {
            public static class War { }
            public static class Over { }
            public static class Standstill { }
            public static class North
            {
                public static class Place { }
                public static class To { }
                public static class Live { }
                public static class Terrible
                {
                    public static class Trying { }
                    public static class To { }
                    public static class Acquire { }
                    public static class Ballistic { }
                    public static class Nuclear { }
                    public static class Weapons { }
                }
            }
            public static class South
            {
                public static class Good { }
                public static class Place { }
                public static class To { }
                public static class Live { }
                public static class Because { }
                public static class Capitalism { }
            }
        }

        public static class War
        {
            public static class World
            {
                public static class First
                {
                    public static class Entente
                    {
                        public static class Italy { }
                        public static class Russia { }
                        public static class UnitedKingdom { }
                    }
                    public static class Won { }
                    public static class Over { }
                    public static class CentralPowers
                    {
                        public static class Germany
                        {
                            public static class Result { }
                            public static class Weimar { }
                            public static class Republic { }
                            public static class Hyperinflation { }
                        }
                        public static class Austria { }
                        public static class Hungary { }
                        public static class Ottoman { }
                        public static class Empire { }
                    }

                }
                public static class Second
                {
                    public static class Over { }
                    public static class Allies { }
                    public static class Won { }
                    public static class Beat { }
                    public static class Axis { }
                    public static class Bloodiest { }
                    public static class War { }
                    public static class On { }
                    public static class Earth { }
                }
            }
        }
    }
}
