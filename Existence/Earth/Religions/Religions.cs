using System;
using Existence.Earth.Alphabet;

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
        [NumberOfFollowers(2300000000, 2400000000)] //2.3-2.4 billion
        Christianity,

        [NumberOfFollowers(1900000000, 2000000000)] //1.9-2.0 billion
        Islam,

        [NumberOfFollowers(1200000000, 1300000000)] //1.2-1.3 billion
        Hinduism,

        [NumberOfFollowers(500000000, 550000000)] //500-550 million
        Buddhism,

        /// <summary>
        /// animism
        /// ancestor worship
        /// totemism
        /// shamanism
        /// polytheism
        /// philosophical/cosmological principles
        /// moral law/social order
        /// </summary>
        [NumberOfFollowers(400000000, 500000000)] //400-500 million
        FolkAndTraditionalReligions,

        [NumberOfFollowers(25000000, 30000000)] //25-30 million
        Sikhism,

        [NumberOfFollowers(15000000, 16000000)] //14-15 million
        Judaism,

        [NumberOfFollowers(10000000, 15000000)] //10-15 million
        Spiritism,

        [NumberOfFollowers(8000000, 12000000)] //8-12 million
        Taoism,

        [NumberOfFollowers(6000000, 10000000)] //6-10 million
        Confucianism,

        /// <summary>
        /// Bahá’í
        /// </summary>
        [NumberOfFollowers(5000000, 8000000)] //5-8 million
        Baháí,

        [NumberOfFollowers(4000000, 6000000)] //4-6 million
        Jainism,

        [NumberOfFollowers(700000, 1000000)] //700,000-1 million
        Yazidism,

        [NumberOfFollowers(110000, 200000)]
        Zoroastrianism,

        [NumberOfFollowers(60000, 100000)]
        Mandaeism,

        [NumberOfFollowers(800, 850)]
        Samaritanism,

        /// <summary>
        /// founded in 3rd century CE, died out between the 14th and 17th centuries
        /// </summary>
        [NumberOfFollowers(0)]
        Manichaeism,

        /// <summary>
        /// existed between 9th–15th centuries CE
        /// </summary>
        [NumberOfFollowers(0)]
        Bogomilism,

        /// <summary>
        /// existed between 12th–14th centuries CE
        /// </summary>
        [NumberOfFollowers(0)]
        [AlsoKnownAs("Albigensianism")]
        Catharism,

        /// <summary>
        /// Hermetic-pagan cult existed between ~3rd–13th centuries CE
        /// </summary>
        [NumberOfFollowers(0)]
        SabiensofHarran,

        /// <summary>
        /// existed between 1st–8th centuries CE
        /// </summary>
        [NumberOfFollowers(0)]
        Elkesaites,

        /// <summary>
        /// existed between 4th–7th centuries CE
        /// </summary>
        [NumberOfFollowers(0)]
        Donatism,

        [NumberOfFollowers(1200000000, 1300000000)] //1.2-1.3 billion
        Noneism,

        /// <summary>
        /// doesn't believe in God
        /// </summary>
        Atheism,

        /// <summary>
        /// 1. Agnostic theist. Believes in God but thinks God's existence can't be proven
        /// 2. Agnostic atheist. Doesn't believe in God but doesn't claim to know for sure that God doesn't exist.
        /// </summary>
        Agnosticism,

        /// <summary>
        /// believes in human-centered ethics and reason
        /// 1. Secular humanism. Explicitly non-religious.
        /// 2. Religious humanism. More rare, still focuses on human concerns over supernatural ones.
        /// </summary>
        Humanist,

        /// <summary>
        /// forms opinions based on reason, logic, and evidence, rather than authority, 
        /// tradition, or dogma — including religious dogma
        /// </summary>
        Freethinker,

        SpiritualButNotReligious,
        BeliefInAGenericHigherPower,
        ParticipateInCulturalTraditionsOrRitualsButDontSeeThemAsReligious,

        /// <summary>
        /// multiple religions contain valid truths, values, or paths to the divine or ultimate reality
        /// * No single religion holds a monopoly on truth
        /// * Different religions may offer complementary or equally valid insights into spiritual or moral truth.
        /// * Pluralists often respect and value diversity of belief rather than insisting that only one religion is "right."
        /// A person can both follow a regular religion and maintain some level of religious plural belief
        /// </summary>
        ReligiousPluralism,

        /// <summary>
        /// Belief System: No belief in ultimate meaning or value
        /// Moral Framework: Denies objective morality
        /// Community/Ritual: Typically individualistic and skeptical of ritual
        /// Purpose in Life: Denies inherent purpose
        /// </summary>
        Nihilism,

        /// <summary>
        /// Still working on this
        /// First Apostle of X, X must be unique among humans
        /// Must provide reference date when creating religion, a human only do this once
        /// </summary>
        [NumberOfFollowers(1, 1)]
        MyPersonalReligion,
    }
}
