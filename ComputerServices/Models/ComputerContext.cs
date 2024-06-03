using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServices.Models
{
    public class ComputerContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\ISOFT;Database=ComputerContext;Trusted_Connection = True;TrustServerCertificate=True;");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ServiceRecord> Services { get; set; }
        public DbSet<ServiceStatus> ServicesStatus { get; set; }
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<Staff> Staffs { get; set;}
    }
}
