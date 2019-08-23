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
            object usuario = filterContext.HttpContext.Session["usuarioLogado"];
            object tipoPerfil = filterContext.HttpContext.Session["TipoPerfil"];

            //object perfil = ((TipoPerfil)tipoPerfil == TipoPerfil.Administrador);

            if (usuario == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Usuario", action = "Index" }
                        )
                    );
            }
            if (usuario != null)
            {
                if ((TipoPerfil)tipoPerfil == TipoPerfil.Administrador)
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new { controller = "Home", action = "Adm" }
                            )
                        );
                }
            }

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