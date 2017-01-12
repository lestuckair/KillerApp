using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp.Models
{
    public class UsableItem : Item
    {
        public int Amount { get; set; }

        public UsableItem(string name, int damage, string description, int amount) : base(name, damage, description)
        {
            Amount = amount;
        }

        public UsableItem(string name, string description, int amount) : base(name, description)
        {
            Amount = amount;
        }
    }
}