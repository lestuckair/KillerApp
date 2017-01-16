using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerApp.DAL.Interfaces;

namespace KillerApp.DAL.Repository
{
    public class EventRepository
    {
        private IEvent eventRepository;

        public EventRepository(IEvent eventRepository)
        {
            this.eventRepository = eventRepository;
        }
    }
}