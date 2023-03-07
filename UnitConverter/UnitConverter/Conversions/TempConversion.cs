using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Conversions
{
    public class TempConversion : Conversion
    {
        private Dictionary<string, Func<double, double>> conversions = new Dictionary<string, Func<double, double>>();

        public TempConversion()
        {
            //load temperature unit options
            units.Add("F", "Fahrenheit");
            units.Add("C", "Celsius");
            units.Add("K", "Kelvin");

            //load conversion functions
            conversions.Add("FtoC", FahrenheitToCelsius);
            conversions.Add("FtoK", FahrenheitToKelvin);
            conversions.Add("CtoF", CelsiusToFahrenheit);
            conversions.Add("CtoK", CelsiusToKelvin);
            conversions.Add("KtoF", KelvinToFahrenheit);
            conversions.Add("KtoC", KelvinToCelsius);
        }

        public override double ConvertValue(double value, string startUnit, string convertedUnit)
        {
            if(startUnit == convertedUnit)
            {
                return value;
            }

           return Math.Round(this.conversions[$"{startUnit}to{convertedUnit}"](value), 6);
        }

        private double FahrenheitToCelsius(double temperature)
        {
            return ((temperature - 32) * 5.0/9.0);
        }

        private double FahrenheitToKelvin(double temperature)
        {
            return ((temperature - 32) * 5.0 / 9.0 + 273.15);
        }

        private double CelsiusToFahrenheit(double temperature)
        {
            return ((temperature * 9.0 / 5.0) + 32);
        }

        private double CelsiusToKelvin(double temperature)
        {
            return temperature + 273.15;
        }

        private double KelvinToFahrenheit(double temperature)
        {
            return ((temperature - 273.15) * 9.0 / 5.0 + 32);
        }

        private double KelvinToCelsius(double temperature)
        {
            return temperature - 273.15;
        }
    }
}
