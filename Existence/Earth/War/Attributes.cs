using System;
using Existence.Earth.Countries;
using Existence.Time;
namespace Existence.Earth.War
{
    public class AssassinatedAttribute : Attribute
    {
        /// <summary>
        /// country where the assassination took place
        /// </summary>
        public CountryLikeThings? Country { get; set; }

        /// <summary>
        /// city where the assassination took place
        /// </summary>
        public WorldCities? City { get; set; }

        /// <summary>
        /// year of the attack, only set when it differs from the date of death (e.g. the target died of their wounds later)
        /// </summary>
        public int? Year { get; set; }

        /// <summary>
        /// month of the attack, only set when it differs from the date of death
        /// </summary>
        public int? Month { get; set; }

        /// <summary>
        /// day of the attack, only set when it differs from the date of death
        /// </summary>
        public int? Day { get; set; }

        /// <summary>
        /// constructor for when the country is unknown
        /// </summary>
        public AssassinatedAttribute()
        {
            this.City = null;
            this.Country = null;
            this.Year = null;
            this.Month = null;
            this.Day = null;
        }

        /// <summary>
        /// constructor for when the country is known but the city is unclear
        /// </summary>
        /// <param name="Country">country where the assassination took place</param>
        public AssassinatedAttribute(CountryLikeThings Country)
        {
            this.Country = Country;
        }

        /// <summary>
        /// constructor for when the country and city are clear
        /// </summary>
        /// <param name="Country">country where the assassination took place</param>
        /// <param name="City">city where the assassination took place</param>
        public AssassinatedAttribute(CountryLikeThings Country, WorldCities City)
        {
            this.Country = Country;
            this.City = City;
        }

        /// <summary>
        /// constructor for when the country is known but the city is unclear, and the attack happened on a different date than the death
        /// </summary>
        /// <param name="Country">country where the assassination took place</param>
        /// <param name="Year">year of the attack</param>
        /// <param name="Month">month of the attack</param>
        /// <param name="Day">day of the attack</param>
        public AssassinatedAttribute(CountryLikeThings Country, int Year, int Month, int Day) : this(Country)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
        }

        /// <summary>
        /// constructor for when the country and city are clear, and the attack happened on a different date than the death
        /// </summary>
        /// <param name="Country">country where the assassination took place</param>
        /// <param name="City">city where the assassination took place</param>
        /// <param name="Year">year of the attack</param>
        /// <param name="Month">month of the attack</param>
        /// <param name="Day">day of the attack</param>
        public AssassinatedAttribute(CountryLikeThings Country, WorldCities City, int Year, int Month, int Day) : this(Country, City)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
        }
    }

    /// <summary>
    /// an assassination attempt the target survived; the date is the date of the attempt
    /// </summary>
    /// <remarks>may be applied more than once, and alongside <see cref="AssassinatedAttribute"/> when a later attempt succeeded</remarks>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class AssassinationAttemptAttribute : YearDateAttribute
    {
        /// <summary>
        /// country where the assassination attempt took place
        /// </summary>
        public CountryLikeThings? Country { get; set; }

        /// <summary>
        /// city where the assassination attempt took place
        /// </summary>
        public WorldCities? City { get; set; }

        /// <summary>
        /// constructor for when the country is unknown
        /// </summary>
        /// <param name="Year">year of the attempt</param>
        /// <param name="Month">month of the attempt</param>
        /// <param name="Day">day of the attempt</param>
        public AssassinationAttemptAttribute(int Year, int Month, int Day) : base(Year, Month, Day)
        {
            this.City = null;
            this.Country = null;
        }

        /// <summary>
        /// constructor for when the country is known but the city is unclear
        /// </summary>
        /// <param name="Year">year of the attempt</param>
        /// <param name="Month">month of the attempt</param>
        /// <param name="Day">day of the attempt</param>
        /// <param name="Country">country where the assassination attempt took place</param>
        public AssassinationAttemptAttribute(int Year, int Month, int Day, CountryLikeThings Country) : this(Year, Month, Day)
        {
            this.Country = Country;
        }

        /// <summary>
        /// constructor for when the country and city are clear
        /// </summary>
        /// <param name="Year">year of the attempt</param>
        /// <param name="Month">month of the attempt</param>
        /// <param name="Day">day of the attempt</param>
        /// <param name="Country">country where the assassination attempt took place</param>
        /// <param name="City">city where the assassination attempt took place</param>
        public AssassinationAttemptAttribute(int Year, int Month, int Day, CountryLikeThings Country, WorldCities City) : this(Year, Month, Day, Country)
        {
            this.City = City;
        }
    }
}
