using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Conversions
{
    public class VolumeConversion : Conversion
    {
        private Dictionary<string, double> toLiterConversions = new Dictionary<string, double>();
        
        public VolumeConversion()
        {
            //load volume unit options
            units.Add("USGal", "US Gallon");
            units.Add("USQt", "US Quart");
            units.Add("USPt", "US Pint");
            units.Add("USC", "US Cup");
            units.Add("USFlOz", "US Fluid Ounce");
            units.Add("USTbsp", "US Tablespoon");
            units.Add("USTsp", "US Teaspoon");
            units.Add("CuM", "Cubic Meter");
            units.Add("CuF", "Cubic Foot");
            units.Add("CuIn", "Cubic Inch");
            units.Add("L", "Liter");
            units.Add("Ml", "Milliliter");
            units.Add("IGal", "Imperial Gallon");
            units.Add("IQt", "Imperial Quart");
            units.Add("IPt", "Imperial Pint");
            units.Add("IC", "Imperial Cup");
            units.Add("IFlOz", "Imperial Fluid Ounce");
            units.Add("ITbsp", "Imperial Tablespoon");
            units.Add("ITsp", "Imperial Teaspoon");

            //load conversion functions unit to liter
            //multiply by value to get to liters
            //then divide by number to get to desired unit
            toLiterConversions.Add("US Gallon", 3.785411784);
            toLiterConversions.Add("US Quart", 0.946352946);
            toLiterConversions.Add("US Pint", 0.473176473);
            toLiterConversions.Add("US Cup", 0.2365882365);
            toLiterConversions.Add("US Fluid Ounce", 0.0295735296);
            toLiterConversions.Add("US Tablespoon", 0.0147867648);
            toLiterConversions.Add("US Teaspoon", 0.0049289216);
            toLiterConversions.Add("Cubic Meter", 1000.00);
            toLiterConversions.Add("Cubic Foot", 28.316846592);
            toLiterConversions.Add("Cubic Inch", 0.016387064);
            toLiterConversions.Add("Liter", 1.0);
            toLiterConversions.Add("Milliliter", 0.001);
            toLiterConversions.Add("Imperial Gallon", 4.54609);
            toLiterConversions.Add("Imperial Quart", 1.1365225);
            toLiterConversions.Add("Imperial Pint", 0.56826125);
            toLiterConversions.Add("Imperial Cup", 0.284130625);
            toLiterConversions.Add("Imperial Fluid Ounce", 0.0284130625);
            toLiterConversions.Add("Imperial Tablespoon", 0.0177581641);
            toLiterConversions.Add("Imperial Teaspoon", 0.005919388);

        }

        public override double ConvertValue(double value, string startUnit, string convertedUnit)
        {
            if (startUnit == convertedUnit)
            {
                return value;
            }
            return Math.Round(this.toLiterConversions[units[startUnit]] * value / this.toLiterConversions[units[convertedUnit]], 6);
        }
    
    }
}
