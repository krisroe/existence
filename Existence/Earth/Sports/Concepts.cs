using Existence.Earth.FieldsOfStudy.Mathematics;

namespace Existence.Earth.Sports
{
    public class GamePointsTieScore : NumberAttribute
    {
        public int TieScore
        {
            get
            {
                return base.Number;
            }
            set
            {
                base.Number = value;
            }
        }
        public GamePointsTieScore(int TieScore) : base(TieScore)
        {

        }
    }

    public class GamePointsWinnerAndLoserScore : NumbersBinary
    {
        public int WinningPoints
        {
            get
            {
                return base.NumberOne;
            }
            set
            {
                base.NumberOne = value;
            }
        }
        public int LosingPoints
        {
            get
            {
                return base.NumberTwo;
            }
            set
            {
                base.NumberTwo = value;
            }
        }
        public GamePointsWinnerAndLoserScore(int WinningPoints, int LosingPoints) : base(WinningPoints, LosingPoints)
        {
        }
    }

    public class TeamWinLossTieRecord : NumbersTrinary
    {
        public int Wins
        {
            get
            {
                return base.NumberOne;
            }
            set
            {
                base.NumberOne = value;
            }
        }
        public int Losses
        {
            get
            {
                return base.NumberTwo;
            }
            set
            {
                base.NumberTwo = value;
            }
        }
        public int Ties
        {
            get
            {
                return base.NumberThree;
            }
            set
            {
                base.NumberThree = value;
            }
        }
        public TeamWinLossTieRecord(int Wins, int Losses, int Ties) : base(Wins, Losses, Ties)
        {
        }
    }
}
