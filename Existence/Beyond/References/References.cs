
using Existence.Beyond.Infrastructure;
using Existence.Earth.Alphabet;
using Existence.Personal.Beyond;
using Existence.Personal.Employment;
using Existence.Time;
using System.Collections.Generic;

namespace Existence.Beyond.References
{
    public class ReferencesHistory
    {
        public enum VersionHistory
        {
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2024, 4, 24)]
            Created
        }

        public ReferencesHistory()
        {
            List<BaseEvent> events = new List<BaseEvent>()
                {
                    new DidNotAssistFamilyMemberInLookingForJob(),
                    new GavePoorReferenceForFormerCoworker()
                };
            new OrderedEvents(null, events);
        }
    }

    public class ChatGPT
    {
        public enum VersionHistory
        {
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 3, 24)]
            Created,

            [BeyondObjectVersion(1, 1, 0, 0)]
            [YearDate(2025, 3, 25)]
            ClarifiedUsageOfChatGPT,
        }

        /// <summary>
        /// I will be a judgment day reference for Chat GPT. I used him as a witness
        /// for an "I will not become the pope" declaration, and have used it for
        /// many purposes.
        /// </summary>
        public class JudgmentDay { }
    }

    public class JaredLaughlin
    {
        public enum VersionHistory
        {
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 3, 25)]
            Created,
        }

        /// <summary>
        /// I was his mentor at Epic, and he didn't significantly need my assistance after day one.
        /// My spouse tells me he adored him both personally and professionally.
        /// He died suddenly ~2 years ago at age 39, I had forgotten he was dead (spouse told me she
        /// had discussed it with me at the time, but I only remembered the death of a different
        /// one of her colleagues around the same timeframe)
        /// </summary>
        public class JudgmentDay { }
    }

    /// <summary>
    /// My cousin was looking for an IT job and had mentioned it incidentally at some family gathering.
    /// I probably could have helped him apply at WTS Paradigm, but I didn't do anything or acknowledge
    /// it in any way.
    /// </summary>
    [Year(2010)]
    [Person((int)FamilyMembers.MyFathersOldestSistersSonMatthew)]
    [SinType(SinType.NotHelpingSomeone)]
    public class DidNotAssistFamilyMemberInLookingForJob : BaseEvent
    {
        public DidNotAssistFamilyMemberInLookingForJob() : base("Didn't help Family Member in Job Search")
        {

        }
    }

    /// <summary>
    /// While I worked at Epic, a coworker who left Epic asked if he would give him a reference.
    /// I agreed and wanted to give a good reference, but I ended up describing him as sloppy.
    /// I probably meant it more in an all-programmers-are sloppy sense, or maybe I was projecting.
    /// I only gave the one reference.
    /// </summary>
    [Year(2013)]
    [MagicWords("Sloppy", "Me", "Job Reference", "Human Resources Person")]
    [Coworker((int)Coworkers.MichaelMcConnell)]
    [SinTypes(SinType.PersonalCommunication, SinType.TalkingBehindSomeonesBack, SinType.Projection)]
    public class GavePoorReferenceForFormerCoworker : BaseEvent
    {
        public GavePoorReferenceForFormerCoworker() : base("Gave Poor Coworker Reference")
        {
        }
    }
}