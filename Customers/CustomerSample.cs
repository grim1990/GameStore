using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class CustomerSample
    {
        public static List<Customer> CreateCustomer()
        {
            List<Customer> customers = new List<Customer>();

            Customer customer0 = new Customer();
            customer0.id = 1;
            customer0.Name = "Karol";
            customer0.Surname = "Malinowski";
            customer0.Address = "ul. Sobieskiego 14";
            customer0.Dateofbirth = 26;
            customer0.LoyalCard = "Y";

            Customer customer1 = new Customer();
            customer1.id = 2;
            customer1.Name = "Marta";
            customer1.Surname = "Tomczak";
            customer1.Address = "ul. Kościuszki 212";
            customer1.Dateofbirth = 25;
            customer1.LoyalCard = "N";

            Customer customer2 = new Customer();
            customer2.id = 3;
            customer2.Name = "Adam";
            customer2.Surname = "Nowak";
            customer2.Address = "ul. Konwaliowa 3";
            customer2.Dateofbirth = 50;
            customer2.LoyalCard = "N";

            Customer customer3 = new Customer();
            customer3.id = 4;
            customer3.Name = "Anna";
            customer3.Surname = "Marecka";
            customer3.Address = "ul. Jasna 2";
            customer3.Dateofbirth = 21;
            customer3.LoyalCard = "Y";

            Customer customer4 = new Customer();
            customer4.id = 5;
            customer4.Name = "Klaudia";
            customer4.Surname = "Lis";
            customer4.Address = "ul. Wiejska 23";
            customer4.Dateofbirth = 41;
            customer4.LoyalCard = "N";

            customers.Add(customer0);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);
            return customers;
        }
    }
}