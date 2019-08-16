using Projeto02.DAO;
using Projeto02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto02.Controllers
{
    public class FuncionarioController : Controller
    {
        //GET: Funcionario
        public ActionResult Index()
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            IList<Funcionario> funcionarios = dao.Lista();
            ViewBag.Funcionario = funcionarios;
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Funcionario funcionario)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.Adiciona(funcionario);
            return View("Adiciona");
        }

        public ActionResult Form()
        {
            EquipeDAO dao = new EquipeDAO();
            IList<Equipe> equipe = dao.Lista();
            ViewBag.Equipe = equipe;

            CargoDAO daoo = new CargoDAO();
            IList<Cargo> cargo = daoo.Lista();
            ViewBag.Cargo = cargo;

            ViewBag.Funcionario = new Funcionario();

            return View();
        }

        public ActionResult Remover(int id)
        {
            var dao = new FuncionarioDAO();
            Funcionario funcionario = dao.BuscaPorIdWhere(id);
            dao.Remover(funcionario);
            return RedirectToAction("Index");
        }
        /*
        [Route("funcionario/{id}")]
        public ActionResult Visualiza()
        {
            var dao = new FuncionarioDAO();
            IList<Funcionario> funcionarios = dao.Lista();
            ViewBag.Funcionario = funcionarios;
            return View();
        }
        */

        public ActionResult Alterar(int id)
        {
            var daoo = new EquipeDAO();
            IList<Equipe> equipe = daoo.Lista();
            ViewBag.Equipe = equipe;

            var daooo = new CargoDAO();
            IList<Cargo> cargo = daooo.Lista();
            ViewBag.Cargo = cargo;

            var dao = new FuncionarioDAO();
            Funcionario funcionario = dao.BuscaPorId(id);
            ViewBag.Funcionario = funcionario;

            return View(funcionario);
        }

        [HttpGet]
        public ActionResult Atualiza(int id)
        {
            var dao = new FuncionarioDAO();
            Funcionario funcionario = dao.BuscaPorId(id);
            return View(funcionario);
        }

        [HttpPost]
        public ActionResult Atualiza([Bind(Include = "Id, Nome, EquipeId, CargoId, Maquina, UsuarioId, EhGestor")] Funcionario funcionario)
        {
            var dao = new FuncionarioDAO();
            dao.Atualiza(funcionario);
            return View();
        }

    }
}
