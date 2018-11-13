using Xunit;
using WHOfansite.Models;
using WHOfansite.Repositories;
using WHOfansite.Controllers;
using System;

namespace WHOFansiteTests
{
    public class StoryControllerTests
    {
        


        [Fact]
        public void AddStoryTest()
        {
            //Arrage
            var repo = new FakeStoryRepository();
            var storyController = new HomeController(repo);
            //Act
            //Assert
        }

        [Fact]
        public void AddCommentTest()
        {
            //Arrage
            //Act
            //Assert
        }

        
    }
}
