using UnitConverter.Conversions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitConversionTests
{
    [TestClass]
    public class TempConversionTests
    {
        TempConversion testConvert = new TempConversion();

        [DataTestMethod]
        [DataRow(0.0, -17.7778)]
        [DataRow(32.0, 0.0)]
        [DataRow(86.0, 30.0)]
        public void FahrenheitToCelsius(double input, double expected)
        {
            //arrange
            double initialValue = input;

            //act
            double actualValue = testConvert.convertValue(initialValue, "F", "C");

            //assert
            Assert.AreEqual(expected, actualValue);
        }
    }
}