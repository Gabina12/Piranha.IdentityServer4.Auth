using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.DependencyInjection;
using Piranha;

namespace Piranha.IdentityServer4
{
    public static class PiranhaIdentityServer4Extensions
    {
        public static PiranhaServiceBuilder UseIdentityServer4Auth(this PiranhaServiceBuilder serviceBuilder, System.Action<OpenIdConnectOptions> ids4Options)
        {
            serviceBuilder.Services.AddPiranhaIdentityServer4Auth(ids4Options);

            return serviceBuilder;
        }

        public static IServiceCollection AddPiranhaIdentityServer4Auth(this IServiceCollection services, System.Action<OpenIdConnectOptions> ids4Options)
        {
            // Add the identity module
            App.Modules.Register<Module>();
            // Register the auth service
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "Cookies";
                options.DefaultChallengeScheme = "oidc";
            })
                .AddCookie("Cookies")
                .AddOpenIdConnect("oidc", ids4Options);

            services.AddSingleton<ISecurity>(new IdentityServer4Security());

            return services;
        }
    }
}
