using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class GamesBase
    {
        private static GamesBase _instance;
        public static List<Games> _games;
        private static double newprice = 0;

        public static GamesBase GetInstance()
        {
            if (_instance == null)
            _instance = new GamesBase();
            return _instance;
        }

        public GamesBase()
        {
            if (_games == null)
            _games = GamesSample.CreateGamesSample();
        }

        public static int IDGeneratorGames()
        {
            Random rnd = new Random();
            int ID = rnd.Next(1, 30); // creates a number between 1 and 30

            var IDs = _games.Where(IDs => IDs.id == ID).ToArray();

            foreach (var idei in IDs)
            {
                if (idei.id == ID)
                {
                   ID = rnd.Next(31,99999);
                }
                else
                {
                    return ID;
                }
            }
            return ID;
        }

        public static void ShowGames(List<Games> games)
        {
            games = _games;
            foreach (Games i in games)
            {
                Console.WriteLine(i);
            }
        }

        public static void ShowGameTypesAction()
        {
            Console.WriteLine("Our Action Games: \n");
            foreach (var item in _games)
            {
                if (item.Type == "Action")
                {
                    Console.WriteLine(item);
                }
                else if (item.Type == "action")
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void ShowGameTypesFPS()
        {
            Console.WriteLine("Our FPS games: \n");
            foreach (var item in _games)
            {
                if (item.Type == "FPS")
                {
                    Console.WriteLine(item);
                }
                else if (item.Type == "fps")
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void ShowGameTypesRPG()
        {
            Console.WriteLine("Our RPG games: \n");
            foreach (var item in _games)
            {
                if (item.Type == "RPG")
                {
                    Console.WriteLine(item);
                }
                else if (item.Type == "rpg")
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void ShowGameTypesSurvival()
        {
            Console.WriteLine("Our survival games: \n");
            foreach (var item in _games)
            {
                if (item.Type == "Survival")
                {
                    Console.WriteLine(item);
                }
                else if (item.Type == "survival")
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void SaveOrUpdateSoldGame(List<Games> games)
        {
            _games.AddRange(games);
        }

        public static void SellGame()
        {
            List<Games> list = new List<Games>();
            Games game = new Games();

            

            bool back = false;
            while (!back)
            {
                Console.WriteLine("Enter what game customer would like to sell.\n");

                game.id = IDGeneratorGames();
                game.Type = Common.GetGameType("Enter game type([RPG],[Survival],[FPS],[Action]): ");
                game.Name = Common.GetString("Enter game name: ");
                game.Description = Common.GetString("Enter game description: ");
                game.Price = Common.GetDouble("Enter game price: ");

                list.Add(game);

            
                Console.Clear();

                List<Customer> customers = new List<Customer>();
                CustomerBase.ShowCustomer(customers);

                int input = Common.GetInt("Enter CUSTOMER ID number who sold game or return to the previouse menu [0].\n", "Please select CUSTOMER ID number.");

                if (input != 0)
                {
                    newprice = game.Price;
                    var CustomerSoldGame = CustomerBase._customers.Where(customer => customer.id == input).ToArray();

                    foreach (var custom in CustomerSoldGame)
                    {
                       if (custom.LoyalCard == "Y")
                       {
                          newprice = newprice * 110 / 100;
                          custom.Wallet += newprice;
                          CustomerBase._customers.Append(custom);
                          newprice = 0;
                        }
                       else
                       {
                           custom.Wallet += newprice;
                           CustomerBase._customers.Append(custom);
                           newprice = 0;
                       }
                    }
                   SaveOrUpdateSoldGame(list);
                   newprice = 0;
                   back = true;
                }
                else if (input == 0)
                {
                    newprice = 0;
                    back = true;
                }
            }
        }

        public static void BuyGame()
        {
            bool back = false;
            while (!back)
            {
                ShowGames(_games);
                
                int input = Common.GetInt("Enter GAME INDEKS to buy game or return to the previouse menu [0].\n", "Please select GAME INDEKS number.");
                
                var GameToRemove = _games.Where(game => game.id == input).ToArray();
                if (input != 0)
                {
                    Console.Clear();

                    List<Customer> customers = new List<Customer>();
                    CustomerBase.ShowCustomer(customers);

                    int input2 = Common.GetInt("Enter CUSTOMER ID number who would like to buy a game or return to the previouse menu [0].\n", "Please select CUSTOMER ID number.");

                    var ChooseCustomer = CustomerBase._customers.Where(customer => customer.id == input2).ToArray();
                    
                    if (input2 != 0)
                    {
                        Console.Clear();
                        foreach (var game in GameToRemove)
                        {
                            newprice = game.Price;
                        }
                        foreach (var custom in ChooseCustomer)
                        {
                            if (custom.LoyalCard == "Y")
                            {
                                newprice = newprice * 90 / 100;
                                if (custom.Wallet < newprice)
                                {
                                    Console.Clear();
                                    foreach (var game in GameToRemove)
                                    {
                                        Console.WriteLine("\nCustomer {0} {1} don't have enouqh money to buy {2} !!!\n", custom.Name, custom.Surname, game.Name);
                                    }
                                    newprice = 0;
                                }
                                else if (custom.Wallet >= newprice)
                                {
                                    Console.Clear();
                                    foreach (var game in GameToRemove)
                                    {
                                        _games.Remove(game);
                                        Console.WriteLine("\nCustomer {0} {1} bought game {2} for {3} zł.\n", custom.Name, custom.Surname, game.Name, Math.Truncate(newprice * 100) / 100);
                                    }
                                    custom.Wallet -= newprice;
                                    CustomerBase._customers.Append(custom);
                                    newprice = 0;
                                }
                            }
                            else
                            {
                                if (custom.Wallet < newprice)
                                {
                                    Console.Clear();
                                    foreach (var game in GameToRemove)
                                    {
                                        Console.WriteLine("\nCustomer {0} {1} don't have enouqh money to buy {2} !!!\n", custom.Name, custom.Surname, game.Name);
                                    }
                                    newprice = 0;
                                }
                                else if (custom.Wallet >= newprice)
                                {
                                    Console.Clear();
                                    foreach (var game in GameToRemove)
                                    {
                                        _games.Remove(game);
                                        Console.WriteLine("\nCustomer {0} {1} bought game {2} for {3} zł.\n", custom.Name, custom.Surname, game.Name, game.Price);
                                    }
                                    custom.Wallet -= newprice;
                                    CustomerBase._customers.Append(custom);
                                    newprice = 0;
                                }
                            }
                        }
                    }
                    else if (input2 == 0)
                    {
                        newprice = 0;
                        Console.Clear();
                        back = true;
                    }
                }
                else if (input == 0)
                {
                    newprice = 0;
                    Console.Clear();
                    back = true;
                }
            }
        }
    }
}