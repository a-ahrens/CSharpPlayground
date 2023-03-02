using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Conversions;

namespace UnitConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            converter.RunConverter();

        }
    }
}
