using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarService_Client;

namespace InputValidation.Tests
{
    [TestClass]
    public class Name_Tests
    {
        [TestMethod]
        public void ValidateName_WithValidArgument()
        {
            // Arrange
            string name = "Nagy Istvan";
            bool expectedResult = true;

            // Act
            bool actualResult = WorkWindow.ValidateString(name);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateName_WithWhiteSpace_ThrowException()
        {
            string name = "    ";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateString(name);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateName_WithSpecialCharacter_ThrowException()
        {
            string name = "Zambo J!immy The King";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateString(name);

            Assert.AreEqual(expectedResult, actualResult);
        }

        public void ValidateName_WithEmptyString_ThrowException()
        {
            string name = "";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateString(name);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
