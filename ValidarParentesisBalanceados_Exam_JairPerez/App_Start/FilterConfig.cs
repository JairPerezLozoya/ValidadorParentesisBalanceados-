using System.Web;
using System.Web.Mvc;

namespace ValidarParentesisBalanceados_Exam_JairPerez
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
