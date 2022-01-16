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
        public static List<Customer> _customers;

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

        public static int IDGenerator()
        {
         //   GetInstance();
            Random rnd = new Random();
            int ID = rnd.Next(3, 100); // creates a number between 3 and 100

            /* if (_list.Contains(ID))
             {
                 //duplicate number
                 ID = rnd.Next(101,9999);
             }
             else
             {
                 _list.Add(ID);
             }*/
            return ID;
        }

        public static void AddNewCustomer()
        {
            List<Customer> list = new List<Customer>();
            Customer customer = new Customer();

            customer.id = CustomerBase.IDGenerator();
            customer.Name = Common.GetString("Enter name:");
            customer.Surname = Common.GetString("Enter surname: ");
            customer.Address = Common.GetString("Enter address: ");
            customer.Dateofbirth = Common.GetInt("Enter age: ");
            customer.Wallet = Common.GetDouble("Enter how much money does customer have: ");
            customer.LoyalCard = Common.GetConfirm("Enter if customer got Loyal Card: Yes[Y] or No[N] ");

            list.Add(customer);
            CustomerBase.SaveOrUpdateCustomer(list);
        }

        public static void ShowCustomer(List<Customer> customers)
        {
            customers = _customers;
            foreach (Customer c in customers)
            {
                Console.WriteLine(c);
            }
        }

        public static void SaveOrUpdateCustomer(List<Customer> customers)
        {
            _customers.AddRange(customers);
        }
    } 
}
