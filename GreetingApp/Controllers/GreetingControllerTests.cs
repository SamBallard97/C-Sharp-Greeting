using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace GreetingApp.Controllers
{
    public class GreetingControllerTests
    {
        public Mock<IItem> _mockIItem;

        public GreetingControllerTests()
        {
            _mockIItem = new Mock<IItem>();
        }
    }

    public class GreetingControllerGetTest : GreetingControllerTests
    {
        [Fact]
        public void GreetingControllerGetReturnsTest()
        {
            //arrange
            var greetingController = new GreetingController(_mockIItem.Object);
            var datedWelcomeMessage = DateTime.Now + "welcome";

            //act
            var result = greetingController.GetWelcomeMessage();

            //assert
            Assert.IsType<string>(result);
            Assert.Equal(datedWelcomeMessage, result);
        }

        [Fact]
        public void GreetingControllerGetItemsReturnsTest()
        {
            //arrange
            var greetingController = new GreetingController(_mockIItem.Object);
            var exampleItem = new Item() { Age = 4, Name = "Item1" };
            //act
            var result = greetingController.GetItems();

            //assert
            Assert.IsType<List<Item>>(result);
            Assert.Equal(exampleItem, result[0]);
        }
    }
}
