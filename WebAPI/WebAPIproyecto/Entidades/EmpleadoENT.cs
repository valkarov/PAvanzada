using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIproyecto.Entidades
{
    public class EmpleadoENT
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string numero { get; set; }
        public string correo_electronico { get; set; }
        public int salario { get; set; }
        public string puesto { get; set; }
        public DateTime? fecha_salida { get; set; }

    }
}