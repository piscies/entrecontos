using System.Web;
using System.Web.Mvc;

namespace Piscies.EntreContos.Frontend.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
