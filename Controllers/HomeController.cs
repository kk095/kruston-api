using Microsoft.AspNetCore.Mvc;

namespace kruston_api.Controllers
{
    [ApiController]
    [Route("api/")]
    public class HomeController : ControllerBase
    {
        [HttpGet("getitem")]
        public async Task<IActionResult> GetItem()
        {
            dynamic x = 78;
            return Ok(x);
        }
    }
}
