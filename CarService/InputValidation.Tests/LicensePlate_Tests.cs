using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarService_Client;

namespace InputValidation.Tests
{
    [TestClass]
    public class LicensePlate_Tests
    {
        [TestMethod]
        public void ValidateLicensePlate_WithValidArgument()
        {
            string licensePlate = "LHY-903";
            bool expectedResult = true;

            bool actualResult = WorkWindow.ValidateLicensePlate(licensePlate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateLicensePlate_WithOneMoreLetter_ThrowsException()
        {
            string licensePlate = "IFRK-364";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateLicensePlate(licensePlate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateLicensePlate_WithOnlyLetters_ThrowsException()
        {
            string licensePlate = "LOL";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateLicensePlate(licensePlate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateLicensePlate_WithOneLessNumber_ThrowsException()
        {
            string licensePlate = "AWR-24";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateLicensePlate(licensePlate);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateLicensePlate_WithWhiteSpace_ThrowsException()
        {
            string licensePlate = "   ";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateLicensePlate(licensePlate);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
