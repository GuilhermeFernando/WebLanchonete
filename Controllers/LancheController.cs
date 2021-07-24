using Microsoft.AspNetCore.Mvc;
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
            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }
    }
}