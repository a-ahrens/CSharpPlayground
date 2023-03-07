using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Conversions
{
    public class AreaConversion : Conversion
    {
        private Dictionary<string, double> toCubicMeterConversions = new Dictionary<string, double>();

        public AreaConversion()
        {
            //load Area unit options
            units.Add("SqKm", "Square Kilometer");
            units.Add("SqM", "Square Meter");
            units.Add("SqMi", "Square Mile");
            units.Add("SqY", "Square Yard");
            units.Add("SqF", "Square Foot");
            units.Add("SqIn", "Square Inch");
            units.Add("Ha", "Hectare");
            units.Add("Ac", "Acre");


            //load conversion functions unit to square meter
            //multiply by value to get to square meters
            //then divide by number to get to desired unit
            toCubicMeterConversions.Add("Square Kilometer", 1000000.00);
            toCubicMeterConversions.Add("Square Meter", 1.0);
            toCubicMeterConversions.Add("Square Mile", 2589988.1103);
            toCubicMeterConversions.Add("Square Yard", 0.83612736);
            toCubicMeterConversions.Add("Square Foot", 0.09290304);
            toCubicMeterConversions.Add("Square Inch", 0.00064516);
            toCubicMeterConversions.Add("Hectare", 1000.0);
            toCubicMeterConversions.Add("Acre", 4046.8564224);

        }

        public override double ConvertValue(double value, string startUnit, string convertedUnit)
        {
            if (startUnit == convertedUnit)
            {
                return value;
            }

            return Math.Round(this.toCubicMeterConversions[units[startUnit]] * value / this.toCubicMeterConversions[units[convertedUnit]], 6);
        }

    }
}
