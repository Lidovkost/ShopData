using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands
{
    internal class FinishCommand : Command
    {
        public FinishCommand(ConsoleUI consoleUI) : base(consoleUI)
        {
        }

        public override string Description()
        {
            return "закончить работу";
        }

        public override void excecute()
        {
            GetConsoleUI().Finish();
        }
    }
}
