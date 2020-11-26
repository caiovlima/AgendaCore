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
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
