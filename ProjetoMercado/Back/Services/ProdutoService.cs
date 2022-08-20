using Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Services
{
    public class ProdutoService : IProdutoService
    {
        private DataContext context;

        public ProdutoService()
        {
            this.context = new DataContext();
        }

        public void CadastroProduto(Produto produto)
        {
            context.Add(produto);
            context.SaveChanges();
        }

        public List<Produto> ListarProdutos()
        {
            return context.produtos.ToList();
        }
    }
}
