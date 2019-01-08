using System.Threading.Tasks;
using HelloWorld.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        private readonly IGreetingRespository _repo;
        public GreetingsController(IGreetingRespository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetGreetings()
        {
            var greetings = await _repo.GetGreetings();
            return Ok(greetings);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGreeting(int id)
        {
            var greeting = await _repo.GetGreeting(id);

            return Ok(greeting);
        }


    }
}