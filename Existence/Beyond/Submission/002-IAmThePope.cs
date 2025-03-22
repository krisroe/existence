
using System.Collections.Generic;
using Existence.Beyond.Infrastructure;
using Existence.Earth.Human.People;
using Existence.Logic;
using Existence.Personal;
using Existence.Personal.Infrastructure;
using Existence.Time;

namespace Existence.Beyond.CosmicSubmission
{
    internal class ThePope : SubmissionBase
    {
        public enum VersionHistory
        {
            /// <summary>
            /// created
            /// </summary>
            [PersonalFirst("Divine Submission")]
            [BeyondObjectVersion(1, 0, 0, 0)]
            [TimelessVersion(2, 0, 0, 0)]
            [YearDate(2025, 3, 22)]
            Created
        }

        [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\009-IAmThePope.txt", PeopleEnumerated.RoweChris)]
        [MusicNotesRepositoryAudioFile(@"Released\Audio\004-IAmThePope.wav", PeopleEnumerated.RoweChris)]
        [TimelessPurpose("Detect/validate truth/untruth")]
        [Owners((int)PeopleEnumerated.RoweChris)]
        [Creators((int)PeopleEnumerated.RoweChris)]
        internal class IamthePopeOriginalSong { }

        [MusicNotesRepositoryOtherFiles(PeopleEnumerated.RoweChris, "list of popes, past to present",
                                        @"Released\Other\001-popelist.xml",
                                        @"Released\Other\001-popelist.txt",
                                        @"Released\Other\001-popelist.csv",
                                        @"Released\Other\001-popelist.xsd")]
        public class PopeList { }

        public class Attachments
        {
            [MusicNotesRepositoryAttachment("St. Mary's Hospital, Madison, WI, USA",
                                            @"Released\Other\003-certificateofbirth{0}.tif", 1, 3)]
            public static class EvidenceOfBirth { }

            [MusicNotesRepositoryAttachment("Friend of my spouse", @"Released\Other\002-marriageproof.jpg")]
            public static class EvidenceOfMarriage { }
        }

        public static class IAmNotThePopePastPresentFutureProof
        {
            public static class HypotheticalPapacy
            {
                /// <summary>
                /// Felix II was an antipope, and we have had legitimate popes Felix II and Felix IV. Felix V is also
                /// an antipope, so if another pope takes Felix they will use Felix VI leaving another hole. This means
                /// Felix has tons of potential for Antipope mischief. This also has a lot of cat-related cheating 
                /// potential since cats have nine lives, and whenever Felix the Cat gets in a fix, he can reach into his 
                /// bag of tricks.
                /// 
                /// There are several other open names that others might find more useful situationally:
                /// Alexander V
                /// Benedict X
                /// Boniface VII
                /// John XVI
                /// John XX (this is the most powerful one since there was no John XX)
                /// Martin II (doesn't exist either because of confusion with Marinus II)
                /// Martin III (doesn't exist either because of confusion with Marinus III)
                /// </summary>
                public const string PapalName = "Felix II";
            }

            public static class PastAndPresent
            {
                /// <summary>
                /// My birthplace and full (secular) name do not match any popes on the pope list
                /// </summary>
                public static class PopeList { }

                /// <summary>
                /// I was born (1980) during his reign (1978-2005)
                /// </summary>
                public static class JohnPaulII { }

                /// <summary>
                /// I was married (2007) during his reign (2005-2013)
                /// </summary>
                public static class BenedictXVI { }

                /// <summary>
                /// My son was born in wedlock (April 2013) during his reign (started March 2013)
                /// </summary>
                public static class Francis { }
            }
            /// <summary>
            /// this amounts to a promise I will not become Pope as a human.
            /// Even if I wake up tomorrow and decide it is my life's purpose to become pope, it's not feasible
            /// </summary>
            public static class Future
            {
                public static class Barriers
                {
                    /// <summary>
                    /// My Lutheran baptism is not a problem for Catholic conversion
                    /// </summary>
                    public static class Barrier1ConversionToCatholicism { }
                    /// <summary>
                    /// Neither annulment nor dissolution are feasible (we have kids)
                    /// </summary>
                    public static class Barrier2SpouseMustDie { }
                    /// <summary>
                    /// seminary isn't strictly required, but how else am I going to learn the background understanding required?
                    /// </summary>
                    public static class Barrier3MustComplete6to8YearsOfSeminary { }
                    /// <summary>
                    /// I do not have anywhere close the amount of social skills required to ascend the poltical hurdles
                    /// required to take the papacy.
                    /// </summary>
                    public static class Barrier4PoliticalBarriersAreInsurmountable { }
                    /// <summary>
                    /// Witness = Chat GPT
                    /// "I solemnly swear (with Chat GPT as my witness) that I will not become pope. I have discussed the hurdles with the 
                    /// witness. If I find any way to eliminate any of the hurdles, I will discuss the matter further with another witness."
                    /// </summary>
                    public static class OathToWitness { }
                }
            }
        }

        public override List<LevelJustification> GetLevelJustifications()
        {
            return new List<LevelJustification>()
            {
                new ReleaseSongJustification(new SongEvent("I am the Pope"), SongJustificationType.ReleaseSong),
                new DocumentsJustification("Past and Present Pope List"),
                new ProofJustification("I am not the Pope (Past, Present, Future)"), //I think this proof is bulletproof
            };
        }

        public override List<TimelessChange>? GetTimelessChanges()
        {
            return new List<TimelessChange>()
            {
                new TimelessChange("Birth Information: Time, City, Name, Species"),
                new TimelessChange("Second nuclear family information (include marriage date)"),
                new TimelessChange("I am NOT the pope"),
            };
        }
    }
}
