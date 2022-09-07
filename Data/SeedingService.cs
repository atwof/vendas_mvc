using System;
using System.Linq;
using ProjetoVendas.Models;
using ProjetoVendas.Models.Enums;

namespace ProjetoVendas.Data
{
    public class SeedingService
    {
        private ProjetoVendasContext _context;

        public SeedingService(ProjetoVendasContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB já foi criado
            }

            // Departamentos
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            // Vendedores
            Seller s1 = new Seller(1, "Bob",   "bob@gmail.com",   new DateTime(1993, 12, 30), 1000.0, d1);
            Seller s2 = new Seller(2, "Pedro", "pedro@gmail.com", new DateTime(2000, 1, 11),  5000.0, d2);
            Seller s3 = new Seller(3, "Jose",  "jose@gmail.com",  new DateTime(1993, 10, 12), 4000.0, d3);
            Seller s4 = new Seller(4, "Maria", "maria@gmail.com", new DateTime(2001, 2, 22),  2222.0, d1);

            // Vendas
            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 7, 7),   9989,    Models.Enums.SaleStatus.Billed,   s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 8, 9),   2123,    Models.Enums.SaleStatus.Canceled, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2022, 9, 11),  201230,  Models.Enums.SaleStatus.Pending,  s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2006, 10, 15), 20220,   Models.Enums.SaleStatus.Billed,   s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2002, 1, 22),  2020,    Models.Enums.SaleStatus.Canceled, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(1932, 3, 2),   20220,   Models.Enums.SaleStatus.Pending,  s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2004, 5, 12),  2045560, Models.Enums.SaleStatus.Billed,   s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7);

            _context.SaveChanges();

        }
    }
}

