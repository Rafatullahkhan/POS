using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techspiders.Pos.DAL.Entities;
namespace Techspiders.Pos.DAL
{
    class PosDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<SalesInvoice> SalesInvoices { get; set; }
        public DbSet<SaleItems> SaleItems { get; set; }

        public PosDbContext() : base("TechSpidersConnectionString")
        {

        }
    }
}
