using System.Collections.Generic;
using System.Text;
using Existence.Beyond.Infrastructure;
using Existence.Earth.Alphabet;
using Existence.Earth.War;
using Existence.Time;

namespace Existence.Beyond.CosmicCurrency
{
    [CosmicProcessResponsibility(CosmicProcess.RealityManipulation, CosmicResponsibility.Responsible)]
    [CosmicTimeScale(CosmicTimeScale.HumanShortTerm, CosmicTimeInterval.Days)]
    [WorkTicket("WCP-9501")]
    internal class TimeTravelingMessageBox : CosmicPaydayBase
    {
        private enum VersionHistory
        {
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 3, 7)]
            Created,

            [BeyondObjectVersion(1, 1, 0, 0)]
            [YearDate(2025, 3, 24)]
            Internalized
        }

        internal override List<CosmicPayday> GetCosmicPayday()
        {
            return new List<CosmicPayday>()
            {
                new CosmicPayday(1, "Small work ticket completed successfully.")
            };
        }
        internal string Consequences
        {
            get
            {
                return "Subsequent reality manipulation not handled responsibly in the human short term (months).";
            }
        }
    }

    internal class IsraelPalestineCosmicCharity : CosmicCharityBase
    {
        private enum VersionHistory
        {
            [BeyondObjectVersion(1, 0, 0, 0)]
            [YearDate(2025, 3, 7)]
            Created,

            [BeyondObjectVersion(1, 1, 0, 0)]
            [YearDate(2025, 3, 24)]
            Internalized
        }

        internal override List<CosmicCharity> GetCosmicCharity()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("I intuit the post October 7th Gaza Hostage Crisis is a level 8 problem (nearly 256 hostages)");
            sb.AppendLine("I imagine the target can use all the help he can get with being a hostage for over a year and wife and children dead.");

            return new List<CosmicCharity>()
            {
               
                new CosmicCharity(1, (int)HostageList.BibasYarden, sb.ToString())
            };
        }
    }
}