using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates
{
    [Year(2025)]
    public static class CurrentYear { }

    public enum Months
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    /// <summary>
    /// Not:
    /// Martin Luther King, Jr. Day
    /// Presidents' Day
    /// Memorial Day
    /// Labor Day
    /// Thanksgiving
    /// Tax Day (April 15, or next business day if it falls on a weekend/holiday)
    /// Equinoxes and Solstices
    /// </summary>
    public class FixedDateHolidays
    {
        /// <summary>
        /// federal holiday
        /// </summary>
        [CalendarDate((int)Months.January, 1)]
        public static class NewYearsDay { }

        [CalendarDate((int)Months.February, 2)]
        public static class GroundhogDay { }
        /// <summary>
        /// observed in some states
        /// </summary>
        [CalendarDate((int)Months.February, 12)]
        public static class LincolnsBirthday { }

        [CalendarDate((int)Months.February, 14)]
        public static class ValentinesDay { }

        /// <summary>
        /// mathematical celebration
        /// </summary>
        [CalendarDate((int)Months.March, 14)]
        public static class PiDay { }

        [CalendarDate((int)Months.March, 17)]
        public static class SaintPatricksDay { }

        [CalendarDate((int)Months.April, 1)]
        public static class AprilFoolsDay { } 

        /// <summary>
        /// cultural celebration
        /// </summary>
        [CalendarDate((int)Months.May, 5)]
        public static class CincoDeMayo { }

        [CalendarDate((int)Months.June, 14)]
        public static class FlagDay { }

        /// <summary>
        /// federal holiday
        /// </summary>
        [CalendarDate((int)Months.July, 4)]
        public static class IndependenceDay { }

        [CalendarDate((int)Months.September, 17)]
        public static class ConstitutionDay { }

        [CalendarDate((int)Months.October, 31)]
        public static class Halloween { }

        /// <summary>
        /// federal holiday
        /// </summary>
        [CalendarDate((int)Months.November, 11)]
        public static class VeteransDay { }

        /// <summary>
        /// National Pearl Harbor Remembrance Day, an annual observance established in 1994
        /// Reference: public Law 103-308, signed by President Bill Clinton on August 23, 1994
        /// The U.S. flag is flown at half-staff until sunset.
        /// Memorial ceremonies are held, especially at the Pearl Harbor National Memorial in Hawaii.
        /// The President issues an annual proclamation encouraging Americans to honor the memory of those who died in the attack.
        /// </summary>
        [CalendarDate((int)Months.December, 7)]
        public static class PearlHarborDay { }

        [CalendarDate((int)Months.December, 24)]
        public static class ChristmasEve { }

        /// <summary>
        /// federal holiday
        /// </summary>
        [CalendarDate((int)Months.December, 25)]
        public static class ChristmasDay { }

        [CalendarDate((int)Months.December, 31)]
        public static class NewYearsEve { }
    }
}
