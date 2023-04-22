using ShopData.ui.commands;
using ShopData.ui.commands.AutoPart_Commands;
using ShopData.ui.commands.drink_Commands;
using ShopData.ui.commands.MilkProductsCommands;
using ShopData.ui.commands.SweetProducts_Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopData.ui
{
    public class Menu
    {
        private ConsoleUI _consoleUi;
        private List<IOption> commands;
        public Menu(ConsoleUI conoleUI) 
        {
            _consoleUi = conoleUI;
            commands = new List<IOption>
            {
                new AddNewDrink(_consoleUi),
                new AddnewAutoPart(_consoleUi),
                new AddnewMilkProduct(_consoleUi),
                new AddnewSweetProduct(_consoleUi),
                new GetAllAutoParts(_consoleUi),
                new GetAllDrinks(_consoleUi),
                new GetAllMilkProducts(_consoleUi),
                new GetAllSweets(_consoleUi),
                new GetAutoPartsByBrand(_consoleUi),
                new GetAutoPartsByTypeName(_consoleUi),
                new GetInvalidSweets(_consoleUi),
                new GetInvalidMilkProducts(_consoleUi),
                new GetInvalidDrinks(_consoleUi),
                new GetSweetsByPrice(_consoleUi),
                new FinishCommand(_consoleUi),
            };
        }
        public void Excecute(int number)
        {
            commands[number-1].excecute();
        }
        public void PrintMenu()
        {
            int i = 1;
            foreach (IOption option in commands) 
            {
                Console.WriteLine(i++ +") " + option.Description());
            }
        }
    }
}
