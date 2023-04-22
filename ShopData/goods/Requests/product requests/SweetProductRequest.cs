using ShopData.goods.products.sweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.goods.Requests.product_requests
{
    public class SweetProductRequest : GoodRequest<Sweet>
    {
        public override Sweet Create()
        {
            Sweet sweet = new Sweet
            {
                typeName = Program.GetText("Введите тип"),
                price = Convert.ToInt32(Program.GetText("Введите цену")),
                amount = Convert.ToInt32(Program.GetText("Введите количество")),
                validDate = new DateTime(Convert.ToInt64(Program.GetText("Введите дату в тиках)))")))
            };
            return sweet;
        }
    }
}
