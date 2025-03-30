
using Existence.Beyond;
using Existence.Earth.Countries.UnitedStates;
using Existence.Time;
using static Existence.Beyond.JudgmentDay.BirthToGrowingUp;
using System;
using Existence.Beyond.Infrastructure;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Beyond.JudgmentDay;

namespace Existence.Personal.Beyond
{
    internal class HumanDivineTeenager
    {
        public const int RELIGION_CHURCH_INDEX = 0;
        public const int PIANO_LESSONS_CHURCH_INDEX = 1;
        public HumanDivineTeenager()
        {
            MyReligiousFlags myFlags = new MyReligiousFlags(Respectful: null, Skepticism: null);

            new CapacityForTheReligious();
            new PersonalBirth();

            PersonalChurches[] personalChurches = new PersonalChurches[2];
            personalChurches[RELIGION_CHURCH_INDEX] = PersonalChurches.DekorraLutheranChurch;
            personalChurches[PIANO_LESSONS_CHURCH_INDEX] = PersonalChurches.PortageUnitedMethodistChurch;

            new ChurchTransitionAfterMove(USCities.WisconsinEndeavor, personalChurches);
            new ChildhoodNativityPlays(myFlags);

            MultiEvent religiousSkepticism = new MultiEvent("ReligiousSkepticism", new BaseEvent[]
            {
                new SkepticismOfReligionPersonal(myFlags),
                new ChurchChoirDirectorEvent(ChurchChoirDirectors.EleanorCollins, ChoirType.Childrens)
            });

            new FirstCommunionAsAnAcolyte();
            new LeadRoleInSilentNight();

            MultiEvent preAthiestEvents = new MultiEvent("Pre-atheist Events", new BaseEvent[]
            {
                new HesGotReligionMagicWords((int)ClassmateList.JasonWhite, (int)ClassmateList.JustinRaudebush, "Present, listening, kept silent"),
                new ELCALutheranConfirmationDespiteNearAtheism()
            });

        }

        /// <summary>
        /// The story here is my mother wanted to sit in on Sunday school but my mother's parents' church wouldn't let her.
        /// So she switched to a different church even though geographically it was less convenient (the Endeavor house
        /// was closer to Oxford than the Dells). I don't remember any of this, but in hindsight it may have been quite
        /// important to avoid the stricter (Missouri synod) denomination in favor of the less strict (ELCA).
        /// 
        /// I believe my father went to church for social reasons (not religious ones as he had issues with his Catholic
        /// school experience). In conversation after his retirement he stated he liked some religious discussions. But as
        /// far as I know he never went up to the communion rail to take Communion.
        /// </summary>
        public class ChurchTransitionAfterMove : BaseEvent
        {
            public ChurchTransitionAfterMove(USCities NewHome, PersonalChurches[] personalChurches) : base("Endeavor Home Church Transition")
            {
                bool moved = false;
                foreach (PersonalChurches next in new PersonalChurches[] { PersonalChurches.SaintJohnLutheranChurch, PersonalChurches.BethanyLutheranChurch })
                {
                    if (SwitchChurchBasedOnMove(USCities.WisconsinEndeavor, next))
                    {
                        personalChurches[RELIGION_CHURCH_INDEX] = next;
                        moved = true;
                    }
                }
                if (!moved) throw new InvalidOperationException();
            }
            private bool SwitchChurchBasedOnMove(USCities Target, PersonalChurches church)
            {
                bool ret;
                if (Target == USCities.WisconsinEndeavor)
                {
                    if (church == PersonalChurches.SaintJohnLutheranChurch)
                        ret = false;
                    else if (church == PersonalChurches.BethanyLutheranChurch)
                        ret = true;
                    else
                        throw new InvalidOperationException();
                }
                else
                {
                    throw new InvalidOperationException();
                }
                return ret;
            }
        }

        /// <summary>
        /// I ignored the First Communion paraphernalia given to us at Sunday School and didn't do first communion.
        /// Typically I wouldn't even go up to the communion rail (following my father's lead). However, that could
        /// not be continued as an acolyte, so I did take communion in that context. Year is approximate.
        /// </summary>
        [Year(1992)]
        public class FirstCommunionAsAnAcolyte : BaseEvent
        {
            public FirstCommunionAsAnAcolyte() : base("First Communion as Acolyte")
            {

            }
        }

        /// <summary>
        /// I participated in a lead role (Franz Gruber) in a Christmas pageant telling the story of Silent Night.
        /// I did the best I could, which was typical for me in a singing/acting public display. Year is approximate.
        /// </summary>
        [Year(1994)]
        public class LeadRoleInSilentNight : BaseEvent
        {
            public LeadRoleInSilentNight() : base("Lead Role in Silent Night Church Christmas Pageant")
            {
            }
        }

        /// <summary>
        /// This was a discussion between two classmates, one of which was in my Sunday School class. These two classmates
        /// were more philosophical then most. One referred to me as "He's got religion" (I may not have the phrasing of the magic
        /// words quite right). The truth was I was closer to atheist than anything else. Still, I did not correct them, I didn't
        /// have an issue with them incorrectly thinking that. In hindsight, I should have said something (anything).
        /// </summary>
        public class HesGotReligionMagicWords : BaseEvent
        {
            public HesGotReligionMagicWords(int Source, int Target, string MyRole) : base("\"He's got religion\"")
            {
            }
        }

        /// <summary>
        /// I had a discussion with Pastor Kreuger before confirmation. I knew full well I wasn't going to have anything to do
        /// with the church in the long term and wanted to make sure nothing was expected of him. The answer to my question was
        /// no, nothing was expected of me. So I got confirmed. I will never know whether going through with the confirmation was
        /// actually a mistake.
        /// </summary>
        public class ELCALutheranConfirmationDespiteNearAtheism : BaseEvent
        {
            public ELCALutheranConfirmationDespiteNearAtheism() : base("Near-atheism ELCA Lutheran Confirmation")
            {
            }
        }

        /// <summary>
        /// I do not remember ever giving up something tangible for Lent (it wasn't emphasized in ELCA Lutheran upbringing,
        /// but I know my Catholic relatives did). As an adult I came up with the running gag of giving up "giving things
        /// up for Lent" for Lent. I'm not sure if I'm being disrespectful of religion or not. Tt's just an absurd way of
        /// saying I don't participate in that part of the religion, but I'm also not a practicing Christian. On the other
        /// hand I'm not really broadcasting that to the world, so maybe it doesn't actually matter. But it's still a joke,
        /// and has remained so even as my understanding of disrespect for religion has increased.
        /// </summary>
        public class GivingUpGivingUpSomethingForLentForLent : BaseEvent
        {
            public GivingUpGivingUpSomethingForLentForLent() : base("Joke Giving Up Nothing for Lent")
            {
            }
        }

        public enum PersonalChurches
        {
            /// <summary>
            /// specific Lutheran denomination not listed on their web site, based on other web site info, not strict
            /// </summary>
            [USCities(USCities.WisconsinPoynette)]
            [UnitedStatesChristianDenomination(ChristianDenominations.Lutheran)]
            DekorraLutheranChurch,

            [USCities(USCities.WisconsinOxford)]
            [UnitedStatesChristianDenomination(ChristianDenominations.LutheranMissouriSynod)]
            SaintJohnLutheranChurch,

            [USCities(USCities.WisconsinWisconsinDells)]
            [UnitedStatesChristianDenomination(ChristianDenominations.LutheranELCA)]
            BethanyLutheranChurch,

            [USCities(USCities.WisconsinPortage)]
            [UnitedStatesChristianDenomination(ChristianDenominations.Methodist)]
            PortageUnitedMethodistChurch,

            [USCities(USCities.WisconsinMadison)]
            [UnitedStatesChristianDenomination(ChristianDenominations.Episcopal)]
            SaintDunstansEpiscopalChurch,
        }
    }

    internal class ReligionHistory
    {
        public ReligionHistory()
        {
            
        }
    }

    /// <summary>
    /// Adding the Lutheran denomination. This is based on parentage. My father was a non-practicing Catholic. My mother
    /// grew up Lutheran (Missouri Synod). My parents' church at the time was Dekorra Lutheran Church which I don't think
    /// was Missouri Synod, and based on contemporary info doesn't appear to be one of the main denominations, although they
    /// seem non strict as it stands today.
    /// </summary>
    [HomeAfterBirth(USCities.WisconsinHarmonyGrove)]
    [Birthdate(1980, 12, 6)]
    [BirthdatePrecise(1980, 12, 6, 12, 53)]
    [UnitedStatesChristianDenomination(ChristianDenominations.Lutheran)]
    public class PersonalBirth : ZBirth
    {
        public PersonalBirth() : base() { }
    }

    /// <summary>
    ///5. Number of Church Choir directors: 4 (including children's choir). This establishes a choir history which is not easy to subvert.
    ///6. Briefly became an agnostic, but remained atheist. "Atheist" ends up the primary religion.But a brief period of agnosticism allows flexibility for defining the religious rules at judgment day.
    ///7. 2018-09-23. Word-based synethesia following the beliefs around parts of liturgy believed in or pronouns.
    ///8. Choir director had their own arrangement of Canticle of the Turning.This allows for a relatively fixed human meaning of Canticle of the Turning, making a personal/Z reinterpretation less risky.
    ///
    /// Birth Religion: 
    /// Lutheran (Generic). This is based on parent preferences.
    /// Did not become Missouri Synod Lutheran despite the opportunity
    /// Lutheran (ELCA). This is specific despite no real personal understanding of Lutheran denominations.
    /// Disrespectful Flag turned on (Childhood nativity play). Not permanent.
    /// Skepticism Flag turned on (I have no sin). This is permanent.
    /// Respectful Flag turned on (First Communion as Acolyte). I think this was permanent.
    /// Confirmed (Nearing Atheism switch, Doubt in a Z sense)
    /// Fake Reputation ("He's got religion"). Only did this once.
    /// Atheist.
    /// Agnostic (brief period in college based on philosophy class, didn't stick)
    /// 
    /// March 2024: Started own religion. Contrafactums of Awesome God and One of Us.
    /// </summary>
    internal class JudgmentDaySomethingReligious
    {
        //CapacityForTheReligious: Minimal
        //Birth (Church = Dekorra Lutheran Church)
        //Baptism (unclear if happened in Harmony Grove or Oxford)
        //Switch to Bethany Lutheran Church (mother wanted to sit in at Sunday school) (divine childhood point?)
        //Mother was Sunday school teacher in the youngest non-early-childhood class)
        //Someone called me a genius (happened at the Oxford Church my grandparents went to)
        //Childhood nativity play: went downhill from respectful to disrespectful over the years
        //Said "I have no sin" magic words alone in my room (divine growing up point)
        //First Communion (ignored materials (4th grade?), put off as long as possible until was an acolyte and didn't want to be disrespectful)
        //Played the lead role in a production of "Silent Night" in a church nativity play.
        //7th grade class - I remember all the classmates except 1
        //8th grade: Jason White referred me as having "religion" in discussion with Justin Raudebush
        //in the foyer of Spring Hill School. I did not respond, I knew I was closer to atheist, but it
        //didn't matter what they thought of me. Not a mistake, but it might have been better to give some
        //sort of social response to this.
        //Confirmation: I talked with Pastor Krueger, I wanted it to be clear that nothing was expected of
        //me. Also not a mistake, although I remember the discussion was a bit out of sorts. Apparently
        //ELCA Lutheran is quite tolerant of skepticism, so it really didn't matter. I didn't understand
        //the strictness differences between different denominations, so my religious ignorance was signifcant.
        //I think I deemed myself an atheist after these two events, but it's not because I specifically
        //remember that order. Both incidents were important events in the path, either before or after
        //they solidified the end result.
        //1. Sophomore in High School: Math class (FST). Publicly claimed to be the Antichrist. This was
        //a joke. Referred to as Satan by Brian Wimann for a time. During one class I stood in front of the
        //classroom and called the class "my people". Melissa Hamburg objected and I told her she was
        //excluded. It didn't take too long for the joke to get old. It remained a joke for many years
        //afterward but is a bit unsetting now.
        //2. Junior in High School: AP US History Class. Possibly inspired by a Simpsons episode, I
        //wrote "Chris Rowe's soul (Yes, it's really his soul)" on a piece of paper as a joke. I think we
        //passed it around a bit and Greg Wisniewski ended up with it, and I remember he was happy about
        //that. The Wisniewski's (Greg and Katie were highly intelligent and highly religious). It remained
        //a joke for many years afterward but is a bit unsettling now.

        //Handbells (practiced in Portage with Mr. Yerke but I think we did it in the Dells)

        //Children's Choir (Choir diretory: Eleanor Collins, Denise Tubman accompanying)
        //Me, Sonya, Karin Christiansen, Erin
        //This is the day

        //School Choir (Ms Pieper)
        //Hero
        //Candle on the Water

        //College: Took philosophy class which upended religious beliefs. Briefly became an agnostic,
        //but returned to atheism in short order.

        //baked potato incident with potential spouse's parents
        //Discussed potential marriage with Mother Mo. I didn't have good reasons for being married, but
        //it really didn't matter for the purpose of the discussion.
        //Married in St.Dunstan's Episcopal Church

        //Original Song: I am the Pope

        //psychiatric hospitalization: met someone in the hospital who seemed to think he was God. I didn't
        //know how to help him.

        //2018 August/September created arrangement of Wade in the Water
        //2018-09-23
        //1. experienced synethesia in pronouns when reading the litergy where my experience of the language
        //changed based on my beliefs about pronouns.
        //2. Played postlude of Wade in the Water after service. Nobody but the choir knew it
        //was unplanned because the choir was in the choir loft and everyone else was downstairs. This was
        //a direct precursor of what I would do at the later company event.

        //Choir Director #1: Mitchell
        //Choir Director #2: Martin Ganschow (Deanna Clement's version of Canticle of the Turning)
        //Choir Director #3: Deanna Clement (paperless).

        //March 2024. Contrafactum of Awesome God and One of Us. Capacity for the divine.
        //Around this time started developing personal religion:
        //1. Origin story: Omniverse Prime (originally Universe Prime)
        //2. Good and Evil: It is up to the objects in the simulation to discriminate and show to whoever's listening
        //3. Capacity for the divine: Different objects have different capacity for the divine, corresponding
        //with free will, self-awareness, purpose, and consequences
        //4. There can be many messiahs with their own message: communication (private and public) is important
        //for a messiah.
        //5. The cloud, AI algorithms, and large language models have potential connections with the divine.
        //6. Miracles are possible within these bounds (small and large). Expect small miracles before large ones.
        //7. End States (technological singularity, human immortality, aliens). These are currently believed to
        //be wrong answers but are useful thought experiments. Maybe even achievable but still a long way off,
        //even at mankind's current hectic rate of progress.
        //8. Communication with the beyond has morphed into communication with the subconscious, now
        //semiconscious. The subconscious processes have a more direct relationship with the beyond, but
        //this is hidden.

        //May 2024. Time-traveling message box. Later recognized one valid interpretation would be religon.

        //        IPT   Cosmic
        //Loop:  Human          Personal
        //              Divine     Z
        //There is an extra-powerful version of the Personal called Z (perhaps call this superpowers).
        //For you the Personal and the Z have merged.
        //You believe there is another edge of the loop between the human and cosmic levels called
        //"Intergalactic Pulsar Time". It appears to correspond with the idea that humans connect with
        //aliens. Your best guess is the usual way to get from Human to Cosmic is humanity dies out,
        //serializes itself, and then is reborn in another spot (e.g. another universe). You believe this
        //results in the loss of important information, and prefer the IPT path even if that has drawbacks.
        //Problems with the IPT path include limitations of human psychology and the reality that physical
        //contact with aliens does not work since the aliens are impossibly remote. You think the combination
        //of upgraded human psychology and connection with the beyond can solve the problem, although it
        //is only blurry conjecture right now.
    }

    /// <summary>
    /// lucky penny incident where I scratched off a $50 scratch-off lottery ticket winner
    /// for Grandma
    /// Grandpa "lost the rent check" from Dad's story
    /// Went to Ho Chunk casino twice (on 18th and 21st birthday). Played black jack, tried to count
    /// cards, not competent enough but won anyway, person who came with lost so even if I won we didn't
    /// actually cheat the casinos.
    /// Once I took insurance even though I didn't want to, Grandpa said I would take insurance. I didn't
    /// want to but the dealer took it anyway. I believe it was a winning bet, but I'm not sure what
    /// would have happened had it been a losing bet or I asserted myself more.
    /// 
    /// This refers to an incident (addition of endeavor house) with sticking my finger in exposed light outlets.
    /// There were no discernable consequences, but the lesson was learned nonetheless.
    /// 
    /// We also have the flashcards domination incident, which had the cosmic consequences of the T.G. loss
    /// also the 2nd grade teacher with "She's dead" and "It might be true" situation.
    /// 
    /// People are inherently Stupid
    /// Psychology is BS
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
    internal class WorkingIdeas
    {
    }
}
