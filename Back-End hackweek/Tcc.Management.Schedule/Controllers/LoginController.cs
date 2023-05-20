using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tcc.Management.Schedule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
  
        // GET api/<Login>/
        [HttpGet]
        public string Login([FromBody] string value)
        {
            return "value";
        }

        // POST api/<CreateLogin>
        [HttpPost]
        public void CreateLogin([FromBody] string value)
        {
            
        }
    }
}
