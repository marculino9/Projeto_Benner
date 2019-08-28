using Projeto02.DAO;
using Projeto02.Filtro;
using Projeto02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto02.Controllers
{
    [AutorizacaoFilter]
    public class SoftwareController : Controller
    {
        // GET: Software
        public ActionResult Index()
        {
            var dao = new SoftwareDAO();
            IList<Software> software = dao.Lista();
            ViewBag.Software = software;
            return View();
        }
        [HttpPost]
        public ActionResult Adiciona(Software software)
        {
            if (ModelState.IsValid)
            {
                var dao = new SoftwareDAO();
                dao.Adiciona(software);
                return View("Adiciona");
            }
            return View("Form");
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Remover(int id)
        {
            var dao = new SoftwareDAO();
            Software software = dao.BuscaPorIdWhere(id);
            dao.Remover(software);
            return RedirectToAction("Index");
        }

        public ActionResult Alterar(int id)
        {
            var dao = new SoftwareDAO();
            Software software = dao.BuscaPorId(id);
            ViewBag.Software = software;
            return View(software);
        }

        [HttpGet]
        public ActionResult Atualiza(int id)
        {
            var dao = new SoftwareDAO();
            Software software = dao.BuscaPorId(id);
            return View(software);
        }

        [HttpPost]
        public ActionResult Atualiza([Bind(Include = "Id, NomeSoftware, Versao")] Software software)
        {
            var dao = new SoftwareDAO();
            dao.Atualiza(software);
            return View();
        }
    }
}