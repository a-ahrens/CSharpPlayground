using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Conversions
{
    public class LengthConversion : Conversion
    {
        private Dictionary<string, double> toMeterConversions = new Dictionary<string, double>();
       
        public LengthConversion()
        {
            //load length unit options
            units.Add("In", "Inch");
            units.Add("F", "Foot");
            units.Add("Y", "Yard");
            units.Add("Mi", "Mile");
            units.Add("NMi", "Nautical Mile");
            units.Add("Nm", "Nanometer");
            units.Add("Um", "Micrometer");
            units.Add("Mm", "Millimeter");
            units.Add("Cm", "Centimeter");
            units.Add("M", "Meter");
            units.Add("Km", "Kilometer");

            //load conversion functions unit to meter
            //multiply by value to get to meters
            //then divide by number to get to desired unit
            toMeterConversions.Add("Inch", 0.0254);
            toMeterConversions.Add("Foot", 0.3048);
            toMeterConversions.Add("Yard", 0.9144);
            toMeterConversions.Add("Mile", 1609.34);
            toMeterConversions.Add("Nautical Mile", 1852.0);
            toMeterConversions.Add("Nanometer",  0.000000001);
            toMeterConversions.Add("Micrometer", 0.000001);
            toMeterConversions.Add("Millimeter", 0.001);
            toMeterConversions.Add("Centimeter", 0.01);
            toMeterConversions.Add("Meter",      1.0);
            toMeterConversions.Add("Kilometer" , 1000.0);

        }

        public override double ConvertValue(double value, string startUnit, string convertedUnit)
        {
            if (startUnit == convertedUnit)
            {
                return value;
            }

            return this.toMeterConversions[units[startUnit]] * value / this.toMeterConversions[units[convertedUnit]];
        }


        
    }
}
