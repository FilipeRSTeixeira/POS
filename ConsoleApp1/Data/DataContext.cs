using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class DataContext : DbContext, IDisposable
    {
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"SERVER=(localdb)\MSSQLLocalDB; DATABASE=POSDataBase1; TRUSTED_CONNECTION=TRUE");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
