using SistemaDeVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVendas.Services
{
    public class DepartamentoService
    {
        private readonly SistemaDeVendasContext _context;

        public DepartamentoService(SistemaDeVendasContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(d => d.Nome).ToList();
        }
    }
}
