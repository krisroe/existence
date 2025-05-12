using System;

namespace Existence
{
    [Flags]
    public enum WorkplaceType
    {
        None = 0,
        Technology = 1,
        Medical = 2,
        NonMedical = 3,
    }

    public class WorkplaceTypesAttribute : Attribute
    {
        public WorkplaceType[] WorkplaceTypes { get; set; }
        public WorkplaceTypesAttribute(params WorkplaceType[] WorkplaceTypes)
        {
            this.WorkplaceTypes = WorkplaceTypes;
        }
    }
}
