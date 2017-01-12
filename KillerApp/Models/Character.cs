using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp.Models
{
    public class Character
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public int MaxHp { get; set; }
        public int MaxMp { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public int Money { get; set; }
        public int Level { get; set; }

        public Character(string name, string race, int maxHp, int maxMp, int hp, int mp, int money, int level)
        {
            Name = name;
            Race = race;
            MaxHp = maxHp;
            MaxMp = maxMp;
            Hp = hp;
            Mp = mp;
            Money = money;
            Level = level;
        }
    }
}