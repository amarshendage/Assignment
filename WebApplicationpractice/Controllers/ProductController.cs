using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationpractice.Model;

namespace WebApplicationpractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost("api/Product")]
        public IActionResult PostProduct([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Product is null");
            }
            return CreatedAtAction(nameof(PostProduct), new { id = product.Id }, product);
        }



    }
}
