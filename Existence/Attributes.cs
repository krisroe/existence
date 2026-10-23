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
}
