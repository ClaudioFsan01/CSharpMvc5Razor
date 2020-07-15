using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5Razor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

//O método Index acima usa um modelo de exibição para gerar uma resposta HTML para o navegador.
// Os métodos do controlador(também conhecidos como métodos de ação), como o método Index acima, 
//  geralmente retornam um ActionResult(ou uma classe derivada de ActionResult), não tipos primitivos como cadeia de caracteres.