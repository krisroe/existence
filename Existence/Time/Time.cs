using System;

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

    public class DeathdateAttribute : YearDateAttribute
    {
        public DeathdateAttribute(int Year, int Month, int Day) : base(Year, Month, Day) { }
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
