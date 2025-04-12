using Existence.Time;
using System;
using System.Collections.Generic;

namespace Existence.Earth.Religions
{
    /// <summary>
    /// independent sovereign state created by the Lateran Treaty of 1929 between the Holy See and Italy
    /// Ensures the Pope is not subject to any other nation's authority.
    /// </summary>
    public static class VaticanCity
    {
        /// <summary>
        /// Sovereign (King/Monarch) of Vatican City
        /// </summary>
        public static class Pope { }
    }

    internal class CatholicChurch
    {
        /// <summary>
        /// central governing institution of the cathoic church, especially in matters of diplomacy and international law
        /// </summary>
        public static class HolySee
        {
            /// <summary>
            /// Bishop of Rome and Supreme Pontiff
            /// </summary>
            public static class Pope { }

            /// <summary>
            /// the administrative departments assisting the pope
            /// </summary>
            public static class RomanCuria { }

            /// <summary>
            /// bishopric of the pope
            /// </summary>
            public static class SeeOfRome { }
        }

        /// <summary>
        /// https://en.wikipedia.org/wiki/List_of_current_cardinals
        /// </summary>
        public static class CollegeOfCardinals { }
    }

    public class PapalInfallibilityAttribute : Attribute
    {
    }

    public class CouncilNumberAttribute : Attribute
    {
        public int Number { get; set; }
        public CouncilNumberAttribute(int Number)
        {
            this.Number = Number;
        }
    }

    public class ChristianDoctrine
    {
        public List<string> TimelessDoctrine { get; set; }
        public List<string> StructuralDoctrine { get; set; }
        public ChristianDoctrine()
        {
            TimelessDoctrine = new List<string>()
            {
                "Trinity: One God in Three (Father, Son, Holy Spirit)",
                "Jesus Christ was preexistent and divine",
                "The soul is immortal by its nature and unique to each human being."
            };
            StructuralDoctrine = new List<string>();
        }
        public ChristianDoctrine(ChristianDoctrine copied)
        {
            TimelessDoctrine = new List<string>(copied.TimelessDoctrine);
            StructuralDoctrine = new List<string>(copied.StructuralDoctrine);
        }
        public void AddTimelessDoctrine(string Doctrine, string Quote)
        {
            TimelessDoctrine.Add(Doctrine);
        }
        public void AddStructuralDoctrine(string Doctrine)
        {
            StructuralDoctrine.Add(Doctrine);
        }
        public void ReplaceDoctrine(string NewDoctrine, string OldDoctrine)
        {
            int iIndex = TimelessDoctrine.IndexOf(OldDoctrine);
            if (iIndex < 0) throw new InvalidOperationException();
            TimelessDoctrine[iIndex] = NewDoctrine;
        }
        public void AffirmDoctrine(string Doctrine, string Quote)
        {
            if (!TimelessDoctrine.Contains(Doctrine))
            {
                throw new InvalidOperationException();
            }
        }
        public void RejectDoctrine(string Doctrine)
        {
        }
        public void RejectHeresy(OrthodoxChristianHeresy Heresy)
        {
        }
    }

    public class ChristianityTimeline
    {


        public ChristianityTimeline()
        {
            new SamaritanCalendar();
            ChristianDoctrine romanCatholicDoctrine = new ChristianDoctrine();
            new JulianCalendarInvented();
            new JesusBirth();
            new JesusDeath();
            new FirstCouncilOfNicaea(romanCatholicDoctrine);
            new HebrewCalendarStandardized();
            new FirstCouncilOfConstantinople(romanCatholicDoctrine);
            new CouncilOfCarthage(romanCatholicDoctrine);
            new CouncilOfEphesus(romanCatholicDoctrine);
            new CouncilOfChalcedon(romanCatholicDoctrine);
            new AnnoDominiDatingSystemCreated();
            new SecondCouncilOfOrange();
            new SecondCouncilOfConstantinople(romanCatholicDoctrine);
            new ThirdCouncilOfToledo();
            new HijriCalendarStart();
            new HijriCalendarFirstUsed();
            new ThirdCouncilOfConstantinople(romanCatholicDoctrine);
            new SecondCouncilOfNicaea(romanCatholicDoctrine);

            ChristianDoctrine easternOrthodoxDoctrine = new ChristianDoctrine(romanCatholicDoctrine);
            easternOrthodoxDoctrine.AddTimelessDoctrine("Christ has a real presence in the Eucharist", string.Empty);
            easternOrthodoxDoctrine.AddTimelessDoctrine("At death, the soul separates from the body, undergoes individual judgment with provisional experience of eternal orientation, awaiting resurrection of the body", string.Empty);
            easternOrthodoxDoctrine.AddTimelessDoctrine("The ancestral sin of Adam wounded human nature and introduced corruption and death into the world. All humans inherit this fallen condition through descent from Adam, resulting in a disordered inclination toward sin and a mortal condition. Though not guilty of Adam’s personal sin, each person enters a world estranged from God and in need of healing and communion through Christ.", string.Empty);
            easternOrthodoxDoctrine.AddTimelessDoctrine("Mary died a natural death, and at the moment of death, her soul was taken by Christ into heaven.", string.Empty);
            easternOrthodoxDoctrine.AddTimelessDoctrine("Additional sacraments: Monastic Tonsure, Consecration of a Church/Altar, Blessing of Holy Water, Imperial Coronation, Funeral Rites", string.Empty);
            romanCatholicDoctrine.AddTimelessDoctrine("Original (Adam's) sin caused real harm to human nature, all humans inherit this sin by propagation through human generation, it results in a loss of sanctifying grace, an inclination toward sin, and spiritual death (alienation from God requiring redemption through baptism).", string.Empty);

            new CatholicFourthCouncilOfConstantinople(romanCatholicDoctrine);
            new OrthodoxFourthCouncilOfConstantinople(easternOrthodoxDoctrine);
            new AdditionOfFilioqueToNiceneCreed(romanCatholicDoctrine);
            new GreatEastWestSchism();

            new FirstLateranCouncil(romanCatholicDoctrine);
            new SecondLateranCouncil(romanCatholicDoctrine);
            new ThirdLateranCouncil(romanCatholicDoctrine);
            new SynodOfVerona(romanCatholicDoctrine);
            new FourthLateranCouncil(romanCatholicDoctrine);
            new FirstCouncilOfLyon(romanCatholicDoctrine);
            new SecondCouncilOfLyon(romanCatholicDoctrine);
            new CouncilOfVienne(romanCatholicDoctrine);
            new CouncilOfConstance(romanCatholicDoctrine);
            new CouncilOfBaselFerreraFlorence(romanCatholicDoctrine);
            new FifthLateranCouncil(romanCatholicDoctrine);
            new CouncilOfTrent(romanCatholicDoctrine);
            new GregorianCalendarIntroduced();
            new ModernConclaveProcessDescribed();
            new PapalDeclarationOfTheImmaculateConception(romanCatholicDoctrine);
            new FirstVaticanCouncil(romanCatholicDoctrine);
            new PapalDeclarationOfTheAssumptionOfMary(romanCatholicDoctrine);
            new SecondVaticanCouncil(romanCatholicDoctrine);
        }

        /// <summary>
        /// Lunisolar calendar closely related to the ancient Hebrew
        /// tradition but maintained independently from Rabbinic Judaism.
        /// races its origins back to ancient Israelite times, likely as 
        /// far back as the First Temple period (before 586 BCE)—before 
        /// the Babylonian exile.
        /// </summary>
        public class SamaritanCalendar
        {
        }

        /// <summary>
        /// Sosigenes of Alexandria created solar calendar to align with the tropical year
        /// It was 11 minutes too long per year (tropical year is 365.2422 days)
        /// This caused a drift of about 1 day every 128 years, eventually misaligning 
        /// the date of the spring equinox and liturgical feasts like Easter.
        /// </summary>
        [Year(-45)]
        public class JulianCalendarInvented
        {
            public JulianCalendarInvented()
            {
            }
        }

        /// <summary>
        /// The Gospel of Matthew says Jesus was born during the reign of Herod the Great.
        /// Herod died in 4 BC, based on multiple ancient sources (Josephus, astronomical 
        /// records of an eclipse, etc.). This implies that Jesus was likely born between 
        /// 6 and 4 BC.
        /// </summary>
        [YearRange(-6, -4)]
        public class JesusBirth
        {
            public JesusBirth()
            {
            }
        }

        /// <summary>
        /// executed by crucifixion
        /// </summary>
        [YearRange(30, 33)]
        public class JesusDeath
        {
            public JesusDeath()
            {
            }
        }

        [CouncilNumber(1)]
        [Year(325)]
        public class FirstCouncilOfNicaea
        {
            public FirstCouncilOfNicaea(ChristianDoctrine doctrine)
            {
                doctrine.AddTimelessDoctrine("The Son is of the same substance as the Father", string.Empty);
                doctrine.AddStructuralDoctrine("Easter is the first Sunday on or after the vernal equinox.");
                doctrine.RejectDoctrine("There was a time when the Son was not");
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Arianism);
            }
        }

        /// <summary>
        /// Hebrew lunar-solar calendar standardization. 
        /// Hillel II, the Nasi (prince) of the Sanhedrin, introduced a fixed, calculated
        /// calendar. This was done because Roman persecution made it difficult to rely 
        /// on centralized witness-based declarations. The mathematical rules of month 
        /// lengths, leap years, and postponement rules (to avoid certain holidays 
        /// falling on inconvenient weekdays) were codified.
        /// 
        /// Metonic Cycle:
        /// 19 solar years ≈ 235 lunar months (less than 2 hour difference over 19 years)
        /// Hebrew calendar adds a leap month in 7/19 years. This keeps Jewish holidays,
        /// like passover in spring, from drifting into the wrong seasons.
        /// There is still a little drift, but since it's very slow, it's been
        /// acceptable for religious and cultural purposes.
        /// </summary>
        [Year(358)]
        public class HebrewCalendarStandardized
        {
            public HebrewCalendarStandardized()
            {
            }
        }

        /// <summary>
        /// Also:
        /// Canon 1: The faith of the 318 Fathers assembled at Nicaea in Bithynia shall not be set aside, but shall remain firm. And every 
        /// heresy shall be anathematized, and in particular that of the Eunomians, Arians, Macedonians (Pneumatomachians), Sabellians, 
        /// Marcellians, Photinians, and Apollinarians.
        /// Canon 3: The Bishop of Constantinople should have primacy of honor after the Bishop of Rome.
        /// </summary>
        [CouncilNumber(2)]
        [Year(381)]
        public class FirstCouncilOfConstantinople
        {
            public FirstCouncilOfConstantinople(ChristianDoctrine doctrine)
            {
                doctrine.AddTimelessDoctrine("The Holy Spirit is fully divine", string.Empty);
                doctrine.AddTimelessDoctrine("The Holy Spirit proceeds from the Father", string.Empty);
                doctrine.AddTimelessDoctrine("Jesus Christ is fully human", "What is not assumed is not healed");
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Arianism);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Apollinarianism);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Pneumatomachianism);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Sabellianism);
            }
        }

        /// <summary>
        /// regional council who affirmed:
        /// 1. Original sin is inherited by all humans through natural propagation, not imitation.
        /// 2. Infants need Baptism not just as a rite, but because they are born in a state of sin.
        /// 3. Salvation begins with grace, not human effort.
        /// 4. Adam’s sin affected the entire human race, damaging human nature.
        /// </summary>
        [Year(418)]
        public class CouncilOfCarthage
        {
            public CouncilOfCarthage(ChristianDoctrine doctrine)
            {
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Pelagianism);
            }
        }

        [CouncilNumber(3)]
        [Year(431)]
        public class CouncilOfEphesus
        {
            public CouncilOfEphesus(ChristianDoctrine doctrine)
            {
                doctrine.AddTimelessDoctrine("Jesus Christ is one divine person", "Mary is rightly called Theotokos (God-bearer)");
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Nestorianism);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Pelagianism);
            }
        }

        /// <summary>
        /// Two natures: Jesus is fully divine and fully human
        /// One person (hypostasis): These two natures exist in one unified person
        /// Without confusion/change: His natures aren't blended into a third hybrid nature
        /// Without division/separation: His divine and human natures aren't split into two persons
        /// </summary>
        [CouncilNumber(4)]
        [Year(451)]
        public class CouncilOfChalcedon
        {
            public CouncilOfChalcedon(ChristianDoctrine doctrine)
            {
                doctrine.AddTimelessDoctrine("Jesus Christ has two natures (divine and human) without confusion, change, division, or separation", string.Empty);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Monophysitism);
            }
        }

        /// <summary>
        /// Created by a monk named Dionysius Exiguus
        /// His goal was to replace the old system based on the reign of the Roman 
        /// Emperor Diocletian, who had persecuted Christians.
        /// Dionysius tried to identify the year of Jesus’ birth and labeled it 1 Anno Domini.
        /// He did not include a Year 0; the system jumps from 1 BC to AD 1.
        /// </summary>
        [Year(525)]
        public class AnnoDominiDatingSystemCreated
        {
            public AnnoDominiDatingSystemCreated()
            {
            }
        }

        /// <summary>
        /// responded to semi-Pelagianism
        /// Affirmed:
        /// 1. Grace is needed even for the beginning of fath
        /// 2. Original sin makes humans unable to save themselves
        /// 3. The will is free, but weakened and in need of healing.
        /// </summary>
        [Year(529)]
        public class SecondCouncilOfOrange
        {
            public SecondCouncilOfOrange()
            {

            }
        }

        /// <summary>
        /// reframed/clarified doctrine to be more compatible with Miaphysitism (restated per Cyril of Alexandria's language)
        /// </summary>
        [CouncilNumber(5)]
        [Year(553)]
        public class SecondCouncilOfConstantinople
        {
            public SecondCouncilOfConstantinople(ChristianDoctrine doctrine)
            {
                doctrine.AffirmDoctrine("Jesus Christ has two natures (divine and human) without confusion, change, division, or separation", "One incarnate nature of God the Word");
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Nestorianism);
            }
        }

        /// <summary>
        /// visigoth kingdom converted from Arian to Nicene Christianity
        /// Regionally added the phrase Filioque to the Nicene Creed
        /// "We believe in the Holy Spirit... who proceeds from the Father AND THE SON"
        /// </summary>
        [Year(589)]
        public class ThirdCouncilOfToledo
        {
            public ThirdCouncilOfToledo()
            {
            }
        }

        /// <summary>
        /// Hijri calendar starts the year of the Hijra—the migration of the Prophet 
        /// Muhammad and his followers from Mecca to Medina.
        /// </summary>
        [Year(622)]
        public class HijriCalendarStart
        {
            public HijriCalendarStart()
            {
            }
        }

        /// <summary>
        /// Caliph ʿUmar ibn al-Khaṭṭāb convened a council of companions (including 
        /// ʿAlī ibn Abī Ṭālib) to select a starting point for the new calendar.
        /// 
        /// They considered: 
        /// 1. the birth of the Prophet
        /// 2. the first revelation
        /// 3. the Hijra (migration) from Mecca to Medina (CHOSEN)
        /// 4. the Prophets death
        /// The Hijra was chosen because it marked the founding of the first Islamic
        /// comunity (ummah), and the beginning of Islam as a sociopolitical order,
        /// not just a religious message.
        /// 
        /// The Hijri calendar is a purely lunar calendar, governs the religious rhythm 
        /// of Islamic life, though most Muslim-majority countries also use the Gregorian 
        /// calendar for daily civil affairs.
        /// </summary>
        [Year(638)]
        public class HijriCalendarFirstUsed
        {
            public HijriCalendarFirstUsed()
            {
            }
        }

        [CouncilNumber(6)]
        [YearRange(680, 681)]
        public class ThirdCouncilOfConstantinople
        {
            public ThirdCouncilOfConstantinople(ChristianDoctrine doctrine)
            {
                doctrine.AddTimelessDoctrine("Jesus Christ has two wills—a divine will and a human will—united in one person, and the human will freely cooperates with the divine.", "Dyothelitism");
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Monothelitism);
            }
        }

        /// <summary>
        /// 1. Icons of Christ, Mary, angels, and saints may be displayed and venerated.
        /// 2. Veneration (honor) (to saints and sacred images) is distinct from worship (given to God alone)
        /// 3. The honor given to the image passes to its prototype
        /// 4. The Incarnation justifies sacred art.
        /// </summary>
        [CouncilNumber(7)]
        [Year(787)]
        public class SecondCouncilOfNicaea
        {
            public SecondCouncilOfNicaea(ChristianDoctrine doctrine)
            {
                doctrine.AddTimelessDoctrine("Icons may be displayed and venerated.", "If you deny images, you deny the humanity of Christ");
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Iconoclasm);
            }
        }

        /// <summary>
        /// The Pope of Rome holds primacy of jurisdiction over the universal Church.
        /// Bishops must practice clerical celibacy.
        /// Simony (buying or selling of church offices) is condemned as heresy.
        /// </summary>
        [CouncilNumber(8)]
        [YearRange(869, 870)]
        public class CatholicFourthCouncilOfConstantinople
        {
            public CatholicFourthCouncilOfConstantinople(ChristianDoctrine doctrine)
            {

            }
        }

        /// <summary>
        /// The Pope is respected as first among equals, but not as a universal juridical authority.
        /// Conciliar authority - major decisions are made through synods.
        /// </summary>
        [CouncilNumber(8)]
        [YearRange(879, 880)]
        public class OrthodoxFourthCouncilOfConstantinople
        {
            public OrthodoxFourthCouncilOfConstantinople(ChristianDoctrine doctrine)
            {
            }
        }

        [Year(1014)]
        public class AdditionOfFilioqueToNiceneCreed
        {
            public AdditionOfFilioqueToNiceneCreed(ChristianDoctrine doctrine)
            {
                doctrine.ReplaceDoctrine("The Holy Spirit proceeds from the Father and the Son", "The Holy Spirit proceeds from the Father");
            }
        }

        /// <summary>
        /// Issues:
        /// 1. Filioque
        /// 2. Centralized papal authority over conciliar synod-based authority
        /// 3. Unleavened (west) vs leavened (east) bread for Eucharist. East preferred leavened for symbolism of Christ rising,
        /// West prefered unleavened for historical accuracy with the last supper.
        /// </summary>
        [Year(1054)]
        public class GreatEastWestSchism
        {
            public GreatEastWestSchism()
            {

            }
        }

        /// <summary>
        /// resolved the investiture controversy: Only the Church—not secular rulers—has the authority to invest bishops with spiritual office.
        /// Reaffirmed clerical celibacy—no priests could marry.
        /// Condemned simony—the buying and selling of Church offices or sacraments.
        /// Declared that only validly elected popes and bishops had authority—trying to stop secular influence and anti-popes.
        /// </summary>
        [CouncilNumber(9)]
        [Year(1123)]
        public class FirstLateranCouncil
        {
            public FirstLateranCouncil(ChristianDoctrine doctrine)
            {
            }
        }

        /// <summary>
        /// resolved a disputed papal election between Innocent II and Anacletus II (who had died) in favor of Innocent II
        /// Excommunication for those who engaged in violence against clergy, churches, or Church property.
        /// simony and immoral clerical behavior were condemned in multiple canons
        /// married priests and their marriages were declared invalid
        /// Unauthorized lay movements were condemned especially armed bands or knightly orders or heretical groups
        /// </summary>
        [CouncilNumber(10)]
        [Year(1139)]
        public class SecondLateranCouncil
        {
            public SecondLateranCouncil(ChristianDoctrine doctrine)
            {
            }
        }

        /// <summary>
        /// Reformed papal elections (2/3 majority required), to prevent future minority-backed antipopes
        /// Simony condemned, clergy forbidden to charge feeds, hold multiple church offices without permission, keep
        /// mistresses or marry. Cathedral schools were to be established to educate future clergy.
        /// Set minimum age requirements for different clerical ranks.
        /// Knights and soldiers were forbidden to attack or rob the defenseless (e.g. clergy, pilgrims, merchants, farmers)
        /// </summary>
        [CouncilNumber(11)]
        [Year(1179)]
        public class ThirdLateranCouncil
        {
            public ThirdLateranCouncil(ChristianDoctrine doctrine)
            {
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Catharism);
                doctrine.AddStructuralDoctrine("A two-thirds majority of the College of Cardinals is required for a valid papal election.");
            }
        }

        /// <summary>
        /// dealing with heresies formalized
        /// </summary>
        [Year(1184)]
        public class SynodOfVerona
        {
            public SynodOfVerona(ChristianDoctrine doctrine)
            {
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Catharism);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Waldensians);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Humiliati);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Arnoldists);
            }
        }

        /// <summary>
        /// Annual confession and communion made mandatory
        /// urged Christian rulers to launch a new crusade to recover Jerusalem, 
        /// Set a timeline, funding mechanisms, and spiritual benefits (indulgences) for crusaders.
        /// Affirmed papal supremacy over spiritual matters
        /// Marriage/clerical behavior:
        /// 1. Prohibited clandestine marriages (had to be public and with witnesses)
        /// 2. Forbade marriage within certain degrees of kinship
        /// 3. Reaffirmed clerical celibacy
        /// 4. Forbade clergy from engaging in simony or other abuses
        /// </summary>
        [CouncilNumber(12)]
        [Year(1215)]
        public class FourthLateranCouncil
        {
            public FourthLateranCouncil(ChristianDoctrine doctrine)
            {
                doctrine.AddTimelessDoctrine("In the Eucharist, the substance of bread and wine becomes the body and blood of Christ", string.Empty);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Catharism);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.Waldensians);
            }
        }

        /// <summary>
        /// Tried to depose a sitting Holy Roman Emperor (Frederick II)
        /// called for a new Crusade—the Seventh Crusade
        /// Issued 22 canons for improving episcopal discipline, combating simony and nepotism, reinforcing clerical
        /// celibacy, addressing abuses in religious orders.
        /// authorized tithes and taxes for crusade support, measures to control and audit church finances, greater
        /// financial oversight of bishops and religious houses.
        /// Reaffirmed papal authority over bishop appointments, reorganized parts of curial administration
        /// </summary>
        [CouncilNumber(13)]
        [Year(1245)]
        public class FirstCouncilOfLyon
        {
            public FirstCouncilOfLyon(ChristianDoctrine doctrine)
            {

            }
        }

        /// <summary>
        /// tried to reunite Roman Catholic and Eastern Orthodox (Filioque and papal primacy), but did not take longterm
        /// Established the conclave system for papal elections
        /// 1. Cardinals must remain locked together ("con clave" = "with a key") until a pope is elected.
        /// 2. The conclave must take place in the city where the pope died, unless the cardinals vote unanimously to move.
        /// 3. After 3 days: only bread, wine, and water until a pope is elected
        /// 4. The election must be held in strict secrecy, with ballots cast and counted behind closed doors.
        /// 5. Cardinals were forbidden from receiving messages or influence from outside parties (especially monarchs).
        /// 6. Cardinals were required to assemble quickly after a pope’s death and begin voting promptly.
        /// planned a new crusade to retake the Holy Land
        /// Issued 31 canons, including stricter rules for bishop residence and responsibilities, regulations on
        /// benefices and simony, encouragement for education of clergy, guidance on relations with non-Christians
        /// 
        /// The Maronite Church (Lebanon) formally entered communion with Rome—a union that still exists today. They 
        /// were Chalcedonian, distinguishing them from non-Chalcedonian Syric Orthodox.
        /// </summary>
        [CouncilNumber(14)]
        [Year(1274)]
        public class SecondCouncilOfLyon
        {
            public SecondCouncilOfLyon(ChristianDoctrine doctrine)
            {
                doctrine.AddTimelessDoctrine("The souls of those who die in a state of mortal sin or with original sin only go down immediately into hell... but the souls of those who die in charity and are truly penitent... are purified after death, and they are soon admitted to the beatific vision of God.", string.Empty);
            }
        }

        /// <summary>
        /// Knights Templar were dissolved for the sake of peace and the Church's reputation. Templar properties were
        /// transferred to the Hospitallers (Knights of St. John)
        /// mandated the teaching of Arabic, Hebrew, and Syriac at several European universities
        /// renewed the call for a new crusade to the Holy Land, but this never happened.
        /// 
        /// Beguines and Beghards were rejected as heresy, but only the ones teaching heresy. Some of them were
        /// even considered saints.
        /// </summary>
        [CouncilNumber(15)]
        [YearRange(1311, 1312)]
        public class CouncilOfVienne
        {
            public CouncilOfVienne(ChristianDoctrine doctrine)
            {
                doctrine.RejectHeresy(OrthodoxChristianHeresy.FreeSpiritMovement);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.MargueritePorete);
            }
        }

        /// <summary>
        /// resolved the crisis of multiple popes (Rome/Avignon/Pisa)
        /// Asserted that a general council has authority over the pope—at least during crises (later retracted)
        /// </summary>
        [CouncilNumber(16)]
        [YearRange(1414, 1418)]
        public class CouncilOfConstance
        {
            public CouncilOfConstance(ChristianDoctrine doctrine)
            {
                doctrine.RejectHeresy(OrthodoxChristianHeresy.JohnWycliffe);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.JanHus);
            }
        }

        /// <summary>
        /// Resolved in favor of papal supremacy, reversing the conciliarist trend from the Council of Constance
        /// Attempted East-West reunion, Greek delegation agreed to accept Filioque, papal primacy, roman catholic positions
        /// on purgatory and bread, but was rejected in the east.
        /// 
        /// Union with other Eastern churches:
        /// 1. Maronite - affirmed, persisting to modern times
        /// 2. Chaldean Catholics (from Church of the East) - brief union, later broken and reestablished
        /// 3. Armenian Catholics (union proclaimed in 1439) - continued in small part
        /// 4. Coptic and Ethiopic delegations - temporary agreements reached, though not sustained
        /// 5. These efforts laid the foundation for the Eastern Catholic Churches (also called Uniate Churches).
        /// 
        /// Canon 8 of Council of Florence (1439): It is valid to use both leavened and unleavened bread, but the Latin Church 
        /// retains unleavened bread, especially to follow the institution of the Eucharist at the Last Supper.
        /// </summary>
        [CouncilNumber(17)]
        [YearRange(1431, 1445)]
        public class CouncilOfBaselFerreraFlorence
        {
            public CouncilOfBaselFerreraFlorence(ChristianDoctrine doctrine)
            {
                doctrine.AddTimelessDoctrine("Seven Sacraments: Baptism, Confirmation, Eucharist, Penance, Annointing the Sick, Holy Orders, Matrimony", string.Empty);
            }
        }

        /// <summary>
        /// Reaffirmed papal supremacy over ecumenical councils
        /// Condemned the idea that the human soul is mortal
        ///  Issued the first official Church censorship decree on printing, required all books to receive ecclesiastical 
        ///  approval (imprimatur) before publication. This was intended to control heretical ideas and prevent misinterpretations of 
        ///  doctrine. This marked the beginning of formal pre-publication censorship in the Church.
        ///  Called for a new crusade to reclaim the Holy Land, which never came to fruition
        ///  Approved the establishment of Monti di Pietà (Christian charitable pawnshops). These were Church-run lending 
        ///  institutions that offered low-interest loans to the poor as an alternative to usurious moneylenders.
        ///  The council declared them not sinful, as long as they were run justly.
        /// </summary>
        [CouncilNumber(18)]
        [YearRange(1512, 1517)]
        public class FifthLateranCouncil
        {
            public FifthLateranCouncil(ChristianDoctrine doctrine)
            {
                doctrine.RejectHeresy(OrthodoxChristianHeresy.AverroistAristotelians);
            }
        }

        /// <summary>
        /// A. Affirmed that Scripture and Apostolic Tradition are equally authoritative sources of divine revelation.
        /// B. Clearly defined the contents of the Bible for the first time in an ecumenical council.
        /// C. Justification comes by grace through faith, but it involves cooperation with grace, good works, and sacraments.
        /// D. Seven Sacraments Dogma (drawing a sharp line between Catholic orthodoxy and Protestant reformers)
        ///  1. Baptism doctrine rejected that Baptism is only a symbol of faith, or unnecssary for infants
        ///  2. Confirmation doctrine rejects that it was a redundant or invented rite, or not a sacrament
        ///  3. Eucharist doctrine rejects symbol-only presence, denial of sacrificial nature, or reception by faith alone without real transformation
        ///  4. Penance doctrine rejects sins can be forgiven without confession, or that absolution is unnecessary because only faith saves
        ///  5. Annointing of sick doctrine rejects it is unnecessary, ineffective, or only symbolic
        ///  6. Holy Orders doctrine rejects that priesthood is human invention, or all believers have the same spiritual authority
        ///  7. Matrimony doctrine rejects that marriage is just a civil contract, or that divorce and remarriage are permissible without annulment
        /// E. Clerical Reform. Required bishops to reside in their dioceses, improved seminary training for priests
        /// F. Prohibited buying and selling of church offices, restricted pluralism (holding multiple benefices at once)
        /// G. Called for the standardization of the Mass
        /// H. Required marriages to be publicly witnessed by a priest and two witnesses (to prevent clandestine marriages).
        /// I. Affirmed Roman Catholic version of original sin
        /// J. Papal Conclave Rules
        /// J-i. Established the formal use of written ballots (called "scrutiny") as the default voting method.
        /// J-ii. Voters were required to swear an oath that they were voting freely and without bribes, threats, or collusion.
        /// J-iii. A multi-step vote counting process was introduced to reduce fraud or miscounting.
        /// J-iv. Cardinals were reminded of their duty to vote for the good of the Church, not personal or political advantage.
        /// </summary>
        [CouncilNumber(19)]
        [YearRange(1545, 1563)]
        public class CouncilOfTrent
        {
            public CouncilOfTrent(ChristianDoctrine doctrine)
            {
                doctrine.AddTimelessDoctrine("Baptism remits original sin and all actual sin, initiates into the Church, absolutely necessary for salvation (or at least desire for it), inclination to sin remains", "I baptize you in the name of the Father, and of the Son, and of the Holy Spirit.");
                doctrine.AddTimelessDoctrine("Confirmation strengthens baptismal grace, confers the gifts of the Holy Spirit, important for full Christian life", "Be sealed with the gift of the Holy Spirit");
                doctrine.AddTimelessDoctrine("Penance forgives post-baptismal mortal sins, reconciles to the Church, includes contrition, confession, absolution, satisfaction, required for salvation if moral sin is present.", string.Empty);
                doctrine.AddTimelessDoctrine("Annointing the sick strengthens the soul, forgives sins, may restore bodily health, prepares for eternal life", string.Empty);
                doctrine.AddTimelessDoctrine("Holy Orders confers spiritual power to administer sacraments and lead the Church.", string.Empty);
                doctrine.AddTimelessDoctrine("Matrimony indissolubly unites man and woman in a bond of grace, sacramentally images Christ and the Church", string.Empty);
                doctrine.RejectHeresy(OrthodoxChristianHeresy.ProtestantReformation);
            }
        }

        /// <summary>
        /// By the 16th century, the Julian calendar had drifted about 10 days off the 
        /// seasonal cycle.
        /// 1. Leap year rule adjusted: every 4 years, except years divisible by 100,
        /// unless also divisible by 400
        /// 2. 10 days removed. October 4, 1582 followed by October 15, 1582.
        /// 3. Easter: Refined calculations for the date of Easter, keeping it near the 
        /// spring equinox.
        /// 
        /// Timeline:
        /// 1582: Initially adopted by Catholic countries (Italy, Spain, Portugal, Poland).
        /// 1700s–1900s: Gradually adopted by Protestant and Orthodox countries:
        /// - Britain and its colonies: 1752 (skipped 11 days)
        /// - Russia: 1918 (after the Bolshevik Revolution)
        /// - Greece: 1923
        /// Eastern Orthodox Churches still use the Julian calendar for some liturgical purposes.
        /// </summary>
        [Year(1582)]
        public class GregorianCalendarIntroduced
        {
            public GregorianCalendarIntroduced()
            {
            }
        }

        /// <summary>
        /// Three methods of Papal election:
        /// 1. Scrutiny: secret ballot voting—now the standard method.
        /// 2. Acclamation by Inspiration: spontaneous, unanimous agreement—no longer used
        /// 3. Election by Compromise: delegation of choice to a committee of cardinals—extremely rare and eventually fell out of use.
        /// Ballot Uniformity - three separate ballot forms
        /// 1. One for voting
        /// 2. One for re-examining votes (recongnitio)
        /// 3. One for approval or correction if needed
        /// Ballot secrecy: Removed the requirement to sign ballots, improving vote confidentiality and reducing peer pressure or intimidation.
        /// Formalized
        /// 1. Scrutineers: three cardinals chosen by lot to count votes,
        /// 2. Infirmarii: three cardinals who collected votes from those too ill to attend in person
        /// 3. Revisers: double-check vote counts for accuracy
        /// </summary>
        [Year(1621)]
        public class ModernConclaveProcessDescribed
        {
            public ModernConclaveProcessDescribed()
            {

            }
        }

        /// <summary>
        /// first example of papal infallibility in hindsight
        /// </summary>
        [Year(1854)]
        [PapalInfallibility]
        public class PapalDeclarationOfTheImmaculateConception
        {
            public PapalDeclarationOfTheImmaculateConception(ChristianDoctrine doctrine)
            {
                doctrine.AddTimelessDoctrine("Mary was conceived without original sin from the very first moment of her existence, by a special grace from God, in preparation for her role as the mother of Jesus.", string.Empty);
            }
        }

        /// <summary>
        /// 1. settled papal primacy and infallibility
        /// 2. Defined the relationship between faith and reason, and revelation.
        /// 2a. God's knowability. God can be known by reason alone (natural theology).
        /// But relevation is also necessary for full knowledge of salvation.
        /// 2b. Condemnation of errors: Rejected rationalism, materialism, and fideism (faith
        /// should reject or ignore reason). Affirmed that faith and reason do not conflict
        /// because both come from God.
        /// 3. Doctrinal precision on faith and dogma. Dogma can develop, but cannot change
        /// in substance. Emphasized permanence and consistency of Church doctrine, especially
        /// in light of modern relativism and liberal theology.
        /// </summary>
        [CouncilNumber(20)]
        [YearRange(1869, 1870)]
        public class FirstVaticanCouncil
        {
            public FirstVaticanCouncil(ChristianDoctrine doctrine)
            {
                doctrine.AddStructuralDoctrine("The pope has full, supreme, and universal jurisdiction over the entire Church—not just honorary primacy.");
                doctrine.AddTimelessDoctrine("The pope is infallible only when speaking ex cathedra (from the chair of Peter), intending to define a doctrine, on matters of faith or morals, to be held by the whole Church.", "Such definitions of the Roman Pontiff are of themselves, and not by the consent of the Church, irreformable.");
            }
        }

        [PapalInfallibility]
        [Year(1950)]
        public class PapalDeclarationOfTheAssumptionOfMary
        {
            public PapalDeclarationOfTheAssumptionOfMary(ChristianDoctrine doctrine)
            {
                doctrine.AddTimelessDoctrine("The Immaculate Mother of God, the ever Virgin Mary, having completed the course of her earthly life, was assumed body and soul into heavenly glory.", string.Empty);
            }
        }

        /// <summary>
        /// 1. Nature of the Church (Ecclesiology). Shift from institutional focus to a 
        /// communion model of the Church. The Church is the People of God, not just a hierarchy.
        /// 2. Revelation and Scripture. Divine revelation comes through both Sacred Scripture 
        /// and Sacred Tradition. Reaffirmed the inspiration and inerrancy of Scripture in 
        /// matters of salvation.
        /// 3. Liturgy and Worship. Allowed use of vernacular languages (instead of Latin) 
        /// in the liturgy.
        /// 4. Church in the Modern World. Addressed issues of culture, politics, economics, family, 
        /// and war. Affirmed human dignity, freedom of conscience, and the rights of the person.
        /// Recognized the Church’s role in promoting justice and peace. Called for dialogue 
        /// between the Church and the modern world.
        /// 5. Decree on Ecumenism. Recognized that non-Catholic Christians 
        /// share real elements of sanctification. Encouraged dialogue and cooperation with 
        /// Protestant and Orthodox churches. Condemned excessive triumphalism and urged humility.
        /// 6. Declaration on the Relation of the Church to Non-Christian Religions
        /// Affirmed truth and holiness in other religions, especially Judaism, Islam, 
        /// Hinduism, and Buddhism. Rejected anti-Semitism and clarified that Jews are not 
        /// collectively guilty for Christ's death.
        /// 7. Religious freedom. Every human person has a right to religious freedom and 
        /// should not be coerced in matters of faith.
        /// 8. Role of the Laity. Affirmed the lay vocation in family, work, society, and Church ministry.
        /// Encouraged lay involvement in evangelization, education, politics, and liturgy.
        /// 9. Renewal of Religious Life and Missions
        /// Perfectae Caritatis: renewal of religious orders according to their founding charisms.
        /// Ad Gentes: emphasis on missionary work and respect for local cultures.
        /// </summary>
        [CouncilNumber(21)]
        [YearRange(1962, 1965)]
        public class SecondVaticanCouncil
        {
            public SecondVaticanCouncil(ChristianDoctrine doctrine)
            {
            }
        }
    }

    public enum OrthodoxChristianHeresy
    {
        /// <summary>
        /// "There was a time when the Son was not"
        /// Timeline:
        /// 1. Absolute Pre-Existence (only the Father exists)
        /// 2. Eternal-But-Created Preexistence (The Son is begotten, mediator between the Father and Humanity)
        /// 3. Creation of the World
        /// 4. The Son's Incarnation in Time
        /// 
        /// This is controversial because it denies Christ's full divinity. The Eunomiusists went further saying the Son was
        /// unlike the Father.
        /// 
        /// Later History:
        /// 1. Became dominant in imperial circles until outlawed in the Roman Empire after 1st council of constantinople (381)
        /// 2. Survived among Germanic tribes in Western Europe
        /// 2a. Visigoths converted to Nicene Christianity at the third Council of Toledo
        /// 2b. Ostrogoths and Vandals were defeated by the Byzantines
        /// 2c. Burgundians converted gradually by the late 5th or early 6th century
        /// 2d. Lombards were the last significant Germanic tribe, with remnants still lingering into the late 7th century.
        /// </summary>
        Arianism,

        /// <summary>
        /// Jesus had a divine mind (Logos) but not a human rational mind. The Logos replaced the human intellect in Jesus.
        /// This was rejected because if Jesus was not fully human he cannot redeem humanity.
        /// 
        /// Apollinaris worked with a tripartite anthropology from Plato and Greek thought:
        /// 1. Human body
        /// 2. Human soul (psyche, emotions, desires, gives life, provides consciousness, impulses)
        /// 3. Human mind/spirit (rational faculty): thinks, understands, makes choices, knows right/wrong, connects with God through reason/contemplation
        /// The concern is if Jesus had a full human mind, he would be capable of choosing sin, just like Adam.
        /// 
        /// So the claim is Jesus had:
        /// 1. Human body
        /// 2. Human soul
        /// 3. Divine mind (replaces human mind)
        /// 
        /// </summary>
        Apollinarianism,

        /// <summary>
        /// The Holy Spirit is not God, but a created being or a power subordinate to the Son. This was rejected
        /// because it undermines the Trinity.
        /// </summary>
        Pneumatomachianism,

        /// <summary>
        /// AKA: Modalism, Patripassianism
        /// The Father, Son, and Holy Spirit are not distinct persons, but modes or roles of one God. This was rejected
        /// because it undermines relational structure of God
        /// </summary>
        Sabellianism,

        /// <summary>
        /// Christ exists as two persons:
        /// 1. Divine (Logos)
        /// 2. Human (Jesus of Nazareth)
        /// 
        /// Therefore, Mary should not be called Theotokos (God-bearer) but Christotokos (Christ-bearer).
        /// 
        /// This is controversial:
        /// - If Christ is two persons, how can we say God became man?
        /// - It divides the Incarnation, making it a partnership rather than a union.
        /// - It risks saying that God did not really suffer, die, or rise—only the human Jesus did.
        /// 
        /// Survived the Church of the East, centered in Persia, formally adopted this theology in the late 400s, spread East.
        /// However, it never called itself "Nestorian", which oversimplifies their Christology. The Church's later
        /// formulations toned down the "two persons" language, emphasizing a unified subject in Christ.
        /// 
        /// Survives in: Assyrian Church of the East, Ancient Church of the East, som in Iraq, Iran, Syria, and India
        /// Considered apostolic but non-Chalcedonian.
        /// </summary>
        Nestorianism,

        /// <summary>
        /// Christ is one person with one nature, mostly divine.
        /// 1. Christ was born of the Virgin Mary
        /// 2. He is truly divine, and He became incarnate
        /// 3. His human nature was united with the divinity in such a way that only one nature remained, a divine nature with human elements.
        /// </summary>
        Monophysitism,

        /// <summary>
        /// Non-Chalcedonian, but not heretical in intent (want to not divide Christ)
        /// 1. Christ is one person
        /// 2. Christ has one united nature that is fully divine and fully human
        /// 3. This nature is without confusion, change, division, or separation
        /// 
        /// Term favored by Cyril of Alexandria (One incarnate nature of God the Word)
        /// 
        /// Still exists as Oriental Orthodox Churches.
        /// 1. Coptic Orthodox Church (Egypt)
        /// 2. Syriac Orthodox Church
        /// 3. Armenian Apostolic Church
        /// 4. Ethiopian and Eritrean Orthodox Churches
        /// </summary>
        Miaphysitism,

        /// <summary>
        /// Jesus has only one will - a divine-human composite will - not a distinct human will alongside a divine one
        /// This was an attempt to heal the division between Chalcedonians (who said Christ had two natures) and Miaphysites 
        /// (who emphasized one united nature).
        /// 
        /// This undermines salvation because Christ must have a human will to redeem our will through obedient submission 
        /// to the Father.
        /// </summary>
        Monothelitism,

        /// <summary>
        /// Argued that icons violated the graven image prohibition in the second commandment
        /// God is invisible and transcendant
        /// </summary>
        Iconoclasm,

        /// <summary>
        /// aka Albigensianism
        /// Dualism: Belief in two opposing divine forces—one good (spirit) and one evil (matter).
        /// Anti-materialism: Physical world (including the human body) was evil; only the soul was good.
        /// Rejection of sacraments: Denied the validity of the Eucharist, baptism, marriage, etc.
        /// Opposed the clergy: Believed the institutional Church was corrupt and illegitimate.
        /// Ascetic lifestyle: The perfecti (elite Cathars) avoided meat, sex, and possessions.
        /// 
        /// Heresy because:
        /// Denied monotheism, rejected the goodness of creation, contradicted Genesis and the creed (creator of heaven
        /// and earth), denied the Incarnation, undermined the atonement (no real body, no real sacrifice)
        /// Rejected all Catholic sacraments, including Baptism, Eucharist, Confession, Marriage. Rejected the real
        /// presence of Christ in the Eucharist. Rejected apostolic succession. Repudiated ecclesiastical authority and 
        /// sacraments. Perfecti had inhumanly strict moral code, devalued physical existence.
        /// 
        /// After the Albigensian Crusade (1209–1229), Catharism went underground
        /// By the mid-14th century, Catharism had effectively disappeared
        /// Last known Cathar Perfectus (Guillaume Bélibaste) was burned at the stake in 1321
        /// </summary>
        Catharism,

        /// <summary>
        /// Scripture is the highest authority
        /// Ordinary Christians could preach the Gospel (not just ordained clergy)
        /// Valued a simple lifestyle, modeled on Jesus and the apostles
        /// Rejected: Purgatory, veneration of saints, transubstantiation, sacraments administered by unworthy priests,
        /// indulgences.
        /// 
        /// Still exists today as a small but active Protestant denomination called the Waldensian Evangelical Church
        /// </summary>
        Waldensians,

        /// <summary>
        /// preached publicly without permission, including laypeople and woman, violating the church teaching that only
        /// ordained clergy had the authority to preach doctrine
        /// They criticized wealthy clergy and called for a return to apostolic poverty, seen as anti-clerical
        /// They organized communities and spiritual fellowships outside Church oversight.
        /// 
        /// Eventually reconciled with the church (1201), but became wealthy and corrupt, and were suppressed entirely
        /// in 1571.
        /// </summary>
        Humiliati,

        /// <summary>
        /// Arnold's motto: “Clergy should own no property, and bishops should renounce political power.”
        /// Arnold argued that the Church should not rule over land or people—its only authority should be spiritual,
        /// which directly challenged the political structure of the medieval church (papal states and investiture system)
        /// Arnold taught that clergy should live in poverty, own no land, and not profit from their positions.
        /// He rejected the legitimacy of the sacraments if performed by priests who lived in sin or owned property.
        /// Arnold gathered a popular following, especially among the poor and politically disaffected in Rome.
        /// </summary>
        Arnoldists,

        /// <summary>
        /// lay Christian movements (mostly women and men, respectively) who lived in semi-monastic communities without formal 
        /// vows. Many were deeply devout and orthodox, but some adopted extreme mystical views
        /// Possible heresies:
        /// 1. Claims of spiritual perfection where the soul becomes indistinguishably united with God, no longer capable of sin
        /// 2. Rejection of Church authority and sacraments as unnecessary for the spiritually “perfect”
        /// 3. Some teachings aligned with the Free Spirit heresy
        /// </summary>
        BeguinesAndBeghards,

        /// <summary>
        /// That perfect souls become divine
        /// That such souls are no longer bound by moral laws
        /// That God and the soul are one and the same at the highest mystical level
        /// 
        /// considered dangerous pantheism and spiritual elitism
        /// some reformation-era radicals had overlapping ideas, as well as Anabaptists and Spiritualists.
        /// </summary>
        FreeSpiritMovement,

        /// <summary>
        /// A French Beguine, she authored The Mirror of Simple Souls, a mystical work describing the soul’s journey to 
        /// complete union with God. Her book taught that the annihilated soul can act without regard to virtue or sin because
        /// God acts entirely through it. Burned at the stake in Paris in 1310
        /// ideas were associated with Free Spirit heresy—seen as denying the need for sacraments, moral effort, or ecclesiastical mediation.
        /// </summary>
        MargueritePorete,

        /// <summary>
        /// English reformer who rejected transubstantiation, papal authority, clerical wealth, veneration of saints.
        /// declared a heretic, ordered his writings burned, and had his remains exhumed and thrown into a river in 1428.
        /// </summary>
        JohnWycliffe,

        /// <summary>
        /// Bohemian preacher influenced by Wycliffe
        /// Criticized ecclesiastical corruption, sale of indulgences, papal immorality
        /// Despite being promised safe conduct, Hus was imprisoned, tried, and burned at the stake in 1415.
        /// </summary>
        JanHus,

        /// <summary>
        /// All humans share one single, eternal intellect—sometimes called the “agent intellect”. Individual humans do not 
        /// have their own immortal, rational souls. At death, the individual’s intellect does not survive as a separate, 
        /// thinking substance.
        /// Some Averroists (especially at the University of Paris) were accused of teaching that a statement could be true 
        /// in philosophy but false in theology, or vice versa.
        /// Aristotle taught, and Averroists generally accepted, that the world has always existed (i.e., no beginning in time).
        /// This contradicted the Christian belief in creation ex nihilo (from nothing) at a specific moment.
        /// Some Averroists leaned toward a deterministic view of human behavior, seeing free will as an illusion.
        /// This conflicted with the Christian view of moral responsibility, sin, and grace.
        /// faded as a formal school in the 17th century, but influenced secular modern thought
        /// </summary>
        AverroistAristotelians,

        /// <summary>
        /// emphasizes human moral responsibility and freedom, but in ways that conflict with Christian teaching about grace and the fall.
        /// 1. Denial of Original Sin. Pelagius taught that Adam’s sin harmed only Adam, not humanity as a whole.
        /// Humans are born morally neutral, not with a sinful nature. There is no inherited guilt or fallen state transmitted to Adam’s descendants.
        /// 2. Baptism not necessary for infants. Since infants have no personal sin and do not inherit Adam’s guilt, baptism 
        /// is not necessary for their salvation. Baptism is useful for remission of personal sin and membership in the Church, 
        /// but not essential for all.
        /// 3. Grace is helpful, but not essential. God's grace consists of: Forgiveness of sins, the example of Christ,
        /// the teaching of Scripture. But human beings can achieve moral perfection and salvation without interior 
        /// grace—through free will and effort alone.
        /// 4. Human Will Is Always Free and Able to Choose Good
        /// Humans can, in any circumstance, choose good or evil without the need for special divine help.
        /// There is no internal weakness of the will (concupiscence) that makes sin inevitable or even likely.
        /// </summary>
        Pelagianism,

        /// <summary>
        /// Example protestant teachings:
        /// Sola Scriptura – Scripture alone is authoritative
        /// Sola Fide – Justification by faith alone
        /// Total depravity – Human nature totally corrupted
        /// Concupiscence is sin
        /// Only 2 sacraments (Baptism and Eucharist)
        /// Symbolic Eucharist
        /// No need for priestly confession
        /// Purgatory is unbiblical
        /// Indulgences are always corrupt
        /// </summary>
        ProtestantReformation,
    }
}

