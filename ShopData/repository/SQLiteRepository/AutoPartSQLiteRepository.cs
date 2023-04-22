using LiteDB;
using ShopData.goods.autoPart;
using ShopData.goods.products.sweets;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.repository.SQLiteRepository
{
    internal class AutoPartSQLiteRepository : IAutoPartRepository
    {
        private const string ConnectionString = "Data Source = D:\\winForms\\ShopData\\ShopData\\myGoods.db;" +
                                                " Version = 3; Pooling = true; Max Pool Size = 10;";
        public bool Add(AutoPart autopart)
        {
            var connection = new SQLiteConnection(ConnectionString);
            try
            {
                connection.Open();
                var command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO autoParts(typeName," +
                    " price, amount, brand) VALUES(@TypeName, @price, @amount, @brand)";
                command.Parameters.AddWithValue("@typeName", autopart.typeName);
                command.Parameters.AddWithValue("@price", autopart.price);
                command.Parameters.AddWithValue("@amount", autopart.amount);
                command.Parameters.AddWithValue("@brand", autopart.brand);
                command.Prepare();
                return command.ExecuteNonQuery() > 0;
            }
            finally { connection.Close(); }
        }

        public List<AutoPart> GetAll()
        {
            var list = new List<AutoPart>();
            var connection = new SQLiteConnection(ConnectionString);
            try
            {
                connection.Open();
                var command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM autoParts";
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    AutoPart autoPart = new AutoPart();
                    autoPart.Id = reader.GetInt32(0);
                    autoPart.typeName = reader.GetString(1);
                    autoPart.price = reader.GetInt32(2);
                    autoPart.amount = reader.GetInt32(3);
                    autoPart.brand = reader.GetString(4);
                    list.Add(autoPart);
                }
                return list;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<AutoPart> GetByBrand(string brandName)
        {
            return GetAll().Where(autopart => autopart.brand.Equals(brandName)).ToList();
        }

        public List<AutoPart> GetByTypeName(string typeName)
        {
            return GetAll().Where(autopart => autopart.typeName.Equals(typeName)).ToList();
        }
    }
}
