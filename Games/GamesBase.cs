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
            GamesBase.GetInstance();
            games = _games;
            foreach (Games i in games)
            {
                Console.WriteLine(i);
            }
        }

        public static void AddSoldGame(List<Games> games)
        {
            GamesBase.GetInstance();
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

                int input = Common.GetInt("Enter game indeks number to buy game or return to the previouse menu enter [0].\n", "Please select game ID number.");

                var GameToRemove = _games.Where(i => i.id == input).ToArray();
                foreach (var item in GameToRemove)
                {
                    _games.Remove(item);
                }
                if (input == 0)
                {
                    back = true;
                }
            }
            Console.Clear();
        }
    }
}
