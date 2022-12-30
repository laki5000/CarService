using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarService_Client;

namespace InputValidation.Tests
{
    [TestClass]
    public class Description_Tests
    {
        [TestMethod]
        public void ValidateDescription_WithValidArgument()
        {
            string desc = "Engine spark plug change";
            bool expectedResult = true;

            bool actualResult = WorkWindow.ValidateShortDescription(desc);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateDescription_WithEmptyString_ThrowsExcepion()
        {
            string desc = "";
            bool expectedResult = false;

            bool actualResult = WorkWindow.ValidateShortDescription(desc);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
