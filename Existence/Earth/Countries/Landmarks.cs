using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existence.Earth.Countries
{
    internal class Landmarks
    {
        /// <summary>
        /// historical Cold War era wall separating West and East Berlin
        /// </summary>
        [Country(CountryLikeThings.Germany)]
        [WorldCity((int)WorldCities.GermanyBerlin)]
        public static class BerlinWall { }

        /// <summary>
        /// Built by the Romans in the 2nd century AD to protect their province of Britannia from northern tribes.
        /// </summary>
        [Country(CountryLikeThings.UnitedKingdom)]
        public static class HadriansWall { }

        [Country(CountryLikeThings.Israel)]
        [WorldCity((int)WorldCities.IsraelJerusalem)]
        public static class WesternOrWailingWall { }

        [Country(CountryLikeThings.UnitedStates)]
        [WorldCity((int)WorldCities.UnitedStatesWashingtonDC)]
        public static class VietnamVeteransMemorial { }

        /// <summary>
        /// remnants of related defensive structures can be found in Mongolia, the actual Great Wall itself remains 
        /// within the boundaries of China.
        /// </summary>
        [Country(CountryLikeThings.China)]
        public static class GreatWallOfChina { }

        /// <summary>
        /// Ancient defensive walls protecting the city of Constantinople (modern-day Istanbul) from invasions for over a 
        /// thousand years, still partially existing.
        /// </summary>
        [Country(CountryLikeThings.Turkey)]
        [WorldCity((int)WorldCities.TurkeyIstanbul)]
        public static class WallsOfConstantinople { }

        [WorldCity((int)WorldCities.WestBankJericho)]
        public static class WallsOfJericho { }
    }
}
