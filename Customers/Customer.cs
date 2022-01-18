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
        private double _wallet;

        public override string ToString()
        {
            return $"Customer ID: {id}\nName: {_name}\nSurname: {_surname}\nAddress: {_address}\nDate of birth: {Dateofbirth}\nLoyal Card: {LoyalCard}\nCustomer Wallet: " + Math.Round(Wallet,2) + " zł\n";
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

        public double Wallet
        {
            get => _wallet;
            set => _wallet = value;
        }
    }
}