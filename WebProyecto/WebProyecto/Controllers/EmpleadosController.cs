using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_R_R_Gastronomia.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult V_AgregarEmpleado()
        {
            return View();
        }

        public ActionResult V_AsignarEmpleadoEvento() 
        { 
            return View(); 
        }
    }
}
