using System;
using System.Collections.Generic;
using System.Text;

namespace DarinsDiceRoller.Models
{
    public enum MenuItemType
    {
        Main,
        Dice,
        Credits,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }
        public string Title { get; set; }
    }
}
