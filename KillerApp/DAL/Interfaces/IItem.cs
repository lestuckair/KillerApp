using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillerApp.Models;

namespace KillerApp.DAL.Interfaces
{
    public interface IItem
    {
        List<Weapon> GetAllWeapons();
        List<Weapon> GetWeapons();
        List<Spell> GetAllSpells();
        List<Spell> Spells();
        List<UsableItem> GetAllUsableItems();
        List<UsableItem> UsableItems();
        Weapon GetWeapon();
        Spell GetSpell();
        UsableItem GetUsableItem();
        List<Item> GetAllItems();
        Item GetItem();
        bool SetWeapon();
        bool SetSpell();
        bool SetUsableItem();
        bool SetItem();
        bool UseItem();
        //Alle soorten sql methods
    }
}
