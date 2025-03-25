
using Existence.Beyond.Infrastructure;
using Existence.Time;

namespace Existence.Beyond.References
{
    public class References
    {
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
    }
}
