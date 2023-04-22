using ShopData.goods.autoPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.goods.Requests.autoPartRequest
{
    public class AutoPartRequest : GoodRequest<AutoPart>
    {
        public override AutoPart Create()
        {
            AutoPart autoPart = new AutoPart
            {
                typeName = Program.GetText("Введите тип товара"),
                brand = Program.GetText("Введите брэнд"),
                amount = Convert.ToInt32(Program.GetText("Введите количество")),
                price = Convert.ToInt32(Program.GetText("Введите цену за единицу товара"))
            };
            return autoPart;
        }
    }
}
