using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp.Models
{
    public class Area
    {
        public string WorldName { get; set; }
        public string AreaType { get; set; }
        public string AreaName { get; set; }
        public string AreaDescription { get; set; }
        public string BonusEffect { get; set; }

        public Area(string worldName, string areaType, string areaName, string areaDescription, string bonusEffect)
        {
            WorldName = worldName;
            AreaType = areaType;
            AreaName = areaName;
            AreaDescription = areaDescription;
            BonusEffect = bonusEffect;
        }
    }
}