using Filters.Infrastructure;
using System.Web;
using System.Web.Mvc;

namespace Filters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomExceptionAttribute());
            filters.Add(new ProfileAllAttribute());
            filters.Add(new CustomAuthAttribute(true));
        }
    }
}
