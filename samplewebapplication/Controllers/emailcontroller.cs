using Microsoft.AspNetCore.Mvc;

namespace samplewebapplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class emailcontroller : ControllerBase
    {
        [HttpPost("api/sendmail")]
        public IActionResult sendMail([FromBody] sendEmailRequest sendEmailRequest)
        {

            Console.WriteLine("email from" + sendEmailRequest.fromEmail);

        }
    }
}
