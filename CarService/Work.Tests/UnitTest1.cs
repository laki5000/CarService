using CarService_Common.Models;
using CarService_Client;

namespace Work.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateString_WithValidArugment()
        {
            // Arrange
            string name = "Nagy Istvan";
            bool expectedResult = true;
            // Act
            var actualResult = ValidateString();
            // Assert
        }
    }
}