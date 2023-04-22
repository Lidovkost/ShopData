using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands
{
    internal class AddnewAutoPart : Command
    {
        public AddnewAutoPart(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Добавить новую автомобильную запчасть";
        }

        public override void excecute()
        {
            GetConsoleUI().AddNewAutoPart();
        }
    }
}
