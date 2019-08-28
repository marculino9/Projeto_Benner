using Projeto02.DAO;
using Projeto02.Models;
using Projeto02.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Projeto02.Filtro
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            //object usuario = filterContext.HttpContext.Session["userAdm"];
            //object tipoPerfil = filterContext.HttpContext.Session["TipoPerfil"];
            object logado = filterContext.HttpContext.Session["usuarioLogin"];

            //object perfil = ((TipoPerfil)tipoPerfil == TipoPerfil.Administrador);

            if (logado == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Login", action = "Login" }
                        )
                    );
            }//else
            //{
            //    filterContext.Result = new RedirectToRouteResult(
            //        new RouteValueDictionary(
            //            new { controller = "Login", action = "Login" }
            //            )
            //        );
            //}
            //if (usuario != null)
            //{
            //    if ((TipoPerfil)tipoPerfil == TipoPerfil.Administrador)
            //    {
            //        filterContext.Result = new RedirectToRouteResult(
            //            new RouteValueDictionary(
            //                new { controller = "Home", action = "Adm" }
            //                )
            //            );
            //    }
            //}

            //if (usuario != null)
            //{
            //    var controllerPage = string.Empty;
            //    var actionPage = string.Empty;

            //    if ((TipoPerfil)tipoPerfil == TipoPerfil.Administrador)
            //    {
            //        filterContext.Result = new RedirectToRouteResult(
            //            new RouteValueDictionary(
            //                new { controller = "Home", action = "Adm" }
            //                )
            //            );
            //    }
            //    else
            //    {
            //        filterContext.Result = new RedirectToRouteResult(
            //            new RouteValueDictionary(
            //                new { controller = "Home", action = "Index" }
            //                )
            //            );
            //    }

            //filterContext.Result = new RedirectToRouteResult(
            //    new RouteValueDictionary(
            //        new { controller = controllerPage, action = actionPage }
            //        )
            //    );


        }

    }

    //private void Redirecionar(ActionExecutingContext filterContext, string controllerPage, string actionPage)
    //{

    //}
}