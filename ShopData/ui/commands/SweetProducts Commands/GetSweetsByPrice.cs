using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands.SweetProducts_Commands
{
    internal class GetSweetsByPrice : Command
    {
        public GetSweetsByPrice(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Отсорировать сладости по цене";
        }

        public override void excecute()
        {
            GetConsoleUI().GetSweetsByPrice();
        }
    }
}
