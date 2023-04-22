using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands.MilkProductsCommands
{
    internal class GetAllMilkProducts : Command
    {
        public GetAllMilkProducts(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Получить список всех молочных продуктов";
        }

        public override void excecute()
        {
            GetConsoleUI().GetMilkProductsList();
        }
    }
}
