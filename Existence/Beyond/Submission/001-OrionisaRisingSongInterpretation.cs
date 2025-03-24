
using Existence.Beyond.Infrastructure;
using Existence.Earth.Human.People;
using Existence.Personal;
using Existence.Personal.Infrastructure;
using Existence.Song;
using Existence.Time;

namespace Existence.Beyond.CosmicSubmission
{
    [CosmicRequest("Please attach any personal contribution to \"Orion is a-rising\" in the provided documentation to the YouTube video")]
    internal class OrionIsarisingSongInterpretation
    {
        public enum VersionHistory
        {
            /// <summary>
            /// created
            /// </summary>
            [PersonalFirst("Cosmic Submission")]
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 3, 7)]
            Created,

            [BeyondObjectVersion(1, 1, 0, 0)]
            [YearDate(2025, 3, 24)]
            InternalizedAndRemovedTimelessVersion
        }

        /// <summary>
        /// professionally produced video, most common use as a reminiscence aid for
        /// humans familiar with the song from their childhood
        /// </summary>
        [Composers("James Zimmerman")]
        [Arrangers("Dan Myers")]
        [Performers("Skip Myers", "Dan Myers", "Julie Dutchak")]
        [YouTubeVideoID("KEuOalGvLdg", 2014, 11, 08)]
        [Dedications("for Orion Zev 2014-11-01")]
        [SongInterpretationLevels(SongInterpretationLevel.ModernHuman)]
        public static class YouTubeVideo { }

        /// <summary>
        /// lyrics interpretation from childhood memories, one fewer verse than in the YouTube video
        /// </summary>
        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\004-OrionisaRisingHuman.txt", PeopleEnumerated.RoweChris)]
        [SongInterpretationLevels(SongInterpretationLevel.ModernHuman)]
        public static class ChildhoodRemembranceInterpretation { }

        /// <summary>
        /// lyrics interpretation of the YouTube video, building on my childhood interpretation.
        /// The interpretation stretches from modern human era to intergalactic pulsar time.
        /// Finally there is a speculative post-intergalactic-pulsar-time interpretation.
        /// </summary>
        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\005-OrionisaRisingIntergalacticPulsarTime.txt", PeopleEnumerated.RoweChris)]
        [SongInterpretationLevels(SongInterpretationLevel.ModernHuman, SongInterpretationLevel.IntergalacticPulsarTime, SongInterpretationLevel.PostIntergalacticPulsarTime)]
        public static class YouTubeVideoLyricsInterpretation { }

        /// <summary>
        /// Finale version of the childhood remembrance of Orion is a-rising
        /// There is a touch of Intergalactic Pulsar Time interpretation, particular with the line breaks for the
        /// seven music staves across the song. The document calls out that the line breaks are assigned by Finale,
        /// which is the notation program used, which is an indication that music can be done in a sort of fixed
        /// width by letting the notation program write the line breaks. 
        /// </summary>
        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\006-OrionIsArising.musc", PeopleEnumerated.RoweChris)]
        [SongInterpretationLevels(SongInterpretationLevel.ModernHuman, SongInterpretationLevel.IntergalacticPulsarTime)]
        public static class ChildhoodRemembranceMUSX { }
    }
}
