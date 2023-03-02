using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Conversions
{
    public class VolumeConversion
    {
        private Dictionary<string, double> toLiterConversions = new Dictionary<string, double>();
        private Dictionary<string, string> units = new Dictionary<string, string>();

        public VolumeConversion()
        {
            //load volume unit options
            this.units.Add("USGal", "US Gallon");
            this.units.Add("USQt", "US Quart");
            this.units.Add("USPt", "US Pint");
            this.units.Add("USC", "US Cup");
            this.units.Add("USFlOz", "US Fluid Ounce");
            this.units.Add("USTbsp", "US Tablespoon");
            this.units.Add("USTsp", "US Teaspoon");
            this.units.Add("CuM", "Cubic Meter");
            this.units.Add("CuF", "Cubic Foot");
            this.units.Add("CuI", "Cubic Inch");
            this.units.Add("L", "Liter");
            this.units.Add("Ml", "Milliliter");
            this.units.Add("IGal", "Imperial Gallon");
            this.units.Add("IQt", "Imperial Quart");
            this.units.Add("IPt", "Imperial Pint");
            this.units.Add("IC", "Imperial Cup");
            this.units.Add("IFlOz", "Imperial Fluid Ounce");
            this.units.Add("ITbsp", "Imperial Tablespoon");
            this.units.Add("ITsp", "Imperial Teaspoon");

            //load conversion functions unit to liter
            //multiply by value to get to liters
            //then divide by number to get to desired unit
            this.toLiterConversions.Add("US Gallon", 3.78541);
            this.toLiterConversions.Add("US Quart", 0.946353);
            this.toLiterConversions.Add("US Pint", 0.473176);
            this.toLiterConversions.Add("US Cup", 0.24);
            this.toLiterConversions.Add("US Fluid Ounce", 0.0295735);
            this.toLiterConversions.Add("US Tablespoon", 0.0147868);
            this.toLiterConversions.Add("US Teaspoon", 0.00492892);
            this.toLiterConversions.Add("Cubic Meter", 1000.00);
            this.toLiterConversions.Add("Cubic Foot", 28.3168);
            this.toLiterConversions.Add("Cubic Inch", 0.0163871);
            this.toLiterConversions.Add("Liter", 1.0);
            this.toLiterConversions.Add("Milliliter", 0.001);
            this.toLiterConversions.Add("Imperial Gallon", 4.54609);
            this.toLiterConversions.Add("Imperial Quart", 1.13652);
            this.toLiterConversions.Add("Imperial Pint", 0.568261);
            this.toLiterConversions.Add("Imperial Cup", 0.284131);
            this.toLiterConversions.Add("Imperial Fluid Ounce", 0.0284131);
            this.toLiterConversions.Add("Imperial Tablespoon", 0.0177582);
            this.toLiterConversions.Add("Imperial Teaspoon", 0.00591939);


        }

        public double convertValue(double value, string startUnit, string convertedUnit)
        {
            if (startUnit == convertedUnit)
            {
                return value;
            }
            return this.toLiterConversions[units[startUnit]] * value / this.toLiterConversions[units[convertedUnit]];
        }

        public Dictionary<string, string> GetUnits()
        {
            return this.units;
        }
    
    }
}
