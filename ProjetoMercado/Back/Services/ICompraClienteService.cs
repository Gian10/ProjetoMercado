using Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Services
{
    public interface ICompraClienteService
    {

        public void CadastrarCompraCliente(CompraCliente compraCliente);

        public List<CompraCliente> ListarComprasClientes();
    }
}
