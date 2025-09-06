using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts.Core
{
    public abstract class Employee
    {
        // Atributes
        public Date BornDate { get; set; } = null!;
        public String FirstName { get; set; } = null!;
        public Date HireDate { get; set; } = null!;
        public int id { get; set; }
        public bool IsActive { get; set; }
        public string LastName { get; set; } = null!;

        //Methods
        public abstract decimal GetValueToPay();
        public override string ToString() => $"{id}\t{FirstName} {LastName}\n\t" +
            $"Born date.....: {BornDate:N2}\n\t" +
            $"Hire date.....: {HireDate:N2}\n\t";
    }
}
