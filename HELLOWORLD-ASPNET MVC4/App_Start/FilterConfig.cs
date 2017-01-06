using System.Web;
using System.Web.Mvc;

namespace HELLOWORLD_ASPNET_MVC4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}