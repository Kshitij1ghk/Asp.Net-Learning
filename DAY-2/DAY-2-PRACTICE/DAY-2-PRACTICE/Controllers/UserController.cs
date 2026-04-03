using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DAY_2_PRACTICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]

        public IActionResult CreateUser()
        {
            var User = new //quick way to define an object without defining a full class 
            //used for returning dummy data
            {
                Name = "Kshitij",
                Email = "kshitj@gmail.com",
                Age = 20
            };

            return Created("/api/user", User);//url-where the new resource lives
            //user -the actual data to return

        }
    }
}
