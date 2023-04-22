using ShopData.goods.products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.goods
{
    public class MilkProduct : Product

    {
        public int qrCode { get; set; }
        public override string ToString()
        {
            return base.ToString() + " QRcode: " + qrCode;
        }



    }
}
