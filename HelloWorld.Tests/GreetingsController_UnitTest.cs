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

            _greetingRepoMock.Setup(repo => repo.GetGreetings()).Returns(Task.FromResult(mockGreentingList));

            var result = await _controller.GetGreetings();

            Assert.Equal(mockGreentingList, result);


        }
    }
}