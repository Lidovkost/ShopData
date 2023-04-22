using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands.AutoPart_Commands
{
    internal class GetAutoPartsByBrand : Command
    {
        public GetAutoPartsByBrand(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Найти автомобильную запчать по брэнду";
        }

        public override void excecute()
        {
            GetConsoleUI().GetAutoPartsByBrand();
        }
    }
}
