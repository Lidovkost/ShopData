using ShopData.goods.products.drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.goods.Requests.product_requests
{
    public class MilkProductRequest : GoodRequest<MilkProduct>
    {
        public override MilkProduct Create()
        {
            MilkProduct milk = new MilkProduct
            {
                typeName = Program.GetText("Введите тип"),
                price = Convert.ToInt32(Program.GetText("Введите цену за единицу")),
                amount = Convert.ToInt32(Program.GetText("Введите количество")),
                validDate = new DateTime(Convert.ToInt64(Program.GetText("Введите дату в тиках)))"))),
                qrCode = Convert.ToInt32(Program.GetText("Введите QRcode продукта"))
            };
            return milk;
        }
    }
}
