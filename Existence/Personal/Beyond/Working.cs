using System.Collections.Generic;
using Existence.Beyond.Infrastructure;
using Existence.Earth.Countries;
using Existence.Earth.FieldsOfStudy.Astrology;
using Existence.Earth.Human;
using Existence.Earth.Human.People;
using Existence.Personal.Employment;
using Existence.Time;

namespace Existence.Personal.Beyond
{
    internal class ThumbOnTheScaleAprilFoolsDay2025
    {
        public class VotingHistory
        {
            public VotingHistory()
            {
                BallotInitiativeVote1 extendRightToVoteInFederalElectionsToChildrenOfUSCitizensLivingAbroadWhoFormerlyResidedInWisconsin =
                    new BallotInitiativeVote1((int)ReferendumChoice.Yes, "Wisconsin LRSS Question 1", true);
                USPresidentVote1 firstUSPresidentialVote = new USPresidentVote1((int)PeopleEnumerated.BrowneHarry, "2000 General Election", false);
                List<BaseEvent> notVotes = new List<BaseEvent>()
                {
                    new HighSchoolNotVote(null, "Class President", false),
                    new WikipediaNotVote((int)PeopleEnumerated.DuninElonka, "Request for Adminship", false),
                };
                List<BaseEvent> votesAndPoliticalPhilosophy = new List<BaseEvent>()
                {
                    new MyPoliticalPhilosophy1(PoliticalPhilosophies.Conservative),
                    new MyPoliticalPhilosophy2(PoliticalPhilosophies.Libertarian),
                    new HighSchoolVote((int)ClassmateList.PaulMartinski, "Prom or Homecoming King/Queen", false),
                    firstUSPresidentialVote,
                    extendRightToVoteInFederalElectionsToChildrenOfUSCitizensLivingAbroadWhoFormerlyResidedInWisconsin,
                    new BallotInitiativeVote2((int)ReferendumChoice.No, "Campaign Finance Reform Question", false),
                    new USPresidentVote2((int)PeopleEnumerated.PaulRon, "2008 Republican Primary", false),
                    new WorkVote((int)Coworkers.NickVavra, "Swiss Army Knife Award", false),
                      
                };
                List<BaseEvent> votesThatWereMistakes = new List<BaseEvent>()
                {
                    extendRightToVoteInFederalElectionsToChildrenOfUSCitizensLivingAbroadWhoFormerlyResidedInWisconsin
                };
                BaseEvent.ChainEvents(votesAndPoliticalPhilosophy, null);
                BaseEvent.ChainEvents(votesThatWereMistakes, firstUSPresidentialVote);
            }
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

        //CSRTODO
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
        public class WorkVote : VoteEvent
        {
            public WorkVote(int? Who, string What, bool Won) : base(Who, What, Won) { }
        }

        /// <summary>
        /// Voting was a novelty. It seemed interesting to me, and I was a libertarian.
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
        /// really didn't mean anything. My spouse and I both voted in the same errand run. I was
        /// a libertarian and at the time I thought it was more ok to vote in a primary than in a general
        /// election.
        /// </summary>
        [AstrologicalSign(AstrologicalSigns.Pisces)] //pisces cutoff within 2/18/2008
        [YearDate(2008, 2, 19)]
        public class USPresidentVote2 : VoteEvent
        {
            public USPresidentVote2(int? Who, string What, bool Won) : base(Who, What, Won) { }
        }

        /// <summary>
        /// I had not recovered
        /// </summary>
        public class USPresidentVote3 : VoteEvent
        {
            public USPresidentVote3(int? Who, string What, bool Won) : base(Who, What, Won) { }
        }
    }

    internal class WorkingIdeas
    {

        /// <summary>
        /// This refers to an incident (addition of endeavor house) with sticking my finger in exposed light outlets.
        /// There were no discernable consequences, but the lesson was learned nonetheless.
        /// 
        /// We also have the flashcards domination incident, which had the cosmic consequences of the T.G. loss
        /// also the 2nd grade teacher with "She's dead" and "It might be true" situation.
        /// 
        /// People are inherently Stupid
        /// Psychology is BS
        /// Become atheist (Antichrist)
        /// 
        /// Blanket (sonya and I) incident
        /// HAlloween getting out of
        /// HAlloween as ghost and myself
        /// 
        /// WEt the bed as a child, got over it with assistance from calendar sticker incentives
        /// last wet the bed incident was at Pine Lake camp (camp counselor washed the sleeping bag)
        /// 
        /// son took forever to get over wetting the bed (wore pullup like forever, his mother really didn't
        /// want to clean it up and appeared to have no idea what would be helpful and never asked me about it). He Didn't seem to
        /// consider it important when asked. Eventually he just stopped wearing the pullup and it was fine.
        /// 
        /// Guarantee incident: Once when mother told us to put on our seat belts for a trip to grandma's house
        /// I refused, saying I guaranteed we would make it to grandma's house without an accident (it was only
        /// a couple of miles). I put on my seat belt, and we made it to grandma's house without incident, and
        /// when we were done I said something to the effect of "see, I was right" (not exact words).
        /// 
        /// childhood nativity play - went from respectful to disrespectful of Christianity over time
        /// 
        /// Sang "Silent Night" in real church nativity play (respectful, but what was my religion at the time?)
        /// 
        /// I do not remember ever believing in Santa Claus.
        /// 
        /// March 16, 1998: worst day of my life. Car wouldn't start and walked 13.5 miles home from school.
        /// (March 15 is called the ides of march, which comports with the roman calendar). The modern day
        /// Ides of March fall on March 16.
        /// 
        /// When my parents moved to Oshkosh there's a story about how Dad was ready to
        /// go (without any cats), but my mother stopped and took april into the car. Dad
        /// objected but mother said she had always lived with cats and wanted to continue.
        /// Then before leaving, my mother stopped and took Chaquita into the car. So
        /// my mother always had cats until Stocco's death.
        /// </summary>
        private class ActionsHaveConsequences : BaseEvent
        {
            public ActionsHaveConsequences() : base("Actions Have Consequences")
            {
            }
        }
    }
}
