using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using ProjetoLanchonete.Models;

namespace ProjetoLanchonete.Repositories
{
    public interface ILanchesRepository
    {
         IEnumerable<Lanche> Lanches{get;}
         IEnumerable<Lanche> LanchesPreferidos {get;}
         Lanche GetLancheById(int LancheId);

    }
}