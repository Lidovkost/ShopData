using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui.commands
{
    public abstract class Command : IOption
    {
        private ConsoleUI _consoleUI;
        public Command(ConsoleUI consoleUI) 
        {
            _consoleUI = consoleUI;
        }

        public abstract string Description();
        public abstract void excecute();

        protected ConsoleUI GetConsoleUI() 
        {
            return _consoleUI;
        }
    }
}
