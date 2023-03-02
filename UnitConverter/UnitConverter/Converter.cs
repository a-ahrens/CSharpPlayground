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
        UserInput input = new UserInput();
        UserOutput output = new UserOutput();
        AreaConversion areaConversion = new AreaConversion();
        LengthConversion lengthConversion = new LengthConversion();
        TempConversion tempConversion = new TempConversion();
        VolumeConversion volumeConversion = new VolumeConversion();

        private string startingUnit;
        private double startingValue;
        private string convertedUnit;
        private double convertedValue;

        private string[] conversionOptions = new string[] { "Temperature", "Length", "Volume", "Area" };


        public void RunConverter()
        {
            string useConverter = "N";

            //Confirm the user wants to use the app
            Console.Write("Welcome to My Conversion App! \n\n Would you like to convert some measurements? \n" +
                          "Enter Y or y for yes. Enter any other key for No. ");
            
            useConverter = Console.ReadLine();

            while (useConverter == "Y" || useConverter == "y")
            {
                //display conversion options
                output.DisplayConversionMenu(conversionOptions);
                
                //obtain user input for conversion option
                int option = input.InputConversionType(conversionOptions.Length);
                string conversionType = conversionOptions[option - 1];

                Console.WriteLine($"\nOption #{option} it is! Let's convert some {conversionType}s! \n");
                Console.WriteLine($"{conversionType} Coversion Options:");


                if (conversionType == "Temperature")
                {
                    output.DisplayUnitTypes(tempConversion.GetUnits());
                    startingUnit = input.InputUnits(tempConversion.GetUnits(), "from");
                    convertedUnit = input.InputUnits(tempConversion.GetUnits(), "to");
                    startingValue = input.InputValue();
                    convertedValue = tempConversion.convertValue(startingValue, startingUnit, convertedUnit);
                }
                else if (conversionType == "Length")
                {
                    output.DisplayUnitTypes(lengthConversion.GetUnits());
                    startingUnit = input.InputUnits(lengthConversion.GetUnits(), "from");
                    convertedUnit = input.InputUnits(lengthConversion.GetUnits(), "to");
                    startingValue = input.InputValue();
                    convertedValue = lengthConversion.convertValue(startingValue, startingUnit, convertedUnit);
                }
                else if (conversionType == "Volume")
                {
                    output.DisplayUnitTypes(volumeConversion.GetUnits());
                    startingUnit = input.InputUnits(volumeConversion.GetUnits(), "from");
                    convertedUnit = input.InputUnits(volumeConversion.GetUnits(), "to");
                    startingValue = input.InputValue();
                    convertedValue = volumeConversion.convertValue(startingValue, startingUnit, convertedUnit);
                }
                else if (conversionType == "Area")
                {
                    output.DisplayUnitTypes(areaConversion.GetUnits());
                    startingUnit = input.InputUnits(areaConversion.GetUnits(), "from");
                    convertedUnit = input.InputUnits(areaConversion.GetUnits(), "to");
                    startingValue = input.InputValue();
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

    }
}
