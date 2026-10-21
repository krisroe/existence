using System;
using Existence.Earth.Countries;
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
        /// constructor for when the country is unknown
        /// </summary>
        public AssassinatedAttribute()
        {
            this.City = null;
            this.Country = null;
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
    }
}
