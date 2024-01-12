using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class User:Person
    {
        public string Login { get; set; }
        public string Password { get; set; } // Armazenar apenas hash da senha
        public string Role { get; set; }
        public string AccountStatus { get; set; }
    }
}
