// See https://aka.ms/new-console-template for more information
using System.Data;
using BookSales;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pkcs;

ClassConnection.Open();

// string strSql = "insert into BookSale values(1, 'Inside C#', 2, 150000)";
// MySqlCommand mySqlCommand = new MySqlCommand(strSql, ClassConnection.mySqlConnection);
// mySqlCommand.ExecuteNonQuery();
// System.Console.WriteLine("Insert successfully");

// int id = Convert.ToInt32(Console.ReadLine());
// int quantity = Convert.ToInt32(Console.ReadLine());
// string strSql = "update BookSale set quantity = @quantity where saleID = @id";
// MySqlCommand mySqlCommand = new MySqlCommand(strSql, ClassConnection.mySqlConnection);
// mySqlCommand.Parameters.AddWithValue("@id", id);
// mySqlCommand.Parameters.AddWithValue("@quantity", quantity);
// mySqlCommand.ExecuteNonQuery();
// System.Console.WriteLine("Update successfully");

// string strSql = "select * from BookSale";
// MySqlCommand mySqlCommand = new MySqlCommand(strSql, ClassConnection.mySqlConnection);
// MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
// while(dataReader.Read()){
//   int id = dataReader.GetInt32(0);
//   string title = dataReader.GetString(1);
//   int quantity = dataReader.GetInt32(2);
//   double price = dataReader.GetDouble(3);
//   System.Console.WriteLine("{0}\t{1}\t{2}\t{3}", id, title, quantity, price);
// }

// string strSql = "select * from BookSale";
// MySqlCommand mySqlCommand = new MySqlCommand(strSql, ClassConnection.mySqlConnection);
// MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
// DataSet dataSet = new DataSet();
// mySqlDataAdapter.Fill(dataSet, "BookSale");
// foreach(DataRow row in dataSet.Tables["BookSale"].Rows){
//   int id = Convert.ToInt32(row[0].ToString());
//   string title = row[1].ToString();
//   int quantity = Convert.ToInt32(row[2].ToString());
//   double price = Convert.ToDouble(row[3].ToString());
//   System.Console.WriteLine("{0}\t{1}\t{2}\t{3}", id, title, quantity, price);
// }

ClassConnection.Close();