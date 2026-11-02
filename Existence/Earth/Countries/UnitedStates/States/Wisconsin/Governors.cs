namespace Existence.Earth.Countries.UnitedStates.States.Wisconsin
{
    /// <summary>
    /// gubernatorial tenures, named by the year the tenure started
    /// </summary>
    public static class Governors
    {
        /// <summary>
        /// resigned after being confirmed as US Secretary of Health and Human Services
        /// </summary>
        [Governor((int)WisconsinPoliticians.ThompsonTommy, 1987, 1, 5, 2001, 2, 1)]
        public static class v1987 { }

        /// <summary>
        /// lieutenant governor who took over when Thompson resigned
        /// </summary>
        [Governor((int)WisconsinPoliticians.McCallumScott, 2001, 2, 1, 2003, 1, 6)]
        public static class v2001 { }

        [Governor((int)WisconsinPoliticians.DoyleJim, 2003, 1, 6, 2011, 1, 3)]
        public static class v2003 { }

        [Governor((int)WisconsinPoliticians.WalkerScott, 2011, 1, 3, 2019, 1, 7)]
        public static class v2011 { }

        [Governor((int)WisconsinPoliticians.EversTony, 2019, 1, 7)]
        [CurrentGovernor]
        public static class v2019 { }
    }
}
