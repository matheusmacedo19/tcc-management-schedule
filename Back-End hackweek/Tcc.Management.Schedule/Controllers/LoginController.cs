using Microsoft.AspNetCore.Mvc;
using Tcc.Management.Schedule.Models;
using Tcc.Management.Schedule.Data;
using Tcc.Management.Schedule.Services;
using Tcc.Management.Schedule.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tcc.Management.Schedule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
  
        // GET api/<Login>/
        [HttpGet]
        public IActionResult Login([FromBody] User user)
        {
            try
            {
                if (!_loginService.ValidateLogin(user))
                {
                    // Usuário não encontrado ou credenciais inválidas
                    return BadRequest("Usuário ou senha inválidos.");
                }

                return Ok(user);

            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        // POST api/<CreateUser>
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            try
            {
                if (_loginService.CreateUser(user))
                {
                    return Ok(user);
                }else
                    return BadRequest();

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
