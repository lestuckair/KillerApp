using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp.Models
{
    public class Item
    {
        public int Damage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Item(string name, int damage, string description)
        {
            Name = name;
            Damage = damage;
            Description = description;
        }

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
            Damage = 0;
        }
    }
}