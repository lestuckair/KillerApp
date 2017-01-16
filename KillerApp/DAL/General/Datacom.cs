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
                    "Data Source=mssql.fhict.local; Database=dbi339843; User Id=dbi339843; Password= Bwn4v$UZ";
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