using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProgram
{
    class GeneralStaff : Employee
    {
        public GeneralStaff(string _fName, string _lName, int _age, decimal _wages, double _tax) : base(_fName, _lName, _age, _wages, _tax)
        {
        }

        public bool CheckAge()
        {
            if (Age >= 18)
            {
                return true;
            }
            return false;
        }

    }
}
