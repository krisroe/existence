
using Existence.Time;

namespace Existence.Earth.Countries.UnitedStates
{

    public enum USStates
    {
        Alabama,
        Alaska,
        Arizona,
        Arkansas,
        California,
        Colorado,
        Connecticut,
        Delaware,
        Florida,
        Georgia,
        Hawaii,
        Idaho,
        Illinois,
        Indiana,
        Iowa,
        Kansas,
        Kentucky,
        Louisiana,
        Maine,
        Maryland,
        Massachusetts,
        Michigan,
        Minnesota,
        Mississippi,
        Missouri,
        Montana,
        Nebraska,
        Nevada,
        NewHampshire,
        NewJersey,
        NewMexico,
        NewYork,
        NorthCarolina,
        NorthDakota,
        Ohio,
        Oklahoma,
        Oregon,
        Pennsylvania,
        RhodeIsland,
        SouthCarolina,
        SouthDakota,
        Tennessee,
        Texas,
        Utah,
        Vermont,
        Virginia,
        Washington,
        WestVirginia,
        Wisconsin,
        Wyoming
    }

    public static class PoliticalPhilosophies
    {
        public static class Communist { }
        public static class Conservative { }
        public static class Environmentalist { }
        public static class Liberal { }
        public static class Libertarian { }        
        public static class Socialist { }
    }

    public static class PoliticalParties
    {
        public static class FirstPastThePostMeansTwoPartySystem
        {
            public static class Republican { }
            public static class Democratic { }
        }
        public static class StableThirdParties
        {
            public static class Green { }
            public static class Libertarian { }
        }
    }

    public static class PotentialNewStates
    {
        public static class DelicatePoliticalBalancePreventsAddingStatesUnlessFavorsNeitherSide { }
        public static class WashingtonDC
        {
            public static class HaveElectoralCollegeVotes { }
        }
        public static class PuertoRico
        {
            public static class CurrentlyACommonwealth { }

            /// <summary>
            /// Statehood:        620,782 (58.61% of valid votes)
            /// Free Association: 313,259 (29.57% of valid votes)
            /// Independence:     125,171 (11.82% of valid votes)
            /// Invalid votes:     23,141
            /// Blank votes:      181,200
            /// Note: "Commonwealth" was NOT an option for this referendum, caused many voters to return blank/invalid ballots
            /// </summary>
            [YearDate(2024, 11, 5)]
            public static class NonBindingReferendum { }
        }
    }
}
