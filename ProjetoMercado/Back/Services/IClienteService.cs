using Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Services
{
    public interface IClienteService
    {

        public void CadastroCliente(Cliente cliente);

        public List<Cliente> LstarClientes();
    }
}
