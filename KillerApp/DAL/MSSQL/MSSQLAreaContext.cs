using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerApp.DAL.General;
using KillerApp.DAL.Interfaces;
using KillerApp.Models;

namespace KillerApp.DAL.MSSQL
{
    public class MssqlAreaContext : IArea
    {
        //SQL querry's
        public List<Area> GetAllAreas()
        {
            List<Area> _areas = new List<Area>();
            Datacom.OpenConnection();



            Datacom.CloseConnection();
            return _areas;
        }
    }
}