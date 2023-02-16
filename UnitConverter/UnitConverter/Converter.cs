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
        AreaConversion areaConversion = new AreaConversion();
        LengthConversion lengthConversion = new LengthConversion();
        TempConversion tempConversion = new TempConversion();
        VolumeConversion volumeConversion = new VolumeConversion();

        private string startingUnit;
        private double startingValue;
        private string convertedUnit;
        private double convertedValue;
        private string useConverter;

        private string[] conversionOptions = new string[] { "Temperature", "Length", "Volume", "Area" };


        public void RunConverter()
        {
            //Confirm the user wants to use the app
            Console.Write("Welcome to My Conversion App! \n\n Would you like to convert some measurements? Y/N: ");
            useConverter = Console.ReadLine();

            while (useConverter == "Y" || useConverter == "y")
            {
                Console.WriteLine("\nSplendid! Here are your unit conversion options: ");
                //Print the available conversion types and have user pick one
                for (int i = 0; i < conversionOptions.Length; i++)
                {
                    Console.WriteLine($"\t{i + 1}) {conversionOptions[i]}");
                }

                Console.Write("\nPlease enter a conversion option number: ");
                int option = int.Parse(Console.ReadLine());
                string conversionType = conversionOptions[option - 1];

                Console.WriteLine($"\nOption #{option} it is! Let's convert some {conversionType}s! \n");

                if (conversionType == "Temperature")
                {
                    Console.WriteLine("Temperature Conversion Options:");
                    UserInput(tempConversion.GetUnits());
                    convertedValue = tempConversion.convertValue(startingValue, startingUnit, convertedUnit);
                }
                else if (conversionType == "Length")
                {
                    Console.WriteLine("Length Conversion Options:");
                    UserInput(lengthConversion.GetUnits());
                    convertedValue = lengthConversion.convertValue(startingValue, startingUnit, convertedUnit);
                }
                else if (conversionType == "Volume")
                {
                    Console.WriteLine("Volume Conversion Options");
                    UserInput(volumeConversion.GetUnits());
                    convertedValue = volumeConversion.convertValue(startingValue, startingUnit, convertedUnit);
                }
                else if (conversionType == "Area")
                {
                    Console.WriteLine("Area Conversion Options:");
                    UserInput(areaConversion.GetUnits());
                    convertedValue = areaConversion.convertValue(startingValue, startingUnit, convertedUnit);
                }

                Console.WriteLine();
                Console.Write("Your conversion: ");
                Console.Write($"{startingValue}{startingUnit} ==> {convertedValue}{convertedUnit}\n\n");

                Console.Write("Would you like to convert another value? Y/N: ");
                useConverter = Console.ReadLine();
            }

            Console.WriteLine("\n\n\tThanks for using the Unit Converter 5000! Goodbye\n");
        }

        private void UserInput(Dictionary<string,string> units)
        {
            foreach (KeyValuePair<string, string> unitPair in units)
            {
                Console.WriteLine($"\t{unitPair.Key} for {unitPair.Value}");
            }

            Console.WriteLine();
            Console.Write("Please select a unit to convert from: ");
            startingUnit = Console.ReadLine();

            Console.Write("Please select a unit to convert to: ");
            convertedUnit = Console.ReadLine();

            Console.Write("Please enter a value: ");
            startingValue = double.Parse(Console.ReadLine());

        }

    }
}
