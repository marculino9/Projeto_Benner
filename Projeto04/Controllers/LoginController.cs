using Projeto02.DAO;
using Projeto02.Models;
using Projeto02.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto02.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        
        public ActionResult Autenticacao(String login, String senha)
        {
            var dao = new UsuarioDAO();
            Usuario usuario = dao.Busca(login, senha);

            Session["usuarioLogin"] = usuario;
 
            if (usuario == null)
            {
                ModelState.AddModelError("senha", "Usuário e/ou senha inválidos");
                return View("Login");
            }
            else if (usuario.Funcionario.TipoPerfil == TipoPerfil.Administrador)
            {
                Session["TipoPerfil"] = TipoPerfil.Administrador;
                Session["nomeUsuario"] = usuario.Funcionario.Nome; ;
                return RedirectToAction("Adm", "Home");
            }
            else if (usuario.Funcionario.TipoPerfil == TipoPerfil.Gestor)
            {
                Session["TipoPerfil"] = TipoPerfil.Gestor;
                Session["nomeUsuario"] = usuario.Funcionario.Nome;
                return RedirectToAction("Gestor", "Home");
            }
            else if (usuario.Funcionario.TipoPerfil == TipoPerfil.Funcionario)
            {
                Session["TipoPerfil"] = TipoPerfil.Funcionario;
                Session["nomeUsuario"] = usuario.Funcionario.Nome;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return new HttpUnauthorizedResult("Usuário com perfil inválido");
            }
        }
    }
}