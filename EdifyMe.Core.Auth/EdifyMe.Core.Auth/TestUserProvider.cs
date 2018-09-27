using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdifyMe.Core.Auth
{
    public class TestUserProvider
    {
        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser>()
            {
                new TestUser(){ SubjectId = "1", Username = "kane",Password = "123" }
            };
        }
    }
}
