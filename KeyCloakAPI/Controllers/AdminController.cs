using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KeycloakWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Administrator")]
    public class AdminController : ControllerBase
    {
        public AdminController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Authorized!");
        }
    }
}
