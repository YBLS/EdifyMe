using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdifyMe.Core.Auth
{
    public class ClientValidator : IClientStore
    {
        public Task<Client> FindClientByIdAsync(string clientId)
        {
            return Task.FromResult<Client>(new Client()
            {
                ClientId = "pclient",

                AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                AllowedScopes = { "edify.me.core", IdentityServerConstants.StandardScopes.OpenId, IdentityServerConstants.StandardScopes.Profile },
                AllowOfflineAccess = true,
            });
        }
    }
}
