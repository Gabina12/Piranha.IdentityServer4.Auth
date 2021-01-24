using System;
using Piranha;

namespace piranha.core.auth.identityServer4
{
    public class SimpleSecurity : ISecurity
    {
        public SimpleSecurity()
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
            throw new ArgumentException("SimpleSecurity only works with a HttpContext");
        }
    }
}
