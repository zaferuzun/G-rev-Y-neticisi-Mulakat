using System.Web;
using System.Web.Mvc;

namespace Görev_Yöneticisi_Mulakat
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
