using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp.Models
{
    public class Spell : Item
    {
        public string Element { get; set; }
        public int ManaCost { get; set; }
        public Spell(string name, int damage, string description, string element, int manaCost) : base(name, damage, description)
        {
            Element = element;
            ManaCost = manaCost;
        }
    }
}