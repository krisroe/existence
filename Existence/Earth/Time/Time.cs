
using Existence.Earth.FieldsOfStudy.Mathematics;
using System;

namespace Existence.Earth.Time
{
    public enum TimePeriods
    {
        Seconds,
        Minutes,
        Hours,
        Days,
        Months,
        Years,
    }

    public static class TimeStatic
    {
        public const int UNKNOWN_TIME_PERIOD = -1;
    }

    public class AgeAttribute : NumberAttribute
    {
        public TimePeriods Period { get; set; }
        public int Age
        {
            get
            {
                return base.Number;
            }
            set
            {
                base.Number = value;
            }
        }
        public AgeAttribute(int Age, TimePeriods Period) : base(Age)
        {
            if (Age < TimeStatic.UNKNOWN_TIME_PERIOD) throw new ArgumentOutOfRangeException(nameof(Age));
            this.Period = Period;
        }
    }

    public class ApproximateAgeInYearsAttribute : Attribute
    {
        public int StartAge { get; set; }
        public int EndAge { get; set; }
        public ApproximateAgeInYearsAttribute(int StartAge, int EndAge)
        {
            if (StartAge < TimeStatic.UNKNOWN_TIME_PERIOD) throw new ArgumentOutOfRangeException(nameof(StartAge));
            if (EndAge < TimeStatic.UNKNOWN_TIME_PERIOD) throw new ArgumentOutOfRangeException(nameof(EndAge));
            this.StartAge = StartAge;
            this.EndAge = EndAge;
        }
        public ApproximateAgeInYearsAttribute(int Age)
        {
            if (Age < TimeStatic.UNKNOWN_TIME_PERIOD) throw new ArgumentOutOfRangeException(nameof(Age));
            StartAge = EndAge = Age;
        }
    }
}
