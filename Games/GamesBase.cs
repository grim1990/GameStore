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
        private static List<Games> _games;
        private static double newprice = 0;
        //private static List<int> _list = new List<int>();

        public static GamesBase GetInstance()
        {
            if (_instance == null)
                _instance = new GamesBase();
            return _instance;
        }

        public GamesBase()
        {
            _games = GamesSample.CreateGamesSample();
        }

        public static int IDGenerator()
        {
            Random rnd = new Random();
            int ID = rnd.Next(8, 100); // creates a number between 8 and 100
            
           /* if (_list.Contains(ID))
            {
                //duplicate number
                ID = rnd.Next(999, 9999);
            }
            else
            {
                _list.Add(ID);
            }*/
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

        public static void SaveOrUpdateSoldGame(List<Games> games)
        {
            _games.AddRange(games);
        }

        public static void SellGame()
        {
            List<Games> list = new List<Games>();
            Games game = new Games();

            game.id = IDGenerator();
            game.Name = Common.GetString("Enter name: ");
            game.Type = Common.GetString("Enter game type: ");
            game.Description = Common.GetString("Enter description: ");
            game.Price = Common.GetDouble("Enter price: ");

            list.Add(game);

            bool back = false;
            while (!back)
            {
                Console.Clear();
                List<Customer> customers = new List<Customer>();
                CustomerBase.ShowCustomer(customers);

                int input = Common.GetInt("Enter CUSTOMER ID number who sold game or return to the previouse menu [0].\n", "Please select CUSTOMER ID number.");

                if (input != 0)
                {
                    newprice = game.Price;
                    var CustomerSoldGame = CustomerBase._customers.Where(customer => customer.id == input).ToArray();

                        foreach (var item in CustomerSoldGame)
                        {
                            item.Wallet += newprice;
                            CustomerBase._customers.Append(item);
                        }
                        GamesBase.SaveOrUpdateSoldGame(list);
                        back = true;
                }
                else if (input == 0)
                {
                    back = true;
                }
            }
            Console.Clear();
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
                                }
                            }
                        }
                    }
                    else if (input2 == 0)
                    {
                        Console.Clear();
                        back = true;
                    }
                }
                else if (input == 0)
                {
                    Console.Clear();
                    back = true;
                }
            }
        }
    }
}