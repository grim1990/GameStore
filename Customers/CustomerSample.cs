using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class CustomerSample
    {
        private static List<int> _list;
        private static CustomerSample _instance;

        private CustomerSample()
        {
            _list = new List<int>();
        }

        private static CustomerSample GetInstance()
        {
            if (_instance == null)
                _instance = new CustomerSample();
            return _instance;
        }

        public static int IDGenerator()
        {
                GetInstance();
                Random rnd = new Random();
                int ID = rnd.Next(3, 100); // creates a number between 3 and 100

                if (_list.Contains(ID))
                {
                    //duplicate number
                    ID = rnd.Next(101,9999);
                }
                else
                {
                    _list.Add(ID);
                }
                return ID;
        }

        public static List<Customer> CreateCustomer()
        {
            List<Customer> customers = new List<Customer>();

            Customer customer0 = new Customer();
            customer0.id = 1;
            customer0.Name = "KarolDDD";
            customer0.Surname = "Malinowski";
            customer0.Address = "ul. Sobieskiego 14";
            customer0.Dateofbirth = 26;

            Customer customer1 = new Customer();
            customer1.id = 2;
            customer1.Name = "Marta";
            customer1.Surname = "Tomczak";
            customer1.Address = "ul. Kościuszki 212";
            customer1.Dateofbirth = 31;

            customers.Add(customer0);
            customers.Add(customer1);
            return customers;
        }
    }
}
