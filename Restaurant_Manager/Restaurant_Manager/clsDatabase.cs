using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant_Manager
{
    internal class clsDatabase
    {
        public static SqlConnection conn;
        public static bool OpenConnection()
        {
            try
            {
<<<<<<< HEAD
                conn = new SqlConnection("Server=HNGHIA;Database=ResManager;uid=sa;pwd=sa2008");
=======
                conn = new SqlConnection("Server=HXPDONG;Database=ResManager;integrated security=true");
>>>>>>> 16d12173520ae1e7011231f6341d21ea3643398f
                conn.Open();
            }
            catch (Exception ex) { return false; }
            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex) { return false; }
            return true;
        }
    }
}
