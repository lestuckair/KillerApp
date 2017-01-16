using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerApp.DAL.Interfaces;
using KillerApp.Models;

namespace KillerApp.DAL.MSSQL
{
    public class MssqlEventContext : IEvent
    {
        //SQL querry's
        public List<EventC> GetAllEvents()
        {
            throw new NotImplementedException();
        }

        public List<EventC> GetPossibleEvents()
        {
            throw new NotImplementedException();
        }

        public EventC GetEvent()
        {
            throw new NotImplementedException();
        }

        public bool PostEventResult()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllOptions()
        {
            throw new NotImplementedException();
        }
    }
}