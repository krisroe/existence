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

    public class CouncilNumberAttribute : Attribute
    {
        public int Number { get; set; }
        public CouncilNumberAttribute(int Number)
        {
            this.Number = Number;
        }
    }

    internal class RomanCatholicDoctrine
    {
        public List<string> TimelessDoctrine { get; set; }
        public RomanCatholicDoctrine()
        {
            TimelessDoctrine = new List<string>();
        }
    }

    internal class RomanCatholicTimeline
    {
        

        public RomanCatholicTimeline()
        {
            RomanCatholicDoctrine doctrine = new RomanCatholicDoctrine();
            new FirstCouncilOfNicaea(doctrine);
           
        }

        [CouncilNumber(1)]
        [Year(325)]
        public class FirstCouncilOfNicaea
        {
            public FirstCouncilOfNicaea(RomanCatholicDoctrine doctrine)
            {
            }
        }

        [CouncilNumber(2)]
        [Year(381)]
        public class FirstCouncilOfConstantinople
        {
            public FirstCouncilOfConstantinople(RomanCatholicDoctrine doctrine)
            {
            }
        }

        [CouncilNumber(3)]
        [Year(431)]
        public class CouncilOfEphesus
        {
            public CouncilOfEphesus(RomanCatholicDoctrine doctrine)
            {

            }
        }

        [CouncilNumber(4)]
        [Year(451)]
        public class CouncilOfChalcedon
        {
        }

        [CouncilNumber(5)]
        [Year(553)]
        public class SecondCouncilOfConstantinople
        {
        }

        [CouncilNumber(6)]
        [YearRange(680, 681)]
        public class ThirdCouncilOfConstantinople
        {
        }

        [CouncilNumber(7)]
        [Year(787)]
        public class SecondCouncilOfNicaea
        {
        }

        [CouncilNumber(8)]
        [YearRange(869, 870)]
        public class CatholicFourthCouncilOfConstantinople
        {
        }

        [CouncilNumber(8)]
        [YearRange(879, 880)]
        public class OrthodoxFourthCouncilOfConstantinople
        {
        }

        [Year(1054)]
        public class GreatEastWestSchism
        {
        }

        [CouncilNumber(9)]
        [Year(1123)]
        public class FirstLateranCouncil
        {
        }

        [CouncilNumber(10)]
        [Year(1139)]
        public class SecondLateranCouncil
        {
        }

        [CouncilNumber(11)]
        [Year(1179)]
        public class ThirdLateranCouncil
        {
        }

        [CouncilNumber(12)]
        [Year(1215)]
        public class FourthLateranCouncil
        {
        }

        [CouncilNumber(13)]
        [Year(1245)]
        public class FirstCouncilOfLyon
        {
        }

        [CouncilNumber(14)]
        [Year(1274)]
        public class SecondCouncilOfLyon
        {
        }

        [CouncilNumber(15)]
        [YearRange(1311, 1312)]
        public class CouncilOfVienne
        {            
        }

        [CouncilNumber(16)]
        [YearRange(1414, 1418)]
        public class CouncilOfConstance
        {
        }

        [CouncilNumber(17)]
        [YearRange(1431, 1445)]
        public class CouncilOfBaselFerreraFlorence
        {            
        }

        [CouncilNumber(18)]
        [YearRange(1512, 1517)]
        public class FifthLateranCouncil
        {
        }

        [CouncilNumber(19)]
        [YearRange(1545, 1563)]
        public class CouncilOfTrent
        {
        }

        [CouncilNumber(20)]
        [YearRange(1869, 1870)]
        public class FirstVaticanCouncil
        {
        }

        [CouncilNumber(21)]
        [YearRange(1962, 1965)]
        public class SecondVaticanCouncil
        {
        }
    }
}
