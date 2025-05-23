﻿using System;
using Existence.Earth.Alphabet;
using Existence.Earth.FieldsOfStudy.Mathematics;
using Existence.Time;

namespace Existence.Earth.Sports
{
    public class RetiredWhenAttribute : YearDateAttribute
    {
        public RetiredWhenAttribute(int Year, int Month, int Day) : base(Year, Month, Day) { }
    }

    public class ChampionshipLoserAttribute : TextAttribute
    {
        public string Loser
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
        public ChampionshipLoserAttribute(string Loser) : base(Loser)
        {

        }
    }

    public class ChampionAttribute : TextAttribute
    {
        public string Champion
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
        public ChampionAttribute(string Champion) : base(Champion)
        {

        }
    }

    public class RegularSeasonGameCountAttribute : NumberAttribute
    {
        public RegularSeasonGameCountAttribute(int Number) : base(Number) { }
    }

    public class SuperBowlNumberAttribute : NumberAttribute
    {
        public SuperBowlNumberAttribute(int Number) : base(Number) { }        
    }

    public class RecordAttribute : Attribute
    {
        public string Record { get; set; }
        public RecordAttribute(string Record)
        {
            this.Record = Record;
        }
    }

    public class ScorigamiLevel : NumberAttribute
    {
        public int Level
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
        public ScorigamiLevel(int Level) : base(Level)
        {

        }
    }

    public class WinnerAttribute : TextAttribute
    {
        public string Winner
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
        public WinnerAttribute(string Winner) : base(Winner)
        {
        }
    }

    /// <summary>
    /// MVP = most valuable player
    /// </summary>
    public class MVPAttribute : TextAttribute
    {
        public string MVP
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
        public MVPAttribute(string MVP) : base(MVP)
        {
        }
    }

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

    public class StartsAttribute: NumberAttribute
    {
        public int Starts
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

        public StartsAttribute(int Starts) : base(Starts)
        {

        }
    }

    public class GamesAttribute: NumberAttribute
    {
        public int Games
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
        public GamesAttribute(int Games) : base (Games)
        {

        }
    }
}
