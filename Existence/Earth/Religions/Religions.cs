using System;

namespace Existence.Earth.Religions
{
    public class NumberOfFollowersAttribute : Attribute
    {
        public long LowEstimate { get; set; }
        public long HighEstimate { get; set; }
        public NumberOfFollowersAttribute(long Estimate)
        {
            LowEstimate = HighEstimate = Estimate;
        }
        public NumberOfFollowersAttribute(long LowEstimate, long HighEstimate)
        {
            this.LowEstimate = LowEstimate;
            this.HighEstimate = HighEstimate;
        }
    }

    public enum WorldReligions
    {
        [NumberOfFollowers(2400000000)] //2.4 billion
        Christianity,

        Islam,
        Buddhism,
        Hinduism,
        Sikhism,
        Taoism,
        Jainism,
        Judaism,
        Atheism,
        Animism,
        Agnosticism,
        ReligiousPluralism,
        Noneism,
        Nihilism
    }

    //First Apostle of X, X must be unique among humans
    //Must provide reference date when creating religion, a human only do this once
}
