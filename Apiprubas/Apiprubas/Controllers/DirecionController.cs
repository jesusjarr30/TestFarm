using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using Apiprubas.Models;
using Microsoft.AspNetCore.Cors;

namespace Apiprubas.Controllers
{
    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class DirecionController : ControllerBase
    {
        public readonly CervezeriaContext _cervezeriaContext;
            //para poder hacer las opciones Crud

            public DirecionController(CervezeriaContext context)
        {
            _cervezeriaContext = context;
        }

        //lista de todos las direciones 

        [HttpGet]
        [Route("Lista")]
        public IActionResult getLista()
        {
            //obtenemos la lista que se necesita 
            List<Direccion> lista = new List<Direccion>();

            //y se procede a hacer el try catch que se requiere 

            try
            {
                lista = _cervezeriaContext.Direccions.ToList();
                return StatusCode(StatusCodes.Status200OK, new {mensaje="ok", response
                = lista});
            }catch(Exception ex){
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }

        [HttpGet]
        [Route("obtener/{idDireccion:int}")]
        public IActionResult Obtener(int idDireccion)
        {
            //obtenemos la lista que se necesita 
            Direccion direccion = _cervezeriaContext.Direccions.Find(idDireccion);

            if (direccion == null)
            {
                return BadRequest("No se eonctro la Direccion que se esta buscando");
            }

            try
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", Response = direccion });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = direccion });
            }
        }
        [HttpPost]
        [Route("Guaradar/")]
        public IActionResult Guardar([FromBody] Direccion d)
        {
            _cervezeriaContext.Direccions.Add(d);
            _cervezeriaContext.SaveChanges();

           try
            {
                _cervezeriaContext.Direccions.Add(d);
                _cervezeriaContext.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, new { mensaje = "ok" });
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }

        }
        //vamos a hacer el put

        [HttpPut]
        [Route("Editar/")]
        public IActionResult Editar (Direccion d){

            Direccion direccion = _cervezeriaContext.Direccions.Find(d.Id);

            if (direccion == null)
            {
                return BadRequest("No se eonctro la Direccion que se esta buscando");
            }
            //si se encutra la direccion entonces se tien guardar los cambios que se necesitan 
            try
            {
                //si se tiene mas campos hacer lo mismo con todos 
                direccion.Nombre = d.Nombre is null ? direccion.Nombre : d.Nombre;
                _cervezeriaContext.Direccions.Update(direccion);
                _cervezeriaContext.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { message = "ok" });


            }catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new { message = "No se puede registrar" });
            }

        }

        //Eliminar un registro de la base de datos 

        [HttpDelete]
        [Route("Eliminar/{idDireccion:int}")]
        public IActionResult Eliminar(int idDireccion)
        {
            Direccion direccion = _cervezeriaContext.Direccions.Find(idDireccion);

            if (direccion == null)
            {
                return BadRequest("No se eonctro la Direccion que se esta buscando");
            }
            //hacer la eliminacion
            try
            {
                _cervezeriaContext.Direccions.Remove(direccion);
                _cervezeriaContext.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { message = "ok" });

            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status421MisdirectedRequest, new { message = "ok" });

            }

        }

    }
}
