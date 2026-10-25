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

    public class MotherAttribute : Attribute
    {
        public int Mother { get; set; }
        public MotherAttribute(int Mother)
        {
            this.Mother = Mother;
        }
    }

    public class FatherAttribute : Attribute
    {
        public int Father { get; set; }
        public FatherAttribute(int Father)
        {
            this.Father = Father;
        }
    }
}
