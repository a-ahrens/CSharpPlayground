using UnitConverter.Conversions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitConversionTests
{
    [TestClass]
    public class LengthConversionTests
    {
        Conversion length = new LengthConversion();

        [DataTestMethod]
        [DataRow(2.2, "M", "In", 86.614173)]
        [DataRow(2.2, "M", "F",   7.217848)]
        [DataRow(2.2, "M", "Y",   2.405949)]
        [DataRow(2.2, "M", "Mi",  0.001367)]
        [DataRow(2.2, "M", "NMi", 0.001188)]
        [DataRow(2.2, "M", "Km",  0.0022)]
        [DataRow(2.2, "M", "M",   2.2)]
        [DataRow(2.2, "M", "Nm", 2200000000)]
        [DataRow(2.2, "M", "Um", 2200000)]
        [DataRow(2.2, "M", "Mm", 2200)]
        [DataRow(2.2, "M", "Cm", 220)]
        [DataRow(2.2, "In", "M",  0.05588)]
        [DataRow(2.2, "F", "M",   0.67056)]
        [DataRow(2.2, "Y", "M",   2.01168)]
        [DataRow(2.2, "Mi", "M",  3540.5568)]
        [DataRow(2.2, "NMi", "M", 4074.4)]
        [DataRow(2.2, "Km", "M", 2200.0)]
        [DataRow(2.2, "Nm", "M", 0.0000000022)]
        [DataRow(2.2, "Um", "M", 0.0000022)]
        [DataRow(2.2, "Mm", "M", 0.0022)]
        [DataRow(2.2, "Cm", "M", 0.022)]

        public void convertLengths(double startValue, string startUnit, string convertedUnit, double expectedValue)
        {
            //ARRANGE
            //ACT
            double actualValue = length.ConvertValue(startValue, startUnit, convertedUnit);

            //ASSERT
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
