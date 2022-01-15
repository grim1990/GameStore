using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class Games
    {
        private int _id;
        private string _name;
        private string _type;
        private string _description;
        private double _price;

        public override string ToString()
        {
            return $"Game number: {_id}\nName: {_name}\nDescription: {_description}\nType: {_type}\nPrice: { _price} zł\n";
        }
        public int id
        {
            get => _id;
            set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public void SellGame()
        {
            List<Games> list = new List<Games>();
            Games game = new Games();

            game.id = GamesSample.IDGenerator();
            game.Name = Common.GetString("Enter name: ");
            game.Type = Common.GetString("Enter game type: ");
            game.Description = Common.GetString("Enter description: ");
            game.Price = Common.GetDouble("Enter price: ");

            list.Add(game);
            GamesBase.AddSoldGame(list);
        }
    }
}
