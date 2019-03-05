using SistemaDeVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVendas.Services
{
    public class VendedorService
    {
        private readonly SistemaDeVendasContext _context;

        public VendedorService(SistemaDeVendasContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Insert(Vendedor vendedor)
        {
            vendedor.Departamento = _context.Departamento.First();

            _context.Add(vendedor);
            _context.SaveChanges();
        }
    }
}
