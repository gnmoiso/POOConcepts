using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts.Core
{
    public class HourlyEmployeecs : Employee
    {
        private decimal _hourValue;
        private float _workingHours;

        public decimal HourValue
        {
            get => _hourValue;
            set => _hourValue = value;
        }

        public float WorkingHours
        {
            get => _workingHours;
            set => _workingHours = value;
        }

        public override decimal GetValueToPay() => HourValue * (decimal)WorkingHours;

        public override string ToString() => $"{base.ToString()}\n\t" +
            $"Working Hours.: {WorkingHours,20:N2}\n\t" +
            $"Hour Value....: {HourValue,20:C2}\n\t" +
            $"Salary........: {GetValueToPay(),20:C2}\n\t";

        private decimal ValidateHourValue(decimal salary)
        {
            if (HourValue <= 0)
            {
                throw new Exception($"The hour value {HourValue:C2} is less or equals than zero");
            }
            return HourValue;
        }

        private float ValidateWorkingHours(float WorkingHours)
        {
            if (WorkingHours <= 0)
            {
                throw new Exception($"The working hours {WorkingHours:N2} is less or equals than zero");
            }
            return WorkingHours;
        }
    }
}
