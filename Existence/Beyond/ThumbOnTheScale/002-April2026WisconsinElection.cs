using Existence.Beyond.Infrastructure;
using Existence.Beyond.JudgmentDay;
using Existence.Earth.Countries;
using Existence.Earth.Countries.UnitedStates.States;
using Existence.Time;
using System.ComponentModel;
namespace Existence.Beyond.ThumbOnTheScale
{
    internal class ThumbOnTheScaleApril2026WisconsinElection : ThumbOnTheScaleBase
    {
        public enum VersionHistory
        {
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2026, 4, 7)]
            Created,

            [BeyondObjectVersion(1, 1, 0, 0)]
            [YearDate(2026, 10, 25)]
            AddPredictionCorrectnessNoChangeAndUseCorrectYearForClassAndFileName,
        }

        [VotedAtLocation((int)PersonalChurches.SaintBernardCatholicChurch)]
        public static class April2026WisconsinElection
        {

        }

        /// <summary>
        /// generally speaking I prefer conservative judges, and that type of ideological control makes me
        /// more comfortable with liberal power over the executive branch of government.
        /// </summary>
        [ThumbOnTheScale((int)WisconsinPoliticians.LazarMaria,
            ThumbOnTheScaleAmount.Full,
            ThumbOnTheScaleImportance.Medium,
            (int)WisconsinPoliticians.LazarMaria,
            (int)WisconsinPoliticians.TaylorChris,
            Correctness.Incorrect,
            Correctness.Future)]
        public static class StateSupremeCourtJustice
        {
            [Politician((int)WisconsinPoliticians.LazarMaria)]
            public static class Option1
            {
                [Description("Had one")]
                public static class PrivacyPolicy { }

                /// <summary>
                /// actually had posted opinions there
                /// </summary>
                public static class Website { }
            }

            [Politician((int)WisconsinPoliticians.TaylorChris)]
            public static class Option2
            {
                [Description("Didn't appear to have one")]
                public static class PrivacyPolicy { }
            }
        }
    }
}
