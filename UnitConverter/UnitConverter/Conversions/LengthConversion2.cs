using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Conversions
{
    public class LengthConversion
    {
        private Dictionary<string, double> toMeterConversions = new Dictionary<string, double>();
        private Dictionary<string, string> units = new Dictionary<string, string>();

        public LengthConversion()
        {
            //load length unit options
            this.units.Add("In", "Inch");
            this.units.Add("F", "Foot");
            this.units.Add("Y", "Yard");
            this.units.Add("Mi", "Mile");
            this.units.Add("NMi", "Nautical Mile");
            this.units.Add("Nm", "Nanometer");
            this.units.Add("Um", "Micrometer");
            this.units.Add("Mm", "Millimeter");
            this.units.Add("Cm", "Centimeter");
            this.units.Add("M", "Meter");
            this.units.Add("Km", "Kilometer");

            //load conversion functions unit to meter
                //multiply by value to get to meters
                    //then divide by number to get to desired unit
            this.toMeterConversions.Add("Inch", 0.0254);
            this.toMeterConversions.Add("Foot", 0.3048);
            this.toMeterConversions.Add("Yard", 0.9144);
            this.toMeterConversions.Add("Mile", 1609.34);
            this.toMeterConversions.Add("Nautical Mile", 1852.0);
            this.toMeterConversions.Add("Nanometer",  0.000000001);
            this.toMeterConversions.Add("Micrometer", 0.000001);
            this.toMeterConversions.Add("Millimeter", 0.001);
            this.toMeterConversions.Add("Centimeter", 0.01);
            this.toMeterConversions.Add("Meter",      1.0);
            this.toMeterConversions.Add("Kilometer" , 1000.0);

        }

        public double convertValue(double value, string startUnit, string convertedUnit)
        {
            return this.toMeterConversions[units[startUnit]] * value / this.toMeterConversions[units[convertedUnit]];
        }

        public Dictionary<string, string> GetUnits()
        {
            return this.units;
        }

        
    }
}
