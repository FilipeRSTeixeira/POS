using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Payment
    {
        public int Id { get; set; }
        public int SaleId { get; set; } // Referência a Sale
        public string PaymentType { get; set; }
        public decimal PaidValue { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
