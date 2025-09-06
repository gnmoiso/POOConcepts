using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts.Core
{
    public class SalaryEmployee : Employee
    {
        private const decimal MINIMUN_SALARY = 1500000;
        private decimal _salary;

        public decimal salary 
        {
            get => _salary;
            set => _salary = ValidateSalary(value);
        }

        public override decimal GetValueToPay() => salary;

        public override string ToString() => $"{base.ToString()}\n\t" +
                $"Salary........: {GetValueToPay(),20:C2}\n\t";
        

        private decimal ValidateSalary(decimal salary)
        {
            if (salary < MINIMUN_SALARY)
            {
                throw new Exception($"The salary {salary:C2} is less than the minimun salary{MINIMUN_SALARY:C2}");
            }
            return salary; 
        }


    }
}
