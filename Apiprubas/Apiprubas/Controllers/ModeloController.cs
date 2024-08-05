using Apiprubas.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Apiprubas.Controllers
{
    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController : Controller
    {
        public readonly CervezeriaContext _cervezeriaContext;

        public ModeloController(CervezeriaContext context)
        {
            _cervezeriaContext = context;
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult crearModelo([FromBody] Modelo m)
        {
            try
            {
                _cervezeriaContext.Modelos.Add(m);
                _cervezeriaContext.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }
        [HttpPut]
        [Route("Editar")]
        public IActionResult EditModelo(Modelo m)
        {
            Modelo modelo = _cervezeriaContext.Modelos.Find(m.Id);

            if (modelo == null)
            {
                return BadRequest("No se eonctro la Marca que se esta buscando");
            }
            //si se encutra la direccion entonces se tien guardar los cambios que se necesitan 
            try
            {
                //si se tiene mas campos hacer lo mismo con todos 
                modelo.Nombre = m.Nombre is null ? modelo.Nombre : m.Nombre;
                _cervezeriaContext.Modelos.Update(modelo);
                _cervezeriaContext.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { message = "ok" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new { message = "No se puedo editar el id que se busca" });
            }
        }
        [HttpDelete]
        [Route("Eliminar")]
        public IActionResult deleteModelo(int idModelo)
        {
            Modelo modelo = _cervezeriaContext.Modelos.Find(idModelo);

            if (modelo == null)
            {
                return BadRequest("No se eonctro la Modelo que se esta buscando");
            }
            //hacer la eliminacion
            try
            {
                _cervezeriaContext.Modelos.Remove(modelo);
                _cervezeriaContext.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { message = "ok" });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status421MisdirectedRequest, new { message = "No puede eliminar la marca" });
            }

        }
        [HttpGet]
        [Route("lista")]
        public IActionResult getLista()
        {
            List<Modelo> lista = new List<Modelo>();

            try
            {
                lista = _cervezeriaContext.Modelos.ToList();
                return StatusCode(StatusCodes.Status200OK, new
                {
                    mensaje = "ok",
                    response
                = lista
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }
    }
}
