using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarService_Server.Repositories;
using CarService_Common.Models;

namespace Estimation_Tests
{
    [TestClass]
    public class ETA_Tests
    {
        [TestMethod]
        public void ETA_With_Engine_Year2016_Severity3_ShouldEqual_3_2()
        {
            Data data = new Data();
            data.WorkCategory = "Engine";
            data.ManufactureYear = 2016;
            data.Seriousness = 3;
            double expectedETA = 3.2;

            double actualETA = DataRepository.CalculateETA(data);

            Assert.AreEqual(expectedETA, actualETA);

        }

        [TestMethod]
        public void ETA_With_Brake_Year1997_Severity7_ShouldEqual_4_8()
        {
            Data data = new Data();
            data.WorkCategory = "Brake";
            data.ManufactureYear = 1997;
            data.Seriousness = 7;
            double expectedETA = 4.8;

            double actualETA = DataRepository.CalculateETA(data);

            Assert.AreEqual(expectedETA, actualETA);
        }

        [TestMethod]
        public void ETA_With_Chassis_Year2005_Severity10_ShouldEqual_4_5()
        {
            Data data = new Data();
            data.WorkCategory = "Chassis";
            data.ManufactureYear = 2005;
            data.Seriousness = 10;
            double expectedETA = 4.5;

            double actualETA = DataRepository.CalculateETA(data);

            Assert.AreEqual(expectedETA, actualETA);
        }

        [TestMethod]
        public void ETA_With_Suspension_Year2012_Severity5_ShouldEqual_5_4()
        {
            Data data = new Data();
            data.WorkCategory = "Suspension";
            data.ManufactureYear = 2012;
            data.Seriousness = 5;
            double expectedETA = 5.4;

            double actualETA = DataRepository.CalculateETA(data);

            Assert.AreEqual(expectedETA, actualETA);
        }

        [TestMethod]
        public void ETA_With_Chassis_Year2020_Severity1_ShouldEqual_0_3()
        {
            Data data = new Data();
            data.WorkCategory = "Chassis";
            data.ManufactureYear = 2020;
            data.Seriousness = 1;
            double expectedETA = 0.3;

            double actualETA = DataRepository.CalculateETA(data);

            Assert.AreEqual(expectedETA, actualETA);
        }
    }
}
