using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerApp.DAL.Interfaces;

namespace KillerApp.DAL.Repository
{
    public class AreaRepository
    {
        private IArea areaContext;

        public AreaRepository(IArea areaContext)
        {
            this.areaContext = areaContext;
        }
    }
}