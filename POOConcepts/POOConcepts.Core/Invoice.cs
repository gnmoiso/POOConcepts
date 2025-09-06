using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts.Core
{
    public class Invoice : IPay
    {
        public int id { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public float Quantity { get; set; }

        public decimal GetValueToPay() => Price * (decimal)Quantity;
        public override string ToString() => $"{base.ToString()}\n\t" + $"{id}\t{Description}\n\t" +
            $"Quantity......: {Quantity,20:N2}\n\t" +
            $"Price.........: {Price,20:C2}\n\t" +
            $"Value To Pay..: {GetValueToPay(),20:C2}";
    }
}