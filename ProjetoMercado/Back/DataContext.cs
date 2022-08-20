using Back.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back
{
    public class DataContext : DbContext
    {

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Produto> produtos { get; set; }
        public DbSet<CompraCliente> compraClientes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=ProjetoTeste; Trusted_Connection = true");
        }
    }
}
