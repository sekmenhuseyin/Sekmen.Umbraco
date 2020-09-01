using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core.Composing;

namespace CreatorCms.Core.StartUp
{
    public class Routing : IComponent
    {
        public void Initialize()
        {
            RouteTable.Routes.MapRoute("TeamMatchController", "TeamMatch/{action}/{id}", new { controller = "TeamMatch", action = "Index", id = UrlParameter.Optional }, new[] { "Proteam360.Core" });
            RouteTable.Routes.MapRoute("PlayerMatchController", "PlayerMatch/{action}/{id}", new { controller = "PlayerMatch", action = "Index", id = UrlParameter.Optional }, new[] { "Proteam360.Core" });
        }

        public void Terminate()
        {
            // Nothing to terminate
        }
    }
}
