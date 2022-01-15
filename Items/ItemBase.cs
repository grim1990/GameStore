using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class ItemBase
    {
        private static ItemBase _instance;
        private static List<Item> _items;

        public static ItemBase GetInstance()
        {
            if (_instance == null)
                _instance = new ItemBase();
            return _instance;
        }

        public ItemBase()
        {
            _items = ItemSample.CreateItem();
        }

        public static void ShowItem(List<Item> items)
        {
            ItemBase.GetInstance();

            items = _items;
            foreach (Item i in items)
            {
                Console.WriteLine(i);
            }
        }

        public static void SaveOrUpdateItem(List<Item> items)
        {
            ItemBase.GetInstance();
            _items.AddRange(items);
        }
    }
}
