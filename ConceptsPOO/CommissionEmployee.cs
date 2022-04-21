using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public Decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (Decimal) CommissionPercentaje;
        }
        public override string ToString() => $"{base.ToString()}" +
                                             $"\n\tCommission percentaje:...{$"{CommissionPercentaje:P2}", 15}" +
                                             $"\n\tSales:...................{$"{Sales:C2}", 15}" +
                                             $"\n\tValue to pay:............{$"{GetValueToPay():C2}", 15}";
    }
}