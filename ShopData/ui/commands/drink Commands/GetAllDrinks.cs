using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands.drink_Commands
{
    internal class GetAllDrinks : Command
    {
        public GetAllDrinks(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Получить список всех напитков";
        }

        public override void excecute()
        {
            GetConsoleUI().GetDrinksList();
        }
    }
}
