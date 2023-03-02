using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class UserInput
    {
        public int InputConversionType(int numOfOptions)
        {
            string optionInput = "";
            int option = 0;
            
            while(true)
            {
                Console.Write("\nPlease enter a conversion option number: ");
                optionInput = Console.ReadLine();

                if(!int.TryParse(optionInput, out option))
                {
                    Console.Write("\t!!! Invalid value. Please enter an integer value!!!");
                } 
                else if (option <= 0 || option > numOfOptions)
                {
                    Console.Write($"\t!!!Choose an Integer value from 1 to {numOfOptions}!!!");
                }
                else
                {
                    break;
                }
            }

            return option;
        }

        public string InputUnits(Dictionary<string,string> units, string fromToStr)
        {
            string inputUnit = "";

            while (true)
            {
                Console.Write($"Please select a unit to convert {fromToStr}: ");
                inputUnit = Console.ReadLine();
                if (!units.ContainsKey(inputUnit))
                {
                    Console.WriteLine("\t!!! Not a valid unit type !!!");
                }
                else
                {
                    break;
                }
            }
            return inputUnit;
        }

        public double InputValue()
        {
            string valueInputStr = "";
            double value = 0.0;

            while (true)
            {
                Console.Write("Please enter a value: ");
                valueInputStr = Console.ReadLine();
                if (!double.TryParse(valueInputStr, out value))
                {
                    Console.WriteLine("!!! Invalid input. Please input a valid numeric value !!!");
                }
                else
                {
                    break;
                }
            }

            return value;


        }
    }
}
