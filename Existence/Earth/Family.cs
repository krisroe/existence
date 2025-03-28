using System;

namespace Existence.Earth
{
    public enum FamilyUnitType
    {
        NuclearFamily,
        SingleParentFamily,
    }

    public class FamilyUnitAttribute : Attribute
    {
        public FamilyUnitType FamilyUnitType { get; set; }
        public FamilyUnitAttribute(FamilyUnitType FamilyUnitType)
        {
            this.FamilyUnitType = FamilyUnitType;
        }
    }
}
