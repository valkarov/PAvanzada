using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPIproyecto.Models;
using WebAPIproyecto.Entidades;

namespace WebAPIproyecto.Controllers
{
    public class SuministroController : ApiController
    {
        // Obtener todos los suministros
        [HttpGet]
        [Route("api/suministros/obtener")]
        public IHttpActionResult ObtenerSuministros()
        {
            using (var conexion = new ProyectoPrograAvanzadaEntities())
            {
                var suministros = conexion.Suministros.ToList();
                return Ok(suministros);
            }
        }

        // Generar un informe de suministros
        [HttpGet]
        [Route("api/suministros/informe")]
        public IHttpActionResult GenerarInformeSuministros()
        {
            using (var conexion = new ProyectoPrograAvanzadaEntities())
            {
                var informe = conexion.Suministros.Select(s => new
                {
                    Id = s.id,
                    Nombre = s.nombre,
                    CantidadDisponible = s.cantidad
                }).ToList();

                return Ok(informe);
            }
        }
    }
}
