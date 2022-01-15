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
            Console.WriteLine("[2] Add item.");
            Console.WriteLine("[3] Show items.");
            Console.WriteLine("[4] Add customer.");
            Console.WriteLine("[5] Show customers.");
            Console.WriteLine("[0] Close application.");
        }
    }
}
