using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] conversionOptions = new string[] { "Temperature", "Length", "Volume", "Area" };

            Console.WriteLine("Please choose a conversion option: ");
            string option = Console.ReadLine();

            Console.WriteLine($"Let's use option #{option} {conversionOptions[int.Parse(option)]}");



        }
    }
}
