using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Conversions
{
    public abstract class Conversion
    {
        protected Dictionary<string, string> units;
        public Conversion() 
        {
            units = new Dictionary<string, string>();
        }

        public Dictionary<string, string> GetUnits()
        {
            return this.units;
        }

        public virtual double ConvertValue(double value, string startUnit, string convertedUnit)
        {
            return 0.0;
        }
    }
}
