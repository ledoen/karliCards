﻿using System;

namespace karliCards.Gui
{
    [Serializable]
    public class GameOptions
    {
        public bool PlayAgainstComputer { get; set; }
        public int NumberOfPlayers { get; set; }
        public int MinutesBeforeLoss { get; set; }
        public ComputerSkillLevel ComputerSkill { get; set; }
    }
    [Serializable]
    public enum ComputerSkillLevel
    { 
        Dumb,
        Good,
        Cheats
    }
}
