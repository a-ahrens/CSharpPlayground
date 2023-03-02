﻿using System;
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

        Conversion area = new AreaConversion();
        Conversion temp = new TempConversion();
        Conversion volume = new VolumeConversion();
        Conversion length = new LengthConversion();


        private string startingUnit;
        private double startingValue;
        private string convertedUnit;
        private double convertedValue;

        private string[] conversionOptions = new string[] { "Temperature", "Length", "Volume", "Area" };
        private Dictionary<string, Conversion> selectConversion = new Dictionary<string, Conversion>();

        public Converter()
        {
            selectConversion.Add("Area", area);
            selectConversion.Add("Length", length);
            selectConversion.Add("Temperature", temp);
            selectConversion.Add("Volume", volume);
        }

        public void RunConverter()
        {
            string useConverter = "N";

            //Confirm the user wants to use the app
            Console.Write("Welcome to My Conversion App! \n\n Would you like to convert some measurements? \n" +
                          "Enter Y/y for yes. Enter any other key for No: ");
            
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

                CalculateConversion(selectConversion[conversionType]);

                Console.WriteLine();
                Console.Write("Your conversion: ");
                Console.Write($"{startingValue} {startingUnit} ==> {convertedValue} {convertedUnit}\n\n");

                Console.Write("Would you like to convert another value? Y/N: ");
                useConverter = Console.ReadLine();
            }

            Console.WriteLine("\n\n\tThanks for using the Unit Converter 5000! Goodbye\n");
        }

        public void CalculateConversion(Conversion conversion)
        {
            output.DisplayUnitTypes(conversion.GetUnits());
            startingUnit = input.InputUnits(conversion, "from");
            convertedUnit = input.InputUnits(conversion, "to");
            startingValue = input.InputValue();
            convertedValue = Math.Round((Double)conversion.ConvertValue(startingValue, startingUnit, convertedUnit), 6);
        }

    }
}
