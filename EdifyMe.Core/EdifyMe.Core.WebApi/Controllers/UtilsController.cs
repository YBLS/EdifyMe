using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EdifyMe.Core.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Utils")]
    public class UtilsController : BaseApiController
    {
        [HttpGet, Route("GuidGenerate")]
        public string GuidGenerate()
        {
            return Guid.NewGuid().ToString();
        }

        [HttpGet, Route("UrlDecode")]
        public string UrlDecode(string url)
        {
            return System.Web.HttpUtility.UrlDecode(url);
        }


        [HttpGet, Route("UrlEncode")]
        public string UrlEncode(string url)
        {
            return System.Web.HttpUtility.UrlEncode(url);
        }
    }
}