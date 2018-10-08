using DLLweightConversions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DLLweightConversionsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Class1 c1 = new Class1();

        [TestMethod]
        public void ConvertToGramsTestMethod()
        {
            double a = c1.ConverttoGrams(2);

            Assert.AreEqual(56.699, a, 0.001);

        }

        [TestMethod]
        public void ConvertToOzTestMethod()
        {

            double a = c1.ConvertToOunces(1);

            Assert.AreEqual(0.035, a, 0.001);
        }
    }
}

