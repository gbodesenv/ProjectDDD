using System.Web;
using System.Web.Mvc;

namespace Rj.SME.Sismonrio.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
