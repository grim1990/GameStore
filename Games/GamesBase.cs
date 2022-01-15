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

        public static GamesBase GetInstance()
        {
            if (_instance == null)
                _instance = new GamesBase();
            return _instance;
        }

        public GamesBase()
        {
            _games = GamesSample.CreateGames();
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

        public static void BuyGame()
        {
            int input = Common.GetInt("Enter number of game that you would like to buy\n");

            var GameToRemove = _games.Where(i => i.id == input).ToArray();
            foreach (var item in GameToRemove)
            {
                _games.Remove(item);
            }

            Console.Clear();
        }
    }
}
