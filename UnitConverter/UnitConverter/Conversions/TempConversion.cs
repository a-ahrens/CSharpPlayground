using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Conversions
{
    public class TempConversion
    {
        public readonly Dictionary<string, Func<double, double>> conversions = new Dictionary<string, Func<double, double>>();
        public readonly Dictionary<string, string> units = new Dictionary<string,string>();

        public TempConversion()
        {
            //load temperature unit options
            this.units.Add("F", "Fahrenheit");
            this.units.Add("C", "Celsius");
            this.units.Add("K", "Kelvin");

            //load conversion functions
            this.conversions.Add("FtoC", FahrenheitToCelsius);
            this.conversions.Add("FtoK", FahrenheitToKelvin);
            this.conversions.Add("CtoF", CelsiusToFahrenheit);
            this.conversions.Add("CtoK", CelsiusToKelvin);
            this.conversions.Add("KtoF", KelvinToFahrenheit);
            this.conversions.Add("KtoC", KelvinToCelsius);
        }

        public double convertValue(double value, string startUnit, string convertedUnit)
        {
            return this.conversions[$"{startUnit}to{convertedUnit}"](value);
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
