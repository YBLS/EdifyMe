using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdifyMe.Core.Auth
{
    public class ApiResourceProvider
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>() {
                new ApiResource("edify.me.core", "edify.me.core"),
                new ApiResource(IdentityServerConstants.StandardScopes.OpenId, IdentityServerConstants.StandardScopes.OpenId),
                new ApiResource( IdentityServerConstants.StandardScopes.Profile, IdentityServerConstants.StandardScopes.Profile)
            };
        }
    }
}
