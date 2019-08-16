using Projeto02.DAO;
using Projeto02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto02.Controllers
{
    public class CargoController : Controller
    {
        // GET: Cargo
        public ActionResult Index()
        {
            CargoDAO dao = new CargoDAO();
            IList<Cargo> cargo = dao.Lista();
            ViewBag.Cargo = cargo;
            return View();
        }
        [HttpPost]
        public ActionResult Adiciona(Cargo cargo)
        {
            CargoDAO dao = new CargoDAO();
            dao.Adiciona(cargo);
            return View("Adiciona");
        }
        [Route("adm/CadastrarCargo")]
        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Remover(int id)
        {
            var dao = new CargoDAO();
            Cargo cargo = dao.BuscaPorIdWhere(id);
            dao.Remover(cargo);
            return RedirectToAction("Index");
        }

        public ActionResult Alterar(int id)
        {
            var dao = new CargoDAO();
            Cargo cargo = dao.BuscaPorId(id);
            ViewBag.Cargo = cargo;

            return View(cargo);
        }

        [HttpGet]
        public ActionResult Atualiza(int id)
        {
            var dao = new CargoDAO();
            Cargo cargo = dao.BuscaPorId(id);
            return View(cargo);
        }

        [HttpPost]
        public ActionResult Atualiza([Bind(Include = "Id, NomeCargo")] Cargo cargo)
        {
            var dao = new CargoDAO();
            dao.Atualiza(cargo);
            return View();
        }
    }
}