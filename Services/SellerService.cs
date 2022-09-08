using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoVendas.Models;

namespace ProjetoVendas.Services
{
    public class SellerService
    {
        private readonly ProjetoVendasContext _context;

        public SellerService(ProjetoVendasContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            seller.Department = _context.Department.First();
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}

