using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KillerApp.DAL.General
{
    public static class Datacom
    {
        public static SqlConnection connect { get; set; }

        
        public static bool OpenConnection()
        {
            connect = new SqlConnection();

            try
            {
                connect.ConnectionString =
                    "Server=localhost;Database=KillerApp;";
                connect.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            if (connect.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CloseConnection()
        {
            connect.Close();
        }
    }
}