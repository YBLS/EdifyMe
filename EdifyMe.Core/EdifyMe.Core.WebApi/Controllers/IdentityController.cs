using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EdifyMe.Core.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Identity")]
    [Authorize]
    public class IdentityController : BaseApiController
    {
        [HttpGet,Route("gethello")]
        public string Get()
        {
            return "Hello Identity";
        }
    }
}