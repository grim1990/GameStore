using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class CategoriesBase
    {
        private static CategoriesBase _instance;
        private static List<Categories> _categories;
        

        public static CategoriesBase GetInstance()
        {
            if (_instance == null)
                _instance = new CategoriesBase();
            return _instance;
        }

        public CategoriesBase()
        {
            _categories = CategoriesSample.CreateCategoriesSample();
        }


        public static void ShowCategories(List<Categories> categories)
        {
            CategoriesBase.GetInstance();
            categories = _categories;
            foreach (Categories i in categories)
            {
                Console.WriteLine(i);
            }
        }
    }
}
