using System;
using System.Collections.Generic;
using System.Linq;

namespace Game_Store
{
    class Program
    {
        private static void MainLoop()
        {
            bool exit = false;
            Menu menu = new Menu();
            menu.MainMenu();

            //  CustomerAction customerAction = new CustomerAction();
            //   ItemAction itemAction = new ItemAction();
            //   AuctionAction auctionAction = new AuctionAction();
            //   Common.GenerateSampleData();

            Customer customer = new Customer();
            Item item = new Item();

            List<Customer> customers = new List<Customer>();
            List<Item> items = new List<Item>();

            while (!exit)
            {
                int input = Common.GetInt("Select: ", "Please select number from [0] to [5]");
                
                switch (input)
                {
                    case 1:
                        // start new auction
                        //   auctionAction.StartNewAuction();
                        break;
                    case 2:
                        Console.Clear();
                        // add new item
                        item.AddNewItem();
                        break;
                    case 3:
                        Console.Clear();
                        // show all items
                        ItemBase.ShowItem(items);
                        break;
                    case 4:
                        Console.Clear();
                        // add new customer
                        customer.AddNewCustomer();
                        break;
                    case 5:
                        Console.Clear();
                        // show all customers
                        CustomerBase.ShowCustomer(customers);
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input - try again");
                        break;
                }
                menu.MainMenu();
            }
        }
        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}
