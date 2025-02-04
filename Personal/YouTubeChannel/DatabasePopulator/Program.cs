using Npgsql;
using System.Text;
using System.Xml;
namespace DatabasePopulator
{
    internal class Program
    {
        static int Main(string[] args)
        {
            int requiredArgsCount = 2;
            if (args == null || args.Length < requiredArgsCount)
            {
                Console.Error.WriteLine(requiredArgsCount + " arguments are required.");
                return -1;
            }
            string sInputFile = args[0];
            if (string.IsNullOrEmpty(sInputFile))
            {
                Console.Error.WriteLine("No input file specified.");
                return -1;
            }
            if (!File.Exists(sInputFile))
            {
                Console.Error.WriteLine("File does not exist: " + sInputFile);
                return -1;
            }
            string sDatabaseName = args[1];
            if (string.IsNullOrEmpty(sDatabaseName))
            {
                Console.Error.WriteLine("No database name specified.");
                return -1;
            }
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(sInputFile);
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

            AllData all = new AllData();

            bool local = true;
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
            string p = "ToiletDrawHind939";
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
                int iID, iOrd, iVideoID;

                foreach (XmlNode nextNode in docElementVal.ChildNodes)
                {
                    if (!CheckForValidXmlElement(nextNode)) continue;
                    XmlElement nextElement = (XmlElement)nextNode;
                    string nodeName = nextElement.Name;
                    if (nodeName == "document")
                    {
                        iID = GetObjectID(nextElement, "document");
                        string sType = GetRegularDataElement(nextElement, "type", "document");
                        string sPurpose = GetRegularDataElement(nextElement, "purpose", "document");
                        string sGoogleDriveFileID = GetRegularDataElement(nextElement, "googledrivefileid", "document");
                        string sComment = GetRegularDataElement(nextElement, "comment", "document");
                        if (string.IsNullOrEmpty(sComment))
                        {
                            throw new InvalidDataException("Documents must currently have a comment");
                        }
                        if (string.IsNullOrEmpty(sGoogleDriveFileID))
                        {
                            throw new InvalidDataException("Documents must have a URL");
                        }
                        if (!Enum.TryParse(sType, out DocumentType eDocType))
                        {
                            throw new InvalidDataException("Invalid document type: " + sType);
                        }
                        if (!Enum.TryParse(sPurpose, out DocumentPurpose eDocPurpose))
                        {
                            throw new InvalidDataException("Invalid document purpose: " + sPurpose);
                        }
                        if (eDocType == DocumentType.MUSX)
                        {
                            if (eDocPurpose != DocumentPurpose.None)
                            {
                                throw new InvalidDataException("MUSX documents should not have a purpose");
                            }
                        }
                        else if (eDocType == DocumentType.AdditionalTextFile)
                        {
                            if (eDocPurpose == DocumentPurpose.None)
                            {
                                throw new InvalidDataException("Additional text document missing purpose");
                            }
                        }
                        else
                        {
                            throw new InvalidDataException("Invalid document type: " + sType);
                        }

                        all.attachedDocuments.Add(new AttachedDocument(iID, eDocType, eDocPurpose, sGoogleDriveFileID));
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
                            throw new InvalidDataException("Invalid video isprivate value: " + sIsPrivate);
                        }
                        string? sAdditionalTextDocID = GetRegularDataElement(nextElement, "additionaltextdocumentid", "video", false);
                        string? sMUSXDocID = GetRegularDataElement(nextElement, "musxdocumentid", "video", false);
                        AttachedDocument? additionalTextDoc = FindAttachedDocument(all, sAdditionalTextDocID, usedDocuments);
                        AttachedDocument? musxDoc = FindAttachedDocument(all, sMUSXDocID, usedDocuments);
                        all.videos.Add(new Video(iID, sYoutubeID, sShortName, sIdentifier, sOwner, bIsPrivate, additionalTextDoc, musxDoc));
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
                            throw new InvalidDataException("Invalid lyricsanalysis video id: " + sVideoID);
                        }
                        if (!Enum.TryParse(sLocation, out LyricsAnalysisLocation loc))
                        {
                            throw new InvalidDataException("Invalid lyricsanalysis location: " + sLocation);
                        }
                        if (!bool.TryParse(sParody, out bool bParody))
                        {
                            throw new InvalidDataException("Invalid lyricsanalysis parody: " + sParody);
                        }
                        if (loc != LyricsAnalysisLocation.VideoDescription && loc != LyricsAnalysisLocation.Commentary)
                        {
                            throw new InvalidDataException("Invalid lyricsanalysis location value: " + loc.ToString());
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
                                throw new InvalidDataException("Invalid complaint video id: " + sVideoID);
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
                    else
                    {
                        throw new InvalidDataException("Invalid data type: " + nodeName);
                    }
                }
                if (usedDocuments.Count != all.attachedDocuments.Count)
                {
                    throw new InvalidDataException("Mismatch between attached documents and usage of documents in primary videos: " + usedDocuments.Count + "," + all.attachedDocuments.Count);
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
            ncsb.Password = p;
            ncsb.Database = sDatabaseName;

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
                        GetIDs(conn, tx, "documents", all.documentIDs, "id");
                        GetIDs(conn, tx, "videos", all.videoIDs, "id");
                        GetIDs(conn, tx, "videolist_mainline", all.mainlinevideoIDs, "videoid");
                        GetIDs(conn, tx, "videolist_sillysongs", all.sillysongvideoIDs, "videoid");
                        GetIDs(conn, tx, "videolist_workvideos", all.workvideoIDs, "videoid");
                        GetIDs(conn, tx, "videolist_kidzvideos", all.kidzvideoIDs, "videoid");
                        GetIDs(conn, tx, "videolist_unexplainablevideos", all.unexplainablevideoIDs, "videoid");
                        GetIDs(conn, tx, "videolist_musicvideos", all.musicvideoIDs, "videoid");
                        GetIDs(conn, tx, "exception_list_member_types", all.exceptionlistmembertypeIDs, "id");
                        GetIDs(conn, tx, "exception_lists", all.exceptionListIDs, "id");
                        GetIDs2(conn, tx, "exception_list_members", all.exceptionlistmemberIDs, "exceptionlistid", "ord");
                        SaveData(all, conn, tx);
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        Console.Error.WriteLine("Transaction rolled back: " + ex.ToString());
                        return -1;
                    }
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
                throw new InvalidDataException("Invalid " + objectType + "  video 1 is additional text: " + sVideo1IsAdditionalText);
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
                    throw new InvalidDataException("Invalid " + objectType + " video id 1: " + sVideoID1);
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
                    throw new InvalidDataException("Invalid " + objectType + " video id 2: " + sVideoID2);
                }
            }
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
                throw new InvalidDataException("Invalid " + objectType + " video id 1: " + sVideoID1);
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
                    throw new InvalidDataException("Invalid " + objectType + " video id 2: " + sVideoID2);
                }
            }
            copyrightList.Add(new Copyright(iID, iOrd, sSong, sCopyright, v1, v2));
        }

        private static AttachedDocument? FindAttachedDocument(AllData all, string? docid, HashSet<int>? usedIDs)
        {
            if (string.IsNullOrEmpty(docid))
            {
                return null;
            }
            if (!int.TryParse(docid, out int iDocID))
            {
                throw new InvalidDataException("Invalid document ID: " + docid);
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
                throw new InvalidDataException("Did not find document: " + docid);
            }
            if (usedIDs != null)
            {
                if (usedIDs.Contains(found.id))
                {
                    throw new InvalidDataException("Document used primarily multiple times: " + docid);
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
                throw new InvalidDataException("Invalid XML node type found: " + node.NodeType.ToString());
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
                        throw new InvalidDataException("Invalid exception list id specified: " + nextElement.InnerText);
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
                        throw new InvalidDataException("Invalid exception list video id: " + nextElement.InnerText);
                    }
                }
                else if (elemName == "member")
                {
                    string sCategoryID = string.Empty;
                    string sName = string.Empty;
                    string sVideoID = string.Empty;
                    foreach (XmlNode propNode in nextElement.ChildNodes)
                    {
                        if (!CheckForValidXmlElement(nextNode)) continue;
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
                            throw new InvalidDataException("Invalid exception list property: " + propName);
                        }
                    }
                    if (string.IsNullOrEmpty(sCategoryID)) throw new InvalidDataException("Exception list member missing category ID");
                    if (string.IsNullOrEmpty(sName)) throw new InvalidDataException("Exception list member missing name");
                    if (string.IsNullOrEmpty(sVideoID)) throw new InvalidDataException("Exception list member missing video id");
                    int iCategoryID;
                    if (!int.TryParse(sCategoryID, out iCategoryID))
                    {
                        throw new InvalidDataException("Invalid exception list member category: " + sCategoryID);
                    }
                    int iVideoID;
                    if (!int.TryParse(sVideoID, out iVideoID))
                    {
                        throw new InvalidDataException("Invalid exception list member video " + sVideoID);
                    }
                    ++iMemberORD;
                    members.Add(new ExceptionListMember(iMemberORD, sName, iVideoID, all, iCategoryID));
                }
                else
                {
                    throw new InvalidDataException("Invalid exception list member " + elemName);
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
                throw new InvalidDataException("Exception list has no members: " + sExceptionListName);
            }
            if (iExceptionListVideoID <= 0)
            {
                throw new InvalidDataException("Invalid exception list video ID: " + iExceptionListVideoID);
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
                    string sMUSXDoc = GetRegularDataElement(nextElement, "musxdocumentid", "video list unexplainablevideo musx document id");
                    AttachedDocument? musxdoc = FindAttachedDocument(all, sMUSXDoc, null);
                    all.unexplainablevideos.Add(new UnexplainableVideo(iVideoID, all, iOrd, sReason, musxdoc));
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
                throw new InvalidDataException("No " + objecttype + " id found");
            }
            string innerText = elem.InnerText;
            if (!int.TryParse(innerText, out int val))
            {
                throw new InvalidDataException("Invalid " + objecttype + " id: " + innerText);
            }
            return val; ;
        }

        private static int GetForeignKeyID(XmlElement nextElement, string objecttype, string elementName)
        {
            XmlElement? elem = nextElement.SelectSingleNode(elementName) as XmlElement;
            if (elem == null)
            {
                throw new InvalidDataException("No " + objecttype + " found");
            }
            string innerText = elem.InnerText;
            if (!int.TryParse(innerText, out int val))
            {
                throw new InvalidDataException("Invalid " + objecttype + ": " + innerText);
            }
            return val;
        }

        private static void SaveData(AllData all, NpgsqlConnection conn, NpgsqlTransaction tx)
        {
            int iID;
            bool updateRecord;
            string insertStatement;
            string updateStatement;
            List<string> idCols;
            List<string> dataCols;

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "doctype", "purpose", "googledrivefileid" };
            updateStatement = GenerateSQLStatement("documents", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("documents", idCols, dataCols, false);
            foreach (AttachedDocument d in all.attachedDocuments)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = d.id;
                    cmd.Parameters.AddWithValue("@id", iID);
                    cmd.Parameters.AddWithValue("@doctype", Convert.ToInt32(d.type));
                    cmd.Parameters.AddWithValue("@purpose", Convert.ToInt32(d.purpose));
                    cmd.Parameters.AddWithValue("@googledrivefileid", d.googledrivefileid);
                    updateRecord = all.documentIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.documentIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "documents", all.documentIDs, idCols);

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "youtubeid", "shortname", "identifier", "owner", "isprivate", "additionaltextdocumentid", "musxdocumentid" };
            updateStatement = GenerateSQLStatement("videos", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("videos", idCols, dataCols, false);
            foreach (Video v in all.videos)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = v.id;
                    cmd.Parameters.AddWithValue("@id", iID);
                    cmd.Parameters.AddWithValue("@youtubeid", v.youtubeid);
                    cmd.Parameters.AddWithValue("@shortname", v.shortname);
                    cmd.Parameters.AddWithValue("@identifier", v.identifier);
                    cmd.Parameters.AddWithValue("@owner", v.owner);
                    cmd.Parameters.AddWithValue("@isprivate", v.isprivate);
                    if (v.additionaltextdocument == null)
                        cmd.Parameters.AddWithValue("@additionaltextdocumentid", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@additionaltextdocumentid", v.additionaltextdocument.id);
                    if (v.musxdocument == null)
                        cmd.Parameters.AddWithValue("@musxdocumentid", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@musxdocumentid", v.musxdocument.id);
                    updateRecord = all.videoIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.videoIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "videos", all.videoIDs, idCols);

            idCols = new List<string>() { "id" };
            dataCols = new List<string>() { "name", "ord" };
            updateStatement = GenerateSQLStatement("performers", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("performers", idCols, dataCols, false);
            foreach (NamedEntity p in all.performers)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = p.id;
                    cmd.Parameters.AddWithValue("@id", iID);
                    cmd.Parameters.AddWithValue("@ord", p.ord);
                    cmd.Parameters.AddWithValue("@name", p.name);
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
                    cmd.Parameters.AddWithValue("@id", iID);
                    cmd.Parameters.AddWithValue("@ord", r.ord);
                    cmd.Parameters.AddWithValue("@number", r.number);
                    cmd.Parameters.AddWithValue("@rule", r.rule);
                    cmd.Parameters.AddWithValue("@source", r.source);
                    cmd.Parameters.AddWithValue("@actualrule", r.actualrule);
                    if (r.video1 != null)
                        cmd.Parameters.AddWithValue("@videoid1", r.video1.id);
                    else
                        cmd.Parameters.AddWithValue("@videoid1", DBNull.Value);
                    if (r.video2 != null)
                        cmd.Parameters.AddWithValue("@videoid2", r.video2.id);
                    else
                        cmd.Parameters.AddWithValue("@videoid2", DBNull.Value);
                    cmd.Parameters.AddWithValue("@video1isadditionaltext", r.video1isadditionaltext);
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
                    cmd.Parameters.AddWithValue("@id", iID);
                    cmd.Parameters.AddWithValue("@ord", r.ord);
                    cmd.Parameters.AddWithValue("@rule", r.rule);
                    cmd.Parameters.AddWithValue("@source", r.source);
                    if (r.video1 != null)
                        cmd.Parameters.AddWithValue("@videoid1", r.video1.id);
                    else
                        cmd.Parameters.AddWithValue("@videoid1", DBNull.Value);
                    if (r.video2 != null)
                        cmd.Parameters.AddWithValue("@videoid2", r.video2.id);
                    else
                        cmd.Parameters.AddWithValue("@videoid2", DBNull.Value);
                    cmd.Parameters.AddWithValue("@video1isadditionaltext", r.video1isadditionaltext);
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
                    cmd.Parameters.AddWithValue("@id", iID);
                    cmd.Parameters.AddWithValue("@ord", la.ord);
                    cmd.Parameters.AddWithValue("@videoid", la.video.id);
                    cmd.Parameters.AddWithValue("@location", Convert.ToInt32(la.location));
                    cmd.Parameters.AddWithValue("@isparody", la.parody);
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
                    cmd.Parameters.AddWithValue("@id", iID);
                    cmd.Parameters.AddWithValue("@ord", elmt.ord);
                    cmd.Parameters.AddWithValue("@name", elmt.name);
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
                    cmd.Parameters.AddWithValue("@id", iID);
                    cmd.Parameters.AddWithValue("@ord", lp.ord);
                    cmd.Parameters.AddWithValue("@name", lp.name);
                    cmd.Parameters.AddWithValue("@url", lp.url);
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
                    cmd.Parameters.AddWithValue("@id", iID);
                    cmd.Parameters.AddWithValue("@ord", c.ord);
                    cmd.Parameters.AddWithValue("@number", c.number);
                    cmd.Parameters.AddWithValue("@target", c.target);
                    cmd.Parameters.AddWithValue("@detail", c.detail);
                    cmd.Parameters.AddWithValue("@source", c.source);
                    cmd.Parameters.AddWithValue("@comment", c.comment);
                    if (c.video == null)
                        cmd.Parameters.AddWithValue("@videoid", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@videoid", c.video.id);
                    updateRecord = all.complaintIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.complaintIDs.Remove(iID);
                }
            }
            DeleteIDs(conn, tx, "complaints", all.complaintIDs, idCols);

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
                    cmd.Parameters.AddWithValue("@videoid", iVideoID);
                    cmd.Parameters.AddWithValue("@ord", v.ord);
                    cmd.Parameters.AddWithValue("@episode", v.episode);
                    cmd.Parameters.AddWithValue("@theme", v.theme);
                    cmd.Parameters.AddWithValue("@audience", v.audience);
                    cmd.Parameters.AddWithValue("@majorrulez", v.majorrulez);
                    cmd.Parameters.AddWithValue("@memes", v.memes);
                    cmd.Parameters.AddWithValue("@minorrulez", v.minorrulez);
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
                    cmd.Parameters.AddWithValue("@videoid", iVideoID);
                    cmd.Parameters.AddWithValue("@ord", p.ord);
                    cmd.Parameters.AddWithValue("@performerid", p.performer.id);
                    cmd.Parameters.AddWithValue("@piece", p.piece);
                    cmd.Parameters.AddWithValue("@author", p.author);
                    cmd.Parameters.AddWithValue("@setting", p.setting);
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
                    cmd.Parameters.AddWithValue("@videoid", iVideoID);
                    cmd.Parameters.AddWithValue("@ord", v.ord);
                    cmd.Parameters.AddWithValue("@number", v.number);
                    cmd.Parameters.AddWithValue("@rulez", v.rulez);
                    cmd.Parameters.AddWithValue("@memes", v.memes);
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
                    cmd.Parameters.AddWithValue("@videoid", iVideoID);
                    cmd.Parameters.AddWithValue("@ord", v.ord);
                    cmd.Parameters.AddWithValue("@concepts", v.concepts);
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
                    cmd.Parameters.AddWithValue("@videoid", iVideoID);
                    cmd.Parameters.AddWithValue("@ord", v.ord);
                    updateRecord = all.kidzvideoIDs.Contains(iVideoID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.kidzvideoIDs.Remove(iVideoID);
                }
            }
            DeleteIDs(conn, tx, "videolist_kidzvideos", all.kidzvideoIDs, idCols);

            idCols = new List<string>() { "videoid" };
            dataCols = new List<string>() { "ord", "reason", "musxdocumentid" };
            updateStatement = GenerateSQLStatement("videolist_unexplainablevideos", idCols, dataCols, true);
            insertStatement = GenerateSQLStatement("videolist_unexplainablevideos", idCols, dataCols, false);
            foreach (UnexplainableVideo v in all.unexplainablevideos)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iVideoID = v.video.id;
                    cmd.Parameters.AddWithValue("@videoid", iVideoID);
                    cmd.Parameters.AddWithValue("@ord", v.ord);
                    cmd.Parameters.AddWithValue("@reason", v.reason);
                    if (v.musxdocument != null)
                        cmd.Parameters.AddWithValue("@musxdocumentid", v.musxdocument.id);
                    else
                        cmd.Parameters.AddWithValue("@musxdocumentid", DBNull.Value);
                    updateRecord = all.unexplainablevideoIDs.Contains(iVideoID);
                    cmd.CommandText = updateRecord ? updateStatement : insertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.unexplainablevideoIDs.Remove(iVideoID);
                }
            }
            DeleteIDs(conn, tx, "videolist_unexplainablevideos", all.unexplainablevideoIDs, idCols);
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
                    cmd.Parameters.AddWithValue("@id", iID);
                    cmd.Parameters.AddWithValue("@ord", nextExList.ord);
                    cmd.Parameters.AddWithValue("@name", nextExList.name);
                    cmd.Parameters.AddWithValue("@videoid", nextExList.SourceVideo.id);
                    cmd.Parameters.AddWithValue("@detail", nextExList.detail);
                    updateRecord = all.exceptionListIDs.Contains(iID);
                    cmd.CommandText = updateRecord ? exceptionlistupdateStatement : exceptionlistinsertStatement;
                    cmd.ExecuteNonQuery();
                    if (updateRecord) all.exceptionListIDs.Remove(iID);
                }
                foreach (ExceptionListMember member in nextExList.Members)
                {
                    using (NpgsqlCommand cmd = GetCommand(conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@exceptionlistid", nextExList.id);
                        cmd.Parameters.AddWithValue("@ord", member.ord);
                        cmd.Parameters.AddWithValue("@categoryid", member.Category.id);
                        cmd.Parameters.AddWithValue("@videoid", member.SourceVideo.id);
                        cmd.Parameters.AddWithValue("@name", member.name);
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
            string updateStatement = GenerateSQLStatement(table, idCols, dataCols, true);
            string insertStatement = GenerateSQLStatement(table, idCols, dataCols, false);
            foreach (Copyright c in lst)
            {
                int iID;
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    iID = c.id;
                    cmd.Parameters.AddWithValue("@id", iID);
                    cmd.Parameters.AddWithValue("@ord", c.ord);
                    cmd.Parameters.AddWithValue("@song", c.song);
                    cmd.Parameters.AddWithValue("@copyright", c.copyright);
                    cmd.Parameters.AddWithValue("@videoid1", c.video1.id);
                    if (c.video2 == null)
                        cmd.Parameters.AddWithValue("@videoid2", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@videoid2", c.video2.id);
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
                    cmd.CommandText = "DELETE FROM " + table + " WHERE " + idCol1 + " = " + idValues[0] + " AND " + idCol2 + " = " + idValues[1];
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void DeleteIDs(NpgsqlConnection conn, NpgsqlTransaction tx, string table, HashSet<int> ids, List<string> idCols)
        {
            if (idCols.Count != 1)
            {
                throw new InvalidDataException("expected a single id column, got " + idCols.Count + " id columns.");
            }
            string idCol = idCols[0];
            foreach (int deleteid in ids)
            {
                using (NpgsqlCommand cmd = GetCommand(conn, tx))
                {
                    cmd.CommandText = "DELETE FROM " + table + " WHERE " + idCol + " = " + deleteid;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void GetIDs2(NpgsqlConnection conn, NpgsqlTransaction tx, string table, HashSet<string> ids, string idCol1, string idCol2)
        {
            using (NpgsqlCommand cmd = GetCommand(conn, tx))
            {
                string sCmd = "SELECT " + idCol1 + "," + idCol2 + " FROM " + table;
                cmd.CommandText = sCmd;
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids.Add(Convert.ToInt32(reader[0]) + "," + Convert.ToInt32(reader[1]));
                    }
                }
            }
        }

        private static void GetIDs(NpgsqlConnection conn, NpgsqlTransaction tx, string table, HashSet<int> ids, string idCol)
        {
            using (NpgsqlCommand cmd = GetCommand(conn, tx))
            {
                string sCmd = "SELECT " + idCol + " FROM " + table;
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

        private static NpgsqlCommand GetCommand(NpgsqlConnection conn, NpgsqlTransaction tx)
        {
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Transaction = tx;
            return cmd;
        }

        private static string GetCDataNode(XmlElement elem, string prop, string objectType)
        {
            XmlElement? subelem = elem.SelectSingleNode(prop) as XmlElement;
            if (subelem == null) throw new InvalidDataException("No " + objectType + " " + prop + " found");
            XmlCDataSection? cdata = subelem.FirstChild as XmlCDataSection;
            if (cdata == null) throw new InvalidDataException("No " + objectType + " " + prop + " cdata found");
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
            XmlElement? subelem = elem.SelectSingleNode(prop) as XmlElement;
            if (subelem == null)
            {
                if (required)
                {
                    throw new InvalidDataException("No " + objectType + " " + prop + " found");
                }
                else
                {
                    return null;
                }
            }
            return subelem.InnerText;
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
        public HashSet<string> exceptionlistmemberIDs = new HashSet<string>();
        public List<AttachedDocument> attachedDocuments = new List<AttachedDocument>();
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
                throw new InvalidDataException("Invalid " + source + " video id found: " + videoid);
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
        public UnexplainableVideo(int videoid, AllData allData, int ord, string reason, AttachedDocument? musxdocument)
            : base(videoid, allData, ord, "unexplainablevideo")
        {
            this.reason = reason;
            this.musxdocument = musxdocument;
        }
        public string reason { get; set; }
        public AttachedDocument? musxdocument { get; set; }
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
        public Video(int id, string youtubeid, string shortname, string identifier, string owner, bool isprivate, AttachedDocument? additionalTextDocument, AttachedDocument? MUSXDocument)
        {
            this.id = id;
            this.youtubeid = youtubeid;
            this.shortname = shortname;
            this.identifier = identifier;
            this.owner = owner;
            this.isprivate = isprivate;
            this.additionaltextdocument = additionalTextDocument;
            this.musxdocument = MUSXDocument;
        }

        public int id { get; set; }
        public string youtubeid { get; set; }
        public string shortname { get; set; }
        public string identifier { get; set; }
        public string owner { get; set; }
        public bool isprivate { get; set; }
        public AttachedDocument? additionaltextdocument { get; set; }
        public AttachedDocument? musxdocument { get; set; }
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
        public Copyright(int id, int ord, string song, string copyright, Video video1, Video? video2)
        {
            this.id = id;
            this.ord = ord;
            this.song = song;
            this.copyright = copyright;
            this.video1 = video1;
            this.video2 = video2;
        }
        public int id { get; set; }
        public int ord { get; set; }
        public string song { get; set; }
        public string copyright { get; set; }
        public Video video1 { get; set; }
        public Video? video2 { get; set; }
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
    }

    [Flags]
    public enum DocumentPurpose
    {
        None = 0,
        Transcript = 1,
        Commentary = 2
    }

    public enum LyricsAnalysisLocation
    {
        VideoDescription = 1,
        Commentary = 2,
    }

    public class AttachedDocument
    {
        public AttachedDocument(int id, DocumentType type, DocumentPurpose purpose, string googledrivefileid)
        {
            this.id = id;
            this.type = type;
            this.purpose = purpose;
            this.googledrivefileid = googledrivefileid;
        }

        public int id { get; set; }
        public DocumentType type { get; set; }
        public DocumentPurpose purpose { get; set; }
        /// <summary>
        /// google drive file id for additional text document or MUSX file
        /// </summary>
        public string googledrivefileid { get; set; }
    }
}
