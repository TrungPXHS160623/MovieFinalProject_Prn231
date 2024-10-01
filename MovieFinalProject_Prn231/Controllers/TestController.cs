using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace MovieFinalProject_Prn231.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public TestController()
        {
            
           
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("HelloWorld!!!");
        }
    }
}
