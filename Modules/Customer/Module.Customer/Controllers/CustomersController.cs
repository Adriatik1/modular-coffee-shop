using Microsoft.AspNetCore.Mvc;

namespace Module.Customer.Controllers
{
    [ApiController]
    [Route("/api/product/[controller]")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
