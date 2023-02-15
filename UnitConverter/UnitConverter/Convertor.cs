using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Conversions;

namespace UnitConverter
{
    internal class Convertor
    {

        TempConversion tempConversion = new TempConversion();
        LengthConversion lengthConversion = new LengthConversion();

        private string startingUnit;
        private double startingValue;
        private string convertedUnit;
        private double convertedValue;

        private string[] conversionOptions = new string[] { "Temperature", "Length", "Volume", "Area" };


        public void RunConvertor()
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
                foreach (KeyValuePair<string, string> tempPair in tempConversion.units)
                {
                    Console.WriteLine($"{tempPair.Key} for {tempPair.Value}");
                }
                UserInput();
                convertedValue = tempConversion.convertValue(startingValue, startingUnit, convertedUnit);
            }
            else if(conversionType == "Length")
            {
                Console.WriteLine("Length Conversion Options:");
                foreach (KeyValuePair<string, string> lengthPair in lengthConversion.units)
                {
                    Console.WriteLine($"{lengthPair.Key} for {lengthPair.Value}");
                }
                UserInput();
                //convertedValue = lengthConversion.convertValue(startingValue, startingUnit, convertedUnit);
            }


/*          
            Console.WriteLine($"{startingValue}{startingUnit} ==> {convertedValue}{convertedUnit}");*/

        }

        private void UserInput()
        {
            Console.WriteLine("Please select a unit to convert from: ");
            startingUnit = Console.ReadLine();

            Console.WriteLine("Please select a unit to convert to: ");
            convertedUnit = Console.ReadLine();

            Console.WriteLine("Please enter a value: ");
            startingValue = double.Parse(Console.ReadLine());

        }

    }
}
