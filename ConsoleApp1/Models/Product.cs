using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string BarCode { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int CategoriaId { get; set; }
        public string UnitMeasure { get; set; }
        public int UnitQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
