using System;
using System.Collections.Generic;
using System.Text;
using AppMvcBasica.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppMvcBasica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Mapear propriedades, recomendado apenas quando há uma camada
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores{ get; set; }
        public DbSet<Endereco> Enderecos{ get; set; }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
