using ShopData.goods.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.goods
{
    public abstract class GoodRequest<T> 
    {
        public abstract T Create();
    }
}
