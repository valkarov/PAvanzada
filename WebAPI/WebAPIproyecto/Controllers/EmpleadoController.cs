using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIproyecto.Entidades;
using WebAPIproyecto.Models;

namespace WebAPIproyecto.Controllers
{
    public class EmpleadoController : ApiController
    {
        [HttpGet]
        [Route("ConsultarEmpleado")]
        public  List<ConsultarEmpleado_SP_Result> ConsultarEmpleado() 
        {
            using (var conexion = new ProyectoPrograAvanzadaEntities()) 
            {
                return conexion.ConsultarEmpleado_SP().ToList();
            }
        }

        [HttpPost]
        [Route("InsertarEmpleado")]
        public int InsertarEmpleado(EmpleadoENT e) 
        {

            using (var conexion = new ProyectoPrograAvanzadaEntities()) 
            {
                return conexion.InsertarEmpleado_SP(e.cedula, e.nombre, e.direccion, e.numero, e.correo_electronico, e.salario, e.puesto, e.fecha_salida);
            }
        
        }


    }
}
