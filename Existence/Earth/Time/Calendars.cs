using System;
using System.Collections.Generic;
using Existence.Earth.Countries;
using Existence.Time;

namespace Existence.Earth.Time
{
    public enum CalendarType
    {
        Solar,
        Lunar,
        Lunisolar,
    }

    public class CalendarTypeAttribute : Attribute
    {
        public CalendarType CalendarType { get; set; }
        public CalendarTypeAttribute(CalendarType CalendarType)
        {
            this.CalendarType = CalendarType;
        }
    }

    public class CalendarAttribute : Attribute
    {
        public Calendars Calendar { get; set; }
        public CalendarAttribute(Calendars Calendar)
        {
            this.Calendar = Calendar;
        }
    }

    public enum Calendars
    {
        #region Secular / Civil Calendars

        /// <summary>
        /// Introduced by Julius Caesar, used throughout Roman Empire and 
        /// in Europe until Gregorian reform.
        /// </summary>
        [Year(-45)]
        [CalendarType(CalendarType.Solar)]
        Julian,

        /// <summary>
        /// Reform of Julian calendar by Pope Gregory XIII to fix drift; 
        /// now the international standard (Anno Domini / Common Era).
        /// </summary>
        [Year(1582)]
        [CalendarType(CalendarType.Solar)]
        Gregorian,

        /// <summary>
        /// Revolutionary calendar used briefly post-French Revolution; 
        /// abolished by Napoleon.
        /// </summary>
        [Year(1793)]
        [CalendarType(CalendarType.Solar)]
        FrenchRepublican,

        /// <summary>
        /// Used by some Eastern Orthodox Churches; aligns with Gregorian 
        /// until year 2800
        /// </summary>
        [Year(1923)]
        [CalendarType(CalendarType.Solar)]
        RevisedJulian,

        /// <summary>
        /// Modern date formatting system based on the Gregorian calendar 
        /// (YYYY-MM-DD); not a new calendar but worth noting.
        /// </summary>
        [Year(1988)]
        [CalendarType(CalendarType.Solar)]
        ISO8601,

        #endregion

        #region Religious

        /// <summary>
        /// Used in Judaism (including as a secular calendar in israel)
        /// months begin with the new moon, but solar year 
        /// is adjusted via leap months.
        /// 
        /// starts at the Babylonian exile
        /// </summary>
        [Year(-600)]
        [CalendarType(CalendarType.Lunisolar)]
        Hebrew,

        /// <summary>
        /// Used in Islam; strictly lunar with 12 months; does not align 
        /// with solar seasons.
        /// 
        /// starts at the Hijra migration
        /// 
        /// Some countires (Saudi Arabia and Taliban Afghanistan use
        /// the Hjiri as a secular calendar)
        /// </summary>
        [Year(622)]
        [CalendarType(CalendarType.Lunar)]
        Hijri,

        /// <summary>
        /// Based on Julian/Gregorian calendar; includes movable feasts 
        /// like Easter (calculated using lunar rules).
        /// </summary>
        [Year(400)]
        [CalendarType(CalendarType.Solar)]
        ChristianLiturgical,

        /// <summary>
        /// Determines Easter Sunday in Christian tradition.
        /// Use began at Council of Nicaea
        /// Lunar rules within a solar calendar
        /// </summary>
        [Year(325)]
        [CalendarType(CalendarType.Solar)]
        EcclesiasticalLunar,

        /// <summary>
        /// Multiple regional variants; months begin with new or full moon; 
        /// leap months added to sync with solar year.
        /// </summary>
        [Year(-1200)] //or earlier
        [CalendarType(CalendarType.Lunisolar)]
        Hindu,

        /// <summary>
        /// Often adapted from Hindu or Chinese systems; Theravāda uses 
        /// modified lunisolar calendar. Modern variants codified later.
        /// </summary>
        [Year(-600)]
        [CalendarType(CalendarType.Lunisolar)]
        Buddhist,

        /// <summary>
        /// Similar to Hindu calendar; used to determine Jain festivals.
        /// </summary>
        [Year(-600)]
        [CalendarType(CalendarType.Lunisolar)]
        Jain,

        /// <summary>
        /// Oldest version was a 360-day solar calendar; modern ones vary
        /// (e.g., Fasli calendar aligned with Gregorian)
        /// </summary>
        [Year(-600)]
        [CalendarType(CalendarType.Solar)]
        Zoroastrian,

        /// <summary>
        /// 19 months of 19 days + intercalary days; begins at vernal equinox.
        /// </summary>
        [Year(1844)]
        [CalendarType(CalendarType.Solar)]
        Baháʼí,

        /// <summary>
        /// Ancient Mesopotamia, unclear date
        /// Has 365 days with no leap year; drifts slowly over time.
        /// </summary>
        [CalendarType(CalendarType.Solar)]
        Mandaean,

        /// <summary>
        /// Ancient Israelite calendar; diverged from Jewish 
        /// practice around the Babylonian Exile (6th century BCE)
        /// </summary>
        [CalendarType(CalendarType.Lunisolar)]
        Samaritan,

        /// <summary>
        /// controversial, lunar-based variability added in 2010,
        /// with a split over which is used
        /// </summary>
        [CalendarType(CalendarType.Solar)]
        [Year(2003)]
        Nanakshahi,

        #endregion

        #region East Asian Cultural

        /// <summary>
        /// Combines lunar months with solar terms; used for festivals, astrology.
        /// started use in Shang dynasty
        /// </summary>
        [Year(-1400)]
        [CalendarType(CalendarType.Lunisolar)]
        Chinese,

        /// <summary>
        /// historically was Lunisolar until Adopted Gregorian calendar in 
        /// 1873. retains traditional lunisolar elements for festivals.
        /// </summary>
        [Year(700)]
        [CalendarType(CalendarType.Solar)]
        Japanese,

        /// <summary>
        /// dates to ancient times
        /// Similar to Chinese; South Korea uses Gregorian calendar 
        /// officially but traditional calendar persists culturally.
        /// </summary>
        [CalendarType(CalendarType.Lunisolar)]
        Korean,

        /// <summary>
        /// dates to ancient times
        /// Similar to Chinese; used for festivals like Tết.
        /// </summary>
        [CalendarType(CalendarType.Lunisolar)]
        Vietnamese,

        #endregion

        #region Obsolete

        /// <summary>
        /// 365-day year, no leap year; refined into Julian calendar.
        /// 
        /// Candidates for earliest known date:
        /// 1. A recorded observation of the heliacal rising of Sirius
        /// July 12, 1830 BCE (Gregorian equivalent). The Egyptians noted
        /// when their calendar aligned with this astronomical event which
        /// allows a precise reckoning of this date with the modern
        /// Gregorian/Julian calendar.
        /// </summary>
        [Year(-3000)]
        [CalendarType(CalendarType.Solar)]
        [Obsolete]
        Egyptian,

        /// <summary>
        /// Used for religious festivals and astronomy; influenced Hebrew calendar.
        /// </summary>
        [Year(-1800)]
        [CalendarType(CalendarType.Lunisolar)]
        [Obsolete]
        Babylonian,

        /// <summary>
        /// includes ritual elements
        /// Several calendars (Tzolk'in, Haab', Long Count); used for 
        /// divination and historical record.
        /// </summary>
        [Year(-1000)]
        [CalendarType(CalendarType.Solar)]
        [Obsolete]
        Mayan,

        /// <summary>
        /// includes ritual elements, similar structure to Mayan system
        /// </summary>
        [Year(1400)]
        [CalendarType(CalendarType.Solar)]
        [Obsolete]
        Aztec,

        /// <summary>
        /// Used in ancient Athens; months began with the new moon.
        /// </summary>
        [Year(-800)]
        [CalendarType(CalendarType.Lunisolar)]
        [Obsolete]
        GreekAttic,

        /// <summary>
        /// used before 45 BCE
        /// Had irregular month lengths and intercalation.
        /// </summary>
        [CalendarType(CalendarType.Lunisolar)]
        [Obsolete]
        RomanPreJulian,

        [Year(100)]
        [CalendarType(CalendarType.Lunisolar)]
        [Obsolete]
        Celtic,

        #endregion
    }
}

//TODO: country list is incomplete
/// <summary>
/// represents country switches from Julian to Gregorian calendar
/// </summary>
public class CountryGregorianCalendarSwitchDate
{
    public static List<CountryGregorianCalendarSwitchDate> CountryLikeEntitySwitchDates;

    static CountryGregorianCalendarSwitchDate()
    {
        CountryLikeEntitySwitchDates = new List<CountryGregorianCalendarSwitchDate>()
        {
            #region first adopters

            //Italy was not yet unified; the Papal States and most Italian states switched on this date
            new CountryGregorianCalendarSwitchDate(CountryLikeThings.Italy, new EndDateAttribute(1582, 10, 4), new StartDateAttribute(1582, 10, 15)),

            new CountryGregorianCalendarSwitchDate(CountryLikeThings.Spain, new EndDateAttribute(1582, 10, 4), new StartDateAttribute(1582, 10, 15)),
            new CountryGregorianCalendarSwitchDate(CountryLikeThings.Portugal, new EndDateAttribute(1582, 10, 4), new StartDateAttribute(1582, 10, 15)),

            #endregion

            //at the time it was the Kingdom of Great Britain, including England+Wales+Scotland
            new CountryGregorianCalendarSwitchDate(CountryLikeThings.UnitedKingdom, new EndDateAttribute(1752, 9, 2), new StartDateAttribute(1752, 9, 14)),

            //same king as the Kingdom of Great Britain, but a different country
            new CountryGregorianCalendarSwitchDate(CountryLikeThings.Ireland, new EndDateAttribute(1752, 9, 2), new StartDateAttribute(1752, 9, 14)),

            //Soviet Russia
            new CountryGregorianCalendarSwitchDate(CountryLikeThings.Russia, new EndDateAttribute(1918, 1, 31), new StartDateAttribute(1918, 2, 14)),

            new CountryGregorianCalendarSwitchDate(CountryLikeThings.Greece, new EndDateAttribute(1923, 2, 15), new StartDateAttribute(1923, 3, 1))
        };
    }
    public CountryLikeThings CountryLikeThing { get; set; }

    /// <summary>
    /// last date the country used with respect to the Julian calendar
    /// </summary>
    public EndDateAttribute JulianEndDate { get; set; }

    /// <summary>
    /// first date the country used with respect to the Gregorian calendar
    /// </summary>
    public StartDateAttribute GregorianStartDate { get; set; }

    /// <summary>
    /// number of dates skipped (that did not exist) in the switch
    /// </summary>
    public int GapDays { get; set; }

    public CountryGregorianCalendarSwitchDate(CountryLikeThings CountryLikeThing, EndDateAttribute JulianEndDate, StartDateAttribute GregorianStartDate)
    {
        this.CountryLikeThing = CountryLikeThing;
        this.JulianEndDate = JulianEndDate;
        this.GregorianStartDate = GregorianStartDate;
        if (JulianEndDate.Month == null || JulianEndDate.Day == null) throw new ArgumentException("A month and day are required.", nameof(JulianEndDate));
        if (GregorianStartDate.Month == null || GregorianStartDate.Day == null) throw new ArgumentException("A month and day are required.", nameof(GregorianStartDate));
        DateTime julian = new DateTime(JulianEndDate.Year, JulianEndDate.Month.Value, JulianEndDate.Day.Value);
        DateTime gregorian = new DateTime(GregorianStartDate.Year, GregorianStartDate.Month.Value, GregorianStartDate.Day.Value);
        GapDays = (gregorian - julian).Days - 1;
    }
}
