using Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Services
{
    public class CompraClienteService : ICompraClienteService
    {
        private DataContext context;
        public CompraClienteService()
        {
            this.context = new DataContext();
        }

        public void CadastrarCompraCliente(CompraCliente compraCliente)
        {
            context.Add(compraCliente);
            context.SaveChanges();
        }

        public List<CompraCliente> ListarComprasClientes()
        {
            return context.compraClientes.ToList();
        }
    }
}
