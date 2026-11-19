using System;

namespace Existence.Song
{
    public class ComposersAttribute : Attribute
    {
        public string[] Composers { get; set; }
        public ComposersAttribute(params string[] Composers)
        {
            this.Composers = Composers;
        }
    }
    public class ArrangersAttribute : Attribute
    {
        public string[] Arrangers { get; set; }
        public ArrangersAttribute(params string[] Arrangers)
        {
            this.Arrangers = Arrangers;
        }
    }
    public class PerformersAttribute : Attribute
    {
        public string[] Performers { get; set; }
        public PerformersAttribute(params string[] Performers)
        {
            this.Performers = Performers;
        }
    }

    public class DedicationsAttribute : Attribute
    {
        public string[] Dedications { get; set; }
        public DedicationsAttribute(params string[] Dedications)
        {
            this.Dedications = Dedications;
        }
    }

    public class YouTubeVideoIDAttribute : Attribute
    {
        public string ID { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public YouTubeVideoIDAttribute(string ID, int Year, int Month, int Day)
        {
            this.ID = ID;
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class MusicalInstrumentGenreAttribute : MusicalInstrumentAttribute
    {
        public MusicGenres Genre { get; set; }
        public MusicalInstrumentGenreAttribute(MusicalInstruments Instrument, MusicGenres Genre) : base(Instrument)
        {
            this.Genre = Genre;
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class MusicalInstrumentAttribute : Attribute
    {
        public MusicalInstruments Instrument { get; set; }
        public MusicalInstrumentAttribute(MusicalInstruments Instrument)
        {
            this.Instrument = Instrument;
        }
    }

    public class MusicalInstrumentsAttribute : Attribute
    {
        public MusicalInstruments[] Instruments { get; set; }
        public MusicalInstrumentsAttribute(params MusicalInstruments[] Instruments)
        {
            this.Instruments = Instruments;
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class MusicalGenreAttribute : Attribute
    {
        public MusicGenres Genre { get; set; }
        public MusicalGenreAttribute(MusicGenres Genre)
        {
            this.Genre = Genre;
        }
    }

    public enum MusicGenres
    {
        Jazz,
    }

    public enum MusicalInstruments
    {
        Piccolo,

        Flute,

        /// <summary>
        /// double reed instrument
        /// </summary>
        Oboe,

        /// <summary>
        /// double reed instrument
        /// </summary>
        Bassoon,

        /// <summary>
        /// single reed instrument
        /// </summary>
        Clarinet,

        ClarinetBass,

        SaxophoneAlto,

        SaxophoneTenor,

        Percussion,

        PercussionDrumSet,

        PercussionXylophone,

        FrenchHorn,

        Trumpet,

        Trombone,

        Tuba,

        Piano,

        Voice,

        Handbells,

        Guitar,
    }

}
