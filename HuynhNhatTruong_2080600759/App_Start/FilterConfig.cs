using System.Web;
using System.Web.Mvc;

namespace HuynhNhatTruong_2080600759
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
