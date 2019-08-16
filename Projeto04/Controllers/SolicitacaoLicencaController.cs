using Projeto02.DAO;
using Projeto02.Models;
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
            return View();
        }

        public ActionResult Adiciona(SolicitacaoLicenca solicitacaoLicenca)
        {
            var dao = new SolicitacaoLicencaDAO();
            dao.Adiciona(solicitacaoLicenca);
            solicitacaoLicenca.Protocolo++;
            return View();
        }

        //public ActionResult Form()
        //{
        //    SolicitacaoLicencaDAO solicitacaoLicencaDAO = new SolicitacaoLicencaDAO();
        //    IList<Licenca> licenca = solicitacaoLicencaDAO.Lista();
        //    ViewBag.Licenca = licenca;
        //    ViewBag.SolicitacaoLicenca = new SolicitacaoLicenca();
        //    return View(licenca);
        //}
    }
}