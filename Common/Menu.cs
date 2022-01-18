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
            Console.WriteLine("[1] Start Auction.");
            Console.WriteLine("[2] Customer options.");
            Console.WriteLine("[3] Games options.");
            Console.WriteLine("[0] Close application.");
        }
        public void MainMenuCustomers()
        {
            Console.WriteLine("Choose action number:\n");
            Console.WriteLine("[1] Add customer.");
            Console.WriteLine("[2] Show customers.");
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
    }
}
