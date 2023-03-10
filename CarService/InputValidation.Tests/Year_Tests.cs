using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarService_Client;

namespace InputValidation.Tests
{
    [TestClass]
    public class Year_Tests
    {
        [TestMethod]
        public void ValidateYear_WithValidArgument()
        {
            string year = "2012";
            bool expectedResult = true;

            bool actualResult = WorkWindow.ValidateNumber(year);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateYear_WithLetterInText_ThrowsExcepion()
        {
            string year = "2003A";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateNumber(year);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
