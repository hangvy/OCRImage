using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietOCR.NET
{
    public class DBConnection
    {
        public string conn { get; set; }
        public MySqlConnection connection;
        public Boolean dbConnect()
        {
            try
            {
                conn = "Server=localhost;Database=doantn;Uid=root;Pwd=root;";
                connection = new MySqlConnection(conn);
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("connect not success");
                return false;
            }
        }

        public  Boolean closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("close not success");
                return false;
            }
        }


    }
}
