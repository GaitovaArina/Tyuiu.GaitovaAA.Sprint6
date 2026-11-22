using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GaitovaAA.Sprint6.Task4.V1.Lib
{
    public class DataService : ISprint6Task4V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.2 == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double y = (Math.Sin(x) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2;
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}
