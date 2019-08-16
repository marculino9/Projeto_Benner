using Projeto02.DAO;
using Projeto02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto02.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autentica(String login, String senha)
        {
            UsuarioDAO dao = new UsuarioDAO();
            Usuario usuario = dao.Busca(login, senha);
            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("index");
            }

        }

        [HttpPost]
        public ActionResult Adiciona(Usuario usuario)
        {
            FuncionarioDAO funDao = new FuncionarioDAO();
            var idFunc = funDao.BuscarPorCodigoVerificacao(usuario.CodigoVerificacao);

            if (idFunc == 0)
                throw new InvalidOperationException("Código de verificação inválido") ;

            usuario.FuncionarioId = idFunc;

            UsuarioDAO dao = new UsuarioDAO();
            dao.Adiciona(usuario);
            return View("Adiciona");
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Visualiza()
        {
            var dao = new UsuarioDAO();
            IList<Usuario> usuario = dao.Lista();
            ViewBag.Usuario = usuario;
            return View();
        }
    }
}