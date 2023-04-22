using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.repository
{
    internal interface IProductRepository<T> : IRepository<T>
    {
        List<T> GetNoValidProducts();
    }
}
