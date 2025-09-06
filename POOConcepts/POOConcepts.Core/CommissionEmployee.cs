using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts.Core
{
    public class CommissionEmployee : Employee
    {
        private float _commissionPercentaje;
        private decimal _sales;

        public float CommissionPercentaje 
        { 
            get => _commissionPercentaje; 
            set => _commissionPercentaje = ValidateCommissionPercentaje(value); 
        }
        public decimal Sales 
        { 
            get => _sales; 
            set => _sales = ValidateSales(value); 
        }

        public override decimal GetValueToPay() => Sales * (decimal)(CommissionPercentaje);

        public override string ToString() => $"{base.ToString()}\n\t" +
            $"Comission %...: {CommissionPercentaje,20:P2}\n\t" +
            $"Sales.........: {Sales,20:C2}\n\t" +
            $"Salary........: {GetValueToPay(),20:C2}\n\t";

        private float ValidateCommissionPercentaje(float commissionPercentaje)
        {
            if (commissionPercentaje <= 0 || commissionPercentaje > 100)
            {
                throw new Exception($"The commission percentaje {commissionPercentaje:P2} is less or equals than zero or greater than 100");
            }
            return commissionPercentaje;
        }

        private decimal ValidateSales(decimal sales)
        {
            if (sales < 0)
            {
                throw new Exception($"The sales {sales:C2} is less than zero");
            }
            return sales;
        }
    }
}

