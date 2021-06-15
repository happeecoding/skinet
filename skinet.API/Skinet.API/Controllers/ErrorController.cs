using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Skinet.API.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skinet.API.Controllers
{
    [Route("errors/{code}")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : BaseApiController
    {
        //[HttpGet]
        public IActionResult Error( int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
