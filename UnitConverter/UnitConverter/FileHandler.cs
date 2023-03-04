using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class FileHandler
    {

        public List<string[]> ReadData()
        {
            List<string[]> values = new List<string[]>();

            //CSharpPlayground\UnitConverter\UnitConverter\bin\Debug\BulkConversions.csv
            string dataFilePath = "C:\\Users\\secon\\Workspace\\CSharp_Projects\\CSharpPlayground\\UnitConverter\\Data\\BulkConversions.csv";

            try
            {
                using (StreamReader reader = new StreamReader(dataFilePath))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        values.Add(reader.ReadLine().Split(new char[] { ',' }));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File Does Not Exist.");
                Console.WriteLine(ex.Message);
            }

            return values;
        }

        public void LogConversions(List<string[]> values, double[] convertedValues)
        {
            //generate conversion file name
            //open new file
            //loop through both values and convertedValues
            //Write each line to the new file

            string filePath = "C:\\Users\\secon\\Workspace\\CSharp_Projects\\CSharpPlayground\\UnitConverter\\Data\\BulkConversionsConverted.csv";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("ConversionType,StartingValue,StartingUnits,ConvertedValue,ConvertedUnits");
                    for(int i = 0; i < values.Count; i++)
                    {
                        writer.WriteLine($"{values[i][0]},{values[i][1]},{values[i][2]},{convertedValues[i]},{values[i][3]}");
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Cannot open the file for writing");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
