using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    internal class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString() => $"{base.ToString()}" +
                                             $"\n\tValue to pay: {$"{GetValueToPay():C2}", 10}"; // \n: Salto de linea \t: tabulador
    }
}
