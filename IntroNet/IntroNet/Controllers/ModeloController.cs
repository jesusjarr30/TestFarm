using IntroNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroNet.Controllers
{
    public class ModeloController : Controller
    {

        private readonly CervezeriaContext _context;//convencion de .net para cuando sea cosas privadas


        public ModeloController(CervezeriaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var beers = await _context.Modelos
        .Include(b => b.IdMarcaNavigation) // Usa la propiedad de navegación correcta
        .ToListAsync();

            return View(beers);
        }
    }
}
