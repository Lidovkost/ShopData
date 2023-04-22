using ShopData.goods.autoPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.repository
{
    internal interface IAutoPartRepository : IRepository<AutoPart>
    {
        List<AutoPart> GetByTypeName(string typeName);
        List<AutoPart> GetByBrand(string brandName);
    }
}
