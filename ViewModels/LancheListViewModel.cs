using ProjetoLanchonete.Models;
using System.Collections.Generic;
namespace ProjetoLanchonete.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches {get;set;}
        public string CategoriaAtual {get;set;}
    }
}