using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Entidades;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class EmpleadoController : Controller
    {
        EmpleadosModel model = new EmpleadosModel();

        [HttpGet]
        
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult InsertarEmpleado()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertarEmpleado(EmpleadoENT e)
        {
            model.InsertarEmpleado(e);
            return View();
        }

        
    }
}