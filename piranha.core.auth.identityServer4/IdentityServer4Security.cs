using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace Piranha.IdentityServer4
{
    public class IdentityServer4Security : ISecurity
    {
        public IdentityServer4Security()
        {
        }

        public Task<bool> SignIn(object context, string username, string password)
        {
            return Task.FromResult(true);
        }

        public async Task SignOut(object context)
        {
            if (context is HttpContext)
            {
                await ((HttpContext)context).SignOutAsync("Cookies");
                await ((HttpContext)context).SignOutAsync("oidc");
            }
            throw new ArgumentException("IdentityServer4Security only works with a HttpContext");
        }
    }
}
