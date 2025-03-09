using System;
using Existence.Earth.Alphabet;

namespace Existence.Time
{
    public class TimeChangeMinutesAttribute : TimeMinutesAttribute
    {
        public TimeChangeMinutesAttribute(int Minutes, int Seconds) : base(Minutes, Seconds)
        {
        }
    }

    public class TimeDurationMinutesAttribute : TimeMinutesAttribute
    {
        public TimeDurationMinutesAttribute(int Minutes, int Seconds) : base(Minutes, Seconds)
        {
        }
    }

    public class TimeMinutesAttribute : Attribute
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public TimeMinutesAttribute(int Minutes, int Seconds)
        {
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }
    }

    public class YearAttribute : Attribute
    {
        public int Year { get; set; }
        public YearAttribute(int Year)
        {
            this.Year = Year;
        }
    }

    public class YearRangeAttribute : Attribute
    {
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public YearRangeAttribute(int StartYear, int EndYear)
        {
            this.StartYear = StartYear;
            this.EndYear = EndYear;
        }
    }

    public class YearListAttribute : Attribute
    {
        public int[] Years { get; set; }
        public YearListAttribute(params int[] Years)
        {
            this.Years = Years;
        }
    }

    public enum Seasons
    {
        Winter,
        Fall,
        Spring,
        Summer,
    }

    public class DeathdateUnknownAttribute : Attribute
    {
    }

    public class DeathdateSignificantEventAttribute : Attribute
    {
        public int SignificantEvent { get; set; }
        public DeathdateSignificantEventAttribute(int SignificantEvent)
        {
            this.SignificantEvent = SignificantEvent;
        }
    }

    public class CauseOfDeathAttribute : TextAttribute
    {
        public string CauseOfDeath
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
        public CauseOfDeathAttribute(string CauseOfDeath) : base(CauseOfDeath) { }
    }

    public class DeathdateAttribute : YearDateAttribute
    {
        public Seasons? Season { get; set; }
        public DeathdateAttribute(int Year) : base(Year, 0, 0)
        {

        }
        public DeathdateAttribute(int Year, Seasons Season) : base(Year, 0, 0)
        {
            this.Season = Season;
        }

        public DeathdateAttribute(int Year, int Month, int Day) : base(Year, Month, Day) { }
    }

    public class ApproximateBirthdateAttribute : BirthdateAttribute
    {
        public ApproximateBirthdateAttribute(int Year) : base(Year, 0, 0)
        {
        }
    }

    public class BirthdateUnknownAttribute : Attribute
    {
    }

    public class BirthdateAttribute : YearDateAttribute
    {
        public BirthdateAttribute(int Year, int Month, int Day) : base(Year, Month, Day) { }
    }

    public class YearDateAttribute : CalendarDateAttribute
    {
        public int Year { get; set; }
        public YearDateAttribute(int Year, int Month, int Day) : base(Month, Day)
        {
            this.Year = Year;
        }
    }

    public class CalendarDateAttribute : Attribute
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public CalendarDateAttribute(int Month, int Day)
        {
            this.Month = Month;
            this.Day = Day;
        }
    }

    internal class SpaceTimeContinuum
    {
        internal class Continuum
        {
            public static class Space { }
            public static class Time { }
        }
    }

    internal class LinkURX
    {
        public static class Uniform { }
        public static class Resource { }
        public static class LocatorOrIndentifier { }
    }

    internal class UPS
    {
        public static class U
        {
            public static class United { }
            public static class Universal { }
        }
        public static class P
        {
            public static class Postal { }
            public static class Parcel { }
        }
        public static class Service { }
    }

    internal class IPT
    {
        public static class Intergalactic { }
        public static class P
        {
            public static class Pulsar { }
            public static class Postal { }
            public static class Parcel { }
        }
        public static class Time { }
    }
}
