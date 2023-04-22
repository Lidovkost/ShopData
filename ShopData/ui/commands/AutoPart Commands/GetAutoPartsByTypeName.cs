using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands.AutoPart_Commands
{
    internal class GetAutoPartsByTypeName : Command
    {
        public GetAutoPartsByTypeName(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Найти автомобильную запчать по типу";
        }

        public override void excecute()
        {
            GetConsoleUI().GetAutoPartsByTypeName();
        }
    }
}
