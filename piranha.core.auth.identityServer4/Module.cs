using System;
using Piranha.Extend;

namespace Piranha.IdentityServer4
{
    public class Module : IModule
    {
        /// <summary>
        /// Gets the Author
        /// </summary>
        public string Author => "Piranha";

        /// <summary>
        /// Gets the Name
        /// </summary>
        public string Name => "Bondx.Piranha.IdentityServer4.Auth";

        /// <summary>
        /// Gets the Version
        /// </summary>
        public string Version => Piranha.Utils.GetAssemblyVersion(GetType().Assembly);

        /// <summary>
        /// Gets the description
        /// </summary>
        public string Description => "OAuth for Piranha CMS using Identity Server 4.";

        /// <summary>
        /// Gets the package url.
        /// </summary>
        public string PackageUrl => "https://www.nuget.org/packages/Bondx.Piranha.IdentityServer4.Auth";

        /// <summary>
        /// Gets the icon url.
        /// </summary>
        public string IconUrl => "https://identityserver.io/images/IDserver_logotransparent.png";

        /// <summary>
        /// Initializes the module.
        /// </summary>
        public void Init() { }
    }
}
