using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerApp.Models
{
    public class EventC
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string Option { get; set; }
        public DateTime DateTime { get; set; }

        public EventC(string type, string description, string option, DateTime dateTime)
        {
            Type = type;
            Description = description;
            Option = option;
            DateTime = dateTime;
        }
    }
}