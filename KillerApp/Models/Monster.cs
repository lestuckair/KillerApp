using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp.Models
{
    public class Monster : Character
    {
        public string ClassName { get; set; }
        public string ClassType { get; set; }

        public Monster(string name, string race, int maxHp, int maxMp, int hp, int mp, int money, int level, string className, string classType) : base(name, race, maxHp, maxMp, hp, mp, money, level)
        {
            ClassName = className;
            ClassType = classType;
        }
    }
}