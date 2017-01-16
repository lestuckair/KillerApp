using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp.Models
{
    public class Player
    {
        public string Gender { get; set; }
        public string HairColor { get; set; }
        public string TypeFace { get; set; }
        public int Age { get; set; }
        public int Xp { get; set; }
        public string ClassName { get; set; }
        public string ClassType { get; set; }

        //public Player(string name, string race, int maxHp, int maxMp, int hp, int mp, int money, int level, string gender, string hairColor, string typeFace, int age, int xp, string className, string classType) : base(name, race, maxHp, maxMp, hp, mp, money, level)
        //{
        //    Gender = gender;
        //    HairColor = hairColor;
        //    TypeFace = typeFace;
        //    Age = age;
        //    Xp = xp;
        //    ClassName = className;
        //    ClassType = classType;
        //}
    }
}