using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Models
{
    public class Produto
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Codigo { get; set; }

        public decimal Valor { get; set; }

        public virtual ICollection<CompraCliente> CompraClientes { get; set; }
    }
}
