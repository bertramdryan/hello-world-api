using System.Collections.Generic;
using HelloWorld.API.Controllers;
using HelloWorld.API.Data;
using HelloWorld.API.Models;
using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;

namespace HelloWorld.Tests
{
    public class GreetingsController_UnitTest
    {      
        private Mock<IGreetingRespository> _greetingRepoMock;
        private GreetingsController _controller;
        public GreetingsController_UnitTest()
        {
            _greetingRepoMock = new Mock<IGreetingRespository>();
            _controller = new GreetingsController(_greetingRepoMock.Object);
        }

        [Fact]
        public async void Greetings_should_return_list()
        {
            var mockGreentingList = new List<Greeting> {
                new Greeting {HelloWorld = "Hello, World!", Langauge = "English"},
                new Greeting {HelloWorld = "Γειά σου Κόσμε!", Langauge = "Greek"}
            };

            _greetingRepoMock.Setup(repo => repo.GetGreetings()).ReturnsAsync((mockGreentingList));

            var result = await _controller.GetGreetings();

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<List<Greeting>>(okResult.Value);

            Assert.Equal(mockGreentingList, returnValue);
        }

        [Fact]
        public async void Greeting_should_return_object()
        {
            var mockGreetingObject = new Greeting {HelloWorld = "Hello, World!", Langauge="English"};

            _greetingRepoMock.Setup(repo => repo.GetGreeting(1)).ReturnsAsync(mockGreetingObject);

            var result = await _controller.GetGreeting(1);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<Greeting>(okResult.Value);

            Assert.Equal(mockGreetingObject, returnValue);
        }
    }
}