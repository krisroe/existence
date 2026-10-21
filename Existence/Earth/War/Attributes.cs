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
        /// constructor for when the country is unknown
        /// </summary>
        public AssassinatedAttribute()
        {
            this.Country = null;
        }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Country">country where the assassination took place</param>
        public AssassinatedAttribute(CountryLikeThings Country)
        {
            this.Country = Country;
        }
    }
}
