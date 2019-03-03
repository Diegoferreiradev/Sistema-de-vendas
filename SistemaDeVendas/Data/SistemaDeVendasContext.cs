﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaDeVendas.Models
{
    public class SistemaDeVendasContext : DbContext
    {
        public SistemaDeVendasContext (DbContextOptions<SistemaDeVendasContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaDeVendas.Models.Departamento> Departamento { get; set; }
    }
}
