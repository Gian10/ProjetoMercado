using Back.Models;
using Back.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private IClienteService clienteService;
        public ClienteController(IClienteService cliente)
        {
            clienteService = cliente;
        }

        [HttpGet]
        public ActionResult<List<Cliente>> GetCleintes()
        {
            return clienteService.LstarClientes();
        }

        [HttpPost]
        public ActionResult PostCliente(Cliente cliente)
        {
            clienteService.CadastroCliente(cliente);
            return Ok();
        }

      
    }
}
