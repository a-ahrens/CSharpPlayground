using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Conversions
{
    public class AreaConversion
    {
        private Dictionary<string, double> toCubicMeterConversions = new Dictionary<string, double>();
        private Dictionary<string, string> units = new Dictionary<string, string>();

        public AreaConversion()
        {
            //load Area unit options
            this.units.Add("SqKm", "Square Kilometer");
            this.units.Add("SqM", "Square Meter");
            this.units.Add("SqMi", "Square Mile");
            this.units.Add("SqY", "Square Yard");
            this.units.Add("SqFt", "Square Foot");
            this.units.Add("SqIn", "Square Inch");
            this.units.Add("Ha", "Hectare");
            this.units.Add("Ac", "Acre");


            //load conversion functions unit to square meter
            //multiply by value to get to square meters
            //then divide by number to get to desired unit
            this.toCubicMeterConversions.Add("Square Kilometer", 1000000.00);
            this.toCubicMeterConversions.Add("Square Meter", 1.0);
            this.toCubicMeterConversions.Add("Square Mile", 2590000);
            this.toCubicMeterConversions.Add("Square Yard", 0.836127);
            this.toCubicMeterConversions.Add("Square Foot", 0.092903);
            this.toCubicMeterConversions.Add("Square Inch", 0.00064516);
            this.toCubicMeterConversions.Add("Hectare", 1000.0);
            this.toCubicMeterConversions.Add("Acre", 4046.86);

        }

        public double convertValue(double value, string startUnit, string convertedUnit)
        {
            return this.toCubicMeterConversions[units[startUnit]] * value / this.toCubicMeterConversions[units[convertedUnit]];
        }

        public Dictionary<string, string> GetUnits()
        {
            return this.units;
        }


    }
}
