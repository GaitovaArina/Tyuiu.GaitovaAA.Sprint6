using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GaitovaAA.Sprint6.Task7.V13.Lib
{
    public class DataService : ISprint6Task7V13
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path)
                                 .Where(line => !string.IsNullOrWhiteSpace(line))
                                 .ToArray();

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;




            int[,] matrix = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] values = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    int val = Convert.ToInt32(values[c].Trim());

                    if (c == 5 && val > 0 && val % 2 == 0)
                    {
                        matrix[r, c] = 111;
                    }
                    else
                    {
                        matrix[r, c] = val;
                    }
                }
            }

            return matrix;
        }
    }
}
