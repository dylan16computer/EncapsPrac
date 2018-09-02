using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProgram
{
    class VIPCustomer : Customer
    {
        public VIPCustomer(string _fName, string _lName, int _age) : base(_fName, _lName, _age)
        {
        }

        public double Discount = 10.5;
    }
}
