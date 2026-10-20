
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
            this.Period = Period;
        }
    }

    public class ApproximateAgeInYearsAttribute : Attribute
    {
        public int StartAge { get; set; }
        public int EndAge { get; set; }
        public ApproximateAgeInYearsAttribute(int StartAge, int EndAge)
        {
            this.StartAge = StartAge;
            this.EndAge = EndAge;
        }
        public ApproximateAgeInYearsAttribute(int Age)
        {
            StartAge = EndAge = Age;
        }
    }
}
