using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;
using ProjetoLanchonete.Context;
using ProjetoLanchonete.Models;

namespace ProjetoLanchonete.Repositories
{
    public class LancheRepository : ILanchesRepository
    {
        private readonly AppDBContext _context;

        public LancheRepository(AppDBContext contexto)
        {   
            _context = contexto;
        }
        public IEnumerable<Lanche> Lanches => _context.Lanche.Include(c=> c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanche.Where(p=> 
        p.IsLanchePreferido).Include(c=> c.Categoria);

       public Lanche GetLancheById ( int lancheId)
       {
           return _context.Lanche.FirstOrDefault(l=> l.LancheId == lancheId);
       }
    }
}