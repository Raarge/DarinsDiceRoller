using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DarinsDiceRoller.Models
{
    public class D20Character
    {
        [PrimaryKey, AutoIncrement]
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }
}
