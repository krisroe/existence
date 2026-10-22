using System;

namespace Existence.Earth.Human
{
    /// <summary>
    /// Base attribute for estimates of a number of people (followers, members, speakers, etc.)
    /// Uses long instead of int because an int can only represent about 2.1 billion, and some groups
    /// are larger
    /// </summary>
    public class NumberOfPeopleAttribute : Attribute
    {
        public long LowEstimate { get; set; }
        public long HighEstimate { get; set; }
        public NumberOfPeopleAttribute(long Estimate)
        {
            LowEstimate = HighEstimate = Estimate;
        }
        public NumberOfPeopleAttribute(long LowEstimate, long HighEstimate)
        {
            this.LowEstimate = LowEstimate;
            this.HighEstimate = HighEstimate;
        }
    }
}
