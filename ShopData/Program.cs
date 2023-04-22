using System.Data.SQLite;
using System.Diagnostics;
using ShopData.goods;
using ShopData.goods.products;
using ShopData.goods.products.drinks;
using ShopData.presenter;
using ShopData.ui;
using static System.Net.Mime.MediaTypeNames;

namespace ShopData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Текущая дата: " + DateTime.Now.Ticks);
            ConfigureSqlLiteConnection();
            IView console = new ConsoleUI();
            new Presenter(console);
            console.Start();

        }
        private static void ConfigureSqlLiteConnection()
        {
            string connectionString = "Data Source = D:\\winForms\\ShopData\\ShopData\\myGoods.db; Version = 3; Pooling = true; Max Pool Size = 10;";
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            PrepareSchema(connection);
        }

        private static void PrepareSchema(SQLiteConnection connection)
        {
            var command = new SQLiteCommand(connection);
            try
            {
                command.CommandText =
                    @"CREATE TABLE drinks(
                    id INTEGER PRIMARY KEY,
                    typeName TEXT,
                    price INT,
                    amount INT,
                    validDate INT)";
                command.ExecuteNonQuery();
                command.CommandText =
                    @"CREATE TABLE milkProducts(
                    id INTEGER PRIMARY KEY,
                    typeName TEXT,
                    price INT,
                    amount INT,
                    validDate INT,
                    qrCode INT)";
                command.ExecuteNonQuery();
                command.CommandText =
                    @"CREATE TABLE sweets(
                    id INTEGER PRIMARY KEY,
                    typeName TEXT,
                    price INT,
                    amount INT,
                    validDate INT)";
                command.ExecuteNonQuery();
                command.CommandText =
                    @"CREATE TABLE autoParts(
                    id INTEGER PRIMARY KEY,
                    typeName TEXT,
                    price INT,
                    amount INT,
                    brand TEXT)";
                command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
        }
        public static string GetText(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
    }
    
}