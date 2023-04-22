using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands
{
    public interface IOption
    {
        string Description();
        void excecute();

    }
}
