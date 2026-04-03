using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAY_2_PRACTICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHello()
        {
            return Ok("Hello World");
        }
    }
}
