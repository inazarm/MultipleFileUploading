using System.Web;
using System.Web.Mvc;

namespace Multiple_File_Uploading_ASP.NET_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
