using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class CustomerBase
    {

        private static CustomerBase _instance;
        private static List<Customer> _customers;

        public static CustomerBase GetInstance()
        {
            if (_instance == null)
                _instance = new CustomerBase();
            return _instance;
        }

        public CustomerBase()
        {
            _customers = CustomerSample.CreateCustomer();
        }

        public static void ShowCustomer(List<Customer> customers)
        {
            CustomerBase.GetInstance();

            customers = _customers;
            foreach (Customer c in customers)
            {
                Console.WriteLine(c);
            }
        }

        public static void SaveOrUpdateCustomer(List<Customer> customers)
        {
            CustomerBase.GetInstance();
            _customers.AddRange(customers);
        }
    } 
}
