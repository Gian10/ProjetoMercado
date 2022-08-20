using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Models
{
    public class CompraCliente
    {
        public int CompraClienteId { get; set; }

        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }


        public int ProdutoId { get; set; }
        [ForeignKey("ProdutoId")]
        public virtual Produto Produto { get; set; }

        public decimal ProdutoValor { get; set; }
    }
}
