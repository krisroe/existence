using System;

namespace Existence.Earth.Companies.Insurance
{
    public enum InsuranceCompanies
    {
        StateFarm,
        GEICO,
        Progressive,
        Allstate,
        /// <summary>
        /// united states automobile association
        /// </summary>
        USAA,
        Farmers,
        Nationwide,
        LibertyMutual,
        AmericanFamily,
        Travelers,
        Chubb,
    }

    public class InsuranceAttribute : Attribute
    {
        public InsuranceCompanies Company { get; set; }
        public InsuranceAttribute(InsuranceCompanies Company)
        {
            this.Company = Company;
        }
    }
}
