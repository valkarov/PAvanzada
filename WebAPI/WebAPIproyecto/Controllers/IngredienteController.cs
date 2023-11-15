using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPIproyecto.Models;

namespace WebAPIproyecto.Controllers
{
    public class IngredienteController : ApiController
    {
        // Listar todos los ingredientes
        [HttpGet]
        [Route("api/Ingredientes/ListarIngredientes")]
        public IHttpActionResult ListarIngredientes()
        {
            using (var conexion = new ProyectoPrograAvanzadaEntities())
            {
                var ingredientes = conexion.Ingredientes.ToList();
                return Ok(ingredientes);
            }
        }

        // Añadir un nuevo ingrediente
        [HttpPost]
        [Route("api/Ingredientes/AgregarIngrediente")]
        public IHttpActionResult AgregarIngrediente(Ingrediente ingrediente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using (var conexion = new ProyectoPrograAvanzadaEntities())
            {
                conexion.Ingredientes.Add(ingrediente);
                conexion.SaveChanges();
            }

            return Ok();
        }

        // Actualizar la cantidad de un ingrediente
        [HttpPost]
        [Route("api/Ingredientes/ActualizarCantidad")]
        public IHttpActionResult ActualizarCantidad(int idIngrediente, int cantidad)
        {
            using (var conexion = new ProyectoPrograAvanzadaEntities())
            {
                var ingrediente = conexion.Ingredientes.FirstOrDefault(i => i.Id_Ingrediente == idIngrediente);
                if (ingrediente == null)
                {
                    return NotFound();
                }

                ingrediente.Cantidad = cantidad;
                conexion.SaveChanges();
                return Ok();
            }
        }

        // Generar un informe de inventario
        [HttpGet]
        [Route("api/Ingredientes/GenerarInformeInventario")]
        public IHttpActionResult GenerarInformeInventario()
        {
            using (var conexion = new ProyectoPrograAvanzadaEntities())
            {
                var informe = conexion.Ingredientes.Select(i => new InformeInventario
                {
                    IdIngrediente = i.Id_Ingrediente,
                    Nombre = i.Nombre,
                    CantidadDisponible = i.Cantidad,
                    Precio = i.Precio
                }).ToList();

                return Ok(informe);
            }
        }
    }
}
