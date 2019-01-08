using HelloWorld.API.Controllers;
using HelloWorld.API.Data;
namespace HelloWorld.Tests
{
    public class GreetingsController_UnitTest
    {
        DataContext _dbContext;
        GreetingsController _greetingsController;
        public GreetingsController_UnitTest()
        {
           
            _greetingsController = new GreetingsController(_dbContext);
        }
    }
}