using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands
{
    internal class AddnewMilkProduct : Command
    {
        public AddnewMilkProduct(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Добавить молочную продукцию ";
        }

        public override void excecute()
        {
            GetConsoleUI().AddNewMilkProduct();
        }
    }
}
