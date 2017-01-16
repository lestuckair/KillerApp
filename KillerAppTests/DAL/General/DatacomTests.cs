using Microsoft.VisualStudio.TestTools.UnitTesting;
using KillerApp.DAL.General;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp.DAL.General.Tests
{
    [TestClass]
    public class DatacomTests
    {
        [TestMethod]
        public void OpenConnectionTest()
        {
            Datacom.OpenConnection();
            int id = 0;
            SqlCommand cmd = new SqlCommand("SELECT ID from karakter where leeftijd = 28",
                                                    Datacom.connect);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["ID"]);

            }
            reader.Close();
            cmd.Dispose();
            Datacom.CloseConnection();
            Assert.AreEqual(1, id);
        }
    }
}