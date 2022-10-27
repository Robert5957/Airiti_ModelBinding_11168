using System.Web;
using System.Web.Mvc;

namespace ModelBindingMVCAPI_11168
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
