using Back.Models;
using Back.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompraClienteController : ControllerBase
    {
        private ICompraClienteService compraClienteService;
        public CompraClienteController(ICompraClienteService service)
        {
            this.compraClienteService = service;
        }

        [HttpGet]
        public ActionResult<List<CompraCliente>> ListarCompraCliente()
        {
            return compraClienteService.ListarComprasClientes();
        }

        [HttpPost]
        public ActionResult CadastrarCompraCliente(CompraCliente compraCliente)
        {
            compraClienteService.CadastrarCompraCliente(compraCliente);
            return Ok();
        }
        
    }
}
