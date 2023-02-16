using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Conversions;

namespace UnitConverter
{
    internal class Converter
    {

        TempConversion tempConversion = new TempConversion();
        LengthConversion lengthConversion = new LengthConversion();

        private string startingUnit;
        private double startingValue;
        private string convertedUnit;
        private double convertedValue;

        private string[] conversionOptions = new string[] { "Temperature", "Length", "Volume", "Area" };


        public void RunConverter()
        {
            //Print the available conversion types and have user pick one
            Console.WriteLine("Please choose a conversion option: ");
            for (int i = 0; i < conversionOptions.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {conversionOptions[i]}");
            }

            int option = int.Parse(Console.ReadLine());
            string conversionType = conversionOptions[option-1];

            Console.WriteLine($"Option #{option} it is! Let's convert some {conversionType}s!");
            Console.WriteLine();

            //pull conversion options based on conversion choice
            if(conversionType == "Temperature")
            {
                Console.WriteLine("Temperature Conversion Options:");
                UserInput(tempConversion.GetUnits());
                convertedValue = tempConversion.convertValue(startingValue, startingUnit, convertedUnit);
            }
            else if(conversionType == "Length")
            {
                Console.WriteLine("Length Conversion Options:");
                UserInput(lengthConversion.GetUnits());
                convertedValue = lengthConversion.convertValue(startingValue, lengthConversion.units[startingUnit], lengthConversion.units[convertedUnit]);
            }

            Console.WriteLine($"{startingValue}{startingUnit} ==> {convertedValue}{convertedUnit}");

        }

        private void UserInput(Dictionary<string,string> units)
        {
            foreach (KeyValuePair<string, string> unitPair in units)
            {
                Console.WriteLine($"{unitPair.Key} for {unitPair.Value}");
            }

            Console.WriteLine("Please select a unit to convert from: ");
            startingUnit = Console.ReadLine();

            Console.WriteLine("Please select a unit to convert to: ");
            convertedUnit = Console.ReadLine();

            Console.WriteLine("Please enter a value: ");
            startingValue = double.Parse(Console.ReadLine());

        }

    }
}
