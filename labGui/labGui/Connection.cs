using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labGui
{
    public class Connection
    {
        public static SqlConnection connect()
        {
            string connectionString = "Server=JAAFAR\\SQLEXPRESS;Database=labGuiAdvanced;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // Open the connection
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                return null; 
            }
        }
        public static void close()
        {
            if(connect != null)
            {
                connect().Close();
            }
            else
            {
                Console.WriteLine("its already not connected");
            }
        }

    }
}
