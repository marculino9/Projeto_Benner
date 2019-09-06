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
    public class LicencaController : Controller
    {
        // GET: Licenca
        private IList<Software> listaSoftwares
        {
            get
            {
                var dao = new SoftwareDAO();
                return dao.Lista();
            }
        }
        public ActionResult Index()
        {
            var dao = new LicencaDAO();
            IList<Licenca> licenca = dao.Lista();
            ViewBag.Licenca = licenca;
            return View();
        }
        [HttpPost]        
        public ActionResult Adiciona(Licenca licenca)
        {
            if (ModelState.IsValid)
            {
                var dao = new LicencaDAO();
                dao.Adiciona(licenca);
                return View("Adiciona");
            }
            ViewBag.Software = listaSoftwares;

            return View("Form",licenca);
        }

        public ActionResult Form()
        {
            ViewBag.Software = listaSoftwares;            
            return View(new Licenca());
        }
        public ActionResult Remover(int id)
        {
            var dao = new LicencaDAO();
            Licenca licenca = dao.BuscaPorIdWhere(id);
            dao.Remover(licenca);
            return RedirectToAction("Index");
        }

        public ActionResult Alterar(int id)
        {
            var dao = new LicencaDAO();
            Licenca licenca = dao.BuscaPorId(id);
            ViewBag.Licenca = licenca;
            return View(licenca);
        }

        [HttpGet]
        public ActionResult Atualiza(int id)
        {
            var dao = new LicencaDAO();
            Licenca licenca = dao.BuscaPorId(id);
            return View(licenca);
        }

        [HttpPost]
        public ActionResult Atualiza([Bind(Include = "Id, Chave, Quantidade, SoftwareId, UsuarioId")] Licenca licenca)
        {
            var dao = new LicencaDAO();
            dao.Atualiza(licenca);
            return View();
        }
        public ActionResult DecrementaQtd(int id)
        {
            LicencaDAO dao = new LicencaDAO();
            Licenca licenca = dao.BuscaPorId(id);
            licenca.Quantidade--;
            dao.Atualiza(licenca);
            return Json(licenca);
        }
    }
}