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

            Customer customer1 = new Customer();
            customer1.id = 1;
            customer1.Name = "Karol";
            customer1.Surname = "Malinowski";
            customer1.Address = "ul. Sobieskiego 14";
            customer1.Dateofbirth = 26;
            customer1.LoyalCard = "Y";
            customer1.Wallet = 200;

            Customer customer2 = new Customer();
            customer2.id = 2;
            customer2.Name = "Marta";
            customer2.Surname = "Tomczak";
            customer2.Address = "ul. Kościuszki 212";
            customer2.Dateofbirth = 25;
            customer2.LoyalCard = "N";
            customer2.Wallet = 30;

            Customer customer3 = new Customer();
            customer3.id = 3;
            customer3.Name = "Adam";
            customer3.Surname = "Nowak";
            customer3.Address = "ul. Konwaliowa 3";
            customer3.Dateofbirth = 50;
            customer3.LoyalCard = "N";
            customer3.Wallet = 400;

            Customer customer4 = new Customer();
            customer4.id = 4;
            customer4.Name = "Anna";
            customer4.Surname = "Marecka";
            customer4.Address = "ul. Jasna 2";
            customer4.Dateofbirth = 21;
            customer4.LoyalCard = "Y";
            customer4.Wallet = 699;

            Customer customer5 = new Customer();
            customer5.id = 5;
            customer5.Name = "Klaudia";
            customer5.Surname = "Lis";
            customer5.Address = "ul. Wiejska 23";
            customer5.Dateofbirth = 41;
            customer5.LoyalCard = "N";
            customer5.Wallet = 40;

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);
            customers.Add(customer5);
            return customers;
        }
    }
}