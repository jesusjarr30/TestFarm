using Apiprubas.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apiprubas.Controllers

{
    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : Controller { 
        
        //parece que esto es muy similar a lo inyeccion de dependencias que se utiliza en java springBoot 
        public readonly CervezeriaContext _cervezeriaContext;

        //y en esta prte parece que se tiene que poner 
    public EmpleadosController(CervezeriaContext context)
    {
        _cervezeriaContext = context;
    }

        [HttpGet]
        [Route("Obtener")]
        public IActionResult getLista()
        {

            List<Empleado> lista = new List<Empleado>();
            try
            {
                lista = _cervezeriaContext.Empleados.ToList();
                return StatusCode(StatusCodes.Status200OK, new
                {
                    mensaje = "ok",
                    response
                    = lista
                });
            }
            catch( Exception ex){
                return StatusCode(StatusCodes.Status200OK, new { message = ex.Message });
            }
        }

        // GET: EmpleadosController
        /*public ActionResult Index()
        {
            return View();
        }

        // GET: EmpleadosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpleadosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpleadosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpleadosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
