using CatraSports.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatraSports.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductosActivos();

            ViewBag.adminwebsiteUrl =
                ConfigurationManager.AppSettings["adminwebsiteUrl"];

            return View(listadeProductos);
        }
    }
}