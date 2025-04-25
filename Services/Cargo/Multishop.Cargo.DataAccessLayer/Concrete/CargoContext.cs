using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Multishop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.Cargo.DataAccessLayer.Concrete
{
    public class CargoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1441;initial catalog=MultishopCargoDb;User=sa;Password=123456aA*;TrustServerCertificate=true");
        }

        public DbSet<CargoOperation> CargoOperations { get; set; }
        public DbSet<CargoCustomer> CargoCustomers { get; set; }
        public DbSet<CargoDetail> CargoDetails { get; set; }
        public DbSet<CargoCompany> CargoCompanies { get; set; } 
    }
}
