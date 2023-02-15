using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Conversions
{
    internal class LengthConversion
    {
        public readonly Dictionary<string, double> conversions = new Dictionary<string, double>();
        public readonly Dictionary<string, string> units = new Dictionary<string, string>();

        public LengthConversion()
        {
            //load length unit options
            this.units.Add("M", "Meters");
            this.units.Add("IN", "Inches");
            this.units.Add("F", "Feet");
            this.units.Add("Mi", "Miles");

            /*Standardize every conversion to go to a single unit, then convert from that unit to the 
             desired unit. Example: Ft => M, then M => In That way we only need conversion factors for 
             from and to Meters*/

            /*            //load conversion functions
                        this.conversions.Add("FtoC", FahrenheitToCelsius);
                        this.conversions.Add("FtoK", FahrenheitToKelvin);
                        this.conversions.Add("CtoF", CelsiusToFahrenheit);
                        this.conversions.Add("CtoK", CelsiusToKelvin);
                        this.conversions.Add("KtoF", KelvinToFahrenheit);
                        this.conversions.Add("KtoC", KelvinToCelsius);
                    }*/
        }
    }
}
