using ShopData.goods.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.repository
{
    internal interface IRepository<T>
    {
        bool Add(T t);
        List<T> GetAll();
    }
}
