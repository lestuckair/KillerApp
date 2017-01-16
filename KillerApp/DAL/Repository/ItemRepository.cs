using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerApp.DAL.Interfaces;

namespace KillerApp.DAL.Repository
{
    public class ItemRepository
    {
        private IItem itemRepository;

        public ItemRepository(IItem itemRepository)
        {
            this.itemRepository = itemRepository;
        }
    }
}