using Existence.Beyond.Infrastructure;
using Existence.Earth.Alphabet;
using Existence.Earth.Countries;
using Existence.Earth.Countries.UnitedStates;
using Existence.Earth.Countries.UnitedStates.States;
using Existence.Earth.FieldsOfStudy.Astrology;
using Existence.Earth.Human;
using Existence.Earth.Human.People;
using Existence.Personal;
using Existence.Personal.Employment;
using Existence.Time;
using System.Collections.Generic;
using System.ComponentModel;

namespace Existence.Beyond.ThumbOnTheScale
{
    [IsReleased(false)]
    internal class ThumbOnTheScaleAprilFoolsDay2025WisconsinElection
    {
        public class VotingHistory
        {
            public VotingHistory()
            {
                MyPoliticalPhilosophy2 libertarianPoliticalPhilosophy = new MyPoliticalPhilosophy2(PoliticalPhilosophies.Libertarian);
                BallotInitiativeVote1 extendRightToVoteInFederalElectionsToChildrenOfUSCitizensLivingAbroadWhoFormerlyResidedInWisconsin =
                    new BallotInitiativeVote1((int)ReferendumChoice.Yes, "Wisconsin LRSS Question 1", true);
                USPresidentVote1 firstUSPresidentVote = new USPresidentVote1((int)UnitedStatesPoliticians.BrowneHarry, "2000 General Election", false);
                USPresidentVote2 secondUSPresidentVote = new USPresidentVote2((int)UnitedStatesPoliticians.PaulRon, "2008 Republican Primary", false);
                USPresidentVote3 thirdUSPresidentVote = new USPresidentVote3((int)UnitedStatesPoliticians.JohnsonGary, "2012 General Election", false);
                USPresidentVote4 fourthUSPresidentVote = new USPresidentVote4((int)UnitedStatesPoliticians.JohnsonGary, "2016 General Election", false);
                GaveMoneyToPresidentialCampaign gaveMoneyToUSPresidentCampaign = new GaveMoneyToPresidentialCampaign((int)UnitedStatesPoliticians.TrumpDonald, "Small Donation", true);
                HighSchoolGraduation highSchoolGraduation = new HighSchoolGraduation();
                OrderedEvents notVotes = new OrderedEvents(null, new List<BaseEvent>()
                {
                    new USPresidentNotVote1((int)UnitedStatesPoliticians.TsongasPaul, "Sixth Grade Primary Choice", false),
                    new HighSchoolNotVote(null, "Class President", false),
                    new HighSchoolNotVote((int)UnitedStatesPoliticians.DoleBob, "Standardized Test Propaganda", false),
                    new HighSchoolVote((int)ClassmateList.PaulMartinski, "Prom or Homecoming King/Queen", false),
                    new HighSchoolGraduation(),
                    new AllInFavorOfKillingJasonSchlakeSayAye(),
                    new WikipediaNotVote((int)PeopleEnumerated.DuninElonka, "Request for Adminship", false),
                });
                OrderedEvents votesAndPoliticalPhilosophy = new OrderedEvents(null, new List<BaseEvent>()
                {
                    new MyPoliticalPhilosophy1(PoliticalPhilosophies.Conservative),
                    libertarianPoliticalPhilosophy,
                    firstUSPresidentVote,
                    extendRightToVoteInFederalElectionsToChildrenOfUSCitizensLivingAbroadWhoFormerlyResidedInWisconsin,
                    new BallotInitiativeVote2((int)ReferendumChoice.No, "Campaign Finance Reform Question", false),
                    secondUSPresidentVote,
                    thirdUSPresidentVote,
                    new WorkVote((int)Coworkers.NickVavra, "Swiss Army Knife Award", false),
                    gaveMoneyToUSPresidentCampaign,
                    fourthUSPresidentVote,
                });
                OrderedEvents votesThatWereMistakes = new OrderedEvents(firstUSPresidentVote, new List<BaseEvent>()
                {
                    extendRightToVoteInFederalElectionsToChildrenOfUSCitizensLivingAbroadWhoFormerlyResidedInWisconsin,
                    thirdUSPresidentVote,
                    fourthUSPresidentVote
                });
                OrderedEvents votesThatWereNotMistakes = new OrderedEvents(libertarianPoliticalPhilosophy, new List<BaseEvent>()
                {
                    firstUSPresidentVote,
                    secondUSPresidentVote,
                    gaveMoneyToUSPresidentCampaign
                });
            }

            /// <summary>
            /// this is from sixth grade when discussing the election in a primary context. There was
            /// no formal vote taken - we just chose our preferred candidate. I mention this not because
            /// it was super important to my political development, I chose the candidate based on his
            /// focus on health care, which was a fairly superficial and suggests a liberal lean.
            /// By the time I understood what "liberal" was, I had outgrown it.
            /// </summary>
            [Year(1992)]
            public class USPresidentNotVote1 : VoteEvent
            {
                public USPresidentNotVote1(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }

            /// <summary>
            /// I don't believe I ever voted for high school class president. I didn't think it mattered.
            /// Winners: Abby Joyce (x2), Jess Graham, Josh Rybaski
            /// </summary>
            [YearRange(1995, 1999)]
            public class HighSchoolNotVote : VoteEvent
            {
                public HighSchoolNotVote(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }

            /// <summary>
            /// this refers to an incident where, in taking a standardized test (trivially easy for me
            /// otherwise), I defaced the test booklet with "Vote Bob Dole" admonishments and propaganda.
            /// I was even hauled into the principal's office for this (the only time this happened in
            /// high school). I told the principal to send it in, and as far as I know that's what happened.
            /// I will never know if any person involved with test processing noticed it at all.
            /// </summary>
            [Year(1996)]
            public class USPresidentNotVote2 : VoteEvent
            {
                public USPresidentNotVote2(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }


            /// <summary>
            /// Conservatism:
            /// 1. Conservatives got control of the US legislative branches for the first time in a long while.
            /// 2. In sophomore US History class (Steffen) said something nice about
            /// Ronald Reagan and was accused of being a conservative, which made me
            /// consider and become a conservative.
            /// 3. Sometimes watched Rush Limbaugh's TV show (aired 1992-1996)
            /// 4. Defaced high school standardized test with "Vote Bob Dole" notes
            /// </summary>
            [YearDate(1996)]
            public class MyPoliticalPhilosophy1 : PoliticalPhilosophyEvent
            {
                public MyPoliticalPhilosophy1(PoliticalPhilosophies Philosophy) : base(Philosophy, "Was a Conservative for a Time")
                {
                    this.Philosophy = Philosophy;
                }
            }

            /// <summary>
            /// My political philosophy was greatly influenced by South Park which began airing
            /// August 1997. I didn't watch the first few episodes, but I believe I was watching
            /// them up-to-date by the time the Halloween episode (Pink-eye) aired 1997-10-29.
            /// </summary>
            [YearRange(1997, 1998)]
            public class MyPoliticalPhilosophy2 : PoliticalPhilosophyEvent
            {
                public MyPoliticalPhilosophy2(PoliticalPhilosophies Philosophy) : base(Philosophy, "Became Libertarian")
                {
                }
            }

            /// <summary>
            /// I didn't understand the procedure where boys voted for the queen
            /// and girls voted for the king, I incorrectly thought everyone voted
            /// for everybody. I don't remember the female I voted for, but I know
            /// the male I wasn't supposed to vote for (it was a joke). I don't even remember
            /// who won the elections, or even if it as prom or homecoming. I have never thought this mattered.
            /// </summary>
            [Year(1998)]
            public class HighSchoolVote : VoteEvent
            {
                public HighSchoolVote(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }

            /// <summary>
            /// my mother's photos are a bit ambiguous between 5/28 and 5/29, but 5/28 was a Friday and
            /// there is an Empire Photo (Madison, WI) that says the date is 5/28
            /// </summary>
            [YearDate(1999, 5, 28)]
            public class HighSchoolGraduation : BaseEvent
            {
                public HighSchoolGraduation() : base("High School Graduation") { }
            }

            /// <summary>
            /// not sure exactly when I created this one, but it was after I was out of high school so
            /// after any tenuous connection with the target had been severed.
            /// </summary>
            [MusicNotesRepositoryAudioFile(@"Released\Audio\007-AllInFavorOfKillingJasonSchlakeSayAye.wav", PeopleEnumerated.RoweChris)]
            [MusicNotesRepositoryMeaningFile(@"Released\SongMeaning\012-AllInFavorOfKillingJasonSchlakeSayAye.txt", PeopleEnumerated.RoweChris)]
            public class AllInFavorOfKillingJasonSchlakeSayAye : OriginalSongEvent
            {
                public AllInFavorOfKillingJasonSchlakeSayAye() : base("All in Favor of Killing Jason Schlake say \"Aye\"")
                {
                }
            }

            /// <summary>
            /// the vote is pass/fail for whether the candidate passed.
            /// not technically a vote since wikipedia works on consensus.
            /// This request for adminship failed, but on the next attempt
            /// the candidate succeeded (I did not vote in that one)
            /// 
            /// My vote received a comment that I did not have many wikipedia contributions
            /// Note to closing bureaucrat: user has only 2 contributions --Van helsing
            /// 
            /// Regardless of what other(s) thought of it, it was the right thing to do.
            /// </summary>
            [YearDate(2007, 8, 3, 14, 43)] //UTC
            public class WikipediaNotVote : VoteEvent
            {
                public WikipediaNotVote(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }

            /// <summary>
            /// I may or may not have voted myself, but I marked this off as my usual target
            /// for such awards. I did win this award and have a trophy to prove it.
            /// This is part of Paradigm's yearly award process - the swiss army knife award
            /// is for someone who is good at many different tasks. I think I earned this one.
            /// </summary>
            [YearDate(2014)]
            [TODO("Image thing")]
            public class WorkVote : VoteEvent
            {
                public WorkVote(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }

            /// <summary>
            /// Voting was a novelty. It seemed interesting to me, so I was curious what would happen.
            /// I was a libertarian at the time so the vote was consistent with my beliefs.
            /// </summary>
            [YearDate(2000, 11, 7)]
            public class USPresidentVote1 : VoteEvent
            {
                public USPresidentVote1(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }

            /// <summary>
            /// I didn't understand the purpose of the referendum and went with the intuitive choice
            /// that it sounded reasonable. This particular vote was a mistake, not because my choice was
            /// wrong, but I hadn't thought it out enough.
            /// </summary>
            [YearDate(2000, 11, 7)]
            public class BallotInitiativeVote1 : VoteEvent
            {
                public BallotInitiativeVote1(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }

            /// <summary>
            /// I clearly remember a second question on the ballot for whether campaign finance reform would be
            /// a good idea. I remember thinking about this beforehand and solidifying my view against campaign
            /// finance reform. I voted "No" and this was not a mistake. The question was a nonbinding or advisory
            /// one that did not actually force the State to change anything. I remember the initiative passed
            /// by a large margin.
            /// 
            /// The confusing part is Ballotpedia and Internet searching has no record of this question. I guess
            /// I will never know whether I invented the whole thing, the world has forgotten this particular
            /// referendum, it wasn't actually a statewide referendum, or some sinister force has scrubbed the 
            /// question from existence.
            /// </summary>
            [YearDate(2000, 11, 7)]
            public class BallotInitiativeVote2 : VoteEvent
            {
                public BallotInitiativeVote2(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }

            /// <summary>
            /// John McCain was the clear front-runner and effectively the presumptive nominee, so this vote
            /// really didn't mean anything. My spouse and I both voted in the same errand run. This
            /// was consistent with my political philosophy and at the time I though it was more ok to vote
            /// in a primary than in a general election. Ron Paul had a more successful campaign in 2012, still
            /// not winning the nomination, but by that time I believe I decided another primary vote was not ok.
            /// </summary>
            [AstrologicalSign(AstrologicalSigns.Pisces)] //pisces cutoff within 2/18/2008
            [YearDate(2008, 2, 19)]
            public class USPresidentVote2 : VoteEvent
            {
                public USPresidentVote2(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }

            /// <summary>
            /// This election occurred after I had a psychiatric hospital stay for a manic episode.
            /// The vote was consistent with my political philosophy but had I been mentally healthy 
            /// I would have abstained like I did in the previous two presidential elections. For
            /// this reason, this vote was a mistake.
            /// </summary>
            [YearDate(2012, 11, 6)]
            public class USPresidentVote3 : VoteEvent
            {
                public USPresidentVote3(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }

            /// <summary>
            /// gave a small amount of money to Trump's first campaign. There is some spite in this decision
            /// as my spouse hated/hates Trump to the point where she cannot civilly discuss the matter. This
            /// is also inconsistent with my prevailing political philosophy. Nevertheless, there is something
            /// special about Trump which renders this NOT A MISTAKE.
            /// </summary>
            [Year(2016)]
            [CurrencyAmount(Currencies.UnitedStatesDollar, 50)]
            public class GaveMoneyToPresidentialCampaign : VoteEvent
            {
                public GaveMoneyToPresidentialCampaign(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }

            /// <summary>
            /// Explanation word-for-word identical with the 2012 presidential election explanation.
            /// </summary>
            [YearDate(2016, 11, 8)]
            public class USPresidentVote4 : VoteEvent
            {
                public USPresidentVote4(int? Who, string What, bool Won) : base(Who, What, Won) { }
            }
        }

        public static class AprilFoolsDay2025WisconsinElection
        {
            /// <summary>
            /// General observations:
            /// 1. The law and order (judicial vs police) imbalance is ridiculous
            /// 2. It's par for the course (both sides) to arbitrarily attack a prosecutor for past choices to prosecute or not.
            /// Actual Wisonsin issues: 
            /// 1 (advantage Schimel). Abortion (respecting the will of the people is the correct direction, but taking down the 1800's era law beforehand is correct)
            /// 2 (advantage neither). Gerrymandering (current situation is better, unclear if further changes are actually helpful)
            /// 3 (advantage Schimel). Act 10 (I think taking it down is wrong)
            /// Personal issues:
            /// 1 (advantage Schimel). Website much easier to wade through.
            /// 2 (advantage neither). Trump endorsement not surprising, Crawford bringing Musk into it is interesting
            /// Non issues:
            /// 1. Rape kits (nicest interpretation of attacks is perfect the enemy of the good, but probably much worse
            /// 2. Voter ID (likely constitutional enshrinement takes it off the table)
            /// General conclusion:
            /// The "liberal" majority has accomplished what was needed. In the meantime, I say
            /// swing the pendulum the other way. The pendulum may swing back, possibly even one 
            /// election cycle down the road.
            /// 
            /// Relevant Cases:
            /// 1. Kaul v Urmanski (presumably the 1800's abortion law will be ruled no longer in force),
            /// but not decided yet. Could be significant but not released yet,
            /// 2. Gerrymandering ruling. The needle has moved on this, let's give it some soak time.
            /// 3. Ballot drop boxes (I agree with the liberal side, but not a big deal policywise other
            /// than excessive ping-ponging)
            /// 4. Rulings on office vacancy not existing before new officer confirmed (I think liberal
            /// side is validly accused of being results-oriented).
            /// </summary>
            [ThumbOnTheScale((int)WisconsinPoliticians.SchimelBrad, ThumbOnTheScaleAmount.Full, ThumbOnTheScaleImportance.High)]
            public static class StateSupremeCourtJustice
            {
                /// <summary>
                /// 1. loses a point for ALL CAPS (I'll give a pass to copy paste losing the all caps, which is also silly)
                /// 2. loses a point for being the messiah in blurb title
                /// 3. loses a point on "only I can fix it" grounds
                /// 4. loses a point for claiming judiciary on the other side are not sane.
                /// 5. loses a point for mentioning immigration high in the blurb (national not wisconsin issue)
                /// 6. loses a point given the only politican endorsing is Trump
                /// 7. gains a point for token fire fighter union endorsement (I'm no fan of unions, but balance is appreciated here)
                /// 8. gains a point for Farm Bureau endorsement and Dairy Business Association
                /// 9. gains a point for Realters Association endorsement
                /// 10. gains a point for Bear Hunters' Association
                /// 11. gains a point for a news section, which is actually helpful (website has far more depth)
                /// Total: -1 point. Points generally don't mean anything other than as organizations of thoughts.
                /// </summary>
                [Politician((int)WisconsinPoliticians.SchimelBrad)]
                public static class Option1
                {
                    [Description("mentions California CCPA law, probably using a standardized template")]
                    public static class PrivacyPolicy { }

                    //blurb: "BRAD SCHIMEL IS RUNNING TO SAVE THE COURT"
                    //blurb: "From opening the border to releasing criminals on our streets, rogue judges across
                    //the nation are putting their radical agenda above the law. Brad Schimel will take back the
                    //Wisconsin Supreme Court and end the madness."
                    // "rogue judges" and "radical agenda"are fair game when there is question as to what "rule of law" even means.
                    //blurb: "Notably, he established a program that addressed decades of neglect surrounding rape kits,
                    //providing victims with closure and clearing a significant backlog. This involved federal grant money (I'm wary of fed grant money)
                    public static class Blurb { }

                    /// <summary>
                    /// having token union support does well for balance
                    /// </summary>
                    //Police Associations
                    //Milwaukee Professional Firefighters Association
                    //Wisconsin Farm Bureau
                    //Wisconsin Realtors Association
                    //54 current county sheriffs, 28 retired county sheriffs
                    public static class Endorsements { }

                    /// <summary>
                    /// "Respect will of the people" (abortion, where I agree wholeheartedly)
                    /// "Disqualifying" (this word makes me cringe)
                    /// Trump endorsement (it's ok given the partisan nature of things, but odd this is ok but other politician support isn't)
                    /// </summary>
                    public static class Videos { }
                }

                /// <summary>
                /// 1. loses a point for Flash cookies in privacy policy
                /// 2. gains a point for Wisconsin Conservation Voters endorsement
                /// 3. gains a point for judicial endorsements (opponent has none). This plays into opponents hand saying
                /// there is a conspiracy on the judiciary to subvert the law, but the opponent pretending there aren't
                /// judicial agendas in place is also ridiculous.
                /// 4. gains a point for sheriff support (balance is appreciated here)
                /// Total: +2 points (points don't really mean anything outside of organizing thoughts)
                /// </summary>
                [Politician((int)WisconsinPoliticians.CrawfordSusan)]
                public static class Option2
                {
                    [Description("Mentions Flash cookies, clearly out of date")]
                    public static class PrivacyPolicy { }

                    //blurb: "will reject efforts to politicize the constitution to undermine our most basic rights"
                    //notes: I don't like this since it suggests the possibility of support for efforts to politicize
                    //the constitution that reinforce whatever she thinks our most basic rights are.

                    //blurb: "represented Planned Parenthood of Wisconsin to defend access to reproductive health care"
                    //notes: I understand the politics, unfortunately this kind of thing is a big problem for me.

                    //blurb: "She has always prioritized following the law and getting the facts right
                    //in every case
                    //to ensure everyone appearing in her courtroom receives a fair and impartial trial."
                    //notes: always and "in every case" is pretty strong language. prioritized implies law and facts
                    //may be in conflict, which is true, but a judge doing law/fact balancing in every case presents
                    //an overly flexible notion of what I think judges do in practice.

                    //I don't really like the word salads I've picked out in the blurb, but they aren't big enough
                    //details to warrant a minus.
                    public static class Blurb { }

                    //4 current supreme court justices
                    //1 former supreme court justice
                    //~160 other judicial endorsements
                    //Several unions (including teachers unions)
                    //exactly 44 former assistant attorneys genral
                    //Wisconsin Conservation Voters
                    //Professional Fire Fighters of Wisconsin
                    //Emily's List / Planned Parenthood (keep-abortion-legal groups)
                    //1 Democratic politician (theoretically bad for a non-partisan election, but I'll allow it)
                    //2 current county sheriffs, 3 retired county sheriffs
                    public static class Endorsements { }

                    /// <summary>
                    /// "[Opponent] will ban abortion" (overreaching for what the powers of the supreme court are)
                    /// "I want [Candidate] in my courtroom" (as an appeals court member will only have limited appellate jurisdiction)
                    /// [rape kits issue, unclear]
                    /// "health of the mother" (mistaking life for health is a common misdirection)
                    /// "Elon Musk is trying to buy [opponent] a seat"
                    /// "doing what's right" (this is in tension with the conept of law as an objective set of rules)
                    /// </summary>
                    public static class Videos { }
                }
            }

            /// <summary>
            /// 1 (Kinser):  More website information
            /// 2 (Kinser):  Privacy policy readability
            /// 3 (neither): Backgrounds are appropriate
            /// 4 (neither): Kinser has professional video, although it avoids the school choice issue
            /// 5 (neither): school choice issue is personally important, but only has a blurb in the
            /// proposal section. If the existing choice programs are ok, not sure this office's opinion matters
            /// 
            /// Verdict: The only issue I see here that matters to me is the school choice issue,
            /// and I'm not necessarily convinced Kinser's proposed path is correct. What's decisive
            /// here is the web site with more relevant information.
            /// </summary>
            [ThumbOnTheScale((int)WisconsinPoliticians.KinserBrittany, ThumbOnTheScaleAmount.Half, ThumbOnTheScaleImportance.Low)]
            public static class SuperintendantOfPublicInstruction
            {
                /// <summary>
                /// 1. I have my issues with standardized tests, lowering/raising arbitrary lines isn't a big deal
                /// 2. I have my issues with focusing too much on college readiness
                /// 3. Is funding centralization an acceptable trade-off for school choice? (rhetorical question)
                /// </summary>
                [Politician((int)WisconsinPoliticians.KinserBrittany)]
                public static class Option1
                {
                    [Description("Nondescript black on white")]
                    private static class PrivacyPolicy { }

                    [Description("Experience as career Teacher/Administrator, Literacy Initiative, Charter School Network")]
                    private static class Blurb { }

                    /// <summary>
                    /// 1. revert standards changes
                    /// 2. focus on basics
                    /// 3. school choice
                    /// 4. centralize school funding in state to allow for school choice
                    /// 5. accuses opponent of hypocrisy in sending her children to private schools
                    /// </summary>
                    private static class Proposals { }

                    /// <summary>
                    /// emphasizes college-readiness, back to basics especially for literacy
                    /// </summary>
                    private static class Video { }
                }

                /// <summary>
                /// difficult-to-read privacy policy
                /// </summary>
                [Politician((int)WisconsinPoliticians.UnderlyJill)]
                [Incumbent]
                public static class Option2
                {
                    [Description("Hard to read red on white")]
                    private static class PrivacyPolicy { }

                    [Description("Career Teacher/Administrator")]
                    private static class Blurb { }

                    /// <summary>
                    /// new bipartisan literacy law that will help improve young kids’ reading
                    /// abilities. The new law hires more reading coaches and shifts students 
                    /// to phonics-based reading instruction for 4-year-old kindergarten 
                    /// through third grade.
                    /// 
                    /// federal grants secured for mental health and special education
                    /// teacher recruitment (I'm wary of federal grant money)
                    /// </summary>
                    private static class Accomplishments { }
                }
            }

            /// <summary>
            /// On the merits I am against Voter Photo ID (lesser forms of identification should be good enough)
            /// But, the existing law is not super harmful.
            /// This vote is for constitutionalizing existing law.
            /// From a rule of law perspective this should pass on consistency grounds, there is also a risk
            /// of liberal judicial overturn, which I would be against.
            /// Nevertheless this should be decided in a November election, not an April election, therefore
            /// I vote "No", but this is awkward so no thumb on the sale. Importance is low since this is
            /// going to pass (if I'm wrong I will have to rethink my process)
            /// </summary>
            [ThumbOnTheScale((int)ReferendumChoice.No, ThumbOnTheScaleAmount.None, ThumbOnTheScaleImportance.Low)]
            public static class VoterPhotoIdentificationAmendment
            {
                /// <summary>
                /// Highly partisan measure: Supported by Democrats, particularly those in legislative bodies
                /// Voter Photo ID is argued to be unnecessary (benefit to electoral security is questionable)
                /// Voter Photo ID requires a slice of voters to get an ID specifically for voting (inconvenient and unfair)
                /// </summary>
                [ReferendumChoice(ReferendumChoice.No)]
                public static class Option1 { }

                /// <summary>
                /// Highly partisan measure: Supported by Republicans
                /// Voter Photo ID will increase confidence in election system for supporters
                /// Voter Photo ID is already the law, so rejecting it will result in significant legal dissonance.
                /// </summary>
                [ReferendumChoice(ReferendumChoice.Yes)]
                public static class Option2 { }
            }

            /// <summary>
            /// Incumbent is running as an incumbent, and here it's enough
            /// 
            /// Challenger is single issue candidate for property taxes. The "How your House is looked at"
            /// graphic is definitely clever (I've even saved it off for posterity), but the property 
            /// taxes connection to affordable housing is questionable, and graphically the focus appears
            /// to be more on potholes. Probably a good fit for sale, I judge less for county executive.
            /// </summary>
            [ThumbOnTheScale((int)WisconsinPoliticians.AgardMelissa, ThumbOnTheScaleAmount.Full, ThumbOnTheScaleImportance.Low)]
            [TODO("Image thing")]
            public static class DaneCountyExecutive
            {
                [Politician((int)WisconsinPoliticians.RatzlaffStephen)]
                public static class Option1
                {
                    /// <summary>
                    /// this is evidence of unseriousness, but I'm not sure what I would think if the 
                    /// candidacy was actually credible.
                    /// </summary>
                    [Description("None")]
                    public static class PrivacyPolicy { }

                    /// <summary>
                    /// self-described single 30% property tax cut candidate
                    /// (connected to affordable housing issue)
                    /// but there is another issue: potholes
                    /// non-government background (Steinhafels sales, EMT)
                    /// </summary>
                    public static class Blurb { }

                    /// <summary>
                    /// How your house is looked at:
                    /// ... by you        (nice house)
                    /// ... the buyer     (less nice house)
                    /// ... the Bank loan (a shack)
                    /// ... the Insurance Evaluator (a disaster waiting to happen)
                    /// ... by the County Appraisal District (as a mansion, to maximize property tax values)
                    /// </summary>
                    public static class InterestingImage { }
                }

                [Politician((int)WisconsinPoliticians.AgardMelissa)]
                [Incumbent]
                public static class Option2
                {
                    [Description("External: PaperForm")]
                    public static class PrivacyPolicy { }

                    /// <summary>
                    /// brief and to the point, highlights several government elected jobs
                    /// </summary>
                    public static class Blurb { }
                }
            }
        }
    }
}
