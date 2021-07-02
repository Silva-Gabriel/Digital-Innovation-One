using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoASPNET.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=ProjetoASPNET;Integrated Security=True");

        }
    }
}
