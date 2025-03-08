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
}
