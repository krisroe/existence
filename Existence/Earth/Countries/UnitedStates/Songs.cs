using System;
using System.Collections.Generic;
using System.Text;

namespace Existence.Earth.Countries.UnitedStates
{
    public enum UnitedStatesSongs
    {
        StarSpangledBanner,
        TakeMeOutToTheBallGame,
    }

    public class SongAttribute : SingularObjectAttribute
    {
        public int Song { get; set; }
        public SongAttribute(int Song)
        {
            this.Song = Song;
        }
    }
}
