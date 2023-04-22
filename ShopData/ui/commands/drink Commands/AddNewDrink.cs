using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands
{
    internal class AddNewDrink : Command
    {
        public AddNewDrink(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Добавить напиток";
        }

        public override void excecute()
        {
            GetConsoleUI().AddNewDrink();
        }
    }
}
