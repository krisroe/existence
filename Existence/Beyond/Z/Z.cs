
using System.Collections.Generic;
using Existence.Beyond.Infrastructure;
using Existence.Beyond.JudgmentDay;
using Existence.Earth;
using Existence.Earth.Alphabet;
using Existence.Personal.Infrastructure;
using Existence.Time;

namespace Existence.Beyond
{
    /// <summary>
    /// Z information MUST be public
    /// This also acts as the rules of the personal realm (for me the personal realm and the Z realm
    /// are the same)
    /// </summary>
    public class Z
    {
        public enum VersionHistory
        {
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 3, 29)]
            Created
        }

        public OrderedEvents ZTimeline { get; set; }
        
        public List<BaseEvent> ZFacts { get; set; }

        public List<BaseEvent> ZRules { get; set; }

        public Z()
        {
            ZRules = new List<BaseEvent>();
            ZFacts = new List<BaseEvent>();
            ZTimeline = new OrderedEvents(null, new List<BaseEvent>());
            SetRules();
            SetFacts();
            SetTimeline();
        }

        public void SetRules()
        {
            ZRules.Add(new BaseEvent("Manic episodes with loss of functionality in home or work responsibilities are not allowed."));
        }

        public void SetFacts()
        {
            //My conjecture is this enables signposts for a "the-divine-walks-on-earth-again" workflow
            ZFacts.Add(new BaseEvent("Name means 'bearing Christ'"));
        }

        public void SetTimeline()
        {
            List<BaseEvent> zTimelineEvents = new List<BaseEvent>();
            zTimelineEvents.AddRange(ZRules);
            zTimelineEvents.AddRange(ZFacts);
            zTimelineEvents.Add(new LessonEvent("Actions have consequences")); //does this actually need a real-life lesson?
            zTimelineEvents.Add(new ZBirth());
            zTimelineEvents.Add(new LessonEvent("Life's not fair")); //this one needs a real-life lesson.
            zTimelineEvents.Add(new SkepticismOfReligionZSignPost()); //hit this one out of the park            

            //it's hard to see this one as anything other than a political/psychological signpoint
            zTimelineEvents.Add(new BaselesslyAccuseATeacherOfBeingACommunist());

            //these are clear religious signpoint
            zTimelineEvents.Add(new MultiEvent("High School Sophmoric Antics",
                [new DoSomethingWithYourSoulAsAJokeAndItsUnclearWhatHappensToIt(),
                new PubliclyClaimToBeTheAntichristAsAJoke()]));

            zTimelineEvents.Add(new ZDeviationMessageBoxViolatingCausality());
            ZTimeline = new OrderedEvents(null, zTimelineEvents);
        }

        /// <summary>
        /// This was a self-aware violation of the general human universe law of causality,
        /// which is not allowed under the human rules of the universe. I did the right thing
        /// and immediately patched the hole. However, not understanding the rules, I went
        /// deeper to find the truth of what was happening, leading in short order to a
        /// manic episode with loss of functionality, breaking a Z rule I hadn't invented yet.
        /// </summary>
        [YearDate(2024, 5, 27)]
        public class ZDeviationMessageBoxViolatingCausality : BaseEvent
        {
            public ZDeviationMessageBoxViolatingCausality() : base("Time Traveling Message Box")
            {
            }
        }
    }

    [PersonalHumanLevel(HumanLevel.Baby)]
    [DivineHumanLevel(HumanLevel.Baby)]
    [CosmicHumanLevel(HumanLevel.Baby)]
    [ZHumanLevel(HumanLevel.Baby)]
    [PersonalZLevel(ZLevel.Zero)]
    [CosmicZLevel(ZLevel.Zero)]
    public class ZBirth : BaseEvent
    {
        public ZBirth() : base("Birth") { }
    }

    [MagicWords("I have no sin.", "Me", "My Bedroom", "Alone")]
    [Consequences("None")]
    public class SkepticismOfReligionZSignPost : SkepticismOfReligionPersonal
    {
    }

    /// <summary>
    /// Even today, I'm not sure if I was 100% joking or not. Teachers today do tend to have leftist leanings.
    /// One point here is the possibility of damaging someone else's reputation without significant consequences.
    /// Another point is you do have to be somewhat knowledgable of history for this to seem credible (even as a joke).
    /// 
    /// But my guess is the actual signpost is as projection. The incident makes a lot more since if the accuser is
    /// actually a secret Communist but trying to get out of the consequences by making an accusation. But since I was not
    /// actually a secret Communist I think it was a subconscious attempt to feel psychological projection.
    /// </summary>
    [Consequences("None")]
    public class BaselesslyAccuseATeacherOfBeingACommunist : BaseEvent
    {
        public BaselesslyAccuseATeacherOfBeingACommunist() : base("Baselessly Accuse Teacher of being a Communist")
        {
        }
    }

    /// <summary>
    /// I think the point here is to set up for any kind of malicious divine/cosmic consequences/signposts 
    /// regarding the lack of a soul or possession by others or destruction or unknown result.
    /// </summary>
    [Consequences("None")]
    public class DoSomethingWithYourSoulAsAJokeAndItsUnclearWhatHappensToIt : BaseEvent
    {
        public DoSomethingWithYourSoulAsAJokeAndItsUnclearWhatHappensToIt() : base("Do a Joke with Your Soul and It's Unclear what Happens to it")
        {

        }
    }

    /// <summary>
    /// I think the point here is this is a minimal way of setting one's "Antichrist" flag, triggering new signposts.
    /// </summary>
    [Consequences("Minimal (the devout may be offended)")]
    public class PubliclyClaimToBeTheAntichristAsAJoke : BaseEvent
    {
        public PubliclyClaimToBeTheAntichristAsAJoke() : base("Publicly Claim to be the Antichrist as a Joke")
        {

        }
    }
}
