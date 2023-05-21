using Microsoft.AspNetCore.Mvc;
using Tcc.Management.Schedule.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tcc.Management.Schedule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingRegisterController : ControllerBase
    {
        private readonly AppDataContext _contex;
        public MeetingRegisterController(AppDataContext context)
        {

        }
        // GET: api/<MeetingRegisterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MeetingRegisterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MeetingRegisterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MeetingRegisterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MeetingRegisterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
