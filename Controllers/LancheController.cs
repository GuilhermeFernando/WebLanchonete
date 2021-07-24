using Microsoft.AspNetCore.Mvc;
using ProjetoLanchonete.ViewModels;
using ProjetoLanchonete.Repositories;

namespace ProjetoLanchonete.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILanchesRepository _lancheRepository;
        private readonly ICategoriasRepository _categoriaRepository;

        public LancheController(ILanchesRepository lancheRepository, ICategoriasRepository categoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult List()
        {
            ViewBag.Lanche ="Lanches";
            ViewData["Categoria"]= "Categoria";

            var lanchelistViewModel = new LancheListViewModel();
            lanchelistViewModel.Lanches = _lancheRepository.Lanches;
            lanchelistViewModel.CategoriaAtual ="Categoria Atual";
            return View(lanchelistViewModel);
            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);
            
        }
    }
}