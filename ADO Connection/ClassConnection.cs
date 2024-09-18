using  MySql.Data;
using MySql.Data.MySqlClient;

namespace BookSales;

public class ClassConnection{
  public static MySqlConnection mySqlConnection;
  public static string strCon = "Host=localhost; Database=BookSales; uid=root; pwd=123456";
  
  public static void Open(){
    mySqlConnection = new MySqlConnection(strCon);
    mySqlConnection.Open();
    System.Console.WriteLine("Connect successfully");
  }

  public static void Close(){
    mySqlConnection.Close();
  }
}