using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoWebSales.Models;

namespace ProjetoWebSales.Data
{
    public class ProjetoWebSalesContext : DbContext
    {
        public ProjetoWebSalesContext (DbContextOptions<ProjetoWebSalesContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoWebSales.Models.Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
