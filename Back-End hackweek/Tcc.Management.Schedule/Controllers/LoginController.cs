using Microsoft.AspNetCore.Mvc;
using Tcc.Management.Schedule.Models;
using Tcc.Management.Schedule.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tcc.Management.Schedule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
  
        public readonly AppDataContext _context;

        public LoginController(AppDataContext context)
        {
            _context = context;
        }
  
        // GET api/<Login>/
        [HttpGet]
        public IActionResult Login([FromBody] Student student)
        {
            var foundUser = _context.Students.FirstOrDefault(student);
    
            if (foundUser == null)
            {
                // Usuário não encontrado ou credenciais inválidas
                return BadRequest("Usuário ou senha inválidos.");
            }

            return Ok(student);
        }

        // POST api/<CreateLogin>
        [HttpPost]
        public void CreateLogin([FromBody] string value)
        {
            
        }
    }
}
