using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("Api is working");
        }
    }
}