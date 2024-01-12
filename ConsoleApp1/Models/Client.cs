using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Client : Person
    {
        //public List<Sale> Sales { get; set; } //Deveria conseguir ver as compras que um cliente realizou
        internal readonly int Identificador;
    }
}
