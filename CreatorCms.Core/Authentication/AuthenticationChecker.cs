using Microsoft.Owin.Security;
using System.Web;
using Umbraco.Web.Security;

namespace CreatorCms.Core.Authentication
{
    public static class AuthenticationChecker
    {
        public static bool IsAuthenticated(HttpContextBase httpContext)
        {
            AuthenticationTicket ticket = httpContext.GetUmbracoAuthTicket();
            return ticket != null;
        }
    }
}
