using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIproyecto.Entidades
{
    public class InformeInventario
    {
        public int IdIngrediente { get; set; }
        public string Nombre { get; set; }
        public int CantidadDisponible { get; set; }
        public double Precio { get; set; }
    }
}
