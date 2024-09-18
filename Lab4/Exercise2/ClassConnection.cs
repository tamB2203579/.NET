using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class ClassConnection
    {
        public static MySqlConnection mySqlConnection;
        public static string strCon = "Host=localhost; Database=QLCB; uid=root; pwd=123456";
        public static void Open()
        {
            mySqlConnection = new MySqlConnection(strCon);
            mySqlConnection.Open();
            System.Console.WriteLine("Connect successfully");
        }

        public static void Close()
        {
            mySqlConnection.Close();
        }
    }
}
