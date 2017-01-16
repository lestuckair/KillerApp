using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerApp.DAL.Interfaces;
using KillerApp.Models;

namespace KillerApp.DAL.MSSQL
{
    public class MssqlItemContext : IItem
    {
        //SQL querry's
        public List<Weapon> GetAllWeapons()
        {
            throw new NotImplementedException();
        }

        public List<Weapon> GetWeapons()
        {
            throw new NotImplementedException();
        }

        public List<Spell> GetAllSpells()
        {
            throw new NotImplementedException();
        }

        public List<Spell> Spells()
        {
            throw new NotImplementedException();
        }

        public List<UsableItem> GetAllUsableItems()
        {
            throw new NotImplementedException();
        }

        public List<UsableItem> UsableItems()
        {
            throw new NotImplementedException();
        }

        public Weapon GetWeapon()
        {
            throw new NotImplementedException();
        }

        public Spell GetSpell()
        {
            throw new NotImplementedException();
        }

        public UsableItem GetUsableItem()
        {
            throw new NotImplementedException();
        }

        public List<Item> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Item GetItem()
        {
            throw new NotImplementedException();
        }

        public bool SetWeapon()
        {
            throw new NotImplementedException();
        }

        public bool SetSpell()
        {
            throw new NotImplementedException();
        }

        public bool SetUsableItem()
        {
            throw new NotImplementedException();
        }

        public bool SetItem()
        {
            throw new NotImplementedException();
        }

        public bool UseItem()
        {
            throw new NotImplementedException();
        }
    }
}