using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoVendas.Models;


    public class ProjetoVendasContext : DbContext
    {
        public ProjetoVendasContext (DbContextOptions<ProjetoVendasContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public SalesRecord SalesRecord { get; set; }
}
