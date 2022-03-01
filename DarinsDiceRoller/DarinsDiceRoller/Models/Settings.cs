using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DarinsDiceRoller.Models
{
    public class Settings
    {
        [PrimaryKey, AutoIncrement]
        public int SettingsId { get; set; }
        public string Colormode { get; set; }
    }
}
