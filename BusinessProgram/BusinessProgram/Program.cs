using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Managers manager = new Managers("Bob", "Smith", 34, 25000, 10.5, true);
            manager.ID = manager.CreateID();

            Customer customer1 = new Customer("Tim", "riufh", 17);
            customer1.PurchCount();

            if (customer1.purchNum >= 10)
            {
                VIPCustomer vIPCustomer1 = new VIPCustomer(customer1.FirstName, customer1.LastName, customer1.Age);
            }

            

        }
    }
}
