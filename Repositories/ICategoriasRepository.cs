using System.Collections.Generic;
using ProjetoLanchonete.Models;
using System;
using System.Linq;

namespace ProjetoLanchonete.Repositories
{
    public interface ICategoriasRepository
    {
        IEnumerable<Categoria> Categorias { get;}
        
    }
}