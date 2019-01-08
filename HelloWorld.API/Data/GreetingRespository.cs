using System.Collections.Generic;
using System.Threading.Tasks;
using HelloWorld.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.API.Data
{
    public class GreetingRespository : IGreetingRespository
    {
        private readonly DataContext _context;
        public GreetingRespository(DataContext context)
        {
            _context = context;

        }

        public async Task<Greeting> GetGreeting(int id)
        {
            var greeting = await _context.Greetings.FirstOrDefaultAsync(g => g.Id == id);

            return greeting;
        }

        public async Task<List<Greeting>> GetGreetings()
        {
            var greetings = await _context.Greetings.ToListAsync();

            return greetings;
        }
    }
}