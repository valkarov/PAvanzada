using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Entidades;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class SuministroController : Controller
    {
        SuministrosModel modelo = new SuministrosModel();

        [HttpGet]
        public ActionResult ListaSuministros()
        {
            var suministros = modelo.ObtenerSuministros();
            return View(suministros);
        }
    }
}
