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

    public class ThePope
    {
        /// <summary>
        /// Papal infallibility is the Roman Catholic doctrine that, under very specific conditions, the 
        /// Pope is preserved from the possibility of error when proclaiming a doctrine of faith or 
        /// morals to be held by the whole Church.
        /// It does not mean the pope is incapable of error in every statement or action.
        /// It applies only when speaking ex cathedra ("from the chair [of Peter]") on faith and morals, 
        /// intending to define doctrine binding on the whole Church.
        /// 
        /// The doctrine of papal infallibility was defined dogmatically by the First Vatican Council (1869–1870).
        /// Second Vatican Council (Vatican II) did not discard papal infallibility.
        /// Instead, Vatican II reaffirmed it, but placed it within the broader context of the Church's 
        /// infallibility, particularly emphasizing the teaching authority of the bishops in union with
        /// the pope (collegiality).
        /// 
        /// How Often Has Papal Infallibility Been Used?
        /// The commonly agreed upon examples of papal infallibility being invoked are:
        /// 1. Immaculate Conception of Mary (Pope Pius IX, 1854) — defined before Vatican I but later 
        /// seen as an example of what Vatican I codified. Mary, from the first moment of her conception 
        /// in her mother’s womb, was preserved by God from original sin
        /// 2. Assumption of Mary (Pope Pius XII, 1950). The Catholic belief that Mary, the mother of
        /// Jesus, was taken up body and soul into heavenly glory at the end of her earthly life.ok
        /// </summary>
        public static class PapalInfallibility { }
    }

    public class Definitions
    {
        /// <summary>
        /// having unlimited power or being able to do anything that is logically possible
        /// typically refers to maximal power within the bounds of logical coherence
        /// </summary>
        public static class Omnipotent { }

        /// <summary>
        /// present everywhere at all times, not limited by space or time
        /// and fully present in all parts of the universe simultaneouslyha
        /// </summary>
        public static class Omnipresent { }

        /// <summary>
        /// having complete and unlimited knowledge
        /// 1. All past, present, and future events (sometimes called foreknowledge).
        /// 2. All thoughts, feelings, and intentions of every being.
        /// 3. All possibilities, including what could happen under any circumstances 
        /// (sometimes called "middle knowledge")
        /// </summary>
        public static class Omniscient { }
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
        /// 
        /// Origin of Universe: No creator - universe exists on its own terms
        /// Cause of Existence: No cause beyond natural processes, or brute fact
        /// Source of Natural Law: Inherent in the universe itself
        /// Ultimate Explanation: "It just is; perhaps no ultimate reason"
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

        /// <summary>
        /// The Creator (God) set the universe in motion but does not intervene in its workings
        /// God created natural laws, but does not perform miracles or reveal truth though holy books.
        /// 
        /// Origin of Universe: Created by a rational, ordering, intelligence
        /// Cause of Existence: God as First Cause, necessary being.
        /// Source of Natural Law: Created and set by God
        /// Ultimate Explanation: "There is a reason: God made it this way."
        /// </summary>
        Deism,

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
