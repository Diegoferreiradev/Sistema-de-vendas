using SistemaDeVendas.Models.Enums;
using System;

namespace SistemaDeVendas.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public VendaStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }


        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double quantidade, VendaStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Status = status;
            Vendedor = vendedor;
        }

    }
}
