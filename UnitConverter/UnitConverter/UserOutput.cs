using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class UserOutput
    {
        public void DisplayConversionMenu(string[] options)
        {
            Console.WriteLine("\nSplendid! Here are your unit conversion options: ");

            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"\t{i + 1}) {options[i]}");
            }
        }


        public void DisplayUnitTypes(Dictionary<string, string> units)
        {
            foreach (KeyValuePair<string, string> unitPair in units)
            {
                Console.WriteLine($"\t{unitPair.Key} for {unitPair.Value}");
            }

            Console.WriteLine();
        }
    }
}
