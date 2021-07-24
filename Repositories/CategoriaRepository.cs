using System.Collections.Generic;
using ProjetoLanchonete.Models;
using ProjetoLanchonete.Context;

namespace ProjetoLanchonete.Repositories
{
    public class CategoriaRepository : ICategoriasRepository
    {
        private readonly AppDBContext _context;
        public CategoriaRepository(AppDBContext contexto)
        {
            _context = contexto;

        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}