using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillerApp.Models;

namespace KillerApp.DAL.Interfaces
{
    public interface IEvent
    {
        List<EventC> GetAllEvents();
        List<EventC> GetPossibleEvents();
        EventC GetEvent();
        bool PostEventResult();
        List<string> GetAllOptions();
        
        //Alle soorten sql methods
    }
}
