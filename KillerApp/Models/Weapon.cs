using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp.Models
{
    public class Weapon : Item
    {
        public bool Equipped { get; set; }

        public Weapon(string name, int damage, string description, bool equipped) : base(name, damage, description)
        {
            Equipped = equipped;
        }
    }
}