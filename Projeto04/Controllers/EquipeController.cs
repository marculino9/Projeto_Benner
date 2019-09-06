using Projeto02.DAO;
using Projeto02.Filtro;
using Projeto02.Models;
using Projeto02.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto02.Controllers
{
    [AutorizacaoFilter]
    public class EquipeController : Controller
    {
        // GET: Equipe
        public ActionResult Index()
        {
            EquipeDAO dao = new EquipeDAO();
            IList<Equipe> equipe = dao.Lista();
            ViewBag.Equipe = equipe;
            return View();
        }
        [HttpPost]
        public ActionResult Adiciona(Equipe equipe)
        {
            if (ModelState.IsValid)
            {
                EquipeDAO dao = new EquipeDAO();
                dao.Adiciona(equipe);
                return View("Adiciona");
            }
            return View("Form");
        }

        public ActionResult Form()
        {
            var dao = new FuncionarioDAO();
            IList<Funcionario> funcionario = dao.Lista().Where(x => x.TipoPerfil == TipoPerfil.Gestor).ToList();
            ViewBag.Funcionario = funcionario;

            return View();
        }
        public ActionResult Remover(int id)
        {
            var dao = new EquipeDAO();
            Equipe equipe = dao.BuscaPorIdWhere(id);
            dao.Remover(equipe);
            return RedirectToAction("Index");
        }

        public ActionResult Alterar(int id)
        {
            var dao = new EquipeDAO();
            Equipe equipe = dao.BuscaPorId(id);
            ViewBag.Equipe = equipe;

            return View(equipe);
        }

        [HttpGet]
        public ActionResult Atualiza(int id)
        {
            var dao = new EquipeDAO();
            Equipe equipe = dao.BuscaPorId(id);
            return View(equipe);
        }

        [HttpPost]
        public ActionResult Atualiza([Bind(Include = "Id, NomeEquipe, GestorId")] Equipe equipe)
        {
            var dao = new EquipeDAO();
            dao.Atualiza(equipe);
            return View();
        }
    }
}