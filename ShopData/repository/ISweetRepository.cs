using ShopData.goods.products.sweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.repository.SQLiteRepository
{
    internal interface ISweetRepository : IProductRepository<Sweet>
    {
        List<Sweet> GetByPrice(int price);
    }
}
