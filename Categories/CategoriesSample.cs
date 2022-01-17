using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class CategoriesSample
    {
        public static List<Categories> CreateCategoriesSample()
        {
            List<Categories> category = new List<Categories>();

            Categories category0 = new Categories();
            category0.Name = "Survival";

            Categories category1 = new Categories();
            category1.Name = "FPS";

            Categories category2 = new Categories();
            category2.Name = "RPG";

            Categories category3 = new Categories();
            category3.Name = "Action";


            category.Add(category0);
            category.Add(category1);
            category.Add(category2);
            category.Add(category3);
           

            return category;
        }
    }
}
