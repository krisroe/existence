using System;

namespace Existence
{
    /// <summary>
    /// base for attributes naming a single X (e.g. Province) that pair with a plural XsAttribute;
    /// apply the singular attribute once per X instead of using the plural
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public abstract class SingularObjectAttribute : Attribute
    {
    }

    /// <summary>
    /// marks an item in a hierarchy of enums as having child items at the next level down
    /// </summary>
    public class HasSubdivisionsAttribute : Attribute { }

    /// <summary>
    /// how strongly an item in a hierarchy originated from another item
    /// </summary>
    public enum HierarchyItemOriginTypes
    {
        /// <summary>
        /// the item's main origin
        /// </summary>
        Main,

        /// <summary>
        /// one of several significant origins
        /// </summary>
        Significant,
    }

    /// <summary>
    /// an item in a hierarchy of enums that this item originated from. Origins can come from any level of the
    /// hierarchy, which may span several enums, so Subdivision takes a value of any enum.
    /// The origin type defaults to Main through a separate constructor rather than an optional parameter, so that
    /// reflection (CustomAttributeData) can tell whether the origin type was specified explicitly.
    /// </summary>
    public class OriginatedFromAttribute : SingularObjectAttribute
    {
        public Enum Subdivision { get; set; }
        public HierarchyItemOriginTypes OriginType { get; set; }
        public OriginatedFromAttribute(object Subdivision) : this(Subdivision, HierarchyItemOriginTypes.Main)
        {
        }
        public OriginatedFromAttribute(object Subdivision, HierarchyItemOriginTypes OriginType)
        {
            this.Subdivision = (Enum)Subdivision;
            this.OriginType = OriginType;
        }
    }
}
