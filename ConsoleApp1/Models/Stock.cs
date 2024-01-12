using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; } // Referência a Product
        public int? StoreId { get; set; } // Opcional, referência a Store
        public int Quantity { get; set; }
        public int QuantityBase { get; set; }
        public string SaleUnit { get; set; }
        public int QuantitySaleUnit { get; set; }
        public DateTime CreatedDate = DateTime.Now;
        public DateTime ModifiedDate = DateTime.Now;
    }
}
