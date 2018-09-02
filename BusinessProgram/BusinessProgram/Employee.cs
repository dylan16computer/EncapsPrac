using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProgram
{
    class Employee : Person
    {
        public int ID { get; set; }
        public int Wages { get; set; }
        public float Tax { get; set; }
        public Employee(string _firstName, string _lastName, int _age) : base(_firstName, _lastName, _age)
        {

        }

    }
}
