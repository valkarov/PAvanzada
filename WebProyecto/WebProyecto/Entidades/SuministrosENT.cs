using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProyecto.Entidades
{
    public class SuministrosENT
    {
        public int IdSuministro { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
