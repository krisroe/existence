
using System;
using System.ComponentModel.DataAnnotations;

namespace Existence.Earth.Human
{
    internal class Limitations
    {
        /// <summary>
        /// 44724 days
        /// </summary>
        public static TimeSpan MaximumFemaleAge;

        /// <summary>
        /// 42422 days
        /// </summary>
        public static TimeSpan MaximumMaleAge;

        static Limitations()
        {
            DateTime dtOldestPersonBirth, dtOldestPersonDeath;

            dtOldestPersonBirth = new DateTime(1875, 2, 21);
            dtOldestPersonDeath = new DateTime(1997, 8, 4);
            MaximumFemaleAge = dtOldestPersonDeath - dtOldestPersonBirth;

            dtOldestPersonBirth = new DateTime(1897, 4, 19);
            dtOldestPersonDeath = new DateTime(2013, 6, 12);
            MaximumMaleAge = dtOldestPersonDeath - dtOldestPersonBirth;
        }
    }
}
