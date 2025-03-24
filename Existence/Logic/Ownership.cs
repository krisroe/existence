using System;

namespace Existence.Logic
{
    public class CreatorsAttribute : Attribute
    {
        public int[]? CreatorsInteger { get; set; }
        public string[]? CreatorsString { get; set; }
        public CreatorsAttribute(params string[] Creators)
        {
            this.CreatorsString = Creators;
            this.CreatorsInteger = null;
        }
        public CreatorsAttribute(params int[] Creators)
        {
            this.CreatorsInteger = Creators;
            this.CreatorsString = null;
        }
    }

    public class GoalOwnerAttribute : Attribute
    {
        public int Owner { get; set; }

        public GoalOwnerAttribute(int Owner)
        {
            this.Owner = Owner;
        }
    }

    public class HumanOwnerAttribute : Attribute
    {
        public int Owner { get; set; }
        public HumanOwnerAttribute(int Owner)
        {
            this.Owner = Owner;
        }
    }

    public class BeyondOwnerAttribute : Attribute
    {
        public int Owner { get; set; }
        public BeyondOwnerAttribute(int Owner)
        {
            this.Owner = Owner;
        }
    }

    public class OwnersAttribute : Attribute
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public int[] Owners { get; set; }
        public OwnersAttribute(int FromYear, int FromMonth, int FromDay, int ToYear, int ToMonth, int ToDay, params int[] Owners)
        {
            this.From = new DateTime(FromYear, FromMonth, FromDay);
            this.To = new DateTime(ToYear, ToMonth, ToDay);
            this.Owners = Owners;
        }
        public OwnersAttribute(params int[] Owners)
        {
            this.From = null;
            this.To = null;
            this.Owners = Owners;
        }
    }
}
