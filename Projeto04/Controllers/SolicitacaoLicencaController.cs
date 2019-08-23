using Projeto02.DAO;
using Projeto02.ExtensionMethods;
using Projeto02.Models;
using Projeto02.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto02.Controllers
{
    public class SolicitacaoLicencaController : Controller
    {
        // GET: SolicitacaoLicenca
        public ActionResult Index()
        {
            var dao = new SolicitacaoLicencaDAO();
            IList<SolicitacaoLicenca> solicitacaoLicenca = dao.Lista();
            ViewBag.SolicitacaoLicenca = solicitacaoLicenca;
            return View();
        }

        public ActionResult Adiciona(SolicitacaoLicenca solicitacaoLicenca)
        {

            var dao = new SolicitacaoLicencaDAO();
            var ultimaSolicitacao = dao.Lista().FirstOrDefault();
            if (ultimaSolicitacao == null)
            {
                var protocolo = 1;
                solicitacaoLicenca.Protocolo = protocolo++;
            }
            else
            {
                solicitacaoLicenca.Protocolo = ultimaSolicitacao.Protocolo++;
            }
            dao.Adiciona(solicitacaoLicenca);
            return View();
        }

        public ActionResult Form()
        {
            var dao = new SoftwareDAO();
            IList<Software> softwares = dao.Lista();
            ViewBag.Software = softwares;

            var daoo = new UsuarioDAO();
            IList<Usuario> usuario = daoo.Lista();
            ViewBag.Usuario = usuario;

            ViewBag.SolicitacaoLicenca = new SolicitacaoLicenca();

            ViewBag.ListaEnum = Status.AguardandoAprovacaodoGestor.ToSelectList();

            return View();
        }
        public ActionResult Remover(int id)
        {
            var dao = new SolicitacaoLicencaDAO();
            SolicitacaoLicenca solicitacaoLicenca = dao.BuscaPorIdWhere(id);
            dao.Remover(solicitacaoLicenca);
            return RedirectToAction("Index");
        }
        public ActionResult Alterar(int id)
        {
            var dao = new SoftwareDAO();
            IList<Software> softwares = dao.Lista();
            ViewBag.Software = softwares;

            var daoo = new SolicitacaoLicencaDAO();
            SolicitacaoLicenca solicitacaoLicenca = daoo.BuscaPorId(id);
            ViewBag.SolicitacaoLicenca = solicitacaoLicenca;

            ViewBag.ListaEnum = Status.AguardandoAprovacaodoGestor.ToSelectList();

            return View(solicitacaoLicenca);
        }

        [HttpGet]
        public ActionResult Atualiza(int id)
        {
            var dao = new SolicitacaoLicencaDAO();
            SolicitacaoLicenca solicitacaoLicenca = dao.BuscaPorId(id);
            return View(solicitacaoLicenca);
        }

        [HttpPost]
        public ActionResult Atualiza(int id, [Bind(Include = "Id, SoftwareId, DataInicio, DataTermino, UsuarioId, MotivoDeUso, Status")] SolicitacaoLicenca solicitacaoLicenca)
        {
            solicitacaoLicenca.Id = id;
            var dao = new SolicitacaoLicencaDAO();
            dao.Atualiza(solicitacaoLicenca);
            return View();
        }

        public ActionResult Licenca()
        {
            var dao = new SolicitacaoLicencaDAO();
            IList<SolicitacaoLicenca> solicitacaoLicenca = dao.Lista();
            ViewBag.SolicitacaoLicenca = solicitacaoLicenca;
            return View();
        }
    }
}