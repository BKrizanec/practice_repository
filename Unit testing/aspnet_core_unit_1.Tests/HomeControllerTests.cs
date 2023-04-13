using aspnet_core_unit_1.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;


namespace aspnet_core_unit_1.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void CheckCountValueWithNumber500_ThrowsException ()
        {          
            // Arrange
            var mockRepository = new Mock<ILogger<HomeController>>();
            var mock = new HomeController(mockRepository.Object);
            int id = 500;

            // Act
            Action actionCheck = () => mock.CheckCountValue(id);

            // Assert
            Exception exception = Assert.Throws<Exception>(actionCheck);
            Assert.Equal("Broj je izvan raspona", exception.Message);
        }

        [Fact]
        public void CheckCountValueWithNumber2 ()
        {
            // Arrange
            var mockRepository = new Mock<ILogger<HomeController>>();
            var mock = new HomeController(mockRepository.Object);
            int id = 2;

            // Act
            var result = mock.CheckCountValue(id) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }
    }
}
