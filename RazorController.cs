using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5Razor.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()
        {
            ViewBag.curso = "Curso de AspNet MVC 5 com Razor";  // dicionário ViewBag

            var hora = DateTime.Now.Hour; // obtem o componente hora

            ViewBag.hora = hora;

            
            if (hora > 12)
            {
               ViewBag.turno = "tarde";
            }
            else
            {
                ViewBag.turno = "manhã";
            }

            return View();
        }
    }
}