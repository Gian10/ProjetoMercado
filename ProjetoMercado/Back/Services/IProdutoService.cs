using Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Services
{
    public interface IProdutoService
    {

        public void CadastroProduto(Produto produto);

        public List<Produto> ListarProdutos();
    }
}
