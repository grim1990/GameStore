using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class Categories
    {
        private string _name;
        public override string ToString()
        {
            return $"Game indeks number: Name: {_name}\n";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
