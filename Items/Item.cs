using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class Item
    {
        private string _name;
        private string _description;
        private int _pricestart;
        private int _pricemin;
        private int _pricesold;
        private string _owner;
        private string _solddate;

        public override string ToString()
        {
            return $"\nName: {_name}\nDescription: {_description}\nOwner: {_owner}\n";
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public int PriceStart
        {
            get => _pricestart;
            set => _pricestart = value;
        }

        public int PriceMin
        {
            get => _pricemin;
            set => _pricemin = value;
        }

        public int PriceSold
        {
            get => _pricesold;
            set => _pricesold = value;
        }

        public string Owner
        {
            get => _owner;
            set => _owner = value;
        }

        public string SoldDate
        {
            get => _solddate;
            set => _solddate = value;
        }

        public void AddNewItem()
        {
            List<Item> list = new List<Item>();
            Item item = new Item();

           // item.id = CustomerSample.IDGenerator();
            item.Name = Common.GetString("Type name: ");
            item.Description = Common.GetString("Type description: ");
            item.Owner = Common.GetString("Type owner: ");

            list.Add(item);
            ItemBase.SaveOrUpdateItem(list);
        }
    }
}
