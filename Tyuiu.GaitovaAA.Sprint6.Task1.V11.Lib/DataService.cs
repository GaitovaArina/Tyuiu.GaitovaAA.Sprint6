using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GaitovaAA.Sprint6.Task1.V11.Lib
{
    public class DataService : ISprint6Task1V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 3;

                if (denominator == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double y = (5 * x + 2.5) / denominator + 2 * x + Math.Cos(x);
                    valueArray[count] = Math.Round(y, 2);
                }

                count++;
            }

            return valueArray;
        }
    }
}
