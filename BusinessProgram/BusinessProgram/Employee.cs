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
        public decimal Wages { get; set; }
        public double Tax { get; set; }

        public Employee(string _fName, string _lName, int _age, decimal _wages, double _tax) : base(_fName, _lName, _age)
        {
            Wages = _wages;
            Tax = _tax;
        }

        public int CreateID()
        {
            Random id = new Random();
            int randomID = id.Next(1000,9999);
            return randomID;
        }
    }
}
