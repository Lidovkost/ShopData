using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands.AutoPart_Commands
{
    internal class GetAllAutoParts : Command
    {
        public GetAllAutoParts(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Получить полный список автомобильных запчестей";
        }

        public override void excecute()
        {
            GetConsoleUI().GetAutoPartList();
        }
    }
}
