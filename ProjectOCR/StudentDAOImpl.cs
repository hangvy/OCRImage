using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietOCR.NET
{
    public class StudentDAOImpl : DBConnection
    {
        public void insertStudenInfor(string idStudent, string fullName, string className)
        {
            if (dbConnect())
            {
                string sql = "INSERT INTO student (idstudent,fullname,classname) VALUES(@idstudent, @fullname,@classname)";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@idstudent", idStudent);
                cmd.Parameters.AddWithValue("@fullname", fullName);
                cmd.Parameters.AddWithValue("@classname", className);
                try
                {
                    cmd.ExecuteNonQuery();
                  
                }
                catch (Exception e)
                {
                    Console.WriteLine("insert not success");
                }
                
            }
        }
    }
}
