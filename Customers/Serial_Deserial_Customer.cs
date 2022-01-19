using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class Serial_Deserial_Customer
    {
        public static void Serialize()
        {
            ISerialize<Customer> xmlSerialize = new XmlSerializer<Customer>(@".\gcustomerXML.xml");
            xmlSerialize.Serialize(CustomerBase._customers);
        }

        public static void Deserialize()
        {
            ISerialize<Customer> xmlSerialize = new XmlSerializer<Customer>(@".\gcustomerXML.xml");
            CustomerBase._customers = xmlSerialize.Deserialize();

            if (CustomerBase._customers == null)
            {
                CustomerBase.GetInstance();
            }
            else if (CustomerBase._customers.Count() == 0)
            {
                CustomerBase._customers = CustomerSample.CreateCustomer();
            }
        }
    }
}
