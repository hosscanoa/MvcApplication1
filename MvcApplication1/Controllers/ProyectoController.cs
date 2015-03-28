using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class ProyectoController : Controller
    {
        //
        // GET: /Proyecto/

        public ActionResult Index()
        {
            ViewBag.titulo = "Bienvenido";
            ViewBag.detalle = "Desarrollo para Entorno Web";

            return View();
        }

    }
}
