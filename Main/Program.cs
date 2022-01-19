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

            Serial_Deserial_Games.Deserialize();
            Serial_Deserial_Customer.Deserialize();
            
            List<Customer> customers = new List<Customer>();
            List<Games> games = new List<Games>();

            while (!exit)
            {
                //show menu and switch case options
                menu.MainMenu();
                int input = Common.GetInt("Select: ", "Please select number from [0] to [3].");
                
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        menu.MainMenuWelcome();
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
                                    // Buy game
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
                                    // Show all categories
                                    while (!back)
                                    {
                                        menu.MainMenuCategories();
                                        int input1 = Common.GetInt("Select: ", "Please select number from [0] to [5].");
                                        switch (input1)
                                        {
                                            case 1:
                                                Console.Clear();
                                                GamesBase.ShowGameTypesSurvival();
                                                break;
                                            case 2:
                                                Console.Clear();
                                                GamesBase.ShowGameTypesRPG();
                                                break;
                                            case 3:
                                                Console.Clear();
                                                GamesBase.ShowGameTypesFPS();
                                                break;
                                            case 4:
                                                Console.Clear();
                                                GamesBase.ShowGameTypesAction();
                                                break;
                                            case 5:
                                                Console.Clear();
                                                GamesBase.ShowGames(games);
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
                        Serial_Deserial_Customer.Serialize();
                        Serial_Deserial_Games.Serialize();
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
