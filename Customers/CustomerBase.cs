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
            if (_customers == null)
            _instance = new CustomerBase();
            return _instance;
        }

        public CustomerBase()
        {
            if (_customers == null)
            _customers = CustomerSample.CreateCustomer();
        }

        public static int CustomerIDGenerator()
        {
            Random rnd = new Random();
            int ID = rnd.Next(1, 30); // creates a number between 1 and 30

            var IDs = _customers.Where(IDs => IDs.id == ID).ToArray();

            foreach (var idei in IDs)
            {
                if (idei.id == ID)
                {
                    ID = rnd.Next(31, 99999);
                }
                else
                {
                    return ID;
                }
            }
            return ID;
        }

        public static void AddNewCustomer()
        {
            List<Customer> list = new List<Customer>();
            Customer customer = new Customer();

            customer.id = CustomerIDGenerator();
            customer.Name = Common.GetString("Enter name:");
            customer.Surname = Common.GetString("Enter surname: ");
            customer.Address = Common.GetString("Enter address: ");
            customer.Dateofbirth = Common.GetInt("Enter age: ");
            customer.Wallet = Common.GetDouble("Enter how much money does customer have: ");
            customer.LoyalCard = Common.GetConfirm("Enter if customer got Loyal Card: Yes[Y] or No[N] ");

            list.Add(customer);
            SaveOrUpdateCustomer(list);
        }

        public static void RemoveCustomer()
        {
            List<Customer> customers = new List<Customer>();
            ShowCustomer(customers);

            bool back = false;
            while (!back)
            {
                int input = Common.GetInt("Enter CUSTOMER ID number to remove customer or return to the previouse menu [0].\n", "Please select CUSTOMER ID number.");

                if (input != 0)
                {
                    var CustomerRemover = _customers.Where(customer => customer.id == input).ToArray();

                    foreach (var customer in CustomerRemover)
                    {
                        var CustomerSoldGame = _customers.Where(customer => customer.id == input).ToArray();

                        _customers.Remove(customer);
                        Console.WriteLine("\nCustomer {0} {1} has been removed from the shop.\n", customer.Name, customer.Surname);
                    }
                }
                else if (input == 0)
                {
                    back = true;
                }
            }
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
