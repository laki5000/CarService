using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarService_Client;

namespace InputValidation.Tests
{
    [TestClass]
    public class CarMake_Tests
    {
        [TestMethod]
        public void ValidateCarMake_WithValidArgument()
        {
            // Arrange
            string name = "BMW E46 330I";
            bool expectedResult = true;

            // Act
            bool actualResult = WorkWindow.ValidateString(name);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateCarMake_WithWhiteSpace_ThrowException()
        {
            string name = "  ";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateString(name);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateCarMake_WithSpecialCharacter_ThrowException()
        {
            string name = "Mercedes #E220";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateString(name);

            Assert.AreEqual(expectedResult, actualResult);
        }

        public void ValidateCarMake_WithEmptyString_ThrowException()
        {
            string name = "";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateString(name);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
