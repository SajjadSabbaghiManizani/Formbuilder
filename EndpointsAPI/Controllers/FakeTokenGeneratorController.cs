using Endpoints_API.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Endpoints_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakeTokenGeneratorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetToken()
        {
            var fakeToken = FakeTokenGenerator.GenerateFakeToken();
            return Ok(fakeToken);
        }
      
    }

}
