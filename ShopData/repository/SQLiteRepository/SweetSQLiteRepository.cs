using ShopData.goods;
using ShopData.goods.products.sweets;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.repository.SQLiteRepository
{
    internal class SweetSQLiteRepository : ISweetRepository
    {
        private const string ConnectionString = "Data Source = D:\\winForms\\ShopData\\ShopData\\myGoods.db;" +
                                                " Version = 3; Pooling = true; Max Pool Size = 10;";
        public bool Add(Sweet sweet)
        {
            var connection = new SQLiteConnection(ConnectionString);
            try
            {
                connection.Open();
                var command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO sweets(typeName," +
                    " price, amount, validDate) VALUES(@TypeName, @price, @amount, @validDate)";
                command.Parameters.AddWithValue("@typeName", sweet.typeName);
                command.Parameters.AddWithValue("@price", sweet.price);
                command.Parameters.AddWithValue("@amount", sweet.amount);
                command.Parameters.AddWithValue("@validDate", sweet.validDate);
                command.Prepare();
                return command.ExecuteNonQuery() > 0;
            }
            finally { connection.Close(); }
        }

        public List<Sweet> GetAll()
        {
            var list = new List<Sweet>();
            var connection = new SQLiteConnection(ConnectionString);
            try
            {
                connection.Open();
                var command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM sweets";
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Sweet sweet = new Sweet();
                    sweet.Id = reader.GetInt32(0);
                    sweet.typeName = reader.GetString(1);
                    sweet.price = reader.GetInt32(2);
                    sweet.amount = reader.GetInt32(3);
                    sweet.validDate = new DateTime(reader.GetInt64(4));
                    list.Add(sweet);
                }
                return list;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Sweet> GetByPrice(int price)
        {
            return GetAll().Where(sweet => sweet.price <= price).ToList();
        }

        public List<Sweet> GetNoValidProducts()
        {
            return GetAll().Where(sweet => sweet.validDate < DateTime.Now).ToList();
        }
    }
}
