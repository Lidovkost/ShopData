using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands.MilkProductsCommands
{
    internal class GetInvalidMilkProducts : Command
    {
        public GetInvalidMilkProducts(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Получить список просроченных молочных продуктов";
        }

        public override void excecute()
        {
            GetConsoleUI().GetInvalidMilkProducts();
        }
    }
}
