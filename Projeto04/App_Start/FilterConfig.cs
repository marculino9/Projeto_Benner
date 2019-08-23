using Projeto02.Filtro;
using System.Web;
using System.Web.Mvc;

namespace Projeto02
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new AutorizacaoFilterAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
