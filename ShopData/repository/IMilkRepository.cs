using ShopData.goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.repository
{
    internal interface IMilkRepository : IProductRepository<MilkProduct>
    {
        MilkProduct GetBYQRcode(int code);
    }
}
