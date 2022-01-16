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
            bool back = false;
            Menu menu = new Menu();

            //  CustomerAction customerAction = new CustomerAction();
            //   ItemAction itemAction = new ItemAction();
            //   AuctionAction auctionAction = new AuctionAction();
            //   Common.GenerateSampleData();

            GamesBase.GetInstance();
            CustomerBase.GetInstance();

            Customer customer = new Customer();
            Games game = new Games();
            Categories category = new Categories();

            List<Customer> customers = new List<Customer>();
            List<Games> games = new List<Games>();
            List<Categories> categories = new List<Categories>();

            while (!exit)
            {
                //show menu and switch case options
                menu.MainMenu();
                int input = Common.GetInt("Select: ", "Please select number from [0] to [3].");
                
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        // not implemented------------------------------------------------
                        // start new auction
                        //   auctionAction.StartNewAuction();
                        break;

                    case 2://CUSTOMER OPTIONS
                        Console.Clear();
                        while (!back)
                        {
                            menu.MainMenuCustomers();
                            int input1 = Common.GetInt("Select: ", "Please select number from [0] to [2].");
                            switch (input1)
                            {
                                case 1:
                                    Console.Clear();
                                    // Add new customer
                                    CustomerBase.AddNewCustomer();
                                    break;
                                case 2:
                                    Console.Clear();
                                    // Show all customers
                                    CustomerBase.ShowCustomer(customers);
                                    break;
                                case 0:
                                    Console.Clear();
                                    // Go back to previous menu
                                    back = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input - try again.");
                                    break;
                            }
                        }
                        break;

                    case 3://GAME OPTIONS
                        Console.Clear();
                        while (!back)
                        {
                            menu.MainMenuGames();
                            int input2 = Common.GetInt("Select: ", "Please select number from [0] to [3].");
                            switch (input2)
                            {
                                case 1:
                                    Console.Clear();
                                    GamesBase.BuyGame();
                                    break;
                                case 2:
                                    Console.Clear();
                                    // Sell game
                                    GamesBase.SellGame();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.Clear();
                                    while (!back)
                                    {
                                        menu.MainMenuCategories();
                                        int input1 = Common.GetInt("Select: ", "Please select number from [0] to [4].");
                                        switch (input1)
                                        {
                                            case 1:
                                                CategoriesBase.ShowCategories(categories);
                                                break;
                                            case 2:
                                                CategoriesBase.ShowCategories(categories);
                                                break;
                                            case 3:
                                                CategoriesBase.ShowCategories(categories);
                                                break;
                                            case 4:
                                                CategoriesBase.ShowCategories(categories);
                                                break;
                                            case 0:
                                                Console.Clear();
                                                back = true;
                                                break;
                                            default:
                                                Console.WriteLine("Wrong Input, try again.");
                                                break;
                                        }
                                    }
                                    // Show all categories
                                    //Console.WriteLine("Categories: \n");
                                    //CategoriesBase.ShowCategories(categories);
                                    break;
                                case 0:
                                    Console.Clear();
                                    // Go back to previous menu
                                    back = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input - try again.");
                                 break;
                            }
                        }
                        break;

                    case 0: //EXIT OPTION
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input - try again.");
                        break;
                }
                back = false;
            }
        }
        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}
