using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands.SweetProducts_Commands
{
    internal class GetAllSweets : Command
    {
        public GetAllSweets(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "Получить список всех сладостей";
        }

        public override void excecute()
        {
            GetConsoleUI().GetSweetsList();
        }
    }
}
