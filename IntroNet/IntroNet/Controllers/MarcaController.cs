using IntroNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroNet.Controllers
{
    public class MarcaController : Controller
    {

        private readonly CervezeriaContext _context;//convencion de .net para cuando sea cosas privadas


        public MarcaController(CervezeriaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Marcas.ToListAsync());
        }
    }
}
