using Projeto02.Filtro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto02.Controllers
{
    [AutorizacaoFilter]

    public class HomeController : Controller
    {
        //[AutorizacaoFilter]
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
        //[AutorizacaoFilter]
        public ActionResult Adm()
        {

            return View();
        }

        public ActionResult Gestor()
        {
            return View();
        }
    }
}