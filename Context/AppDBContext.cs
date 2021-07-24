using Microsoft.EntityFrameworkCore;
using ProjetoLanchonete.Models;

namespace ProjetoLanchonete.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Lanche> Lanche{get;set;}
        public DbSet<Categoria> Categorias {get;set;}
        
    }
}