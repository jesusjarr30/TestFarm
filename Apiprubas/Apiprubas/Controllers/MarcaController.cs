using Apiprubas.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Apiprubas.Controllers
{
    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : Controller
    { 
        public readonly CervezeriaContext _cervezeriaContext;

        public MarcaController(CervezeriaContext context)
        {
            _cervezeriaContext = context;
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult crearMarca([FromBody] Marca m)
        {
            try
            {
                _cervezeriaContext.Marcas.Add(m);
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
        public IActionResult EditMarca(Marca m) {
            Marca marca = _cervezeriaContext.Marcas.Find(m.Id);

            if (marca == null)
            {
                return BadRequest("No se eonctro la Marca que se esta buscando");
            }
            //si se encutra la direccion entonces se tien guardar los cambios que se necesitan 
            try
            {
                //si se tiene mas campos hacer lo mismo con todos 
                marca.Nombre = m.Nombre is null ? marca.Nombre : m.Nombre;
                _cervezeriaContext.Marcas.Update(marca);
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
        public IActionResult deleteMarca(int idMarca)
        {
            Marca marca = _cervezeriaContext.Marcas.Find(idMarca);

            if (marca == null)
            {
                return BadRequest("No se eonctro la Marca que se esta buscando");
            }
            //hacer la eliminacion
            try
            {
                _cervezeriaContext.Marcas.Remove(marca);
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
            List<Marca> lista = new List<Marca>();

            try
            {
                lista = _cervezeriaContext.Marcas.ToList();
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
