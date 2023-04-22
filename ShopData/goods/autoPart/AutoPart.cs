using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.goods.autoPart
{
    public class AutoPart
    {
        public int Id { get; set; }
        public string brand { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        public string typeName { get; set; }
        public override string ToString()
        {
            return "Тип: " + typeName + " цена: " + price + " количесвто: " + amount + " брэнд: " + brand;
        }

    }
}
