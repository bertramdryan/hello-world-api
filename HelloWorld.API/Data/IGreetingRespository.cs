using System.Collections.Generic;
using System.Threading.Tasks;
using HelloWorld.API.Models;

namespace HelloWorld.API.Data
{
    public interface IGreetingRespository
    {
         Task<IEnumerable<Greeting>> GetGreetings();
         Task<Greeting> GetGreeting(int id);
    }
}