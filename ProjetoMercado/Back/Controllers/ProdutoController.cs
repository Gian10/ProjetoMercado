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
    public class ProdutoController : ControllerBase
    {
        private IProdutoService produtoService;
        public ProdutoController(IProdutoService produto)
        {
            this.produtoService = produto;
        }

        [HttpPost]
        public ActionResult CadastroProduto(Produto produto)
        {
            produtoService.CadastroProduto(produto);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<Produto>> ListarProdutos()
        {
            return produtoService.ListarProdutos();
        }



    }



}
    