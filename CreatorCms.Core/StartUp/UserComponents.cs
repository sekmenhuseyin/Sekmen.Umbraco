using CreatorCms.Core.Controllers;
using CreatorCms.Core.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;
// ReSharper disable UnusedMember.Global

namespace CreatorCms.Core.StartUp
{
    public class UserComponents : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<UploadController>(Lifetime.Request);
            composition.Register<CountriesService>(Lifetime.Request);
            composition.Components().Append<Routing>();
        }
    }
}
