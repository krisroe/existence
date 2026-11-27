using Npgsql;
using NpgsqlTypes;
using System.Globalization;
using System.Text;
using System.Xml;
namespace DatabasePopulator
{
    internal class Program
    {
        private static readonly string[] PublishTimestampFormats = { "yyyy-MM-dd'T'HH:mm:ssK", "yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK" };

        /// <summary>
        /// database populator
        /// </summary>
        /// <param name="args">command line arguments</param>
        /// <returns>process return code</returns>
        /// <remarks>
        /// Command line arguments:
        ///  1. Input data file (path to Data.xml)
        ///  2. Database name (typically DestroyAllPugs)
        ///  3. local or remote
        ///  4. postgres user password
        /// </remarks>
        static int Main(string[] args)
        {
            int requiredArgsCount = 4;
            if (args == null || args.Length < requiredArgsCount)
            {
                Console.Error.WriteLine($"{requiredArgsCount} arguments are required.");
                return -1;
            }
            string inputFile = args[0];
            if (string.IsNullOrEmpty(inputFile))
            {
                Console.Error.WriteLine("No input file specified.");
                return -1;
            }
            if (!File.Exists(inputFile))
            {
                Console.Error.WriteLine($"File does not exist: {inputFile}");
                return -1;
            }
            string dbName = args[1];
            if (string.IsNullOrEmpty(dbName))
            {
                Console.Error.WriteLine("No database name specified.");
                return -1;
            }
            bool local;
            string localOrRemote = args[2];
            if (localOrRemote == "local")
            {
                local = true;
            }
            else if (localOrRemote == "remote")
            {
                local = false;
            }
            else
            {
                Console.Error.WriteLine($"Invalid argument #3 (local or remote): {localOrRemote}");
                return -1;
            }
            string password = args[3];
            if (string.IsNullOrEmpty(password))
            {
                Console.Error.WriteLine("No password specified.");
                return -1;
            }

            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(inputFile);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error reading XML document: " + ex.ToString());
                return -1;
            }
            XmlElement? docElement = xmlDoc.DocumentElement;
            if (docElement == null)
            {
                Console.Error.WriteLine("XML document missing document element");
                return -1;
            }
            XmlElement docElementVal = docElement;

            HashSet<int> usedDocuments = new HashSet<int>(); //each document has one primary sink video
            HashSet<string> songDocuments = new HashSet<string>(); //song id,document id pairs already linked

            AllData all = new AllData();

            string host;
            int port;
            if (local)
            {
                host = "localhost";
                port = 5432;
            }
            else
            {
                host = "destroyallpugz.site";
                port = 24866;
            }
            try
            {
                int iPerformerOrder = 0;
                int complaintOrder = 0;
                int exceptionListMemberTypeOrder = 0;
                int exceptionListOrder = 0;
                int copyrightFoundOrder = 0;
                int copyrightMissingOrder = 0;
                int ruleOfficialOrder = 0;
                int ruleUnofficialOrder = 0;
                int lyricsAnalysisOrder = 0;
                int landingPageOrder = 0;
                int audioOrder = 0;
                int documentOrder = 0;
                int songOrder = 0;
                int iID, iOrd, iVideoID;
                string sGoogleDriveFileID;

                foreach (XmlNode nextNode in docElementVal.ChildNodes)
                {
                    if (!CheckForValidXmlElement(nextNode)) continue;
                    XmlElement nextElement = (XmlElement)nextNode;
                    string nodeName = nextElement.Name;
                    if (nodeName == "document")
                    {
                        iID = GetObjectID(nextElement, "document");
                        iOrd = ++documentOrder;
                        string sType = GetRegularDataElement(nextElement, "type", "document");
                        string? purpose = GetRegularDataElement(nextElement, "purpose", "document", false);
                        sGoogleDriveFileID = GetRegularDataElement(nextElement, "googledrivefileid", "document");
                        string sComment = GetRegularDataElement(nextElement, "comment", "document");
                        if (string.IsNullOrEmpty(sComment))
                        {
                            throw new InvalidDataException("Documents must currently have a comment");
                        }
                        if (string.IsNullOrEmpty(sGoogleDriveFileID))
                        {
                            throw new InvalidDataException("Documents must have a URL");
                        }
                        if (!Enum.TryParse(sType, out DocumentType docType))
                        {
                            throw new InvalidDataException($"Invalid document type: {sType}");
                        }
                        DocumentPurpose docPurpose = DocumentPurpose.None;
                        if (purpose != null && !Enum.TryParse(purpose, out docPurpose))
                        {
                            throw new InvalidDataException($"Invalid document purpose: {purpose}");
                        }
                        bool isMusicNotationDocument = docType == DocumentType.MUSX || docType == DocumentType.Dorico;
                        string? sSupportsPlayback = GetRegularDataElement(nextElement, "supportsplayback", "document", isMusicNotationDocument);
                        bool? supportsPlayback = null;
                        if (isMusicNotationDocument)
                        {
                            if (purpose != null)
                            {
                                throw new InvalidDataException($"{docType} documents should not have a purpose");
                            }
                            if (!string.IsNullOrEmpty(sSupportsPlayback))
                            {
                                if (!bool.TryParse(sSupportsPlayback, out bool bParsedSupportsPlayback))
                                {
                                    throw new InvalidDataException($"Invalid document supportsplayback value: {sSupportsPlayback}");
                                }
                                supportsPlayback = bParsedSupportsPlayback;
                            }
                            else if (docType == DocumentType.Dorico)
                            {
                                throw new InvalidDataException("Dorico documents must have supportsplayback");
                            }
                        }
                        else if (docType == DocumentType.AdditionalTextFile)
                        {
                            if (docPurpose == DocumentPurpose.None)
                            {
                                throw new InvalidDataException("Additional text document missing purpose");
                            }
                            if (sSupportsPlayback != null)
                            {
                                throw new InvalidDataException("Additional text documents should not have supportsplayback");
                            }
                        }
                        else
                        {
                            throw new InvalidDataException($"Invalid document type: {sType}");
                        }

                        all.attachedDocuments.Add(new AttachedDocument(iID, iOrd, docType, docPurpose, sGoogleDriveFileID, supportsPlayback));
                    }
                    else if (nodeName == "song")
                    {
                        all.songs.Add(ProcessSong(nextElement, ++songOrder, all, songDocuments));
                    }
                    else if (nodeName == "video")
                    {
                        iID = GetObjectID(nextElement, "video");
                        string sYoutubeID = GetRegularDataElement(nextElement, "youtubeid", "video");
                        string sShortName = GetRegularDataElement(nextElement, "shortname", "video");
                        string sIdentifier = GetRegularDataElement(nextElement, "identifier", "video");
                        string sOwner = GetRegularDataElement(nextElement, "owner", "video");
                        string sIsPrivate = GetRegularDataElement(nextElement, "isprivate", "video");
                        if (!bool.TryParse(sIsPrivate, out bool bIsPrivate))
                        {
                            throw new InvalidDataException($"Invalid video isprivate value: {sIsPrivate}");
                        }
                        string? sPublishTimestamp = GetRegularDataElement(nextElement, "publishtimestamp", "video", false);
                        DateTime? publishTimestamp = null;
                        if (sPublishTimestamp != null)
                        {
                            publishTimestamp = ParsePublishTimestamp(sPublishTimestamp);
                            if (publishTimestamp == null)
                            {
                                throw new InvalidDataException($"Invalid video publishtimestamp value: {sPublishTimestamp}");
                            }
                        }
                        AttachedDocument? additionalTextDoc = GetVideoDocument(nextElement, "additionaltextdocumentid", DocumentType.AdditionalTextFile, all, usedDocuments);
                        AttachedDocument? musxDoc = GetVideoDocument(nextElement, "musxdocumentid", DocumentType.MUSX, all, usedDocuments);
                        AttachedDocument? doricoDoc = GetVideoDocument(nextElement, "doricodocumentid", DocumentType.Dorico, all, usedDocuments);
                        all.videos.Add(new Video(iID, sYoutubeID, sShortName, sIdentifier, sOwner, bIsPrivate, publishTimestamp, additionalTextDoc, musxDoc, doricoDoc));
                    }
                    else if (nodeName == "performer")
                    {
                        iID = GetObjectID(nextElement, "performer");
                        iOrd = ++iPerformerOrder;
                        string sName = GetCDataNode(nextElement, "name", "performer");
                        all.performers.Add(new NamedEntity(iID, iOrd, sName));
                    }
                    else if (nodeName == "rule")
                    {
                        iID = GetObjectID(nextElement, "rule");
                        iOrd = ++ruleOfficialOrder;
                        string sNumber = GetCDataNode(nextElement, "number", "rule");
                        string sActualRule = GetCDataNode(nextElement, "actualrule", "rule");
                        GetRuleCommon(nextElement, "rule", all, out string sRule, out string sSource, out Video? video1, out Video? video2, out bool video1isadditionaltext);
                        all.rulesOfficial.Add(new RuleOfficial(iID, iOrd, sNumber, sRule, sSource, sActualRule, video1, video2, video1isadditionaltext));
                    }
                    else if (nodeName == "ruleunofficial")
                    {
                        iID = GetObjectID(nextElement, "ruleunofficial");
                        iOrd = ++ruleUnofficialOrder;
                        GetRuleCommon(nextElement, "ruleunofficial", all, out string sRule, out string sSource, out Video? video1, out Video? video2, out bool video1isadditionaltext);
                        all.rulesUnofficial.Add(new RuleUnofficial(iID, iOrd, sRule, sSource, video1, video2, video1isadditionaltext));
                    }
                    else if (nodeName == "lyricsanalysis")
                    {
                        iID = GetObjectID(nextElement, "lyricsanalysis");
                        iOrd = ++lyricsAnalysisOrder;
                        string sVideoID = GetRegularDataElement(nextElement, "videoid", "lyricsanalysis");
                        string sLocation = GetRegularDataElement(nextElement, "location", "lyricsanalysis");
                        string sParody = GetRegularDataElement(nextElement, "parody", "lyricsanalysis");
                        if (!int.TryParse(sVideoID, out iVideoID))
                        {
                            throw new InvalidDataException($"Invalid lyricsanalysis video id: {sVideoID}");
                        }
                        if (!Enum.TryParse(sLocation, out LyricsAnalysisLocation loc))
                        {
                            throw new InvalidDataException($"Invalid lyricsanalysis location: {sLocation}");
                        }
                        if (!bool.TryParse(sParody, out bool bParody))
                        {
                            throw new InvalidDataException($"Invalid lyricsanalysis parody: {sParody}");
                        }
                        if (loc != LyricsAnalysisLocation.VideoDescription && loc != LyricsAnalysisLocation.Commentary)
                        {
                            throw new InvalidDataException($"Invalid lyricsanalysis location value: {loc.ToString()}");
                        }
                        Video v = all.GetVideoByID(iVideoID, "lyricsanalysis");
                        all.lyricsAnalyses.Add(new LyricsAnalysis(iID, iOrd, v, loc, bParody));
                    }
                    else if (nodeName == "copyrightfound")
                    {
                        ProcessCopyrightXMLEntry(nextElement, ref copyrightFoundOrder, "copyrightfound", all, all.copyrightsFound);
                    }
                    else if (nodeName == "copyrightmissing")
                    {
                        ProcessCopyrightXMLEntry(nextElement, ref copyrightMissingOrder, "copyrightmissing", all, all.copyrightsMissing);
                    }
                    else if (nodeName == "complaint")
                    {
                        iID = GetObjectID(nextElement, "complaint");
                        iOrd = ++complaintOrder;
                        string sNumber = GetCDataNode(nextElement, "number", "complaint");
                        string sTarget = GetCDataNode(nextElement, "target", "complaint");
                        string sDetail = GetCDataNode(nextElement, "detail", "complaint");
                        string sSource = GetCDataNode(nextElement, "source", "complaint");
                        string sComment = GetCDataNode(nextElement, "comment", "complaint");
                        string sVideoID = GetRegularDataElement(nextElement, "videoid", "complaint");
                        Video? v = null;
                        if (!string.IsNullOrEmpty(sVideoID))
                        {
                            if (int.TryParse(sVideoID, out iVideoID))
                            {
                                v = all.GetVideoByID(iVideoID, "complaint");
                            }
                            else
                            {
                                throw new InvalidDataException($"Invalid complaint video id: {sVideoID}");
                            }
                        }
                        all.complaints.Add(new Complaint(iID, iOrd, sNumber, sTarget, sDetail, sSource, sComment, v));
                    }
                    else if (nodeName == "land")
                    {
                        iID = GetObjectID(nextElement, "landingpage");
                        iOrd = ++landingPageOrder;
                        string sName = GetRegularDataElement(nextElement, "name", "landingpage");
                        string sURL = GetRegularDataElement(nextElement, "url", "landingpage");
                        if (string.IsNullOrEmpty(sName)) throw new InvalidDataException("No landing page name found!");
                        if (string.IsNullOrEmpty(sURL)) throw new InvalidDataException("No landing page URL found!");
                        all.landingpages.Add(new LandingPage(iID, iOrd, sName, sURL));
                    }
                    else if (nodeName == "exceptionlistmembertype")
                    {
                        iID = GetObjectID(nextElement, "exceptionlistmembertype");
                        iOrd = ++exceptionListMemberTypeOrder;
                        string sName = GetRegularDataElement(nextElement, "name", "exceptionlistmembertype");
                        all.exceptionListMemberTypes.Add(new NamedEntity(iID, iOrd, sName));
                    }
                    else if (nodeName == "exceptionlist")
                    {
                        iOrd = ++exceptionListOrder;
                        ProcessExceptionList(nextElement, all, exceptionListOrder);
                    }
                    else if (nodeName == "videolists")
                    {
                        ProcessVideoLists(nextElement, all);
                    }
                    else if (nodeName == "audio")
                    {
                        iID = GetObjectID(nextElement, "audio");
                        iOrd = ++audioOrder;
                        sGoogleDriveFileID = GetRegularDataElement(nextElement, "googledrivefileid", "audio");
                        string sNumber = GetRegularDataElement(nextElement, "number", "audio");
                        if (!int.TryParse(sNumber, out int iNumber))
                        {
                            throw new InvalidOperationException($"Invalid audio number: {iNumber}");
                        }
                        string sName = GetRegularDataElement(nextElement, "name", "audio");
                        string sSuggestion = GetRegularDataElement(nextElement, "suggestion", "audio");
                        all.audios.Add(new Audio(iID, iOrd, sGoogleDriveFileID, iNumber, sName, sSuggestion));
                    }
                    else
                    {
                        throw new InvalidDataException($"Invalid data type: {nodeName}");
                    }
                }
                if (usedDocuments.Count != all.attachedDocuments.Count)
                {
                    throw new InvalidDataException($"Mismatch between attached documents and usage of documents in primary videos: {usedDocuments.Count},{all.attachedDocuments.Count}");
                }
            }
            catch (InvalidDataException ex)
            {
                Console.Error.WriteLine(ex.Message);
                return -1;
            }

            NpgsqlConnectionStringBuilder ncsb = new NpgsqlConnectionStringBuilder();
            ncsb.Host = host;
            ncsb.Port = port;
            ncsb.Username = "postgres";
            ncsb.Password = password;
            ncsb.Database = dbName;

            Dictionary<int, DateTime> databasePublishTimestamps = new Dictionary<int, DateTime>();
            using (NpgsqlConnection conn = new NpgsqlConnection(ncsb.ToString()))
            {
                conn.Open();
                using (NpgsqlTransaction tx = conn.BeginTransaction())
                {
                    try
                    {
                        GetIDs(conn, tx, "performers", all.performerIDs, "id");
                        GetIDs(conn, tx, "rulez_official", all.rulesOfficialIDs, "id");
                        GetIDs(conn, tx, "rulez_unofficial", all.rulesUnofficialIDs, "id");
                        GetIDs(conn, tx, "lyrics_analyses", all.lyricsAnalysisIDs, "id");
                        GetIDs(conn, tx, "copyrights_found", all.copyrightFoundIDs, "id");
                        GetIDs(conn, tx, "copyrights_missing", all.copyrightMissingIDs, "id");
                        GetIDs(conn, tx, "complaints", all.complaintIDs, "id");
                        GetIDs(conn, tx, "landing_pages", all.landingPageIDs, "id");
                        GetIDs(conn, tx, "audios", all.audioIDs, "id");
                        GetIDs(conn, tx, "documents", all.documentIDs, "id");
                        GetIDs(conn, tx, "videos", all.videoIDs, "id");
                        GetIDs(conn, tx, "songs", all.songIDs, "id");
                        GetIDs2(conn, tx, "song_documents", all.songDocumentIDs, "songid", "documentid");
                        GetIDs(conn, tx, "videolist_mainline", all.mainlinevideoIDs, "videoid");
                        GetIDs(conn, tx, "videolist_sillysongs", all.sillysongvideoIDs, "videoid");
                        GetIDs(conn, tx, "videolist_workvideos", all.workvideoIDs, "videoid");
                        GetIDs(conn, tx, "videolist_kidzvideos", all.kidzvideoIDs, "videoid");
                        GetIDs(conn, tx, "videolist_unexplainablevideos", all.unexplainablevideoIDs, "videoid");
                        GetIDs(conn, tx, "videolist_musicvideos", all.musicvideoIDs, "videoid");
                        GetIDs(conn, tx, "exception_list_member_types", all.exceptionlistmembertypeIDs, "id");
                        GetIDs(conn, tx, "exception_lists", all.exceptionListIDs, "id");
                        GetIDs2(conn, tx, "exception_list_members", all.exceptionlistmemberIDs, "exceptionlistid", "ord");
                        SaveData(all, conn, tx, local);
                        if (!local)
                        {
                            GetPublishTimestamps(conn, tx, databasePublishTimestamps);
                        }
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        Console.Error.WriteLine($"Transaction rolled back: {ex}");
                        return -1;
                    }
                }
            }

            if (!local)
            {
                try
                {
                    CopyPublishTimestampsToXml(inputFile, all, databasePublishTimestamps);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"Database was updated, but copying publish timestamps to the XML file failed: {ex}");
                    return -1;
                }
            }

            return 0;
        }

        private static void GetRuleCommon(XmlElement nextElement, string objectType, AllData all, out string sRule, out string sSource, out Video? video1, out Video? video2, out bool video1isadditionaltext)
        {
            sRule = GetCDataNode(nextElement, "rule", objectType);
            sSource = GetCDataNode(nextElement, "source", objectType);
            string sVideoID1 = GetRegularDataElement(nextElement, "videoid1", objectType);
            string sVideoID2 = GetRegularDataElement(nextElement, "videoid2", objectType);
            string sVideo1IsAdditionalText = GetRegularDataElement(nextElement, "video1isadditionaltext", objectType);
            if (string.IsNullOrEmpty(sVideo1IsAdditionalText))
            {
                video1isadditionaltext = false;
            }
            else if (!bool.TryParse(sVideo1IsAdditionalText, out video1isadditionaltext))
            {
                throw new InvalidDataException($"Invalid {objectType} video 1 is additional text: {sVideo1IsAdditionalText}");
            }
            video1 = null;
            if (!string.IsNullOrEmpty(sVideoID1))
            {
                if (int.TryParse(sVideoID1, out int iVideoID1))
                {
                    video1 = all.GetVideoByID(iVideoID1, objectType);
                }
                else
                {
                    throw new InvalidDataException($"Invalid {objectType} video id 1: {sVideoID1}");
                }
            }
            video2 = null;
            if (!string.IsNullOrEmpty(sVideoID2))
            {
                if (int.TryParse(sVideoID2, out int iVideoID2))
                {
                    video2 = all.GetVideoByID(iVideoID2, objectType);
                }
                else
                {
                    throw new InvalidDataException($"Invalid {objectType} video id 2: {sVideoID2}");
                }
            }
        }

        /// <summary>
        /// Reads a song element, including the MUSX/Dorico documents it links to.
        /// </summary>
        /// <param name="songElement">song element</param>
        /// <param name="ord">song order</param>
        /// <param name="all">data read so far; the linked documents must already be in it</param>
        /// <param name="songDocuments">song id,document id pairs linked so far, used to reject duplicate links</param>
        /// <returns>the song</returns>
        private static Song ProcessSong(XmlElement songElement, int ord, AllData all, HashSet<string> songDocuments)
        {
            const string objectType = "song";
            int iID = GetObjectID(songElement, objectType);
            if (all.songs.Any(s => s.id == iID))
            {
                throw new InvalidDataException($"Duplicate song id: {iID}");
            }
            string sTitle = GetCDataNode(songElement, "title", objectType);
            string sAuthor = GetCDataNode(songElement, "author", objectType);
            if (string.IsNullOrEmpty(sTitle))
            {
                throw new InvalidDataException($"Song {iID} has no title");
            }
            if (string.IsNullOrEmpty(sAuthor))
            {
                throw new InvalidDataException($"Song {iID} has no author");
            }
            string? sArtist = GetOptionalCDataNode(songElement, "artist", objectType);
            string? sCopyright = GetOptionalCDataNode(songElement, "copyright", objectType);
            string? sPersonalConnection = GetOptionalCDataNode(songElement, "personalconnection", objectType);
            int? yearStart = GetOptionalInt(songElement, "copyrightyearstart", objectType);
            int? yearEnd = GetOptionalInt(songElement, "copyrightyearend", objectType);
            if (yearEnd != null && yearStart == null)
            {
                throw new InvalidDataException($"Song {iID} has a copyrightyearend without a copyrightyearstart");
            }
            if (yearEnd != null && yearEnd < yearStart)
            {
                throw new InvalidDataException($"Song {iID} copyrightyearend {yearEnd} is before copyrightyearstart {yearStart}");
            }
            DateOnly? noticeDate = GetOptionalDate(songElement, "copyrightnoticedate", objectType);
            DateOnly? registrationDate = GetOptionalDate(songElement, "copyrightregistrationdate", objectType);
            string? sRegistrationNumber = GetRegularDataElement(songElement, "copyrightregistrationnumber", objectType, false);
            if (string.IsNullOrEmpty(sRegistrationNumber))
            {
                sRegistrationNumber = null;
            }
            CopyrightFlags? flags = null;
            string? sFlags = GetRegularDataElement(songElement, "copyrightflags", objectType, false);
            if (!string.IsNullOrEmpty(sFlags))
            {
                if (!Enum.TryParse(sFlags, out CopyrightFlags parsedFlags) || int.TryParse(sFlags, out _))
                {
                    throw new InvalidDataException($"Invalid song {iID} copyrightflags: {sFlags}");
                }
                flags = parsedFlags;
            }

            Song song = new Song(iID, ord, sTitle, sAuthor, sArtist, sCopyright, yearStart, yearEnd, noticeDate, registrationDate, sRegistrationNumber, flags, sPersonalConnection);
            foreach (XmlNode docNode in songElement.SelectNodes("documentid") ?? throw new InvalidDataException("song documentid selection failed"))
            {
                AttachedDocument? doc = FindAttachedDocument(all, docNode.InnerText, null);
                if (doc == null)
                {
                    throw new InvalidDataException($"Song {iID} has an empty documentid");
                }
                if (doc.type != DocumentType.MUSX && doc.type != DocumentType.Dorico)
                {
                    throw new InvalidDataException($"Song {iID} document {doc.id} is not a {DocumentType.MUSX} or {DocumentType.Dorico} document");
                }
                if (!songDocuments.Add($"{iID},{doc.id}"))
                {
                    throw new InvalidDataException($"Song {iID} links to document {doc.id} more than once");
                }
                song.documents.Add(doc);
            }
            return song;
        }

        private static string? GetOptionalCDataNode(XmlElement elem, string prop, string objectType)
        {
            string? ret = null;
            if (elem.SelectSingleNode(prop) != null)
            {
                ret = GetCDataNode(elem, prop, objectType);
                if (string.IsNullOrEmpty(ret))
                {
                    ret = null;
                }
            }
            return ret;
        }

        private static int? GetOptionalInt(XmlElement elem, string prop, string objectType)
        {
            int? ret = null;
            string? s = GetRegularDataElement(elem, prop, objectType, false);
            if (!string.IsNullOrEmpty(s))
            {
                if (!int.TryParse(s, NumberStyles.None, CultureInfo.InvariantCulture, out int parsed))
                {
                    throw new InvalidDataException($"Invalid {objectType} {prop}: {s}");
                }
                ret = parsed;
            }
            return ret;
        }

        private static DateOnly? GetOptionalDate(XmlElement elem, string prop, string objectType)
        {
            DateOnly? ret = null;
            string? s = GetRegularDataElement(elem, prop, objectType, false);
            if (!string.IsNullOrEmpty(s))
            {
                if (!DateOnly.TryParseExact(s, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly parsed))
                {
                    throw new InvalidDataException($"Invalid {objectType} {prop} (expected yyyy-MM-dd): {s}");
                }
                ret = parsed;
            }
            return ret;
        }

        private static void ProcessCopyrightXMLEntry(XmlElement nextElement, ref int order, string objectType, AllData all, List<Copyright> copyrightList)
        {
            int iID = GetObjectID(nextElement, objectType);
            int iOrd = ++order;
            string sVideoID1 = GetRegularDataElement(nextElement, "videoid1", objectType);
            string sVideoID2 = GetRegularDataElement(nextElement, "videoid2", objectType);
            string sSong = GetCDataNode(nextElement, "song", objectType);
            string sCopyright = GetCDataNode(nextElement, "copyright", objectType);
            int iVideoID1, iVideoID2;
            Video v1;
            if (int.TryParse(sVideoID1, out iVideoID1))
            {
                v1 = all.GetVideoByID(iVideoID1, objectType);
            }
            else
            {
                throw new InvalidDataException($"Invalid {objectType} video id 1: {sVideoID1}");
            }
            Video? v2 = null;
            if (!string.IsNullOrEmpty(sVideoID2))
            {
                if (int.TryParse(sVideoID2, out iVideoID2))
                {
                    v2 = all.GetVideoByID(iVideoID2, objectType);
                }
                else
                {
                    throw new InvalidDataException($"Invalid {objectType} video id 2: {sVideoID2}");
                }
            }
            Song? song = null;
            bool songRequired = copyrightList == all.copyrightsFound;
            string? sSongID = GetRegularDataElement(nextElement, "songid", objectType, false);
            if (!string.IsNullOrEmpty(sSongID))
            {
                if (!songRequired)
                {
                    throw new InvalidDataException($"{objectType} entries do not support songid");
                }
                if (!int.TryParse(sSongID, out int iSongID))
                {
                    throw new InvalidDataException($"Invalid {objectType} song id: {sSongID}");
                }
                song = all.songs.FirstOrDefault(s => s.id == iSongID) ?? throw new InvalidDataException($"Invalid {objectType} song id found: {iSongID}");
            }
            else if (songRequired)
            {
                throw new InvalidDataException($"{objectType} {iID} has no songid");
            }
            copyrightList.Add(new Copyright(iID, iOrd, sSong, sCopyright, v1, v2, song));
        }

        /// <summary>
        /// Gets a document referenced by a video. Each document normally belongs to exactly one video; a reference marked
        /// shared="true" points to a document that belongs to another video and is not counted as that document's use.
        /// </summary>
        private static AttachedDocument? GetVideoDocument(XmlElement videoElement, string elementName, DocumentType expectedType, AllData all, HashSet<int> usedDocuments)
        {
            AttachedDocument? doc = null;
            XmlElement? subelem = videoElement.SelectSingleNode(elementName) as XmlElement;
            if (subelem != null)
            {
                string sShared = subelem.GetAttribute("shared");
                bool bShared = false;
                if (!string.IsNullOrEmpty(sShared) && !bool.TryParse(sShared, out bShared))
                {
                    throw new InvalidDataException($"Invalid video {elementName} shared value: {sShared}");
                }
                doc = FindAttachedDocument(all, subelem.InnerText, bShared ? null : usedDocuments);
                if (doc != null && doc.type != expectedType)
                {
                    throw new InvalidDataException($"Video {elementName} {doc.id} is not a {expectedType} document");
                }
            }
            return doc;
        }

        private static AttachedDocument? FindAttachedDocument(AllData all, string? docid, HashSet<int>? usedIDs)
        {
            if (string.IsNullOrEmpty(docid))
            {
                return null;
            }
            if (!int.TryParse(docid, out int iDocID))
            {
                throw new InvalidDataException($"Invalid document ID: {docid}");
            }
            AttachedDocument? found = null;
            foreach (AttachedDocument doc in all.attachedDocuments)
            {
                if (doc.id == iDocID)
                {
                    found = doc;
                    break;
                }
            }
            if (found == null)
            {
                throw new InvalidDataException($"Did not find document: {docid}");
            }
            if (usedIDs != null)
            {
                if (usedIDs.Contains(found.id))
                {
                    throw new InvalidDataException($"Document used primarily multiple times: {docid}");
                }
                usedIDs.Add(found.id);
            }
            return found;
        }

        private static bool CheckForValidXmlElement(XmlNode node)
        {
            if (node.NodeType == XmlNodeType.Whitespace || node.NodeType == XmlNodeType.Comment)
            {
                return false;
            }
            else if (node.NodeType == XmlNodeType.Element)
            {
                return true;
            }
            else
            {
                throw new InvalidDataException($"Invalid XML node type found: {node.NodeType}");
            }
        }

        private static void ProcessExceptionList(XmlElement exceptionListElement, AllData all, int ord)
        {
            int iMemberORD = 0;
            int iExceptionListID = 0;
            int iExceptionListVideoID = 0;
            string sExceptionListName = string.Empty;
            string? sExceptionListDetailHTML = null;
            List<ExceptionListMember> members = new List<ExceptionListMember>();
            foreach (XmlNode nextNode in exceptionListElement.ChildNodes)
            {
                if (!CheckForValidXmlElement(nextNode)) continue;
                XmlElement nextElement = (XmlElement)nextNode;
                string elemName = nextElement.Name;
                if (elemName == "id")
                {
                    if (!int.TryParse(nextElement.InnerText, out iExceptionListID))
                    {
                        throw new InvalidDataException($"Invalid exception list id specified: {nextElement.InnerText}");
                    }
                }
                else if (elemName == "detail")
                {
                    sExceptionListDetailHTML = GetCDataNode(exceptionListElement, "detail", "exceptionlist");
                }
                else if (elemName == "name")
                {
                    sExceptionListName = nextElement.InnerText;
                }
                else if (elemName == "videoid")
                {
                    if (!int.TryParse(nextElement.InnerText, out iExceptionListVideoID))
                    {
                        throw new InvalidDataException($"Invalid exception list video id: {nextElement.InnerText}");
                    }
                }
                else if (elemName == "member")
                {
                    string sCategoryID = string.Empty;
                    string sName = string.Empty;
                    string sVideoID = string.Empty;
                    foreach (XmlNode propNode in nextElement.ChildNodes)
                    {
                        if (CheckForValidXmlElement(propNode))
                        {
                            XmlElement propElement = (XmlElement)propNode;
                            string propName = propElement.Name;
                            if (propName == "categoryid")
                            {
                                sCategoryID = propElement.InnerText;
                            }
                            else if (propName == "name")
                            {
                                sName = propElement.InnerText;
                            }
                            else if (propName == "videoid")
                            {
                                sVideoID = propElement.InnerText;
                            }
                            else
                            {
                                throw new InvalidDataException($"Invalid exception list property: {propName}");
                            }
                        }
                    }
                    if (string.IsNullOrEmpty(sCategoryID)) throw new InvalidDataException("Exception list member missing category ID");
                    if (string.IsNullOrEmpty(sName)) throw new InvalidDataException("Exception list member missing name");
                    if (string.IsNullOrEmpty(sVideoID)) throw new InvalidDataException("Exception list member missing video id");
                    int iCategoryID;
                    if (!int.TryParse(sCategoryID, out iCategoryID))
                    {
                        throw new InvalidDataException($"Invalid exception list member category: {sCategoryID}");
                    }
                    int iVideoID;
                    if (!int.TryParse(sVideoID, out iVideoID))
                    {
                        throw new InvalidDataException($"Invalid exception list member video {sVideoID}");
                    }
                    ++iMemberORD;
                    members.Add(new ExceptionListMember(iMemberORD, sName, iVideoID, all, iCategoryID));
                }
                else
                {
                    throw new InvalidDataException($"Invalid exception list member {elemName}");
                }
            }
            if (iExceptionListID <= 0)
            {
                throw new InvalidDataException("Invalid exception list ID");
            }
            if (string.IsNullOrEmpty(sExceptionListName))
            {
                throw new InvalidDataException("No exception list name specified.");
            }
            if (members.Count == 0)
            {
                throw new InvalidDataException($"Exception list has no members: {sExceptionListName}");
            }
            if (iExceptionListVideoID <= 0)
            {
                throw new InvalidDataException($"Invalid exception list video ID: {iExceptionListVideoID}");
            }
            if (sExceptionListDetailHTML == null)
            {
                throw new InvalidDataException("No exception list detail specified");
            }
            ExceptionList el = new ExceptionList(iExceptionListID, ord, sExceptionListName, iExceptionListVideoID, all, sExceptionListDetailHTML);
            el.Members.AddRange(members);
            all.exceptionLists.Add(el);
        }

        private static void ProcessVideoLists(XmlElement videoListsElement, AllData all)
        {
            int mainlineOrder = 0;
            int musicvideoOrder = 0;
            int sillysongOrder = 0;
            int workvideoOrder = 0;
            int kidzvideoOrder = 0;
            int unexplainablevideoOrder = 0;
            foreach (XmlNode nextNode in videoListsElement.ChildNodes)
            {
                if (!CheckForValidXmlElement(nextNode)) continue;
                XmlElement nextElement = (XmlElement)nextNode;
                string elemName = nextElement.Name;
                int iVideoID, iOrd;
                string sObjectType;
                if (elemName == "mainline")
                {
                    sObjectType = "videolist video mainline";
                    iVideoID = GetForeignKeyID(nextElement, "video list mainline videoid", "videoid");
                    iOrd = ++mainlineOrder;
                    string sEpisode = GetCDataNode(nextElement, "episode", sObjectType);
                    string sTheme = GetCDataNode(nextElement, "theme", sObjectType);
                    string sAudience = GetCDataNode(nextElement, "audience", sObjectType);
                    string sMajorRulez = GetCDataNode(nextElement, "majorrulez", sObjectType);
                    string sMemes = GetCDataNode(nextElement, "memes", sObjectType);
                    string sMinorRulez = GetCDataNode(nextElement, "minorrulez", sObjectType);
                    all.mainlinevideos.Add(new MainLineVideo(iVideoID, all, iOrd, sEpisode, sTheme, sAudience, sMajorRulez, sMemes, sMinorRulez));
                }
                else if (elemName == "musicvideo")
                {
                    sObjectType = "videolist video musicvideo";
                    iVideoID = GetForeignKeyID(nextElement, "musicvideo videoid", "videoid");
                    iOrd = ++musicvideoOrder;
                    int iPerformerID = GetForeignKeyID(nextElement, "video list musicvideo performerid", "performerid");
                    string sPiece = GetCDataNode(nextElement, "piece", "musicvideo");
                    string sAuthor = GetCDataNode(nextElement, "author", "musicvideo");
                    string sSetting = GetCDataNode(nextElement, "setting", "musicvideo");
                    all.musicvideos.Add(new MusicVideo(iVideoID, all, iOrd, iPerformerID, sPiece, sAuthor, sSetting));
                }
                else if (elemName == "sillysong")
                {
                    sObjectType = "videolist video sillysong";
                    iVideoID = GetForeignKeyID(nextElement, "video list sillysong video id", "videoid");
                    iOrd = ++sillysongOrder;
                    string sNumber = GetCDataNode(nextElement, "number", sObjectType);
                    string sRulez = GetCDataNode(nextElement, "rulez", sObjectType);
                    string sMemes = GetCDataNode(nextElement, "memes", sObjectType);
                    all.sillysongvideos.Add(new SillySongVideo(iVideoID, all, iOrd, sNumber, sRulez, sMemes));
                }
                else if (elemName == "workvideo")
                {
                    sObjectType = "videolist video workvideo";
                    iVideoID = GetForeignKeyID(nextElement, "video list workvideo video id", "videoid");
                    iOrd = ++workvideoOrder;
                    string sConcepts = GetCDataNode(nextElement, "concepts", sObjectType);
                    all.workvideos.Add(new WorkVideo(iVideoID, all, iOrd, sConcepts));
                }
                else if (elemName == "kidzvideo")
                {
                    sObjectType = "videolist video kidzvideo";
                    iVideoID = GetForeignKeyID(nextElement, "video list kidzvideo video id", "videoid");
                    iOrd = ++kidzvideoOrder;
                    all.kidzvideos.Add(new KidzVideo(iVideoID, all, iOrd));
                }
                else if (elemName == "unexplainablevideo")
                {
                    sObjectType = "videolist video unexplainablevideo";
                    iVideoID = GetForeignKeyID(nextElement, "video list unexplainablevideo video id", "videoid");
                    iOrd = ++unexplainablevideoOrder;
                    string sReason = GetCDataNode(nextElement, "reason", sObjectType);
                    all.unexplainablevideos.Add(new UnexplainableVideo(iVideoID, all, iOrd, sReason));
                }
                else
                {
                    throw new InvalidDataException("invalid video list element");
                }
            }
        }

        private static int GetObjectID(XmlElement nextElement, string objecttype)
        {
            XmlElement? elem = nextElement.SelectSingleNode("id") as XmlElement;
            if (elem == null)
            {
                throw new InvalidDataException($"No {objecttype} id found");
            }
            string innerText = elem.InnerText;
            if (!int.TryParse(innerText, out int val))
            {
                throw new InvalidDataException($"Invalid {objecttype} id: {innerText}");
            }
            return val; ;
        }

        private static int GetForeignKeyID(XmlElement nextElement, string objecttype, string elementName)
        {
            XmlElement? elem = nextElement.SelectSingleNode(elementName) as XmlElement;
            if (elem == null)
            {
                throw new InvalidDataException($"No {objecttype} found");
            }
            string innerText = elem.InnerText;
            if (!int.TryParse(innerText, out int val))
            {
                throw new InvalidDataException($"Invalid {objecttype}: {innerText}");
            }
            return val;
        }

        /// <summary>
        /// Saves the data read from the XML file to the database.
        /// </summary>
        /// <param name="all">data read from the XML file</param>
        /// <param name="conn">database connection</param>
        /// <param name="tx">database transaction</param>
        /// <param name="local">
        /// true to also save each video's <see cref="Video.publishtimestamp"/>; in remote mode the website's admin refresh
        /// fills in that column from the YouTube API, so it's left alone
        /// </param>
        private static void SaveData(AllData all, NpgsqlConnection conn, NpgsqlTransaction tx, bool local)
        {
            int iID;
            bool updateRecord;
            string insertStatement;
            string updateStatement;
            List<string> idCols;
            List<string> dataCols;

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "ord", "doctype", "purpose", "googledrivefileid", "supportsplayback" };
            updateStatement = GenerateSQLStatement("documents", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("documents", idCols, dataCols, false);
            foreach (AttachedDocument d in all.attachedDocuments)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = d.id;
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, iID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, d.ord);
                    AddParameter(cmd, "@doctype", NpgsqlDbType.Integer, Convert.ToInt32(d.type));
                    AddParameter(cmd, "@purpose", NpgsqlDbType.Integer, Convert.ToInt32(d.purpose));
                    AddParameter(cmd, "@googledrivefileid", NpgsqlDbType.Varchar, d.googledrivefileid);
                    AddParameter(cmd, "@supportsplayback", NpgsqlDbType.Boolean, d.supportsplayback);
                    updateRecord = all.documentIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.documentIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "documents", all.documentIDs, idCols);

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "youtubeid", "shortname", "identifier", "owner", "isprivate", "additionaltextdocumentid", "musxdocumentid", "doricodocumentid" };
            if (local)
            {
                dataCols.Add("published_timestamp");
            }
            updateStatement = GenerateSQLStatement("videos", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("videos", idCols, dataCols, false);
            foreach (Video v in all.videos)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = v.id;
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, iID);
                    AddParameter(cmd, "@youtubeid", NpgsqlDbType.Varchar, v.youtubeid);
                    AddParameter(cmd, "@shortname", NpgsqlDbType.Varchar, v.shortname);
                    AddParameter(cmd, "@identifier", NpgsqlDbType.Varchar, v.identifier);
                    AddParameter(cmd, "@owner", NpgsqlDbType.Varchar, v.owner);
                    AddParameter(cmd, "@isprivate", NpgsqlDbType.Boolean, v.isprivate);
                    AddParameter(cmd, "@additionaltextdocumentid", NpgsqlDbType.Integer, v.additionaltextdocument?.id);
                    AddParameter(cmd, "@musxdocumentid", NpgsqlDbType.Integer, v.musxdocument?.id);
                    AddParameter(cmd, "@doricodocumentid", NpgsqlDbType.Integer, v.doricodocument?.id);
                    if (local)
                    {
                        AddParameter(cmd, "@published_timestamp", NpgsqlDbType.TimestampTz, v.publishtimestamp);
                    }
                    updateRecord = all.videoIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.videoIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "videos", all.videoIDs, idCols);

            SaveSongs(conn, tx, all);

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "name", "ord" };
            updateStatement = GenerateSQLStatement("performers", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("performers", idCols, dataCols, false);
            foreach (NamedEntity p in all.performers)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = p.id;
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, iID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, p.ord);
                    AddParameter(cmd, "@name", NpgsqlDbType.Varchar, p.name);
                    updateRecord = all.performerIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.performerIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "performers", all.performerIDs, idCols);

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "ord", "number", "rule", "source", "actualrule", "videoid1", "videoid2", "video1isadditionaltext" };
            updateStatement = GenerateSQLStatement("rulez_official", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("rulez_official", idCols, dataCols, false);
            foreach (RuleOfficial r in all.rulesOfficial)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = r.id;
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, iID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, r.ord);
                    AddParameter(cmd, "@number", NpgsqlDbType.Varchar, r.number);
                    AddParameter(cmd, "@rule", NpgsqlDbType.Varchar, r.rule);
                    AddParameter(cmd, "@source", NpgsqlDbType.Varchar, r.source);
                    AddParameter(cmd, "@actualrule", NpgsqlDbType.Varchar, r.actualrule);
                    AddParameter(cmd, "@videoid1", NpgsqlDbType.Integer, r.video1?.id);
                    AddParameter(cmd, "@videoid2", NpgsqlDbType.Integer, r.video2?.id);
                    AddParameter(cmd, "@video1isadditionaltext", NpgsqlDbType.Boolean, r.video1isadditionaltext);
                    updateRecord = all.rulesOfficialIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.rulesOfficialIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "rulez_official", all.rulesOfficialIDs, idCols);

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "ord", "rule", "source", "videoid1", "videoid2", "video1isadditionaltext" };
            updateStatement = GenerateSQLStatement("rulez_unofficial", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("rulez_unofficial", idCols, dataCols, false);
            foreach (RuleUnofficial r in all.rulesUnofficial)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = r.id;
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, iID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, r.ord);
                    AddParameter(cmd, "@rule", NpgsqlDbType.Varchar, r.rule);
                    AddParameter(cmd, "@source", NpgsqlDbType.Varchar, r.source);
                    AddParameter(cmd, "@videoid1", NpgsqlDbType.Integer, r.video1?.id);
                    AddParameter(cmd, "@videoid2", NpgsqlDbType.Integer, r.video2?.id);
                    AddParameter(cmd, "@video1isadditionaltext", NpgsqlDbType.Boolean, r.video1isadditionaltext);
                    updateRecord = all.rulesUnofficialIDs.Contains(r.id);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.rulesUnofficialIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "rulez_unofficial", all.rulesUnofficialIDs, idCols);

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "ord", "videoid", "location", "isparody" };
            updateStatement = GenerateSQLStatement("lyrics_analyses", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("lyrics_analyses", idCols, dataCols, false);
            foreach (LyricsAnalysis la in all.lyricsAnalyses)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = la.id;
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, iID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, la.ord);
                    AddParameter(cmd, "@videoid", NpgsqlDbType.Integer, la.video.id);
                    AddParameter(cmd, "@location", NpgsqlDbType.Integer, Convert.ToInt32(la.location));
                    AddParameter(cmd, "@isparody", NpgsqlDbType.Boolean, la.parody);
                    updateRecord = all.lyricsAnalysisIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.lyricsAnalysisIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "lyrics_analyses", all.lyricsAnalysisIDs, idCols);

            ProcessCopyright(conn, tx, all, true);
            ProcessCopyright(conn, tx, all, false);

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "ord", "name" };
            updateStatement = GenerateSQLStatement("exception_list_member_types", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("exception_list_member_types", idCols, dataCols, false);
            foreach (NamedEntity elmt in all.exceptionListMemberTypes)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = elmt.id;
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, iID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, elmt.ord);
                    AddParameter(cmd, "@name", NpgsqlDbType.Varchar, elmt.name);
                    updateRecord = all.exceptionlistmembertypeIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.exceptionlistmembertypeIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "exception_list_member_types", all.exceptionlistmembertypeIDs, idCols);

            SaveExceptionLists(conn, tx, all);

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "ord", "name", "url" };
            updateStatement = GenerateSQLStatement("landing_pages", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("landing_pages", idCols, dataCols, false);
            foreach (LandingPage lp in all.landingpages)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = lp.id;
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, iID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, lp.ord);
                    AddParameter(cmd, "@name", NpgsqlDbType.Varchar, lp.name);
                    AddParameter(cmd, "@url", NpgsqlDbType.Varchar, lp.url);
                    updateRecord = all.landingPageIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.landingPageIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "landing_pages", all.landingPageIDs, idCols);

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "ord", "number", "target", "detail", "source", "comment", "videoid" };
            updateStatement = GenerateSQLStatement("complaints", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("complaints", idCols, dataCols, false);
            foreach (Complaint c in all.complaints)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = c.id;
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, iID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, c.ord);
                    AddParameter(cmd, "@number", NpgsqlDbType.Varchar, c.number);
                    AddParameter(cmd, "@target", NpgsqlDbType.Varchar, c.target);
                    AddParameter(cmd, "@detail", NpgsqlDbType.Varchar, c.detail);
                    AddParameter(cmd, "@source", NpgsqlDbType.Varchar, c.source);
                    AddParameter(cmd, "@comment", NpgsqlDbType.Varchar, c.comment);
                    AddParameter(cmd, "@videoid", NpgsqlDbType.Integer, c.video?.id);
                    updateRecord = all.complaintIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.complaintIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "complaints", all.complaintIDs, idCols);

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "ord", "number", "googledrivefileid", "name", "suggestion" };
            updateStatement = GenerateSQLStatement("audios", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("audios", idCols, dataCols, false);
            foreach (Audio a in all.audios)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = a.id;
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, iID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, a.ord);
                    AddParameter(cmd, "@googledrivefileid", NpgsqlDbType.Varchar, a.googledrivefileid);
                    AddParameter(cmd, "@number", NpgsqlDbType.Integer, a.number);
                    AddParameter(cmd, "@name", NpgsqlDbType.Varchar, a.name);
                    AddParameter(cmd, "@suggestion", NpgsqlDbType.Varchar, a.suggestion);
                    updateRecord = all.audioIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.audioIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "audios", all.audioIDs, idCols);

            int iVideoID;

            idCols = new List<string>() { "videoid" };
            dataCols = new List<string>() { "ord", "episode", "theme", "audience", "majorrulez", "memes", "minorrulez" };
            updateStatement = GenerateSQLStatement("videolist_mainline", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("videolist_mainline", idCols, dataCols, false);
            foreach (MainLineVideo v in all.mainlinevideos)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iVideoID = v.video.id;
                    AddParameter(cmd, "@videoid", NpgsqlDbType.Integer, iVideoID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, v.ord);
                    AddParameter(cmd, "@episode", NpgsqlDbType.Varchar, v.episode);
                    AddParameter(cmd, "@theme", NpgsqlDbType.Varchar, v.theme);
                    AddParameter(cmd, "@audience", NpgsqlDbType.Varchar, v.audience);
                    AddParameter(cmd, "@majorrulez", NpgsqlDbType.Varchar, v.majorrulez);
                    AddParameter(cmd, "@memes", NpgsqlDbType.Varchar, v.memes);
                    AddParameter(cmd, "@minorrulez", NpgsqlDbType.Varchar, v.minorrulez);
                    updateRecord = all.mainlinevideoIDs.Contains(iVideoID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.mainlinevideoIDs.Remove(iVideoID);
                }
            }
            DeleteIDs(conn, tx, "videolist_mainline", all.mainlinevideoIDs, idCols);

            idCols = new List<string>() { "videoid" };
            dataCols = new List<string>() { "ord", "performerid", "piece", "author", "setting" };
            updateStatement = GenerateSQLStatement("videolist_musicvideos", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("videolist_musicvideos", idCols, dataCols, false);
            foreach (MusicVideo p in all.musicvideos)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iVideoID = p.video.id;
                    AddParameter(cmd, "@videoid", NpgsqlDbType.Integer, iVideoID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, p.ord);
                    AddParameter(cmd, "@performerid", NpgsqlDbType.Integer, p.performer.id);
                    AddParameter(cmd, "@piece", NpgsqlDbType.Varchar, p.piece);
                    AddParameter(cmd, "@author", NpgsqlDbType.Varchar, p.author);
                    AddParameter(cmd, "@setting", NpgsqlDbType.Varchar, p.setting);
                    updateRecord = all.musicvideoIDs.Contains(iVideoID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.musicvideoIDs.Remove(iVideoID);
                }
            }
            DeleteIDs(conn, tx, "videolist_musicvideos", all.musicvideoIDs, idCols);

            idCols = new List<string>() { "videoid" };
            dataCols = new List<string>() { "ord", "number", "rulez", "memes" };
            updateStatement = GenerateSQLStatement("videolist_sillysongs", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("videolist_sillysongs", idCols, dataCols, false);
            foreach (SillySongVideo v in all.sillysongvideos)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iVideoID = v.video.id;
                    AddParameter(cmd, "@videoid", NpgsqlDbType.Integer, iVideoID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, v.ord);
                    AddParameter(cmd, "@number", NpgsqlDbType.Varchar, v.number);
                    AddParameter(cmd, "@rulez", NpgsqlDbType.Varchar, v.rulez);
                    AddParameter(cmd, "@memes", NpgsqlDbType.Varchar, v.memes);
                    updateRecord = all.sillysongvideoIDs.Contains(iVideoID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.sillysongvideoIDs.Remove(iVideoID);
                }
            }
            DeleteIDs(conn, tx, "videolist_sillysongs", all.sillysongvideoIDs, idCols);

            idCols = new List<string>() { "videoid" };
            dataCols = new List<string>() { "ord", "concepts" };
            updateStatement = GenerateSQLStatement("videolist_workvideos", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("videolist_workvideos", idCols, dataCols, false);
            foreach (WorkVideo v in all.workvideos)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iVideoID = v.video.id;
                    AddParameter(cmd, "@videoid", NpgsqlDbType.Integer, iVideoID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, v.ord);
                    AddParameter(cmd, "@concepts", NpgsqlDbType.Varchar, v.concepts);
                    updateRecord = all.workvideoIDs.Contains(iVideoID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.workvideoIDs.Remove(iVideoID);
                }
            }
            DeleteIDs(conn, tx, "videolist_workvideos", all.workvideoIDs, idCols);

            idCols = new List<string>() { "videoid" };
            dataCols = new List<string>() { "ord" };
            updateStatement = GenerateSQLStatement("videolist_kidzvideos", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("videolist_kidzvideos", idCols, dataCols, false);
            foreach (KidzVideo v in all.kidzvideos)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iVideoID = v.video.id;
                    AddParameter(cmd, "@videoid", NpgsqlDbType.Integer, iVideoID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, v.ord);
                    updateRecord = all.kidzvideoIDs.Contains(iVideoID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.kidzvideoIDs.Remove(iVideoID);
                }
            }
            DeleteIDs(conn, tx, "videolist_kidzvideos", all.kidzvideoIDs, idCols);

            idCols = new List<string>() { "videoid" };
            dataCols = new List<string>() { "ord", "reason" };
            updateStatement = GenerateSQLStatement("videolist_unexplainablevideos", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("videolist_unexplainablevideos", idCols, dataCols, false);
            foreach (UnexplainableVideo v in all.unexplainablevideos)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iVideoID = v.video.id;
                    AddParameter(cmd, "@videoid", NpgsqlDbType.Integer, iVideoID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, v.ord);
                    AddParameter(cmd, "@reason", NpgsqlDbType.Varchar, v.reason);
                    updateRecord = all.unexplainablevideoIDs.Contains(iVideoID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.unexplainablevideoIDs.Remove(iVideoID);
                }
            }
            DeleteIDs(conn, tx, "videolist_unexplainablevideos", all.unexplainablevideoIDs, idCols);
        }

        /// <summary>
        /// Saves songs and their song_documents links. Must run after documents are saved and before copyrights found,
        /// which reference songs.
        /// </summary>
        private static void SaveSongs(NpgsqlConnection conn, NpgsqlTransaction tx, AllData all)
        {
            List<string> idCols = new List<string>() { "id" };
            List<string> dataCols = new List<string>() { "ord", "title", "author", "artist", "copyright", "copyrightyearstart", "copyrightyearend", "copyrightnoticedate", "copyrightregistrationdate", "copyrightregistrationnumber", "copyrightflags", "personalconnection" };
            string updateStatement = GenerateSQLStatement("songs", idCols, dataCols, true);
            string insertStatement = GenerateSQLStatement("songs", idCols, dataCols, false);
            foreach (Song s in all.songs)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, s.id);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, s.ord);
                    AddParameter(cmd, "@title", NpgsqlDbType.Varchar, s.title);
                    AddParameter(cmd, "@author", NpgsqlDbType.Varchar, s.author);
                    AddParameter(cmd, "@artist", NpgsqlDbType.Varchar, s.artist);
                    AddParameter(cmd, "@copyright", NpgsqlDbType.Varchar, s.copyright);
                    AddParameter(cmd, "@copyrightyearstart", NpgsqlDbType.Integer, s.copyrightyearstart);
                    AddParameter(cmd, "@copyrightyearend", NpgsqlDbType.Integer, s.copyrightyearend);
                    AddParameter(cmd, "@copyrightnoticedate", NpgsqlDbType.Date, s.copyrightnoticedate);
                    AddParameter(cmd, "@copyrightregistrationdate", NpgsqlDbType.Date, s.copyrightregistrationdate);
                    AddParameter(cmd, "@copyrightregistrationnumber", NpgsqlDbType.Varchar, s.copyrightregistrationnumber);
                    AddParameter(cmd, "@copyrightflags", NpgsqlDbType.Integer, s.copyrightflags == null ? null : (int)s.copyrightflags.Value);
                    AddParameter(cmd, "@personalconnection", NpgsqlDbType.Varchar, s.personalconnection);
                    bool updateRecord = all.songIDs.Contains(s.id);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.songIDs.Remove(s.id);
                }
            }
            DeleteIDs(conn, tx, "songs", all.songIDs, idCols);

            //the junction table has no data columns, so links are only inserted or deleted
            string linkInsertStatement = GenerateSQLStatement("song_documents", new List<string>() { "songid", "documentid" }, new List<string>(), false);
            foreach (Song s in all.songs)
            {
                foreach (AttachedDocument d in s.documents)
                {
                    string key = s.id + "," + d.id;
                    if (all.songDocumentIDs.Remove(key)) continue;
                    using (NpgsqlCommand cmd = GetCommand(conn, tx))
                    {
                        AddParameter(cmd, "@songid", NpgsqlDbType.Integer, s.id);
                        AddParameter(cmd, "@documentid", NpgsqlDbType.Integer, d.id);
                        cmd.CommandText = linkInsertStatement;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            DeleteIDs2(conn, tx, "song_documents", all.songDocumentIDs, "songid", "documentid");
        }

        private static void SaveExceptionLists(NpgsqlConnection conn, NpgsqlTransaction tx, AllData all)
        {
            int iID;
            bool updateRecord;
            List<string> exceptionlistidCols = new List<string>() { "id" };
            List<string> exceptionlistdataCols = new List<string>() { "ord", "name", "videoid", "detail" };
            string exceptionlistupdateStatement = GenerateSQLStatement("exception_lists", exceptionlistidCols, exceptionlistdataCols, true);
            string exceptionlistinsertStatement = GenerateSQLStatement("exception_lists", exceptionlistidCols, exceptionlistdataCols, false);
            List<string> exceptionlistmemberidCols = new List<string>() { "exceptionlistid", "ord" };
            List<string> exceptionlistmemberdataCols = new List<string>() { "categoryid", "videoid", "name" };
            string exceptionlistmemberupdateStatement = GenerateSQLStatement("exception_list_members", exceptionlistmemberidCols, exceptionlistmemberdataCols, true);
            string exceptionlistmemberinsertStatement = GenerateSQLStatement("exception_list_members", exceptionlistmemberidCols, exceptionlistmemberdataCols, false);
            foreach (ExceptionList nextExList in all.exceptionLists)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = nextExList.id;
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, iID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, nextExList.ord);
                    AddParameter(cmd, "@name", NpgsqlDbType.Varchar, nextExList.name);
                    AddParameter(cmd, "@videoid", NpgsqlDbType.Integer, nextExList.SourceVideo.id);
                    AddParameter(cmd, "@detail", NpgsqlDbType.Varchar, nextExList.detail);
                    updateRecord = all.exceptionListIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? exceptionlistupdateStatement : exceptionlistinsertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.exceptionListIDs.Remove(iID);
                }
                foreach (ExceptionListMember member in nextExList.Members)
                {
                    using (NpgsqlCommand cmd = GetCommand(conn, tx))
                    {
                        AddParameter(cmd, "@exceptionlistid", NpgsqlDbType.Integer, nextExList.id);
                        AddParameter(cmd, "@ord", NpgsqlDbType.Integer, member.ord);
                        AddParameter(cmd, "@categoryid", NpgsqlDbType.Integer, member.Category.id);
                        AddParameter(cmd, "@videoid", NpgsqlDbType.Integer, member.SourceVideo.id);
                        AddParameter(cmd, "@name", NpgsqlDbType.Varchar, member.name);
                        string key = nextExList.id + "," + member.ord;
                        updateRecord = all.exceptionlistmemberIDs.Contains(key);
                        cmd.CommandText = updateRecord ? exceptionlistmemberupdateStatement : exceptionlistmemberinsertStatement;
                        cmd.ExecuteNonQuery();
                        if (updateRecord) all.exceptionlistmemberIDs.Remove(key);
                    }
                }
            }
            DeleteIDs(conn, tx, "exception_lists", all.exceptionListIDs, exceptionlistidCols);
            DeleteIDs2(conn, tx, "exception_list_members", all.exceptionlistmemberIDs, "exceptionlistid", "ord");
        }

        private static string GenerateSQLStatement(string tableName, List<string> idcols, List<string> datacols, bool isUpdate)
        {
            StringBuilder sb = new StringBuilder();
            bool first;
            if (isUpdate)
            {
                sb.Append("UPDATE ");
                sb.Append(tableName);
                sb.Append(" SET ");
                first = true;
                foreach (string nextdatacol in datacols)
                {
                    if (!first) sb.Append(",");
                    sb.Append(nextdatacol);
                    sb.Append("=@");
                    sb.Append(nextdatacol);
                    first = false;
                }
                sb.Append(" WHERE ");
                first = true;
                foreach (string nextidcol in idcols)
                {
                    if (!first) sb.Append(" AND ");
                    sb.Append(nextidcol);
                    sb.Append("=@");
                    sb.Append(nextidcol);
                    first = false;
                }
            }
            else //update
            {
                sb.Append("INSERT INTO ");
                sb.Append(tableName);
                sb.Append("(");
                first = true;
                foreach (string nextidcol in idcols)
                {
                    if (!first) sb.Append(",");
                    sb.Append(nextidcol);
                    first = false;
                }
                foreach (string nextdatacol in datacols)
                {
                    if (!first) sb.Append(",");
                    sb.Append(nextdatacol);
                    first = false;
                }
                sb.Append(") VALUES (");
                first = true;
                foreach (string nextidcol in idcols)
                {
                    if (!first) sb.Append(",");
                    sb.Append("@");
                    sb.Append(nextidcol);
                    first = false;
                }
                foreach (string nextdatacol in datacols)
                {
                    if (!first) sb.Append(",");
                    sb.Append("@");
                    sb.Append(nextdatacol);
                    first = false;
                }
                sb.Append(")");
            }
            return sb.ToString();
        }

        private static void ProcessCopyright(NpgsqlConnection conn, NpgsqlTransaction tx, AllData all, bool forFound)
        {
            string table;
            HashSet<int> ids;
            List<Copyright> lst;
            if (forFound)
            {
                table = "copyrights_found";
                ids = all.copyrightFoundIDs;
                lst = all.copyrightsFound;
            }
            else
            {
                table = "copyrights_missing";
                ids = all.copyrightMissingIDs;
                lst = all.copyrightsMissing;
            }
            List<string> idCols = new List<string>() { "id" };
            List<string> dataCols = new List<string>() { "ord", "song", "copyright", "videoid1", "videoid2" };
            if (forFound)
            {
                dataCols.Add("songid");
            }
            string updateStatement = GenerateSQLStatement(table, idCols, dataCols, true);
            string insertStatement = GenerateSQLStatement(table, idCols, dataCols, false);
            foreach (Copyright c in lst)
            {
                int iID;
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = c.id;
                    AddParameter(cmd, "@id", NpgsqlDbType.Integer, iID);
                    AddParameter(cmd, "@ord", NpgsqlDbType.Integer, c.ord);
                    AddParameter(cmd, "@song", NpgsqlDbType.Varchar, c.song);
                    AddParameter(cmd, "@copyright", NpgsqlDbType.Varchar, c.copyright);
                    AddParameter(cmd, "@videoid1", NpgsqlDbType.Integer, c.video1.id);
                    AddParameter(cmd, "@videoid2", NpgsqlDbType.Integer, c.video2?.id);
                    if (forFound)
                    {
                        AddParameter(cmd, "@songid", NpgsqlDbType.Integer, c.songEntity?.id);
                    }
                    bool updateRecord = ids.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) ids.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, table, ids, idCols);
        }

        private static void DeleteIDs2(NpgsqlConnection conn, NpgsqlTransaction tx, string table, HashSet<string> ids, string idCol1, string idCol2)
        {
            foreach (string deleteIDs in ids)
            {
                string[] idValues = deleteIDs.Split([',']);
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    cmd.CommandText = $"DELETE FROM {table} WHERE {idCol1} = {idValues[0]} AND {idCol2} = {idValues[1]}";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void DeleteIDs(NpgsqlConnection conn, NpgsqlTransaction tx, string table, HashSet<int> ids, List<string> idCols)
        {
            if (idCols.Count != 1)
            {
                throw new InvalidDataException($"expected a single id column, got {idCols.Count} id columns.");
            }
            string idCol = idCols[0];
            foreach (int deleteid in ids)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    cmd.CommandText = $"DELETE FROM {table} WHERE {idCol} = {deleteid}";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void GetIDs2(NpgsqlConnection conn, NpgsqlTransaction tx, string table, HashSet<string> ids, string idCol1, string idCol2)
        {
            using (NpgsqlCommand cmd = GetCommand(conn, tx))
            {
                string sCmd = $"SELECT {idCol1},{idCol2} FROM {table}";
                cmd.CommandText = sCmd;
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids.Add($"{Convert.ToInt32(reader[0])},{Convert.ToInt32(reader[1])}");
                    }
                }
            }
        }

        private static void GetIDs(NpgsqlConnection conn, NpgsqlTransaction tx, string table, HashSet<int> ids, string idCol)
        {
            using (NpgsqlCommand cmd = GetCommand(conn, tx))
            {
                string sCmd = $"SELECT {idCol} FROM {table}";
                cmd.CommandText = sCmd;
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids.Add(Convert.ToInt32(reader[0]));
                    }
                }
            }
        }

        /// <summary>
        /// Gets the publish timestamps the database has for videos.
        /// </summary>
        /// <param name="conn">database connection</param>
        /// <param name="tx">database transaction</param>
        /// <param name="timestamps">receives each video ID that has a publish timestamp, mapped to that timestamp in UTC</param>
        private static void GetPublishTimestamps(NpgsqlConnection conn, NpgsqlTransaction tx, Dictionary<int, DateTime> timestamps)
        {
            using (NpgsqlCommand cmd = GetCommand(conn, tx))
            {
                cmd.CommandText = "SELECT id, published_timestamp FROM videos WHERE published_timestamp IS NOT NULL";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timestamps[reader.GetInt32(0)] = reader.GetFieldValue<DateTime>(1);
                    }
                }
            }
        }

        /// <summary>
        /// Parses a video publish timestamp from the XML file, such as 2023-10-07T14:32:05Z.
        /// </summary>
        /// <param name="s">ISO 8601 timestamp; one without an offset is treated as UTC</param>
        /// <returns>the timestamp in UTC (<see cref="DateTimeKind.Utc"/>), or null if it isn't valid</returns>
        private static DateTime? ParsePublishTimestamp(string s)
        {
            DateTime? ret;
            if (DateTimeOffset.TryParseExact(s, PublishTimestampFormats, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out DateTimeOffset parsed))
            {
                ret = parsed.UtcDateTime;
            }
            else
            {
                ret = null;
            }
            return ret;
        }

        /// <summary>
        /// Formats a video publish timestamp for the XML file in the same form the YouTube API uses, such as 2023-10-07T14:32:05Z.
        /// </summary>
        /// <param name="timestamp">timestamp in UTC</param>
        /// <returns>the formatted timestamp, with fractional seconds only when there are any</returns>
        private static string FormatPublishTimestamp(DateTime timestamp)
        {
            return timestamp.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFF'Z'", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Copies the database's publish timestamps into the XML file's video elements. Only the lines holding those
        /// timestamps are changed, so the rest of the file (formatting, comments, entities, line endings) stays as it was.
        /// </summary>
        /// <param name="inputFile">path to the XML file</param>
        /// <param name="all">data read from the XML file</param>
        /// <param name="databasePublishTimestamps">publish timestamps from the database, by video ID</param>
        /// <remarks>
        /// A new publishtimestamp element goes on the line after the video's isprivate element. A video that has a
        /// timestamp in the XML file but not in the database keeps its XML value.
        /// </remarks>
        private static void CopyPublishTimestampsToXml(string inputFile, AllData all, Dictionary<int, DateTime> databasePublishTimestamps)
        {
            Dictionary<int, DateTime> changes = new Dictionary<int, DateTime>();
            foreach (Video v in all.videos)
            {
                if (databasePublishTimestamps.TryGetValue(v.id, out DateTime databaseValue))
                {
                    if (v.publishtimestamp != databaseValue)
                    {
                        changes[v.id] = databaseValue;
                    }
                }
                else if (v.publishtimestamp != null)
                {
                    Console.WriteLine($"Video {v.id} has a publishtimestamp in the XML file but not in the database; keeping the XML file's value.");
                }
            }
            if (changes.Count == 0)
            {
                Console.WriteLine("No publish timestamps to copy to the XML file.");
                return;
            }

            byte[] bytes = File.ReadAllBytes(inputFile);
            bool hasBOM = bytes.Length >= 3 && bytes[0] == 0xEF && bytes[1] == 0xBB && bytes[2] == 0xBF;
            UTF8Encoding encoding = new UTF8Encoding(hasBOM);
            int textStart = hasBOM ? 3 : 0;
            string text = encoding.GetString(bytes, textStart, bytes.Length - textStart);
            string newLine = text.Contains("\r\n") ? "\r\n" : "\n";
            string textWithoutNewLines = text.Replace(newLine, string.Empty);
            if (textWithoutNewLines.Contains('\r') || textWithoutNewLines.Contains('\n'))
            {
                throw new InvalidDataException("The XML file has mixed line endings");
            }
            List<string> lines = new List<string>(text.Split(newLine));

            //find the (0-based) lines holding each changed video's isprivate and publishtimestamp elements
            Dictionary<int, (int isPrivateLine, int? publishTimestampLine)> locations = new Dictionary<int, (int isPrivateLine, int? publishTimestampLine)>();
            XmlReaderSettings settings = new XmlReaderSettings() { IgnoreComments = true, IgnoreWhitespace = true };
            using (XmlReader reader = XmlReader.Create(new StringReader(text), settings))
            {
                IXmlLineInfo lineInfo = (IXmlLineInfo)reader;
                bool inVideo = false;
                string? childName = null;
                string? sID = null;
                int? isPrivateLine = null;
                int? publishTimestampLine = null;
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Depth == 1 && reader.Name == "video")
                    {
                        inVideo = !reader.IsEmptyElement;
                        childName = null;
                        sID = null;
                        isPrivateLine = null;
                        publishTimestampLine = null;
                    }
                    else if (!inVideo)
                    {
                        continue;
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Depth == 2)
                    {
                        childName = reader.Name;
                        if (childName == "isprivate")
                        {
                            isPrivateLine = lineInfo.LineNumber - 1;
                        }
                        else if (childName == "publishtimestamp")
                        {
                            publishTimestampLine = lineInfo.LineNumber - 1;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.Text && reader.Depth == 3 && childName == "id")
                    {
                        sID = reader.Value;
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Depth == 1)
                    {
                        inVideo = false;
                        if (int.TryParse(sID, out int iID) && changes.ContainsKey(iID) && isPrivateLine != null)
                        {
                            locations[iID] = (isPrivateLine.Value, publishTimestampLine);
                        }
                    }
                }
            }
            foreach (int videoID in changes.Keys)
            {
                if (!locations.ContainsKey(videoID))
                {
                    throw new InvalidDataException($"Could not find the isprivate element of video {videoID} in the XML file");
                }
            }

            //edit from the bottom of the file up so that inserting a line doesn't move the lines still to be edited
            foreach (KeyValuePair<int, (int isPrivateLine, int? publishTimestampLine)> location in locations.OrderByDescending(l => l.Value.isPrivateLine))
            {
                int videoID = location.Key;
                int lineIndex = location.Value.publishTimestampLine ?? location.Value.isPrivateLine;
                string elementName = location.Value.publishTimestampLine != null ? "publishtimestamp" : "isprivate";
                string existingLine = lines[lineIndex];
                string trimmedLine = existingLine.TrimStart();
                if (!trimmedLine.StartsWith("<" + elementName + ">") || !trimmedLine.TrimEnd().EndsWith("</" + elementName + ">"))
                {
                    throw new InvalidDataException($"The {elementName} element of video {videoID} must be on a line of its own in the XML file");
                }
                string indent = existingLine.Substring(0, existingLine.Length - trimmedLine.Length);
                string newElementLine = indent + "<publishtimestamp>" + FormatPublishTimestamp(changes[videoID]) + "</publishtimestamp>";
                if (location.Value.publishTimestampLine != null)
                {
                    lines[lineIndex] = newElementLine;
                }
                else
                {
                    lines.Insert(lineIndex + 1, newElementLine);
                }
            }

            File.WriteAllText(inputFile, string.Join(newLine, lines), encoding);
            Console.WriteLine($"Copied {changes.Count} publish timestamps to the XML file.");
        }

        /// <summary>
        /// Adds a parameter with an explicit column type; a null value is sent as SQL NULL.
        /// </summary>
        /// <param name="cmd">command object</param>
        /// <param name="name">parameter name</param>
        /// <param name="type">parameter type</param>
        /// <param name="value">parameter value, with null treated as <see cref="DBNull.Value"/></param>
        private static void AddParameter(NpgsqlCommand cmd, string name, NpgsqlDbType type, object? value)
        {
            cmd.Parameters.Add(name, type).Value = value ?? DBNull.Value;
        }

        private static NpgsqlCommand GetCommand(NpgsqlConnection conn, NpgsqlTransaction tx)
        {
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Transaction = tx;
            return cmd;
        }

        private static string GetCDataNode(XmlElement elem, string prop, string objectType)
        {
            XmlElement? subelem = elem.SelectSingleNode(prop) as XmlElement;
            if (subelem == null) throw new InvalidDataException($"No {objectType} {prop} found");
            XmlCDataSection? cdata = subelem.FirstChild as XmlCDataSection;
            if (cdata == null) throw new InvalidDataException($"No {objectType} {prop} cdata found");
            return cdata.InnerText;
        }

        private static string GetRegularDataElement(XmlElement elem, string prop, string objectType)
        {
            string? s = GetRegularDataElement(elem, prop, objectType, true);
            if (s == null) throw new InvalidDataException("data element is null"); //should never happen
            return (string)s;
        }

        private static string? GetRegularDataElement(XmlElement elem, string prop, string objectType, bool required)
        {
            string? ret = null;
            XmlElement? subelem = elem.SelectSingleNode(prop) as XmlElement;
            if (subelem != null)
            {
                ret = subelem.InnerText;
            }
            else if (required)
            {
                throw new InvalidDataException($"No {objectType} {prop} found");
            }
            return ret;
        }
    }

    internal class InvalidDataException : Exception
    {
        public InvalidDataException(string? msg) : base(msg)
        {
        }
    }

    internal class AllData
    {
        public HashSet<int> documentIDs = new HashSet<int>();
        public HashSet<int> videoIDs = new HashSet<int>();
        public HashSet<int> performerIDs = new HashSet<int>();
        public HashSet<int> rulesOfficialIDs = new HashSet<int>();
        public HashSet<int> rulesUnofficialIDs = new HashSet<int>();
        public HashSet<int> lyricsAnalysisIDs = new HashSet<int>();
        public HashSet<int> copyrightFoundIDs = new HashSet<int>();
        public HashSet<int> copyrightMissingIDs = new HashSet<int>();
        public HashSet<int> complaintIDs = new HashSet<int>();
        public HashSet<int> exceptionlistmembertypeIDs = new HashSet<int>();
        public HashSet<int> exceptionListIDs = new HashSet<int>();
        public HashSet<int> mainlinevideoIDs = new HashSet<int>();
        public HashSet<int> musicvideoIDs = new HashSet<int>();
        public HashSet<int> sillysongvideoIDs = new HashSet<int>();
        public HashSet<int> workvideoIDs = new HashSet<int>();
        public HashSet<int> kidzvideoIDs = new HashSet<int>();
        public HashSet<int> unexplainablevideoIDs = new HashSet<int>();
        public HashSet<int> landingPageIDs = new HashSet<int>();
        public HashSet<int> audioIDs = new HashSet<int>();
        public HashSet<string> exceptionlistmemberIDs = new HashSet<string>();
        public HashSet<int> songIDs = new HashSet<int>();
        public HashSet<string> songDocumentIDs = new HashSet<string>();
        public List<AttachedDocument> attachedDocuments = new List<AttachedDocument>();
        public List<Song> songs = new List<Song>();
        public List<Video> videos = new List<Video>();
        public List<NamedEntity> performers = new List<NamedEntity>();
        public List<RuleOfficial> rulesOfficial = new List<RuleOfficial>();
        public List<RuleUnofficial> rulesUnofficial = new List<RuleUnofficial>();
        public List<LyricsAnalysis> lyricsAnalyses = new List<LyricsAnalysis>();
        public List<Copyright> copyrightsFound = new List<Copyright>();
        public List<Copyright> copyrightsMissing = new List<Copyright>();
        public List<Complaint> complaints = new List<Complaint>();
        public List<MainLineVideo> mainlinevideos = new List<MainLineVideo>();
        public List<MusicVideo> musicvideos = new List<MusicVideo>();
        public List<SillySongVideo> sillysongvideos = new List<SillySongVideo>();
        public List<WorkVideo> workvideos = new List<WorkVideo>();
        public List<KidzVideo> kidzvideos = new List<KidzVideo>();
        public List<UnexplainableVideo> unexplainablevideos = new List<UnexplainableVideo>();
        public List<LandingPage> landingpages = new List<LandingPage>();
        public List<NamedEntity> exceptionListMemberTypes = new List<NamedEntity>();
        public List<ExceptionList> exceptionLists = new List<ExceptionList>();
        public List<Audio> audios = new List<Audio>();

        public Video GetVideoByID(int videoid, string source)
        {
            Video? foundVideo = null;
            foreach (Video v in videos)
            {
                if (v.id == videoid)
                {
                    foundVideo = v;
                    break;
                }
            }
            if (foundVideo == null)
            {
                throw new InvalidDataException($"Invalid {source} video id found: {videoid}");
            }
            return foundVideo;
        }
    }

    internal class KidzVideo : VideoInVideoList
    {
        public KidzVideo(int videoid, AllData allData, int ord)
            : base (videoid, allData, ord, "kidzvideo")
        {
        }
    }

    internal class WorkVideo : VideoInVideoList
    {
        public WorkVideo(int videoid, AllData allData, int ord, string concepts)
            : base(videoid, allData, ord, "workvideo")
        {
            this.concepts = concepts;
        }
        public string concepts { get; set; }
    }

    internal class UnexplainableVideo : VideoInVideoList
    {
        public UnexplainableVideo(int videoid, AllData allData, int ord, string reason)
            : base(videoid, allData, ord, "unexplainablevideo")
        {
            this.reason = reason;
        }
        public string reason { get; set; }
    }

    internal class SillySongVideo : VideoInVideoList
    {
        public SillySongVideo(int videoid, AllData allData, int ord, string number, string rulez, string memes) 
            : base(videoid, allData, ord, "sillysong")
        {
            this.number = number;
            this.rulez = rulez;
            this.memes = memes;
        }

        public string number { get; set; }
        public string rulez { get; set; }
        public string memes { get; set; }
    }

    internal class MainLineVideo : VideoInVideoList
    {
        public MainLineVideo(int videoid, AllData allData, int ord, string episode, string theme, string audience, string majorrulez, string memes, string minorrulez)
            : base(videoid, allData, ord, "mainlinevideo")
        {
            this.episode = episode;
            this.theme = theme;
            this.audience = audience;
            this.majorrulez = majorrulez;
            this.memes = memes;
            this.minorrulez = minorrulez;
        }

        public string episode { get; set; }
        public string theme { get; set; }
        public string audience { get; set; }
        public string majorrulez { get; set; }
        public string memes { get; set; }
        public string minorrulez { get; set; }
    }

    internal class MusicVideo : VideoInVideoList
    {
        public MusicVideo(int videoid, AllData allData, int ord, int performerid, string piece, string author, string setting)
            : base(videoid, allData, ord, "musicvideo")
        {
            NamedEntity? foundPerformer = null;
            foreach (NamedEntity p in allData.performers)
            {
                if (p.id == performerid)
                {
                    foundPerformer = p;
                    break;
                }
            }
            if (foundPerformer == null)
            {
                throw new InvalidDataException("Invalid musicvideo performer found: " + performerid);
            }
            this.piece = piece;
            this.author = author;
            this.setting = setting;
            this.performer = foundPerformer;
        }
        public NamedEntity performer { get; set; }
        public string piece { get; set; }
        public string author { get; set; }
        public string setting { get; set; }
    }

    internal class VideoInVideoList
    {
        public Video video;
        public int ord { get; set; }

        public VideoInVideoList(int videoid, AllData allData, int ord, string source)
        {
            this.video = allData.GetVideoByID(videoid, source);
            this.ord = ord;
        }
    }

    internal class Video
    {
        public Video(int id, string youtubeid, string shortname, string identifier, string owner, bool isprivate, DateTime? publishtimestamp, AttachedDocument? additionalTextDocument, AttachedDocument? MUSXDocument, AttachedDocument? doricoDocument)
        {
            this.id = id;
            this.youtubeid = youtubeid;
            this.shortname = shortname;
            this.identifier = identifier;
            this.owner = owner;
            this.isprivate = isprivate;
            this.publishtimestamp = publishtimestamp;
            this.additionaltextdocument = additionalTextDocument;
            this.musxdocument = MUSXDocument;
            this.doricodocument = doricoDocument;
        }

        public int id { get; set; }
        public string youtubeid { get; set; }
        public string shortname { get; set; }
        public string identifier { get; set; }
        public string owner { get; set; }
        public bool isprivate { get; set; }
        /// <summary>
        /// when the video was published on YouTube, in UTC (<see cref="DateTimeKind.Utc"/>), or null if not known
        /// </summary>
        public DateTime? publishtimestamp { get; set; }
        public AttachedDocument? additionaltextdocument { get; set; }
        public AttachedDocument? musxdocument { get; set; }
        public AttachedDocument? doricodocument { get; set; }
    }

    internal class NamedEntity
    {
        public NamedEntity(int id, int ord, string name)
        {
            this.id = id;
            this.ord = ord;
            this.name = name;
        }
        public int id { get; set; }
        public int ord { get; set; }
        public string name { get; set; }
    }

    internal class LandingPage : NamedEntity
    {
        public LandingPage(int id, int ord, string name, string url) : base(id, ord, name)
        {
            this.url = url;
        }
        public string url { get; set; }
    }

    internal class RuleOfficial
    {
        public RuleOfficial(int id, int ord, string number, string rule, string source, string actualrule, Video? video1, Video? video2, bool video1isadditionaltext)
        {
            this.id = id;
            this.ord = ord;
            this.number = number;
            this.rule = rule;
            this.source = source;
            this.actualrule = actualrule;
            this.video1 = video1;
            this.video2 = video2;
            this.video1isadditionaltext = video1isadditionaltext;
        }
        public int id { get; set; }
        public int ord { get; set; }
        public string number { get; set; }
        public string rule { get; set; }
        public string source { get; set; }
        public string actualrule { get; set; }
        public Video? video1 { get; set; }
        public Video? video2 { get; set; }
        public bool video1isadditionaltext { get; set; }
    }

    internal class RuleUnofficial
    {
        public RuleUnofficial(int id, int ord, string rule, string source, Video? video1, Video? video2, bool video1isadditionaltext)
        {
            this.id = id;
            this.ord = ord;
            this.rule = rule;
            this.source = source;
            this.video1 = video1;
            this.video2 = video2;
            this.video1isadditionaltext = video1isadditionaltext;
        }
        public int id { get; set; }
        public int ord { get; set; }
        public string rule { get; set; }
        public string source { get; set; }
        public Video? video1 { get; set; }
        public Video? video2 { get; set; }
        public bool video1isadditionaltext { get; set; }
    }

    internal class LyricsAnalysis
    {
        public LyricsAnalysis(int id, int ord, Video video, LyricsAnalysisLocation location, bool parody)
        {
            this.id = id;
            this.ord = ord;
            this.video = video;
            this.location = location;
            this.parody = parody;
        }
        public int id { get; set; }
        public int ord { get; set; }
        public Video video { get; set; }
        public LyricsAnalysisLocation location { get; set; }
        public bool parody { get; set; }
    }

    internal class Copyright
    {
        public Copyright(int id, int ord, string song, string copyright, Video video1, Video? video2, Song? songEntity)
        {
            this.id = id;
            this.ord = ord;
            this.song = song;
            this.copyright = copyright;
            this.video1 = video1;
            this.video2 = video2;
            this.songEntity = songEntity;
        }
        public int id { get; set; }
        public int ord { get; set; }
        /// <summary>
        /// song description HTML
        /// </summary>
        public string song { get; set; }
        public string copyright { get; set; }
        public Video video1 { get; set; }
        public Video? video2 { get; set; }
        /// <summary>
        /// the song record this copyright is for; required for copyrights found, and null for copyrights missing
        /// </summary>
        public Song? songEntity { get; set; }
    }

    internal class Song
    {
        public Song(int id, int ord, string title, string author, string? artist, string? copyright, int? copyrightyearstart, int? copyrightyearend, DateOnly? copyrightnoticedate, DateOnly? copyrightregistrationdate, string? copyrightregistrationnumber, CopyrightFlags? copyrightflags, string? personalconnection)
        {
            this.id = id;
            this.ord = ord;
            this.title = title;
            this.author = author;
            this.artist = artist;
            this.copyright = copyright;
            this.copyrightyearstart = copyrightyearstart;
            this.copyrightyearend = copyrightyearend;
            this.copyrightnoticedate = copyrightnoticedate;
            this.copyrightregistrationdate = copyrightregistrationdate;
            this.copyrightregistrationnumber = copyrightregistrationnumber;
            this.copyrightflags = copyrightflags;
            this.personalconnection = personalconnection;
            this.documents = new List<AttachedDocument>();
        }
        public int id { get; set; }
        public int ord { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string? artist { get; set; }
        /// <summary>
        /// copyright holder
        /// </summary>
        public string? copyright { get; set; }
        public int? copyrightyearstart { get; set; }
        /// <summary>
        /// last year of the copyright year range, set only when the copyright year is a range
        /// </summary>
        public int? copyrightyearend { get; set; }
        public DateOnly? copyrightnoticedate { get; set; }
        public DateOnly? copyrightregistrationdate { get; set; }
        public string? copyrightregistrationnumber { get; set; }
        public CopyrightFlags? copyrightflags { get; set; }
        public string? personalconnection { get; set; }
        /// <summary>
        /// MUSX and Dorico documents for the song, saved to the song_documents junction table
        /// </summary>
        public List<AttachedDocument> documents { get; set; }
    }

    internal class Complaint
    {
        public Complaint(int id, int ord, string number, string target, string detail, string source, string comment, Video? video)
        {
            this.id = id;
            this.ord = ord;
            this.number = number;
            this.target = target;
            this.detail = detail;
            this.source = source;
            this.comment = comment;
            this.video = video;
        }

        public int id { get; set; }
        public int ord { get; set; }
        public string number { get; set; }
        public string target { get; set; }
        public string detail { get; set; }
        public string source { get; set; }
        public string comment { get; set; }
        public Video? video { get; set; }
    }

    internal class Audio
    {
        public Audio(int id, int ord, string googledrivefileid, int number, string name, string suggestion)
        {
            this.id = id;
            this.ord = ord;
            this.googledrivefileid = googledrivefileid;
            this.number = number;
            this.name = name;
            this.suggestion = suggestion;
        }
        public int id { get; set; }
        public int ord { get; set; }
        public string googledrivefileid { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public string suggestion { get; set; }
    }

    internal class ExceptionList : NamedEntity
    {
        public ExceptionList(int id, int ord, string name, int videoid, AllData allData, string detail) : base(id, ord, name)
        {
            this.SourceVideo = allData.GetVideoByID(videoid, "exception list");
            this.Members = new List<ExceptionListMember>();
            this.detail = detail;
        }
        /// <summary>
        /// detail HTML
        /// </summary>
        public string detail { get; set; }
        public Video SourceVideo { get; set; }
        public List<ExceptionListMember> Members { get; set; }
    }

    internal class ExceptionListMember
    {
        public ExceptionListMember(int ord, string name, int videoid, AllData allData, int categoryid)
        {
            this.ord = ord;
            this.name = name;
            this.SourceVideo = allData.GetVideoByID(videoid, "exception list member");
            foreach (NamedEntity ne in allData.exceptionListMemberTypes)
            {
                if (ne.id == categoryid)
                {
                    this.Category = ne;
                    break;
                }
            }
            if (this.Category == null)
            {
                throw new InvalidDataException("No category found for exception list member");
            }
        }
        public int ord { get; set; }
        public string name { get; set; }
        public Video SourceVideo { get; set; }
        public NamedEntity Category { get; set; }
    }

    public enum DocumentType
    {
        AdditionalTextFile = 1,
        MUSX = 2,
        Dorico = 3,
    }

    [Flags]
    public enum DocumentPurpose
    {
        None = 0,
        Transcript = 1,
        Commentary = 2
    }

    [Flags]
    public enum CopyrightFlags
    {
        None = 0,
        AllRightsReserved = 1,
        InternationalCopyrightSecured = 2,
        PublicDomain = 4,
    }

    public enum LyricsAnalysisLocation
    {
        VideoDescription = 1,
        Commentary = 2,
    }

    public class AttachedDocument
    {
        public AttachedDocument(int id, int ord, DocumentType type, DocumentPurpose purpose, string googledrivefileid, bool? supportsplayback)
        {
            this.id = id;
            this.ord = ord;
            this.type = type;
            this.purpose = purpose;
            this.googledrivefileid = googledrivefileid;
            this.supportsplayback = supportsplayback;
        }

        public int id { get; set; }
        public int ord { get; set; }
        public DocumentType type { get; set; }
        public DocumentPurpose purpose { get; set; }
        /// <summary>
        /// google drive file id for additional text document, MUSX file or Dorico file
        /// </summary>
        public string googledrivefileid { get; set; }
        /// <summary>
        /// whether a MUSX or Dorico document supports playback; null if unknown or not applicable
        /// </summary>
        public bool? supportsplayback { get; set; }
    }
}
