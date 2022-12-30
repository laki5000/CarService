using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarService_Client;

namespace InputValidation.Tests
{
    [TestClass]
    public class Severity_Tests
    {
        [TestMethod]
        public void ValidateSeverity_WithValidArgument()
        {
            string year = "3";
            bool expectedResult = true;

            bool actualResult = WorkWindow.ValidateSeverity(year);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateSeverity_WithText_ThrowsExcepion()
        {
            string severity = "Deez Nuts";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateSeverity(severity);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateSeverity_WithHigherThan10Number_ThrowsExcepion()
        {
            string severity = "13";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateSeverity(severity);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateSeverity_WithLowerThan1Number_ThrowsExcepion()
        {
            string severity = "0";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateSeverity(severity);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateSeverity_WithEmptyString_ThrowsExcepion()
        {
            string severity = "";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateSeverity(severity);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
