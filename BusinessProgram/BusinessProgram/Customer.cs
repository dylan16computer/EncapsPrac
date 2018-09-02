using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProgram
{
    class Customer : Person
    {
        public int purchNum { get; set; }

        public Customer(string _fName, string _lName, int _age) : base(_fName, _lName, _age)
        {
        }

        public int PurchCount()
        {
            return purchNum++;
        }
    }
}
