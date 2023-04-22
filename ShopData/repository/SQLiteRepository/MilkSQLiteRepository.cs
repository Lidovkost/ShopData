using LiteDB;
using ShopData.goods;
using ShopData.goods.products.drinks;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.repository.SQLiteRepository
{
    public class MilkSQLiteRepository : IMilkRepository
    {
        private const string ConnectionString = "Data Source = D:\\winForms\\ShopData\\ShopData\\myGoods.db;" +
                                                " Version = 3; Pooling = true; Max Pool Size = 10;";
        public bool Add(MilkProduct milk)
        {
            
            var connection = new SQLiteConnection(ConnectionString);
            try
            {
                connection.Open();
                var command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO milkProducts(typeName," +
                    " price, amount, validDate, qrCode ) VALUES(@TypeName, @price, @amount, @validDate, @qrCode)";
                command.Parameters.AddWithValue("@typeName", milk.typeName);
                command.Parameters.AddWithValue("@price", milk.price);
                command.Parameters.AddWithValue("@amount", milk.amount);
                command.Parameters.AddWithValue("@validDate", milk.validDate);
                command.Parameters.AddWithValue("qrCode", milk.qrCode);
                command.Prepare();
                return command.ExecuteNonQuery() > 0;
            }
            finally { connection.Close(); }
        }

        public List<MilkProduct> GetAll()
        {
            var list = new List<MilkProduct>();
            var connection = new SQLiteConnection(ConnectionString);
            try
            {
                connection.Open();
                var command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM milkProducts";
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MilkProduct milk = new MilkProduct();
                    milk.Id = reader.GetInt32(0);
                    milk.typeName = reader.GetString(1);
                    milk.price = reader.GetInt32(2);
                    milk.amount = reader.GetInt32(3);
                    milk.validDate = new DateTime(reader.GetInt64(4));
                    milk.qrCode = reader.GetInt32(5);
                    list.Add(milk);
                }
                return list;
            }
            finally
            {
                connection.Close();
            }
        }

        public MilkProduct GetBYQRcode(int code)
        {
            return GetAll().Find(milk => milk.qrCode == milk.qrCode);
        }

        public List<MilkProduct> GetNoValidProducts()
        {
            return GetAll().Where(milk => milk.validDate < DateTime.Now).ToList();
        }
    }
}
