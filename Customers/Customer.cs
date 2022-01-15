using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class Customer
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _address;
        private string _loyalcard;
        private int _dateofbirth;


        public override string ToString()
        {
            return $"\nID: {id}\nName: {_name}\nSurname: {_surname}\nAddress: {_address}\nDate of birth: {Dateofbirth}\n";
        }

        public int id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public string LoyalCard
        {
            get => _loyalcard;
            set => _loyalcard = value;
        }

        public int Dateofbirth
        {
            get => _dateofbirth;
            set => _dateofbirth = value;
        }



        public void AddNewCustomer()
        {
            List<Customer> list = new List<Customer>();
            Customer customer = new Customer();

            customer.id = CustomerSample.IDGenerator();
            customer.Name = Common.GetString("Type name: ");
            customer.Surname = Common.GetString("Type surname: ");
            customer.Address = Common.GetString("Type address: ");
            customer.Dateofbirth = Common.GetInt("Type age: ");
            customer.LoyalCard = Common.GetConfirm("Type age: ");

            list.Add(customer);
            CustomerBase.SaveOrUpdateCustomer(list);
        }
    }
}