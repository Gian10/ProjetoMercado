using Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Services
{
    public class ClienteService : IClienteService
    {
        private DataContext context;


        public ClienteService()
        {
            context = new DataContext();
        }

        public void CadastroCliente(Cliente cliente)
        {
            context.Add(cliente);
            context.SaveChanges();
        }

        public List<Cliente> LstarClientes()
        {
            return context.clientes.ToList();
        }
    }
}
