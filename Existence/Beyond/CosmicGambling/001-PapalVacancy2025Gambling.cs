using Existence.Beyond.Infrastructure;
using Existence.Earth.Alphabet;
using Existence.Earth.Countries;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Earth.Gambling;
using Existence.Earth.Human.People;
using Existence.Time;
using System.ComponentModel;

namespace Existence.Beyond.CosmicGambling
{
    internal class PapalVacancy2025Gambling
    {
        private enum VersionHistory
        {
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 5, 3)]
            Created,

            [BeyondObjectVersion(1, 1, 0, 0)]
            [YearDate(2025, 5, 5)]
            AddMoreDetailsToBet,

            [BeyondObjectVersion(1, 2, 0, 0)]
            [YearDate(2025, 5, 8)]
            AddPapalWinner,

            [BeyondObjectVersion(1, 3, 0, 0)]
            [YearDate(2025, 5, 13)]
            AddMissingDateToSonNamingMethod
        }

        /// <summary>
        /// I ripped a $20 bill into many pieces, threw it into the garbage
        /// can saying "Delete, Shred, Recycle". I figure this gives me
        /// $20 cosmic USD to play with.
        /// 
        /// I have no special insight into Vatican politics so I go with Chat GPT's initial
        /// intuition.
        /// </summary>
        [Odds(7.6, 1)]
        [Bet("Matteo Zuppi", 20, Currencies.UnitedStatesDollar)]
        [ThumbOnTheScale((int)PeopleEnumerated.ZuppiMatteo, ThumbOnTheScaleAmount.Full, ThumbOnTheScaleImportance.Low, (int)PeopleEnumerated.ParolinPietro, (int)PeopleEnumerated.PrevostRobertFrancis)]
        public enum PapalVacancyBet
        {
        }

        /// <summary>
        ///   5 consisteries of John Paul II
        ///  22 consisteries of Benedict XVI (including Antonio Cañizares Llovea who changed his mind on participation)
        /// 108 consisteries of Francis
        /// </summary>
        public enum PapalContenders
        {
            [Country(CountryLikeThings.Italy)]
            [Ideology("Moderate")]
            [Description("Extensive diplomatic experience as Vatican Secretary of State, including involvement in negotations with China, viewed as continuing Francis' governance approach")]
            PietroParolin,

            [Country(CountryLikeThings.Philippines)]
            [Ideology("Progressive")]
            [Description("Former Archbishop of Manila, close to Francis, multilingual, globalist")]
            LuisAntonioTagle,

            [Country(CountryLikeThings.Ghana)]
            [Ideology("Moderate")]
            [Description("Strong on climate justice, previously led Dicastery for Integral Human Development")]
            PeterTurkson,

            [Country(CountryLikeThings.Italy)]
            [Ideology("Moderate/Francis-aligned")]
            [Description("Advocate for social inclusion and peace, President of Italian Bishops' Conference, peacemaker (Ukraine), rising profile")]
            MatteoZuppi,

            [Country(CountryLikeThings.Italy)]
            [Description("Latin Patriarch of Jerusalem, irsthand experience with interfaith dialogue and conflict resolution in the Middle East, pastoral approach with focus on peace and reconciliation")]
            PierbattistaPizzaballa,

            [Country(CountryLikeThings.Hungary)]
            [Ideology("Conservative")]
            [Description("Traditionalist views, aligned with nationalist politics, could appeal to those seeking a return to more orthodox practices")]
            PéterErdő,

            [Country(CountryLikeThings.Guinea)]
            [Ideology("Conservative")]
            [Description("Very traditional, beloved by some for liturgical stances, but polarizing")]
            RobertSarah,

            [Country(CountryLikeThings.France)]
            [Description("astoral experience, intellectual acumen, and alignment with progressive ecclesial values")]
            JeanMarcAveline,

            [Country(CountryLikeThings.Luxembourg)]
            [Ideology("Progressive")]
            [Description("Jesuit, favors synodality, LGBTQ-inclusive language")]
            JeanClaudeHollerich,

            [Country(CountryLikeThings.Portugal)]
            [Ideology("Progressive")]
            [Description("Theologian and poet with scholarly perspective, unique candidate with cultural insights")]
            JoséTolentinodeMendonça,
        }

        public class MyGamblingHistory
        {
            public MyGamblingHistory()
            {
                new MyMothersParents40thAnniversaryCasino();
                new ScratchedOff50DollarWinningLotteryTicket();
                new FamilyMichiganRummy();
                new PlayedFantasyFootballWithMyFather();
                new MyMothersFatherLostTheRentCheck();
                new TakingInsuranceInBlackjack();
                new TryingToCountCardsAtBlackjack1();
                new TryingToCountCardsAtBlackjack2();
                new FilledOutNCAATournamentBrackets();
                new ChoseSonsNameViaSixteenTeamTournament();
                new PokerWithMyKids();
            }
        }
    }

    /// <summary>
    /// For my mother's parents' 40th wedding anniversary there was a casino-
    /// themed party. There was roulette and craps and blackjack and a big 
    /// wheel. At the time my favorite casino game was craps.
    /// </summary>
    [YearDate(1989, 7, 16)]
    public class MyMothersParents40thAnniversaryCasino : BaseEvent
    {
        public MyMothersParents40thAnniversaryCasino() : base("Grandparents Anniversary Casino Theme")
        {
        }
    }

    /// <summary>
    /// My mother's mother would sometimes take me on errands such as
    /// the grocery store. She would by a scratch-off lottery ticket
    /// and let me scratch it off. Once I scratched one off with a
    /// penny and won $50. Because of this my mother's mother 
    /// considered me "lucky" for a time". I don't think my mother's
    /// mother had a gambling issue, it was just something for fun.
    /// </summary>
    [ApproximateAgeInYears(10)]
    public class ScratchedOff50DollarWinningLotteryTicket : BaseEvent
    {
        public ScratchedOff50DollarWinningLotteryTicket() : base("Scratched Off Winning Lottery Ticket")
        {
        }
    }
    
    /// <summary>
    /// My mother's parents liked to play a variant of Michigan Rummy, a game with
    /// many players and chips. The preferred arrangement was to play for real money,
    /// so the kids would even get loans from the adults. Poker is one of the parts
    /// of the game. It's mostly luck based, although there is at least one photograph
    /// of me getting the 6-7-8 (or similar).
    /// </summary>
    [StartYear(1989)]
    public class FamilyMichiganRummy : BaseEvent
    {
        public FamilyMichiganRummy() : base("Played Michigan Rummy with Family")
        {
        }
    }


    /// <summary>
    /// My father and I played a form of fantasy football where we
    /// paid some money up front, and then we had to pick players who
    /// we thought would have good statistics. I don't remember if
    /// we could change out the players per week. There were weekly 
    /// prizes, and I think there were prizes at the end of the year
    /// too but I don't remember exactly. I remember we won a weekly
    /// prize once (might have been $50 or even less). I don't remember 
    /// exactly what we chose except for Mark Ingram of the Dolphins.
    /// I think he had a good day on our winning week but not certain.
    /// </summary>
    [YearRange(1992, 1993)]
    public class PlayedFantasyFootballWithMyFather : BaseEvent
    {
        public PlayedFantasyFootballWithMyFather() : base("Played Fantasy Football with My Father")
        {
        }
    }

    /// <summary>
    /// My father has a story where he was discussing things with my mother's
    /// father about how my mother's father lost a tenan'ts rent by going to the Ho
    /// Chunk casino and gambling it away. I believe "I lost the rent check"
    /// is a direct quote. My mother's father did have a bit of a gambling problem.
    /// </summary>
    [MagicWords("I lost the rent check", "My Mother's Father", "Unknown", "My Father")]
    public class MyMothersFatherLostTheRentCheck : BaseEvent
    {
        public MyMothersFatherLostTheRentCheck() : base("My Mother's Father Gambled away the Rent Check")
        {
        }
    }

    /// <summary>
    /// At Ho Chunk casino with my grandfather playing Blackjack, I got into a situation where I could take insurance. I didn't want
    /// to take insurance, but my grandfather interceded and said I did. I did not protest and the insurance paid off. It is unclear
    /// exactly how I would have responded to a loss. The lack of protest is a communication sin. It is also unclear how I would have
    /// responded to a loss, in which case it might be beyond that.
    /// </summary>
    [YearDate(1998, 12, 6)]
    [SinType(SinType.PersonalCommunication)]
    [Witness((int)FamilyMembers.MyMothersFatherSkip)]
    public class TakingInsuranceInBlackjack : BaseEvent
    {
        public TakingInsuranceInBlackjack() : base("Took Insurance in Blackjack Despite Not Wanting to")
        {
        }
    }

    /// <summary>
    /// I wasn't competent enough to successfully count cards (Archer method) but I won a little bit
    /// anyway. My companion lost more than I won so overall the casinos won.
    /// </summary>
    [YearDate(1998, 12, 6)]
    [SinType(SinType.Cheating)]
    [Witness((int)FamilyMembers.MyMothersFatherSkip)]
    public class TryingToCountCardsAtBlackjack1 : BaseEvent
    {
        public TryingToCountCardsAtBlackjack1() : base("Tried to Count Cards at Casino Blackjack #1")
        {
        }
    }

    /// <summary>
    /// I wasn't competent enough to successfully count cards (Archer method) but I won a little bit
    /// anyway. My companion lost more than I won so overall the casinos won.
    /// </summary>
    [YearDate(2001, 12, 6)]
    [SinType(SinType.Cheating)]
    [Witness((int)FamilyMembers.MyFatherJerry)]
    public class TryingToCountCardsAtBlackjack2 : BaseEvent
    {
        public TryingToCountCardsAtBlackjack2() : base("Tried to Count Cards at Casino Blackjack #2")
        {
        }
    }

    /// <summary>
    /// I have filled out NCAA tournament brackets multiple times.
    /// Most of the times were using Yahoo Sports brackets, but I have
    /// also filled out work (WTS Paradigm) brackets a small number of
    /// times. I believe my best bracket was 2004, when I correctly
    /// picked Duke to the final four (I may also have picked 
    /// Connecticut but that is hazier). I believe I had a pretty good
    /// "top percentage" number that year but I don't remember exactly.
    /// I have always had a strong preference for choosing Duke which
    /// I can't fully explain (perhaps Mike Krzyzewski has a strong
    /// brand)
    /// </summary>
    [StartYear(2000)]
    public class FilledOutNCAATournamentBrackets : BaseEvent
    {
        public FilledOutNCAATournamentBrackets() : base("Filled out NCAA March Madness Brackets")
        {
        }
    }

    /// <summary>
    /// I wanted to choose my son's name via a tournament with dice
    /// rolls (I had leverage on this since my spouse chose my
    /// daughter's name). We had extreme difficulty coming up with a
    /// list of names since my spouse rejected many, and I also 
    /// rejected names I thought too common. We eventually settled
    /// on a sixteen team bracket. Each "game" consisted of one dice
    /// roll using a 20-sided die to determine the cutoff point for a
    /// win. This established two bounds, for example a value of 10
    /// meant bounds of 1-9 and 10-20. A value of 1 meant bounds of the
    /// null set and 1-20. My spouse could choose which name got the upper
    /// and lower bound. A second die roll determined which name won
    /// (usually meaningful but not in the 1-20 case). My spouse performed
    /// the die rolls. The brackets are but the final pairings were Adam 
    /// and Dean. The first roll was a 3 (I think), and my spouse preferred 
    /// Adam, so 1-2 was for Dean and 3-20 for Adam. I don't remember
    /// the last die roll but Adam won. The name Victor was in the
    /// semifinals and was chosen by agreement for middle name (no
    /// chance included)
    /// </summary>
    [YearDate(2013)]
    public class ChoseSonsNameViaSixteenTeamTournament : BaseEvent
    {
        public ChoseSonsNameViaSixteenTeamTournament() : base("Chose Sons Name via Tournament")
        {
        }
    }

    /// <summary>
    /// I got a poker chips set and have played poker with my son and daughter. It's
    /// never been for real money, we just hand out some number (e.g. 100) of chips
    /// ahead of time. The games are mostly Texas Hold 'em and draw poker.
    /// </summary>
    [StartYear(2020)]
    public class PokerWithMyKids : BaseEvent
    {
        public PokerWithMyKids() : base("Played Poker with Kids Not for Real Money")
        {
        }
    }

    /// <summary>
    /// I was unable to establish a cryptocurrency wallet with coinbase
    /// because I couldn't make an acceptable photo of my driver's license.
    /// So I couldn't play PolyMarket (illegal in United States anyway).
    /// My cosmic gambling instead is played with $20 I ripped to shreds and
    /// thus exists only metaphysically. This violates United States law
    /// (18 US Code 333), but there are no consequences of doing this 
    /// privately.
    /// </summary>
    [YearDate(2025, 5, 3)]
    [SinType(SinType.BreakingTheLaw)]
    public class IntentionallyDestroyedCurrency : BaseEvent
    {
        public IntentionallyDestroyedCurrency() : base("Intentionally Destroyed Currency for Cosmic Currency")
        {
        }
    }
}
