using System;

namespace Existence.Logic
{
    public class OwnersAttribute : Attribute
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int[] Owners { get; set; }
        public OwnersAttribute(int FromYear, int FromMonth, int FromDay, int ToYear, int ToMonth, int ToDay, params int[] Owners)
        {
            this.From = new DateTime(FromYear, FromMonth, FromDay);
            this.To = new DateTime(ToYear, ToMonth, ToDay);
            this.Owners = Owners;
        }
    }
}
