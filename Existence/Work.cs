using System;

namespace Existence
{
    [Flags]
    public enum WorkplaceType
    {
        None = 0,
        Technology = 1,
        Medical = 2,
    }

    public class WorkplaceTypeAttribute : Attribute
    {
        public WorkplaceType WorkplaceType { get; set; }
        public WorkplaceTypeAttribute(WorkplaceType WorkplaceType)
        {
            this.WorkplaceType = WorkplaceType;
        }
    }
}
