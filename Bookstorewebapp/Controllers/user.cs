using Bookstorewebapp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstorewebapp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class user : ControllerBase
    {
        [HttpGet("addUser/{username}/{password}")]
        //public IActionResult AddUser([FromRoute] string username, [FromRoute] string password, [FromQuery] string department)
        public IActionResult AddUser([FromRoute] string username, [FromRoute] string password)
        {
            //Console.WriteLine($"Username Is {username} password is {password} from {department}");
            Console.WriteLine($"Username Is {username} password is {password}");

            return Ok();
            
        }

        [HttpPost("AddUsers")]

        public IActionResult AddUsers([FromBody] UserDetails userDetails)
        {
            Console.WriteLine($"Username Is {userDetails.Username} password is {userDetails.Password}");
            return Ok();
        }
    }
}
