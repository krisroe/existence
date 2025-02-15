﻿using System;

namespace Existence.Earth.Human.People
{
    public class MarriedAttribute : Attribute
    {
        public bool IsMarried { get; set; }
        public MarriedAttribute(bool IsMarried)
        {
            this.IsMarried = IsMarried;
        }
    }

    public class InRelationshipWithAttribute : Attribute
    {
        PeopleEnumerated Person { get; set; }
        Level Level { get; set; }
        public InRelationshipWithAttribute(PeopleEnumerated p)
        {
            Person = p;
        }
        public InRelationshipWithAttribute(PeopleEnumerated p, Level l) : this(p)
        {
            Level = l;
        }
    }

    public enum Level
    {
        None,
        Serious,
    }

    /// <summary>
    /// people important enough to have their own enumeration value
    /// </summary>
    public enum PeopleEnumerated
    {
        TaylorSwift,
    }
}
