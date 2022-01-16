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

        public static void AddSoldGame(List<Games> games)
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
            GamesBase.AddSoldGame(list);
        }

        public static void BuyGame()
        {
            bool back = false;
            while (!back)
            {
                Console.Clear();
                ShowGames(_games);
                
                int input = Common.GetInt("Enter game indeks number to buy game or return to the previouse menu enter [0].\n", "Please select GAME INDEKS number.");
                
                var GameToRemove = _games.Where(game => game.id == input).ToArray();

                double newprice = 0;

                if (input != 0)
                {
                    Console.Clear();
                    List<Customer> customers = new List<Customer>();
                    CustomerBase.ShowCustomer(customers);
                    int input2 = Common.GetInt("Enter customer ID number who would like to buy a game or return to the previouse menu enter [0].\n", "Please select customer ID number.");
                    if (input2 != 0)
                    {
                        foreach (var item in GameToRemove)
                        {
                            newprice = item.Price;
                            _games.Remove(item);
                        }
                        var ChooseCustomer = CustomerBase._customers.Where(customer => customer.id == input2).ToArray();
                        foreach (var item in ChooseCustomer)
                        {
                            item.Wallet -= newprice;
                            CustomerBase._customers.Append(item);
                        }
                    }
                }

                else if (input == 0)
                {
                    back = true;
                }
            }
            Console.Clear();
        }
    }
}