using ShopData.goods.products.drinks;
using ShopData.goods.Requests;
using ShopData.goods.Requests.product_requests;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShopData.repository.SQLiteRepository
{
    internal class DrinkSQLiteRepository : IDrinkRepository
    {
        private const string ConnectionString = "Data Source = D:\\winForms\\ShopData\\ShopData\\myGoods.db;" +
                                                " Version = 3; Pooling = true; Max Pool Size = 10;";
        public bool Add(Drink drink)
        {
            var connection = new SQLiteConnection(ConnectionString);
            try
            {
                connection.Open();
                var command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO drinks(typeName, price, amount, validDate)" +
                    " VALUES(@TypeName, @price, @amount, @validDate)";
                command.Parameters.AddWithValue("@typeName", drink.typeName);
                command.Parameters.AddWithValue("@price", drink.price);
                command.Parameters.AddWithValue("@amount", drink.amount);
                command.Parameters.AddWithValue("@validDate", drink.validDate.Ticks);
                command.Prepare();
                return command.ExecuteNonQuery() > 0;
            }
            finally { connection.Close(); }
        }

        public List<Drink> GetAll()
        {
            var list = new List<Drink>();
            var connection = new SQLiteConnection(ConnectionString);
            try
            {
                connection.Open();
                var command = new SQLiteCommand(connection); 
                command.CommandText = "SELECT * FROM drinks";
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Drink drink = new Drink();
                    drink.Id = reader.GetInt32(0);
                    drink.typeName = reader.GetString(1);
                    drink.price = reader.GetInt32(2);
                    drink.amount = reader.GetInt32(3);
                    drink.validDate = new DateTime(reader.GetInt64(4));
                    list.Add(drink);
                }
                return list;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Drink> GetNoValidProducts()
        {
            return GetAll().Where(date => date.validDate < DateTime.Now).ToList();
        }
    }
}
