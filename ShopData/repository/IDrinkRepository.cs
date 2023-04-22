using ShopData.goods.products.drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.repository
{
    interface IDrinkRepository : IProductRepository<Drink>
    {
    }
}
