using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts.Core
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        private decimal _salary;

        public decimal Salary 
        { 
            get => _salary; 
            set => _salary = ValidateSalary(value);
        }

        public override decimal GetValueToPay() => base.GetValueToPay() + Salary;

        private decimal ValidateSalary(decimal salary)
        {
            if (salary < 300000)
            {
                throw new Exception($"The salary {salary:C2} is less than minimun salary ({300000:c2})");
            }
            return salary;
        }
    }
}
