using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Existence.Earth.Alphabet;

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

        [Country(CountryLikeThings.PalestineWestBank)]
        [WorldCity((int)WorldCities.WestBankJericho)]
        public static class WallsOfJericho { }

        /// <summary>
        /// highly fortified border wall and security barriers dividing North and South Korea
        /// </summary>
        [Countries(CountryLikeThings.NorthKorea, CountryLikeThings.SouthKorea)]
        public static class KoreanDemilitarizedZone { }

        /// <summary>
        /// dividing wall and buffer zone separating the Greek Cypriot and Turkish Cypriot communities in Cyprus.
        /// </summary>
        [Countries(CountryLikeThings.CyprusSouth, CountryLikeThings.CyprusNorth)]
        public static class CyprusGreenLine { }

        /// <summary>
        /// A series of barriers and fencing along the U.S.-Mexico border, built for immigration control and national security.
        /// </summary>
        [Countries(CountryLikeThings.UnitedStates, CountryLikeThings.Mexico)]
        public static class USMexicoBorderWall { }

        [Countries(CountryLikeThings.Poland)]
        [WorldCity((int)WorldCities.PolandOświęcim)]
        public static class AuschwitzConcentrationCampWall { }

        /// <summary>
        /// The legendary city walls of ancient Troy, made famous by Homer’s Iliad, although the connection between the
        /// real walls and the Iliad is questionable
        /// </summary>
        [Countries(CountryLikeThings.Turkey)]
        [WorldCity((int)WorldCities.TurkeyHisarlık)]
        public static class WallsOfTroy { }

        /// <summary>
        /// A graffiti-covered wall in Prague that became a symbol of freedom and resistance against oppression.
        /// </summary>
        [Countries(CountryLikeThings.CzechRepublic)]
        [WorldCity((int)WorldCities.CzechRepublicPrague)]
        public static class LennonWall { }

        /// <summary>
        /// Walls built to separate Protestant and Catholic communities in Belfast and other areas during The Troubles.
        /// </summary>
        [Countries(CountryLikeThings.NorthernIreland)]
        [WorldCity((int)WorldCities.NorthernIrelandBelfast)]
        public static class PeaceWalls { }

        [TODO("something")]
        public static class PinkFloydsTheWall { }
    }
}
