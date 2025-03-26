using Existence.Beyond.Infrastructure;
using Existence.Earth.Human.People;
using Existence.Time;

namespace Existence.Personal.Beyond
{
    internal class ThumbOnTheScaleAprilFoolsDay2025
    {
        public class VotingHistory
        {
            public VotingHistory()
            {
                new HighSchoolVote1(null, "Class President", false);
                new HighSchoolVote2((int)ClassmateList.PaulMartinski, "Prom or Homecoming King/Queen", false);
                new WikipediaVote((int)PeopleEnumerated.DuninElonka, "Request for Adminship", false);
            }
        }


        /// <summary>
        /// I don't believe I ever voted for high school class president
        /// Winners: Abby Joyce (x2), Jess Graham, Josh Rybaski
        /// </summary>
        [YearRange(1995, 1999)]
        public class HighSchoolVote1 : VoteEvent
        {
            public HighSchoolVote1(int? Who, string What, bool Won) : base(Who, What, Won)
            {
            }
        }

        /// <summary>
        /// I didn't understand the procedure where boys voted for the queen
        /// and girls voted for the king, I incorrectly thought everyone voted
        /// for everybody. I don't remember the female I voted for, but I know
        /// the male I wasn't supposed to vote for. I don't even remember
        /// who won the elections, or even if it as prom or homecoming.
        /// </summary>
        [Year(1998)]
        public class HighSchoolVote2 : VoteEvent
        {
            public HighSchoolVote2(int? Who, string What, bool Won) : base(Who, What, Won)
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
        /// </summary>
        [YearDate(2007, 8, 3, 14, 43)] //UTC
        public class WikipediaVote : VoteEvent
        {
            public WikipediaVote(int? Who, string What, bool Won) : base(Who, What, Won)
            {
            }
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
