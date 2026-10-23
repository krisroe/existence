using System;
namespace Existence.Earth.Human.Personal
{
    /// <summary>
    /// whether a person has a tattoo
    /// </summary>
    public class HasTattooAttribute : Attribute
    {
        /// <summary>
        /// true if the person has a tattoo, false otherwise
        /// </summary>
        public bool HasTattoo { get; set; }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="HasTattoo">whether the person has a tattoo</param>
        public HasTattooAttribute(bool HasTattoo)
        {
            this.HasTattoo = HasTattoo;
        }
    }
}
