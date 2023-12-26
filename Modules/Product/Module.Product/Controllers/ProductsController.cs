using Microsoft.AspNetCore.Mvc;

namespace Module.Product.Controllers
{
    [ApiController]
    [Route("/api/product/[controller]")]
    internal class ProductsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
