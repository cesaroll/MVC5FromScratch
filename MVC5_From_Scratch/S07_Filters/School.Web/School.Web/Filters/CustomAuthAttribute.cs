using System.Web;
using System.Web.Mvc;

namespace Ces.Sch.Web.Filters
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {
        private bool LocalAllowed { get; set; }

        public CustomAuthAttribute(bool localAllowed)
        {
            LocalAllowed = localAllowed;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if(httpContext.Request.IsLocal)
                return LocalAllowed;

            return true;
        }
    }
}