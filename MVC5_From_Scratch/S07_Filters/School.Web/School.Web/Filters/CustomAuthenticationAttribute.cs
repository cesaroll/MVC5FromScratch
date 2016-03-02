using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Ces.Sch.Web.Filters
{
    public class CustomAuthenticationAttribute : FilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (filterContext == null || filterContext.Principal == null || filterContext.Principal.Identity == null || 
                !filterContext.Principal.Identity.IsAuthenticated)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            //throw new System.NotImplementedException();
        }
    }
}