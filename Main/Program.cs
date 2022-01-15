﻿using System;
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

            Customer customer = new Customer();
            Games game = new Games();

            List<Customer> customers = new List<Customer>();
            List<Games> games = new List<Games>();

            while (!exit)
            {
                //show menu and switch case options
                menu.MainMenu();
                int input = Common.GetInt("Select: ", "Please select number from [0] to [3]");
                
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
                            int input1 = Common.GetInt("Select: ", "Please select number from [0] to [2]");
                            switch (input1)
                            {
                                case 1:
                                    Console.Clear();
                                    // Add new customer
                                    customer.AddNewCustomer();
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
                                    Console.WriteLine("Wrong input - try again");
                                    break;
                            }
                        }
                        break;

                    case 3://GAME OPTIONS
                        Console.Clear();
                        while (!back)
                        {
                            menu.MainMenuGames();
                            int input1 = Common.GetInt("Select: ", "Please select number from [0] to [3]");
                            switch (input1)
                            {
                                case 1:
                                    bool back1 = false;
                                    while (!back1)
                                    {
                                        Console.Clear();
                                        // Buy game
                                        // not properly implemented ---------------------------
                                        GamesBase.ShowGames(games);
                                        GamesBase.BuyGame();


                                        int input2 = Common.GetInt("Would you like to buy another game?", "Please select game ID number");

                                        if (input2 == 0)
                                        {
                                            back1 = true;
                                        }
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    // Sell game
                                    game.SellGame();
                                    break;
                                case 3:
                                    Console.Clear();
                                    // Show all games
                                    GamesBase.ShowGames(games);
                                    break;
                                case 0:
                                    Console.Clear();
                                    // Go back to previous menu
                                    back = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input - try again");
                                 break;
                            }
                        }
                        break;

                    case 0: //EXIT OPTION
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input - try again");
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
