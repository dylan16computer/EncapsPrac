using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProgram
{
    class Managers : Employee
    {
        public Managers(string _fName, string _lName, int _age, decimal _wages, double _tax, bool _admin) : base(_fName, _lName, _age, _wages, _tax)
        {
            Admin = _admin;
        }

        public bool Admin { get; set; }
       

    }
}
