using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GaitovaAA.Sprint6.Task5.V22.Lib
{
    public class DataService : ISprint6Task5V22
    {
        public int len = 0;

        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path)
                                 .Where(line => !string.IsNullOrWhiteSpace(line))
                                 .ToArray();

            double[] allNums = new double[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string cleanLine = lines[i].Trim().Replace('.', ',');
                allNums[i] = Math.Round(Convert.ToDouble(cleanLine), 3);
            }

            double[] numsArray = allNums.Where(val => val > 5).ToArray();
            len = numsArray.Length;

            return numsArray;
        }

    }
}
