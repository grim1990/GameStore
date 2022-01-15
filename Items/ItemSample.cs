using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class ItemSample
    {
        private static List<int> _list;
        private static ItemSample _instance;

        private ItemSample()
        {
            _list = new List<int>();
        }

        private static ItemSample GetInstance()
        {
            if (_instance == null)
                _instance = new ItemSample();
            return _instance;
        }
        /*
        public static int IDGenerator()
        {
            GetInstance();
            Random rnd = new Random();
            int ID = rnd.Next(3, 100); // creates a number between 3 and 100

            if (_list.Contains(ID))
            {
                //duplicate number
                ID = rnd.Next(101, 9999);
            }
            else
            {
                _list.Add(ID);
            }
            return ID;
        }*/

        public static List<Item> CreateItem()
        {
            List<Item> items = new List<Item>();

            Item item0 = new Item();
            item0.Name = "Młotek";
            item0.Description = "Służy do wbijania gwoździ";
            item0.Owner = "Karol Malinowski";

            Item item1 = new Item();
            item1.Name = "Szpadel";
            item1.Description = "Służy do kopoania";
            item1.Owner = "Marta Tomczak";

            items.Add(item0);
            items.Add(item1);
            return items;
        }
    }
}