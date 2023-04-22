using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.goods.products
{
    public class Product
    {
        public string typeName { get; set; }
        public int price { get; set; }
        public int amount { get; set; }
        public DateTime validDate { get; set; }
        public int Id { get; set; }
        public override string ToString()
        {
            return "Тип: " + typeName + " цена: " + price + " количесвто: " + amount + " годен до: " + validDate;
        }


    }
}
