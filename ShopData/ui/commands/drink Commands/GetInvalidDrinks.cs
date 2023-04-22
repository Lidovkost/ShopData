using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands.drink_Commands
{
    internal class GetInvalidDrinks : Command
    {
        public GetInvalidDrinks(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Получить список просроченных напитков";
        }

        public override void excecute()
        {
            GetConsoleUI().GetInvalidDrinks();
        }
    }
}
