using UnitConverter.Conversions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitConversionTests
{
    [TestClass]
    public class TempConversionTests
    {
        Conversion temp = new TempConversion();

        [DataTestMethod]
        [DataRow(0.0, -17.777778)]
        [DataRow(32.0, 0.0)]
        [DataRow(212.0, 100.00)]
        [DataRow(52.6253412, 11.458523)]
        public void FahrenheitToCelsius(double input, double expected)
        {
            //arrange
            double initialValue = input;

            //act
            double actualValue = temp.ConvertValue(initialValue, "F", "C");

            //assert
            Assert.AreEqual(expected, actualValue);
        }

        [DataTestMethod]
        [DataRow(0.0, 255.372222)]
        [DataRow(32.0, 273.15)]
        [DataRow(212.0, 373.15)]
        [DataRow(52.6253412, 284.608523)]
        [DataRow(-500.0, -22.405556)]
        public void FahrenheitToKelvin(double input, double expected)
        {
            //arrange
            double initialValue = input;

            //act
            double actualValue = temp.ConvertValue(initialValue, "F", "K");

            //assert
            Assert.AreEqual(expected, actualValue);
        }

        [DataTestMethod]
        [DataRow(0.0, -459.67)]
        [DataRow(373.15, 212.0)]
        [DataRow(273.15, 32.0)]
        [DataRow(-52.0, -553.27)]
        public void KelvinToFahrenheit(double input, double expected)
        {
            //arrange
            double initialValue = input;

            //act
            double actualValue = temp.ConvertValue(initialValue, "K", "F");

            //assert
            Assert.AreEqual(expected, actualValue);
        }

        [DataTestMethod]
        [DataRow(0.0, 32.0)]
        [DataRow(100.0, 212.0)]
        [DataRow(-32.0, -25.6)]
        [DataRow(52.6253412, 126.725614)]
        public void CelsiusToFahrenheit(double input, double expected)
        {
            double initialValue = input;
            double actualValue = temp.ConvertValue(initialValue, "C", "F");
            Assert.AreEqual(expected, actualValue);
        }

        [DataTestMethod]
        [DataRow(0.0, 273.15)]
        [DataRow(1.0, 274.15)]
        [DataRow(100.0, 373.15)]
        [DataRow(-273.15, 0.0)]
        public void CelsiusToKelvin(double input, double expected)
        {
            double initialValue = input;
            double actualValue = temp.ConvertValue(initialValue, "C", "K");
            Assert.AreEqual(expected, actualValue);
        }

        [DataTestMethod]
        [DataRow(0.0, -273.15)]
        [DataRow(273.15, 0.0)]
        [DataRow(373.15, 100.0)]
        [DataRow(-200.0, -473.15)]
        public void KelvinToCelcius(double input, double expected)
        {
            double initialValue = input;
            double actualValue = temp.ConvertValue(initialValue, "K", "C");
            Assert.AreEqual(expected, actualValue);
        }
        [DataTestMethod]
        [DataRow(100, "F","F", 100)]
        [DataRow(100, "C", "C", 100)]
        [DataRow(100, "K", "K", 100)]
        public void MatchingUnits(double input, string startUnits, string convertUnits, double expectedValue)
        {
            double initialValue = input;
            double actualValue = temp.ConvertValue(initialValue, startUnits, convertUnits);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}