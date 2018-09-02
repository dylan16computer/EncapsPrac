using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProgram
{
    class Managers : Employee
    {
        public bool Admin { get; set; }
        public Managers(string _firstName, string _lastName, int _age) : base(_firstName, _lastName, _age)
        {
        }
    }
}
