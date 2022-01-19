using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class Menu
    {
        public void MainMenu()
        {
            Console.WriteLine("Choose action number:\n");
            Console.WriteLine("[1] Check the guide.");
            Console.WriteLine("[2] Customer options.");
            Console.WriteLine("[3] Games options.");
            Console.WriteLine("[0] Close application.");
        }
        public void MainMenuCustomers()
        {
            Console.WriteLine("Choose action number:\n");
            Console.WriteLine("[1] Add customer.");
            Console.WriteLine("[2] Remove customer.");
            Console.WriteLine("[3] Show customers.");
            Console.WriteLine("[0] Return to the previous menu.");
        }
        public void MainMenuGames()
        {
            Console.WriteLine("Choose action number:\n");
            Console.WriteLine("[1] Buy game.");
            Console.WriteLine("[2] Sell game.");
            Console.WriteLine("[3] Show categories.");
            Console.WriteLine("[0] Return to the previous menu.");
        }
        public void MainMenuCategories()
        {
            Console.WriteLine("Choose action number:\n");
            Console.WriteLine("[1] Survival");
            Console.WriteLine("[2] RPG");
            Console.WriteLine("[3] FPS");
            Console.WriteLine("[4] Action");
            Console.WriteLine("[5] All games with details");
            Console.WriteLine("[0] Return to the main menu.");
        }

        public void MainMenuWelcome()
        {
            Console.WriteLine("              Welcome to ---Game_Shop---\n\n");
            Console.WriteLine(" In this App you will be able to create your Customer account, \n buy and sell games and browse to find a game just for you. \n");
        }

        public void MainMenuGuide()
        {
            Console.WriteLine("              Welcome to the Guide!\n\n");
            Console.WriteLine("In order to procceed choose from keybord specific digit \nmostly from [0] to [5] as in instruction \n");
            Console.WriteLine("Sometimes you could be asked to input specific word \nlike type of a game [RPG]/[FPS] or confirm specific action \nlike [Y]/[N] refer to YES or NO\n");
            Console.WriteLine("Furthermore just follow the instruction and have fun!\n");
        }
    }
}
