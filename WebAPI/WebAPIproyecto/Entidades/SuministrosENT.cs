using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIproyecto.Entidades
{
    public class SuministroENT
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
    }
}
