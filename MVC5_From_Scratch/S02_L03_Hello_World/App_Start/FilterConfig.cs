using System.Web;
using System.Web.Mvc;

namespace S02_L03_Hello_World
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
