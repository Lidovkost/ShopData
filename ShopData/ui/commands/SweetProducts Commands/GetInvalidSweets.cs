using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands.SweetProducts_Commands
{
    internal class GetInvalidSweets : Command
    {
        public GetInvalidSweets(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Получить список просроченных сладостей";
        }

        public override void excecute()
        {
            GetConsoleUI().GetInvalidSweets();
        }
    }
}
