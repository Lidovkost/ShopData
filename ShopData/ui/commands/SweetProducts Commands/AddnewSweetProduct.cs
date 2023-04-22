using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands
{
    internal class AddnewSweetProduct : Command
    {
        public AddnewSweetProduct(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Добавить новую сладость";
        }

        public override void excecute()
        {
            GetConsoleUI().AddNewSweetProduct();
        }
    }
}
