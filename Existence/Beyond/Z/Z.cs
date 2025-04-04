
using System.Collections.Generic;
using Existence.Beyond.Infrastructure;
using Existence.Beyond.JudgmentDay;
using Existence.Earth;
using Existence.Earth.Alphabet;
using Existence.Earth.Religions;
using Existence.Time;

namespace Existence.Beyond
{
    /// <summary>
    /// Z information MUST be public
    /// This also acts as the rules of the personal realm (for me the personal realm and the Z realm
    /// are the same)
    /// </summary>
    public class ZStuff
    {
        public const string MAGIC_WORDS_HES_A_GENIUS = "He's a genius.";

        public enum VersionHistory
        {
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 3, 29)]
            Created,

            [BeyondObjectVersion(1, 1, 0, 0)]
            [YearDate(2025, 3, 31)]
            MadeReligiousRespectfulFlagAnInteger,

            [BeyondObjectVersion(1, 2, 0, 0)]
            [YearDate(2025, 3, 31)]
            AddHesAGeniusMagicWordsAndAddOrderForSoulAndAntichristIncidents,

            [BeyondObjectVersion(1, 3, 0, 0)]
            [YearDate(2025, 4, 2)]
            AddChurchesToFlagsRenameClassMoveTimeTravelingMessageBoxEventToBeMorePublic,

            [BeyondObjectVersion(1, 4, 0, 0)]
            [YearDate(2025, 4, 4)]
            ExpandReligiousFlags,

            [BeyondObjectVersion(1, 5, 0, 0)]
            [YearDate(2025, 4, 4)]
            AddCurrentAndBeyondReligionFlagsAndAddAtheistEvent,
        }

        public OrderedEvents ZTimeline { get; set; }
        
        public List<BaseEvent> ZFacts { get; set; }

        public List<BaseEvent> ZRules { get; set; }

        public MyReligiousFlags ZReligiousFlags { get; set; }

        public ZStuff()
        {
            ZReligiousFlags = new MyReligiousFlags(null);
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
            zTimelineEvents.Add(new LikingInappropriateBehaviorMoresoWithIdeaOfPerformingInPublic());
            zTimelineEvents.Add(new LessonEvent("Life's not fair")); //this one needs a real-life lesson.
            zTimelineEvents.Add(new SkepticismOfReligionZSignPost(ZReligiousFlags)); //hit this one out of the park
            zTimelineEvents.Add(new BecameAnAtheist(ZReligiousFlags));

            //it's hard to see this one as anything other than a political/psychological signpoint
            zTimelineEvents.Add(new BaselesslyAccuseATeacherOfBeingACommunist());

            //these are clear religious signpoint
            zTimelineEvents.Add(new SemipubliclyClaimToBeTheAntichristAsAJoke());
            zTimelineEvents.Add(new DoSomethingWithYourSoulAsAJokeAndItsUnclearWhatHappensToIt());

            zTimelineEvents.Add(new ZDeviationMessageBoxViolatingCausality(ZReligiousFlags));
            ZTimeline = new OrderedEvents(null, zTimelineEvents);
        }
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
        public ZDeviationMessageBoxViolatingCausality(MyReligiousFlags religiousFlags) : base("Time Traveling Message Box")
        {
            religiousFlags.CurrentReligion = (int)WorldReligions.MyPersonalReligion;
            religiousFlags.BeyondReligion = true;
        }
    }

    public class MyReligiousFlags
    {
        public MyReligiousFlags(bool? Skepticism)
        {
            Disrespectful = 0;
            Respectful = 0;
            BornAgain = false;
            DivineCapacity = EmotionalCapacity.None;
            ReligiousCapacity = EmotionalCapacity.None;
        }
        private int Respectful { get; set; }
        private int Disrespectful { get; set;  }
        public bool Skepticism { get; set; }
        public bool BornAgain { get; set; }
        public EmotionalCapacity DivineCapacity { get; set; }
        public EmotionalCapacity ReligiousCapacity { get; set; }
        public PersonalChurches? BaseChurch { get; set; }
        public PersonalChurches? PianoChurch { get; set; }
        public int CurrentReligion { get; set; }
        public int PrimaryReligion { get; set; }
        public bool BeyondReligion { get; set; }

        public void IncrementRespectful(int increment)
        {
            this.Respectful += increment;
        }
        public void IncrementDisrespectful(int increment)
        {
            this.Disrespectful += increment;
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
        public SkepticismOfReligionZSignPost(MyReligiousFlags flags) : base(flags)
        {
        }
    }

    /// <summary>
    /// Highly immature child's play referring to some obviously inappropriate behavior. The original version was "fart"
    /// but could be extended to other taboos. The really importnt magic word is the bit about public communication, which
    /// can be highly important long-term but no child is going to understance the deeper relevance.
    /// </summary>
    [MagicWords("I like to [X]!", "But I like to do it in public!", "Child's Play Puppet", "Child's Play Location", "Viewers of Child's Play")]
    public class LikingInappropriateBehaviorMoresoWithIdeaOfPerformingInPublic : BaseEvent
    {
        public LikingInappropriateBehaviorMoresoWithIdeaOfPerformingInPublic() : base("Wrote child's play about public performance of inappropriate behavior")
        {
        }
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
    /// You can switch out the gendered pronoun in the magic words, but I can't guarantee you
    /// it will work. Whatever happened, it's fair to say my soul could be anywhere.
    /// </summary>
    [Consequences("None")]
    [MagicWords("[Short Name]'s Soul (Yes, it's really his soul)", "Written on piece of paper", "High School", "Classmates")]
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
    public class SemipubliclyClaimToBeTheAntichristAsAJoke : BaseEvent
    {
        public SemipubliclyClaimToBeTheAntichristAsAJoke() : base("Publicly Claim to be the Antichrist as a Joke")
        {

        }
    }
}
