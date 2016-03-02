using System.Web.Mvc;

namespace Ces.Sch.Web.Filters
{
    public class ExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                filterContext.Result = new ViewResult
                {
                    ViewName = "Error",
                    ViewData = new ViewDataDictionary<string>(filterContext.Exception.Message)
                };

                filterContext.ExceptionHandled = true;
            }
        }
    }
}